using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000360 RID: 864
	[Serializable]
	internal class CallContextRemotingData : ICloneable
	{
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00075B29 File Offset: 0x00073D29
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00075B31 File Offset: 0x00073D31
		internal string LogicalCallID
		{
			get
			{
				return this._logicalCallID;
			}
			set
			{
				this._logicalCallID = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00075B3A File Offset: 0x00073D3A
		internal bool HasInfo
		{
			get
			{
				return this._logicalCallID != null;
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00075B45 File Offset: 0x00073D45
		public object Clone()
		{
			return new CallContextRemotingData
			{
				LogicalCallID = this.LogicalCallID
			};
		}

		// Token: 0x04000B69 RID: 2921
		private string _logicalCallID;
	}
}
