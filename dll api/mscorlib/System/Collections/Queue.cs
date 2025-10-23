using System;
using System.Diagnostics;
using System.Threading;

namespace System.Collections
{
	/// <summary>Represents a first-in, first-out collection of objects.</summary>
	// Token: 0x020005E0 RID: 1504
	[DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Queue : ICollection, IEnumerable, ICloneable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the default initial capacity, and uses the default growth factor.</summary>
		// Token: 0x06002CCE RID: 11470 RVA: 0x000B863D File Offset: 0x000B683D
		public Queue() : this(32, 2f)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the specified initial capacity, and uses the default growth factor.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Queue" /> can contain. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero. </exception>
		// Token: 0x06002CCF RID: 11471 RVA: 0x000B864C File Offset: 0x000B684C
		public Queue(int capacity) : this(capacity, 2f)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the specified initial capacity, and uses the specified growth factor.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Queue" /> can contain. </param>
		/// <param name="growFactor">The factor by which the capacity of the <see cref="T:System.Collections.Queue" /> is expanded. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero.-or- 
		///         <paramref name="growFactor" /> is less than 1.0 or greater than 10.0. </exception>
		// Token: 0x06002CD0 RID: 11472 RVA: 0x000B865C File Offset: 0x000B685C
		public Queue(int capacity, float growFactor)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", "Non-negative number required.");
			}
			if ((double)growFactor < 1.0 || (double)growFactor > 10.0)
			{
				throw new ArgumentOutOfRangeException("growFactor", SR.Format("Queue grow factor must be between {0} and {1}.", 1, 10));
			}
			this._array = new object[capacity];
			this._head = 0;
			this._tail = 0;
			this._size = 0;
			this._growFactor = (int)(growFactor * 100f);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that contains elements copied from the specified collection, has the same initial capacity as the number of elements copied, and uses the default growth factor.</summary>
		/// <param name="col">The <see cref="T:System.Collections.ICollection" /> to copy elements from. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="col" /> is <see langword="null" />. </exception>
		// Token: 0x06002CD1 RID: 11473 RVA: 0x000B86F0 File Offset: 0x000B68F0
		public Queue(ICollection col) : this((col == null) ? 32 : col.Count)
		{
			if (col == null)
			{
				throw new ArgumentNullException("col");
			}
			foreach (object obj in col)
			{
				this.Enqueue(obj);
			}
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000B873B File Offset: 0x000B693B
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x06002CD3 RID: 11475 RVA: 0x000B8744 File Offset: 0x000B6944
		public virtual object Clone()
		{
			Queue queue = new Queue(this._size);
			queue._size = this._size;
			int num = this._size;
			int num2 = (this._array.Length - this._head < num) ? (this._array.Length - this._head) : num;
			Array.Copy(this._array, this._head, queue._array, 0, num2);
			num -= num2;
			if (num > 0)
			{
				Array.Copy(this._array, 0, queue._array, this._array.Length - this._head, num);
			}
			queue._version = this._version;
			return queue;
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Queue" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.Queue" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000B87E5 File Offset: 0x000B69E5
		public virtual object SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Copies the <see cref="T:System.Collections.Queue" /> elements to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Queue" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Queue" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Collections.Queue" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002CD6 RID: 11478 RVA: 0x000B8808 File Offset: 0x000B6A08
		public virtual void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (array.Length - index < this._size)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			int num = this._size;
			if (num == 0)
			{
				return;
			}
			int num2 = (this._array.Length - this._head < num) ? (this._array.Length - this._head) : num;
			Array.Copy(this._array, this._head, array, index, num2);
			num -= num2;
			if (num > 0)
			{
				Array.Copy(this._array, 0, array, index + this._array.Length - this._head, num);
			}
		}

		/// <summary>Adds an object to the end of the <see cref="T:System.Collections.Queue" />.</summary>
		/// <param name="obj">The object to add to the <see cref="T:System.Collections.Queue" />. The value can be <see langword="null" />. </param>
		// Token: 0x06002CD7 RID: 11479 RVA: 0x000B88D8 File Offset: 0x000B6AD8
		public virtual void Enqueue(object obj)
		{
			if (this._size == this._array.Length)
			{
				int num = (int)((long)this._array.Length * (long)this._growFactor / 100L);
				if (num < this._array.Length + 4)
				{
					num = this._array.Length + 4;
				}
				this.SetCapacity(num);
			}
			this._array[this._tail] = obj;
			this._tail = (this._tail + 1) % this._array.Length;
			this._size++;
			this._version++;
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x06002CD8 RID: 11480 RVA: 0x000B896C File Offset: 0x000B6B6C
		public virtual IEnumerator GetEnumerator()
		{
			return new Queue.QueueEnumerator(this);
		}

		/// <summary>Removes and returns the object at the beginning of the <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>The object that is removed from the beginning of the <see cref="T:System.Collections.Queue" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Queue" /> is empty. </exception>
		// Token: 0x06002CD9 RID: 11481 RVA: 0x000B8974 File Offset: 0x000B6B74
		public virtual object Dequeue()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("Queue empty.");
			}
			object result = this._array[this._head];
			this._array[this._head] = null;
			this._head = (this._head + 1) % this._array.Length;
			this._size--;
			this._version++;
			return result;
		}

