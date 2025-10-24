using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x0200034E RID: 846
	internal class AppDomainLevelActivator : IActivator
	{
		// Token: 0x06001AFF RID: 6911 RVA: 0x00075265 File Offset: 0x00073465
		public AppDomainLevelActivator(string activationUrl, IActivator next)
		{
			this._activationUrl = activationUrl;
			this._next = next;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0007527B File Offset: 0x0007347B
		public IActivator NextActivator
		{
			get
			{
				return this._next;
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00075284 File Offset: 0x00073484
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			IActivator activator = (IActivator)RemotingServices.Connect(typeof(IActivator), this._activationUrl);
			ctorCall.Activator = ctorCall.Activator.NextActivator;
			IConstructionReturnMessage constructionReturnMessage;
			try
			{
				constructionReturnMessage = activator.Activate(ctorCall);
			}
			catch (Exception e)
			{
				return new ConstructionResponse(e, ctorCall);
			}
			ObjRef objRef = (ObjRef)constructionReturnMessage.ReturnValue;
			if (RemotingServices.GetIdentityForUri(objRef.URI) != null)
			{
				throw new RemotingException("Inconsistent state during activation; there may be two proxies for the same object");
			}
			object obj;
			Identity orCreateClientIdentity = RemotingServices.GetOrCreateClientIdentity(objRef, null, out obj);
			RemotingServices.SetMessageTargetIdentity(ctorCall, orCreateClientIdentity);
			return constructionReturnMessage;
		}

		// Token: 0x04000B49 RID: 2889
		private string _activationUrl;

		// Token: 0x04000B4A RID: 2890
		private IActivator _next;
	}
}
