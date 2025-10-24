using System;

namespace System.Xml
{
	// Token: 0x02000034 RID: 52
	internal abstract class IncrementalReadDecoder
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600019F RID: 415
		internal abstract bool IsFull { get; }

		// Token: 0x060001A0 RID: 416
		internal abstract int Decode(char[] chars, int startPos, int len);
	}
}
