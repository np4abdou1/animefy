using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace System.Data
{
	/// <summary>Contains a default <see cref="T:System.Data.DataViewSettingCollection" /> for each <see cref="T:System.Data.DataTable" /> in a <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x0200004A RID: 74
	public class DataViewManager : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x0001D248 File Offset: 0x0001B448
		internal DataViewManager(DataSet dataSet, bool locked)
		{
			GC.SuppressFinalize(this);
			this._dataSet = dataSet;
			if (this._dataSet != null)
			{
				this._dataSet.Tables.CollectionChanged += this.TableCollectionChanged;
				this._dataSet.Relations.CollectionChanged += this.RelationCollectionChanged;
			}
			this._locked = locked;
			this._item = new DataViewManagerListItemTypeDescriptor(this);
			this._dataViewSettingsCollection = new DataViewSettingCollection(this);
		}

		/// <summary>Gets or sets the <see cref="T:System.Data.DataSet" /> to use with the <see cref="T:System.Data.DataViewManager" />.</summary>
		/// <returns>The <see cref="T:System.Data.DataSet" /> to use.</returns>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001D2C9 File Offset: 0x0001B4C9
		[DefaultValue(null)]
		public DataSet DataSet
		{
			get
			{
				return this._dataSet;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataViewSettingCollection" /> for each <see cref="T:System.Data.DataTable" /> in the <see cref="T:System.Data.DataSet" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataViewSettingCollection" /> for each <see langword="DataTable" />.</returns>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001D2D1 File Offset: 0x0001B4D1
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataViewSettingCollection DataViewSettings
		{
			get
			{
				return this._dataViewSettingsCollection;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
		/// <returns>For a description of this member, see <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</returns>
		// Token: 0x06000630 RID: 1584 RVA: 0x0001D2DC File Offset: 0x0001B4DC
		IEnumerator IEnumerable.GetEnumerator()
		{
			DataViewManagerListItemTypeDescriptor[] array = new DataViewManagerListItemTypeDescriptor[1];
			((ICollection)this).CopyTo(array, 0);
			return array.GetEnumerator();
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.Count" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.ICollection.Count" />.</returns>
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00002317 File Offset: 0x00000517
		int ICollection.Count
		{
			get
			{
				return 1;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x000020BC File Offset: 0x000002BC
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</returns>
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00002317 File Offset: 0x00000517
		bool IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00002317 File Offset: 0x00000517
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		// Token: 0x06000636 RID: 1590 RVA: 0x0001D2FE File Offset: 0x0001B4FE
		void ICollection.CopyTo(Array array, int index)
		{
			array.SetValue(new DataViewManagerListItemTypeDescriptor(this), index);
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set. </param>
		/// <returns>The element at the specified index.</returns>
		// Token: 0x170000FF RID: 255
		object IList.this[int index]
		{
			get
			{
				return this._item;
			}
			set
			{
				throw ExceptionBuilder.CannotModifyCollection();
			}
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to add to the <see cref="T:System.Collections.IList" />. </param>
		/// <returns>The position into which the new element was inserted.</returns>
		// Token: 0x06000639 RID: 1593 RVA: 0x0001D315 File Offset: 0x0001B515
		int IList.Add(object value)
		{
			throw ExceptionBuilder.CannotModifyCollection();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Clear" />.</summary>
		// Token: 0x0600063A RID: 1594 RVA: 0x0001D315 File Offset: 0x0001B515
		void IList.Clear()
		{
			throw ExceptionBuilder.CannotModifyCollection();
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.IList" /> contains a specific value.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600063B RID: 1595 RVA: 0x0001D31C File Offset: 0x0001B51C
		bool IList.Contains(object value)
		{
			return value == this._item;
		}

		/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />. </param>
		/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
		// Token: 0x0600063C RID: 1596 RVA: 0x0001D327 File Offset: 0x0001B527
		int IList.IndexOf(object value)
		{
			if (value != this._item)
			{
				return -1;
			}
			return 1;
		}

		/// <summary>Inserts an item to the <see cref="T:System.Collections.IList" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert into the <see cref="T:System.Collections.IList" />. </param>
		// Token: 0x0600063D RID: 1597 RVA: 0x0001D315 File Offset: 0x0001B515
		void IList.Insert(int index, object value)
		{
			throw ExceptionBuilder.CannotModifyCollection();
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.IList" />. </param>
		// Token: 0x0600063E RID: 1598 RVA: 0x0001D315 File Offset: 0x0001B515
		void IList.Remove(object value)
		{
			throw ExceptionBuilder.CannotModifyCollection();
		}

		/// <summary>Removes the <see cref="T:System.Collections.IList" /> item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove. </param>
		// Token: 0x0600063F RID: 1599 RVA: 0x0001D315 File Offset: 0x0001B515
		void IList.RemoveAt(int index)
		{
			throw ExceptionBuilder.CannotModifyCollection();
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowNew" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowNew" />.</returns>
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000020BC File Offset: 0x000002BC
		bool IBindingList.AllowNew
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</summary>
		/// <returns>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</returns>
		// Token: 0x06000641 RID: 1601 RVA: 0x0001D335 File Offset: 0x0001B535
		object IBindingList.AddNew()
		{
			throw DataViewManager.s_notSupported;
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowEdit" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowEdit" />.</returns>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000020BC File Offset: 0x000002BC
		bool IBindingList.AllowEdit
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowRemove" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowRemove" />.</returns>
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000020BC File Offset: 0x000002BC
		bool IBindingList.AllowRemove
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</returns>
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00002317 File Offset: 0x00000517
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</returns>
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000020BC File Offset: 0x000002BC
		bool IBindingList.SupportsSearching
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</returns>
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000020BC File Offset: 0x000002BC
		bool IBindingList.SupportsSorting
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</returns>
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0001D335 File Offset: 0x0001B535
		bool IBindingList.IsSorted
		{
			get
			{
				throw DataViewManager.s_notSupported;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</returns>
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001D335 File Offset: 0x0001B535
		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
				throw DataViewManager.s_notSupported;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</returns>
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0001D335 File Offset: 0x0001B535
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				throw DataViewManager.s_notSupported;
			}
		}

		/// <summary>Adds the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the indexes used for searching.</summary>
		/// <param name="property">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to add to the indexes used for searching. </param>
		// Token: 0x0600064A RID: 1610 RVA: 0x000057B2 File Offset: 0x000039B2
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		/// <summary>Sorts the list based on a <see cref="T:System.ComponentModel.PropertyDescriptor" /> and a <see cref="T:System.ComponentModel.ListSortDirection" />.</summary>
		/// <param name="property">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to sort by. </param>
		/// <param name="direction">One of the <see cref="T:System.ComponentModel.ListSortDirection" /> values. </param>
		// Token: 0x0600064B RID: 1611 RVA: 0x0001D335 File Offset: 0x0001B535
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw DataViewManager.s_notSupported;
		}

		/// <summary>Returns the index of the row that has the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
		/// <param name="property">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to search on.</param>
		/// <param name="key">The value of the property parameter to search for.</param>
		/// <returns>The index of the row that has the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x0600064C RID: 1612 RVA: 0x0001D335 File Offset: 0x0001B535
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			throw DataViewManager.s_notSupported;
		}

		/// <summary>Removes the <see cref="T:System.ComponentModel.PropertyDescriptor" /> from the indexes used for searching.</summary>
		/// <param name="property">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to remove from the indexes used for searching. </param>
		// Token: 0x0600064D RID: 1613 RVA: 0x000057B2 File Offset: 0x000039B2
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		/// <summary>Removes any sort applied using <see cref="M:System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" />.</summary>
		// Token: 0x0600064E RID: 1614 RVA: 0x0001D335 File Offset: 0x0001B535
		void IBindingList.RemoveSort()
		{
			throw DataViewManager.s_notSupported;
		}

		/// <summary>Returns the name of the list.</summary>
		/// <param name="listAccessors">An array of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects, for which the list name is returned. This can be <see langword="null" />. </param>
		/// <returns>The name of the list.</returns>
		// Token: 0x0600064F RID: 1615 RVA: 0x0001D33C File Offset: 0x0001B53C
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			DataSet dataSet = this.DataSet;
			if (dataSet == null)
			{
				throw ExceptionBuilder.CanNotUseDataViewManager();
			}
			if (listAccessors == null || listAccessors.Length == 0)
			{
				return dataSet.DataSetName;
			}
			DataTable dataTable = dataSet.FindTable(null, listAccessors, 0);
			if (dataTable != null)
			{
				return dataTable.TableName;
			}
			return string.Empty;
		}

		/// <summary>Returns the <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that represents the properties on each item used to bind data.</summary>
		/// <param name="listAccessors">An array of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects to find in the collection as bindable. This can be <see langword="null" />. </param>
		/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that represents the properties on each item used to bind data.</returns>
		// Token: 0x06000650 RID: 1616 RVA: 0x0001D380 File Offset: 0x0001B580
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			DataSet dataSet = this.DataSet;
			if (dataSet == null)
			{
				throw ExceptionBuilder.CanNotUseDataViewManager();
			}
			if (listAccessors == null || listAccessors.Length == 0)
			{
				return ((ICustomTypeDescriptor)new DataViewManagerListItemTypeDescriptor(this)).GetProperties();
			}
			DataTable dataTable = dataSet.FindTable(null, listAccessors, 0);
			if (dataTable != null)
			{
				return dataTable.GetPropertyDescriptorCollection(null);
			}
			return new PropertyDescriptorCollection(null);
		}

		/// <summary>Creates a <see cref="T:System.Data.DataView" /> for the specified <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="table">The name of the <see cref="T:System.Data.DataTable" /> to use in the <see cref="T:System.Data.DataView" />. </param>
		/// <returns>A <see cref="T:System.Data.DataView" /> object.</returns>
		// Token: 0x06000651 RID: 1617 RVA: 0x0001D3CB File Offset: 0x0001B5CB
		public DataView CreateDataView(DataTable table)
		{
			if (this._dataSet == null)
			{
				throw ExceptionBuilder.CanNotUseDataViewManager();
			}
			DataView dataView = new DataView(table);
			dataView.SetDataViewManager(this);
			return dataView;
		}

		/// <summary>Raises the <see cref="E:System.Data.DataViewManager.ListChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		// Token: 0x06000652 RID: 1618 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			try
			{
				ListChangedEventHandler listChanged = this.ListChanged;
				if (listChanged != null)
				{
					listChanged(this, e);
				}
			}
			catch (Exception e2) when (ADP.IsCatchableExceptionType(e2))
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e2);
			}
		}

		/// <summary>Raises a <see cref="E:System.Data.DataTableCollection.CollectionChanged" /> event when a <see cref="T:System.Data.DataTable" /> is added to or removed from the <see cref="T:System.Data.DataTableCollection" />.</summary>
		/// <param name="sender">The source of the event. </param>
		/// <param name="e">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x06000653 RID: 1619 RVA: 0x0001D43C File Offset: 0x0001B63C
		protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			PropertyDescriptor propDesc = null;
			this.OnListChanged((e.Action == CollectionChangeAction.Add) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, new DataTablePropertyDescriptor((DataTable)e.Element)) : ((e.Action == CollectionChangeAction.Refresh) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, propDesc) : ((e.Action == CollectionChangeAction.Remove) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, new DataTablePropertyDescriptor((DataTable)e.Element)) : null)));
		}

		/// <summary>Raises a <see cref="E:System.Data.DataRelationCollection.CollectionChanged" /> event when a <see cref="T:System.Data.DataRelation" /> is added to or removed from the <see cref="T:System.Data.DataRelationCollection" />.</summary>
		/// <param name="sender">The source of the event. </param>
		/// <param name="e">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x06000654 RID: 1620 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
		protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			DataRelationPropertyDescriptor propDesc = null;
			this.OnListChanged((e.Action == CollectionChangeAction.Add) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, new DataRelationPropertyDescriptor((DataRelation)e.Element)) : ((e.Action == CollectionChangeAction.Refresh) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, propDesc) : ((e.Action == CollectionChangeAction.Remove) ? new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, new DataRelationPropertyDescriptor((DataRelation)e.Element)) : null)));
		}

		// Token: 0x04000172 RID: 370
		private DataViewSettingCollection _dataViewSettingsCollection;

		// Token: 0x04000173 RID: 371
		private DataSet _dataSet;

		// Token: 0x04000174 RID: 372
		private DataViewManagerListItemTypeDescriptor _item;

		// Token: 0x04000175 RID: 373
		private bool _locked;

		// Token: 0x04000176 RID: 374
		internal int _nViews;

		// Token: 0x04000177 RID: 375
		private static NotSupportedException s_notSupported = new NotSupportedException();

		// Token: 0x04000178 RID: 376
		[CompilerGenerated]
		private ListChangedEventHandler ListChanged;
	}
}
