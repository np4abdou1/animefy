using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x0200062A RID: 1578
	internal struct LargeArrayBuilder<T>
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x000C229B File Offset: 0x000C049B
		public LargeArrayBuilder(bool initialize)
		{
			this = new LargeArrayBuilder<T>(int.MaxValue);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000C22A8 File Offset: 0x000C04A8
		public LargeArrayBuilder(int maxCapacity)
		{
			this = default(LargeArrayBuilder<T>);
			this._first = (this._current = Array.Empty<T>());
			this._maxCapacity = maxCapacity;
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000C22D8 File Offset: 0x000C04D8
		public void AddRange(IEnumerable<T> items)
		{
			using (IEnumerator<T> enumerator = items.GetEnumerator())
			{
				T[] current = this._current;
				int num = this._index;
				while (enumerator.MoveNext())
				{
					T t = enumerator.Current;
					if (num >= current.Length)
					{
						this.AddWithBufferAllocation(t, ref current, ref num);
					}
					else
					{
						current[num] = t;
					}
					num++;
				}
				this._count += num - this._index;
				this._index = num;
			}
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000C2364 File Offset: 0x000C0564
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddWithBufferAllocation(T item, ref T[] destination, ref int index)
		{
			this._count += index - this._index;
			this._index = index;
			this.AllocateBuffer();
			destination = this._current;
			index = this._index;
			this._current[index] = item;
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000C23B4 File Offset: 0x000C05B4
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			int num = 0;
			while (count > 0)
			{
				T[] buffer = this.GetBuffer(num);
				int num2 = Math.Min(count, buffer.Length);
				Array.Copy(buffer, 0, array, arrayIndex, num2);
				count -= num2;
				arrayIndex += num2;
				num++;
			}
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000C23F3 File Offset: 0x000C05F3
		public T[] GetBuffer(int index)
		{
			if (index == 0)
			{
				return this._first;
			}
			if (index > this._buffers.Count)
			{
				return this._current;
			}
			return this._buffers[index - 1];
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000C2424 File Offset: 0x000C0624
		public T[] ToArray()
		{
			T[] array;
			if (this.TryMove(out array))
			{
				return array;
			}
			array = new T[this._count];
			this.CopyTo(array, 0, this._count);
			return array;
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000C2458 File Offset: 0x000C0658
		public bool TryMove(out T[] array)
		{
			array = this._first;
			return this._count == this._first.Length;
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x000C2474 File Offset: 0x000C0674
		private void AllocateBuffer()
		{
			if (this._count < 8)
			{
				int num = Math.Min((this._count == 0) ? 4 : (this._count * 2), this._maxCapacity);
				this._current = new T[num];
				Array.Copy(this._first, 0, this._current, 0, this._count);
				this._first = this._current;
				return;
			}
			int num2;
			if (this._count == 8)
			{
				num2 = 8;
			}
			else
			{
				this._buffers.Add(this._current);
				num2 = Math.Min(this._count, this._maxCapacity - this._count);
			}
			this._current = new T[num2];
			this._index = 0;
		}

		// Token: 0x0400191E RID: 6430
		private readonly int _maxCapacity;

		// Token: 0x0400191F RID: 6431
		private T[] _first;

		// Token: 0x04001920 RID: 6432
		private ArrayBuilder<T[]> _buffers;

		// Token: 0x04001921 RID: 6433
		private T[] _current;

		// Token: 0x04001922 RID: 6434
		private int _index;

		// Token: 0x04001923 RID: 6435
		private int _count;
	}
}
