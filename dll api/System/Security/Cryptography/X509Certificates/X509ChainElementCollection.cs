using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> objects. This class cannot be inherited.</summary>
	// Token: 0x020000FB RID: 251
	public sealed class X509ChainElementCollection : ICollection, IEnumerable
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x00028DFA File Offset: 0x00026FFA
		internal X509ChainElementCollection()
		{
			this._list = new ArrayList();
		}

		/// <summary>Gets the number of elements in the collection.</summary>
		/// <returns>An integer representing the number of elements in the collection.</returns>
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00028E0D File Offset: 0x0002700D
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Gets a value indicating whether the collection of chain elements is synchronized.</summary>
		/// <returns>Always returns <see langword="false" />.</returns>
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00028E1A File Offset: 0x0002701A
		public bool IsSynchronized
		{
			get
			{
				return this._list.IsSynchronized;
			}
		}

		/// <summary>Gets the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> object at the specified index.</summary>
		/// <param name="index">An integer value. </param>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is greater than or equal to the length of the collection. </exception>
		// Token: 0x1700012C RID: 300
		public X509ChainElement this[int index]
		{
			get
			{
				return (X509ChainElement)this._list[index];
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object.</summary>
		/// <returns>A pointer reference to the current object.</returns>
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00028E3A File Offset: 0x0002703A
		public object SyncRoot
		{
			get
			{
				return this._list.SyncRoot;
			}
		}

		/// <summary>Copies an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object into an array, starting at the specified index.</summary>
		/// <param name="array">An array to copy the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object to.</param>
		/// <param name="index">The index of <paramref name="array" /> at which to start copying.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The specified <paramref name="index" /> is less than zero, or greater than or equal to the length of the array. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> plus the current count is greater than the length of the array. </exception>
		// Token: 0x06000717 RID: 1815 RVA: 0x00028E47 File Offset: 0x00027047
		void ICollection.CopyTo(Array array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Gets an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator" /> object that can be used to navigate through a collection of chain elements.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator" /> object.</returns>
		// Token: 0x06000718 RID: 1816 RVA: 0x00028E56 File Offset: 0x00027056
		public X509ChainElementEnumerator GetEnumerator()
		{
			return new X509ChainElementEnumerator(this._list);
		}

		/// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> object that can be used to navigate a collection of chain elements.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object.</returns>
		// Token: 0x06000719 RID: 1817 RVA: 0x00028E56 File Offset: 0x00027056
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new X509ChainElementEnumerator(this._list);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00028E63 File Offset: 0x00027063
		internal void Add(X509Certificate2 certificate)
		{
			this._list.Add(new X509ChainElement(certificate));
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00028E77 File Offset: 0x00027077
		internal void Clear()
		{
			this._list.Clear();
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00028E84 File Offset: 0x00027084
		internal bool Contains(X509Certificate2 certificate)
		{
			for (int i = 0; i < this._list.Count; i++)
			{
				if (certificate.Equals((this._list[i] as X509ChainElement).Certificate))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040004E5 RID: 1253
		private ArrayList _list;
	}
}
