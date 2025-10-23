using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="extension" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is for complex types with complex content model derived by extension. It extends the complex type by adding attributes or elements.</summary>
	// Token: 0x020002DF RID: 735
	public class XmlSchemaComplexContentExtension : XmlSchemaContent
	{
		/// <summary>Gets or sets the name of the complex type from which this type is derived by extension.</summary>
		/// <returns>The name of the complex type from which this type is derived by extension.</returns>
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0009684B File Offset: 0x00094A4B
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x00096853 File Offset: 0x00094A53
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

		/// <summary>Gets or sets one of the <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</summary>
		/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</returns>
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0009686C File Offset: 0x00094A6C
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x00096874 File Offset: 0x00094A74
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		public XmlSchemaParticle Particle
		{
			get
			{
				return this.particle;
			}
			set
			{
				this.particle = value;
			}
		}

		/// <summary>Gets the collection of attributes for the complex content. Contains <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> and <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> elements.</summary>
		/// <returns>The collection of attributes for the complex content.</returns>
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0009687D File Offset: 0x00094A7D
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		public XmlSchemaObjectCollection Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex content model.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex content model.</returns>
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x00096885 File Offset: 0x00094A85
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x0009688D File Offset: 0x00094A8D
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

		// Token: 0x06001899 RID: 6297 RVA: 0x00096896 File Offset: 0x00094A96
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x04001063 RID: 4195
		private XmlSchemaParticle particle;

		// Token: 0x04001064 RID: 4196
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04001065 RID: 4197
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04001066 RID: 4198
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;
	}
}
