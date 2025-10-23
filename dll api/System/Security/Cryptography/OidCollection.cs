using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Security.Cryptography
{
	/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.Oid" /> objects. This class cannot be inherited.</summary>
	// Token: 0x020000DC RID: 220
	public sealed class OidCollection : ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.OidCollection" /> class.</summary>
		// Token: 0x06000652 RID: 1618 RVA: 0x00025E9C File Offset: 0x0002409C
		public OidCollection()
		{
			this._list = new List<Oid>();
		}

		/// <summary>Adds an <see cref="T:System.Security.Cryptography.Oid" /> object to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <param name="oid">The <see cref="T:System.Security.Cryptography.Oid" /> object to add to the collection.</param>
		/// <returns>The index of the added <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		// Token: 0x06000653 RID: 1619 RVA: 0x00025EAF File Offset: 0x000240AF
		public int Add(Oid oid)
		{
			int count = this._list.Count;
			this._list.Add(oid);
			return count;
		}

		/// <summary>Gets an <see cref="T:System.Security.Cryptography.Oid" /> object from the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <param name="index">The location of the <see cref="T:System.Security.Cryptography.Oid" /> object in the collection.</param>
		/// <returns>An <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		// Token: 0x170000E4 RID: 228
		public Oid this[int index]
		{
			get
			{
				return this._list[index];
			}
		}

		/// <summary>Gets the number of <see cref="T:System.Security.Cryptography.Oid" /> objects in a collection. </summary>
		/// <returns>The number of <see cref="T:System.Security.Cryptography.Oid" /> objects in a collection.</returns>
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00025ED6 File Offset: 0x000240D6
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Returns an <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.OidEnumerator" /> object.</returns>
		// Token: 0x06000656 RID: 1622 RVA: 0x00025EE3 File Offset: 0x000240E3
		public OidEnumerator GetEnumerator()
		{
			return new OidEnumerator(this);
		}

		/// <summary>Returns an <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the collection.</returns>
		// Token: 0x06000657 RID: 1623 RVA: 0x00025EEB File Offset: 0x000240EB
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Copies the <see cref="T:System.Security.Cryptography.OidCollection" /> object into an array.</summary>
		/// <param name="array">The array to copy the <see cref="T:System.Security.Cryptography.OidCollection" /> object to.</param>
		/// <param name="index">The location where the copy operation starts.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> cannot be a multidimensional array.-or-
		///         The length of <paramref name="array" /> is an invalid offset length.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="index" /> is out range.</exception>
		// Token: 0x06000658 RID: 1624 RVA: 0x00025EF4 File Offset: 0x000240F4
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			if (index < 0 || index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (index + this.Count > array.Length)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(this[i], index);
				index++;
			}
		}

		/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object is thread safe.</summary>
		/// <returns>
		///     <see langword="false" /> in all cases.</returns>
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</returns>
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00014B09 File Offset: 0x00012D09
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000437 RID: 1079
		private readonly List<Oid> _list;
	}
}
