using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="restriction" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is for complex types with a complex content model derived by restriction. It restricts the contents of the complex type to a subset of the inherited complex type.</summary>
	// Token: 0x020002E0 RID: 736
	public class XmlSchemaComplexContentRestriction : XmlSchemaContent
	{
		/// <summary>Gets or sets the name of a complex type from which this type is derived by restriction.</summary>
		/// <returns>The name of the complex type from which this type is derived by restriction.</returns>
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x000968BD File Offset: 0x00094ABD
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x000968C5 File Offset: 0x00094AC5
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
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x000968DE File Offset: 0x00094ADE
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x000968E6 File Offset: 0x00094AE6
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

		/// <summary>Gets the collection of attributes for the complex type. Contains the <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> and <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> elements.</summary>
		/// <returns>The collection of attributes for the complex type.</returns>
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x000968EF File Offset: 0x00094AEF
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
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x000968F7 File Offset: 0x00094AF7
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x000968FF File Offset: 0x00094AFF
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

		// Token: 0x060018A2 RID: 6306 RVA: 0x00096908 File Offset: 0x00094B08
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x04001067 RID: 4199
		private XmlSchemaParticle particle;

		// Token: 0x04001068 RID: 4200
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04001069 RID: 4201
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x0400106A RID: 4202
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;
	}
}
