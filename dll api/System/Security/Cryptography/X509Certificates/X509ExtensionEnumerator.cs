using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Supports a simple iteration over a <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />. This class cannot be inherited.</summary>
	// Token: 0x02000104 RID: 260
	public sealed class X509ExtensionEnumerator : IEnumerator
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x0002A8AE File Offset: 0x00028AAE
		internal X509ExtensionEnumerator(ArrayList list)
		{
			this.enumerator = list.GetEnumerator();
		}

		/// <summary>Gets the current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0002A8C2 File Offset: 0x00028AC2
		public X509Extension Current
		{
			get
			{
				return (X509Extension)this.enumerator.Current;
			}
		}

		/// <summary>Gets an object from a collection.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002A8D4 File Offset: 0x00028AD4
		object IEnumerator.Current
		{
			get
			{
				return this.enumerator.Current;
			}
		}

		/// <summary>Advances the enumerator to the next element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06000779 RID: 1913 RVA: 0x0002A8E1 File Offset: 0x00028AE1
		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>Sets the enumerator to its initial position, which is before the first element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x0600077A RID: 1914 RVA: 0x0002A8EE File Offset: 0x00028AEE
		public void Reset()
		{
			this.enumerator.Reset();
		}

		// Token: 0x04000507 RID: 1287
		private IEnumerator enumerator;
	}
}
