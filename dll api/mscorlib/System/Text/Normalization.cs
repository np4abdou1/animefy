using System;
using System.Runtime.CompilerServices;
using Mono.Globalization.Unicode;

namespace System.Text
{
	// Token: 0x02000274 RID: 628
	internal class Normalization
	{
		// Token: 0x06001619 RID: 5657 RVA: 0x0005A675 File Offset: 0x00058875
		private unsafe static uint PropValue(int cp)
		{
			return (uint)Normalization.props[NormalizationTableUtil.PropIdx(cp)];
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0005A684 File Offset: 0x00058884
		private unsafe static int CharMapIdx(int cp)
		{
			return (int)Normalization.charMapIndex[NormalizationTableUtil.MapIdx(cp)];
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0005A696 File Offset: 0x00058896
		private unsafe static byte GetCombiningClass(int c)
		{
			return Normalization.combiningClass[NormalizationTableUtil.Combining.ToIndex(c)];
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0005A6AA File Offset: 0x000588AA
		private unsafe static int GetPrimaryCompositeFromMapIndex(int src)
		{
			return (int)Normalization.mapIdxToComposite[NormalizationTableUtil.Composite.ToIndex(src)];
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0005A6C1 File Offset: 0x000588C1
		private unsafe static int GetPrimaryCompositeHelperIndex(int cp)
		{
			return (int)Normalization.helperIndex[NormalizationTableUtil.Helper.ToIndex(cp)];
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0005A6D8 File Offset: 0x000588D8
		private static string Compose(string source, int checkType)
		{
			StringBuilder stringBuilder = null;
			Normalization.Decompose(source, ref stringBuilder, (checkType == 2) ? 3 : 1);
			if (stringBuilder == null)
			{
				stringBuilder = Normalization.Combine(source, 0, checkType);
			}
			else
			{
				Normalization.Combine(stringBuilder, 0, checkType);
			}
			if (stringBuilder == null)
			{
				return source;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0005A718 File Offset: 0x00058918
		private static StringBuilder Combine(string source, int start, int checkType)
		{
			for (int i = 0; i < source.Length; i++)
			{
				if (Normalization.QuickCheck(source[i], checkType) != NormalizationCheck.Yes)
				{
					StringBuilder stringBuilder = new StringBuilder(source.Length + source.Length / 10);
					stringBuilder.Append(source);
					Normalization.Combine(stringBuilder, i, checkType);
					return stringBuilder;
				}
			}
			return null;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0005A76C File Offset: 0x0005896C
		private static void Combine(StringBuilder sb, int i, int checkType)
		{
			Normalization.CombineHangul(sb, null, (i > 0) ? (i - 1) : i);
			while (i < sb.Length)
			{
				if (Normalization.QuickCheck(sb[i], checkType) == NormalizationCheck.Yes)
				{
					i++;
				}
				else
				{
					i = Normalization.TryComposeWithPreviousStarter(sb, null, i);
				}
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0005A7AC File Offset: 0x000589AC
		private static int CombineHangul(StringBuilder sb, string s, int current)
		{
			int num = (sb != null) ? sb.Length : s.Length;
			int num2 = Normalization.Fetch(sb, s, current);
			int i = current + 1;
			while (i < num)
			{
				int num3 = Normalization.Fetch(sb, s, i);
				int num4 = num2 - 4352;
				if (0 > num4 || num4 >= 19)
				{
					goto IL_8A;
				}
				int num5 = num3 - 4449;
				if (0 > num5 || num5 >= 21)
				{
					goto IL_8A;
				}
				if (sb == null)
				{
					return -1;
				}
				num2 = 44032 + (num4 * 21 + num5) * 28;
				sb[i - 1] = (char)num2;
				sb.Remove(i, 1);
				i--;
				num--;
				IL_E6:
				i++;
				continue;
				IL_8A:
				int num6 = num2 - 44032;
				if (0 <= num6 && num6 < 11172 && num6 % 28 == 0)
				{
					int num7 = num3 - 4519;
					if (0 < num7 && num7 < 28)
					{
						if (sb == null)
						{
							return -1;
						}
						num2 += num7;
						sb[i - 1] = (char)num2;
						sb.Remove(i, 1);
						i--;
						num--;
						goto IL_E6;
					}
				}
				num2 = num3;
				goto IL_E6;
			}
			return num;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0005A8AB File Offset: 0x00058AAB
		private static int Fetch(StringBuilder sb, string s, int i)
		{
			if (sb == null)
			{
				return (int)s[i];
			}
			return (int)sb[i];
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0005A8C0 File Offset: 0x00058AC0
		private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
		{
			int num = current - 1;
			if (Normalization.GetCombiningClass(Normalization.Fetch(sb, s, current)) == 0)
			{
				if (num < 0 || Normalization.GetCombiningClass(Normalization.Fetch(sb, s, num)) != 0)
				{
					return current + 1;
				}
			}
			else
			{
				while (num >= 0 && Normalization.GetCombiningClass(Normalization.Fetch(sb, s, num)) != 0)
				{
					num--;
				}
				if (num < 0)
				{
					return current + 1;
				}
			}
			int num2 = Normalization.Fetch(sb, s, num);
			int primaryCompositeHelperIndex = Normalization.GetPrimaryCompositeHelperIndex(num2);
			if (primaryCompositeHelperIndex == 0)
			{
				return current + 1;
			}
			int num3 = (sb != null) ? sb.Length : s.Length;
			int num4 = -1;
			for (int i = num + 1; i < num3; i++)
			{
				int num5 = Normalization.Fetch(sb, s, i);
				int num6 = (int)Normalization.GetCombiningClass(num5);
				if (num6 != num4)
				{
					int num7 = Normalization.TryCompose(primaryCompositeHelperIndex, num2, num5);
					if (num7 != 0)
					{
						if (sb == null)
						{
							return -1;
						}
						sb[num] = (char)num7;
						sb.Remove(i, 1);
						return current;
					}
					else
					{
						if (num6 == 0)
						{
							return i + 1;
						}
						num4 = num6;
					}
				}
			}
			return num3;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0005A9A8 File Offset: 0x00058BA8
		private unsafe static int TryCompose(int i, int starter, int candidate)
		{
			while (Normalization.mappedChars[i] == starter)
			{
				if (Normalization.mappedChars[i + 1] == candidate && Normalization.mappedChars[i + 2] == 0)
				{
					int primaryCompositeFromMapIndex = Normalization.GetPrimaryCompositeFromMapIndex(i);
					if ((Normalization.PropValue(primaryCompositeFromMapIndex) & 64U) == 0U)
					{
						return primaryCompositeFromMapIndex;
					}
				}
				while (Normalization.mappedChars[i] != 0)
				{
					i++;
				}
				i++;
			}
			return 0;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0005AA10 File Offset: 0x00058C10
		private static string Decompose(string source, int checkType)
		{
			StringBuilder stringBuilder = null;
			Normalization.Decompose(source, ref stringBuilder, checkType);
			if (stringBuilder == null)
			{
				return source;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0005AA34 File Offset: 0x00058C34
		private static void Decompose(string source, ref StringBuilder sb, int checkType)
		{
			int[] array = null;
			int num = 0;
			for (int i = 0; i < source.Length; i++)
			{
				if (Normalization.QuickCheck(source[i], checkType) == NormalizationCheck.No)
				{
					Normalization.DecomposeChar(ref sb, ref array, source, i, checkType, ref num);
				}
			}
			if (sb != null)
			{
				sb.Append(source, num, source.Length - num);
			}
			Normalization.ReorderCanonical(source, ref sb, 1);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0005AA94 File Offset: 0x00058C94
		private static void ReorderCanonical(string src, ref StringBuilder sb, int start)
		{
			if (sb == null)
			{
				for (int i = 1; i < src.Length; i++)
				{
					int num = (int)Normalization.GetCombiningClass((int)src[i]);
					if (num != 0 && (int)Normalization.GetCombiningClass((int)src[i - 1]) > num)
					{
						sb = new StringBuilder(src.Length);
						sb.Append(src, 0, src.Length);
						Normalization.ReorderCanonical(src, ref sb, i);
						return;
					}
				}
				return;
			}
			int j = start;
			while (j < sb.Length)
			{
				int num2 = (int)Normalization.GetCombiningClass((int)sb[j]);
				if (num2 == 0 || (int)Normalization.GetCombiningClass((int)sb[j - 1]) <= num2)
				{
					j++;
				}
				else
				{
					char value = sb[j - 1];
					sb[j - 1] = sb[j];
					sb[j] = value;
					if (j > 1)
					{
						j--;
					}
				}
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0005AB68 File Offset: 0x00058D68
		private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start)
		{
			if (sb == null)
			{
				sb = new StringBuilder(s.Length + 100);
			}
			sb.Append(s, start, i - start);
			if (buf == null)
			{
				buf = new int[19];
			}
			int canonical = Normalization.GetCanonical((int)s[i], buf, 0, checkType);
			for (int j = 0; j < canonical; j++)
			{
				if (buf[j] < 65535)
				{
					sb.Append((char)buf[j]);
				}
				else
				{
					sb.Append((char)(buf[j] >> 10));
					sb.Append((char)((buf[j] & 4095) + 56320));
				}
			}
			start = i + 1;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0005AC10 File Offset: 0x00058E10
		public static NormalizationCheck QuickCheck(char c, int type)
		{
			switch (type)
			{
			case 1:
				if ('가' <= c && c <= '힣')
				{
					return NormalizationCheck.No;
				}
				if ((Normalization.PropValue((int)c) & 1U) == 0U)
				{
					return NormalizationCheck.Yes;
				}
				return NormalizationCheck.No;
			case 2:
			{
				uint num = Normalization.PropValue((int)c);
				if ((num & 16U) != 0U)
				{
					return NormalizationCheck.No;
				}
				if ((num & 32U) == 0U)
				{
					return NormalizationCheck.Yes;
				}
				return NormalizationCheck.Maybe;
			}
			case 3:
				if ('가' <= c && c <= '힣')
				{
					return NormalizationCheck.No;
				}
				if ((Normalization.PropValue((int)c) & 2U) == 0U)
				{
					return NormalizationCheck.Yes;
				}
				return NormalizationCheck.No;
			default:
			{
				uint num = Normalization.PropValue((int)c);
				if ((num & 4U) != 0U)
				{
					return NormalizationCheck.No;
				}
				if ((num & 8U) != 0U)
				{
					return NormalizationCheck.Maybe;
				}
				return NormalizationCheck.Yes;
			}
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0005ACA0 File Offset: 0x00058EA0
		private static int GetCanonicalHangul(int s, int[] buf, int bufIdx)
		{
			int num = s - 44032;
			if (num < 0 || num >= 11172)
			{
				return bufIdx;
			}
			int num2 = 4352 + num / 588;
			int num3 = 4449 + num % 588 / 28;
			int num4 = 4519 + num % 28;
			buf[bufIdx++] = num2;
			buf[bufIdx++] = num3;
			if (num4 != 4519)
			{
				buf[bufIdx++] = num4;
			}
			buf[bufIdx] = 0;
			return bufIdx;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0005AD18 File Offset: 0x00058F18
		private unsafe static int GetCanonical(int c, int[] buf, int bufIdx, int checkType)
		{
			int canonicalHangul = Normalization.GetCanonicalHangul(c, buf, bufIdx);
			if (canonicalHangul > bufIdx)
			{
				return canonicalHangul;
			}
			int num = Normalization.CharMapIdx(c);
			if (num == 0 || Normalization.mappedChars[num] == c)
			{
				buf[bufIdx++] = c;
			}
			else
			{
				while (Normalization.mappedChars[num] != 0)
				{
					int num2 = Normalization.mappedChars[num];
					if (num2 <= 65535 && Normalization.QuickCheck((char)num2, checkType) == NormalizationCheck.Yes)
					{
						buf[bufIdx++] = num2;
					}
					else
					{
						bufIdx = Normalization.GetCanonical(num2, buf, bufIdx, checkType);
					}
					num++;
				}
			}
			return bufIdx;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0005AD9D File Offset: 0x00058F9D
		public static string Normalize(string source, NormalizationForm normalizationForm)
		{
			switch (normalizationForm)
			{
			case NormalizationForm.FormD:
				return Normalization.Normalize(source, 1);
			default:
				return Normalization.Normalize(source, 0);
			case NormalizationForm.FormKC:
				return Normalization.Normalize(source, 2);
			case NormalizationForm.FormKD:
				return Normalization.Normalize(source, 3);
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0005ADDA File Offset: 0x00058FDA
		public static string Normalize(string source, int type)
		{
			switch (type)
			{
			case 1:
			case 3:
				return Normalization.Decompose(source, type);
			default:
				return Normalization.Compose(source, type);
			}
		}

		// Token: 0x0600162E RID: 5678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass);

		// Token: 0x0600162F RID: 5679 RVA: 0x0005AE00 File Offset: 0x00059000
		unsafe static Normalization()
		{
			object obj = Normalization.forLock;
			lock (obj)
			{
				IntPtr value;
				IntPtr value2;
				IntPtr value3;
				IntPtr value4;
				IntPtr value5;
				IntPtr value6;
				Normalization.load_normalization_resource(out value, out value2, out value3, out value4, out value5, out value6);
				Normalization.props = (byte*)((void*)value);
				Normalization.mappedChars = (int*)((void*)value2);
				Normalization.charMapIndex = (short*)((void*)value3);
				Normalization.helperIndex = (short*)((void*)value4);
				Normalization.mapIdxToComposite = (ushort*)((void*)value5);
				Normalization.combiningClass = (byte*)((void*)value6);
			}
			Normalization.isReady = true;
		}

		// Token: 0x040008A1 RID: 2209
		private unsafe static byte* props;

		// Token: 0x040008A2 RID: 2210
		private unsafe static int* mappedChars;

		// Token: 0x040008A3 RID: 2211
		private unsafe static short* charMapIndex;

		// Token: 0x040008A4 RID: 2212
		private unsafe static short* helperIndex;

		// Token: 0x040008A5 RID: 2213
		private unsafe static ushort* mapIdxToComposite;

		// Token: 0x040008A6 RID: 2214
		private unsafe static byte* combiningClass;

		// Token: 0x040008A7 RID: 2215
		private static object forLock = new object();

		// Token: 0x040008A8 RID: 2216
		public static readonly bool isReady;
	}
}
