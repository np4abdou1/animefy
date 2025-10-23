using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="list" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to define a <see langword="simpleType" /> element as a list of values of a specified data type.</summary>
	// Token: 0x0200031C RID: 796
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		/// <summary>Gets or sets the name of a built-in data type or <see langword="simpleType" /> element defined in this schema (or another schema indicated by the specified namespace).</summary>
		/// <returns>The type name of the simple type list.</returns>
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x0009AB38 File Offset: 0x00098D38
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0009AB40 File Offset: 0x00098D40
		[XmlAttribute("itemType")]
		public XmlQualifiedName ItemTypeName
		{
			get
			{
				return this.itemTypeName;
			}
			set
			{
				this.itemTypeName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>Gets or sets the <see langword="simpleType" /> element that is derived from the type specified by the base value.</summary>
		/// <returns>The item type for the simple type element.</returns>
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0009AB59 File Offset: 0x00098D59
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0009AB61 File Offset: 0x00098D61
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaSimpleType ItemType
		{
			get
			{
				return this.itemType;
			}
			set
			{
				this.itemType = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> representing the type of the <see langword="simpleType" /> element based on the <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeList.ItemType" /> and <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeList.ItemTypeName" /> values of the simple type.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> representing the type of the <see langword="simpleType" /> element.</returns>
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0009AB6A File Offset: 0x00098D6A
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0009AB72 File Offset: 0x00098D72
		[XmlIgnore]
		public XmlSchemaSimpleType BaseItemType
		{
			get
			{
				return this.baseItemType;
			}
			set
			{
				this.baseItemType = value;
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0009AB7B File Offset: 0x00098D7B
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaSimpleTypeList xmlSchemaSimpleTypeList = (XmlSchemaSimpleTypeList)base.MemberwiseClone();
			xmlSchemaSimpleTypeList.ItemTypeName = this.itemTypeName.Clone();
			return xmlSchemaSimpleTypeList;
		}

		// Token: 0x04001129 RID: 4393
		private XmlQualifiedName itemTypeName = XmlQualifiedName.Empty;

		// Token: 0x0400112A RID: 4394
		private XmlSchemaSimpleType itemType;

		// Token: 0x0400112B RID: 4395
		private XmlSchemaSimpleType baseItemType;
	}
}
