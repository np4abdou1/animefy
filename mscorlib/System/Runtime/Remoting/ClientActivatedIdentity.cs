using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x02000313 RID: 787
	internal class ClientActivatedIdentity : ServerIdentity
	{
		// Token: 0x060019F7 RID: 6647 RVA: 0x00071902 File Offset: 0x0006FB02
		public ClientActivatedIdentity(string objectUri, Type objectType) : base(objectUri, null, objectType)
		{
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0007190D File Offset: 0x0006FB0D
		public MarshalByRefObject GetServerObject()
		{
			return this._serverObject;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00071915 File Offset: 0x0006FB15
		public void SetClientProxy(MarshalByRefObject obj)
		{
			this._targetThis = obj;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0007191E File Offset: 0x0006FB1E
		public override void OnLifetimeExpired()
		{
			base.OnLifetimeExpired();
			RemotingServices.DisposeIdentity(this);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0007192C File Offset: 0x0006FB2C
		public override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			if (this._serverSink == null)
			{
				bool flag = this._targetThis != null;
				this._serverSink = this._context.CreateServerObjectSinkChain(flag ? this._targetThis : this._serverObject, flag);
			}
			return this._serverSink.SyncProcessMessage(msg);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0007197C File Offset: 0x0006FB7C
		public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
		{
			if (this._serverSink == null)
			{
				bool flag = this._targetThis != null;
				this._serverSink = this._context.CreateServerObjectSinkChain(flag ? this._targetThis : this._serverObject, flag);
			}
			return this._serverSink.AsyncProcessMessage(msg, replySink);
		}

		// Token: 0x04000AD5 RID: 2773
		private MarshalByRefObject _targetThis;
	}
}
