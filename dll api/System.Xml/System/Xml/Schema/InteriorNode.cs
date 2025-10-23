using System;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x0200023B RID: 571
	internal abstract class InteriorNode : SyntaxTreeNode
	{
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00072094 File Offset: 0x00070294
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0007209C File Offset: 0x0007029C
		public SyntaxTreeNode LeftChild
		{
			get
			{
				return this.leftChild;
			}
			set
			{
				this.leftChild = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x000720A5 File Offset: 0x000702A5
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x000720AD File Offset: 0x000702AD
		public SyntaxTreeNode RightChild
		{
			get
			{
				return this.rightChild;
			}
			set
			{
				this.rightChild = value;
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000720B8 File Offset: 0x000702B8
		protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			Stack<InteriorNode> stack = new Stack<InteriorNode>();
			InteriorNode interiorNode = this;
			while (interiorNode.leftChild is ChoiceNode || interiorNode.leftChild is SequenceNode)
			{
				stack.Push(interiorNode);
				interiorNode = (InteriorNode)interiorNode.leftChild;
			}
			interiorNode.leftChild.ExpandTree(interiorNode, symbols, positions);
			for (;;)
			{
				if (interiorNode.rightChild != null)
				{
					interiorNode.rightChild.ExpandTree(interiorNode, symbols, positions);
				}
				if (stack.Count == 0)
				{
					break;
				}
				interiorNode = stack.Pop();
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00072131 File Offset: 0x00070331
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			this.leftChild.ExpandTree(this, symbols, positions);
			if (this.rightChild != null)
			{
				this.rightChild.ExpandTree(this, symbols, positions);
			}
		}

		// Token: 0x04000C9D RID: 3229
		private SyntaxTreeNode leftChild;

		// Token: 0x04000C9E RID: 3230
		private SyntaxTreeNode rightChild;
	}
}
