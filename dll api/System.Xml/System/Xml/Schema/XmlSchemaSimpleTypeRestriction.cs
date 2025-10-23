using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="restriction" /> element for simple types from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used restricting <see langword="simpleType" /> element.</summary>
	// Token: 0x0200031D RID: 797
	public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
	{
		/// <summary>Gets or sets the name of the qualified base type.</summary>
		/// <returns>The qualified name of the simple type restriction base type.</returns>
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0009ABAC File Offset: 0x00098DAC
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0009ABB4 File Offset: 0x00098DB4
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

		/// <summary>Gets or sets information on the base type.</summary>
		/// <returns>The base type for the <see langword="simpleType" /> element.</returns>
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0009ABCD File Offset: 0x00098DCD
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0009ABD5 File Offset: 0x00098DD5
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
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x0009ABDE File Offset: 0x00098DDE
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

		// Token: 0x06001A72 RID: 6770 RVA: 0x0009ABE6 File Offset: 0x00098DE6
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaSimpleTypeRestriction xmlSchemaSimpleTypeRestriction = (XmlSchemaSimpleTypeRestriction)base.MemberwiseClone();
			xmlSchemaSimpleTypeRestriction.BaseTypeName = this.baseTypeName.Clone();
			return xmlSchemaSimpleTypeRestriction;
		}

		// Token: 0x0400112C RID: 4396
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;

		// Token: 0x0400112D RID: 4397
		private XmlSchemaSimpleType baseType;

		// Token: 0x0400112E RID: 4398
		private XmlSchemaObjectCollection facets = new XmlSchemaObjectCollection();
	}
}
