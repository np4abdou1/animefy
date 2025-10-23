using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200023A RID: 570
	internal class NamespaceListNode : SyntaxTreeNode
	{
		// Token: 0x060012B1 RID: 4785 RVA: 0x00071FBA File Offset: 0x000701BA
		public NamespaceListNode(NamespaceList namespaceList, object particle)
		{
			this.namespaceList = namespaceList;
			this.particle = particle;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00071FD0 File Offset: 0x000701D0
		public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols)
		{
			return symbols.GetNamespaceListSymbols(this.namespaceList);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00071FE0 File Offset: 0x000701E0
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			SyntaxTreeNode syntaxTreeNode = null;
			foreach (object obj in this.GetResolvedSymbols(symbols))
			{
				int symbol = (int)obj;
				if (symbols.GetParticle(symbol) != this.particle)
				{
					symbols.IsUpaEnforced = false;
				}
				LeafNode leafNode = new LeafNode(positions.Add(symbol, this.particle));
				if (syntaxTreeNode == null)
				{
					syntaxTreeNode = leafNode;
				}
				else
				{
					syntaxTreeNode = new ChoiceNode
					{
						LeftChild = syntaxTreeNode,
						RightChild = leafNode
					};
				}
			}
			if (parent.LeftChild == this)
			{
				parent.LeftChild = syntaxTreeNode;
				return;
			}
			parent.RightChild = syntaxTreeNode;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000434BD File Offset: 0x000416BD
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000434BD File Offset: 0x000416BD
		public override bool IsNullable
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x04000C9B RID: 3227
		protected NamespaceList namespaceList;

		// Token: 0x04000C9C RID: 3228
		protected object particle;
	}
}
