using System;

namespace System.Xml.Schema
{
	// Token: 0x0200023F RID: 575
	internal sealed class PlusNode : InteriorNode
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x00072444 File Offset: 0x00070644
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			base.LeftChild.ConstructPos(firstpos, lastpos, followpos);
			for (int num = lastpos.NextSet(-1); num != -1; num = lastpos.NextSet(num))
			{
				followpos[num].Or(firstpos);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x0007247E File Offset: 0x0007067E
		public override bool IsNullable
		{
			get
			{
				return base.LeftChild.IsNullable;
			}
		}
	}
}
