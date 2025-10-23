using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="attributeGroup" /> element with the <see langword="ref" /> attribute from the XML Schema as specified by the World Wide Web Consortium (W3C). AttributesGroupRef is the reference for an attributeGroup, name property contains the attribute group being referenced. </summary>
	// Token: 0x020002D8 RID: 728
	public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the name of the referenced <see langword="attributeGroup" /> element.</summary>
		/// <returns>The name of the referenced attribute group. The value must be a QName.</returns>
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00096421 File Offset: 0x00094621
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x00096429 File Offset: 0x00094629
		[XmlAttribute("ref")]
		public XmlQualifiedName RefName
		{
			get
			{
				return this.refName;
			}
			set
			{
				this.refName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		// Token: 0x04001051 RID: 4177
		private XmlQualifiedName refName = XmlQualifiedName.Empty;
	}
}
