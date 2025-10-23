using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Defines a collection that stores <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> objects.</summary>
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> class.</summary>
		// Token: 0x060006E8 RID: 1768 RVA: 0x000287CC File Offset: 0x000269CC
		public X509CertificateCollection()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> class from another <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> with which to initialize the new object. </param>
		// Token: 0x060006E9 RID: 1769 RVA: 0x000287D4 File Offset: 0x000269D4
		public X509CertificateCollection(X509CertificateCollection value)
		{
			this.AddRange(value);
		}

		/// <summary>Gets or sets the entry at the specified index of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="index">The zero-based index of the entry to locate in the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> at the specified index of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is outside the valid range of indexes for the collection. </exception>
		// Token: 0x1700011F RID: 287
		public X509Certificate this[int index]
		{
			get
			{
				return (X509Certificate)base.InnerList[index];
			}
		}

		/// <summary>Adds an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> with the specified value to the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> to add to the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />. </param>
		/// <returns>The index into the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> at which the new <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> was inserted.</returns>
		// Token: 0x060006EB RID: 1771 RVA: 0x000287F6 File Offset: 0x000269F6
		public int Add(X509Certificate value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return base.InnerList.Add(value);
		}

		/// <summary>Copies the elements of the specified <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> to the end of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <param name="value">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> containing the objects to add to the collection. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />. </exception>
		// Token: 0x060006EC RID: 1772 RVA: 0x00028814 File Offset: 0x00026A14
		public void AddRange(X509CertificateCollection value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			for (int i = 0; i < value.InnerList.Count; i++)
			{
				base.InnerList.Add(value[i]);
			}
		}

		/// <summary>Returns an enumerator that can iterate through the <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <returns>An enumerator of the subelements of <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> you can use to iterate through the collection.</returns>
		// Token: 0x060006ED RID: 1773 RVA: 0x00028858 File Offset: 0x00026A58
		public new X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			return new X509CertificateCollection.X509CertificateEnumerator(this);
		}

		/// <summary>Builds a hash value based on all values contained in the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		/// <returns>A hash value based on all values contained in the current <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</returns>
		// Token: 0x060006EE RID: 1774 RVA: 0x00028860 File Offset: 0x00026A60
		public override int GetHashCode()
		{
			return base.InnerList.GetHashCode();
		}

		/// <summary>Enumerates the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> objects in an <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
		// Token: 0x020000F7 RID: 247
		public class X509CertificateEnumerator : IEnumerator
		{
			/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator" /> class for the specified <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
			/// <param name="mappings">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> to enumerate. </param>
			// Token: 0x060006EF RID: 1775 RVA: 0x0002886D File Offset: 0x00026A6D
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
				this.enumerator = ((IEnumerable)mappings).GetEnumerator();
			}

			/// <summary>Gets the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> in the <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</summary>
			/// <returns>The current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> in the <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00028881 File Offset: 0x00026A81
			public X509Certificate Current
			{
				get
				{
					return (X509Certificate)this.enumerator.Current;
				}
			}

			/// <summary>For a description of this member, see <see cref="P:System.Collections.IEnumerator.Current" />.</summary>
			/// <returns>The current X.509 certificate object in the <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> object.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00028893 File Offset: 0x00026A93
			object IEnumerator.Current
			{
				get
				{
					return this.enumerator.Current;
				}
			}

			/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerator.MoveNext" />.</summary>
			/// <returns>
			///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was instantiated. </exception>
			// Token: 0x060006F2 RID: 1778 RVA: 0x000288A0 File Offset: 0x00026AA0
			bool IEnumerator.MoveNext()
			{
				return this.enumerator.MoveNext();
			}

			/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerator.Reset" />.</summary>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was instantiated. </exception>
			// Token: 0x060006F3 RID: 1779 RVA: 0x000288AD File Offset: 0x00026AAD
			void IEnumerator.Reset()
			{
				this.enumerator.Reset();
			}

			/// <summary>Advances the enumerator to the next element of the collection.</summary>
			/// <returns>
			///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was instantiated. </exception>
			// Token: 0x060006F4 RID: 1780 RVA: 0x000288A0 File Offset: 0x00026AA0
			public bool MoveNext()
			{
				return this.enumerator.MoveNext();
			}

			// Token: 0x040004DE RID: 1246
			private IEnumerator enumerator;
		}
	}
}
