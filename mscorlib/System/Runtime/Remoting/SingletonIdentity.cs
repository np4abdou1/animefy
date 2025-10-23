using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x02000314 RID: 788
	internal class SingletonIdentity : ServerIdentity
	{
		// Token: 0x060019FD RID: 6653 RVA: 0x000719CB File Offset: 0x0006FBCB
		public SingletonIdentity(string objectUri, Context context, Type objectType) : base(objectUri, context, objectType)
		{
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000719D8 File Offset: 0x0006FBD8
		public MarshalByRefObject GetServerObject()
		{
			if (this._serverObject != null)
			{
				return this._serverObject;
			}
			lock (this)
			{
				if (this._serverObject == null)
				{
					MarshalByRefObject marshalByRefObject = (MarshalByRefObject)Activator.CreateInstance(this._objectType, true);
					base.AttachServerObject(marshalByRefObject, Context.DefaultContext);
					base.StartTrackingLifetime((ILease)marshalByRefObject.InitializeLifetimeService());
				}
			}
			return this._serverObject;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00071A5C File Offset: 0x0006FC5C
		public override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			MarshalByRefObject serverObject = this.GetServerObject();
			if (this._serverSink == null)
			{
				this._serverSink = this._context.CreateServerObjectSinkChain(serverObject, false);
			}
			return this._serverSink.SyncProcessMessage(msg);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00071A98 File Offset: 0x0006FC98
		public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
		{
			MarshalByRefObject serverObject = this.GetServerObject();
			if (this._serverSink == null)
			{
				this._serverSink = this._context.CreateServerObjectSinkChain(serverObject, false);
			}
			return this._serverSink.AsyncProcessMessage(msg, replySink);
		}
	}
}
