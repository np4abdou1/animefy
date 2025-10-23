using System;
using System.Collections;
using System.ComponentModel;

namespace System.Data
{
	/// <summary>Contains a read-only collection of <see cref="T:System.Data.DataViewSetting" /> objects for each <see cref="T:System.Data.DataTable" /> in a <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x0200004E RID: 78
	public class DataViewSettingCollection : ICollection, IEnumerable
	{
		// Token: 0x0600066B RID: 1643 RVA: 0x0001D619 File Offset: 0x0001B819
		internal DataViewSettingCollection(DataViewManager dataViewManager)
		{
			if (dataViewManager == null)
			{
				throw ExceptionBuilder.ArgumentNull("dataViewManager");
			}
			this._dataViewManager = dataViewManager;
		}

		/// <summary>Gets the <see cref="T:System.Data.DataViewSetting" /> objects of the specified <see cref="T:System.Data.DataTable" /> from the collection. </summary>
		/// <param name="table">The <see cref="T:System.Data.DataTable" /> to find. </param>
		/// <returns>A collection of <see cref="T:System.Data.DataViewSetting" /> objects.</returns>
		// Token: 0x1700010D RID: 269
		public virtual DataViewSetting this[DataTable table]
		{
			get
			{
				if (table == null)
				{
					throw ExceptionBuilder.ArgumentNull("table");
				}
				DataViewSetting dataViewSetting = (DataViewSetting)this._list[table];
				if (dataViewSetting == null)
				{
					dataViewSetting = new DataViewSetting();
					this[table] = dataViewSetting;
				}
				return dataViewSetting;
			}
			set
			{
				if (table == null)
				{
					throw ExceptionBuilder.ArgumentNull("table");
				}
				value.SetDataViewManager(this._dataViewManager);
				value.SetDataTable(table);
				this._list[table] = value;
			}
		}

		/// <summary>Copies the collection objects to a one-dimensional <see cref="T:System.Array" /> instance starting at the specified index.</summary>
		/// <param name="ar">The one-dimensional <see cref="T:System.Array" /> that is the destination of the values copied from the collection. </param>
		/// <param name="index">The index of the array at which to start inserting. </param>
		// Token: 0x0600066E RID: 1646 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
		public void CopyTo(Array ar, int index)
		{
			foreach (object value in this)
			{
				ar.SetValue(value, index++);
			}
		}

		/// <summary>Gets the number of <see cref="T:System.Data.DataViewSetting" /> objects in the <see cref="T:System.Data.DataViewSettingCollection" />.</summary>
		/// <returns>The number of <see cref="T:System.Data.DataViewSetting" /> objects in the collection.</returns>
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001D6E4 File Offset: 0x0001B8E4
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				DataSet dataSet = this._dataViewManager.DataSet;
				if (dataSet != null)
				{
					return dataSet.Tables.Count;
				}
				return 0;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> for the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object.</returns>
		// Token: 0x06000670 RID: 1648 RVA: 0x0001D70D File Offset: 0x0001B90D
		public IEnumerator GetEnumerator()
		{
			return new DataViewSettingCollection.DataViewSettingsEnumerator(this._dataViewManager);
		}

		/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Data.DataViewSettingCollection" /> is synchronized (thread-safe).</summary>
		/// <returns>This property is always <see langword="false" />, unless overridden by a derived class.</returns>
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x000020BC File Offset: 0x000002BC
		[Browsable(false)]
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Data.DataViewSettingCollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Data.DataViewSettingCollection" />.</returns>
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		[Browsable(false)]
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001D71A File Offset: 0x0001B91A
		internal void Remove(DataTable table)
		{
			this._list.Remove(table);
		}

		// Token: 0x0400018A RID: 394
		private readonly DataViewManager _dataViewManager;

		// Token: 0x0400018B RID: 395
		private readonly Hashtable _list = new Hashtable();

		// Token: 0x0200004F RID: 79
		private sealed class DataViewSettingsEnumerator : IEnumerator
		{
			// Token: 0x06000674 RID: 1652 RVA: 0x0001D728 File Offset: 0x0001B928
			public DataViewSettingsEnumerator(DataViewManager dvm)
			{
				if (dvm.DataSet != null)
				{
					this._dataViewSettings = dvm.DataViewSettings;
					this._tableEnumerator = dvm.DataSet.Tables.GetEnumerator();
					return;
				}
				this._dataViewSettings = null;
				this._tableEnumerator = Array.Empty<DataTable>().GetEnumerator();
			}

			// Token: 0x06000675 RID: 1653 RVA: 0x0001D77D File Offset: 0x0001B97D
			public bool MoveNext()
			{
				return this._tableEnumerator.MoveNext();
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x0001D78A File Offset: 0x0001B98A
			public void Reset()
			{
				this._tableEnumerator.Reset();
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001D797 File Offset: 0x0001B997
			public object Current
			{
				get
				{
					return this._dataViewSettings[(DataTable)this._tableEnumerator.Current];
				}
			}

			// Token: 0x0400018C RID: 396
			private DataViewSettingCollection _dataViewSettings;

			// Token: 0x0400018D RID: 397
			private IEnumerator _tableEnumerator;
		}
	}
}
