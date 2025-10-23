using System;

namespace System.Collections.Generic
{
	// Token: 0x02000628 RID: 1576
	internal struct ArrayBuilder<T>
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x000C216A File Offset: 0x000C036A
		public int Capacity
		{
			get
			{
				T[] array = this._array;
				if (array == null)
				{
					return 0;
				}
				return array.Length;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x000C217A File Offset: 0x000C037A
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170007CB RID: 1995
		public T this[int index]
		{
			get
			{
				return this._array[index];
			}
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x000C2190 File Offset: 0x000C0390
		public void Add(T item)
		{
			if (this._count == this.Capacity)
			{
				this.EnsureCapacity(this._count + 1);
			}
			this.UncheckedAdd(item);
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x000C21B8 File Offset: 0x000C03B8
		public void UncheckedAdd(T item)
		{
			T[] array = this._array;
			int count = this._count;
			this._count = count + 1;
			array[count] = item;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x000C21E4 File Offset: 0x000C03E4
		private void EnsureCapacity(int minimum)
		{
			int capacity = this.Capacity;
			int num = (capacity == 0) ? 4 : (2 * capacity);
			if (num > 2146435071)
			{
				num = Math.Max(capacity + 1, 2146435071);
			}
			num = Math.Max(num, minimum);
			T[] array = new T[num];
			if (this._count > 0)
			{
				Array.Copy(this._array, 0, array, 0, this._count);
			}
			this._array = array;
		}

		// Token: 0x0400191C RID: 6428
		private T[] _array;

		// Token: 0x0400191D RID: 6429
		private int _count;
	}
}
