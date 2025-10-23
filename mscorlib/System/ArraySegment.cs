using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics.Hashing;
using System.Reflection;

namespace System
{
	/// <summary>Delimits a section of a one-dimensional array.</summary>
	/// <typeparam name="T">The type of the elements in the array segment.</typeparam>
	// Token: 0x0200007C RID: 124
	[DefaultMember("Item")]
	[Serializable]
	public readonly struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000EA1E File Offset: 0x0000CC1E
		public static ArraySegment<T> Empty { get; } = new ArraySegment<T>(new T[0]);

		/// <summary>Initializes a new instance of the <see cref="T:System.ArraySegment`1" /> structure that delimits all the elements in the specified array.</summary>
		/// <param name="array">The array to wrap.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		// Token: 0x06000298 RID: 664 RVA: 0x0000EA25 File Offset: 0x0000CC25
		public ArraySegment(T[] array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			this._array = array;
			this._offset = 0;
			this._count = array.Length;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArraySegment`1" /> structure that delimits the specified range of the elements in the specified array.</summary>
		/// <param name="array">The array containing the range of elements to delimit.</param>
		/// <param name="offset">The zero-based index of the first element in the range.</param>
		/// <param name="count">The number of elements in the range.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" /> and <paramref name="count" /> do not specify a valid range in <paramref name="array" />.</exception>
		// Token: 0x06000299 RID: 665 RVA: 0x0000EA47 File Offset: 0x0000CC47
		public ArraySegment(T[] array, int offset, int count)
		{
			if (array == null || offset > array.Length || count > array.Length - offset)
			{
				ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(array, offset, count);
			}
			this._array = array;
			this._offset = offset;
			this._count = count;
		}

		/// <summary>Gets the original array containing the range of elements that the array segment delimits.</summary>
		/// <returns>The original array that was passed to the constructor, and that contains the range delimited by the <see cref="T:System.ArraySegment`1" />.</returns>
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000EA77 File Offset: 0x0000CC77
		public T[] Array
		{
			get
			{
				return this._array;
			}
		}

		/// <summary>Gets the position of the first element in the range delimited by the array segment, relative to the start of the original array.</summary>
		/// <returns>The position of the first element in the range delimited by the <see cref="T:System.ArraySegment`1" />, relative to the start of the original array.</returns>
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000EA7F File Offset: 0x0000CC7F
		public int Offset
		{
			get
			{
				return this._offset;
			}
		}

		/// <summary>Gets the number of elements in the range delimited by the array segment.</summary>
		/// <returns>The number of elements in the range delimited by the <see cref="T:System.ArraySegment`1" />.</returns>
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000EA87 File Offset: 0x0000CC87
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000EA8F File Offset: 0x0000CC8F
		public ArraySegment<T>.Enumerator GetEnumerator()
		{
			this.ThrowInvalidOperationIfDefault();
			return new ArraySegment<T>.Enumerator(this);
		}

		/// <summary>Returns the hash code for the current instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600029E RID: 670 RVA: 0x0000EAA2 File Offset: 0x0000CCA2
		public override int GetHashCode()
		{
			if (this._array == null)
			{
				return 0;
			}
			return System.Numerics.Hashing.HashHelpers.Combine(System.Numerics.Hashing.HashHelpers.Combine(5381, this._offset), this._count) ^ this._array.GetHashCode();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000EAD5 File Offset: 0x0000CCD5
		public void CopyTo(T[] destination, int destinationIndex)
		{
			this.ThrowInvalidOperationIfDefault();
			System.Array.Copy(this._array, this._offset, destination, destinationIndex, this._count);
		}

		/// <summary>Determines whether the specified object is equal to the current instance.</summary>
		/// <param name="obj">The object to be compared with the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if the specified object is a <see cref="T:System.ArraySegment`1" /> structure and is equal to the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060002A0 RID: 672 RVA: 0x0000EAF6 File Offset: 0x0000CCF6
		public override bool Equals(object obj)
		{
			return obj is ArraySegment<T> && this.Equals((ArraySegment<T>)obj);
		}

		/// <summary>Determines whether the specified <see cref="T:System.ArraySegment`1" /> structure is equal to the current instance.</summary>
		/// <param name="obj">The structure to compare with the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if the specified <see cref="T:System.ArraySegment`1" /> structure is equal to the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060002A1 RID: 673 RVA: 0x0000EB0E File Offset: 0x0000CD0E
		public bool Equals(ArraySegment<T> obj)
		{
			return obj._array == this._array && obj._offset == this._offset && obj._count == this._count;
		}

		// Token: 0x17000042 RID: 66
		T IList<!0>.this[int index]
		{
			get
			{
				this.ThrowInvalidOperationIfDefault();
				if (index < 0 || index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				return this._array[this._offset + index];
			}
			set
			{
				this.ThrowInvalidOperationIfDefault();
				if (index < 0 || index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				this._array[this._offset + index] = value;
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000EB98 File Offset: 0x0000CD98
		int IList<!0>.IndexOf(T item)
		{
			this.ThrowInvalidOperationIfDefault();
			int num = System.Array.IndexOf<T>(this._array, item, this._offset, this._count);
			if (num < 0)
			{
				return -1;
			}
			return num - this._offset;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
		void IList<!0>.Insert(int index, T item)
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
		void IList<!0>.RemoveAt(int index)
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x17000043 RID: 67
		T IReadOnlyList<!0>.this[int index]
		{
			get
			{
				this.ThrowInvalidOperationIfDefault();
				if (index < 0 || index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				return this._array[this._offset + index];
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000B18D File Offset: 0x0000938D
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
		void ICollection<!0>.Add(T item)
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
		void ICollection<!0>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000EBD9 File Offset: 0x0000CDD9
		bool ICollection<!0>.Contains(T item)
		{
			this.ThrowInvalidOperationIfDefault();
			return System.Array.IndexOf<T>(this._array, item, this._offset, this._count) >= 0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000EBFF File Offset: 0x0000CDFF
		bool ICollection<!0>.Remove(T item)
		{
			ThrowHelper.ThrowNotSupportedException();
			return false;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000EC07 File Offset: 0x0000CE07
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Returns an enumerator that iterates through an array segment.</summary>
		/// <returns>An enumerator that can be used to iterate through the array segment.</returns>
		// Token: 0x060002AE RID: 686 RVA: 0x0000EC07 File Offset: 0x0000CE07
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000EC14 File Offset: 0x0000CE14
		private void ThrowInvalidOperationIfDefault()
		{
			if (this._array == null)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_NullArray);
			}
		}

		// Token: 0x040001AC RID: 428
		private readonly T[] _array;

		// Token: 0x040001AD RID: 429
		private readonly int _offset;

		// Token: 0x040001AE RID: 430
		private readonly int _count;

		// Token: 0x0200007D RID: 125
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x060002B1 RID: 689 RVA: 0x0000EC37 File Offset: 0x0000CE37
			internal Enumerator(ArraySegment<T> arraySegment)
			{
				this._array = arraySegment.Array;
				this._start = arraySegment.Offset;
				this._end = arraySegment.Offset + arraySegment.Count;
				this._current = arraySegment.Offset - 1;
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x0000EC77 File Offset: 0x0000CE77
			public bool MoveNext()
			{
				if (this._current < this._end)
				{
					this._current++;
					return this._current < this._end;
				}
				return false;
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000ECA5 File Offset: 0x0000CEA5
			public T Current
			{
				get
				{
					if (this._current < this._start)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumNotStarted();
					}
					if (this._current >= this._end)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumEnded();
					}
					return this._array[this._current];
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000ECDE File Offset: 0x0000CEDE
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000ECEB File Offset: 0x0000CEEB
			void IEnumerator.Reset()
			{
				this._current = this._start - 1;
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x00002A7D File Offset: 0x00000C7D
			public void Dispose()
			{
			}

			// Token: 0x040001AF RID: 431
			private readonly T[] _array;

			// Token: 0x040001B0 RID: 432
			private readonly int _start;

			// Token: 0x040001B1 RID: 433
			private readonly int _end;

			// Token: 0x040001B2 RID: 434
			private int _current;
		}
	}
}
