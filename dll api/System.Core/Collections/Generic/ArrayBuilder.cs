using System;

namespace System.Collections.Generic
{
	// Token: 0x02000144 RID: 324
	internal struct ArrayBuilder<T>
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x00026888 File Offset: 0x00024A88
		public ArrayBuilder(int capacity)
		{
			this = default(ArrayBuilder<T>);
			if (capacity > 0)
			{
				this._array = new T[capacity];
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000268A1 File Offset: 0x00024AA1
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000268B1 File Offset: 0x00024AB1
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001C4 RID: 452
		public T this[int index]
		{
			get
			{
				return this._array[index];
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000268C7 File Offset: 0x00024AC7
		public void Add(T item)
		{
			if (this._count == this.Capacity)
			{
				this.EnsureCapacity(this._count + 1);
			}
			this.UncheckedAdd(item);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000268EC File Offset: 0x00024AEC
		public T First()
		{
			return this._array[0];
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000268FA File Offset: 0x00024AFA
		public T Last()
		{
			return this._array[this._count - 1];
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00026910 File Offset: 0x00024B10
		public T[] ToArray()
		{
			if (this._count == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = this._array;
			if (this._count < array.Length)
			{
				array = new T[this._count];
				Array.Copy(this._array, 0, array, 0, this._count);
			}
			return array;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00026960 File Offset: 0x00024B60
		public void UncheckedAdd(T item)
		{
			T[] array = this._array;
			int count = this._count;
			this._count = count + 1;
			array[count] = item;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002698C File Offset: 0x00024B8C
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

		// Token: 0x0400030A RID: 778
		private T[] _array;

		// Token: 0x0400030B RID: 779
		private int _count;
	}
}
