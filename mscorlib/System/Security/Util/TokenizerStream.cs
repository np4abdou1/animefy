using System;

namespace System.Security.Util
{
	// Token: 0x02000291 RID: 657
	internal sealed class TokenizerStream
	{
		// Token: 0x060016AC RID: 5804 RVA: 0x0005D582 File Offset: 0x0005B782
		internal TokenizerStream()
		{
			this.m_countTokens = 0;
			this.m_headTokens = new TokenizerShortBlock();
			this.m_headStrings = new TokenizerStringBlock();
			this.Reset();
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0005D5B0 File Offset: 0x0005B7B0
		internal void AddToken(short token)
		{
			if (this.m_currentTokens.m_block.Length <= this.m_indexTokens)
			{
				this.m_currentTokens.m_next = new TokenizerShortBlock();
				this.m_currentTokens = this.m_currentTokens.m_next;
				this.m_indexTokens = 0;
			}
			this.m_countTokens++;
			short[] block = this.m_currentTokens.m_block;
			int indexTokens = this.m_indexTokens;
			this.m_indexTokens = indexTokens + 1;
			block[indexTokens] = token;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0005D628 File Offset: 0x0005B828
		internal void AddString(string str)
		{
			if (this.m_currentStrings.m_block.Length <= this.m_indexStrings)
			{
				this.m_currentStrings.m_next = new TokenizerStringBlock();
				this.m_currentStrings = this.m_currentStrings.m_next;
				this.m_indexStrings = 0;
			}
			string[] block = this.m_currentStrings.m_block;
			int indexStrings = this.m_indexStrings;
			this.m_indexStrings = indexStrings + 1;
			block[indexStrings] = str;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0005D690 File Offset: 0x0005B890
		internal void Reset()
		{
			this.m_lastTokens = null;
			this.m_currentTokens = this.m_headTokens;
			this.m_currentStrings = this.m_headStrings;
			this.m_indexTokens = 0;
			this.m_indexStrings = 0;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0005D6C0 File Offset: 0x0005B8C0
		internal short GetNextFullToken()
		{
			if (this.m_currentTokens.m_block.Length <= this.m_indexTokens)
			{
				this.m_lastTokens = this.m_currentTokens;
				this.m_currentTokens = this.m_currentTokens.m_next;
				this.m_indexTokens = 0;
			}
			short[] block = this.m_currentTokens.m_block;
			int indexTokens = this.m_indexTokens;
			this.m_indexTokens = indexTokens + 1;
			return block[indexTokens];
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0005D723 File Offset: 0x0005B923
		internal short GetNextToken()
		{
			return this.GetNextFullToken() & 255;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0005D734 File Offset: 0x0005B934
		internal string GetNextString()
		{
			if (this.m_currentStrings.m_block.Length <= this.m_indexStrings)
			{
				this.m_currentStrings = this.m_currentStrings.m_next;
				this.m_indexStrings = 0;
			}
			string[] block = this.m_currentStrings.m_block;
			int indexStrings = this.m_indexStrings;
			this.m_indexStrings = indexStrings + 1;
			return block[indexStrings];
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0005D78B File Offset: 0x0005B98B
		internal void ThrowAwayNextString()
		{
			this.GetNextString();
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0005D794 File Offset: 0x0005B994
		internal void TagLastToken(short tag)
		{
			if (this.m_indexTokens == 0)
			{
				this.m_lastTokens.m_block[this.m_lastTokens.m_block.Length - 1] = (short)((ushort)this.m_lastTokens.m_block[this.m_lastTokens.m_block.Length - 1] | (ushort)tag);
				return;
			}
			this.m_currentTokens.m_block[this.m_indexTokens - 1] = (short)((ushort)this.m_currentTokens.m_block[this.m_indexTokens - 1] | (ushort)tag);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0005D812 File Offset: 0x0005BA12
		internal int GetTokenCount()
		{
			return this.m_countTokens;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0005D81C File Offset: 0x0005BA1C
		internal void GoToPosition(int position)
		{
			this.Reset();
			for (int i = 0; i < position; i++)
			{
				if (this.GetNextToken() == 3)
				{
					this.ThrowAwayNextString();
				}
			}
		}

		// Token: 0x040008EF RID: 2287
		private int m_countTokens;

		// Token: 0x040008F0 RID: 2288
		private TokenizerShortBlock m_headTokens;

		// Token: 0x040008F1 RID: 2289
		private TokenizerShortBlock m_lastTokens;

		// Token: 0x040008F2 RID: 2290
		private TokenizerShortBlock m_currentTokens;

		// Token: 0x040008F3 RID: 2291
		private int m_indexTokens;

		// Token: 0x040008F4 RID: 2292
		private TokenizerStringBlock m_headStrings;

		// Token: 0x040008F5 RID: 2293
		private TokenizerStringBlock m_currentStrings;

		// Token: 0x040008F6 RID: 2294
		private int m_indexStrings;
	}
}
