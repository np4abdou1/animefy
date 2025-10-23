using System;

namespace System.Collections.Specialized
{
	/// <summary>Represents a collection of strings.</summary>
	// Token: 0x020002C9 RID: 713
	[Serializable]
	public class StringCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the entry to get or set. </param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Specialized.StringCollection.Count" />. </exception>
		// Token: 0x170003D8 RID: 984
		public string this[int index]
		{
			get
			{
				return (string)this.data[index];
			}
			set
			{
				this.data[index] = value;
			}
		}

		/// <summary>Gets the number of strings contained in the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <returns>The number of strings contained in the <see cref="T:System.Collections.Specialized.StringCollection" />.</returns>
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0005A689 File Offset: 0x00058889
		public int Count
		{
			get
			{
				return this.data.Count;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.StringCollection" /> object is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Specialized.StringCollection" /> object is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x000023F6 File Offset: 0x000005F6
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.StringCollection" /> object has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Specialized.StringCollection" /> object has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x000023F6 File Offset: 0x000005F6
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Adds a string to the end of the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The string to add to the end of the <see cref="T:System.Collections.Specialized.StringCollection" />. The value can be <see langword="null" />. </param>
		/// <returns>The zero-based index at which the new element is inserted.</returns>
		// Token: 0x06001317 RID: 4887 RVA: 0x0005A696 File Offset: 0x00058896
		public int Add(string value)
		{
			return this.data.Add(value);
		}

		/// <summary>Removes all the strings from the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		// Token: 0x06001318 RID: 4888 RVA: 0x0005A6A4 File Offset: 0x000588A4
		public void Clear()
		{
			this.data.Clear();
		}

		/// <summary>Determines whether the specified string is in the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The string to locate in the <see cref="T:System.Collections.Specialized.StringCollection" />. The value can be <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is found in the <see cref="T:System.Collections.Specialized.StringCollection" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001319 RID: 4889 RVA: 0x0005A6B1 File Offset: 0x000588B1
		public bool Contains(string value)
		{
			return this.data.Contains(value);
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.Specialized.StringCollection" /> values to a one-dimensional array of strings, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional array of strings that is the destination of the elements copied from <see cref="T:System.Collections.Specialized.StringCollection" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Specialized.StringCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.StringCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x0600131A RID: 4890 RVA: 0x0005A6BF File Offset: 0x000588BF
		public void CopyTo(string[] array, int index)
		{
			this.data.CopyTo(array, index);
		}

		/// <summary>Searches for the specified string and returns the zero-based index of the first occurrence within the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The string to locate. The value can be <see langword="null" />. </param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> in the <see cref="T:System.Collections.Specialized.StringCollection" />, if found; otherwise, -1.</returns>
		// Token: 0x0600131B RID: 4891 RVA: 0x0005A6CE File Offset: 0x000588CE
		public int IndexOf(string value)
		{
			return this.data.IndexOf(value);
		}

		/// <summary>Inserts a string into the <see cref="T:System.Collections.Specialized.StringCollection" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> is inserted. </param>
		/// <param name="value">The string to insert. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> greater than <see cref="P:System.Collections.Specialized.StringCollection.Count" />. </exception>
		// Token: 0x0600131C RID: 4892 RVA: 0x0005A6DC File Offset: 0x000588DC
		public void Insert(int index, string value)
		{
			this.data.Insert(index, value);
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Specialized.StringCollection" /> is synchronized (thread safe).</summary>
		/// <returns>This property always returns <see langword="false" />.</returns>
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Removes the first occurrence of a specific string from the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The string to remove from the <see cref="T:System.Collections.Specialized.StringCollection" />. The value can be <see langword="null" />. </param>
		// Token: 0x0600131E RID: 4894 RVA: 0x0005A6EB File Offset: 0x000588EB
		public void Remove(string value)
		{
			this.data.Remove(value);
		}

		/// <summary>Removes the string at the specified index of the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="index">The zero-based index of the string to remove. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Specialized.StringCollection.Count" />. </exception>
		// Token: 0x0600131F RID: 4895 RVA: 0x0005A6F9 File Offset: 0x000588F9
		public void RemoveAt(int index)
		{
			this.data.RemoveAt(index);
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.StringCollection" />.</returns>
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0005A707 File Offset: 0x00058907
		public object SyncRoot
		{
			get
			{
				return this.data.SyncRoot;
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set. </param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Specialized.StringCollection.Count" />. </exception>
		// Token: 0x170003DE RID: 990
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (string)value;
			}
		}

		/// <summary>Adds an object to the end of the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be added to the end of the <see cref="T:System.Collections.Specialized.StringCollection" />. The value can be <see langword="null" />. </param>
		/// <returns>The <see cref="T:System.Collections.Specialized.StringCollection" /> index at which the <paramref name="value" /> has been added.</returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.StringCollection" /> is read-only.-or- The <see cref="T:System.Collections.Specialized.StringCollection" /> has a fixed size. </exception>
		// Token: 0x06001323 RID: 4899 RVA: 0x0005A72C File Offset: 0x0005892C
		int IList.Add(object value)
		{
			return this.Add((string)value);
		}

		/// <summary>Determines whether an element is in the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.Specialized.StringCollection" />. The value can be <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is found in the <see cref="T:System.Collections.Specialized.StringCollection" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001324 RID: 4900 RVA: 0x0005A73A File Offset: 0x0005893A
		bool IList.Contains(object value)
		{
			return this.Contains((string)value);
		}

		/// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.Specialized.StringCollection" />. The value can be <see langword="null" />. </param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the entire <see cref="T:System.Collections.Specialized.StringCollection" />, if found; otherwise, -1.</returns>
		// Token: 0x06001325 RID: 4901 RVA: 0x0005A748 File Offset: 0x00058948
		int IList.IndexOf(object value)
		{
			return this.IndexOf((string)value);
		}

		/// <summary>Inserts an element into the <see cref="T:System.Collections.Specialized.StringCollection" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.Specialized.StringCollection.Count" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.StringCollection" /> is read-only.-or- The <see cref="T:System.Collections.Specialized.StringCollection" /> has a fixed size. </exception>
		// Token: 0x06001326 RID: 4902 RVA: 0x0005A756 File Offset: 0x00058956
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (string)value);
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.Specialized.StringCollection" />. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.StringCollection" /> is read-only.-or- The <see cref="T:System.Collections.Specialized.StringCollection" /> has a fixed size. </exception>
		// Token: 0x06001327 RID: 4903 RVA: 0x0005A765 File Offset: 0x00058965
		void IList.Remove(object value)
		{
			this.Remove((string)value);
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.Specialized.StringCollection" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Specialized.StringCollection" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Specialized.StringCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.StringCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06001328 RID: 4904 RVA: 0x0005A6BF File Offset: 0x000588BF
		void ICollection.CopyTo(Array array, int index)
		{
			this.data.CopyTo(array, index);
		}

		/// <summary>Returns a <see cref="T:System.Collections.IEnumerator" /> that iterates through the <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <returns>A <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Specialized.StringCollection" />.</returns>
		// Token: 0x06001329 RID: 4905 RVA: 0x0005A773 File Offset: 0x00058973
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.data.GetEnumerator();
		}

		// Token: 0x04000D34 RID: 3380
		private readonly ArrayList data = new ArrayList();
	}
}
