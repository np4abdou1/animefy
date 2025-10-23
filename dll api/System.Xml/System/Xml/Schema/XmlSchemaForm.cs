using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Indicates if attributes or elements need to be qualified with a namespace prefix.</summary>
	// Token: 0x020002FB RID: 763
	public enum XmlSchemaForm
	{
		/// <summary>Element and attribute form is not specified in the schema.</summary>
		// Token: 0x040010C4 RID: 4292
		[XmlIgnore]
		None,
		/// <summary>Elements and attributes must be qualified with a namespace prefix.</summary>
		// Token: 0x040010C5 RID: 4293
		[XmlEnum("qualified")]
		Qualified,
		/// <summary>Elements and attributes are not required to be qualified with a namespace prefix.</summary>
		// Token: 0x040010C6 RID: 4294
		[XmlEnum("unqualified")]
		Unqualified
	}
}
