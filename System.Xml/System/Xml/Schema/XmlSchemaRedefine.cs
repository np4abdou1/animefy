using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="redefine" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to allow simple and complex types, groups and attribute groups from external schema files to be redefined in the current schema. This class can also be used to provide versioning for the schema elements.</summary>
	// Token: 0x02000314 RID: 788
	public class XmlSchemaRedefine : XmlSchemaExternal
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaRedefine" /> class.</summary>
		// Token: 0x06001A0F RID: 6671 RVA: 0x00098C6F File Offset: 0x00096E6F
		public XmlSchemaRedefine()
		{
			base.Compositor = Compositor.Redefine;
		}

		/// <summary>Gets the collection of the following classes: <see cref="T:System.Xml.Schema.XmlSchemaAnnotation" />, <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroup" />, <see cref="T:System.Xml.Schema.XmlSchemaComplexType" />, <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" />, and <see cref="T:System.Xml.Schema.XmlSchemaGroup" />.</summary>
		/// <returns>The elements contained within the redefine element.</returns>
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00098CAA File Offset: 0x00096EAA
		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
		[XmlElement("complexType", typeof(XmlSchemaComplexType))]
		[XmlElement("group", typeof(XmlSchemaGroup))]
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> , for all attributes in the schema, which holds the post-compilation value of the <see langword="AttributeGroups" /> property.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> for all attributes in the schema. The post-compilation value of the <see langword="AttributeGroups" /> property.</returns>
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00098CB2 File Offset: 0x00096EB2
		[XmlIgnore]
		public XmlSchemaObjectTable AttributeGroups
		{
			get
			{
				return this.attributeGroups;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />, for all simple and complex types in the schema, which holds the post-compilation value of the <see langword="SchemaTypes" /> property.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> for all schema types in the schema. The post-compilation value of the <see langword="SchemaTypes" /> property.</returns>
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00098CBA File Offset: 0x00096EBA
		[XmlIgnore]
		public XmlSchemaObjectTable SchemaTypes
		{
			get
			{
				return this.types;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />, for all groups in the schema, which holds the post-compilation value of the <see langword="Groups" /> property.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> for all groups in the schema. The post-compilation value of the <see langword="Groups" /> property.</returns>
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00098CC2 File Offset: 0x00096EC2
		[XmlIgnore]
		public XmlSchemaObjectTable Groups
		{
			get
			{
				return this.groups;
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00098CCA File Offset: 0x00096ECA
		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			this.items.Add(annotation);
		}

		// Token: 0x04001106 RID: 4358
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();

		// Token: 0x04001107 RID: 4359
		private XmlSchemaObjectTable attributeGroups = new XmlSchemaObjectTable();

		// Token: 0x04001108 RID: 4360
		private XmlSchemaObjectTable types = new XmlSchemaObjectTable();

		// Token: 0x04001109 RID: 4361
		private XmlSchemaObjectTable groups = new XmlSchemaObjectTable();
	}
}
