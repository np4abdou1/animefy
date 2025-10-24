using System;
using System.Collections;
using System.Xml.XPath;

namespace System.Xml.Schema
{
	// Token: 0x0200032D RID: 813
	internal abstract class XmlBaseConverter : XmlValueConverter
	{
		// Token: 0x06001B43 RID: 6979 RVA: 0x0009EAF0 File Offset: 0x0009CCF0
		protected XmlBaseConverter(XmlSchemaType schemaType)
		{
			XmlSchemaDatatype datatype = schemaType.Datatype;
			while (schemaType != null && !(schemaType is XmlSchemaSimpleType))
			{
				schemaType = schemaType.BaseXmlSchemaType;
			}
			if (schemaType == null)
			{
				schemaType = XmlSchemaType.GetBuiltInSimpleType(datatype.TypeCode);
			}
			this.schemaType = schemaType;
			this.typeCode = schemaType.TypeCode;
			this.clrTypeDefault = schemaType.Datatype.ValueType;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0009EB54 File Offset: 0x0009CD54
		protected XmlBaseConverter(XmlTypeCode typeCode)
		{
			if (typeCode != XmlTypeCode.Item)
			{
				if (typeCode != XmlTypeCode.Node)
				{
					if (typeCode == XmlTypeCode.AnyAtomicType)
					{
						this.clrTypeDefault = XmlBaseConverter.XmlAtomicValueType;
					}
				}
				else
				{
					this.clrTypeDefault = XmlBaseConverter.XPathNavigatorType;
				}
			}
			else
			{
				this.clrTypeDefault = XmlBaseConverter.XPathItemType;
			}
			this.typeCode = typeCode;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0009EBA2 File Offset: 0x0009CDA2
		protected XmlBaseConverter(XmlBaseConverter converterAtomic)
		{
			this.schemaType = converterAtomic.schemaType;
			this.typeCode = converterAtomic.typeCode;
			this.clrTypeDefault = Array.CreateInstance(converterAtomic.DefaultClrType, 0).GetType();
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0009EBD9 File Offset: 0x0009CDD9
		protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault)
		{
			this.schemaType = converterAtomic.schemaType;
			this.typeCode = converterAtomic.typeCode;
			this.clrTypeDefault = clrTypeDefault;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0009EC00 File Offset: 0x0009CE00
		public override bool ToBoolean(DateTime value)
		{
			return (bool)this.ChangeType(value, XmlBaseConverter.BooleanType, null);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0009EC19 File Offset: 0x0009CE19
		public override bool ToBoolean(double value)
		{
			return (bool)this.ChangeType(value, XmlBaseConverter.BooleanType, null);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0009EC32 File Offset: 0x0009CE32
		public override bool ToBoolean(int value)
		{
			return (bool)this.ChangeType(value, XmlBaseConverter.BooleanType, null);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0009EC4B File Offset: 0x0009CE4B
		public override bool ToBoolean(long value)
		{
			return (bool)this.ChangeType(value, XmlBaseConverter.BooleanType, null);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0009EC64 File Offset: 0x0009CE64
		public override bool ToBoolean(string value)
		{
			return (bool)this.ChangeType(value, XmlBaseConverter.BooleanType, null);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0009EC64 File Offset: 0x0009CE64
		public override bool ToBoolean(object value)
		{
			return (bool)this.ChangeType(value, XmlBaseConverter.BooleanType, null);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0009EC78 File Offset: 0x0009CE78
		public override DateTime ToDateTime(bool value)
		{
			return (DateTime)this.ChangeType(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0009EC91 File Offset: 0x0009CE91
		public override DateTime ToDateTime(DateTimeOffset value)
		{
			return (DateTime)this.ChangeType(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0009ECAA File Offset: 0x0009CEAA
		public override DateTime ToDateTime(double value)
		{
			return (DateTime)this.ChangeType(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0009ECC3 File Offset: 0x0009CEC3
		public override DateTime ToDateTime(int value)
		{
			return (DateTime)this.ChangeType(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0009ECDC File Offset: 0x0009CEDC
		public override DateTime ToDateTime(long value)
		{
			return (DateTime)this.ChangeType(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0009ECF5 File Offset: 0x0009CEF5
		public override DateTime ToDateTime(string value)
		{
			return (DateTime)this.ChangeType(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0009ECF5 File Offset: 0x0009CEF5
		public override DateTime ToDateTime(object value)
		{
			return (DateTime)this.ChangeType(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0009ED09 File Offset: 0x0009CF09
		public override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			return (DateTimeOffset)this.ChangeType(value, XmlBaseConverter.DateTimeOffsetType, null);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0009ED22 File Offset: 0x0009CF22
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			return (DateTimeOffset)this.ChangeType(value, XmlBaseConverter.DateTimeOffsetType, null);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0009ED22 File Offset: 0x0009CF22
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			return (DateTimeOffset)this.ChangeType(value, XmlBaseConverter.DateTimeOffsetType, null);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0009ED36 File Offset: 0x0009CF36
		public override decimal ToDecimal(string value)
		{
			return (decimal)this.ChangeType(value, XmlBaseConverter.DecimalType, null);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0009ED36 File Offset: 0x0009CF36
		public override decimal ToDecimal(object value)
		{
			return (decimal)this.ChangeType(value, XmlBaseConverter.DecimalType, null);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0009ED4A File Offset: 0x0009CF4A
		public override double ToDouble(bool value)
		{
			return (double)this.ChangeType(value, XmlBaseConverter.DoubleType, null);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0009ED63 File Offset: 0x0009CF63
		public override double ToDouble(DateTime value)
		{
			return (double)this.ChangeType(value, XmlBaseConverter.DoubleType, null);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0009ED7C File Offset: 0x0009CF7C
		public override double ToDouble(int value)
		{
			return (double)this.ChangeType(value, XmlBaseConverter.DoubleType, null);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0009ED95 File Offset: 0x0009CF95
		public override double ToDouble(long value)
		{
			return (double)this.ChangeType(value, XmlBaseConverter.DoubleType, null);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0009EDAE File Offset: 0x0009CFAE
		public override double ToDouble(string value)
		{
			return (double)this.ChangeType(value, XmlBaseConverter.DoubleType, null);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0009EDAE File Offset: 0x0009CFAE
		public override double ToDouble(object value)
		{
			return (double)this.ChangeType(value, XmlBaseConverter.DoubleType, null);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0009EDC2 File Offset: 0x0009CFC2
		public override int ToInt32(bool value)
		{
			return (int)this.ChangeType(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0009EDDB File Offset: 0x0009CFDB
		public override int ToInt32(DateTime value)
		{
			return (int)this.ChangeType(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0009EDF4 File Offset: 0x0009CFF4
		public override int ToInt32(double value)
		{
			return (int)this.ChangeType(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0009EE0D File Offset: 0x0009D00D
		public override int ToInt32(long value)
		{
			return (int)this.ChangeType(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0009EE26 File Offset: 0x0009D026
		public override int ToInt32(string value)
		{
			return (int)this.ChangeType(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0009EE26 File Offset: 0x0009D026
		public override int ToInt32(object value)
		{
			return (int)this.ChangeType(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0009EE3A File Offset: 0x0009D03A
		public override long ToInt64(bool value)
		{
			return (long)this.ChangeType(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0009EE53 File Offset: 0x0009D053
		public override long ToInt64(DateTime value)
		{
			return (long)this.ChangeType(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0009EE6C File Offset: 0x0009D06C
		public override long ToInt64(double value)
		{
			return (long)this.ChangeType(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0009EE85 File Offset: 0x0009D085
		public override long ToInt64(int value)
		{
			return (long)this.ChangeType(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0009EE9E File Offset: 0x0009D09E
		public override long ToInt64(string value)
		{
			return (long)this.ChangeType(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0009EE9E File Offset: 0x0009D09E
		public override long ToInt64(object value)
		{
			return (long)this.ChangeType(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0009EEB2 File Offset: 0x0009D0B2
		public override float ToSingle(double value)
		{
			return (float)this.ChangeType(value, XmlBaseConverter.SingleType, null);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0009EECB File Offset: 0x0009D0CB
		public override float ToSingle(string value)
		{
			return (float)this.ChangeType(value, XmlBaseConverter.SingleType, null);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0009EECB File Offset: 0x0009D0CB
		public override float ToSingle(object value)
		{
			return (float)this.ChangeType(value, XmlBaseConverter.SingleType, null);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0009EEDF File Offset: 0x0009D0DF
		public override string ToString(bool value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
		public override string ToString(DateTime value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0009EF11 File Offset: 0x0009D111
		public override string ToString(DateTimeOffset value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0009EF2A File Offset: 0x0009D12A
		public override string ToString(decimal value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0009EF43 File Offset: 0x0009D143
		public override string ToString(double value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0009EF5C File Offset: 0x0009D15C
		public override string ToString(int value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0009EF75 File Offset: 0x0009D175
		public override string ToString(long value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0009EF8E File Offset: 0x0009D18E
		public override string ToString(float value)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, null);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0009EFA7 File Offset: 0x0009D1A7
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			return (string)this.ChangeType(value, XmlBaseConverter.StringType, nsResolver);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0009EFBB File Offset: 0x0009D1BB
		public override string ToString(object value)
		{
			return this.ToString(value, null);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0009EFC5 File Offset: 0x0009D1C5
		public override object ChangeType(bool value, Type destinationType)
		{
			return this.ChangeType(value, destinationType, null);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0009EFD5 File Offset: 0x0009D1D5
		public override object ChangeType(DateTime value, Type destinationType)
		{
			return this.ChangeType(value, destinationType, null);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0009EFE5 File Offset: 0x0009D1E5
		public override object ChangeType(decimal value, Type destinationType)
		{
			return this.ChangeType(value, destinationType, null);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0009EFF5 File Offset: 0x0009D1F5
		public override object ChangeType(double value, Type destinationType)
		{
			return this.ChangeType(value, destinationType, null);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0009F005 File Offset: 0x0009D205
		public override object ChangeType(int value, Type destinationType)
		{
			return this.ChangeType(value, destinationType, null);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0009F015 File Offset: 0x0009D215
		public override object ChangeType(long value, Type destinationType)
		{
			return this.ChangeType(value, destinationType, null);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0009F025 File Offset: 0x0009D225
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return this.ChangeType(value, destinationType, nsResolver);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0009F030 File Offset: 0x0009D230
		public override object ChangeType(object value, Type destinationType)
		{
			return this.ChangeType(value, destinationType, null);
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x0009F03B File Offset: 0x0009D23B
		protected XmlSchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0009F043 File Offset: 0x0009D243
		protected XmlTypeCode TypeCode
		{
			get
			{
				return this.typeCode;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0009F04C File Offset: 0x0009D24C
		protected string XmlTypeName
		{
			get
			{
				XmlSchemaType baseXmlSchemaType = this.schemaType;
				if (baseXmlSchemaType != null)
				{
					while (baseXmlSchemaType.QualifiedName.IsEmpty)
					{
						baseXmlSchemaType = baseXmlSchemaType.BaseXmlSchemaType;
					}
					return XmlBaseConverter.QNameToString(baseXmlSchemaType.QualifiedName);
				}
				if (this.typeCode == XmlTypeCode.Node)
				{
					return "node";
				}
				if (this.typeCode == XmlTypeCode.AnyAtomicType)
				{
					return "xdt:anyAtomicType";
				}
				return "item";
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0009F0A9 File Offset: 0x0009D2A9
		protected Type DefaultClrType
		{
			get
			{
				return this.clrTypeDefault;
			}
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0009F0B1 File Offset: 0x0009D2B1
		protected static bool IsDerivedFrom(Type derivedType, Type baseType)
		{
			while (derivedType != null)
			{
				if (derivedType == baseType)
				{
					return true;
				}
				derivedType = derivedType.BaseType;
			}
			return false;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0009F0D4 File Offset: 0x0009D2D4
		protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			if (sourceType == destinationType)
			{
				return new InvalidCastException(Res.GetString("Xml type '{0}' does not support Clr type '{1}'.", new object[]
				{
					this.XmlTypeName,
					sourceType.Name
				}));
			}
			return new InvalidCastException(Res.GetString("Xml type '{0}' does not support a conversion from Clr type '{1}' to Clr type '{2}'.", new object[]
			{
				this.XmlTypeName,
				sourceType.Name,
				destinationType.Name
			}));
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0009F144 File Offset: 0x0009D344
		protected static string QNameToString(XmlQualifiedName name)
		{
			if (name.Namespace.Length == 0)
			{
				return name.Name;
			}
			if (name.Namespace == "http://www.w3.org/2001/XMLSchema")
			{
				return "xs:" + name.Name;
			}
			if (name.Namespace == "http://www.w3.org/2003/11/xpath-datatypes")
			{
				return "xdt:" + name.Name;
			}
			return "{" + name.Namespace + "}" + name.Name;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0009F1C6 File Offset: 0x0009D3C6
		protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw this.CreateInvalidClrMappingException(value.GetType(), destinationType);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0009F1D5 File Offset: 0x0009D3D5
		protected static byte[] StringToBase64Binary(string value)
		{
			return Convert.FromBase64String(XmlConvert.TrimString(value));
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0009F1E2 File Offset: 0x0009D3E2
		protected static DateTime StringToDate(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Date);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0009F1F0 File Offset: 0x0009D3F0
		protected static DateTime StringToDateTime(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.DateTime);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0009F200 File Offset: 0x0009D400
		protected static TimeSpan StringToDayTimeDuration(string value)
		{
			return new XsdDuration(value, XsdDuration.DurationType.DayTimeDuration).ToTimeSpan(XsdDuration.DurationType.DayTimeDuration);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0009F220 File Offset: 0x0009D420
		protected static TimeSpan StringToDuration(string value)
		{
			return new XsdDuration(value, XsdDuration.DurationType.Duration).ToTimeSpan(XsdDuration.DurationType.Duration);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0009F23D File Offset: 0x0009D43D
		protected static DateTime StringToGDay(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GDay);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0009F24C File Offset: 0x0009D44C
		protected static DateTime StringToGMonth(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonth);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0009F25E File Offset: 0x0009D45E
		protected static DateTime StringToGMonthDay(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonthDay);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0009F26D File Offset: 0x0009D46D
		protected static DateTime StringToGYear(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYear);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0009F27C File Offset: 0x0009D47C
		protected static DateTime StringToGYearMonth(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYearMonth);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0009F28A File Offset: 0x0009D48A
		protected static DateTimeOffset StringToDateOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Date);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0009F298 File Offset: 0x0009D498
		protected static DateTimeOffset StringToDateTimeOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.DateTime);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0009F2A6 File Offset: 0x0009D4A6
		protected static DateTimeOffset StringToGDayOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GDay);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0009F2B5 File Offset: 0x0009D4B5
		protected static DateTimeOffset StringToGMonthOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonth);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0009F2C7 File Offset: 0x0009D4C7
		protected static DateTimeOffset StringToGMonthDayOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonthDay);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0009F2D6 File Offset: 0x0009D4D6
		protected static DateTimeOffset StringToGYearOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYear);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0009F2E5 File Offset: 0x0009D4E5
		protected static DateTimeOffset StringToGYearMonthOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYearMonth);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0009F2F4 File Offset: 0x0009D4F4
		protected static byte[] StringToHexBinary(string value)
		{
			byte[] result;
			try
			{
				result = XmlConvert.FromBinHexString(XmlConvert.TrimString(value), false);
			}
			catch (XmlException ex)
			{
				throw new FormatException(ex.Message);
			}
			return result;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0009F32C File Offset: 0x0009D52C
		protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver)
		{
			value = value.Trim();
			string text;
			string name;
			try
			{
				ValidateNames.ParseQNameThrow(value, out text, out name);
			}
			catch (XmlException ex)
			{
				throw new FormatException(ex.Message);
			}
			if (nsResolver == null)
			{
				throw new InvalidCastException(Res.GetString("The String '{0}' cannot be represented as an XmlQualifiedName.  A namespace for prefix '{1}' cannot be found.", new object[]
				{
					value,
					text
				}));
			}
			string text2 = nsResolver.LookupNamespace(text);
			if (text2 == null)
			{
				throw new InvalidCastException(Res.GetString("The String '{0}' cannot be represented as an XmlQualifiedName.  A namespace for prefix '{1}' cannot be found.", new object[]
				{
					value,
					text
				}));
			}
			return new XmlQualifiedName(name, text2);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0009F3BC File Offset: 0x0009D5BC
		protected static DateTime StringToTime(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Time);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0009F3CA File Offset: 0x0009D5CA
		protected static DateTimeOffset StringToTimeOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Time);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0009F3D8 File Offset: 0x0009D5D8
		protected static TimeSpan StringToYearMonthDuration(string value)
		{
			return new XsdDuration(value, XsdDuration.DurationType.YearMonthDuration).ToTimeSpan(XsdDuration.DurationType.YearMonthDuration);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0009F3F5 File Offset: 0x0009D5F5
		protected static string AnyUriToString(Uri value)
		{
			return value.OriginalString;
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0009F3FD File Offset: 0x0009D5FD
		protected static string Base64BinaryToString(byte[] value)
		{
			return Convert.ToBase64String(value);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0009F408 File Offset: 0x0009D608
		protected static string DateToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Date).ToString();
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0009F42C File Offset: 0x0009D62C
		protected static string DateTimeToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.DateTime).ToString();
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0009F450 File Offset: 0x0009D650
		protected static string DayTimeDurationToString(TimeSpan value)
		{
			return new XsdDuration(value, XsdDuration.DurationType.DayTimeDuration).ToString(XsdDuration.DurationType.DayTimeDuration);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0009F470 File Offset: 0x0009D670
		protected static string DurationToString(TimeSpan value)
		{
			return new XsdDuration(value, XsdDuration.DurationType.Duration).ToString(XsdDuration.DurationType.Duration);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0009F490 File Offset: 0x0009D690
		protected static string GDayToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GDay).ToString();
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0009F4B4 File Offset: 0x0009D6B4
		protected static string GMonthToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonth).ToString();
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0009F4DC File Offset: 0x0009D6DC
		protected static string GMonthDayToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonthDay).ToString();
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0009F500 File Offset: 0x0009D700
		protected static string GYearToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYear).ToString();
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0009F524 File Offset: 0x0009D724
		protected static string GYearMonthToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYearMonth).ToString();
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0009F548 File Offset: 0x0009D748
		protected static string DateOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Date).ToString();
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0009F56C File Offset: 0x0009D76C
		protected static string DateTimeOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.DateTime).ToString();
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0009F590 File Offset: 0x0009D790
		protected static string GDayOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GDay).ToString();
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0009F5B4 File Offset: 0x0009D7B4
		protected static string GMonthOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonth).ToString();
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0009F5DC File Offset: 0x0009D7DC
		protected static string GMonthDayOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GMonthDay).ToString();
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0009F600 File Offset: 0x0009D800
		protected static string GYearOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYear).ToString();
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0009F624 File Offset: 0x0009D824
		protected static string GYearMonthOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.GYearMonth).ToString();
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0009F648 File Offset: 0x0009D848
		protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver)
		{
			if (nsResolver == null)
			{
				return "{" + qname.Namespace + "}" + qname.Name;
			}
			string text = nsResolver.LookupPrefix(qname.Namespace);
			if (text == null)
			{
				throw new InvalidCastException(Res.GetString("The QName '{0}' cannot be represented as a String.  A prefix for namespace '{1}' cannot be found.", new object[]
				{
					qname.ToString(),
					qname.Namespace
				}));
			}
			if (text.Length == 0)
			{
				return qname.Name;
			}
			return text + ":" + qname.Name;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0009F6CC File Offset: 0x0009D8CC
		protected static string TimeToString(DateTime value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Time).ToString();
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0009F6F0 File Offset: 0x0009D8F0
		protected static string TimeOffsetToString(DateTimeOffset value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.Time).ToString();
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0009F714 File Offset: 0x0009D914
		protected static string YearMonthDurationToString(TimeSpan value)
		{
			return new XsdDuration(value, XsdDuration.DurationType.YearMonthDuration).ToString(XsdDuration.DurationType.YearMonthDuration);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0009F731 File Offset: 0x0009D931
		internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value)
		{
			return value.LocalDateTime;
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0009F73C File Offset: 0x0009D93C
		internal static int DecimalToInt32(decimal value)
		{
			if (value < -2147483648m || value > 2147483647m)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"Int32"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (int)value;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0009F79C File Offset: 0x0009D99C
		protected static long DecimalToInt64(decimal value)
		{
			if (value < -9223372036854775808m || value > 9223372036854775807m)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"Int64"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (long)value;
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0009F804 File Offset: 0x0009DA04
		protected static ulong DecimalToUInt64(decimal value)
		{
			if (value < 0m || value > 18446744073709551615m)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"UInt64"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (ulong)value;
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0009F85C File Offset: 0x0009DA5C
		protected static byte Int32ToByte(int value)
		{
			if (value < 0 || value > 255)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"Byte"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (byte)value;
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0009F8A0 File Offset: 0x0009DAA0
		protected static short Int32ToInt16(int value)
		{
			if (value < -32768 || value > 32767)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"Int16"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (short)value;
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0009F8E8 File Offset: 0x0009DAE8
		protected static sbyte Int32ToSByte(int value)
		{
			if (value < -128 || value > 127)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"SByte"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (sbyte)value;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0009F92C File Offset: 0x0009DB2C
		protected static ushort Int32ToUInt16(int value)
		{
			if (value < 0 || value > 65535)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"UInt16"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (ushort)value;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0009F970 File Offset: 0x0009DB70
		protected static int Int64ToInt32(long value)
		{
			if (value < -2147483648L || value > 2147483647L)
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"Int32"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (int)value;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0009F9BC File Offset: 0x0009DBBC
		protected static uint Int64ToUInt32(long value)
		{
			if (value < 0L || value > (long)((ulong)-1))
			{
				string name = "Value '{0}' was either too large or too small for {1}.";
				object[] args = new string[]
				{
					XmlConvert.ToString(value),
					"UInt32"
				};
				throw new OverflowException(Res.GetString(name, args));
			}
			return (uint)value;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0009F9FE File Offset: 0x0009DBFE
		protected static DateTime UntypedAtomicToDateTime(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.AllXsd);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0009FA10 File Offset: 0x0009DC10
		protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value)
		{
			return new XsdDateTime(value, XsdDateTimeFlags.AllXsd);
		}

		// Token: 0x040011C9 RID: 4553
		private XmlSchemaType schemaType;

		// Token: 0x040011CA RID: 4554
		private XmlTypeCode typeCode;

		// Token: 0x040011CB RID: 4555
		private Type clrTypeDefault;

		// Token: 0x040011CC RID: 4556
		protected static readonly Type ICollectionType = typeof(ICollection);

		// Token: 0x040011CD RID: 4557
		protected static readonly Type IEnumerableType = typeof(IEnumerable);

		// Token: 0x040011CE RID: 4558
		protected static readonly Type IListType = typeof(IList);

		// Token: 0x040011CF RID: 4559
		protected static readonly Type ObjectArrayType = typeof(object[]);

		// Token: 0x040011D0 RID: 4560
		protected static readonly Type StringArrayType = typeof(string[]);

		// Token: 0x040011D1 RID: 4561
		protected static readonly Type XmlAtomicValueArrayType = typeof(XmlAtomicValue[]);

		// Token: 0x040011D2 RID: 4562
		protected static readonly Type DecimalType = typeof(decimal);

		// Token: 0x040011D3 RID: 4563
		protected static readonly Type Int32Type = typeof(int);

		// Token: 0x040011D4 RID: 4564
		protected static readonly Type Int64Type = typeof(long);

		// Token: 0x040011D5 RID: 4565
		protected static readonly Type StringType = typeof(string);

		// Token: 0x040011D6 RID: 4566
		protected static readonly Type XmlAtomicValueType = typeof(XmlAtomicValue);

		// Token: 0x040011D7 RID: 4567
		protected static readonly Type ObjectType = typeof(object);

		// Token: 0x040011D8 RID: 4568
		protected static readonly Type ByteType = typeof(byte);

		// Token: 0x040011D9 RID: 4569
		protected static readonly Type Int16Type = typeof(short);

		// Token: 0x040011DA RID: 4570
		protected static readonly Type SByteType = typeof(sbyte);

		// Token: 0x040011DB RID: 4571
		protected static readonly Type UInt16Type = typeof(ushort);

		// Token: 0x040011DC RID: 4572
		protected static readonly Type UInt32Type = typeof(uint);

		// Token: 0x040011DD RID: 4573
		protected static readonly Type UInt64Type = typeof(ulong);

		// Token: 0x040011DE RID: 4574
		protected static readonly Type XPathItemType = typeof(XPathItem);

		// Token: 0x040011DF RID: 4575
		protected static readonly Type DoubleType = typeof(double);

		// Token: 0x040011E0 RID: 4576
		protected static readonly Type SingleType = typeof(float);

		// Token: 0x040011E1 RID: 4577
		protected static readonly Type DateTimeType = typeof(DateTime);

		// Token: 0x040011E2 RID: 4578
		protected static readonly Type DateTimeOffsetType = typeof(DateTimeOffset);

		// Token: 0x040011E3 RID: 4579
		protected static readonly Type BooleanType = typeof(bool);

		// Token: 0x040011E4 RID: 4580
		protected static readonly Type ByteArrayType = typeof(byte[]);

		// Token: 0x040011E5 RID: 4581
		protected static readonly Type XmlQualifiedNameType = typeof(XmlQualifiedName);

		// Token: 0x040011E6 RID: 4582
		protected static readonly Type UriType = typeof(Uri);

		// Token: 0x040011E7 RID: 4583
		protected static readonly Type TimeSpanType = typeof(TimeSpan);

		// Token: 0x040011E8 RID: 4584
		protected static readonly Type XPathNavigatorType = typeof(XPathNavigator);
	}
}
