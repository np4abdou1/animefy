using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Services;

namespace System.Runtime.Remoting
{
	// Token: 0x02000312 RID: 786
	internal abstract class ServerIdentity : Identity
	{
		// Token: 0x060019EB RID: 6635 RVA: 0x00071761 File Offset: 0x0006F961
		public ServerIdentity(string objectUri, Context context, Type objectType) : base(objectUri)
		{
			this._objectType = objectType;
			this._context = context;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00071778 File Offset: 0x0006F978
		public Type ObjectType
		{
			get
			{
				return this._objectType;
			}
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00071780 File Offset: 0x0006F980
		public void StartTrackingLifetime(ILease lease)
		{
			if (lease != null && lease.CurrentState == LeaseState.Null)
			{
				lease = null;
			}
			if (lease != null)
			{
				if (!(lease is Lease))
				{
					lease = new Lease();
				}
				this._lease = (Lease)lease;
				LifetimeServices.TrackLifetime(this);
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000717B4 File Offset: 0x0006F9B4
		public virtual void OnLifetimeExpired()
		{
			this.DisposeServerObject();
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000717BC File Offset: 0x0006F9BC
		public override ObjRef CreateObjRef(Type requestedType)
		{
			if (this._objRef != null)
			{
				this._objRef.UpdateChannelInfo();
				return this._objRef;
			}
			if (requestedType == null)
			{
				requestedType = this._objectType;
			}
			this._objRef = new ObjRef();
			this._objRef.TypeInfo = new TypeInfo(requestedType);
			this._objRef.URI = this._objectUri;
			if (this._envoySink != null && !(this._envoySink is EnvoyTerminatorSink))
			{
				this._objRef.EnvoyInfo = new EnvoyInfo(this._envoySink);
			}
			return this._objRef;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00071854 File Offset: 0x0006FA54
		public void AttachServerObject(MarshalByRefObject serverObject, Context context)
		{
			this.DisposeServerObject();
			this._context = context;
			this._serverObject = serverObject;
			if (RemotingServices.IsTransparentProxy(serverObject))
			{
				RealProxy realProxy = RemotingServices.GetRealProxy(serverObject);
				if (realProxy.ObjectIdentity == null)
				{
					realProxy.ObjectIdentity = this;
					return;
				}
			}
			else
			{
				if (this._objectType.IsContextful)
				{
					this._envoySink = context.CreateEnvoySink(serverObject);
				}
				this._serverObject.ObjectIdentity = this;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x000718BA File Offset: 0x0006FABA
		public Lease Lease
		{
			get
			{
				return this._lease;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000718C2 File Offset: 0x0006FAC2
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x000718CA File Offset: 0x0006FACA
		public Context Context
		{
			get
			{
				return this._context;
			}
			set
			{
				this._context = value;
			}
		}

		// Token: 0x060019F4 RID: 6644
		public abstract IMessage SyncObjectProcessMessage(IMessage msg);

		// Token: 0x060019F5 RID: 6645
		public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

		// Token: 0x060019F6 RID: 6646 RVA: 0x000718D3 File Offset: 0x0006FAD3
		protected void DisposeServerObject()
		{
			if (this._serverObject != null)
			{
				object serverObject = this._serverObject;
				this._serverObject.ObjectIdentity = null;
				this._serverObject = null;
				this._serverSink = null;
				TrackingServices.NotifyDisconnectedObject(serverObject);
			}
		}

		// Token: 0x04000AD0 RID: 2768
		protected Type _objectType;

		// Token: 0x04000AD1 RID: 2769
		protected MarshalByRefObject _serverObject;

		// Token: 0x04000AD2 RID: 2770
		protected IMessageSink _serverSink;

		// Token: 0x04000AD3 RID: 2771
		protected Context _context;

		// Token: 0x04000AD4 RID: 2772
		protected Lease _lease;
	}
}
