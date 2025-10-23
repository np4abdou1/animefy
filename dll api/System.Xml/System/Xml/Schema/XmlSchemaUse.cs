using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Indicator of how the attribute is used.</summary>
	// Token: 0x02000322 RID: 802
	public enum XmlSchemaUse
	{
		/// <summary>Attribute use not specified.</summary>
		// Token: 0x04001140 RID: 4416
		[XmlIgnore]
		None,
		/// <summary>Attribute is optional.</summary>
		// Token: 0x04001141 RID: 4417
		[XmlEnum("optional")]
		Optional,
		/// <summary>Attribute cannot be used.</summary>
		// Token: 0x04001142 RID: 4418
		[XmlEnum("prohibited")]
		Prohibited,
		/// <summary>Attribute must appear once.</summary>
		// Token: 0x04001143 RID: 4419
		[XmlEnum("required")]
		Required
	}
}
