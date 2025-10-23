using System;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Encodes and decodes XML names, and provides methods for converting between common language runtime types and XML Schema definition language (XSD) types. When converting data types, the values returned are locale-independent.</summary>
	// Token: 0x020001A0 RID: 416
	public class XmlConvert
	{
		/// <summary>Converts the name to a valid XML name.</summary>
		/// <param name="name">A name to be translated. </param>
		/// <returns>Returns the name with any invalid characters replaced by an escape string.</returns>
		// Token: 0x06000E36 RID: 3638 RVA: 0x0005E5F8 File Offset: 0x0005C7F8
		public static string EncodeName(string name)
		{
			return XmlConvert.EncodeName(name, true, false);
		}

		/// <summary>Converts the name to a valid XML local name.</summary>
		/// <param name="name">The name to be encoded. </param>
		/// <returns>The encoded name.</returns>
		// Token: 0x06000E37 RID: 3639 RVA: 0x0005E602 File Offset: 0x0005C802
		public static string EncodeLocalName(string name)
		{
			return XmlConvert.EncodeName(name, true, true);
		}

		/// <summary>Decodes a name. This method does the reverse of the <see cref="M:System.Xml.XmlConvert.EncodeName(System.String)" /> and <see cref="M:System.Xml.XmlConvert.EncodeLocalName(System.String)" /> methods.</summary>
		/// <param name="name">The name to be transformed. </param>
		/// <returns>The decoded name.</returns>
		// Token: 0x06000E38 RID: 3640 RVA: 0x0005E60C File Offset: 0x0005C80C
		public static string DecodeName(string name)
		{
			if (name == null || name.Length == 0)
			{
				return name;
			}
			StringBuilder stringBuilder = null;
			int length = name.Length;
			int num = 0;
			int num2 = name.IndexOf('_');
			if (num2 < 0)
			{
				return name;
			}
			if (XmlConvert.c_DecodeCharPattern == null)
			{
				XmlConvert.c_DecodeCharPattern = new Regex("_[Xx]([0-9a-fA-F]{4}|[0-9a-fA-F]{8})_");
			}
			IEnumerator enumerator = XmlConvert.c_DecodeCharPattern.Matches(name, num2).GetEnumerator();
			int num3 = -1;
			if (enumerator != null && enumerator.MoveNext())
			{
				num3 = ((Match)enumerator.Current).Index;
			}
			for (int i = 0; i < length - XmlConvert.c_EncodedCharLength + 1; i++)
			{
				if (i == num3)
				{
					if (enumerator.MoveNext())
					{
						num3 = ((Match)enumerator.Current).Index;
					}
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder(length + 20);
					}
					stringBuilder.Append(name, num, i - num);
					if (name[i + 6] != '_')
					{
						int num4 = XmlConvert.FromHex(name[i + 2]) * 268435456 + XmlConvert.FromHex(name[i + 3]) * 16777216 + XmlConvert.FromHex(name[i + 4]) * 1048576 + XmlConvert.FromHex(name[i + 5]) * 65536 + XmlConvert.FromHex(name[i + 6]) * 4096 + XmlConvert.FromHex(name[i + 7]) * 256 + XmlConvert.FromHex(name[i + 8]) * 16 + XmlConvert.FromHex(name[i + 9]);
						if (num4 >= 65536)
						{
							if (num4 <= 1114111)
							{
								num = i + XmlConvert.c_EncodedCharLength + 4;
								char value;
								char value2;
								XmlCharType.SplitSurrogateChar(num4, out value, out value2);
								stringBuilder.Append(value2);
								stringBuilder.Append(value);
							}
						}
						else
						{
							num = i + XmlConvert.c_EncodedCharLength + 4;
							stringBuilder.Append((char)num4);
						}
						i += XmlConvert.c_EncodedCharLength - 1 + 4;
					}
					else
					{
						num = i + XmlConvert.c_EncodedCharLength;
						stringBuilder.Append((char)(XmlConvert.FromHex(name[i + 2]) * 4096 + XmlConvert.FromHex(name[i + 3]) * 256 + XmlConvert.FromHex(name[i + 4]) * 16 + XmlConvert.FromHex(name[i + 5])));
						i += XmlConvert.c_EncodedCharLength - 1;
					}
				}
			}
			if (num == 0)
			{
				return name;
			}
			if (num < length)
			{
				stringBuilder.Append(name, num, length - num);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0005E898 File Offset: 0x0005CA98
		private static string EncodeName(string name, bool first, bool local)
		{
			if (string.IsNullOrEmpty(name))
			{
				return name;
			}
			StringBuilder stringBuilder = null;
			int length = name.Length;
			int num = 0;
			int i = 0;
			int num2 = name.IndexOf('_');
			IEnumerator enumerator = null;
			if (num2 >= 0)
			{
				if (XmlConvert.c_EncodeCharPattern == null)
				{
					XmlConvert.c_EncodeCharPattern = new Regex("(?<=_)[Xx]([0-9a-fA-F]{4}|[0-9a-fA-F]{8})_");
				}
				enumerator = XmlConvert.c_EncodeCharPattern.Matches(name, num2).GetEnumerator();
			}
			int num3 = -1;
			if (enumerator != null && enumerator.MoveNext())
			{
				num3 = ((Match)enumerator.Current).Index - 1;
			}
			if (first && ((!XmlConvert.xmlCharType.IsStartNCNameCharXml4e(name[0]) && (local || (!local && name[0] != ':'))) || num3 == 0))
			{
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(length + 20);
				}
				stringBuilder.Append("_x");
				if (length > 1 && XmlCharType.IsHighSurrogate((int)name[0]) && XmlCharType.IsLowSurrogate((int)name[1]))
				{
					int highChar = (int)name[0];
					stringBuilder.Append(XmlCharType.CombineSurrogateChar((int)name[1], highChar).ToString("X8", CultureInfo.InvariantCulture));
					i++;
					num = 2;
				}
				else
				{
					stringBuilder.Append(((int)name[0]).ToString("X4", CultureInfo.InvariantCulture));
					num = 1;
				}
				stringBuilder.Append("_");
				i++;
				if (num3 == 0 && enumerator.MoveNext())
				{
					num3 = ((Match)enumerator.Current).Index - 1;
				}
			}
			while (i < length)
			{
				if ((local && !XmlConvert.xmlCharType.IsNCNameCharXml4e(name[i])) || (!local && !XmlConvert.xmlCharType.IsNameCharXml4e(name[i])) || num3 == i)
				{
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder(length + 20);
					}
					if (num3 == i && enumerator.MoveNext())
					{
						num3 = ((Match)enumerator.Current).Index - 1;
					}
					stringBuilder.Append(name, num, i - num);
					stringBuilder.Append("_x");
					if (length > i + 1 && XmlCharType.IsHighSurrogate((int)name[i]) && XmlCharType.IsLowSurrogate((int)name[i + 1]))
					{
						int highChar2 = (int)name[i];
						stringBuilder.Append(XmlCharType.CombineSurrogateChar((int)name[i + 1], highChar2).ToString("X8", CultureInfo.InvariantCulture));
						num = i + 2;
						i++;
					}
					else
					{
						stringBuilder.Append(((int)name[i]).ToString("X4", CultureInfo.InvariantCulture));
						num = i + 1;
					}
					stringBuilder.Append("_");
				}
				i++;
			}
			if (num == 0)
			{
				return name;
			}
			if (num < length)
			{
				stringBuilder.Append(name, num, length - num);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0005EB5A File Offset: 0x0005CD5A
		private static int FromHex(char digit)
		{
			if (digit > '9')
			{
				return (int)(((digit <= 'F') ? (digit - 'A') : (digit - 'a')) + '\n');
			}
			return (int)(digit - '0');
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0005EB78 File Offset: 0x0005CD78
		internal static byte[] FromBinHexString(string s)
		{
			return XmlConvert.FromBinHexString(s, true);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0005EB81 File Offset: 0x0005CD81
		internal static byte[] FromBinHexString(string s, bool allowOddCount)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return BinHexDecoder.Decode(s.ToCharArray(), allowOddCount);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0005EB9D File Offset: 0x0005CD9D
		internal static string ToBinHexString(byte[] inArray)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			return BinHexEncoder.Encode(inArray, 0, inArray.Length);
		}

		/// <summary>Verifies that the name is a valid name according to the W3C Extended Markup Language recommendation.</summary>
		/// <param name="name">The name to verify. </param>
		/// <returns>The name, if it is a valid XML name.</returns>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="name" /> is not a valid XML name. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" /> or String.Empty. </exception>
		// Token: 0x06000E3E RID: 3646 RVA: 0x0005EBB8 File Offset: 0x0005CDB8
		public static string VerifyName(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentNullException("name", Res.GetString("The empty string '' is not a valid name."));
			}
			int num = ValidateNames.ParseNameNoNamespaces(name, 0);
			if (num != name.Length)
			{
				throw XmlConvert.CreateInvalidNameCharException(name, num, ExceptionType.XmlException);
			}
			return name;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0005EC0C File Offset: 0x0005CE0C
		internal static Exception TryVerifyName(string name)
		{
			if (name == null || name.Length == 0)
			{
				return new XmlException("The empty string '' is not a valid name.", string.Empty);
			}
			int num = ValidateNames.ParseNameNoNamespaces(name, 0);
			if (num != name.Length)
			{
				return new XmlException((num == 0) ? "Name cannot begin with the '{0}' character, hexadecimal value {1}." : "The '{0}' character, hexadecimal value {1}, cannot be included in a name.", XmlException.BuildCharExceptionArgs(name, num));
			}
			return null;
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0005EC64 File Offset: 0x0005CE64
		internal static string VerifyQName(string name, ExceptionType exceptionType)
		{
			if (name == null || name.Length == 0)
			{
				throw new ArgumentNullException("name");
			}
			int num = -1;
			int num2 = ValidateNames.ParseQName(name, 0, out num);
			if (num2 != name.Length)
			{
				throw XmlConvert.CreateException("The '{0}' character, hexadecimal value {1}, cannot be included in a name.", XmlException.BuildCharExceptionArgs(name, num2), exceptionType, 0, num2 + 1);
			}
			return name;
		}

		/// <summary>Verifies that the name is a valid <see langword="NCName" /> according to the W3C Extended Markup Language recommendation. An <see langword="NCName" /> is a name that cannot contain a colon.</summary>
		/// <param name="name">The name to verify. </param>
		/// <returns>The name, if it is a valid NCName.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" /> or String.Empty. </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="name" /> is not a valid non-colon name. </exception>
		// Token: 0x06000E41 RID: 3649 RVA: 0x0005ECB4 File Offset: 0x0005CEB4
		public static string VerifyNCName(string name)
		{
			return XmlConvert.VerifyNCName(name, ExceptionType.XmlException);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0005ECC0 File Offset: 0x0005CEC0
		internal static string VerifyNCName(string name, ExceptionType exceptionType)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentNullException("name", Res.GetString("The empty string '' is not a valid local name."));
			}
			int num = ValidateNames.ParseNCName(name, 0);
			if (num != name.Length)
			{
				throw XmlConvert.CreateInvalidNameCharException(name, num, exceptionType);
			}
			return name;
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0005ED14 File Offset: 0x0005CF14
		internal static Exception TryVerifyNCName(string name)
		{
			int num = ValidateNames.ParseNCName(name);
			if (num == 0 || num != name.Length)
			{
				return ValidateNames.GetInvalidNameException(name, 0, num);
			}
			return null;
		}

		/// <summary>Verifies that the string is a valid token according to the W3C XML Schema Part2: Datatypes recommendation.</summary>
		/// <param name="token">The string value you wish to verify.</param>
		/// <returns>The token, if it is a valid token.</returns>
		/// <exception cref="T:System.Xml.XmlException">The string value is not a valid token.</exception>
		// Token: 0x06000E44 RID: 3652 RVA: 0x0005ED40 File Offset: 0x0005CF40
		public static string VerifyTOKEN(string token)
		{
			if (token == null || token.Length == 0)
			{
				return token;
			}
			if (token[0] == ' ' || token[token.Length - 1] == ' ' || token.IndexOfAny(XmlConvert.crt) != -1 || token.IndexOf("  ", StringComparison.Ordinal) != -1)
			{
				throw new XmlException("line-feed (#xA) or tab (#x9) characters, leading or trailing spaces and sequences of one or more spaces (#x20) are not allowed in 'xs:token'.", token);
			}
			return token;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0005EDA4 File Offset: 0x0005CFA4
		internal static Exception TryVerifyTOKEN(string token)
		{
			if (token == null || token.Length == 0)
			{
				return null;
			}
			if (token[0] == ' ' || token[token.Length - 1] == ' ' || token.IndexOfAny(XmlConvert.crt) != -1 || token.IndexOf("  ", StringComparison.Ordinal) != -1)
			{
				return new XmlException("line-feed (#xA) or tab (#x9) characters, leading or trailing spaces and sequences of one or more spaces (#x20) are not allowed in 'xs:token'.", token);
			}
			return null;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0005EE08 File Offset: 0x0005D008
		internal static Exception TryVerifyNMTOKEN(string name)
		{
			if (name == null || name.Length == 0)
			{
				return new XmlException("The empty string '' is not a valid name.", string.Empty);
			}
			int num = ValidateNames.ParseNmtokenNoNamespaces(name, 0);
			if (num != name.Length)
			{
				return new XmlException("The '{0}' character, hexadecimal value {1}, cannot be included in a name.", XmlException.BuildCharExceptionArgs(name, num));
			}
			return null;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0005EE54 File Offset: 0x0005D054
		internal static Exception TryVerifyNormalizedString(string str)
		{
			if (str.IndexOfAny(XmlConvert.crt) != -1)
			{
				return new XmlSchemaException("Carriage return (#xD), line feed (#xA), and tab (#x9) characters are not allowed in xs:normalizedString.", str);
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.Boolean" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Boolean" />, that is, "true" or "false".</returns>
		// Token: 0x06000E48 RID: 3656 RVA: 0x0005EE71 File Offset: 0x0005D071
		public static string ToString(bool value)
		{
			if (!value)
			{
				return "false";
			}
			return "true";
		}

		/// <summary>Converts the <see cref="T:System.Char" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Char" />.</returns>
		// Token: 0x06000E49 RID: 3657 RVA: 0x0005EE81 File Offset: 0x0005D081
		public static string ToString(char value)
		{
			return value.ToString(null);
		}

		/// <summary>Converts the <see cref="T:System.Decimal" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Decimal" />.</returns>
		// Token: 0x06000E4A RID: 3658 RVA: 0x0005EE8B File Offset: 0x0005D08B
		public static string ToString(decimal value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.SByte" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="SByte" />.</returns>
		// Token: 0x06000E4B RID: 3659 RVA: 0x0005EE9A File Offset: 0x0005D09A
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.Int16" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Int16" />.</returns>
		// Token: 0x06000E4C RID: 3660 RVA: 0x0005EEA9 File Offset: 0x0005D0A9
		public static string ToString(short value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.Int32" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Int32" />.</returns>
		// Token: 0x06000E4D RID: 3661 RVA: 0x0005EEB8 File Offset: 0x0005D0B8
		public static string ToString(int value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.Int64" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Int64" />.</returns>
		// Token: 0x06000E4E RID: 3662 RVA: 0x0005EEC7 File Offset: 0x0005D0C7
		public static string ToString(long value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.Byte" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Byte" />.</returns>
		// Token: 0x06000E4F RID: 3663 RVA: 0x0005EED6 File Offset: 0x0005D0D6
		public static string ToString(byte value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.UInt16" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="UInt16" />.</returns>
		// Token: 0x06000E50 RID: 3664 RVA: 0x0005EEE5 File Offset: 0x0005D0E5
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.UInt32" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="UInt32" />.</returns>
		// Token: 0x06000E51 RID: 3665 RVA: 0x0005EEF4 File Offset: 0x0005D0F4
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.UInt64" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="UInt64" />.</returns>
		// Token: 0x06000E52 RID: 3666 RVA: 0x0005EF03 File Offset: 0x0005D103
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return value.ToString(null, NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.Single" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Single" />.</returns>
		// Token: 0x06000E53 RID: 3667 RVA: 0x0005EF12 File Offset: 0x0005D112
		public static string ToString(float value)
		{
			if (float.IsNegativeInfinity(value))
			{
				return "-INF";
			}
			if (float.IsPositiveInfinity(value))
			{
				return "INF";
			}
			if (XmlConvert.IsNegativeZero((double)value))
			{
				return "-0";
			}
			return value.ToString("R", NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.Double" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Double" />.</returns>
		// Token: 0x06000E54 RID: 3668 RVA: 0x0005EF50 File Offset: 0x0005D150
		public static string ToString(double value)
		{
			if (double.IsNegativeInfinity(value))
			{
				return "-INF";
			}
			if (double.IsPositiveInfinity(value))
			{
				return "INF";
			}
			if (XmlConvert.IsNegativeZero(value))
			{
				return "-0";
			}
			return value.ToString("R", NumberFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.TimeSpan" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="TimeSpan" />.</returns>
		// Token: 0x06000E55 RID: 3669 RVA: 0x0005EF90 File Offset: 0x0005D190
		public static string ToString(TimeSpan value)
		{
			return new XsdDuration(value).ToString();
		}

		/// <summary>Converts the <see cref="T:System.DateTime" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <param name="format">The format structure that defines how to display the converted string. Valid formats include "yyyy-MM-ddTHH:mm:sszzzzzz" and its subsets. </param>
		/// <returns>A string representation of the <see langword="DateTime" /> in the specified format.</returns>
		// Token: 0x06000E56 RID: 3670 RVA: 0x0005EFB1 File Offset: 0x0005D1B1
		public static string ToString(DateTime value, string format)
		{
			return value.ToString(format, DateTimeFormatInfo.InvariantInfo);
		}

		/// <summary>Converts the <see cref="T:System.DateTime" /> to a <see cref="T:System.String" /> using the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> specified.</summary>
		/// <param name="value">The <see cref="T:System.DateTime" /> value to convert.</param>
		/// <param name="dateTimeOption">One of the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> values that specify how to treat the <see cref="T:System.DateTime" /> value.</param>
		/// <returns>A <see cref="T:System.String" /> equivalent of the <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="dateTimeOption" /> value is not valid.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> or <paramref name="dateTimeOption" /> value is <see langword="null" />.</exception>
		// Token: 0x06000E57 RID: 3671 RVA: 0x0005EFC0 File Offset: 0x0005D1C0
		public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption)
		{
			switch (dateTimeOption)
			{
			case XmlDateTimeSerializationMode.Local:
				value = XmlConvert.SwitchToLocalTime(value);
				break;
			case XmlDateTimeSerializationMode.Utc:
				value = XmlConvert.SwitchToUtcTime(value);
				break;
			case XmlDateTimeSerializationMode.Unspecified:
				value = new DateTime(value.Ticks, DateTimeKind.Unspecified);
				break;
			case XmlDateTimeSerializationMode.RoundtripKind:
				break;
			default:
				throw new ArgumentException(Res.GetString("The '{0}' value for the 'dateTimeOption' parameter is not an allowed value for the 'XmlDateTimeSerializationMode' enumeration.", new object[]
				{
					dateTimeOption,
					"dateTimeOption"
				}));
			}
			XsdDateTime xsdDateTime = new XsdDateTime(value, XsdDateTimeFlags.DateTime);
			return xsdDateTime.ToString();
		}

		/// <summary>Converts the supplied <see cref="T:System.DateTimeOffset" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The <see cref="T:System.DateTimeOffset" /> to be converted.</param>
		/// <returns>A <see cref="T:System.String" /> representation of the supplied <see cref="T:System.DateTimeOffset" />.</returns>
		// Token: 0x06000E58 RID: 3672 RVA: 0x0005F048 File Offset: 0x0005D248
		public static string ToString(DateTimeOffset value)
		{
			XsdDateTime xsdDateTime = new XsdDateTime(value);
			return xsdDateTime.ToString();
		}

		/// <summary>Converts the <see cref="T:System.Guid" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A string representation of the <see langword="Guid" />.</returns>
		// Token: 0x06000E59 RID: 3673 RVA: 0x0005F06A File Offset: 0x0005D26A
		public static string ToString(Guid value)
		{
			return value.ToString();
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Boolean" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="Boolean" /> value, that is, <see langword="true" /> or <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> does not represent a <see langword="Boolean" /> value. </exception>
		// Token: 0x06000E5A RID: 3674 RVA: 0x0005F07C File Offset: 0x0005D27C
		public static bool ToBoolean(string s)
		{
			s = XmlConvert.TrimString(s);
			if (s == "1" || s == "true")
			{
				return true;
			}
			if (s == "0" || s == "false")
			{
				return false;
			}
			throw new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
			{
				s,
				"Boolean"
			}));
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0005F0EC File Offset: 0x0005D2EC
		internal static Exception TryToBoolean(string s, out bool result)
		{
			s = XmlConvert.TrimString(s);
			if (s == "0" || s == "false")
			{
				result = false;
				return null;
			}
			if (s == "1" || s == "true")
			{
				result = true;
				return null;
			}
			result = false;
			return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
			{
				s,
				"Boolean"
			}));
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Char" /> equivalent.</summary>
		/// <param name="s">The string containing a single character to convert. </param>
		/// <returns>A <see langword="Char" /> representing the single character.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value of the <paramref name="s" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">The <paramref name="s" /> parameter contains more than one character. </exception>
		// Token: 0x06000E5C RID: 3676 RVA: 0x0005F163 File Offset: 0x0005D363
		public static char ToChar(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.Length != 1)
			{
				throw new FormatException(Res.GetString("String must be exactly one character long."));
			}
			return s[0];
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0005F193 File Offset: 0x0005D393
		internal static Exception TryToChar(string s, out char result)
		{
			if (!char.TryParse(s, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Char"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Decimal" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="Decimal" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000E5E RID: 3678 RVA: 0x0005F1C1 File Offset: 0x0005D3C1
		public static decimal ToDecimal(string s)
		{
			return decimal.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		internal static Exception TryToDecimal(string s, out decimal result)
		{
			if (!decimal.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Decimal"
				}));
			}
			return null;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0005F205 File Offset: 0x0005D405
		internal static decimal ToInteger(string s)
		{
			return decimal.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0005F213 File Offset: 0x0005D413
		internal static Exception TryToInteger(string s, out decimal result)
		{
			if (!decimal.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Integer"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.SByte" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>An <see langword="SByte" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		// Token: 0x06000E62 RID: 3682 RVA: 0x0005F247 File Offset: 0x0005D447
		[CLSCompliant(false)]
		public static sbyte ToSByte(string s)
		{
			return sbyte.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0005F255 File Offset: 0x0005D455
		internal static Exception TryToSByte(string s, out sbyte result)
		{
			if (!sbyte.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"SByte"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Int16" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>An <see langword="Int16" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		// Token: 0x06000E64 RID: 3684 RVA: 0x0005F289 File Offset: 0x0005D489
		public static short ToInt16(string s)
		{
			return short.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0005F297 File Offset: 0x0005D497
		internal static Exception TryToInt16(string s, out short result)
		{
			if (!short.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Int16"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Int32" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>An <see langword="Int32" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x06000E66 RID: 3686 RVA: 0x0005F2CB File Offset: 0x0005D4CB
		public static int ToInt32(string s)
		{
			return int.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0005F2D9 File Offset: 0x0005D4D9
		internal static Exception TryToInt32(string s, out int result)
		{
			if (!int.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Int32"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Int64" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>An <see langword="Int64" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		// Token: 0x06000E68 RID: 3688 RVA: 0x0005F30D File Offset: 0x0005D50D
		public static long ToInt64(string s)
		{
			return long.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0005F31B File Offset: 0x0005D51B
		internal static Exception TryToInt64(string s, out long result)
		{
			if (!long.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Int64"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Byte" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="Byte" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x06000E6A RID: 3690 RVA: 0x0005F34F File Offset: 0x0005D54F
		public static byte ToByte(string s)
		{
			return byte.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0005F35D File Offset: 0x0005D55D
		internal static Exception TryToByte(string s, out byte result)
		{
			if (!byte.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Byte"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.UInt16" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="UInt16" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x06000E6C RID: 3692 RVA: 0x0005F391 File Offset: 0x0005D591
		[CLSCompliant(false)]
		public static ushort ToUInt16(string s)
		{
			return ushort.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0005F39F File Offset: 0x0005D59F
		internal static Exception TryToUInt16(string s, out ushort result)
		{
			if (!ushort.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"UInt16"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.UInt32" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="UInt32" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x06000E6E RID: 3694 RVA: 0x0005F3D3 File Offset: 0x0005D5D3
		[CLSCompliant(false)]
		public static uint ToUInt32(string s)
		{
			return uint.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0005F3E1 File Offset: 0x0005D5E1
		internal static Exception TryToUInt32(string s, out uint result)
		{
			if (!uint.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"UInt32"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.UInt64" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="UInt64" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		// Token: 0x06000E70 RID: 3696 RVA: 0x0005F415 File Offset: 0x0005D615
		[CLSCompliant(false)]
		public static ulong ToUInt64(string s)
		{
			return ulong.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0005F423 File Offset: 0x0005D623
		internal static Exception TryToUInt64(string s, out ulong result)
		{
			if (!ulong.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"UInt64"
				}));
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Single" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="Single" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception>
		// Token: 0x06000E72 RID: 3698 RVA: 0x0005F458 File Offset: 0x0005D658
		public static float ToSingle(string s)
		{
			s = XmlConvert.TrimString(s);
			if (s == "-INF")
			{
				return float.NegativeInfinity;
			}
			if (s == "INF")
			{
				return float.PositiveInfinity;
			}
			float num = float.Parse(s, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (num == 0f && s[0] == '-')
			{
				return --0f;
			}
			return num;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
		internal static Exception TryToSingle(string s, out float result)
		{
			s = XmlConvert.TrimString(s);
			if (s == "-INF")
			{
				result = float.NegativeInfinity;
				return null;
			}
			if (s == "INF")
			{
				result = float.PositiveInfinity;
				return null;
			}
			if (!float.TryParse(s, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Single"
				}));
			}
			if (result == 0f && s[0] == '-')
			{
				result = --0f;
			}
			return null;
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Double" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="Double" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
		// Token: 0x06000E74 RID: 3700 RVA: 0x0005F554 File Offset: 0x0005D754
		public static double ToDouble(string s)
		{
			s = XmlConvert.TrimString(s);
			if (s == "-INF")
			{
				return double.NegativeInfinity;
			}
			if (s == "INF")
			{
				return double.PositiveInfinity;
			}
			double num = double.Parse(s, NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			if (num == 0.0 && s[0] == '-')
			{
				return --0.0;
			}
			return num;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0005F5CC File Offset: 0x0005D7CC
		internal static Exception TryToDouble(string s, out double result)
		{
			s = XmlConvert.TrimString(s);
			if (s == "-INF")
			{
				result = double.NegativeInfinity;
				return null;
			}
			if (s == "INF")
			{
				result = double.PositiveInfinity;
				return null;
			}
			if (!double.TryParse(s, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Double"
				}));
			}
			if (result == 0.0 && s[0] == '-')
			{
				result = --0.0;
			}
			return null;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0005F670 File Offset: 0x0005D870
		internal static double ToXPathDouble(object o)
		{
			string text = o as string;
			if (text != null)
			{
				text = XmlConvert.TrimString(text);
				double result;
				if (text.Length != 0 && text[0] != '+' && double.TryParse(text, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result))
				{
					return result;
				}
				return double.NaN;
			}
			else
			{
				if (o is double)
				{
					return (double)o;
				}
				if (!(o is bool))
				{
					try
					{
						return Convert.ToDouble(o, NumberFormatInfo.InvariantInfo);
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					catch (ArgumentNullException)
					{
					}
					return double.NaN;
				}
				if (!(bool)o)
				{
					return 0.0;
				}
				return 1.0;
			}
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.TimeSpan" /> equivalent.</summary>
		/// <param name="s">The string to convert. The string format must conform to the W3C XML Schema Part 2: Datatypes recommendation for duration.</param>
		/// <returns>A <see langword="TimeSpan" /> equivalent of the string.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in correct format to represent a <see langword="TimeSpan" /> value. </exception>
		// Token: 0x06000E77 RID: 3703 RVA: 0x0005F73C File Offset: 0x0005D93C
		public static TimeSpan ToTimeSpan(string s)
		{
			XsdDuration xsdDuration;
			try
			{
				xsdDuration = new XsdDuration(s);
			}
			catch (Exception)
			{
				throw new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"TimeSpan"
				}));
			}
			return xsdDuration.ToTimeSpan();
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0005F78C File Offset: 0x0005D98C
		internal static Exception TryToTimeSpan(string s, out TimeSpan result)
		{
			XsdDuration xsdDuration;
			Exception ex = XsdDuration.TryParse(s, out xsdDuration);
			if (ex != null)
			{
				result = TimeSpan.MinValue;
				return ex;
			}
			return xsdDuration.TryToTimeSpan(out result);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0005F7BA File Offset: 0x0005D9BA
		private static string[] AllDateTimeFormats
		{
			get
			{
				if (XmlConvert.s_allDateTimeFormats == null)
				{
					XmlConvert.CreateAllDateTimeFormats();
				}
				return XmlConvert.s_allDateTimeFormats;
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
		private static void CreateAllDateTimeFormats()
		{
			if (XmlConvert.s_allDateTimeFormats == null)
			{
				XmlConvert.s_allDateTimeFormats = new string[]
				{
					"yyyy-MM-ddTHH:mm:ss.FFFFFFFzzzzzz",
					"yyyy-MM-ddTHH:mm:ss.FFFFFFF",
					"yyyy-MM-ddTHH:mm:ss.FFFFFFFZ",
					"HH:mm:ss.FFFFFFF",
					"HH:mm:ss.FFFFFFFZ",
					"HH:mm:ss.FFFFFFFzzzzzz",
					"yyyy-MM-dd",
					"yyyy-MM-ddZ",
					"yyyy-MM-ddzzzzzz",
					"yyyy-MM",
					"yyyy-MMZ",
					"yyyy-MMzzzzzz",
					"yyyy",
					"yyyyZ",
					"yyyyzzzzzz",
					"--MM-dd",
					"--MM-ddZ",
					"--MM-ddzzzzzz",
					"---dd",
					"---ddZ",
					"---ddzzzzzz",
					"--MM--",
					"--MM--Z",
					"--MM--zzzzzz"
				};
			}
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.DateTime" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="DateTime" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is an empty string or is not in the correct format. </exception>
		// Token: 0x06000E7B RID: 3707 RVA: 0x0005F8CA File Offset: 0x0005DACA
		public static DateTime ToDateTime(string s)
		{
			return XmlConvert.ToDateTime(s, XmlConvert.AllDateTimeFormats);
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.DateTime" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <param name="formats">An array containing the format structures to apply to the converted <see langword="DateTime" />. Valid formats include "yyyy-MM-ddTHH:mm:sszzzzzz" and its subsets. </param>
		/// <returns>A <see langword="DateTime" /> equivalent of the string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> or an element of <paramref name="formats" /> is String.Empty -or- 
		///         <paramref name="s" /> does not contain a date and time that corresponds to any of the elements of <paramref name="formats" />. </exception>
		// Token: 0x06000E7C RID: 3708 RVA: 0x0005F8D7 File Offset: 0x0005DAD7
		public static DateTime ToDateTime(string s, string[] formats)
		{
			return DateTime.ParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite);
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.DateTime" /> using the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> specified</summary>
		/// <param name="s">The <see cref="T:System.String" /> value to convert.</param>
		/// <param name="dateTimeOption">One of the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> values that specify whether the date should be converted to local time or preserved as Coordinated Universal Time (UTC), if it is a UTC date.</param>
		/// <returns>A <see cref="T:System.DateTime" /> equivalent of the <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.NullReferenceException">
		///         <paramref name="s" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="dateTimeOption" /> value is <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is an empty string or is not in a valid format.</exception>
		// Token: 0x06000E7D RID: 3709 RVA: 0x0005F8E8 File Offset: 0x0005DAE8
		public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption)
		{
			DateTime dateTime = new XsdDateTime(s, XsdDateTimeFlags.AllXsd);
			switch (dateTimeOption)
			{
			case XmlDateTimeSerializationMode.Local:
				dateTime = XmlConvert.SwitchToLocalTime(dateTime);
				break;
			case XmlDateTimeSerializationMode.Utc:
				dateTime = XmlConvert.SwitchToUtcTime(dateTime);
				break;
			case XmlDateTimeSerializationMode.Unspecified:
				dateTime = new DateTime(dateTime.Ticks, DateTimeKind.Unspecified);
				break;
			case XmlDateTimeSerializationMode.RoundtripKind:
				break;
			default:
				throw new ArgumentException(Res.GetString("The '{0}' value for the 'dateTimeOption' parameter is not an allowed value for the 'XmlDateTimeSerializationMode' enumeration.", new object[]
				{
					dateTimeOption,
					"dateTimeOption"
				}));
			}
			return dateTime;
		}

		/// <summary>Converts the supplied <see cref="T:System.String" /> to a <see cref="T:System.DateTimeOffset" /> equivalent.</summary>
		/// <param name="s">The string to convert.
		///       Note   The string must conform to a subset of the W3C Recommendation for the XML dateTime type. For more information see http://www.w3.org/TR/xmlschema-2/#dateTime.</param>
		/// <returns>The <see cref="T:System.DateTimeOffset" /> equivalent of the supplied string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The argument passed to this method is outside the range of allowable values. For information about allowable values, see <see cref="T:System.DateTimeOffset" />.</exception>
		/// <exception cref="T:System.FormatException">The argument passed to this method does not conform to a subset of the W3C Recommendations for the XML dateTime type. For more information see http://www.w3.org/TR/xmlschema-2/#dateTime.</exception>
		// Token: 0x06000E7E RID: 3710 RVA: 0x0005F969 File Offset: 0x0005DB69
		public static DateTimeOffset ToDateTimeOffset(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return new XsdDateTime(s, XsdDateTimeFlags.AllXsd);
		}

		/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Guid" /> equivalent.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>A <see langword="Guid" /> equivalent of the string.</returns>
		// Token: 0x06000E7F RID: 3711 RVA: 0x0005F989 File Offset: 0x0005DB89
		public static Guid ToGuid(string s)
		{
			return new Guid(s);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0005F994 File Offset: 0x0005DB94
		internal static Exception TryToGuid(string s, out Guid result)
		{
			Exception result2 = null;
			result = Guid.Empty;
			try
			{
				result = new Guid(s);
			}
			catch (ArgumentException)
			{
				result2 = new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Guid"
				}));
			}
			catch (FormatException)
			{
				result2 = new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Guid"
				}));
			}
			return result2;
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0005FA24 File Offset: 0x0005DC24
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			switch (value.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(value.Ticks, DateTimeKind.Local);
			case DateTimeKind.Utc:
				return value.ToLocalTime();
			case DateTimeKind.Local:
				return value;
			default:
				return value;
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0005FA68 File Offset: 0x0005DC68
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			switch (value.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(value.Ticks, DateTimeKind.Utc);
			case DateTimeKind.Utc:
				return value;
			case DateTimeKind.Local:
				return value.ToUniversalTime();
			default:
				return value;
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0005FAAC File Offset: 0x0005DCAC
		internal static Uri ToUri(string s)
		{
			if (s != null && s.Length > 0)
			{
				s = XmlConvert.TrimString(s);
				if (s.Length == 0 || s.IndexOf("##", StringComparison.Ordinal) != -1)
				{
					throw new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
					{
						s,
						"Uri"
					}));
				}
			}
			Uri result;
			if (!Uri.TryCreate(s, UriKind.RelativeOrAbsolute, out result))
			{
				throw new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Uri"
				}));
			}
			return result;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0005FB34 File Offset: 0x0005DD34
		internal static Exception TryToUri(string s, out Uri result)
		{
			result = null;
			if (s != null && s.Length > 0)
			{
				s = XmlConvert.TrimString(s);
				if (s.Length == 0 || s.IndexOf("##", StringComparison.Ordinal) != -1)
				{
					return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
					{
						s,
						"Uri"
					}));
				}
			}
			if (!Uri.TryCreate(s, UriKind.RelativeOrAbsolute, out result))
			{
				return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					s,
					"Uri"
				}));
			}
			return null;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0005FBC0 File Offset: 0x0005DDC0
		internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2)
		{
			if (strLen1 != str2.Length)
			{
				return false;
			}
			int num = 0;
			while (num < strLen1 && chars[strPos1 + num] == str2[num])
			{
				num++;
			}
			return num == strLen1;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0005FBF6 File Offset: 0x0005DDF6
		internal static string TrimString(string value)
		{
			return value.Trim(XmlConvert.WhitespaceChars);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0005FC03 File Offset: 0x0005DE03
		internal static string TrimStringStart(string value)
		{
			return value.TrimStart(XmlConvert.WhitespaceChars);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0005FC10 File Offset: 0x0005DE10
		internal static string TrimStringEnd(string value)
		{
			return value.TrimEnd(XmlConvert.WhitespaceChars);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0005FC1D File Offset: 0x0005DE1D
		internal static string[] SplitString(string value)
		{
			return value.Split(XmlConvert.WhitespaceChars, StringSplitOptions.RemoveEmptyEntries);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0005FC2B File Offset: 0x0005DE2B
		internal static bool IsNegativeZero(double value)
		{
			return value == 0.0 && XmlConvert.DoubleToInt64Bits(value) == XmlConvert.DoubleToInt64Bits(--0.0);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0005FC52 File Offset: 0x0005DE52
		private unsafe static long DoubleToInt64Bits(double value)
		{
			return *(long*)(&value);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0005FC58 File Offset: 0x0005DE58
		internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType)
		{
			if (data == null || data.Length == 0)
			{
				return;
			}
			int num = 0;
			int length = data.Length;
			for (;;)
			{
				if (num >= length || (XmlConvert.xmlCharType.charProperties[(int)data[num]] & 16) == 0)
				{
					if (num == length)
					{
						break;
					}
					if (!XmlCharType.IsHighSurrogate((int)data[num]))
					{
						goto IL_90;
					}
					if (num + 1 == length)
					{
						goto Block_5;
					}
					if (!XmlCharType.IsLowSurrogate((int)data[num + 1]))
					{
						goto IL_75;
					}
					num += 2;
				}
				else
				{
					num++;
				}
			}
			return;
			Block_5:
			throw XmlConvert.CreateException("The surrogate pair is invalid. Missing a low surrogate character.", invSurrogateExceptionType, 0, num + 1);
			IL_75:
			throw XmlConvert.CreateInvalidSurrogatePairException(data[num + 1], data[num], invSurrogateExceptionType, 0, num + 1);
			IL_90:
			throw XmlConvert.CreateInvalidCharException(data, num, invCharExceptionType);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0005FCFD File Offset: 0x0005DEFD
		internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos)
		{
			if (exceptionType != ExceptionType.ArgumentException)
			{
				if (exceptionType != ExceptionType.XmlException)
				{
				}
				return new XmlException(res, string.Empty, lineNo, linePos);
			}
			return new ArgumentException(Res.GetString(res));
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0005FD21 File Offset: 0x0005DF21
		internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos)
		{
			if (exceptionType != ExceptionType.ArgumentException)
			{
				if (exceptionType != ExceptionType.XmlException)
				{
				}
				return new XmlException(res, arg, lineNo, linePos);
			}
			return new ArgumentException(Res.GetString(res, new object[]
			{
				arg
			}));
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0005FD4C File Offset: 0x0005DF4C
		internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType)
		{
			return XmlConvert.CreateException(res, args, exceptionType, 0, 0);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0005FD58 File Offset: 0x0005DF58
		internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos)
		{
			if (exceptionType != ExceptionType.ArgumentException)
			{
				if (exceptionType != ExceptionType.XmlException)
				{
				}
				return new XmlException(res, args, lineNo, linePos);
			}
			return new ArgumentException(Res.GetString(res, args));
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0005FD87 File Offset: 0x0005DF87
		internal static Exception CreateInvalidSurrogatePairException(char low, char hi)
		{
			return XmlConvert.CreateInvalidSurrogatePairException(low, hi, ExceptionType.ArgumentException);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0005FD91 File Offset: 0x0005DF91
		internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType)
		{
			return XmlConvert.CreateInvalidSurrogatePairException(low, hi, exceptionType, 0, 0);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0005FDA0 File Offset: 0x0005DFA0
		internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			string[] array = new string[2];
			int num = 0;
			uint num2 = (uint)hi;
			array[num] = num2.ToString("X", CultureInfo.InvariantCulture);
			int num3 = 1;
			num2 = (uint)low;
			array[num3] = num2.ToString("X", CultureInfo.InvariantCulture);
			string[] args = array;
			return XmlConvert.CreateException("The surrogate pair (0x{0}, 0x{1}) is invalid. A high surrogate character (0xD800 - 0xDBFF) must always be paired with a low surrogate character (0xDC00 - 0xDFFF).", args, exceptionType, lineNo, linePos);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0005FDEF File Offset: 0x0005DFEF
		internal static Exception CreateInvalidHighSurrogateCharException(char hi)
		{
			return XmlConvert.CreateInvalidHighSurrogateCharException(hi, ExceptionType.ArgumentException);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0005FDF8 File Offset: 0x0005DFF8
		internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType)
		{
			return XmlConvert.CreateInvalidHighSurrogateCharException(hi, exceptionType, 0, 0);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0005FE04 File Offset: 0x0005E004
		internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			string res = "Invalid high surrogate character (0x{0}). A high surrogate character must have a value from range (0xD800 - 0xDBFF).";
			uint num = (uint)hi;
			return XmlConvert.CreateException(res, num.ToString("X", CultureInfo.InvariantCulture), exceptionType, lineNo, linePos);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0005FE31 File Offset: 0x0005E031
		internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType)
		{
			return XmlConvert.CreateException("'{0}', hexadecimal value {1}, is an invalid character.", XmlException.BuildCharExceptionArgs(data, invCharPos), exceptionType, 0, invCharPos + 1);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0005FE49 File Offset: 0x0005E049
		internal static Exception CreateInvalidCharException(char invChar, char nextChar)
		{
			return XmlConvert.CreateInvalidCharException(invChar, nextChar, ExceptionType.ArgumentException);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0005FE53 File Offset: 0x0005E053
		internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType)
		{
			return XmlConvert.CreateException("'{0}', hexadecimal value {1}, is an invalid character.", XmlException.BuildCharExceptionArgs(invChar, nextChar), exceptionType);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0005FE67 File Offset: 0x0005E067
		internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
		{
			return XmlConvert.CreateException((index == 0) ? "Name cannot begin with the '{0}' character, hexadecimal value {1}." : "The '{0}' character, hexadecimal value {1}, cannot be included in a name.", XmlException.BuildCharExceptionArgs(name, index), exceptionType, 0, index + 1);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0005FE89 File Offset: 0x0005E089
		internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
		{
			if (name != null)
			{
				return new ArgumentException(Res.GetString("The empty string '' is not a valid name."), argumentName);
			}
			return new ArgumentNullException(argumentName);
		}

		// Token: 0x04000AA1 RID: 2721
		private static XmlCharType xmlCharType = XmlCharType.Instance;

		// Token: 0x04000AA2 RID: 2722
		internal static char[] crt = new char[]
		{
			'\n',
			'\r',
			'\t'
		};

		// Token: 0x04000AA3 RID: 2723
		private static readonly int c_EncodedCharLength = 7;

		// Token: 0x04000AA4 RID: 2724
		private static volatile Regex c_EncodeCharPattern;

		// Token: 0x04000AA5 RID: 2725
		private static volatile Regex c_DecodeCharPattern;

		// Token: 0x04000AA6 RID: 2726
		private static volatile string[] s_allDateTimeFormats;

		// Token: 0x04000AA7 RID: 2727
		internal static readonly char[] WhitespaceChars = new char[]
		{
			' ',
			'\t',
			'\n',
			'\r'
		};
	}
}
