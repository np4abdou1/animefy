using System;

namespace System.Xml.Schema
{
	// Token: 0x0200032E RID: 814
	internal class XmlNumeric10Converter : XmlBaseConverter
	{
		// Token: 0x06001BC1 RID: 7105 RVA: 0x0009FBE4 File Offset: 0x0009DDE4
		protected XmlNumeric10Converter(XmlSchemaType schemaType) : base(schemaType)
		{
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0009FBED File Offset: 0x0009DDED
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			return new XmlNumeric10Converter(schemaType);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0009FBF5 File Offset: 0x0009DDF5
		public override decimal ToDecimal(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.TypeCode == XmlTypeCode.Decimal)
			{
				return XmlConvert.ToDecimal(value);
			}
			return XmlConvert.ToInteger(value);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0009FC1C File Offset: 0x0009DE1C
		public override decimal ToDecimal(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Type type = value.GetType();
			if (type == XmlBaseConverter.DecimalType)
			{
				return (decimal)value;
			}
			if (type == XmlBaseConverter.Int32Type)
			{
				return (int)value;
			}
			if (type == XmlBaseConverter.Int64Type)
			{
				return (long)value;
			}
			if (type == XmlBaseConverter.StringType)
			{
				return this.ToDecimal((string)value);
			}
			if (type == XmlBaseConverter.XmlAtomicValueType)
			{
				return (decimal)((XmlAtomicValue)value).ValueAs(XmlBaseConverter.DecimalType);
			}
			return (decimal)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.DecimalType, null);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0009FCD3 File Offset: 0x0009DED3
		public override int ToInt32(long value)
		{
			return XmlBaseConverter.Int64ToInt32(value);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0009FCDB File Offset: 0x0009DEDB
		public override int ToInt32(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.TypeCode == XmlTypeCode.Decimal)
			{
				return XmlBaseConverter.DecimalToInt32(XmlConvert.ToDecimal(value));
			}
			return XmlConvert.ToInt32(value);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0009FD08 File Offset: 0x0009DF08
		public override int ToInt32(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Type type = value.GetType();
			if (type == XmlBaseConverter.DecimalType)
			{
				return XmlBaseConverter.DecimalToInt32((decimal)value);
			}
			if (type == XmlBaseConverter.Int32Type)
			{
				return (int)value;
			}
			if (type == XmlBaseConverter.Int64Type)
			{
				return XmlBaseConverter.Int64ToInt32((long)value);
			}
			if (type == XmlBaseConverter.StringType)
			{
				return this.ToInt32((string)value);
			}
			if (type == XmlBaseConverter.XmlAtomicValueType)
			{
				return ((XmlAtomicValue)value).ValueAsInt;
			}
			return (int)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0009FDB5 File Offset: 0x0009DFB5
		public override long ToInt64(int value)
		{
			return (long)value;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0009FDB9 File Offset: 0x0009DFB9
		public override long ToInt64(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.TypeCode == XmlTypeCode.Decimal)
			{
				return XmlBaseConverter.DecimalToInt64(XmlConvert.ToDecimal(value));
			}
			return XmlConvert.ToInt64(value);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0009FDE8 File Offset: 0x0009DFE8
		public override long ToInt64(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Type type = value.GetType();
			if (type == XmlBaseConverter.DecimalType)
			{
				return XmlBaseConverter.DecimalToInt64((decimal)value);
			}
			if (type == XmlBaseConverter.Int32Type)
			{
				return (long)((int)value);
			}
			if (type == XmlBaseConverter.Int64Type)
			{
				return (long)value;
			}
			if (type == XmlBaseConverter.StringType)
			{
				return this.ToInt64((string)value);
			}
			if (type == XmlBaseConverter.XmlAtomicValueType)
			{
				return ((XmlAtomicValue)value).ValueAsLong;
			}
			return (long)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0009FE91 File Offset: 0x0009E091
		public override string ToString(decimal value)
		{
			if (base.TypeCode == XmlTypeCode.Decimal)
			{
				return XmlConvert.ToString(value);
			}
			return XmlConvert.ToString(decimal.Truncate(value));
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0009FEAF File Offset: 0x0009E0AF
		public override string ToString(int value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0009FEB7 File Offset: 0x0009E0B7
		public override string ToString(long value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0009FEC0 File Offset: 0x0009E0C0
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Type type = value.GetType();
			if (type == XmlBaseConverter.DecimalType)
			{
				return this.ToString((decimal)value);
			}
			if (type == XmlBaseConverter.Int32Type)
			{
				return XmlConvert.ToString((int)value);
			}
			if (type == XmlBaseConverter.Int64Type)
			{
				return XmlConvert.ToString((long)value);
			}
			if (type == XmlBaseConverter.StringType)
			{
				return (string)value;
			}
			if (type == XmlBaseConverter.XmlAtomicValueType)
			{
				return ((XmlAtomicValue)value).Value;
			}
			return (string)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.StringType, nsResolver);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0009FF70 File Offset: 0x0009E170
		public override object ChangeType(decimal value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.DecimalType)
			{
				return value;
			}
			if (destinationType == XmlBaseConverter.Int32Type)
			{
				return XmlBaseConverter.DecimalToInt32(value);
			}
			if (destinationType == XmlBaseConverter.Int64Type)
			{
				return XmlBaseConverter.DecimalToInt64(value);
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return this.ToString(value);
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000A0050 File Offset: 0x0009E250
		public override object ChangeType(int value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.DecimalType)
			{
				return value;
			}
			if (destinationType == XmlBaseConverter.Int32Type)
			{
				return value;
			}
			if (destinationType == XmlBaseConverter.Int64Type)
			{
				return (long)value;
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToString(value);
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000A0120 File Offset: 0x0009E320
		public override object ChangeType(long value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.DecimalType)
			{
				return value;
			}
			if (destinationType == XmlBaseConverter.Int32Type)
			{
				return XmlBaseConverter.Int64ToInt32(value);
			}
			if (destinationType == XmlBaseConverter.Int64Type)
			{
				return value;
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToString(value);
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000A01F4 File Offset: 0x0009E3F4
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.DecimalType)
			{
				return this.ToDecimal(value);
			}
			if (destinationType == XmlBaseConverter.Int32Type)
			{
				return this.ToInt32(value);
			}
			if (destinationType == XmlBaseConverter.Int64Type)
			{
				return this.ToInt64(value);
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return value;
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, nsResolver);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000A02D4 File Offset: 0x0009E4D4
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			Type type = value.GetType();
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.DecimalType)
			{
				return this.ToDecimal(value);
			}
			if (destinationType == XmlBaseConverter.Int32Type)
			{
				return this.ToInt32(value);
			}
			if (destinationType == XmlBaseConverter.Int64Type)
			{
				return this.ToInt64(value);
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return this.ToString(value, nsResolver);
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				if (type == XmlBaseConverter.DecimalType)
				{
					return new XmlAtomicValue(base.SchemaType, value);
				}
				if (type == XmlBaseConverter.Int32Type)
				{
					return new XmlAtomicValue(base.SchemaType, (int)value);
				}
				if (type == XmlBaseConverter.Int64Type)
				{
					return new XmlAtomicValue(base.SchemaType, (long)value);
				}
				if (type == XmlBaseConverter.StringType)
				{
					return new XmlAtomicValue(base.SchemaType, (string)value);
				}
				if (type == XmlBaseConverter.XmlAtomicValueType)
				{
					return (XmlAtomicValue)value;
				}
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				if (type == XmlBaseConverter.DecimalType)
				{
					return new XmlAtomicValue(base.SchemaType, value);
				}
				if (type == XmlBaseConverter.Int32Type)
				{
					return new XmlAtomicValue(base.SchemaType, (int)value);
				}
				if (type == XmlBaseConverter.Int64Type)
				{
					return new XmlAtomicValue(base.SchemaType, (long)value);
				}
				if (type == XmlBaseConverter.StringType)
				{
					return new XmlAtomicValue(base.SchemaType, (string)value);
				}
				if (type == XmlBaseConverter.XmlAtomicValueType)
				{
					return (XmlAtomicValue)value;
				}
			}
			if (destinationType == XmlBaseConverter.ByteType)
			{
				return XmlBaseConverter.Int32ToByte(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.Int16Type)
			{
				return XmlBaseConverter.Int32ToInt16(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.SByteType)
			{
				return XmlBaseConverter.Int32ToSByte(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.UInt16Type)
			{
				return XmlBaseConverter.Int32ToUInt16(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.UInt32Type)
			{
				return XmlBaseConverter.Int64ToUInt32(this.ToInt64(value));
			}
			if (destinationType == XmlBaseConverter.UInt64Type)
			{
				return XmlBaseConverter.DecimalToUInt64(this.ToDecimal(value));
			}
			if (type == XmlBaseConverter.ByteType)
			{
				return this.ChangeType((int)((byte)value), destinationType);
			}
			if (type == XmlBaseConverter.Int16Type)
			{
				return this.ChangeType((int)((short)value), destinationType);
			}
			if (type == XmlBaseConverter.SByteType)
			{
				return this.ChangeType((int)((sbyte)value), destinationType);
			}
			if (type == XmlBaseConverter.UInt16Type)
			{
				return this.ChangeType((int)((ushort)value), destinationType);
			}
			if (type == XmlBaseConverter.UInt32Type)
			{
				return this.ChangeType((long)((ulong)((uint)value)), destinationType);
			}
			if (type == XmlBaseConverter.UInt64Type)
			{
				return this.ChangeType((ulong)value, destinationType);
			}
			return this.ChangeListType(value, destinationType, nsResolver);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000A0624 File Offset: 0x0009E824
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			if (type == XmlBaseConverter.ByteType)
			{
				return this.ChangeType((int)((byte)value), destinationType);
			}
			if (type == XmlBaseConverter.Int16Type)
			{
				return this.ChangeType((int)((short)value), destinationType);
			}
			if (type == XmlBaseConverter.SByteType)
			{
				return this.ChangeType((int)((sbyte)value), destinationType);
			}
			if (type == XmlBaseConverter.UInt16Type)
			{
				return this.ChangeType((int)((ushort)value), destinationType);
			}
			if (type == XmlBaseConverter.UInt32Type)
			{
				return this.ChangeType((long)((ulong)((uint)value)), destinationType);
			}
			if (type == XmlBaseConverter.UInt64Type)
			{
				return this.ChangeType((ulong)value, destinationType);
			}
			return this.ChangeListType(value, destinationType, nsResolver);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000A06EC File Offset: 0x0009E8EC
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (destinationType == XmlBaseConverter.ByteType)
			{
				return XmlBaseConverter.Int32ToByte(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.Int16Type)
			{
				return XmlBaseConverter.Int32ToInt16(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.SByteType)
			{
				return XmlBaseConverter.Int32ToSByte(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.UInt16Type)
			{
				return XmlBaseConverter.Int32ToUInt16(this.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.UInt32Type)
			{
				return XmlBaseConverter.Int64ToUInt32(this.ToInt64(value));
			}
			if (destinationType == XmlBaseConverter.UInt64Type)
			{
				return XmlBaseConverter.DecimalToUInt64(this.ToDecimal(value));
			}
			return this.ChangeListType(value, destinationType, nsResolver);
		}
	}
}
