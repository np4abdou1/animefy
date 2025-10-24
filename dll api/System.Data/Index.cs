using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace System.Data
{
	// Token: 0x0200008E RID: 142
	internal sealed class Index
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x0002AA48 File Offset: 0x00028C48
		public Index(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) : this(table, indexFields, null, recordStates, rowFilter)
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0002AA56 File Offset: 0x00028C56
		public Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) : this(table, Index.GetAllFields(table.Columns), comparison, recordStates, rowFilter)
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0002AA70 File Offset: 0x00028C70
		private static IndexField[] GetAllFields(DataColumnCollection columns)
		{
			IndexField[] array = new IndexField[columns.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new IndexField(columns[i], false);
			}
			return array;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0002AAAC File Offset: 0x00028CAC
		private Index(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter)
		{
			DataCommonEventSource.Log.Trace<int, int, DataViewRowState>("<ds.Index.Index|API> {0}, table={1}, recordStates={2}", this.ObjectID, (table != null) ? table.ObjectID : 0, recordStates);
			if ((recordStates & ~(DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent | DataViewRowState.ModifiedOriginal)) != DataViewRowState.None)
			{
				throw ExceptionBuilder.RecordStateRange();
			}
			this._table = table;
			this._listeners = new Listeners<DataViewListener>(this.ObjectID, (DataViewListener listener) => listener != null);
			this._indexFields = indexFields;
			this._recordStates = recordStates;
			this._comparison = comparison;
			DataColumnCollection columns = table.Columns;
			this._isSharable = (rowFilter == null && comparison == null);
			if (rowFilter != null)
			{
				this._rowFilter = new WeakReference(rowFilter);
				DataExpression dataExpression = rowFilter as DataExpression;
				if (dataExpression != null)
				{
					this._hasRemoteAggregate = dataExpression.HasRemoteAggregate();
				}
			}
			this.InitRecords(rowFilter);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0002AB94 File Offset: 0x00028D94
		public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
		{
			if (!this._isSharable || this._indexFields.Length != indexDesc.Length || this._recordStates != recordStates || rowFilter != null)
			{
				return false;
			}
			for (int i = 0; i < this._indexFields.Length; i++)
			{
				if (this._indexFields[i].Column != indexDesc[i].Column || this._indexFields[i].IsDescending != indexDesc[i].IsDescending)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0002AC18 File Offset: 0x00028E18
		internal bool HasRemoteAggregate
		{
			get
			{
				return this._hasRemoteAggregate;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0002AC20 File Offset: 0x00028E20
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0002AC28 File Offset: 0x00028E28
		public DataViewRowState RecordStates
		{
			get
			{
				return this._recordStates;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0002AC30 File Offset: 0x00028E30
		public IFilter RowFilter
		{
			get
			{
				return (IFilter)((this._rowFilter != null) ? this._rowFilter.Target : null);
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0002AC4D File Offset: 0x00028E4D
		public int GetRecord(int recordIndex)
		{
			return this._records[recordIndex];
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0002AC5B File Offset: 0x00028E5B
		public bool HasDuplicates
		{
			get
			{
				return this._records.HasDuplicates;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0002AC68 File Offset: 0x00028E68
		public int RecordCount
		{
			get
			{
				return this._recordCount;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0002AC70 File Offset: 0x00028E70
		public bool IsSharable
		{
			get
			{
				return this._isSharable;
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0002AC78 File Offset: 0x00028E78
		private bool AcceptRecord(int record)
		{
			return this.AcceptRecord(record, this.RowFilter);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0002AC88 File Offset: 0x00028E88
		private bool AcceptRecord(int record, IFilter filter)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.Index.AcceptRecord|API> {0}, record={1}", this.ObjectID, record);
			if (filter == null)
			{
				return true;
			}
			DataRow dataRow = this._table._recordManager[record];
			if (dataRow == null)
			{
				return true;
			}
			DataRowVersion version = DataRowVersion.Default;
			if (dataRow._oldRecord == record)
			{
				version = DataRowVersion.Original;
			}
			else if (dataRow._newRecord == record)
			{
				version = DataRowVersion.Current;
			}
			else if (dataRow._tempRecord == record)
			{
				version = DataRowVersion.Proposed;
			}
			return filter.Invoke(dataRow, version);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0002AD06 File Offset: 0x00028F06
		internal void ListChangedAdd(DataViewListener listener)
		{
			this._listeners.Add(listener);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0002AD14 File Offset: 0x00028F14
		internal void ListChangedRemove(DataViewListener listener)
		{
			this._listeners.Remove(listener);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0002AD22 File Offset: 0x00028F22
		public int RefCount
		{
			get
			{
				return this._refCount;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0002AD2C File Offset: 0x00028F2C
		public void AddRef()
		{
			DataCommonEventSource.Log.Trace<int>("<ds.Index.AddRef|API> {0}", this.ObjectID);
			this._table._indexesLock.EnterWriteLock();
			try
			{
				if (this._refCount == 0)
				{
					this._table.ShadowIndexCopy();
					this._table._indexes.Add(this);
				}
				this._refCount++;
			}
			finally
			{
				this._table._indexesLock.ExitWriteLock();
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0002ADB4 File Offset: 0x00028FB4
		public int RemoveRef()
		{
			DataCommonEventSource.Log.Trace<int>("<ds.Index.RemoveRef|API> {0}", this.ObjectID);
			this._table._indexesLock.EnterWriteLock();
			int result;
			try
			{
				int num = this._refCount - 1;
				this._refCount = num;
				result = num;
				if (this._refCount <= 0)
				{
					this._table.ShadowIndexCopy();
					this._table._indexes.Remove(this);
				}
			}
			finally
			{
				this._table._indexesLock.ExitWriteLock();
			}
			return result;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0002AE44 File Offset: 0x00029044
		private void ApplyChangeAction(int record, int action, int changeRecord)
		{
			if (action != 0)
			{
				if (action > 0)
				{
					if (this.AcceptRecord(record))
					{
						this.InsertRecord(record, true);
						return;
					}
				}
				else
				{
					if (this._comparison != null && -1 != record)
					{
						this.DeleteRecord(this.GetIndex(record, changeRecord));
						return;
					}
					this.DeleteRecord(this.GetIndex(record));
				}
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0002AE93 File Offset: 0x00029093
		public bool CheckUnique()
		{
			return !this.HasDuplicates;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0002AEA0 File Offset: 0x000290A0
		private int CompareRecords(int record1, int record2)
		{
			if (this._comparison != null)
			{
				return this.CompareDataRows(record1, record2);
			}
			if (this._indexFields.Length != 0)
			{
				int i = 0;
				while (i < this._indexFields.Length)
				{
					int num = this._indexFields[i].Column.Compare(record1, record2);
					if (num != 0)
					{
						if (!this._indexFields[i].IsDescending)
						{
							return num;
						}
						return -num;
					}
					else
					{
						i++;
					}
				}
				return 0;
			}
			return this._table.Rows.IndexOf(this._table._recordManager[record1]).CompareTo(this._table.Rows.IndexOf(this._table._recordManager[record2]));
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0002AF5A File Offset: 0x0002915A
		private int CompareDataRows(int record1, int record2)
		{
			return this._comparison(this._table._recordManager[record1], this._table._recordManager[record2]);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0002AF8C File Offset: 0x0002918C
		private int CompareDuplicateRecords(int record1, int record2)
		{
			if (this._table._recordManager[record1] == null)
			{
				if (this._table._recordManager[record2] != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (this._table._recordManager[record2] == null)
				{
					return 1;
				}
				int num = this._table._recordManager[record1].rowID.CompareTo(this._table._recordManager[record2].rowID);
				if (num == 0 && record1 != record2)
				{
					num = ((int)this._table._recordManager[record1].GetRecordState(record1)).CompareTo((int)this._table._recordManager[record2].GetRecordState(record2));
				}
				return num;
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0002B04C File Offset: 0x0002924C
		private int CompareRecordToKey(int record1, object[] vals)
		{
			int i = 0;
			while (i < this._indexFields.Length)
			{
				int num = this._indexFields[i].Column.CompareValueTo(record1, vals[i]);
				if (num != 0)
				{
					if (!this._indexFields[i].IsDescending)
					{
						return num;
					}
					return -num;
				}
				else
				{
					i++;
				}
			}
			return 0;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0002B0A3 File Offset: 0x000292A3
		public void DeleteRecordFromIndex(int recordIndex)
		{
			this.DeleteRecord(recordIndex, false);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0002B0AD File Offset: 0x000292AD
		private void DeleteRecord(int recordIndex)
		{
			this.DeleteRecord(recordIndex, true);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0002B0B8 File Offset: 0x000292B8
		private void DeleteRecord(int recordIndex, bool fireEvent)
		{
			DataCommonEventSource.Log.Trace<int, int, bool>("<ds.Index.DeleteRecord|INFO> {0}, recordIndex={1}, fireEvent={2}", this.ObjectID, recordIndex, fireEvent);
			if (recordIndex >= 0)
			{
				this._recordCount--;
				int record = this._records.DeleteByIndex(recordIndex);
				this.MaintainDataView(ListChangedType.ItemDeleted, record, !fireEvent);
				if (fireEvent)
				{
					this.OnListChanged(ListChangedType.ItemDeleted, recordIndex);
				}
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0002B112 File Offset: 0x00029312
		public RBTree<int>.RBTreeEnumerator GetEnumerator(int startIndex)
		{
			return new RBTree<int>.RBTreeEnumerator(this._records, startIndex);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0002B120 File Offset: 0x00029320
		public int GetIndex(int record)
		{
			return this._records.GetIndexByKey(record);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0002B130 File Offset: 0x00029330
		private int GetIndex(int record, int changeRecord)
		{
			DataRow dataRow = this._table._recordManager[record];
			int newRecord = dataRow._newRecord;
			int oldRecord = dataRow._oldRecord;
			int indexByKey;
			try
			{
				if (changeRecord != 1)
				{
					if (changeRecord == 2)
					{
						dataRow._oldRecord = record;
					}
				}
				else
				{
					dataRow._newRecord = record;
				}
				indexByKey = this._records.GetIndexByKey(record);
			}
			finally
			{
				if (changeRecord != 1)
				{
					if (changeRecord == 2)
					{
						dataRow._oldRecord = oldRecord;
					}
				}
				else
				{
					dataRow._newRecord = newRecord;
				}
			}
			return indexByKey;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0002B1B4 File Offset: 0x000293B4
		public object[] GetUniqueKeyValues()
		{
			if (this._indexFields == null || this._indexFields.Length == 0)
			{
				return Array.Empty<object>();
			}
			List<object[]> list = new List<object[]>();
			this.GetUniqueKeyValues(list, this._records.root);
			return list.ToArray();
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0002B1F8 File Offset: 0x000293F8
		public int FindRecord(int record)
		{
			int num = this._records.Search(record);
			if (num != 0)
			{
				return this._records.GetIndexByNode(num);
			}
			return -1;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0002B224 File Offset: 0x00029424
		private int FindNodeByKey(object originalKey)
		{
			if (this._indexFields.Length != 1)
			{
				throw ExceptionBuilder.IndexKeyLength(this._indexFields.Length, 1);
			}
			int num = this._records.root;
			if (num != 0)
			{
				DataColumn column = this._indexFields[0].Column;
				object value = column.ConvertValue(originalKey);
				num = this._records.root;
				if (this._indexFields[0].IsDescending)
				{
					while (num != 0)
					{
						int num2 = column.CompareValueTo(this._records.Key(num), value);
						if (num2 == 0)
						{
							break;
						}
						if (num2 < 0)
						{
							num = this._records.Left(num);
						}
						else
						{
							num = this._records.Right(num);
						}
					}
				}
				else
				{
					while (num != 0)
					{
						int num2 = column.CompareValueTo(this._records.Key(num), value);
						if (num2 == 0)
						{
							break;
						}
						if (num2 > 0)
						{
							num = this._records.Left(num);
						}
						else
						{
							num = this._records.Right(num);
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0002B310 File Offset: 0x00029510
		private int FindNodeByKeys(object[] originalKey)
		{
			int num = (originalKey != null) ? originalKey.Length : 0;
			if (num == 0 || this._indexFields.Length != num)
			{
				throw ExceptionBuilder.IndexKeyLength(this._indexFields.Length, num);
			}
			int num2 = this._records.root;
			if (num2 != 0)
			{
				object[] array = new object[originalKey.Length];
				for (int i = 0; i < originalKey.Length; i++)
				{
					array[i] = this._indexFields[i].Column.ConvertValue(originalKey[i]);
				}
				num2 = this._records.root;
				while (num2 != 0)
				{
					num = this.CompareRecordToKey(this._records.Key(num2), array);
					if (num == 0)
					{
						break;
					}
					if (num > 0)
					{
						num2 = this._records.Left(num2);
					}
					else
					{
						num2 = this._records.Right(num2);
					}
				}
			}
			return num2;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0002B3D0 File Offset: 0x000295D0
		private int FindNodeByKeyRecord(int record)
		{
			int num = this._records.root;
			if (num != 0)
			{
				num = this._records.root;
				while (num != 0)
				{
					int num2 = this.CompareRecords(this._records.Key(num), record);
					if (num2 == 0)
					{
						break;
					}
					if (num2 > 0)
					{
						num = this._records.Left(num);
					}
					else
					{
						num = this._records.Right(num);
					}
				}
			}
			return num;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0002B438 File Offset: 0x00029638
		private Range GetRangeFromNode(int nodeId)
		{
			if (nodeId == 0)
			{
				return default(Range);
			}
			int indexByNode = this._records.GetIndexByNode(nodeId);
			if (this._records.Next(nodeId) == 0)
			{
				return new Range(indexByNode, indexByNode);
			}
			int num = this._records.SubTreeSize(this._records.Next(nodeId));
			return new Range(indexByNode, indexByNode + num - 1);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0002B498 File Offset: 0x00029698
		public Range FindRecords(object key)
		{
			int nodeId = this.FindNodeByKey(key);
			return this.GetRangeFromNode(nodeId);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0002B4B4 File Offset: 0x000296B4
		public Range FindRecords(object[] key)
		{
			int nodeId = this.FindNodeByKeys(key);
			return this.GetRangeFromNode(nodeId);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0002B4D0 File Offset: 0x000296D0
		internal void FireResetEvent()
		{
			DataCommonEventSource.Log.Trace<int>("<ds.Index.FireResetEvent|API> {0}", this.ObjectID);
			if (this.DoListChanged)
			{
				this.OnListChanged(DataView.s_resetEventArgs);
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0002B4FC File Offset: 0x000296FC
		private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState)
		{
			int num = ((this._recordStates & oldState) == DataViewRowState.None) ? 0 : 1;
			return (((this._recordStates & newState) == DataViewRowState.None) ? 0 : 1) - num;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0002B528 File Offset: 0x00029728
		private static int GetReplaceAction(DataViewRowState oldState)
		{
			if ((DataViewRowState.CurrentRows & oldState) != DataViewRowState.None)
			{
				return 1;
			}
			if ((DataViewRowState.OriginalRows & oldState) == DataViewRowState.None)
			{
				return 0;
			}
			return 2;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0002B53B File Offset: 0x0002973B
		public DataRow GetRow(int i)
		{
			return this._table._recordManager[this.GetRecord(i)];
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0002B554 File Offset: 0x00029754
		public DataRow[] GetRows(object[] values)
		{
			return this.GetRows(this.FindRecords(values));
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0002B564 File Offset: 0x00029764
		public DataRow[] GetRows(Range range)
		{
			DataRow[] array = this._table.NewRowArray(range.Count);
			if (array.Length != 0)
			{
				RBTree<int>.RBTreeEnumerator enumerator = this.GetEnumerator(range.Min);
				int num = 0;
				while (num < array.Length && enumerator.MoveNext())
				{
					array[num] = this._table._recordManager[enumerator.Current];
					num++;
				}
			}
			return array;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0002B5C8 File Offset: 0x000297C8
		private void InitRecords(IFilter filter)
		{
			DataViewRowState recordStates = this._recordStates;
			bool append = this._indexFields.Length == 0;
			this._records = new Index.IndexTree(this);
			this._recordCount = 0;
			foreach (object obj in this._table.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				int num = -1;
				if (dataRow._oldRecord == dataRow._newRecord)
				{
					if ((recordStates & DataViewRowState.Unchanged) != DataViewRowState.None)
					{
						num = dataRow._oldRecord;
					}
				}
				else if (dataRow._oldRecord == -1)
				{
					if ((recordStates & DataViewRowState.Added) != DataViewRowState.None)
					{
						num = dataRow._newRecord;
					}
				}
				else if (dataRow._newRecord == -1)
				{
					if ((recordStates & DataViewRowState.Deleted) != DataViewRowState.None)
					{
						num = dataRow._oldRecord;
					}
				}
				else if ((recordStates & DataViewRowState.ModifiedCurrent) != DataViewRowState.None)
				{
					num = dataRow._newRecord;
				}
				else if ((recordStates & DataViewRowState.ModifiedOriginal) != DataViewRowState.None)
				{
					num = dataRow._oldRecord;
				}
				if (num != -1 && this.AcceptRecord(num, filter))
				{
					this._records.InsertAt(-1, num, append);
					this._recordCount++;
				}
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0002B6EC File Offset: 0x000298EC
		public int InsertRecordToIndex(int record)
		{
			int result = -1;
			if (this.AcceptRecord(record))
			{
				result = this.InsertRecord(record, false);
			}
			return result;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0002B710 File Offset: 0x00029910
		private int InsertRecord(int record, bool fireEvent)
		{
			DataCommonEventSource.Log.Trace<int, int, bool>("<ds.Index.InsertRecord|INFO> {0}, record={1}, fireEvent={2}", this.ObjectID, record, fireEvent);
			bool append = false;
			if (this._indexFields.Length == 0 && this._table != null)
			{
				DataRow row = this._table._recordManager[record];
				append = (this._table.Rows.IndexOf(row) + 1 == this._table.Rows.Count);
			}
			int node = this._records.InsertAt(-1, record, append);
			this._recordCount++;
			this.MaintainDataView(ListChangedType.ItemAdded, record, !fireEvent);
			if (fireEvent)
			{
				if (this.DoListChanged)
				{
					this.OnListChanged(ListChangedType.ItemAdded, this._records.GetIndexByNode(node));
				}
				return 0;
			}
			return this._records.GetIndexByNode(node);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0002B7D4 File Offset: 0x000299D4
		public bool IsKeyInIndex(object key)
		{
			int num = this.FindNodeByKey(key);
			return num != 0;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0002B7F0 File Offset: 0x000299F0
		public bool IsKeyInIndex(object[] key)
		{
			int num = this.FindNodeByKeys(key);
			return num != 0;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0002B80C File Offset: 0x00029A0C
		public bool IsKeyRecordInIndex(int record)
		{
			int num = this.FindNodeByKeyRecord(record);
			return num != 0;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0002B825 File Offset: 0x00029A25
		private bool DoListChanged
		{
			get
			{
				return !this._suspendEvents && this._listeners.HasListeners && !this._table.AreIndexEventsSuspended;
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0002B84C File Offset: 0x00029A4C
		private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex)
		{
			if (this.DoListChanged)
			{
				this.OnListChanged(new ListChangedEventArgs(changedType, newIndex, oldIndex));
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0002B864 File Offset: 0x00029A64
		private void OnListChanged(ListChangedType changedType, int index)
		{
			if (this.DoListChanged)
			{
				this.OnListChanged(new ListChangedEventArgs(changedType, index));
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0002B87C File Offset: 0x00029A7C
		private void OnListChanged(ListChangedEventArgs e)
		{
			DataCommonEventSource.Log.Trace<int>("<ds.Index.OnListChanged|INFO> {0}", this.ObjectID);
			this._listeners.Notify<ListChangedEventArgs, bool, bool>(e, false, false, delegate(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3)
			{
				listener.IndexListChanged(args);
			});
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0002B8CC File Offset: 0x00029ACC
		private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove)
		{
			this._listeners.Notify<ListChangedType, DataRow, bool>(changedType, (0 <= record) ? this._table._recordManager[record] : null, trackAddRemove, delegate(DataViewListener listener, ListChangedType type, DataRow row, bool track)
			{
				listener.MaintainDataView(changedType, row, track);
			});
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0002B91C File Offset: 0x00029B1C
		public void Reset()
		{
			DataCommonEventSource.Log.Trace<int>("<ds.Index.Reset|API> {0}", this.ObjectID);
			this.InitRecords(this.RowFilter);
			this.MaintainDataView(ListChangedType.Reset, -1, false);
			this.FireResetEvent();
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0002B950 File Offset: 0x00029B50
		public void RecordChanged(int record)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.Index.RecordChanged|API> {0}, record={1}", this.ObjectID, record);
			if (this.DoListChanged)
			{
				int index = this.GetIndex(record);
				if (index >= 0)
				{
					this.OnListChanged(ListChangedType.ItemChanged, index);
				}
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0002B990 File Offset: 0x00029B90
		public void RecordChanged(int oldIndex, int newIndex)
		{
			DataCommonEventSource.Log.Trace<int, int, int>("<ds.Index.RecordChanged|API> {0}, oldIndex={1}, newIndex={2}", this.ObjectID, oldIndex, newIndex);
			if (oldIndex > -1 || newIndex > -1)
			{
				if (oldIndex == newIndex)
				{
					this.OnListChanged(ListChangedType.ItemChanged, newIndex, oldIndex);
					return;
				}
				if (oldIndex == -1)
				{
					this.OnListChanged(ListChangedType.ItemAdded, newIndex, oldIndex);
					return;
				}
				if (newIndex == -1)
				{
					this.OnListChanged(ListChangedType.ItemDeleted, oldIndex);
					return;
				}
				this.OnListChanged(ListChangedType.ItemMoved, newIndex, oldIndex);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002B9F0 File Offset: 0x00029BF0
		public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
		{
			DataCommonEventSource.Log.Trace<int, int, DataViewRowState, DataViewRowState>("<ds.Index.RecordStateChanged|API> {0}, record={1}, oldState={2}, newState={3}", this.ObjectID, record, oldState, newState);
			int changeAction = this.GetChangeAction(oldState, newState);
			this.ApplyChangeAction(record, changeAction, Index.GetReplaceAction(oldState));
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002BA2C File Offset: 0x00029C2C
		public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState)
		{
			DataCommonEventSource.Log.Trace<int, int, DataViewRowState, DataViewRowState, int, DataViewRowState, DataViewRowState>("<ds.Index.RecordStateChanged|API> {0}, oldRecord={1}, oldOldState={2}, oldNewState={3}, newRecord={4}, newOldState={5}, newNewState={6}", this.ObjectID, oldRecord, oldOldState, oldNewState, newRecord, newOldState, newNewState);
			int changeAction = this.GetChangeAction(oldOldState, oldNewState);
			int changeAction2 = this.GetChangeAction(newOldState, newNewState);
			if (changeAction != -1 || changeAction2 != 1 || !this.AcceptRecord(newRecord))
			{
				this.ApplyChangeAction(oldRecord, changeAction, Index.GetReplaceAction(oldOldState));
				this.ApplyChangeAction(newRecord, changeAction2, Index.GetReplaceAction(newOldState));
				return;
			}
			int index;
			if (this._comparison != null && changeAction < 0)
			{
				index = this.GetIndex(oldRecord, Index.GetReplaceAction(oldOldState));
			}
			else
			{
				index = this.GetIndex(oldRecord);
			}
			if (this._comparison == null && index != -1 && this.CompareRecords(oldRecord, newRecord) == 0)
			{
				this._records.UpdateNodeKey(oldRecord, newRecord);
				int index2 = this.GetIndex(newRecord);
				this.OnListChanged(ListChangedType.ItemChanged, index2, index2);
				return;
			}
			this._suspendEvents = true;
			if (index != -1)
			{
				this._records.DeleteByIndex(index);
				this._recordCount--;
			}
			this._records.Insert(newRecord);
			this._recordCount++;
			this._suspendEvents = false;
			int index3 = this.GetIndex(newRecord);
			if (index == index3)
			{
				this.OnListChanged(ListChangedType.ItemChanged, index3, index);
				return;
			}
			if (index == -1)
			{
				this.MaintainDataView(ListChangedType.ItemAdded, newRecord, false);
				this.OnListChanged(ListChangedType.ItemAdded, this.GetIndex(newRecord));
				return;
			}
			this.OnListChanged(ListChangedType.ItemMoved, index3, index);
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002BB8C File Offset: 0x00029D8C
		internal DataTable Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0002BB94 File Offset: 0x00029D94
		private void GetUniqueKeyValues(List<object[]> list, int curNodeId)
		{
			if (curNodeId != 0)
			{
				this.GetUniqueKeyValues(list, this._records.Left(curNodeId));
				int record = this._records.Key(curNodeId);
				object[] array = new object[this._indexFields.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this._indexFields[i].Column[record];
				}
				list.Add(array);
				this.GetUniqueKeyValues(list, this._records.Right(curNodeId));
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0002BC14 File Offset: 0x00029E14
		internal static int IndexOfReference<T>(List<T> list, T item) where T : class
		{
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] == item)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x040002DC RID: 732
		private readonly DataTable _table;

		// Token: 0x040002DD RID: 733
		internal readonly IndexField[] _indexFields;

		// Token: 0x040002DE RID: 734
		private readonly Comparison<DataRow> _comparison;

		// Token: 0x040002DF RID: 735
		private readonly DataViewRowState _recordStates;

		// Token: 0x040002E0 RID: 736
		private WeakReference _rowFilter;

		// Token: 0x040002E1 RID: 737
		private Index.IndexTree _records;

		// Token: 0x040002E2 RID: 738
		private int _recordCount;

		// Token: 0x040002E3 RID: 739
		private int _refCount;

		// Token: 0x040002E4 RID: 740
		private Listeners<DataViewListener> _listeners;

		// Token: 0x040002E5 RID: 741
		private bool _suspendEvents;

		// Token: 0x040002E6 RID: 742
		private readonly bool _isSharable;

		// Token: 0x040002E7 RID: 743
		private readonly bool _hasRemoteAggregate;

		// Token: 0x040002E8 RID: 744
		private static int s_objectTypeCount;

		// Token: 0x040002E9 RID: 745
		private readonly int _objectID = Interlocked.Increment(ref Index.s_objectTypeCount);

		// Token: 0x0200008F RID: 143
		private sealed class IndexTree : RBTree<int>
		{
			// Token: 0x060008A1 RID: 2209 RVA: 0x0002BC4C File Offset: 0x00029E4C
			internal IndexTree(Index index) : base(TreeAccessMethod.KEY_SEARCH_AND_INDEX)
			{
				this._index = index;
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x0002BC5C File Offset: 0x00029E5C
			protected override int CompareNode(int record1, int record2)
			{
				return this._index.CompareRecords(record1, record2);
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x0002BC6B File Offset: 0x00029E6B
			protected override int CompareSateliteTreeNode(int record1, int record2)
			{
				return this._index.CompareDuplicateRecords(record1, record2);
			}

			// Token: 0x040002EA RID: 746
			private readonly Index _index;
		}
	}
}
