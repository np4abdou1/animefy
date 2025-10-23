using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single regular expression match.</summary>
	// Token: 0x0200009D RID: 157
	[Serializable]
	public class Match : Group
	{
		// Token: 0x060003E2 RID: 994 RVA: 0x0001603C File Offset: 0x0001423C
		internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos) : base(text, new int[2], 0, "0")
		{
			this._regex = regex;
			this._matchcount = new int[capcount];
			this._matches = new int[capcount][];
			this._matches[0] = this._caps;
			this._textbeg = begpos;
			this._textend = begpos + len;
			this._textstart = startpos;
			this._balancing = false;
		}

		/// <summary>Gets the empty group. All failed matches return this empty match.</summary>
		/// <returns>An empty match.</returns>
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000160AB File Offset: 0x000142AB
		public static Match Empty { get; } = new Match(null, 1, string.Empty, 0, 0, 0);

		// Token: 0x060003E4 RID: 996 RVA: 0x000160B4 File Offset: 0x000142B4
		internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
		{
			this._regex = regex;
			base.Text = text;
			this._textbeg = textbeg;
			this._textend = textend;
			this._textstart = textstart;
			for (int i = 0; i < this._matchcount.Length; i++)
			{
				this._matchcount[i] = 0;
			}
			this._balancing = false;
		}

		/// <summary>Returns a new <see cref="T:System.Text.RegularExpressions.Match" /> object with the results for the next match, starting at the position at which the last match ended (at the character after the last matched character).</summary>
		/// <returns>The next regular expression match.</returns>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
		// Token: 0x060003E5 RID: 997 RVA: 0x00016109 File Offset: 0x00014309
		public Match NextMatch()
		{
			if (this._regex == null)
			{
				return this;
			}
			return this._regex.Run(false, base.Length, base.Text, this._textbeg, this._textend - this._textbeg, this._textpos);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00016148 File Offset: 0x00014348
		internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum)
		{
			int num = this._matchcount[groupnum];
			if (num == 0)
			{
				return string.Empty;
			}
			int[] array = this._matches[groupnum];
			return base.Text.AsSpan(array[(num - 1) * 2], array[num * 2 - 1]);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001618E File Offset: 0x0001438E
		internal ReadOnlySpan<char> LastGroupToStringImpl()
		{
			return this.GroupToStringImpl(this._matchcount.Length - 1);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000161A0 File Offset: 0x000143A0
		internal virtual void AddMatch(int cap, int start, int len)
		{
			if (this._matches[cap] == null)
			{
				this._matches[cap] = new int[2];
			}
			int num = this._matchcount[cap];
			if (num * 2 + 2 > this._matches[cap].Length)
			{
				int[] array = this._matches[cap];
				int[] array2 = new int[num * 8];
				for (int i = 0; i < num * 2; i++)
				{
					array2[i] = array[i];
				}
				this._matches[cap] = array2;
			}
			this._matches[cap][num * 2] = start;
			this._matches[cap][num * 2 + 1] = len;
			this._matchcount[cap] = num + 1;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00016238 File Offset: 0x00014438
		internal virtual void BalanceMatch(int cap)
		{
			this._balancing = true;
			int num = this._matchcount[cap] * 2 - 2;
			if (this._matches[cap][num] < 0)
			{
				num = -3 - this._matches[cap][num];
			}
			num -= 2;
			if (num >= 0 && this._matches[cap][num] < 0)
			{
				this.AddMatch(cap, this._matches[cap][num], this._matches[cap][num + 1]);
				return;
			}
			this.AddMatch(cap, -3 - num, -4 - num);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000162B6 File Offset: 0x000144B6
		internal virtual void RemoveMatch(int cap)
		{
			this._matchcount[cap]--;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000162C9 File Offset: 0x000144C9
		internal virtual bool IsMatched(int cap)
		{
			return cap < this._matchcount.Length && this._matchcount[cap] > 0 && this._matches[cap][this._matchcount[cap] * 2 - 1] != -2;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00016300 File Offset: 0x00014500
		internal virtual int MatchIndex(int cap)
		{
			int num = this._matches[cap][this._matchcount[cap] * 2 - 2];
			if (num >= 0)
			{
				return num;
			}
			return this._matches[cap][-3 - num];
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00016338 File Offset: 0x00014538
		internal virtual int MatchLength(int cap)
		{
			int num = this._matches[cap][this._matchcount[cap] * 2 - 1];
			if (num >= 0)
			{
				return num;
			}
			return this._matches[cap][-3 - num];
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00016370 File Offset: 0x00014570
		internal virtual void Tidy(int textpos)
		{
			int[] array = this._matches[0];
			base.Index = array[0];
			base.Length = array[1];
			this._textpos = textpos;
			this._capcount = this._matchcount[0];
			if (this._balancing)
			{
				for (int i = 0; i < this._matchcount.Length; i++)
				{
					int num = this._matchcount[i] * 2;
					int[] array2 = this._matches[i];
					int j = 0;
					while (j < num && array2[j] >= 0)
					{
						j++;
					}
					int num2 = j;
					while (j < num)
					{
						if (array2[j] < 0)
						{
							num2--;
						}
						else
						{
							if (j != num2)
							{
								array2[num2] = array2[j];
							}
							num2++;
						}
						j++;
					}
					this._matchcount[i] = num2 / 2;
				}
				this._balancing = false;
			}
		}

		// Token: 0x0400029D RID: 669
		internal Regex _regex;

		// Token: 0x0400029E RID: 670
		internal int _textbeg;

		// Token: 0x0400029F RID: 671
		internal int _textpos;

		// Token: 0x040002A0 RID: 672
		internal int _textend;

		// Token: 0x040002A1 RID: 673
		internal int _textstart;

		// Token: 0x040002A2 RID: 674
		internal int[][] _matches;

		// Token: 0x040002A3 RID: 675
		internal int[] _matchcount;

		// Token: 0x040002A4 RID: 676
		internal bool _balancing;
	}
}
