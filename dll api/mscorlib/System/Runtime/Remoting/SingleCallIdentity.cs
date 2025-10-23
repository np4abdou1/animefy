using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x02000315 RID: 789
	internal class SingleCallIdentity : ServerIdentity
	{
		// Token: 0x06001A01 RID: 6657 RVA: 0x000719CB File Offset: 0x0006FBCB
		public SingleCallIdentity(string objectUri, Context context, Type objectType) : base(objectUri, context, objectType)
		{
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00071AD4 File Offset: 0x0006FCD4
		public override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			MarshalByRefObject marshalByRefObject = (MarshalByRefObject)Activator.CreateInstance(this._objectType, true);
			if (marshalByRefObject.ObjectIdentity == null)
			{
				marshalByRefObject.ObjectIdentity = this;
			}
			IMessage result = this._context.CreateServerObjectSinkChain(marshalByRefObject, false).SyncProcessMessage(msg);
			if (marshalByRefObject is IDisposable)
			{
				((IDisposable)marshalByRefObject).Dispose();
			}
			return result;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00071B28 File Offset: 0x0006FD28
		public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
		{
			MarshalByRefObject marshalByRefObject = (MarshalByRefObject)Activator.CreateInstance(this._objectType, true);
			IMessageSink messageSink = this._context.CreateServerObjectSinkChain(marshalByRefObject, false);
			if (marshalByRefObject is IDisposable)
			{
				replySink = new DisposerReplySink(replySink, (IDisposable)marshalByRefObject);
			}
			return messageSink.AsyncProcessMessage(msg, replySink);
		}
	}
}
