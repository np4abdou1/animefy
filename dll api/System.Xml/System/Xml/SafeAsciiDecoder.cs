using System;
using System.Text;

namespace System.Xml
{
	// Token: 0x020001A8 RID: 424
	internal class SafeAsciiDecoder : Decoder
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x0000A219 File Offset: 0x00008419
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return count;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000608D4 File Offset: 0x0005EAD4
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			int i = byteIndex;
			int num = charIndex;
			while (i < byteIndex + byteCount)
			{
				chars[num++] = (char)bytes[i++];
			}
			return byteCount;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00060900 File Offset: 0x0005EB00
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			if (charCount < byteCount)
			{
				byteCount = charCount;
				completed = false;
			}
			else
			{
				completed = true;
			}
			int i = byteIndex;
			int num = charIndex;
			int num2 = byteIndex + byteCount;
			while (i < num2)
			{
				chars[num++] = (char)bytes[i++];
			}
			charsUsed = byteCount;
			bytesUsed = byteCount;
		}
	}
}
