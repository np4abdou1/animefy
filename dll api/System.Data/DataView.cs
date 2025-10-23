using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace System.Data
{
	/// <summary>Represents a databindable, customized view of a <see cref="T:System.Data.DataTable" /> for sorting, filtering, searching, editing, and navigation. The <see cref="T:System.Data.DataView" /> does not store data, but instead represents a connected view of its corresponding <see cref="T:System.Data.DataTable" />. Changes to the <see cref="T:System.Data.DataView" />’s data will affect the <see cref="T:System.Data.DataTable" />. Changes to the <see cref="T:System.Data.DataTable" />’s data will affect all <see cref="T:System.Data.DataView" />s associated with it.</summary>
	// Token: 0x02000047 RID: 71
	[DefaultProperty("Table")]
	[DefaultEvent("PositionChanged")]
	public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList, ISupportInitializeNotification, ISupportInitialize
	{
		// Token: 0x060005C2 RID: 1474 RVA: 0x0001B910 File Offset: 0x00019B10
		internal DataView(DataTable table, bool locked)
		{
			GC.SuppressFinalize(this);
			DataCommonEventSource.Log.Trace<int, int, bool>("<ds.DataView.DataView|INFO> {0}, table={1}, locked={2}", this.ObjectID, (table != null) ? table.ObjectID : 0, locked);
			this._dvListener = new DataViewListener(this);
			this._locked = locked;
			this._table = table;
			this._dvListener.RegisterMetaDataEvents(this._table);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataView" /> class with the specified <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="table">A <see cref="T:System.Data.DataTable" /> to add to the <see cref="T:System.Data.DataView" />. </param>
		// Token: 0x060005C3 RID: 1475 RVA: 0x0001B9DC File Offset: 0x00019BDC
		public DataView(DataTable table) : this(table, false)
		{
			this.SetIndex2("", DataViewRowState.CurrentRows, null, true);
		}

		/// <summary>Sets or gets a value that indicates whether deletes are allowed.</summary>
		/// <returns>
		///     <see langword="true" />, if deletes are allowed; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001B9F5 File Offset: 0x00019BF5
		[DefaultValue(true)]
		public bool AllowDelete
		{
			get
			{
				return this._allowDelete;
			}
		}

		/// <summary>Gets or sets a value that indicates whether edits are allowed.</summary>
		/// <returns>
		///     <see langword="true" />, if edits are allowed; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001B9FD File Offset: 0x00019BFD
		[DefaultValue(true)]
		public bool AllowEdit
		{
			get
			{
				return this._allowEdit;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the new rows can be added by using the <see cref="M:System.Data.DataView.AddNew" /> method.</summary>
		/// <returns>
		///     <see langword="true" />, if new rows can be added; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001BA05 File Offset: 0x00019C05
		[DefaultValue(true)]
		public bool AllowNew
		{
			get
			{
				return this._allowNew;
			}
		}

		/// <summary>Gets the number of records in the <see cref="T:System.Data.DataView" /> after <see cref="P:System.Data.DataView.RowFilter" /> and <see cref="P:System.Data.DataView.RowStateFilter" /> have been applied.</summary>
		/// <returns>The number of records in the <see cref="T:System.Data.DataView" />.</returns>
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001BA0D File Offset: 0x00019C0D
		[Browsable(false)]
		public int Count
		{
			get
			{
				return this._rowViewCache.Count;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001BA1A File Offset: 0x00019C1A
		private int CountFromIndex
		{
			get
			{
				return ((this._index != null) ? this._index.RecordCount : 0) + ((this._addNewRow != null) ? 1 : 0);
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataViewManager" /> associated with this view.</summary>
		/// <returns>The <see langword="DataViewManager" /> that created this view. If this is the default <see cref="T:System.Data.DataView" /> for a <see cref="T:System.Data.DataTable" />, the <see langword="DataViewManager" /> property returns the default <see langword="DataViewManager" /> for the <see langword="DataSet" />. Otherwise, if the <see langword="DataView" /> was created without a <see langword="DataViewManager" />, this property is <see langword="null" />.</returns>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001BA3F File Offset: 0x00019C3F
		[Browsable(false)]
		public DataViewManager DataViewManager
		{
			get
			{
				return this._dataViewManager;
			}
		}

		/// <summary>Gets a value that indicates whether the data source is currently open and projecting views of data on the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>
		///     <see langword="true" />, if the source is open; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0001BA47 File Offset: 0x00019C47
		[Browsable(false)]
		protected bool IsOpen
		{
			get
			{
				return this._open;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000020BC File Offset: 0x000002BC
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets or sets the expression used to filter which rows are viewed in the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>A string that specifies how rows are to be filtered. For more information, see the Remarks section.</returns>
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001BA50 File Offset: 0x00019C50
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0001BA78 File Offset: 0x00019C78
		[DefaultValue("")]
		public virtual string RowFilter
		{
			get
			{
				DataExpression dataExpression = this._rowFilter as DataExpression;
				if (dataExpression != null)
				{
					return dataExpression.Expression;
				}
				return "";
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				DataCommonEventSource.Log.Trace<int, string>("<ds.DataView.set_RowFilter|API> {0}, '{1}'", this.ObjectID, value);
				if (this._fInitInProgress)
				{
					this._delayedRowFilter = value;
					return;
				}
				CultureInfo culture = (this._table != null) ? this._table.Locale : CultureInfo.CurrentCulture;
				if (this._rowFilter == null || string.Compare(this.RowFilter, value, false, culture) != 0)
				{
					DataExpression newRowFilter = new DataExpression(this._table, value);
					this.SetIndex(this._sort, this._recordStates, newRowFilter);
				}
			}
		}

		/// <summary>Gets or sets the row state filter used in the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>One of the <see cref="T:System.Data.DataViewRowState" /> values.</returns>
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0001BB08 File Offset: 0x00019D08
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0001BB10 File Offset: 0x00019D10
		[DefaultValue(DataViewRowState.CurrentRows)]
		public DataViewRowState RowStateFilter
		{
			get
			{
				return this._recordStates;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, DataViewRowState>("<ds.DataView.set_RowStateFilter|API> {0}, {1}", this.ObjectID, value);
				if (this._fInitInProgress)
				{
					this._delayedRecordStates = value;
					return;
				}
				if ((value & ~(DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent | DataViewRowState.ModifiedOriginal)) != DataViewRowState.None)
				{
					throw ExceptionBuilder.RecordStateRange();
				}
				if ((value & DataViewRowState.ModifiedOriginal) != DataViewRowState.None && (value & DataViewRowState.ModifiedCurrent) != DataViewRowState.None)
				{
					throw ExceptionBuilder.SetRowStateFilter();
				}
				if (this._recordStates != value)
				{
					this.SetIndex(this._sort, value, this._rowFilter);
				}
			}
		}

		/// <summary>Gets or sets the sort column or columns, and sort order for the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>A string that contains the column name followed by "ASC" (ascending) or "DESC" (descending). Columns are sorted ascending by default. Multiple columns can be separated by commas.</returns>
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001BB80 File Offset: 0x00019D80
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0001BBD8 File Offset: 0x00019DD8
		[DefaultValue("")]
		public string Sort
		{
			get
			{
				if (this._sort.Length == 0 && this._applyDefaultSort && this._table != null && this._table._primaryIndex.Length != 0)
				{
					return this._table.FormatSortString(this._table._primaryIndex);
				}
				return this._sort;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				DataCommonEventSource.Log.Trace<int, string>("<ds.DataView.set_Sort|API> {0}, '{1}'", this.ObjectID, value);
				if (this._fInitInProgress)
				{
					this._delayedSort = value;
					return;
				}
				CultureInfo culture = (this._table != null) ? this._table.Locale : CultureInfo.CurrentCulture;
				if (string.Compare(this._sort, value, false, culture) != 0 || this._comparison != null)
				{
					this.CheckSort(value);
					this._comparison = null;
					this.SetIndex(value, this._recordStates, this._rowFilter);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001BC69 File Offset: 0x00019E69
		internal Comparison<DataRow> SortComparison
		{
			get
			{
				return this._comparison;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</returns>
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets or sets the source <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> that provides the data for this view.</returns>
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001BC71 File Offset: 0x00019E71
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0001BC7C File Offset: 0x00019E7C
		[TypeConverter(typeof(DataTableTypeConverter))]
		[DefaultValue(null)]
		[RefreshProperties(RefreshProperties.All)]
		public DataTable Table
		{
			get
			{
				return this._table;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, int>("<ds.DataView.set_Table|API> {0}, {1}", this.ObjectID, (value != null) ? value.ObjectID : 0);
				if (this._fInitInProgress && value != null)
				{
					this._delayedTable = value;
					return;
				}
				if (this._locked)
				{
					throw ExceptionBuilder.SetTable();
				}
				if (this._dataViewManager != null)
				{
					throw ExceptionBuilder.CanNotSetTable();
				}
				if (value != null && value.TableName.Length == 0)
				{
					throw ExceptionBuilder.CanNotBindTable();
				}
				if (this._table != value)
				{
					this._dvListener.UnregisterMetaDataEvents();
					this._table = value;
					if (this._table != null)
					{
						this._dvListener.RegisterMetaDataEvents(this._table);
					}
					this.SetIndex2("", DataViewRowState.CurrentRows, null, false);
					if (this._table != null)
					{
						this.OnListChanged(new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, new DataTablePropertyDescriptor(this._table)));
					}
					this.OnListChanged(DataView.s_resetEventArgs);
				}
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</summary>
		/// <param name="recordIndex">A <see cref="System.Int32" /> value.</param>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</returns>
		// Token: 0x170000EA RID: 234
		object IList.this[int recordIndex]
		{
			get
			{
				return this[recordIndex];
			}
			set
			{
				throw ExceptionBuilder.SetIListObject();
			}
		}

		/// <summary>Gets a row of data from a specified table.</summary>
		/// <param name="recordIndex">The index of a record in the <see cref="T:System.Data.DataTable" />. </param>
		/// <returns>A <see cref="T:System.Data.DataRowView" /> of the row that you want.</returns>
		// Token: 0x170000EB RID: 235
		public DataRowView this[int recordIndex]
		{
			get
			{
				return this.GetRowView(this.GetRow(recordIndex));
			}
		}

		/// <summary>Adds a new row to the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>A new <see cref="T:System.Data.DataRowView" /> object.</returns>
		// Token: 0x060005D9 RID: 1497 RVA: 0x0001BD7C File Offset: 0x00019F7C
		public virtual DataRowView AddNew()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataView.AddNew|API> {0}", this.ObjectID);
			DataRowView result;
			try
			{
				this.CheckOpen();
				if (!this.AllowNew)
				{
					throw ExceptionBuilder.AddNewNotAllowNull();
				}
				if (this._addNewRow != null)
				{
					this._rowViewCache[this._addNewRow].EndEdit();
				}
				this._addNewRow = this._table.NewRow();
				DataRowView dataRowView = new DataRowView(this, this._addNewRow);
				this._rowViewCache.Add(this._addNewRow, dataRowView);
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, this.IndexOf(dataRowView)));
				result = dataRowView;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Ends the initialization of a <see cref="T:System.Data.DataView" /> that is used on a form or used by another component. The initialization occurs at runtime.</summary>
		// Token: 0x060005DA RID: 1498 RVA: 0x0001BE38 File Offset: 0x0001A038
		public void EndInit()
		{
			if (this._delayedTable != null && this._delayedTable.fInitInProgress)
			{
				this._delayedTable._delayedViews.Add(this);
				return;
			}
			this._fInitInProgress = false;
			this._fEndInitInProgress = true;
			if (this._delayedTable != null)
			{
				this.Table = this._delayedTable;
				this._delayedTable = null;
			}
			if (this._delayedSort != null)
			{
				this.Sort = this._delayedSort;
				this._delayedSort = null;
			}
			if (this._delayedRowFilter != null)
			{
				this.RowFilter = this._delayedRowFilter;
				this._delayedRowFilter = null;
			}
			if (this._delayedRecordStates != (DataViewRowState)(-1))
			{
				this.RowStateFilter = this._delayedRecordStates;
				this._delayedRecordStates = (DataViewRowState)(-1);
			}
			this._fEndInitInProgress = false;
			this.SetIndex(this.Sort, this.RowStateFilter, this._rowFilter);
			this.OnInitialized();
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001BF0C File Offset: 0x0001A10C
		private void CheckOpen()
		{
			if (!this.IsOpen)
			{
				throw ExceptionBuilder.NotOpen();
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001BF1C File Offset: 0x0001A11C
		private void CheckSort(string sort)
		{
			if (this._table == null)
			{
				throw ExceptionBuilder.CanNotUse();
			}
			if (sort.Length == 0)
			{
				return;
			}
			this._table.ParseSortString(sort);
		}

		/// <summary>Closes the <see cref="T:System.Data.DataView" />.</summary>
		// Token: 0x060005DD RID: 1501 RVA: 0x0001BF42 File Offset: 0x0001A142
		protected void Close()
		{
			this._shouldOpen = false;
			this.UpdateIndex();
			this._dvListener.UnregisterMetaDataEvents();
		}

		/// <summary>Copies items into an array. Only for Web Forms Interfaces.</summary>
		/// <param name="array">array to copy into. </param>
		/// <param name="index">index to start at. </param>
		// Token: 0x060005DE RID: 1502 RVA: 0x0001BF5C File Offset: 0x0001A15C
		public void CopyTo(Array array, int index)
		{
			checked
			{
				if (this._index != null)
				{
					RBTree<int>.RBTreeEnumerator enumerator = this._index.GetEnumerator(0);
					while (enumerator.MoveNext())
					{
						int record = enumerator.Current;
						array.SetValue(this.GetRowView(record), index);
						index++;
					}
				}
				if (this._addNewRow != null)
				{
					array.SetValue(this._rowViewCache[this._addNewRow], index);
				}
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0001BFC4 File Offset: 0x0001A1C4
		private void CopyTo(DataRowView[] array, int index)
		{
			checked
			{
				if (this._index != null)
				{
					RBTree<int>.RBTreeEnumerator enumerator = this._index.GetEnumerator(0);
					while (enumerator.MoveNext())
					{
						int record = enumerator.Current;
						array[index] = this.GetRowView(record);
						index++;
					}
				}
				if (this._addNewRow != null)
				{
					array[index] = this._rowViewCache[this._addNewRow];
				}
			}
		}

		/// <summary>Deletes a row at the specified index.</summary>
		/// <param name="index">The index of the row to delete. </param>
		// Token: 0x060005E0 RID: 1504 RVA: 0x0001C022 File Offset: 0x0001A222
		public void Delete(int index)
		{
			this.Delete(this.GetRow(index));
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0001C034 File Offset: 0x0001A234
		internal void Delete(DataRow row)
		{
			if (row != null)
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataView.Delete|API> {0}, row={1}", this.ObjectID, row._objectID);
				try
				{
					this.CheckOpen();
					if (row == this._addNewRow)
					{
						this.FinishAddNew(false);
					}
					else
					{
						if (!this.AllowDelete)
						{
							throw ExceptionBuilder.CanNotDelete();
						}
						row.Delete();
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		/// <summary>Disposes of the resources (other than memory) used by the <see cref="T:System.Data.DataView" /> object.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060005E2 RID: 1506 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
		internal void FinishAddNew(bool success)
		{
			DataCommonEventSource.Log.Trace<int, bool>("<ds.DataView.FinishAddNew|INFO> {0}, success={1}", this.ObjectID, success);
			DataRow addNewRow = this._addNewRow;
			if (success)
			{
				if (DataRowState.Detached == addNewRow.RowState)
				{
					this._table.Rows.Add(addNewRow);
				}
				else
				{
					addNewRow.EndEdit();
				}
			}
			if (addNewRow == this._addNewRow)
			{
				this._rowViewCache.Remove(this._addNewRow);
				this._addNewRow = null;
				if (!success)
				{
					addNewRow.CancelEdit();
				}
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, this.Count));
			}
		}

		/// <summary>Gets an enumerator for this <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for navigating through the list.</returns>
		// Token: 0x060005E4 RID: 1508 RVA: 0x0001C14C File Offset: 0x0001A34C
		public IEnumerator GetEnumerator()
		{
			DataRowView[] array = new DataRowView[this.Count];
			this.CopyTo(array, 0);
			return array.GetEnumerator();
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</returns>
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000020BC File Offset: 0x000002BC
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</returns>
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000020BC File Offset: 0x000002BC
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</summary>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</returns>
		// Token: 0x060005E7 RID: 1511 RVA: 0x0001C173 File Offset: 0x0001A373
		int IList.Add(object value)
		{
			if (value == null)
			{
				this.AddNew();
				return this.Count - 1;
			}
			throw ExceptionBuilder.AddExternalObject();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Clear" />.</summary>
		// Token: 0x060005E8 RID: 1512 RVA: 0x0001C18D File Offset: 0x0001A38D
		void IList.Clear()
		{
			throw ExceptionBuilder.CanNotClear();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</summary>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</returns>
		// Token: 0x060005E9 RID: 1513 RVA: 0x0001C194 File Offset: 0x0001A394
		bool IList.Contains(object value)
		{
			return 0 <= this.IndexOf(value as DataRowView);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</summary>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</returns>
		// Token: 0x060005EA RID: 1514 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as DataRowView);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		internal int IndexOf(DataRowView rowview)
		{
			if (rowview != null)
			{
				if (this._addNewRow == rowview.Row)
				{
					return this.Count - 1;
				}
				DataRowView dataRowView;
				if (this._index != null && DataRowState.Detached != rowview.Row.RowState && this._rowViewCache.TryGetValue(rowview.Row, out dataRowView) && dataRowView == rowview)
				{
					return this.IndexOfDataRowView(rowview);
				}
			}
			return -1;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001C217 File Offset: 0x0001A417
		private int IndexOfDataRowView(DataRowView rowview)
		{
			return this._index.GetIndex(rowview.Row.GetRecordFromVersion(rowview.Row.GetDefaultRowVersion(this.RowStateFilter) & (DataRowVersion)(-1025)));
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Insert(System.Int32,System.Object)" />.</summary>
		/// <param name="index">A <see cref="System.Int32" /> value.</param>
		/// <param name="value">A <see cref="System.Object" /> value to be inserted.</param>
		// Token: 0x060005ED RID: 1517 RVA: 0x0001C246 File Offset: 0x0001A446
		void IList.Insert(int index, object value)
		{
			throw ExceptionBuilder.InsertExternalObject();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Remove(System.Object)" />.</summary>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		// Token: 0x060005EE RID: 1518 RVA: 0x0001C250 File Offset: 0x0001A450
		void IList.Remove(object value)
		{
			int num = this.IndexOf(value as DataRowView);
			if (0 <= num)
			{
				((IList)this).RemoveAt(num);
				return;
			}
			throw ExceptionBuilder.RemoveExternalObject();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.RemoveAt(System.Int32)" />.</summary>
		/// <param name="index">A <see cref="System.Int32" /> value.</param>
		// Token: 0x060005EF RID: 1519 RVA: 0x0001C27B File Offset: 0x0001A47B
		void IList.RemoveAt(int index)
		{
			this.Delete(index);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001C284 File Offset: 0x0001A484
		internal Index GetFindIndex(string column, bool keepIndex)
		{
			if (this._findIndexes == null)
			{
				this._findIndexes = new Dictionary<string, Index>();
			}
			Index index;
			if (this._findIndexes.TryGetValue(column, out index))
			{
				if (!keepIndex)
				{
					this._findIndexes.Remove(column);
					index.RemoveRef();
					if (index.RefCount == 1)
					{
						index.RemoveRef();
					}
				}
			}
			else if (keepIndex)
			{
				index = this._table.GetIndex(column, this._recordStates, this.GetFilter());
				this._findIndexes[column] = index;
				index.AddRef();
			}
			return index;
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowNew" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowNew" />.</returns>
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001C30D File Offset: 0x0001A50D
		bool IBindingList.AllowNew
		{
			get
			{
				return this.AllowNew;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</summary>
		/// <returns>The item added to the list.</returns>
		// Token: 0x060005F2 RID: 1522 RVA: 0x0001C315 File Offset: 0x0001A515
		object IBindingList.AddNew()
		{
			return this.AddNew();
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowEdit" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowEdit" />.</returns>
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001C31D File Offset: 0x0001A51D
		bool IBindingList.AllowEdit
		{
			get
			{
				return this.AllowEdit;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowRemove" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowRemove" />.</returns>
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001C325 File Offset: 0x0001A525
		bool IBindingList.AllowRemove
		{
			get
			{
				return this.AllowDelete;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</returns>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00002317 File Offset: 0x00000517
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</returns>
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00002317 File Offset: 0x00000517
		bool IBindingList.SupportsSearching
		{
			get
			{
				return true;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</returns>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00002317 File Offset: 0x00000517
		bool IBindingList.SupportsSorting
		{
			get
			{
				return true;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</returns>
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001C32D File Offset: 0x0001A52D
		bool IBindingList.IsSorted
		{
			get
			{
				return this.Sort.Length != 0;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</returns>
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001C33D File Offset: 0x0001A53D
		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
				return this.GetSortProperty();
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001C345 File Offset: 0x0001A545
		internal PropertyDescriptor GetSortProperty()
		{
			if (this._table != null && this._index != null && this._index._indexFields.Length == 1)
			{
				return new DataColumnPropertyDescriptor(this._index._indexFields[0].Column);
			}
			return null;
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</returns>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001C384 File Offset: 0x0001A584
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				if (this._index._indexFields.Length != 1 || !this._index._indexFields[0].IsDescending)
				{
					return ListSortDirection.Ascending;
				}
				return ListSortDirection.Descending;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
		/// <param name="property">A <see cref="System.ComponentModel.PropertyDescriptor" /> object.</param>
		// Token: 0x060005FC RID: 1532 RVA: 0x0001C3B1 File Offset: 0x0001A5B1
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
			this.GetFindIndex(property.Name, true);
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" />.</summary>
		/// <param name="property">A <see cref="System.ComponentModel.PropertyDescriptor" /> object.</param>
		/// <param name="direction">A <see cref="System.ComponentModel.ListSortDirection" /> object.</param>
		// Token: 0x060005FD RID: 1533 RVA: 0x0001C3C1 File Offset: 0x0001A5C1
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			this.Sort = this.CreateSortString(property, direction);
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />.</summary>
		/// <param name="property">A <see cref="System.ComponentModel.PropertyDescriptor" /> object.</param>
		/// <param name="key">A <see cref="System.Object" /> value.</param>
		/// <returns>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />.</returns>
		// Token: 0x060005FE RID: 1534 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			if (property != null)
			{
				bool flag = false;
				Index index = null;
				try
				{
					if (this._findIndexes == null || !this._findIndexes.TryGetValue(property.Name, out index))
					{
						flag = true;
						index = this._table.GetIndex(property.Name, this._recordStates, this.GetFilter());
						index.AddRef();
					}
					Range range = index.FindRecords(key);
					if (!range.IsNull)
					{
						return this._index.GetIndex(index.GetRecord(range.Min));
					}
				}
				finally
				{
					if (flag && index != null)
					{
						index.RemoveRef();
						if (index.RefCount == 1)
						{
							index.RemoveRef();
						}
					}
				}
				return -1;
			}
			return -1;
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
		/// <param name="property">A <see cref="System.ComponentModel.PropertyDescriptor" /> object.</param>
		// Token: 0x060005FF RID: 1535 RVA: 0x0001C490 File Offset: 0x0001A690
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
			this.GetFindIndex(property.Name, false);
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.RemoveSort" />.</summary>
		// Token: 0x06000600 RID: 1536 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		void IBindingList.RemoveSort()
		{
			DataCommonEventSource.Log.Trace<int>("<ds.DataView.RemoveSort|API> {0}", this.ObjectID);
			this.Sort = string.Empty;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		private string CreateSortString(PropertyDescriptor property, ListSortDirection direction)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('[');
			stringBuilder.Append(property.Name);
			stringBuilder.Append(']');
			if (ListSortDirection.Descending == direction)
			{
				stringBuilder.Append(" DESC");
			}
			return stringBuilder.ToString();
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[])" />.</summary>
		/// <param name="listAccessors">An array of <see cref="System.ComponentModel.PropertyDescriptor" /> objects.</param>
		/// <returns>For a description of this member, see <see cref="M:System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[])" />.</returns>
		// Token: 0x06000602 RID: 1538 RVA: 0x0001C50C File Offset: 0x0001A70C
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			if (this._table != null)
			{
				if (listAccessors == null || listAccessors.Length == 0)
				{
					return this._table.TableName;
				}
				DataSet dataSet = this._table.DataSet;
				if (dataSet != null)
				{
					DataTable dataTable = dataSet.FindTable(this._table, listAccessors, 0);
					if (dataTable != null)
					{
						return dataTable.TableName;
					}
				}
			}
			return string.Empty;
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[])" />.</summary>
		// Token: 0x06000603 RID: 1539 RVA: 0x0001C564 File Offset: 0x0001A764
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			if (this._table != null)
			{
				if (listAccessors == null || listAccessors.Length == 0)
				{
					return this._table.GetPropertyDescriptorCollection(null);
				}
				DataSet dataSet = this._table.DataSet;
				if (dataSet == null)
				{
					return new PropertyDescriptorCollection(null);
				}
				DataTable dataTable = dataSet.FindTable(this._table, listAccessors, 0);
				if (dataTable != null)
				{
					return dataTable.GetPropertyDescriptorCollection(null);
				}
			}
			return new PropertyDescriptorCollection(null);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001C5C3 File Offset: 0x0001A7C3
		internal virtual IFilter GetFilter()
		{
			return this._rowFilter;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001C5CB File Offset: 0x0001A7CB
		private int GetRecord(int recordIndex)
		{
			if (this.Count <= recordIndex)
			{
				throw ExceptionBuilder.RowOutOfRange(recordIndex);
			}
			if (recordIndex != this._index.RecordCount)
			{
				return this._index.GetRecord(recordIndex);
			}
			return this._addNewRow.GetDefaultRecord();
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0001C604 File Offset: 0x0001A804
		internal DataRow GetRow(int index)
		{
			int count = this.Count;
			if (count <= index)
			{
				throw ExceptionBuilder.GetElementIndex(index);
			}
			if (index == count - 1 && this._addNewRow != null)
			{
				return this._addNewRow;
			}
			return this._table._recordManager[this.GetRecord(index)];
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0001C64F File Offset: 0x0001A84F
		private DataRowView GetRowView(int record)
		{
			return this.GetRowView(this._table._recordManager[record]);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0001C668 File Offset: 0x0001A868
		private DataRowView GetRowView(DataRow dr)
		{
			return this._rowViewCache[dr];
		}

		/// <summary>Occurs after a <see cref="T:System.Data.DataView" /> has been changed successfully.</summary>
		/// <param name="sender">The source of the event. </param>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		// Token: 0x06000609 RID: 1545 RVA: 0x0001C676 File Offset: 0x0001A876
		protected virtual void IndexListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType != ListChangedType.Reset)
			{
				this.OnListChanged(e);
			}
			if (this._addNewRow != null && this._index.RecordCount == 0)
			{
				this.FinishAddNew(false);
			}
			if (e.ListChangedType == ListChangedType.Reset)
			{
				this.OnListChanged(e);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001C6B4 File Offset: 0x0001A8B4
		internal void IndexListChangedInternal(ListChangedEventArgs e)
		{
			this._rowViewBuffer.Clear();
			if (ListChangedType.ItemAdded == e.ListChangedType && this._addNewMoved != null && this._addNewMoved.NewIndex != this._addNewMoved.OldIndex)
			{
				ListChangedEventArgs addNewMoved = this._addNewMoved;
				this._addNewMoved = null;
				this.IndexListChanged(this, addNewMoved);
			}
			this.IndexListChanged(this, e);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001C714 File Offset: 0x0001A914
		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
			DataRowView dataRowView = null;
			switch (changedType)
			{
			case ListChangedType.Reset:
				this.ResetRowViewCache();
				break;
			case ListChangedType.ItemAdded:
				if (trackAddRemove && this._rowViewBuffer.TryGetValue(row, out dataRowView))
				{
					this._rowViewBuffer.Remove(row);
				}
				if (row == this._addNewRow)
				{
					int newIndex = this.IndexOfDataRowView(this._rowViewCache[this._addNewRow]);
					this._addNewRow = null;
					this._addNewMoved = new ListChangedEventArgs(ListChangedType.ItemMoved, newIndex, this.Count - 1);
					return;
				}
				if (!this._rowViewCache.ContainsKey(row))
				{
					this._rowViewCache.Add(row, dataRowView ?? new DataRowView(this, row));
					return;
				}
				break;
			case ListChangedType.ItemDeleted:
				if (trackAddRemove)
				{
					this._rowViewCache.TryGetValue(row, out dataRowView);
					if (dataRowView != null)
					{
						this._rowViewBuffer.Add(row, dataRowView);
					}
				}
				this._rowViewCache.Remove(row);
				return;
			case ListChangedType.ItemMoved:
			case ListChangedType.ItemChanged:
			case ListChangedType.PropertyDescriptorAdded:
			case ListChangedType.PropertyDescriptorDeleted:
			case ListChangedType.PropertyDescriptorChanged:
				break;
			default:
				return;
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataView.ListChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		// Token: 0x0600060C RID: 1548 RVA: 0x0001C808 File Offset: 0x0001AA08
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			DataCommonEventSource.Log.Trace<int, ListChangedType>("<ds.DataView.OnListChanged|INFO> {0}, ListChangedType={1}", this.ObjectID, e.ListChangedType);
			try
			{
				DataColumn dataColumn = null;
				string text = null;
				switch (e.ListChangedType)
				{
				case ListChangedType.ItemMoved:
				case ListChangedType.ItemChanged:
					if (0 <= e.NewIndex)
					{
						DataRow row = this.GetRow(e.NewIndex);
						if (row.HasPropertyChanged)
						{
							dataColumn = row.LastChangedColumn;
							text = ((dataColumn != null) ? dataColumn.ColumnName : string.Empty);
						}
					}
					break;
				}
				if (this._onListChanged != null)
				{
					if (dataColumn != null && e.NewIndex == e.OldIndex)
					{
						ListChangedEventArgs e2 = new ListChangedEventArgs(e.ListChangedType, e.NewIndex, new DataColumnPropertyDescriptor(dataColumn));
						this._onListChanged(this, e2);
					}
					else
					{
						this._onListChanged(this, e);
					}
				}
				if (text != null)
				{
					this[e.NewIndex].RaisePropertyChangedEvent(text);
				}
			}
			catch (Exception e3) when (ADP.IsCatchableExceptionType(e3))
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e3);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001C934 File Offset: 0x0001AB34
		private void OnInitialized()
		{
			EventHandler initialized = this.Initialized;
			if (initialized == null)
			{
				return;
			}
			initialized(this, EventArgs.Empty);
		}

		/// <summary>Reserved for internal use only.</summary>
		// Token: 0x0600060E RID: 1550 RVA: 0x0001C94C File Offset: 0x0001AB4C
		protected void Reset()
		{
			if (this.IsOpen)
			{
				this._index.Reset();
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001C964 File Offset: 0x0001AB64
		internal void ResetRowViewCache()
		{
			Dictionary<DataRow, DataRowView> dictionary = new Dictionary<DataRow, DataRowView>(this.CountFromIndex, DataView.DataRowReferenceComparer.s_default);
			if (this._index != null)
			{
				RBTree<int>.RBTreeEnumerator enumerator = this._index.GetEnumerator(0);
				while (enumerator.MoveNext())
				{
					int record = enumerator.Current;
					DataRow dataRow = this._table._recordManager[record];
					DataRowView value;
					if (!this._rowViewCache.TryGetValue(dataRow, out value))
					{
						value = new DataRowView(this, dataRow);
					}
					dictionary.Add(dataRow, value);
				}
			}
			if (this._addNewRow != null)
			{
				DataRowView value;
				this._rowViewCache.TryGetValue(this._addNewRow, out value);
				dictionary.Add(this._addNewRow, value);
			}
			this._rowViewCache = dictionary;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001CA0C File Offset: 0x0001AC0C
		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
			if (this._table == null)
			{
				throw ExceptionBuilder.CanNotUse();
			}
			if (this._dataViewManager != dataViewManager)
			{
				if (dataViewManager != null)
				{
					dataViewManager._nViews--;
				}
				this._dataViewManager = dataViewManager;
				if (dataViewManager != null)
				{
					dataViewManager._nViews++;
					DataViewSetting dataViewSetting = dataViewManager.DataViewSettings[this._table];
					try
					{
						this._applyDefaultSort = dataViewSetting.ApplyDefaultSort;
						DataExpression newRowFilter = new DataExpression(this._table, dataViewSetting.RowFilter);
						this.SetIndex(dataViewSetting.Sort, dataViewSetting.RowStateFilter, newRowFilter);
					}
					catch (Exception e) when (ADP.IsCatchableExceptionType(e))
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e);
					}
					this._locked = true;
					return;
				}
				this.SetIndex("", DataViewRowState.CurrentRows, null);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
			this.SetIndex2(newSort, newRowStates, newRowFilter, true);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent)
		{
			DataCommonEventSource.Log.Trace<int, string, DataViewRowState>("<ds.DataView.SetIndex|INFO> {0}, newSort='{1}', newRowStates={2}", this.ObjectID, newSort, newRowStates);
			this._sort = newSort;
			this._recordStates = newRowStates;
			this._rowFilter = newRowFilter;
			if (this._fEndInitInProgress)
			{
				return;
			}
			if (fireEvent)
			{
				this.UpdateIndex(true);
			}
			else
			{
				this.UpdateIndex(true, false);
			}
			if (this._findIndexes != null)
			{
				Dictionary<string, Index> findIndexes = this._findIndexes;
				this._findIndexes = null;
				foreach (KeyValuePair<string, Index> keyValuePair in findIndexes)
				{
					keyValuePair.Value.RemoveRef();
				}
			}
		}

		/// <summary>Reserved for internal use only.</summary>
		// Token: 0x06000613 RID: 1555 RVA: 0x0001CBAC File Offset: 0x0001ADAC
		protected void UpdateIndex()
		{
			this.UpdateIndex(false);
		}

		/// <summary>Reserved for internal use only.</summary>
		/// <param name="force">Reserved for internal use only. </param>
		// Token: 0x06000614 RID: 1556 RVA: 0x0001CBB5 File Offset: 0x0001ADB5
		protected virtual void UpdateIndex(bool force)
		{
			this.UpdateIndex(force, true);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		internal void UpdateIndex(bool force, bool fireEvent)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataView.UpdateIndex|INFO> {0}, force={1}", this.ObjectID, force);
			try
			{
				if (this._open != this._shouldOpen || force)
				{
					this._open = this._shouldOpen;
					Index index = null;
					if (this._open && this._table != null)
					{
						if (this.SortComparison != null)
						{
							index = new Index(this._table, this.SortComparison, this._recordStates, this.GetFilter());
							index.AddRef();
						}
						else
						{
							index = this._table.GetIndex(this.Sort, this._recordStates, this.GetFilter());
						}
					}
					if (this._index != index)
					{
						if (this._index == null)
						{
							DataTable table = index.Table;
						}
						else
						{
							DataTable table2 = this._index.Table;
						}
						if (this._index != null)
						{
							this._dvListener.UnregisterListChangedEvent();
						}
						this._index = index;
						if (this._index != null)
						{
							this._dvListener.RegisterListChangedEvent(this._index);
						}
						this.ResetRowViewCache();
						if (fireEvent)
						{
							this.OnListChanged(DataView.s_resetEventArgs);
						}
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			DataRelationPropertyDescriptor propDesc = null;
			this.OnListChanged((e.Action == CollectionChangeAction.Add) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, new DataRelationPropertyDescriptor((DataRelation)e.Element)) : ((e.Action == CollectionChangeAction.Refresh) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, propDesc) : ((e.Action == CollectionChangeAction.Remove) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, new DataRelationPropertyDescriptor((DataRelation)e.Element)) : null)));
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001CD60 File Offset: 0x0001AF60
		internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			DataRelationPropertyDescriptor propDesc = null;
			this.OnListChanged((e.Action == CollectionChangeAction.Add) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, new DataRelationPropertyDescriptor((DataRelation)e.Element)) : ((e.Action == CollectionChangeAction.Refresh) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, propDesc) : ((e.Action == CollectionChangeAction.Remove) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, new DataRelationPropertyDescriptor((DataRelation)e.Element)) : null)));
		}

		/// <summary>Occurs after a <see cref="T:System.Data.DataColumnCollection" /> has been changed successfully.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		// Token: 0x06000618 RID: 1560 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			DataColumnPropertyDescriptor propDesc = null;
			this.OnListChanged((e.Action == CollectionChangeAction.Add) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, new DataColumnPropertyDescriptor((DataColumn)e.Element)) : ((e.Action == CollectionChangeAction.Refresh) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, propDesc) : ((e.Action == CollectionChangeAction.Remove) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, new DataColumnPropertyDescriptor((DataColumn)e.Element)) : null)));
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001CE36 File Offset: 0x0001B036
		internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e)
		{
			this.ColumnCollectionChanged(sender, e);
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001CE40 File Offset: 0x0001B040
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		// Token: 0x0400014E RID: 334
		private DataViewManager _dataViewManager;

		// Token: 0x0400014F RID: 335
		private DataTable _table;

		// Token: 0x04000150 RID: 336
		private bool _locked;

		// Token: 0x04000151 RID: 337
		private Index _index;

		// Token: 0x04000152 RID: 338
		private Dictionary<string, Index> _findIndexes;

		// Token: 0x04000153 RID: 339
		private string _sort = string.Empty;

		// Token: 0x04000154 RID: 340
		private Comparison<DataRow> _comparison;

		// Token: 0x04000155 RID: 341
		private IFilter _rowFilter;

		// Token: 0x04000156 RID: 342
		private DataViewRowState _recordStates = DataViewRowState.CurrentRows;

		// Token: 0x04000157 RID: 343
		private bool _shouldOpen = true;

		// Token: 0x04000158 RID: 344
		private bool _open;

		// Token: 0x04000159 RID: 345
		private bool _allowNew = true;

		// Token: 0x0400015A RID: 346
		private bool _allowEdit = true;

		// Token: 0x0400015B RID: 347
		private bool _allowDelete = true;

		// Token: 0x0400015C RID: 348
		private bool _applyDefaultSort;

		// Token: 0x0400015D RID: 349
		internal DataRow _addNewRow;

		// Token: 0x0400015E RID: 350
		private ListChangedEventArgs _addNewMoved;

		// Token: 0x0400015F RID: 351
		private ListChangedEventHandler _onListChanged;

		// Token: 0x04000160 RID: 352
		internal static ListChangedEventArgs s_resetEventArgs = new ListChangedEventArgs(ListChangedType.Reset, -1);

		// Token: 0x04000161 RID: 353
		private DataTable _delayedTable;

		// Token: 0x04000162 RID: 354
		private string _delayedRowFilter;

		// Token: 0x04000163 RID: 355
		private string _delayedSort;

		// Token: 0x04000164 RID: 356
		private DataViewRowState _delayedRecordStates = (DataViewRowState)(-1);

		// Token: 0x04000165 RID: 357
		private bool _fInitInProgress;

		// Token: 0x04000166 RID: 358
		private bool _fEndInitInProgress;

		// Token: 0x04000167 RID: 359
		private Dictionary<DataRow, DataRowView> _rowViewCache = new Dictionary<DataRow, DataRowView>(DataView.DataRowReferenceComparer.s_default);

		// Token: 0x04000168 RID: 360
		private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer = new Dictionary<DataRow, DataRowView>(DataView.DataRowReferenceComparer.s_default);

		// Token: 0x04000169 RID: 361
		private DataViewListener _dvListener;

		// Token: 0x0400016A RID: 362
		private static int s_objectTypeCount;

		// Token: 0x0400016B RID: 363
		private readonly int _objectID = Interlocked.Increment(ref DataView.s_objectTypeCount);

		// Token: 0x0400016C RID: 364
		[CompilerGenerated]
		private EventHandler Initialized;

		// Token: 0x02000048 RID: 72
		private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
		{
			// Token: 0x0600061C RID: 1564 RVA: 0x000020FA File Offset: 0x000002FA
			private DataRowReferenceComparer()
			{
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x0001CE56 File Offset: 0x0001B056
			public bool Equals(DataRow x, DataRow y)
			{
				return x == y;
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x0001CE5C File Offset: 0x0001B05C
			public int GetHashCode(DataRow obj)
			{
				return obj._objectID;
			}

			// Token: 0x0400016D RID: 365
			internal static readonly DataView.DataRowReferenceComparer s_default = new DataView.DataRowReferenceComparer();
		}
	}
}
