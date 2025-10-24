using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Threading;

namespace System.Data
{
	/// <summary>Represents the collection of <see cref="T:System.Data.DataRelation" /> objects for this <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000027 RID: 39
	[DefaultEvent("CollectionChanged")]
	[DefaultProperty("Table")]
	public abstract class DataRelationCollection : InternalDataCollectionBase
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000992D File Offset: 0x00007B2D
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataRelation" /> object at the specified index.</summary>
		/// <param name="index">The zero-based index to find. </param>
		/// <returns>The <see cref="T:System.Data.DataRelation" />, or a null value if the specified <see cref="T:System.Data.DataRelation" /> does not exist.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection. </exception>
		// Token: 0x1700006A RID: 106
		public abstract DataRelation this[int index]
		{
			get;
		}

		/// <summary>Gets the <see cref="T:System.Data.DataRelation" /> object specified by name.</summary>
		/// <param name="name">The name of the relation to find. </param>
		/// <returns>The named <see cref="T:System.Data.DataRelation" />, or a null value if the specified <see cref="T:System.Data.DataRelation" /> does not exist.</returns>
		// Token: 0x1700006B RID: 107
		public abstract DataRelation this[string name]
		{
			get;
		}

		/// <summary>Adds a <see cref="T:System.Data.DataRelation" /> to the <see cref="T:System.Data.DataRelationCollection" />.</summary>
		/// <param name="relation">The <see langword="DataRelation" /> to add to the collection. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="relation" /> parameter is a null value. </exception>
		/// <exception cref="T:System.ArgumentException">The relation already belongs to this collection, or it belongs to another collection. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">The collection already has a relation with the specified name. (The comparison is not case sensitive.) </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The relation has entered an invalid state since it was created. </exception>
		// Token: 0x060002C0 RID: 704 RVA: 0x00009938 File Offset: 0x00007B38
		public void Add(DataRelation relation)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataRelationCollection.Add|API> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			try
			{
				if (this._inTransition != relation)
				{
					this._inTransition = relation;
					try
					{
						this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, relation));
						this.AddCore(relation);
						this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, relation));
					}
					finally
					{
						this._inTransition = null;
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Performs verification on the table.</summary>
		/// <param name="relation">The relation to check.</param>
		/// <exception cref="T:System.ArgumentNullException">The relation is null. </exception>
		/// <exception cref="T:System.ArgumentException">The relation already belongs to this collection, or it belongs to another collection. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">The collection already has a relation with the same name. (The comparison is not case sensitive.) </exception>
		// Token: 0x060002C1 RID: 705 RVA: 0x000099CC File Offset: 0x00007BCC
		protected virtual void AddCore(DataRelation relation)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataRelationCollection.AddCore|INFO> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			if (relation == null)
			{
				throw ExceptionBuilder.ArgumentNull("relation");
			}
			relation.CheckState();
			DataSet dataSet = this.GetDataSet();
			if (relation.DataSet == dataSet)
			{
				throw ExceptionBuilder.RelationAlreadyInTheDataSet();
			}
			if (relation.DataSet != null)
			{
				throw ExceptionBuilder.RelationAlreadyInOtherDataSet();
			}
			if (relation.ChildTable.Locale.LCID != relation.ParentTable.Locale.LCID || relation.ChildTable.CaseSensitive != relation.ParentTable.CaseSensitive)
			{
				throw ExceptionBuilder.CaseLocaleMismatch();
			}
			if (relation.Nested)
			{
				relation.CheckNamespaceValidityForNestedRelations(relation.ParentTable.Namespace);
				relation.ValidateMultipleNestedRelations();
				DataTable parentTable = relation.ParentTable;
				int elementColumnCount = parentTable.ElementColumnCount;
				parentTable.ElementColumnCount = elementColumnCount + 1;
			}
		}

		/// <summary>Occurs when the collection has changed.</summary>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060002C2 RID: 706 RVA: 0x00009AA6 File Offset: 0x00007CA6
		// (remove) Token: 0x060002C3 RID: 707 RVA: 0x00009AD4 File Offset: 0x00007CD4
		public event CollectionChangeEventHandler CollectionChanged
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.add_CollectionChanged|API> {0}", this.ObjectID);
				this._onCollectionChangedDelegate = (CollectionChangeEventHandler)Delegate.Combine(this._onCollectionChangedDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.remove_CollectionChanged|API> {0}", this.ObjectID);
				this._onCollectionChangedDelegate = (CollectionChangeEventHandler)Delegate.Remove(this._onCollectionChangedDelegate, value);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009B02 File Offset: 0x00007D02
		internal string AssignName()
		{
			string result = this.MakeName(this._defaultNameIndex);
			this._defaultNameIndex++;
			return result;
		}

		/// <summary>Clears the collection of any relations.</summary>
		// Token: 0x060002C5 RID: 709 RVA: 0x00009B20 File Offset: 0x00007D20
		public virtual void Clear()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataRelationCollection.Clear|API> {0}", this.ObjectID);
			try
			{
				int count = this.Count;
				this.OnCollectionChanging(InternalDataCollectionBase.s_refreshEventArgs);
				for (int i = count - 1; i >= 0; i--)
				{
					this._inTransition = this[i];
					this.RemoveCore(this._inTransition);
				}
				this.OnCollectionChanged(InternalDataCollectionBase.s_refreshEventArgs);
				this._inTransition = null;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Verifies whether a <see cref="T:System.Data.DataRelation" /> with the specific name (case insensitive) exists in the collection.</summary>
		/// <param name="name">The name of the relation to find. </param>
		/// <returns>
		///     <see langword="true" />, if a relation with the specified name exists; otherwise <see langword="false" />.</returns>
		// Token: 0x060002C6 RID: 710 RVA: 0x00009BAC File Offset: 0x00007DAC
		public virtual bool Contains(string name)
		{
			return this.InternalIndexOf(name) >= 0;
		}

		/// <summary>Gets the index of the <see cref="T:System.Data.DataRelation" /> specified by name.</summary>
		/// <param name="relationName">The name of the relation to find. </param>
		/// <returns>The zero-based index of the relation with the specified name, or -1 if the relation does not exist in the collection.</returns>
		// Token: 0x060002C7 RID: 711 RVA: 0x00009BBC File Offset: 0x00007DBC
		public virtual int IndexOf(string relationName)
		{
			int num = this.InternalIndexOf(relationName);
			if (num >= 0)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009BD8 File Offset: 0x00007DD8
		internal int InternalIndexOf(string name)
		{
			int num = -1;
			if (name != null && 0 < name.Length)
			{
				int count = this.List.Count;
				for (int i = 0; i < count; i++)
				{
					DataRelation dataRelation = (DataRelation)this.List[i];
					int num2 = base.NamesEqual(dataRelation.RelationName, name, false, this.GetDataSet().Locale);
					if (num2 == 1)
					{
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

		/// <summary>This method supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>The referenced DataSet.</returns>
		// Token: 0x060002C9 RID: 713
		protected abstract DataSet GetDataSet();

		// Token: 0x060002CA RID: 714 RVA: 0x00009C50 File Offset: 0x00007E50
		private string MakeName(int index)
		{
			if (index != 1)
			{
				return "Relation" + index.ToString(CultureInfo.InvariantCulture);
			}
			return "Relation1";
		}

		/// <summary>Raises the <see cref="E:System.Data.DataRelationCollection.CollectionChanged" /> event.</summary>
		/// <param name="ccevent">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060002CB RID: 715 RVA: 0x00009C72 File Offset: 0x00007E72
		protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
			if (this._onCollectionChangedDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.OnCollectionChanged|INFO> {0}", this.ObjectID);
				this._onCollectionChangedDelegate(this, ccevent);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataRelationCollection.CollectionChanged" /> event.</summary>
		/// <param name="ccevent">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060002CC RID: 716 RVA: 0x00009C9E File Offset: 0x00007E9E
		protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
			if (this._onCollectionChangingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.OnCollectionChanging|INFO> {0}", this.ObjectID);
				this._onCollectionChangingDelegate(this, ccevent);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00009CCC File Offset: 0x00007ECC
		internal void RegisterName(string name)
		{
			DataCommonEventSource.Log.Trace<int, string>("<ds.DataRelationCollection.RegisterName|INFO> {0}, name='{1}'", this.ObjectID, name);
			CultureInfo locale = this.GetDataSet().Locale;
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				if (base.NamesEqual(name, this[i].RelationName, true, locale) != 0)
				{
					throw ExceptionBuilder.DuplicateRelation(this[i].RelationName);
				}
			}
			if (base.NamesEqual(name, this.MakeName(this._defaultNameIndex), true, locale) != 0)
			{
				this._defaultNameIndex++;
			}
		}

		/// <summary>Removes the specified relation from the collection.</summary>
		/// <param name="relation">The relation to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">The relation is a null value.</exception>
		/// <exception cref="T:System.ArgumentException">The relation does not belong to the collection.</exception>
		// Token: 0x060002CE RID: 718 RVA: 0x00009D5C File Offset: 0x00007F5C
		public void Remove(DataRelation relation)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataRelationCollection.Remove|API> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			if (this._inTransition == relation)
			{
				return;
			}
			this._inTransition = relation;
			try
			{
				this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Remove, relation));
				this.RemoveCore(relation);
				this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, relation));
			}
			finally
			{
				this._inTransition = null;
			}
		}

		/// <summary>Removes the relation at the specified index from the collection.</summary>
		/// <param name="index">The index of the relation to remove. </param>
		/// <exception cref="T:System.ArgumentException">The collection does not have a relation at the specified index. </exception>
		// Token: 0x060002CF RID: 719 RVA: 0x00009DD8 File Offset: 0x00007FD8
		public void RemoveAt(int index)
		{
			DataRelation dataRelation = this[index];
			if (dataRelation == null)
			{
				throw ExceptionBuilder.RelationOutOfRange(index);
			}
			this.Remove(dataRelation);
		}

		/// <summary>Performs a verification on the specified <see cref="T:System.Data.DataRelation" /> object.</summary>
		/// <param name="relation">The <see langword="DataRelation" /> object to verify. </param>
		/// <exception cref="T:System.ArgumentNullException">The collection does not have a relation at the specified index. </exception>
		/// <exception cref="T:System.ArgumentException">The specified relation does not belong to this collection, or it belongs to another collection. </exception>
		// Token: 0x060002D0 RID: 720 RVA: 0x00009E04 File Offset: 0x00008004
		protected virtual void RemoveCore(DataRelation relation)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataRelationCollection.RemoveCore|INFO> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			if (relation == null)
			{
				throw ExceptionBuilder.ArgumentNull("relation");
			}
			DataSet dataSet = this.GetDataSet();
			if (relation.DataSet != dataSet)
			{
				throw ExceptionBuilder.RelationNotInTheDataSet(relation.RelationName);
			}
			if (relation.Nested)
			{
				DataTable parentTable = relation.ParentTable;
				int elementColumnCount = parentTable.ElementColumnCount;
				parentTable.ElementColumnCount = elementColumnCount - 1;
				relation.ParentTable.Columns.UnregisterName(relation.ChildTable.TableName);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00009E94 File Offset: 0x00008094
		internal void UnregisterName(string name)
		{
			DataCommonEventSource.Log.Trace<int, string>("<ds.DataRelationCollection.UnregisterName|INFO> {0}, name='{1}'", this.ObjectID, name);
			if (base.NamesEqual(name, this.MakeName(this._defaultNameIndex - 1), true, this.GetDataSet().Locale) != 0)
			{
				do
				{
					this._defaultNameIndex--;
				}
				while (this._defaultNameIndex > 1 && !this.Contains(this.MakeName(this._defaultNameIndex - 1)));
			}
		}

		// Token: 0x04000076 RID: 118
		private DataRelation _inTransition;

		// Token: 0x04000077 RID: 119
		private int _defaultNameIndex = 1;

		// Token: 0x04000078 RID: 120
		private CollectionChangeEventHandler _onCollectionChangedDelegate;

		// Token: 0x04000079 RID: 121
		private CollectionChangeEventHandler _onCollectionChangingDelegate;

		// Token: 0x0400007A RID: 122
		private static int s_objectTypeCount;

		// Token: 0x0400007B RID: 123
		private readonly int _objectID = Interlocked.Increment(ref DataRelationCollection.s_objectTypeCount);

		// Token: 0x02000028 RID: 40
		internal sealed class DataTableRelationCollection : DataRelationCollection
		{
			// Token: 0x060002D3 RID: 723 RVA: 0x00009F26 File Offset: 0x00008126
			internal DataTableRelationCollection(DataTable table, bool fParentCollection)
			{
				if (table == null)
				{
					throw ExceptionBuilder.RelationTableNull();
				}
				this._table = table;
				this._fParentCollection = fParentCollection;
				this._relations = new ArrayList();
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x00009F50 File Offset: 0x00008150
			protected override ArrayList List
			{
				get
				{
					return this._relations;
				}
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x00009F58 File Offset: 0x00008158
			private void EnsureDataSet()
			{
				if (this._table.DataSet == null)
				{
					throw ExceptionBuilder.RelationTableWasRemoved();
				}
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x00009F6D File Offset: 0x0000816D
			protected override DataSet GetDataSet()
			{
				this.EnsureDataSet();
				return this._table.DataSet;
			}

			// Token: 0x1700006D RID: 109
			public override DataRelation this[int index]
			{
				get
				{
					if (index >= 0 && index < this._relations.Count)
					{
						return (DataRelation)this._relations[index];
					}
					throw ExceptionBuilder.RelationOutOfRange(index);
				}
			}

			// Token: 0x1700006E RID: 110
			public override DataRelation this[string name]
			{
				get
				{
					int num = base.InternalIndexOf(name);
					if (num == -2)
					{
						throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
					}
					if (num >= 0)
					{
						return (DataRelation)this.List[num];
					}
					return null;
				}
			}

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x060002D9 RID: 729 RVA: 0x00009FEC File Offset: 0x000081EC
			// (remove) Token: 0x060002DA RID: 730 RVA: 0x0000A024 File Offset: 0x00008224
			internal event CollectionChangeEventHandler RelationPropertyChanged;

			// Token: 0x060002DB RID: 731 RVA: 0x0000A059 File Offset: 0x00008259
			internal void OnRelationPropertyChanged(CollectionChangeEventArgs ccevent)
			{
				if (!this._fParentCollection)
				{
					this._table.UpdatePropertyDescriptorCollectionCache();
				}
				CollectionChangeEventHandler relationPropertyChanged = this.RelationPropertyChanged;
				if (relationPropertyChanged == null)
				{
					return;
				}
				relationPropertyChanged(this, ccevent);
			}

			// Token: 0x060002DC RID: 732 RVA: 0x0000A080 File Offset: 0x00008280
			private void AddCache(DataRelation relation)
			{
				this._relations.Add(relation);
				if (!this._fParentCollection)
				{
					this._table.UpdatePropertyDescriptorCollectionCache();
				}
			}

			// Token: 0x060002DD RID: 733 RVA: 0x0000A0A4 File Offset: 0x000082A4
			protected override void AddCore(DataRelation relation)
			{
				if (this._fParentCollection)
				{
					if (relation.ChildTable != this._table)
					{
						throw ExceptionBuilder.ChildTableMismatch();
					}
				}
				else if (relation.ParentTable != this._table)
				{
					throw ExceptionBuilder.ParentTableMismatch();
				}
				this.GetDataSet().Relations.Add(relation);
				this.AddCache(relation);
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0000A0FC File Offset: 0x000082FC
			private void RemoveCache(DataRelation relation)
			{
				for (int i = 0; i < this._relations.Count; i++)
				{
					if (relation == this._relations[i])
					{
						this._relations.RemoveAt(i);
						if (!this._fParentCollection)
						{
							this._table.UpdatePropertyDescriptorCollectionCache();
						}
						return;
					}
				}
				throw ExceptionBuilder.RelationDoesNotExist();
			}

			// Token: 0x060002DF RID: 735 RVA: 0x0000A154 File Offset: 0x00008354
			protected override void RemoveCore(DataRelation relation)
			{
				if (this._fParentCollection)
				{
					if (relation.ChildTable != this._table)
					{
						throw ExceptionBuilder.ChildTableMismatch();
					}
				}
				else if (relation.ParentTable != this._table)
				{
					throw ExceptionBuilder.ParentTableMismatch();
				}
				this.GetDataSet().Relations.Remove(relation);
				this.RemoveCache(relation);
			}

			// Token: 0x0400007C RID: 124
			private readonly DataTable _table;

			// Token: 0x0400007D RID: 125
			private readonly ArrayList _relations;

			// Token: 0x0400007E RID: 126
			private readonly bool _fParentCollection;
		}

		// Token: 0x02000029 RID: 41
		internal sealed class DataSetRelationCollection : DataRelationCollection
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x0000A1A9 File Offset: 0x000083A9
			internal DataSetRelationCollection(DataSet dataSet)
			{
				if (dataSet == null)
				{
					throw ExceptionBuilder.RelationDataSetNull();
				}
				this._dataSet = dataSet;
				this._relations = new ArrayList();
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000A1CC File Offset: 0x000083CC
			protected override ArrayList List
			{
				get
				{
					return this._relations;
				}
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0000A1D4 File Offset: 0x000083D4
			public override void Clear()
			{
				base.Clear();
				if (this._dataSet._fInitInProgress && this._delayLoadingRelations != null)
				{
					this._delayLoadingRelations = null;
				}
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000A1F8 File Offset: 0x000083F8
			protected override DataSet GetDataSet()
			{
				return this._dataSet;
			}

			// Token: 0x17000070 RID: 112
			public override DataRelation this[int index]
			{
				get
				{
					if (index >= 0 && index < this._relations.Count)
					{
						return (DataRelation)this._relations[index];
					}
					throw ExceptionBuilder.RelationOutOfRange(index);
				}
			}

			// Token: 0x17000071 RID: 113
			public override DataRelation this[string name]
			{
				get
				{
					int num = base.InternalIndexOf(name);
					if (num == -2)
					{
						throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
					}
					if (num >= 0)
					{
						return (DataRelation)this.List[num];
					}
					return null;
				}
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0000A26C File Offset: 0x0000846C
			protected override void AddCore(DataRelation relation)
			{
				base.AddCore(relation);
				if (relation.ChildTable.DataSet != this._dataSet || relation.ParentTable.DataSet != this._dataSet)
				{
					throw ExceptionBuilder.ForeignRelation();
				}
				relation.CheckState();
				if (relation.Nested)
				{
					relation.CheckNestedRelations();
				}
				if (relation._relationName.Length == 0)
				{
					relation._relationName = base.AssignName();
				}
				else
				{
					base.RegisterName(relation._relationName);
				}
				DataKey childKey = relation.ChildKey;
				for (int i = 0; i < this._relations.Count; i++)
				{
					if (childKey.ColumnsEqual(((DataRelation)this._relations[i]).ChildKey) && relation.ParentKey.ColumnsEqual(((DataRelation)this._relations[i]).ParentKey))
					{
						throw ExceptionBuilder.RelationAlreadyExists();
					}
				}
				this._relations.Add(relation);
				((DataRelationCollection.DataTableRelationCollection)relation.ParentTable.ChildRelations).Add(relation);
				((DataRelationCollection.DataTableRelationCollection)relation.ChildTable.ParentRelations).Add(relation);
				relation.SetDataSet(this._dataSet);
				relation.ChildKey.GetSortIndex().AddRef();
				if (relation.Nested)
				{
					relation.ChildTable.CacheNestedParent();
				}
				ForeignKeyConstraint foreignKeyConstraint = relation.ChildTable.Constraints.FindForeignKeyConstraint(relation.ParentColumnsReference, relation.ChildColumnsReference);
				if (relation._createConstraints && foreignKeyConstraint == null)
				{
					relation.ChildTable.Constraints.Add(foreignKeyConstraint = new ForeignKeyConstraint(relation.ParentColumnsReference, relation.ChildColumnsReference));
					try
					{
						foreignKeyConstraint.ConstraintName = relation.RelationName;
					}
					catch (Exception e) when (ADP.IsCatchableExceptionType(e))
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e);
					}
				}
				UniqueConstraint parentKeyConstraint = relation.ParentTable.Constraints.FindKeyConstraint(relation.ParentColumnsReference);
				relation.SetParentKeyConstraint(parentKeyConstraint);
				relation.SetChildKeyConstraint(foreignKeyConstraint);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000A470 File Offset: 0x00008670
			protected override void RemoveCore(DataRelation relation)
			{
				base.RemoveCore(relation);
				this._dataSet.OnRemoveRelationHack(relation);
				relation.SetDataSet(null);
				relation.ChildKey.GetSortIndex().RemoveRef();
				if (relation.Nested)
				{
					relation.ChildTable.CacheNestedParent();
				}
				for (int i = 0; i < this._relations.Count; i++)
				{
					if (relation == this._relations[i])
					{
						this._relations.RemoveAt(i);
						((DataRelationCollection.DataTableRelationCollection)relation.ParentTable.ChildRelations).Remove(relation);
						((DataRelationCollection.DataTableRelationCollection)relation.ChildTable.ParentRelations).Remove(relation);
						if (relation.Nested)
						{
							relation.ChildTable.CacheNestedParent();
						}
						base.UnregisterName(relation.RelationName);
						relation.SetParentKeyConstraint(null);
						relation.SetChildKeyConstraint(null);
						return;
					}
				}
				throw ExceptionBuilder.RelationDoesNotExist();
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000A554 File Offset: 0x00008754
			internal void FinishInitRelations()
			{
				if (this._delayLoadingRelations == null)
				{
					return;
				}
				for (int i = 0; i < this._delayLoadingRelations.Length; i++)
				{
					DataRelation dataRelation = this._delayLoadingRelations[i];
					if (dataRelation._parentColumnNames == null || dataRelation._childColumnNames == null)
					{
						base.Add(dataRelation);
					}
					else
					{
						int num = dataRelation._parentColumnNames.Length;
						DataColumn[] array = new DataColumn[num];
						DataColumn[] array2 = new DataColumn[num];
						for (int j = 0; j < num; j++)
						{
							if (dataRelation._parentTableNamespace == null)
							{
								array[j] = this._dataSet.Tables[dataRelation._parentTableName].Columns[dataRelation._parentColumnNames[j]];
							}
							else
							{
								array[j] = this._dataSet.Tables[dataRelation._parentTableName, dataRelation._parentTableNamespace].Columns[dataRelation._parentColumnNames[j]];
							}
							if (dataRelation._childTableNamespace == null)
							{
								array2[j] = this._dataSet.Tables[dataRelation._childTableName].Columns[dataRelation._childColumnNames[j]];
							}
							else
							{
								array2[j] = this._dataSet.Tables[dataRelation._childTableName, dataRelation._childTableNamespace].Columns[dataRelation._childColumnNames[j]];
							}
						}
						base.Add(new DataRelation(dataRelation._relationName, array, array2, false)
						{
							Nested = dataRelation._nested
						});
					}
				}
				this._delayLoadingRelations = null;
			}

			// Token: 0x04000080 RID: 128
			private readonly DataSet _dataSet;

			// Token: 0x04000081 RID: 129
			private readonly ArrayList _relations;

			// Token: 0x04000082 RID: 130
			private DataRelation[] _delayLoadingRelations;
		}
	}
}
