using System;
using System.Collections;

namespace System.Data
{
	/// <summary>Represents a collection of rows for a <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x02000030 RID: 48
	public sealed class DataRowCollection : InternalDataCollectionBase
	{
		// Token: 0x06000342 RID: 834 RVA: 0x0000BBBB File Offset: 0x00009DBB
		internal DataRowCollection(DataTable table)
		{
			this._table = table;
		}

		/// <summary>Gets the total number of <see cref="T:System.Data.DataRow" /> objects in this collection.</summary>
		/// <returns>The total number of <see cref="T:System.Data.DataRow" /> objects in this collection.</returns>
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000BBD5 File Offset: 0x00009DD5
		public override int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Gets the row at the specified index.</summary>
		/// <param name="index">The zero-based index of the row to return. </param>
		/// <returns>The specified <see cref="T:System.Data.DataRow" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection. </exception>
		// Token: 0x17000086 RID: 134
		public DataRow this[int index]
		{
			get
			{
				return this._list[index];
			}
		}

		/// <summary>Adds the specified <see cref="T:System.Data.DataRow" /> to the <see cref="T:System.Data.DataRowCollection" /> object.</summary>
		/// <param name="row">The <see cref="T:System.Data.DataRow" /> to add.</param>
		/// <exception cref="T:System.ArgumentNullException">The row is null. </exception>
		/// <exception cref="T:System.ArgumentException">The row either belongs to another table or already belongs to this table.</exception>
		/// <exception cref="T:System.Data.ConstraintException">The addition invalidates a constraint. </exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">The addition tries to put a null in a <see cref="T:System.Data.DataColumn" /> where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is false.</exception>
		// Token: 0x06000345 RID: 837 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		public void Add(DataRow row)
		{
			this._table.AddRow(row, -1);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000BC00 File Offset: 0x00009E00
		internal void DiffInsertAt(DataRow row, int pos)
		{
			if (pos < 0 || pos == this._list.Count)
			{
				this._table.AddRow(row, (pos > -1) ? (pos + 1) : -1);
				return;
			}
			if (this._table.NestedParentRelations.Length == 0)
			{
				this._table.InsertRow(row, pos + 1, (pos > this._list.Count) ? -1 : pos);
				return;
			}
			if (pos >= this._list.Count)
			{
				while (pos > this._list.Count)
				{
					this._list.Add(null);
					this._nullInList++;
				}
				this._table.AddRow(row, pos + 1);
				return;
			}
			if (this._list[pos] != null)
			{
				throw ExceptionBuilder.RowInsertTwice(pos, this._table.TableName);
			}
			this._list.RemoveAt(pos);
			this._nullInList--;
			this._table.InsertRow(row, pos + 1, pos);
		}

		/// <summary>Gets the index of the specified <see cref="T:System.Data.DataRow" /> object.</summary>
		/// <param name="row">The <see langword="DataRow" /> to search for.</param>
		/// <returns>The zero-based index of the row, or -1 if the row is not found in the collection.</returns>
		// Token: 0x06000347 RID: 839 RVA: 0x0000BCFA File Offset: 0x00009EFA
		public int IndexOf(DataRow row)
		{
			if (row != null && row.Table == this._table && (row.RBTreeNodeId != 0 || row.RowState != DataRowState.Detached))
			{
				return this._list.IndexOf(row.RBTreeNodeId, row);
			}
			return -1;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000BD34 File Offset: 0x00009F34
		internal DataRow AddWithColumnEvents(params object[] values)
		{
			DataRow dataRow = this._table.NewRow(-1);
			dataRow.ItemArray = values;
			this._table.AddRow(dataRow, -1);
			return dataRow;
		}

		/// <summary>Creates a row using specified values and adds it to the <see cref="T:System.Data.DataRowCollection" />.</summary>
		/// <param name="values">The array of values that are used to create the new row. </param>
		/// <returns>None.</returns>
		/// <exception cref="T:System.ArgumentException">The array is larger than the number of columns in the table.</exception>
		/// <exception cref="T:System.InvalidCastException">A value does not match its respective column type. </exception>
		/// <exception cref="T:System.Data.ConstraintException">Adding the row invalidates a constraint. </exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">Trying to put a null in a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is false. </exception>
		// Token: 0x06000349 RID: 841 RVA: 0x0000BD64 File Offset: 0x00009F64
		public DataRow Add(params object[] values)
		{
			int record = this._table.NewRecordFromArray(values);
			DataRow dataRow = this._table.NewRow(record);
			this._table.AddRow(dataRow, -1);
			return dataRow;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000BD99 File Offset: 0x00009F99
		internal void ArrayAdd(DataRow row)
		{
			row.RBTreeNodeId = this._list.Add(row);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000BDAD File Offset: 0x00009FAD
		internal void ArrayInsert(DataRow row, int pos)
		{
			row.RBTreeNodeId = this._list.Insert(pos, row);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000BDC2 File Offset: 0x00009FC2
		internal void ArrayClear()
		{
			this._list.Clear();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000BDCF File Offset: 0x00009FCF
		internal void ArrayRemove(DataRow row)
		{
			if (row.RBTreeNodeId == 0)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.AttachedNodeWithZerorbTreeNodeId);
			}
			this._list.RBDelete(row.RBTreeNodeId);
			row.RBTreeNodeId = 0;
		}

		/// <summary>Copies all the <see cref="T:System.Data.DataRow" /> objects from the collection into the given array, starting at the given destination array index.</summary>
		/// <param name="ar">The one-dimensional array that is the destination of the elements copied from the <see langword="DataRowCollection" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in the array at which copying begins.</param>
		// Token: 0x0600034E RID: 846 RVA: 0x0000BDFA File Offset: 0x00009FFA
		public override void CopyTo(Array ar, int index)
		{
			this._list.CopyTo(ar, index);
		}

		/// <summary>Copies all the <see cref="T:System.Data.DataRow" /> objects from the collection into the given array, starting at the given destination array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the <see langword="DataRowCollection" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in the array at which copying begins.</param>
		// Token: 0x0600034F RID: 847 RVA: 0x0000BE09 File Offset: 0x0000A009
		public void CopyTo(DataRow[] array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> for this collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for this collection.</returns>
		// Token: 0x06000350 RID: 848 RVA: 0x0000BE18 File Offset: 0x0000A018
		public override IEnumerator GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x040000A1 RID: 161
		private readonly DataTable _table;

		// Token: 0x040000A2 RID: 162
		private readonly DataRowCollection.DataRowTree _list = new DataRowCollection.DataRowTree();

		// Token: 0x040000A3 RID: 163
		internal int _nullInList;

		// Token: 0x02000031 RID: 49
		private sealed class DataRowTree : RBTree<DataRow>
		{
			// Token: 0x06000351 RID: 849 RVA: 0x0000BE25 File Offset: 0x0000A025
			internal DataRowTree() : base(TreeAccessMethod.INDEX_ONLY)
			{
			}

			// Token: 0x06000352 RID: 850 RVA: 0x0000BE2E File Offset: 0x0000A02E
			protected override int CompareNode(DataRow record1, DataRow record2)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CompareNodeInDataRowTree);
			}

			// Token: 0x06000353 RID: 851 RVA: 0x0000BE37 File Offset: 0x0000A037
			protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CompareSateliteTreeNodeInDataRowTree);
			}
		}
	}
}
