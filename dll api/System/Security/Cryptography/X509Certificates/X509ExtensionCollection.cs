using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects. This class cannot be inherited.</summary>
	// Token: 0x02000103 RID: 259
	public sealed class X509ExtensionCollection : ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> class. </summary>
		// Token: 0x0600076C RID: 1900 RVA: 0x0002A774 File Offset: 0x00028974
		public X509ExtensionCollection()
		{
			this._list = new ArrayList();
		}

		/// <summary>Gets the number of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects in a <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
		/// <returns>An integer representing the number of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0002A787 File Offset: 0x00028987
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Gets a value indicating whether the collection is guaranteed to be thread safe.</summary>
		/// <returns>
		///     <see langword="true" /> if the collection is thread safe; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0002A794 File Offset: 0x00028994
		public bool IsSynchronized
		{
			get
			{
				return this._list.IsSynchronized;
			}
		}

		/// <summary>Gets an object that you can use to synchronize access to the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
		/// <returns>An object that you can use to synchronize access to the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00014B09 File Offset: 0x00012D09
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets the first <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> object whose value or friendly name is specified by an object identifier (OID).</summary>
		/// <param name="oid">The object identifier (OID) of the extension to retrieve. </param>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> object.</returns>
		// Token: 0x17000148 RID: 328
		public X509Extension this[string oid]
		{
			get
			{
				if (oid == null)
				{
					throw new ArgumentNullException("oid");
				}
				if (this._list.Count == 0 || oid.Length == 0)
				{
					return null;
				}
				foreach (object obj in this._list)
				{
					X509Extension x509Extension = (X509Extension)obj;
					if (x509Extension.Oid.Value.Equals(oid))
					{
						return x509Extension;
					}
				}
				return null;
			}
		}

		/// <summary>Adds an <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> object to an <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
		/// <param name="extension">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />  object to add to the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object. </param>
		/// <returns>The index at which the <paramref name="extension" /> parameter was added.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value of the <paramref name="extension" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000771 RID: 1905 RVA: 0x0002A838 File Offset: 0x00028A38
		public int Add(X509Extension extension)
		{
			if (extension == null)
			{
				throw new ArgumentNullException("extension");
			}
			return this._list.Add(extension);
		}

		/// <summary>Copies the collection into an array starting at the specified index.</summary>
		/// <param name="array">An array of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects. </param>
		/// <param name="index">The location in the array at which copying starts. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> is a zero-length string or contains an invalid value. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="index" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> specifies a value that is not in the range of the array. </exception>
		// Token: 0x06000772 RID: 1906 RVA: 0x0002A854 File Offset: 0x00028A54
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("negative index");
			}
			if (index >= array.Length)
			{
				throw new ArgumentOutOfRangeException("index >= array.Length");
			}
			this._list.CopyTo(array, index);
		}

		/// <summary>Returns an enumerator that can iterate through an <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator" /> object to use to iterate through the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
		// Token: 0x06000773 RID: 1907 RVA: 0x0002A894 File Offset: 0x00028A94
		public X509ExtensionEnumerator GetEnumerator()
		{
			return new X509ExtensionEnumerator(this._list);
		}

		/// <summary>Returns an enumerator that can iterate through an <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object to use to iterate through the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
		// Token: 0x06000774 RID: 1908 RVA: 0x0002A894 File Offset: 0x00028A94
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new X509ExtensionEnumerator(this._list);
		}

		// Token: 0x04000505 RID: 1285
		private static byte[] Empty = new byte[0];

		// Token: 0x04000506 RID: 1286
		private ArrayList _list;
	}
}
