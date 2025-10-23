using System;
using System.Globalization;

namespace System.Data.Common
{
	// Token: 0x020000D4 RID: 212
	internal sealed class DbSchemaRow
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x00049DD0 File Offset: 0x00047FD0
		internal static DbSchemaRow[] GetSortedSchemaRows(DataTable dataTable, bool returnProviderSpecificTypes)
		{
			DataColumn dataColumn = dataTable.Columns["SchemaMapping Unsorted Index"];
			if (dataColumn == null)
			{
				dataColumn = new DataColumn("SchemaMapping Unsorted Index", typeof(int));
				dataTable.Columns.Add(dataColumn);
			}
			int count = dataTable.Rows.Count;
			for (int i = 0; i < count; i++)
			{
				dataTable.Rows[i][dataColumn] = i;
			}
			DbSchemaTable schemaTable = new DbSchemaTable(dataTable, returnProviderSpecificTypes);
			DataRow[] array = dataTable.Select(null, "ColumnOrdinal ASC", DataViewRowState.CurrentRows);
			DbSchemaRow[] array2 = new DbSchemaRow[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				array2[j] = new DbSchemaRow(schemaTable, array[j]);
			}
			return array2;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00049E8C File Offset: 0x0004808C
		internal DbSchemaRow(DbSchemaTable schemaTable, DataRow dataRow)
		{
			this._schemaTable = schemaTable;
			this._dataRow = dataRow;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00049EA2 File Offset: 0x000480A2
		internal DataRow DataRow
		{
			get
			{
				return this._dataRow;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00049EAC File Offset: 0x000480AC
		internal int Size
		{
			get
			{
				object value = this._dataRow[this._schemaTable.Size, DataRowVersion.Default];
				if (!Convert.IsDBNull(value))
				{
					return Convert.ToInt32(value, CultureInfo.InvariantCulture);
				}
				return 0;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00049EEC File Offset: 0x000480EC
		internal string BaseTableName
		{
			get
			{
				if (this._schemaTable.BaseTableName != null)
				{
					object value = this._dataRow[this._schemaTable.BaseTableName, DataRowVersion.Default];
					if (!Convert.IsDBNull(value))
					{
						return Convert.ToString(value, CultureInfo.InvariantCulture);
					}
				}
				return string.Empty;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00049F3C File Offset: 0x0004813C
		internal bool IsAutoIncrement
		{
			get
			{
				if (this._schemaTable.IsAutoIncrement != null)
				{
					object value = this._dataRow[this._schemaTable.IsAutoIncrement, DataRowVersion.Default];
					if (!Convert.IsDBNull(value))
					{
						return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
					}
				}
				return false;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00049F88 File Offset: 0x00048188
		internal bool IsUnique
		{
			get
			{
				if (this._schemaTable.IsUnique != null)
				{
					object value = this._dataRow[this._schemaTable.IsUnique, DataRowVersion.Default];
					if (!Convert.IsDBNull(value))
					{
						return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
					}
				}
				return false;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00049FD4 File Offset: 0x000481D4
		internal bool IsKey
		{
			get
			{
				if (this._schemaTable.IsKey != null)
				{
					object value = this._dataRow[this._schemaTable.IsKey, DataRowVersion.Default];
					if (!Convert.IsDBNull(value))
					{
						return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
					}
				}
				return false;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0004A020 File Offset: 0x00048220
		internal bool IsHidden
		{
			get
			{
				if (this._schemaTable.IsHidden != null)
				{
					object value = this._dataRow[this._schemaTable.IsHidden, DataRowVersion.Default];
					if (!Convert.IsDBNull(value))
					{
						return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
					}
				}
				return false;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0004A06C File Offset: 0x0004826C
		internal bool IsReadOnly
		{
			get
			{
				if (this._schemaTable.IsReadOnly != null)
				{
					object value = this._dataRow[this._schemaTable.IsReadOnly, DataRowVersion.Default];
					if (!Convert.IsDBNull(value))
					{
						return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
					}
				}
				return false;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0004A0B8 File Offset: 0x000482B8
		internal Type DataType
		{
			get
			{
				if (this._schemaTable.DataType != null)
				{
					object obj = this._dataRow[this._schemaTable.DataType, DataRowVersion.Default];
					if (!Convert.IsDBNull(obj))
					{
						return (Type)obj;
					}
				}
				return null;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0004A100 File Offset: 0x00048300
		internal bool AllowDBNull
		{
			get
			{
				if (this._schemaTable.AllowDBNull != null)
				{
					object value = this._dataRow[this._schemaTable.AllowDBNull, DataRowVersion.Default];
					if (!Convert.IsDBNull(value))
					{
						return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
					}
				}
				return true;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0004A14B File Offset: 0x0004834B
		internal int UnsortedIndex
		{
			get
			{
				return (int)this._dataRow[this._schemaTable.UnsortedIndex, DataRowVersion.Default];
			}
		}

		// Token: 0x0400048C RID: 1164
		private DbSchemaTable _schemaTable;

		// Token: 0x0400048D RID: 1165
		private DataRow _dataRow;
	}
}
