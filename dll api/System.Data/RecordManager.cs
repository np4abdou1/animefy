using System;
using System.Collections.Generic;
using System.Data.Common;

namespace System.Data
{
	// Token: 0x02000085 RID: 133
	internal sealed class RecordManager
	{
		// Token: 0x06000829 RID: 2089 RVA: 0x00028B04 File Offset: 0x00026D04
		internal RecordManager(DataTable table)
		{
			if (table == null)
			{
				throw ExceptionBuilder.ArgumentNull("table");
			}
			this._table = table;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00028B34 File Offset: 0x00026D34
		private void GrowRecordCapacity()
		{
			this.RecordCapacity = ((RecordManager.NewCapacity(this._recordCapacity) < this.NormalizedMinimumCapacity(this._minimumCapacity)) ? this.NormalizedMinimumCapacity(this._minimumCapacity) : RecordManager.NewCapacity(this._recordCapacity));
			DataRow[] array = this._table.NewRowArray(this._recordCapacity);
			if (this._rows != null)
			{
				Array.Copy(this._rows, 0, array, 0, Math.Min(this._lastFreeRecord, this._rows.Length));
			}
			this._rows = array;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00028BBB File Offset: 0x00026DBB
		internal int LastFreeRecord
		{
			get
			{
				return this._lastFreeRecord;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00028BC3 File Offset: 0x00026DC3
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00028BCB File Offset: 0x00026DCB
		internal int MinimumCapacity
		{
			get
			{
				return this._minimumCapacity;
			}
			set
			{
				if (this._minimumCapacity != value)
				{
					if (value < 0)
					{
						throw ExceptionBuilder.NegativeMinimumCapacity();
					}
					this._minimumCapacity = value;
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00028BE7 File Offset: 0x00026DE7
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00028BF0 File Offset: 0x00026DF0
		internal int RecordCapacity
		{
			get
			{
				return this._recordCapacity;
			}
			set
			{
				if (this._recordCapacity != value)
				{
					for (int i = 0; i < this._table.Columns.Count; i++)
					{
						this._table.Columns[i].SetCapacity(value);
					}
					this._recordCapacity = value;
				}
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00028C3F File Offset: 0x00026E3F
		internal static int NewCapacity(int capacity)
		{
			if (capacity >= 128)
			{
				return capacity + capacity;
			}
			return 128;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00028C52 File Offset: 0x00026E52
		private int NormalizedMinimumCapacity(int capacity)
		{
			if (capacity >= 1014)
			{
				return (capacity + 10 >> 10) + 1 << 10;
			}
			if (capacity >= 246)
			{
				return 1024;
			}
			if (capacity < 54)
			{
				return 64;
			}
			return 256;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00028C84 File Offset: 0x00026E84
		internal int NewRecordBase()
		{
			int result;
			if (this._freeRecordList.Count != 0)
			{
				result = this._freeRecordList[this._freeRecordList.Count - 1];
				this._freeRecordList.RemoveAt(this._freeRecordList.Count - 1);
			}
			else
			{
				if (this._lastFreeRecord >= this._recordCapacity)
				{
					this.GrowRecordCapacity();
				}
				result = this._lastFreeRecord;
				this._lastFreeRecord++;
			}
			return result;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00028CFC File Offset: 0x00026EFC
		internal void FreeRecord(ref int record)
		{
			if (-1 != record)
			{
				this[record] = null;
				int count = this._table._columnCollection.Count;
				for (int i = 0; i < count; i++)
				{
					this._table._columnCollection[i].FreeRecord(record);
				}
				if (this._lastFreeRecord == record + 1)
				{
					this._lastFreeRecord--;
				}
				else if (record < this._lastFreeRecord)
				{
					this._freeRecordList.Add(record);
				}
				record = -1;
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00028D84 File Offset: 0x00026F84
		internal void Clear(bool clearAll)
		{
			if (clearAll)
			{
				for (int i = 0; i < this._recordCapacity; i++)
				{
					this._rows[i] = null;
				}
				int count = this._table._columnCollection.Count;
				for (int j = 0; j < count; j++)
				{
					DataColumn dataColumn = this._table._columnCollection[j];
					for (int k = 0; k < this._recordCapacity; k++)
					{
						dataColumn.FreeRecord(k);
					}
				}
				this._lastFreeRecord = 0;
				this._freeRecordList.Clear();
				return;
			}
			this._freeRecordList.Capacity = this._freeRecordList.Count + this._table.Rows.Count;
			for (int l = 0; l < this._recordCapacity; l++)
			{
				if (this._rows[l] != null && this._rows[l].rowID != -1L)
				{
					int num = l;
					this.FreeRecord(ref num);
				}
			}
		}

		// Token: 0x1700013B RID: 315
		internal DataRow this[int record]
		{
			get
			{
				return this._rows[record];
			}
			set
			{
				this._rows[record] = value;
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00028E87 File Offset: 0x00027087
		internal int ImportRecord(DataTable src, int record)
		{
			return this.CopyRecord(src, record, -1);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00028E94 File Offset: 0x00027094
		internal int CopyRecord(DataTable src, int record, int copy)
		{
			if (record == -1)
			{
				return copy;
			}
			int num = -1;
			try
			{
				num = ((copy == -1) ? this._table.NewUninitializedRecord() : copy);
				int count = this._table.Columns.Count;
				for (int i = 0; i < count; i++)
				{
					DataColumn dataColumn = this._table.Columns[i];
					DataColumn dataColumn2 = src.Columns[dataColumn.ColumnName];
					if (dataColumn2 != null)
					{
						object obj = dataColumn2[record];
						ICloneable cloneable = obj as ICloneable;
						if (cloneable != null)
						{
							dataColumn[num] = cloneable.Clone();
						}
						else
						{
							dataColumn[num] = obj;
						}
					}
					else if (-1 == copy)
					{
						dataColumn.Init(num);
					}
				}
			}
			catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
			{
				if (-1 == copy)
				{
					this.FreeRecord(ref num);
				}
				throw;
			}
			return num;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00028F78 File Offset: 0x00027178
		internal void SetRowCache(DataRow[] newRows)
		{
			this._rows = newRows;
			this._lastFreeRecord = this._rows.Length;
			this._recordCapacity = this._lastFreeRecord;
		}

		// Token: 0x040002B5 RID: 693
		private readonly DataTable _table;

		// Token: 0x040002B6 RID: 694
		private int _lastFreeRecord;

		// Token: 0x040002B7 RID: 695
		private int _minimumCapacity = 50;

		// Token: 0x040002B8 RID: 696
		private int _recordCapacity;

		// Token: 0x040002B9 RID: 697
		private readonly List<int> _freeRecordList = new List<int>();

		// Token: 0x040002BA RID: 698
		private DataRow[] _rows;
	}
}
