using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.Win32.SafeHandles;
using Mono.Security;
using Mono.Security.Authenticode;

namespace Mono
{
	// Token: 0x02000006 RID: 6
	internal abstract class X509PalImpl
	{
		// Token: 0x06000017 RID: 23
		public abstract X509CertificateImpl Import(byte[] data);

		// Token: 0x06000018 RID: 24
		public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);

		// Token: 0x06000019 RID: 25
		public abstract X509Certificate2Impl Import(X509Certificate cert);

		// Token: 0x0600001A RID: 26 RVA: 0x0000230C File Offset: 0x0000050C
		private static byte[] PEM(string type, byte[] data)
		{
			string @string = Encoding.ASCII.GetString(data);
			string text = string.Format("-----BEGIN {0}-----", type);
			string value = string.Format("-----END {0}-----", type);
			int num = @string.IndexOf(text) + text.Length;
			int num2 = @string.IndexOf(value, num);
			return Convert.FromBase64String(@string.Substring(num, num2 - num));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002364 File Offset: 0x00000564
		protected static byte[] ConvertData(byte[] data)
		{
			if (data == null || data.Length == 0)
			{
				return data;
			}
			if (data[0] != 48)
			{
				try
				{
					return X509PalImpl.PEM("CERTIFICATE", data);
				}
				catch
				{
				}
				return data;
			}
			return data;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000023A8 File Offset: 0x000005A8
		internal X509Certificate2Impl ImportFallback(byte[] data)
		{
			data = X509PalImpl.ConvertData(data);
			X509Certificate2Impl result;
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(null))
			{
				result = new X509Certificate2ImplMono(data, safePasswordHandle, X509KeyStorageFlags.DefaultKeySet);
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000023EC File Offset: 0x000005EC
		internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return new X509Certificate2ImplMono(data, password, keyStorageFlags);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool SupportsLegacyBasicConstraintsExtension
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000023FC File Offset: 0x000005FC
		public X509ContentType GetCertContentType(byte[] rawData)
		{
			if (rawData == null || rawData.Length == 0)
			{
				throw new ArgumentException("rawData");
			}
			if (rawData[0] == 48)
			{
				try
				{
					ASN1 asn = new ASN1(rawData);
					if (asn.Count == 3 && asn[0].Tag == 48 && asn[1].Tag == 48 && asn[2].Tag == 3)
					{
						return X509ContentType.Cert;
					}
					if (asn.Count == 3 && asn[0].Tag == 2 && asn[1].Tag == 48 && asn[2].Tag == 48)
					{
						return X509ContentType.Pfx;
					}
					if (asn.Count > 0 && asn[0].Tag == 6 && asn[0].CompareValue(X509PalImpl.signedData))
					{
						return X509ContentType.Pkcs7;
					}
					return X509ContentType.Unknown;
				}
				catch (Exception)
				{
					return X509ContentType.Unknown;
				}
			}
			if (Encoding.ASCII.GetString(rawData).IndexOf("-----BEGIN CERTIFICATE-----") >= 0)
			{
				return X509ContentType.Cert;
			}
			X509ContentType result;
			try
			{
				new AuthenticodeDeformatter(rawData);
				result = X509ContentType.Authenticode;
			}
			catch
			{
				result = X509ContentType.Unknown;
			}
			return result;
		}

		// Token: 0x04000008 RID: 8
		private static byte[] signedData = new byte[]
		{
			42,
			134,
			72,
			134,
			247,
			13,
			1,
			7,
			2
		};
	}
}
