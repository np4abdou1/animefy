using System;

namespace System.Xml
{
	// Token: 0x0200000E RID: 14
	internal class BinHexDecoder : IncrementalReadDecoder
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002B4F File Offset: 0x00000D4F
		internal override bool IsFull
		{
			get
			{
				return this.curIndex == this.endIndex;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002B60 File Offset: 0x00000D60
		internal unsafe override int Decode(char[] chars, int startPos, int len)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars");
			}
			if (len < 0)
			{
				throw new ArgumentOutOfRangeException("len");
			}
			if (startPos < 0)
			{
				throw new ArgumentOutOfRangeException("startPos");
			}
			if (chars.Length - startPos < len)
			{
				throw new ArgumentOutOfRangeException("len");
			}
			if (len == 0)
			{
				return 0;
			}
			int result;
			int num;
			fixed (char* ptr = &chars[startPos])
			{
				char* ptr2 = ptr;
				fixed (byte* ptr3 = &this.buffer[this.curIndex])
				{
					byte* ptr4 = ptr3;
					BinHexDecoder.Decode(ptr2, ptr2 + len, ptr4, ptr4 + (this.endIndex - this.curIndex), ref this.hasHalfByteCached, ref this.cachedHalfByte, out result, out num);
				}
			}
			this.curIndex += num;
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002C14 File Offset: 0x00000E14
		public unsafe static byte[] Decode(char[] chars, bool allowOddChars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars");
			}
			int num = chars.Length;
			if (num == 0)
			{
				return new byte[0];
			}
			byte[] array = new byte[(num + 1) / 2];
			bool flag = false;
			byte b = 0;
			int num3;
			fixed (char* ptr = &chars[0])
			{
				char* ptr2 = ptr;
				fixed (byte* ptr3 = &array[0])
				{
					byte* ptr4 = ptr3;
					int num2;
					BinHexDecoder.Decode(ptr2, ptr2 + num, ptr4, ptr4 + array.Length, ref flag, ref b, out num2, out num3);
				}
			}
			if (flag && !allowOddChars)
			{
				throw new XmlException("'{0}' is not a valid BinHex text sequence. The sequence must contain an even number of characters.", new string(chars));
			}
			if (num3 < array.Length)
			{
				byte[] array2 = new byte[num3];
				Array.Copy(array, 0, array2, 0, num3);
				array = array2;
			}
			return array;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002CC0 File Offset: 0x00000EC0
		private unsafe static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded)
		{
			char* ptr = pChars;
			byte* ptr2 = pBytes;
			XmlCharType instance = XmlCharType.Instance;
			while (ptr < pCharsEndPos && ptr2 < pBytesEndPos)
			{
				char c = *(ptr++);
				byte b;
				if (c >= 'a' && c <= 'f')
				{
					b = (byte)(c - 'a' + '\n');
				}
				else if (c >= 'A' && c <= 'F')
				{
					b = (byte)(c - 'A' + '\n');
				}
				else if (c >= '0' && c <= '9')
				{
					b = (byte)(c - '0');
				}
				else
				{
					if ((instance.charProperties[(int)c] & 1) == 0)
					{
						throw new XmlException("'{0}' is not a valid BinHex text sequence.", new string(pChars, 0, (int)((long)(pCharsEndPos - pChars))));
					}
					continue;
				}
				if (hasHalfByteCached)
				{
					*(ptr2++) = (byte)(((int)cachedHalfByte << 4) + (int)b);
					hasHalfByteCached = false;
				}
				else
				{
					cachedHalfByte = b;
					hasHalfByteCached = true;
				}
			}
			bytesDecoded = (int)((long)(ptr2 - pBytes));
			charsDecoded = (int)((long)(ptr - pChars));
		}

		// Token: 0x0400002A RID: 42
		private byte[] buffer;

		// Token: 0x0400002B RID: 43
		private int curIndex;

		// Token: 0x0400002C RID: 44
		private int endIndex;

		// Token: 0x0400002D RID: 45
		private bool hasHalfByteCached;

		// Token: 0x0400002E RID: 46
		private byte cachedHalfByte;
	}
}
