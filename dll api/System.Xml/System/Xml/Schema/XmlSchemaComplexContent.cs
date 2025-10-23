using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="complexContent" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class represents the complex content model for complex types. It contains extensions or restrictions on a complex type that has either only elements or mixed content.</summary>
	// Token: 0x020002DE RID: 734
	public class XmlSchemaComplexContent : XmlSchemaContentModel
	{
		/// <summary>Gets or sets information that determines if the type has a mixed content model.</summary>
		/// <returns>If this property is <see langword="true" />, character data is allowed to appear between the child elements of the complex type (mixed content model). The default is <see langword="false" />.Optional.</returns>
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00096812 File Offset: 0x00094A12
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0009681A File Offset: 0x00094A1A
		[XmlAttribute("mixed")]
		public bool IsMixed
		{
			get
			{
				return this.isMixed;
			}
			set
			{
				this.isMixed = value;
				this.hasMixedAttribute = true;
			}
		}

		/// <summary>Gets or sets the content.</summary>
		/// <returns>One of either the <see cref="T:System.Xml.Schema.XmlSchemaComplexContentRestriction" /> or <see cref="T:System.Xml.Schema.XmlSchemaComplexContentExtension" /> classes.</returns>
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0009682A File Offset: 0x00094A2A
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x00096832 File Offset: 0x00094A32
		[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
		[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
		public override XmlSchemaContent Content
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

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x0009683B File Offset: 0x00094A3B
		[XmlIgnore]
		internal bool HasMixedAttribute
		{
			get
			{
				return this.hasMixedAttribute;
			}
		}

		// Token: 0x04001060 RID: 4192
		private XmlSchemaContent content;

		// Token: 0x04001061 RID: 4193
		private bool isMixed;

		// Token: 0x04001062 RID: 4194
		private bool hasMixedAttribute;
	}
}
