using System;
using System.Collections;
using System.Threading;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000328 RID: 808
	internal class LeaseManager
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x00073210 File Offset: 0x00071410
		public void SetPollTime(TimeSpan timeSpan)
		{
			object syncRoot = this._objects.SyncRoot;
			lock (syncRoot)
			{
				if (this._timer != null)
				{
					this._timer.Change(timeSpan, timeSpan);
				}
			}
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00073268 File Offset: 0x00071468
		public void TrackLifetime(ServerIdentity identity)
		{
			object syncRoot = this._objects.SyncRoot;
			lock (syncRoot)
			{
				identity.Lease.Activate();
				this._objects.Add(identity);
				if (this._timer == null)
				{
					this.StartManager();
				}
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x000732D0 File Offset: 0x000714D0
		public void StartManager()
		{
			this._timer = new Timer(new TimerCallback(this.ManageLeases), null, LifetimeServices.LeaseManagerPollTime, LifetimeServices.LeaseManagerPollTime);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x000732F4 File Offset: 0x000714F4
		public void StopManager()
		{
			Timer timer = this._timer;
			this._timer = null;
			if (timer != null)
			{
				timer.Dispose();
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00073318 File Offset: 0x00071518
		public void ManageLeases(object state)
		{
			object syncRoot = this._objects.SyncRoot;
			lock (syncRoot)
			{
				int i = 0;
				while (i < this._objects.Count)
				{
					ServerIdentity serverIdentity = (ServerIdentity)this._objects[i];
					serverIdentity.Lease.UpdateState();
					if (serverIdentity.Lease.CurrentState == LeaseState.Expired)
					{
						this._objects.RemoveAt(i);
						serverIdentity.OnLifetimeExpired();
					}
					else
					{
						i++;
					}
				}
				if (this._objects.Count == 0)
				{
					this.StopManager();
				}
			}
		}

		// Token: 0x04000B06 RID: 2822
		private ArrayList _objects = new ArrayList();

		// Token: 0x04000B07 RID: 2823
		private Timer _timer;
	}
}
