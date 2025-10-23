﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel
{
	/// <summary>Provides the base class for a generic collection.</summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	// Token: 0x02000604 RID: 1540
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Collection<T> : IList<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.Collection`1" /> class that is empty.</summary>
		// Token: 0x06002E99 RID: 11929 RVA: 0x000BE934 File Offset: 0x000BCB34
		public Collection()
		{
			this.items = new List<T>();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.Collection`1" /> class as a wrapper for the specified list.</summary>
		/// <param name="list">The list that is wrapped by the new collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="list" /> is <see langword="null" />.</exception>
		// Token: 0x06002E9A RID: 11930 RVA: 0x000BE947 File Offset: 0x000BCB47
		public Collection(IList<T> list)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			this.items = list;
		}

		/// <summary>Gets the number of elements actually contained in the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <returns>The number of elements actually contained in the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x000BE95F File Offset: 0x000BCB5F
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		/// <summary>Gets a <see cref="T:System.Collections.Generic.IList`1" /> wrapper around the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.IList`1" /> wrapper around the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x000BE96C File Offset: 0x000BCB6C
		protected IList<T> Items
		{
			get
			{
				return this.items;
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />. </exception>
		// Token: 0x1700075E RID: 1886
		public T this[int index]
		{
			get
			{
				return this.items[index];
			}
			set
			{
				if (this.items.IsReadOnly)
				{
					ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
				}
				if (index >= this.items.Count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				this.SetItem(index, value);
			}
		}

		/// <summary>Adds an object to the end of the <see cref="T:System.Collections.ObjectModel.Collection`1" />. </summary>
		/// <param name="item">The object to be added to the end of the <see cref="T:System.Collections.ObjectModel.Collection`1" />. The value can be <see langword="null" /> for reference types.</param>
		// Token: 0x06002E9F RID: 11935 RVA: 0x000BE9B4 File Offset: 0x000BCBB4
		public void Add(T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			int count = this.items.Count;
			this.InsertItem(count, item);
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		// Token: 0x06002EA0 RID: 11936 RVA: 0x000BE9E9 File Offset: 0x000BCBE9
		public void Clear()
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			this.ClearItems();
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.ObjectModel.Collection`1" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ObjectModel.Collection`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.ObjectModel.Collection`1" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		// Token: 0x06002EA1 RID: 11937 RVA: 0x000BEA05 File Offset: 0x000BCC05
		public void CopyTo(T[] array, int index)
		{
			this.items.CopyTo(array, index);
		}

		/// <summary>Determines whether an element is in the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.ObjectModel.Collection`1" />. The value can be <see langword="null" /> for reference types.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> is found in the <see cref="T:System.Collections.ObjectModel.Collection`1" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002EA2 RID: 11938 RVA: 0x000BEA14 File Offset: 0x000BCC14
		public bool Contains(T item)
		{
			return this.items.Contains(item);
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerator`1" /> for the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x06002EA3 RID: 11939 RVA: 0x000BEA22 File Offset: 0x000BCC22
		public IEnumerator<T> GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		/// <summary>Searches for the specified object and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.List`1" />. The value can be <see langword="null" /> for reference types.</param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="item" /> within the entire <see cref="T:System.Collections.ObjectModel.Collection`1" />, if found; otherwise, -1.</returns>
		// Token: 0x06002EA4 RID: 11940 RVA: 0x000BEA2F File Offset: 0x000BCC2F
		public int IndexOf(T item)
		{
			return this.items.IndexOf(item);
		}

		/// <summary>Inserts an element into the <see cref="T:System.Collections.ObjectModel.Collection`1" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="item">The object to insert. The value can be <see langword="null" /> for reference types.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06002EA5 RID: 11941 RVA: 0x000BEA3D File Offset: 0x000BCC3D
		public void Insert(int index, T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (index > this.items.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			this.InsertItem(index, item);
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="item">The object to remove from the <see cref="T:System.Collections.ObjectModel.Collection`1" />. The value can be <see langword="null" /> for reference types.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> is successfully removed; otherwise, <see langword="false" />.  This method also returns <see langword="false" /> if <paramref name="item" /> was not found in the original <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x06002EA6 RID: 11942 RVA: 0x000BEA70 File Offset: 0x000BCC70
		public bool Remove(T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			int num = this.items.IndexOf(item);
			if (num < 0)
			{
				return false;
			}
			this.RemoveItem(num);
			return true;
		}

		/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="index">The zero-based index of the element to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06002EA7 RID: 11943 RVA: 0x000BEAAC File Offset: 0x000BCCAC
		public void RemoveAt(int index)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (index >= this.items.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			this.RemoveItem(index);
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		// Token: 0x06002EA8 RID: 11944 RVA: 0x000BEADC File Offset: 0x000BCCDC
		protected virtual void ClearItems()
		{
			this.items.Clear();
		}

		/// <summary>Inserts an element into the <see cref="T:System.Collections.ObjectModel.Collection`1" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="item">The object to insert. The value can be <see langword="null" /> for reference types.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06002EA9 RID: 11945 RVA: 0x000BEAE9 File Offset: 0x000BCCE9
		protected virtual void InsertItem(int index, T item)
		{
			this.items.Insert(index, item);
		}

		/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="index">The zero-based index of the element to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06002EAA RID: 11946 RVA: 0x000BEAF8 File Offset: 0x000BCCF8
		protected virtual void RemoveItem(int index)
		{
			this.items.RemoveAt(index);
		}

		/// <summary>Replaces the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to replace.</param>
		/// <param name="item">The new value for the element at the specified index. The value can be <see langword="null" /> for reference types.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06002EAB RID: 11947 RVA: 0x000BEB06 File Offset: 0x000BCD06
		protected virtual void SetItem(int index, T item)
		{
			this.items[index] = item;
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x000BEB15 File Offset: 0x000BCD15
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return this.items.IsReadOnly;
			}
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06002EAD RID: 11949 RVA: 0x000BEB22 File Offset: 0x000BCD22
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.ObjectModel.Collection`1" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.  In the default implementation of <see cref="T:System.Collections.ObjectModel.Collection`1" />, this property always returns the current instance.</returns>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x000BEB30 File Offset: 0x000BCD30
		object ICollection.SyncRoot
		{
			get
			{
				ICollection collection = this.items as ICollection;
				if (collection == null)
				{
					return this;
				}
				return collection.SyncRoot;
			}
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or-
		///         <paramref name="array" /> does not have zero-based indexing.-or-The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.-or-The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		// Token: 0x06002EB0 RID: 11952 RVA: 0x000BEB54 File Offset: 0x000BCD54
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			if (array.GetLowerBound(0) != 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.items.CopyTo(array2, index);
				return;
			}
			Type elementType = array.GetType().GetElementType();
			Type typeFromHandle = typeof(T);
			if (!elementType.IsAssignableFrom(typeFromHandle) && !typeFromHandle.IsAssignableFrom(elementType))
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
			int count = this.items.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					array3[index++] = this.items[i];
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.ArgumentException">The property is set and <paramref name="value" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x17000762 RID: 1890
		object IList.this[int index]
		{
			get
			{
				return this.items[index];
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

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> is read-only; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.ObjectModel.Collection`1" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x000BEB15 File Offset: 0x000BCD15
		bool IList.IsReadOnly
		{
			get
			{
				return this.items.IsReadOnly;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.ObjectModel.Collection`1" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x000BECAC File Offset: 0x000BCEAC
		bool IList.IsFixedSize
		{
			get
			{
				IList list = this.items as IList;
				if (list != null)
				{
					return list.IsFixedSize;
				}
				return this.items.IsReadOnly;
			}
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to add to the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>The position into which the new element was inserted.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002EB5 RID: 11957 RVA: 0x000BECDC File Offset: 0x000BCEDC
		int IList.Add(object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			try
			{
				this.Add((T)((object)value));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
			}
			return this.Count - 1;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.IList" /> contains a specific value.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002EB6 RID: 11958 RVA: 0x000BED40 File Offset: 0x000BCF40
		bool IList.Contains(object value)
		{
			return Collection<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002EB7 RID: 11959 RVA: 0x000BED58 File Offset: 0x000BCF58
		int IList.IndexOf(object value)
		{
			if (Collection<T>.IsCompatibleObject(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		/// <summary>Inserts an item into the <see cref="T:System.Collections.IList" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert into the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.IList" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002EB8 RID: 11960 RVA: 0x000BED70 File Offset: 0x000BCF70
		void IList.Insert(int index, object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			try
			{
				this.Insert(index, (T)((object)value));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
			}
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is of a type that is not assignable to the <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06002EB9 RID: 11961 RVA: 0x000BEDCC File Offset: 0x000BCFCC
		void IList.Remove(object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (Collection<T>.IsCompatibleObject(value))
			{
				this.Remove((T)((object)value));
			}
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x000BEDF8 File Offset: 0x000BCFF8
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		// Token: 0x040018DC RID: 6364
		private IList<T> items;
	}
}
