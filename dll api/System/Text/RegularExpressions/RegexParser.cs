using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B4 RID: 180
	internal sealed class RegexParser
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		public static RegexTree Parse(string re, RegexOptions op)
		{
			RegexParser regexParser = new RegexParser(((op & RegexOptions.CultureInvariant) != RegexOptions.None) ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture);
			regexParser._options = op;
			regexParser.SetPattern(re);
			regexParser.CountCaptures();
			regexParser.Reset(op);
			RegexNode root = regexParser.ScanRegex();
			string[] capsList;
			if (regexParser._capnamelist == null)
			{
				capsList = null;
			}
			else
			{
				capsList = regexParser._capnamelist.ToArray();
			}
			return new RegexTree(root, regexParser._caps, regexParser._capnumlist, regexParser._captop, regexParser._capnames, capsList, op);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00020034 File Offset: 0x0001E234
		public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op)
		{
			RegexParser regexParser = new RegexParser(((op & RegexOptions.CultureInvariant) != RegexOptions.None) ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture);
			regexParser._options = op;
			regexParser.NoteCaptures(caps, capsize, capnames);
			regexParser.SetPattern(rep);
			RegexNode concat = regexParser.ScanReplacement();
			return new RegexReplacement(rep, concat, caps);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00020082 File Offset: 0x0001E282
		private RegexParser(CultureInfo culture)
		{
			this._culture = culture;
			this._optionsStack = new List<RegexOptions>();
			this._caps = new Hashtable();
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000200A7 File Offset: 0x0001E2A7
		private void SetPattern(string Re)
		{
			if (Re == null)
			{
				Re = string.Empty;
			}
			this._pattern = Re;
			this._currentPos = 0;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000200C4 File Offset: 0x0001E2C4
		private void Reset(RegexOptions topopts)
		{
			this._currentPos = 0;
			this._autocap = 1;
			this._ignoreNextParen = false;
			if (this._optionsStack.Count > 0)
			{
				this._optionsStack.RemoveRange(0, this._optionsStack.Count - 1);
			}
			this._options = topopts;
			this._stack = null;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0002011C File Offset: 0x0001E31C
		private RegexNode ScanRegex()
		{
			bool flag = false;
			this.StartGroup(new RegexNode(28, this._options, 0, -1));
			while (this.CharsRight() > 0)
			{
				bool flag2 = flag;
				flag = false;
				this.ScanBlank();
				int num = this.Textpos();
				char c;
				if (this.UseOptionX())
				{
					while (this.CharsRight() > 0)
					{
						if (RegexParser.IsStopperX(c = this.RightChar()))
						{
							if (c != '{')
							{
								break;
							}
							if (this.IsTrueQuantifier())
							{
								break;
							}
						}
						this.MoveRight();
					}
				}
				else
				{
					while (this.CharsRight() > 0 && (!RegexParser.IsSpecial(c = this.RightChar()) || (c == '{' && !this.IsTrueQuantifier())))
					{
						this.MoveRight();
					}
				}
				int num2 = this.Textpos();
				this.ScanBlank();
				if (this.CharsRight() == 0)
				{
					c = '!';
				}
				else if (RegexParser.IsSpecial(c = this.RightChar()))
				{
					flag = RegexParser.IsQuantifier(c);
					this.MoveRight();
				}
				else
				{
					c = ' ';
				}
				if (num < num2)
				{
					int num3 = num2 - num - (flag ? 1 : 0);
					flag2 = false;
					if (num3 > 0)
					{
						this.AddConcatenate(num, num3, false);
					}
					if (flag)
					{
						this.AddUnitOne(this.CharAt(num2 - 1));
					}
				}
				if (c <= '?')
				{
					switch (c)
					{
					case ' ':
						continue;
					case '!':
						goto IL_414;
					case '"':
					case '#':
					case '%':
					case '&':
					case '\'':
					case ',':
					case '-':
						goto IL_2A3;
					case '$':
						this.AddUnitType(this.UseOptionM() ? 15 : 20);
						break;
					case '(':
					{
						this.PushOptions();
						RegexNode openGroup;
						if ((openGroup = this.ScanGroupOpen()) == null)
						{
							this.PopKeepOptions();
							continue;
						}
						this.PushGroup();
						this.StartGroup(openGroup);
						continue;
					}
					case ')':
						if (this.EmptyStack())
						{
							throw this.MakeException("Too many )'s.");
						}
						this.AddGroup();
						this.PopGroup();
						this.PopOptions();
						if (this.Unit() == null)
						{
							continue;
						}
						break;
					case '*':
					case '+':
						goto IL_271;
					case '.':
						if (this.UseOptionS())
						{
							this.AddUnitSet("\0\u0001\0\0");
						}
						else
						{
							this.AddUnitNotone('\n');
						}
						break;
					default:
						if (c != '?')
						{
							goto IL_2A3;
						}
						goto IL_271;
					}
				}
				else
				{
					switch (c)
					{
					case '[':
						this.AddUnitSet(this.ScanCharClass(this.UseOptionI(), false).ToStringClass());
						break;
					case '\\':
						this.AddUnitNode(this.ScanBackslash(false));
						break;
					case ']':
						goto IL_2A3;
					case '^':
						this.AddUnitType(this.UseOptionM() ? 14 : 18);
						break;
					default:
						if (c == '{')
						{
							goto IL_271;
						}
						if (c != '|')
						{
							goto IL_2A3;
						}
						this.AddAlternate();
						continue;
					}
				}
				IL_2AF:
				this.ScanBlank();
				if (this.CharsRight() == 0 || !(flag = this.IsTrueQuantifier()))
				{
					this.AddConcatenate();
					continue;
				}
				c = this.RightCharMoveRight();
				while (this.Unit() != null)
				{
					int num4;
					int num5;
					if (c <= '+')
					{
						if (c != '*')
						{
							if (c != '+')
							{
								goto IL_3AD;
							}
							num4 = 1;
							num5 = int.MaxValue;
						}
						else
						{
							num4 = 0;
							num5 = int.MaxValue;
						}
					}
					else if (c != '?')
					{
						if (c != '{')
						{
							goto IL_3AD;
						}
						num = this.Textpos();
						num4 = (num5 = this.ScanDecimal());
						if (num < this.Textpos() && this.CharsRight() > 0 && this.RightChar() == ',')
						{
							this.MoveRight();
							if (this.CharsRight() == 0 || this.RightChar() == '}')
							{
								num5 = int.MaxValue;
							}
							else
							{
								num5 = this.ScanDecimal();
							}
						}
						if (num == this.Textpos() || this.CharsRight() == 0 || this.RightCharMoveRight() != '}')
						{
							this.AddConcatenate();
							this.Textto(num - 1);
							break;
						}
					}
					else
					{
						num4 = 0;
						num5 = 1;
					}
					this.ScanBlank();
					bool lazy;
					if (this.CharsRight() == 0 || this.RightChar() != '?')
					{
						lazy = false;
					}
					else
					{
						this.MoveRight();
						lazy = true;
					}
					if (num4 > num5)
					{
						throw this.MakeException("Illegal {x,y} with x > y.");
					}
					this.AddConcatenate(lazy, num4, num5);
					continue;
					IL_3AD:
					throw this.MakeException("Internal error in ScanRegex.");
				}
				continue;
				IL_271:
				if (this.Unit() == null)
				{
					throw this.MakeException(flag2 ? SR.Format("Nested quantifier {0}.", c.ToString()) : "Quantifier {x,y} following nothing.");
				}
				this.MoveLeft();
				goto IL_2AF;
				IL_2A3:
				throw this.MakeException("Internal error in ScanRegex.");
			}
			IL_414:
			if (!this.EmptyStack())
			{
				throw this.MakeException("Not enough )'s.");
			}
			this.AddGroup();
			return this.Unit();
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00020560 File Offset: 0x0001E760
		private RegexNode ScanReplacement()
		{
			this._concatenation = new RegexNode(25, this._options);
			for (;;)
			{
				int num = this.CharsRight();
				if (num == 0)
				{
					break;
				}
				int num2 = this.Textpos();
				while (num > 0 && this.RightChar() != '$')
				{
					this.MoveRight();
					num--;
				}
				this.AddConcatenate(num2, this.Textpos() - num2, true);
				if (num > 0)
				{
					if (this.RightCharMoveRight() == '$')
					{
						this.AddUnitNode(this.ScanDollar());
					}
					this.AddConcatenate();
				}
			}
			return this._concatenation;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000205E4 File Offset: 0x0001E7E4
		private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
		{
			char c = '\0';
			bool flag = false;
			bool flag2 = true;
			bool flag3 = false;
			RegexCharClass regexCharClass = scanOnly ? null : new RegexCharClass();
			if (this.CharsRight() > 0 && this.RightChar() == '^')
			{
				this.MoveRight();
				if (!scanOnly)
				{
					regexCharClass.Negate = true;
				}
			}
			while (this.CharsRight() > 0)
			{
				bool flag4 = false;
				char c2 = this.RightCharMoveRight();
				if (c2 == ']')
				{
					if (!flag2)
					{
						flag3 = true;
						break;
					}
					goto IL_261;
				}
				else
				{
					if (c2 == '\\' && this.CharsRight() > 0)
					{
						char c3;
						c2 = (c3 = this.RightCharMoveRight());
						if (c3 <= 'S')
						{
							if (c3 <= 'D')
							{
								if (c3 != '-')
								{
									if (c3 != 'D')
									{
										goto IL_1FA;
									}
								}
								else
								{
									if (!scanOnly)
									{
										regexCharClass.AddRange(c2, c2);
										goto IL_371;
									}
									goto IL_371;
								}
							}
							else
							{
								if (c3 == 'P')
								{
									goto IL_19B;
								}
								if (c3 != 'S')
								{
									goto IL_1FA;
								}
								goto IL_12B;
							}
						}
						else
						{
							if (c3 <= 'd')
							{
								if (c3 != 'W')
								{
									if (c3 != 'd')
									{
										goto IL_1FA;
									}
									goto IL_ED;
								}
							}
							else
							{
								if (c3 == 'p')
								{
									goto IL_19B;
								}
								if (c3 == 's')
								{
									goto IL_12B;
								}
								if (c3 != 'w')
								{
									goto IL_1FA;
								}
							}
							if (scanOnly)
							{
								goto IL_371;
							}
							if (flag)
							{
								throw this.MakeException(SR.Format("Cannot include class \\{0} in character range.", c2.ToString()));
							}
							regexCharClass.AddWord(this.UseOptionE(), c2 == 'W');
							goto IL_371;
						}
						IL_ED:
						if (scanOnly)
						{
							goto IL_371;
						}
						if (flag)
						{
							throw this.MakeException(SR.Format("Cannot include class \\{0} in character range.", c2.ToString()));
						}
						regexCharClass.AddDigit(this.UseOptionE(), c2 == 'D', this._pattern);
						goto IL_371;
						IL_12B:
						if (scanOnly)
						{
							goto IL_371;
						}
						if (flag)
						{
							throw this.MakeException(SR.Format("Cannot include class \\{0} in character range.", c2.ToString()));
						}
						regexCharClass.AddSpace(this.UseOptionE(), c2 == 'S');
						goto IL_371;
						IL_19B:
						if (scanOnly)
						{
							this.ParseProperty();
							goto IL_371;
						}
						if (flag)
						{
							throw this.MakeException(SR.Format("Cannot include class \\{0} in character range.", c2.ToString()));
						}
						regexCharClass.AddCategoryFromName(this.ParseProperty(), c2 != 'p', caseInsensitive, this._pattern);
						goto IL_371;
						IL_1FA:
						this.MoveLeft();
						c2 = this.ScanCharEscape();
						flag4 = true;
						goto IL_261;
					}
					if (c2 != '[' || this.CharsRight() <= 0 || this.RightChar() != ':' || flag)
					{
						goto IL_261;
					}
					int pos = this.Textpos();
					this.MoveRight();
					this.ScanCapname();
					if (this.CharsRight() < 2 || this.RightCharMoveRight() != ':' || this.RightCharMoveRight() != ']')
					{
						this.Textto(pos);
						goto IL_261;
					}
					goto IL_261;
				}
				IL_371:
				flag2 = false;
				continue;
				IL_261:
				if (flag)
				{
					flag = false;
					if (scanOnly)
					{
						goto IL_371;
					}
					if (c2 == '[' && !flag4 && !flag2)
					{
						regexCharClass.AddChar(c);
						regexCharClass.AddSubtraction(this.ScanCharClass(caseInsensitive, scanOnly));
						if (this.CharsRight() > 0 && this.RightChar() != ']')
						{
							throw this.MakeException("A subtraction must be the last element in a character class.");
						}
						goto IL_371;
					}
					else
					{
						if (c > c2)
						{
							throw this.MakeException("[x-y] range in reverse order.");
						}
						regexCharClass.AddRange(c, c2);
						goto IL_371;
					}
				}
				else
				{
					if (this.CharsRight() >= 2 && this.RightChar() == '-' && this.RightChar(1) != ']')
					{
						c = c2;
						flag = true;
						this.MoveRight();
						goto IL_371;
					}
					if (this.CharsRight() >= 1 && c2 == '-' && !flag4 && this.RightChar() == '[' && !flag2)
					{
						if (scanOnly)
						{
							this.MoveRight(1);
							this.ScanCharClass(caseInsensitive, scanOnly);
							goto IL_371;
						}
						this.MoveRight(1);
						regexCharClass.AddSubtraction(this.ScanCharClass(caseInsensitive, scanOnly));
						if (this.CharsRight() > 0 && this.RightChar() != ']')
						{
							throw this.MakeException("A subtraction must be the last element in a character class.");
						}
						goto IL_371;
					}
					else
					{
						if (!scanOnly)
						{
							regexCharClass.AddRange(c2, c2);
							goto IL_371;
						}
						goto IL_371;
					}
				}
			}
			if (!flag3)
			{
				throw this.MakeException("Unterminated [] set.");
			}
			if (!scanOnly && caseInsensitive)
			{
				regexCharClass.AddLowercase(this._culture);
			}
			return regexCharClass;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00020998 File Offset: 0x0001EB98
		private RegexNode ScanGroupOpen()
		{
			char c = '>';
			if (this.CharsRight() != 0 && this.RightChar() == '?' && (this.RightChar() != '?' || this.CharsRight() <= 1 || this.RightChar(1) != ')'))
			{
				this.MoveRight();
				if (this.CharsRight() != 0)
				{
					char c2 = this.RightCharMoveRight();
					int type;
					char c3;
					if (c2 <= '\'')
					{
						if (c2 == '!')
						{
							this._options &= ~RegexOptions.RightToLeft;
							type = 31;
							goto IL_4FA;
						}
						if (c2 != '\'')
						{
							goto IL_4C1;
						}
						c = '\'';
					}
					else if (c2 != '(')
					{
						switch (c2)
						{
						case ':':
							type = 29;
							goto IL_4FA;
						case ';':
							goto IL_4C1;
						case '<':
							break;
						case '=':
							this._options &= ~RegexOptions.RightToLeft;
							type = 30;
							goto IL_4FA;
						case '>':
							type = 32;
							goto IL_4FA;
						default:
							goto IL_4C1;
						}
					}
					else
					{
						int num = this.Textpos();
						if (this.CharsRight() > 0)
						{
							c3 = this.RightChar();
							if (c3 >= '0' && c3 <= '9')
							{
								int num2 = this.ScanDecimal();
								if (this.CharsRight() <= 0 || this.RightCharMoveRight() != ')')
								{
									throw this.MakeException(SR.Format("(?({0}) ) malformed.", num2.ToString(CultureInfo.CurrentCulture)));
								}
								if (this.IsCaptureSlot(num2))
								{
									return new RegexNode(33, this._options, num2);
								}
								throw this.MakeException(SR.Format("(?({0}) ) reference to undefined group.", num2.ToString(CultureInfo.CurrentCulture)));
							}
							else if (RegexCharClass.IsWordChar(c3))
							{
								string capname = this.ScanCapname();
								if (this.IsCaptureName(capname) && this.CharsRight() > 0 && this.RightCharMoveRight() == ')')
								{
									return new RegexNode(33, this._options, this.CaptureSlotFromName(capname));
								}
							}
						}
						type = 34;
						this.Textto(num - 1);
						this._ignoreNextParen = true;
						int num3 = this.CharsRight();
						if (num3 < 3 || this.RightChar(1) != '?')
						{
							goto IL_4FA;
						}
						char c4 = this.RightChar(2);
						if (c4 == '#')
						{
							throw this.MakeException("Alternation conditions cannot be comments.");
						}
						if (c4 == '\'')
						{
							throw this.MakeException("Alternation conditions do not capture and cannot be named.");
						}
						if (num3 >= 4 && c4 == '<' && this.RightChar(3) != '!' && this.RightChar(3) != '=')
						{
							throw this.MakeException("Alternation conditions do not capture and cannot be named.");
						}
						goto IL_4FA;
					}
					if (this.CharsRight() == 0)
					{
						goto IL_507;
					}
					char c5;
					c3 = (c5 = this.RightCharMoveRight());
					if (c5 != '!')
					{
						if (c5 == '=')
						{
							if (c != '\'')
							{
								this._options |= RegexOptions.RightToLeft;
								type = 30;
								goto IL_4FA;
							}
							goto IL_507;
						}
						else
						{
							this.MoveLeft();
							int num4 = -1;
							int num5 = -1;
							bool flag = false;
							if (c3 >= '0' && c3 <= '9')
							{
								num4 = this.ScanDecimal();
								if (!this.IsCaptureSlot(num4))
								{
									num4 = -1;
								}
								if (this.CharsRight() > 0 && this.RightChar() != c && this.RightChar() != '-')
								{
									throw this.MakeException("Invalid group name: Group names must begin with a word character.");
								}
								if (num4 == 0)
								{
									throw this.MakeException("Capture number cannot be zero.");
								}
							}
							else if (RegexCharClass.IsWordChar(c3))
							{
								string capname2 = this.ScanCapname();
								if (this.IsCaptureName(capname2))
								{
									num4 = this.CaptureSlotFromName(capname2);
								}
								if (this.CharsRight() > 0 && this.RightChar() != c && this.RightChar() != '-')
								{
									throw this.MakeException("Invalid group name: Group names must begin with a word character.");
								}
							}
							else
							{
								if (c3 != '-')
								{
									throw this.MakeException("Invalid group name: Group names must begin with a word character.");
								}
								flag = true;
							}
							if ((num4 != -1 || flag) && this.CharsRight() > 1 && this.RightChar() == '-')
							{
								this.MoveRight();
								c3 = this.RightChar();
								if (c3 >= '0' && c3 <= '9')
								{
									num5 = this.ScanDecimal();
									if (!this.IsCaptureSlot(num5))
									{
										throw this.MakeException(SR.Format("Reference to undefined group number {0}.", num5));
									}
									if (this.CharsRight() > 0 && this.RightChar() != c)
									{
										throw this.MakeException("Invalid group name: Group names must begin with a word character.");
									}
								}
								else
								{
									if (!RegexCharClass.IsWordChar(c3))
									{
										throw this.MakeException("Invalid group name: Group names must begin with a word character.");
									}
									string text = this.ScanCapname();
									if (!this.IsCaptureName(text))
									{
										throw this.MakeException(SR.Format("Reference to undefined group name {0}.", text));
									}
									num5 = this.CaptureSlotFromName(text);
									if (this.CharsRight() > 0 && this.RightChar() != c)
									{
										throw this.MakeException("Invalid group name: Group names must begin with a word character.");
									}
								}
							}
							if ((num4 != -1 || num5 != -1) && this.CharsRight() > 0 && this.RightCharMoveRight() == c)
							{
								return new RegexNode(28, this._options, num4, num5);
							}
							goto IL_507;
						}
					}
					else
					{
						if (c != '\'')
						{
							this._options |= RegexOptions.RightToLeft;
							type = 31;
							goto IL_4FA;
						}
						goto IL_507;
					}
					IL_4C1:
					this.MoveLeft();
					type = 29;
					if (this._group.NType != 34)
					{
						this.ScanOptions();
					}
					if (this.CharsRight() == 0)
					{
						goto IL_507;
					}
					if ((c3 = this.RightCharMoveRight()) == ')')
					{
						return null;
					}
					if (c3 != ':')
					{
						goto IL_507;
					}
					IL_4FA:
					return new RegexNode(type, this._options);
				}
				IL_507:
				throw this.MakeException("Unrecognized grouping construct.");
			}
			if (this.UseOptionN() || this._ignoreNextParen)
			{
				this._ignoreNextParen = false;
				return new RegexNode(29, this._options);
			}
			int type2 = 28;
			RegexOptions options = this._options;
			int autocap = this._autocap;
			this._autocap = autocap + 1;
			return new RegexNode(type2, options, autocap, -1);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00020EB8 File Offset: 0x0001F0B8
		private void ScanBlank()
		{
			if (this.UseOptionX())
			{
				for (;;)
				{
					if (this.CharsRight() <= 0 || !RegexParser.IsSpace(this.RightChar()))
					{
						if (this.CharsRight() == 0)
						{
							return;
						}
						if (this.RightChar() == '#')
						{
							while (this.CharsRight() > 0)
							{
								if (this.RightChar() == '\n')
								{
									break;
								}
								this.MoveRight();
							}
						}
						else
						{
							if (this.CharsRight() < 3 || this.RightChar(2) != '#' || this.RightChar(1) != '?' || this.RightChar() != '(')
							{
								return;
							}
							while (this.CharsRight() > 0 && this.RightChar() != ')')
							{
								this.MoveRight();
							}
							if (this.CharsRight() == 0)
							{
								break;
							}
							this.MoveRight();
						}
					}
					else
					{
						this.MoveRight();
					}
				}
				throw this.MakeException("Unterminated (?#...) comment.");
			}
			while (this.CharsRight() >= 3 && this.RightChar(2) == '#' && this.RightChar(1) == '?' && this.RightChar() == '(')
			{
				while (this.CharsRight() > 0 && this.RightChar() != ')')
				{
					this.MoveRight();
				}
				if (this.CharsRight() == 0)
				{
					throw this.MakeException("Unterminated (?#...) comment.");
				}
				this.MoveRight();
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00020FF0 File Offset: 0x0001F1F0
		private RegexNode ScanBackslash(bool scanOnly)
		{
			if (this.CharsRight() == 0)
			{
				throw this.MakeException("Illegal \\ at end of pattern.");
			}
			char c2;
			char c = c2 = this.RightChar();
			if (c2 <= 'Z')
			{
				if (c2 <= 'P')
				{
					switch (c2)
					{
					case 'A':
					case 'B':
					case 'G':
						break;
					case 'C':
					case 'E':
					case 'F':
						goto IL_274;
					case 'D':
						this.MoveRight();
						if (scanOnly)
						{
							return null;
						}
						if (this.UseOptionE())
						{
							return new RegexNode(11, this._options, "\u0001\u0002\00:");
						}
						return new RegexNode(11, this._options, RegexCharClass.NotDigitClass);
					default:
						if (c2 != 'P')
						{
							goto IL_274;
						}
						goto IL_21B;
					}
				}
				else if (c2 != 'S')
				{
					if (c2 != 'W')
					{
						if (c2 != 'Z')
						{
							goto IL_274;
						}
					}
					else
					{
						this.MoveRight();
						if (scanOnly)
						{
							return null;
						}
						if (this.UseOptionE())
						{
							return new RegexNode(11, this._options, "\u0001\n\00:A[_`a{İı");
						}
						return new RegexNode(11, this._options, RegexCharClass.NotWordClass);
					}
				}
				else
				{
					this.MoveRight();
					if (scanOnly)
					{
						return null;
					}
					if (this.UseOptionE())
					{
						return new RegexNode(11, this._options, "\u0001\u0004\0\t\u000e !");
					}
					return new RegexNode(11, this._options, RegexCharClass.NotSpaceClass);
				}
			}
			else if (c2 <= 'p')
			{
				if (c2 != 'b')
				{
					if (c2 != 'd')
					{
						if (c2 != 'p')
						{
							goto IL_274;
						}
						goto IL_21B;
					}
					else
					{
						this.MoveRight();
						if (scanOnly)
						{
							return null;
						}
						if (this.UseOptionE())
						{
							return new RegexNode(11, this._options, "\0\u0002\00:");
						}
						return new RegexNode(11, this._options, RegexCharClass.DigitClass);
					}
				}
			}
			else if (c2 != 's')
			{
				if (c2 != 'w')
				{
					if (c2 != 'z')
					{
						goto IL_274;
					}
				}
				else
				{
					this.MoveRight();
					if (scanOnly)
					{
						return null;
					}
					if (this.UseOptionE())
					{
						return new RegexNode(11, this._options, "\0\n\00:A[_`a{İı");
					}
					return new RegexNode(11, this._options, RegexCharClass.WordClass);
				}
			}
			else
			{
				this.MoveRight();
				if (scanOnly)
				{
					return null;
				}
				if (this.UseOptionE())
				{
					return new RegexNode(11, this._options, "\0\u0004\0\t\u000e !");
				}
				return new RegexNode(11, this._options, RegexCharClass.SpaceClass);
			}
			this.MoveRight();
			if (scanOnly)
			{
				return null;
			}
			return new RegexNode(this.TypeFromCode(c), this._options);
			IL_21B:
			this.MoveRight();
			if (scanOnly)
			{
				return null;
			}
			RegexCharClass regexCharClass = new RegexCharClass();
			regexCharClass.AddCategoryFromName(this.ParseProperty(), c != 'p', this.UseOptionI(), this._pattern);
			if (this.UseOptionI())
			{
				regexCharClass.AddLowercase(this._culture);
			}
			return new RegexNode(11, this._options, regexCharClass.ToStringClass());
			IL_274:
			return this.ScanBasicBackslash(scanOnly);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00021278 File Offset: 0x0001F478
		private RegexNode ScanBasicBackslash(bool scanOnly)
		{
			if (this.CharsRight() == 0)
			{
				throw this.MakeException("Illegal \\ at end of pattern.");
			}
			bool flag = false;
			char c = '\0';
			int pos = this.Textpos();
			char c2 = this.RightChar();
			if (c2 == 'k')
			{
				if (this.CharsRight() >= 2)
				{
					this.MoveRight();
					c2 = this.RightCharMoveRight();
					if (c2 == '<' || c2 == '\'')
					{
						flag = true;
						c = ((c2 == '\'') ? '\'' : '>');
					}
				}
				if (!flag || this.CharsRight() <= 0)
				{
					throw this.MakeException("Malformed \\k<...> named back reference.");
				}
				c2 = this.RightChar();
			}
			else if ((c2 == '<' || c2 == '\'') && this.CharsRight() > 1)
			{
				flag = true;
				c = ((c2 == '\'') ? '\'' : '>');
				this.MoveRight();
				c2 = this.RightChar();
			}
			if (flag && c2 >= '0' && c2 <= '9')
			{
				int num = this.ScanDecimal();
				if (this.CharsRight() > 0 && this.RightCharMoveRight() == c)
				{
					if (scanOnly)
					{
						return null;
					}
					if (this.IsCaptureSlot(num))
					{
						return new RegexNode(13, this._options, num);
					}
					throw this.MakeException(SR.Format("Reference to undefined group number {0}.", num.ToString(CultureInfo.CurrentCulture)));
				}
			}
			else if (!flag && c2 >= '1' && c2 <= '9')
			{
				if (this.UseOptionE())
				{
					int num2 = -1;
					int i = (int)(c2 - '0');
					int num3 = this.Textpos() - 1;
					while (i <= this._captop)
					{
						if (this.IsCaptureSlot(i) && (this._caps == null || (int)this._caps[i] < num3))
						{
							num2 = i;
						}
						this.MoveRight();
						if (this.CharsRight() == 0 || (c2 = this.RightChar()) < '0' || c2 > '9')
						{
							break;
						}
						i = i * 10 + (int)(c2 - '0');
					}
					if (num2 >= 0)
					{
						if (!scanOnly)
						{
							return new RegexNode(13, this._options, num2);
						}
						return null;
					}
				}
				else
				{
					int num4 = this.ScanDecimal();
					if (scanOnly)
					{
						return null;
					}
					if (this.IsCaptureSlot(num4))
					{
						return new RegexNode(13, this._options, num4);
					}
					if (num4 <= 9)
					{
						throw this.MakeException(SR.Format("Reference to undefined group number {0}.", num4.ToString(CultureInfo.CurrentCulture)));
					}
				}
			}
			else if (flag && RegexCharClass.IsWordChar(c2))
			{
				string text = this.ScanCapname();
				if (this.CharsRight() > 0 && this.RightCharMoveRight() == c)
				{
					if (scanOnly)
					{
						return null;
					}
					if (this.IsCaptureName(text))
					{
						return new RegexNode(13, this._options, this.CaptureSlotFromName(text));
					}
					throw this.MakeException(SR.Format("Reference to undefined group name {0}.", text));
				}
			}
			this.Textto(pos);
			c2 = this.ScanCharEscape();
			if (this.UseOptionI())
			{
				c2 = this._culture.TextInfo.ToLower(c2);
			}
			if (!scanOnly)
			{
				return new RegexNode(9, this._options, c2);
			}
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00021534 File Offset: 0x0001F734
		private RegexNode ScanDollar()
		{
			if (this.CharsRight() == 0)
			{
				return new RegexNode(9, this._options, '$');
			}
			char c = this.RightChar();
			int num = this.Textpos();
			int pos = num;
			bool flag;
			if (c == '{' && this.CharsRight() > 1)
			{
				flag = true;
				this.MoveRight();
				c = this.RightChar();
			}
			else
			{
				flag = false;
			}
			if (c >= '0' && c <= '9')
			{
				if (!flag && this.UseOptionE())
				{
					int num2 = -1;
					int num3 = (int)(c - '0');
					this.MoveRight();
					if (this.IsCaptureSlot(num3))
					{
						num2 = num3;
						pos = this.Textpos();
					}
					while (this.CharsRight() > 0 && (c = this.RightChar()) >= '0' && c <= '9')
					{
						int num4 = (int)(c - '0');
						if (num3 > 214748364 || (num3 == 214748364 && num4 > 7))
						{
							throw this.MakeException("Capture group numbers must be less than or equal to Int32.MaxValue.");
						}
						num3 = num3 * 10 + num4;
						this.MoveRight();
						if (this.IsCaptureSlot(num3))
						{
							num2 = num3;
							pos = this.Textpos();
						}
					}
					this.Textto(pos);
					if (num2 >= 0)
					{
						return new RegexNode(13, this._options, num2);
					}
				}
				else
				{
					int num5 = this.ScanDecimal();
					if ((!flag || (this.CharsRight() > 0 && this.RightCharMoveRight() == '}')) && this.IsCaptureSlot(num5))
					{
						return new RegexNode(13, this._options, num5);
					}
				}
			}
			else if (flag && RegexCharClass.IsWordChar(c))
			{
				string capname = this.ScanCapname();
				if (this.CharsRight() > 0 && this.RightCharMoveRight() == '}' && this.IsCaptureName(capname))
				{
					return new RegexNode(13, this._options, this.CaptureSlotFromName(capname));
				}
			}
			else if (!flag)
			{
				int num6 = 1;
				if (c <= '+')
				{
					switch (c)
					{
					case '$':
						this.MoveRight();
						return new RegexNode(9, this._options, '$');
					case '%':
						break;
					case '&':
						num6 = 0;
						break;
					case '\'':
						num6 = -2;
						break;
					default:
						if (c == '+')
						{
							num6 = -3;
						}
						break;
					}
				}
				else if (c != '_')
				{
					if (c == '`')
					{
						num6 = -1;
					}
				}
				else
				{
					num6 = -4;
				}
				if (num6 != 1)
				{
					this.MoveRight();
					return new RegexNode(13, this._options, num6);
				}
			}
			this.Textto(num);
			return new RegexNode(9, this._options, '$');
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00021780 File Offset: 0x0001F980
		private string ScanCapname()
		{
			int num = this.Textpos();
			while (this.CharsRight() > 0)
			{
				if (!RegexCharClass.IsWordChar(this.RightCharMoveRight()))
				{
					this.MoveLeft();
					break;
				}
			}
			return this._pattern.Substring(num, this.Textpos() - num);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000217C8 File Offset: 0x0001F9C8
		private char ScanOctal()
		{
			int num = 3;
			if (num > this.CharsRight())
			{
				num = this.CharsRight();
			}
			int num2 = 0;
			int num3;
			while (num > 0 && (num3 = (int)(this.RightChar() - '0')) <= 7)
			{
				this.MoveRight();
				num2 *= 8;
				num2 += num3;
				if (this.UseOptionE() && num2 >= 32)
				{
					break;
				}
				num--;
			}
			num2 &= 255;
			return (char)num2;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00021828 File Offset: 0x0001FA28
		private int ScanDecimal()
		{
			int num = 0;
			int num2;
			while (this.CharsRight() > 0 && (num2 = (int)((ushort)(this.RightChar() - '0'))) <= 9)
			{
				this.MoveRight();
				if (num > 214748364 || (num == 214748364 && num2 > 7))
				{
					throw this.MakeException("Capture group numbers must be less than or equal to Int32.MaxValue.");
				}
				num *= 10;
				num += num2;
			}
			return num;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00021884 File Offset: 0x0001FA84
		private char ScanHex(int c)
		{
			int num = 0;
			if (this.CharsRight() >= c)
			{
				int num2;
				while (c > 0 && (num2 = RegexParser.HexDigit(this.RightCharMoveRight())) >= 0)
				{
					num *= 16;
					num += num2;
					c--;
				}
			}
			if (c > 0)
			{
				throw this.MakeException("Insufficient hexadecimal digits.");
			}
			return (char)num;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000218D4 File Offset: 0x0001FAD4
		private static int HexDigit(char ch)
		{
			int num;
			if ((num = (int)(ch - '0')) <= 9)
			{
				return num;
			}
			if ((num = (int)(ch - 'a')) <= 5)
			{
				return num + 10;
			}
			if ((num = (int)(ch - 'A')) <= 5)
			{
				return num + 10;
			}
			return -1;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0002190C File Offset: 0x0001FB0C
		private char ScanControl()
		{
			if (this.CharsRight() <= 0)
			{
				throw this.MakeException("Missing control character.");
			}
			char c = this.RightCharMoveRight();
			if (c >= 'a' && c <= 'z')
			{
				c -= ' ';
			}
			if ((c -= '@') < ' ')
			{
				return c;
			}
			throw this.MakeException("Unrecognized control character.");
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0002195D File Offset: 0x0001FB5D
		private bool IsOnlyTopOption(RegexOptions option)
		{
			return option == RegexOptions.RightToLeft || option == RegexOptions.CultureInvariant || option == RegexOptions.ECMAScript;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00021978 File Offset: 0x0001FB78
		private void ScanOptions()
		{
			bool flag = false;
			while (this.CharsRight() > 0)
			{
				char c = this.RightChar();
				if (c == '-')
				{
					flag = true;
				}
				else if (c == '+')
				{
					flag = false;
				}
				else
				{
					RegexOptions regexOptions = RegexParser.OptionFromCode(c);
					if (regexOptions == RegexOptions.None || this.IsOnlyTopOption(regexOptions))
					{
						return;
					}
					if (flag)
					{
						this._options &= ~regexOptions;
					}
					else
					{
						this._options |= regexOptions;
					}
				}
				this.MoveRight();
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000219E8 File Offset: 0x0001FBE8
		private char ScanCharEscape()
		{
			char c = this.RightCharMoveRight();
			if (c >= '0' && c <= '7')
			{
				this.MoveLeft();
				return this.ScanOctal();
			}
			switch (c)
			{
			case 'a':
				return '\a';
			case 'b':
				return '\b';
			case 'c':
				return this.ScanControl();
			case 'd':
				break;
			case 'e':
				return '\u001b';
			case 'f':
				return '\f';
			default:
				switch (c)
				{
				case 'n':
					return '\n';
				case 'r':
					return '\r';
				case 't':
					return '\t';
				case 'u':
					return this.ScanHex(4);
				case 'v':
					return '\v';
				case 'x':
					return this.ScanHex(2);
				}
				break;
			}
			if (!this.UseOptionE() && RegexCharClass.IsWordChar(c))
			{
				throw this.MakeException(SR.Format("Unrecognized escape sequence \\{0}.", c.ToString()));
			}
			return c;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00021AC4 File Offset: 0x0001FCC4
		private string ParseProperty()
		{
			if (this.CharsRight() < 3)
			{
				throw this.MakeException("Incomplete \\p{X} character escape.");
			}
			char c = this.RightCharMoveRight();
			if (c != '{')
			{
				throw this.MakeException("Malformed \\p{X} character escape.");
			}
			int num = this.Textpos();
			while (this.CharsRight() > 0)
			{
				c = this.RightCharMoveRight();
				if (!RegexCharClass.IsWordChar(c) && c != '-')
				{
					this.MoveLeft();
					break;
				}
			}
			string result = this._pattern.Substring(num, this.Textpos() - num);
			if (this.CharsRight() == 0 || this.RightCharMoveRight() != '}')
			{
				throw this.MakeException("Incomplete \\p{X} character escape.");
			}
			return result;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00021B60 File Offset: 0x0001FD60
		private int TypeFromCode(char ch)
		{
			if (ch <= 'G')
			{
				if (ch == 'A')
				{
					return 18;
				}
				if (ch != 'B')
				{
					if (ch == 'G')
					{
						return 19;
					}
				}
				else
				{
					if (!this.UseOptionE())
					{
						return 17;
					}
					return 42;
				}
			}
			else
			{
				if (ch == 'Z')
				{
					return 20;
				}
				if (ch != 'b')
				{
					if (ch == 'z')
					{
						return 21;
					}
				}
				else
				{
					if (!this.UseOptionE())
					{
						return 16;
					}
					return 41;
				}
			}
			return 22;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00021BC0 File Offset: 0x0001FDC0
		private static RegexOptions OptionFromCode(char ch)
		{
			if (ch >= 'A' && ch <= 'Z')
			{
				ch += ' ';
			}
			if (ch <= 'i')
			{
				if (ch == 'e')
				{
					return RegexOptions.ECMAScript;
				}
				if (ch == 'i')
				{
					return RegexOptions.IgnoreCase;
				}
			}
			else
			{
				switch (ch)
				{
				case 'm':
					return RegexOptions.Multiline;
				case 'n':
					return RegexOptions.ExplicitCapture;
				case 'o':
				case 'p':
				case 'q':
					break;
				case 'r':
					return RegexOptions.RightToLeft;
				case 's':
					return RegexOptions.Singleline;
				default:
					if (ch == 'x')
					{
						return RegexOptions.IgnorePatternWhitespace;
					}
					break;
				}
			}
			return RegexOptions.None;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00021C34 File Offset: 0x0001FE34
		private void CountCaptures()
		{
			this.NoteCaptureSlot(0, 0);
			this._autocap = 1;
			while (this.CharsRight() > 0)
			{
				int pos = this.Textpos();
				char c = this.RightCharMoveRight();
				if (c <= '(')
				{
					if (c != '#')
					{
						if (c == '(')
						{
							if (this.CharsRight() >= 2 && this.RightChar(1) == '#' && this.RightChar() == '?')
							{
								this.MoveLeft();
								this.ScanBlank();
							}
							else
							{
								this.PushOptions();
								if (this.CharsRight() > 0 && this.RightChar() == '?')
								{
									this.MoveRight();
									if (this.CharsRight() > 1 && (this.RightChar() == '<' || this.RightChar() == '\''))
									{
										this.MoveRight();
										c = this.RightChar();
										if (c != '0' && RegexCharClass.IsWordChar(c))
										{
											if (c >= '1' && c <= '9')
											{
												this.NoteCaptureSlot(this.ScanDecimal(), pos);
											}
											else
											{
												this.NoteCaptureName(this.ScanCapname(), pos);
											}
										}
									}
									else
									{
										this.ScanOptions();
										if (this.CharsRight() > 0)
										{
											if (this.RightChar() == ')')
											{
												this.MoveRight();
												this.PopKeepOptions();
											}
											else if (this.RightChar() == '(')
											{
												this._ignoreNextParen = true;
												continue;
											}
										}
									}
								}
								else if (!this.UseOptionN() && !this._ignoreNextParen)
								{
									int autocap = this._autocap;
									this._autocap = autocap + 1;
									this.NoteCaptureSlot(autocap, pos);
								}
							}
							this._ignoreNextParen = false;
						}
					}
					else if (this.UseOptionX())
					{
						this.MoveLeft();
						this.ScanBlank();
					}
				}
				else if (c != ')')
				{
					if (c != '[')
					{
						if (c == '\\' && this.CharsRight() > 0)
						{
							this.ScanBackslash(true);
						}
					}
					else
					{
						this.ScanCharClass(false, true);
					}
				}
				else if (!this.EmptyOptionsStack())
				{
					this.PopOptions();
				}
			}
			this.AssignNameSlots();
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00021E18 File Offset: 0x00020018
		private void NoteCaptureSlot(int i, int pos)
		{
			if (!this._caps.ContainsKey(i))
			{
				this._caps.Add(i, pos);
				this._capcount++;
				if (this._captop <= i)
				{
					if (i == 2147483647)
					{
						this._captop = i;
						return;
					}
					this._captop = i + 1;
				}
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00021E80 File Offset: 0x00020080
		private void NoteCaptureName(string name, int pos)
		{
			if (this._capnames == null)
			{
				this._capnames = new Hashtable();
				this._capnamelist = new List<string>();
			}
			if (!this._capnames.ContainsKey(name))
			{
				this._capnames.Add(name, pos);
				this._capnamelist.Add(name);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00021ED7 File Offset: 0x000200D7
		private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames)
		{
			this._caps = caps;
			this._capsize = capsize;
			this._capnames = capnames;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00021EF0 File Offset: 0x000200F0
		private void AssignNameSlots()
		{
			if (this._capnames != null)
			{
				for (int i = 0; i < this._capnamelist.Count; i++)
				{
					while (this.IsCaptureSlot(this._autocap))
					{
						this._autocap++;
					}
					string key = this._capnamelist[i];
					int pos = (int)this._capnames[key];
					this._capnames[key] = this._autocap;
					this.NoteCaptureSlot(this._autocap, pos);
					this._autocap++;
				}
			}
			if (this._capcount < this._captop)
			{
				this._capnumlist = new int[this._capcount];
				int num = 0;
				IDictionaryEnumerator enumerator = this._caps.GetEnumerator();
				while (enumerator.MoveNext())
				{
					this._capnumlist[num++] = (int)enumerator.Key;
				}
				Array.Sort<int>(this._capnumlist, Comparer<int>.Default);
			}
			if (this._capnames != null || this._capnumlist != null)
			{
				int num2 = 0;
				List<string> list;
				int num3;
				if (this._capnames == null)
				{
					list = null;
					this._capnames = new Hashtable();
					this._capnamelist = new List<string>();
					num3 = -1;
				}
				else
				{
					list = this._capnamelist;
					this._capnamelist = new List<string>();
					num3 = (int)this._capnames[list[0]];
				}
				for (int j = 0; j < this._capcount; j++)
				{
					int num4 = (this._capnumlist == null) ? j : this._capnumlist[j];
					if (num3 == num4)
					{
						this._capnamelist.Add(list[num2++]);
						num3 = ((num2 == list.Count) ? -1 : ((int)this._capnames[list[num2]]));
					}
					else
					{
						string text = Convert.ToString(num4, this._culture);
						this._capnamelist.Add(text);
						this._capnames[text] = num4;
					}
				}
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00022101 File Offset: 0x00020301
		private int CaptureSlotFromName(string capname)
		{
			return (int)this._capnames[capname];
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00022114 File Offset: 0x00020314
		private bool IsCaptureSlot(int i)
		{
			if (this._caps != null)
			{
				return this._caps.ContainsKey(i);
			}
			return i >= 0 && i < this._capsize;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002213F File Offset: 0x0002033F
		private bool IsCaptureName(string capname)
		{
			return this._capnames != null && this._capnames.ContainsKey(capname);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00022157 File Offset: 0x00020357
		private bool UseOptionN()
		{
			return (this._options & RegexOptions.ExplicitCapture) > RegexOptions.None;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00022164 File Offset: 0x00020364
		private bool UseOptionI()
		{
			return (this._options & RegexOptions.IgnoreCase) > RegexOptions.None;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00022171 File Offset: 0x00020371
		private bool UseOptionM()
		{
			return (this._options & RegexOptions.Multiline) > RegexOptions.None;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002217E File Offset: 0x0002037E
		private bool UseOptionS()
		{
			return (this._options & RegexOptions.Singleline) > RegexOptions.None;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002218C File Offset: 0x0002038C
		private bool UseOptionX()
		{
			return (this._options & RegexOptions.IgnorePatternWhitespace) > RegexOptions.None;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002219A File Offset: 0x0002039A
		private bool UseOptionE()
		{
			return (this._options & RegexOptions.ECMAScript) > RegexOptions.None;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000221AB File Offset: 0x000203AB
		private static bool IsSpecial(char ch)
		{
			return ch <= '|' && RegexParser.s_category[(int)ch] >= 4;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000221C1 File Offset: 0x000203C1
		private static bool IsStopperX(char ch)
		{
			return ch <= '|' && RegexParser.s_category[(int)ch] >= 2;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000221D7 File Offset: 0x000203D7
		private static bool IsQuantifier(char ch)
		{
			return ch <= '{' && RegexParser.s_category[(int)ch] >= 5;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000221F0 File Offset: 0x000203F0
		private bool IsTrueQuantifier()
		{
			int num = this.CharsRight();
			if (num == 0)
			{
				return false;
			}
			int num2 = this.Textpos();
			char c = this.CharAt(num2);
			if (c != '{')
			{
				return c <= '{' && RegexParser.s_category[(int)c] >= 5;
			}
			int num3 = num2;
			while (--num > 0 && (c = this.CharAt(++num3)) >= '0' && c <= '9')
			{
			}
			if (num == 0 || num3 - num2 == 1)
			{
				return false;
			}
			if (c == '}')
			{
				return true;
			}
			if (c != ',')
			{
				return false;
			}
			while (--num > 0 && (c = this.CharAt(++num3)) >= '0' && c <= '9')
			{
			}
			return num > 0 && c == '}';
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00022294 File Offset: 0x00020494
		private static bool IsSpace(char ch)
		{
			return ch <= ' ' && RegexParser.s_category[(int)ch] == 2;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000222A8 File Offset: 0x000204A8
		private void AddConcatenate(int pos, int cch, bool isReplacement)
		{
			if (cch == 0)
			{
				return;
			}
			RegexNode newChild;
			if (cch > 1)
			{
				string text = this._pattern.Substring(pos, cch);
				if (this.UseOptionI() && !isReplacement)
				{
					StringBuilder stringBuilder = StringBuilderCache.Acquire(text.Length);
					for (int i = 0; i < text.Length; i++)
					{
						stringBuilder.Append(this._culture.TextInfo.ToLower(text[i]));
					}
					text = StringBuilderCache.GetStringAndRelease(stringBuilder);
				}
				newChild = new RegexNode(12, this._options, text);
			}
			else
			{
				char c = this._pattern[pos];
				if (this.UseOptionI() && !isReplacement)
				{
					c = this._culture.TextInfo.ToLower(c);
				}
				newChild = new RegexNode(9, this._options, c);
			}
			this._concatenation.AddChild(newChild);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00022374 File Offset: 0x00020574
		private void PushGroup()
		{
			this._group.Next = this._stack;
			this._alternation.Next = this._group;
			this._concatenation.Next = this._alternation;
			this._stack = this._concatenation;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000223C0 File Offset: 0x000205C0
		private void PopGroup()
		{
			this._concatenation = this._stack;
			this._alternation = this._concatenation.Next;
			this._group = this._alternation.Next;
			this._stack = this._group.Next;
			if (this._group.Type() == 34 && this._group.ChildCount() == 0)
			{
				if (this._unit == null)
				{
					throw this.MakeException("Illegal conditional (?(...)) expression.");
				}
				this._group.AddChild(this._unit);
				this._unit = null;
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00022454 File Offset: 0x00020654
		private bool EmptyStack()
		{
			return this._stack == null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002245F File Offset: 0x0002065F
		private void StartGroup(RegexNode openGroup)
		{
			this._group = openGroup;
			this._alternation = new RegexNode(24, this._options);
			this._concatenation = new RegexNode(25, this._options);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00022490 File Offset: 0x00020690
		private void AddAlternate()
		{
			if (this._group.Type() == 34 || this._group.Type() == 33)
			{
				this._group.AddChild(this._concatenation.ReverseLeft());
			}
			else
			{
				this._alternation.AddChild(this._concatenation.ReverseLeft());
			}
			this._concatenation = new RegexNode(25, this._options);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000224FC File Offset: 0x000206FC
		private void AddConcatenate()
		{
			this._concatenation.AddChild(this._unit);
			this._unit = null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00022516 File Offset: 0x00020716
		private void AddConcatenate(bool lazy, int min, int max)
		{
			this._concatenation.AddChild(this._unit.MakeQuantifier(lazy, min, max));
			this._unit = null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00022538 File Offset: 0x00020738
		private RegexNode Unit()
		{
			return this._unit;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00022540 File Offset: 0x00020740
		private void AddUnitOne(char ch)
		{
			if (this.UseOptionI())
			{
				ch = this._culture.TextInfo.ToLower(ch);
			}
			this._unit = new RegexNode(9, this._options, ch);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00022571 File Offset: 0x00020771
		private void AddUnitNotone(char ch)
		{
			if (this.UseOptionI())
			{
				ch = this._culture.TextInfo.ToLower(ch);
			}
			this._unit = new RegexNode(10, this._options, ch);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000225A2 File Offset: 0x000207A2
		private void AddUnitSet(string cc)
		{
			this._unit = new RegexNode(11, this._options, cc);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000225B8 File Offset: 0x000207B8
		private void AddUnitNode(RegexNode node)
		{
			this._unit = node;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000225C1 File Offset: 0x000207C1
		private void AddUnitType(int type)
		{
			this._unit = new RegexNode(type, this._options);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000225D8 File Offset: 0x000207D8
		private void AddGroup()
		{
			if (this._group.Type() == 34 || this._group.Type() == 33)
			{
				this._group.AddChild(this._concatenation.ReverseLeft());
				if ((this._group.Type() == 33 && this._group.ChildCount() > 2) || this._group.ChildCount() > 3)
				{
					throw this.MakeException("Too many | in (?()|).");
				}
			}
			else
			{
				this._alternation.AddChild(this._concatenation.ReverseLeft());
				this._group.AddChild(this._alternation);
			}
			this._unit = this._group;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00022683 File Offset: 0x00020883
		private void PushOptions()
		{
			this._optionsStack.Add(this._options);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00022696 File Offset: 0x00020896
		private void PopOptions()
		{
			this._options = this._optionsStack[this._optionsStack.Count - 1];
			this._optionsStack.RemoveAt(this._optionsStack.Count - 1);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000226CE File Offset: 0x000208CE
		private bool EmptyOptionsStack()
		{
			return this._optionsStack.Count == 0;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000226DE File Offset: 0x000208DE
		private void PopKeepOptions()
		{
			this._optionsStack.RemoveAt(this._optionsStack.Count - 1);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000226F8 File Offset: 0x000208F8
		private ArgumentException MakeException(string message)
		{
			return new ArgumentException(SR.Format("parsing \"{0}\" - {1}", this._pattern, message));
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00022710 File Offset: 0x00020910
		private int Textpos()
		{
			return this._currentPos;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00022718 File Offset: 0x00020918
		private void Textto(int pos)
		{
			this._currentPos = pos;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00022724 File Offset: 0x00020924
		private char RightCharMoveRight()
		{
			string pattern = this._pattern;
			int currentPos = this._currentPos;
			this._currentPos = currentPos + 1;
			return pattern[currentPos];
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0002274D File Offset: 0x0002094D
		private void MoveRight()
		{
			this.MoveRight(1);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00022756 File Offset: 0x00020956
		private void MoveRight(int i)
		{
			this._currentPos += i;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00022766 File Offset: 0x00020966
		private void MoveLeft()
		{
			this._currentPos--;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00022776 File Offset: 0x00020976
		private char CharAt(int i)
		{
			return this._pattern[i];
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00022784 File Offset: 0x00020984
		internal char RightChar()
		{
			return this._pattern[this._currentPos];
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00022797 File Offset: 0x00020997
		private char RightChar(int i)
		{
			return this._pattern[this._currentPos + i];
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000227AC File Offset: 0x000209AC
		private int CharsRight()
		{
			return this._pattern.Length - this._currentPos;
		}

		// Token: 0x04000363 RID: 867
		private RegexNode _stack;

		// Token: 0x04000364 RID: 868
		private RegexNode _group;

		// Token: 0x04000365 RID: 869
		private RegexNode _alternation;

		// Token: 0x04000366 RID: 870
		private RegexNode _concatenation;

		// Token: 0x04000367 RID: 871
		private RegexNode _unit;

		// Token: 0x04000368 RID: 872
		private string _pattern;

		// Token: 0x04000369 RID: 873
		private int _currentPos;

		// Token: 0x0400036A RID: 874
		private CultureInfo _culture;

		// Token: 0x0400036B RID: 875
		private int _autocap;

		// Token: 0x0400036C RID: 876
		private int _capcount;

		// Token: 0x0400036D RID: 877
		private int _captop;

		// Token: 0x0400036E RID: 878
		private int _capsize;

		// Token: 0x0400036F RID: 879
		private Hashtable _caps;

		// Token: 0x04000370 RID: 880
		private Hashtable _capnames;

		// Token: 0x04000371 RID: 881
		private int[] _capnumlist;

		// Token: 0x04000372 RID: 882
		private List<string> _capnamelist;

		// Token: 0x04000373 RID: 883
		private RegexOptions _options;

		// Token: 0x04000374 RID: 884
		private List<RegexOptions> _optionsStack;

		// Token: 0x04000375 RID: 885
		private bool _ignoreNextParen;

		// Token: 0x04000376 RID: 886
		private static readonly byte[] s_category = new byte[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			2,
			2,
			0,
			2,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			2,
			0,
			0,
			3,
			4,
			0,
			0,
			0,
			4,
			4,
			5,
			5,
			0,
			0,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			4,
			4,
			0,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			5,
			4,
			0,
			0,
			0
		};
	}
}
