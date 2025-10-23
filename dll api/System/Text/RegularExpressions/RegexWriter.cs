using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000BA RID: 186
	internal ref struct RegexWriter
	{
		// Token: 0x0600059F RID: 1439 RVA: 0x000233B7 File Offset: 0x000215B7
		private RegexWriter(Span<int> emittedSpan, Span<int> intStackSpan)
		{
			this._emitted = new ValueListBuilder<int>(emittedSpan);
			this._intStack = new ValueListBuilder<int>(intStackSpan);
			this._stringHash = new Dictionary<string, int>();
			this._stringTable = new List<string>();
			this._caps = null;
			this._trackCount = 0;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000233F8 File Offset: 0x000215F8
		public unsafe static RegexCode Write(RegexTree tree)
		{
			Span<int> emittedSpan = new Span<int>(stackalloc byte[(UIntPtr)224], 56);
			Span<int> intStackSpan = new Span<int>(stackalloc byte[(UIntPtr)128], 32);
			RegexWriter regexWriter = new RegexWriter(emittedSpan, intStackSpan);
			RegexCode result = regexWriter.RegexCodeFromRegexTree(tree);
			regexWriter.Dispose();
			return result;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0002343D File Offset: 0x0002163D
		public void Dispose()
		{
			this._emitted.Dispose();
			this._intStack.Dispose();
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00023458 File Offset: 0x00021658
		public RegexCode RegexCodeFromRegexTree(RegexTree tree)
		{
			int capsize;
			if (tree.CapNumList == null || tree.CapTop == tree.CapNumList.Length)
			{
				capsize = tree.CapTop;
				this._caps = null;
			}
			else
			{
				capsize = tree.CapNumList.Length;
				this._caps = tree.Caps;
				for (int i = 0; i < tree.CapNumList.Length; i++)
				{
					this._caps[tree.CapNumList[i]] = i;
				}
			}
			RegexNode regexNode = tree.Root;
			int num = 0;
			this.Emit(23, 0);
			for (;;)
			{
				if (regexNode.Children == null)
				{
					this.EmitFragment(regexNode.NType, regexNode, 0);
				}
				else if (num < regexNode.Children.Count)
				{
					this.EmitFragment(regexNode.NType | 64, regexNode, num);
					regexNode = regexNode.Children[num];
					this._intStack.Append(num);
					num = 0;
					continue;
				}
				if (this._intStack.Length == 0)
				{
					break;
				}
				num = this._intStack.Pop();
				regexNode = regexNode.Next;
				this.EmitFragment(regexNode.NType | 128, regexNode, num);
				num++;
			}
			this.PatchJump(0, this._emitted.Length);
			this.Emit(40);
			RegexPrefix? fcPrefix = RegexFCD.FirstChars(tree);
			RegexPrefix regexPrefix = RegexFCD.Prefix(tree);
			bool rightToLeft = (tree.Options & RegexOptions.RightToLeft) > RegexOptions.None;
			CultureInfo culture = ((tree.Options & RegexOptions.CultureInvariant) != RegexOptions.None) ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture;
			RegexBoyerMoore bmPrefix;
			if (regexPrefix.Prefix.Length > 0)
			{
				bmPrefix = new RegexBoyerMoore(regexPrefix.Prefix, regexPrefix.CaseInsensitive, rightToLeft, culture);
			}
			else
			{
				bmPrefix = null;
			}
			int anchors = RegexFCD.Anchors(tree);
			return new RegexCode(this._emitted.AsSpan().ToArray(), this._stringTable, this._trackCount, this._caps, capsize, bmPrefix, fcPrefix, anchors, rightToLeft);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00023637 File Offset: 0x00021837
		private unsafe void PatchJump(int offset, int jumpDest)
		{
			*this._emitted[offset + 1] = jumpDest;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00023649 File Offset: 0x00021849
		private void Emit(int op)
		{
			if (RegexCode.OpcodeBacktracks(op))
			{
				this._trackCount++;
			}
			this._emitted.Append(op);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002366D File Offset: 0x0002186D
		private void Emit(int op, int opd1)
		{
			if (RegexCode.OpcodeBacktracks(op))
			{
				this._trackCount++;
			}
			this._emitted.Append(op);
			this._emitted.Append(opd1);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002369D File Offset: 0x0002189D
		private void Emit(int op, int opd1, int opd2)
		{
			if (RegexCode.OpcodeBacktracks(op))
			{
				this._trackCount++;
			}
			this._emitted.Append(op);
			this._emitted.Append(opd1);
			this._emitted.Append(opd2);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000236DC File Offset: 0x000218DC
		private int StringCode(string str)
		{
			if (str == null)
			{
				str = string.Empty;
			}
			int count;
			if (!this._stringHash.TryGetValue(str, out count))
			{
				count = this._stringTable.Count;
				this._stringHash[str] = count;
				this._stringTable.Add(str);
			}
			return count;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00023729 File Offset: 0x00021929
		private int MapCapnum(int capnum)
		{
			if (capnum == -1)
			{
				return -1;
			}
			if (this._caps != null)
			{
				return (int)this._caps[capnum];
			}
			return capnum;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00023754 File Offset: 0x00021954
		private void EmitFragment(int nodetype, RegexNode node, int curIndex)
		{
			int num = 0;
			if (nodetype <= 13)
			{
				if (node.UseOptionR())
				{
					num |= 64;
				}
				if ((node.Options & RegexOptions.IgnoreCase) != RegexOptions.None)
				{
					num |= 512;
				}
			}
			switch (nodetype)
			{
			case 3:
			case 4:
			case 6:
			case 7:
				if (node.M > 0)
				{
					this.Emit(((node.NType == 3 || node.NType == 6) ? 0 : 1) | num, (int)node.Ch, node.M);
				}
				if (node.N > node.M)
				{
					this.Emit(node.NType | num, (int)node.Ch, (node.N == int.MaxValue) ? int.MaxValue : (node.N - node.M));
					return;
				}
				return;
			case 5:
			case 8:
				if (node.M > 0)
				{
					this.Emit(2 | num, this.StringCode(node.Str), node.M);
				}
				if (node.N > node.M)
				{
					this.Emit(node.NType | num, this.StringCode(node.Str), (node.N == int.MaxValue) ? int.MaxValue : (node.N - node.M));
					return;
				}
				return;
			case 9:
			case 10:
				this.Emit(node.NType | num, (int)node.Ch);
				return;
			case 11:
				this.Emit(node.NType | num, this.StringCode(node.Str));
				return;
			case 12:
				this.Emit(node.NType | num, this.StringCode(node.Str));
				return;
			case 13:
				this.Emit(node.NType | num, this.MapCapnum(node.M));
				return;
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 41:
			case 42:
				this.Emit(node.NType);
				return;
			case 23:
				return;
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
				break;
			default:
				switch (nodetype)
				{
				case 88:
					if (curIndex < node.Children.Count - 1)
					{
						this._intStack.Append(this._emitted.Length);
						this.Emit(23, 0);
						return;
					}
					return;
				case 89:
				case 93:
					return;
				case 90:
				case 91:
					if (node.N < 2147483647 || node.M > 1)
					{
						this.Emit((node.M == 0) ? 26 : 27, (node.M == 0) ? 0 : (1 - node.M));
					}
					else
					{
						this.Emit((node.M == 0) ? 30 : 31);
					}
					if (node.M == 0)
					{
						this._intStack.Append(this._emitted.Length);
						this.Emit(38, 0);
					}
					this._intStack.Append(this._emitted.Length);
					return;
				case 92:
					this.Emit(31);
					return;
				case 94:
					this.Emit(34);
					this.Emit(31);
					return;
				case 95:
					this.Emit(34);
					this._intStack.Append(this._emitted.Length);
					this.Emit(23, 0);
					return;
				case 96:
					this.Emit(34);
					return;
				case 97:
					if (curIndex == 0)
					{
						this.Emit(34);
						this._intStack.Append(this._emitted.Length);
						this.Emit(23, 0);
						this.Emit(37, this.MapCapnum(node.M));
						this.Emit(36);
						return;
					}
					return;
				case 98:
					if (curIndex == 0)
					{
						this.Emit(34);
						this.Emit(31);
						this._intStack.Append(this._emitted.Length);
						this.Emit(23, 0);
						return;
					}
					return;
				default:
					switch (nodetype)
					{
					case 152:
						if (curIndex < node.Children.Count - 1)
						{
							int offset = this._intStack.Pop();
							this._intStack.Append(this._emitted.Length);
							this.Emit(38, 0);
							this.PatchJump(offset, this._emitted.Length);
							return;
						}
						for (int i = 0; i < curIndex; i++)
						{
							this.PatchJump(this._intStack.Pop(), this._emitted.Length);
						}
						return;
					case 153:
					case 157:
						return;
					case 154:
					case 155:
					{
						int length = this._emitted.Length;
						int num2 = nodetype - 154;
						if (node.N < 2147483647 || node.M > 1)
						{
							this.Emit(28 + num2, this._intStack.Pop(), (node.N == int.MaxValue) ? int.MaxValue : (node.N - node.M));
						}
						else
						{
							this.Emit(24 + num2, this._intStack.Pop());
						}
						if (node.M == 0)
						{
							this.PatchJump(this._intStack.Pop(), length);
							return;
						}
						return;
					}
					case 156:
						this.Emit(32, this.MapCapnum(node.M), this.MapCapnum(node.N));
						return;
					case 158:
						this.Emit(33);
						this.Emit(36);
						return;
					case 159:
						this.Emit(35);
						this.PatchJump(this._intStack.Pop(), this._emitted.Length);
						this.Emit(36);
						return;
					case 160:
						this.Emit(36);
						return;
					case 161:
						if (curIndex != 0)
						{
							if (curIndex != 1)
							{
								return;
							}
						}
						else
						{
							int offset2 = this._intStack.Pop();
							this._intStack.Append(this._emitted.Length);
							this.Emit(38, 0);
							this.PatchJump(offset2, this._emitted.Length);
							this.Emit(36);
							if (node.Children.Count > 1)
							{
								return;
							}
						}
						this.PatchJump(this._intStack.Pop(), this._emitted.Length);
						return;
					case 162:
						switch (curIndex)
						{
						case 0:
							this.Emit(33);
							this.Emit(36);
							return;
						case 1:
						{
							int offset3 = this._intStack.Pop();
							this._intStack.Append(this._emitted.Length);
							this.Emit(38, 0);
							this.PatchJump(offset3, this._emitted.Length);
							this.Emit(33);
							this.Emit(36);
							if (node.Children.Count > 2)
							{
								return;
							}
							break;
						}
						case 2:
							break;
						default:
							return;
						}
						this.PatchJump(this._intStack.Pop(), this._emitted.Length);
						return;
					}
					break;
				}
				break;
			}
			throw new ArgumentException(SR.Format("Unexpected opcode in regular expression generation: {0}.", nodetype.ToString(CultureInfo.CurrentCulture)));
		}

		// Token: 0x04000396 RID: 918
		private ValueListBuilder<int> _emitted;

		// Token: 0x04000397 RID: 919
		private ValueListBuilder<int> _intStack;

		// Token: 0x04000398 RID: 920
		private readonly Dictionary<string, int> _stringHash;

		// Token: 0x04000399 RID: 921
		private readonly List<string> _stringTable;

		// Token: 0x0400039A RID: 922
		private Hashtable _caps;

		// Token: 0x0400039B RID: 923
		private int _trackCount;
	}
}
