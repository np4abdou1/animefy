using System;
using System.Text;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents an X509 extension.</summary>
	// Token: 0x02000102 RID: 258
	public class X509Extension : AsnEncodedData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> class.</summary>
		// Token: 0x06000766 RID: 1894 RVA: 0x0002A6B6 File Offset: 0x000288B6
		protected X509Extension()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> class.</summary>
		/// <param name="oid">A string representing the object identifier.</param>
		/// <param name="rawData">The encoded data used to create the extension.</param>
		/// <param name="critical">
		///       <see langword="true" /> if the extension is critical; otherwise <see langword="false" />.</param>
		// Token: 0x06000767 RID: 1895 RVA: 0x0002A6BE File Offset: 0x000288BE
		public X509Extension(string oid, byte[] rawData, bool critical) : base(oid, rawData)
		{
			this._critical = critical;
		}

		/// <summary>Gets a Boolean value indicating whether the extension is critical.</summary>
		/// <returns>
		///     <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0002A6CF File Offset: 0x000288CF
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x0002A6D7 File Offset: 0x000288D7
		public bool Critical
		{
			get
			{
				return this._critical;
			}
			set
			{
				this._critical = value;
			}
		}

		/// <summary>Copies the extension properties of the specified <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
		/// <param name="asnEncodedData">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> to be copied.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asnEncodedData" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asnEncodedData" /> does not have a valid X.509 extension.</exception>
		// Token: 0x0600076A RID: 1898 RVA: 0x0002A6E0 File Offset: 0x000288E0
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("encodedData");
			}
			X509Extension x509Extension = asnEncodedData as X509Extension;
			if (x509Extension == null)
			{
				throw new ArgumentException(Locale.GetText("Expected a X509Extension instance."));
			}
			base.CopyFrom(asnEncodedData);
			this._critical = x509Extension.Critical;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0002A728 File Offset: 0x00028928
		internal string FormatUnkownData(byte[] data)
		{
			if (data == null || data.Length == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				stringBuilder.Append(data[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000504 RID: 1284
		private bool _critical;
	}
}
