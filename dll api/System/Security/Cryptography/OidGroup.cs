using System;

namespace System.Security.Cryptography
{
	/// <summary>Identifies Windows cryptographic object identifier (OID) groups.</summary>
	// Token: 0x020000DE RID: 222
	public enum OidGroup
	{
		/// <summary>All the groups.</summary>
		// Token: 0x0400043B RID: 1083
		All,
		/// <summary>The Windows group that is represented by CRYPT_HASH_ALG_OID_GROUP_ID.</summary>
		// Token: 0x0400043C RID: 1084
		HashAlgorithm,
		/// <summary>The Windows group that is represented by CRYPT_ENCRYPT_ALG_OID_GROUP_ID.</summary>
		// Token: 0x0400043D RID: 1085
		EncryptionAlgorithm,
		/// <summary>The Windows group that is represented by CRYPT_PUBKEY_ALG_OID_GROUP_ID.</summary>
		// Token: 0x0400043E RID: 1086
		PublicKeyAlgorithm,
		/// <summary>The Windows group that is represented by CRYPT_SIGN_ALG_OID_GROUP_ID.</summary>
		// Token: 0x0400043F RID: 1087
		SignatureAlgorithm,
		/// <summary>The Windows group that is represented by CRYPT_RDN_ATTR_OID_GROUP_ID.</summary>
		// Token: 0x04000440 RID: 1088
		Attribute,
		/// <summary>The Windows group that is represented by CRYPT_EXT_OR_ATTR_OID_GROUP_ID.</summary>
		// Token: 0x04000441 RID: 1089
		ExtensionOrAttribute,
		/// <summary>The Windows group that is represented by CRYPT_ENHKEY_USAGE_OID_GROUP_ID.</summary>
		// Token: 0x04000442 RID: 1090
		EnhancedKeyUsage,
		/// <summary>The Windows group that is represented by CRYPT_POLICY_OID_GROUP_ID.</summary>
		// Token: 0x04000443 RID: 1091
		Policy,
		/// <summary>The Windows group that is represented by CRYPT_TEMPLATE_OID_GROUP_ID.</summary>
		// Token: 0x04000444 RID: 1092
		Template,
		/// <summary>The Windows group that is represented by CRYPT_KDF_OID_GROUP_ID.</summary>
		// Token: 0x04000445 RID: 1093
		KeyDerivationFunction
	}
}
