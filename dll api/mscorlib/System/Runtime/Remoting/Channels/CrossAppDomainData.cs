using System;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200033F RID: 831
	[Serializable]
	internal class CrossAppDomainData
	{
		// Token: 0x06001ACF RID: 6863 RVA: 0x00074A08 File Offset: 0x00072C08
		internal CrossAppDomainData(int domainId)
		{
			this._ContextID = 0;
			this._DomainID = domainId;
			this._processGuid = RemotingConfiguration.ProcessId;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00074A2E File Offset: 0x00072C2E
		internal int DomainID
		{
			get
			{
				return this._DomainID;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00074A36 File Offset: 0x00072C36
		internal string ProcessID
		{
			get
			{
				return this._processGuid;
			}
		}

		// Token: 0x04000B3A RID: 2874
		private object _ContextID;

		// Token: 0x04000B3B RID: 2875
		private int _DomainID;

		// Token: 0x04000B3C RID: 2876
		private string _processGuid;
	}
}
