using System;

namespace System.Net
{
	// Token: 0x0200016E RID: 366
	internal class HeaderInfo
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00035329 File Offset: 0x00033529
		internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
		{
			this.HeaderName = name;
			this.IsRequestRestricted = requestRestricted;
			this.IsResponseRestricted = responseRestricted;
			this.Parser = p;
			this.AllowMultiValues = multi;
		}

		// Token: 0x04000750 RID: 1872
		internal readonly bool IsRequestRestricted;

		// Token: 0x04000751 RID: 1873
		internal readonly bool IsResponseRestricted;

		// Token: 0x04000752 RID: 1874
		internal readonly HeaderParser Parser;

		// Token: 0x04000753 RID: 1875
		internal readonly string HeaderName;

		// Token: 0x04000754 RID: 1876
		internal readonly bool AllowMultiValues;
	}
}
