using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies the way to open the X.509 certificate store.</summary>
	// Token: 0x020000E1 RID: 225
	[Flags]
	public enum OpenFlags
	{
		/// <summary>Open the X.509 certificate store for reading only.</summary>
		// Token: 0x04000450 RID: 1104
		ReadOnly = 0,
		/// <summary>Open the X.509 certificate store for both reading and writing.</summary>
		// Token: 0x04000451 RID: 1105
		ReadWrite = 1,
		/// <summary>Open the X.509 certificate store for the highest access allowed.</summary>
		// Token: 0x04000452 RID: 1106
		MaxAllowed = 2,
		/// <summary>Opens only existing stores; if no store exists, the <see cref="M:System.Security.Cryptography.X509Certificates.X509Store.Open(System.Security.Cryptography.X509Certificates.OpenFlags)" /> method will not create a new store.</summary>
		// Token: 0x04000453 RID: 1107
		OpenExistingOnly = 4,
		/// <summary>Open the X.509 certificate store and include archived certificates.</summary>
		// Token: 0x04000454 RID: 1108
		IncludeArchived = 8
	}
}
