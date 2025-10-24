using System;

namespace System.Xml
{
	// Token: 0x02000035 RID: 53
	internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000A216 File Offset: 0x00008416
		internal override bool IsFull
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A219 File Offset: 0x00008419
		internal override int Decode(char[] chars, int startPos, int len)
		{
			return len;
		}
	}
}
