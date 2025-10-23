using System;

namespace System.Data
{
	/// <summary>Determines the serialization format for a <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000037 RID: 55
	public enum SerializationFormat
	{
		/// <summary>Serialize as XML content. The default.</summary>
		// Token: 0x040000B5 RID: 181
		Xml,
		/// <summary>Serialize as binary content. Available in ADO.NET 2.0 only.</summary>
		// Token: 0x040000B6 RID: 182
		Binary
	}
}
