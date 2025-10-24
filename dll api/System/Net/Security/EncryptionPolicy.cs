using System;

namespace System.Net.Security
{
	/// <summary>The EncryptionPolicy to use. </summary>
	// Token: 0x0200021E RID: 542
	public enum EncryptionPolicy
	{
		/// <summary>Require encryption and never allow a NULL cipher.</summary>
		// Token: 0x04000BD1 RID: 3025
		RequireEncryption,
		/// <summary>Prefer that full encryption be used, but allow a NULL cipher (no encryption) if the server agrees. </summary>
		// Token: 0x04000BD2 RID: 3026
		AllowNoEncryption,
		/// <summary>Allow no encryption and request that a NULL cipher be used if the other endpoint can handle a NULL cipher.</summary>
		// Token: 0x04000BD3 RID: 3027
		NoEncryption
	}
}
