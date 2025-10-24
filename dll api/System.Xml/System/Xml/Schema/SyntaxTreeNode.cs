using System;

namespace System.Xml.Schema
{
	// Token: 0x02000238 RID: 568
	internal abstract class SyntaxTreeNode
	{
		// Token: 0x060012A6 RID: 4774
		public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

		// Token: 0x060012A7 RID: 4775
		public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060012A8 RID: 4776
		public abstract bool IsNullable { get; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool IsRangeNode
		{
			get
			{
				return false;
			}
		}
	}
}
