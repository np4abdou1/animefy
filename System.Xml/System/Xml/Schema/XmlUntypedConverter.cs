using System;

namespace System.Xml.Schema
{
	// Token: 0x02000334 RID: 820
	internal class XmlUntypedConverter : XmlListConverter
	{
		// Token: 0x06001C06 RID: 7174 RVA: 0x000A202E File Offset: 0x000A022E
		protected XmlUntypedConverter() : base(DatatypeImplementation.UntypedAtomicType)
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x000A203B File Offset: 0x000A023B
		protected XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList) : base(atomicConverter, allowListToList ? XmlBaseConverter.StringArrayType : XmlBaseConverter.StringType)
		{
			this.allowListToList = allowListToList;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x000A1424 File Offset: 0x0009F624
		public override bool ToBoolean(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlConvert.ToBoolean(value);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x000A205A File Offset: 0x000A025A
		public override bool ToBoolean(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToBoolean((string)value);
			}
			return (bool)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.BooleanType, null);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x000A209A File Offset: 0x000A029A
		public override DateTime ToDateTime(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlBaseConverter.UntypedAtomicToDateTime(value);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000A20B0 File Offset: 0x000A02B0
		public override DateTime ToDateTime(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.UntypedAtomicToDateTime((string)value);
			}
			return (DateTime)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.DateTimeType, null);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000A20F0 File Offset: 0x000A02F0
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlBaseConverter.UntypedAtomicToDateTimeOffset(value);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000A2106 File Offset: 0x000A0306
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.UntypedAtomicToDateTimeOffset((string)value);
			}
			return (DateTimeOffset)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.DateTimeOffsetType, null);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000A2146 File Offset: 0x000A0346
		public override decimal ToDecimal(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlConvert.ToDecimal(value);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000A215C File Offset: 0x000A035C
		public override decimal ToDecimal(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToDecimal((string)value);
			}
			return (decimal)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.DecimalType, null);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000A219C File Offset: 0x000A039C
		public override double ToDouble(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlConvert.ToDouble(value);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000A21B2 File Offset: 0x000A03B2
		public override double ToDouble(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToDouble((string)value);
			}
			return (double)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.DoubleType, null);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000A21F2 File Offset: 0x000A03F2
		public override int ToInt32(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlConvert.ToInt32(value);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000A2208 File Offset: 0x000A0408
		public override int ToInt32(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToInt32((string)value);
			}
			return (int)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.Int32Type, null);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000A2248 File Offset: 0x000A0448
		public override long ToInt64(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlConvert.ToInt64(value);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000A225E File Offset: 0x000A045E
		public override long ToInt64(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToInt64((string)value);
			}
			return (long)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.Int64Type, null);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000A229E File Offset: 0x000A049E
		public override float ToSingle(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return XmlConvert.ToSingle(value);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000A22B4 File Offset: 0x000A04B4
		public override float ToSingle(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.GetType() == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToSingle((string)value);
			}
			return (float)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.SingleType, null);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000A14B6 File Offset: 0x0009F6B6
		public override string ToString(bool value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000A22F4 File Offset: 0x000A04F4
		public override string ToString(DateTime value)
		{
			return XmlBaseConverter.DateTimeToString(value);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000A22FC File Offset: 0x000A04FC
		public override string ToString(DateTimeOffset value)
		{
			return XmlBaseConverter.DateTimeOffsetToString(value);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000A2304 File Offset: 0x000A0504
		public override string ToString(decimal value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000A230C File Offset: 0x000A050C
		public override string ToString(double value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0009FEAF File Offset: 0x0009E0AF
		public override string ToString(int value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0009FEB7 File Offset: 0x0009E0B7
		public override string ToString(long value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000A2315 File Offset: 0x000A0515
		public override string ToString(float value)
		{
			return XmlConvert.ToString(value);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000A2320 File Offset: 0x000A0520
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Type type = value.GetType();
			if (type == XmlBaseConverter.BooleanType)
			{
				return XmlConvert.ToString((bool)value);
			}
			if (type == XmlBaseConverter.ByteType)
			{
				return XmlConvert.ToString((byte)value);
			}
			if (type == XmlBaseConverter.ByteArrayType)
			{
				return XmlBaseConverter.Base64BinaryToString((byte[])value);
			}
			if (type == XmlBaseConverter.DateTimeType)
			{
				return XmlBaseConverter.DateTimeToString((DateTime)value);
			}
			if (type == XmlBaseConverter.DateTimeOffsetType)
			{
				return XmlBaseConverter.DateTimeOffsetToString((DateTimeOffset)value);
			}
			if (type == XmlBaseConverter.DecimalType)
			{
				return XmlConvert.ToString((decimal)value);
			}
			if (type == XmlBaseConverter.DoubleType)
			{
				return XmlConvert.ToString((double)value);
			}
			if (type == XmlBaseConverter.Int16Type)
			{
				return XmlConvert.ToString((short)value);
			}
			if (type == XmlBaseConverter.Int32Type)
			{
				return XmlConvert.ToString((int)value);
			}
			if (type == XmlBaseConverter.Int64Type)
			{
				return XmlConvert.ToString((long)value);
			}
			if (type == XmlBaseConverter.SByteType)
			{
				return XmlConvert.ToString((sbyte)value);
			}
			if (type == XmlBaseConverter.SingleType)
			{
				return XmlConvert.ToString((float)value);
			}
			if (type == XmlBaseConverter.StringType)
			{
				return (string)value;
			}
			if (type == XmlBaseConverter.TimeSpanType)
			{
				return XmlBaseConverter.DurationToString((TimeSpan)value);
			}
			if (type == XmlBaseConverter.UInt16Type)
			{
				return XmlConvert.ToString((ushort)value);
			}
			if (type == XmlBaseConverter.UInt32Type)
			{
				return XmlConvert.ToString((uint)value);
			}
			if (type == XmlBaseConverter.UInt64Type)
			{
				return XmlConvert.ToString((ulong)value);
			}
			if (XmlBaseConverter.IsDerivedFrom(type, XmlBaseConverter.UriType))
			{
				return XmlBaseConverter.AnyUriToString((Uri)value);
			}
			if (type == XmlBaseConverter.XmlAtomicValueType)
			{
				return (string)((XmlAtomicValue)value).ValueAs(XmlBaseConverter.StringType, nsResolver);
			}
			if (XmlBaseConverter.IsDerivedFrom(type, XmlBaseConverter.XmlQualifiedNameType))
			{
				return XmlBaseConverter.QNameToString((XmlQualifiedName)value, nsResolver);
			}
			return (string)this.ChangeTypeWildcardDestination(value, XmlBaseConverter.StringType, nsResolver);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000A2550 File Offset: 0x000A0750
		public override object ChangeType(bool value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToString(value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000A25A8 File Offset: 0x000A07A8
		public override object ChangeType(DateTime value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.DateTimeToString(value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000A2600 File Offset: 0x000A0800
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
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToString(value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000A2658 File Offset: 0x000A0858
		public override object ChangeType(double value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == XmlBaseConverter.ObjectType)
			{
				destinationType = base.DefaultClrType;
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToString(value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000A26B4 File Offset: 0x000A08B4
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
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToString(value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000A270C File Offset: 0x000A090C
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
			if (destinationType == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToString(value);
			}
			return this.ChangeTypeWildcardSource(value, destinationType, null);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000A2764 File Offset: 0x000A0964
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
			if (destinationType == XmlBaseConverter.BooleanType)
			{
				return XmlConvert.ToBoolean(value);
			}
			if (destinationType == XmlBaseConverter.ByteType)
			{
				return XmlBaseConverter.Int32ToByte(XmlConvert.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.ByteArrayType)
			{
				return XmlBaseConverter.StringToBase64Binary(value);
			}
			if (destinationType == XmlBaseConverter.DateTimeType)
			{
				return XmlBaseConverter.UntypedAtomicToDateTime(value);
			}
			if (destinationType == XmlBaseConverter.DateTimeOffsetType)
			{
				return XmlBaseConverter.UntypedAtomicToDateTimeOffset(value);
			}
			if (destinationType == XmlBaseConverter.DecimalType)
			{
				return XmlConvert.ToDecimal(value);
			}
			if (destinationType == XmlBaseConverter.DoubleType)
			{
				return XmlConvert.ToDouble(value);
			}
			if (destinationType == XmlBaseConverter.Int16Type)
			{
				return XmlBaseConverter.Int32ToInt16(XmlConvert.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.Int32Type)
			{
				return XmlConvert.ToInt32(value);
			}
			if (destinationType == XmlBaseConverter.Int64Type)
			{
				return XmlConvert.ToInt64(value);
			}
			if (destinationType == XmlBaseConverter.SByteType)
			{
				return XmlBaseConverter.Int32ToSByte(XmlConvert.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.SingleType)
			{
				return XmlConvert.ToSingle(value);
			}
			if (destinationType == XmlBaseConverter.TimeSpanType)
			{
				return XmlBaseConverter.StringToDuration(value);
			}
			if (destinationType == XmlBaseConverter.UInt16Type)
			{
				return XmlBaseConverter.Int32ToUInt16(XmlConvert.ToInt32(value));
			}
			if (destinationType == XmlBaseConverter.UInt32Type)
			{
				return XmlBaseConverter.Int64ToUInt32(XmlConvert.ToInt64(value));
			}
			if (destinationType == XmlBaseConverter.UInt64Type)
			{
				return XmlBaseConverter.DecimalToUInt64(XmlConvert.ToDecimal(value));
			}
			if (destinationType == XmlBaseConverter.UriType)
			{
				return XmlConvert.ToUri(value);
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			if (destinationType == XmlBaseConverter.XmlQualifiedNameType)
			{
				return XmlBaseConverter.StringToQName(value, nsResolver);
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				return new XmlAtomicValue(base.SchemaType, value);
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return value;
			}
			return this.ChangeTypeWildcardSource(value, destinationType, nsResolver);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000A29C8 File Offset: 0x000A0BC8
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
			if (destinationType == XmlBaseConverter.BooleanType && type == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToBoolean((string)value);
			}
			if (destinationType == XmlBaseConverter.ByteType && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.Int32ToByte(XmlConvert.ToInt32((string)value));
			}
			if (destinationType == XmlBaseConverter.ByteArrayType && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.StringToBase64Binary((string)value);
			}
			if (destinationType == XmlBaseConverter.DateTimeType && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.UntypedAtomicToDateTime((string)value);
			}
			if (destinationType == XmlBaseConverter.DateTimeOffsetType && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.UntypedAtomicToDateTimeOffset((string)value);
			}
			if (destinationType == XmlBaseConverter.DecimalType && type == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToDecimal((string)value);
			}
			if (destinationType == XmlBaseConverter.DoubleType && type == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToDouble((string)value);
			}
			if (destinationType == XmlBaseConverter.Int16Type && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.Int32ToInt16(XmlConvert.ToInt32((string)value));
			}
			if (destinationType == XmlBaseConverter.Int32Type && type == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToInt32((string)value);
			}
			if (destinationType == XmlBaseConverter.Int64Type && type == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToInt64((string)value);
			}
			if (destinationType == XmlBaseConverter.SByteType && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.Int32ToSByte(XmlConvert.ToInt32((string)value));
			}
			if (destinationType == XmlBaseConverter.SingleType && type == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToSingle((string)value);
			}
			if (destinationType == XmlBaseConverter.TimeSpanType && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.StringToDuration((string)value);
			}
			if (destinationType == XmlBaseConverter.UInt16Type && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.Int32ToUInt16(XmlConvert.ToInt32((string)value));
			}
			if (destinationType == XmlBaseConverter.UInt32Type && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.Int64ToUInt32(XmlConvert.ToInt64((string)value));
			}
			if (destinationType == XmlBaseConverter.UInt64Type && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.DecimalToUInt64(XmlConvert.ToDecimal((string)value));
			}
			if (destinationType == XmlBaseConverter.UriType && type == XmlBaseConverter.StringType)
			{
				return XmlConvert.ToUri((string)value);
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				if (type == XmlBaseConverter.StringType)
				{
					return new XmlAtomicValue(base.SchemaType, (string)value);
				}
				if (type == XmlBaseConverter.XmlAtomicValueType)
				{
					return (XmlAtomicValue)value;
				}
			}
			if (destinationType == XmlBaseConverter.XmlQualifiedNameType && type == XmlBaseConverter.StringType)
			{
				return XmlBaseConverter.StringToQName((string)value, nsResolver);
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				if (type == XmlBaseConverter.StringType)
				{
					return new XmlAtomicValue(base.SchemaType, (string)value);
				}
				if (type == XmlBaseConverter.XmlAtomicValueType)
				{
					return (XmlAtomicValue)value;
				}
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return this.ToString(value, nsResolver);
			}
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				return new XmlAtomicValue(base.SchemaType, this.ToString(value, nsResolver));
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				return new XmlAtomicValue(base.SchemaType, this.ToString(value, nsResolver));
			}
			if (type == XmlBaseConverter.XmlAtomicValueType)
			{
				return ((XmlAtomicValue)value).ValueAs(destinationType, nsResolver);
			}
			return this.ChangeListType(value, destinationType, nsResolver);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000A1DF1 File Offset: 0x0009FFF1
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value.GetType() == XmlBaseConverter.XmlAtomicValueType)
			{
				return ((XmlAtomicValue)value).ValueAs(destinationType, nsResolver);
			}
			return this.ChangeListType(value, destinationType, nsResolver);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000A2E28 File Offset: 0x000A1028
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (destinationType == XmlBaseConverter.XmlAtomicValueType)
			{
				return new XmlAtomicValue(base.SchemaType, this.ToString(value, nsResolver));
			}
			if (destinationType == XmlBaseConverter.XPathItemType)
			{
				return new XmlAtomicValue(base.SchemaType, this.ToString(value, nsResolver));
			}
			return this.ChangeListType(value, destinationType, nsResolver);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000A2E80 File Offset: 0x000A1080
		protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			if (this.atomicConverter != null && (this.allowListToList || !(type != XmlBaseConverter.StringType) || !(destinationType != XmlBaseConverter.StringType)))
			{
				return base.ChangeListType(value, destinationType, nsResolver);
			}
			if (this.SupportsType(type))
			{
				throw new InvalidCastException(Res.GetString("Xml type '{0}' cannot convert from Clr type '{1}' unless the destination type is String or XmlAtomicValue.", new object[]
				{
					base.XmlTypeName,
					type.Name
				}));
			}
			if (this.SupportsType(destinationType))
			{
				throw new InvalidCastException(Res.GetString("Xml type '{0}' cannot convert to Clr type '{1}' unless the source value is a String or an XmlAtomicValue.", new object[]
				{
					base.XmlTypeName,
					destinationType.Name
				}));
			}
			throw base.CreateInvalidClrMappingException(type, destinationType);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000A2F38 File Offset: 0x000A1138
		private bool SupportsType(Type clrType)
		{
			return clrType == XmlBaseConverter.BooleanType || clrType == XmlBaseConverter.ByteType || clrType == XmlBaseConverter.ByteArrayType || clrType == XmlBaseConverter.DateTimeType || clrType == XmlBaseConverter.DateTimeOffsetType || clrType == XmlBaseConverter.DecimalType || clrType == XmlBaseConverter.DoubleType || clrType == XmlBaseConverter.Int16Type || clrType == XmlBaseConverter.Int32Type || clrType == XmlBaseConverter.Int64Type || clrType == XmlBaseConverter.SByteType || clrType == XmlBaseConverter.SingleType || clrType == XmlBaseConverter.TimeSpanType || clrType == XmlBaseConverter.UInt16Type || clrType == XmlBaseConverter.UInt32Type || clrType == XmlBaseConverter.UInt64Type || clrType == XmlBaseConverter.UriType || clrType == XmlBaseConverter.XmlQualifiedNameType;
		}

		// Token: 0x040011E9 RID: 4585
		private bool allowListToList;

		// Token: 0x040011EA RID: 4586
		public static readonly XmlValueConverter Untyped = new XmlUntypedConverter(new XmlUntypedConverter(), false);

		// Token: 0x040011EB RID: 4587
		public static readonly XmlValueConverter UntypedList = new XmlUntypedConverter(new XmlUntypedConverter(), true);
	}
}
