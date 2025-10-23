using System;

namespace System.Data.Common
{
	/// <summary>Describes optional column metadata of the schema for a database table.</summary>
	// Token: 0x02000103 RID: 259
	public static class SchemaTableOptionalColumn
	{
		/// <summary>Specifies the provider-specific data type of the column.</summary>
		// Token: 0x0400053D RID: 1341
		public static readonly string ProviderSpecificDataType = "ProviderSpecificDataType";

		/// <summary>Specifies whether the column values in the column are automatically incremented.</summary>
		// Token: 0x0400053E RID: 1342
		public static readonly string IsAutoIncrement = "IsAutoIncrement";

		/// <summary>Specifies whether this column is hidden.</summary>
		// Token: 0x0400053F RID: 1343
		public static readonly string IsHidden = "IsHidden";

		/// <summary>Specifies whether this column is read-only.</summary>
		// Token: 0x04000540 RID: 1344
		public static readonly string IsReadOnly = "IsReadOnly";

		/// <summary>Specifies whether this column contains row version information.</summary>
		// Token: 0x04000541 RID: 1345
		public static readonly string IsRowVersion = "IsRowVersion";

		/// <summary>The server name of the column.</summary>
		// Token: 0x04000542 RID: 1346
		public static readonly string BaseServerName = "BaseServerName";

		/// <summary>The name of the catalog associated with the results of the latest query.</summary>
		// Token: 0x04000543 RID: 1347
		public static readonly string BaseCatalogName = "BaseCatalogName";

		/// <summary>Specifies the value at which the series for new identity columns is assigned.</summary>
		// Token: 0x04000544 RID: 1348
		public static readonly string AutoIncrementSeed = "AutoIncrementSeed";

		/// <summary>Specifies the increment between values in the identity column.</summary>
		// Token: 0x04000545 RID: 1349
		public static readonly string AutoIncrementStep = "AutoIncrementStep";

		/// <summary>The default value for the column.</summary>
		// Token: 0x04000546 RID: 1350
		public static readonly string DefaultValue = "DefaultValue";

		/// <summary>The expression used to compute the column.</summary>
		// Token: 0x04000547 RID: 1351
		public static readonly string Expression = "Expression";

		/// <summary>The namespace for the table that contains the column.</summary>
		// Token: 0x04000548 RID: 1352
		public static readonly string BaseTableNamespace = "BaseTableNamespace";

		/// <summary>The namespace of the column.</summary>
		// Token: 0x04000549 RID: 1353
		public static readonly string BaseColumnNamespace = "BaseColumnNamespace";

		/// <summary>Specifies the mapping for the column.</summary>
		// Token: 0x0400054A RID: 1354
		public static readonly string ColumnMapping = "ColumnMapping";
	}
}
