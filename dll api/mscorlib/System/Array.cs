using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Provides methods for creating, manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x0200012C RID: 300
	[Serializable]
	public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable
	{
		/// <summary>Returns a read-only wrapper for the specified array.</summary>
		/// <param name="array">The one-dimensional, zero-based array to wrap in a read-only <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />  wrapper.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>A read-only <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> wrapper for the specified array.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		// Token: 0x06000B92 RID: 2962 RVA: 0x00030028 File Offset: 0x0002E228
		public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return new ReadOnlyCollection<T>(array);
		}

		/// <summary>Changes the number of elements of a one-dimensional array to the specified new size.</summary>
		/// <param name="array">The one-dimensional, zero-based array to resize, or <see langword="null" /> to create a new array with the specified size.</param>
		/// <param name="newSize">The size of the new array.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="newSize" /> is less than zero.</exception>
		// Token: 0x06000B93 RID: 2963 RVA: 0x00030040 File Offset: 0x0002E240
		public static void Resize<T>(ref T[] array, int newSize)
		{
			if (newSize < 0)
			{
				throw new ArgumentOutOfRangeException("newSize", "Non-negative number required.");
			}
			T[] array2 = array;
			if (array2 == null)
			{
				array = new T[newSize];
				return;
			}
			if (array2.Length != newSize)
			{
				T[] array3 = new T[newSize];
				Array.Copy(array2, 0, array3, 0, (array2.Length > newSize) ? newSize : array2.Length);
				array = array3;
			}
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Array" />.</summary>
		/// <returns>The number of elements contained in the collection.</returns>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x00030095 File Offset: 0x0002E295
		int ICollection.Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ICollection.Count" />.</exception>
		/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
		// Token: 0x170000F5 RID: 245
		object IList.this[int index]
		{
			get
			{
				return this.GetValue(index);
			}
			set
			{
				this.SetValue(value, index);
			}
		}

		/// <summary>Calling this method always throws a <see cref="T:System.NotSupportedException" /> exception. </summary>
		/// <param name="value">The object to be added to the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Adding a value to an array is not supported. No value is returned. </returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> has a fixed size.</exception>
		// Token: 0x06000B98 RID: 2968 RVA: 0x000300B0 File Offset: 0x0002E2B0
		int IList.Add(object value)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Determines whether an element is in the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The object to locate in the current list. The element to locate can be <see langword="null" /> for reference types.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000B99 RID: 2969 RVA: 0x000300BC File Offset: 0x0002E2BC
		bool IList.Contains(object value)
		{
			return Array.IndexOf(this, value) >= 0;
		}

		/// <summary>Removes all items from the <see cref="T:System.Collections.IList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.</exception>
		// Token: 0x06000B9A RID: 2970 RVA: 0x000300CB File Offset: 0x0002E2CB
		void IList.Clear()
		{
			Array.Clear(this, this.GetLowerBound(0), this.Length);
		}

		/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The object to locate in the current list.</param>
		/// <returns>The index of value if found in the list; otherwise, -1.</returns>
		// Token: 0x06000B9B RID: 2971 RVA: 0x000300E0 File Offset: 0x0002E2E0
		int IList.IndexOf(object value)
		{
			return Array.IndexOf(this, value);
		}

		/// <summary>Inserts an item to the <see cref="T:System.Collections.IList" /> at the specified index.</summary>
		/// <param name="index">The index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The object to insert.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.IList" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.-or- The <see cref="T:System.Collections.IList" /> has a fixed size. </exception>
		/// <exception cref="T:System.NullReferenceException">
		///         <paramref name="value" /> is null reference in the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06000B9C RID: 2972 RVA: 0x000300B0 File Offset: 0x0002E2B0
		void IList.Insert(int index, object value)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The object to remove from the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.-or- The <see cref="T:System.Collections.IList" /> has a fixed size. </exception>
		// Token: 0x06000B9D RID: 2973 RVA: 0x000300B0 File Offset: 0x0002E2B0
		void IList.Remove(object value)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Removes the <see cref="T:System.Collections.IList" /> item at the specified index.</summary>
		/// <param name="index">The index of the element to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">index is not a valid index in the <see cref="T:System.Collections.IList" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.-or- The <see cref="T:System.Collections.IList" /> has a fixed size.</exception>
		// Token: 0x06000B9E RID: 2974 RVA: 0x000300B0 File Offset: 0x0002E2B0
		void IList.RemoveAt(int index)
		{
			throw new NotSupportedException("Collection was of a fixed size.");
		}

		/// <summary>Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 32-bit integer.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the current array.</param>
		/// <param name="index">A 32-bit integer that represents the index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or-The number of elements in the source array is greater than the available number of elements from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Array" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">The source array is multidimensional.</exception>
		/// <exception cref="T:System.InvalidCastException">At least one element in the source <see cref="T:System.Array" /> cannot be cast to the type of destination <paramref name="array" />.</exception>
		// Token: 0x06000B9F RID: 2975 RVA: 0x000300E9 File Offset: 0x0002E2E9
		public void CopyTo(Array array, int index)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			Array.Copy(this, this.GetLowerBound(0), array, index, this.Length);
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Array" />.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Array" />.</returns>
		// Token: 0x06000BA0 RID: 2976 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Determines whether the current collection object precedes, occurs in the same position as, or follows another object in the sort order.</summary>
		/// <param name="other">The object to compare with the current instance.</param>
		/// <param name="comparer">An object that compares the current object and <paramref name="other" />.</param>
		/// <returns>An integer that indicates the relationship of the current collection object to other, as shown in the following table.Return valueDescription-1The current instance precedes <paramref name="other" />.0The current instance and <paramref name="other" /> are equal.1The current instance follows <paramref name="other" />.</returns>
		// Token: 0x06000BA1 RID: 2977 RVA: 0x00030118 File Offset: 0x0002E318
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Array array = other as Array;
			if (array == null || this.Length != array.Length)
			{
				throw new ArgumentException("Object is not a array with the same number of elements as the array to compare it to.", "other");
			}
			int num = 0;
			int num2 = 0;
			while (num < array.Length && num2 == 0)
			{
				object value = this.GetValue(num);
				object value2 = array.GetValue(num);
				num2 = comparer.Compare(value, value2);
				num++;
			}
			return num2;
		}

		/// <summary>Determines whether an object is equal to the current instance.</summary>
		/// <param name="other">The object to compare with the current instance.</param>
		/// <param name="comparer">An object that determines whether the current instance and <paramref name="other" /> are equal. </param>
		/// <returns>
		///     <see langword="true" /> if the two objects are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000BA2 RID: 2978 RVA: 0x00030184 File Offset: 0x0002E384
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			Array array = other as Array;
			if (array == null || array.Length != this.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				object value = this.GetValue(i);
				object value2 = array.GetValue(i);
				if (!comparer.Equals(value, value2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0001D7A3 File Offset: 0x0001B9A3
		internal static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		/// <summary>Returns a hash code for the current instance.</summary>
		/// <param name="comparer">An object that computes the hash code of the current object.</param>
		/// <returns>The hash code for the current instance.</returns>
		// Token: 0x06000BA4 RID: 2980 RVA: 0x000301E4 File Offset: 0x0002E3E4
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}
			int num = 0;
			for (int i = (this.Length >= 8) ? (this.Length - 8) : 0; i < this.Length; i++)
			{
				num = Array.CombineHashCodes(num, comparer.GetHashCode(this.GetValue(i)));
			}
			return num;
		}

		/// <summary>Searches an entire one-dimensional sorted array for a specific element, using the <see cref="T:System.IComparable" /> interface implemented by each element of the array and by the specified object.</summary>
		/// <param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param>
		/// <param name="value">The object to search for.</param>
		/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception>
		// Token: 0x06000BA5 RID: 2981 RVA: 0x0003023A File Offset: 0x0002E43A
		public static int BinarySearch(Array array, object value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch(array, array.GetLowerBound(0), array.Length, value, null);
		}

		/// <summary>Converts an array of one type to an array of another type.</summary>
		/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to convert to a target type.</param>
		/// <param name="converter">A <see cref="T:System.Converter`2" /> that converts each element from one type to another type.</param>
		/// <typeparam name="TInput">The type of the elements of the source array.</typeparam>
		/// <typeparam name="TOutput">The type of the elements of the target array.</typeparam>
		/// <returns>An array of the target type containing the converted elements from the source array.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.-or-
		///         <paramref name="converter" /> is <see langword="null" />.</exception>
		// Token: 0x06000BA6 RID: 2982 RVA: 0x00030260 File Offset: 0x0002E460
		public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (converter == null)
			{
				throw new ArgumentNullException("converter");
			}
			TOutput[] array2 = new TOutput[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = converter(array[i]);
			}
			return array2;
		}

		/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index. The length and the indexes are specified as 64-bit integers.</summary>
		/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
		/// <param name="sourceIndex">A 64-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param>
		/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
		/// <param name="destinationIndex">A 64-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param>
		/// <param name="length">A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="F:System.Int32.MaxValue" />, inclusive.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sourceArray" /> is <see langword="null" />.-or-
		///         <paramref name="destinationArray" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">
		///         <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
		/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="sourceIndex" /> is outside the range of valid indexes for the <paramref name="sourceArray" />.-or-
		///         <paramref name="destinationIndex" /> is outside the range of valid indexes for the <paramref name="destinationArray" />.-or-
		///         <paramref name="length" /> is less than 0 or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.-or-
		///         <paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
		// Token: 0x06000BA7 RID: 2983 RVA: 0x000302B8 File Offset: 0x0002E4B8
		public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
		{
			if (sourceIndex > 2147483647L || sourceIndex < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Arrays larger than 2GB are not supported.");
			}
			if (destinationIndex > 2147483647L || destinationIndex < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Arrays larger than 2GB are not supported.");
			}
			if (length > 2147483647L || length < -2147483648L)
			{
				throw new ArgumentOutOfRangeException("length", "Arrays larger than 2GB are not supported.");
			}
			Array.Copy(sourceArray, (int)sourceIndex, destinationArray, (int)destinationIndex, (int)length);
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Array" /> has a fixed size.</summary>
		/// <returns>This property is always <see langword="true" /> for all arrays.</returns>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0000B18D File Offset: 0x0000938D
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Array" /> is synchronized (thread safe).</summary>
		/// <returns>This property is always <see langword="false" /> for all arrays.</returns>
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Array" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Array" />.</returns>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0000245A File Offset: 0x0000065A
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Searches an entire one-dimensional sorted array for a value using the specified <see cref="T:System.Collections.IComparer" /> interface.</summary>
		/// <param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param>
		/// <param name="value">The object to search for.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- 
		///       <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
		/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception>
		// Token: 0x06000BAB RID: 2987 RVA: 0x0003033B File Offset: 0x0002E53B
		public static int BinarySearch(Array array, object value, IComparer comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch(array, array.GetLowerBound(0), array.Length, value, comparer);
		}

		/// <summary>Searches a range of elements in a one-dimensional sorted array for a value, using the specified <see cref="T:System.Collections.IComparer" /> interface.</summary>
		/// <param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param>
		/// <param name="index">The starting index of the range to search.</param>
		/// <param name="length">The length of the range to search.</param>
		/// <param name="value">The object to search for.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- 
		///       <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
		/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.-or-
		///         <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception>
		// Token: 0x06000BAC RID: 2988 RVA: 0x00030360 File Offset: 0x0002E560
		public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (array.Rank != 1)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			if (comparer == null)
			{
				comparer = Comparer.Default;
			}
			int i = index;
			int num = index + length - 1;
			object[] array2 = array as object[];
			if (array2 != null)
			{
				while (i <= num)
				{
					int median = Array.GetMedian(i, num);
					int num2;
					try
					{
						num2 = comparer.Compare(array2[median], value);
					}
					catch (Exception innerException)
					{
						throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
					}
					if (num2 == 0)
					{
						return median;
					}
					if (num2 < 0)
					{
						i = median + 1;
					}
					else
					{
						num = median - 1;
					}
				}
			}
			else
			{
				while (i <= num)
				{
					int median2 = Array.GetMedian(i, num);
					int num3;
					try
					{
						num3 = comparer.Compare(array.GetValue(median2), value);
					}
					catch (Exception innerException2)
					{
						throw new InvalidOperationException("Failed to compare two elements in the array.", innerException2);
					}
					if (num3 == 0)
					{
						return median2;
					}
					if (num3 < 0)
					{
						i = median2 + 1;
					}
					else
					{
						num = median2 - 1;
					}
				}
			}
			return ~i;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00030494 File Offset: 0x0002E694
		private static int GetMedian(int low, int hi)
		{
			return low + (hi - low >> 1);
		}

		/// <summary>Searches an entire one-dimensional sorted array for a specific element, using the <see cref="T:System.IComparable`1" /> generic interface implemented by each element of the <see cref="T:System.Array" /> and by the specified object.</summary>
		/// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
		/// <param name="value">The object to search for.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
		// Token: 0x06000BAE RID: 2990 RVA: 0x0003049D File Offset: 0x0002E69D
		public static int BinarySearch<T>(T[] array, T value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch<T>(array, 0, array.Length, value, null);
		}

		/// <summary>Searches an entire one-dimensional sorted array for a value using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
		/// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search. </param>
		/// <param name="value">The object to search for.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> implementation to use when comparing elements.-or- 
		///       <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> implementation of each element.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface</exception>
		// Token: 0x06000BAF RID: 2991 RVA: 0x000304B9 File Offset: 0x0002E6B9
		public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.BinarySearch<T>(array, 0, array.Length, value, comparer);
		}

		/// <summary>Searches a range of elements in a one-dimensional sorted array for a value, using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
		/// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
		/// <param name="index">The starting index of the range to search.</param>
		/// <param name="length">The length of the range to search.</param>
		/// <param name="value">The object to search for.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> implementation to use when comparing elements.-or- 
		///       <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> implementation of each element.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.-or-
		///         <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
		// Token: 0x06000BB0 RID: 2992 RVA: 0x000304D8 File Offset: 0x0002E6D8
		public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return ArraySortHelper<T>.Default.BinarySearch(array, index, length, value, comparer);
		}

		/// <summary>Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.</summary>
		/// <param name="array">The one-dimensional array to search.</param>
		/// <param name="value">The object to locate in <paramref name="array" />.</param>
		/// <returns>The index of the first occurrence of <paramref name="value" /> in <paramref name="array" />, if found; otherwise, the lower bound of the array minus 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		// Token: 0x06000BB1 RID: 2993 RVA: 0x00030539 File Offset: 0x0002E739
		public static int IndexOf(Array array, object value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.IndexOf(array, value, array.GetLowerBound(0), array.Length);
		}

		/// <summary>Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs first occurrence. The range extends from a specified index for a specified number of elements.</summary>
		/// <param name="array">The one-dimensional array to search.</param>
		/// <param name="value">The object to locate in <paramref name="array" />.</param>
		/// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
		/// <param name="count">The number of elements to search.</param>
		/// <returns>The index of the first occurrence of <paramref name="value" />, if it’s found in the <paramref name="array" /> from index <paramref name="startIndex" /> to <paramref name="startIndex" /> + <paramref name="count" /> - 1; otherwise, the lower bound of the array minus 1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.-or-
		///         <paramref name="count" /> is less than zero.-or-
		///         <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		// Token: 0x06000BB2 RID: 2994 RVA: 0x00030560 File Offset: 0x0002E760
		public static int IndexOf(Array array, object value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			int lowerBound = array.GetLowerBound(0);
			if (startIndex < lowerBound || startIndex > array.Length + lowerBound)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || count > array.Length - startIndex + lowerBound)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			object[] array2 = array as object[];
			int num = startIndex + count;
			if (array2 != null)
			{
				if (value == null)
				{
					for (int i = startIndex; i < num; i++)
					{
						if (array2[i] == null)
						{
							return i;
						}
					}
				}
				else
				{
					for (int j = startIndex; j < num; j++)
					{
						object obj = array2[j];
						if (obj != null && obj.Equals(value))
						{
							return j;
						}
					}
				}
			}
			else
			{
				for (int k = startIndex; k < num; k++)
				{
					object value2 = array.GetValue(k);
					if (value2 == null)
					{
						if (value == null)
						{
							return k;
						}
					}
					else if (value2.Equals(value))
					{
						return k;
					}
				}
			}
			return lowerBound - 1;
		}

		/// <summary>Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.</summary>
		/// <param name="array">The one-dimensional, zero-based array to search.</param>
		/// <param name="value">The object to locate in <paramref name="array" />.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> in the entire <paramref name="array" />, if found; otherwise, –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		// Token: 0x06000BB3 RID: 2995 RVA: 0x0003065A File Offset: 0x0002E85A
		public static int IndexOf<T>(T[] array, T value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.IndexOfImpl<T>(array, value, 0, array.Length);
		}

		/// <summary>Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index for a specified number of elements.</summary>
		/// <param name="array">The one-dimensional, zero-based array to search.</param>
		/// <param name="value">The object to locate in <paramref name="array" />.</param>
		/// <param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty array.</param>
		/// <param name="count">The number of elements in the section to search.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified in <paramref name="count" />, if found; otherwise, –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.-or-
		///         <paramref name="count" /> is less than zero.-or-
		///         <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
		// Token: 0x06000BB4 RID: 2996 RVA: 0x00030678 File Offset: 0x0002E878
		public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (startIndex < 0 || startIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || count > array.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			return Array.IndexOfImpl<T>(array, value, startIndex, count);
		}

		/// <summary>Searches for the specified object and returns the index of the last occurrence within the entire <see cref="T:System.Array" />.</summary>
		/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
		/// <param name="value">The object to locate in <paramref name="array" />.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the entire <paramref name="array" />, if found; otherwise, –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		// Token: 0x06000BB5 RID: 2997 RVA: 0x000306D2 File Offset: 0x0002E8D2
		public static int LastIndexOf<T>(T[] array, T value)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			return Array.LastIndexOf<T>(array, value, array.Length - 1, array.Length);
		}

		/// <summary>Searches for the specified object and returns the index of the last occurrence within the range of elements in the <see cref="T:System.Array" /> that contains the specified number of elements and ends at the specified index.</summary>
		/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
		/// <param name="value">The object to locate in <paramref name="array" />.</param>
		/// <param name="startIndex">The zero-based starting index of the backward search.</param>
		/// <param name="count">The number of elements in the section to search.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that contains the number of elements specified in <paramref name="count" /> and ends at <paramref name="startIndex" />, if found; otherwise, –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.-or-
		///         <paramref name="count" /> is less than zero.-or-
		///         <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
		// Token: 0x06000BB6 RID: 2998 RVA: 0x000306F4 File Offset: 0x0002E8F4
		public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Length == 0)
			{
				if (startIndex != -1 && startIndex != 0)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count != 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				return -1;
			}
			else
			{
				if (startIndex < 0 || startIndex >= array.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count < 0 || startIndex - count + 1 < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				return Array.LastIndexOfImpl<T>(array, value, startIndex, count);
			}
		}

		/// <summary>Reverses the sequence of the elements in a range of elements in the one-dimensional <see cref="T:System.Array" />.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to reverse.</param>
		/// <param name="index">The starting index of the section to reverse.</param>
		/// <param name="length">The number of elements in the section to reverse.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.</exception>
		// Token: 0x06000BB7 RID: 2999 RVA: 0x00030780 File Offset: 0x0002E980
		public static void Reverse(Array array, int index, int length)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int lowerBound = array.GetLowerBound(0);
			if (index < lowerBound || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < lowerBound) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - (index - lowerBound) < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (array.Rank != 1)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			object[] array2 = array as object[];
			if (array2 != null)
			{
				Array.Reverse<object>(array2, index, length);
				return;
			}
			int i = index;
			int num = index + length - 1;
			while (i < num)
			{
				object value = array.GetValue(i);
				array.SetValue(array.GetValue(num), i);
				array.SetValue(value, num);
				i++;
				num--;
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0003083B File Offset: 0x0002EA3B
		public static void Reverse<T>(T[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Reverse<T>(array, 0, array.Length);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00030858 File Offset: 0x0002EA58
		public static void Reverse<T>(T[] array, int index, int length)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "length", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length <= 1)
			{
				return;
			}
			ref T ptr = ref Unsafe.Add<T>(Unsafe.As<byte, T>(array.GetRawSzArrayData()), index);
			ref T ptr2 = ref Unsafe.Add<T>(Unsafe.Add<T>(ref ptr, length), -1);
			do
			{
				T t = ptr;
				ptr = ptr2;
				ptr2 = t;
				ptr = Unsafe.Add<T>(ref ptr, 1);
				ptr2 = Unsafe.Add<T>(ref ptr2, -1);
			}
			while (Unsafe.IsAddressLessThan<T>(ref ptr, ref ptr2));
		}

		/// <summary>Sorts the elements in a one-dimensional <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="array">The one-dimensional array to sort.</param>
		/// <param name="comparer">The implementation to use when comparing elements.-or-
		///       <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
		/// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		// Token: 0x06000BBA RID: 3002 RVA: 0x00030901 File Offset: 0x0002EB01
		public static void Sort(Array array, IComparer comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Sort(array, null, array.GetLowerBound(0), array.Length, comparer);
		}

		/// <summary>Sorts the elements in a range of elements in a one-dimensional <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param>
		/// <param name="index">The starting index of the range to sort.</param>
		/// <param name="length">The number of elements in the range to sort.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or-
		///       <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="array" /> is multidimensional.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />. -or-
		///         The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
		// Token: 0x06000BBB RID: 3003 RVA: 0x00030926 File Offset: 0x0002EB26
		public static void Sort(Array array, int index, int length, IComparer comparer)
		{
			Array.Sort(array, null, index, length, comparer);
		}

		/// <summary>Sorts a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each key.</summary>
		/// <param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param>
		/// <param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.-or-
		///       <see langword="null" /> to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="keys" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.-or-The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">One or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
		// Token: 0x06000BBC RID: 3004 RVA: 0x00030932 File Offset: 0x0002EB32
		public static void Sort(Array keys, Array items)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			Array.Sort(keys, items, keys.GetLowerBound(0), keys.Length, null);
		}

		/// <summary>Sorts a range of elements in a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param>
		/// <param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.-or-
		///       <see langword="null" /> to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param>
		/// <param name="index">The starting index of the range to sort.</param>
		/// <param name="length">The number of elements in the range to sort.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or-
		///       <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="keys" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.-or-The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="keys" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.-or-
		///         <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.-or-
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.-or-
		///         <paramref name="items" /> is not <see langword="null" />, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />. -or-
		///         The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
		// Token: 0x06000BBD RID: 3005 RVA: 0x00030958 File Offset: 0x0002EB58
		public static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			if (keys.Rank != 1 || (items != null && items.Rank != 1))
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			int lowerBound = keys.GetLowerBound(0);
			if (items != null && lowerBound != items.GetLowerBound(0))
			{
				throw new ArgumentException("The arrays' lower bounds must be identical.");
			}
			if (index < lowerBound || length < 0)
			{
				throw new ArgumentOutOfRangeException((length < 0) ? "length" : "index", "Non-negative number required.");
			}
			if (keys.Length - (index - lowerBound) < length || (items != null && index - lowerBound > items.Length - length))
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length > 1)
			{
				Array.SortImpl(keys, items, index, length, comparer);
			}
		}

		/// <summary>Sorts the elements in a range of elements in an <see cref="T:System.Array" /> using the <see cref="T:System.IComparable`1" /> generic interface implementation of each element of the <see cref="T:System.Array" />.</summary>
		/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to sort</param>
		/// <param name="index">The starting index of the range to sort.</param>
		/// <param name="length">The number of elements in the range to sort.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
		// Token: 0x06000BBE RID: 3006 RVA: 0x00030A0D File Offset: 0x0002EC0D
		public static void Sort<T>(T[] array, int index, int length)
		{
			Array.Sort<T>(array, index, length, null);
		}

		/// <summary>Sorts the elements in an <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
		/// <param name="array">The one-dimensional, zero-base <see cref="T:System.Array" /> to sort</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
		/// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		// Token: 0x06000BBF RID: 3007 RVA: 0x00030A18 File Offset: 0x0002EC18
		public static void Sort<T>(T[] array, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Array.Sort<T>(array, 0, array.Length, comparer);
		}

		/// <summary>Sorts the elements in a range of elements in an <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
		/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to sort.</param>
		/// <param name="index">The starting index of the range to sort.</param>
		/// <param name="length">The number of elements in the range to sort.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />. -or-
		///         The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
		// Token: 0x06000BC0 RID: 3008 RVA: 0x00030A34 File Offset: 0x0002EC34
		public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((length < 0) ? "length" : "index", "Non-negative number required.");
			}
			if (array.Length - index < length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length > 1)
			{
				ArraySortHelper<T>.Default.Sort(array, index, length, comparer);
			}
		}

		/// <summary>Sorts a pair of <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
		/// <param name="keys">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the keys to sort. </param>
		/// <param name="items">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the items that correspond to the keys in <paramref name="keys" />, or <see langword="null" /> to sort only <paramref name="keys" />.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
		/// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
		/// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="keys" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.-or-
		///         <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.-or-
		///         The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
		// Token: 0x06000BC1 RID: 3009 RVA: 0x00030A97 File Offset: 0x0002EC97
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			Array.Sort<TKey, TValue>(keys, items, 0, keys.Length, comparer);
		}

		/// <summary>Sorts a range of elements in a pair of <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
		/// <param name="keys">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the keys to sort. </param>
		/// <param name="items">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the items that correspond to the keys in <paramref name="keys" />, or <see langword="null" /> to sort only <paramref name="keys" />.</param>
		/// <param name="index">The starting index of the range to sort.</param>
		/// <param name="length">The number of elements in the range to sort.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
		/// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
		/// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="keys" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="keys" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.-or-
		///         <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.-or-
		///         <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.-or-
		///         <paramref name="items" /> is not <see langword="null" />, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />. -or-
		///         The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00030AB4 File Offset: 0x0002ECB4
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			if (index < 0 || length < 0)
			{
				throw new ArgumentOutOfRangeException((length < 0) ? "length" : "index", "Non-negative number required.");
			}
			if (keys.Length - index < length || (items != null && index > items.Length - length))
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (length > 1)
			{
				if (items == null)
				{
					Array.Sort<TKey>(keys, index, length, comparer);
					return;
				}
				ArraySortHelper<TKey, TValue>.Default.Sort(keys, items, index, length, comparer);
			}
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Array" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Array" />.</returns>
		// Token: 0x06000BC3 RID: 3011 RVA: 0x00030B32 File Offset: 0x0002ED32
		public IEnumerator GetEnumerator()
		{
			return new Array.ArrayEnumerator(this);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00003ACD File Offset: 0x00001CCD
		private Array()
		{
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00030095 File Offset: 0x0002E295
		internal int InternalArray__ICollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0000B18D File Offset: 0x0000938D
		internal bool InternalArray__ICollection_get_IsReadOnly()
		{
			return true;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00030B3A File Offset: 0x0002ED3A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ref byte GetRawSzArrayData()
		{
			return ref Unsafe.As<Array.RawData>(this).Data;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00030B47 File Offset: 0x0002ED47
		internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			if (this.Length == 0)
			{
				return Array.EmptyInternalEnumerator<T>.Value;
			}
			return new Array.InternalEnumerator<T>(this);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00030B62 File Offset: 0x0002ED62
		internal void InternalArray__ICollection_Clear()
		{
			throw new NotSupportedException("Collection is read-only");
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00030B6E File Offset: 0x0002ED6E
		internal void InternalArray__ICollection_Add<T>(T item)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00030B6E File Offset: 0x0002ED6E
		internal bool InternalArray__ICollection_Remove<T>(T item)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00030B7C File Offset: 0x0002ED7C
		internal bool InternalArray__ICollection_Contains<T>(T item)
		{
			if (this.Rank > 1)
			{
				throw new RankException("Only single dimension arrays are supported.");
			}
			int length = this.Length;
			for (int i = 0; i < length; i++)
			{
				T t;
				this.GetGenericValueImpl<T>(i, out t);
				if (item == null)
				{
					if (t == null)
					{
						return true;
					}
				}
				else if (item.Equals(t))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00030BE3 File Offset: 0x0002EDE3
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
		{
			Array.Copy(this, this.GetLowerBound(0), array, arrayIndex, this.Length);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00030BFC File Offset: 0x0002EDFC
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			if (index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			T result;
			this.GetGenericValueImpl<T>(index, out result);
			return result;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00030095 File Offset: 0x0002E295
		internal int InternalArray__IReadOnlyCollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00030B6E File Offset: 0x0002ED6E
		internal void InternalArray__Insert<T>(int index, T item)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00030B6E File Offset: 0x0002ED6E
		internal void InternalArray__RemoveAt(int index)
		{
			throw new NotSupportedException("Collection is of a fixed size");
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00030C28 File Offset: 0x0002EE28
		internal int InternalArray__IndexOf<T>(T item)
		{
			if (this.Rank > 1)
			{
				throw new RankException("Only single dimension arrays are supported.");
			}
			int length = this.Length;
			for (int i = 0; i < length; i++)
			{
				T t;
				this.GetGenericValueImpl<T>(i, out t);
				if (item == null)
				{
					if (t == null)
					{
						return i + this.GetLowerBound(0);
					}
				}
				else if (t.Equals(item))
				{
					return i + this.GetLowerBound(0);
				}
			}
			return this.GetLowerBound(0) - 1;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00030CA8 File Offset: 0x0002EEA8
		internal T InternalArray__get_Item<T>(int index)
		{
			if (index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			T result;
			this.GetGenericValueImpl<T>(index, out result);
			return result;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00030CD4 File Offset: 0x0002EED4
		internal void InternalArray__set_Item<T>(int index, T item)
		{
			if (index >= this.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			object[] array = this as object[];
			if (array != null)
			{
				array[index] = item;
				return;
			}
			this.SetGenericValueImpl<T>(index, ref item);
		}

		// Token: 0x06000BD5 RID: 3029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGenericValue_icall<T>(ref Array self, int pos, out T value);

		// Token: 0x06000BD6 RID: 3030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGenericValue_icall<T>(ref Array self, int pos, ref T value);

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00030D14 File Offset: 0x0002EF14
		internal void GetGenericValueImpl<T>(int pos, out T value)
		{
			Array array = this;
			Array.GetGenericValue_icall<T>(ref array, pos, out value);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00030D2C File Offset: 0x0002EF2C
		internal void SetGenericValueImpl<T>(int pos, ref T value)
		{
			Array array = this;
			Array.SetGenericValue_icall<T>(ref array, pos, ref value);
		}

		/// <summary>Gets the total number of elements in all the dimensions of the <see cref="T:System.Array" />.</summary>
		/// <returns>The total number of elements in all the dimensions of the <see cref="T:System.Array" />; zero if there are no elements in the array.</returns>
		/// <exception cref="T:System.OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00030D44 File Offset: 0x0002EF44
		public int Length
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				int num = this.GetLength(0);
				for (int i = 1; i < this.Rank; i++)
				{
					num *= this.GetLength(i);
				}
				return num;
			}
		}

		/// <summary>Gets the rank (number of dimensions) of the <see cref="T:System.Array" />. For example, a one-dimensional array returns 1, a two-dimensional array returns 2, and so on. </summary>
		/// <returns>The rank (number of dimensions) of the <see cref="T:System.Array" />.</returns>
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00030D75 File Offset: 0x0002EF75
		public int Rank
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.GetRank();
			}
		}

		// Token: 0x06000BDB RID: 3035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetRank();

		/// <summary>Gets a 32-bit integer that represents the number of elements in the specified dimension of the <see cref="T:System.Array" />.</summary>
		/// <param name="dimension">A zero-based dimension of the <see cref="T:System.Array" /> whose length needs to be determined.</param>
		/// <returns>A 32-bit integer that represents the number of elements in the specified dimension.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="dimension" /> is less than zero.-or-
		///         <paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception>
		// Token: 0x06000BDC RID: 3036
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetLength(int dimension);

		/// <summary>Gets the index of the first element of the specified dimension in the array.</summary>
		/// <param name="dimension">A zero-based dimension of the array whose starting index needs to be determined.</param>
		/// <returns>The index of the first element of the specified dimension in the array.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="dimension" /> is less than zero.-or-
		///         <paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception>
		// Token: 0x06000BDD RID: 3037
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetLowerBound(int dimension);

		/// <summary>Gets the value at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 32-bit integers.</summary>
		/// <param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the <see cref="T:System.Array" /> element to get.</param>
		/// <returns>The value at the specified position in the multidimensional <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="indices" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
		// Token: 0x06000BDE RID: 3038
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern object GetValue(params int[] indices);

		/// <summary>Sets a value to the element at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 32-bit integers.</summary>
		/// <param name="value">The new value for the specified element.</param>
		/// <param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the element to set.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="indices" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
		// Token: 0x06000BDF RID: 3039
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetValue(object value, params int[] indices);

		// Token: 0x06000BE0 RID: 3040
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern object GetValueImpl(int pos);

		// Token: 0x06000BE1 RID: 3041
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetValueImpl(object value, int pos);

		// Token: 0x06000BE2 RID: 3042
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length);

		// Token: 0x06000BE3 RID: 3043
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds);

		/// <summary>Gets the index of the last element of the specified dimension in the array.</summary>
		/// <param name="dimension">A zero-based dimension of the array whose upper bound needs to be determined.</param>
		/// <returns>The index of the last element of the specified dimension in the array, or -1 if the specified dimension is empty. </returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="dimension" /> is less than zero.-or-
		///         <paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception>
		// Token: 0x06000BE4 RID: 3044 RVA: 0x00030D7D File Offset: 0x0002EF7D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int GetUpperBound(int dimension)
		{
			return this.GetLowerBound(dimension) + this.GetLength(dimension) - 1;
		}

		/// <summary>Gets the value at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 32-bit integer.</summary>
		/// <param name="index">A 32-bit integer that represents the position of the <see cref="T:System.Array" /> element to get.</param>
		/// <returns>The value at the specified position in the one-dimensional <see cref="T:System.Array" />.</returns>
		/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception>
		// Token: 0x06000BE5 RID: 3045 RVA: 0x00030D90 File Offset: 0x0002EF90
		public object GetValue(int index)
		{
			if (this.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			int lowerBound = this.GetLowerBound(0);
			if (index < lowerBound || index > this.GetUpperBound(0))
			{
				throw new IndexOutOfRangeException("Index has to be between upper and lower bound of the array.");
			}
			if (base.GetType().GetElementType().IsPointer)
			{
				throw new NotSupportedException("Type is not supported.");
			}
			return this.GetValueImpl(index - lowerBound);
		}

		/// <summary>Sets a value to the element at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 32-bit integer.</summary>
		/// <param name="value">The new value for the specified element.</param>
		/// <param name="index">A 32-bit integer that represents the position of the <see cref="T:System.Array" /> element to set.</param>
		/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception>
		// Token: 0x06000BE6 RID: 3046 RVA: 0x00030DF8 File Offset: 0x0002EFF8
		public void SetValue(object value, int index)
		{
			if (this.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			int lowerBound = this.GetLowerBound(0);
			if (index < lowerBound || index > this.GetUpperBound(0))
			{
				throw new IndexOutOfRangeException("Index has to be >= lower bound and <= upper bound of the array.");
			}
			if (base.GetType().GetElementType().IsPointer)
			{
				throw new NotSupportedException("Type is not supported.");
			}
			this.SetValueImpl(value, index - lowerBound);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00030E61 File Offset: 0x0002F061
		internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
		{
			return Array.CreateInstance(elementType, lengths, lowerBounds);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00030E6B File Offset: 0x0002F06B
		internal static Array UnsafeCreateInstance(Type elementType, params int[] lengths)
		{
			return Array.CreateInstance(elementType, lengths);
		}

		/// <summary>Creates a one-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and length, with zero-based indexing.</summary>
		/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
		/// <param name="length">The size of the <see cref="T:System.Array" /> to create.</param>
		/// <returns>A new one-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length, using zero-based indexing.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="elementType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.-or-
		///
		///         <paramref name="elementType" /> is an open generic type.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="length" /> is less than zero.</exception>
		// Token: 0x06000BE9 RID: 3049 RVA: 0x00030E74 File Offset: 0x0002F074
		public static Array CreateInstance(Type elementType, int length)
		{
			int[] lengths = new int[]
			{
				length
			};
			return Array.CreateInstance(elementType, lengths);
		}

		/// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 32-bit integers.</summary>
		/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
		/// <param name="lengths">An array of 32-bit integers that represent the size of each dimension of the <see cref="T:System.Array" /> to create.</param>
		/// <returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="elementType" /> is <see langword="null" />.-or-
		///         <paramref name="lengths" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.-or-The <paramref name="lengths" /> array contains less than one element.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported. -or-
		///
		///         <paramref name="elementType" /> is an open generic type.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero.</exception>
		// Token: 0x06000BEA RID: 3050 RVA: 0x00030E94 File Offset: 0x0002F094
		public static Array CreateInstance(Type elementType, params int[] lengths)
		{
			if (elementType == null)
			{
				throw new ArgumentNullException("elementType");
			}
			if (lengths == null)
			{
				throw new ArgumentNullException("lengths");
			}
			if (lengths.Length > 255)
			{
				throw new TypeLoadException();
			}
			int[] bounds = null;
			elementType = (elementType.UnderlyingSystemType as RuntimeType);
			if (elementType == null)
			{
				throw new ArgumentException("Type must be a type provided by the runtime.", "elementType");
			}
			if (elementType.Equals(typeof(void)))
			{
				throw new NotSupportedException("Array type can not be void");
			}
			if (elementType.ContainsGenericParameters)
			{
				throw new NotSupportedException("Array type can not be an open generic type");
			}
			return Array.CreateInstanceImpl(elementType, lengths, bounds);
		}

		/// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with the specified lower bounds.</summary>
		/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
		/// <param name="lengths">A one-dimensional array that contains the size of each dimension of the <see cref="T:System.Array" /> to create.</param>
		/// <param name="lowerBounds">A one-dimensional array that contains the lower bound (starting index) of each dimension of the <see cref="T:System.Array" /> to create.</param>
		/// <returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length and lower bound for each dimension.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="elementType" /> is <see langword="null" />.-or-
		///         <paramref name="lengths" /> is <see langword="null" />.-or-
		///         <paramref name="lowerBounds" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.-or-The <paramref name="lengths" /> array contains less than one element.-or-The <paramref name="lengths" /> and <paramref name="lowerBounds" /> arrays do not contain the same number of elements.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported. -or-
		///
		///         <paramref name="elementType" /> is an open generic type.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero.-or-Any value in <paramref name="lowerBounds" /> is very large, such that the sum of a dimension's lower bound and length is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06000BEB RID: 3051 RVA: 0x00030F34 File Offset: 0x0002F134
		public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
		{
			if (elementType == null)
			{
				throw new ArgumentNullException("elementType");
			}
			if (lengths == null)
			{
				throw new ArgumentNullException("lengths");
			}
			if (lowerBounds == null)
			{
				throw new ArgumentNullException("lowerBounds");
			}
			elementType = (elementType.UnderlyingSystemType as RuntimeType);
			if (elementType == null)
			{
				throw new ArgumentException("Type must be a type provided by the runtime.", "elementType");
			}
			if (elementType.Equals(typeof(void)))
			{
				throw new NotSupportedException("Array type can not be void");
			}
			if (elementType.ContainsGenericParameters)
			{
				throw new NotSupportedException("Array type can not be an open generic type");
			}
			if (lengths.Length < 1)
			{
				throw new ArgumentException("Arrays must contain >= 1 elements.");
			}
			if (lengths.Length != lowerBounds.Length)
			{
				throw new ArgumentException("Arrays must be of same size.");
			}
			for (int i = 0; i < lowerBounds.Length; i++)
			{
				if (lengths[i] < 0)
				{
					throw new ArgumentOutOfRangeException("lengths", "Each value has to be >= 0.");
				}
				if ((long)lowerBounds[i] + (long)lengths[i] > 2147483647L)
				{
					throw new ArgumentOutOfRangeException("lengths", "Length + bound must not exceed Int32.MaxValue.");
				}
			}
			if (lengths.Length > 255)
			{
				throw new TypeLoadException();
			}
			return Array.CreateInstanceImpl(elementType, lengths, lowerBounds);
		}

		/// <summary>Sets a range of elements in an array to the default value of each element type.</summary>
		/// <param name="array">The array whose elements need to be cleared.</param>
		/// <param name="index">The starting index of the range of elements to clear.</param>
		/// <param name="length">The number of elements to clear.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-
		///         <paramref name="length" /> is less than zero.-or-The sum of <paramref name="index" /> and <paramref name="length" /> is greater than the size of <paramref name="array" />.</exception>
		// Token: 0x06000BEC RID: 3052 RVA: 0x00031048 File Offset: 0x0002F248
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void Clear(Array array, int index, int length)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (length < 0)
			{
				throw new IndexOutOfRangeException("length < 0");
			}
			int lowerBound = array.GetLowerBound(0);
			if (index < lowerBound)
			{
				throw new IndexOutOfRangeException("index < lower bound");
			}
			index -= lowerBound;
			if (index > array.Length - length)
			{
				throw new IndexOutOfRangeException("index + length > size");
			}
			Array.ClearInternal(array, index, length);
		}

		// Token: 0x06000BED RID: 3053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ClearInternal(Array a, int index, int count);

		/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the first element and pastes them into another <see cref="T:System.Array" /> starting at the first element. The length is specified as a 32-bit integer.</summary>
		/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
		/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
		/// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sourceArray" /> is <see langword="null" />.-or-
		///         <paramref name="destinationArray" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">
		///         <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
		/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="length" /> is greater than the number of elements in <paramref name="sourceArray" />.-or-
		///         <paramref name="length" /> is greater than the number of elements in <paramref name="destinationArray" />.</exception>
		// Token: 0x06000BEE RID: 3054 RVA: 0x000310AC File Offset: 0x0002F2AC
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, Array destinationArray, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			Array.Copy(sourceArray, sourceArray.GetLowerBound(0), destinationArray, destinationArray.GetLowerBound(0), length);
		}

		/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index. The length and the indexes are specified as 32-bit integers.</summary>
		/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
		/// <param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param>
		/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
		/// <param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param>
		/// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sourceArray" /> is <see langword="null" />.-or-
		///         <paramref name="destinationArray" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.RankException">
		///         <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">
		///         <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
		/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="sourceIndex" /> is less than the lower bound of the first dimension of <paramref name="sourceArray" />.-or-
		///         <paramref name="destinationIndex" /> is less than the lower bound of the first dimension of <paramref name="destinationArray" />.-or-
		///         <paramref name="length" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.-or-
		///         <paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
		// Token: 0x06000BEF RID: 3055 RVA: 0x000310E0 File Offset: 0x0002F2E0
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Value has to be >= 0.");
			}
			if (sourceArray.Rank != destinationArray.Rank)
			{
				throw new RankException("Only single dimension arrays are supported here.");
			}
			if (sourceIndex < 0)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Value has to be >= 0.");
			}
			if (destinationIndex < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Value has to be >= 0.");
			}
			if (Array.FastCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length))
			{
				return;
			}
			int num = sourceIndex - sourceArray.GetLowerBound(0);
			int num2 = destinationIndex - destinationArray.GetLowerBound(0);
			if (num2 < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Index was less than the array's lower bound in the first dimension.");
			}
			if (num > sourceArray.Length - length)
			{
				throw new ArgumentException("length");
			}
			if (num2 > destinationArray.Length - length)
			{
				throw new ArgumentException("Destination array was not long enough. Check destIndex and length, and the array's lower bounds", "destinationArray");
			}
			Type elementType = sourceArray.GetType().GetElementType();
			Type elementType2 = destinationArray.GetType().GetElementType();
			bool isValueType = elementType2.IsValueType;
			if (sourceArray != destinationArray || num > num2)
			{
				for (int i = 0; i < length; i++)
				{
					object valueImpl = sourceArray.GetValueImpl(num + i);
					if (valueImpl == null && isValueType)
					{
						throw new InvalidCastException();
					}
					try
					{
						destinationArray.SetValueImpl(valueImpl, num2 + i);
					}
					catch (ArgumentException)
					{
						throw Array.CreateArrayTypeMismatchException();
					}
					catch (InvalidCastException)
					{
						if (Array.CanAssignArrayElement(elementType, elementType2))
						{
							throw;
						}
						throw Array.CreateArrayTypeMismatchException();
					}
				}
				return;
			}
			for (int j = length - 1; j >= 0; j--)
			{
				object valueImpl2 = sourceArray.GetValueImpl(num + j);
				try
				{
					destinationArray.SetValueImpl(valueImpl2, num2 + j);
				}
				catch (ArgumentException)
				{
					throw Array.CreateArrayTypeMismatchException();
				}
				catch
				{
					if (Array.CanAssignArrayElement(elementType, elementType2))
					{
						throw;
					}
					throw Array.CreateArrayTypeMismatchException();
				}
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002F56C File Offset: 0x0002D76C
		private static ArrayTypeMismatchException CreateArrayTypeMismatchException()
		{
			return new ArrayTypeMismatchException();
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000312C0 File Offset: 0x0002F4C0
		private static bool CanAssignArrayElement(Type source, Type target)
		{
			if (source.IsValueType)
			{
				return source.IsAssignableFrom(target);
			}
			if (source.IsInterface)
			{
				return !target.IsValueType;
			}
			if (target.IsInterface)
			{
				return !source.IsValueType;
			}
			return source.IsAssignableFrom(target) || target.IsAssignableFrom(source);
		}

		/// <summary>Returns an empty array.</summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <returns>Returns an empty <see cref="T:System.Array" />.</returns>
		// Token: 0x06000BF2 RID: 3058 RVA: 0x00031313 File Offset: 0x0002F513
		public static T[] Empty<T>()
		{
			return EmptyArray<T>.Value;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0003131A File Offset: 0x0002F51A
		private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			return EqualityComparer<T>.Default.IndexOf(array, value, startIndex, count);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0003132A File Offset: 0x0002F52A
		private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			return EqualityComparer<T>.Default.LastIndexOf(array, value, startIndex, count);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0003133C File Offset: 0x0002F53C
		private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer)
		{
			object[] array = keys as object[];
			object[] array2 = null;
			if (array != null)
			{
				array2 = (items as object[]);
			}
			if (array != null && (items == null || array2 != null))
			{
				Array.SorterObjectArray sorterObjectArray = new Array.SorterObjectArray(array, array2, comparer);
				sorterObjectArray.Sort(index, length);
				return;
			}
			Array.SorterGenericArray sorterGenericArray = new Array.SorterGenericArray(keys, items, comparer);
			sorterGenericArray.Sort(index, length);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0003138E File Offset: 0x0002F58E
		internal static T UnsafeLoad<T>(T[] array, int index)
		{
			return array[index];
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00031397 File Offset: 0x0002F597
		internal static R UnsafeMov<S, R>(S instance)
		{
			return (R)((object)instance);
		}

		// Token: 0x0200012D RID: 301
		private sealed class ArrayEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06000BF8 RID: 3064 RVA: 0x000313A4 File Offset: 0x0002F5A4
			internal ArrayEnumerator(Array array)
			{
				this._array = array;
				this._index = -1;
				this._endIndex = array.Length;
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x000313C6 File Offset: 0x0002F5C6
			public bool MoveNext()
			{
				if (this._index < this._endIndex)
				{
					this._index++;
					return this._index < this._endIndex;
				}
				return false;
			}

			// Token: 0x06000BFA RID: 3066 RVA: 0x000313F4 File Offset: 0x0002F5F4
			public void Reset()
			{
				this._index = -1;
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00031400 File Offset: 0x0002F600
			public object Current
			{
				get
				{
					if (this._index < 0)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					if (this._index >= this._endIndex)
					{
						throw new InvalidOperationException("Enumeration already finished.");
					}
					if (this._index == 0 && this._array.GetType().GetElementType().IsPointer)
					{
						throw new NotSupportedException("Type is not supported.");
					}
					return this._array.GetValueImpl(this._index);
				}
			}

			// Token: 0x040003DE RID: 990
			private Array _array;

			// Token: 0x040003DF RID: 991
			private int _index;

			// Token: 0x040003E0 RID: 992
			private int _endIndex;
		}

		// Token: 0x0200012E RID: 302
		[StructLayout(0)]
		private class RawData
		{
			// Token: 0x040003E1 RID: 993
			public IntPtr Bounds;

			// Token: 0x040003E2 RID: 994
			public IntPtr Count;

			// Token: 0x040003E3 RID: 995
			public byte Data;
		}

		// Token: 0x0200012F RID: 303
		internal struct InternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000BFD RID: 3069 RVA: 0x00031475 File Offset: 0x0002F675
			internal InternalEnumerator(Array array)
			{
				this.array = array;
				this.idx = -2;
			}

			// Token: 0x06000BFE RID: 3070 RVA: 0x00002A7D File Offset: 0x00000C7D
			public void Dispose()
			{
			}

			// Token: 0x06000BFF RID: 3071 RVA: 0x00031488 File Offset: 0x0002F688
			public bool MoveNext()
			{
				if (this.idx == -2)
				{
					this.idx = this.array.Length;
				}
				if (this.idx != -1)
				{
					int num = this.idx - 1;
					this.idx = num;
					return num != -1;
				}
				return false;
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000C00 RID: 3072 RVA: 0x000314D4 File Offset: 0x0002F6D4
			public T Current
			{
				get
				{
					if (this.idx == -2)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext");
					}
					if (this.idx == -1)
					{
						throw new InvalidOperationException("Enumeration already finished");
					}
					return this.array.InternalArray__get_Item<T>(this.array.Length - 1 - this.idx);
				}
			}

			// Token: 0x06000C01 RID: 3073 RVA: 0x00031529 File Offset: 0x0002F729
			void IEnumerator.Reset()
			{
				this.idx = -2;
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00031533 File Offset: 0x0002F733
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x040003E4 RID: 996
			private readonly Array array;

			// Token: 0x040003E5 RID: 997
			private int idx;
		}

		// Token: 0x02000130 RID: 304
		internal class EmptyInternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000C03 RID: 3075 RVA: 0x00002A7D File Offset: 0x00000C7D
			public void Dispose()
			{
			}

			// Token: 0x06000C04 RID: 3076 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			public bool MoveNext()
			{
				return false;
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00031540 File Offset: 0x0002F740
			public T Current
			{
				get
				{
					throw new InvalidOperationException("Enumeration has not started. Call MoveNext");
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0003154C File Offset: 0x0002F74C
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000C07 RID: 3079 RVA: 0x00002A7D File Offset: 0x00000C7D
			void IEnumerator.Reset()
			{
			}

			// Token: 0x040003E6 RID: 998
			public static readonly Array.EmptyInternalEnumerator<T> Value = new Array.EmptyInternalEnumerator<T>();
		}

		// Token: 0x02000131 RID: 305
		private struct SorterObjectArray
		{
			// Token: 0x06000C0A RID: 3082 RVA: 0x00031565 File Offset: 0x0002F765
			internal SorterObjectArray(object[] keys, object[] items, IComparer comparer)
			{
				if (comparer == null)
				{
					comparer = Comparer.Default;
				}
				this.keys = keys;
				this.items = items;
				this.comparer = comparer;
			}

			// Token: 0x06000C0B RID: 3083 RVA: 0x00031588 File Offset: 0x0002F788
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				if (a != b && this.comparer.Compare(this.keys[a], this.keys[b]) > 0)
				{
					object obj = this.keys[a];
					this.keys[a] = this.keys[b];
					this.keys[b] = obj;
					if (this.items != null)
					{
						object obj2 = this.items[a];
						this.items[a] = this.items[b];
						this.items[b] = obj2;
					}
				}
			}

			// Token: 0x06000C0C RID: 3084 RVA: 0x00031604 File Offset: 0x0002F804
			private void Swap(int i, int j)
			{
				object obj = this.keys[i];
				this.keys[i] = this.keys[j];
				this.keys[j] = obj;
				if (this.items != null)
				{
					object obj2 = this.items[i];
					this.items[i] = this.items[j];
					this.items[j] = obj2;
				}
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x0003165D File Offset: 0x0002F85D
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x00031668 File Offset: 0x0002F868
			private void IntrospectiveSort(int left, int length)
			{
				if (length < 2)
				{
					return;
				}
				try
				{
					this.IntroSort(left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2PlusOne(this.keys.Length));
				}
				catch (IndexOutOfRangeException)
				{
					IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(this.comparer);
				}
				catch (Exception innerException)
				{
					throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
				}
			}

			// Token: 0x06000C0F RID: 3087 RVA: 0x000316D0 File Offset: 0x0002F8D0
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				while (hi > lo)
				{
					int num = hi - lo + 1;
					if (num <= 16)
					{
						if (num == 1)
						{
							return;
						}
						if (num == 2)
						{
							this.SwapIfGreaterWithItems(lo, hi);
							return;
						}
						if (num == 3)
						{
							this.SwapIfGreaterWithItems(lo, hi - 1);
							this.SwapIfGreaterWithItems(lo, hi);
							this.SwapIfGreaterWithItems(hi - 1, hi);
							return;
						}
						this.InsertionSort(lo, hi);
						return;
					}
					else
					{
						if (depthLimit == 0)
						{
							this.Heapsort(lo, hi);
							return;
						}
						depthLimit--;
						int num2 = this.PickPivotAndPartition(lo, hi);
						this.IntroSort(num2 + 1, hi, depthLimit);
						hi = num2 - 1;
					}
				}
			}

			// Token: 0x06000C10 RID: 3088 RVA: 0x00031754 File Offset: 0x0002F954
			private int PickPivotAndPartition(int lo, int hi)
			{
				int num = lo + (hi - lo) / 2;
				this.SwapIfGreaterWithItems(lo, num);
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(num, hi);
				object obj = this.keys[num];
				this.Swap(num, hi - 1);
				int i = lo;
				int num2 = hi - 1;
				while (i < num2)
				{
					while (this.comparer.Compare(this.keys[++i], obj) < 0)
					{
					}
					while (this.comparer.Compare(obj, this.keys[--num2]) < 0)
					{
					}
					if (i >= num2)
					{
						break;
					}
					this.Swap(i, num2);
				}
				this.Swap(i, hi - 1);
				return i;
			}

			// Token: 0x06000C11 RID: 3089 RVA: 0x000317F0 File Offset: 0x0002F9F0
			private void Heapsort(int lo, int hi)
			{
				int num = hi - lo + 1;
				for (int i = num / 2; i >= 1; i--)
				{
					this.DownHeap(i, num, lo);
				}
				for (int j = num; j > 1; j--)
				{
					this.Swap(lo, lo + j - 1);
					this.DownHeap(1, j - 1, lo);
				}
			}

			// Token: 0x06000C12 RID: 3090 RVA: 0x00031840 File Offset: 0x0002FA40
			private void DownHeap(int i, int n, int lo)
			{
				object obj = this.keys[lo + i - 1];
				object obj2 = (this.items != null) ? this.items[lo + i - 1] : null;
				while (i <= n / 2)
				{
					int num = 2 * i;
					if (num < n && this.comparer.Compare(this.keys[lo + num - 1], this.keys[lo + num]) < 0)
					{
						num++;
					}
					if (this.comparer.Compare(obj, this.keys[lo + num - 1]) >= 0)
					{
						break;
					}
					this.keys[lo + i - 1] = this.keys[lo + num - 1];
					if (this.items != null)
					{
						this.items[lo + i - 1] = this.items[lo + num - 1];
					}
					i = num;
				}
				this.keys[lo + i - 1] = obj;
				if (this.items != null)
				{
					this.items[lo + i - 1] = obj2;
				}
			}

			// Token: 0x06000C13 RID: 3091 RVA: 0x00031928 File Offset: 0x0002FB28
			private void InsertionSort(int lo, int hi)
			{
				for (int i = lo; i < hi; i++)
				{
					int num = i;
					object obj = this.keys[i + 1];
					object obj2 = (this.items != null) ? this.items[i + 1] : null;
					while (num >= lo && this.comparer.Compare(obj, this.keys[num]) < 0)
					{
						this.keys[num + 1] = this.keys[num];
						if (this.items != null)
						{
							this.items[num + 1] = this.items[num];
						}
						num--;
					}
					this.keys[num + 1] = obj;
					if (this.items != null)
					{
						this.items[num + 1] = obj2;
					}
				}
			}

			// Token: 0x040003E7 RID: 999
			private object[] keys;

			// Token: 0x040003E8 RID: 1000
			private object[] items;

			// Token: 0x040003E9 RID: 1001
			private IComparer comparer;
		}

		// Token: 0x02000132 RID: 306
		private struct SorterGenericArray
		{
			// Token: 0x06000C14 RID: 3092 RVA: 0x000319D5 File Offset: 0x0002FBD5
			internal SorterGenericArray(Array keys, Array items, IComparer comparer)
			{
				if (comparer == null)
				{
					comparer = Comparer.Default;
				}
				this.keys = keys;
				this.items = items;
				this.comparer = comparer;
			}

			// Token: 0x06000C15 RID: 3093 RVA: 0x000319F8 File Offset: 0x0002FBF8
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				if (a != b && this.comparer.Compare(this.keys.GetValue(a), this.keys.GetValue(b)) > 0)
				{
					object value = this.keys.GetValue(a);
					this.keys.SetValue(this.keys.GetValue(b), a);
					this.keys.SetValue(value, b);
					if (this.items != null)
					{
						object value2 = this.items.GetValue(a);
						this.items.SetValue(this.items.GetValue(b), a);
						this.items.SetValue(value2, b);
					}
				}
			}

			// Token: 0x06000C16 RID: 3094 RVA: 0x00031AA0 File Offset: 0x0002FCA0
			private void Swap(int i, int j)
			{
				object value = this.keys.GetValue(i);
				this.keys.SetValue(this.keys.GetValue(j), i);
				this.keys.SetValue(value, j);
				if (this.items != null)
				{
					object value2 = this.items.GetValue(i);
					this.items.SetValue(this.items.GetValue(j), i);
					this.items.SetValue(value2, j);
				}
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x00031B19 File Offset: 0x0002FD19
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x00031B24 File Offset: 0x0002FD24
			private void IntrospectiveSort(int left, int length)
			{
				if (length < 2)
				{
					return;
				}
				try
				{
					this.IntroSort(left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2PlusOne(this.keys.Length));
				}
				catch (IndexOutOfRangeException)
				{
					IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(this.comparer);
				}
				catch (Exception innerException)
				{
					throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
				}
			}

			// Token: 0x06000C19 RID: 3097 RVA: 0x00031B90 File Offset: 0x0002FD90
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				while (hi > lo)
				{
					int num = hi - lo + 1;
					if (num <= 16)
					{
						if (num == 1)
						{
							return;
						}
						if (num == 2)
						{
							this.SwapIfGreaterWithItems(lo, hi);
							return;
						}
						if (num == 3)
						{
							this.SwapIfGreaterWithItems(lo, hi - 1);
							this.SwapIfGreaterWithItems(lo, hi);
							this.SwapIfGreaterWithItems(hi - 1, hi);
							return;
						}
						this.InsertionSort(lo, hi);
						return;
					}
					else
					{
						if (depthLimit == 0)
						{
							this.Heapsort(lo, hi);
							return;
						}
						depthLimit--;
						int num2 = this.PickPivotAndPartition(lo, hi);
						this.IntroSort(num2 + 1, hi, depthLimit);
						hi = num2 - 1;
					}
				}
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x00031C14 File Offset: 0x0002FE14
			private int PickPivotAndPartition(int lo, int hi)
			{
				int num = lo + (hi - lo) / 2;
				this.SwapIfGreaterWithItems(lo, num);
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(num, hi);
				object value = this.keys.GetValue(num);
				this.Swap(num, hi - 1);
				int i = lo;
				int num2 = hi - 1;
				while (i < num2)
				{
					while (this.comparer.Compare(this.keys.GetValue(++i), value) < 0)
					{
					}
					while (this.comparer.Compare(value, this.keys.GetValue(--num2)) < 0)
					{
					}
					if (i >= num2)
					{
						break;
					}
					this.Swap(i, num2);
				}
				this.Swap(i, hi - 1);
				return i;
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x00031CBC File Offset: 0x0002FEBC
			private void Heapsort(int lo, int hi)
			{
				int num = hi - lo + 1;
				for (int i = num / 2; i >= 1; i--)
				{
					this.DownHeap(i, num, lo);
				}
				for (int j = num; j > 1; j--)
				{
					this.Swap(lo, lo + j - 1);
					this.DownHeap(1, j - 1, lo);
				}
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00031D0C File Offset: 0x0002FF0C
			private void DownHeap(int i, int n, int lo)
			{
				object value = this.keys.GetValue(lo + i - 1);
				object value2 = (this.items != null) ? this.items.GetValue(lo + i - 1) : null;
				while (i <= n / 2)
				{
					int num = 2 * i;
					if (num < n && this.comparer.Compare(this.keys.GetValue(lo + num - 1), this.keys.GetValue(lo + num)) < 0)
					{
						num++;
					}
					if (this.comparer.Compare(value, this.keys.GetValue(lo + num - 1)) >= 0)
					{
						break;
					}
					this.keys.SetValue(this.keys.GetValue(lo + num - 1), lo + i - 1);
					if (this.items != null)
					{
						this.items.SetValue(this.items.GetValue(lo + num - 1), lo + i - 1);
					}
					i = num;
				}
				this.keys.SetValue(value, lo + i - 1);
				if (this.items != null)
				{
					this.items.SetValue(value2, lo + i - 1);
				}
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x00031E20 File Offset: 0x00030020
			private void InsertionSort(int lo, int hi)
			{
				for (int i = lo; i < hi; i++)
				{
					int num = i;
					object value = this.keys.GetValue(i + 1);
					object value2 = (this.items != null) ? this.items.GetValue(i + 1) : null;
					while (num >= lo && this.comparer.Compare(value, this.keys.GetValue(num)) < 0)
					{
						this.keys.SetValue(this.keys.GetValue(num), num + 1);
						if (this.items != null)
						{
							this.items.SetValue(this.items.GetValue(num), num + 1);
						}
						num--;
					}
					this.keys.SetValue(value, num + 1);
					if (this.items != null)
					{
						this.items.SetValue(value2, num + 1);
					}
				}
			}

			// Token: 0x040003EA RID: 1002
			private Array keys;

			// Token: 0x040003EB RID: 1003
			private Array items;

			// Token: 0x040003EC RID: 1004
			private IComparer comparer;
		}
	}
}
