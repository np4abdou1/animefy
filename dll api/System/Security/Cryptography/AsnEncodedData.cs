﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Represents Abstract Syntax Notation One (ASN.1)-encoded data.</summary>
	// Token: 0x020000E0 RID: 224
	public class AsnEncodedData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</summary>
		// Token: 0x06000660 RID: 1632 RVA: 0x0000222D File Offset: 0x0000042D
		protected AsnEncodedData()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using a byte array.</summary>
		/// <param name="oid">A string that represents <see cref="T:System.Security.Cryptography.Oid" /> information.</param>
		/// <param name="rawData">A byte array that contains Abstract Syntax Notation One (ASN.1)-encoded data.</param>
		// Token: 0x06000661 RID: 1633 RVA: 0x00025FE1 File Offset: 0x000241E1
		public AsnEncodedData(string oid, byte[] rawData)
		{
			this._oid = new Oid(oid);
			this.RawData = rawData;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using an <see cref="T:System.Security.Cryptography.Oid" /> object and a byte array.</summary>
		/// <param name="oid">An <see cref="T:System.Security.Cryptography.Oid" /> object.</param>
		/// <param name="rawData">A byte array that contains Abstract Syntax Notation One (ASN.1)-encoded data.</param>
		// Token: 0x06000662 RID: 1634 RVA: 0x00025FFC File Offset: 0x000241FC
		public AsnEncodedData(Oid oid, byte[] rawData)
		{
			this.Oid = oid;
			this.RawData = rawData;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using an instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</summary>
		/// <param name="asnEncodedData">An instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asnEncodedData" /> is <see langword="null" />.</exception>
		// Token: 0x06000663 RID: 1635 RVA: 0x00026012 File Offset: 0x00024212
		public AsnEncodedData(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			if (asnEncodedData._oid != null)
			{
				this.Oid = new Oid(asnEncodedData._oid);
			}
			this.RawData = asnEncodedData._raw;
		}

		/// <summary>Gets or sets the <see cref="T:System.Security.Cryptography.Oid" /> value for an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0002604D File Offset: 0x0002424D
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00026055 File Offset: 0x00024255
		public Oid Oid
		{
			get
			{
				return this._oid;
			}
			set
			{
				if (value == null)
				{
					this._oid = null;
					return;
				}
				this._oid = new Oid(value);
			}
		}

		/// <summary>Gets or sets the Abstract Syntax Notation One (ASN.1)-encoded data represented in a byte array.</summary>
		/// <returns>A byte array that represents the Abstract Syntax Notation One (ASN.1)-encoded data.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value is <see langword="null" />.</exception>
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0002606E File Offset: 0x0002426E
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00026076 File Offset: 0x00024276
		public byte[] RawData
		{
			get
			{
				return this._raw;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("RawData");
				}
				this._raw = (byte[])value.Clone();
			}
		}

		/// <summary>Copies information from an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
		/// <param name="asnEncodedData">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object to base the new object on.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asnEncodedData " />is <see langword="null" />.</exception>
		// Token: 0x06000668 RID: 1640 RVA: 0x00026097 File Offset: 0x00024297
		public virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			if (asnEncodedData._oid == null)
			{
				this.Oid = null;
			}
			else
			{
				this.Oid = new Oid(asnEncodedData._oid);
			}
			this.RawData = asnEncodedData._raw;
		}

		/// <summary>Returns a formatted version of the Abstract Syntax Notation One (ASN.1)-encoded data as a string.</summary>
		/// <param name="multiLine">
		///       <see langword="true" /> if the return string should contain carriage returns; otherwise, <see langword="false" />.</param>
		/// <returns>A formatted string that represents the Abstract Syntax Notation One (ASN.1)-encoded data.</returns>
		// Token: 0x06000669 RID: 1641 RVA: 0x000260D5 File Offset: 0x000242D5
		public virtual string Format(bool multiLine)
		{
			if (this._raw == null)
			{
				return string.Empty;
			}
			if (this._oid == null)
			{
				return this.Default(multiLine);
			}
			return this.ToString(multiLine);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000260FC File Offset: 0x000242FC
		internal virtual string ToString(bool multiLine)
		{
			string value = this._oid.Value;
			if (value == "2.5.29.19")
			{
				return this.BasicConstraintsExtension(multiLine);
			}
			if (value == "2.5.29.37")
			{
				return this.EnhancedKeyUsageExtension(multiLine);
			}
			if (value == "2.5.29.15")
			{
				return this.KeyUsageExtension(multiLine);
			}
			if (value == "2.5.29.14")
			{
				return this.SubjectKeyIdentifierExtension(multiLine);
			}
			if (value == "2.5.29.17")
			{
				return this.SubjectAltName(multiLine);
			}
			if (!(value == "2.16.840.1.113730.1.1"))
			{
				return this.Default(multiLine);
			}
			return this.NetscapeCertType(multiLine);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002619C File Offset: 0x0002439C
		internal string Default(bool multiLine)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this._raw.Length; i++)
			{
				stringBuilder.Append(this._raw[i].ToString("x2"));
				if (i != this._raw.Length - 1)
				{
					stringBuilder.Append(" ");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00026200 File Offset: 0x00024400
		internal string BasicConstraintsExtension(bool multiLine)
		{
			string result;
			try
			{
				result = new X509BasicConstraintsExtension(this, false).ToString(multiLine);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00026238 File Offset: 0x00024438
		internal string EnhancedKeyUsageExtension(bool multiLine)
		{
			string result;
			try
			{
				result = new X509EnhancedKeyUsageExtension(this, false).ToString(multiLine);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00026270 File Offset: 0x00024470
		internal string KeyUsageExtension(bool multiLine)
		{
			string result;
			try
			{
				result = new X509KeyUsageExtension(this, false).ToString(multiLine);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000262A8 File Offset: 0x000244A8
		internal string SubjectKeyIdentifierExtension(bool multiLine)
		{
			string result;
			try
			{
				result = new X509SubjectKeyIdentifierExtension(this, false).ToString(multiLine);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000262E0 File Offset: 0x000244E0
		internal string SubjectAltName(bool multiLine)
		{
			if (this._raw.Length < 5)
			{
				return "Information Not Available";
			}
			string result;
			try
			{
				ASN1 asn = new ASN1(this._raw);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < asn.Count; i++)
				{
					ASN1 asn2 = asn[i];
					byte tag = asn2.Tag;
					string value;
					string value2;
					if (tag != 129)
					{
						if (tag != 130)
						{
							value = string.Format("Unknown ({0})=", asn2.Tag);
							value2 = CryptoConvert.ToHex(asn2.Value);
						}
						else
						{
							value = "DNS Name=";
							value2 = Encoding.ASCII.GetString(asn2.Value);
						}
					}
					else
					{
						value = "RFC822 Name=";
						value2 = Encoding.ASCII.GetString(asn2.Value);
					}
					stringBuilder.Append(value);
					stringBuilder.Append(value2);
					if (multiLine)
					{
						stringBuilder.Append(Environment.NewLine);
					}
					else if (i < asn.Count - 1)
					{
						stringBuilder.Append(", ");
					}
				}
				result = stringBuilder.ToString();
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0002640C File Offset: 0x0002460C
		internal string NetscapeCertType(bool multiLine)
		{
			if (this._raw.Length < 4 || this._raw[0] != 3 || this._raw[1] != 2)
			{
				return "Information Not Available";
			}
			int num = this._raw[3] >> (int)this._raw[2] << (int)this._raw[2];
			StringBuilder stringBuilder = new StringBuilder();
			if ((num & 128) == 128)
			{
				stringBuilder.Append("SSL Client Authentication");
			}
			if ((num & 64) == 64)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SSL Server Authentication");
			}
			if ((num & 32) == 32)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SMIME");
			}
			if ((num & 16) == 16)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Signature");
			}
			if ((num & 8) == 8)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Unknown cert type");
			}
			if ((num & 4) == 4)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SSL CA");
			}
			if ((num & 2) == 2)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SMIME CA");
			}
			if ((num & 1) == 1)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Signature CA");
			}
			stringBuilder.AppendFormat(" ({0})", num.ToString("x2"));
			return stringBuilder.ToString();
		}

		// Token: 0x0400044D RID: 1101
		internal Oid _oid;

		// Token: 0x0400044E RID: 1102
		internal byte[] _raw;
	}
}
