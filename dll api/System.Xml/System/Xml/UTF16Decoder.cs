using System;
using System.Text;

namespace System.Xml
{
	// Token: 0x020001A7 RID: 423
	internal class UTF16Decoder : Decoder
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x00060624 File Offset: 0x0005E824
		public UTF16Decoder(bool bigEndian)
		{
			this.lastByte = -1;
			this.bigEndian = bigEndian;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0006063A File Offset: 0x0005E83A
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return this.GetCharCount(bytes, index, count, false);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00060648 File Offset: 0x0005E848
		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			int num = count + ((this.lastByte >= 0) ? 1 : 0);
			if (flush && num % 2 != 0)
			{
				throw new ArgumentException(Res.GetString("Invalid byte was found at index {0}.", new object[]
				{
					-1
				}), null);
			}
			return num / 2;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00060694 File Offset: 0x0005E894
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			int charCount = this.GetCharCount(bytes, byteIndex, byteCount);
			if (this.lastByte >= 0)
			{
				if (byteCount == 0)
				{
					return charCount;
				}
				int num = (int)bytes[byteIndex++];
				byteCount--;
				chars[charIndex++] = (this.bigEndian ? ((char)(this.lastByte << 8 | num)) : ((char)(num << 8 | this.lastByte)));
				this.lastByte = -1;
			}
			if ((byteCount & 1) != 0)
			{
				this.lastByte = (int)bytes[byteIndex + --byteCount];
			}
			if (this.bigEndian == BitConverter.IsLittleEndian)
			{
				int num2 = byteIndex + byteCount;
				if (this.bigEndian)
				{
					while (byteIndex < num2)
					{
						int num3 = (int)bytes[byteIndex++];
						int num4 = (int)bytes[byteIndex++];
						chars[charIndex++] = (char)(num3 << 8 | num4);
					}
				}
				else
				{
					while (byteIndex < num2)
					{
						int num5 = (int)bytes[byteIndex++];
						int num6 = (int)bytes[byteIndex++];
						chars[charIndex++] = (char)(num6 << 8 | num5);
					}
				}
			}
			else
			{
				Buffer.BlockCopy(bytes, byteIndex, chars, charIndex * 2, byteCount);
			}
			return charCount;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00060790 File Offset: 0x0005E990
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			charsUsed = 0;
			bytesUsed = 0;
			if (this.lastByte >= 0)
			{
				if (byteCount == 0)
				{
					completed = true;
					return;
				}
				int num = (int)bytes[byteIndex++];
				byteCount--;
				bytesUsed++;
				chars[charIndex++] = (this.bigEndian ? ((char)(this.lastByte << 8 | num)) : ((char)(num << 8 | this.lastByte)));
				charCount--;
				charsUsed++;
				this.lastByte = -1;
			}
			if (charCount * 2 < byteCount)
			{
				byteCount = charCount * 2;
				completed = false;
			}
			else
			{
				completed = true;
			}
			if (this.bigEndian == BitConverter.IsLittleEndian)
			{
				int i = byteIndex;
				int num2 = i + (byteCount & -2);
				if (this.bigEndian)
				{
					while (i < num2)
					{
						int num3 = (int)bytes[i++];
						int num4 = (int)bytes[i++];
						chars[charIndex++] = (char)(num3 << 8 | num4);
					}
				}
				else
				{
					while (i < num2)
					{
						int num5 = (int)bytes[i++];
						int num6 = (int)bytes[i++];
						chars[charIndex++] = (char)(num6 << 8 | num5);
					}
				}
			}
			else
			{
				Buffer.BlockCopy(bytes, byteIndex, chars, charIndex * 2, byteCount & -2);
			}
			charsUsed += byteCount / 2;
			bytesUsed += byteCount;
			if ((byteCount & 1) != 0)
			{
				this.lastByte = (int)bytes[byteIndex + byteCount - 1];
			}
		}

		// Token: 0x04000AB8 RID: 2744
		private bool bigEndian;

		// Token: 0x04000AB9 RID: 2745
		private int lastByte;
	}
}
