using System;

namespace System.Xml
{
	// Token: 0x0200019B RID: 411
	internal static class ValidateNames
	{
		// Token: 0x06000E0C RID: 3596 RVA: 0x0005DCC0 File Offset: 0x0005BEC0
		internal static int ParseNmtoken(string s, int offset)
		{
			int num = offset;
			while (num < s.Length && (ValidateNames.xmlCharType.charProperties[(int)s[num]] & 8) != 0)
			{
				num++;
			}
			return num - offset;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0005DCF8 File Offset: 0x0005BEF8
		internal static int ParseNmtokenNoNamespaces(string s, int offset)
		{
			int num = offset;
			while (num < s.Length && ((ValidateNames.xmlCharType.charProperties[(int)s[num]] & 8) != 0 || s[num] == ':'))
			{
				num++;
			}
			return num - offset;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0005DD3C File Offset: 0x0005BF3C
		internal static int ParseNameNoNamespaces(string s, int offset)
		{
			int num = offset;
			if (num < s.Length)
			{
				if ((ValidateNames.xmlCharType.charProperties[(int)s[num]] & 4) == 0 && s[num] != ':')
				{
					return 0;
				}
				num++;
				while (num < s.Length && ((ValidateNames.xmlCharType.charProperties[(int)s[num]] & 8) != 0 || s[num] == ':'))
				{
					num++;
				}
			}
			return num - offset;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0005DDB0 File Offset: 0x0005BFB0
		internal static bool IsNameNoNamespaces(string s)
		{
			int num = ValidateNames.ParseNameNoNamespaces(s, 0);
			return num > 0 && num == s.Length;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0005DDD4 File Offset: 0x0005BFD4
		internal static int ParseNCName(string s, int offset)
		{
			int num = offset;
			if (num < s.Length)
			{
				if ((ValidateNames.xmlCharType.charProperties[(int)s[num]] & 4) == 0)
				{
					return 0;
				}
				num++;
				while (num < s.Length && (ValidateNames.xmlCharType.charProperties[(int)s[num]] & 8) != 0)
				{
					num++;
				}
			}
			return num - offset;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0005DE30 File Offset: 0x0005C030
		internal static int ParseNCName(string s)
		{
			return ValidateNames.ParseNCName(s, 0);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0005DE3C File Offset: 0x0005C03C
		internal static int ParseQName(string s, int offset, out int colonOffset)
		{
			colonOffset = 0;
			int num = ValidateNames.ParseNCName(s, offset);
			if (num != 0)
			{
				offset += num;
				if (offset < s.Length && s[offset] == ':')
				{
					int num2 = ValidateNames.ParseNCName(s, offset + 1);
					if (num2 != 0)
					{
						colonOffset = offset;
						num += num2 + 1;
					}
				}
			}
			return num;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0005DE88 File Offset: 0x0005C088
		internal static void ParseQNameThrow(string s, out string prefix, out string localName)
		{
			int num2;
			int num = ValidateNames.ParseQName(s, 0, out num2);
			if (num == 0 || num != s.Length)
			{
				ValidateNames.ThrowInvalidName(s, 0, num);
			}
			if (num2 != 0)
			{
				prefix = s.Substring(0, num2);
				localName = s.Substring(num2 + 1);
				return;
			}
			prefix = "";
			localName = s;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0005DED8 File Offset: 0x0005C0D8
		internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar)
		{
			if (offsetStartChar >= s.Length)
			{
				throw new XmlException("The empty string '' is not a valid name.", string.Empty);
			}
			if (ValidateNames.xmlCharType.IsNCNameSingleChar(s[offsetBadChar]) && !XmlCharType.Instance.IsStartNCNameSingleChar(s[offsetBadChar]))
			{
				throw new XmlException("Name cannot begin with the '{0}' character, hexadecimal value {1}.", XmlException.BuildCharExceptionArgs(s, offsetBadChar));
			}
			throw new XmlException("The '{0}' character, hexadecimal value {1}, cannot be included in a name.", XmlException.BuildCharExceptionArgs(s, offsetBadChar));
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0005DF4C File Offset: 0x0005C14C
		internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar)
		{
			if (offsetStartChar >= s.Length)
			{
				return new XmlException("The empty string '' is not a valid name.", string.Empty);
			}
			if (ValidateNames.xmlCharType.IsNCNameSingleChar(s[offsetBadChar]) && !ValidateNames.xmlCharType.IsStartNCNameSingleChar(s[offsetBadChar]))
			{
				return new XmlException("Name cannot begin with the '{0}' character, hexadecimal value {1}.", XmlException.BuildCharExceptionArgs(s, offsetBadChar));
			}
			return new XmlException("The '{0}' character, hexadecimal value {1}, cannot be included in a name.", XmlException.BuildCharExceptionArgs(s, offsetBadChar));
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0005DFBC File Offset: 0x0005C1BC
		internal static void SplitQName(string name, out string prefix, out string lname)
		{
			int num = name.IndexOf(':');
			if (-1 == num)
			{
				prefix = string.Empty;
				lname = name;
				return;
			}
			if (num == 0 || name.Length - 1 == num)
			{
				string name2 = "The '{0}' character, hexadecimal value {1}, cannot be included in a name.";
				object[] args = XmlException.BuildCharExceptionArgs(':', '\0');
				throw new ArgumentException(Res.GetString(name2, args), "name");
			}
			prefix = name.Substring(0, num);
			num++;
			lname = name.Substring(num, name.Length - num);
		}

		// Token: 0x04000A95 RID: 2709
		private static XmlCharType xmlCharType = XmlCharType.Instance;
	}
}
