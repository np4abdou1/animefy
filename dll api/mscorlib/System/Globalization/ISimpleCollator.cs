using System;

namespace System.Globalization
{
	// Token: 0x020005A6 RID: 1446
	internal interface ISimpleCollator
	{
		// Token: 0x06002B92 RID: 11154
		SortKey GetSortKey(string source, CompareOptions options);

		// Token: 0x06002B93 RID: 11155
		int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

		// Token: 0x06002B94 RID: 11156
		bool IsPrefix(string src, string target, CompareOptions opt);

		// Token: 0x06002B95 RID: 11157
		bool IsSuffix(string src, string target, CompareOptions opt);

		// Token: 0x06002B96 RID: 11158
		int IndexOf(string s, string target, int start, int length, CompareOptions opt);

		// Token: 0x06002B97 RID: 11159
		int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
	}
}
