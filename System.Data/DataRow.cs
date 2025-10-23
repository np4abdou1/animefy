using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Threading;

namespace System.Data
{
	/// <summary>Represents a row of data in a <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x0200002B RID: 43
	public class DataRow
	{
		/// <summary>Initializes a new instance of the DataRow. Constructs a row from the builder. Only for internal usage..</summary>
		/// <param name="builder">builder </param>
		// Token: 0x060002F5 RID: 757 RVA: 0x0000A744 File Offset: 0x00008944
		protected internal DataRow(DataRowBuilder builder)
		{
			this._tempRecord = builder._record;
			this._table = builder._table;
			this._columns = this._table.Columns;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000A7A6 File Offset: 0x000089A6
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000A7B9 File Offset: 0x000089B9
		internal DataColumn LastChangedColumn
		{
			get
			{
				if (this._countColumnChange == 1)
				{
					return this._lastChangedColumn;
				}
				return null;
			}
			set
			{
				this._countColumnChange++;
				this._lastChangedColumn = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000A7D0 File Offset: 0x000089D0
		internal bool HasPropertyChanged
		{
			get
			{
				return 0 < this._countColumnChange;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000A7DB File Offset: 0x000089DB
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000A7E3 File Offset: 0x000089E3
		internal int RBTreeNodeId
		{
			get
			{
				return this._rbTreeNodeId;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, int>("<ds.DataRow.set_RBTreeNodeId|INFO> {0}, value={1}", this._objectID, value);
				this._rbTreeNodeId = value;
			}
		}

		/// <summary>Gets or sets the custom error description for a row.</summary>
		/// <returns>The text describing an error.</returns>
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000A802 File Offset: 0x00008A02
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000A820 File Offset: 0x00008A20
		public string RowError
		{
			get
			{
				if (this._error != null)
				{
					return this._error.Text;
				}
				return string.Empty;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, string>("<ds.DataRow.set_RowError|API> {0}, value='{1}'", this._objectID, value);
				if (this._error == null)
				{
					if (!string.IsNullOrEmpty(value))
					{
						this._error = new DataError(value);
					}
					this.RowErrorChanged();
					return;
				}
				if (this._error.Text != value)
				{
					this._error.Text = value;
					this.RowErrorChanged();
				}
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000A88B File Offset: 0x00008A8B
		private void RowErrorChanged()
		{
			if (this._oldRecord != -1)
			{
				this._table.RecordChanged(this._oldRecord);
			}
			if (this._newRecord != -1)
			{
				this._table.RecordChanged(this._newRecord);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000A8C1 File Offset: 0x00008AC1
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000A8C9 File Offset: 0x00008AC9
		internal long rowID
		{
			get
			{
				return this._rowID;
			}
			set
			{
				this.ResetLastChangedColumn();
				this._rowID = value;
			}
		}

		/// <summary>Gets the current state of the row with regard to its relationship to the <see cref="T:System.Data.DataRowCollection" />.</summary>
		/// <returns>One of the <see cref="T:System.Data.DataRowState" /> values.</returns>
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		public DataRowState RowState
		{
			get
			{
				if (this._oldRecord == this._newRecord)
				{
					if (this._oldRecord == -1)
					{
						return DataRowState.Detached;
					}
					if (0 < this._columns.ColumnsImplementingIChangeTrackingCount)
					{
						foreach (DataColumn column in this._columns.ColumnsImplementingIChangeTracking)
						{
							object obj = this[column];
							if (DBNull.Value != obj && ((IChangeTracking)obj).IsChanged)
							{
								return DataRowState.Modified;
							}
						}
					}
					return DataRowState.Unchanged;
				}
				else
				{
					if (this._oldRecord == -1)
					{
						return DataRowState.Added;
					}
					if (this._newRecord == -1)
					{
						return DataRowState.Deleted;
					}
					return DataRowState.Modified;
				}
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataTable" /> for which this row has a schema.</summary>
		/// <returns>The <see cref="T:System.Data.DataTable" /> to which this row belongs.</returns>
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000A964 File Offset: 0x00008B64
		public DataTable Table
		{
			get
			{
				return this._table;
			}
		}

		/// <summary>Gets or sets the data stored in the column specified by index.</summary>
		/// <param name="columnIndex">The zero-based index of the column. </param>
		/// <returns>An <see cref="T:System.Object" /> that contains the data.</returns>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">Occurs when you try to set a value on a deleted row. </exception>
		/// <exception cref="T:System.IndexOutOfRangeException">The <paramref name="columnIndex" /> argument is out of range. </exception>
		/// <exception cref="T:System.InvalidCastException">Occurs when you set the value and the new value's <see cref="T:System.Type" /> does not match <see cref="P:System.Data.DataColumn.DataType" />. </exception>
		// Token: 0x1700007D RID: 125
		public object this[int columnIndex]
		{
			get
			{
				DataColumn dataColumn = this._columns[columnIndex];
				int defaultRecord = this.GetDefaultRecord();
				return dataColumn[defaultRecord];
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000A994 File Offset: 0x00008B94
		internal void CheckForLoops(DataRelation rel)
		{
			if (this._table._fInLoadDiffgram || (this._table.DataSet != null && this._table.DataSet._fInLoadDiffgram))
			{
				return;
			}
			int count = this._table.Rows.Count;
			int num = 0;
			for (DataRow parentRow = this.GetParentRow(rel); parentRow != null; parentRow = parentRow.GetParentRow(rel))
			{
				if (parentRow == this || num > count)
				{
					throw ExceptionBuilder.NestedCircular(this._table.TableName);
				}
				num++;
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000AA14 File Offset: 0x00008C14
		internal int GetNestedParentCount()
		{
			int num = 0;
			foreach (DataRelation dataRelation in this._table.NestedParentRelations)
			{
				if (dataRelation != null)
				{
					if (dataRelation.ParentTable == this._table)
					{
						this.CheckForLoops(dataRelation);
					}
					if (this.GetParentRow(dataRelation) != null)
					{
						num++;
					}
				}
			}
			return num;
		}

		/// <summary>Gets or sets the data stored in the column specified by name.</summary>
		/// <param name="columnName">The name of the column. </param>
		/// <returns>An <see cref="T:System.Object" /> that contains the data.</returns>
		/// <exception cref="T:System.ArgumentException">The column specified by <paramref name="columnName" /> cannot be found. </exception>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">Occurs when you try to set a value on a deleted row. </exception>
		/// <exception cref="T:System.InvalidCastException">Occurs when you set a value and its <see cref="T:System.Type" /> does not match <see cref="P:System.Data.DataColumn.DataType" />. </exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">Occurs when you try to insert a null value into a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is set to <see langword="false" />.</exception>
		// Token: 0x1700007E RID: 126
		public object this[string columnName]
		{
			set
			{
				DataColumn dataColumn = this.GetDataColumn(columnName);
				this[dataColumn] = value;
			}
		}

		/// <summary>Gets or sets the data stored in the specified <see cref="T:System.Data.DataColumn" />.</summary>
		/// <param name="column">A <see cref="T:System.Data.DataColumn" /> that contains the data. </param>
		/// <returns>An <see cref="T:System.Object" /> that contains the data.</returns>
		/// <exception cref="T:System.ArgumentException">The column does not belong to this table. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> is null. </exception>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">An attempt was made to set a value on a deleted row. </exception>
		/// <exception cref="T:System.InvalidCastException">The data types of the value and the column do not match. </exception>
		// Token: 0x1700007F RID: 127
		public object this[DataColumn column]
		{
			get
			{
				this.CheckColumn(column);
				int defaultRecord = this.GetDefaultRecord();
				return column[defaultRecord];
			}
			set
			{
				this.CheckColumn(column);
				if (this._inChangingEvent)
				{
					throw ExceptionBuilder.EditInRowChanging();
				}
				if (-1L != this.rowID && column.ReadOnly)
				{
					throw ExceptionBuilder.ReadOnly(column.ColumnName);
				}
				DataColumnChangeEventArgs dataColumnChangeEventArgs = null;
				if (this._table.NeedColumnChangeEvents)
				{
					dataColumnChangeEventArgs = new DataColumnChangeEventArgs(this, column, value);
					this._table.OnColumnChanging(dataColumnChangeEventArgs);
				}
				if (column.Table != this._table)
				{
					throw ExceptionBuilder.ColumnNotInTheTable(column.ColumnName, this._table.TableName);
				}
				if (-1L != this.rowID && column.ReadOnly)
				{
					throw ExceptionBuilder.ReadOnly(column.ColumnName);
				}
				object obj = (dataColumnChangeEventArgs != null) ? dataColumnChangeEventArgs.ProposedValue : value;
				if (obj == null)
				{
					if (column.IsValueType)
					{
						throw ExceptionBuilder.CannotSetToNull(column);
					}
					obj = DBNull.Value;
				}
				bool flag = this.BeginEditInternal();
				try
				{
					int proposedRecordNo = this.GetProposedRecordNo();
					column[proposedRecordNo] = obj;
				}
				catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
				{
					if (flag)
					{
						this.CancelEdit();
					}
					throw;
				}
				this.LastChangedColumn = column;
				if (dataColumnChangeEventArgs != null)
				{
					this._table.OnColumnChanged(dataColumnChangeEventArgs);
				}
				if (flag)
				{
					this.EndEdit();
				}
			}
		}

		/// <summary>Gets the specified version of data stored in the specified <see cref="T:System.Data.DataColumn" />.</summary>
		/// <param name="column">A <see cref="T:System.Data.DataColumn" /> that contains information about the column. </param>
		/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values that specifies the row version that you want. Possible values are <see langword="Default" />, <see langword="Original" />, <see langword="Current" />, and <see langword="Proposed" />. </param>
		/// <returns>An <see cref="T:System.Object" /> that contains the data.</returns>
		/// <exception cref="T:System.ArgumentException">The column does not belong to the table. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> argument contains null. </exception>
		/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have this version of data. </exception>
		// Token: 0x17000080 RID: 128
		public object this[DataColumn column, DataRowVersion version]
		{
			get
			{
				this.CheckColumn(column);
				int recordFromVersion = this.GetRecordFromVersion(version);
				return column[recordFromVersion];
			}
		}

		/// <summary>Gets or sets all the values for this row through an array.</summary>
		/// <returns>An array of type <see cref="T:System.Object" />.</returns>
		/// <exception cref="T:System.ArgumentException">The array is larger than the number of columns in the table. </exception>
		/// <exception cref="T:System.InvalidCastException">A value in the array does not match its <see cref="P:System.Data.DataColumn.DataType" /> in its respective <see cref="T:System.Data.DataColumn" />. </exception>
		/// <exception cref="T:System.Data.ConstraintException">An edit broke a constraint. </exception>
		/// <exception cref="T:System.Data.ReadOnlyException">An edit tried to change the value of a read-only column. </exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">An edit tried to put a null value in a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> of the <see cref="T:System.Data.DataColumn" /> object is <see langword="false" />. </exception>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">The row has been deleted. </exception>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000AC08 File Offset: 0x00008E08
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000AC54 File Offset: 0x00008E54
		public object[] ItemArray
		{
			get
			{
				int defaultRecord = this.GetDefaultRecord();
				object[] array = new object[this._columns.Count];
				for (int i = 0; i < array.Length; i++)
				{
					DataColumn dataColumn = this._columns[i];
					array[i] = dataColumn[defaultRecord];
				}
				return array;
			}
			set
			{
				if (value == null)
				{
					throw ExceptionBuilder.ArgumentNull("ItemArray");
				}
				if (this._columns.Count < value.Length)
				{
					throw ExceptionBuilder.ValueArrayLength();
				}
				DataColumnChangeEventArgs dataColumnChangeEventArgs = null;
				if (this._table.NeedColumnChangeEvents)
				{
					dataColumnChangeEventArgs = new DataColumnChangeEventArgs(this);
				}
				bool flag = this.BeginEditInternal();
				for (int i = 0; i < value.Length; i++)
				{
					if (value[i] != null)
					{
						DataColumn dataColumn = this._columns[i];
						if (-1L != this.rowID && dataColumn.ReadOnly)
						{
							throw ExceptionBuilder.ReadOnly(dataColumn.ColumnName);
						}
						if (dataColumnChangeEventArgs != null)
						{
							dataColumnChangeEventArgs.InitializeColumnChangeEvent(dataColumn, value[i]);
							this._table.OnColumnChanging(dataColumnChangeEventArgs);
						}
						if (dataColumn.Table != this._table)
						{
							throw ExceptionBuilder.ColumnNotInTheTable(dataColumn.ColumnName, this._table.TableName);
						}
						if (-1L != this.rowID && dataColumn.ReadOnly)
						{
							throw ExceptionBuilder.ReadOnly(dataColumn.ColumnName);
						}
						if (this._tempRecord == -1)
						{
							this.BeginEditInternal();
						}
						object obj = (dataColumnChangeEventArgs != null) ? dataColumnChangeEventArgs.ProposedValue : value[i];
						if (obj == null)
						{
							if (dataColumn.IsValueType)
							{
								throw ExceptionBuilder.CannotSetToNull(dataColumn);
							}
							obj = DBNull.Value;
						}
						try
						{
							int proposedRecordNo = this.GetProposedRecordNo();
							dataColumn[proposedRecordNo] = obj;
						}
						catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
						{
							if (flag)
							{
								this.CancelEdit();
							}
							throw;
						}
						this.LastChangedColumn = dataColumn;
						if (dataColumnChangeEventArgs != null)
						{
							this._table.OnColumnChanged(dataColumnChangeEventArgs);
						}
					}
				}
				this.EndEdit();
			}
		}

		/// <summary>Commits all the changes made to this row since the last time <see cref="M:System.Data.DataRow.AcceptChanges" /> was called.</summary>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table. </exception>
		// Token: 0x0600030B RID: 779 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		public void AcceptChanges()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataRow.AcceptChanges|API> {0}", this._objectID);
			try
			{
				this.EndEdit();
				if (this.RowState != DataRowState.Detached && this.RowState != DataRowState.Deleted && this._columns.ColumnsImplementingIChangeTrackingCount > 0)
				{
					foreach (DataColumn column in this._columns.ColumnsImplementingIChangeTracking)
					{
						object obj = this[column];
						if (DBNull.Value != obj)
						{
							IChangeTracking changeTracking = (IChangeTracking)obj;
							if (changeTracking.IsChanged)
							{
								changeTracking.AcceptChanges();
							}
						}
					}
				}
				this._table.CommitRow(this);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Starts an edit operation on a <see cref="T:System.Data.DataRow" /> object.</summary>
		/// <exception cref="T:System.Data.InRowChangingEventException">The method was called inside the <see cref="E:System.Data.DataTable.RowChanging" /> event. </exception>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">The method was called upon a deleted row. </exception>
		// Token: 0x0600030C RID: 780 RVA: 0x0000AEA0 File Offset: 0x000090A0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void BeginEdit()
		{
			this.BeginEditInternal();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000AEAC File Offset: 0x000090AC
		private bool BeginEditInternal()
		{
			if (this._inChangingEvent)
			{
				throw ExceptionBuilder.BeginEditInRowChanging();
			}
			if (this._tempRecord != -1)
			{
				if (this._tempRecord < this._table._recordManager.LastFreeRecord)
				{
					return false;
				}
				this._tempRecord = -1;
			}
			if (this._oldRecord != -1 && this._newRecord == -1)
			{
				throw ExceptionBuilder.DeletedRowInaccessible();
			}
			this.ResetLastChangedColumn();
			this._tempRecord = this._table.NewRecord(this._newRecord);
			return true;
		}

		/// <summary>Cancels the current edit on the row.</summary>
		/// <exception cref="T:System.Data.InRowChangingEventException">The method was called inside the <see cref="E:System.Data.DataTable.RowChanging" /> event. </exception>
		// Token: 0x0600030E RID: 782 RVA: 0x0000AF27 File Offset: 0x00009127
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void CancelEdit()
		{
			if (this._inChangingEvent)
			{
				throw ExceptionBuilder.CancelEditInRowChanging();
			}
			this._table.FreeRecord(ref this._tempRecord);
			this.ResetLastChangedColumn();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000AF4E File Offset: 0x0000914E
		private void CheckColumn(DataColumn column)
		{
			if (column == null)
			{
				throw ExceptionBuilder.ArgumentNull("column");
			}
			if (column.Table != this._table)
			{
				throw ExceptionBuilder.ColumnNotInTheTable(column.ColumnName, this._table.TableName);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000AF83 File Offset: 0x00009183
		internal void CheckInTable()
		{
			if (this.rowID == -1L)
			{
				throw ExceptionBuilder.RowNotInTheTable();
			}
		}

		/// <summary>Deletes the <see cref="T:System.Data.DataRow" />.</summary>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">The <see cref="T:System.Data.DataRow" /> has already been deleted.</exception>
		// Token: 0x06000311 RID: 785 RVA: 0x0000AF95 File Offset: 0x00009195
		public void Delete()
		{
			if (this._inDeletingEvent)
			{
				throw ExceptionBuilder.DeleteInRowDeleting();
			}
			if (this._newRecord == -1)
			{
				return;
			}
			this._table.DeleteRow(this);
		}

		/// <summary>Ends the edit occurring on the row.</summary>
		/// <exception cref="T:System.Data.InRowChangingEventException">The method was called inside the <see cref="E:System.Data.DataTable.RowChanging" /> event. </exception>
		/// <exception cref="T:System.Data.ConstraintException">The edit broke a constraint. </exception>
		/// <exception cref="T:System.Data.ReadOnlyException">The row belongs to the table and the edit tried to change the value of a read-only column. </exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">The edit tried to put a null value into a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is false. </exception>
		// Token: 0x06000312 RID: 786 RVA: 0x0000AFBC File Offset: 0x000091BC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndEdit()
		{
			if (this._inChangingEvent)
			{
				throw ExceptionBuilder.EndEditInRowChanging();
			}
			if (this._newRecord == -1)
			{
				return;
			}
			if (this._tempRecord != -1)
			{
				try
				{
					this._table.SetNewRecord(this, this._tempRecord, DataRowAction.Change, false, true, true);
				}
				finally
				{
					this.ResetLastChangedColumn();
				}
			}
		}

		/// <summary>Sets the error description for a column specified by index.</summary>
		/// <param name="columnIndex">The zero-based index of the column. </param>
		/// <param name="error">The error description. </param>
		/// <exception cref="T:System.IndexOutOfRangeException">The <paramref name="columnIndex" /> argument is out of range </exception>
		// Token: 0x06000313 RID: 787 RVA: 0x0000B01C File Offset: 0x0000921C
		public void SetColumnError(int columnIndex, string error)
		{
			DataColumn dataColumn = this._columns[columnIndex];
			if (dataColumn == null)
			{
				throw ExceptionBuilder.ColumnOutOfRange(columnIndex);
			}
			this.SetColumnError(dataColumn, error);
		}

		/// <summary>Sets the error description for a column specified as a <see cref="T:System.Data.DataColumn" />.</summary>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to set the error description for. </param>
		/// <param name="error">The error description. </param>
		// Token: 0x06000314 RID: 788 RVA: 0x0000B048 File Offset: 0x00009248
		public void SetColumnError(DataColumn column, string error)
		{
			this.CheckColumn(column);
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int, string>("<ds.DataRow.SetColumnError|API> {0}, column={1}, error='{2}'", this._objectID, column.ObjectID, error);
			try
			{
				if (this._error == null)
				{
					this._error = new DataError();
				}
				if (this.GetColumnError(column) != error)
				{
					this._error.SetColumnError(column, error);
					this.RowErrorChanged();
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Gets the error description of the specified <see cref="T:System.Data.DataColumn" />.</summary>
		/// <param name="column">A <see cref="T:System.Data.DataColumn" />. </param>
		/// <returns>The text of the error description.</returns>
		// Token: 0x06000315 RID: 789 RVA: 0x0000B0CC File Offset: 0x000092CC
		public string GetColumnError(DataColumn column)
		{
			this.CheckColumn(column);
			if (this._error == null)
			{
				this._error = new DataError();
			}
			return this._error.GetColumnError(column);
		}

		/// <summary>Clears the errors for the row. This includes the <see cref="P:System.Data.DataRow.RowError" /> and errors set with <see cref="M:System.Data.DataRow.SetColumnError(System.Int32,System.String)" />.</summary>
		// Token: 0x06000316 RID: 790 RVA: 0x0000B0F4 File Offset: 0x000092F4
		public void ClearErrors()
		{
			if (this._error != null)
			{
				this._error.Clear();
				this.RowErrorChanged();
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000B10F File Offset: 0x0000930F
		internal void ClearError(DataColumn column)
		{
			if (this._error != null)
			{
				this._error.Clear(column);
				this.RowErrorChanged();
			}
		}

		/// <summary>Gets a value that indicates whether there are errors in a row.</summary>
		/// <returns>
		///     <see langword="true" /> if the row contains an error; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000B12B File Offset: 0x0000932B
		public bool HasErrors
		{
			get
			{
				return this._error != null && this._error.HasErrors;
			}
		}

		/// <summary>Gets an array of columns that have errors.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that contain errors.</returns>
		// Token: 0x06000319 RID: 793 RVA: 0x0000B142 File Offset: 0x00009342
		public DataColumn[] GetColumnsInError()
		{
			if (this._error != null)
			{
				return this._error.GetColumnsInError();
			}
			return Array.Empty<DataColumn>();
		}

		/// <summary>Gets the child rows of this <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use. </param>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects or an array of length zero.</returns>
		/// <exception cref="T:System.ArgumentException">The relation and row do not belong to the same table. </exception>
		/// <exception cref="T:System.ArgumentNullException">The relation is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table. </exception>
		/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have this version of data. </exception>
		// Token: 0x0600031A RID: 794 RVA: 0x0000B15D File Offset: 0x0000935D
		public DataRow[] GetChildRows(DataRelation relation)
		{
			return this.GetChildRows(relation, DataRowVersion.Default);
		}

		/// <summary>Gets the child rows of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />, and <see cref="T:System.Data.DataRowVersion" />.</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use. </param>
		/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values specifying the version of the data to get. Possible values are <see langword="Default" />, <see langword="Original" />, <see langword="Current" />, and <see langword="Proposed" />. </param>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects.</returns>
		/// <exception cref="T:System.ArgumentException">The relation and row do not belong to the same table. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="relation" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table. </exception>
		/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have the requested <see cref="T:System.Data.DataRowVersion" />. </exception>
		// Token: 0x0600031B RID: 795 RVA: 0x0000B16C File Offset: 0x0000936C
		public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version)
		{
			if (relation == null)
			{
				return this._table.NewRowArray(0);
			}
			if (relation.DataSet != this._table.DataSet)
			{
				throw ExceptionBuilder.RowNotInTheDataSet();
			}
			if (relation.ParentKey.Table != this._table)
			{
				throw ExceptionBuilder.RelationForeignTable(relation.ParentTable.TableName, this._table.TableName);
			}
			return DataRelation.GetChildRows(relation.ParentKey, relation.ChildKey, this, version);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000B1E8 File Offset: 0x000093E8
		internal DataColumn GetDataColumn(string columnName)
		{
			DataColumn dataColumn = this._columns[columnName];
			if (dataColumn != null)
			{
				return dataColumn;
			}
			throw ExceptionBuilder.ColumnNotInTheTable(columnName, this._table.TableName);
		}

		/// <summary>Gets the parent row of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use. </param>
		/// <returns>The parent <see cref="T:System.Data.DataRow" /> of the current row.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="relation" /> does not belong to the <see cref="T:System.Data.DataTable" />.The row is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.DataException">A child row has multiple parents.</exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">This row does not belong to the child table of the <see cref="T:System.Data.DataRelation" /> object. </exception>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a table. </exception>
		// Token: 0x0600031D RID: 797 RVA: 0x0000B218 File Offset: 0x00009418
		public DataRow GetParentRow(DataRelation relation)
		{
			return this.GetParentRow(relation, DataRowVersion.Default);
		}

		/// <summary>Gets the parent row of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />, and <see cref="T:System.Data.DataRowVersion" />.</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use. </param>
		/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values specifying the version of the data to get. </param>
		/// <returns>The parent <see cref="T:System.Data.DataRow" /> of the current row.</returns>
		/// <exception cref="T:System.ArgumentNullException">The row is <see langword="null" />.The <paramref name="relation" /> does not belong to this table's parent relations. </exception>
		/// <exception cref="T:System.Data.DataException">A child row has multiple parents.</exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The relation's child table is not the table the row belongs to. </exception>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a table. </exception>
		/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have this version of data. </exception>
		// Token: 0x0600031E RID: 798 RVA: 0x0000B228 File Offset: 0x00009428
		public DataRow GetParentRow(DataRelation relation, DataRowVersion version)
		{
			if (relation == null)
			{
				return null;
			}
			if (relation.DataSet != this._table.DataSet)
			{
				throw ExceptionBuilder.RelationForeignRow();
			}
			if (relation.ChildKey.Table != this._table)
			{
				throw ExceptionBuilder.GetParentRowTableMismatch(relation.ChildTable.TableName, this._table.TableName);
			}
			return DataRelation.GetParentRow(relation.ParentKey, relation.ChildKey, this, version);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000B298 File Offset: 0x00009498
		internal DataRow GetNestedParentRow(DataRowVersion version)
		{
			foreach (DataRelation dataRelation in this._table.NestedParentRelations)
			{
				if (dataRelation != null)
				{
					if (dataRelation.ParentTable == this._table)
					{
						this.CheckForLoops(dataRelation);
					}
					DataRow parentRow = this.GetParentRow(dataRelation, version);
					if (parentRow != null)
					{
						return parentRow;
					}
				}
			}
			return null;
		}

		/// <summary>Gets the parent rows of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use. </param>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects or an array of length zero.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Data.DataRelation" /> does not belong to this row's <see cref="T:System.Data.DataSet" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">The row is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The relation's child table is not the table the row belongs to. </exception>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a <see cref="T:System.Data.DataTable" />. </exception>
		// Token: 0x06000320 RID: 800 RVA: 0x0000B2EA File Offset: 0x000094EA
		public DataRow[] GetParentRows(DataRelation relation)
		{
			return this.GetParentRows(relation, DataRowVersion.Default);
		}

		/// <summary>Gets the parent rows of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />, and <see cref="T:System.Data.DataRowVersion" />.</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use. </param>
		/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values specifying the version of the data to get. </param>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects or an array of length zero.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Data.DataRelation" /> does not belong to this row's <see cref="T:System.Data.DataSet" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">The row is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The relation's child table is not the table the row belongs to. </exception>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a <see cref="T:System.Data.DataTable" />. </exception>
		/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have the requested <see cref="T:System.Data.DataRowVersion" />. </exception>
		// Token: 0x06000321 RID: 801 RVA: 0x0000B2F8 File Offset: 0x000094F8
		public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version)
		{
			if (relation == null)
			{
				return this._table.NewRowArray(0);
			}
			if (relation.DataSet != this._table.DataSet)
			{
				throw ExceptionBuilder.RowNotInTheDataSet();
			}
			if (relation.ChildKey.Table != this._table)
			{
				throw ExceptionBuilder.GetParentRowTableMismatch(relation.ChildTable.TableName, this._table.TableName);
			}
			return DataRelation.GetParentRows(relation.ParentKey, relation.ChildKey, this, version);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000B373 File Offset: 0x00009573
		internal object[] GetColumnValues(DataColumn[] columns)
		{
			return this.GetColumnValues(columns, DataRowVersion.Default);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000B384 File Offset: 0x00009584
		internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version)
		{
			DataKey key = new DataKey(columns, false);
			return this.GetKeyValues(key, version);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000B3A4 File Offset: 0x000095A4
		internal object[] GetKeyValues(DataKey key)
		{
			int defaultRecord = this.GetDefaultRecord();
			return key.GetKeyValues(defaultRecord);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000B3C0 File Offset: 0x000095C0
		internal object[] GetKeyValues(DataKey key, DataRowVersion version)
		{
			int recordFromVersion = this.GetRecordFromVersion(version);
			return key.GetKeyValues(recordFromVersion);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000B3DD File Offset: 0x000095DD
		internal int GetCurrentRecordNo()
		{
			if (this._newRecord == -1)
			{
				throw ExceptionBuilder.NoCurrentData();
			}
			return this._newRecord;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000B3F4 File Offset: 0x000095F4
		internal int GetDefaultRecord()
		{
			if (this._tempRecord != -1)
			{
				return this._tempRecord;
			}
			if (this._newRecord != -1)
			{
				return this._newRecord;
			}
			throw (this._oldRecord == -1) ? ExceptionBuilder.RowRemovedFromTheTable() : ExceptionBuilder.DeletedRowInaccessible();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000B42B File Offset: 0x0000962B
		internal int GetOriginalRecordNo()
		{
			if (this._oldRecord == -1)
			{
				throw ExceptionBuilder.NoOriginalData();
			}
			return this._oldRecord;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000B442 File Offset: 0x00009642
		private int GetProposedRecordNo()
		{
			if (this._tempRecord == -1)
			{
				throw ExceptionBuilder.NoProposedData();
			}
			return this._tempRecord;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000B45C File Offset: 0x0000965C
		internal int GetRecordFromVersion(DataRowVersion version)
		{
			if (version <= DataRowVersion.Current)
			{
				if (version == DataRowVersion.Original)
				{
					return this.GetOriginalRecordNo();
				}
				if (version == DataRowVersion.Current)
				{
					return this.GetCurrentRecordNo();
				}
			}
			else
			{
				if (version == DataRowVersion.Proposed)
				{
					return this.GetProposedRecordNo();
				}
				if (version == DataRowVersion.Default)
				{
					return this.GetDefaultRecord();
				}
			}
			throw ExceptionBuilder.InvalidRowVersion();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000B4B8 File Offset: 0x000096B8
		internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState)
		{
			if (this._oldRecord == this._newRecord)
			{
				int oldRecord = this._oldRecord;
				return DataRowVersion.Default;
			}
			if (this._oldRecord == -1)
			{
				return DataRowVersion.Default;
			}
			if (this._newRecord == -1)
			{
				return DataRowVersion.Original;
			}
			if ((DataViewRowState.ModifiedCurrent & viewState) != DataViewRowState.None)
			{
				return DataRowVersion.Default;
			}
			return DataRowVersion.Original;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000B514 File Offset: 0x00009714
		internal DataViewRowState GetRecordState(int record)
		{
			if (record == -1)
			{
				return DataViewRowState.None;
			}
			if (record == this._oldRecord && record == this._newRecord)
			{
				return DataViewRowState.Unchanged;
			}
			if (record == this._oldRecord)
			{
				if (this._newRecord == -1)
				{
					return DataViewRowState.Deleted;
				}
				return DataViewRowState.ModifiedOriginal;
			}
			else
			{
				if (record != this._newRecord)
				{
					return DataViewRowState.None;
				}
				if (this._oldRecord == -1)
				{
					return DataViewRowState.Added;
				}
				return DataViewRowState.ModifiedCurrent;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000B56A File Offset: 0x0000976A
		internal bool HasKeyChanged(DataKey key)
		{
			return this.HasKeyChanged(key, DataRowVersion.Current, DataRowVersion.Proposed);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000B57D File Offset: 0x0000977D
		internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2)
		{
			return !this.HasVersion(version1) || !this.HasVersion(version2) || !key.RecordsEqual(this.GetRecordFromVersion(version1), this.GetRecordFromVersion(version2));
		}

		/// <summary>Gets a value that indicates whether a specified version exists.</summary>
		/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values that specifies the row version. </param>
		/// <returns>
		///     <see langword="true" /> if the version exists; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600032F RID: 815 RVA: 0x0000B5AC File Offset: 0x000097AC
		public bool HasVersion(DataRowVersion version)
		{
			if (version <= DataRowVersion.Current)
			{
				if (version == DataRowVersion.Original)
				{
					return this._oldRecord != -1;
				}
				if (version == DataRowVersion.Current)
				{
					return this._newRecord != -1;
				}
			}
			else
			{
				if (version == DataRowVersion.Proposed)
				{
					return this._tempRecord != -1;
				}
				if (version == DataRowVersion.Default)
				{
					return this._tempRecord != -1 || this._newRecord != -1;
				}
			}
			throw ExceptionBuilder.InvalidRowVersion();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000B62C File Offset: 0x0000982C
		internal bool HasChanges()
		{
			if (!this.HasVersion(DataRowVersion.Original) || !this.HasVersion(DataRowVersion.Current))
			{
				return true;
			}
			using (IEnumerator enumerator = this.Table.Columns.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((DataColumn)enumerator.Current).Compare(this._oldRecord, this._newRecord) != 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000B6B8 File Offset: 0x000098B8
		internal bool HaveValuesChanged(DataColumn[] columns)
		{
			return this.HaveValuesChanged(columns, DataRowVersion.Current, DataRowVersion.Proposed);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000B6CC File Offset: 0x000098CC
		internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2)
		{
			for (int i = 0; i < columns.Length; i++)
			{
				this.CheckColumn(columns[i]);
			}
			DataKey key = new DataKey(columns, false);
			return this.HasKeyChanged(key, version1, version2);
		}

		/// <summary>Rejects all changes made to the row since <see cref="M:System.Data.DataRow.AcceptChanges" /> was last called.</summary>
		/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table. </exception>
		// Token: 0x06000333 RID: 819 RVA: 0x0000B704 File Offset: 0x00009904
		public void RejectChanges()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataRow.RejectChanges|API> {0}", this._objectID);
			try
			{
				if (this.RowState != DataRowState.Detached)
				{
					if (this._columns.ColumnsImplementingIChangeTrackingCount != this._columns.ColumnsImplementingIRevertibleChangeTrackingCount)
					{
						foreach (DataColumn dataColumn in this._columns.ColumnsImplementingIChangeTracking)
						{
							if (!dataColumn.ImplementsIRevertibleChangeTracking)
							{
								object obj;
								if (this.RowState != DataRowState.Deleted)
								{
									obj = this[dataColumn];
								}
								else
								{
									obj = this[dataColumn, DataRowVersion.Original];
								}
								if (DBNull.Value != obj && ((IChangeTracking)obj).IsChanged)
								{
									throw ExceptionBuilder.UDTImplementsIChangeTrackingButnotIRevertible(dataColumn.DataType.AssemblyQualifiedName);
								}
							}
						}
					}
					foreach (DataColumn column in this._columns.ColumnsImplementingIChangeTracking)
					{
						object obj2;
						if (this.RowState != DataRowState.Deleted)
						{
							obj2 = this[column];
						}
						else
						{
							obj2 = this[column, DataRowVersion.Original];
						}
						if (DBNull.Value != obj2 && ((IChangeTracking)obj2).IsChanged)
						{
							((IRevertibleChangeTracking)obj2).RejectChanges();
						}
					}
				}
				this._table.RollbackRow(this);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000B860 File Offset: 0x00009A60
		internal void ResetLastChangedColumn()
		{
			this._lastChangedColumn = null;
			this._countColumnChange = 0;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000B870 File Offset: 0x00009A70
		internal void SetKeyValues(DataKey key, object[] keyValues)
		{
			bool flag = true;
			bool flag2 = this._tempRecord == -1;
			for (int i = 0; i < keyValues.Length; i++)
			{
				if (!this[key.ColumnsReference[i]].Equals(keyValues[i]))
				{
					if (flag2 && flag)
					{
						flag = false;
						this.BeginEditInternal();
					}
					this[key.ColumnsReference[i]] = keyValues[i];
				}
			}
			if (!flag)
			{
				this.EndEdit();
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B8DC File Offset: 0x00009ADC
		internal void SetNestedParentRow(DataRow parentRow, bool setNonNested)
		{
			if (parentRow == null)
			{
				this.SetParentRowToDBNull();
				return;
			}
			foreach (object obj in this._table.ParentRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				if ((dataRelation.Nested || setNonNested) && dataRelation.ParentKey.Table == parentRow._table)
				{
					object[] keyValues = parentRow.GetKeyValues(dataRelation.ParentKey);
					this.SetKeyValues(dataRelation.ChildKey, keyValues);
					if (dataRelation.Nested)
					{
						if (parentRow._table == this._table)
						{
							this.CheckForLoops(dataRelation);
						}
						else
						{
							this.GetParentRow(dataRelation);
						}
					}
				}
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		internal void SetParentRowToDBNull()
		{
			foreach (object obj in this._table.ParentRelations)
			{
				DataRelation parentRowToDBNull = (DataRelation)obj;
				this.SetParentRowToDBNull(parentRowToDBNull);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000BA04 File Offset: 0x00009C04
		internal void SetParentRowToDBNull(DataRelation relation)
		{
			if (relation.ChildKey.Table != this._table)
			{
				throw ExceptionBuilder.SetParentRowTableMismatch(relation.ChildKey.Table.TableName, this._table.TableName);
			}
			object[] keyValues = new object[]
			{
				DBNull.Value
			};
			this.SetKeyValues(relation.ChildKey, keyValues);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000BA68 File Offset: 0x00009C68
		internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex)
		{
			int num = 0;
			if (this._oldRecord != -1)
			{
				for (int i = 0; i < this._columns.Count; i++)
				{
					this._columns[i].CopyValueIntoStore(this._oldRecord, storeList[i], (BitArray)nullbitList[i], storeIndex);
				}
				num++;
				storeIndex++;
			}
			DataRowState rowState = this.RowState;
			if (DataRowState.Added == rowState || DataRowState.Modified == rowState)
			{
				for (int j = 0; j < this._columns.Count; j++)
				{
					this._columns[j].CopyValueIntoStore(this._newRecord, storeList[j], (BitArray)nullbitList[j], storeIndex);
				}
				num++;
				storeIndex++;
			}
			if (-1 != this._tempRecord)
			{
				for (int k = 0; k < this._columns.Count; k++)
				{
					this._columns[k].CopyValueIntoStore(this._tempRecord, storeList[k], (BitArray)nullbitList[k], storeIndex);
				}
				num++;
				storeIndex++;
			}
			return num;
		}

		// Token: 0x04000084 RID: 132
		private readonly DataTable _table;

		// Token: 0x04000085 RID: 133
		private readonly DataColumnCollection _columns;

		// Token: 0x04000086 RID: 134
		internal int _oldRecord = -1;

		// Token: 0x04000087 RID: 135
		internal int _newRecord = -1;

		// Token: 0x04000088 RID: 136
		internal int _tempRecord;

		// Token: 0x04000089 RID: 137
		internal long _rowID = -1L;

		// Token: 0x0400008A RID: 138
		internal DataRowAction _action;

		// Token: 0x0400008B RID: 139
		internal bool _inChangingEvent;

		// Token: 0x0400008C RID: 140
		internal bool _inDeletingEvent;

		// Token: 0x0400008D RID: 141
		internal bool _inCascade;

		// Token: 0x0400008E RID: 142
		private DataColumn _lastChangedColumn;

		// Token: 0x0400008F RID: 143
		private int _countColumnChange;

		// Token: 0x04000090 RID: 144
		private DataError _error;

		// Token: 0x04000091 RID: 145
		private int _rbTreeNodeId;

		// Token: 0x04000092 RID: 146
		private static int s_objectTypeCount;

		// Token: 0x04000093 RID: 147
		internal readonly int _objectID = Interlocked.Increment(ref DataRow.s_objectTypeCount);
	}
}
