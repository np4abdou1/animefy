using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x02000302 RID: 770
	[Serializable]
	internal class EnvoyInfo : IEnvoyInfo
	{
		// Token: 0x0600195A RID: 6490 RVA: 0x0006EA15 File Offset: 0x0006CC15
		public EnvoyInfo(IMessageSink sinks)
		{
			this.envoySinks = sinks;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x0006EA24 File Offset: 0x0006CC24
		public IMessageSink EnvoySinks
		{
			get
			{
				return this.envoySinks;
			}
		}

		// Token: 0x04000A93 RID: 2707
		private IMessageSink envoySinks;
	}
}
