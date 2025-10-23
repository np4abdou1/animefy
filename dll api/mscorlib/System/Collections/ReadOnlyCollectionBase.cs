using System;

namespace System.Collections
{
	/// <summary>Provides the <see langword="abstract" /> base class for a strongly typed non-generic read-only collection.</summary>
	// Token: 0x020005E3 RID: 1507
	[Serializable]
	public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
	{
		/// <summary>Gets the list of elements contained in the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Collections.ArrayList" /> representing the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance itself.</returns>
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000B8C51 File Offset: 0x000B6E51
		protected ArrayList InnerList
		{
			get
			{
				if (this._list == null)
				{
					this._list = new ArrayList();
				}
				return this._list;
			}
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.Retrieving the value of this property is an O(1) operation.</returns>
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x000B8C6C File Offset: 0x000B6E6C
		public virtual int Count
		{
			get
			{
				return this.InnerList.Count;
			}
		}

		/// <summary>Gets a value indicating whether access to a <see cref="T:System.Collections.ReadOnlyCollectionBase" /> object is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> object is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000B8C79 File Offset: 0x000B6E79
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.InnerList.IsSynchronized;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to a <see cref="T:System.Collections.ReadOnlyCollectionBase" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> object.</returns>
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000B8C86 File Offset: 0x000B6E86
		object ICollection.SyncRoot
		{
			get
			{
				return this.InnerList.SyncRoot;
			}
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.ReadOnlyCollectionBase" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ReadOnlyCollectionBase" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.ReadOnlyCollectionBase" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ReadOnlyCollectionBase" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002CE6 RID: 11494 RVA: 0x000B8C93 File Offset: 0x000B6E93
		void ICollection.CopyTo(Array array, int index)
		{
			this.InnerList.CopyTo(array, index);
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</returns>
		// Token: 0x06002CE7 RID: 11495 RVA: 0x000B8CA2 File Offset: 0x000B6EA2
		public virtual IEnumerator GetEnumerator()
		{
			return this.InnerList.GetEnumerator();
		}

		// Token: 0x04001878 RID: 6264
		private ArrayList _list;
	}
}
