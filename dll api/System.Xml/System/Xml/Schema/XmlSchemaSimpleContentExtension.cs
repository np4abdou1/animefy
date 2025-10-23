using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="extension" /> element for simple content from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to derive simple types by extension. Such derivations are used to extend the simple type content of the element by adding attributes.</summary>
	// Token: 0x02000318 RID: 792
	public class XmlSchemaSimpleContentExtension : XmlSchemaContent
	{
		/// <summary>Gets or sets the name of a built-in data type or simple type from which this type is extended.</summary>
		/// <returns>The base type name.</returns>
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x0009A9FE File Offset: 0x00098BFE
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x0009AA06 File Offset: 0x00098C06
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

		/// <summary>Gets the collection of <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> and <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" />.</summary>
		/// <returns>The collection of attributes for the <see langword="simpleType" /> element.</returns>
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x0009AA1F File Offset: 0x00098C1F
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		public XmlSchemaObjectCollection Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets or sets the <see langword="XmlSchemaAnyAttribute" /> to be used for the attribute value.</summary>
		/// <returns>The <see langword="XmlSchemaAnyAttribute" />.Optional.</returns>
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0009AA27 File Offset: 0x00098C27
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0009AA2F File Offset: 0x00098C2F
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

		// Token: 0x06001A54 RID: 6740 RVA: 0x0009AA38 File Offset: 0x00098C38
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x04001120 RID: 4384
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04001121 RID: 4385
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04001122 RID: 4386
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;
	}
}
