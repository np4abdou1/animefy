using System;

namespace System
{
	// Token: 0x020000AA RID: 170
	internal ref struct DTSubString
	{
		// Token: 0x17000071 RID: 113
		internal unsafe char this[int relativeIndex]
		{
			get
			{
				return (char)(*this.s[this.index + relativeIndex]);
			}
		}

		// Token: 0x0400027E RID: 638
		internal ReadOnlySpan<char> s;

		// Token: 0x0400027F RID: 639
		internal int index;

		// Token: 0x04000280 RID: 640
		internal int length;

		// Token: 0x04000281 RID: 641
		internal DTSubStringType type;

		// Token: 0x04000282 RID: 642
		internal int value;
	}
}
