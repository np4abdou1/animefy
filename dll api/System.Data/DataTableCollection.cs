using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace System.Data
{
	/// <summary>Represents the collection of tables for the <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000040 RID: 64
	[DefaultEvent("CollectionChanged")]
	[ListBindable(false)]
	public sealed class DataTableCollection : InternalDataCollectionBase
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00019A94 File Offset: 0x00017C94
		internal DataTableCollection(DataSet dataSet)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataTableCollection.DataTableCollection|INFO> {0}, dataSet={1}", this.ObjectID, (dataSet != null) ? dataSet.ObjectID : 0);
			this._dataSet = dataSet;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00019AF1 File Offset: 0x00017CF1
		protected override ArrayList List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00019AF9 File Offset: 0x00017CF9
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataTable" /> object at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Data.DataTable" /> to find. </param>
		/// <returns>A <see cref="T:System.Data.DataTable" />with the specified index; otherwise <see langword="null" /> if the <see cref="T:System.Data.DataTable" /> does not exist.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection. </exception>
		// Token: 0x170000CF RID: 207
		public DataTable this[int index]
		{
			get
			{
				DataTable result;
				try
				{
					result = (DataTable)this._list[index];
				}
				catch (ArgumentOutOfRangeException)
				{
					throw ExceptionBuilder.TableOutOfRange(index);
				}
				return result;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataTable" /> object with the specified name.</summary>
		/// <param name="name">The name of the <see langword="DataTable" /> to find. </param>
		/// <returns>A <see cref="T:System.Data.DataTable" /> with the specified name; otherwise <see langword="null" /> if the <see cref="T:System.Data.DataTable" /> does not exist.</returns>
		// Token: 0x170000D0 RID: 208
		public DataTable this[string name]
		{
			get
			{
				int num = this.InternalIndexOf(name);
				if (num == -2)
				{
					throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
				}
				if (num == -3)
				{
					throw ExceptionBuilder.NamespaceNameConflict(name);
				}
				if (num >= 0)
				{
					return (DataTable)this._list[num];
				}
				return null;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataTable" /> object with the specified name in the specified namespace.</summary>
		/// <param name="name">The name of the <see langword="DataTable" /> to find.</param>
		/// <param name="tableNamespace">The name of the <see cref="T:System.Data.DataTable" /> namespace to look in.</param>
		/// <returns>A <see cref="T:System.Data.DataTable" /> with the specified name; otherwise <see langword="null" /> if the <see cref="T:System.Data.DataTable" /> does not exist.</returns>
		// Token: 0x170000D1 RID: 209
		public DataTable this[string name, string tableNamespace]
		{
			get
			{
				if (tableNamespace == null)
				{
					throw ExceptionBuilder.ArgumentNull("tableNamespace");
				}
				int num = this.InternalIndexOf(name, tableNamespace);
				if (num == -2)
				{
					throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
				}
				if (num >= 0)
				{
					return (DataTable)this._list[num];
				}
				return null;
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00019BCC File Offset: 0x00017DCC
		internal DataTable GetTable(string name, string ns)
		{
			for (int i = 0; i < this._list.Count; i++)
			{
				DataTable dataTable = (DataTable)this._list[i];
				if (dataTable.TableName == name && dataTable.Namespace == ns)
				{
					return dataTable;
				}
			}
			return null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00019C20 File Offset: 0x00017E20
		internal DataTable GetTableSmart(string name, string ns)
		{
			int num = 0;
			DataTable result = null;
			for (int i = 0; i < this._list.Count; i++)
			{
				DataTable dataTable = (DataTable)this._list[i];
				if (dataTable.TableName == name)
				{
					if (dataTable.Namespace == ns)
					{
						return dataTable;
					}
					num++;
					result = dataTable;
				}
			}
			if (num != 1)
			{
				return null;
			}
			return result;
		}

		/// <summary>Adds the specified <see langword="DataTable" /> to the collection.</summary>
		/// <param name="table">The <see langword="DataTable" /> object to add. </param>
		/// <exception cref="T:System.ArgumentNullException">The value specified for the table is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The table already belongs to this collection, or belongs to another collection. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">A table in the collection has the same name. The comparison is not case sensitive. </exception>
		// Token: 0x06000570 RID: 1392 RVA: 0x00019C84 File Offset: 0x00017E84
		public void Add(DataTable table)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataTableCollection.Add|API> {0}, table={1}", this.ObjectID, (table != null) ? table.ObjectID : 0);
			try
			{
				this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, table));
				this.BaseAdd(table);
				this.ArrayAdd(table);
				if (table.SetLocaleValue(this._dataSet.Locale, false, false) || table.SetCaseSensitiveValue(this._dataSet.CaseSensitive, false, false))
				{
					table.ResetIndexes();
				}
				this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, table));
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Occurs after the <see cref="T:System.Data.DataTableCollection" /> is changed because of <see cref="T:System.Data.DataTable" /> objects being added or removed.</summary>
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000571 RID: 1393 RVA: 0x00019D2C File Offset: 0x00017F2C
		// (remove) Token: 0x06000572 RID: 1394 RVA: 0x00019D5A File Offset: 0x00017F5A
		public event CollectionChangeEventHandler CollectionChanged
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTableCollection.add_CollectionChanged|API> {0}", this.ObjectID);
				this._onCollectionChangedDelegate = (CollectionChangeEventHandler)Delegate.Combine(this._onCollectionChangedDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTableCollection.remove_CollectionChanged|API> {0}", this.ObjectID);
				this._onCollectionChangedDelegate = (CollectionChangeEventHandler)Delegate.Remove(this._onCollectionChangedDelegate, value);
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00019D88 File Offset: 0x00017F88
		private void ArrayAdd(DataTable table)
		{
			this._list.Add(table);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00019D98 File Offset: 0x00017F98
		internal string AssignName()
		{
			string result;
			while (this.Contains(result = this.MakeName(this._defaultNameIndex)))
			{
				this._defaultNameIndex++;
			}
			return result;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00019DD0 File Offset: 0x00017FD0
		private void BaseAdd(DataTable table)
		{
			if (table == null)
			{
				throw ExceptionBuilder.ArgumentNull("table");
			}
			if (table.DataSet == this._dataSet)
			{
				throw ExceptionBuilder.TableAlreadyInTheDataSet();
			}
			if (table.DataSet != null)
			{
				throw ExceptionBuilder.TableAlreadyInOtherDataSet();
			}
			if (table.TableName.Length == 0)
			{
				table.TableName = this.AssignName();
			}
			else
			{
				if (base.NamesEqual(table.TableName, this._dataSet.DataSetName, false, this._dataSet.Locale) != 0 && !table._fNestedInDataset)
				{
					throw ExceptionBuilder.DatasetConflictingName(this._dataSet.DataSetName);
				}
				this.RegisterName(table.TableName, table.Namespace);
			}
			table.SetDataSet(this._dataSet);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00019E84 File Offset: 0x00018084
		private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength)
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
				if (!flag && oldArray[i].DataSet == this._dataSet)
				{
					this.BaseRemove(oldArray[i]);
				}
			}
			for (int k = 0; k < newLength; k++)
			{
				if (newArray[k].DataSet != this._dataSet)
				{
					this.BaseAdd(newArray[k]);
					this._list.Add(newArray[k]);
				}
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00019F1A File Offset: 0x0001811A
		private void BaseRemove(DataTable table)
		{
			if (this.CanRemove(table, true))
			{
				this.UnregisterName(table.TableName);
				table.SetDataSet(null);
			}
			this._list.Remove(table);
			this._dataSet.OnRemovedTable(table);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00019F54 File Offset: 0x00018154
		internal bool CanRemove(DataTable table, bool fThrowException)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int, bool>("<ds.DataTableCollection.CanRemove|INFO> {0}, table={1}, fThrowException={2}", this.ObjectID, (table != null) ? table.ObjectID : 0, fThrowException);
			bool result;
			try
			{
				if (table == null)
				{
					if (fThrowException)
					{
						throw ExceptionBuilder.ArgumentNull("table");
					}
					result = false;
				}
				else if (table.DataSet != this._dataSet)
				{
					if (fThrowException)
					{
						throw ExceptionBuilder.TableNotInTheDataSet(table.TableName);
					}
					result = false;
				}
				else
				{
					this._dataSet.OnRemoveTable(table);
					if (table.ChildRelations.Count != 0 || table.ParentRelations.Count != 0)
					{
						if (fThrowException)
						{
							throw ExceptionBuilder.TableInRelation();
						}
						result = false;
					}
					else
					{
						ParentForeignKeyConstraintEnumerator parentForeignKeyConstraintEnumerator = new ParentForeignKeyConstraintEnumerator(this._dataSet, table);
						while (parentForeignKeyConstraintEnumerator.GetNext())
						{
							ForeignKeyConstraint foreignKeyConstraint = parentForeignKeyConstraintEnumerator.GetForeignKeyConstraint();
							if (foreignKeyConstraint.Table != table || foreignKeyConstraint.RelatedTable != table)
							{
								if (!fThrowException)
								{
									return false;
								}
								throw ExceptionBuilder.TableInConstraint(table, foreignKeyConstraint);
							}
						}
						ChildForeignKeyConstraintEnumerator childForeignKeyConstraintEnumerator = new ChildForeignKeyConstraintEnumerator(this._dataSet, table);
						while (childForeignKeyConstraintEnumerator.GetNext())
						{
							ForeignKeyConstraint foreignKeyConstraint2 = childForeignKeyConstraintEnumerator.GetForeignKeyConstraint();
							if (foreignKeyConstraint2.Table != table || foreignKeyConstraint2.RelatedTable != table)
							{
								if (!fThrowException)
								{
									return false;
								}
								throw ExceptionBuilder.TableInConstraint(table, foreignKeyConstraint2);
							}
						}
						result = true;
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Clears the collection of all <see cref="T:System.Data.DataTable" /> objects.</summary>
		// Token: 0x06000579 RID: 1401 RVA: 0x0001A09C File Offset: 0x0001829C
		public void Clear()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTableCollection.Clear|API> {0}", this.ObjectID);
			try
			{
				int count = this._list.Count;
				DataTable[] array = new DataTable[this._list.Count];
				this._list.CopyTo(array, 0);
				this.OnCollectionChanging(InternalDataCollectionBase.s_refreshEventArgs);
				if (this._dataSet._fInitInProgress && this._delayedAddRangeTables != null)
				{
					this._delayedAddRangeTables = null;
				}
				this.BaseGroupSwitch(array, count, null, 0);
				this._list.Clear();
				this.OnCollectionChanged(InternalDataCollectionBase.s_refreshEventArgs);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Gets a value that indicates whether a <see cref="T:System.Data.DataTable" /> object with the specified name exists in the collection.</summary>
		/// <param name="name">The name of the <see cref="T:System.Data.DataTable" /> to find. </param>
		/// <returns>
		///     <see langword="true" /> if the specified table exists; otherwise <see langword="false" />.</returns>
		// Token: 0x0600057A RID: 1402 RVA: 0x0001A150 File Offset: 0x00018350
		public bool Contains(string name)
		{
			return this.InternalIndexOf(name) >= 0;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001A160 File Offset: 0x00018360
		internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive)
		{
			if (!caseSensitive)
			{
				return this.InternalIndexOf(name) >= 0;
			}
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				DataTable dataTable = (DataTable)this._list[i];
				string a = checkProperty ? dataTable.Namespace : dataTable._tableNamespace;
				if (base.NamesEqual(dataTable.TableName, name, true, this._dataSet.Locale) == 1 && a == tableNamespace)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001A1E4 File Offset: 0x000183E4
		internal bool Contains(string name, bool caseSensitive)
		{
			if (!caseSensitive)
			{
				return this.InternalIndexOf(name) >= 0;
			}
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				DataTable dataTable = (DataTable)this._list[i];
				if (base.NamesEqual(dataTable.TableName, name, true, this._dataSet.Locale) == 1)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Gets the index of the specified <see cref="T:System.Data.DataTable" /> object.</summary>
		/// <param name="table">The <see langword="DataTable" /> to search for. </param>
		/// <returns>The zero-based index of the table, or -1 if the table is not found in the collection.</returns>
		// Token: 0x0600057D RID: 1405 RVA: 0x0001A24C File Offset: 0x0001844C
		public int IndexOf(DataTable table)
		{
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				if (table == (DataTable)this._list[i])
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Gets the index in the collection of the <see cref="T:System.Data.DataTable" /> object with the specified name.</summary>
		/// <param name="tableName">The name of the <see langword="DataTable" /> object to look for. </param>
		/// <returns>The zero-based index of the <see langword="DataTable" /> with the specified name, or -1 if the table does not exist in the collection.Returns -1 when two or more tables have the same name but different namespaces. The call does not succeed if there is any ambiguity when matching a table name to exactly one table.</returns>
		// Token: 0x0600057E RID: 1406 RVA: 0x0001A288 File Offset: 0x00018488
		public int IndexOf(string tableName)
		{
			int num = this.InternalIndexOf(tableName);
			if (num >= 0)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0001A2A4 File Offset: 0x000184A4
		internal int IndexOf(string tableName, string tableNamespace, bool chekforNull)
		{
			if (chekforNull)
			{
				if (tableName == null)
				{
					throw ExceptionBuilder.ArgumentNull("tableName");
				}
				if (tableNamespace == null)
				{
					throw ExceptionBuilder.ArgumentNull("tableNamespace");
				}
			}
			int num = this.InternalIndexOf(tableName, tableNamespace);
			if (num >= 0)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001A2E0 File Offset: 0x000184E0
		internal void ReplaceFromInference(List<DataTable> tableList)
		{
			this._list.Clear();
			this._list.AddRange(tableList);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001A2FC File Offset: 0x000184FC
		internal int InternalIndexOf(string tableName)
		{
			int num = -1;
			if (tableName != null && 0 < tableName.Length)
			{
				int count = this._list.Count;
				for (int i = 0; i < count; i++)
				{
					DataTable dataTable = (DataTable)this._list[i];
					int num2 = base.NamesEqual(dataTable.TableName, tableName, false, this._dataSet.Locale);
					if (num2 == 1)
					{
						for (int j = i + 1; j < count; j++)
						{
							DataTable dataTable2 = (DataTable)this._list[j];
							if (base.NamesEqual(dataTable2.TableName, tableName, false, this._dataSet.Locale) == 1)
							{
								return -3;
							}
						}
						return i;
					}
					if (num2 == -1)
					{
						num = ((num == -1) ? i : -2);
					}
				}
			}
			return num;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001A3C8 File Offset: 0x000185C8
		internal int InternalIndexOf(string tableName, string tableNamespace)
		{
			int num = -1;
			if (tableName != null && 0 < tableName.Length)
			{
				int count = this._list.Count;
				for (int i = 0; i < count; i++)
				{
					DataTable dataTable = (DataTable)this._list[i];
					int num2 = base.NamesEqual(dataTable.TableName, tableName, false, this._dataSet.Locale);
					if (num2 == 1 && dataTable.Namespace == tableNamespace)
					{
						return i;
					}
					if (num2 == -1 && dataTable.Namespace == tableNamespace)
					{
						num = ((num == -1) ? i : -2);
					}
				}
			}
			return num;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001A464 File Offset: 0x00018664
		internal void FinishInitCollection()
		{
			if (this._delayedAddRangeTables != null)
			{
				foreach (DataTable dataTable in this._delayedAddRangeTables)
				{
					if (dataTable != null)
					{
						this.Add(dataTable);
					}
				}
				this._delayedAddRangeTables = null;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001A4A3 File Offset: 0x000186A3
		private string MakeName(int index)
		{
			if (1 != index)
			{
				return "Table" + index.ToString(CultureInfo.InvariantCulture);
			}
			return "Table1";
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001A4C5 File Offset: 0x000186C5
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
			if (this._onCollectionChangedDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTableCollection.OnCollectionChanged|INFO> {0}", this.ObjectID);
				this._onCollectionChangedDelegate(this, ccevent);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001A4F1 File Offset: 0x000186F1
		private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
			if (this._onCollectionChangingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTableCollection.OnCollectionChanging|INFO> {0}", this.ObjectID);
				this._onCollectionChangingDelegate(this, ccevent);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001A520 File Offset: 0x00018720
		internal void RegisterName(string name, string tbNamespace)
		{
			DataCommonEventSource.Log.Trace<int, string, string>("<ds.DataTableCollection.RegisterName|INFO> {0}, name='{1}', tbNamespace='{2}'", this.ObjectID, name, tbNamespace);
			CultureInfo locale = this._dataSet.Locale;
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				DataTable dataTable = (DataTable)this._list[i];
				if (base.NamesEqual(name, dataTable.TableName, true, locale) != 0 && tbNamespace == dataTable.Namespace)
				{
					throw ExceptionBuilder.DuplicateTableName(((DataTable)this._list[i]).TableName);
				}
			}
			if (base.NamesEqual(name, this.MakeName(this._defaultNameIndex), true, locale) != 0)
			{
				this._defaultNameIndex++;
			}
		}

		/// <summary>Removes the specified <see cref="T:System.Data.DataTable" /> object from the collection.</summary>
		/// <param name="table">The <see langword="DataTable" /> to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">The value specified for the table is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The table does not belong to this collection.-or- The table is part of a relationship. </exception>
		// Token: 0x06000588 RID: 1416 RVA: 0x0001A5DC File Offset: 0x000187DC
		public void Remove(DataTable table)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataTableCollection.Remove|API> {0}, table={1}", this.ObjectID, (table != null) ? table.ObjectID : 0);
			try
			{
				this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Remove, table));
				this.BaseRemove(table);
				this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, table));
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001A64C File Offset: 0x0001884C
		internal void UnregisterName(string name)
		{
			DataCommonEventSource.Log.Trace<int, string>("<ds.DataTableCollection.UnregisterName|INFO> {0}, name='{1}'", this.ObjectID, name);
			if (base.NamesEqual(name, this.MakeName(this._defaultNameIndex - 1), true, this._dataSet.Locale) != 0)
			{
				do
				{
					this._defaultNameIndex--;
				}
				while (this._defaultNameIndex > 1 && !this.Contains(this.MakeName(this._defaultNameIndex - 1)));
			}
		}

		// Token: 0x04000132 RID: 306
		private readonly DataSet _dataSet;

		// Token: 0x04000133 RID: 307
		private readonly ArrayList _list = new ArrayList();

		// Token: 0x04000134 RID: 308
		private int _defaultNameIndex = 1;

		// Token: 0x04000135 RID: 309
		private DataTable[] _delayedAddRangeTables;

		// Token: 0x04000136 RID: 310
		private CollectionChangeEventHandler _onCollectionChangedDelegate;

		// Token: 0x04000137 RID: 311
		private CollectionChangeEventHandler _onCollectionChangingDelegate;

		// Token: 0x04000138 RID: 312
		private static int s_objectTypeCount;

		// Token: 0x04000139 RID: 313
		private readonly int _objectID = Interlocked.Increment(ref DataTableCollection.s_objectTypeCount);
	}
}
