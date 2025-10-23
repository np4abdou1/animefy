﻿using System;

namespace System.Xml
{
	// Token: 0x0200000F RID: 15
	internal static class BinHexEncoder
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002D90 File Offset: 0x00000F90
		internal static void Encode(byte[] buffer, int index, int count, XmlWriter writer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count > buffer.Length - index)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			char[] array = new char[(count * 2 < 128) ? (count * 2) : 128];
			int num = index + count;
			while (index < num)
			{
				int num2 = (count < 64) ? count : 64;
				int count2 = BinHexEncoder.Encode(buffer, index, num2, array);
				writer.WriteRaw(array, 0, count2);
				index += num2;
				count -= num2;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E28 File Offset: 0x00001028
		internal static string Encode(byte[] inArray, int offsetIn, int count)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			if (0 > offsetIn)
			{
				throw new ArgumentOutOfRangeException("offsetIn");
			}
			if (0 > count)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count > inArray.Length - offsetIn)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			char[] array = new char[2 * count];
			int length = BinHexEncoder.Encode(inArray, offsetIn, count, array);
			return new string(array, 0, length);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002E90 File Offset: 0x00001090
		private static int Encode(byte[] inArray, int offsetIn, int count, char[] outArray)
		{
			int num = 0;
			int num2 = 0;
			int num3 = outArray.Length;
			for (int i = 0; i < count; i++)
			{
				byte b = inArray[offsetIn++];
				outArray[num++] = "0123456789ABCDEF"[b >> 4];
				if (num == num3)
				{
					break;
				}
				outArray[num++] = "0123456789ABCDEF"[(int)(b & 15)];
				if (num == num3)
				{
					break;
				}
			}
			return num - num2;
		}
	}
}
