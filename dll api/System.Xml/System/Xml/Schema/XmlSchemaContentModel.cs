using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Specifies the order and structure of the child elements of a type.</summary>
	// Token: 0x020002E3 RID: 739
	public abstract class XmlSchemaContentModel : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the content of the type.</summary>
		/// <returns>Provides the content of the type.</returns>
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060018CD RID: 6349
		// (set) Token: 0x060018CE RID: 6350
		[XmlIgnore]
		public abstract XmlSchemaContent Content { get; set; }
	}
}
