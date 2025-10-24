using System;

namespace System.Xml.Schema
{
	// Token: 0x02000241 RID: 577
	internal sealed class StarNode : InteriorNode
	{
		// Token: 0x060012CD RID: 4813 RVA: 0x0007249C File Offset: 0x0007069C
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			base.LeftChild.ConstructPos(firstpos, lastpos, followpos);
			for (int num = lastpos.NextSet(-1); num != -1; num = lastpos.NextSet(num))
			{
				followpos[num].Or(firstpos);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool IsNullable
		{
			get
			{
				return true;
			}
		}
	}
}
