using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Defines how the certificate key can be used. If this value is not defined, the key can be used for any purpose.</summary>
	// Token: 0x020000E7 RID: 231
	[Flags]
	public enum X509KeyUsageFlags
	{
		/// <summary>No key usage parameters.</summary>
		// Token: 0x04000498 RID: 1176
		None = 0,
		/// <summary>The key can be used for encryption only.</summary>
		// Token: 0x04000499 RID: 1177
		EncipherOnly = 1,
		/// <summary>The key can be used to sign a certificate revocation list (CRL).</summary>
		// Token: 0x0400049A RID: 1178
		CrlSign = 2,
		/// <summary>The key can be used to sign certificates.</summary>
		// Token: 0x0400049B RID: 1179
		KeyCertSign = 4,
		/// <summary>The key can be used to determine key agreement, such as a key created using the Diffie-Hellman key agreement algorithm.</summary>
		// Token: 0x0400049C RID: 1180
		KeyAgreement = 8,
		/// <summary>The key can be used for data encryption.</summary>
		// Token: 0x0400049D RID: 1181
		DataEncipherment = 16,
		/// <summary>The key can be used for key encryption.</summary>
		// Token: 0x0400049E RID: 1182
		KeyEncipherment = 32,
		/// <summary>The key can be used for authentication.</summary>
		// Token: 0x0400049F RID: 1183
		NonRepudiation = 64,
		/// <summary>The key can be used as a digital signature.</summary>
		// Token: 0x040004A0 RID: 1184
		DigitalSignature = 128,
		/// <summary>The key can be used for decryption only.</summary>
		// Token: 0x040004A1 RID: 1185
		DecipherOnly = 32768
	}
}
