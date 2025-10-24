using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000237 RID: 567
	internal class Positions
	{
		// Token: 0x060012A2 RID: 4770 RVA: 0x00071F34 File Offset: 0x00070134
		public int Add(int symbol, object particle)
		{
			return this.positions.Add(new Position(symbol, particle));
		}

		// Token: 0x170003E1 RID: 993
		public Position this[int pos]
		{
			get
			{
				return (Position)this.positions[pos];
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00071F60 File Offset: 0x00070160
		public int Count
		{
			get
			{
				return this.positions.Count;
			}
		}

		// Token: 0x04000C99 RID: 3225
		private ArrayList positions = new ArrayList();
	}
}
