using System;
using System.Security.Principal;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200035F RID: 863
	[Serializable]
	internal class CallContextSecurityData : ICloneable
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00075B0B File Offset: 0x00073D0B
		internal bool HasInfo
		{
			get
			{
				return this._principal != null;
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00075B16 File Offset: 0x00073D16
		public object Clone()
		{
			return new CallContextSecurityData
			{
				_principal = this._principal
			};
		}

		// Token: 0x04000B68 RID: 2920
		private IPrincipal _principal;
	}
}
