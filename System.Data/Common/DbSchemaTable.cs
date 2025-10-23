using System;

namespace System.Data.Common
{
	// Token: 0x020000D5 RID: 213
	internal sealed class DbSchemaTable
	{
		// Token: 0x06000EB4 RID: 3764 RVA: 0x0004A16D File Offset: 0x0004836D
		internal DbSchemaTable(DataTable dataTable, bool returnProviderSpecificTypes)
		{
			this._dataTable = dataTable;
			this._columns = dataTable.Columns;
			this._returnProviderSpecificTypes = returnProviderSpecificTypes;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0004A1A1 File Offset: 0x000483A1
		internal DataColumn Size
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.ColumnSize);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0004A1AA File Offset: 0x000483AA
		internal DataColumn BaseTableName
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.BaseTableName);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0004A1B3 File Offset: 0x000483B3
		internal DataColumn IsAutoIncrement
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsAutoIncrement);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0004A1BC File Offset: 0x000483BC
		internal DataColumn IsUnique
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsUnique);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0004A1C6 File Offset: 0x000483C6
		internal DataColumn IsKey
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsKey);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0004A1D0 File Offset: 0x000483D0
		internal DataColumn AllowDBNull
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.AllowDBNull);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0004A1DA File Offset: 0x000483DA
		internal DataColumn IsHidden
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsHidden);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0004A1E4 File Offset: 0x000483E4
		internal DataColumn IsReadOnly
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsReadOnly);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0004A1EE File Offset: 0x000483EE
		internal DataColumn UnsortedIndex
		{
			get
			{
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.SchemaMappingUnsortedIndex);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0004A1F8 File Offset: 0x000483F8
		internal DataColumn DataType
		{
			get
			{
				if (this._returnProviderSpecificTypes)
				{
					return this.CachedDataColumn(DbSchemaTable.ColumnEnum.ProviderSpecificDataType, DbSchemaTable.ColumnEnum.DataType);
				}
				return this.CachedDataColumn(DbSchemaTable.ColumnEnum.DataType);
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0004A215 File Offset: 0x00048415
		private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column)
		{
			return this.CachedDataColumn(column, column);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0004A220 File Offset: 0x00048420
		private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column, DbSchemaTable.ColumnEnum column2)
		{
			DataColumn dataColumn = this._columnCache[(int)column];
			if (dataColumn == null)
			{
				int num = this._columns.IndexOf(DbSchemaTable.s_DBCOLUMN_NAME[(int)column]);
				if (-1 == num && column != column2)
				{
					num = this._columns.IndexOf(DbSchemaTable.s_DBCOLUMN_NAME[(int)column2]);
				}
				if (-1 != num)
				{
					dataColumn = this._columns[num];
					this._columnCache[(int)column] = dataColumn;
				}
			}
			return dataColumn;
		}

		// Token: 0x0400048E RID: 1166
		private static readonly string[] s_DBCOLUMN_NAME = new string[]
		{
			SchemaTableColumn.ColumnName,
			SchemaTableColumn.ColumnOrdinal,
			SchemaTableColumn.ColumnSize,
			SchemaTableOptionalColumn.BaseServerName,
			SchemaTableOptionalColumn.BaseCatalogName,
			SchemaTableColumn.BaseColumnName,
			SchemaTableColumn.BaseSchemaName,
			SchemaTableColumn.BaseTableName,
			SchemaTableOptionalColumn.IsAutoIncrement,
			SchemaTableColumn.IsUnique,
			SchemaTableColumn.IsKey,
			SchemaTableOptionalColumn.IsRowVersion,
			SchemaTableColumn.DataType,
			SchemaTableOptionalColumn.ProviderSpecificDataType,
			SchemaTableColumn.AllowDBNull,
			SchemaTableColumn.ProviderType,
			SchemaTableColumn.IsExpression,
			SchemaTableOptionalColumn.IsHidden,
			SchemaTableColumn.IsLong,
			SchemaTableOptionalColumn.IsReadOnly,
			"SchemaMapping Unsorted Index"
		};

		// Token: 0x0400048F RID: 1167
		internal DataTable _dataTable;

		// Token: 0x04000490 RID: 1168
		private DataColumnCollection _columns;

		// Token: 0x04000491 RID: 1169
		private DataColumn[] _columnCache = new DataColumn[DbSchemaTable.s_DBCOLUMN_NAME.Length];

		// Token: 0x04000492 RID: 1170
		private bool _returnProviderSpecificTypes;

		// Token: 0x020000D6 RID: 214
		private enum ColumnEnum
		{
			// Token: 0x04000494 RID: 1172
			ColumnName,
			// Token: 0x04000495 RID: 1173
			ColumnOrdinal,
			// Token: 0x04000496 RID: 1174
			ColumnSize,
			// Token: 0x04000497 RID: 1175
			BaseServerName,
			// Token: 0x04000498 RID: 1176
			BaseCatalogName,
			// Token: 0x04000499 RID: 1177
			BaseColumnName,
			// Token: 0x0400049A RID: 1178
			BaseSchemaName,
			// Token: 0x0400049B RID: 1179
			BaseTableName,
			// Token: 0x0400049C RID: 1180
			IsAutoIncrement,
			// Token: 0x0400049D RID: 1181
			IsUnique,
			// Token: 0x0400049E RID: 1182
			IsKey,
			// Token: 0x0400049F RID: 1183
			IsRowVersion,
			// Token: 0x040004A0 RID: 1184
			DataType,
			// Token: 0x040004A1 RID: 1185
			ProviderSpecificDataType,
			// Token: 0x040004A2 RID: 1186
			AllowDBNull,
			// Token: 0x040004A3 RID: 1187
			ProviderType,
			// Token: 0x040004A4 RID: 1188
			IsExpression,
			// Token: 0x040004A5 RID: 1189
			IsHidden,
			// Token: 0x040004A6 RID: 1190
			IsLong,
			// Token: 0x040004A7 RID: 1191
			IsReadOnly,
			// Token: 0x040004A8 RID: 1192
			SchemaMappingUnsortedIndex
		}
	}
}
