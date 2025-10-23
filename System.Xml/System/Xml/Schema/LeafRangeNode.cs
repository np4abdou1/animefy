using System;

namespace System.Xml.Schema
{
	// Token: 0x02000242 RID: 578
	internal sealed class LeafRangeNode : LeafNode
	{
		// Token: 0x060012D0 RID: 4816 RVA: 0x000724D6 File Offset: 0x000706D6
		public LeafRangeNode(decimal min, decimal max) : this(-1, min, max)
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000724E1 File Offset: 0x000706E1
		public LeafRangeNode(int pos, decimal min, decimal max) : base(pos)
		{
			this.min = min;
			this.max = max;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000724F8 File Offset: 0x000706F8
		public decimal Max
		{
			get
			{
				return this.max;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00072500 File Offset: 0x00070700
		public decimal Min
		{
			get
			{
				return this.min;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00072508 File Offset: 0x00070708
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x00072510 File Offset: 0x00070710
		public BitSet NextIteration
		{
			get
			{
				return this.nextIteration;
			}
			set
			{
				this.nextIteration = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool IsRangeNode
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00072519 File Offset: 0x00070719
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			if (parent.LeftChild.IsNullable)
			{
				this.min = 0m;
			}
		}

		// Token: 0x04000CA4 RID: 3236
		private decimal min;

		// Token: 0x04000CA5 RID: 3237
		private decimal max;

		// Token: 0x04000CA6 RID: 3238
		private BitSet nextIteration;
	}
}
