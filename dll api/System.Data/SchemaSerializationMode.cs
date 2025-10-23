using System;

namespace System.Data
{
	/// <summary>Indicates the schema serialization mode for a typed <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000089 RID: 137
	public enum SchemaSerializationMode
	{
		/// <summary>Includes schema serialization for a typed <see cref="T:System.Data.DataSet" />. The default.</summary>
		// Token: 0x040002C5 RID: 709
		IncludeSchema = 1,
		/// <summary>Skips schema serialization for a typed <see cref="T:System.Data.DataSet" />.</summary>
		// Token: 0x040002C6 RID: 710
		ExcludeSchema
	}
}
