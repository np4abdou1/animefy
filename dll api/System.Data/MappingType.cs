using System;

namespace System.Data
{
	/// <summary>Specifies how a <see cref="T:System.Data.DataColumn" /> is mapped.</summary>
	// Token: 0x02000074 RID: 116
	public enum MappingType
	{
		/// <summary>The column is mapped to an XML element.</summary>
		// Token: 0x04000267 RID: 615
		Element = 1,
		/// <summary>The column is mapped to an XML attribute.</summary>
		// Token: 0x04000268 RID: 616
		Attribute,
		/// <summary>The column is mapped to an <see cref="T:System.Xml.XmlText" /> node.</summary>
		// Token: 0x04000269 RID: 617
		SimpleContent,
		/// <summary>The column is mapped to an internal structure.</summary>
		// Token: 0x0400026A RID: 618
		Hidden
	}
}
