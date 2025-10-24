using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000E9 RID: 233
	internal static class ParseNumbers
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x000230A8 File Offset: 0x000212A8
		public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags)
		{
			int num = 0;
			return ParseNumbers.StringToLong(s, radix, flags, ref num);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000230C4 File Offset: 0x000212C4
		public unsafe static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			int num = currPos;
			int num2 = (-1 == radix) ? 10 : radix;
			if (num2 != 2 && num2 != 10 && num2 != 8 && num2 != 16)
			{
				throw new ArgumentException("Invalid Base.", "radix");
			}
			int length = s.Length;
			if (num < 0 || num >= length)
			{
				throw new ArgumentOutOfRangeException("Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if ((flags & 4096) == 0 && (flags & 8192) == 0)
			{
				ParseNumbers.EatWhiteSpace(s, ref num);
				if (num == length)
				{
					throw new FormatException("Input string was either empty or contained only whitespace.");
				}
			}
			int num3 = 1;
			if (*s[num] == 45)
			{
				if (num2 != 10)
				{
					throw new ArgumentException("String cannot contain a minus sign if the base is not 10.");
				}
				if ((flags & 512) != 0)
				{
					throw new OverflowException("The string was being parsed as an unsigned number and could not have a negative sign.");
				}
				num3 = -1;
				num++;
			}
			else if (*s[num] == 43)
			{
				num++;
			}
			if ((radix == -1 || radix == 16) && num + 1 < length && *s[num] == 48 && (*s[num + 1] == 120 || *s[num + 1] == 88))
			{
				num2 = 16;
				num += 2;
			}
			int num4 = num;
			long num5 = ParseNumbers.GrabLongs(num2, s, ref num, (flags & 512) != 0);
			if (num == num4)
			{
				throw new FormatException("Could not find any recognizable digits.");
			}
			if ((flags & 4096) != 0 && num < length)
			{
				throw new FormatException("Additional non-parsable characters are at the end of the string.");
			}
			currPos = num;
			if (num5 == -9223372036854775808L && num3 == 1 && num2 == 10 && (flags & 512) == 0)
			{
				throw new OverflowException("Value was either too large or too small for an Int64.");
			}
			if (num2 == 10)
			{
				num5 *= (long)num3;
			}
			return num5;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002324C File Offset: 0x0002144C
		public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags)
		{
			int num = 0;
			return ParseNumbers.StringToInt(s, radix, flags, ref num);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00023268 File Offset: 0x00021468
		public unsafe static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			int num = currPos;
			int num2 = (-1 == radix) ? 10 : radix;
			if (num2 != 2 && num2 != 10 && num2 != 8 && num2 != 16)
			{
				throw new ArgumentException("Invalid Base.", "radix");
			}
			int length = s.Length;
			if (num < 0 || num >= length)
			{
				throw new ArgumentOutOfRangeException("Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if ((flags & 4096) == 0 && (flags & 8192) == 0)
			{
				ParseNumbers.EatWhiteSpace(s, ref num);
				if (num == length)
				{
					throw new FormatException("Input string was either empty or contained only whitespace.");
				}
			}
			int num3 = 1;
			if (*s[num] == 45)
			{
				if (num2 != 10)
				{
					throw new ArgumentException("String cannot contain a minus sign if the base is not 10.");
				}
				if ((flags & 512) != 0)
				{
					throw new OverflowException("The string was being parsed as an unsigned number and could not have a negative sign.");
				}
				num3 = -1;
				num++;
			}
			else if (*s[num] == 43)
			{
				num++;
			}
			if ((radix == -1 || radix == 16) && num + 1 < length && *s[num] == 48 && (*s[num + 1] == 120 || *s[num + 1] == 88))
			{
				num2 = 16;
				num += 2;
			}
			int num4 = num;
			int num5 = ParseNumbers.GrabInts(num2, s, ref num, (flags & 512) != 0);
			if (num == num4)
			{
				throw new FormatException("Could not find any recognizable digits.");
			}
			if ((flags & 4096) != 0 && num < length)
			{
				throw new FormatException("Additional non-parsable characters are at the end of the string.");
			}
			currPos = num;
			if ((flags & 1024) != 0)
			{
				if (num5 > 255)
				{
					throw new OverflowException("Value was either too large or too small for a signed byte.");
				}
			}
			else if ((flags & 2048) != 0)
			{
				if (num5 > 65535)
				{
					throw new OverflowException("Value was either too large or too small for an Int16.");
				}
			}
			else if (num5 == -2147483648 && num3 == 1 && num2 == 10 && (flags & 512) == 0)
			{
				throw new OverflowException("Value was either too large or too small for an Int32.");
			}
			if (num2 == 10)
			{
				num5 *= num3;
			}
			return num5;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00023428 File Offset: 0x00021628
		private unsafe static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i)
		{
			int num = i;
			while (num < s.Length && char.IsWhiteSpace((char)(*s[num])))
			{
				num++;
			}
			i = num;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0002345C File Offset: 0x0002165C
		private unsafe static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			ulong num = 0UL;
			if (radix == 10 && !isUnsigned)
			{
				ulong num2 = 922337203685477580UL;
				int num3;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num3))
				{
					if (num > num2 || num < 0UL)
					{
						ParseNumbers.ThrowOverflowInt64Exception();
					}
					num = num * (ulong)((long)radix) + (ulong)((long)num3);
					i++;
				}
				if (num < 0UL && num != 9223372036854775808UL)
				{
					ParseNumbers.ThrowOverflowInt64Exception();
				}
			}
			else
			{
				ulong num2 = (radix == 10) ? 1844674407370955161UL : ((radix == 16) ? 1152921504606846975UL : ((radix == 8) ? 2305843009213693951UL : 9223372036854775807UL));
				int num4;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num4))
				{
					if (num > num2)
					{
						ParseNumbers.ThrowOverflowUInt64Exception();
					}
					ulong num5 = num * (ulong)((long)radix) + (ulong)((long)num4);
					if (num5 < num)
					{
						ParseNumbers.ThrowOverflowUInt64Exception();
					}
					num = num5;
					i++;
				}
			}
			return (long)num;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00023554 File Offset: 0x00021754
		private unsafe static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			uint num = 0U;
			if (radix == 10 && !isUnsigned)
			{
				uint num2 = 214748364U;
				int num3;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num3))
				{
					if (num > num2 || num < 0U)
					{
						ParseNumbers.ThrowOverflowInt32Exception();
					}
					num = num * (uint)radix + (uint)num3;
					i++;
				}
				if (num < 0U && num != 2147483648U)
				{
					ParseNumbers.ThrowOverflowInt32Exception();
				}
			}
			else
			{
				uint num2 = (radix == 10) ? 429496729U : ((radix == 16) ? 268435455U : ((radix == 8) ? 536870911U : 2147483647U));
				int num4;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num4))
				{
					if (num > num2)
					{
						throw new OverflowException("Value was either too large or too small for a UInt32.");
					}
					uint num5 = num * (uint)radix + (uint)num4;
					if (num5 < num)
					{
						ParseNumbers.ThrowOverflowUInt32Exception();
					}
					num = num5;
					i++;
				}
			}
			return (int)num;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00010725 File Offset: 0x0000E925
		private static void ThrowOverflowInt32Exception()
		{
			throw new OverflowException("Value was either too large or too small for an Int32.");
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0001073D File Offset: 0x0000E93D
		private static void ThrowOverflowInt64Exception()
		{
			throw new OverflowException("Value was either too large or too small for an Int64.");
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00010731 File Offset: 0x0000E931
		private static void ThrowOverflowUInt32Exception()
		{
			throw new OverflowException("Value was either too large or too small for a UInt32.");
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00010749 File Offset: 0x0000E949
		private static void ThrowOverflowUInt64Exception()
		{
			throw new OverflowException("Value was either too large or too small for a UInt64.");
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00023630 File Offset: 0x00021830
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsDigit(char c, int radix, out int result)
		{
			int num;
			if (c - '0' <= '\t')
			{
				num = (result = (int)(c - '0'));
			}
			else if (c - 'A' <= '\u0019')
			{
				num = (result = (int)(c - 'A' + '\n'));
			}
			else
			{
				if (c - 'a' > '\u0019')
				{
					result = -1;
					return false;
				}
				num = (result = (int)(c - 'a' + '\n'));
			}
			return num < radix;
		}
	}
}
