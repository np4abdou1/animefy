using System;
using System.Security;

namespace System.Globalization
{
	// Token: 0x020005A9 RID: 1449
	[Serializable]
	internal class CodePageDataItem
	{
		// Token: 0x06002BC8 RID: 11208 RVA: 0x000B09D2 File Offset: 0x000AEBD2
		[SecurityCritical]
		internal CodePageDataItem(int dataIndex)
		{
			this.m_dataIndex = dataIndex;
			this.m_uiFamilyCodePage = (int)EncodingTable.codePageDataPtr[dataIndex].uiFamilyCodePage;
			this.m_flags = EncodingTable.codePageDataPtr[dataIndex].flags;
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000B0A0D File Offset: 0x000AEC0D
		[SecurityCritical]
		internal static string CreateString(string pStrings, uint index)
		{
			if (pStrings[0] == '|')
			{
				return pStrings.Split(CodePageDataItem.sep, StringSplitOptions.RemoveEmptyEntries)[(int)index];
			}
			return pStrings;
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x000B0A2A File Offset: 0x000AEC2A
		public string WebName
		{
			[SecuritySafeCritical]
			get
			{
				if (this.m_webName == null)
				{
					this.m_webName = CodePageDataItem.CreateString(EncodingTable.codePageDataPtr[this.m_dataIndex].Names, 0U);
				}
				return this.m_webName;
			}
		}

		// Token: 0x040017B2 RID: 6066
		internal int m_dataIndex;

		// Token: 0x040017B3 RID: 6067
		internal int m_uiFamilyCodePage;

		// Token: 0x040017B4 RID: 6068
		internal string m_webName;

		// Token: 0x040017B5 RID: 6069
		internal uint m_flags;

		// Token: 0x040017B6 RID: 6070
		private static readonly char[] sep = new char[]
		{
			'|'
		};
	}
}