		/// <summary>Returns the object at the beginning of the <see cref="T:System.Collections.Queue" /> without removing it.</summary>
		/// <returns>The object at the beginning of the <see cref="T:System.Collections.Queue" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Queue" /> is empty. </exception>
		// Token: 0x06002CDA RID: 11482 RVA: 0x000B89E2 File Offset: 0x000B6BE2
		public virtual object Peek()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("Queue empty.");
			}
			return this._array[this._head];
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000B8A04 File Offset: 0x000B6C04
		internal object GetElement(int i)
		{
			return this._array[(this._head + i) % this._array.Length];
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000B8A20 File Offset: 0x000B6C20
		private void SetCapacity(int capacity)
		{
			object[] array = new object[capacity];
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

		// Token: 0x0400186D RID: 6253
		private object[] _array;

		// Token: 0x0400186E RID: 6254
		private int _head;

		// Token: 0x0400186F RID: 6255
		private int _tail;

		// Token: 0x04001870 RID: 6256
		private int _size;

		// Token: 0x04001871 RID: 6257
		private int _growFactor;

		// Token: 0x04001872 RID: 6258
		private int _version;

		// Token: 0x04001873 RID: 6259
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020005E1 RID: 1505
		[Serializable]
		private class QueueEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06002CDD RID: 11485 RVA: 0x000B8AE0 File Offset: 0x000B6CE0
			internal QueueEnumerator(Queue q)
			{
				this._q = q;
				this._version = this._q._version;
				this._index = 0;
				this._currentElement = this._q._array;
				if (this._q._size == 0)
				{
					this._index = -1;
				}
			}

			// Token: 0x06002CDE RID: 11486 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06002CDF RID: 11487 RVA: 0x000B8B38 File Offset: 0x000B6D38
			public virtual bool MoveNext()
			{
				if (this._version != this._q._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._index < 0)
				{
					this._currentElement = this._q._array;
					return false;
				}
				this._currentElement = this._q.GetElement(this._index);
				this._index++;
				if (this._index == this._q._size)
				{
					this._index = -1;
				}
				return true;
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000B8BBF File Offset: 0x000B6DBF
			public virtual object Current
			{
				get
				{
					if (this._currentElement != this._q._array)
					{
						return this._currentElement;
					}
					if (this._index == 0)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					throw new InvalidOperationException("Enumeration already finished.");
				}
			}

			// Token: 0x06002CE1 RID: 11489 RVA: 0x000B8BF8 File Offset: 0x000B6DF8
			public virtual void Reset()
			{
				if (this._version != this._q._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._q._size == 0)
				{
					this._index = -1;
				}
				else
				{
					this._index = 0;
				}
				this._currentElement = this._q._array;
			}

			// Token: 0x04001874 RID: 6260
			private Queue _q;

			// Token: 0x04001875 RID: 6261
			private int _index;

			// Token: 0x04001876 RID: 6262
			private int _version;

			// Token: 0x04001877 RID: 6263
			private object _currentElement;
		}

		// Token: 0x020005E2 RID: 1506
		internal class QueueDebugView
		{
		}
	}
}
