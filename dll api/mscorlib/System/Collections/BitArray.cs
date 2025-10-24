using System;
using System.Threading;

namespace System.Collections
{
	/// <summary>Manages a compact array of bit values, which are represented as Booleans, where <see langword="true" /> indicates that the bit is on (1) and <see langword="false" /> indicates the bit is off (0).</summary>
	// Token: 0x020005ED RID: 1517
	[Serializable]
	public sealed class BitArray : ICollection, IEnumerable, ICloneable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that can hold the specified number of bit values, which are initially set to <see langword="false" />.</summary>
		/// <param name="length">The number of bit values in the new <see cref="T:System.Collections.BitArray" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="length" /> is less than zero. </exception>
		// Token: 0x06002D5E RID: 11614 RVA: 0x000BA0E1 File Offset: 0x000B82E1
		public BitArray(int length) : this(length, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that can hold the specified number of bit values, which are initially set to the specified value.</summary>
		/// <param name="length">The number of bit values in the new <see cref="T:System.Collections.BitArray" />. </param>
		/// <param name="defaultValue">The Boolean value to assign to each bit. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="length" /> is less than zero. </exception>
		// Token: 0x06002D5F RID: 11615 RVA: 0x000BA0EC File Offset: 0x000B82EC
		public BitArray(int length, bool defaultValue)
		{
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", length, "Non-negative number required.");
			}
			this.m_array = new int[BitArray.GetArrayLength(length, 32)];
			this.m_length = length;
			int num = defaultValue ? -1 : 0;
			for (int i = 0; i < this.m_array.Length; i++)
			{
				this.m_array[i] = num;
			}
			this._version = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that contains bit values copied from the specified <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="bits">The <see cref="T:System.Collections.BitArray" /> to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bits" /> is <see langword="null" />. </exception>
		// Token: 0x06002D60 RID: 11616 RVA: 0x000BA160 File Offset: 0x000B8360
		public BitArray(BitArray bits)
		{
			if (bits == null)
			{
				throw new ArgumentNullException("bits");
			}
			int arrayLength = BitArray.GetArrayLength(bits.m_length, 32);
			this.m_array = new int[arrayLength];
			Array.Copy(bits.m_array, 0, this.m_array, 0, arrayLength);
			this.m_length = bits.m_length;
			this._version = bits._version;
		}

		/// <summary>Gets or sets the value of the bit at a specific position in the <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="index">The zero-based index of the value to get or set. </param>
		/// <returns>The value of the bit at position <paramref name="index" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.BitArray.Count" />. </exception>
		// Token: 0x17000709 RID: 1801
		public bool this[int index]
		{
			get
			{
				return this.Get(index);
			}
			set
			{
				this.Set(index, value);
			}
		}

		/// <summary>Gets the value of the bit at a specific position in the <see cref="T:System.Collections.BitArray" />.</summary>
		/// <param name="index">The zero-based index of the value to get. </param>
		/// <returns>The value of the bit at position <paramref name="index" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is greater than or equal to the number of elements in the <see cref="T:System.Collections.BitArray" />. </exception>
		// Token: 0x06002D63 RID: 11619 RVA: 0x000BA1DA File Offset: 0x000B83DA
		public bool Get(int index)
		{
			if (index < 0 || index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index", index, "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return (this.m_array[index / 32] & 1 << index % 32) != 0;
		}

		/// <summary>Sets the bit at a specific position in the <see cref="T:System.Collections.BitArray" /> to the specified value.</summary>
		/// <param name="index">The zero-based index of the bit to set. </param>
		/// <param name="value">The Boolean value to assign to the bit. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is greater than or equal to the number of elements in the <see cref="T:System.Collections.BitArray" />. </exception>
		// Token: 0x06002D64 RID: 11620 RVA: 0x000BA218 File Offset: 0x000B8418
		public void Set(int index, bool value)
		{
			if (index < 0 || index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index", index, "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (value)
			{
				this.m_array[index / 32] |= 1 << index % 32;
			}
			else
			{
				this.m_array[index / 32] &= ~(1 << index % 32);
			}
			this._version++;
		}

		/// <summary>Gets or sets the number of elements in the <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>The number of elements in the <see cref="T:System.Collections.BitArray" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is set to a value that is less than zero. </exception>
		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000BA294 File Offset: 0x000B8494
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x000BA29C File Offset: 0x000B849C
		public int Length
		{
			get
			{
				return this.m_length;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value", value, "Non-negative number required.");
				}
				int arrayLength = BitArray.GetArrayLength(value, 32);
				if (arrayLength > this.m_array.Length || arrayLength + 256 < this.m_array.Length)
				{
					Array.Resize<int>(ref this.m_array, arrayLength);
				}
				if (value > this.m_length)
				{
					int num = BitArray.GetArrayLength(this.m_length, 32) - 1;
					int num2 = this.m_length % 32;
					if (num2 > 0)
					{
						this.m_array[num] &= (1 << num2) - 1;
					}
					Array.Clear(this.m_array, num + 1, arrayLength - num - 1);
				}
				this.m_length = value;
				this._version++;
			}
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.BitArray" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.BitArray" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.BitArray" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.BitArray" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002D67 RID: 11623 RVA: 0x000BA35C File Offset: 0x000B855C
		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			int[] array2 = array as int[];
			if (array2 != null)
			{
				int num = BitArray.GetArrayLength(this.m_length, 32) - 1;
				int num2 = this.m_length % 32;
				if (num2 == 0)
				{
					Array.Copy(this.m_array, 0, array2, index, BitArray.GetArrayLength(this.m_length, 32));
					return;
				}
				Array.Copy(this.m_array, 0, array2, index, BitArray.GetArrayLength(this.m_length, 32) - 1);
				array2[index + num] = (this.m_array[num] & (1 << num2) - 1);
				return;
			}
			else if (array is byte[])
			{
				int num3 = this.m_length % 8;
				int num4 = BitArray.GetArrayLength(this.m_length, 8);
				if (array.Length - index < num4)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (num3 > 0)
				{
					num4--;
				}
				byte[] array3 = (byte[])array;
				for (int i = 0; i < num4; i++)
				{
					array3[index + i] = (byte)(this.m_array[i / 4] >> i % 4 * 8 & 255);
				}
				if (num3 > 0)
				{
					int num5 = num4;
					array3[index + num5] = (byte)(this.m_array[num5 / 4] >> num5 % 4 * 8 & (1 << num3) - 1);
					return;
				}
				return;
			}
			else
			{
				if (!(array is bool[]))
				{
					throw new ArgumentException("Only supported array types for CopyTo on BitArrays are Boolean[], Int32[] and Byte[].", "array");
				}
				if (array.Length - index < this.m_length)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				bool[] array4 = (bool[])array;
				for (int j = 0; j < this.m_length; j++)
				{
					array4[index + j] = ((this.m_array[j / 32] >> j % 32 & 1) != 0);
				}
				return;
			}
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x000BA294 File Offset: 0x000B8494
		public int Count
		{
			get
			{
				return this.m_length;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000BA544 File Offset: 0x000B8744
		public object SyncRoot
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

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.BitArray" /> is synchronized (thread safe).</summary>
		/// <returns>This property is always <see langword="false" />.</returns>
		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x06002D6B RID: 11627 RVA: 0x000BA566 File Offset: 0x000B8766
		public object Clone()
		{
			return new BitArray(this);
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.BitArray" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the entire <see cref="T:System.Collections.BitArray" />.</returns>
		// Token: 0x06002D6C RID: 11628 RVA: 0x000BA56E File Offset: 0x000B876E
		public IEnumerator GetEnumerator()
		{
			return new BitArray.BitArrayEnumeratorSimple(this);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000BA576 File Offset: 0x000B8776
		private static int GetArrayLength(int n, int div)
		{
			if (n <= 0)
			{
				return 0;
			}
			return (n - 1) / div + 1;
		}

		// Token: 0x04001896 RID: 6294
		private int[] m_array;

		// Token: 0x04001897 RID: 6295
		private int m_length;

		// Token: 0x04001898 RID: 6296
		private int _version;

		// Token: 0x04001899 RID: 6297
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020005EE RID: 1518
		[Serializable]
		private class BitArrayEnumeratorSimple : IEnumerator, ICloneable
		{
			// Token: 0x06002D6E RID: 11630 RVA: 0x000BA585 File Offset: 0x000B8785
			internal BitArrayEnumeratorSimple(BitArray bitarray)
			{
				this.bitarray = bitarray;
				this.index = -1;
				this.version = bitarray._version;
			}

			// Token: 0x06002D6F RID: 11631 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06002D70 RID: 11632 RVA: 0x000BA5A8 File Offset: 0x000B87A8
			public virtual bool MoveNext()
			{
				ICollection collection = this.bitarray;
				if (this.version != this.bitarray._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this.index < collection.Count - 1)
				{
					this.index++;
					this.currentElement = this.bitarray.Get(this.index);
					return true;
				}
				this.index = collection.Count;
				return false;
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000BA61E File Offset: 0x000B881E
			public virtual object Current
			{
				get
				{
					if (this.index == -1)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					if (this.index >= ((ICollection)this.bitarray).Count)
					{
						throw new InvalidOperationException("Enumeration already finished.");
					}
					return this.currentElement;
				}
			}

			// Token: 0x06002D72 RID: 11634 RVA: 0x000BA65D File Offset: 0x000B885D
			public void Reset()
			{
				if (this.version != this.bitarray._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this.index = -1;
			}

			// Token: 0x0400189A RID: 6298
			private BitArray bitarray;

			// Token: 0x0400189B RID: 6299
			private int index;

			// Token: 0x0400189C RID: 6300
			private int version;

			// Token: 0x0400189D RID: 6301
			private bool currentElement;
		}
	}
}
