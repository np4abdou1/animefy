using System;
using System.Text;

namespace Mono.Btls
{
	// Token: 0x0200004D RID: 77
	internal static class MonoBtlsUtils
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00007A54 File Offset: 0x00005C54
		public static bool Compare(byte[] a, byte[] b)
		{
			if (a.Length != b.Length)
			{
				return false;
			}
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00007A84 File Offset: 0x00005C84
		private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes)
		{
			MonoBtlsX509NameEntryType monoBtlsX509NameEntryType = name.GetEntryType(index);
			if (monoBtlsX509NameEntryType < MonoBtlsX509NameEntryType.Unknown)
			{
				return false;
			}
			if (monoBtlsX509NameEntryType == MonoBtlsX509NameEntryType.Unknown && MonoBtlsUtils.Compare(name.GetEntryOidData(index), MonoBtlsUtils.emailOid))
			{
				monoBtlsX509NameEntryType = MonoBtlsX509NameEntryType.Email;
			}
			int num;
			string text = name.GetEntryValue(index, out num);
			if (text == null)
			{
				return false;
			}
			string entryOid = name.GetEntryOid(index);
			if (entryOid == null)
			{
				return false;
			}
			if (sb.Length > 0)
			{
				sb.Append(separator);
			}
			switch (monoBtlsX509NameEntryType)
			{
			case MonoBtlsX509NameEntryType.CountryName:
				sb.Append("C=");
				break;
			case MonoBtlsX509NameEntryType.OrganizationName:
				sb.Append("O=");
				break;
			case MonoBtlsX509NameEntryType.OrganizationalUnitName:
				sb.Append("OU=");
				break;
			case MonoBtlsX509NameEntryType.CommonName:
				sb.Append("CN=");
				break;
			case MonoBtlsX509NameEntryType.LocalityName:
				sb.Append("L=");
				break;
			case MonoBtlsX509NameEntryType.StateOrProvinceName:
				sb.Append("S=");
				break;
			case MonoBtlsX509NameEntryType.StreetAddress:
				sb.Append("STREET=");
				break;
			case MonoBtlsX509NameEntryType.SerialNumber:
				sb.Append("SERIALNUMBER=");
				break;
			case MonoBtlsX509NameEntryType.DomainComponent:
				sb.Append("DC=");
				break;
			case MonoBtlsX509NameEntryType.UserId:
				sb.Append("UID=");
				break;
			case MonoBtlsX509NameEntryType.Email:
				sb.Append("E=");
				break;
			case MonoBtlsX509NameEntryType.DnQualifier:
				sb.Append("dnQualifier=");
				break;
			case MonoBtlsX509NameEntryType.Title:
				sb.Append("T=");
				break;
			case MonoBtlsX509NameEntryType.Surname:
				sb.Append("SN=");
				break;
			case MonoBtlsX509NameEntryType.GivenName:
				sb.Append("G=");
				break;
			case MonoBtlsX509NameEntryType.Initial:
				sb.Append("I=");
				break;
			default:
				sb.Append("OID.");
				sb.Append(entryOid);
				sb.Append("=");
				break;
			}
			char[] anyOf = new char[]
			{
				',',
				'+',
				'"',
				'\\',
				'<',
				'>',
				';'
			};
			if (quotes && num != 30 && (text.IndexOfAny(anyOf, 0, text.Length) > 0 || text.StartsWith(" ") || text.EndsWith(" ")))
			{
				text = "\"" + text + "\"";
			}
			sb.Append(text);
			return true;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007CB0 File Offset: 0x00005EB0
		public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes)
		{
			int entryCount = name.GetEntryCount();
			StringBuilder stringBuilder = new StringBuilder();
			if (reversed)
			{
				for (int i = entryCount - 1; i >= 0; i--)
				{
					MonoBtlsUtils.AppendEntry(stringBuilder, name, i, separator, quotes);
				}
			}
			else
			{
				for (int j = 0; j < entryCount; j++)
				{
					MonoBtlsUtils.AppendEntry(stringBuilder, name, j, separator, quotes);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040000DD RID: 221
		private static byte[] emailOid = new byte[]
		{
			42,
			134,
			72,
			134,
			247,
			13,
			1,
			9,
			1
		};
	}
}
