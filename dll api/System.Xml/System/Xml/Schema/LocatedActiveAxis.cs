using System;

namespace System.Xml.Schema
{
	// Token: 0x0200022E RID: 558
	internal class LocatedActiveAxis : ActiveAxis
	{
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x000712B6 File Offset: 0x0006F4B6
		internal int Column
		{
			get
			{
				return this.column;
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000712BE File Offset: 0x0006F4BE
		internal LocatedActiveAxis(Asttree astfield, KeySequence ks, int column) : base(astfield)
		{
			this.Ks = ks;
			this.column = column;
			this.isMatched = false;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000712DC File Offset: 0x0006F4DC
		internal void Reactivate(KeySequence ks)
		{
			base.Reactivate();
			this.Ks = ks;
		}

		// Token: 0x04000C79 RID: 3193
		private int column;

		// Token: 0x04000C7A RID: 3194
		internal bool isMatched;

		// Token: 0x04000C7B RID: 3195
		internal KeySequence Ks;
	}
}
