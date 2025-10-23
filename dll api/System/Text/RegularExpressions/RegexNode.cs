using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B2 RID: 178
	internal sealed class RegexNode
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x0001F744 File Offset: 0x0001D944
		public RegexNode(int type, RegexOptions options)
		{
			this.NType = type;
			this.Options = options;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001F75A File Offset: 0x0001D95A
		public RegexNode(int type, RegexOptions options, char ch)
		{
			this.NType = type;
			this.Options = options;
			this.Ch = ch;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001F777 File Offset: 0x0001D977
		public RegexNode(int type, RegexOptions options, string str)
		{
			this.NType = type;
			this.Options = options;
			this.Str = str;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001F794 File Offset: 0x0001D994
		public RegexNode(int type, RegexOptions options, int m)
		{
			this.NType = type;
			this.Options = options;
			this.M = m;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001F7B1 File Offset: 0x0001D9B1
		public RegexNode(int type, RegexOptions options, int m, int n)
		{
			this.NType = type;
			this.Options = options;
			this.M = m;
			this.N = n;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001F7D6 File Offset: 0x0001D9D6
		public bool UseOptionR()
		{
			return (this.Options & RegexOptions.RightToLeft) > RegexOptions.None;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		public RegexNode ReverseLeft()
		{
			if (this.UseOptionR() && this.NType == 25 && this.Children != null)
			{
				this.Children.Reverse(0, this.Children.Count);
			}
			return this;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001F818 File Offset: 0x0001DA18
		private void MakeRep(int type, int min, int max)
		{
			this.NType += type - 9;
			this.M = min;
			this.N = max;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001F83C File Offset: 0x0001DA3C
		private RegexNode Reduce()
		{
			int num = this.Type();
			RegexNode result;
			if (num != 5 && num != 11)
			{
				switch (num)
				{
				case 24:
					return this.ReduceAlternation();
				case 25:
					return this.ReduceConcatenation();
				case 26:
				case 27:
					return this.ReduceRep();
				case 29:
					return this.ReduceGroup();
				}
				result = this;
			}
			else
			{
				result = this.ReduceSet();
			}
			return result;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001F8AC File Offset: 0x0001DAAC
		private RegexNode StripEnation(int emptyType)
		{
			int num = this.ChildCount();
			if (num == 0)
			{
				return new RegexNode(emptyType, this.Options);
			}
			if (num != 1)
			{
				return this;
			}
			return this.Child(0);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001F8E0 File Offset: 0x0001DAE0
		private RegexNode ReduceGroup()
		{
			RegexNode regexNode = this;
			while (regexNode.Type() == 29)
			{
				regexNode = regexNode.Child(0);
			}
			return regexNode;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001F904 File Offset: 0x0001DB04
		private RegexNode ReduceRep()
		{
			RegexNode regexNode = this;
			int num = this.Type();
			int num2 = this.M;
			int num3 = this.N;
			while (regexNode.ChildCount() != 0)
			{
				RegexNode regexNode2 = regexNode.Child(0);
				if (regexNode2.Type() != num)
				{
					int num4 = regexNode2.Type();
					if ((num4 < 3 || num4 > 5 || num != 26) && (num4 < 6 || num4 > 8 || num != 27))
					{
						break;
					}
				}
				if ((regexNode.M == 0 && regexNode2.M > 1) || regexNode2.N < regexNode2.M * 2)
				{
					break;
				}
				regexNode = regexNode2;
				if (regexNode.M > 0)
				{
					num2 = (regexNode.M = ((2147483646 / regexNode.M < num2) ? int.MaxValue : (regexNode.M * num2)));
				}
				if (regexNode.N > 0)
				{
					num3 = (regexNode.N = ((2147483646 / regexNode.N < num3) ? int.MaxValue : (regexNode.N * num3)));
				}
			}
			if (num2 != 2147483647)
			{
				return regexNode;
			}
			return new RegexNode(22, this.Options);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001FA18 File Offset: 0x0001DC18
		private RegexNode ReduceSet()
		{
			if (RegexCharClass.IsEmpty(this.Str))
			{
				this.NType = 22;
				this.Str = null;
			}
			else if (RegexCharClass.IsSingleton(this.Str))
			{
				this.Ch = RegexCharClass.SingletonChar(this.Str);
				this.Str = null;
				this.NType += -2;
			}
			else if (RegexCharClass.IsSingletonInverse(this.Str))
			{
				this.Ch = RegexCharClass.SingletonChar(this.Str);
				this.Str = null;
				this.NType += -1;
			}
			return this;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001FAB0 File Offset: 0x0001DCB0
		private RegexNode ReduceAlternation()
		{
			if (this.Children == null)
			{
				return new RegexNode(22, this.Options);
			}
			bool flag = false;
			bool flag2 = false;
			RegexOptions regexOptions = RegexOptions.None;
			int i = 0;
			int num = 0;
			while (i < this.Children.Count)
			{
				RegexNode regexNode = this.Children[i];
				if (num < i)
				{
					this.Children[num] = regexNode;
				}
				if (regexNode.NType == 24)
				{
					for (int j = 0; j < regexNode.Children.Count; j++)
					{
						regexNode.Children[j].Next = this;
					}
					this.Children.InsertRange(i + 1, regexNode.Children);
					num--;
				}
				else if (regexNode.NType == 11 || regexNode.NType == 9)
				{
					RegexOptions regexOptions2 = regexNode.Options & (RegexOptions.IgnoreCase | RegexOptions.RightToLeft);
					if (regexNode.NType == 11)
					{
						if (!flag || regexOptions != regexOptions2 || flag2 || !RegexCharClass.IsMergeable(regexNode.Str))
						{
							flag = true;
							flag2 = !RegexCharClass.IsMergeable(regexNode.Str);
							regexOptions = regexOptions2;
							goto IL_1D0;
						}
					}
					else if (!flag || regexOptions != regexOptions2 || flag2)
					{
						flag = true;
						flag2 = false;
						regexOptions = regexOptions2;
						goto IL_1D0;
					}
					num--;
					RegexNode regexNode2 = this.Children[num];
					RegexCharClass regexCharClass;
					if (regexNode2.NType == 9)
					{
						regexCharClass = new RegexCharClass();
						regexCharClass.AddChar(regexNode2.Ch);
					}
					else
					{
						regexCharClass = RegexCharClass.Parse(regexNode2.Str);
					}
					if (regexNode.NType == 9)
					{
						regexCharClass.AddChar(regexNode.Ch);
					}
					else
					{
						RegexCharClass cc = RegexCharClass.Parse(regexNode.Str);
						regexCharClass.AddCharClass(cc);
					}
					regexNode2.NType = 11;
					regexNode2.Str = regexCharClass.ToStringClass();
				}
				else if (regexNode.NType == 22)
				{
					num--;
				}
				else
				{
					flag = false;
					flag2 = false;
				}
				IL_1D0:
				i++;
				num++;
			}
			if (num < i)
			{
				this.Children.RemoveRange(num, i - num);
			}
			return this.StripEnation(22);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001FCCC File Offset: 0x0001DECC
		private RegexNode ReduceConcatenation()
		{
			if (this.Children == null)
			{
				return new RegexNode(23, this.Options);
			}
			bool flag = false;
			RegexOptions regexOptions = RegexOptions.None;
			int i = 0;
			int num = 0;
			while (i < this.Children.Count)
			{
				RegexNode regexNode = this.Children[i];
				if (num < i)
				{
					this.Children[num] = regexNode;
				}
				if (regexNode.NType == 25 && (regexNode.Options & RegexOptions.RightToLeft) == (this.Options & RegexOptions.RightToLeft))
				{
					for (int j = 0; j < regexNode.Children.Count; j++)
					{
						regexNode.Children[j].Next = this;
					}
					this.Children.InsertRange(i + 1, regexNode.Children);
					num--;
				}
				else if (regexNode.NType == 12 || regexNode.NType == 9)
				{
					RegexOptions regexOptions2 = regexNode.Options & (RegexOptions.IgnoreCase | RegexOptions.RightToLeft);
					if (!flag || regexOptions != regexOptions2)
					{
						flag = true;
						regexOptions = regexOptions2;
					}
					else
					{
						RegexNode regexNode2 = this.Children[--num];
						if (regexNode2.NType == 9)
						{
							regexNode2.NType = 12;
							regexNode2.Str = Convert.ToString(regexNode2.Ch, CultureInfo.InvariantCulture);
						}
						if ((regexOptions2 & RegexOptions.RightToLeft) == RegexOptions.None)
						{
							if (regexNode.NType == 9)
							{
								RegexNode regexNode3 = regexNode2;
								regexNode3.Str += regexNode.Ch.ToString();
							}
							else
							{
								RegexNode regexNode4 = regexNode2;
								regexNode4.Str += regexNode.Str;
							}
						}
						else if (regexNode.NType == 9)
						{
							regexNode2.Str = regexNode.Ch.ToString() + regexNode2.Str;
						}
						else
						{
							regexNode2.Str = regexNode.Str + regexNode2.Str;
						}
					}
				}
				else if (regexNode.NType == 23)
				{
					num--;
				}
				else
				{
					flag = false;
				}
				i++;
				num++;
			}
			if (num < i)
			{
				this.Children.RemoveRange(num, i - num);
			}
			return this.StripEnation(23);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
		public RegexNode MakeQuantifier(bool lazy, int min, int max)
		{
			if (min == 0 && max == 0)
			{
				return new RegexNode(23, this.Options);
			}
			if (min == 1 && max == 1)
			{
				return this;
			}
			int ntype = this.NType;
			if (ntype - 9 <= 2)
			{
				this.MakeRep(lazy ? 6 : 3, min, max);
				return this;
			}
			RegexNode regexNode = new RegexNode(lazy ? 27 : 26, this.Options, min, max);
			regexNode.AddChild(this);
			return regexNode;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001FF4C File Offset: 0x0001E14C
		public void AddChild(RegexNode newChild)
		{
			if (this.Children == null)
			{
				this.Children = new List<RegexNode>(4);
			}
			RegexNode regexNode = newChild.Reduce();
			this.Children.Add(regexNode);
			regexNode.Next = this;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001FF87 File Offset: 0x0001E187
		public RegexNode Child(int i)
		{
			return this.Children[i];
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001FF95 File Offset: 0x0001E195
		public int ChildCount()
		{
			if (this.Children != null)
			{
				return this.Children.Count;
			}
			return 0;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		public int Type()
		{
			return this.NType;
		}

		// Token: 0x04000350 RID: 848
		public int NType;

		// Token: 0x04000351 RID: 849
		public List<RegexNode> Children;

		// Token: 0x04000352 RID: 850
		public string Str;

		// Token: 0x04000353 RID: 851
		public char Ch;

		// Token: 0x04000354 RID: 852
		public int M;

		// Token: 0x04000355 RID: 853
		public int N;

		// Token: 0x04000356 RID: 854
		public readonly RegexOptions Options;

		// Token: 0x04000357 RID: 855
		public RegexNode Next;
	}
}
