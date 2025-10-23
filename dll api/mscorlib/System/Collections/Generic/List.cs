using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Generic
{
	/// <summary>Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	// Token: 0x02000625 RID: 1573
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.List`1" /> class that is empty and has the default initial capacity.</summary>
		// Token: 0x06002FC1 RID: 12225 RVA: 0x000C1500 File Offset: 0x000BF700
		public List()
		{
			this._items = List<T>.s_emptyArray;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.List`1" /> class that is empty and has the specified initial capacity.</summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than 0. </exception>
		// Token: 0x06002FC2 RID: 12226 RVA: 0x000C1513 File Offset: 0x000BF713
		public List(int capacity)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (capacity == 0)
			{
				this._items = List<T>.s_emptyArray;
				return;
			}
			this._items = new T[capacity];
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.List`1" /> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.</summary>
		/// <param name="collection">The collection whose elements are copied to the new list.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="collection" /> is <see langword="null" />.</exception>
		// Token: 0x06002FC3 RID: 12227 RVA: 0x000C1544 File Offset: 0x000BF744
		public List(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 == null)
			{
				this._size = 0;
				this._items = List<T>.s_emptyArray;
				this.AddEnumerable(collection);
				return;
			}
			int count = collection2.Count;
			if (count == 0)
			{
				this._items = List<T>.s_emptyArray;
				return;
			}
			this._items = new T[count];
			collection2.CopyTo(this._items, 0);
			this._size = count;
		}

		/// <summary>Gets or sets the total number of elements the internal data structure can hold without resizing.</summary>
		/// <returns>The number of elements that the <see cref="T:System.Collections.Generic.List`1" /> can contain before resizing is required.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <see cref="P:System.Collections.Generic.List`1.Capacity" /> is set to a value that is less than <see cref="P:System.Collections.Generic.List`1.Count" />. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
		// Token: 0x170007BD RID: 1981
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x000C15BC File Offset: 0x000BF7BC
		public int Capacity
		{
			set
			{
				if (value < this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
				}
				if (value != this._items.Length)
				{
					if (value > 0)
					{
						T[] array = new T[value];
						if (this._size > 0)
						{
							Array.Copy(this._items, 0, array, 0, this._size);
						}
						this._items = array;
						return;
					}
					this._items = List<T>.s_emptyArray;
				}
			}
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000C1621 File Offset: 0x000BF821
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.List`1" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> is read-only; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.List`1" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.List`1" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.  In the default implementation of <see cref="T:System.Collections.Generic.List`1" />, this property always returns the current instance.</returns>
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06002FCA RID: 12234 RVA: 0x000C1629 File Offset: 0x000BF829
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

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />. </exception>
		// Token: 0x170007C4 RID: 1988
		public T this[int index]
		{
			get
			{
				if (index >= this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				return this._items[index];
			}
			set
			{
				if (index >= this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				this._items[index] = value;
				this._version++;
			}
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x000C1694 File Offset: 0x000BF894
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.ArgumentException">The property is set and <paramref name="value" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x170007C5 RID: 1989
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
				try
				{
					this[index] = (T)((object)value);
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
				}
			}
		}

		/// <summary>Adds an object to the end of the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">The object to be added to the end of the <see cref="T:System.Collections.Generic.List`1" />. The value can be <see langword="null" /> for reference types.</param>
		// Token: 0x06002FD0 RID: 12240 RVA: 0x000C1718 File Offset: 0x000BF918
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(T item)
		{
			this._version++;
			T[] items = this._items;
			int size = this._size;
			if (size < items.Length)
			{
				this._size = size + 1;
				items[size] = item;
				return;
			}
			this.AddWithResize(item);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000C1760 File Offset: 0x000BF960
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddWithResize(T item)
		{
			int size = this._size;
			this.EnsureCapacity(size + 1);
			this._size = size + 1;
			this._items[size] = item;
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="item">The <see cref="T:System.Object" /> to add to the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>The position into which the new element was inserted.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="item" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002FD2 RID: 12242 RVA: 0x000C1794 File Offset: 0x000BF994
		int IList.Add(object item)
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
			try
			{
				this.Add((T)((object)item));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
			}
			return this.Count - 1;
		}

		/// <summary>Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.List`1" />. The collection itself cannot be <see langword="null" />, but it can contain elements that are <see langword="null" />, if type <paramref name="T" /> is a reference type.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="collection" /> is <see langword="null" />.</exception>
		// Token: 0x06002FD3 RID: 12243 RVA: 0x000C17E4 File Offset: 0x000BF9E4
		public void AddRange(IEnumerable<T> collection)
		{
			this.InsertRange(this._size, collection);
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		// Token: 0x06002FD4 RID: 12244 RVA: 0x000C17F4 File Offset: 0x000BF9F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			this._version++;
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				int size = this._size;
				this._size = 0;
				if (size > 0)
				{
					Array.Clear(this._items, 0, size);
					return;
				}
			}
			else
			{
				this._size = 0;
			}
		}

		/// <summary>Determines whether an element is in the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.List`1" />. The value can be <see langword="null" /> for reference types.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.List`1" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002FD5 RID: 12245 RVA: 0x000C183D File Offset: 0x000BFA3D
		public bool Contains(T item)
		{
			return this._size != 0 && this.IndexOf(item) != -1;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.IList" /> contains a specific value.</summary>
		/// <param name="item">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002FD6 RID: 12246 RVA: 0x000C1856 File Offset: 0x000BFA56
		bool IList.Contains(object item)
		{
			return List<T>.IsCompatibleObject(item) && this.Contains((T)((object)item));
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.Generic.List`1" /> to a compatible one-dimensional array, starting at the beginning of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.List`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.Generic.List`1" /> is greater than the number of elements that the destination <paramref name="array" /> can contain.</exception>
		// Token: 0x06002FD7 RID: 12247 RVA: 0x000C186E File Offset: 0x000BFA6E
		public void CopyTo(T[] array)
		{
			this.CopyTo(array, 0);
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or-
		///         <paramref name="array" /> does not have zero-based indexing.-or-The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.-or-The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		// Token: 0x06002FD8 RID: 12248 RVA: 0x000C1878 File Offset: 0x000BFA78
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			try
			{
				Array.Copy(this._items, 0, array, arrayIndex, this._size);
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.Generic.List`1" /> to a compatible one-dimensional array, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.List`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.Generic.List`1" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.</exception>
		// Token: 0x06002FD9 RID: 12249 RVA: 0x000C18C8 File Offset: 0x000BFAC8
		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x000C18E0 File Offset: 0x000BFAE0
		private void EnsureCapacity(int min)
		{
			if (this._items.Length < min)
			{
				int num = (this._items.Length == 0) ? 4 : (this._items.Length * 2);
				if (num > 2146435071)
				{
					num = 2146435071;
				}
				if (num < min)
				{
					num = min;
				}
				this.Capacity = num;
			}
		}

		/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="match">The <see cref="T:System.Predicate`1" /> delegate that defines the conditions of the element to search for.</param>
		/// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="match" /> is <see langword="null" />.</exception>
		// Token: 0x06002FDB RID: 12251 RVA: 0x000C192A File Offset: 0x000BFB2A
		public int FindIndex(Predicate<T> match)
		{
			return this.FindIndex(0, this._size, match);
		}

		/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the <see cref="T:System.Collections.Generic.List`1" /> that starts at the specified index and contains the specified number of elements.</summary>
		/// <param name="startIndex">The zero-based starting index of the search.</param>
		/// <param name="count">The number of elements in the section to search.</param>
		/// <param name="match">The <see cref="T:System.Predicate`1" /> delegate that defines the conditions of the element to search for.</param>
		/// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="match" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is outside the range of valid indexes for the <see cref="T:System.Collections.Generic.List`1" />.-or-
		///         <paramref name="count" /> is less than 0.-or-
		///         <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in the <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06002FDC RID: 12252 RVA: 0x000C193C File Offset: 0x000BFB3C
		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			if (startIndex > this._size)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index();
			}
			if (count < 0 || startIndex > this._size - count)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (match(this._items[i]))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.List`1.Enumerator" /> for the <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x06002FDD RID: 12253 RVA: 0x000C199B File Offset: 0x000BFB9B
		public List<T>.Enumerator GetEnumerator()
		{
			return new List<T>.Enumerator(this);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x000C19A3 File Offset: 0x000BFBA3
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new List<T>.Enumerator(this);
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06002FDF RID: 12255 RVA: 0x000C19A3 File Offset: 0x000BFBA3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new List<T>.Enumerator(this);
		}

		/// <summary>Searches for the specified object and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.List`1" />. The value can be <see langword="null" /> for reference types.</param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="item" /> within the entire <see cref="T:System.Collections.Generic.List`1" />, if found; otherwise, –1.</returns>
		// Token: 0x06002FE0 RID: 12256 RVA: 0x000C19B0 File Offset: 0x000BFBB0
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._items, item, 0, this._size);
		}

		/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>The index of <paramref name="item" /> if found in the list; otherwise, –1.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="item" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002FE1 RID: 12257 RVA: 0x000C19C5 File Offset: 0x000BFBC5
		int IList.IndexOf(object item)
		{
			if (List<T>.IsCompatibleObject(item))
			{
				return this.IndexOf((T)((object)item));
			}
			return -1;
		}

		/// <summary>Inserts an element into the <see cref="T:System.Collections.Generic.List`1" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="item">The object to insert. The value can be <see langword="null" /> for reference types.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		// Token: 0x06002FE2 RID: 12258 RVA: 0x000C19E0 File Offset: 0x000BFBE0
		public void Insert(int index, T item)
		{
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_ListInsert);
			}
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this._items, index, this._items, index + 1, this._size - index);
			}
			this._items[index] = item;
			this._size++;
			this._version++;
		}

		/// <summary>Inserts an item to the <see cref="T:System.Collections.IList" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="item">The object to insert into the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.IList" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="item" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002FE3 RID: 12259 RVA: 0x000C1A6C File Offset: 0x000BFC6C
		void IList.Insert(int index, object item)
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
			try
			{
				this.Insert(index, (T)((object)item));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
			}
		}

		/// <summary>Inserts the elements of a collection into the <see cref="T:System.Collections.Generic.List`1" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which the new elements should be inserted.</param>
		/// <param name="collection">The collection whose elements should be inserted into the <see cref="T:System.Collections.Generic.List`1" />. The collection itself cannot be <see langword="null" />, but it can contain elements that are <see langword="null" />, if type <paramref name="T" /> is a reference type.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="collection" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		// Token: 0x06002FE4 RID: 12260 RVA: 0x000C1AB4 File Offset: 0x000BFCB4
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > 0)
				{
					this.EnsureCapacity(this._size + count);
					if (index < this._size)
					{
						Array.Copy(this._items, index, this._items, index + count, this._size - index);
					}
					if (this == collection2)
					{
						Array.Copy(this._items, 0, this._items, index, index);
						Array.Copy(this._items, index + count, this._items, index * 2, this._size - index);
					}
					else
					{
						collection2.CopyTo(this._items, index);
					}
					this._size += count;
				}
			}
			else
			{
				if (index < this._size)
				{
					using (IEnumerator<T> enumerator = collection.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							T item = enumerator.Current;
							this.Insert(index++, item);
						}
						goto IL_FB;
					}
				}
				this.AddEnumerable(collection);
			}
			IL_FB:
			this._version++;
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.List`1" />. The value can be <see langword="null" /> for reference types.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> is successfully removed; otherwise, <see langword="false" />.  This method also returns <see langword="false" /> if <paramref name="item" /> was not found in the <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x06002FE5 RID: 12261 RVA: 0x000C1BDC File Offset: 0x000BFDDC
		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num >= 0)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="item">The object to remove from the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="item" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002FE6 RID: 12262 RVA: 0x000C1BFF File Offset: 0x000BFDFF
		void IList.Remove(object item)
		{
			if (List<T>.IsCompatibleObject(item))
			{
				this.Remove((T)((object)item));
			}
		}

		/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="index">The zero-based index of the element to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		// Token: 0x06002FE7 RID: 12263 RVA: 0x000C1C18 File Offset: 0x000BFE18
		public void RemoveAt(int index)
		{
			if (index >= this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				this._items[this._size] = default(T);
			}
			this._version++;
		}

		/// <summary>Removes a range of elements from the <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="index">The zero-based starting index of the range of elements to remove.</param>
		/// <param name="count">The number of elements to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06002FE8 RID: 12264 RVA: 0x000C1C98 File Offset: 0x000BFE98
		public void RemoveRange(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 0)
			{
				int size = this._size;
				this._size -= count;
				if (index < this._size)
				{
					Array.Copy(this._items, index + count, this._items, index, this._size - index);
				}
				this._version++;
				if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
				{
					Array.Clear(this._items, this._size, count);
				}
			}
		}

		/// <summary>Reverses the order of the elements in the entire <see cref="T:System.Collections.Generic.List`1" />.</summary>
		// Token: 0x06002FE9 RID: 12265 RVA: 0x000C1D32 File Offset: 0x000BFF32
		public void Reverse()
		{
			this.Reverse(0, this.Count);
		}

		/// <summary>Reverses the order of the elements in the specified range.</summary>
		/// <param name="index">The zero-based starting index of the range to reverse.</param>
		/// <param name="count">The number of elements in the range to reverse.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="count" /> is less than 0. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />. </exception>
		// Token: 0x06002FEA RID: 12266 RVA: 0x000C1D44 File Offset: 0x000BFF44
		public void Reverse(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 1)
			{
				Array.Reverse<T>(this._items, index, count);
			}
			this._version++;
		}

		/// <summary>Sorts the elements in the entire <see cref="T:System.Collections.Generic.List`1" /> using the specified comparer.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> implementation to use when comparing elements, or <see langword="null" /> to use the default comparer <see cref="P:System.Collections.Generic.Comparer`1.Default" />.</param>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and the default comparer <see cref="P:System.Collections.Generic.Comparer`1.Default" /> cannot find implementation of the <see cref="T:System.IComparable`1" /> generic interface or the <see cref="T:System.IComparable" /> interface for type <paramref name="T" />.</exception>
		/// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		// Token: 0x06002FEB RID: 12267 RVA: 0x000C1D97 File Offset: 0x000BFF97
		public void Sort(IComparer<T> comparer)
		{
			this.Sort(0, this.Count, comparer);
		}

		/// <summary>Sorts the elements in a range of elements in <see cref="T:System.Collections.Generic.List`1" /> using the specified comparer.</summary>
		/// <param name="index">The zero-based starting index of the range to sort.</param>
		/// <param name="count">The length of the range to sort.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> implementation to use when comparing elements, or <see langword="null" /> to use the default comparer <see cref="P:System.Collections.Generic.Comparer`1.Default" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the <see cref="T:System.Collections.Generic.List`1" />.-or-The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="comparer" /> is <see langword="null" />, and the default comparer <see cref="P:System.Collections.Generic.Comparer`1.Default" /> cannot find implementation of the <see cref="T:System.IComparable`1" /> generic interface or the <see cref="T:System.IComparable" /> interface for type <paramref name="T" />.</exception>
		// Token: 0x06002FEC RID: 12268 RVA: 0x000C1DA8 File Offset: 0x000BFFA8
		public void Sort(int index, int count, IComparer<T> comparer)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 1)
			{
				Array.Sort<T>(this._items, index, count, comparer);
			}
			this._version++;
		}

		/// <summary>Sorts the elements in the entire <see cref="T:System.Collections.Generic.List`1" /> using the specified <see cref="T:System.Comparison`1" />.</summary>
		/// <param name="comparison">The <see cref="T:System.Comparison`1" /> to use when comparing elements.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="comparison" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparison" /> caused an error during the sort. For example, <paramref name="comparison" /> might not return 0 when comparing an item with itself.</exception>
		// Token: 0x06002FED RID: 12269 RVA: 0x000C1DFC File Offset: 0x000BFFFC
		public void Sort(Comparison<T> comparison)
		{
			if (comparison == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparison);
			}
			if (this._size > 1)
			{
				ArraySortHelper<T>.Sort(this._items, 0, this._size, comparison);
			}
			this._version++;
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.Generic.List`1" /> to a new array.</summary>
		/// <returns>An array containing copies of the elements of the <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x06002FEE RID: 12270 RVA: 0x000C1E34 File Offset: 0x000C0034
		public T[] ToArray()
		{
			if (this._size == 0)
			{
				return List<T>.s_emptyArray;
			}
			T[] array = new T[this._size];
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		/// <summary>Sets the capacity to the actual number of elements in the <see cref="T:System.Collections.Generic.List`1" />, if that number is less than a threshold value.</summary>
		// Token: 0x06002FEF RID: 12271 RVA: 0x000C1E70 File Offset: 0x000C0070
		public void TrimExcess()
		{
			int num = (int)((double)this._items.Length * 0.9);
			if (this._size < num)
			{
				this.Capacity = this._size;
			}
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000C1EA8 File Offset: 0x000C00A8
		private void AddEnumerable(IEnumerable<T> enumerable)
		{
			this._version++;
			foreach (T t in enumerable)
			{
				if (this._size == this._items.Length)
				{
					this.EnsureCapacity(this._size + 1);
				}
				T[] items = this._items;
				int size = this._size;
				this._size = size + 1;
				items[size] = t;
			}
		}

		// Token: 0x04001910 RID: 6416
		private T[] _items;

		// Token: 0x04001911 RID: 6417
		private int _size;

		// Token: 0x04001912 RID: 6418
		private int _version;

		// Token: 0x04001913 RID: 6419
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x04001914 RID: 6420
		private static readonly T[] s_emptyArray = new T[0];

		/// <summary>Enumerates the elements of a <see cref="T:System.Collections.Generic.List`1" />.</summary>
		// Token: 0x02000626 RID: 1574
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06002FF2 RID: 12274 RVA: 0x000C1F41 File Offset: 0x000C0141
			internal Enumerator(List<T> list)
			{
				this._list = list;
				this._index = 0;
				this._version = list._version;
				this._current = default(T);
			}

			/// <summary>Releases all resources used by the <see cref="T:System.Collections.Generic.List`1.Enumerator" />.</summary>
			// Token: 0x06002FF3 RID: 12275 RVA: 0x00002A7D File Offset: 0x00000C7D
			public void Dispose()
			{
			}

			/// <summary>Advances the enumerator to the next element of the <see cref="T:System.Collections.Generic.List`1" />.</summary>
			/// <returns>
			///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x06002FF4 RID: 12276 RVA: 0x000C1F6C File Offset: 0x000C016C
			public bool MoveNext()
			{
				List<T> list = this._list;
				if (this._version == list._version && this._index < list._size)
				{
					this._current = list._items[this._index];
					this._index++;
					return true;
				}
				return this.MoveNextRare();
			}

			// Token: 0x06002FF5 RID: 12277 RVA: 0x000C1FC9 File Offset: 0x000C01C9
			private bool MoveNextRare()
			{
				if (this._version != this._list._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = this._list._size + 1;
				this._current = default(T);
				return false;
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the <see cref="T:System.Collections.Generic.List`1" /> at the current position of the enumerator.</returns>
			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000C2003 File Offset: 0x000C0203
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the <see cref="T:System.Collections.Generic.List`1" /> at the current position of the enumerator.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x000C200B File Offset: 0x000C020B
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._list._size + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this.Current;
				}
			}

			/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x06002FF8 RID: 12280 RVA: 0x000C203A File Offset: 0x000C023A
			void IEnumerator.Reset()
			{
				if (this._version != this._list._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x04001915 RID: 6421
			private List<T> _list;

			// Token: 0x04001916 RID: 6422
			private int _index;

			// Token: 0x04001917 RID: 6423
			private int _version;

			// Token: 0x04001918 RID: 6424
			private T _current;
		}
	}
}
