using System;

namespace System.Xml.Schema
{
	// Token: 0x02000240 RID: 576
	internal sealed class QmarkNode : InteriorNode
	{
		// Token: 0x060012CA RID: 4810 RVA: 0x0007248B File Offset: 0x0007068B
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			base.LeftChild.ConstructPos(firstpos, lastpos, followpos);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool IsNullable
		{
			get
			{
				return true;
			}
		}
	}
}
