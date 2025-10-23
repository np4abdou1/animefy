﻿using System;
using System.Globalization;

namespace Mono.Globalization.Unicode
{
	// Token: 0x0200003C RID: 60
	internal class SimpleCollator : ISimpleCollator
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x000048FC File Offset: 0x00002AFC
		public SimpleCollator(CultureInfo culture)
		{
			this.lcid = culture.LCID;
			this.textInfo = culture.TextInfo;
			this.SetCJKTable(culture, ref this.cjkIndexer, ref this.cjkCatTable, ref this.cjkLv1Table, ref this.cjkLv2Indexer, ref this.cjkLv2Table);
			TailoringInfo tailoringInfo = null;
			CultureInfo cultureInfo = culture;
			while (cultureInfo.LCID != 127)
			{
				tailoringInfo = MSCompatUnicodeTable.GetTailoringInfo(cultureInfo.LCID);
				if (tailoringInfo != null)
				{
					break;
				}
				cultureInfo = cultureInfo.Parent;
			}
			if (tailoringInfo == null)
			{
				tailoringInfo = MSCompatUnicodeTable.GetTailoringInfo(127);
			}
			this.frenchSort = tailoringInfo.FrenchSort;
			MSCompatUnicodeTable.BuildTailoringTables(culture, tailoringInfo, ref this.contractions, ref this.level2Maps);
			this.unsafeFlags = new byte[96];
			foreach (Contraction contraction in this.contractions)
			{
				if (contraction.Source.Length > 1)
				{
					foreach (char c in contraction.Source)
					{
						byte[] array2 = this.unsafeFlags;
						char c2 = c / '\b';
						array2[(int)c2] = (array2[(int)c2] | (byte)(1 << (int)(c & '\a')));
					}
				}
			}
			if (this.lcid != 127)
			{
				foreach (Contraction contraction2 in SimpleCollator.invariant.contractions)
				{
					if (contraction2.Source.Length > 1)
					{
						foreach (char c3 in contraction2.Source)
						{
							byte[] array3 = this.unsafeFlags;
							char c4 = c3 / '\b';
							array3[(int)c4] = (array3[(int)c4] | (byte)(1 << (int)(c3 & '\a')));
						}
					}
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004A85 File Offset: 0x00002C85
		private unsafe void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			MSCompatUnicodeTable.FillCJK(SimpleCollator.GetNeutralCulture(culture).Name, ref cjkIndexer, ref catTable, ref lv1Table, ref lv2Indexer, ref lv2Table);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004AA0 File Offset: 0x00002CA0
		private static CultureInfo GetNeutralCulture(CultureInfo info)
		{
			CultureInfo cultureInfo = info;
			while (cultureInfo.Parent != null && cultureInfo.Parent.LCID != 127)
			{
				cultureInfo = cultureInfo.Parent;
			}
			return cultureInfo;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004AD0 File Offset: 0x00002CD0
		private unsafe byte Category(int cp)
		{
			if (cp < 12288 || this.cjkCatTable == null)
			{
				return MSCompatUnicodeTable.Category(cp);
			}
			int num = this.cjkIndexer.ToIndex(cp);
			if (num >= 0)
			{
				return this.cjkCatTable[num];
			}
			return MSCompatUnicodeTable.Category(cp);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004B18 File Offset: 0x00002D18
		private unsafe byte Level1(int cp)
		{
			if (cp < 12288 || this.cjkLv1Table == null)
			{
				return MSCompatUnicodeTable.Level1(cp);
			}
			int num = this.cjkIndexer.ToIndex(cp);
			if (num >= 0)
			{
				return this.cjkLv1Table[num];
			}
			return MSCompatUnicodeTable.Level1(cp);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004B60 File Offset: 0x00002D60
		private unsafe byte Level2(int cp, SimpleCollator.ExtenderType ext)
		{
			if (ext == SimpleCollator.ExtenderType.Buggy)
			{
				return 5;
			}
			if (ext == SimpleCollator.ExtenderType.Conditional)
			{
				return 0;
			}
			if (cp < 12288 || this.cjkLv2Table == null)
			{
				return MSCompatUnicodeTable.Level2(cp);
			}
			int num = this.cjkLv2Indexer.ToIndex(cp);
			byte b = (num < 0) ? 0 : this.cjkLv2Table[num];
			if (b != 0)
			{
				return b;
			}
			b = MSCompatUnicodeTable.Level2(cp);
			if (this.level2Maps.Length == 0)
			{
				return b;
			}
			for (int i = 0; i < this.level2Maps.Length; i++)
			{
				if (this.level2Maps[i].Source == b)
				{
					return this.level2Maps[i].Replace;
				}
				if (this.level2Maps[i].Source > b)
				{
					break;
				}
			}
			return b;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004C09 File Offset: 0x00002E09
		private static bool IsHalfKana(int cp, CompareOptions opt)
		{
			return (opt & CompareOptions.IgnoreWidth) != CompareOptions.None || MSCompatUnicodeTable.IsHalfWidthKana((char)cp);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004C1C File Offset: 0x00002E1C
		private Contraction GetContraction(string s, int start, int end)
		{
			Contraction contraction = this.GetContraction(s, start, end, this.contractions);
			if (contraction != null || this.lcid == 127)
			{
				return contraction;
			}
			return this.GetContraction(s, start, end, SimpleCollator.invariant.contractions);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004C5C File Offset: 0x00002E5C
		private Contraction GetContraction(string s, int start, int end, Contraction[] clist)
		{
			foreach (Contraction contraction in clist)
			{
				int num = (int)(contraction.Source[0] - s[start]);
				if (num > 0)
				{
					return null;
				}
				if (num >= 0)
				{
					char[] source = contraction.Source;
					if (end - start >= source.Length)
					{
						bool flag = true;
						for (int j = 0; j < source.Length; j++)
						{
							if (s[start + j] != source[j])
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							return contraction;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004CD8 File Offset: 0x00002ED8
		private Contraction GetTailContraction(string s, int start, int end)
		{
			Contraction tailContraction = this.GetTailContraction(s, start, end, this.contractions);
			if (tailContraction != null || this.lcid == 127)
			{
				return tailContraction;
			}
			return this.GetTailContraction(s, start, end, SimpleCollator.invariant.contractions);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004D18 File Offset: 0x00002F18
		private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist)
		{
			if (start == end || end < -1 || start >= s.Length || s.Length <= end + 1)
			{
				throw new SystemException(string.Format("MONO internal error. Failed to get TailContraction. start = {0} end = {1} string = '{2}'", start, end, s));
			}
			foreach (Contraction contraction in clist)
			{
				char[] source = contraction.Source;
				if (source.Length <= start - end && source[source.Length - 1] == s[start])
				{
					bool flag = true;
					int j = 0;
					int num = start - source.Length + 1;
					while (j < source.Length)
					{
						if (s[num] != source[j])
						{
							flag = false;
							break;
						}
						j++;
						num++;
					}
					if (flag)
					{
						return contraction;
					}
				}
			}
			return null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004DCC File Offset: 0x00002FCC
		private int FilterOptions(int i, CompareOptions opt)
		{
			if ((opt & CompareOptions.IgnoreWidth) != CompareOptions.None)
			{
				int num = MSCompatUnicodeTable.ToWidthCompat(i);
				if (num != 0)
				{
					i = num;
				}
			}
			if ((opt & CompareOptions.OrdinalIgnoreCase) != CompareOptions.None)
			{
				i = (int)this.textInfo.ToLower((char)i);
			}
			if ((opt & CompareOptions.IgnoreCase) != CompareOptions.None)
			{
				i = (int)this.textInfo.ToLower((char)i);
			}
			if ((opt & CompareOptions.IgnoreKanaType) != CompareOptions.None)
			{
				i = MSCompatUnicodeTable.ToKanaTypeInsensitive(i);
			}
			return i;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004E28 File Offset: 0x00003028
		private SimpleCollator.ExtenderType GetExtenderType(int i)
		{
			if (i == 8213)
			{
				if (this.lcid != 16)
				{
					return SimpleCollator.ExtenderType.None;
				}
				return SimpleCollator.ExtenderType.Conditional;
			}
			else
			{
				if (i < 12293 || i > 65392)
				{
					return SimpleCollator.ExtenderType.None;
				}
				if (i >= 65148)
				{
					if (i - 65148 <= 1)
					{
						return SimpleCollator.ExtenderType.Simple;
					}
					if (i == 65392)
					{
						return SimpleCollator.ExtenderType.Conditional;
					}
					if (i - 65438 <= 1)
					{
						return SimpleCollator.ExtenderType.Voiced;
					}
				}
				if (i > 12542)
				{
					return SimpleCollator.ExtenderType.None;
				}
				if (i <= 12338)
				{
					if (i == 12293)
					{
						return SimpleCollator.ExtenderType.Buggy;
					}
					if (i - 12337 > 1)
					{
						return SimpleCollator.ExtenderType.None;
					}
				}
				else if (i != 12445)
				{
					if (i != 12446)
					{
						switch (i)
						{
						case 12540:
							return SimpleCollator.ExtenderType.Conditional;
						case 12541:
							return SimpleCollator.ExtenderType.Simple;
						case 12542:
							break;
						default:
							return SimpleCollator.ExtenderType.None;
						}
					}
					return SimpleCollator.ExtenderType.Voiced;
				}
				return SimpleCollator.ExtenderType.Simple;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004EE2 File Offset: 0x000030E2
		private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			if ((opt & CompareOptions.IgnoreNonSpace) != CompareOptions.None)
			{
				return 3;
			}
			if (ext == SimpleCollator.ExtenderType.None)
			{
				return 3;
			}
			if (ext != SimpleCollator.ExtenderType.Conditional)
			{
				return 4;
			}
			return 5;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004EFC File Offset: 0x000030FC
		private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			if (ext == SimpleCollator.ExtenderType.Conditional && MSCompatUnicodeTable.HasSpecialWeight((char)i))
			{
				bool flag = SimpleCollator.IsHalfKana((int)((ushort)i), opt);
				bool flag2 = !MSCompatUnicodeTable.IsHiragana((char)i);
				switch (this.Level1(i) & 7)
				{
				case 2:
					if (flag)
					{
						return 65393;
					}
					if (!flag2)
					{
						return 12354;
					}
					return 12450;
				case 3:
					if (flag)
					{
						return 65394;
					}
					if (!flag2)
					{
						return 12356;
					}
					return 12452;
				case 4:
					if (flag)
					{
						return 65395;
					}
					if (!flag2)
					{
						return 12358;
					}
					return 12454;
				case 5:
					if (flag)
					{
						return 65396;
					}
					if (!flag2)
					{
						return 12360;
					}
					return 12456;
				case 6:
					if (flag)
					{
						return 65397;
					}
					if (!flag2)
					{
						return 12362;
					}
					return 12458;
				}
			}
			return i;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004FD1 File Offset: 0x000031D1
		private static bool IsIgnorable(int i, CompareOptions opt)
		{
			return MSCompatUnicodeTable.IsIgnorable(i, (byte)((((opt & (CompareOptions.OrdinalIgnoreCase | CompareOptions.Ordinal)) == CompareOptions.None) ? 1 : 0) + (((opt & CompareOptions.IgnoreSymbols) != CompareOptions.None) ? 2 : 0) + (((opt & CompareOptions.IgnoreNonSpace) != CompareOptions.None) ? 4 : 0)));
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004FFB File Offset: 0x000031FB
		private bool IsSafe(int i)
		{
			return i / 8 >= this.unsafeFlags.Length || ((int)this.unsafeFlags[i / 8] & 1 << i % 8) == 0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005022 File Offset: 0x00003222
		public SortKey GetSortKey(string s, CompareOptions options)
		{
			return this.GetSortKey(s, 0, s.Length, options);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005034 File Offset: 0x00003234
		public SortKey GetSortKey(string s, int start, int length, CompareOptions options)
		{
			SortKeyBuffer sortKeyBuffer = new SortKeyBuffer(this.lcid);
			sortKeyBuffer.Initialize(options, this.lcid, s, this.frenchSort);
			int end = start + length;
			this.GetSortKey(s, start, end, sortKeyBuffer, options);
			return sortKeyBuffer.GetResultAndReset();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005078 File Offset: 0x00003278
		private unsafe void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt)
		{
			byte* ptr = stackalloc byte[(UIntPtr)4];
			this.ClearBuffer(ptr, 4);
			SimpleCollator.Context context = new SimpleCollator.Context(opt, null, null, null, null, ptr);
			for (int i = start; i < end; i++)
			{
				int num = (int)s[i];
				SimpleCollator.ExtenderType extenderType = this.GetExtenderType(num);
				if (extenderType != SimpleCollator.ExtenderType.None)
				{
					num = this.FilterExtender(context.PrevCode, extenderType, opt);
					if (num >= 0)
					{
						this.FillSortKeyRaw(num, extenderType, buf, opt);
					}
					else if (context.PrevSortKey != null)
					{
						byte* prevSortKey = context.PrevSortKey;
						buf.AppendNormal(*prevSortKey, prevSortKey[1], (prevSortKey[2] != 1) ? prevSortKey[2] : this.Level2(num, extenderType), (prevSortKey[3] != 1) ? prevSortKey[3] : MSCompatUnicodeTable.Level3(num));
					}
				}
				else if (!SimpleCollator.IsIgnorable(num, opt))
				{
					num = this.FilterOptions(num, opt);
					Contraction contraction = this.GetContraction(s, i, end);
					if (contraction != null)
					{
						if (contraction.Replacement != null)
						{
							this.GetSortKey(contraction.Replacement, 0, contraction.Replacement.Length, buf, opt);
						}
						else
						{
							byte* prevSortKey2 = context.PrevSortKey;
							for (int j = 0; j < contraction.SortKey.Length; j++)
							{
								prevSortKey2[j] = contraction.SortKey[j];
							}
							buf.AppendNormal(*prevSortKey2, prevSortKey2[1], (prevSortKey2[2] != 1) ? prevSortKey2[2] : this.Level2(num, extenderType), (prevSortKey2[3] != 1) ? prevSortKey2[3] : MSCompatUnicodeTable.Level3(num));
							context.PrevCode = -1;
						}
						i += contraction.Source.Length - 1;
					}
					else
					{
						if (!MSCompatUnicodeTable.IsIgnorableNonSpacing(num))
						{
							context.PrevCode = num;
						}
						this.FillSortKeyRaw(num, SimpleCollator.ExtenderType.None, buf, opt);
					}
				}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000523C File Offset: 0x0000343C
		private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt)
		{
			if (13312 <= i && i <= 19893)
			{
				int num = i - 13312;
				buf.AppendCJKExtension((byte)(16 + num / 254), (byte)(num % 254 + 2));
				return;
			}
			UnicodeCategory unicodeCategory = char.GetUnicodeCategory((char)i);
			if (unicodeCategory == UnicodeCategory.Surrogate)
			{
				this.FillSurrogateSortKeyRaw(i, buf);
				return;
			}
			if (unicodeCategory == UnicodeCategory.PrivateUse)
			{
				int num2 = i - 57344;
				buf.AppendNormal((byte)(229 + num2 / 254), (byte)(num2 % 254 + 2), 0, 0);
				return;
			}
			byte lv = this.Level2(i, ext);
			if (MSCompatUnicodeTable.HasSpecialWeight((char)i))
			{
				byte lv2 = this.Level1(i);
				buf.AppendKana(this.Category(i), lv2, lv, MSCompatUnicodeTable.Level3(i), MSCompatUnicodeTable.IsJapaneseSmallLetter((char)i), SimpleCollator.ToDashTypeValue(ext, opt), !MSCompatUnicodeTable.IsHiragana((char)i), SimpleCollator.IsHalfKana((int)((ushort)i), opt));
				if ((opt & CompareOptions.IgnoreNonSpace) == CompareOptions.None && ext == SimpleCollator.ExtenderType.Voiced)
				{
					buf.AppendNormal(1, 1, 1, 0);
					return;
				}
			}
			else
			{
				buf.AppendNormal(this.Category(i), this.Level1(i), lv, MSCompatUnicodeTable.Level3(i));
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005344 File Offset: 0x00003544
		private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
		{
			int num;
			int num2;
			byte b;
			if (i < 55360)
			{
				num = 55296;
				num2 = 65;
				b = ((i == 55296) ? 62 : 63);
			}
			else if (55360 <= i && i < 55424)
			{
				num = 55360;
				num2 = 242;
				b = 62;
			}
			else if (56192 <= i && i < 56320)
			{
				num = 56128;
				num2 = 254;
				b = 62;
			}
			else
			{
				num = 56074;
				num2 = 65;
				b = 63;
			}
			int num3 = i - num;
			buf.AppendNormal((byte)(num2 + num3 / 254), (byte)(num3 % 254 + 2), b, b);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000053E8 File Offset: 0x000035E8
		int ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			return this.Compare(s1, idx1, len1, s2, idx2, len2, options);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000053FC File Offset: 0x000035FC
		internal unsafe int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			byte* ptr = stackalloc byte[(UIntPtr)4];
			byte* ptr2 = stackalloc byte[(UIntPtr)4];
			this.ClearBuffer(ptr, 4);
			this.ClearBuffer(ptr2, 4);
			SimpleCollator.Context context = new SimpleCollator.Context(options, null, null, ptr, ptr2, null);
			bool flag;
			bool flag2;
			int num = this.CompareInternal(s1, idx1, len1, s2, idx2, len2, out flag, out flag2, true, false, ref context);
			if (num == 0)
			{
				return 0;
			}
			if (num >= 0)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000545C File Offset: 0x0000365C
		private unsafe void ClearBuffer(byte* buffer, int size)
		{
			for (int i = 0; i < size; i++)
			{
				buffer[i] = 0;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000547C File Offset: 0x0000367C
		private unsafe int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx)
		{
			CompareOptions option = ctx.Option;
			int num = idx1;
			int num2 = idx2;
			int num3 = idx1 + len1;
			int num4 = idx2 + len2;
			targetConsumed = false;
			sourceConsumed = false;
			SimpleCollator.PreviousInfo previousInfo = new SimpleCollator.PreviousInfo(false);
			int num5 = 0;
			int num6 = 5;
			int num7 = -1;
			int num8 = -1;
			int num9 = 0;
			int num10 = 0;
			if (skipHeadingExtenders)
			{
				while (idx1 < num3)
				{
					if (this.GetExtenderType((int)s1[idx1]) == SimpleCollator.ExtenderType.None)
					{
						IL_71:
						while (idx2 < num4 && this.GetExtenderType((int)s2[idx2]) != SimpleCollator.ExtenderType.None)
						{
							idx2++;
						}
						goto IL_77;
					}
					idx1++;
				}
				goto IL_71;
			}
			IL_77:
			SimpleCollator.ExtenderType extenderType = SimpleCollator.ExtenderType.None;
			SimpleCollator.ExtenderType extenderType2 = SimpleCollator.ExtenderType.None;
			int num11 = idx1;
			int num12 = idx2;
			bool flag = (option & CompareOptions.StringSort) > CompareOptions.None;
			bool flag2 = (option & CompareOptions.IgnoreNonSpace) > CompareOptions.None;
			SimpleCollator.Escape escape = default(SimpleCollator.Escape);
			SimpleCollator.Escape escape2 = default(SimpleCollator.Escape);
			int num20;
			for (;;)
			{
				if (idx1 < num3)
				{
					if (SimpleCollator.IsIgnorable((int)s1[idx1], option))
					{
						idx1++;
						continue;
					}
				}
				while (idx2 < num4 && SimpleCollator.IsIgnorable((int)s2[idx2], option))
				{
					idx2++;
				}
				if (idx1 >= num3)
				{
					if (escape.Source == null)
					{
						goto IL_882;
					}
					s1 = escape.Source;
					num = escape.Start;
					idx1 = escape.Index;
					num3 = escape.End;
					num11 = escape.Optional;
					escape.Source = null;
				}
				else if (idx2 >= num4)
				{
					if (escape2.Source == null)
					{
						goto IL_882;
					}
					s2 = escape2.Source;
					num2 = escape2.Start;
					idx2 = escape2.Index;
					num4 = escape2.End;
					num12 = escape2.Optional;
					escape2.Source = null;
				}
				else
				{
					if (num11 < idx1 && num12 < idx2)
					{
						while (idx1 < num3 && idx2 < num4 && s1[idx1] == s2[idx2])
						{
							idx1++;
							idx2++;
						}
						if (idx1 != num3 && idx2 != num4)
						{
							int num13 = num11;
							int num14 = num12;
							num11 = idx1;
							num12 = idx2;
							idx1--;
							idx2--;
							while (idx1 > num13)
							{
								if (this.Category((int)s1[idx1]) != 1)
								{
									IL_20B:
									while (idx2 > num14)
									{
										if (this.Category((int)s2[idx2]) != 1)
										{
											IL_227:
											while (idx1 > num13)
											{
												if (this.IsSafe((int)s1[idx1]))
												{
													IL_245:
													while (idx2 > num14 && !this.IsSafe((int)s2[idx2]))
													{
														idx2--;
													}
													goto IL_24B;
												}
												idx1--;
											}
											goto IL_245;
										}
										idx2--;
									}
									goto IL_227;
								}
								idx1--;
							}
							goto IL_20B;
						}
						continue;
					}
					IL_24B:
					int num15 = idx1;
					int num16 = idx2;
					byte* ptr = null;
					byte* ptr2 = null;
					int num17 = this.FilterOptions((int)s1[idx1], option);
					int num18 = this.FilterOptions((int)s2[idx2], option);
					bool flag3 = false;
					bool flag4 = false;
					extenderType = this.GetExtenderType(num17);
					if (extenderType != SimpleCollator.ExtenderType.None)
					{
						if (ctx.PrevCode < 0)
						{
							if (ctx.PrevSortKey == null)
							{
								idx1++;
								continue;
							}
							ptr = ctx.PrevSortKey;
						}
						else
						{
							num17 = this.FilterExtender(ctx.PrevCode, extenderType, option);
						}
					}
					extenderType2 = this.GetExtenderType(num18);
					if (extenderType2 != SimpleCollator.ExtenderType.None)
					{
						if (previousInfo.Code < 0)
						{
							if (previousInfo.SortKey == null)
							{
								idx2++;
								continue;
							}
							ptr2 = previousInfo.SortKey;
						}
						else
						{
							num18 = this.FilterExtender(previousInfo.Code, extenderType2, option);
						}
					}
					byte b = this.Category(num17);
					byte b2 = this.Category(num18);
					if (b == 6)
					{
						if (!flag && num6 == 5)
						{
							num7 = ((escape.Source != null) ? (escape.Index - escape.Start) : (num15 - num));
							num9 = (int)this.Level1(num17) << (int)(8 + MSCompatUnicodeTable.Level3(num17));
						}
						ctx.PrevCode = num17;
						idx1++;
					}
					if (b2 == 6)
					{
						if (!flag && num6 == 5)
						{
							num8 = ((escape2.Source != null) ? (escape2.Index - escape2.Start) : (num16 - num2));
							num10 = (int)this.Level1(num18) << (int)(8 + MSCompatUnicodeTable.Level3(num18));
						}
						previousInfo.Code = num18;
						idx2++;
					}
					if (b == 6 || b2 == 6)
					{
						if (num6 == 5)
						{
							if (num9 == num10)
							{
								num8 = (num7 = -1);
								num10 = (num9 = 0);
							}
							else
							{
								num6 = 4;
							}
						}
					}
					else
					{
						Contraction contraction = null;
						if (extenderType == SimpleCollator.ExtenderType.None)
						{
							contraction = this.GetContraction(s1, idx1, num3);
						}
						int num19 = 1;
						if (ptr != null)
						{
							num19 = 1;
						}
						else if (contraction != null)
						{
							num19 = contraction.Source.Length;
							if (contraction.SortKey != null)
							{
								ptr = ctx.Buffer1;
								for (int i = 0; i < contraction.SortKey.Length; i++)
								{
									ptr[i] = contraction.SortKey[i];
								}
								ctx.PrevCode = -1;
								ctx.PrevSortKey = ptr;
							}
							else if (escape.Source == null)
							{
								escape.Source = s1;
								escape.Start = num;
								escape.Index = num15 + contraction.Source.Length;
								escape.End = num3;
								escape.Optional = num11;
								s1 = contraction.Replacement;
								idx1 = 0;
								num = 0;
								num3 = s1.Length;
								num11 = 0;
								continue;
							}
						}
						else
						{
							ptr = ctx.Buffer1;
							*ptr = b;
							ptr[1] = this.Level1(num17);
							if (!flag2 && num6 > 1)
							{
								ptr[2] = this.Level2(num17, extenderType);
							}
							if (num6 > 2)
							{
								ptr[3] = MSCompatUnicodeTable.Level3(num17);
							}
							if (num6 > 3)
							{
								flag3 = MSCompatUnicodeTable.HasSpecialWeight((char)num17);
							}
							if (b > 1)
							{
								ctx.PrevCode = num17;
							}
						}
						Contraction contraction2 = null;
						if (extenderType2 == SimpleCollator.ExtenderType.None)
						{
							contraction2 = this.GetContraction(s2, idx2, num4);
						}
						if (ptr2 != null)
						{
							idx2++;
						}
						else if (contraction2 != null)
						{
							idx2 += contraction2.Source.Length;
							if (contraction2.SortKey != null)
							{
								ptr2 = ctx.Buffer2;
								for (int j = 0; j < contraction2.SortKey.Length; j++)
								{
									ptr2[j] = contraction2.SortKey[j];
								}
								previousInfo.Code = -1;
								previousInfo.SortKey = ptr2;
							}
							else if (escape2.Source == null)
							{
								escape2.Source = s2;
								escape2.Start = num2;
								escape2.Index = num16 + contraction2.Source.Length;
								escape2.End = num4;
								escape2.Optional = num12;
								s2 = contraction2.Replacement;
								idx2 = 0;
								num2 = 0;
								num4 = s2.Length;
								num12 = 0;
								continue;
							}
						}
						else
						{
							ptr2 = ctx.Buffer2;
							*ptr2 = b2;
							ptr2[1] = this.Level1(num18);
							if (!flag2 && num6 > 1)
							{
								ptr2[2] = this.Level2(num18, extenderType2);
							}
							if (num6 > 2)
							{
								ptr2[3] = MSCompatUnicodeTable.Level3(num18);
							}
							if (num6 > 3)
							{
								flag4 = MSCompatUnicodeTable.HasSpecialWeight((char)num18);
							}
							if (b2 > 1)
							{
								previousInfo.Code = num18;
							}
							idx2++;
						}
						idx1 += num19;
						if (!flag2)
						{
							while (idx1 < num3)
							{
								if (this.Category((int)s1[idx1]) != 1)
								{
									IL_72B:
									while (idx2 < num4 && this.Category((int)s2[idx2]) == 1)
									{
										if (ptr2[2] == 0)
										{
											ptr2[2] = 2;
										}
										ptr2[2] = ptr2[2] + this.Level2((int)s2[idx2], SimpleCollator.ExtenderType.None);
										idx2++;
									}
									goto IL_731;
								}
								if (ptr[2] == 0)
								{
									ptr[2] = 2;
								}
								ptr[2] = ptr[2] + this.Level2((int)s1[idx1], SimpleCollator.ExtenderType.None);
								idx1++;
							}
							goto IL_72B;
						}
						IL_731:
						num20 = (int)(*ptr - *ptr2);
						num20 = ((num20 != 0) ? num20 : ((int)(ptr[1] - ptr2[1])));
						if (num20 != 0)
						{
							break;
						}
						if (num6 != 1)
						{
							if (!flag2)
							{
								num20 = (int)(ptr[2] - ptr2[2]);
								if (num20 != 0)
								{
									num5 = num20;
									if (immediateBreakup)
									{
										return -1;
									}
									num6 = (this.frenchSort ? 2 : 1);
									continue;
								}
							}
							if (num6 != 2)
							{
								num20 = (int)(ptr[3] - ptr2[3]);
								if (num20 != 0)
								{
									num5 = num20;
									if (immediateBreakup)
									{
										return -1;
									}
									num6 = 2;
								}
								else if (num6 != 3)
								{
									if (flag3 != flag4)
									{
										if (immediateBreakup)
										{
											return -1;
										}
										num5 = (flag3 ? 1 : -1);
										num6 = 3;
									}
									else if (flag3)
									{
										num20 = this.CompareFlagPair(!MSCompatUnicodeTable.IsJapaneseSmallLetter((char)num17), !MSCompatUnicodeTable.IsJapaneseSmallLetter((char)num18));
										num20 = ((num20 != 0) ? num20 : ((int)(SimpleCollator.ToDashTypeValue(extenderType, option) - SimpleCollator.ToDashTypeValue(extenderType2, option))));
										num20 = ((num20 != 0) ? num20 : this.CompareFlagPair(MSCompatUnicodeTable.IsHiragana((char)num17), MSCompatUnicodeTable.IsHiragana((char)num18)));
										num20 = ((num20 != 0) ? num20 : this.CompareFlagPair(!SimpleCollator.IsHalfKana((int)((ushort)num17), option), !SimpleCollator.IsHalfKana((int)((ushort)num18), option)));
										if (num20 != 0)
										{
											if (immediateBreakup)
											{
												return -1;
											}
											num5 = num20;
											num6 = 3;
										}
									}
								}
							}
						}
					}
				}
			}
			return num20;
			IL_882:
			if (!flag2 && num5 != 0 && num6 > 2)
			{
				while (idx1 < num3 && idx2 < num4 && MSCompatUnicodeTable.IsIgnorableNonSpacing((int)s1[idx1]) && MSCompatUnicodeTable.IsIgnorableNonSpacing((int)s2[idx2]))
				{
					num5 = (int)(this.Level2(this.FilterOptions((int)s1[idx1], option), extenderType) - this.Level2(this.FilterOptions((int)s2[idx2], option), extenderType2));
					if (num5 != 0)
					{
						break;
					}
					idx1++;
					idx2++;
					extenderType = SimpleCollator.ExtenderType.None;
					extenderType2 = SimpleCollator.ExtenderType.None;
				}
			}
			if (num6 == 1 && num5 != 0)
			{
				while (idx1 < num3)
				{
					if (!MSCompatUnicodeTable.IsIgnorableNonSpacing((int)s1[idx1]))
					{
						IL_939:
						while (idx2 < num4 && MSCompatUnicodeTable.IsIgnorableNonSpacing((int)s2[idx2]))
						{
							idx2++;
						}
						goto IL_93F;
					}
					idx1++;
				}
				goto IL_939;
			}
			IL_93F:
			if (num5 == 0)
			{
				if (num7 < 0 && num8 >= 0)
				{
					num5 = -1;
				}
				else if (num8 < 0 && num7 >= 0)
				{
					num5 = 1;
				}
				else
				{
					num5 = num7 - num8;
					if (num5 == 0)
					{
						num5 = num9 - num10;
					}
				}
			}
			if (num5 == 0)
			{
				if (idx2 == num4)
				{
					targetConsumed = true;
				}
				if (idx1 == num3)
				{
					sourceConsumed = true;
				}
			}
			if (idx1 != num3)
			{
				return 1;
			}
			if (idx2 != num4)
			{
				return -1;
			}
			return num5;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005E22 File Offset: 0x00004022
		private int CompareFlagPair(bool b1, bool b2)
		{
			if (b1 == b2)
			{
				return 0;
			}
			if (!b1)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005E30 File Offset: 0x00004030
		public bool IsPrefix(string src, string target, CompareOptions opt)
		{
			return this.IsPrefix(src, target, 0, src.Length, opt);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005E44 File Offset: 0x00004044
		public unsafe bool IsPrefix(string s, string target, int start, int length, CompareOptions opt)
		{
			if (target.Length == 0)
			{
				return true;
			}
			byte* ptr = stackalloc byte[(UIntPtr)4];
			byte* ptr2 = stackalloc byte[(UIntPtr)4];
			this.ClearBuffer(ptr, 4);
			this.ClearBuffer(ptr2, 4);
			SimpleCollator.Context context = new SimpleCollator.Context(opt, null, null, ptr, ptr2, null);
			return this.IsPrefix(s, target, start, length, true, ref context);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005E94 File Offset: 0x00004094
		private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx)
		{
			bool result;
			bool flag;
			this.CompareInternal(s, start, length, target, 0, target.Length, out result, out flag, skipHeadingExtenders, true, ref ctx);
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005EBE File Offset: 0x000040BE
		public bool IsSuffix(string src, string target, CompareOptions opt)
		{
			return this.IsSuffix(src, target, src.Length - 1, src.Length, opt);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005ED8 File Offset: 0x000040D8
		public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt)
		{
			if (target.Length == 0)
			{
				return true;
			}
			int num = this.LastIndexOf(s, target, start, length, opt);
			return num >= 0 && this.Compare(s, num, s.Length - num, target, 0, target.Length, opt) == 0;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005F20 File Offset: 0x00004120
		private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
		{
			int num = -1;
			int num2 = -1;
			testWasUnable = true;
			if (target.Length == 0)
			{
				return 0;
			}
			if (target.Length > length)
			{
				return -1;
			}
			testWasUnable = false;
			int num3 = start + length - target.Length + 1;
			for (int i = start; i < num3; i++)
			{
				bool flag = false;
				for (int j = 0; j < target.Length; j++)
				{
					if (num2 < j)
					{
						char c = target[j];
						if (c == '\0' || c >= '\u0080')
						{
							testWasUnable = true;
							return -1;
						}
						num2 = j;
					}
					if (num < i + j)
					{
						char c2 = s[i + j];
						if (c2 == '\0' || c2 >= '\u0080')
						{
							testWasUnable = true;
							return -1;
						}
						num = i + j;
					}
					if (s[i + j] != target[j])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005FF8 File Offset: 0x000041F8
		public unsafe int IndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			if (opt == CompareOptions.Ordinal)
			{
				throw new NotSupportedException("Should not be reached");
			}
			if (opt == CompareOptions.OrdinalIgnoreCase)
			{
				throw new NotSupportedException("Should not be reached");
			}
			if (opt == CompareOptions.None)
			{
				bool flag;
				int result = this.QuickIndexOf(s, target, start, length, out flag);
				if (!flag)
				{
					return result;
				}
			}
			byte* ptr = stackalloc byte[(UIntPtr)16];
			byte* ptr2 = stackalloc byte[(UIntPtr)16];
			byte* ptr3 = stackalloc byte[(UIntPtr)4];
			byte* ptr4 = stackalloc byte[(UIntPtr)4];
			byte* ptr5 = stackalloc byte[(UIntPtr)4];
			this.ClearBuffer(ptr, 16);
			this.ClearBuffer(ptr2, 16);
			this.ClearBuffer(ptr3, 4);
			this.ClearBuffer(ptr4, 4);
			this.ClearBuffer(ptr5, 4);
			SimpleCollator.Context context = new SimpleCollator.Context(opt, ptr, ptr2, ptr4, ptr5, null);
			return this.IndexOf(s, target, start, length, ptr3, ref context);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000060AC File Offset: 0x000042AC
		private int IndexOfOrdinal(string s, string target, int start, int length)
		{
			if (target.Length == 0)
			{
				return 0;
			}
			if (target.Length > length)
			{
				return -1;
			}
			int num = start + length - target.Length + 1;
			for (int i = start; i < num; i++)
			{
				bool flag = false;
				for (int j = 0; j < target.Length; j++)
				{
					if (s[i + j] != target[j])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00006118 File Offset: 0x00004318
		private int IndexOfOrdinal(string s, char target, int start, int length)
		{
			int num = start + length;
			for (int i = start; i < num; i++)
			{
				if (s[i] == target)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006144 File Offset: 0x00004344
		private unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			int num = start + length;
			int i = start;
			while (i < num)
			{
				int result = i;
				if (this.MatchesForward(s, ref i, num, ti, sortkey, noLv4, ref ctx))
				{
					return result;
				}
			}
			return -1;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006178 File Offset: 0x00004378
		private unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			CompareOptions option = ctx.Option;
			int num = 0;
			while (num < target.Length && SimpleCollator.IsIgnorable((int)target[num], option))
			{
				num++;
			}
			if (num != target.Length)
			{
				Contraction contraction = this.GetContraction(target, num, target.Length - num);
				string text = (contraction != null) ? contraction.Replacement : null;
				byte* ptr = (text == null) ? targetSortKey : null;
				bool noLv = true;
				char target2 = '\0';
				int num2 = -1;
				if (contraction != null && ptr != null)
				{
					for (int i = 0; i < contraction.SortKey.Length; i++)
					{
						ptr[i] = contraction.SortKey[i];
					}
				}
				else if (ptr != null)
				{
					target2 = target[num];
					num2 = this.FilterOptions((int)target[num], option);
					*ptr = this.Category(num2);
					ptr[1] = this.Level1(num2);
					if ((option & CompareOptions.IgnoreNonSpace) == CompareOptions.None)
					{
						ptr[2] = this.Level2(num2, SimpleCollator.ExtenderType.None);
					}
					ptr[3] = MSCompatUnicodeTable.Level3(num2);
					noLv = !MSCompatUnicodeTable.HasSpecialWeight((char)num2);
				}
				if (ptr != null)
				{
					num++;
					while (num < target.Length && this.Category((int)target[num]) == 1)
					{
						if (ptr[2] == 0)
						{
							ptr[2] = 2;
						}
						ptr[2] = ptr[2] + this.Level2((int)target[num], SimpleCollator.ExtenderType.None);
						num++;
					}
				}
				for (;;)
				{
					int num3;
					if (text != null)
					{
						num3 = this.IndexOf(s, text, start, length, targetSortKey, ref ctx);
					}
					else
					{
						num3 = this.IndexOfSortKey(s, start, length, ptr, target2, num2, noLv, ref ctx);
					}
					if (num3 < 0)
					{
						break;
					}
					length -= num3 - start;
					start = num3;
					if (this.IsPrefix(s, target, start, length, false, ref ctx))
					{
						return num3;
					}
					Contraction contraction2 = this.GetContraction(s, start, length);
					if (contraction2 != null)
					{
						start += contraction2.Source.Length;
						length -= contraction2.Source.Length;
					}
					else
					{
						start++;
						length--;
					}
					if (length <= 0)
					{
						return -1;
					}
				}
				return -1;
			}
			if (this.IndexOfOrdinal(target, '\0', 0, target.Length) < 0)
			{
				return start;
			}
			return this.IndexOfOrdinal(s, target, start, length);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006384 File Offset: 0x00004584
		public unsafe int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			if (opt == CompareOptions.Ordinal)
			{
				throw new NotSupportedException("Should not be reached");
			}
			if (opt == CompareOptions.OrdinalIgnoreCase)
			{
				throw new NotSupportedException("Should not be reached");
			}
			byte* ptr = stackalloc byte[(UIntPtr)16];
			byte* ptr2 = stackalloc byte[(UIntPtr)16];
			byte* ptr3 = stackalloc byte[(UIntPtr)4];
			byte* ptr4 = stackalloc byte[(UIntPtr)4];
			byte* ptr5 = stackalloc byte[(UIntPtr)4];
			this.ClearBuffer(ptr, 16);
			this.ClearBuffer(ptr2, 16);
			this.ClearBuffer(ptr3, 4);
			this.ClearBuffer(ptr4, 4);
			this.ClearBuffer(ptr5, 4);
			SimpleCollator.Context context = new SimpleCollator.Context(opt, ptr, ptr2, ptr4, ptr5, null);
			return this.LastIndexOf(s, target, start, length, ptr3, ref context);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006420 File Offset: 0x00004620
		private int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			if (target.Length == 0)
			{
				return start;
			}
			if (s.Length < target.Length || target.Length > length)
			{
				return -1;
			}
			int num = start - length + target.Length - 1;
			char c = target[target.Length - 1];
			int i = start;
			while (i > num)
			{
				if (s[i] != c)
				{
					i--;
				}
				else
				{
					int num2 = i - target.Length + 1;
					i--;
					bool flag = false;
					for (int j = target.Length - 2; j >= 0; j--)
					{
						if (s[num2 + j] != target[j])
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						return num2;
					}
				}
			}
			return -1;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000064D0 File Offset: 0x000046D0
		private unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			int num = start - length;
			int i = start;
			while (i > num)
			{
				int result = i;
				if (this.MatchesBackward(s, ref i, num, orgStart, ti, sortkey, noLv4, ref ctx))
				{
					return result;
				}
			}
			return -1;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00006504 File Offset: 0x00004704
		private unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			CompareOptions option = ctx.Option;
			int num = start;
			int num2 = 0;
			while (num2 < target.Length && SimpleCollator.IsIgnorable((int)target[num2], option))
			{
				num2++;
			}
			if (num2 != target.Length)
			{
				Contraction contraction = this.GetContraction(target, num2, target.Length - num2);
				string text = (contraction != null) ? contraction.Replacement : null;
				byte* ptr = (text == null) ? targetSortKey : null;
				bool noLv = true;
				int num3 = -1;
				if (contraction != null && ptr != null)
				{
					for (int i = 0; i < contraction.SortKey.Length; i++)
					{
						ptr[i] = contraction.SortKey[i];
					}
				}
				else if (ptr != null)
				{
					num3 = this.FilterOptions((int)target[num2], option);
					*ptr = this.Category(num3);
					ptr[1] = this.Level1(num3);
					if ((option & CompareOptions.IgnoreNonSpace) == CompareOptions.None)
					{
						ptr[2] = this.Level2(num3, SimpleCollator.ExtenderType.None);
					}
					ptr[3] = MSCompatUnicodeTable.Level3(num3);
					noLv = !MSCompatUnicodeTable.HasSpecialWeight((char)num3);
				}
				if (ptr != null)
				{
					num2++;
					while (num2 < target.Length && this.Category((int)target[num2]) == 1)
					{
						if (ptr[2] == 0)
						{
							ptr[2] = 2;
						}
						ptr[2] = ptr[2] + this.Level2((int)target[num2], SimpleCollator.ExtenderType.None);
						num2++;
					}
				}
				int num4;
				for (;;)
				{
					if (text != null)
					{
						num4 = this.LastIndexOf(s, text, start, length, targetSortKey, ref ctx);
					}
					else
					{
						num4 = this.LastIndexOfSortKey(s, start, num, length, ptr, num3, noLv, ref ctx);
					}
					if (num4 < 0)
					{
						break;
					}
					length -= start - num4;
					start = num4;
					if (this.IsPrefix(s, target, num4, num - num4 + 1, false, ref ctx))
					{
						goto Block_16;
					}
					Contraction contraction2 = this.GetContraction(s, num4, num - num4 + 1);
					if (contraction2 != null)
					{
						start -= contraction2.Source.Length;
						length -= contraction2.Source.Length;
					}
					else
					{
						start--;
						length--;
					}
					if (length <= 0)
					{
						return -1;
					}
				}
				return -1;
				Block_16:
				while (num4 < num && SimpleCollator.IsIgnorable((int)s[num4], option))
				{
					num4++;
				}
				return num4;
			}
			if (this.IndexOfOrdinal(target, '\0', 0, target.Length) < 0)
			{
				return start;
			}
			return this.LastIndexOfOrdinal(s, target, start, length);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00006730 File Offset: 0x00004930
		private unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			int num = (int)s[idx];
			if (ctx.AlwaysMatchFlags != null && num < 128 && ((int)ctx.AlwaysMatchFlags[num / 8] & 1 << num % 8) != 0)
			{
				return true;
			}
			if (ctx.NeverMatchFlags != null && num < 128 && ((int)ctx.NeverMatchFlags[num / 8] & 1 << num % 8) != 0)
			{
				idx++;
				return false;
			}
			SimpleCollator.ExtenderType extenderType = this.GetExtenderType((int)s[idx]);
			Contraction contraction = null;
			if (this.MatchesForwardCore(s, ref idx, end, ti, sortkey, noLv4, extenderType, ref contraction, ref ctx))
			{
				if (ctx.AlwaysMatchFlags != null && contraction == null && extenderType == SimpleCollator.ExtenderType.None && num < 128)
				{
					byte* ptr = ctx.AlwaysMatchFlags + num / 8;
					*ptr |= (byte)(1 << num % 8);
				}
				return true;
			}
			if (ctx.NeverMatchFlags != null && contraction == null && extenderType == SimpleCollator.ExtenderType.None && num < 128)
			{
				byte* ptr2 = ctx.NeverMatchFlags + num / 8;
				*ptr2 |= (byte)(1 << num % 8);
			}
			return false;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006834 File Offset: 0x00004A34
		private unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			CompareOptions option = ctx.Option;
			byte* ptr = ctx.Buffer1;
			bool flag = (option & CompareOptions.IgnoreNonSpace) > CompareOptions.None;
			int num = -1;
			if (ext == SimpleCollator.ExtenderType.None)
			{
				ct = this.GetContraction(s, idx, end);
			}
			else if (ctx.PrevCode < 0)
			{
				if (ctx.PrevSortKey == null)
				{
					idx++;
					return false;
				}
				ptr = ctx.PrevSortKey;
			}
			else
			{
				num = this.FilterExtender(ctx.PrevCode, ext, option);
			}
			if (ct != null)
			{
				idx += ct.Source.Length;
				if (!noLv4)
				{
					return false;
				}
				if (ct.SortKey == null)
				{
					int num2 = 0;
					return this.MatchesForward(ct.Replacement, ref num2, ct.Replacement.Length, ti, sortkey, noLv4, ref ctx);
				}
				for (int i = 0; i < 4; i++)
				{
					ptr[i] = sortkey[i];
				}
				ctx.PrevCode = -1;
				ctx.PrevSortKey = ptr;
			}
			else
			{
				if (num < 0)
				{
					num = this.FilterOptions((int)s[idx], option);
				}
				idx++;
				*ptr = this.Category(num);
				bool flag2 = false;
				if (*sortkey == *ptr)
				{
					ptr[1] = this.Level1(num);
				}
				else
				{
					flag2 = true;
				}
				if (!flag && sortkey[1] == ptr[1])
				{
					ptr[2] = this.Level2(num, ext);
				}
				else if (!flag)
				{
					flag2 = true;
				}
				if (flag2)
				{
					while (idx < end && this.Category((int)s[idx]) == 1)
					{
						idx++;
					}
					return false;
				}
				ptr[3] = MSCompatUnicodeTable.Level3(num);
				if (*ptr != 1)
				{
					ctx.PrevCode = num;
				}
			}
			while (idx < end && this.Category((int)s[idx]) == 1)
			{
				if (!flag)
				{
					if (ptr[2] == 0)
					{
						ptr[2] = 2;
					}
					ptr[2] = ptr[2] + this.Level2((int)s[idx], SimpleCollator.ExtenderType.None);
				}
				idx++;
			}
			return this.MatchesPrimitive(option, ptr, num, ext, sortkey, ti, noLv4);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006A14 File Offset: 0x00004C14
		private unsafe bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4)
		{
			bool flag = (opt & CompareOptions.IgnoreNonSpace) > CompareOptions.None;
			return *source == *target && source[1] == target[1] && (flag || source[2] == target[2]) && source[3] == target[3] && ((noLv4 && (si < 0 || !MSCompatUnicodeTable.HasSpecialWeight((char)si))) || (!noLv4 && (flag || ext != SimpleCollator.ExtenderType.Conditional) && MSCompatUnicodeTable.IsJapaneseSmallLetter((char)si) == MSCompatUnicodeTable.IsJapaneseSmallLetter((char)ti) && SimpleCollator.ToDashTypeValue(ext, opt) == SimpleCollator.ToDashTypeValue(SimpleCollator.ExtenderType.None, opt) && !MSCompatUnicodeTable.IsHiragana((char)si) == !MSCompatUnicodeTable.IsHiragana((char)ti) && SimpleCollator.IsHalfKana((int)((ushort)si), opt) == SimpleCollator.IsHalfKana((int)((ushort)ti), opt)));
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00006AC8 File Offset: 0x00004CC8
		private unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			int num = (int)s[idx];
			if (ctx.AlwaysMatchFlags != null && num < 128 && ((int)ctx.AlwaysMatchFlags[num / 8] & 1 << num % 8) != 0)
			{
				return true;
			}
			if (ctx.NeverMatchFlags != null && num < 128 && ((int)ctx.NeverMatchFlags[num / 8] & 1 << num % 8) != 0)
			{
				idx--;
				return false;
			}
			SimpleCollator.ExtenderType extenderType = this.GetExtenderType((int)s[idx]);
			Contraction contraction = null;
			if (this.MatchesBackwardCore(s, ref idx, end, orgStart, ti, sortkey, noLv4, extenderType, ref contraction, ref ctx))
			{
				if (ctx.AlwaysMatchFlags != null && contraction == null && extenderType == SimpleCollator.ExtenderType.None && num < 128)
				{
					byte* ptr = ctx.AlwaysMatchFlags + num / 8;
					*ptr |= (byte)(1 << num % 8);
				}
				return true;
			}
			if (ctx.NeverMatchFlags != null && contraction == null && extenderType == SimpleCollator.ExtenderType.None && num < 128)
			{
				byte* ptr2 = ctx.NeverMatchFlags + num / 8;
				*ptr2 |= (byte)(1 << num % 8);
			}
			return false;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00006BCC File Offset: 0x00004DCC
		private unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			CompareOptions option = ctx.Option;
			byte* buffer = ctx.Buffer1;
			bool flag = (option & CompareOptions.IgnoreNonSpace) > CompareOptions.None;
			int num = idx;
			int num2 = -1;
			if (ext != SimpleCollator.ExtenderType.None)
			{
				byte b = 0;
				for (int i = idx; i >= 0; i--)
				{
					if (!SimpleCollator.IsIgnorable((int)s[i], option))
					{
						int num3 = this.FilterOptions((int)s[i], option);
						byte b2 = this.Category(num3);
						if (b2 != 1)
						{
							num2 = this.FilterExtender(num3, ext, option);
							*buffer = b2;
							buffer[1] = this.Level1(num2);
							if (!flag)
							{
								buffer[2] = this.Level2(num2, ext);
							}
							buffer[3] = MSCompatUnicodeTable.Level3(num2);
							if (ext != SimpleCollator.ExtenderType.Conditional && b != 0)
							{
								buffer[2] = ((buffer[2] == 0) ? (b + 2) : b);
							}
							idx--;
							goto IL_DA;
						}
						b = this.Level2(num3, SimpleCollator.ExtenderType.None);
					}
				}
				return false;
			}
			IL_DA:
			if (ext == SimpleCollator.ExtenderType.None)
			{
				ct = this.GetTailContraction(s, idx, end);
			}
			if (ct != null)
			{
				idx -= ct.Source.Length;
				if (!noLv4)
				{
					return false;
				}
				if (ct.SortKey == null)
				{
					int num4 = ct.Replacement.Length - 1;
					return 0 <= this.LastIndexOfSortKey(ct.Replacement, num4, num4, ct.Replacement.Length, sortkey, ti, noLv4, ref ctx);
				}
				for (int j = 0; j < 4; j++)
				{
					buffer[j] = sortkey[j];
				}
				ctx.PrevCode = -1;
				ctx.PrevSortKey = buffer;
			}
			else if (ext == SimpleCollator.ExtenderType.None)
			{
				if (num2 < 0)
				{
					num2 = this.FilterOptions((int)s[idx], option);
				}
				idx--;
				bool flag2 = false;
				*buffer = this.Category(num2);
				if (*buffer == *sortkey)
				{
					buffer[1] = this.Level1(num2);
				}
				else
				{
					flag2 = true;
				}
				if (!flag && buffer[1] == sortkey[1])
				{
					buffer[2] = this.Level2(num2, ext);
				}
				else if (!flag)
				{
					flag2 = true;
				}
				if (flag2)
				{
					return false;
				}
				buffer[3] = MSCompatUnicodeTable.Level3(num2);
				if (*buffer != 1)
				{
					ctx.PrevCode = num2;
				}
			}
			if (ext == SimpleCollator.ExtenderType.None)
			{
				int num5 = num + 1;
				while (num5 < orgStart && this.Category((int)s[num5]) == 1)
				{
					if (!flag)
					{
						if (buffer[2] == 0)
						{
							buffer[2] = 2;
						}
						buffer[2] = buffer[2] + this.Level2((int)s[num5], SimpleCollator.ExtenderType.None);
					}
					num5++;
				}
			}
			return this.MatchesPrimitive(option, buffer, num2, ext, sortkey, ti, noLv4);
		}

		// Token: 0x04000106 RID: 262
		private static SimpleCollator invariant = new SimpleCollator(CultureInfo.InvariantCulture);

		// Token: 0x04000107 RID: 263
		private readonly TextInfo textInfo;

		// Token: 0x04000108 RID: 264
		private readonly CodePointIndexer cjkIndexer;

		// Token: 0x04000109 RID: 265
		private readonly Contraction[] contractions;

		// Token: 0x0400010A RID: 266
		private readonly Level2Map[] level2Maps;

		// Token: 0x0400010B RID: 267
		private readonly byte[] unsafeFlags;

		// Token: 0x0400010C RID: 268
		private unsafe readonly byte* cjkCatTable;

		// Token: 0x0400010D RID: 269
		private unsafe readonly byte* cjkLv1Table;

		// Token: 0x0400010E RID: 270
		private unsafe readonly byte* cjkLv2Table;

		// Token: 0x0400010F RID: 271
		private readonly CodePointIndexer cjkLv2Indexer;

		// Token: 0x04000110 RID: 272
		private readonly int lcid;

		// Token: 0x04000111 RID: 273
		private readonly bool frenchSort;

		// Token: 0x0200003D RID: 61
		internal struct Context
		{
			// Token: 0x060000F7 RID: 247 RVA: 0x00006E57 File Offset: 0x00005057
			public unsafe Context(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
				this.Option = opt;
				this.AlwaysMatchFlags = alwaysMatchFlags;
				this.NeverMatchFlags = neverMatchFlags;
				this.Buffer1 = buffer1;
				this.Buffer2 = buffer2;
				this.PrevSortKey = prev1;
				this.PrevCode = -1;
			}

			// Token: 0x04000112 RID: 274
			public readonly CompareOptions Option;

			// Token: 0x04000113 RID: 275
			public unsafe readonly byte* NeverMatchFlags;

			// Token: 0x04000114 RID: 276
			public unsafe readonly byte* AlwaysMatchFlags;

			// Token: 0x04000115 RID: 277
			public unsafe byte* Buffer1;

			// Token: 0x04000116 RID: 278
			public unsafe byte* Buffer2;

			// Token: 0x04000117 RID: 279
			public int PrevCode;

			// Token: 0x04000118 RID: 280
			public unsafe byte* PrevSortKey;
		}

		// Token: 0x0200003E RID: 62
		private struct PreviousInfo
		{
			// Token: 0x060000F8 RID: 248 RVA: 0x00006E8D File Offset: 0x0000508D
			public PreviousInfo(bool dummy)
			{
				this.Code = -1;
				this.SortKey = null;
			}

			// Token: 0x04000119 RID: 281
			public int Code;

			// Token: 0x0400011A RID: 282
			public unsafe byte* SortKey;
		}

		// Token: 0x0200003F RID: 63
		private struct Escape
		{
			// Token: 0x0400011B RID: 283
			public string Source;

			// Token: 0x0400011C RID: 284
			public int Index;

			// Token: 0x0400011D RID: 285
			public int Start;

			// Token: 0x0400011E RID: 286
			public int End;

			// Token: 0x0400011F RID: 287
			public int Optional;
		}

		// Token: 0x02000040 RID: 64
		private enum ExtenderType
		{
			// Token: 0x04000121 RID: 289
			None,
			// Token: 0x04000122 RID: 290
			Simple,
			// Token: 0x04000123 RID: 291
			Voiced,
			// Token: 0x04000124 RID: 292
			Conditional,
			// Token: 0x04000125 RID: 293
			Buggy
		}
	}
}
