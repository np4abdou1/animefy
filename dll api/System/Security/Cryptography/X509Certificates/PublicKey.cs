using System;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents a certificate's public key information. This class cannot be inherited.</summary>
	// Token: 0x020000ED RID: 237
	public sealed class PublicKey
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.PublicKey" /> class using an object identifier (OID) object of the public key, an ASN.1-encoded representation of the public key parameters, and an ASN.1-encoded representation of the public key value. </summary>
		/// <param name="oid">An object identifier (OID) object that represents the public key.</param>
		/// <param name="parameters">An ASN.1-encoded representation of the public key parameters.</param>
		/// <param name="keyValue">An ASN.1-encoded representation of the public key value.</param>
		// Token: 0x06000672 RID: 1650 RVA: 0x000265B8 File Offset: 0x000247B8
		public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			if (keyValue == null)
			{
				throw new ArgumentNullException("keyValue");
			}
			this._oid = new Oid(oid);
			this._params = new AsnEncodedData(parameters);
			this._keyValue = new AsnEncodedData(keyValue);
		}

		/// <summary>Gets the ASN.1-encoded representation of the public key value.</summary>
		/// <returns>The ASN.1-encoded representation of the public key value.</returns>
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00026619 File Offset: 0x00024819
		public AsnEncodedData EncodedKeyValue
		{
			get
			{
				return this._keyValue;
			}
		}

		/// <summary>Gets the ASN.1-encoded representation of the public key parameters.</summary>
		/// <returns>The ASN.1-encoded representation of the public key parameters.</returns>
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00026621 File Offset: 0x00024821
		public AsnEncodedData EncodedParameters
		{
			get
			{
				return this._params;
			}
		}

		/// <summary>Gets an <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> or <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object representing the public key.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object representing the public key.</returns>
		/// <exception cref="T:System.NotSupportedException">The key algorithm is not supported.</exception>
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0002662C File Offset: 0x0002482C
		public AsymmetricAlgorithm Key
		{
			get
			{
				string value = this._oid.Value;
				if (value == "1.2.840.113549.1.1.1")
				{
					return PublicKey.DecodeRSA(this._keyValue.RawData);
				}
				if (!(value == "1.2.840.10040.4.1"))
				{
					throw new NotSupportedException(Locale.GetText("Cannot decode public key from unknown OID '{0}'.", new object[]
					{
						this._oid.Value
					}));
				}
				return PublicKey.DecodeDSA(this._keyValue.RawData, this._params.RawData);
			}
		}

		/// <summary>Gets an object identifier (OID) object of the public key.</summary>
		/// <returns>An object identifier (OID) object of the public key.</returns>
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x000266B1 File Offset: 0x000248B1
		public Oid Oid
		{
			get
			{
				return this._oid;
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000266BC File Offset: 0x000248BC
		private static byte[] GetUnsignedBigInteger(byte[] integer)
		{
			if (integer[0] != 0)
			{
				return integer;
			}
			int num = integer.Length - 1;
			byte[] array = new byte[num];
			Buffer.BlockCopy(integer, 1, array, 0, num);
			return array;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000266E8 File Offset: 0x000248E8
		internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters)
		{
			DSAParameters dsaparameters = default(DSAParameters);
			try
			{
				ASN1 asn = new ASN1(rawPublicKey);
				if (asn.Tag != 2)
				{
					throw new CryptographicException(Locale.GetText("Missing DSA Y integer."));
				}
				dsaparameters.Y = PublicKey.GetUnsignedBigInteger(asn.Value);
				ASN1 asn2 = new ASN1(rawParameters);
				if (asn2 == null || asn2.Tag != 48 || asn2.Count < 3)
				{
					throw new CryptographicException(Locale.GetText("Missing DSA parameters."));
				}
				if (asn2[0].Tag != 2 || asn2[1].Tag != 2 || asn2[2].Tag != 2)
				{
					throw new CryptographicException(Locale.GetText("Invalid DSA parameters."));
				}
				dsaparameters.P = PublicKey.GetUnsignedBigInteger(asn2[0].Value);
				dsaparameters.Q = PublicKey.GetUnsignedBigInteger(asn2[1].Value);
				dsaparameters.G = PublicKey.GetUnsignedBigInteger(asn2[2].Value);
			}
			catch (Exception inner)
			{
				throw new CryptographicException(Locale.GetText("Error decoding the ASN.1 structure."), inner);
			}
			DSACryptoServiceProvider dsacryptoServiceProvider = new DSACryptoServiceProvider(dsaparameters.Y.Length << 3);
			dsacryptoServiceProvider.ImportParameters(dsaparameters);
			return dsacryptoServiceProvider;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0002681C File Offset: 0x00024A1C
		internal static RSA DecodeRSA(byte[] rawPublicKey)
		{
			RSAParameters rsaparameters = default(RSAParameters);
			try
			{
				ASN1 asn = new ASN1(rawPublicKey);
				if (asn.Count == 0)
				{
					throw new CryptographicException(Locale.GetText("Missing RSA modulus and exponent."));
				}
				ASN1 asn2 = asn[0];
				if (asn2 == null || asn2.Tag != 2)
				{
					throw new CryptographicException(Locale.GetText("Missing RSA modulus."));
				}
				ASN1 asn3 = asn[1];
				if (asn3.Tag != 2)
				{
					throw new CryptographicException(Locale.GetText("Missing RSA public exponent."));
				}
				rsaparameters.Modulus = PublicKey.GetUnsignedBigInteger(asn2.Value);
				rsaparameters.Exponent = asn3.Value;
			}
			catch (Exception inner)
			{
				throw new CryptographicException(Locale.GetText("Error decoding the ASN.1 structure."), inner);
			}
			RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider(rsaparameters.Modulus.Length << 3);
			rsacryptoServiceProvider.ImportParameters(rsaparameters);
			return rsacryptoServiceProvider;
		}

		// Token: 0x040004C4 RID: 1220
		private AsnEncodedData _keyValue;

		// Token: 0x040004C5 RID: 1221
		private AsnEncodedData _params;

		// Token: 0x040004C6 RID: 1222
		private Oid _oid;

		// Token: 0x040004C7 RID: 1223
		private static byte[] Empty = new byte[0];
	}
}
