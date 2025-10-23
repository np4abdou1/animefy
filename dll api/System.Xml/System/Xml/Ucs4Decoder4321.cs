﻿using System;

namespace System.Xml
{
	// Token: 0x020001AF RID: 431
	internal class Ucs4Decoder4321 : Ucs4Decoder
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x00060C78 File Offset: 0x0005EE78
		internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			byteCount += byteIndex;
			int num = byteIndex;
			int num2 = charIndex;
			while (num + 3 < byteCount)
			{
				uint num3 = (uint)((int)bytes[num + 3] << 24 | (int)bytes[num + 2] << 16 | (int)bytes[num + 1] << 8 | (int)bytes[num]);
				if (num3 > 1114111U)
				{
					throw new ArgumentException(Res.GetString("Invalid byte was found at index {0}.", new object[]
					{
						num
					}), null);
				}
				if (num3 > 65535U)
				{
					base.Ucs4ToUTF16(num3, chars, num2);
					num2++;
				}
				else
				{
					if (XmlCharType.IsSurrogate((int)num3))
					{
						throw new XmlException("Invalid character in the given encoding.", string.Empty);
					}
					chars[num2] = (char)num3;
				}
				num2++;
				num += 4;
			}
			return num2 - charIndex;
		}
	}
}
