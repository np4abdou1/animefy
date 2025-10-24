using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Linq
{
	// Token: 0x02000032 RID: 50
	[DebuggerDisplay("Key = {Key}")]
	[DebuggerTypeProxy(typeof(SystemLinq_GroupingDebugView<, >))]
	internal class Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
	{
		// Token: 0x0600014A RID: 330 RVA: 0x000072DD File Offset: 0x000054DD
		internal Grouping()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000072E8 File Offset: 0x000054E8
		internal void Add(TElement element)
		{
			if (this._elements.Length == this._count)
			{
				Array.Resize<TElement>(ref this._elements, checked(this._count * 2));
			}
			this._elements[this._count] = element;
			this._count++;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00007338 File Offset: 0x00005538
		public IEnumerator<TElement> GetEnumerator()
		{
			int num;
			for (int i = 0; i < this._count; i = num + 1)
			{
				yield return this._elements[i];
				num = i;
			}
			yield break;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007347 File Offset: 0x00005547
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000734F File Offset: 0x0000554F
		int ICollection<!1>.Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00007357 File Offset: 0x00005557
		bool ICollection<!1>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000532B File Offset: 0x0000352B
		void ICollection<!1>.Add(TElement item)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000532B File Offset: 0x0000352B
		void ICollection<!1>.Clear()
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000735A File Offset: 0x0000555A
		bool ICollection<!1>.Contains(TElement item)
		{
			return Array.IndexOf<TElement>(this._elements, item, 0, this._count) >= 0;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00007375 File Offset: 0x00005575
		void ICollection<!1>.CopyTo(TElement[] array, int arrayIndex)
		{
			Array.Copy(this._elements, 0, array, arrayIndex, this._count);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000532B File Offset: 0x0000352B
		bool ICollection<!1>.Remove(TElement item)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000738B File Offset: 0x0000558B
		int IList<!1>.IndexOf(TElement item)
		{
			return Array.IndexOf<TElement>(this._elements, item, 0, this._count);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000532B File Offset: 0x0000352B
		void IList<!1>.Insert(int index, TElement item)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000532B File Offset: 0x0000352B
		void IList<!1>.RemoveAt(int index)
		{
			throw Error.NotSupported();
		}

		// Token: 0x17000010 RID: 16
		TElement IList<!1>.this[int index]
		{
			get
			{
				if (index < 0 || index >= this._count)
				{
					throw Error.ArgumentOutOfRange("index");
				}
				return this._elements[index];
			}
			set
			{
				throw Error.NotSupported();
			}
		}

		// Token: 0x04000057 RID: 87
		internal TKey _key;

		// Token: 0x04000058 RID: 88
		internal int _hashCode;

		// Token: 0x04000059 RID: 89
		internal TElement[] _elements;

		// Token: 0x0400005A RID: 90
		internal int _count;

		// Token: 0x0400005B RID: 91
		internal Grouping<TKey, TElement> _hashNext;

		// Token: 0x0400005C RID: 92
		internal Grouping<TKey, TElement> _next;
	}
}
