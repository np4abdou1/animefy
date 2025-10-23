using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x02000350 RID: 848
	[Serializable]
	internal class ContextLevelActivator : IActivator
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x0007532F File Offset: 0x0007352F
		public ContextLevelActivator(IActivator next)
		{
			this.m_NextActivator = next;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0007533E File Offset: 0x0007353E
		public IActivator NextActivator
		{
			get
			{
				return this.m_NextActivator;
			}
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00075348 File Offset: 0x00073548
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			ServerIdentity serverIdentity = RemotingServices.CreateContextBoundObjectIdentity(ctorCall.ActivationType);
			RemotingServices.SetMessageTargetIdentity(ctorCall, serverIdentity);
			ConstructionCall constructionCall = ctorCall as ConstructionCall;
			if (constructionCall == null || !constructionCall.IsContextOk)
			{
				serverIdentity.Context = Context.CreateNewContext(ctorCall);
				Context newContext = Context.SwitchToContext(serverIdentity.Context);
				try
				{
					return this.m_NextActivator.Activate(ctorCall);
				}
				finally
				{
					Context.SwitchToContext(newContext);
				}
			}
			return this.m_NextActivator.Activate(ctorCall);
		}

		// Token: 0x04000B4B RID: 2891
		private IActivator m_NextActivator;
	}
}
