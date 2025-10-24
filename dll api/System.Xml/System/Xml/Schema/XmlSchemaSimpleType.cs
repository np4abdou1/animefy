using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="simpleType" /> element for simple content from XML Schema as specified by the World Wide Web Consortium (W3C). This class defines a simple type. Simple types can specify information and constraints for the value of attributes or elements with text-only content.</summary>
	// Token: 0x0200031A RID: 794
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		/// <summary>Gets or sets one of <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeUnion" />, <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeList" />, or <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeRestriction" />.</summary>
		/// <returns>One of <see langword="XmlSchemaSimpleTypeUnion" />, <see langword="XmlSchemaSimpleTypeList" />, or <see langword="XmlSchemaSimpleTypeRestriction" />.</returns>
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0009AAEC File Offset: 0x00098CEC
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0009AAF4 File Offset: 0x00098CF4
		[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
		[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
		[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
		public XmlSchemaSimpleTypeContent Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.content = value;
			}
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0009AB00 File Offset: 0x00098D00
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaSimpleType xmlSchemaSimpleType = (XmlSchemaSimpleType)base.MemberwiseClone();
			if (this.content != null)
			{
				xmlSchemaSimpleType.Content = (XmlSchemaSimpleTypeContent)this.content.Clone();
			}
			return xmlSchemaSimpleType;
		}

		// Token: 0x04001128 RID: 4392
		private XmlSchemaSimpleTypeContent content;
	}
}
