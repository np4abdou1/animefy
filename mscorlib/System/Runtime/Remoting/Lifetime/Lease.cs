using System;
using System.Collections;
using System.Threading;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000326 RID: 806
	internal class Lease : MarshalByRefObject, ILease
	{
		// Token: 0x06001A59 RID: 6745 RVA: 0x00072F74 File Offset: 0x00071174
		public Lease()
		{
			this._currentState = LeaseState.Initial;
			this._initialLeaseTime = LifetimeServices.LeaseTime;
			this._renewOnCallTime = LifetimeServices.RenewOnCallTime;
			this._sponsorshipTimeout = LifetimeServices.SponsorshipTimeout;
			this._leaseExpireTime = DateTime.UtcNow + this._initialLeaseTime;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00072FC5 File Offset: 0x000711C5
		public TimeSpan CurrentLeaseTime
		{
			get
			{
				return this._leaseExpireTime - DateTime.UtcNow;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00072FD7 File Offset: 0x000711D7
		public LeaseState CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00072FDF File Offset: 0x000711DF
		public void Activate()
		{
			this._currentState = LeaseState.Active;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00072FE8 File Offset: 0x000711E8
		public TimeSpan RenewOnCallTime
		{
			get
			{
				return this._renewOnCallTime;
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00072FF0 File Offset: 0x000711F0
		public TimeSpan Renew(TimeSpan renewalTime)
		{
			DateTime dateTime = DateTime.UtcNow + renewalTime;
			if (dateTime > this._leaseExpireTime)
			{
				this._leaseExpireTime = dateTime;
			}
			return this.CurrentLeaseTime;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00073024 File Offset: 0x00071224
		public void Unregister(ISponsor obj)
		{
			lock (this)
			{
				if (this._sponsors != null)
				{
					for (int i = 0; i < this._sponsors.Count; i++)
					{
						if (this._sponsors[i] == obj)
						{
							this._sponsors.RemoveAt(i);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00073098 File Offset: 0x00071298
		internal void UpdateState()
		{
			if (this._currentState != LeaseState.Active)
			{
				return;
			}
			if (this.CurrentLeaseTime > TimeSpan.Zero)
			{
				return;
			}
			if (this._sponsors != null)
			{
				this._currentState = LeaseState.Renewing;
				lock (this)
				{
					this._renewingSponsors = new Queue(this._sponsors);
				}
				this.CheckNextSponsor();
				return;
			}
			this._currentState = LeaseState.Expired;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00073118 File Offset: 0x00071318
		private void CheckNextSponsor()
		{
			if (this._renewingSponsors.Count == 0)
			{
				this._currentState = LeaseState.Expired;
				this._renewingSponsors = null;
				return;
			}
			ISponsor @object = (ISponsor)this._renewingSponsors.Peek();
			this._renewalDelegate = new Lease.RenewalDelegate(@object.Renewal);
			IAsyncResult asyncResult = this._renewalDelegate.BeginInvoke(this, null, null);
			ThreadPool.RegisterWaitForSingleObject(asyncResult.AsyncWaitHandle, new WaitOrTimerCallback(this.ProcessSponsorResponse), asyncResult, this._sponsorshipTimeout, true);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00073194 File Offset: 0x00071394
		private void ProcessSponsorResponse(object state, bool timedOut)
		{
			if (!timedOut)
			{
				try
				{
					IAsyncResult result = (IAsyncResult)state;
					TimeSpan timeSpan = this._renewalDelegate.EndInvoke(result);
					if (timeSpan != TimeSpan.Zero)
					{
						this.Renew(timeSpan);
						this._currentState = LeaseState.Active;
						this._renewingSponsors = null;
						return;
					}
				}
				catch
				{
				}
			}
			this.Unregister((ISponsor)this._renewingSponsors.Dequeue());
			this.CheckNextSponsor();
		}

		// Token: 0x04000AFE RID: 2814
		private DateTime _leaseExpireTime;

		// Token: 0x04000AFF RID: 2815
		private LeaseState _currentState;

		// Token: 0x04000B00 RID: 2816
		private TimeSpan _initialLeaseTime;

		// Token: 0x04000B01 RID: 2817
		private TimeSpan _renewOnCallTime;

		// Token: 0x04000B02 RID: 2818
		private TimeSpan _sponsorshipTimeout;

		// Token: 0x04000B03 RID: 2819
		private ArrayList _sponsors;

		// Token: 0x04000B04 RID: 2820
		private Queue _renewingSponsors;

		// Token: 0x04000B05 RID: 2821
		private Lease.RenewalDelegate _renewalDelegate;

		// Token: 0x02000327 RID: 807
		// (Invoke) Token: 0x06001A64 RID: 6756
		private delegate TimeSpan RenewalDelegate(ILease lease);
	}
}
