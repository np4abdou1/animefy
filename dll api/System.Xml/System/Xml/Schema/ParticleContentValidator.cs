using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000244 RID: 580
	internal sealed class ParticleContentValidator : ContentValidator
	{
		// Token: 0x060012E7 RID: 4839 RVA: 0x000726AC File Offset: 0x000708AC
		public ParticleContentValidator(XmlSchemaContentType contentType) : this(contentType, true)
		{
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x000726B6 File Offset: 0x000708B6
		public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck) : base(contentType)
		{
			this.enableUpaCheck = enableUpaCheck;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000434BD File Offset: 0x000416BD
		public override void InitValidation(ValidationState context)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000434BD File Offset: 0x000416BD
		public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000434BD File Offset: 0x000416BD
		public override bool CompleteValidation(ValidationState context)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000726C6 File Offset: 0x000708C6
		public void Start()
		{
			this.symbols = new SymbolsDictionary();
			this.positions = new Positions();
			this.stack = new Stack();
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000726E9 File Offset: 0x000708E9
		public void OpenGroup()
		{
			this.stack.Push(null);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x000726F8 File Offset: 0x000708F8
		public void CloseGroup()
		{
			SyntaxTreeNode syntaxTreeNode = (SyntaxTreeNode)this.stack.Pop();
			if (syntaxTreeNode == null)
			{
				return;
			}
			if (this.stack.Count == 0)
			{
				this.contentNode = syntaxTreeNode;
				this.isPartial = false;
				return;
			}
			InteriorNode interiorNode = (InteriorNode)this.stack.Pop();
			if (interiorNode != null)
			{
				interiorNode.RightChild = syntaxTreeNode;
				syntaxTreeNode = interiorNode;
				this.isPartial = true;
			}
			else
			{
				this.isPartial = false;
			}
			this.stack.Push(syntaxTreeNode);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0007276F File Offset: 0x0007096F
		public bool Exists(XmlQualifiedName name)
		{
			return this.symbols.Exists(name);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00072782 File Offset: 0x00070982
		public void AddName(XmlQualifiedName name, object particle)
		{
			this.AddLeafNode(new LeafNode(this.positions.Add(this.symbols.AddName(name, particle), particle)));
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000727A8 File Offset: 0x000709A8
		public void AddNamespaceList(NamespaceList namespaceList, object particle)
		{
			this.symbols.AddNamespaceList(namespaceList, particle, false);
			this.AddLeafNode(new NamespaceListNode(namespaceList, particle));
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000727C8 File Offset: 0x000709C8
		private void AddLeafNode(SyntaxTreeNode node)
		{
			if (this.stack.Count > 0)
			{
				InteriorNode interiorNode = (InteriorNode)this.stack.Pop();
				if (interiorNode != null)
				{
					interiorNode.RightChild = node;
					node = interiorNode;
				}
			}
			this.stack.Push(node);
			this.isPartial = true;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00072814 File Offset: 0x00070A14
		public void AddChoice()
		{
			SyntaxTreeNode leftChild = (SyntaxTreeNode)this.stack.Pop();
			InteriorNode interiorNode = new ChoiceNode();
			interiorNode.LeftChild = leftChild;
			this.stack.Push(interiorNode);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0007284C File Offset: 0x00070A4C
		public void AddSequence()
		{
			SyntaxTreeNode leftChild = (SyntaxTreeNode)this.stack.Pop();
			InteriorNode interiorNode = new SequenceNode();
			interiorNode.LeftChild = leftChild;
			this.stack.Push(interiorNode);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00072883 File Offset: 0x00070A83
		public void AddStar()
		{
			this.Closure(new StarNode());
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00072890 File Offset: 0x00070A90
		public void AddPlus()
		{
			this.Closure(new PlusNode());
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0007289D File Offset: 0x00070A9D
		public void AddQMark()
		{
			this.Closure(new QmarkNode());
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000728AC File Offset: 0x00070AAC
		public void AddLeafRange(decimal min, decimal max)
		{
			LeafRangeNode leafRangeNode = new LeafRangeNode(min, max);
			int pos = this.positions.Add(-2, leafRangeNode);
			leafRangeNode.Pos = pos;
			this.Closure(new SequenceNode
			{
				RightChild = leafRangeNode
			});
			this.minMaxNodesCount++;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000728FC File Offset: 0x00070AFC
		private void Closure(InteriorNode node)
		{
			if (this.stack.Count > 0)
			{
				SyntaxTreeNode syntaxTreeNode = (SyntaxTreeNode)this.stack.Pop();
				InteriorNode interiorNode = syntaxTreeNode as InteriorNode;
				if (this.isPartial && interiorNode != null)
				{
					node.LeftChild = interiorNode.RightChild;
					interiorNode.RightChild = node;
				}
				else
				{
					node.LeftChild = syntaxTreeNode;
					syntaxTreeNode = node;
				}
				this.stack.Push(syntaxTreeNode);
				return;
			}
			if (this.contentNode != null)
			{
				node.LeftChild = this.contentNode;
				this.contentNode = node;
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00072980 File Offset: 0x00070B80
		public ContentValidator Finish(bool useDFA)
		{
			if (this.contentNode == null)
			{
				if (base.ContentType != XmlSchemaContentType.Mixed)
				{
					return ContentValidator.Empty;
				}
				bool isOpen = base.IsOpen;
				if (!base.IsOpen)
				{
					return ContentValidator.TextOnly;
				}
				return ContentValidator.Any;
			}
			else
			{
				InteriorNode interiorNode = new SequenceNode();
				interiorNode.LeftChild = this.contentNode;
				LeafNode leafNode = new LeafNode(this.positions.Add(this.symbols.AddName(XmlQualifiedName.Empty, null), null));
				interiorNode.RightChild = leafNode;
				this.contentNode.ExpandTree(interiorNode, this.symbols, this.positions);
				int count = this.symbols.Count;
				int count2 = this.positions.Count;
				BitSet bitSet = new BitSet(count2);
				BitSet lastpos = new BitSet(count2);
				BitSet[] array = new BitSet[count2];
				for (int i = 0; i < count2; i++)
				{
					array[i] = new BitSet(count2);
				}
				interiorNode.ConstructPos(bitSet, lastpos, array);
				if (this.minMaxNodesCount > 0)
				{
					BitSet bitSet2;
					BitSet[] minmaxFollowPos = this.CalculateTotalFollowposForRangeNodes(bitSet, array, out bitSet2);
					if (this.enableUpaCheck)
					{
						this.CheckCMUPAWithLeafRangeNodes(this.GetApplicableMinMaxFollowPos(bitSet, bitSet2, minmaxFollowPos));
						for (int j = 0; j < count2; j++)
						{
							this.CheckCMUPAWithLeafRangeNodes(this.GetApplicableMinMaxFollowPos(array[j], bitSet2, minmaxFollowPos));
						}
					}
					return new RangeContentValidator(bitSet, array, this.symbols, this.positions, leafNode.Pos, base.ContentType, interiorNode.LeftChild.IsNullable, bitSet2, this.minMaxNodesCount);
				}
				int[][] array2 = null;
				if (!this.symbols.IsUpaEnforced)
				{
					if (this.enableUpaCheck)
					{
						this.CheckUniqueParticleAttribution(bitSet, array);
					}
				}
				else if (useDFA)
				{
					array2 = this.BuildTransitionTable(bitSet, array, leafNode.Pos);
				}
				if (array2 != null)
				{
					return new DfaContentValidator(array2, this.symbols, base.ContentType, base.IsOpen, interiorNode.LeftChild.IsNullable);
				}
				return new NfaContentValidator(bitSet, array, this.symbols, this.positions, leafNode.Pos, base.ContentType, base.IsOpen, interiorNode.LeftChild.IsNullable);
			}
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00072B84 File Offset: 0x00070D84
		private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals)
		{
			int count = this.positions.Count;
			posWithRangeTerminals = new BitSet(count);
			BitSet[] array = new BitSet[this.minMaxNodesCount];
			int num = 0;
			for (int i = count - 1; i >= 0; i--)
			{
				Position position = this.positions[i];
				if (position.symbol == -2)
				{
					LeafRangeNode leafRangeNode = position.particle as LeafRangeNode;
					BitSet bitSet = new BitSet(count);
					bitSet.Clear();
					bitSet.Or(followpos[i]);
					if (leafRangeNode.Min != leafRangeNode.Max)
					{
						bitSet.Or(leafRangeNode.NextIteration);
					}
					for (int num2 = bitSet.NextSet(-1); num2 != -1; num2 = bitSet.NextSet(num2))
					{
						if (num2 > i)
						{
							Position position2 = this.positions[num2];
							if (position2.symbol == -2)
							{
								LeafRangeNode leafRangeNode2 = position2.particle as LeafRangeNode;
								bitSet.Or(array[leafRangeNode2.Pos]);
							}
						}
					}
					array[num] = bitSet;
					leafRangeNode.Pos = num++;
					posWithRangeTerminals.Set(i);
				}
			}
			return array;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00072CA0 File Offset: 0x00070EA0
		private void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
		{
			object[] array = new object[this.symbols.Count];
			for (int num = curpos.NextSet(-1); num != -1; num = curpos.NextSet(num))
			{
				Position position = this.positions[num];
				int symbol = position.symbol;
				if (symbol >= 0)
				{
					if (array[symbol] != null)
					{
						throw new UpaException(array[symbol], position.particle);
					}
					array[symbol] = position.particle;
				}
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00072D0C File Offset: 0x00070F0C
		private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos)
		{
			if (curpos.Intersects(posWithRangeTerminals))
			{
				BitSet bitSet = new BitSet(this.positions.Count);
				bitSet.Or(curpos);
				bitSet.And(posWithRangeTerminals);
				curpos = curpos.Clone();
				for (int num = bitSet.NextSet(-1); num != -1; num = bitSet.NextSet(num))
				{
					LeafRangeNode leafRangeNode = this.positions[num].particle as LeafRangeNode;
					curpos.Or(minmaxFollowPos[leafRangeNode.Pos]);
				}
			}
			return curpos;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00072D88 File Offset: 0x00070F88
		private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos)
		{
			this.CheckUniqueParticleAttribution(firstpos);
			for (int i = 0; i < this.positions.Count; i++)
			{
				this.CheckUniqueParticleAttribution(followpos[i]);
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00072DBC File Offset: 0x00070FBC
		private void CheckUniqueParticleAttribution(BitSet curpos)
		{
			object[] array = new object[this.symbols.Count];
			for (int num = curpos.NextSet(-1); num != -1; num = curpos.NextSet(num))
			{
				int symbol = this.positions[num].symbol;
				if (array[symbol] == null)
				{
					array[symbol] = this.positions[num].particle;
				}
				else if (array[symbol] != this.positions[num].particle)
				{
					throw new UpaException(array[symbol], this.positions[num].particle);
				}
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00072E50 File Offset: 0x00071050
		private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos)
		{
			int count = this.positions.Count;
			int num = 8192 / count;
			int count2 = this.symbols.Count;
			ArrayList arrayList = new ArrayList();
			Hashtable hashtable = new Hashtable();
			hashtable.Add(new BitSet(count), -1);
			Queue queue = new Queue();
			int num2 = 0;
			queue.Enqueue(firstpos);
			hashtable.Add(firstpos, 0);
			arrayList.Add(new int[count2 + 1]);
			while (queue.Count > 0)
			{
				BitSet bitSet = (BitSet)queue.Dequeue();
				int[] array = (int[])arrayList[num2];
				if (bitSet[endMarkerPos])
				{
					array[count2] = 1;
				}
				for (int i = 0; i < count2; i++)
				{
					BitSet bitSet2 = new BitSet(count);
					for (int num3 = bitSet.NextSet(-1); num3 != -1; num3 = bitSet.NextSet(num3))
					{
						if (i == this.positions[num3].symbol)
						{
							bitSet2.Or(followpos[num3]);
						}
					}
					object obj = hashtable[bitSet2];
					if (obj != null)
					{
						array[i] = (int)obj;
					}
					else
					{
						int num4 = hashtable.Count - 1;
						if (num4 >= num)
						{
							return null;
						}
						queue.Enqueue(bitSet2);
						hashtable.Add(bitSet2, num4);
						arrayList.Add(new int[count2 + 1]);
						array[i] = num4;
					}
				}
				num2++;
			}
			return (int[][])arrayList.ToArray(typeof(int[]));
		}

		// Token: 0x04000CAE RID: 3246
		private SymbolsDictionary symbols;

		// Token: 0x04000CAF RID: 3247
		private Positions positions;

		// Token: 0x04000CB0 RID: 3248
		private Stack stack;

		// Token: 0x04000CB1 RID: 3249
		private SyntaxTreeNode contentNode;

		// Token: 0x04000CB2 RID: 3250
		private bool isPartial;

		// Token: 0x04000CB3 RID: 3251
		private int minMaxNodesCount;

		// Token: 0x04000CB4 RID: 3252
		private bool enableUpaCheck;
	}
}
