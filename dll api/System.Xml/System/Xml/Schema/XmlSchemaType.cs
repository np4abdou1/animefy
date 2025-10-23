using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>The base class for all simple types and complex types.</summary>
	// Token: 0x02000321 RID: 801
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		/// <summary>Returns an <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type of the simple type that is specified by the qualified name.</summary>
		/// <param name="qualifiedName">The <see cref="T:System.Xml.XmlQualifiedName" /> of the simple type.</param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.XmlQualifiedName" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06001A81 RID: 6785 RVA: 0x0009AD16 File Offset: 0x00098F16
		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName)
		{
			if (qualifiedName == null)
			{
				throw new ArgumentNullException("qualifiedName");
			}
			return DatatypeImplementation.GetSimpleTypeFromXsdType(qualifiedName);
		}

		/// <summary>Returns an <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type of the specified simple type.</summary>
		/// <param name="typeCode">One of the <see cref="T:System.Xml.Schema.XmlTypeCode" /> values representing the simple type.</param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type.</returns>
		// Token: 0x06001A82 RID: 6786 RVA: 0x0009AD32 File Offset: 0x00098F32
		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			return DatatypeImplementation.GetSimpleTypeFromTypeCode(typeCode);
		}

		/// <summary>Returns an <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> that represents the built-in complex type of the complex type specified by qualified name.</summary>
		/// <param name="qualifiedName">The <see cref="T:System.Xml.XmlQualifiedName" /> of the complex type.</param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> that represents the built-in complex type.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.XmlQualifiedName" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06001A83 RID: 6787 RVA: 0x0009AD3C File Offset: 0x00098F3C
		public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName)
		{
			if (qualifiedName == null)
			{
				throw new ArgumentNullException("qualifiedName");
			}
			if (qualifiedName.Equals(XmlSchemaComplexType.AnyType.QualifiedName))
			{
				return XmlSchemaComplexType.AnyType;
			}
			if (qualifiedName.Equals(XmlSchemaComplexType.UntypedAnyType.QualifiedName))
			{
				return XmlSchemaComplexType.UntypedAnyType;
			}
			return null;
		}

		/// <summary>Gets or sets the name of the type.</summary>
		/// <returns>The name of the type.</returns>
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0009AD8E File Offset: 0x00098F8E
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0009AD96 File Offset: 0x00098F96
		[XmlAttribute("name")]
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets or sets the final attribute of the type derivation that indicates if further derivations are allowed.</summary>
		/// <returns>One of the valid <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> values. The default is <see cref="F:System.Xml.Schema.XmlSchemaDerivationMethod.None" />.</returns>
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0009AD9F File Offset: 0x00098F9F
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0009ADA7 File Offset: 0x00098FA7
		[XmlAttribute("final")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod Final
		{
			get
			{
				return this.final;
			}
			set
			{
				this.final = value;
			}
		}

		/// <summary>Gets the qualified name for the type built from the <see langword="Name" /> attribute of this type. This is a post-schema-compilation property.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlQualifiedName" /> for the type built from the <see langword="Name" /> attribute of this type.</returns>
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0009ADB0 File Offset: 0x00098FB0
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
		}

		/// <summary>Gets the post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaType.Final" /> property.</summary>
		/// <returns>The post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaType.Final" /> property. The default is the <see langword="finalDefault" /> attribute value of the <see langword="schema" /> element.</returns>
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0009ADBA File Offset: 0x00098FBA
		[XmlIgnore]
		public XmlSchemaDerivationMethod FinalResolved
		{
			get
			{
				return this.finalResolved;
			}
		}

		/// <summary>Gets the post-compilation value for the base type of this schema type.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object representing the base type of this schema type.</returns>
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0009ADC2 File Offset: 0x00098FC2
		[XmlIgnore]
		public XmlSchemaType BaseXmlSchemaType
		{
			get
			{
				return this.baseSchemaType;
			}
		}

		/// <summary>Gets the post-compilation information on how this element was derived from its base type.</summary>
		/// <returns>One of the valid <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> values.</returns>
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0009ADCA File Offset: 0x00098FCA
		[XmlIgnore]
		public XmlSchemaDerivationMethod DerivedBy
		{
			get
			{
				return this.derivedBy;
			}
		}

		/// <summary>Gets the post-compilation value for the data type of the complex type.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> post-schema-compilation value.</returns>
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0009ADD2 File Offset: 0x00098FD2
		[XmlIgnore]
		public XmlSchemaDatatype Datatype
		{
			get
			{
				return this.datatype;
			}
		}

		/// <summary>Gets or sets a value indicating if this type has a mixed content model. This property is only valid in a complex type.</summary>
		/// <returns>
		///     <see langword="true" /> if the type has a mixed content model; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0000A216 File Offset: 0x00008416
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x00008574 File Offset: 0x00006774
		[XmlIgnore]
		public virtual bool IsMixed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlTypeCode" /> of the type.</summary>
		/// <returns>One of the <see cref="T:System.Xml.Schema.XmlTypeCode" /> values.</returns>
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x0009ADDA File Offset: 0x00098FDA
		[XmlIgnore]
		public XmlTypeCode TypeCode
		{
			get
			{
				if (this == XmlSchemaComplexType.AnyType)
				{
					return XmlTypeCode.Item;
				}
				if (this.datatype == null)
				{
					return XmlTypeCode.None;
				}
				return this.datatype.TypeCode;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0009ADFB File Offset: 0x00098FFB
		[XmlIgnore]
		internal XmlValueConverter ValueConverter
		{
			get
			{
				if (this.datatype == null)
				{
					return XmlUntypedConverter.Untyped;
				}
				return this.datatype.ValueConverter;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0009AE16 File Offset: 0x00099016
		internal XmlSchemaContentType SchemaContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0009AE1E File Offset: 0x0009901E
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qname = value;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0009AE29 File Offset: 0x00099029
		internal void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
			this.finalResolved = value;
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0009AE32 File Offset: 0x00099032
		internal void SetBaseSchemaType(XmlSchemaType value)
		{
			this.baseSchemaType = value;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0009AE3B File Offset: 0x0009903B
		internal void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
			this.derivedBy = value;
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0009AE44 File Offset: 0x00099044
		internal void SetDatatype(XmlSchemaDatatype value)
		{
			this.datatype = value;
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0009AE4D File Offset: 0x0009904D
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0009AE57 File Offset: 0x00099057
		internal SchemaElementDecl ElementDecl
		{
			get
			{
				return this.elementDecl;
			}
			set
			{
				this.elementDecl = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0009AE62 File Offset: 0x00099062
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0009AE6A File Offset: 0x0009906A
		[XmlIgnore]
		internal XmlSchemaType Redefined
		{
			get
			{
				return this.redefined;
			}
			set
			{
				this.redefined = value;
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0009AE73 File Offset: 0x00099073
		internal void SetContentType(XmlSchemaContentType value)
		{
			this.contentType = value;
		}

		/// <summary>Returns a value indicating if the derived schema type specified is derived from the base schema type specified</summary>
		/// <param name="derivedType">The derived <see cref="T:System.Xml.Schema.XmlSchemaType" /> to test.</param>
		/// <param name="baseType">The base <see cref="T:System.Xml.Schema.XmlSchemaType" /> to test the derived <see cref="T:System.Xml.Schema.XmlSchemaType" /> against.</param>
		/// <param name="except">One of the <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> values representing a type derivation method to exclude from testing.</param>
		/// <returns>
		///     <see langword="true" /> if the derived type is derived from the base type; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001A9C RID: 6812 RVA: 0x0009AE7C File Offset: 0x0009907C
		public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except)
		{
			if (derivedType == null || baseType == null)
			{
				return false;
			}
			if (derivedType == baseType)
			{
				return true;
			}
			if (baseType == XmlSchemaComplexType.AnyType)
			{
				return true;
			}
			XmlSchemaSimpleType xmlSchemaSimpleType;
			XmlSchemaSimpleType xmlSchemaSimpleType2;
			for (;;)
			{
				xmlSchemaSimpleType = (derivedType as XmlSchemaSimpleType);
				xmlSchemaSimpleType2 = (baseType as XmlSchemaSimpleType);
				if (xmlSchemaSimpleType2 != null && xmlSchemaSimpleType != null)
				{
					break;
				}
				if ((except & derivedType.DerivedBy) != XmlSchemaDerivationMethod.Empty)
				{
					return false;
				}
				derivedType = derivedType.BaseXmlSchemaType;
				if (derivedType == baseType)
				{
					return true;
				}
				if (derivedType == null)
				{
					return false;
				}
			}
			return xmlSchemaSimpleType2 == DatatypeImplementation.AnySimpleType || ((except & derivedType.DerivedBy) == XmlSchemaDerivationMethod.Empty && xmlSchemaSimpleType.Datatype.IsDerivedFrom(xmlSchemaSimpleType2.Datatype));
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0009AEFE File Offset: 0x000990FE
		internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except)
		{
			return DatatypeImplementation.AnySimpleType.Datatype == baseDataType || derivedDataType.IsDerivedFrom(baseDataType);
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0009AF16 File Offset: 0x00099116
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0009AF1E File Offset: 0x0009911E
		[XmlIgnore]
		internal override string NameAttribute
		{
			get
			{
				return this.Name;
			}
			set
			{
				this.Name = value;
			}
		}

		// Token: 0x04001135 RID: 4405
		private string name;

		// Token: 0x04001136 RID: 4406
		private XmlSchemaDerivationMethod final = XmlSchemaDerivationMethod.None;

		// Token: 0x04001137 RID: 4407
		private XmlSchemaDerivationMethod derivedBy;

		// Token: 0x04001138 RID: 4408
		private XmlSchemaType baseSchemaType;

		// Token: 0x04001139 RID: 4409
		private XmlSchemaDatatype datatype;

		// Token: 0x0400113A RID: 4410
		private XmlSchemaDerivationMethod finalResolved;

		// Token: 0x0400113B RID: 4411
		private volatile SchemaElementDecl elementDecl;

		// Token: 0x0400113C RID: 4412
		private volatile XmlQualifiedName qname = XmlQualifiedName.Empty;

		// Token: 0x0400113D RID: 4413
		private XmlSchemaType redefined;

		// Token: 0x0400113E RID: 4414
		private XmlSchemaContentType contentType;
	}
}
