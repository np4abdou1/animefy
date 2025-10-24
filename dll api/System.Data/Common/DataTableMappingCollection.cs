using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace System.Data.Common
{
	/// <summary>A collection of <see cref="T:System.Data.Common.DataTableMapping" /> objects. This class cannot be inherited.</summary>
	// Token: 0x020000E2 RID: 226
	[ListBindable(false)]
	public sealed class DataTableMappingCollection : MarshalByRefObject, ITableMappingCollection, IList, ICollection, IEnumerable
	{
		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x000020BC File Offset: 0x000002BC
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00002050 File Offset: 0x00000250
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x000020BC File Offset: 0x000002BC
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x000020BC File Offset: 0x000002BC
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets or sets an item from the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the item to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		// Token: 0x17000210 RID: 528
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this.ValidateType(value);
				this[index] = (DataTableMapping)value;
			}
		}

		/// <summary>Gets the number of <see cref="T:System.Data.Common.DataTableMapping" /> objects in the collection.</summary>
		/// <returns>The number of <see langword="DataTableMapping" /> objects in the collection.</returns>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x0004BEBC File Offset: 0x0004A0BC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Count
		{
			get
			{
				if (this._items == null)
				{
					return 0;
				}
				return this._items.Count;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0004BED3 File Offset: 0x0004A0D3
		private Type ItemType
		{
			get
			{
				return typeof(DataTableMapping);
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Data.Common.DataTableMapping" /> object at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataTableMapping" /> object to return. </param>
		/// <returns>The <see cref="T:System.Data.Common.DataTableMapping" /> object at the specified index.</returns>
		// Token: 0x17000213 RID: 531
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataTableMapping this[int index]
		{
			get
			{
				this.RangeCheck(index);
				return this._items[index];
			}
			set
			{
				this.RangeCheck(index);
				this.Replace(index, value);
			}
		}

		/// <summary>Adds an <see cref="T:System.Object" /> that is a table mapping to the collection.</summary>
		/// <param name="value">A <see langword="DataTableMapping" /> object to add to the collection. </param>
		/// <returns>The index of the <see langword="DataTableMapping" /> object added to the collection.</returns>
		/// <exception cref="T:System.InvalidCastException">The object passed in was not a <see cref="T:System.Data.Common.DataTableMapping" /> object. </exception>
		// Token: 0x06000F75 RID: 3957 RVA: 0x0004BF05 File Offset: 0x0004A105
		public int Add(object value)
		{
			this.ValidateType(value);
			this.Add((DataTableMapping)value);
			return this.Count - 1;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0004BF23 File Offset: 0x0004A123
		private DataTableMapping Add(DataTableMapping value)
		{
			this.AddWithoutEvents(value);
			return value;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0004BF2D File Offset: 0x0004A12D
		private void AddWithoutEvents(DataTableMapping value)
		{
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Add(value);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0004BF4C File Offset: 0x0004A14C
		private List<DataTableMapping> ArrayList()
		{
			List<DataTableMapping> result;
			if ((result = this._items) == null)
			{
				result = (this._items = new List<DataTableMapping>());
			}
			return result;
		}

		/// <summary>Removes all <see cref="T:System.Data.Common.DataTableMapping" /> objects from the collection.</summary>
		// Token: 0x06000F79 RID: 3961 RVA: 0x0004BF71 File Offset: 0x0004A171
		public void Clear()
		{
			if (0 < this.Count)
			{
				this.ClearWithoutEvents();
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0004BF84 File Offset: 0x0004A184
		private void ClearWithoutEvents()
		{
			if (this._items != null)
			{
				foreach (DataTableMapping dataTableMapping in this._items)
				{
					dataTableMapping.Parent = null;
				}
				this._items.Clear();
			}
		}

		/// <summary>Gets a value indicating whether the given <see cref="T:System.Data.Common.DataTableMapping" /> object exists in the collection.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that is the <see cref="T:System.Data.Common.DataTableMapping" />. </param>
		/// <returns>
		///     <see langword="true" /> if this collection contains the specified <see cref="T:System.Data.Common.DataTableMapping" />; otherwise <see langword="false" />.</returns>
		// Token: 0x06000F7B RID: 3963 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		public bool Contains(object value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Copies the elements of the <see cref="T:System.Data.Common.DataTableMappingCollection" /> to the specified array.</summary>
		/// <param name="array">An <see cref="T:System.Array" /> to which to copy the <see cref="T:System.Data.Common.DataTableMappingCollection" /> elements. </param>
		/// <param name="index">The starting index of the array. </param>
		// Token: 0x06000F7C RID: 3964 RVA: 0x0004BFF7 File Offset: 0x0004A1F7
		public void CopyTo(Array array, int index)
		{
			((ICollection)this.ArrayList()).CopyTo(array, index);
		}

		/// <summary>Gets an enumerator that can iterate through the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06000F7D RID: 3965 RVA: 0x0004C006 File Offset: 0x0004A206
		public IEnumerator GetEnumerator()
		{
			return this.ArrayList().GetEnumerator();
		}

		/// <summary>Gets the location of the specified <see cref="T:System.Data.Common.DataTableMapping" /> object within the collection.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that is the <see cref="T:System.Data.Common.DataTableMapping" /> object to find. </param>
		/// <returns>The zero-based location of the specified <see cref="T:System.Data.Common.DataTableMapping" /> object within the collection.</returns>
		// Token: 0x06000F7E RID: 3966 RVA: 0x0004C018 File Offset: 0x0004A218
		public int IndexOf(object value)
		{
			if (value != null)
			{
				this.ValidateType(value);
				for (int i = 0; i < this.Count; i++)
				{
					if (this._items[i] == value)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Gets the location of the <see cref="T:System.Data.Common.DataTableMapping" /> object with the specified source table name.</summary>
		/// <param name="sourceTable">The case-sensitive name of the source table. </param>
		/// <returns>The zero-based location of the <see cref="T:System.Data.Common.DataTableMapping" /> object with the specified source table name.</returns>
		// Token: 0x06000F7F RID: 3967 RVA: 0x0004C054 File Offset: 0x0004A254
		public int IndexOf(string sourceTable)
		{
			if (!string.IsNullOrEmpty(sourceTable))
			{
				for (int i = 0; i < this.Count; i++)
				{
					string sourceTable2 = this._items[i].SourceTable;
					if (sourceTable2 != null && ADP.SrcCompare(sourceTable, sourceTable2) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Gets the location of the <see cref="T:System.Data.Common.DataTableMapping" /> object with the specified <see cref="T:System.Data.DataSet" /> table name.</summary>
		/// <param name="dataSetTable">The name, which is not case-sensitive, of the <see langword="DataSet" /> table to find. </param>
		/// <returns>The zero-based location of the <see cref="T:System.Data.Common.DataTableMapping" /> object with the given <see cref="T:System.Data.DataSet" /> table name, or -1 if the <see cref="T:System.Data.Common.DataTableMapping" /> object does not exist in the collection.</returns>
		// Token: 0x06000F80 RID: 3968 RVA: 0x0004C09C File Offset: 0x0004A29C
		public int IndexOfDataSetTable(string dataSetTable)
		{
			if (!string.IsNullOrEmpty(dataSetTable))
			{
				for (int i = 0; i < this.Count; i++)
				{
					string dataSetTable2 = this._items[i].DataSetTable;
					if (dataSetTable2 != null && ADP.DstCompare(dataSetTable, dataSetTable2) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Inserts a <see cref="T:System.Data.Common.DataTableMapping" /> object into the <see cref="T:System.Data.Common.DataTableMappingCollection" /> at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataTableMapping" /> object to insert. </param>
		/// <param name="value">The <see cref="T:System.Data.Common.DataTableMapping" /> object to insert. </param>
		// Token: 0x06000F81 RID: 3969 RVA: 0x0004C0E3 File Offset: 0x0004A2E3
		public void Insert(int index, object value)
		{
			this.ValidateType(value);
			this.Insert(index, (DataTableMapping)value);
		}

		/// <summary>Inserts a <see cref="T:System.Data.Common.DataTableMapping" /> object into the <see cref="T:System.Data.Common.DataTableMappingCollection" /> at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataTableMapping" /> object to insert.</param>
		/// <param name="value">The <see cref="T:System.Data.Common.DataTableMapping" /> object to insert.</param>
		// Token: 0x06000F82 RID: 3970 RVA: 0x0004C0F9 File Offset: 0x0004A2F9
		public void Insert(int index, DataTableMapping value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Insert(index, value);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0004C125 File Offset: 0x0004A325
		private void RangeCheck(int index)
		{
			if (index < 0 || this.Count <= index)
			{
				throw ADP.TablesIndexInt32(index, this);
			}
		}

		/// <summary>Removes the <see cref="T:System.Data.Common.DataTableMapping" /> object located at the specified index from the collection.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataTableMapping" /> object to remove. </param>
		/// <exception cref="T:System.IndexOutOfRangeException">A <see cref="T:System.Data.Common.DataTableMapping" /> object does not exist with the specified index. </exception>
		// Token: 0x06000F84 RID: 3972 RVA: 0x0004C13C File Offset: 0x0004A33C
		public void RemoveAt(int index)
		{
			this.RangeCheck(index);
			this.RemoveIndex(index);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0004C14C File Offset: 0x0004A34C
		private void RemoveIndex(int index)
		{
			this._items[index].Parent = null;
			this._items.RemoveAt(index);
		}

		/// <summary>Removes the specified <see cref="T:System.Data.Common.DataTableMapping" /> object from the collection.</summary>
		/// <param name="value">The <see cref="T:System.Data.Common.DataTableMapping" /> object to remove. </param>
		/// <exception cref="T:System.InvalidCastException">The object specified was not a <see cref="T:System.Data.Common.DataTableMapping" /> object. </exception>
		/// <exception cref="T:System.ArgumentException">The object specified is not in the collection. </exception>
		// Token: 0x06000F86 RID: 3974 RVA: 0x0004C16C File Offset: 0x0004A36C
		public void Remove(object value)
		{
			this.ValidateType(value);
			this.Remove((DataTableMapping)value);
		}

		/// <summary>Removes the specified <see cref="T:System.Data.Common.DataTableMapping" /> object from the collection.</summary>
		/// <param name="value">The <see cref="T:System.Data.Common.DataTableMapping" /> object to remove.</param>
		// Token: 0x06000F87 RID: 3975 RVA: 0x0004C184 File Offset: 0x0004A384
		public void Remove(DataTableMapping value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			int num = this.IndexOf(value);
			if (-1 != num)
			{
				this.RemoveIndex(num);
				return;
			}
			throw ADP.CollectionRemoveInvalidObject(this.ItemType, this);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0004C1BF File Offset: 0x0004A3BF
		private void Replace(int index, DataTableMapping newValue)
		{
			this.Validate(index, newValue);
			this._items[index].Parent = null;
			newValue.Parent = this;
			this._items[index] = newValue;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0004C1EF File Offset: 0x0004A3EF
		private void ValidateType(object value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			if (!this.ItemType.IsInstanceOfType(value))
			{
				throw ADP.NotADataTableMapping(value);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0004C214 File Offset: 0x0004A414
		private void Validate(int index, DataTableMapping value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			if (value.Parent != null)
			{
				if (this != value.Parent)
				{
					throw ADP.TablesIsNotParent(this);
				}
				if (index != this.IndexOf(value))
				{
					throw ADP.TablesIsParent(this);
				}
			}
			string text = value.SourceTable;
			if (string.IsNullOrEmpty(text))
			{
				index = 1;
				do
				{
					text = "SourceTable" + index.ToString(CultureInfo.InvariantCulture);
					index++;
				}
				while (-1 != this.IndexOf(text));
				value.SourceTable = text;
				return;
			}
			this.ValidateSourceTable(index, text);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0004C2A0 File Offset: 0x0004A4A0
		internal void ValidateSourceTable(int index, string value)
		{
			int num = this.IndexOf(value);
			if (-1 != num && index != num)
			{
				throw ADP.TablesUniqueSourceTable(value);
			}
		}

		/// <summary>Gets a <see cref="T:System.Data.Common.DataColumnMapping" /> object with the specified source table name and <see cref="T:System.Data.DataSet" /> table name, using the given <see cref="T:System.Data.MissingMappingAction" />.</summary>
		/// <param name="tableMappings">The <see cref="T:System.Data.Common.DataTableMappingCollection" /> collection to search. </param>
		/// <param name="sourceTable">The case-sensitive name of the mapped source table. </param>
		/// <param name="dataSetTable">The name, which is not case-sensitive, of the mapped <see cref="T:System.Data.DataSet" /> table. </param>
		/// <param name="mappingAction">One of the <see cref="T:System.Data.MissingMappingAction" /> values. </param>
		/// <returns>A <see cref="T:System.Data.Common.DataTableMapping" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <paramref name="mappingAction" /> parameter was set to <see langword="Error" />, and no mapping was specified. </exception>
		// Token: 0x06000F8C RID: 3980 RVA: 0x0004C2C4 File Offset: 0x0004A4C4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static DataTableMapping GetTableMappingBySchemaAction(DataTableMappingCollection tableMappings, string sourceTable, string dataSetTable, MissingMappingAction mappingAction)
		{
			if (tableMappings != null)
			{
				int num = tableMappings.IndexOf(sourceTable);
				if (-1 != num)
				{
					return tableMappings._items[num];
				}
			}
			if (string.IsNullOrEmpty(sourceTable))
			{
				throw ADP.InvalidSourceTable("sourceTable");
			}
			switch (mappingAction)
			{
			case MissingMappingAction.Passthrough:
				return new DataTableMapping(sourceTable, dataSetTable);
			case MissingMappingAction.Ignore:
				return null;
			case MissingMappingAction.Error:
				throw ADP.MissingTableMapping(sourceTable);
			default:
				throw ADP.InvalidMissingMappingAction(mappingAction);
			}
		}

		// Token: 0x040004FC RID: 1276
		private List<DataTableMapping> _items;
	}
}
