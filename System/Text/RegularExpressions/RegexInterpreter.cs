using System;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000AF RID: 175
	internal sealed class RegexInterpreter : RegexRunner
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x0001DCF5 File Offset: 0x0001BEF5
		public RegexInterpreter(RegexCode code, CultureInfo culture)
		{
			this._code = code;
			this._culture = culture;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001DD0B File Offset: 0x0001BF0B
		protected override void InitTrackCount()
		{
			this.runtrackcount = this._code.TrackCount;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001DD1E File Offset: 0x0001BF1E
		private void Advance(int i)
		{
			this._codepos += i + 1;
			this.SetOperator(this._code.Codes[this._codepos]);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001DD48 File Offset: 0x0001BF48
		private void Goto(int newpos)
		{
			if (newpos < this._codepos)
			{
				base.EnsureStorage();
			}
			this.SetOperator(this._code.Codes[newpos]);
			this._codepos = newpos;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001DD73 File Offset: 0x0001BF73
		private void Textto(int newpos)
		{
			this.runtextpos = newpos;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001DD7C File Offset: 0x0001BF7C
		private void Trackto(int newpos)
		{
			this.runtrackpos = this.runtrack.Length - newpos;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001DD8E File Offset: 0x0001BF8E
		private int Textstart()
		{
			return this.runtextstart;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001DD96 File Offset: 0x0001BF96
		private int Textpos()
		{
			return this.runtextpos;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001DD9E File Offset: 0x0001BF9E
		private int Trackpos()
		{
			return this.runtrack.Length - this.runtrackpos;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		private void TrackPush()
		{
			int[] runtrack = this.runtrack;
			int num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack[num] = this._codepos;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0001DDDC File Offset: 0x0001BFDC
		private void TrackPush(int I1)
		{
			int[] runtrack = this.runtrack;
			int num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack[num] = I1;
			int[] runtrack2 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack2[num] = this._codepos;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001DE20 File Offset: 0x0001C020
		private void TrackPush(int I1, int I2)
		{
			int[] runtrack = this.runtrack;
			int num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack[num] = I1;
			int[] runtrack2 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack2[num] = I2;
			int[] runtrack3 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack3[num] = this._codepos;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001DE80 File Offset: 0x0001C080
		private void TrackPush(int I1, int I2, int I3)
		{
			int[] runtrack = this.runtrack;
			int num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack[num] = I1;
			int[] runtrack2 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack2[num] = I2;
			int[] runtrack3 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack3[num] = I3;
			int[] runtrack4 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack4[num] = this._codepos;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		private void TrackPush2(int I1)
		{
			int[] runtrack = this.runtrack;
			int num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack[num] = I1;
			int[] runtrack2 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack2[num] = -this._codepos;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001DF40 File Offset: 0x0001C140
		private void TrackPush2(int I1, int I2)
		{
			int[] runtrack = this.runtrack;
			int num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack[num] = I1;
			int[] runtrack2 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack2[num] = I2;
			int[] runtrack3 = this.runtrack;
			num = this.runtrackpos - 1;
			this.runtrackpos = num;
			runtrack3[num] = -this._codepos;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		private void Backtrack()
		{
			int[] runtrack = this.runtrack;
			int runtrackpos = this.runtrackpos;
			this.runtrackpos = runtrackpos + 1;
			int num = runtrack[runtrackpos];
			if (num < 0)
			{
				num = -num;
				this.SetOperator(this._code.Codes[num] | 256);
			}
			else
			{
				this.SetOperator(this._code.Codes[num] | 128);
			}
			if (num < this._codepos)
			{
				base.EnsureStorage();
			}
			this._codepos = num;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001E017 File Offset: 0x0001C217
		private void SetOperator(int op)
		{
			this._caseInsensitive = ((op & 512) != 0);
			this._rightToLeft = ((op & 64) != 0);
			this._operator = (op & -577);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001E043 File Offset: 0x0001C243
		private void TrackPop()
		{
			this.runtrackpos++;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001E053 File Offset: 0x0001C253
		private void TrackPop(int framesize)
		{
			this.runtrackpos += framesize;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001E063 File Offset: 0x0001C263
		private int TrackPeek()
		{
			return this.runtrack[this.runtrackpos - 1];
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001E074 File Offset: 0x0001C274
		private int TrackPeek(int i)
		{
			return this.runtrack[this.runtrackpos - i - 1];
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001E088 File Offset: 0x0001C288
		private void StackPush(int I1)
		{
			int[] runstack = this.runstack;
			int num = this.runstackpos - 1;
			this.runstackpos = num;
			runstack[num] = I1;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		private void StackPush(int I1, int I2)
		{
			int[] runstack = this.runstack;
			int num = this.runstackpos - 1;
			this.runstackpos = num;
			runstack[num] = I1;
			int[] runstack2 = this.runstack;
			num = this.runstackpos - 1;
			this.runstackpos = num;
			runstack2[num] = I2;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001E0EF File Offset: 0x0001C2EF
		private void StackPop()
		{
			this.runstackpos++;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001E0FF File Offset: 0x0001C2FF
		private void StackPop(int framesize)
		{
			this.runstackpos += framesize;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001E10F File Offset: 0x0001C30F
		private int StackPeek()
		{
			return this.runstack[this.runstackpos - 1];
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001E120 File Offset: 0x0001C320
		private int StackPeek(int i)
		{
			return this.runstack[this.runstackpos - i - 1];
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001E133 File Offset: 0x0001C333
		private int Operator()
		{
			return this._operator;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001E13B File Offset: 0x0001C33B
		private int Operand(int i)
		{
			return this._code.Codes[this._codepos + i + 1];
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001E153 File Offset: 0x0001C353
		private int Leftchars()
		{
			return this.runtextpos - this.runtextbeg;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001E162 File Offset: 0x0001C362
		private int Rightchars()
		{
			return this.runtextend - this.runtextpos;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001E171 File Offset: 0x0001C371
		private int Bump()
		{
			if (!this._rightToLeft)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001E17E File Offset: 0x0001C37E
		private int Forwardchars()
		{
			if (!this._rightToLeft)
			{
				return this.runtextend - this.runtextpos;
			}
			return this.runtextpos - this.runtextbeg;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		private char Forwardcharnext()
		{
			char c;
			if (!this._rightToLeft)
			{
				string runtext = this.runtext;
				int num = this.runtextpos;
				this.runtextpos = num + 1;
				c = runtext[num];
			}
			else
			{
				string runtext2 = this.runtext;
				int num = this.runtextpos - 1;
				this.runtextpos = num;
				c = runtext2[num];
			}
			char c2 = c;
			if (!this._caseInsensitive)
			{
				return c2;
			}
			return this._culture.TextInfo.ToLower(c2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001E210 File Offset: 0x0001C410
		private bool Stringmatch(string str)
		{
			int num;
			int num2;
			if (!this._rightToLeft)
			{
				if (this.runtextend - this.runtextpos < (num = str.Length))
				{
					return false;
				}
				num2 = this.runtextpos + num;
			}
			else
			{
				if (this.runtextpos - this.runtextbeg < (num = str.Length))
				{
					return false;
				}
				num2 = this.runtextpos;
			}
			if (!this._caseInsensitive)
			{
				while (num != 0)
				{
					if (str[--num] != this.runtext[--num2])
					{
						return false;
					}
				}
			}
			else
			{
				while (num != 0)
				{
					if (str[--num] != this._culture.TextInfo.ToLower(this.runtext[--num2]))
					{
						return false;
					}
				}
			}
			if (!this._rightToLeft)
			{
				num2 += str.Length;
			}
			this.runtextpos = num2;
			return true;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		private bool Refmatch(int index, int len)
		{
			int num;
			if (!this._rightToLeft)
			{
				if (this.runtextend - this.runtextpos < len)
				{
					return false;
				}
				num = this.runtextpos + len;
			}
			else
			{
				if (this.runtextpos - this.runtextbeg < len)
				{
					return false;
				}
				num = this.runtextpos;
			}
			int num2 = index + len;
			int num3 = len;
			if (!this._caseInsensitive)
			{
				while (num3-- != 0)
				{
					if (this.runtext[--num2] != this.runtext[--num])
					{
						return false;
					}
				}
			}
			else
			{
				while (num3-- != 0)
				{
					if (this._culture.TextInfo.ToLower(this.runtext[--num2]) != this._culture.TextInfo.ToLower(this.runtext[--num]))
					{
						return false;
					}
				}
			}
			if (!this._rightToLeft)
			{
				num += len;
			}
			this.runtextpos = num;
			return true;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0001E3CB File Offset: 0x0001C5CB
		private void Backwardnext()
		{
			this.runtextpos += (this._rightToLeft ? 1 : -1);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001E3E6 File Offset: 0x0001C5E6
		private char CharAt(int j)
		{
			return this.runtext[j];
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		protected override bool FindFirstChar()
		{
			if ((this._code.Anchors & 53) != 0)
			{
				if (!this._code.RightToLeft)
				{
					if (((this._code.Anchors & 1) != 0 && this.runtextpos > this.runtextbeg) || ((this._code.Anchors & 4) != 0 && this.runtextpos > this.runtextstart))
					{
						this.runtextpos = this.runtextend;
						return false;
					}
					if ((this._code.Anchors & 16) != 0 && this.runtextpos < this.runtextend - 1)
					{
						this.runtextpos = this.runtextend - 1;
					}
					else if ((this._code.Anchors & 32) != 0 && this.runtextpos < this.runtextend)
					{
						this.runtextpos = this.runtextend;
					}
				}
				else
				{
					if (((this._code.Anchors & 32) != 0 && this.runtextpos < this.runtextend) || ((this._code.Anchors & 16) != 0 && (this.runtextpos < this.runtextend - 1 || (this.runtextpos == this.runtextend - 1 && this.CharAt(this.runtextpos) != '\n'))) || ((this._code.Anchors & 4) != 0 && this.runtextpos < this.runtextstart))
					{
						this.runtextpos = this.runtextbeg;
						return false;
					}
					if ((this._code.Anchors & 1) != 0 && this.runtextpos > this.runtextbeg)
					{
						this.runtextpos = this.runtextbeg;
					}
				}
				return this._code.BMPrefix == null || this._code.BMPrefix.IsMatch(this.runtext, this.runtextpos, this.runtextbeg, this.runtextend);
			}
			if (this._code.BMPrefix != null)
			{
				this.runtextpos = this._code.BMPrefix.Scan(this.runtext, this.runtextpos, this.runtextbeg, this.runtextend);
				if (this.runtextpos == -1)
				{
					this.runtextpos = (this._code.RightToLeft ? this.runtextbeg : this.runtextend);
					return false;
				}
				return true;
			}
			else
			{
				if (this._code.FCPrefix == null)
				{
					return true;
				}
				this._rightToLeft = this._code.RightToLeft;
				this._caseInsensitive = this._code.FCPrefix.GetValueOrDefault().CaseInsensitive;
				string prefix = this._code.FCPrefix.GetValueOrDefault().Prefix;
				if (RegexCharClass.IsSingleton(prefix))
				{
					char c = RegexCharClass.SingletonChar(prefix);
					for (int i = this.Forwardchars(); i > 0; i--)
					{
						if (c == this.Forwardcharnext())
						{
							this.Backwardnext();
							return true;
						}
					}
				}
				else
				{
					for (int j = this.Forwardchars(); j > 0; j--)
					{
						if (RegexCharClass.CharInClass(this.Forwardcharnext(), prefix))
						{
							this.Backwardnext();
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
		protected override void Go()
		{
			this.Goto(0);
			int num = -1;
			for (;;)
			{
				if (num >= 0)
				{
					this.Advance(num);
					num = -1;
				}
				base.CheckTimeout();
				int num2 = this.Operator();
				switch (num2)
				{
				case 0:
				{
					int num3 = this.Operand(1);
					if (this.Forwardchars() >= num3)
					{
						char c = (char)this.Operand(0);
						while (num3-- > 0)
						{
							if (this.Forwardcharnext() != c)
							{
								goto IL_DA8;
							}
						}
						num = 2;
						continue;
					}
					break;
				}
				case 1:
				{
					int num4 = this.Operand(1);
					if (this.Forwardchars() >= num4)
					{
						char c2 = (char)this.Operand(0);
						while (num4-- > 0)
						{
							if (this.Forwardcharnext() == c2)
							{
								goto IL_DA8;
							}
						}
						num = 2;
						continue;
					}
					break;
				}
				case 2:
				{
					int num5 = this.Operand(1);
					if (this.Forwardchars() >= num5)
					{
						string set = this._code.Strings[this.Operand(0)];
						while (num5-- > 0)
						{
							if (!RegexCharClass.CharInClass(this.Forwardcharnext(), set))
							{
								goto IL_DA8;
							}
						}
						num = 2;
						continue;
					}
					break;
				}
				case 3:
				{
					int num6 = this.Operand(1);
					if (num6 > this.Forwardchars())
					{
						num6 = this.Forwardchars();
					}
					char c3 = (char)this.Operand(0);
					int i;
					for (i = num6; i > 0; i--)
					{
						if (this.Forwardcharnext() != c3)
						{
							this.Backwardnext();
							break;
						}
					}
					if (num6 > i)
					{
						this.TrackPush(num6 - i - 1, this.Textpos() - this.Bump());
					}
					num = 2;
					continue;
				}
				case 4:
				{
					int num7 = this.Operand(1);
					if (num7 > this.Forwardchars())
					{
						num7 = this.Forwardchars();
					}
					char c4 = (char)this.Operand(0);
					int j;
					for (j = num7; j > 0; j--)
					{
						if (this.Forwardcharnext() == c4)
						{
							this.Backwardnext();
							break;
						}
					}
					if (num7 > j)
					{
						this.TrackPush(num7 - j - 1, this.Textpos() - this.Bump());
					}
					num = 2;
					continue;
				}
				case 5:
				{
					int num8 = this.Operand(1);
					if (num8 > this.Forwardchars())
					{
						num8 = this.Forwardchars();
					}
					string set2 = this._code.Strings[this.Operand(0)];
					int k;
					for (k = num8; k > 0; k--)
					{
						if (!RegexCharClass.CharInClass(this.Forwardcharnext(), set2))
						{
							this.Backwardnext();
							break;
						}
					}
					if (num8 > k)
					{
						this.TrackPush(num8 - k - 1, this.Textpos() - this.Bump());
					}
					num = 2;
					continue;
				}
				case 6:
				case 7:
				{
					int num9 = this.Operand(1);
					if (num9 > this.Forwardchars())
					{
						num9 = this.Forwardchars();
					}
					if (num9 > 0)
					{
						this.TrackPush(num9 - 1, this.Textpos());
					}
					num = 2;
					continue;
				}
				case 8:
				{
					int num10 = this.Operand(1);
					if (num10 > this.Forwardchars())
					{
						num10 = this.Forwardchars();
					}
					if (num10 > 0)
					{
						this.TrackPush(num10 - 1, this.Textpos());
					}
					num = 2;
					continue;
				}
				case 9:
					if (this.Forwardchars() >= 1 && this.Forwardcharnext() == (char)this.Operand(0))
					{
						num = 1;
						continue;
					}
					break;
				case 10:
					if (this.Forwardchars() >= 1 && this.Forwardcharnext() != (char)this.Operand(0))
					{
						num = 1;
						continue;
					}
					break;
				case 11:
					if (this.Forwardchars() >= 1 && RegexCharClass.CharInClass(this.Forwardcharnext(), this._code.Strings[this.Operand(0)]))
					{
						num = 1;
						continue;
					}
					break;
				case 12:
					if (this.Stringmatch(this._code.Strings[this.Operand(0)]))
					{
						num = 1;
						continue;
					}
					break;
				case 13:
				{
					int cap = this.Operand(0);
					if (base.IsMatched(cap))
					{
						if (!this.Refmatch(base.MatchIndex(cap), base.MatchLength(cap)))
						{
							break;
						}
					}
					else if ((this.runregex.roptions & RegexOptions.ECMAScript) == RegexOptions.None)
					{
						break;
					}
					num = 1;
					continue;
				}
				case 14:
					if (this.Leftchars() <= 0 || this.CharAt(this.Textpos() - 1) == '\n')
					{
						num = 0;
						continue;
					}
					break;
				case 15:
					if (this.Rightchars() <= 0 || this.CharAt(this.Textpos()) == '\n')
					{
						num = 0;
						continue;
					}
					break;
				case 16:
					if (base.IsBoundary(this.Textpos(), this.runtextbeg, this.runtextend))
					{
						num = 0;
						continue;
					}
					break;
				case 17:
					if (!base.IsBoundary(this.Textpos(), this.runtextbeg, this.runtextend))
					{
						num = 0;
						continue;
					}
					break;
				case 18:
					if (this.Leftchars() <= 0)
					{
						num = 0;
						continue;
					}
					break;
				case 19:
					if (this.Textpos() == this.Textstart())
					{
						num = 0;
						continue;
					}
					break;
				case 20:
					if (this.Rightchars() <= 1 && (this.Rightchars() != 1 || this.CharAt(this.Textpos()) == '\n'))
					{
						num = 0;
						continue;
					}
					break;
				case 21:
					if (this.Rightchars() <= 0)
					{
						num = 0;
						continue;
					}
					break;
				case 22:
					break;
				case 23:
					this.TrackPush(this.Textpos());
					num = 1;
					continue;
				case 24:
					this.StackPop();
					if (this.Textpos() - this.StackPeek() != 0)
					{
						this.TrackPush(this.StackPeek(), this.Textpos());
						this.StackPush(this.Textpos());
						this.Goto(this.Operand(0));
						continue;
					}
					this.TrackPush2(this.StackPeek());
					num = 1;
					continue;
				case 25:
				{
					this.StackPop();
					int num11 = this.StackPeek();
					if (this.Textpos() != num11)
					{
						if (num11 != -1)
						{
							this.TrackPush(num11, this.Textpos());
						}
						else
						{
							this.TrackPush(this.Textpos(), this.Textpos());
						}
					}
					else
					{
						this.StackPush(num11);
						this.TrackPush2(this.StackPeek());
					}
					num = 1;
					continue;
				}
				case 26:
					this.StackPush(-1, this.Operand(0));
					this.TrackPush();
					num = 1;
					continue;
				case 27:
					this.StackPush(this.Textpos(), this.Operand(0));
					this.TrackPush();
					num = 1;
					continue;
				case 28:
				{
					this.StackPop(2);
					int num12 = this.StackPeek();
					int num13 = this.StackPeek(1);
					int num14 = this.Textpos() - num12;
					if (num13 >= this.Operand(1) || (num14 == 0 && num13 >= 0))
					{
						this.TrackPush2(num12, num13);
						num = 2;
						continue;
					}
					this.TrackPush(num12);
					this.StackPush(this.Textpos(), num13 + 1);
					this.Goto(this.Operand(0));
					continue;
				}
				case 29:
				{
					this.StackPop(2);
					int i2 = this.StackPeek();
					int num15 = this.StackPeek(1);
					if (num15 < 0)
					{
						this.TrackPush2(i2);
						this.StackPush(this.Textpos(), num15 + 1);
						this.Goto(this.Operand(0));
						continue;
					}
					this.TrackPush(i2, num15, this.Textpos());
					num = 2;
					continue;
				}
				case 30:
					this.StackPush(-1);
					this.TrackPush();
					num = 0;
					continue;
				case 31:
					this.StackPush(this.Textpos());
					this.TrackPush();
					num = 0;
					continue;
				case 32:
					if (this.Operand(1) == -1 || base.IsMatched(this.Operand(1)))
					{
						this.StackPop();
						if (this.Operand(1) != -1)
						{
							base.TransferCapture(this.Operand(0), this.Operand(1), this.StackPeek(), this.Textpos());
						}
						else
						{
							base.Capture(this.Operand(0), this.StackPeek(), this.Textpos());
						}
						this.TrackPush(this.StackPeek());
						num = 2;
						continue;
					}
					break;
				case 33:
					this.StackPop();
					this.TrackPush(this.StackPeek());
					this.Textto(this.StackPeek());
					num = 0;
					continue;
				case 34:
					this.StackPush(this.Trackpos(), base.Crawlpos());
					this.TrackPush();
					num = 0;
					continue;
				case 35:
					this.StackPop(2);
					this.Trackto(this.StackPeek());
					while (base.Crawlpos() != this.StackPeek(1))
					{
						base.Uncapture();
					}
					break;
				case 36:
					this.StackPop(2);
					this.Trackto(this.StackPeek());
					this.TrackPush(this.StackPeek(1));
					num = 0;
					continue;
				case 37:
					if (base.IsMatched(this.Operand(0)))
					{
						num = 1;
						continue;
					}
					break;
				case 38:
					this.Goto(this.Operand(0));
					continue;
				case 39:
					goto IL_D9D;
				case 40:
					return;
				case 41:
					if (base.IsECMABoundary(this.Textpos(), this.runtextbeg, this.runtextend))
					{
						num = 0;
						continue;
					}
					break;
				case 42:
					if (!base.IsECMABoundary(this.Textpos(), this.runtextbeg, this.runtextend))
					{
						num = 0;
						continue;
					}
					break;
				default:
					switch (num2)
					{
					case 131:
					case 132:
					{
						this.TrackPop(2);
						int num16 = this.TrackPeek();
						int num17 = this.TrackPeek(1);
						this.Textto(num17);
						if (num16 > 0)
						{
							this.TrackPush(num16 - 1, num17 - this.Bump());
						}
						num = 2;
						continue;
					}
					case 133:
					{
						this.TrackPop(2);
						int num18 = this.TrackPeek();
						int num19 = this.TrackPeek(1);
						this.Textto(num19);
						if (num18 > 0)
						{
							this.TrackPush(num18 - 1, num19 - this.Bump());
						}
						num = 2;
						continue;
					}
					case 134:
					{
						this.TrackPop(2);
						int num20 = this.TrackPeek(1);
						this.Textto(num20);
						if (this.Forwardcharnext() == (char)this.Operand(0))
						{
							int num21 = this.TrackPeek();
							if (num21 > 0)
							{
								this.TrackPush(num21 - 1, num20 + this.Bump());
							}
							num = 2;
							continue;
						}
						break;
					}
					case 135:
					{
						this.TrackPop(2);
						int num22 = this.TrackPeek(1);
						this.Textto(num22);
						if (this.Forwardcharnext() != (char)this.Operand(0))
						{
							int num23 = this.TrackPeek();
							if (num23 > 0)
							{
								this.TrackPush(num23 - 1, num22 + this.Bump());
							}
							num = 2;
							continue;
						}
						break;
					}
					case 136:
					{
						this.TrackPop(2);
						int num24 = this.TrackPeek(1);
						this.Textto(num24);
						if (RegexCharClass.CharInClass(this.Forwardcharnext(), this._code.Strings[this.Operand(0)]))
						{
							int num25 = this.TrackPeek();
							if (num25 > 0)
							{
								this.TrackPush(num25 - 1, num24 + this.Bump());
							}
							num = 2;
							continue;
						}
						break;
					}
					case 137:
					case 138:
					case 139:
					case 140:
					case 141:
					case 142:
					case 143:
					case 144:
					case 145:
					case 146:
					case 147:
					case 148:
					case 149:
					case 150:
					case 163:
						goto IL_D9D;
					case 151:
						this.TrackPop();
						this.Textto(this.TrackPeek());
						this.Goto(this.Operand(0));
						continue;
					case 152:
						this.TrackPop(2);
						this.StackPop();
						this.Textto(this.TrackPeek(1));
						this.TrackPush2(this.TrackPeek());
						num = 1;
						continue;
					case 153:
					{
						this.TrackPop(2);
						int num26 = this.TrackPeek(1);
						this.TrackPush2(this.TrackPeek());
						this.StackPush(num26);
						this.Textto(num26);
						this.Goto(this.Operand(0));
						continue;
					}
					case 154:
						this.StackPop(2);
						break;
					case 155:
						this.StackPop(2);
						break;
					case 156:
						this.TrackPop();
						this.StackPop(2);
						if (this.StackPeek(1) > 0)
						{
							this.Textto(this.StackPeek());
							this.TrackPush2(this.TrackPeek(), this.StackPeek(1) - 1);
							num = 2;
							continue;
						}
						this.StackPush(this.TrackPeek(), this.StackPeek(1) - 1);
						break;
					case 157:
					{
						this.TrackPop(3);
						int num27 = this.TrackPeek();
						int num28 = this.TrackPeek(2);
						if (this.TrackPeek(1) < this.Operand(1) && num28 != num27)
						{
							this.Textto(num28);
							this.StackPush(num28, this.TrackPeek(1) + 1);
							this.TrackPush2(num27);
							this.Goto(this.Operand(0));
							continue;
						}
						this.StackPush(this.TrackPeek(), this.TrackPeek(1));
						break;
					}
					case 158:
					case 159:
						this.StackPop();
						break;
					case 160:
						this.TrackPop();
						this.StackPush(this.TrackPeek());
						base.Uncapture();
						if (this.Operand(0) != -1 && this.Operand(1) != -1)
						{
							base.Uncapture();
						}
						break;
					case 161:
						this.TrackPop();
						this.StackPush(this.TrackPeek());
						break;
					case 162:
						this.StackPop(2);
						break;
					case 164:
						this.TrackPop();
						while (base.Crawlpos() != this.TrackPeek())
						{
							base.Uncapture();
						}
						break;
					default:
						switch (num2)
						{
						case 280:
							this.TrackPop();
							this.StackPush(this.TrackPeek());
							goto IL_DA8;
						case 281:
							this.StackPop();
							this.TrackPop();
							this.StackPush(this.TrackPeek());
							goto IL_DA8;
						case 284:
							this.TrackPop(2);
							this.StackPush(this.TrackPeek(), this.TrackPeek(1));
							goto IL_DA8;
						case 285:
							this.TrackPop();
							this.StackPop(2);
							this.StackPush(this.TrackPeek(), this.StackPeek(1) - 1);
							goto IL_DA8;
						}
						goto Block_4;
					}
					break;
				}
				IL_DA8:
				this.Backtrack();
			}
			Block_4:
			IL_D9D:
			throw NotImplemented.ByDesignWithMessage("Unimplemented state.");
		}

		// Token: 0x04000345 RID: 837
		private readonly RegexCode _code;

		// Token: 0x04000346 RID: 838
		private readonly CultureInfo _culture;

		// Token: 0x04000347 RID: 839
		private int _operator;

		// Token: 0x04000348 RID: 840
		private int _codepos;

		// Token: 0x04000349 RID: 841
		private bool _rightToLeft;

		// Token: 0x0400034A RID: 842
		private bool _caseInsensitive;
	}
}
