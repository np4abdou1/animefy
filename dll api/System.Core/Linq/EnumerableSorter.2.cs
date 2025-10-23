using System;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x0200003F RID: 63
	internal sealed class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00007F4E File Offset: 0x0000614E
		internal EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
		{
			this._keySelector = keySelector;
			this._comparer = comparer;
			this._descending = descending;
			this._next = next;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007F74 File Offset: 0x00006174
		internal override void ComputeKeys(TElement[] elements, int count)
		{
			this._keys = new TKey[count];
			for (int i = 0; i < count; i++)
			{
				this._keys[i] = this._keySelector(elements[i]);
			}
			EnumerableSorter<TElement> next = this._next;
			if (next == null)
			{
				return;
			}
			next.ComputeKeys(elements, count);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007FCC File Offset: 0x000061CC
		internal override int CompareAnyKeys(int index1, int index2)
		{
			int num = this._comparer.Compare(this._keys[index1], this._keys[index2]);
			if (num == 0)
			{
				if (this._next == null)
				{
					return index1 - index2;
				}
				return this._next.CompareAnyKeys(index1, index2);
			}
			else
			{
				if (this._descending == num > 0)
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00008029 File Offset: 0x00006229
		protected override void QuickSort(int[] keys, int lo, int hi)
		{
			Array.Sort<int>(keys, lo, hi - lo + 1, Comparer<int>.Create(new Comparison<int>(this.CompareAnyKeys)));
		}

		// Token: 0x0400007C RID: 124
		private readonly Func<TElement, TKey> _keySelector;

		// Token: 0x0400007D RID: 125
		private readonly IComparer<TKey> _comparer;

		// Token: 0x0400007E RID: 126
		private readonly bool _descending;

		// Token: 0x0400007F RID: 127
		private readonly EnumerableSorter<TElement> _next;

		// Token: 0x04000080 RID: 128
		private TKey[] _keys;
	}
}
