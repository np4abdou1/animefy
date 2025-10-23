using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000A6 RID: 166
	internal sealed class RegexCharClass
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x000175F4 File Offset: 0x000157F4
		public RegexCharClass()
		{
			this._rangelist = new List<RegexCharClass.SingleRange>(6);
			this._canonical = true;
			this._categories = new StringBuilder();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001761A File Offset: 0x0001581A
		private RegexCharClass(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
		{
			this._rangelist = ranges;
			this._categories = categories;
			this._canonical = true;
			this._negate = negate;
			this._subtractor = subtraction;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00017646 File Offset: 0x00015846
		public bool CanMerge
		{
			get
			{
				return !this._negate && this._subtractor == null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x0001765B File Offset: 0x0001585B
		public bool Negate
		{
			set
			{
				this._negate = value;
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00017664 File Offset: 0x00015864
		public void AddChar(char c)
		{
			this.AddRange(c, c);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00017670 File Offset: 0x00015870
		public void AddCharClass(RegexCharClass cc)
		{
			if (!cc._canonical)
			{
				this._canonical = false;
			}
			else if (this._canonical && this.RangeCount() > 0 && cc.RangeCount() > 0 && cc.GetRangeAt(0).First <= this.GetRangeAt(this.RangeCount() - 1).Last)
			{
				this._canonical = false;
			}
			for (int i = 0; i < cc.RangeCount(); i++)
			{
				this._rangelist.Add(cc.GetRangeAt(i));
			}
			this._categories.Append(cc._categories.ToString());
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001770C File Offset: 0x0001590C
		private void AddSet(string set)
		{
			if (this._canonical && this.RangeCount() > 0 && set.Length > 0 && set[0] <= this.GetRangeAt(this.RangeCount() - 1).Last)
			{
				this._canonical = false;
			}
			int i;
			for (i = 0; i < set.Length - 1; i += 2)
			{
				this._rangelist.Add(new RegexCharClass.SingleRange(set[i], set[i + 1] - '\u0001'));
			}
			if (i < set.Length)
			{
				this._rangelist.Add(new RegexCharClass.SingleRange(set[i], char.MaxValue));
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000177B1 File Offset: 0x000159B1
		public void AddSubtraction(RegexCharClass sub)
		{
			this._subtractor = sub;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000177BC File Offset: 0x000159BC
		public void AddRange(char first, char last)
		{
			this._rangelist.Add(new RegexCharClass.SingleRange(first, last));
			if (this._canonical && this._rangelist.Count > 0 && first <= this._rangelist[this._rangelist.Count - 1].Last)
			{
				this._canonical = false;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00017818 File Offset: 0x00015A18
		public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
		{
			string text;
			if (RegexCharClass.s_definedCategories.TryGetValue(categoryName, out text) && !categoryName.Equals(RegexCharClass.s_internalRegexIgnoreCase))
			{
				if (caseInsensitive && (categoryName.Equals("Ll") || categoryName.Equals("Lu") || categoryName.Equals("Lt")))
				{
					text = RegexCharClass.s_definedCategories[RegexCharClass.s_internalRegexIgnoreCase];
				}
				if (invert)
				{
					text = RegexCharClass.NegateCategory(text);
				}
				this._categories.Append(text);
				return;
			}
			this.AddSet(RegexCharClass.SetFromProperty(categoryName, invert, pattern));
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000178A2 File Offset: 0x00015AA2
		private void AddCategory(string category)
		{
			this._categories.Append(category);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000178B4 File Offset: 0x00015AB4
		public void AddLowercase(CultureInfo culture)
		{
			this._canonical = false;
			int count = this._rangelist.Count;
			for (int i = 0; i < count; i++)
			{
				RegexCharClass.SingleRange singleRange = this._rangelist[i];
				if (singleRange.First == singleRange.Last)
				{
					char c = culture.TextInfo.ToLower(singleRange.First);
					this._rangelist[i] = new RegexCharClass.SingleRange(c, c);
				}
				else
				{
					this.AddLowercaseRange(singleRange.First, singleRange.Last, culture);
				}
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00017938 File Offset: 0x00015B38
		private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
		{
			int i = 0;
			int num = RegexCharClass.s_lcTable.Length;
			while (i < num)
			{
				int num2 = (i + num) / 2;
				if (RegexCharClass.s_lcTable[num2].ChMax < chMin)
				{
					i = num2 + 1;
				}
				else
				{
					num = num2;
				}
			}
			if (i >= RegexCharClass.s_lcTable.Length)
			{
				return;
			}
			RegexCharClass.LowerCaseMapping lowerCaseMapping;
			while (i < RegexCharClass.s_lcTable.Length && (lowerCaseMapping = RegexCharClass.s_lcTable[i]).ChMin <= chMax)
			{
				char c;
				if ((c = lowerCaseMapping.ChMin) < chMin)
				{
					c = chMin;
				}
				char c2;
				if ((c2 = lowerCaseMapping.ChMax) > chMax)
				{
					c2 = chMax;
				}
				switch (lowerCaseMapping.LcOp)
				{
				case 0:
					c = (char)lowerCaseMapping.Data;
					c2 = (char)lowerCaseMapping.Data;
					break;
				case 1:
					c += (char)lowerCaseMapping.Data;
					c2 += (char)lowerCaseMapping.Data;
					break;
				case 2:
					c |= '\u0001';
					c2 |= '\u0001';
					break;
				case 3:
					c += (c & '\u0001');
					c2 += (c2 & '\u0001');
					break;
				}
				if (c < chMin || c2 > chMax)
				{
					this.AddRange(c, c2);
				}
				i++;
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00017A4F File Offset: 0x00015C4F
		public void AddWord(bool ecma, bool negate)
		{
			if (negate)
			{
				if (ecma)
				{
					this.AddSet("\00:A[_`a{İı");
					return;
				}
				this.AddCategory(RegexCharClass.s_notWord);
				return;
			}
			else
			{
				if (ecma)
				{
					this.AddSet("0:A[_`a{İı");
					return;
				}
				this.AddCategory(RegexCharClass.s_word);
				return;
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00017A89 File Offset: 0x00015C89
		public void AddSpace(bool ecma, bool negate)
		{
			if (negate)
			{
				if (ecma)
				{
					this.AddSet("\0\t\u000e !");
					return;
				}
				this.AddCategory(RegexCharClass.s_notSpace);
				return;
			}
			else
			{
				if (ecma)
				{
					this.AddSet("\t\u000e !");
					return;
				}
				this.AddCategory(RegexCharClass.s_space);
				return;
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00017AC3 File Offset: 0x00015CC3
		public void AddDigit(bool ecma, bool negate, string pattern)
		{
			if (!ecma)
			{
				this.AddCategoryFromName("Nd", negate, false, pattern);
				return;
			}
			if (negate)
			{
				this.AddSet("\00:");
				return;
			}
			this.AddSet("0:");
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00017AF1 File Offset: 0x00015CF1
		public static char SingletonChar(string set)
		{
			return set[3];
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00017AFA File Offset: 0x00015CFA
		public static bool IsMergeable(string charClass)
		{
			return !RegexCharClass.IsNegated(charClass) && !RegexCharClass.IsSubtraction(charClass);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00017B0F File Offset: 0x00015D0F
		public static bool IsEmpty(string charClass)
		{
			return charClass[2] == '\0' && charClass[0] == '\0' && charClass[1] == '\0' && !RegexCharClass.IsSubtraction(charClass);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00017B38 File Offset: 0x00015D38
		public static bool IsSingleton(string set)
		{
			return set[0] == '\0' && set[2] == '\0' && set[1] == '\u0002' && !RegexCharClass.IsSubtraction(set) && (set[3] == char.MaxValue || set[3] + '\u0001' == set[4]);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00017B8C File Offset: 0x00015D8C
		public static bool IsSingletonInverse(string set)
		{
			return set[0] == '\u0001' && set[2] == '\0' && set[1] == '\u0002' && !RegexCharClass.IsSubtraction(set) && (set[3] == char.MaxValue || set[3] + '\u0001' == set[4]);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00017BE1 File Offset: 0x00015DE1
		private static bool IsSubtraction(string charClass)
		{
			return charClass.Length > (int)('\u0003' + charClass[1] + charClass[2]);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00017BFC File Offset: 0x00015DFC
		private static bool IsNegated(string set)
		{
			return set != null && set[0] == '\u0001';
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00017C0D File Offset: 0x00015E0D
		public static bool IsECMAWordChar(char ch)
		{
			return RegexCharClass.CharInClass(ch, "\0\n\00:A[_`a{İı");
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00017C1A File Offset: 0x00015E1A
		public static bool IsWordChar(char ch)
		{
			return RegexCharClass.CharInClass(ch, RegexCharClass.WordClass) || ch == '‍' || ch == '‌';
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00017C3B File Offset: 0x00015E3B
		public static bool CharInClass(char ch, string set)
		{
			return RegexCharClass.CharInClassRecursive(ch, set, 0);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00017C48 File Offset: 0x00015E48
		private static bool CharInClassRecursive(char ch, string set, int start)
		{
			int num = (int)set[start + 1];
			int num2 = (int)set[start + 2];
			int num3 = start + 3 + num + num2;
			bool flag = false;
			if (set.Length > num3)
			{
				flag = RegexCharClass.CharInClassRecursive(ch, set, num3);
			}
			bool flag2 = RegexCharClass.CharInClassInternal(ch, set, start, num, num2);
			if (set[start] == '\u0001')
			{
				flag2 = !flag2;
			}
			return flag2 && !flag;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00017CAC File Offset: 0x00015EAC
		private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			int num = start + 3;
			int num2 = num + mySetLength;
			while (num != num2)
			{
				int num3 = (num + num2) / 2;
				if (ch < set[num3])
				{
					num2 = num3;
				}
				else
				{
					num = num3 + 1;
				}
			}
			return (num & 1) == (start & 1) || (myCategoryLength != 0 && RegexCharClass.CharInCategory(ch, set, start, mySetLength, myCategoryLength));
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00017CFC File Offset: 0x00015EFC
		private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(ch);
			int i = start + 3 + mySetLength;
			int num = i + myCategoryLength;
			while (i < num)
			{
				int num2 = (int)((short)set[i]);
				if (num2 == 0)
				{
					if (RegexCharClass.CharInCategoryGroup(ch, unicodeCategory, set, ref i))
					{
						return true;
					}
				}
				else if (num2 > 0)
				{
					if (num2 == 100)
					{
						if (char.IsWhiteSpace(ch))
						{
							return true;
						}
						i++;
						continue;
					}
					else
					{
						num2--;
						if (unicodeCategory == (UnicodeCategory)num2)
						{
							return true;
						}
					}
				}
				else if (num2 == -100)
				{
					if (!char.IsWhiteSpace(ch))
					{
						return true;
					}
					i++;
					continue;
				}
				else
				{
					num2 = -1 - num2;
					if (unicodeCategory != (UnicodeCategory)num2)
					{
						return true;
					}
				}
				i++;
			}
			return false;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00017D84 File Offset: 0x00015F84
		private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
		{
			i++;
			int num = (int)((short)category[i]);
			if (num > 0)
			{
				bool flag = false;
				while (num != 0)
				{
					if (!flag)
					{
						num--;
						if (chcategory == (UnicodeCategory)num)
						{
							flag = true;
						}
					}
					i++;
					num = (int)((short)category[i]);
				}
				return flag;
			}
			bool flag2 = true;
			while (num != 0)
			{
				if (flag2)
				{
					num = -1 - num;
					if (chcategory == (UnicodeCategory)num)
					{
						flag2 = false;
					}
				}
				i++;
				num = (int)((short)category[i]);
			}
			return flag2;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00017DF0 File Offset: 0x00015FF0
		private static string NegateCategory(string category)
		{
			if (category == null)
			{
				return null;
			}
			StringBuilder stringBuilder = StringBuilderCache.Acquire(category.Length);
			foreach (short num in category)
			{
				stringBuilder.Append((char)(-(char)num));
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00017E38 File Offset: 0x00016038
		public static RegexCharClass Parse(string charClass)
		{
			return RegexCharClass.ParseRecursive(charClass, 0);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00017E44 File Offset: 0x00016044
		private static RegexCharClass ParseRecursive(string charClass, int start)
		{
			int num = (int)charClass[start + 1];
			int num2 = (int)charClass[start + 2];
			int num3 = start + 3 + num + num2;
			List<RegexCharClass.SingleRange> list = new List<RegexCharClass.SingleRange>(num);
			int i = start + 3;
			int num4 = i + num;
			while (i < num4)
			{
				char first = charClass[i];
				i++;
				char last;
				if (i < num4)
				{
					last = charClass[i] - '\u0001';
				}
				else
				{
					last = char.MaxValue;
				}
				i++;
				list.Add(new RegexCharClass.SingleRange(first, last));
			}
			RegexCharClass subtraction = null;
			if (charClass.Length > num3)
			{
				subtraction = RegexCharClass.ParseRecursive(charClass, num3);
			}
			return new RegexCharClass(charClass[start] == '\u0001', list, new StringBuilder(charClass.Substring(num4, num2)), subtraction);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00017EFD File Offset: 0x000160FD
		private int RangeCount()
		{
			return this._rangelist.Count;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00017F0C File Offset: 0x0001610C
		public string ToStringClass()
		{
			if (!this._canonical)
			{
				this.Canonicalize();
			}
			int num = this._rangelist.Count * 2;
			StringBuilder stringBuilder = StringBuilderCache.Acquire(num + this._categories.Length + 3);
			int num2;
			if (this._negate)
			{
				num2 = 1;
			}
			else
			{
				num2 = 0;
			}
			stringBuilder.Append((char)num2);
			stringBuilder.Append((char)num);
			stringBuilder.Append((char)this._categories.Length);
			for (int i = 0; i < this._rangelist.Count; i++)
			{
				RegexCharClass.SingleRange singleRange = this._rangelist[i];
				stringBuilder.Append(singleRange.First);
				if (singleRange.Last != '￿')
				{
					stringBuilder.Append(singleRange.Last + '\u0001');
				}
			}
			stringBuilder[1] = (char)(stringBuilder.Length - 3);
			stringBuilder.Append(this._categories);
			if (this._subtractor != null)
			{
				stringBuilder.Append(this._subtractor.ToStringClass());
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001800B File Offset: 0x0001620B
		private RegexCharClass.SingleRange GetRangeAt(int i)
		{
			return this._rangelist[i];
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001801C File Offset: 0x0001621C
		private void Canonicalize()
		{
			this._canonical = true;
			this._rangelist.Sort(RegexCharClass.SingleRangeComparer.Instance);
			if (this._rangelist.Count > 1)
			{
				bool flag = false;
				int num = 1;
				int num2 = 0;
				for (;;)
				{
					IL_2F:
					char last = this._rangelist[num2].Last;
					while (num != this._rangelist.Count && last != '￿')
					{
						RegexCharClass.SingleRange singleRange;
						if ((singleRange = this._rangelist[num]).First <= last + '\u0001')
						{
							if (last < singleRange.Last)
							{
								last = singleRange.Last;
							}
							num++;
						}
						else
						{
							IL_8A:
							this._rangelist[num2] = new RegexCharClass.SingleRange(this._rangelist[num2].First, last);
							num2++;
							if (!flag)
							{
								if (num2 < num)
								{
									this._rangelist[num2] = this._rangelist[num];
								}
								num++;
								goto IL_2F;
							}
							goto IL_DA;
						}
					}
					flag = true;
					goto IL_8A;
				}
				IL_DA:
				this._rangelist.RemoveRange(num2, this._rangelist.Count - num2);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001811C File Offset: 0x0001631C
		private static string SetFromProperty(string capname, bool invert, string pattern)
		{
			int num = 0;
			int num2 = RegexCharClass.s_propTable.Length;
			while (num != num2)
			{
				int num3 = (num + num2) / 2;
				int num4 = string.Compare(capname, RegexCharClass.s_propTable[num3][0], StringComparison.Ordinal);
				if (num4 < 0)
				{
					num2 = num3;
				}
				else if (num4 > 0)
				{
					num = num3 + 1;
				}
				else
				{
					string text = RegexCharClass.s_propTable[num3][1];
					if (!invert)
					{
						return text;
					}
					if (text[0] == '\0')
					{
						return text.Substring(1);
					}
					return "\0" + text;
				}
			}
			throw new ArgumentException(SR.Format("parsing \"{0}\" - {1}", pattern, SR.Format("Unknown property '{0}'.", capname)));
		}

		// Token: 0x040002DF RID: 735
		private static readonly string s_internalRegexIgnoreCase = "__InternalRegexIgnoreCase__";

		// Token: 0x040002E0 RID: 736
		private static readonly string s_space = "d";

		// Token: 0x040002E1 RID: 737
		private static readonly string s_notSpace = "ﾜ";

		// Token: 0x040002E2 RID: 738
		private static readonly string s_word = "\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0";

		// Token: 0x040002E3 RID: 739
		private static readonly string s_notWord = "\0￾￼￻�￿￺￷￭\0";

		// Token: 0x040002E4 RID: 740
		public static readonly string SpaceClass = "\0\0\u0001d";

		// Token: 0x040002E5 RID: 741
		public static readonly string NotSpaceClass = "\u0001\0\u0001d";

		// Token: 0x040002E6 RID: 742
		public static readonly string WordClass = "\0\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0";

		// Token: 0x040002E7 RID: 743
		public static readonly string NotWordClass = "\u0001\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0";

		// Token: 0x040002E8 RID: 744
		public static readonly string DigitClass = "\0\0\u0001\t";

		// Token: 0x040002E9 RID: 745
		public static readonly string NotDigitClass = "\0\0\u0001￷";

		// Token: 0x040002EA RID: 746
		private static readonly Dictionary<string, string> s_definedCategories = new Dictionary<string, string>(38)
		{
			{
				"Cc",
				"\u000f"
			},
			{
				"Cf",
				"\u0010"
			},
			{
				"Cn",
				"\u001e"
			},
			{
				"Co",
				"\u0012"
			},
			{
				"Cs",
				"\u0011"
			},
			{
				"C",
				"\0\u000f\u0010\u001e\u0012\u0011\0"
			},
			{
				"Ll",
				"\u0002"
			},
			{
				"Lm",
				"\u0004"
			},
			{
				"Lo",
				"\u0005"
			},
			{
				"Lt",
				"\u0003"
			},
			{
				"Lu",
				"\u0001"
			},
			{
				"L",
				"\0\u0002\u0004\u0005\u0003\u0001\0"
			},
			{
				"__InternalRegexIgnoreCase__",
				"\0\u0002\u0003\u0001\0"
			},
			{
				"Mc",
				"\a"
			},
			{
				"Me",
				"\b"
			},
			{
				"Mn",
				"\u0006"
			},
			{
				"M",
				"\0\a\b\u0006\0"
			},
			{
				"Nd",
				"\t"
			},
			{
				"Nl",
				"\n"
			},
			{
				"No",
				"\v"
			},
			{
				"N",
				"\0\t\n\v\0"
			},
			{
				"Pc",
				"\u0013"
			},
			{
				"Pd",
				"\u0014"
			},
			{
				"Pe",
				"\u0016"
			},
			{
				"Po",
				"\u0019"
			},
			{
				"Ps",
				"\u0015"
			},
			{
				"Pf",
				"\u0018"
			},
			{
				"Pi",
				"\u0017"
			},
			{
				"P",
				"\0\u0013\u0014\u0016\u0019\u0015\u0018\u0017\0"
			},
			{
				"Sc",
				"\u001b"
			},
			{
				"Sk",
				"\u001c"
			},
			{
				"Sm",
				"\u001a"
			},
			{
				"So",
				"\u001d"
			},
			{
				"S",
				"\0\u001b\u001c\u001a\u001d\0"
			},
			{
				"Zl",
				"\r"
			},
			{
				"Zp",
				"\u000e"
			},
			{
				"Zs",
				"\f"
			},
			{
				"Z",
				"\0\r\u000e\f\0"
			}
		};

		// Token: 0x040002EB RID: 747
		private static readonly string[][] s_propTable = new string[][]
		{
			new string[]
			{
				"IsAlphabeticPresentationForms",
				"ﬀﭐ"
			},
			new string[]
			{
				"IsArabic",
				"؀܀"
			},
			new string[]
			{
				"IsArabicPresentationForms-A",
				"ﭐ︀"
			},
			new string[]
			{
				"IsArabicPresentationForms-B",
				"ﹰ＀"
			},
			new string[]
			{
				"IsArmenian",
				"԰֐"
			},
			new string[]
			{
				"IsArrows",
				"←∀"
			},
			new string[]
			{
				"IsBasicLatin",
				"\0\u0080"
			},
			new string[]
			{
				"IsBengali",
				"ঀ਀"
			},
			new string[]
			{
				"IsBlockElements",
				"▀■"
			},
			new string[]
			{
				"IsBopomofo",
				"㄀㄰"
			},
			new string[]
			{
				"IsBopomofoExtended",
				"ㆠ㇀"
			},
			new string[]
			{
				"IsBoxDrawing",
				"─▀"
			},
			new string[]
			{
				"IsBraillePatterns",
				"⠀⤀"
			},
			new string[]
			{
				"IsBuhid",
				"ᝀᝠ"
			},
			new string[]
			{
				"IsCJKCompatibility",
				"㌀㐀"
			},
			new string[]
			{
				"IsCJKCompatibilityForms",
				"︰﹐"
			},
			new string[]
			{
				"IsCJKCompatibilityIdeographs",
				"豈ﬀ"
			},
			new string[]
			{
				"IsCJKRadicalsSupplement",
				"⺀⼀"
			},
			new string[]
			{
				"IsCJKSymbolsandPunctuation",
				"\u3000぀"
			},
			new string[]
			{
				"IsCJKUnifiedIdeographs",
				"一ꀀ"
			},
			new string[]
			{
				"IsCJKUnifiedIdeographsExtensionA",
				"㐀䷀"
			},
			new string[]
			{
				"IsCherokee",
				"Ꭰ᐀"
			},
			new string[]
			{
				"IsCombiningDiacriticalMarks",
				"̀Ͱ"
			},
			new string[]
			{
				"IsCombiningDiacriticalMarksforSymbols",
				"⃐℀"
			},
			new string[]
			{
				"IsCombiningHalfMarks",
				"︠︰"
			},
			new string[]
			{
				"IsCombiningMarksforSymbols",
				"⃐℀"
			},
			new string[]
			{
				"IsControlPictures",
				"␀⑀"
			},
			new string[]
			{
				"IsCurrencySymbols",
				"₠⃐"
			},
			new string[]
			{
				"IsCyrillic",
				"ЀԀ"
			},
			new string[]
			{
				"IsCyrillicSupplement",
				"Ԁ԰"
			},
			new string[]
			{
				"IsDevanagari",
				"ऀঀ"
			},
			new string[]
			{
				"IsDingbats",
				"✀⟀"
			},
			new string[]
			{
				"IsEnclosedAlphanumerics",
				"①─"
			},
			new string[]
			{
				"IsEnclosedCJKLettersandMonths",
				"㈀㌀"
			},
			new string[]
			{
				"IsEthiopic",
				"ሀᎀ"
			},
			new string[]
			{
				"IsGeneralPunctuation",
				"\u2000⁰"
			},
			new string[]
			{
				"IsGeometricShapes",
				"■☀"
			},
			new string[]
			{
				"IsGeorgian",
				"Ⴀᄀ"
			},
			new string[]
			{
				"IsGreek",
				"ͰЀ"
			},
			new string[]
			{
				"IsGreekExtended",
				"ἀ\u2000"
			},
			new string[]
			{
				"IsGreekandCoptic",
				"ͰЀ"
			},
			new string[]
			{
				"IsGujarati",
				"઀଀"
			},
			new string[]
			{
				"IsGurmukhi",
				"਀઀"
			},
			new string[]
			{
				"IsHalfwidthandFullwidthForms",
				"＀￰"
			},
			new string[]
			{
				"IsHangulCompatibilityJamo",
				"㄰㆐"
			},
			new string[]
			{
				"IsHangulJamo",
				"ᄀሀ"
			},
			new string[]
			{
				"IsHangulSyllables",
				"가ힰ"
			},
			new string[]
			{
				"IsHanunoo",
				"ᜠᝀ"
			},
			new string[]
			{
				"IsHebrew",
				"֐؀"
			},
			new string[]
			{
				"IsHighPrivateUseSurrogates",
				"\udb80\udc00"
			},
			new string[]
			{
				"IsHighSurrogates",
				"\ud800\udb80"
			},
			new string[]
			{
				"IsHiragana",
				"぀゠"
			},
			new string[]
			{
				"IsIPAExtensions",
				"ɐʰ"
			},
			new string[]
			{
				"IsIdeographicDescriptionCharacters",
				"⿰\u3000"
			},
			new string[]
			{
				"IsKanbun",
				"㆐ㆠ"
			},
			new string[]
			{
				"IsKangxiRadicals",
				"⼀⿠"
			},
			new string[]
			{
				"IsKannada",
				"ಀഀ"
			},
			new string[]
			{
				"IsKatakana",
				"゠㄀"
			},
			new string[]
			{
				"IsKatakanaPhoneticExtensions",
				"ㇰ㈀"
			},
			new string[]
			{
				"IsKhmer",
				"ក᠀"
			},
			new string[]
			{
				"IsKhmerSymbols",
				"᧠ᨀ"
			},
			new string[]
			{
				"IsLao",
				"຀ༀ"
			},
			new string[]
			{
				"IsLatin-1Supplement",
				"\u0080Ā"
			},
			new string[]
			{
				"IsLatinExtended-A",
				"Āƀ"
			},
			new string[]
			{
				"IsLatinExtended-B",
				"ƀɐ"
			},
			new string[]
			{
				"IsLatinExtendedAdditional",
				"Ḁἀ"
			},
			new string[]
			{
				"IsLetterlikeSymbols",
				"℀⅐"
			},
			new string[]
			{
				"IsLimbu",
				"ᤀᥐ"
			},
			new string[]
			{
				"IsLowSurrogates",
				"\udc00"
			},
			new string[]
			{
				"IsMalayalam",
				"ഀ඀"
			},
			new string[]
			{
				"IsMathematicalOperators",
				"∀⌀"
			},
			new string[]
			{
				"IsMiscellaneousMathematicalSymbols-A",
				"⟀⟰"
			},
			new string[]
			{
				"IsMiscellaneousMathematicalSymbols-B",
				"⦀⨀"
			},
			new string[]
			{
				"IsMiscellaneousSymbols",
				"☀✀"
			},
			new string[]
			{
				"IsMiscellaneousSymbolsandArrows",
				"⬀Ⰰ"
			},
			new string[]
			{
				"IsMiscellaneousTechnical",
				"⌀␀"
			},
			new string[]
			{
				"IsMongolian",
				"᠀ᢰ"
			},
			new string[]
			{
				"IsMyanmar",
				"ကႠ"
			},
			new string[]
			{
				"IsNumberForms",
				"⅐←"
			},
			new string[]
			{
				"IsOgham",
				"\u1680ᚠ"
			},
			new string[]
			{
				"IsOpticalCharacterRecognition",
				"⑀①"
			},
			new string[]
			{
				"IsOriya",
				"଀஀"
			},
			new string[]
			{
				"IsPhoneticExtensions",
				"ᴀᶀ"
			},
			new string[]
			{
				"IsPrivateUse",
				"豈"
			},
			new string[]
			{
				"IsPrivateUseArea",
				"豈"
			},
			new string[]
			{
				"IsRunic",
				"ᚠᜀ"
			},
			new string[]
			{
				"IsSinhala",
				"඀฀"
			},
			new string[]
			{
				"IsSmallFormVariants",
				"﹐ﹰ"
			},
			new string[]
			{
				"IsSpacingModifierLetters",
				"ʰ̀"
			},
			new string[]
			{
				"IsSpecials",
				"￰"
			},
			new string[]
			{
				"IsSuperscriptsandSubscripts",
				"⁰₠"
			},
			new string[]
			{
				"IsSupplementalArrows-A",
				"⟰⠀"
			},
			new string[]
			{
				"IsSupplementalArrows-B",
				"⤀⦀"
			},
			new string[]
			{
				"IsSupplementalMathematicalOperators",
				"⨀⬀"
			},
			new string[]
			{
				"IsSyriac",
				"܀ݐ"
			},
			new string[]
			{
				"IsTagalog",
				"ᜀᜠ"
			},
			new string[]
			{
				"IsTagbanwa",
				"ᝠក"
			},
			new string[]
			{
				"IsTaiLe",
				"ᥐᦀ"
			},
			new string[]
			{
				"IsTamil",
				"஀ఀ"
			},
			new string[]
			{
				"IsTelugu",
				"ఀಀ"
			},
			new string[]
			{
				"IsThaana",
				"ހ߀"
			},
			new string[]
			{
				"IsThai",
				"฀຀"
			},
			new string[]
			{
				"IsTibetan",
				"ༀက"
			},
			new string[]
			{
				"IsUnifiedCanadianAboriginalSyllabics",
				"᐀\u1680"
			},
			new string[]
			{
				"IsVariationSelectors",
				"︀︐"
			},
			new string[]
			{
				"IsYiRadicals",
				"꒐ꓐ"
			},
			new string[]
			{
				"IsYiSyllables",
				"ꀀ꒐"
			},
			new string[]
			{
				"IsYijingHexagramSymbols",
				"䷀一"
			},
			new string[]
			{
				"_xmlC",
				"-/0;A[_`a{·¸À×Ø÷øĲĴĿŁŉŊſƀǄǍǱǴǶǺȘɐʩʻ˂ː˒̀͆͢͠Ά΋Ό΍Ύ΢ΣϏϐϗϚϛϜϝϞϟϠϡϢϴЁЍЎѐёѝў҂҃҇ҐӅӇӉӋӍӐӬӮӶӸӺԱ՗ՙ՚աևֺֻ֑֢֣־ֿ׀ׁ׃ׅׄא׫װ׳ءػـٓ٠٪ٰڸںڿۀۏې۔ە۩۪ۮ۰ۺँऄअऺ़ॎ॑ॕक़।०॰ঁ঄অ঍এ঑ও঩প঱ল঳শ঺়ঽা৅ে৉োৎৗ৘ড়৞য়৤০৲ਂਃਅ਋ਏ਑ਓ਩ਪ਱ਲ਴ਵ਷ਸ਺਼਽ਾ੃ੇ੉ੋ੎ਖ਼੝ਫ਼੟੦ੵઁ઄અઌઍ઎એ઒ઓ઩પ઱લ઴વ઺઼૆ે૊ો૎ૠૡ૦૰ଁ଄ଅ଍ଏ଑ଓ଩ପ଱ଲ଴ଶ଺଼ୄେ୉ୋ୎ୖ୘ଡ଼୞ୟୢ୦୰ஂ஄அ஋எ஑ஒ஖ங஛ஜ஝ஞ஠ண஥ந஫மஶஷ஺ா௃ெ௉ொ௎ௗ௘௧௰ఁఄఅ఍ఎ఑ఒ఩పఴవ఺ా౅ె౉ొ౎ౕ౗ౠౢ౦౰ಂ಄ಅ಍ಎ಑ಒ಩ಪ಴ವ಺ಾ೅ೆ೉ೊ೎ೕ೗ೞ೟ೠೢ೦೰ംഄഅ഍എ഑ഒഩപഺാൄെ൉ൊൎൗ൘ൠൢ൦൰กฯะ฻เ๏๐๚ກ຃ຄ຅ງຉຊ຋ຍຎດຘນຠມ຤ລ຦ວຨສຬອຯະ຺ົ຾ເ໅ໆ໇່໎໐໚༘༚༠༪༵༶༷༸༹༺༾཈ཉཪཱ྅྆ྌྐྖྗ྘ྙྮྱྸྐྵྺႠ჆აჷᄀᄁᄂᄄᄅᄈᄉᄊᄋᄍᄎᄓᄼᄽᄾᄿᅀᅁᅌᅍᅎᅏᅐᅑᅔᅖᅙᅚᅟᅢᅣᅤᅥᅦᅧᅨᅩᅪᅭᅯᅲᅴᅵᅶᆞᆟᆨᆩᆫᆬᆮᆰᆷᆹᆺᆻᆼᇃᇫᇬᇰᇱᇹᇺḀẜẠỺἀ἖Ἐ἞ἠ὆Ὀ὎ὐ὘Ὑ὚Ὓ὜Ὕ὞Ὗ὾ᾀ᾵ᾶ᾽ι᾿ῂ῅ῆ῍ῐ῔ῖ῜ῠ῭ῲ῵ῶ´⃐⃝⃡⃢Ω℧Kℬ℮ℯↀↃ々〆〇〈〡〰〱〶ぁゕ゙゛ゝゟァ・ーヿㄅㄭ一龦가힤"
			},
			new string[]
			{
				"_xmlD",
				"0:٠٪۰ۺ०॰০ৰ੦ੰ૦૰୦୰௧௰౦౰೦೰൦൰๐๚໐໚༠༪၀၊፩፲០៪᠐᠚０："
			},
			new string[]
			{
				"_xmlI",
				":;A[_`a{À×Ø÷øĲĴĿŁŉŊſƀǄǍǱǴǶǺȘɐʩʻ˂Ά·Έ΋Ό΍Ύ΢ΣϏϐϗϚϛϜϝϞϟϠϡϢϴЁЍЎѐёѝў҂ҐӅӇӉӋӍӐӬӮӶӸӺԱ՗ՙ՚աևא׫װ׳ءػفًٱڸںڿۀۏې۔ەۖۥۧअऺऽाक़ॢঅ঍এ঑ও঩প঱ল঳শ঺ড়৞য়ৢৰ৲ਅ਋ਏ਑ਓ਩ਪ਱ਲ਴ਵ਷ਸ਺ਖ਼੝ਫ਼੟ੲੵઅઌઍ઎એ઒ઓ઩પ઱લ઴વ઺ઽાૠૡଅ଍ଏ଑ଓ଩ପ଱ଲ଴ଶ଺ଽାଡ଼୞ୟୢஅ஋எ஑ஒ஖ங஛ஜ஝ஞ஠ண஥ந஫மஶஷ஺అ఍ఎ఑ఒ఩పఴవ఺ౠౢಅ಍ಎ಑ಒ಩ಪ಴ವ಺ೞ೟ೠೢഅ഍എ഑ഒഩപഺൠൢกฯะัาิเๆກ຃ຄ຅ງຉຊ຋ຍຎດຘນຠມ຤ລ຦ວຨສຬອຯະັາິຽ຾ເ໅ཀ཈ཉཪႠ჆აჷᄀᄁᄂᄄᄅᄈᄉᄊᄋᄍᄎᄓᄼᄽᄾᄿᅀᅁᅌᅍᅎᅏᅐᅑᅔᅖᅙᅚᅟᅢᅣᅤᅥᅦᅧᅨᅩᅪᅭᅯᅲᅴᅵᅶᆞᆟᆨᆩᆫᆬᆮᆰᆷᆹᆺᆻᆼᇃᇫᇬᇰᇱᇹᇺḀẜẠỺἀ἖Ἐ἞ἠ὆Ὀ὎ὐ὘Ὑ὚Ὓ὜Ὕ὞Ὗ὾ᾀ᾵ᾶ᾽ι᾿ῂ῅ῆ῍ῐ῔ῖ῜ῠ῭ῲ῵ῶ´Ω℧Kℬ℮ℯↀↃ〇〈〡〪ぁゕァ・ㄅㄭ一龦가힤"
			},
			new string[]
			{
				"_xmlW",
				"$%+,0:<?A[^_`{|}~\u007f¢«¬­®·¸»¼¿ÀȡȢȴɐʮʰ˯̀͐͠ͰʹͶͺͻ΄·Έ΋Ό΍Ύ΢ΣϏϐϷЀ҇҈ӏӐӶӸӺԀԐԱ՗ՙ՚աֈֺֻ֑֢֣־ֿ׀ׁ׃ׅׄא׫װ׳ءػـٖ٠٪ٮ۔ە۝۞ۮ۰ۿܐܭܰ݋ހ޲ँऄअऺ़ॎॐॕक़।०॰ঁ঄অ঍এ঑ও঩প঱ল঳শ঺়ঽা৅ে৉োৎৗ৘ড়৞য়৤০৻ਂਃਅ਋ਏ਑ਓ਩ਪ਱ਲ਴ਵ਷ਸ਺਼਽ਾ੃ੇ੉ੋ੎ਖ਼੝ਫ਼੟੦ੵઁ઄અઌઍ઎એ઒ઓ઩પ઱લ઴વ઺઼૆ે૊ો૎ૐ૑ૠૡ૦૰ଁ଄ଅ଍ଏ଑ଓ଩ପ଱ଲ଴ଶ଺଼ୄେ୉ୋ୎ୖ୘ଡ଼୞ୟୢ୦ୱஂ஄அ஋எ஑ஒ஖ங஛ஜ஝ஞ஠ண஥ந஫மஶஷ஺ா௃ெ௉ொ௎ௗ௘௧௳ఁఄఅ఍ఎ఑ఒ఩పఴవ఺ా౅ె౉ొ౎ౕ౗ౠౢ౦౰ಂ಄ಅ಍ಎ಑ಒ಩ಪ಴ವ಺ಾ೅ೆ೉ೊ೎ೕ೗ೞ೟ೠೢ೦೰ംഄഅ഍എ഑ഒഩപഺാൄെ൉ൊൎൗ൘ൠൢ൦൰ං඄අ඗ක඲ඳ඼ල඾ව෇්෋ා෕ූ෗ෘ෠ෲ෴ก฻฿๏๐๚ກ຃ຄ຅ງຉຊ຋ຍຎດຘນຠມ຤ລ຦ວຨສຬອ຺ົ຾ເ໅ໆ໇່໎໐໚ໜໞༀ༄༓༺༾཈ཉཫཱ྅྆ྌྐ྘ྙ྽྾࿍࿏࿐ကဢဣဨဩါာဳံ်၀၊ၐၚႠ჆აჹᄀᅚᅟᆣᆨᇺሀሇለቇቈ቉ቊ቎ቐ቗ቘ቙ቚ቞በኇኈ኉ኊ኎ነኯኰ኱ኲ኶ኸ኿ዀ዁ዂ዆ወዏዐ዗ዘዯደጏጐ጑ጒ጖ጘጟጠፇፈ፛፩፽ᎠᏵᐁ᙭ᙯᙷᚁ᚛ᚠ᛫ᛮᛱᜀᜍᜎ᜕ᜠ᜵ᝀ᝔ᝠ᝭ᝮ᝱ᝲ᝴ក។ៗ៘៛៝០៪᠋᠎᠐᠚ᠠᡸᢀᢪḀẜẠỺἀ἖Ἐ἞ἠ὆Ὀ὎ὐ὘Ὑ὚Ὓ὜Ὕ὞Ὗ὾ᾀ᾵ᾶ῅ῆ῔ῖ῜῝῰ῲ῵ῶ῿⁄⁅⁒⁓⁰⁲⁴⁽ⁿ₍₠₲⃫⃐℀℻ℽ⅌⅓ↄ←〈⌫⎴⎷⏏␀␧⑀⑋①⓿─☔☖☘☙♾⚀⚊✁✅✆✊✌✨✩❌❍❎❏❓❖❗❘❟❡❨❶➕➘➰➱➿⟐⟦⟰⦃⦙⧘⧜⧼⧾⬀⺀⺚⺛⻴⼀⿖⿰⿼〄〈〒〔〠〰〱〽〾぀ぁ゗゙゠ァ・ー㄀ㄅㄭㄱ㆏㆐ㆸㇰ㈝㈠㉄㉑㉼㉿㋌㋐㋿㌀㍷㍻㏞㏠㏿㐀䶶一龦ꀀ꒍꒐꓇가힤豈郞侮恵ﬀ﬇ﬓ﬘יִ﬷טּ﬽מּ﬿נּ﭂ףּ﭅צּ﮲ﯓ﴾ﵐ﶐ﶒ﷈ﷰ﷽︀︐︠︤﹢﹣﹤﹧﹩﹪ﹰ﹵ﹶ﻽＄％＋，０：＜？Ａ［＾＿｀｛｜｝～｟ｦ﾿ￂ￈ￊ￐ￒ￘ￚ￝￠￧￨￯￼￾"
			}
		};

		// Token: 0x040002EC RID: 748
		private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable = new RegexCharClass.LowerCaseMapping[]
		{
			new RegexCharClass.LowerCaseMapping('A', 'Z', 1, 32),
			new RegexCharClass.LowerCaseMapping('À', 'Þ', 1, 32),
			new RegexCharClass.LowerCaseMapping('Ā', 'Į', 2, 0),
			new RegexCharClass.LowerCaseMapping('İ', 'İ', 0, 105),
			new RegexCharClass.LowerCaseMapping('Ĳ', 'Ķ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ĺ', 'Ň', 3, 0),
			new RegexCharClass.LowerCaseMapping('Ŋ', 'Ŷ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ÿ', 'Ÿ', 0, 255),
			new RegexCharClass.LowerCaseMapping('Ź', 'Ž', 3, 0),
			new RegexCharClass.LowerCaseMapping('Ɓ', 'Ɓ', 0, 595),
			new RegexCharClass.LowerCaseMapping('Ƃ', 'Ƅ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ɔ', 'Ɔ', 0, 596),
			new RegexCharClass.LowerCaseMapping('Ƈ', 'Ƈ', 0, 392),
			new RegexCharClass.LowerCaseMapping('Ɖ', 'Ɗ', 1, 205),
			new RegexCharClass.LowerCaseMapping('Ƌ', 'Ƌ', 0, 396),
			new RegexCharClass.LowerCaseMapping('Ǝ', 'Ǝ', 0, 477),
			new RegexCharClass.LowerCaseMapping('Ə', 'Ə', 0, 601),
			new RegexCharClass.LowerCaseMapping('Ɛ', 'Ɛ', 0, 603),
			new RegexCharClass.LowerCaseMapping('Ƒ', 'Ƒ', 0, 402),
			new RegexCharClass.LowerCaseMapping('Ɠ', 'Ɠ', 0, 608),
			new RegexCharClass.LowerCaseMapping('Ɣ', 'Ɣ', 0, 611),
			new RegexCharClass.LowerCaseMapping('Ɩ', 'Ɩ', 0, 617),
			new RegexCharClass.LowerCaseMapping('Ɨ', 'Ɨ', 0, 616),
			new RegexCharClass.LowerCaseMapping('Ƙ', 'Ƙ', 0, 409),
			new RegexCharClass.LowerCaseMapping('Ɯ', 'Ɯ', 0, 623),
			new RegexCharClass.LowerCaseMapping('Ɲ', 'Ɲ', 0, 626),
			new RegexCharClass.LowerCaseMapping('Ɵ', 'Ɵ', 0, 629),
			new RegexCharClass.LowerCaseMapping('Ơ', 'Ƥ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ƨ', 'Ƨ', 0, 424),
			new RegexCharClass.LowerCaseMapping('Ʃ', 'Ʃ', 0, 643),
			new RegexCharClass.LowerCaseMapping('Ƭ', 'Ƭ', 0, 429),
			new RegexCharClass.LowerCaseMapping('Ʈ', 'Ʈ', 0, 648),
			new RegexCharClass.LowerCaseMapping('Ư', 'Ư', 0, 432),
			new RegexCharClass.LowerCaseMapping('Ʊ', 'Ʋ', 1, 217),
			new RegexCharClass.LowerCaseMapping('Ƴ', 'Ƶ', 3, 0),
			new RegexCharClass.LowerCaseMapping('Ʒ', 'Ʒ', 0, 658),
			new RegexCharClass.LowerCaseMapping('Ƹ', 'Ƹ', 0, 441),
			new RegexCharClass.LowerCaseMapping('Ƽ', 'Ƽ', 0, 445),
			new RegexCharClass.LowerCaseMapping('Ǆ', 'ǅ', 0, 454),
			new RegexCharClass.LowerCaseMapping('Ǉ', 'ǈ', 0, 457),
			new RegexCharClass.LowerCaseMapping('Ǌ', 'ǋ', 0, 460),
			new RegexCharClass.LowerCaseMapping('Ǎ', 'Ǜ', 3, 0),
			new RegexCharClass.LowerCaseMapping('Ǟ', 'Ǯ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ǳ', 'ǲ', 0, 499),
			new RegexCharClass.LowerCaseMapping('Ǵ', 'Ǵ', 0, 501),
			new RegexCharClass.LowerCaseMapping('Ǻ', 'Ȗ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ά', 'Ά', 0, 940),
			new RegexCharClass.LowerCaseMapping('Έ', 'Ί', 1, 37),
			new RegexCharClass.LowerCaseMapping('Ό', 'Ό', 0, 972),
			new RegexCharClass.LowerCaseMapping('Ύ', 'Ώ', 1, 63),
			new RegexCharClass.LowerCaseMapping('Α', 'Ϋ', 1, 32),
			new RegexCharClass.LowerCaseMapping('Ϣ', 'Ϯ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ё', 'Џ', 1, 80),
			new RegexCharClass.LowerCaseMapping('А', 'Я', 1, 32),
			new RegexCharClass.LowerCaseMapping('Ѡ', 'Ҁ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ґ', 'Ҿ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ӂ', 'Ӄ', 3, 0),
			new RegexCharClass.LowerCaseMapping('Ӈ', 'Ӈ', 0, 1224),
			new RegexCharClass.LowerCaseMapping('Ӌ', 'Ӌ', 0, 1228),
			new RegexCharClass.LowerCaseMapping('Ӑ', 'Ӫ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ӯ', 'Ӵ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ӹ', 'Ӹ', 0, 1273),
			new RegexCharClass.LowerCaseMapping('Ա', 'Ֆ', 1, 48),
			new RegexCharClass.LowerCaseMapping('Ⴀ', 'Ⴥ', 1, 48),
			new RegexCharClass.LowerCaseMapping('Ḁ', 'Ỹ', 2, 0),
			new RegexCharClass.LowerCaseMapping('Ἀ', 'Ἇ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ἐ', '἟', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ἠ', 'Ἧ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ἰ', 'Ἷ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ὀ', 'Ὅ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ὑ', 'Ὑ', 0, 8017),
			new RegexCharClass.LowerCaseMapping('Ὓ', 'Ὓ', 0, 8019),
			new RegexCharClass.LowerCaseMapping('Ὕ', 'Ὕ', 0, 8021),
			new RegexCharClass.LowerCaseMapping('Ὗ', 'Ὗ', 0, 8023),
			new RegexCharClass.LowerCaseMapping('Ὠ', 'Ὧ', 1, -8),
			new RegexCharClass.LowerCaseMapping('ᾈ', 'ᾏ', 1, -8),
			new RegexCharClass.LowerCaseMapping('ᾘ', 'ᾟ', 1, -8),
			new RegexCharClass.LowerCaseMapping('ᾨ', 'ᾯ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ᾰ', 'Ᾱ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ὰ', 'Ά', 1, -74),
			new RegexCharClass.LowerCaseMapping('ᾼ', 'ᾼ', 0, 8115),
			new RegexCharClass.LowerCaseMapping('Ὲ', 'Ή', 1, -86),
			new RegexCharClass.LowerCaseMapping('ῌ', 'ῌ', 0, 8131),
			new RegexCharClass.LowerCaseMapping('Ῐ', 'Ῑ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ὶ', 'Ί', 1, -100),
			new RegexCharClass.LowerCaseMapping('Ῠ', 'Ῡ', 1, -8),
			new RegexCharClass.LowerCaseMapping('Ὺ', 'Ύ', 1, -112),
			new RegexCharClass.LowerCaseMapping('Ῥ', 'Ῥ', 0, 8165),
			new RegexCharClass.LowerCaseMapping('Ὸ', 'Ό', 1, -128),
			new RegexCharClass.LowerCaseMapping('Ὼ', 'Ώ', 1, -126),
			new RegexCharClass.LowerCaseMapping('ῼ', 'ῼ', 0, 8179),
			new RegexCharClass.LowerCaseMapping('Ⅰ', 'Ⅿ', 1, 16),
			new RegexCharClass.LowerCaseMapping('Ⓐ', 'ⓐ', 1, 26),
			new RegexCharClass.LowerCaseMapping('Ａ', 'Ｚ', 1, 32)
		};

		// Token: 0x040002ED RID: 749
		private List<RegexCharClass.SingleRange> _rangelist;

		// Token: 0x040002EE RID: 750
		private StringBuilder _categories;

		// Token: 0x040002EF RID: 751
		private bool _canonical;

		// Token: 0x040002F0 RID: 752
		private bool _negate;

		// Token: 0x040002F1 RID: 753
		private RegexCharClass _subtractor;

		// Token: 0x020000A7 RID: 167
		private readonly struct LowerCaseMapping
		{
			// Token: 0x0600046B RID: 1131 RVA: 0x000199F8 File Offset: 0x00017BF8
			internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
			{
				this.ChMin = chMin;
				this.ChMax = chMax;
				this.LcOp = lcOp;
				this.Data = data;
			}

			// Token: 0x040002F2 RID: 754
			public readonly char ChMin;

			// Token: 0x040002F3 RID: 755
			public readonly char ChMax;

			// Token: 0x040002F4 RID: 756
			public readonly int LcOp;

			// Token: 0x040002F5 RID: 757
			public readonly int Data;
		}

		// Token: 0x020000A8 RID: 168
		private sealed class SingleRangeComparer : IComparer<RegexCharClass.SingleRange>
		{
			// Token: 0x0600046C RID: 1132 RVA: 0x0000222D File Offset: 0x0000042D
			private SingleRangeComparer()
			{
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00019A17 File Offset: 0x00017C17
			public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y)
			{
				return x.First.CompareTo(y.First);
			}

			// Token: 0x040002F6 RID: 758
			public static readonly RegexCharClass.SingleRangeComparer Instance = new RegexCharClass.SingleRangeComparer();
		}

		// Token: 0x020000A9 RID: 169
		private readonly struct SingleRange
		{
			// Token: 0x0600046F RID: 1135 RVA: 0x00019A37 File Offset: 0x00017C37
			internal SingleRange(char first, char last)
			{
				this.First = first;
				this.Last = last;
			}

			// Token: 0x040002F7 RID: 759
			public readonly char First;

			// Token: 0x040002F8 RID: 760
			public readonly char Last;
		}
	}
}
