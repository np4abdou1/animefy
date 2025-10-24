using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Generic
{
	// Token: 0x0200062F RID: 1583
	[DebuggerTypeProxy(typeof(QueueDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e")]
	[Serializable]
	public class Queue<T> : IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06003020 RID: 12320 RVA: 0x000C2821 File Offset: 0x000C0A21
		public Queue()
		{
			this._array = Array.Empty<T>();
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x000C2834 File Offset: 0x000C0A34
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x000C283C File Offset: 0x000C0A3C
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x000C2860 File Offset: 0x000C0A60
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new ArgumentException("The lower bound of target array must be zero.", "array");
			}
			int length = array.Length;
			if (index < 0 || index > length)
			{
				throw new ArgumentOutOfRangeException("index", index, "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (length - index < this._size)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			int num = this._size;
			if (num == 0)
			{
				return;
			}
			try
			{
				int num2 = (this._array.Length - this._head < num) ? (this._array.Length - this._head) : num;
				Array.Copy(this._array, this._head, array, index, num2);
				num -= num2;
				if (num > 0)
				{
					Array.Copy(this._array, 0, array, index + this._array.Length - this._head, num);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.", "array");
			}
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x000C2978 File Offset: 0x000C0B78
		public void Enqueue(T item)
		{
			if (this._size == this._array.Length)
			{
				int num = (int)((long)this._array.Length * 200L / 100L);
				if (num < this._array.Length + 4)
				{
					num = this._array.Length + 4;
				}
				this.SetCapacity(num);
			}
			this._array[this._tail] = item;
			this.MoveNext(ref this._tail);
			this._size++;
			this._version++;
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x000C2A04 File Offset: 0x000C0C04
		public Queue<T>.Enumerator GetEnumerator()
		{
			return new Queue<T>.Enumerator(this);
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x000C2A0C File Offset: 0x000C0C0C
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new Queue<T>.Enumerator(this);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x000C2A0C File Offset: 0x000C0C0C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Queue<T>.Enumerator(this);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x000C2A1C File Offset: 0x000C0C1C
		public T Dequeue()
		{
			int head = this._head;
			T[] array = this._array;
			if (this._size == 0)
			{
				this.ThrowForEmptyQueue();
			}
			T result = array[head];
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				array[head] = default(T);
			}
			this.MoveNext(ref this._head);
			this._size--;
			this._version++;
			return result;
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x000C2A8C File Offset: 0x000C0C8C
		private void SetCapacity(int capacity)
		{
			T[] array = new T[capacity];
			if (this._size > 0)
			{
				if (this._head < this._tail)
				{
					Array.Copy(this._array, this._head, array, 0, this._size);
				}
				else
				{
					Array.Copy(this._array, this._head, array, 0, this._array.Length - this._head);
					Array.Copy(this._array, 0, array, this._array.Length - this._head, this._tail);
				}
			}
			this._array = array;
			this._head = 0;
			this._tail = ((this._size == capacity) ? 0 : this._size);
			this._version++;
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x000C2B4C File Offset: 0x000C0D4C
		private void MoveNext(ref int index)
		{
			int num = index + 1;
			if (num == this._array.Length)
			{
				num = 0;
			}
			index = num;
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x000C2B6E File Offset: 0x000C0D6E
		private void ThrowForEmptyQueue()
		{
			throw new InvalidOperationException("Queue empty.");
		}

		// Token: 0x0400192C RID: 6444
		private T[] _array;

		// Token: 0x0400192D RID: 6445
		private int _head;

		// Token: 0x0400192E RID: 6446
		private int _tail;

		// Token: 0x0400192F RID: 6447
		private int _size;

		// Token: 0x04001930 RID: 6448
		private int _version;

		// Token: 0x04001931 RID: 6449
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x02000630 RID: 1584
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x0600302D RID: 12333 RVA: 0x000C2B7A File Offset: 0x000C0D7A
			internal Enumerator(Queue<T> q)
			{
				this._q = q;
				this._version = q._version;
				this._index = -1;
				this._currentElement = default(T);
			}

			// Token: 0x0600302E RID: 12334 RVA: 0x000C2BA2 File Offset: 0x000C0DA2
			public void Dispose()
			{
				this._index = -2;
				this._currentElement = default(T);
			}

			// Token: 0x0600302F RID: 12335 RVA: 0x000C2BB8 File Offset: 0x000C0DB8
			public bool MoveNext()
			{
				if (this._version != this._q._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._index == -2)
				{
					return false;
				}
				this._index++;
				if (this._index == this._q._size)
				{
					this._index = -2;
					this._currentElement = default(T);
					return false;
				}
				T[] array = this._q._array;
				int num = array.Length;
				int num2 = this._q._head + this._index;
				if (num2 >= num)
				{
					num2 -= num;
				}
				this._currentElement = array[num2];
				return true;
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x06003030 RID: 12336 RVA: 0x000C2C5F File Offset: 0x000C0E5F
			public T Current
			{
				get
				{
					if (this._index < 0)
					{
						this.ThrowEnumerationNotStartedOrEnded();
					}
					return this._currentElement;
				}
			}

			// Token: 0x06003031 RID: 12337 RVA: 0x000C2C76 File Offset: 0x000C0E76
			private void ThrowEnumerationNotStartedOrEnded()
			{
				throw new InvalidOperationException((this._index == -1) ? "Enumeration has not started. Call MoveNext." : "Enumeration already finished.");
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x06003032 RID: 12338 RVA: 0x000C2C92 File Offset: 0x000C0E92
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06003033 RID: 12339 RVA: 0x000C2C9F File Offset: 0x000C0E9F
			void IEnumerator.Reset()
			{
				if (this._version != this._q._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._index = -1;
				this._currentElement = default(T);
			}

			// Token: 0x04001932 RID: 6450
			private readonly Queue<T> _q;

			// Token: 0x04001933 RID: 6451
			private readonly int _version;

			// Token: 0x04001934 RID: 6452
			private int _index;

			// Token: 0x04001935 RID: 6453
			private T _currentElement;
		}
	}
}
