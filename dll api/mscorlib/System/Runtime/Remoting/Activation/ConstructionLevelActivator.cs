using System;
using System.Threading;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x0200034F RID: 847
	[Serializable]
	internal class ConstructionLevelActivator : IActivator
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0002AC82 File Offset: 0x00028E82
		public IActivator NextActivator
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00075318 File Offset: 0x00073518
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			return (IConstructionReturnMessage)Thread.CurrentContext.GetServerContextSinkChain().SyncProcessMessage(msg);
		}
	}
}
