using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x0200014A RID: 330
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	internal readonly struct Marker
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x00027068 File Offset: 0x00025268
		public Marker(int count, int index)
		{
			this.Count = count;
			this.Index = index;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00027078 File Offset: 0x00025278
		public int Count { get; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00027080 File Offset: 0x00025280
		public int Index { get; }
	}
}
