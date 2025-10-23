using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="restriction" /> element for simple content from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to derive simple types by restriction. Such derivations can be used to restrict the range of values for the element to a subset of the values specified in the inherited simple type.</summary>
	// Token: 0x02000319 RID: 793
	public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
	{
		/// <summary>Gets or sets the name of the built-in data type or simple type from which this type is derived.</summary>
		/// <returns>The name of the base type.</returns>
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0009AA5F File Offset: 0x00098C5F
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0009AA67 File Offset: 0x00098C67
		[XmlAttribute("base")]
		public XmlQualifiedName BaseTypeName
		{
			get
			{
				return this.baseTypeName;
			}
			set
			{
				this.baseTypeName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>Gets or sets the simple type base value.</summary>
		/// <returns>The simple type base value.</returns>
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0009AA80 File Offset: 0x00098C80
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0009AA88 File Offset: 0x00098C88
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaSimpleType BaseType
		{
			get
			{
				return this.baseType;
			}
			set
			{
				this.baseType = value;
			}
		}

		/// <summary>Gets or sets an Xml Schema facet. </summary>
		/// <returns>One of the following facet classes:
		///     <see cref="T:System.Xml.Schema.XmlSchemaLengthFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaMinLengthFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaMaxLengthFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaPatternFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaEnumerationFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaMaxInclusiveFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaMaxExclusiveFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaMinInclusiveFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaMinExclusiveFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaFractionDigitsFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaTotalDigitsFacet" />, <see cref="T:System.Xml.Schema.XmlSchemaWhiteSpaceFacet" />.</returns>
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0009AA91 File Offset: 0x00098C91
		[XmlElement("length", typeof(XmlSchemaLengthFacet))]
		[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
		[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
		[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
		[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
		[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
		[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
		[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
		[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
		[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
		[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
		[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
		public XmlSchemaObjectCollection Facets
		{
			get
			{
				return this.facets;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> and <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> collection of attributes for the simple type.</summary>
		/// <returns>The collection of attributes for a simple type.</returns>
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x0009AA99 File Offset: 0x00098C99
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		public XmlSchemaObjectCollection Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets or sets an <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> to be used for the attribute value.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> for the attribute value.Optional.</returns>
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0009AAA1 File Offset: 0x00098CA1
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0009AAA9 File Offset: 0x00098CA9
		[XmlElement("anyAttribute")]
		public XmlSchemaAnyAttribute AnyAttribute
		{
			get
			{
				return this.anyAttribute;
			}
			set
			{
				this.anyAttribute = value;
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0009AAB2 File Offset: 0x00098CB2
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x04001123 RID: 4387
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;

		// Token: 0x04001124 RID: 4388
		private XmlSchemaSimpleType baseType;

		// Token: 0x04001125 RID: 4389
		private XmlSchemaObjectCollection facets = new XmlSchemaObjectCollection();

		// Token: 0x04001126 RID: 4390
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04001127 RID: 4391
		private XmlSchemaAnyAttribute anyAttribute;
	}
}
