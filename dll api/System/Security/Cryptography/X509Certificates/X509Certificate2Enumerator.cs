using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Supports a simple iteration over a <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object. This class cannot be inherited.</summary>
	// Token: 0x020000F2 RID: 242
	public sealed class X509Certificate2Enumerator : IEnumerator
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00027F85 File Offset: 0x00026185
		internal X509Certificate2Enumerator(X509Certificate2Collection collection)
		{
			this.enumerator = ((IEnumerable)collection).GetEnumerator();
		}

		/// <summary>Gets the current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00027F99 File Offset: 0x00026199
		public X509Certificate2 Current
		{
			get
			{
				return (X509Certificate2)this.enumerator.Current;
			}
		}

		/// <summary>Advances the enumerator to the next element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
		/// <returns>
		///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x060006B1 RID: 1713 RVA: 0x00027FAB File Offset: 0x000261AB
		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IEnumerator.Current" />.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00027FB8 File Offset: 0x000261B8
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
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x060006B3 RID: 1715 RVA: 0x00027FAB File Offset: 0x000261AB
		bool IEnumerator.MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerator.Reset" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x060006B4 RID: 1716 RVA: 0x00027FC5 File Offset: 0x000261C5
		void IEnumerator.Reset()
		{
			this.enumerator.Reset();
		}

		// Token: 0x040004D7 RID: 1239
		private IEnumerator enumerator;
	}
}
