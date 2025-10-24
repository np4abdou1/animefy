using System;
using System.ComponentModel;

namespace System.Data
{
	/// <summary>Represents the default settings for <see cref="P:System.Data.DataView.ApplyDefaultSort" />, <see cref="P:System.Data.DataView.DataViewManager" />, <see cref="P:System.Data.DataView.RowFilter" />, <see cref="P:System.Data.DataView.RowStateFilter" />, <see cref="P:System.Data.DataView.Sort" />, and <see cref="P:System.Data.DataView.Table" /> for DataViews created from the <see cref="T:System.Data.DataViewManager" />.</summary>
	// Token: 0x0200004D RID: 77
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class DataViewSetting
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x0001D5AF File Offset: 0x0001B7AF
		internal DataViewSetting()
		{
		}

		/// <summary>Gets or sets a value indicating whether to use the default sort.</summary>
		/// <returns>
		///     <see langword="true" /> if the default sort is used; otherwise <see langword="false" />.</returns>
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001D5D5 File Offset: 0x0001B7D5
		public bool ApplyDefaultSort
		{
			get
			{
				return this._applyDefaultSort;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001D5DD File Offset: 0x0001B7DD
		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
			if (this._dataViewManager != dataViewManager)
			{
				this._dataViewManager = dataViewManager;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001D5EF File Offset: 0x0001B7EF
		internal void SetDataTable(DataTable table)
		{
			if (this._table != table)
			{
				this._table = table;
			}
		}

		/// <summary>Gets or sets the filter to apply in the <see cref="T:System.Data.DataView" />. See <see cref="P:System.Data.DataView.RowFilter" /> for a code sample using RowFilter.</summary>
		/// <returns>A string that contains the filter to apply.</returns>
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0001D601 File Offset: 0x0001B801
		public string RowFilter
		{
			get
			{
				return this._rowFilter;
			}
		}

		/// <summary>Gets or sets a value indicating whether to display Current, Deleted, Modified Current, ModifiedOriginal, New, Original, Unchanged, or no rows in the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>A value that indicates which rows to display.</returns>
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001D609 File Offset: 0x0001B809
		public DataViewRowState RowStateFilter
		{
			get
			{
				return this._rowStateFilter;
			}
		}

		/// <summary>Gets or sets a value indicating the sort to apply in the <see cref="T:System.Data.DataView" />. </summary>
		/// <returns>The sort to apply in the <see cref="T:System.Data.DataView" />.</returns>
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001D611 File Offset: 0x0001B811
		public string Sort
		{
			get
			{
				return this._sort;
			}
		}

		// Token: 0x04000184 RID: 388
		private DataViewManager _dataViewManager;

		// Token: 0x04000185 RID: 389
		private DataTable _table;

		// Token: 0x04000186 RID: 390
		private string _sort = string.Empty;

		// Token: 0x04000187 RID: 391
		private string _rowFilter = string.Empty;

		// Token: 0x04000188 RID: 392
		private DataViewRowState _rowStateFilter = DataViewRowState.CurrentRows;

		// Token: 0x04000189 RID: 393
		private bool _applyDefaultSort;
	}
}
