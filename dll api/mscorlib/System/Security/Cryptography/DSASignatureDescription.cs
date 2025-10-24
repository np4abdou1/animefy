using System;

namespace System.Security.Cryptography
{
	// Token: 0x020002DD RID: 733
	internal class DSASignatureDescription : SignatureDescription
	{
		// Token: 0x06001840 RID: 6208 RVA: 0x00067805 File Offset: 0x00065A05
		public DSASignatureDescription()
		{
			base.KeyAlgorithm = "System.Security.Cryptography.DSACryptoServiceProvider";
			base.DigestAlgorithm = "System.Security.Cryptography.SHA1CryptoServiceProvider";
			base.FormatterAlgorithm = "System.Security.Cryptography.DSASignatureFormatter";
			base.DeformatterAlgorithm = "System.Security.Cryptography.DSASignatureDeformatter";
		}
	}
}
