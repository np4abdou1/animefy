using System;

namespace System.Collections.Generic
{
	/// <summary>Represents a node in a <see cref="T:System.Collections.Generic.LinkedList`1" />. This class cannot be inherited.</summary>
	/// <typeparam name="T">Specifies the element type of the linked list.</typeparam>
	// Token: 0x020002D7 RID: 727
	public sealed class LinkedListNode<T>
	{
		// Token: 0x06001399 RID: 5017 RVA: 0x0005BD13 File Offset: 0x00059F13
		internal LinkedListNode(LinkedList<T> list, T value)
		{
			this.list = list;
			this.item = value;
		}

		/// <summary>Gets the next node in the <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <returns>A reference to the next node in the <see cref="T:System.Collections.Generic.LinkedList`1" />, or <see langword="null" /> if the current node is the last element (<see cref="P:System.Collections.Generic.LinkedList`1.Last" />) of the <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0005BD29 File Offset: 0x00059F29
		public LinkedListNode<T> Next
		{
			get
			{
				if (this.next != null && this.next != this.list.head)
				{
					return this.next;
				}
				return null;
			}
		}

		/// <summary>Gets the value contained in the node.</summary>
		/// <returns>The value contained in the node.</returns>
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0005BD4E File Offset: 0x00059F4E
		public T Value
		{
			get
			{
				return this.item;
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0005BD56 File Offset: 0x00059F56
		internal void Invalidate()
		{
			this.list = null;
			this.next = null;
			this.prev = null;
		}

		// Token: 0x04000D60 RID: 3424
		internal LinkedList<T> list;

		// Token: 0x04000D61 RID: 3425
		internal LinkedListNode<T> next;

		// Token: 0x04000D62 RID: 3426
		internal LinkedListNode<T> prev;

		// Token: 0x04000D63 RID: 3427
		internal T item;
	}
}
