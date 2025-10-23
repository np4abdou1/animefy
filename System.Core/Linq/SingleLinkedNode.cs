using System;

namespace System.Linq
{
	// Token: 0x02000045 RID: 69
	internal sealed class SingleLinkedNode<TSource>
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000836E File Offset: 0x0000656E
		public SingleLinkedNode(TSource item)
		{
			this.Item = item;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000837D File Offset: 0x0000657D
		private SingleLinkedNode(SingleLinkedNode<TSource> linked, TSource item)
		{
			this.Linked = linked;
			this.Item = item;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00008393 File Offset: 0x00006593
		public TSource Item { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000839B File Offset: 0x0000659B
		public SingleLinkedNode<TSource> Linked { get; }

		// Token: 0x060001C3 RID: 451 RVA: 0x000083A3 File Offset: 0x000065A3
		public SingleLinkedNode<TSource> Add(TSource item)
		{
			return new SingleLinkedNode<TSource>(this, item);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000083AC File Offset: 0x000065AC
		public SingleLinkedNode<TSource> GetNode(int index)
		{
			SingleLinkedNode<TSource> singleLinkedNode = this;
			while (index > 0)
			{
				singleLinkedNode = singleLinkedNode.Linked;
				index--;
			}
			return singleLinkedNode;
		}
	}
}
