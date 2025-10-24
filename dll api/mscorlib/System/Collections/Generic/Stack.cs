using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Generic
{
	// Token: 0x02000632 RID: 1586
	[DebuggerTypeProxy(typeof(StackDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e")]
	[Serializable]
	public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06003034 RID: 12340 RVA: 0x000C2CD2 File Offset: 0x000C0ED2
		public Stack()
		{
			this._array = Array.Empty<T>();
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x000C2CE5 File Offset: 0x000C0EE5
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x000C2CED File Offset: 0x000C0EED
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

		// Token: 0x06003038 RID: 12344 RVA: 0x000C2D10 File Offset: 0x000C0F10
		void ICollection.CopyTo(Array array, int arrayIndex)
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
			if (arrayIndex < 0 || arrayIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", arrayIndex, "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (array.Length - arrayIndex < this._size)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			try
			{
				Array.Copy(this._array, 0, array, arrayIndex, this._size);
				Array.Reverse(array, arrayIndex, this._size);
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.", "array");
			}
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x000C2DE0 File Offset: 0x000C0FE0
		public Stack<T>.Enumerator GetEnumerator()
		{
			return new Stack<T>.Enumerator(this);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x000C2DE8 File Offset: 0x000C0FE8
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new Stack<T>.Enumerator(this);
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000C2DE8 File Offset: 0x000C0FE8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Stack<T>.Enumerator(this);
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x000C2DF8 File Offset: 0x000C0FF8
		public T Peek()
		{
			int num = this._size - 1;
			T[] array = this._array;
			if (num >= array.Length)
			{
				this.ThrowForEmptyStack();
			}
			return array[num];
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x000C2E28 File Offset: 0x000C1028
		public T Pop()
		{
			int num = this._size - 1;
			T[] array = this._array;
			if (num >= array.Length)
			{
				this.ThrowForEmptyStack();
			}
			this._version++;
			this._size = num;
			T result = array[num];
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				array[num] = default(T);
			}
			return result;
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x000C2E84 File Offset: 0x000C1084
		public bool TryPop(out T result)
		{
			int num = this._size - 1;
			T[] array = this._array;
			if (num >= array.Length)
			{
				result = default(T);
				return false;
			}
			this._version++;
			this._size = num;
			result = array[num];
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				array[num] = default(T);
			}
			return true;
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000C2EEC File Offset: 0x000C10EC
		public void Push(T item)
		{
			int size = this._size;
			T[] array = this._array;
			if (size < array.Length)
			{
				array[size] = item;
				this._version++;
				this._size = size + 1;
				return;
			}
			this.PushWithResize(item);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x000C2F34 File Offset: 0x000C1134
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PushWithResize(T item)
		{
			Array.Resize<T>(ref this._array, (this._array.Length == 0) ? 4 : (2 * this._array.Length));
			this._array[this._size] = item;
			this._version++;
			this._size++;
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000C2F90 File Offset: 0x000C1190
		private void ThrowForEmptyStack()
		{
			throw new InvalidOperationException("Stack empty.");
		}

		// Token: 0x04001936 RID: 6454
		private T[] _array;

		// Token: 0x04001937 RID: 6455
		private int _size;

		// Token: 0x04001938 RID: 6456
		private int _version;

		// Token: 0x04001939 RID: 6457
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x02000633 RID: 1587
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06003042 RID: 12354 RVA: 0x000C2F9C File Offset: 0x000C119C
			internal Enumerator(Stack<T> stack)
			{
				this._stack = stack;
				this._version = stack._version;
				this._index = -2;
				this._currentElement = default(T);
			}

			// Token: 0x06003043 RID: 12355 RVA: 0x000C2FC5 File Offset: 0x000C11C5
			public void Dispose()
			{
				this._index = -1;
			}

			// Token: 0x06003044 RID: 12356 RVA: 0x000C2FD0 File Offset: 0x000C11D0
			public bool MoveNext()
			{
				if (this._version != this._stack._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._index == -2)
				{
					this._index = this._stack._size - 1;
					bool flag = this._index >= 0;
					if (flag)
					{
						this._currentElement = this._stack._array[this._index];
					}
					return flag;
				}
				if (this._index == -1)
				{
					return false;
				}
				int num = this._index - 1;
				this._index = num;
				bool flag2 = num >= 0;
				if (flag2)
				{
					this._currentElement = this._stack._array[this._index];
					return flag2;
				}
				this._currentElement = default(T);
				return flag2;
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06003045 RID: 12357 RVA: 0x000C3092 File Offset: 0x000C1292
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

			// Token: 0x06003046 RID: 12358 RVA: 0x000C30A9 File Offset: 0x000C12A9
			private void ThrowEnumerationNotStartedOrEnded()
			{
				throw new InvalidOperationException((this._index == -2) ? "Enumeration has not started. Call MoveNext." : "Enumeration already finished.");
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x06003047 RID: 12359 RVA: 0x000C30C6 File Offset: 0x000C12C6
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06003048 RID: 12360 RVA: 0x000C30D3 File Offset: 0x000C12D3
			void IEnumerator.Reset()
			{
				if (this._version != this._stack._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._index = -2;
				this._currentElement = default(T);
			}

			// Token: 0x0400193A RID: 6458
			private readonly Stack<T> _stack;

			// Token: 0x0400193B RID: 6459
			private readonly int _version;

			// Token: 0x0400193C RID: 6460
			private int _index;

			// Token: 0x0400193D RID: 6461
			private T _currentElement;
		}
	}
}
