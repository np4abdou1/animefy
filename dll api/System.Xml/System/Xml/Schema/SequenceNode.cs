using System;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x0200023C RID: 572
	internal sealed class SequenceNode : InteriorNode
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x00072160 File Offset: 0x00070360
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			Stack<SequenceNode.SequenceConstructPosContext> stack = new Stack<SequenceNode.SequenceConstructPosContext>();
			SequenceNode.SequenceConstructPosContext sequenceConstructPosContext = new SequenceNode.SequenceConstructPosContext(this, firstpos, lastpos);
			SequenceNode this_;
			for (;;)
			{
				this_ = sequenceConstructPosContext.this_;
				sequenceConstructPosContext.lastposLeft = new BitSet(lastpos.Count);
				if (!(this_.LeftChild is SequenceNode))
				{
					break;
				}
				stack.Push(sequenceConstructPosContext);
				sequenceConstructPosContext = new SequenceNode.SequenceConstructPosContext((SequenceNode)this_.LeftChild, sequenceConstructPosContext.firstpos, sequenceConstructPosContext.lastposLeft);
			}
			this_.LeftChild.ConstructPos(sequenceConstructPosContext.firstpos, sequenceConstructPosContext.lastposLeft, followpos);
			for (;;)
			{
				sequenceConstructPosContext.firstposRight = new BitSet(firstpos.Count);
				this_.RightChild.ConstructPos(sequenceConstructPosContext.firstposRight, sequenceConstructPosContext.lastpos, followpos);
				if (this_.LeftChild.IsNullable && !this_.RightChild.IsRangeNode)
				{
					sequenceConstructPosContext.firstpos.Or(sequenceConstructPosContext.firstposRight);
				}
				if (this_.RightChild.IsNullable)
				{
					sequenceConstructPosContext.lastpos.Or(sequenceConstructPosContext.lastposLeft);
				}
				for (int num = sequenceConstructPosContext.lastposLeft.NextSet(-1); num != -1; num = sequenceConstructPosContext.lastposLeft.NextSet(num))
				{
					followpos[num].Or(sequenceConstructPosContext.firstposRight);
				}
				if (this_.RightChild.IsRangeNode)
				{
					((LeafRangeNode)this_.RightChild).NextIteration = sequenceConstructPosContext.firstpos.Clone();
				}
				if (stack.Count == 0)
				{
					break;
				}
				sequenceConstructPosContext = stack.Pop();
				this_ = sequenceConstructPosContext.this_;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x000722C8 File Offset: 0x000704C8
		public override bool IsNullable
		{
			get
			{
				SequenceNode sequenceNode = this;
				while (!sequenceNode.RightChild.IsRangeNode || !(((LeafRangeNode)sequenceNode.RightChild).Min == 0m))
				{
					if (!sequenceNode.RightChild.IsNullable && !sequenceNode.RightChild.IsRangeNode)
					{
						return false;
					}
					SyntaxTreeNode leftChild = sequenceNode.LeftChild;
					sequenceNode = (leftChild as SequenceNode);
					if (sequenceNode == null)
					{
						return leftChild.IsNullable;
					}
				}
				return true;
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00072335 File Offset: 0x00070535
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			base.ExpandTreeNoRecursive(parent, symbols, positions);
		}

		// Token: 0x0200023D RID: 573
		private struct SequenceConstructPosContext
		{
			// Token: 0x060012C1 RID: 4801 RVA: 0x00072348 File Offset: 0x00070548
			public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
			{
				this.this_ = node;
				this.firstpos = firstpos;
				this.lastpos = lastpos;
				this.lastposLeft = null;
				this.firstposRight = null;
			}

			// Token: 0x04000C9F RID: 3231
			public SequenceNode this_;

			// Token: 0x04000CA0 RID: 3232
			public BitSet firstpos;

			// Token: 0x04000CA1 RID: 3233
			public BitSet lastpos;

			// Token: 0x04000CA2 RID: 3234
			public BitSet lastposLeft;

			// Token: 0x04000CA3 RID: 3235
			public BitSet firstposRight;
		}
	}
}
