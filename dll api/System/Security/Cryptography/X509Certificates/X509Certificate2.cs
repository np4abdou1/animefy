using System;
using System.Runtime.Serialization;
using System.Text;
using Internal.Cryptography;
using Microsoft.Win32.SafeHandles;
using Mono;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents an X.509 certificate.  </summary>
	// Token: 0x020000F0 RID: 240
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		/// <summary>Resets the state of an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</summary>
		// Token: 0x0600068D RID: 1677 RVA: 0x00026FCC File Offset: 0x000251CC
		public override void Reset()
		{
			this.lazyRawData = null;
			this.lazySignatureAlgorithm = null;
			this.lazyVersion = 0;
			this.lazySubjectName = null;
			this.lazyIssuerName = null;
			this.lazyPublicKey = null;
			this.lazyPrivateKey = null;
			this.lazyExtensions = null;
			base.Reset();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class.</summary>
		// Token: 0x0600068E RID: 1678 RVA: 0x00027027 File Offset: 0x00025227
		public X509Certificate2()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class using information from a byte array.</summary>
		/// <param name="rawData">A byte array containing data from an X.509 certificate. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception>
		// Token: 0x0600068F RID: 1679 RVA: 0x00027030 File Offset: 0x00025230
		public X509Certificate2(byte[] rawData) : base(rawData)
		{
			if (rawData != null && rawData.Length != 0)
			{
				using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(null))
				{
					X509CertificateImpl impl = X509Helper.Import(rawData, safePasswordHandle, X509KeyStorageFlags.DefaultKeySet);
					base.ImportHandle(impl);
				}
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00027080 File Offset: 0x00025280
		internal X509Certificate2(X509Certificate2Impl impl) : base(impl)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class using an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</summary>
		/// <param name="certificate">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception>
		// Token: 0x06000691 RID: 1681 RVA: 0x00027089 File Offset: 0x00025289
		public X509Certificate2(X509Certificate certificate) : base(certificate)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class using the specified serialization and stream context information. </summary>
		/// <param name="info">The serialization information required to deserialize the new <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <param name="context">Contextual information about the source of the stream to be deserialized.</param>
		// Token: 0x06000692 RID: 1682 RVA: 0x00027092 File Offset: 0x00025292
		protected X509Certificate2(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Gets a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable. </exception>
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x000270A4 File Offset: 0x000252A4
		public X509ExtensionCollection Extensions
		{
			get
			{
				base.ThrowIfInvalid();
				X509ExtensionCollection x509ExtensionCollection = this.lazyExtensions;
				if (x509ExtensionCollection == null)
				{
					x509ExtensionCollection = new X509ExtensionCollection();
					foreach (X509Extension x509Extension in this.Impl.Extensions)
					{
						X509Extension x509Extension2 = X509Certificate2.CreateCustomExtensionIfAny(x509Extension.Oid);
						if (x509Extension2 == null)
						{
							x509ExtensionCollection.Add(x509Extension);
						}
						else
						{
							x509Extension2.CopyFrom(x509Extension);
							x509ExtensionCollection.Add(x509Extension2);
						}
					}
					this.lazyExtensions = x509ExtensionCollection;
				}
				return x509ExtensionCollection;
			}
		}

		/// <summary>Gets the distinguished name of the certificate issuer.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" /> object that contains the name of the certificate issuer.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0002713C File Offset: 0x0002533C
		public X500DistinguishedName IssuerName
		{
			get
			{
				base.ThrowIfInvalid();
				X500DistinguishedName x500DistinguishedName = this.lazyIssuerName;
				if (x500DistinguishedName == null)
				{
					x500DistinguishedName = (this.lazyIssuerName = this.Impl.IssuerName);
				}
				return x500DistinguishedName;
			}
		}

		/// <summary>Gets the date in local time after which a certificate is no longer valid.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object that represents the expiration date for the certificate.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable. </exception>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00027173 File Offset: 0x00025373
		public DateTime NotAfter
		{
			get
			{
				return base.GetNotAfter();
			}
		}

		/// <summary>Gets the date in local time on which a certificate becomes valid.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object that represents the effective date of the certificate.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable. </exception>
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0002717B File Offset: 0x0002537B
		public DateTime NotBefore
		{
			get
			{
				return base.GetNotBefore();
			}
		}

		/// <summary>Gets a <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.PublicKey" /> object associated with a certificate.</summary>
		/// <returns>A <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.PublicKey" /> object.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key value is not an RSA or DSA key, or the key is unreadable. </exception>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00027184 File Offset: 0x00025384
		public PublicKey PublicKey
		{
			get
			{
				base.ThrowIfInvalid();
				PublicKey publicKey = this.lazyPublicKey;
				if (publicKey == null)
				{
					string keyAlgorithm = this.GetKeyAlgorithm();
					byte[] keyAlgorithmParameters = this.GetKeyAlgorithmParameters();
					byte[] publicKey2 = this.GetPublicKey();
					Oid oid = new Oid(keyAlgorithm);
					publicKey = (this.lazyPublicKey = new PublicKey(oid, new AsnEncodedData(oid, keyAlgorithmParameters), new AsnEncodedData(oid, publicKey2)));
				}
				return publicKey;
			}
		}

		/// <summary>Gets the raw data of a certificate.</summary>
		/// <returns>The raw data of the certificate as a byte array.</returns>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x000271E0 File Offset: 0x000253E0
		public byte[] RawData
		{
			get
			{
				base.ThrowIfInvalid();
				byte[] array = this.lazyRawData;
				if (array == null)
				{
					array = (this.lazyRawData = this.Impl.RawData);
				}
				return array.CloneByteArray();
			}
		}

		/// <summary>Gets the serial number of a certificate.</summary>
		/// <returns>The serial number of the certificate.</returns>
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0002721C File Offset: 0x0002541C
		public string SerialNumber
		{
			get
			{
				return this.GetSerialNumberString();
			}
		}

		/// <summary>Gets the algorithm used to create the signature of a certificate.</summary>
		/// <returns>Returns the object identifier (<see cref="T:System.Security.Cryptography.Oid" />) of the signature algorithm.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable. </exception>
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00027224 File Offset: 0x00025424
		public Oid SignatureAlgorithm
		{
			get
			{
				base.ThrowIfInvalid();
				Oid oid = this.lazySignatureAlgorithm;
				if (oid == null)
				{
					string signatureAlgorithm = this.Impl.SignatureAlgorithm;
					oid = (this.lazySignatureAlgorithm = Oid.FromOidValue(signatureAlgorithm, OidGroup.SignatureAlgorithm));
				}
				return oid;
			}
		}

		/// <summary>Gets the subject distinguished name from a certificate.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" /> object that represents the name of the certificate subject.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00027264 File Offset: 0x00025464
		public X500DistinguishedName SubjectName
		{
			get
			{
				base.ThrowIfInvalid();
				X500DistinguishedName x500DistinguishedName = this.lazySubjectName;
				if (x500DistinguishedName == null)
				{
					x500DistinguishedName = (this.lazySubjectName = this.Impl.SubjectName);
				}
				return x500DistinguishedName;
			}
		}

		/// <summary>Gets the thumbprint of a certificate.</summary>
		/// <returns>The thumbprint of the certificate.</returns>
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0002729B File Offset: 0x0002549B
		public string Thumbprint
		{
			get
			{
				return this.GetCertHash().ToHexStringUpper();
			}
		}

		/// <summary>Gets the X.509 format version of a certificate.</summary>
		/// <returns>The certificate format.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable. </exception>
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x000272A8 File Offset: 0x000254A8
		public int Version
		{
			get
			{
				base.ThrowIfInvalid();
				int num = this.lazyVersion;
				if (num == 0)
				{
					num = (this.lazyVersion = this.Impl.Version);
				}
				return num;
			}
		}

		/// <summary>Indicates the type of certificate contained in a byte array.</summary>
		/// <param name="rawData">A byte array containing data from an X.509 certificate. </param>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> object.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="rawData" /> has a zero length or is <see langword="null" />. </exception>
		// Token: 0x0600069E RID: 1694 RVA: 0x000272DF File Offset: 0x000254DF
		public static X509ContentType GetCertContentType(byte[] rawData)
		{
			if (rawData == null || rawData.Length == 0)
			{
				throw new ArgumentException("Array cannot be empty or null.", "rawData");
			}
			return X509Pal.Instance.GetCertContentType(rawData);
		}

		/// <summary>Gets the subject and issuer names from a certificate.</summary>
		/// <param name="nameType">The <see cref="T:System.Security.Cryptography.X509Certificates.X509NameType" /> value for the subject. </param>
		/// <param name="forIssuer">
		///       <see langword="true" /> to include the issuer name; otherwise, <see langword="false" />. </param>
		/// <returns>The name of the certificate.</returns>
		// Token: 0x0600069F RID: 1695 RVA: 0x00027303 File Offset: 0x00025503
		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			return this.Impl.GetNameInfo(nameType, forIssuer);
		}

		/// <summary>Displays an X.509 certificate in text format.</summary>
		/// <returns>The certificate information.</returns>
		// Token: 0x060006A0 RID: 1696 RVA: 0x00027312 File Offset: 0x00025512
		public override string ToString()
		{
			return base.ToString(true);
		}

		/// <summary>Displays an X.509 certificate in text format.</summary>
		/// <param name="verbose">
		///       <see langword="true" /> to display the public key, private key, extensions, and so forth; <see langword="false" /> to display information that is similar to the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class, including thumbprint, serial number, subject and issuer names, and so on. </param>
		/// <returns>The certificate information.</returns>
		// Token: 0x060006A1 RID: 1697 RVA: 0x0002731C File Offset: 0x0002551C
		public override string ToString(bool verbose)
		{
			if (!verbose || !base.IsValid)
			{
				return this.ToString();
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("[Version]");
			stringBuilder.Append("  V");
			stringBuilder.Append(this.Version);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Subject]");
			stringBuilder.Append("  ");
			stringBuilder.Append(this.SubjectName.Name);
			string nameInfo = this.GetNameInfo(X509NameType.SimpleName, false);
			if (nameInfo.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Simple Name: ");
				stringBuilder.Append(nameInfo);
			}
			string nameInfo2 = this.GetNameInfo(X509NameType.EmailName, false);
			if (nameInfo2.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Email Name: ");
				stringBuilder.Append(nameInfo2);
			}
			string nameInfo3 = this.GetNameInfo(X509NameType.UpnName, false);
			if (nameInfo3.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("UPN Name: ");
				stringBuilder.Append(nameInfo3);
			}
			string nameInfo4 = this.GetNameInfo(X509NameType.DnsName, false);
			if (nameInfo4.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("DNS Name: ");
				stringBuilder.Append(nameInfo4);
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Issuer]");
			stringBuilder.Append("  ");
			stringBuilder.Append(this.IssuerName.Name);
			nameInfo = this.GetNameInfo(X509NameType.SimpleName, true);
			if (nameInfo.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Simple Name: ");
				stringBuilder.Append(nameInfo);
			}
			nameInfo2 = this.GetNameInfo(X509NameType.EmailName, true);
			if (nameInfo2.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Email Name: ");
				stringBuilder.Append(nameInfo2);
			}
			nameInfo3 = this.GetNameInfo(X509NameType.UpnName, true);
			if (nameInfo3.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("UPN Name: ");
				stringBuilder.Append(nameInfo3);
			}
			nameInfo4 = this.GetNameInfo(X509NameType.DnsName, true);
			if (nameInfo4.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("DNS Name: ");
				stringBuilder.Append(nameInfo4);
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Serial Number]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(this.SerialNumber);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Not Before]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(X509Certificate.FormatDate(this.NotBefore));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Not After]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(X509Certificate.FormatDate(this.NotAfter));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Thumbprint]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(this.Thumbprint);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Signature Algorithm]");
			stringBuilder.Append("  ");
			stringBuilder.Append(this.SignatureAlgorithm.FriendlyName);
			stringBuilder.Append('(');
			stringBuilder.Append(this.SignatureAlgorithm.Value);
			stringBuilder.AppendLine(")");
			stringBuilder.AppendLine();
			stringBuilder.Append("[Public Key]");
			try
			{
				PublicKey publicKey = this.PublicKey;
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Algorithm: ");
				stringBuilder.Append(publicKey.Oid.FriendlyName);
				try
				{
					stringBuilder.AppendLine();
					stringBuilder.Append("  ");
					stringBuilder.Append("Length: ");
					using (RSA rsapublicKey = this.GetRSAPublicKey())
					{
						if (rsapublicKey != null)
						{
							stringBuilder.Append(rsapublicKey.KeySize);
						}
					}
				}
				catch (NotSupportedException)
				{
				}
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Key Blob: ");
				stringBuilder.AppendLine(publicKey.EncodedKeyValue.Format(true));
				stringBuilder.Append("  ");
				stringBuilder.Append("Parameters: ");
				stringBuilder.Append(publicKey.EncodedParameters.Format(true));
			}
			catch (CryptographicException)
			{
			}
			this.Impl.AppendPrivateKeyInfo(stringBuilder);
			X509ExtensionCollection extensions = this.Extensions;
			if (extensions.Count > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.AppendLine();
				stringBuilder.Append("[Extensions]");
				foreach (X509Extension x509Extension in extensions)
				{
					try
					{
						stringBuilder.AppendLine();
						stringBuilder.Append("* ");
						stringBuilder.Append(x509Extension.Oid.FriendlyName);
						stringBuilder.Append('(');
						stringBuilder.Append(x509Extension.Oid.Value);
						stringBuilder.Append("):");
						stringBuilder.AppendLine();
						stringBuilder.Append("  ");
						stringBuilder.Append(x509Extension.Format(true));
					}
					catch (CryptographicException)
					{
					}
				}
			}
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
		}

		/// <summary>Performs a X.509 chain validation using basic validation policy.</summary>
		/// <returns>
		///     <see langword="true" /> if the validation succeeds; <see langword="false" /> if the validation fails.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable. </exception>
		// Token: 0x060006A2 RID: 1698 RVA: 0x000278CC File Offset: 0x00025ACC
		public bool Verify()
		{
			return this.Impl.Verify(this);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000278DC File Offset: 0x00025ADC
		private static X509Extension CreateCustomExtensionIfAny(Oid oid)
		{
			string value = oid.Value;
			if (!(value == "2.5.29.10"))
			{
				if (value == "2.5.29.19")
				{
					return new X509BasicConstraintsExtension();
				}
				if (value == "2.5.29.15")
				{
					return new X509KeyUsageExtension();
				}
				if (value == "2.5.29.37")
				{
					return new X509EnhancedKeyUsageExtension();
				}
				if (!(value == "2.5.29.14"))
				{
					return null;
				}
				return new X509SubjectKeyIdentifierExtension();
			}
			else
			{
				if (!X509Pal.Instance.SupportsLegacyBasicConstraintsExtension)
				{
					return null;
				}
				return new X509BasicConstraintsExtension();
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00027960 File Offset: 0x00025B60
		internal new X509Certificate2Impl Impl
		{
			get
			{
				X509Certificate2Impl x509Certificate2Impl = base.Impl as X509Certificate2Impl;
				X509Helper.ThrowIfContextInvalid(x509Certificate2Impl);
				return x509Certificate2Impl;
			}
		}

		// Token: 0x040004CE RID: 1230
		private volatile byte[] lazyRawData;

		// Token: 0x040004CF RID: 1231
		private volatile Oid lazySignatureAlgorithm;

		// Token: 0x040004D0 RID: 1232
		private volatile int lazyVersion;

		// Token: 0x040004D1 RID: 1233
		private volatile X500DistinguishedName lazySubjectName;

		// Token: 0x040004D2 RID: 1234
		private volatile X500DistinguishedName lazyIssuerName;

		// Token: 0x040004D3 RID: 1235
		private volatile PublicKey lazyPublicKey;

		// Token: 0x040004D4 RID: 1236
		private volatile AsymmetricAlgorithm lazyPrivateKey;

		// Token: 0x040004D5 RID: 1237
		private volatile X509ExtensionCollection lazyExtensions;
	}
}
