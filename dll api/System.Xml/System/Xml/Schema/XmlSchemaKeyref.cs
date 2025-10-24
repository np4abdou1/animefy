using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>This class represents the <see langword="keyref" /> element from XMLSchema as specified by the World Wide Web Consortium (W3C).</summary>
	// Token: 0x02000303 RID: 771
	public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
	{
		/// <summary>Gets or sets the name of the key that this constraint refers to in another simple or complex type.</summary>
		/// <returns>The QName of the key that this constraint refers to.</returns>
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x00098063 File Offset: 0x00096263
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x0009806B File Offset: 0x0009626B
		[XmlAttribute("refer")]
		public XmlQualifiedName Refer
		{
			get
			{
				return this.refer;
			}
			set
			{
				this.refer = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		// Token: 0x040010D6 RID: 4310
		private XmlQualifiedName refer = XmlQualifiedName.Empty;
	}
}
