using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200009E RID: 158
	internal class MatchSparse : Match
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00016456 File Offset: 0x00014656
		internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) : base(regex, capcount, text, begpos, len, startpos)
		{
			this._caps = caps;
		}

		// Token: 0x040002A6 RID: 678
		internal new readonly Hashtable _caps;
	}
}
