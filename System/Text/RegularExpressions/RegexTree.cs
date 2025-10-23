using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B9 RID: 185
	internal sealed class RegexTree
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x0002337A File Offset: 0x0002157A
		internal RegexTree(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options)
		{
			this.Root = root;
			this.Caps = caps;
			this.CapNumList = capNumList;
			this.CapTop = capTop;
			this.CapNames = capNames;
			this.CapsList = capsList;
			this.Options = options;
		}

		// Token: 0x0400038F RID: 911
		public readonly RegexNode Root;

		// Token: 0x04000390 RID: 912
		public readonly Hashtable Caps;

		// Token: 0x04000391 RID: 913
		public readonly int[] CapNumList;

		// Token: 0x04000392 RID: 914
		public readonly int CapTop;

		// Token: 0x04000393 RID: 915
		public readonly Hashtable CapNames;

		// Token: 0x04000394 RID: 916
		public readonly string[] CapsList;

		// Token: 0x04000395 RID: 917
		public readonly RegexOptions Options;
	}
}
