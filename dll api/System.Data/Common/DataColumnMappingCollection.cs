using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace System.Data.Common
{
	/// <summary>Contains a collection of <see cref="T:System.Data.Common.DataColumnMapping" /> objects.</summary>
	// Token: 0x020000DB RID: 219
	public sealed class DataColumnMappingCollection : MarshalByRefObject, IColumnMappingCollection, IList, ICollection, IEnumerable
	{
		/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000020BC File Offset: 0x000002BC
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00002050 File Offset: 0x00000250
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Collections.IList" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000020BC File Offset: 0x000002BC
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Collections.IList" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x000020BC File Offset: 0x000002BC
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		// Token: 0x17000200 RID: 512
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this.ValidateType(value);
				this[index] = (DataColumnMapping)value;
			}
		}

		/// <summary>Gets the number of <see cref="T:System.Data.Common.DataColumnMapping" /> objects in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x0004AC37 File Offset: 0x00048E37
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0004AC4E File Offset: 0x00048E4E
		private Type ItemType
		{
			get
			{
				return typeof(DataColumnMapping);
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Data.Common.DataColumnMapping" /> object at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataColumnMapping" /> object to find. </param>
		/// <returns>The <see cref="T:System.Data.Common.DataColumnMapping" /> object at the specified index.</returns>
		// Token: 0x17000203 RID: 515
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataColumnMapping this[int index]
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

		/// <summary>Adds a <see cref="T:System.Data.Common.DataColumnMapping" /> object to the collection.</summary>
		/// <param name="value">A <see langword="DataColumnMapping" /> object to add to the collection. </param>
		/// <returns>The index of the <see langword="DataColumnMapping" /> object that was added to the collection.</returns>
		/// <exception cref="T:System.InvalidCastException">The object passed in was not a <see cref="T:System.Data.Common.DataColumnMapping" /> object. </exception>
		// Token: 0x06000EFB RID: 3835 RVA: 0x0004AC80 File Offset: 0x00048E80
		public int Add(object value)
		{
			this.ValidateType(value);
			this.Add((DataColumnMapping)value);
			return this.Count - 1;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0004AC9E File Offset: 0x00048E9E
		private DataColumnMapping Add(DataColumnMapping value)
		{
			this.AddWithoutEvents(value);
			return value;
		}

		/// <summary>Copies the elements of the specified <see cref="T:System.Data.Common.DataColumnMapping" /> array to the end of the collection.</summary>
		/// <param name="values">The array of <see cref="T:System.Data.Common.DataColumnMapping" /> objects to add to the collection. </param>
		// Token: 0x06000EFD RID: 3837 RVA: 0x0004ACA8 File Offset: 0x00048EA8
		public void AddRange(DataColumnMapping[] values)
		{
			this.AddEnumerableRange(values, false);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0004ACB4 File Offset: 0x00048EB4
		private void AddEnumerableRange(IEnumerable values, bool doClone)
		{
			if (values == null)
			{
				throw ADP.ArgumentNull("values");
			}
			foreach (object value in values)
			{
				this.ValidateType(value);
			}
			if (doClone)
			{
				using (IEnumerator enumerator = values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						ICloneable cloneable = (ICloneable)obj;
						this.AddWithoutEvents(cloneable.Clone() as DataColumnMapping);
					}
					return;
				}
			}
			foreach (object obj2 in values)
			{
				DataColumnMapping value2 = (DataColumnMapping)obj2;
				this.AddWithoutEvents(value2);
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0004ADA8 File Offset: 0x00048FA8
		private void AddWithoutEvents(DataColumnMapping value)
		{
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Add(value);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0004ADC5 File Offset: 0x00048FC5
		private List<DataColumnMapping> ArrayList()
		{
			if (this._items == null)
			{
				this._items = new List<DataColumnMapping>();
			}
			return this._items;
		}

		/// <summary>Removes all <see cref="T:System.Data.Common.DataColumnMapping" /> objects from the collection.</summary>
		// Token: 0x06000F01 RID: 3841 RVA: 0x0004ADE0 File Offset: 0x00048FE0
		public void Clear()
		{
			if (0 < this.Count)
			{
				this.ClearWithoutEvents();
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0004ADF4 File Offset: 0x00048FF4
		private void ClearWithoutEvents()
		{
			if (this._items != null)
			{
				foreach (DataColumnMapping dataColumnMapping in this._items)
				{
					dataColumnMapping.Parent = null;
				}
				this._items.Clear();
			}
		}

		/// <summary>Gets a value indicating whether a <see cref="T:System.Data.Common.DataColumnMapping" /> object with the given <see cref="T:System.Object" /> exists in the collection.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that is the <see cref="T:System.Data.Common.DataColumnMapping" />. </param>
		/// <returns>
		///     <see langword="true" /> if the collection contains the specified <see cref="T:System.Data.Common.DataColumnMapping" /> object; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidCastException">The object passed in was not a <see cref="T:System.Data.Common.DataColumnMapping" /> object. </exception>
		// Token: 0x06000F03 RID: 3843 RVA: 0x0004AE58 File Offset: 0x00049058
		public bool Contains(object value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Copies the elements of the <see cref="T:System.Data.Common.DataColumnMappingCollection" /> to the specified array.</summary>
		/// <param name="array">An <see cref="T:System.Array" /> to which to copy <see cref="T:System.Data.Common.DataColumnMappingCollection" /> elements. </param>
		/// <param name="index">The starting index of the array. </param>
		// Token: 0x06000F04 RID: 3844 RVA: 0x0004AE67 File Offset: 0x00049067
		public void CopyTo(Array array, int index)
		{
			((ICollection)this.ArrayList()).CopyTo(array, index);
		}

		/// <summary>Copies the elements of the <see cref="T:System.Data.Common.DataColumnMappingCollection" /> to the specified <see cref="T:System.Data.Common.DataColumnMapping" /> array.</summary>
		/// <param name="array">A <see cref="T:System.Data.Common.DataColumnMapping" /> array to which to copy the <see cref="T:System.Data.Common.DataColumnMappingCollection" /> elements.</param>
		/// <param name="index">The zero-based index in the <paramref name="array" /> at which copying begins.</param>
		// Token: 0x06000F05 RID: 3845 RVA: 0x0004AE76 File Offset: 0x00049076
		public void CopyTo(DataColumnMapping[] array, int index)
		{
			this.ArrayList().CopyTo(array, index);
		}

		/// <summary>Gets an enumerator that can iterate through the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06000F06 RID: 3846 RVA: 0x0004AE85 File Offset: 0x00049085
		public IEnumerator GetEnumerator()
		{
			return this.ArrayList().GetEnumerator();
		}

		/// <summary>Gets the location of the specified <see cref="T:System.Object" /> that is a <see cref="T:System.Data.Common.DataColumnMapping" /> within the collection.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that is the <see cref="T:System.Data.Common.DataColumnMapping" /> to find. </param>
		/// <returns>The zero-based location of the specified <see cref="T:System.Object" /> that is a <see cref="T:System.Data.Common.DataColumnMapping" /> within the collection.</returns>
		// Token: 0x06000F07 RID: 3847 RVA: 0x0004AE98 File Offset: 0x00049098
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

		/// <summary>Gets the location of the <see cref="T:System.Data.Common.DataColumnMapping" /> with the specified source column name.</summary>
		/// <param name="sourceColumn">The case-sensitive name of the source column. </param>
		/// <returns>The zero-based location of the <see cref="T:System.Data.Common.DataColumnMapping" /> with the specified case-sensitive source column name.</returns>
		// Token: 0x06000F08 RID: 3848 RVA: 0x0004AED4 File Offset: 0x000490D4
		public int IndexOf(string sourceColumn)
		{
			if (!string.IsNullOrEmpty(sourceColumn))
			{
				int count = this.Count;
				for (int i = 0; i < count; i++)
				{
					if (ADP.SrcCompare(sourceColumn, this._items[i].SourceColumn) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Inserts a <see cref="T:System.Data.Common.DataColumnMapping" /> object into the <see cref="T:System.Data.Common.DataColumnMappingCollection" /> at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataColumnMapping" /> object to insert. </param>
		/// <param name="value">The <see cref="T:System.Data.Common.DataColumnMapping" /> object. </param>
		// Token: 0x06000F09 RID: 3849 RVA: 0x0004AF18 File Offset: 0x00049118
		public void Insert(int index, object value)
		{
			this.ValidateType(value);
			this.Insert(index, (DataColumnMapping)value);
		}

		/// <summary>Inserts a <see cref="T:System.Data.Common.DataColumnMapping" /> object into the <see cref="T:System.Data.Common.DataColumnMappingCollection" /> at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataColumnMapping" /> object to insert.</param>
		/// <param name="value">The <see cref="T:System.Data.Common.DataColumnMapping" /> object.</param>
		// Token: 0x06000F0A RID: 3850 RVA: 0x0004AF2E File Offset: 0x0004912E
		public void Insert(int index, DataColumnMapping value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Insert(index, value);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0004AF5A File Offset: 0x0004915A
		private void RangeCheck(int index)
		{
			if (index < 0 || this.Count <= index)
			{
				throw ADP.ColumnsIndexInt32(index, this);
			}
		}

		/// <summary>Removes the <see cref="T:System.Data.Common.DataColumnMapping" /> object with the specified index from the collection.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.Common.DataColumnMapping" /> object to remove. </param>
		/// <exception cref="T:System.IndexOutOfRangeException">There is no <see cref="T:System.Data.Common.DataColumnMapping" /> object with the specified index. </exception>
		// Token: 0x06000F0C RID: 3852 RVA: 0x0004AF71 File Offset: 0x00049171
		public void RemoveAt(int index)
		{
			this.RangeCheck(index);
			this.RemoveIndex(index);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0004AF81 File Offset: 0x00049181
		private void RemoveIndex(int index)
		{
			this._items[index].Parent = null;
			this._items.RemoveAt(index);
		}

		/// <summary>Removes the <see cref="T:System.Object" /> that is a <see cref="T:System.Data.Common.DataColumnMapping" /> from the collection.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> that is the <see cref="T:System.Data.Common.DataColumnMapping" /> to remove. </param>
		/// <exception cref="T:System.InvalidCastException">The object specified was not a <see cref="T:System.Data.Common.DataColumnMapping" /> object. </exception>
		/// <exception cref="T:System.ArgumentException">The object specified is not in the collection. </exception>
		// Token: 0x06000F0E RID: 3854 RVA: 0x0004AFA1 File Offset: 0x000491A1
		public void Remove(object value)
		{
			this.ValidateType(value);
			this.Remove((DataColumnMapping)value);
		}

		/// <summary>Removes the specified <see cref="T:System.Data.Common.DataColumnMapping" /> from the collection.</summary>
		/// <param name="value">The <see cref="T:System.Data.Common.DataColumnMapping" /> to remove.</param>
		// Token: 0x06000F0F RID: 3855 RVA: 0x0004AFB8 File Offset: 0x000491B8
		public void Remove(DataColumnMapping value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			int num = this.IndexOf(value);
			if (-1 != num)
			{
				this.RemoveIndex(num);
				return;
			}
			throw ADP.CollectionRemoveInvalidObject(this.ItemType, this);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0004AFF3 File Offset: 0x000491F3
		private void Replace(int index, DataColumnMapping newValue)
		{
			this.Validate(index, newValue);
			this._items[index].Parent = null;
			newValue.Parent = this;
			this._items[index] = newValue;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0004B023 File Offset: 0x00049223
		private void ValidateType(object value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			if (!this.ItemType.IsInstanceOfType(value))
			{
				throw ADP.NotADataColumnMapping(value);
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0004B048 File Offset: 0x00049248
		private void Validate(int index, DataColumnMapping value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			if (value.Parent != null)
			{
				if (this != value.Parent)
				{
					throw ADP.ColumnsIsNotParent(this);
				}
				if (index != this.IndexOf(value))
				{
					throw ADP.ColumnsIsParent(this);
				}
			}
			string text = value.SourceColumn;
			if (string.IsNullOrEmpty(text))
			{
				index = 1;
				do
				{
					text = "SourceColumn" + index.ToString(CultureInfo.InvariantCulture);
					index++;
				}
				while (-1 != this.IndexOf(text));
				value.SourceColumn = text;
				return;
			}
			this.ValidateSourceColumn(index, text);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0004B0D4 File Offset: 0x000492D4
		internal void ValidateSourceColumn(int index, string value)
		{
			int num = this.IndexOf(value);
			if (-1 != num && index != num)
			{
				throw ADP.ColumnsUniqueSourceColumn(value);
			}
		}

		/// <summary>A static method that returns a <see cref="T:System.Data.DataColumn" /> object without instantiating a <see cref="T:System.Data.Common.DataColumnMappingCollection" /> object.</summary>
		/// <param name="columnMappings">The <see cref="T:System.Data.Common.DataColumnMappingCollection" />.</param>
		/// <param name="sourceColumn">The case-sensitive column name from a data source.</param>
		/// <param name="dataType">The data type for the column being mapped.</param>
		/// <param name="dataTable">An instance of <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="mappingAction">One of the <see cref="T:System.Data.MissingMappingAction" /> values.</param>
		/// <param name="schemaAction">Determines the action to take when the existing <see cref="T:System.Data.DataSet" /> schema does not match incoming data.</param>
		/// <returns>A <see cref="T:System.Data.DataColumn" /> object.</returns>
		// Token: 0x06000F14 RID: 3860 RVA: 0x0004B0F8 File Offset: 0x000492F8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static DataColumn GetDataColumn(DataColumnMappingCollection columnMappings, string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction)
		{
			if (columnMappings != null)
			{
				int num = columnMappings.IndexOf(sourceColumn);
				if (-1 != num)
				{
					return columnMappings._items[num].GetDataColumnBySchemaAction(dataTable, dataType, schemaAction);
				}
			}
			if (string.IsNullOrEmpty(sourceColumn))
			{
				throw ADP.InvalidSourceColumn("sourceColumn");
			}
			switch (mappingAction)
			{
			case MissingMappingAction.Passthrough:
				return DataColumnMapping.GetDataColumnBySchemaAction(sourceColumn, sourceColumn, dataTable, dataType, schemaAction);
			case MissingMappingAction.Ignore:
				return null;
			case MissingMappingAction.Error:
				throw ADP.MissingColumnMapping(sourceColumn);
			default:
				throw ADP.InvalidMissingMappingAction(mappingAction);
			}
		}

		// Token: 0x040004B8 RID: 1208
		private List<DataColumnMapping> _items;
	}
}
