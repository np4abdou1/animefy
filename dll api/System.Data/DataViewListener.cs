using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Data
{
	// Token: 0x02000049 RID: 73
	internal sealed class DataViewListener
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x0001CE70 File Offset: 0x0001B070
		internal DataViewListener(DataView dv)
		{
			this._objectID = dv.ObjectID;
			this._dvWeak = new WeakReference(dv);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001CE90 File Offset: 0x0001B090
		private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			DataView dataView = (DataView)this._dvWeak.Target;
			if (dataView != null)
			{
				dataView.ChildRelationCollectionChanged(sender, e);
				return;
			}
			this.CleanUp(true);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			DataView dataView = (DataView)this._dvWeak.Target;
			if (dataView != null)
			{
				dataView.ParentRelationCollectionChanged(sender, e);
				return;
			}
			this.CleanUp(true);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001CEF8 File Offset: 0x0001B0F8
		private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			DataView dataView = (DataView)this._dvWeak.Target;
			if (dataView != null)
			{
				dataView.ColumnCollectionChangedInternal(sender, e);
				return;
			}
			this.CleanUp(true);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001CF2C File Offset: 0x0001B12C
		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
			DataView dataView = (DataView)this._dvWeak.Target;
			if (dataView != null)
			{
				dataView.MaintainDataView(changedType, row, trackAddRemove);
				return;
			}
			this.CleanUp(true);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001CF60 File Offset: 0x0001B160
		internal void IndexListChanged(ListChangedEventArgs e)
		{
			DataView dataView = (DataView)this._dvWeak.Target;
			if (dataView != null)
			{
				dataView.IndexListChangedInternal(e);
				return;
			}
			this.CleanUp(true);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0001CF90 File Offset: 0x0001B190
		internal void RegisterMetaDataEvents(DataTable table)
		{
			this._table = table;
			if (table != null)
			{
				this.RegisterListener(table);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.ColumnCollectionChanged);
				table.Columns.ColumnPropertyChanged += value;
				table.Columns.CollectionChanged += value;
				CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.ChildRelationCollectionChanged);
				((DataRelationCollection.DataTableRelationCollection)table.ChildRelations).RelationPropertyChanged += value2;
				table.ChildRelations.CollectionChanged += value2;
				CollectionChangeEventHandler value3 = new CollectionChangeEventHandler(this.ParentRelationCollectionChanged);
				((DataRelationCollection.DataTableRelationCollection)table.ParentRelations).RelationPropertyChanged += value3;
				table.ParentRelations.CollectionChanged += value3;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001D02A File Offset: 0x0001B22A
		internal void UnregisterMetaDataEvents()
		{
			this.UnregisterMetaDataEvents(true);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001D034 File Offset: 0x0001B234
		private void UnregisterMetaDataEvents(bool updateListeners)
		{
			DataTable table = this._table;
			this._table = null;
			if (table != null)
			{
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.ColumnCollectionChanged);
				table.Columns.ColumnPropertyChanged -= value;
				table.Columns.CollectionChanged -= value;
				CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.ChildRelationCollectionChanged);
				((DataRelationCollection.DataTableRelationCollection)table.ChildRelations).RelationPropertyChanged -= value2;
				table.ChildRelations.CollectionChanged -= value2;
				CollectionChangeEventHandler value3 = new CollectionChangeEventHandler(this.ParentRelationCollectionChanged);
				((DataRelationCollection.DataTableRelationCollection)table.ParentRelations).RelationPropertyChanged -= value3;
				table.ParentRelations.CollectionChanged -= value3;
				if (updateListeners)
				{
					List<DataViewListener> listeners = table.GetListeners();
					List<DataViewListener> obj = listeners;
					lock (obj)
					{
						listeners.Remove(this);
					}
				}
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001D110 File Offset: 0x0001B310
		internal void RegisterListChangedEvent(Index index)
		{
			this._index = index;
			if (index != null)
			{
				lock (index)
				{
					index.AddRef();
					index.ListChangedAdd(this);
				}
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001D15C File Offset: 0x0001B35C
		internal void UnregisterListChangedEvent()
		{
			Index index = this._index;
			this._index = null;
			if (index != null)
			{
				Index obj = index;
				lock (obj)
				{
					index.ListChangedRemove(this);
					if (index.RemoveRef() <= 1)
					{
						index.RemoveRef();
					}
				}
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001D1BC File Offset: 0x0001B3BC
		private void CleanUp(bool updateListeners)
		{
			this.UnregisterMetaDataEvents(updateListeners);
			this.UnregisterListChangedEvent();
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001D1CC File Offset: 0x0001B3CC
		private void RegisterListener(DataTable table)
		{
			List<DataViewListener> listeners = table.GetListeners();
			List<DataViewListener> obj = listeners;
			lock (obj)
			{
				int num = listeners.Count - 1;
				while (0 <= num)
				{
					DataViewListener dataViewListener = listeners[num];
					if (!dataViewListener._dvWeak.IsAlive)
					{
						listeners.RemoveAt(num);
						dataViewListener.CleanUp(false);
					}
					num--;
				}
				listeners.Add(this);
			}
		}

		// Token: 0x0400016E RID: 366
		private readonly WeakReference _dvWeak;

		// Token: 0x0400016F RID: 367
		private DataTable _table;

		// Token: 0x04000170 RID: 368
		private Index _index;

		// Token: 0x04000171 RID: 369
		internal readonly int _objectID;
	}
}
