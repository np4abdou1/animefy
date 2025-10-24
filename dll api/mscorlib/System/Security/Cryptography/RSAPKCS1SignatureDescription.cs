using System;

namespace System.Security.Cryptography
{
	// Token: 0x020002D8 RID: 728
	internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
	{
		// Token: 0x0600183B RID: 6203 RVA: 0x00067786 File Offset: 0x00065986
		protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
		{
			base.KeyAlgorithm = "System.Security.Cryptography.RSA";
			base.DigestAlgorithm = digestAlgorithm;
			base.FormatterAlgorithm = "System.Security.Cryptography.RSAPKCS1SignatureFormatter";
			base.DeformatterAlgorithm = "System.Security.Cryptography.RSAPKCS1SignatureDeformatter";
			this._hashAlgorithm = hashAlgorithm;
		}

		// Token: 0x04000A00 RID: 2560
		private string _hashAlgorithm;
	}
}
