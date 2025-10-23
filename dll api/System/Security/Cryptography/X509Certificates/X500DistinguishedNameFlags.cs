using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies characteristics of the X.500 distinguished name.</summary>
	// Token: 0x020000E4 RID: 228
	[Flags]
	public enum X500DistinguishedNameFlags
	{
		/// <summary>The distinguished name has no special characteristics.</summary>
		// Token: 0x04000462 RID: 1122
		None = 0,
		/// <summary>The distinguished name is reversed.</summary>
		// Token: 0x04000463 RID: 1123
		Reversed = 1,
		/// <summary>The distinguished name uses semicolons.</summary>
		// Token: 0x04000464 RID: 1124
		UseSemicolons = 16,
		/// <summary>The distinguished name does not use the plus sign.</summary>
		// Token: 0x04000465 RID: 1125
		DoNotUsePlusSign = 32,
		/// <summary>The distinguished name does not use quotation marks.</summary>
		// Token: 0x04000466 RID: 1126
		DoNotUseQuotes = 64,
		/// <summary>The distinguished name uses commas.</summary>
		// Token: 0x04000467 RID: 1127
		UseCommas = 128,
		/// <summary>The distinguished name uses the new line character.</summary>
		// Token: 0x04000468 RID: 1128
		UseNewLines = 256,
		/// <summary>The distinguished name uses UTF8 encoding instead of Unicode character encoding.</summary>
		// Token: 0x04000469 RID: 1129
		UseUTF8Encoding = 4096,
		/// <summary>The distinguished name uses T61 encoding.</summary>
		// Token: 0x0400046A RID: 1130
		UseT61Encoding = 8192,
		/// <summary>Forces the distinguished name to encode specific X.500 keys as UTF-8 strings rather than printable Unicode strings. For more information and the list of X.500 keys affected, see the X500NameFlags enumeration.</summary>
		// Token: 0x0400046B RID: 1131
		ForceUTF8Encoding = 16384
	}
}
