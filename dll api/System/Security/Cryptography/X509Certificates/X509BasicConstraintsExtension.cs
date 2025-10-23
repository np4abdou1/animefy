using System;
using System.Text;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Defines the constraints set on a certificate. This class cannot be inherited.</summary>
	// Token: 0x020000EF RID: 239
	public sealed class X509BasicConstraintsExtension : X509Extension
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension" /> class.</summary>
		// Token: 0x06000685 RID: 1669 RVA: 0x00026C88 File Offset: 0x00024E88
		public X509BasicConstraintsExtension()
		{
			this._oid = new Oid("2.5.29.19", "Basic Constraints");
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension" /> class using an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object and a value that identifies whether the extension is critical. </summary>
		/// <param name="encodedBasicConstraints">The encoded data to use to create the extension.</param>
		/// <param name="critical">
		///       <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
		// Token: 0x06000686 RID: 1670 RVA: 0x00026CA8 File Offset: 0x00024EA8
		public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
		{
			this._oid = new Oid("2.5.29.19", "Basic Constraints");
			this._raw = encodedBasicConstraints.RawData;
			base.Critical = critical;
			this._status = this.Decode(base.RawData);
		}

		/// <summary>Gets a value indicating whether a certificate is a certificate authority (CA) certificate.</summary>
		/// <returns>
		///     <see langword="true" /> if the certificate is a certificate authority (CA) certificate, otherwise, <see langword="false" />.</returns>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00026CF8 File Offset: 0x00024EF8
		public bool CertificateAuthority
		{
			get
			{
				AsnDecodeStatus status = this._status;
				if (status == AsnDecodeStatus.Ok || status == AsnDecodeStatus.InformationNotAvailable)
				{
					return this._certificateAuthority;
				}
				throw new CryptographicException("Badly encoded extension.");
			}
		}

		/// <summary>Gets a value indicating whether a certificate has a restriction on the number of path levels it allows.</summary>
		/// <returns>
		///     <see langword="true" /> if the certificate has a restriction on the number of path levels it allows, otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The extension cannot be decoded. </exception>
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00026D24 File Offset: 0x00024F24
		public bool HasPathLengthConstraint
		{
			get
			{
				AsnDecodeStatus status = this._status;
				if (status == AsnDecodeStatus.Ok || status == AsnDecodeStatus.InformationNotAvailable)
				{
					return this._hasPathLengthConstraint;
				}
				throw new CryptographicException("Badly encoded extension.");
			}
		}

		/// <summary>Gets the number of levels allowed in a certificate's path.</summary>
		/// <returns>An integer indicating the number of levels allowed in a certificate's path.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The extension cannot be decoded. </exception>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00026D50 File Offset: 0x00024F50
		public int PathLengthConstraint
		{
			get
			{
				AsnDecodeStatus status = this._status;
				if (status == AsnDecodeStatus.Ok || status == AsnDecodeStatus.InformationNotAvailable)
				{
					return this._pathLengthConstraint;
				}
				throw new CryptographicException("Badly encoded extension.");
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension" /> class using an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
		/// <param name="asnEncodedData">The encoded data to use to create the extension.</param>
		// Token: 0x0600068A RID: 1674 RVA: 0x00026D7C File Offset: 0x00024F7C
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
				this._oid = new Oid("2.5.29.19", "Basic Constraints");
			}
			else
			{
				this._oid = new Oid(x509Extension._oid);
			}
			base.RawData = x509Extension.RawData;
			base.Critical = x509Extension.Critical;
			this._status = this.Decode(base.RawData);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00026E10 File Offset: 0x00025010
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			if (extension == null || extension.Length == 0)
			{
				return AsnDecodeStatus.BadAsn;
			}
			if (extension[0] != 48)
			{
				return AsnDecodeStatus.BadTag;
			}
			if (extension.Length < 3 && (extension.Length != 2 || extension[1] != 0))
			{
				return AsnDecodeStatus.BadLength;
			}
			try
			{
				ASN1 asn = new ASN1(extension);
				int num = 0;
				ASN1 asn2 = asn[num++];
				if (asn2 != null && asn2.Tag == 1)
				{
					this._certificateAuthority = (asn2.Value[0] == byte.MaxValue);
					asn2 = asn[num++];
				}
				if (asn2 != null && asn2.Tag == 2)
				{
					this._hasPathLengthConstraint = true;
					this._pathLengthConstraint = ASN1Convert.ToInt32(asn2);
				}
			}
			catch
			{
				return AsnDecodeStatus.BadAsn;
			}
			return AsnDecodeStatus.Ok;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00026EC0 File Offset: 0x000250C0
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
				if (this._oid.Value != "2.5.29.19")
				{
					return string.Format("Unknown Key Usage ({0})", this._oid.Value);
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("Subject Type=");
				if (this._certificateAuthority)
				{
					stringBuilder.Append("CA");
				}
				else
				{
					stringBuilder.Append("End Entity");
				}
				if (multiLine)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Path Length Constraint=");
				if (this._hasPathLengthConstraint)
				{
					stringBuilder.Append(this._pathLengthConstraint);
				}
				else
				{
					stringBuilder.Append("None");
				}
				if (multiLine)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x040004CA RID: 1226
		private bool _certificateAuthority;

		// Token: 0x040004CB RID: 1227
		private bool _hasPathLengthConstraint;

		// Token: 0x040004CC RID: 1228
		private int _pathLengthConstraint;

		// Token: 0x040004CD RID: 1229
		private AsnDecodeStatus _status;
	}
}
