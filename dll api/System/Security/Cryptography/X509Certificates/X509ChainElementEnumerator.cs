using System;
using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Supports a simple iteration over an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />. This class cannot be inherited.</summary>
	// Token: 0x020000FC RID: 252
	public sealed class X509ChainElementEnumerator : IEnumerator
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x00028EC8 File Offset: 0x000270C8
		internal X509ChainElementEnumerator(IEnumerable enumerable)
		{
			this.enumerator = enumerable.GetEnumerator();
		}

		/// <summary>Gets the current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00028EDC File Offset: 0x000270DC
		public X509ChainElement Current
		{
			get
			{
				return (X509ChainElement)this.enumerator.Current;
			}
		}

		/// <summary>Gets the current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00028EEE File Offset: 0x000270EE
		object IEnumerator.Current
		{
			get
			{
				return this.enumerator.Current;
			}
		}

		/// <summary>Advances the enumerator to the next element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06000720 RID: 1824 RVA: 0x00028EFB File Offset: 0x000270FB
		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>Sets the enumerator to its initial position, which is before the first element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06000721 RID: 1825 RVA: 0x00028F08 File Offset: 0x00027108
		public void Reset()
		{
			this.enumerator.Reset();
		}

		// Token: 0x040004E6 RID: 1254
		private IEnumerator enumerator;
	}
}
