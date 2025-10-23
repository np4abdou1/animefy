using System;

namespace System.Xml.Schema
{
	// Token: 0x0200023E RID: 574
	internal sealed class ChoiceNode : InteriorNode
	{
		// Token: 0x060012C2 RID: 4802 RVA: 0x00072370 File Offset: 0x00070570
		private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			BitSet bitSet = new BitSet(firstpos.Count);
			BitSet bitSet2 = new BitSet(lastpos.Count);
			child.ConstructPos(bitSet, bitSet2, followpos);
			firstpos.Or(bitSet);
			lastpos.Or(bitSet2);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000723AC File Offset: 0x000705AC
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			BitSet bitSet = new BitSet(firstpos.Count);
			BitSet bitSet2 = new BitSet(lastpos.Count);
			ChoiceNode choiceNode = this;
			SyntaxTreeNode leftChild;
			do
			{
				ChoiceNode.ConstructChildPos(choiceNode.RightChild, bitSet, bitSet2, followpos);
				leftChild = choiceNode.LeftChild;
				choiceNode = (leftChild as ChoiceNode);
			}
			while (choiceNode != null);
			leftChild.ConstructPos(firstpos, lastpos, followpos);
			firstpos.Or(bitSet);
			lastpos.Or(bitSet2);
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0007240C File Offset: 0x0007060C
		public override bool IsNullable
		{
			get
			{
				ChoiceNode choiceNode = this;
				while (!choiceNode.RightChild.IsNullable)
				{
					SyntaxTreeNode leftChild = choiceNode.LeftChild;
					choiceNode = (leftChild as ChoiceNode);
					if (choiceNode == null)
					{
						return leftChild.IsNullable;
					}
				}
				return true;
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00072335 File Offset: 0x00070535
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			base.ExpandTreeNoRecursive(parent, symbols, positions);
		}
	}
}
