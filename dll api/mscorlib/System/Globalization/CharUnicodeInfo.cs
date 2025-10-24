using System;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	/// <summary>Retrieves information about a Unicode character. This class cannot be inherited.</summary>
	// Token: 0x02000576 RID: 1398
	public static class CharUnicodeInfo
	{
		// Token: 0x060029B3 RID: 10675 RVA: 0x000A6724 File Offset: 0x000A4924
		internal static int InternalConvertToUtf32(string s, int index)
		{
			if (index < s.Length - 1)
			{
				int num = (int)(s[index] - '\ud800');
				if (num <= 1023)
				{
					int num2 = (int)(s[index + 1] - '\udc00');
					if (num2 <= 1023)
					{
						return num * 1024 + num2 + 65536;
					}
				}
			}
			return (int)s[index];
		}

		/// <summary>Gets the Unicode category of the specified character.</summary>
		/// <param name="ch">The Unicode character for which to get the Unicode category. </param>
		/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value indicating the category of the specified character.</returns>
		// Token: 0x060029B4 RID: 10676 RVA: 0x000A6781 File Offset: 0x000A4981
		public static UnicodeCategory GetUnicodeCategory(char ch)
		{
			return CharUnicodeInfo.GetUnicodeCategory((int)ch);
		}

		/// <summary>Gets the Unicode category of the character at the specified index of the specified string.</summary>
		/// <param name="s">The <see cref="T:System.String" /> containing the Unicode character for which to get the Unicode category. </param>
		/// <param name="index">The index of the Unicode character for which to get the Unicode category. </param>
		/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value indicating the category of the character at the specified index of the specified string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the range of valid indexes in <paramref name="s" />. </exception>
		// Token: 0x060029B5 RID: 10677 RVA: 0x000A6789 File Offset: 0x000A4989
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return CharUnicodeInfo.InternalGetUnicodeCategory(s, index);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000A67B4 File Offset: 0x000A49B4
		public static UnicodeCategory GetUnicodeCategory(int codePoint)
		{
			return (UnicodeCategory)CharUnicodeInfo.InternalGetCategoryValue(codePoint, 0);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000A67C0 File Offset: 0x000A49C0
		internal unsafe static byte InternalGetCategoryValue(int ch, int offset)
		{
			int num = (int)(*CharUnicodeInfo.CategoryLevel1Index[ch >> 9]);
			num = (int)Unsafe.ReadUnaligned<ushort>(Unsafe.AsRef<byte>(CharUnicodeInfo.CategoryLevel2Index[(num << 6) + (ch >> 3 & 62)]));
			if (!BitConverter.IsLittleEndian)
			{
				num = (int)BinaryPrimitives.ReverseEndianness((ushort)num);
			}
			num = (int)(*CharUnicodeInfo.CategoryLevel3Index[(num << 4) + (ch & 15)]);
			return *CharUnicodeInfo.CategoriesValue[num * 2 + offset];
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000A683B File Offset: 0x000A4A3B
		internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			return CharUnicodeInfo.GetUnicodeCategory(CharUnicodeInfo.InternalConvertToUtf32(value, index));
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000A684C File Offset: 0x000A4A4C
		internal static bool IsWhiteSpace(string s, int index)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(s, index);
			return unicodeCategory - UnicodeCategory.SpaceSeparator <= 2;
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000A686C File Offset: 0x000A4A6C
		internal static bool IsWhiteSpace(char c)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
			return unicodeCategory - UnicodeCategory.SpaceSeparator <= 2;
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x000A688A File Offset: 0x000A4A8A
		private unsafe static ReadOnlySpan<byte> CategoryLevel1Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B55F94CD2F415D0279D7A1AF2265C4D9A90CE47F8C900D5D09AD088796210838), 2176);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x000A689B File Offset: 0x000A4A9B
		private unsafe static ReadOnlySpan<byte> CategoryLevel2Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.9086502742CE7F0595B57A4E5B32901FF4CF97959B92F7E91A435E4765AC1115), 5952);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x000A68AC File Offset: 0x000A4AAC
		private unsafe static ReadOnlySpan<byte> CategoryLevel3Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.56073E3CC3FC817690CC306D0DB7EA63EBCB0801359567CA44CA3D3B9BF63854), 10800);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x000A68BD File Offset: 0x000A4ABD
		private unsafe static ReadOnlySpan<byte> CategoriesValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.D6691EE5A533DE7E0859066942261B24D0C836D7EE016D2251377BFEE40FEA15), 172);
			}
		}
	}
}
