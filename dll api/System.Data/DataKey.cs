using System;

namespace System.Data
{
	// Token: 0x02000025 RID: 37
	internal readonly struct DataKey
	{
		// Token: 0x0600027E RID: 638 RVA: 0x00008480 File Offset: 0x00006680
		internal DataKey(DataColumn[] columns, bool copyColumns)
		{
			if (columns == null)
			{
				throw ExceptionBuilder.ArgumentNull("columns");
			}
			if (columns.Length == 0)
			{
				throw ExceptionBuilder.KeyNoColumns();
			}
			if (columns.Length > 32)
			{
				throw ExceptionBuilder.KeyTooManyColumns(32);
			}
			for (int i = 0; i < columns.Length; i++)
			{
				if (columns[i] == null)
				{
					throw ExceptionBuilder.ArgumentNull("column");
				}
			}
			for (int j = 0; j < columns.Length; j++)
			{
				for (int k = 0; k < j; k++)
				{
					if (columns[j] == columns[k])
					{
						throw ExceptionBuilder.KeyDuplicateColumns(columns[j].ColumnName);
					}
				}
			}
			if (copyColumns)
			{
				this._columns = new DataColumn[columns.Length];
				for (int l = 0; l < columns.Length; l++)
				{
					this._columns[l] = columns[l];
				}
			}
			else
			{
				this._columns = columns;
			}
			this.CheckState();
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000853B File Offset: 0x0000673B
		internal DataColumn[] ColumnsReference
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00008543 File Offset: 0x00006743
		internal bool HasValue
		{
			get
			{
				return this._columns != null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000854E File Offset: 0x0000674E
		internal DataTable Table
		{
			get
			{
				return this._columns[0].Table;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00008560 File Offset: 0x00006760
		internal void CheckState()
		{
			DataTable table = this._columns[0].Table;
			if (table == null)
			{
				throw ExceptionBuilder.ColumnNotInAnyTable();
			}
			for (int i = 1; i < this._columns.Length; i++)
			{
				if (this._columns[i].Table == null)
				{
					throw ExceptionBuilder.ColumnNotInAnyTable();
				}
				if (this._columns[i].Table != table)
				{
					throw ExceptionBuilder.KeyTableMismatch();
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000085C2 File Offset: 0x000067C2
		internal bool ColumnsEqual(DataKey key)
		{
			return DataKey.ColumnsEqual(this._columns, key._columns);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000085D8 File Offset: 0x000067D8
		internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2)
		{
			if (column1 == column2)
			{
				return true;
			}
			if (column1 == null || column2 == null)
			{
				return false;
			}
			if (column1.Length != column2.Length)
			{
				return false;
			}
			for (int i = 0; i < column1.Length; i++)
			{
				bool flag = false;
				for (int j = 0; j < column2.Length; j++)
				{
					if (column1[i].Equals(column2[j]))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00008634 File Offset: 0x00006834
		internal bool ContainsColumn(DataColumn column)
		{
			for (int i = 0; i < this._columns.Length; i++)
			{
				if (column == this._columns[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00008662 File Offset: 0x00006862
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00008674 File Offset: 0x00006874
		public override bool Equals(object value)
		{
			return this.Equals((DataKey)value);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00008684 File Offset: 0x00006884
		internal bool Equals(DataKey value)
		{
			DataColumn[] columns = this._columns;
			DataColumn[] columns2 = value._columns;
			if (columns == columns2)
			{
				return true;
			}
			if (columns == null || columns2 == null)
			{
				return false;
			}
			if (columns.Length != columns2.Length)
			{
				return false;
			}
			for (int i = 0; i < columns.Length; i++)
			{
				if (!columns[i].Equals(columns2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000086D8 File Offset: 0x000068D8
		internal string[] GetColumnNames()
		{
			string[] array = new string[this._columns.Length];
			for (int i = 0; i < this._columns.Length; i++)
			{
				array[i] = this._columns[i].ColumnName;
			}
			return array;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00008718 File Offset: 0x00006918
		internal IndexField[] GetIndexDesc()
		{
			IndexField[] array = new IndexField[this._columns.Length];
			for (int i = 0; i < this._columns.Length; i++)
			{
				array[i] = new IndexField(this._columns[i], false);
			}
			return array;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000875C File Offset: 0x0000695C
		internal object[] GetKeyValues(int record)
		{
			object[] array = new object[this._columns.Length];
			for (int i = 0; i < this._columns.Length; i++)
			{
				array[i] = this._columns[i][record];
			}
			return array;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000879C File Offset: 0x0000699C
		internal Index GetSortIndex()
		{
			return this.GetSortIndex(DataViewRowState.CurrentRows);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000087A8 File Offset: 0x000069A8
		internal Index GetSortIndex(DataViewRowState recordStates)
		{
			IndexField[] indexDesc = this.GetIndexDesc();
			return this._columns[0].Table.GetIndex(indexDesc, recordStates, null);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000087D4 File Offset: 0x000069D4
		internal bool RecordsEqual(int record1, int record2)
		{
			for (int i = 0; i < this._columns.Length; i++)
			{
				if (this._columns[i].Compare(record1, record2) != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00008808 File Offset: 0x00006A08
		internal DataColumn[] ToArray()
		{
			DataColumn[] array = new DataColumn[this._columns.Length];
			for (int i = 0; i < this._columns.Length; i++)
			{
				array[i] = this._columns[i];
			}
			return array;
		}

		// Token: 0x04000062 RID: 98
		private readonly DataColumn[] _columns;
	}
}
