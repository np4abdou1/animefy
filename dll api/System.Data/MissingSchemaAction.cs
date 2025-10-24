﻿using System;

namespace System.Data
{
	/// <summary>Specifies the action to take when adding data to the <see cref="T:System.Data.DataSet" /> and the required <see cref="T:System.Data.DataTable" /> or <see cref="T:System.Data.DataColumn" /> is missing.</summary>
	// Token: 0x02000079 RID: 121
	public enum MissingSchemaAction
	{
		/// <summary>Adds the necessary columns to complete the schema.</summary>
		// Token: 0x04000278 RID: 632
		Add = 1,
		/// <summary>Ignores the extra columns.</summary>
		// Token: 0x04000279 RID: 633
		Ignore,
		/// <summary>An <see cref="T:System.InvalidOperationException" /> is generated if the specified column mapping is missing.</summary>
		// Token: 0x0400027A RID: 634
		Error,
		/// <summary>Adds the necessary columns and primary key information to complete the schema. For more information about how primary key information is added to a <see cref="T:System.Data.DataTable" />, see <see cref="M:System.Data.IDataAdapter.FillSchema(System.Data.DataSet,System.Data.SchemaType)" />.To function properly with the .NET Framework Data Provider for OLE DB, <see langword="AddWithKey" /> requires that the native OLE DB provider obtains necessary primary key information by setting the DBPROP_UNIQUEROWS property, and then determines which columns are primary key columns by examining DBCOLUMN_KEYCOLUMN in the IColumnsRowset. As an alternative, the user may explicitly set the primary key constraints on each <see cref="T:System.Data.DataTable" />. This ensures that incoming records that match existing records are updated instead of appended. When using <see langword="AddWithKey" />, the .NET Framework Data Provider for SQL Server appends a FOR BROWSE clause to the statement being executed. The user should be aware of potential side effects, such as interference with the use of SET FMTONLY ON statements. See SQL Server Books Online for more information.</summary>
		// Token: 0x0400027B RID: 635
		AddWithKey
	}
}
