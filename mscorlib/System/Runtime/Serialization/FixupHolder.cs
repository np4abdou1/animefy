using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003A7 RID: 935
	[Serializable]
	internal class FixupHolder
	{
		// Token: 0x06001D17 RID: 7447 RVA: 0x0007B7C2 File Offset: 0x000799C2
		internal FixupHolder(long id, object fixupInfo, int fixupType)
		{
			this.m_id = id;
			this.m_fixupInfo = fixupInfo;
			this.m_fixupType = fixupType;
		}

		// Token: 0x04000C29 RID: 3113
		internal long m_id;

		// Token: 0x04000C2A RID: 3114
		internal object m_fixupInfo;

		// Token: 0x04000C2B RID: 3115
		internal int m_fixupType;
	}
}
