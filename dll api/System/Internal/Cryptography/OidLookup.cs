using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Internal.Cryptography
{
	// Token: 0x02000069 RID: 105
	internal static class OidLookup
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x00009438 File Offset: 0x00007638
		public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			bool flag = OidLookup.ShouldUseCache(oidGroup);
			string text;
			if (flag && (OidLookup.s_oidToFriendlyName.TryGetValue(oid, out text) || OidLookup.s_compatOids.TryGetValue(oid, out text) || OidLookup.s_lateBoundOidToFriendlyName.TryGetValue(oid, out text)))
			{
				return text;
			}
			text = OidLookup.NativeOidToFriendlyName(oid, oidGroup, fallBackToAllGroups);
			if (flag && text != null)
			{
				OidLookup.s_lateBoundOidToFriendlyName.TryAdd(oid, text);
			}
			return text;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000094AC File Offset: 0x000076AC
		public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			if (friendlyName == null)
			{
				throw new ArgumentNullException("friendlyName");
			}
			if (friendlyName.Length == 0)
			{
				return null;
			}
			bool flag = OidLookup.ShouldUseCache(oidGroup);
			string text;
			if (flag && (OidLookup.s_friendlyNameToOid.TryGetValue(friendlyName, out text) || OidLookup.s_lateBoundFriendlyNameToOid.TryGetValue(friendlyName, out text)))
			{
				return text;
			}
			text = OidLookup.NativeFriendlyNameToOid(friendlyName, oidGroup, fallBackToAllGroups);
			if (flag && text != null)
			{
				OidLookup.s_lateBoundFriendlyNameToOid.TryAdd(friendlyName, text);
			}
			return text;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00009518 File Offset: 0x00007718
		private static bool ShouldUseCache(OidGroup oidGroup)
		{
			return true;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000951C File Offset: 0x0000771C
		private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(oid);
			if (num <= 3329931538U)
			{
				if (num <= 2883603088U)
				{
					if (num != 2095896238U)
					{
						if (num == 2883603088U)
						{
							if (oid == "1.2.840.113549.1.9.5")
							{
								return "Signing Time";
							}
						}
					}
					else if (oid == "1.2.840.113549.1.7.1")
					{
						return "PKCS 7 Data";
					}
				}
				else if (num != 2900380707U)
				{
					if (num != 2984268802U)
					{
						if (num == 3329931538U)
						{
							if (oid == "1.2.840.113549.1.9.16.3.3")
							{
								return "id-smime-alg-3DESwrap";
							}
						}
					}
					else if (oid == "1.2.840.113549.1.9.3")
					{
						return "Content Type";
					}
				}
				else if (oid == "1.2.840.113549.1.9.4")
				{
					return "Message Digest";
				}
			}
			else if (num <= 3523885206U)
			{
				if (num != 3506813397U)
				{
					if (num != 3507107587U)
					{
						if (num == 3523885206U)
						{
							if (oid == "2.5.29.14")
							{
								return "Subject Key Identifier";
							}
						}
					}
					else if (oid == "2.5.29.17")
					{
						return "Subject Alternative Name";
					}
				}
				else if (oid == "2.5.29.37")
				{
					return "Extended Key Usage";
				}
			}
			else if (num != 3540662825U)
			{
				if (num != 3691389006U)
				{
					if (num == 3741994253U)
					{
						if (oid == "2.5.29.19")
						{
							return "Basic Constraints";
						}
					}
				}
				else if (oid == "2.16.840.1.113730.1.1")
				{
					return "Netscape Cert Type";
				}
			}
			else if (oid == "2.5.29.15")
			{
				return "Key Usage";
			}
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000096D8 File Offset: 0x000078D8
		private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(friendlyName);
			if (num <= 1964409053U)
			{
				if (num <= 1440264225U)
				{
					if (num != 61174027U)
					{
						if (num == 1440264225U)
						{
							if (friendlyName == "PKCS 7 Data")
							{
								return "1.2.840.113549.1.7.1";
							}
						}
					}
					else if (friendlyName == "Key Usage")
					{
						return "2.5.29.15";
					}
				}
				else if (num != 1542349551U)
				{
					if (num != 1597341437U)
					{
						if (num == 1964409053U)
						{
							if (friendlyName == "Basic Constraints")
							{
								return "2.5.29.19";
							}
						}
					}
					else if (friendlyName == "Signing Time")
					{
						return "1.2.840.113549.1.9.5";
					}
				}
				else if (friendlyName == "Subject Key Identifier")
				{
					return "2.5.29.14";
				}
			}
			else if (num <= 3023050339U)
			{
				if (num != 2503680566U)
				{
					if (num != 2647597108U)
					{
						if (num == 3023050339U)
						{
							if (friendlyName == "Subject Alternative Name")
							{
								return "2.5.29.17";
							}
						}
					}
					else if (friendlyName == "Netscape Cert Type")
					{
						return "2.16.840.1.113730.1.1";
					}
				}
				else if (friendlyName == "Content Type")
				{
					return "1.2.840.113549.1.9.3";
				}
			}
			else if (num != 3092919136U)
			{
				if (num != 3434299060U)
				{
					if (num == 3799289321U)
					{
						if (friendlyName == "id-smime-alg-3DESwrap")
						{
							return "1.2.840.113549.1.9.16.3.3";
						}
					}
				}
				else if (friendlyName == "Message Digest")
				{
					return "1.2.840.113549.1.9.4";
				}
			}
			else if (friendlyName == "Extended Key Usage")
			{
				return "2.5.29.37";
			}
			return null;
		}

		// Token: 0x0400015C RID: 348
		private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName = new ConcurrentDictionary<string, string>();

		// Token: 0x0400015D RID: 349
		private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid = new ConcurrentDictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400015E RID: 350
		private static readonly Dictionary<string, string> s_friendlyNameToOid = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
		{
			{
				"3des",
				"1.2.840.113549.3.7"
			},
			{
				"aes128",
				"2.16.840.1.101.3.4.1.2"
			},
			{
				"aes128wrap",
				"2.16.840.1.101.3.4.1.5"
			},
			{
				"aes192",
				"2.16.840.1.101.3.4.1.22"
			},
			{
				"aes192wrap",
				"2.16.840.1.101.3.4.1.25"
			},
			{
				"aes256",
				"2.16.840.1.101.3.4.1.42"
			},
			{
				"aes256wrap",
				"2.16.840.1.101.3.4.1.45"
			},
			{
				"brainpoolP160r1",
				"1.3.36.3.3.2.8.1.1.1"
			},
			{
				"brainpoolP160t1",
				"1.3.36.3.3.2.8.1.1.2"
			},
			{
				"brainpoolP192r1",
				"1.3.36.3.3.2.8.1.1.3"
			},
			{
				"brainpoolP192t1",
				"1.3.36.3.3.2.8.1.1.4"
			},
			{
				"brainpoolP224r1",
				"1.3.36.3.3.2.8.1.1.5"
			},
			{
				"brainpoolP224t1",
				"1.3.36.3.3.2.8.1.1.6"
			},
			{
				"brainpoolP256r1",
				"1.3.36.3.3.2.8.1.1.7"
			},
			{
				"brainpoolP256t1",
				"1.3.36.3.3.2.8.1.1.8"
			},
			{
				"brainpoolP320r1",
				"1.3.36.3.3.2.8.1.1.9"
			},
			{
				"brainpoolP320t1",
				"1.3.36.3.3.2.8.1.1.10"
			},
			{
				"brainpoolP384r1",
				"1.3.36.3.3.2.8.1.1.11"
			},
			{
				"brainpoolP384t1",
				"1.3.36.3.3.2.8.1.1.12"
			},
			{
				"brainpoolP512r1",
				"1.3.36.3.3.2.8.1.1.13"
			},
			{
				"brainpoolP512t1",
				"1.3.36.3.3.2.8.1.1.14"
			},
			{
				"C",
				"2.5.4.6"
			},
			{
				"CMS3DESwrap",
				"1.2.840.113549.1.9.16.3.6"
			},
			{
				"CMSRC2wrap",
				"1.2.840.113549.1.9.16.3.7"
			},
			{
				"CN",
				"2.5.4.3"
			},
			{
				"CPS",
				"1.3.6.1.5.5.7.2.1"
			},
			{
				"DC",
				"0.9.2342.19200300.100.1.25"
			},
			{
				"des",
				"1.3.14.3.2.7"
			},
			{
				"Description",
				"2.5.4.13"
			},
			{
				"DH",
				"1.2.840.10046.2.1"
			},
			{
				"dnQualifier",
				"2.5.4.46"
			},
			{
				"DSA",
				"1.2.840.10040.4.1"
			},
			{
				"dsaSHA1",
				"1.3.14.3.2.27"
			},
			{
				"E",
				"1.2.840.113549.1.9.1"
			},
			{
				"ec192wapi",
				"1.2.156.11235.1.1.2.1"
			},
			{
				"ECC",
				"1.2.840.10045.2.1"
			},
			{
				"ECDH_STD_SHA1_KDF",
				"1.3.133.16.840.63.0.2"
			},
			{
				"ECDH_STD_SHA256_KDF",
				"1.3.132.1.11.1"
			},
			{
				"ECDH_STD_SHA384_KDF",
				"1.3.132.1.11.2"
			},
			{
				"ECDSA_P256",
				"1.2.840.10045.3.1.7"
			},
			{
				"ECDSA_P384",
				"1.3.132.0.34"
			},
			{
				"ECDSA_P521",
				"1.3.132.0.35"
			},
			{
				"ESDH",
				"1.2.840.113549.1.9.16.3.5"
			},
			{
				"G",
				"2.5.4.42"
			},
			{
				"I",
				"2.5.4.43"
			},
			{
				"L",
				"2.5.4.7"
			},
			{
				"md2",
				"1.2.840.113549.2.2"
			},
			{
				"md2RSA",
				"1.2.840.113549.1.1.2"
			},
			{
				"md4",
				"1.2.840.113549.2.4"
			},
			{
				"md4RSA",
				"1.2.840.113549.1.1.3"
			},
			{
				"md5",
				"1.2.840.113549.2.5"
			},
			{
				"md5RSA",
				"1.2.840.113549.1.1.4"
			},
			{
				"mgf1",
				"1.2.840.113549.1.1.8"
			},
			{
				"mosaicKMandUpdSig",
				"2.16.840.1.101.2.1.1.20"
			},
			{
				"mosaicUpdatedSig",
				"2.16.840.1.101.2.1.1.19"
			},
			{
				"nistP192",
				"1.2.840.10045.3.1.1"
			},
			{
				"nistP224",
				"1.3.132.0.33"
			},
			{
				"NO_SIGN",
				"1.3.6.1.5.5.7.6.2"
			},
			{
				"O",
				"2.5.4.10"
			},
			{
				"OU",
				"2.5.4.11"
			},
			{
				"Phone",
				"2.5.4.20"
			},
			{
				"POBox",
				"2.5.4.18"
			},
			{
				"PostalCode",
				"2.5.4.17"
			},
			{
				"rc2",
				"1.2.840.113549.3.2"
			},
			{
				"rc4",
				"1.2.840.113549.3.4"
			},
			{
				"RSA",
				"1.2.840.113549.1.1.1"
			},
			{
				"RSAES_OAEP",
				"1.2.840.113549.1.1.7"
			},
			{
				"RSASSA-PSS",
				"1.2.840.113549.1.1.10"
			},
			{
				"S",
				"2.5.4.8"
			},
			{
				"secP160k1",
				"1.3.132.0.9"
			},
			{
				"secP160r1",
				"1.3.132.0.8"
			},
			{
				"secP160r2",
				"1.3.132.0.30"
			},
			{
				"secP192k1",
				"1.3.132.0.31"
			},
			{
				"secP224k1",
				"1.3.132.0.32"
			},
			{
				"secP256k1",
				"1.3.132.0.10"
			},
			{
				"SERIALNUMBER",
				"2.5.4.5"
			},
			{
				"sha1",
				"1.3.14.3.2.26"
			},
			{
				"sha1DSA",
				"1.2.840.10040.4.3"
			},
			{
				"sha1ECDSA",
				"1.2.840.10045.4.1"
			},
			{
				"sha1RSA",
				"1.2.840.113549.1.1.5"
			},
			{
				"sha256",
				"2.16.840.1.101.3.4.2.1"
			},
			{
				"sha256ECDSA",
				"1.2.840.10045.4.3.2"
			},
			{
				"sha256RSA",
				"1.2.840.113549.1.1.11"
			},
			{
				"sha384",
				"2.16.840.1.101.3.4.2.2"
			},
			{
				"sha384ECDSA",
				"1.2.840.10045.4.3.3"
			},
			{
				"sha384RSA",
				"1.2.840.113549.1.1.12"
			},
			{
				"sha512",
				"2.16.840.1.101.3.4.2.3"
			},
			{
				"sha512ECDSA",
				"1.2.840.10045.4.3.4"
			},
			{
				"sha512RSA",
				"1.2.840.113549.1.1.13"
			},
			{
				"SN",
				"2.5.4.4"
			},
			{
				"specifiedECDSA",
				"1.2.840.10045.4.3"
			},
			{
				"STREET",
				"2.5.4.9"
			},
			{
				"T",
				"2.5.4.12"
			},
			{
				"wtls9",
				"2.23.43.1.4.9"
			},
			{
				"X21Address",
				"2.5.4.24"
			},
			{
				"x962P192v2",
				"1.2.840.10045.3.1.2"
			},
			{
				"x962P192v3",
				"1.2.840.10045.3.1.3"
			},
			{
				"x962P239v1",
				"1.2.840.10045.3.1.4"
			},
			{
				"x962P239v2",
				"1.2.840.10045.3.1.5"
			},
			{
				"x962P239v3",
				"1.2.840.10045.3.1.6"
			}
		};

		// Token: 0x0400015F RID: 351
		private static readonly Dictionary<string, string> s_oidToFriendlyName = OidLookup.s_friendlyNameToOid.ToDictionary((KeyValuePair<string, string> kvp) => kvp.Value, (KeyValuePair<string, string> kvp) => kvp.Key);

		// Token: 0x04000160 RID: 352
		private static readonly Dictionary<string, string> s_compatOids = new Dictionary<string, string>
		{
			{
				"1.2.840.113549.1.3.1",
				"DH"
			},
			{
				"1.3.14.3.2.12",
				"DSA"
			},
			{
				"1.3.14.3.2.13",
				"sha1DSA"
			},
			{
				"1.3.14.3.2.15",
				"shaRSA"
			},
			{
				"1.3.14.3.2.18",
				"sha"
			},
			{
				"1.3.14.3.2.2",
				"md4RSA"
			},
			{
				"1.3.14.3.2.22",
				"RSA_KEYX"
			},
			{
				"1.3.14.3.2.29",
				"sha1RSA"
			},
			{
				"1.3.14.3.2.3",
				"md5RSA"
			},
			{
				"1.3.14.3.2.4",
				"md4RSA"
			},
			{
				"1.3.14.7.2.3.1",
				"md2RSA"
			}
		};
	}
}
