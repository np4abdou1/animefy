using System;
using System.Globalization;
using System.Text;

namespace System.Xml.Serialization
{
	// Token: 0x020001E5 RID: 485
	internal class XmlCustomFormatter
	{
		// Token: 0x0600100E RID: 4110 RVA: 0x00065174 File Offset: 0x00063374
		internal static string FromEnum(long value, string[] values, long[] ids, string typeName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = ids.Length;
			long num2 = value;
			int num3 = -1;
			for (int i = 0; i < num; i++)
			{
				if (ids[i] == 0L)
				{
					num3 = i;
				}
				else
				{
					if (num2 == 0L)
					{
						break;
					}
					if ((ids[i] & value) == ids[i])
					{
						if (stringBuilder.Length != 0)
						{
							stringBuilder.Append(' ');
						}
						stringBuilder.Append(values[i]);
						num2 &= ~ids[i];
					}
				}
			}
			if (num2 == 0L)
			{
				if (stringBuilder.Length == 0 && num3 != -1)
				{
					stringBuilder.Append(values[num3]);
				}
				return stringBuilder.ToString();
			}
			if (typeName != null)
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "'{0}' is not a valid value for {1}.", value, typeName));
			}
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "'{0}' is not a valid value.", value));
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00065236 File Offset: 0x00063436
		internal static string FromXmlName(string name)
		{
			return XmlConvert.EncodeName(name);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0006523E File Offset: 0x0006343E
		internal static string FromXmlNCName(string ncName)
		{
			return XmlConvert.EncodeLocalName(ncName);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00065248 File Offset: 0x00063448
		internal static string ToXmlString(TypeData type, object value)
		{
			if (value == null)
			{
				return null;
			}
			string xmlType = type.XmlType;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(xmlType);
			if (num <= 1683620383U)
			{
				if (num <= 1042916651U)
				{
					if (num <= 735213196U)
					{
						if (num != 520654156U)
						{
							if (num != 735213196U)
							{
								goto IL_428;
							}
							if (!(xmlType == "unsignedByte"))
							{
								goto IL_428;
							}
							return XmlConvert.ToString((byte)value);
						}
						else
						{
							if (!(xmlType == "decimal"))
							{
								goto IL_428;
							}
							return XmlConvert.ToString((decimal)value);
						}
					}
					else if (num != 748388108U)
					{
						if (num != 799079693U)
						{
							if (num != 1042916651U)
							{
								goto IL_428;
							}
							if (!(xmlType == "hexBinary"))
							{
								goto IL_428;
							}
							if (value != null)
							{
								return XmlConvert.ToBinHexString((byte[])value);
							}
							return string.Empty;
						}
						else
						{
							if (!(xmlType == "duration"))
							{
								goto IL_428;
							}
							return (string)value;
						}
					}
					else
					{
						if (!(xmlType == "guid"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((Guid)value);
					}
				}
				else if (num <= 1412591975U)
				{
					if (num != 1293334960U)
					{
						if (num != 1412591975U)
						{
							goto IL_428;
						}
						if (!(xmlType == "unsignedInt"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((uint)value);
					}
					else
					{
						if (!(xmlType == "dateTime"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.RoundtripKind);
					}
				}
				else if (num != 1467875291U)
				{
					if (num != 1564253156U)
					{
						if (num != 1683620383U)
						{
							goto IL_428;
						}
						if (!(xmlType == "byte"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((sbyte)value);
					}
					else
					{
						if (!(xmlType == "time"))
						{
							goto IL_428;
						}
						return ((DateTime)value).ToString("HH:mm:ss.FFFFFFF", CultureInfo.InvariantCulture);
					}
				}
				else if (!(xmlType == "base64Binary"))
				{
					goto IL_428;
				}
			}
			else if (num <= 2699759368U)
			{
				if (num <= 2282863728U)
				{
					if (num != 1710517951U)
					{
						if (num != 2282863728U)
						{
							goto IL_428;
						}
						if (!(xmlType == "unsignedLong"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((ulong)value);
					}
					else
					{
						if (!(xmlType == "boolean"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((bool)value);
					}
				}
				else if (num != 2515107422U)
				{
					if (num != 2673764304U)
					{
						if (num != 2699759368U)
						{
							goto IL_428;
						}
						if (!(xmlType == "double"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((double)value);
					}
					else
					{
						if (!(xmlType == "unsignedShort"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((ushort)value);
					}
				}
				else
				{
					if (!(xmlType == "int"))
					{
						goto IL_428;
					}
					return XmlConvert.ToString((int)value);
				}
			}
			else if (num <= 3122818005U)
			{
				if (num != 2797886853U)
				{
					if (num != 2823553821U)
					{
						if (num != 3122818005U)
						{
							goto IL_428;
						}
						if (!(xmlType == "short"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((short)value);
					}
					else
					{
						if (!(xmlType == "char"))
						{
							goto IL_428;
						}
						return XmlConvert.ToString((int)((char)value));
					}
				}
				else
				{
					if (!(xmlType == "float"))
					{
						goto IL_428;
					}
					return XmlConvert.ToString((float)value);
				}
			}
			else if (num != 3270303571U)
			{
				if (num != 3564297305U)
				{
					if (num != 4031671994U)
					{
						goto IL_428;
					}
					if (!(xmlType == "base64"))
					{
						goto IL_428;
					}
				}
				else
				{
					if (!(xmlType == "date"))
					{
						goto IL_428;
					}
					return ((DateTime)value).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
				}
			}
			else
			{
				if (!(xmlType == "long"))
				{
					goto IL_428;
				}
				return XmlConvert.ToString((long)value);
			}
			if (value != null)
			{
				return Convert.ToBase64String((byte[])value);
			}
			return string.Empty;
			IL_428:
			if (!(value is IFormattable))
			{
				return value.ToString();
			}
			return ((IFormattable)value).ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000656A0 File Offset: 0x000638A0
		internal static object FromXmlString(TypeData type, string value)
		{
			if (value == null)
			{
				return null;
			}
			string xmlType = type.XmlType;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(xmlType);
			if (num <= 1683620383U)
			{
				if (num <= 1042916651U)
				{
					if (num <= 735213196U)
					{
						if (num != 520654156U)
						{
							if (num != 735213196U)
							{
								goto IL_405;
							}
							if (!(xmlType == "unsignedByte"))
							{
								goto IL_405;
							}
							return XmlConvert.ToByte(value);
						}
						else
						{
							if (!(xmlType == "decimal"))
							{
								goto IL_405;
							}
							return XmlConvert.ToDecimal(value);
						}
					}
					else if (num != 748388108U)
					{
						if (num != 799079693U)
						{
							if (num != 1042916651U)
							{
								goto IL_405;
							}
							if (!(xmlType == "hexBinary"))
							{
								goto IL_405;
							}
							return XmlConvert.FromBinHexString(value);
						}
						else
						{
							if (!(xmlType == "duration"))
							{
								goto IL_405;
							}
							return value;
						}
					}
					else
					{
						if (!(xmlType == "guid"))
						{
							goto IL_405;
						}
						return XmlConvert.ToGuid(value);
					}
				}
				else if (num <= 1412591975U)
				{
					if (num != 1293334960U)
					{
						if (num != 1412591975U)
						{
							goto IL_405;
						}
						if (!(xmlType == "unsignedInt"))
						{
							goto IL_405;
						}
						return XmlConvert.ToUInt32(value);
					}
					else
					{
						if (!(xmlType == "dateTime"))
						{
							goto IL_405;
						}
						return XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.RoundtripKind);
					}
				}
				else if (num != 1467875291U)
				{
					if (num != 1564253156U)
					{
						if (num != 1683620383U)
						{
							goto IL_405;
						}
						if (!(xmlType == "byte"))
						{
							goto IL_405;
						}
						return XmlConvert.ToSByte(value);
					}
					else
					{
						if (!(xmlType == "time"))
						{
							goto IL_405;
						}
						return DateTime.ParseExact(value, XmlCustomFormatter.allTimeFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.RoundtripKind);
					}
				}
				else if (!(xmlType == "base64Binary"))
				{
					goto IL_405;
				}
			}
			else if (num <= 2699759368U)
			{
				if (num <= 2282863728U)
				{
					if (num != 1710517951U)
					{
						if (num != 2282863728U)
						{
							goto IL_405;
						}
						if (!(xmlType == "unsignedLong"))
						{
							goto IL_405;
						}
						return XmlConvert.ToUInt64(value);
					}
					else
					{
						if (!(xmlType == "boolean"))
						{
							goto IL_405;
						}
						return XmlConvert.ToBoolean(value);
					}
				}
				else if (num != 2515107422U)
				{
					if (num != 2673764304U)
					{
						if (num != 2699759368U)
						{
							goto IL_405;
						}
						if (!(xmlType == "double"))
						{
							goto IL_405;
						}
						return XmlConvert.ToDouble(value);
					}
					else
					{
						if (!(xmlType == "unsignedShort"))
						{
							goto IL_405;
						}
						return XmlConvert.ToUInt16(value);
					}
				}
				else
				{
					if (!(xmlType == "int"))
					{
						goto IL_405;
					}
					return XmlConvert.ToInt32(value);
				}
			}
			else if (num <= 3122818005U)
			{
				if (num != 2797886853U)
				{
					if (num != 2823553821U)
					{
						if (num != 3122818005U)
						{
							goto IL_405;
						}
						if (!(xmlType == "short"))
						{
							goto IL_405;
						}
						return XmlConvert.ToInt16(value);
					}
					else
					{
						if (!(xmlType == "char"))
						{
							goto IL_405;
						}
						return (char)XmlConvert.ToInt32(value);
					}
				}
				else
				{
					if (!(xmlType == "float"))
					{
						goto IL_405;
					}
					return XmlConvert.ToSingle(value);
				}
			}
			else if (num != 3270303571U)
			{
				if (num != 3564297305U)
				{
					if (num != 4031671994U)
					{
						goto IL_405;
					}
					if (!(xmlType == "base64"))
					{
						goto IL_405;
					}
				}
				else
				{
					if (!(xmlType == "date"))
					{
						goto IL_405;
					}
					return XmlConvert.ToDateTime(value).Date;
				}
			}
			else
			{
				if (!(xmlType == "long"))
				{
					goto IL_405;
				}
				return XmlConvert.ToInt64(value);
			}
			return Convert.FromBase64String(value);
			IL_405:
			if (type.Type != null)
			{
				return Convert.ChangeType(value, type.Type, null);
			}
			return value;
		}

		// Token: 0x04000B6B RID: 2923
		private static string[] allTimeFormats = new string[]
		{
			"HH:mm:ss.fffffffzzzzzz",
			"HH:mm:ss",
			"HH:mm:ss.f",
			"HH:mm:ss.ff",
			"HH:mm:ss.fff",
			"HH:mm:ss.ffff",
			"HH:mm:ss.fffff",
			"HH:mm:ss.ffffff",
			"HH:mm:ss.fffffff",
			"HH:mm:ssZ",
			"HH:mm:ss.fZ",
			"HH:mm:ss.ffZ",
			"HH:mm:ss.fffZ",
			"HH:mm:ss.ffffZ",
			"HH:mm:ss.fffffZ",
			"HH:mm:ss.ffffffZ",
			"HH:mm:ss.fffffffZ",
			"HH:mm:sszzzzzz",
			"HH:mm:ss.fzzzzzz",
			"HH:mm:ss.ffzzzzzz",
			"HH:mm:ss.fffzzzzzz",
			"HH:mm:ss.ffffzzzzzz",
			"HH:mm:ss.fffffzzzzzz",
			"HH:mm:ss.ffffffzzzzzz"
		};
	}
}
