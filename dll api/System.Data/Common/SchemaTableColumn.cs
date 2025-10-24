using System;

namespace System.Data.Common
{
	/// <summary>Describes the column metadata of the schema for a database table.</summary>
	// Token: 0x02000102 RID: 258
	public static class SchemaTableColumn
	{
		/// <summary>Specifies the name of the column in the schema table.</summary>
		// Token: 0x0400052C RID: 1324
		public static readonly string ColumnName = "ColumnName";

		/// <summary>Specifies the ordinal of the column.</summary>
		// Token: 0x0400052D RID: 1325
		public static readonly string ColumnOrdinal = "ColumnOrdinal";

		/// <summary>Specifies the size of the column.</summary>
		// Token: 0x0400052E RID: 1326
		public static readonly string ColumnSize = "ColumnSize";

		/// <summary>Specifies the precision of the column data, if the data is numeric.</summary>
		// Token: 0x0400052F RID: 1327
		public static readonly string NumericPrecision = "NumericPrecision";

		/// <summary>Specifies the scale of the column data, if the data is numeric.</summary>
		// Token: 0x04000530 RID: 1328
		public static readonly string NumericScale = "NumericScale";

		/// <summary>Specifies the type of data in the column.</summary>
		// Token: 0x04000531 RID: 1329
		public static readonly string DataType = "DataType";

		/// <summary>Specifies the provider-specific data type of the column.</summary>
		// Token: 0x04000532 RID: 1330
		public static readonly string ProviderType = "ProviderType";

		/// <summary>Specifies the non-versioned provider-specific data type of the column.</summary>
		// Token: 0x04000533 RID: 1331
		public static readonly string NonVersionedProviderType = "NonVersionedProviderType";

		/// <summary>Specifies whether this column contains long data.</summary>
		// Token: 0x04000534 RID: 1332
		public static readonly string IsLong = "IsLong";

		/// <summary>Specifies whether value <see langword="DBNull" /> is allowed.</summary>
		// Token: 0x04000535 RID: 1333
		public static readonly string AllowDBNull = "AllowDBNull";

		/// <summary>Specifies whether this column is aliased.</summary>
		// Token: 0x04000536 RID: 1334
		public static readonly string IsAliased = "IsAliased";

		/// <summary>Specifies whether this column is an expression.</summary>
		// Token: 0x04000537 RID: 1335
		public static readonly string IsExpression = "IsExpression";

		/// <summary>Specifies whether this column is a key for the table. </summary>
		// Token: 0x04000538 RID: 1336
		public static readonly string IsKey = "IsKey";

		/// <summary>Specifies whether a unique constraint applies to this column.</summary>
		// Token: 0x04000539 RID: 1337
		public static readonly string IsUnique = "IsUnique";

		/// <summary>Specifies the name of the schema in the schema table.</summary>
		// Token: 0x0400053A RID: 1338
		public static readonly string BaseSchemaName = "BaseSchemaName";

		/// <summary>Specifies the name of the table in the schema table.</summary>
		// Token: 0x0400053B RID: 1339
		public static readonly string BaseTableName = "BaseTableName";

		/// <summary>Specifies the name of the column in the schema table.</summary>
		// Token: 0x0400053C RID: 1340
		public static readonly string BaseColumnName = "BaseColumnName";
	}
}
