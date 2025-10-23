using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Data
{
	/// <summary>Represents a collection of <see cref="T:System.Data.DataColumn" /> objects for a <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x02000015 RID: 21
	[DefaultEvent("CollectionChanged")]
	public sealed class DataColumnCollection : InternalDataCollectionBase
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00005CE6 File Offset: 0x00003EE6
		internal DataColumnCollection(DataTable table)
		{
			this._table = table;
			this._columnFromName = new Dictionary<string, DataColumn>();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00005D1D File Offset: 0x00003F1D
		protected override ArrayList List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00005D25 File Offset: 0x00003F25
		internal DataColumn[] ColumnsImplementingIChangeTracking
		{
			get
			{
				return this._columnsImplementingIChangeTracking;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00005D2D File Offset: 0x00003F2D
		internal int ColumnsImplementingIChangeTrackingCount
		{
			get
			{
				return this._nColumnsImplementingIChangeTracking;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00005D35 File Offset: 0x00003F35
		internal int ColumnsImplementingIRevertibleChangeTrackingCount
		{
			get
			{
				return this._nColumnsImplementingIRevertibleChangeTracking;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataColumn" /> from the collection at the specified index.</summary>
		/// <param name="index">The zero-based index of the column to return. </param>
		/// <returns>The <see cref="T:System.Data.DataColumn" /> at the specified index.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection. </exception>
		// Token: 0x1700004A RID: 74
		public DataColumn this[int index]
		{
			get
			{
				DataColumn result;
				try
				{
					result = (DataColumn)this._list[index];
				}
				catch (ArgumentOutOfRangeException)
				{
					throw ExceptionBuilder.ColumnOutOfRange(index);
				}
				return result;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataColumn" /> from the collection with the specified name.</summary>
		/// <param name="name">The <see cref="P:System.Data.DataColumn.ColumnName" /> of the column to return. </param>
		/// <returns>The <see cref="T:System.Data.DataColumn" /> in the collection with the specified <see cref="P:System.Data.DataColumn.ColumnName" />; otherwise a null value if the <see cref="T:System.Data.DataColumn" /> does not exist.</returns>
		// Token: 0x1700004B RID: 75
		public DataColumn this[string name]
		{
			get
			{
				if (name == null)
				{
					throw ExceptionBuilder.ArgumentNull("name");
				}
				DataColumn dataColumn;
				if (!this._columnFromName.TryGetValue(name, out dataColumn) || dataColumn == null)
				{
					int num = this.IndexOfCaseInsensitive(name);
					if (0 <= num)
					{
						dataColumn = (DataColumn)this._list[num];
					}
					else if (-2 == num)
					{
						throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
					}
				}
				return dataColumn;
			}
		}

		// Token: 0x1700004C RID: 76
		internal DataColumn this[string name, string ns]
		{
			get
			{
				DataColumn dataColumn;
				if (this._columnFromName.TryGetValue(name, out dataColumn) && dataColumn != null && dataColumn.Namespace == ns)
				{
					return dataColumn;
				}
				return null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005E09 File Offset: 0x00004009
		internal void EnsureAdditionalCapacity(int capacity)
		{
			if (this._list.Capacity < capacity + this._list.Count)
			{
				this._list.Capacity = capacity + this._list.Count;
			}
		}

		/// <summary>Creates and adds the specified <see cref="T:System.Data.DataColumn" /> object to the <see cref="T:System.Data.DataColumnCollection" />.</summary>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to add. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The column already belongs to this collection, or to another collection. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">The collection already has a column with the specified name. (The comparison is not case-sensitive.) </exception>
		/// <exception cref="T:System.Data.InvalidExpressionException">The expression is invalid. See the <see cref="P:System.Data.DataColumn.Expression" /> property for more information about how to create expressions. </exception>
		// Token: 0x06000113 RID: 275 RVA: 0x00005E3D File Offset: 0x0000403D
		public void Add(DataColumn column)
		{
			this.AddAt(-1, column);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005E48 File Offset: 0x00004048
		internal void AddAt(int index, DataColumn column)
		{
			if (column != null && column.ColumnMapping == MappingType.SimpleContent)
			{
				if (this._table.XmlText != null && this._table.XmlText != column)
				{
					throw ExceptionBuilder.CannotAddColumn3();
				}
				if (this._table.ElementColumnCount > 0)
				{
					throw ExceptionBuilder.CannotAddColumn4(column.ColumnName);
				}
				this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, column));
				this.BaseAdd(column);
				if (index != -1)
				{
					this.ArrayAdd(index, column);
				}
				else
				{
					this.ArrayAdd(column);
				}
				this._table.XmlText = column;
			}
			else
			{
				this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, column));
				this.BaseAdd(column);
				if (index != -1)
				{
					this.ArrayAdd(index, column);
				}
				else
				{
					this.ArrayAdd(column);
				}
				if (column.ColumnMapping == MappingType.Element)
				{
					DataTable table = this._table;
					int elementColumnCount = table.ElementColumnCount;
					table.ElementColumnCount = elementColumnCount + 1;
				}
			}
			if (!this._table.fInitInProgress && column != null && column.Computed)
			{
				column.Expression = column.Expression;
			}
			this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, column));
		}

		/// <summary>Occurs when the columns collection changes, either by adding or removing a column.</summary>
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000115 RID: 277 RVA: 0x00005F4C File Offset: 0x0000414C
		// (remove) Token: 0x06000116 RID: 278 RVA: 0x00005F84 File Offset: 0x00004184
		public event CollectionChangeEventHandler CollectionChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000117 RID: 279 RVA: 0x00005FBC File Offset: 0x000041BC
		// (remove) Token: 0x06000118 RID: 280 RVA: 0x00005FF4 File Offset: 0x000041F4
		internal event CollectionChangeEventHandler ColumnPropertyChanged;

		// Token: 0x06000119 RID: 281 RVA: 0x00006029 File Offset: 0x00004229
		private void ArrayAdd(DataColumn column)
		{
			this._list.Add(column);
			column.SetOrdinalInternal(this._list.Count - 1);
			this.CheckIChangeTracking(column);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006052 File Offset: 0x00004252
		private void ArrayAdd(int index, DataColumn column)
		{
			this._list.Insert(index, column);
			this.CheckIChangeTracking(column);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006068 File Offset: 0x00004268
		private void ArrayRemove(DataColumn column)
		{
			column.SetOrdinalInternal(-1);
			this._list.Remove(column);
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				((DataColumn)this._list[i]).SetOrdinalInternal(i);
			}
			if (column.ImplementsIChangeTracking)
			{
				this.RemoveColumnsImplementingIChangeTrackingList(column);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000060C8 File Offset: 0x000042C8
		internal string AssignName()
		{
			int defaultNameIndex = this._defaultNameIndex;
			this._defaultNameIndex = defaultNameIndex + 1;
			string text = this.MakeName(defaultNameIndex);
			while (this._columnFromName.ContainsKey(text))
			{
				defaultNameIndex = this._defaultNameIndex;
				this._defaultNameIndex = defaultNameIndex + 1;
				text = this.MakeName(defaultNameIndex);
			}
			return text;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006118 File Offset: 0x00004318
		private void BaseAdd(DataColumn column)
		{
			if (column == null)
			{
				throw ExceptionBuilder.ArgumentNull("column");
			}
			if (column._table == this._table)
			{
				throw ExceptionBuilder.CannotAddColumn1(column.ColumnName);
			}
			if (column._table != null)
			{
				throw ExceptionBuilder.CannotAddColumn2(column.ColumnName);
			}
			if (column.ColumnName.Length == 0)
			{
				column.ColumnName = this.AssignName();
			}
			this.RegisterColumnName(column.ColumnName, column);
			try
			{
				column.SetTable(this._table);
				if (!this._table.fInitInProgress && column.Computed && column.DataExpression.DependsOn(column))
				{
					throw ExceptionBuilder.ExpressionCircular();
				}
				if (0 < this._table.RecordCapacity)
				{
					column.SetCapacity(this._table.RecordCapacity);
				}
				for (int i = 0; i < this._table.RecordCapacity; i++)
				{
					column.InitializeRecord(i);
				}
				if (this._table.DataSet != null)
				{
					column.OnSetDataSet();
				}
			}
			catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
			{
				this.UnregisterName(column.ColumnName);
				throw;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006244 File Offset: 0x00004444
		private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength)
		{
			int num = 0;
			for (int i = 0; i < oldLength; i++)
			{
				bool flag = false;
				for (int j = num; j < newLength; j++)
				{
					if (oldArray[i] == newArray[j])
					{
						if (num == j)
						{
							num++;
						}
						flag = true;
						break;
					}
				}
				if (!flag && oldArray[i].Table == this._table)
				{
					this.BaseRemove(oldArray[i]);
					this._list.Remove(oldArray[i]);
					oldArray[i].SetOrdinalInternal(-1);
				}
			}
			for (int k = 0; k < newLength; k++)
			{
				if (newArray[k].Table != this._table)
				{
					this.BaseAdd(newArray[k]);
					this._list.Add(newArray[k]);
				}
				newArray[k].SetOrdinalInternal(k);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000062FC File Offset: 0x000044FC
		private void BaseRemove(DataColumn column)
		{
			if (this.CanRemove(column, true))
			{
				if (column._errors > 0)
				{
					for (int i = 0; i < this._table.Rows.Count; i++)
					{
						this._table.Rows[i].ClearError(column);
					}
				}
				this.UnregisterName(column.ColumnName);
				column.SetTable(null);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006364 File Offset: 0x00004564
		internal bool CanRemove(DataColumn column, bool fThrowException)
		{
			if (column == null)
			{
				if (!fThrowException)
				{
					return false;
				}
				throw ExceptionBuilder.ArgumentNull("column");
			}
			else if (column._table != this._table)
			{
				if (!fThrowException)
				{
					return false;
				}
				throw ExceptionBuilder.CannotRemoveColumn();
			}
			else
			{
				this._table.OnRemoveColumnInternal(column);
				if (this._table._primaryKey == null || !this._table._primaryKey.Key.ContainsColumn(column))
				{
					int i = 0;
					while (i < this._table.ParentRelations.Count)
					{
						if (this._table.ParentRelations[i].ChildKey.ContainsColumn(column))
						{
							if (!fThrowException)
							{
								return false;
							}
							throw ExceptionBuilder.CannotRemoveChildKey(this._table.ParentRelations[i].RelationName);
						}
						else
						{
							i++;
						}
					}
					int j = 0;
					while (j < this._table.ChildRelations.Count)
					{
						if (this._table.ChildRelations[j].ParentKey.ContainsColumn(column))
						{
							if (!fThrowException)
							{
								return false;
							}
							throw ExceptionBuilder.CannotRemoveChildKey(this._table.ChildRelations[j].RelationName);
						}
						else
						{
							j++;
						}
					}
					int k = 0;
					while (k < this._table.Constraints.Count)
					{
						if (this._table.Constraints[k].ContainsColumn(column))
						{
							if (!fThrowException)
							{
								return false;
							}
							throw ExceptionBuilder.CannotRemoveConstraint(this._table.Constraints[k].ConstraintName, this._table.Constraints[k].Table.TableName);
						}
						else
						{
							k++;
						}
					}
					if (this._table.DataSet != null)
					{
						ParentForeignKeyConstraintEnumerator parentForeignKeyConstraintEnumerator = new ParentForeignKeyConstraintEnumerator(this._table.DataSet, this._table);
						while (parentForeignKeyConstraintEnumerator.GetNext())
						{
							Constraint constraint = parentForeignKeyConstraintEnumerator.GetConstraint();
							if (((ForeignKeyConstraint)constraint).ParentKey.ContainsColumn(column))
							{
								if (!fThrowException)
								{
									return false;
								}
								throw ExceptionBuilder.CannotRemoveConstraint(constraint.ConstraintName, constraint.Table.TableName);
							}
						}
					}
					if (column._dependentColumns != null)
					{
						for (int l = 0; l < column._dependentColumns.Count; l++)
						{
							DataColumn dataColumn = column._dependentColumns[l];
							if ((!this._fInClear || (dataColumn.Table != this._table && dataColumn.Table != null)) && dataColumn.Table != null)
							{
								DataExpression dataExpression = dataColumn.DataExpression;
								if (dataExpression != null && dataExpression.DependsOn(column))
								{
									if (!fThrowException)
									{
										return false;
									}
									throw ExceptionBuilder.CannotRemoveExpression(dataColumn.ColumnName, dataColumn.Expression);
								}
							}
						}
					}
					foreach (Index index in this._table.LiveIndexes)
					{
					}
					return true;
				}
				if (!fThrowException)
				{
					return false;
				}
				throw ExceptionBuilder.CannotRemovePrimaryKey();
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006648 File Offset: 0x00004848
		private void CheckIChangeTracking(DataColumn column)
		{
			if (column.ImplementsIRevertibleChangeTracking)
			{
				this._nColumnsImplementingIRevertibleChangeTracking++;
				this._nColumnsImplementingIChangeTracking++;
				this.AddColumnsImplementingIChangeTrackingList(column);
				return;
			}
			if (column.ImplementsIChangeTracking)
			{
				this._nColumnsImplementingIChangeTracking++;
				this.AddColumnsImplementingIChangeTrackingList(column);
			}
		}

		/// <summary>Clears the collection of any columns.</summary>
		// Token: 0x06000122 RID: 290 RVA: 0x000066A0 File Offset: 0x000048A0
		public void Clear()
		{
			int count = this._list.Count;
			DataColumn[] array = new DataColumn[this._list.Count];
			this._list.CopyTo(array, 0);
			this.OnCollectionChanging(InternalDataCollectionBase.s_refreshEventArgs);
			if (this._table.fInitInProgress && this._delayedAddRangeColumns != null)
			{
				this._delayedAddRangeColumns = null;
			}
			try
			{
				this._fInClear = true;
				this.BaseGroupSwitch(array, count, null, 0);
				this._fInClear = false;
			}
			catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
			{
				this._fInClear = false;
				this.BaseGroupSwitch(null, 0, array, count);
				this._list.Clear();
				for (int i = 0; i < count; i++)
				{
					this._list.Add(array[i]);
				}
				throw;
			}
			this._list.Clear();
			this._table.ElementColumnCount = 0;
			this.OnCollectionChanged(InternalDataCollectionBase.s_refreshEventArgs);
		}

		/// <summary>Checks whether the collection contains a column with the specified name.</summary>
		/// <param name="name">The <see cref="P:System.Data.DataColumn.ColumnName" /> of the column to look for. </param>
		/// <returns>
		///     <see langword="true" /> if a column exists with this name; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000123 RID: 291 RVA: 0x0000679C File Offset: 0x0000499C
		public bool Contains(string name)
		{
			DataColumn dataColumn;
			return (this._columnFromName.TryGetValue(name, out dataColumn) && dataColumn != null) || this.IndexOfCaseInsensitive(name) >= 0;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000067CC File Offset: 0x000049CC
		internal bool Contains(string name, bool caseSensitive)
		{
			DataColumn dataColumn;
			return (this._columnFromName.TryGetValue(name, out dataColumn) && dataColumn != null) || (!caseSensitive && this.IndexOfCaseInsensitive(name) >= 0);
		}

		/// <summary>Gets the index of the column with the specific name (the name is not case sensitive).</summary>
		/// <param name="columnName">The name of the column to find. </param>
		/// <returns>The zero-based index of the column with the specified name, or -1 if the column does not exist in the collection.</returns>
		// Token: 0x06000125 RID: 293 RVA: 0x00006800 File Offset: 0x00004A00
		public int IndexOf(string columnName)
		{
			if (columnName != null && 0 < columnName.Length)
			{
				int count = this.Count;
				DataColumn dataColumn;
				if (this._columnFromName.TryGetValue(columnName, out dataColumn) && dataColumn != null)
				{
					for (int i = 0; i < count; i++)
					{
						if (dataColumn == this._list[i])
						{
							return i;
						}
					}
				}
				else
				{
					int num = this.IndexOfCaseInsensitive(columnName);
					if (num >= 0)
					{
						return num;
					}
					return -1;
				}
			}
			return -1;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006864 File Offset: 0x00004A64
		internal int IndexOfCaseInsensitive(string name)
		{
			int specialHashCode = this._table.GetSpecialHashCode(name);
			int num = -1;
			for (int i = 0; i < this.Count; i++)
			{
				DataColumn dataColumn = (DataColumn)this._list[i];
				if ((specialHashCode == 0 || dataColumn._hashCode == 0 || dataColumn._hashCode == specialHashCode) && base.NamesEqual(dataColumn.ColumnName, name, false, this._table.Locale) != 0)
				{
					if (num != -1)
					{
						return -2;
					}
					num = i;
				}
			}
			return num;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000068E0 File Offset: 0x00004AE0
		internal void FinishInitCollection()
		{
			if (this._delayedAddRangeColumns != null)
			{
				foreach (DataColumn dataColumn in this._delayedAddRangeColumns)
				{
					if (dataColumn != null)
					{
						this.Add(dataColumn);
					}
				}
				foreach (DataColumn dataColumn2 in this._delayedAddRangeColumns)
				{
					if (dataColumn2 != null)
					{
						dataColumn2.FinishInitInProgress();
					}
				}
				this._delayedAddRangeColumns = null;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006941 File Offset: 0x00004B41
		private string MakeName(int index)
		{
			if (index != 1)
			{
				return "Column" + index.ToString(CultureInfo.InvariantCulture);
			}
			return "Column1";
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006964 File Offset: 0x00004B64
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
			this._table.UpdatePropertyDescriptorCollectionCache();
			if (ccevent != null && !this._table.SchemaLoading && !this._table.fInitInProgress)
			{
				DataColumn dataColumn = (DataColumn)ccevent.Element;
			}
			CollectionChangeEventHandler collectionChanged = this.CollectionChanged;
			if (collectionChanged == null)
			{
				return;
			}
			collectionChanged(this, ccevent);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000069B7 File Offset: 0x00004BB7
		private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
			CollectionChangeEventHandler collectionChanging = this.CollectionChanging;
			if (collectionChanging == null)
			{
				return;
			}
			collectionChanging(this, ccevent);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000069CB File Offset: 0x00004BCB
		internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent)
		{
			this._table.UpdatePropertyDescriptorCollectionCache();
			CollectionChangeEventHandler columnPropertyChanged = this.ColumnPropertyChanged;
			if (columnPropertyChanged == null)
			{
				return;
			}
			columnPropertyChanged(this, ccevent);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000069EC File Offset: 0x00004BEC
		internal void RegisterColumnName(string name, DataColumn column)
		{
			try
			{
				this._columnFromName.Add(name, column);
				if (column != null)
				{
					column._hashCode = this._table.GetSpecialHashCode(name);
				}
			}
			catch (ArgumentException)
			{
				if (this._columnFromName[name] == null)
				{
					throw ExceptionBuilder.CannotAddDuplicate2(name);
				}
				if (column != null)
				{
					throw ExceptionBuilder.CannotAddDuplicate(name);
				}
				throw ExceptionBuilder.CannotAddDuplicate3(name);
			}
			if (column == null && base.NamesEqual(name, this.MakeName(this._defaultNameIndex), true, this._table.Locale) != 0)
			{
				do
				{
					this._defaultNameIndex++;
				}
				while (this.Contains(this.MakeName(this._defaultNameIndex)));
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006A9C File Offset: 0x00004C9C
		internal bool CanRegisterName(string name)
		{
			return !this._columnFromName.ContainsKey(name);
		}

		/// <summary>Removes the specified <see cref="T:System.Data.DataColumn" /> object from the collection.</summary>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The column does not belong to this collection.-Or- The column is part of a relationship.-Or- Another column's expression depends on this column. </exception>
		// Token: 0x0600012E RID: 302 RVA: 0x00006AB0 File Offset: 0x00004CB0
		public void Remove(DataColumn column)
		{
			this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Remove, column));
			this.BaseRemove(column);
			this.ArrayRemove(column);
			this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, column));
			if (column.ColumnMapping == MappingType.Element)
			{
				DataTable table = this._table;
				int elementColumnCount = table.ElementColumnCount;
				table.ElementColumnCount = elementColumnCount - 1;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006B04 File Offset: 0x00004D04
		internal void UnregisterName(string name)
		{
			this._columnFromName.Remove(name);
			if (base.NamesEqual(name, this.MakeName(this._defaultNameIndex - 1), true, this._table.Locale) != 0)
			{
				do
				{
					this._defaultNameIndex--;
				}
				while (this._defaultNameIndex > 1 && !this.Contains(this.MakeName(this._defaultNameIndex - 1)));
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006B70 File Offset: 0x00004D70
		private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
			DataColumn[] columnsImplementingIChangeTracking = this._columnsImplementingIChangeTracking;
			DataColumn[] array = new DataColumn[columnsImplementingIChangeTracking.Length + 1];
			columnsImplementingIChangeTracking.CopyTo(array, 0);
			array[columnsImplementingIChangeTracking.Length] = dataColumn;
			this._columnsImplementingIChangeTracking = array;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006BA4 File Offset: 0x00004DA4
		private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
			DataColumn[] columnsImplementingIChangeTracking = this._columnsImplementingIChangeTracking;
			DataColumn[] array = new DataColumn[columnsImplementingIChangeTracking.Length - 1];
			int i = 0;
			int num = 0;
			while (i < columnsImplementingIChangeTracking.Length)
			{
				if (columnsImplementingIChangeTracking[i] != dataColumn)
				{
					array[num++] = columnsImplementingIChangeTracking[i];
				}
				i++;
			}
			this._columnsImplementingIChangeTracking = array;
		}

		// Token: 0x04000050 RID: 80
		private readonly DataTable _table;

		// Token: 0x04000051 RID: 81
		private readonly ArrayList _list = new ArrayList();

		// Token: 0x04000052 RID: 82
		private int _defaultNameIndex = 1;

		// Token: 0x04000053 RID: 83
		private DataColumn[] _delayedAddRangeColumns;

		// Token: 0x04000054 RID: 84
		private readonly Dictionary<string, DataColumn> _columnFromName;

		// Token: 0x04000055 RID: 85
		private bool _fInClear;

		// Token: 0x04000056 RID: 86
		private DataColumn[] _columnsImplementingIChangeTracking = Array.Empty<DataColumn>();

		// Token: 0x04000057 RID: 87
		private int _nColumnsImplementingIChangeTracking;

		// Token: 0x04000058 RID: 88
		private int _nColumnsImplementingIRevertibleChangeTracking;

		// Token: 0x0400005A RID: 90
		[CompilerGenerated]
		private CollectionChangeEventHandler CollectionChanging;
	}
}
