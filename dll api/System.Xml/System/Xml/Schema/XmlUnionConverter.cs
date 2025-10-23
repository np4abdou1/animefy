using System;

namespace System.Xml.Schema
{
	// Token: 0x02000338 RID: 824
	internal class XmlUnionConverter : XmlBaseConverter
	{
		// Token: 0x06001C52 RID: 7250 RVA: 0x000A4114 File Offset: 0x000A2314
		protected XmlUnionConverter(XmlSchemaType schemaType) : base(schemaType)
		{
			while (schemaType.DerivedBy == XmlSchemaDerivationMethod.Restriction)
			{
				schemaType = schemaType.BaseXmlSchemaType;
			}
			XmlSchemaSimpleType[] baseMemberTypes = ((XmlSchemaSimpleTypeUnion)((XmlSchemaSimpleType)schemaType).Content).BaseMemberTypes;
			this.converters = new XmlValueConverter[baseMemberTypes.Length];
			for (int i = 0; i < baseMemberTypes.Length; i++)
			{
				this.converters[i] = baseMemberTypes[i].ValueConverter;
				if (baseMemberTypes[i].Datatype.Variety == XmlSchemaDatatypeVariety.List)
				{
					this.hasListMember = true;
				}
				else if (baseMemberTypes[i].Datatype.Variety == XmlSchemaDatatypeVariety.Atomic)
				{
					this.hasAtomicMember = true;
				}
			}
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000A41AC File Offset: 0x000A23AC
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			return new XmlUnionConverter(schemaType);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x000A41B4 File Offset: 0x000A23B4
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
			if (type == XmlBaseConverter.XmlAtomicValueType && this.hasAtomicMember)
			{
				return ((XmlAtomicValue)value).ValueAs(destinationType, nsResolver);
			}
			if (type == XmlBaseConverter.XmlAtomicValueArrayType && this.hasListMember)
			{
				return XmlAnyListConverter.ItemList.ChangeType(value, destinationType, nsResolver);
			}
			if (!(type == XmlBaseConverter.StringType))
			{
				throw base.CreateInvalidClrMappingException(type, destinationType);
			}
			if (destinationType == XmlBaseConverter.StringType)
			{
				return value;
			}
			return ((XsdSimpleValue)base.SchemaType.Datatype.ParseValue((string)value, new NameTable(), nsResolver, true)).XmlType.ValueConverter.ChangeType((string)value, destinationType, nsResolver);
		}

		// Token: 0x040011F1 RID: 4593
		private XmlValueConverter[] converters;

		// Token: 0x040011F2 RID: 4594
		private bool hasAtomicMember;

		// Token: 0x040011F3 RID: 4595
		private bool hasListMember;
	}
}
