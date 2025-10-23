using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Provides extension methods for retrieving <see cref="T:System.Security.Cryptography.RSA" /> implementations for the public and private keys of an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />. </summary>
	// Token: 0x02000015 RID: 21
	public static class RSACertificateExtensions
	{
		/// <summary>Gets the <see cref="T:System.Security.Cryptography.RSA" /> public key from the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		/// <param name="certificate">The certificate. </param>
		/// <returns>The public key, or <see langword="null" /> if the certificate does not have an RSA public key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="certificate" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Windows reports an error. See the <see cref="P:System.Exception.Message" /> property for more information. </exception>
		// Token: 0x0600005E RID: 94 RVA: 0x00003ED0 File Offset: 0x000020D0
		public static RSA GetRSAPublicKey(this X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return certificate.PublicKey.Key as RSA;
		}
	}
}
