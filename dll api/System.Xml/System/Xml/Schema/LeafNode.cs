using System;

namespace System.Xml.Schema
{
	// Token: 0x02000239 RID: 569
	internal class LeafNode : SyntaxTreeNode
	{
		// Token: 0x060012AB RID: 4779 RVA: 0x00071F80 File Offset: 0x00070180
		public LeafNode(int pos)
		{
			this.pos = pos;
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00071F8F File Offset: 0x0007018F
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x00071F97 File Offset: 0x00070197
		public int Pos
		{
			get
			{
				return this.pos;
			}
			set
			{
				this.pos = value;
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00008574 File Offset: 0x00006774
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00071FA0 File Offset: 0x000701A0
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			firstpos.Set(this.pos);
			lastpos.Set(this.pos);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0000A216 File Offset: 0x00008416
		public override bool IsNullable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000C9A RID: 3226
		private int pos;
	}
}
