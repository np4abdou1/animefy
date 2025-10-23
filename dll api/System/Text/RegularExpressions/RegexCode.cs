using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000AA RID: 170
	internal sealed class RegexCode
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x00019A48 File Offset: 0x00017C48
		public RegexCode(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix? fcPrefix, int anchors, bool rightToLeft)
		{
			this.Codes = codes;
			this.Strings = stringlist.ToArray();
			this.TrackCount = trackcount;
			this.Caps = caps;
			this.CapSize = capsize;
			this.BMPrefix = bmPrefix;
			this.FCPrefix = fcPrefix;
			this.Anchors = anchors;
			this.RightToLeft = rightToLeft;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00019AA8 File Offset: 0x00017CA8
		public static bool OpcodeBacktracks(int Op)
		{
			Op &= 63;
			switch (Op)
			{
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 38:
				return true;
			}
			return false;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00019B58 File Offset: 0x00017D58
		public static int OpcodeSize(int opcode)
		{
			opcode &= 63;
			switch (opcode)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 28:
			case 29:
			case 32:
				return 3;
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 37:
			case 38:
			case 39:
				return 2;
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 30:
			case 31:
			case 33:
			case 34:
			case 35:
			case 36:
			case 40:
			case 41:
			case 42:
				return 1;
			default:
				throw new ArgumentException(SR.Format("Unexpected opcode in regular expression generation: {0}.", opcode.ToString(CultureInfo.CurrentCulture)));
			}
		}

		// Token: 0x040002F9 RID: 761
		public readonly int[] Codes;

		// Token: 0x040002FA RID: 762
		public readonly string[] Strings;

		// Token: 0x040002FB RID: 763
		public readonly int TrackCount;

		// Token: 0x040002FC RID: 764
		public readonly Hashtable Caps;

		// Token: 0x040002FD RID: 765
		public readonly int CapSize;

		// Token: 0x040002FE RID: 766
		public readonly RegexPrefix? FCPrefix;

		// Token: 0x040002FF RID: 767
		public readonly RegexBoyerMoore BMPrefix;

		// Token: 0x04000300 RID: 768
		public readonly int Anchors;

		// Token: 0x04000301 RID: 769
		public readonly bool RightToLeft;
	}
}
