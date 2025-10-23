using System;
using System.Text;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Defines a string that identifies a certificate's subject key identifier (SKI). This class cannot be inherited.</summary>
	// Token: 0x02000108 RID: 264
	public sealed class X509SubjectKeyIdentifierExtension : X509Extension
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class.</summary>
		// Token: 0x0600078E RID: 1934 RVA: 0x0002AF7C File Offset: 0x0002917C
		public X509SubjectKeyIdentifierExtension()
		{
			this._oid = new Oid("2.5.29.14", "Subject Key Identifier");
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class using encoded data and a value that identifies whether the extension is critical.</summary>
		/// <param name="encodedSubjectKeyIdentifier">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object to use to create the extension.</param>
		/// <param name="critical">
		///       <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
		// Token: 0x0600078F RID: 1935 RVA: 0x0002AF9C File Offset: 0x0002919C
		public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
		{
			this._oid = new Oid("2.5.29.14", "Subject Key Identifier");
			this._raw = encodedSubjectKeyIdentifier.RawData;
			base.Critical = critical;
			this._status = this.Decode(base.RawData);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class using a public key, a hash algorithm identifier, and a value indicating whether the extension is critical. </summary>
		/// <param name="key">A <see cref="T:System.Security.Cryptography.X509Certificates.PublicKey" /> object to create a subject key identifier (SKI) from.</param>
		/// <param name="algorithm">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm" /> values that identifies which hash algorithm to use.</param>
		/// <param name="critical">
		///       <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
		// Token: 0x06000790 RID: 1936 RVA: 0x0002AFEC File Offset: 0x000291EC
		public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			byte[] rawData = key.EncodedKeyValue.RawData;
			switch (algorithm)
			{
			case X509SubjectKeyIdentifierHashAlgorithm.Sha1:
				this._subjectKeyIdentifier = SHA1.Create().ComputeHash(rawData);
				break;
			case X509SubjectKeyIdentifierHashAlgorithm.ShortSha1:
			{
				Array src = SHA1.Create().ComputeHash(rawData);
				this._subjectKeyIdentifier = new byte[8];
				Buffer.BlockCopy(src, 12, this._subjectKeyIdentifier, 0, 8);
				this._subjectKeyIdentifier[0] = (64 | (this._subjectKeyIdentifier[0] & 15));
				break;
			}
			case X509SubjectKeyIdentifierHashAlgorithm.CapiSha1:
			{
				ASN1 asn = new ASN1(48);
				ASN1 asn2 = asn.Add(new ASN1(48));
				asn2.Add(new ASN1(CryptoConfig.EncodeOID(key.Oid.Value)));
				asn2.Add(new ASN1(key.EncodedParameters.RawData));
				byte[] array = new byte[rawData.Length + 1];
				Buffer.BlockCopy(rawData, 0, array, 1, rawData.Length);
				asn.Add(new ASN1(3, array));
				this._subjectKeyIdentifier = SHA1.Create().ComputeHash(asn.GetBytes());
				break;
			}
			default:
				throw new ArgumentException("algorithm");
			}
			this._oid = new Oid("2.5.29.14", "Subject Key Identifier");
			base.Critical = critical;
			base.RawData = this.Encode();
		}

		/// <summary>Gets a string that represents the subject key identifier (SKI) for a certificate.</summary>
		/// <returns>A string, encoded in hexadecimal format, that represents the subject key identifier (SKI).</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The extension cannot be decoded. </exception>
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0002B140 File Offset: 0x00029340
		public string SubjectKeyIdentifier
		{
			get
			{
				AsnDecodeStatus status = this._status;
				if (status == AsnDecodeStatus.Ok || status == AsnDecodeStatus.InformationNotAvailable)
				{
					if (this._subjectKeyIdentifier != null)
					{
						this._ski = CryptoConvert.ToHex(this._subjectKeyIdentifier);
					}
					return this._ski;
				}
				throw new CryptographicException("Badly encoded extension.");
			}
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class by copying information from encoded data.</summary>
		/// <param name="asnEncodedData">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object to use to create the extension.</param>
		// Token: 0x06000792 RID: 1938 RVA: 0x0002B188 File Offset: 0x00029388
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			X509Extension x509Extension = asnEncodedData as X509Extension;
			if (x509Extension == null)
			{
				throw new ArgumentException(Locale.GetText("Wrong type."), "asnEncodedData");
			}
			if (x509Extension._oid == null)
			{
				this._oid = new Oid("2.5.29.14", "Subject Key Identifier");
			}
			else
			{
				this._oid = new Oid(x509Extension._oid);
			}
			base.RawData = x509Extension.RawData;
			base.Critical = x509Extension.Critical;
			this._status = this.Decode(base.RawData);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0002B21C File Offset: 0x0002941C
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			if (extension == null || extension.Length == 0)
			{
				return AsnDecodeStatus.BadAsn;
			}
			this._ski = string.Empty;
			if (extension[0] != 4)
			{
				return AsnDecodeStatus.BadTag;
			}
			if (extension.Length == 2)
			{
				return AsnDecodeStatus.InformationNotAvailable;
			}
			if (extension.Length < 3)
			{
				return AsnDecodeStatus.BadLength;
			}
			try
			{
				ASN1 asn = new ASN1(extension);
				this._subjectKeyIdentifier = asn.Value;
			}
			catch
			{
				return AsnDecodeStatus.BadAsn;
			}
			return AsnDecodeStatus.Ok;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0002B284 File Offset: 0x00029484
		internal byte[] Encode()
		{
			return new ASN1(4, this._subjectKeyIdentifier).GetBytes();
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0002B298 File Offset: 0x00029498
		internal override string ToString(bool multiLine)
		{
			switch (this._status)
			{
			case AsnDecodeStatus.BadAsn:
				return string.Empty;
			case AsnDecodeStatus.BadTag:
			case AsnDecodeStatus.BadLength:
				return base.FormatUnkownData(this._raw);
			case AsnDecodeStatus.InformationNotAvailable:
				return "Information Not Available";
			default:
			{
				if (this._oid.Value != "2.5.29.14")
				{
					return string.Format("Unknown Key Usage ({0})", this._oid.Value);
				}
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < this._subjectKeyIdentifier.Length; i++)
				{
					stringBuilder.Append(this._subjectKeyIdentifier[i].ToString("x2"));
					if (i != this._subjectKeyIdentifier.Length - 1)
					{
						stringBuilder.Append(" ");
					}
				}
				if (multiLine)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x0400050F RID: 1295
		private byte[] _subjectKeyIdentifier;

		// Token: 0x04000510 RID: 1296
		private string _ski;

		// Token: 0x04000511 RID: 1297
		private AsnDecodeStatus _status;
	}
}
