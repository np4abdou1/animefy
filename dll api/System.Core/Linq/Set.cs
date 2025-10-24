using System;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x02000043 RID: 67
	internal sealed class Set<TElement>
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x000080CF File Offset: 0x000062CF
		public Set(IEqualityComparer<TElement> comparer)
		{
			this._comparer = (comparer ?? EqualityComparer<TElement>.Default);
			this._buckets = new int[7];
			this._slots = new Set<TElement>.Slot[7];
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008100 File Offset: 0x00006300
		public bool Add(TElement value)
		{
			int num = this.InternalGetHashCode(value);
			for (int i = this._buckets[num % this._buckets.Length] - 1; i >= 0; i = this._slots[i]._next)
			{
				if (this._slots[i]._hashCode == num && this._comparer.Equals(this._slots[i]._value, value))
				{
					return false;
				}
			}
			if (this._count == this._slots.Length)
			{
				this.Resize();
			}
			int count = this._count;
			this._count++;
			int num2 = num % this._buckets.Length;
			this._slots[count]._hashCode = num;
			this._slots[count]._value = value;
			this._slots[count]._next = this._buckets[num2] - 1;
			this._buckets[num2] = count + 1;
			return true;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000081F8 File Offset: 0x000063F8
		private void Resize()
		{
			int num = checked(this._count * 2 + 1);
			int[] array = new int[num];
			Set<TElement>.Slot[] array2 = new Set<TElement>.Slot[num];
			Array.Copy(this._slots, 0, array2, 0, this._count);
			for (int i = 0; i < this._count; i++)
			{
				int num2 = array2[i]._hashCode % num;
				array2[i]._next = array[num2] - 1;
				array[num2] = i + 1;
			}
			this._buckets = array;
			this._slots = array2;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000827C File Offset: 0x0000647C
		public TElement[] ToArray()
		{
			TElement[] array = new TElement[this._count];
			for (int num = 0; num != array.Length; num++)
			{
				array[num] = this._slots[num]._value;
			}
			return array;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000082BC File Offset: 0x000064BC
		public List<TElement> ToList()
		{
			int count = this._count;
			List<TElement> list = new List<TElement>(count);
			for (int num = 0; num != count; num++)
			{
				list.Add(this._slots[num]._value);
			}
			return list;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000082FB File Offset: 0x000064FB
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00008304 File Offset: 0x00006504
		public void UnionWith(IEnumerable<TElement> other)
		{
			foreach (TElement value in other)
			{
				this.Add(value);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008350 File Offset: 0x00006550
		private int InternalGetHashCode(TElement value)
		{
			if (value != null)
			{
				return this._comparer.GetHashCode(value) & int.MaxValue;
			}
			return 0;
		}

		// Token: 0x04000082 RID: 130
		private readonly IEqualityComparer<TElement> _comparer;

		// Token: 0x04000083 RID: 131
		private int[] _buckets;

		// Token: 0x04000084 RID: 132
		private Set<TElement>.Slot[] _slots;

		// Token: 0x04000085 RID: 133
		private int _count;

		// Token: 0x02000044 RID: 68
		private struct Slot
		{
			// Token: 0x04000086 RID: 134
			internal int _hashCode;

			// Token: 0x04000087 RID: 135
			internal int _next;

			// Token: 0x04000088 RID: 136
			internal TElement _value;
		}
	}
}
