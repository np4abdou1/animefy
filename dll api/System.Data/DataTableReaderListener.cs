using System;
using System.ComponentModel;

namespace System.Data
{
	// Token: 0x02000045 RID: 69
	internal sealed class DataTableReaderListener
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x0001B6A4 File Offset: 0x000198A4
		internal DataTableReaderListener(DataTableReader reader)
		{
			if (reader == null)
			{
				throw ExceptionBuilder.ArgumentNull("DataTableReader");
			}
			if (this._currentDataTable != null)
			{
				this.UnSubscribeEvents();
			}
			this._readerWeak = new WeakReference(reader);
			this._currentDataTable = reader.CurrentDataTable;
			if (this._currentDataTable != null)
			{
				this.SubscribeEvents();
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001B6F9 File Offset: 0x000198F9
		internal void CleanUp()
		{
			this.UnSubscribeEvents();
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001B701 File Offset: 0x00019901
		internal void UpdataTable(DataTable datatable)
		{
			if (datatable == null)
			{
				throw ExceptionBuilder.ArgumentNull("DataTable");
			}
			this.UnSubscribeEvents();
			this._currentDataTable = datatable;
			this.SubscribeEvents();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001B724 File Offset: 0x00019924
		private void SubscribeEvents()
		{
			if (this._currentDataTable == null)
			{
				return;
			}
			if (this._isSubscribed)
			{
				return;
			}
			this._currentDataTable.Columns.ColumnPropertyChanged += this.SchemaChanged;
			this._currentDataTable.Columns.CollectionChanged += this.SchemaChanged;
			this._currentDataTable.RowChanged += this.DataChanged;
			this._currentDataTable.RowDeleted += this.DataChanged;
			this._currentDataTable.TableCleared += this.DataTableCleared;
			this._isSubscribed = true;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001B7C8 File Offset: 0x000199C8
		private void UnSubscribeEvents()
		{
			if (this._currentDataTable == null)
			{
				return;
			}
			if (!this._isSubscribed)
			{
				return;
			}
			this._currentDataTable.Columns.ColumnPropertyChanged -= this.SchemaChanged;
			this._currentDataTable.Columns.CollectionChanged -= this.SchemaChanged;
			this._currentDataTable.RowChanged -= this.DataChanged;
			this._currentDataTable.RowDeleted -= this.DataChanged;
			this._currentDataTable.TableCleared -= this.DataTableCleared;
			this._isSubscribed = false;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001B86C File Offset: 0x00019A6C
		private void DataTableCleared(object sender, DataTableClearEventArgs e)
		{
			DataTableReader dataTableReader = (DataTableReader)this._readerWeak.Target;
			if (dataTableReader != null)
			{
				dataTableReader.DataTableCleared();
				return;
			}
			this.UnSubscribeEvents();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001B89C File Offset: 0x00019A9C
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			DataTableReader dataTableReader = (DataTableReader)this._readerWeak.Target;
			if (dataTableReader != null)
			{
				dataTableReader.SchemaChanged();
				return;
			}
			this.UnSubscribeEvents();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001B8CC File Offset: 0x00019ACC
		private void DataChanged(object sender, DataRowChangeEventArgs args)
		{
			DataTableReader dataTableReader = (DataTableReader)this._readerWeak.Target;
			if (dataTableReader != null)
			{
				dataTableReader.DataChanged(args);
				return;
			}
			this.UnSubscribeEvents();
		}

		// Token: 0x0400014B RID: 331
		private DataTable _currentDataTable;

		// Token: 0x0400014C RID: 332
		private bool _isSubscribed;

		// Token: 0x0400014D RID: 333
		private WeakReference _readerWeak;
	}
}
