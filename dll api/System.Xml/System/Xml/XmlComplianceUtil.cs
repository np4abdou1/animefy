using System;
using System.Text;
using System.Xml.XmlConfiguration;

namespace System.Xml
{
	// Token: 0x0200019D RID: 413
	internal static class XmlComplianceUtil
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x0005E408 File Offset: 0x0005C608
		public static string NonCDataNormalize(string value)
		{
			int length = value.Length;
			if (length <= 0)
			{
				return string.Empty;
			}
			int num = 0;
			StringBuilder stringBuilder = null;
			XmlCharType instance = XmlCharType.Instance;
			while (instance.IsWhiteSpace(value[num]))
			{
				num++;
				if (num == length)
				{
					if (!XmlReaderSection.CollapseWhiteSpaceIntoEmptyString)
					{
						return " ";
					}
					return "";
				}
			}
			int i = num;
			while (i < length)
			{
				if (!instance.IsWhiteSpace(value[i]))
				{
					i++;
				}
				else
				{
					int num2 = i + 1;
					while (num2 < length && instance.IsWhiteSpace(value[num2]))
					{
						num2++;
					}
					if (num2 == length)
					{
						if (stringBuilder == null)
						{
							return value.Substring(num, i - num);
						}
						stringBuilder.Append(value, num, i - num);
						return stringBuilder.ToString();
					}
					else if (num2 > i + 1 || value[i] != ' ')
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder(length);
						}
						stringBuilder.Append(value, num, i - num);
						stringBuilder.Append(' ');
						num = num2;
						i = num2;
					}
					else
					{
						i++;
					}
				}
			}
			if (stringBuilder != null)
			{
				if (num < i)
				{
					stringBuilder.Append(value, num, i - num);
				}
				return stringBuilder.ToString();
			}
			if (num > 0)
			{
				return value.Substring(num, length - num);
			}
			return value;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0005E544 File Offset: 0x0005C744
		public static string CDataNormalize(string value)
		{
			int length = value.Length;
			if (length <= 0)
			{
				return string.Empty;
			}
			int i = 0;
			int num = 0;
			StringBuilder stringBuilder = null;
			while (i < length)
			{
				char c = value[i];
				if (c >= ' ' || (c != '\t' && c != '\n' && c != '\r'))
				{
					i++;
				}
				else
				{
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder(length);
					}
					if (num < i)
					{
						stringBuilder.Append(value, num, i - num);
					}
					stringBuilder.Append(' ');
					if (c == '\r' && i + 1 < length && value[i + 1] == '\n')
					{
						i += 2;
					}
					else
					{
						i++;
					}
					num = i;
				}
			}
			if (stringBuilder == null)
			{
				return value;
			}
			if (i > num)
			{
				stringBuilder.Append(value, num, i - num);
			}
			return stringBuilder.ToString();
		}
	}
}
