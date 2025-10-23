using System;
using System.Collections.Generic;

namespace Android.Text
{
	// Token: 0x020001BF RID: 447
	public class TextChangedEventArgs : EventArgs
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x0002A33A File Offset: 0x0002853A
		public TextChangedEventArgs(IEnumerable<char> text, int start, int before, int after)
		{
			this.text = text;
			this.start = start;
			this.before = before;
			this.after = after;
		}

		// Token: 0x0400076E RID: 1902
		private IEnumerable<char> text;

		// Token: 0x0400076F RID: 1903
		private int after;

		// Token: 0x04000770 RID: 1904
		private int before;

		// Token: 0x04000771 RID: 1905
		private int start;
	}
}
