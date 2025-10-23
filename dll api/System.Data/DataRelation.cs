using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Data
{
	/// <summary>Represents a parent/child relationship between two <see cref="T:System.Data.DataTable" /> objects.</summary>
	// Token: 0x02000026 RID: 38
	[DefaultProperty("RelationName")]
	[TypeConverter(typeof(RelationshipConverter))]
	public class DataRelation
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelation" /> class using the specified <see cref="T:System.Data.DataRelation" /> name, and parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="relationName">The name of the <see cref="T:System.Data.DataRelation" />. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />. </param>
		/// <param name="parentColumn">The parent <see cref="T:System.Data.DataColumn" /> in the relationship. </param>
		/// <param name="childColumn">The child <see cref="T:System.Data.DataColumn" /> in the relationship. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the <see cref="T:System.Data.DataColumn" /> objects contains <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types -Or- The tables do not belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000290 RID: 656 RVA: 0x00008842 File Offset: 0x00006A42
		public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn) : this(relationName, parentColumn, childColumn, true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelation" /> class using the specified name, parent and child <see cref="T:System.Data.DataColumn" /> objects, and a value that indicates whether to create constraints.</summary>
		/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />. </param>
		/// <param name="parentColumn">The parent <see cref="T:System.Data.DataColumn" /> in the relation. </param>
		/// <param name="childColumn">The child <see cref="T:System.Data.DataColumn" /> in the relation. </param>
		/// <param name="createConstraints">A value that indicates whether constraints are created. <see langword="true" />, if constraints are created. Otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the <see cref="T:System.Data.DataColumn" /> objects contains <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types -Or- The tables do not belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000291 RID: 657 RVA: 0x00008850 File Offset: 0x00006A50
		public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints)
		{
			this._relationName = string.Empty;
			this._checkMultipleNested = true;
			this._objectID = Interlocked.Increment(ref DataRelation.s_objectTypeCount);
			base..ctor();
			DataCommonEventSource.Log.Trace<int, string, int, int, bool>("<ds.DataRelation.DataRelation|API> {0}, relationName='{1}', parentColumn={2}, childColumn={3}, createConstraints={4}", this.ObjectID, relationName, (parentColumn != null) ? parentColumn.ObjectID : 0, (childColumn != null) ? childColumn.ObjectID : 0, createConstraints);
			this.Create(relationName, new DataColumn[]
			{
				parentColumn
			}, new DataColumn[]
			{
				childColumn
			}, createConstraints);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelation" /> class using the specified <see cref="T:System.Data.DataRelation" /> name and matched arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />. </param>
		/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> objects. </param>
		/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> objects. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the <see cref="T:System.Data.DataColumn" /> objects contains <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The <see cref="T:System.Data.DataColumn" /> objects have different data types -Or- One or both of the arrays are not composed of distinct columns from the same table.-Or- The tables do not belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000292 RID: 658 RVA: 0x000088D6 File Offset: 0x00006AD6
		public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) : this(relationName, parentColumns, childColumns, true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelation" /> class using the specified name, matched arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects, and value that indicates whether to create constraints.</summary>
		/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />. </param>
		/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> objects. </param>
		/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> objects. </param>
		/// <param name="createConstraints">A value that indicates whether to create constraints. <see langword="true" />, if constraints are created. Otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the <see cref="T:System.Data.DataColumn" /> objects is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types -Or- The tables do not belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000293 RID: 659 RVA: 0x000088E2 File Offset: 0x00006AE2
		public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints)
		{
			this._relationName = string.Empty;
			this._checkMultipleNested = true;
			this._objectID = Interlocked.Increment(ref DataRelation.s_objectTypeCount);
			base..ctor();
			this.Create(relationName, parentColumns, childColumns, createConstraints);
		}

		/// <summary>This constructor is provided for design time support in the Visual Studio environment.</summary>
		/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />. </param>
		/// <param name="parentTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the parent table of the relation. </param>
		/// <param name="childTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the child table of the relation. </param>
		/// <param name="parentColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the parent <see cref="T:System.Data.DataTable" /> of the relation. </param>
		/// <param name="childColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the child <see cref="T:System.Data.DataTable" /> of the relation. </param>
		/// <param name="nested">A value that indicates whether relationships are nested. </param>
		// Token: 0x06000294 RID: 660 RVA: 0x00008918 File Offset: 0x00006B18
		[Browsable(false)]
		public DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested)
		{
			this._relationName = string.Empty;
			this._checkMultipleNested = true;
			this._objectID = Interlocked.Increment(ref DataRelation.s_objectTypeCount);
			base..ctor();
			this._relationName = relationName;
			this._parentColumnNames = parentColumnNames;
			this._childColumnNames = childColumnNames;
			this._parentTableName = parentTableName;
			this._childTableName = childTableName;
			this._nested = nested;
		}

		/// <summary>This constructor is provided for design time support in the Visual Studio environment.</summary>
		/// <param name="relationName">The name of the <see cref="T:System.Data.DataRelation" />. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />. </param>
		/// <param name="parentTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the parent table of the relation.</param>
		/// <param name="parentTableNamespace">The name of the parent table namespace.</param>
		/// <param name="childTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the child table of the relation. </param>
		/// <param name="childTableNamespace">The name of the child table namespace.</param>
		/// <param name="parentColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the parent <see cref="T:System.Data.DataTable" /> of the relation.</param>
		/// <param name="childColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the child <see cref="T:System.Data.DataTable" /> of the relation.</param>
		/// <param name="nested">A value that indicates whether relationships are nested.</param>
		// Token: 0x06000295 RID: 661 RVA: 0x0000897C File Offset: 0x00006B7C
		[Browsable(false)]
		public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested)
		{
			this._relationName = string.Empty;
			this._checkMultipleNested = true;
			this._objectID = Interlocked.Increment(ref DataRelation.s_objectTypeCount);
			base..ctor();
			this._relationName = relationName;
			this._parentColumnNames = parentColumnNames;
			this._childColumnNames = childColumnNames;
			this._parentTableName = parentTableName;
			this._childTableName = childTableName;
			this._parentTableNamespace = parentTableNamespace;
			this._childTableNamespace = childTableNamespace;
			this._nested = nested;
		}

		/// <summary>Gets the child <see cref="T:System.Data.DataColumn" /> objects of this relation.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects.</returns>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000089EE File Offset: 0x00006BEE
		public virtual DataColumn[] ChildColumns
		{
			get
			{
				this.CheckStateForProperty();
				return this._childKey.ToArray();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00008A01 File Offset: 0x00006C01
		internal DataColumn[] ChildColumnsReference
		{
			get
			{
				this.CheckStateForProperty();
				return this._childKey.ColumnsReference;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00008A14 File Offset: 0x00006C14
		internal DataKey ChildKey
		{
			get
			{
				this.CheckStateForProperty();
				return this._childKey;
			}
		}

		/// <summary>Gets the child table of this relation.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> that is the child table of the relation.</returns>
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00008A22 File Offset: 0x00006C22
		public virtual DataTable ChildTable
		{
			get
			{
				this.CheckStateForProperty();
				return this._childKey.Table;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which the <see cref="T:System.Data.DataRelation" /> belongs.</summary>
		/// <returns>A <see cref="T:System.Data.DataSet" /> to which the <see cref="T:System.Data.DataRelation" /> belongs.</returns>
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00008A35 File Offset: 0x00006C35
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual DataSet DataSet
		{
			get
			{
				this.CheckStateForProperty();
				return this._dataSet;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00008A43 File Offset: 0x00006C43
		internal string[] ParentColumnNames
		{
			get
			{
				return this._parentKey.GetColumnNames();
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00008A50 File Offset: 0x00006C50
		internal string[] ChildColumnNames
		{
			get
			{
				return this._childKey.GetColumnNames();
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00008A60 File Offset: 0x00006C60
		private static bool IsKeyNull(object[] values)
		{
			for (int i = 0; i < values.Length; i++)
			{
				if (!DataStorage.IsObjectNull(values[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00008A88 File Offset: 0x00006C88
		internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version)
		{
			object[] keyValues = parentRow.GetKeyValues(parentKey, version);
			if (DataRelation.IsKeyNull(keyValues))
			{
				return childKey.Table.NewRowArray(0);
			}
			return childKey.GetSortIndex((version == DataRowVersion.Original) ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows).GetRows(keyValues);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00008AD0 File Offset: 0x00006CD0
		internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
		{
			object[] keyValues = childRow.GetKeyValues(childKey, version);
			if (DataRelation.IsKeyNull(keyValues))
			{
				return parentKey.Table.NewRowArray(0);
			}
			return parentKey.GetSortIndex((version == DataRowVersion.Original) ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows).GetRows(keyValues);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00008B18 File Offset: 0x00006D18
		internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
		{
			if (!childRow.HasVersion((version == DataRowVersion.Original) ? DataRowVersion.Original : DataRowVersion.Current) && childRow._tempRecord == -1)
			{
				return null;
			}
			object[] keyValues = childRow.GetKeyValues(childKey, version);
			if (DataRelation.IsKeyNull(keyValues))
			{
				return null;
			}
			Index sortIndex = parentKey.GetSortIndex((version == DataRowVersion.Original) ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows);
			Range range = sortIndex.FindRecords(keyValues);
			if (range.IsNull)
			{
				return null;
			}
			if (range.Count > 1)
			{
				throw ExceptionBuilder.MultipleParents();
			}
			return parentKey.Table._recordManager[sortIndex.GetRecord(range.Min)];
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00008BB6 File Offset: 0x00006DB6
		internal void SetDataSet(DataSet dataSet)
		{
			if (this._dataSet != dataSet)
			{
				this._dataSet = dataSet;
			}
		}

		/// <summary>Gets an array of <see cref="T:System.Data.DataColumn" /> objects that are the parent columns of this <see cref="T:System.Data.DataRelation" />.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that are the parent columns of this <see cref="T:System.Data.DataRelation" />.</returns>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public virtual DataColumn[] ParentColumns
		{
			get
			{
				this.CheckStateForProperty();
				return this._parentKey.ToArray();
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00008BDB File Offset: 0x00006DDB
		internal DataColumn[] ParentColumnsReference
		{
			get
			{
				return this._parentKey.ColumnsReference;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00008BE8 File Offset: 0x00006DE8
		internal DataKey ParentKey
		{
			get
			{
				this.CheckStateForProperty();
				return this._parentKey;
			}
		}

		/// <summary>Gets the parent <see cref="T:System.Data.DataTable" /> of this <see cref="T:System.Data.DataRelation" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> that is the parent table of this relation.</returns>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00008BF6 File Offset: 0x00006DF6
		public virtual DataTable ParentTable
		{
			get
			{
				this.CheckStateForProperty();
				return this._parentKey.Table;
			}
		}

		/// <summary>Gets or sets the name used to retrieve a <see cref="T:System.Data.DataRelation" /> from the <see cref="T:System.Data.DataRelationCollection" />.</summary>
		/// <returns>The name of the a <see cref="T:System.Data.DataRelation" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <see langword="null" /> or empty string ("") was passed into a <see cref="T:System.Data.DataColumn" /> that is a <see cref="T:System.Data.DataRelation" />. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">The <see cref="T:System.Data.DataRelation" /> belongs to a collection that already contains a <see cref="T:System.Data.DataRelation" /> with the same name. </exception>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00008C09 File Offset: 0x00006E09
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00008C18 File Offset: 0x00006E18
		[DefaultValue("")]
		public virtual string RelationName
		{
			get
			{
				this.CheckStateForProperty();
				return this._relationName;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, string>("<ds.DataRelation.set_RelationName|API> {0}, '{1}'", this.ObjectID, value);
				try
				{
					if (value == null)
					{
						value = string.Empty;
					}
					CultureInfo culture = (this._dataSet != null) ? this._dataSet.Locale : CultureInfo.CurrentCulture;
					if (string.Compare(this._relationName, value, true, culture) != 0)
					{
						if (this._dataSet != null)
						{
							if (value.Length == 0)
							{
								throw ExceptionBuilder.NoRelationName();
							}
							this._dataSet.Relations.RegisterName(value);
							if (this._relationName.Length != 0)
							{
								this._dataSet.Relations.UnregisterName(this._relationName);
							}
						}
						this._relationName = value;
						((DataRelationCollection.DataTableRelationCollection)this.ParentTable.ChildRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, this));
						((DataRelationCollection.DataTableRelationCollection)this.ChildTable.ParentRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, this));
					}
					else if (string.Compare(this._relationName, value, false, culture) != 0)
					{
						this._relationName = value;
						((DataRelationCollection.DataTableRelationCollection)this.ParentTable.ChildRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, this));
						((DataRelationCollection.DataTableRelationCollection)this.ChildTable.ParentRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, this));
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008D78 File Offset: 0x00006F78
		internal void CheckNamespaceValidityForNestedRelations(string ns)
		{
			foreach (object obj in this.ChildTable.ParentRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				if ((dataRelation == this || dataRelation.Nested) && dataRelation.ParentTable.Namespace != ns)
				{
					throw ExceptionBuilder.InValidNestedRelation(this.ChildTable.TableName);
				}
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00008E00 File Offset: 0x00007000
		internal void CheckNestedRelations()
		{
			DataCommonEventSource.Log.Trace<int>("<ds.DataRelation.CheckNestedRelations|INFO> {0}", this.ObjectID);
			DataTable parentTable = this.ParentTable;
			if (this.ChildTable != this.ParentTable)
			{
				List<DataTable> list = new List<DataTable>();
				list.Add(this.ChildTable);
				for (int i = 0; i < list.Count; i++)
				{
					foreach (DataRelation dataRelation in list[i].NestedParentRelations)
					{
						if (dataRelation.ParentTable == this.ChildTable && dataRelation.ChildTable != this.ChildTable)
						{
							throw ExceptionBuilder.LoopInNestedRelations(this.ChildTable.TableName);
						}
						if (!list.Contains(dataRelation.ParentTable))
						{
							list.Add(dataRelation.ParentTable);
						}
					}
				}
				return;
			}
			if (string.Compare(this.ChildTable.TableName, this.ChildTable.DataSet.DataSetName, true, this.ChildTable.DataSet.Locale) == 0)
			{
				throw ExceptionBuilder.SelfnestedDatasetConflictingName(this.ChildTable.TableName);
			}
		}

		/// <summary>Gets or sets a value that indicates whether <see cref="T:System.Data.DataRelation" /> objects are nested.</summary>
		/// <returns>
		///     <see langword="true" />, if <see cref="T:System.Data.DataRelation" /> objects are nested; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00008F0A File Offset: 0x0000710A
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00008F18 File Offset: 0x00007118
		[DefaultValue(false)]
		public virtual bool Nested
		{
			get
			{
				this.CheckStateForProperty();
				return this._nested;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataRelation.set_Nested|API> {0}, {1}", this.ObjectID, value);
				try
				{
					if (this._nested != value)
					{
						if (this._dataSet != null && value)
						{
							if (this.ChildTable.IsNamespaceInherited())
							{
								this.CheckNamespaceValidityForNestedRelations(this.ParentTable.Namespace);
							}
							ForeignKeyConstraint foreignKeyConstraint = this.ChildTable.Constraints.FindForeignKeyConstraint(this.ChildKey.ColumnsReference, this.ParentKey.ColumnsReference);
							if (foreignKeyConstraint != null)
							{
								foreignKeyConstraint.CheckConstraint();
							}
							this.ValidateMultipleNestedRelations();
						}
						if (!value && this._parentKey.ColumnsReference[0].ColumnMapping == MappingType.Hidden)
						{
							throw ExceptionBuilder.RelationNestedReadOnly();
						}
						if (value)
						{
							this.ParentTable.Columns.RegisterColumnName(this.ChildTable.TableName, null);
						}
						else
						{
							this.ParentTable.Columns.UnregisterName(this.ChildTable.TableName);
						}
						this.RaisePropertyChanging("Nested");
						if (value)
						{
							this.CheckNestedRelations();
							if (this.DataSet != null)
							{
								if (this.ParentTable == this.ChildTable)
								{
									foreach (object obj in this.ChildTable.Rows)
									{
										((DataRow)obj).CheckForLoops(this);
									}
									if (this.ChildTable.DataSet != null && string.Compare(this.ChildTable.TableName, this.ChildTable.DataSet.DataSetName, true, this.ChildTable.DataSet.Locale) == 0)
									{
										throw ExceptionBuilder.DatasetConflictingName(this._dataSet.DataSetName);
									}
									this.ChildTable._fNestedInDataset = false;
								}
								else
								{
									foreach (object obj2 in this.ChildTable.Rows)
									{
										((DataRow)obj2).GetParentRow(this);
									}
								}
							}
							DataTable parentTable = this.ParentTable;
							int elementColumnCount = parentTable.ElementColumnCount;
							parentTable.ElementColumnCount = elementColumnCount + 1;
						}
						else
						{
							DataTable parentTable2 = this.ParentTable;
							int elementColumnCount = parentTable2.ElementColumnCount;
							parentTable2.ElementColumnCount = elementColumnCount - 1;
						}
						this._nested = value;
						this.ChildTable.CacheNestedParent();
						if (value && string.IsNullOrEmpty(this.ChildTable.Namespace) && (this.ChildTable.NestedParentsCount > 1 || (this.ChildTable.NestedParentsCount > 0 && !this.ChildTable.DataSet.Relations.Contains(this.RelationName))))
						{
							string text = null;
							foreach (object obj3 in this.ChildTable.ParentRelations)
							{
								DataRelation dataRelation = (DataRelation)obj3;
								if (dataRelation.Nested)
								{
									if (text == null)
									{
										text = dataRelation.ParentTable.Namespace;
									}
									else if (string.Compare(text, dataRelation.ParentTable.Namespace, StringComparison.Ordinal) != 0)
									{
										this._nested = false;
										throw ExceptionBuilder.InvalidParentNamespaceinNestedRelation(this.ChildTable.TableName);
									}
								}
							}
							if (this.CheckMultipleNested && this.ChildTable._tableNamespace != null && this.ChildTable._tableNamespace.Length == 0)
							{
								throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
							}
							this.ChildTable._tableNamespace = null;
						}
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.UniqueConstraint" /> that guarantees that values in the parent column of a <see cref="T:System.Data.DataRelation" /> are unique.</summary>
		/// <returns>A <see cref="T:System.Data.UniqueConstraint" /> that makes sure that values in a parent column are unique.</returns>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000092FC File Offset: 0x000074FC
		public virtual UniqueConstraint ParentKeyConstraint
		{
			get
			{
				this.CheckStateForProperty();
				return this._parentKeyConstraint;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000930A File Offset: 0x0000750A
		internal void SetParentKeyConstraint(UniqueConstraint value)
		{
			this._parentKeyConstraint = value;
		}

		/// <summary>Gets the <see cref="T:System.Data.ForeignKeyConstraint" /> for the relation.</summary>
		/// <returns>A <see langword="ForeignKeyConstraint" />.</returns>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00009313 File Offset: 0x00007513
		public virtual ForeignKeyConstraint ChildKeyConstraint
		{
			get
			{
				this.CheckStateForProperty();
				return this._childKeyConstraint;
			}
		}

		/// <summary>Gets the collection that stores customized properties.</summary>
		/// <returns>A <see cref="T:System.Data.PropertyCollection" /> that contains customized properties.</returns>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00009324 File Offset: 0x00007524
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			get
			{
				PropertyCollection result;
				if ((result = this._extendedProperties) == null)
				{
					result = (this._extendedProperties = new PropertyCollection());
				}
				return result;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00009349 File Offset: 0x00007549
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00009351 File Offset: 0x00007551
		internal bool CheckMultipleNested
		{
			get
			{
				return this._checkMultipleNested;
			}
			set
			{
				this._checkMultipleNested = value;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000935A File Offset: 0x0000755A
		internal void SetChildKeyConstraint(ForeignKeyConstraint value)
		{
			this._childKeyConstraint = value;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00009364 File Offset: 0x00007564
		internal void CheckState()
		{
			if (this._dataSet == null)
			{
				this._parentKey.CheckState();
				this._childKey.CheckState();
				if (this._parentKey.Table.DataSet != this._childKey.Table.DataSet)
				{
					throw ExceptionBuilder.RelationDataSetMismatch();
				}
				if (this._childKey.ColumnsEqual(this._parentKey))
				{
					throw ExceptionBuilder.KeyColumnsIdentical();
				}
				for (int i = 0; i < this._parentKey.ColumnsReference.Length; i++)
				{
					if (this._parentKey.ColumnsReference[i].DataType != this._childKey.ColumnsReference[i].DataType || (this._parentKey.ColumnsReference[i].DataType == typeof(DateTime) && this._parentKey.ColumnsReference[i].DateTimeMode != this._childKey.ColumnsReference[i].DateTimeMode && (this._parentKey.ColumnsReference[i].DateTimeMode & this._childKey.ColumnsReference[i].DateTimeMode) != DataSetDateTime.Unspecified))
					{
						throw ExceptionBuilder.ColumnsTypeMismatch();
					}
				}
			}
		}

		/// <summary>This method supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <exception cref="T:System.Data.DataException">The parent and child tables belong to different <see cref="T:System.Data.DataSet" /> objects.-Or- One or more pairs of parent and child <see cref="T:System.Data.DataColumn" /> objects have mismatched data types.-Or- The parent and child <see cref="T:System.Data.DataColumn" /> objects are identical. </exception>
		// Token: 0x060002B4 RID: 692 RVA: 0x00009494 File Offset: 0x00007694
		protected void CheckStateForProperty()
		{
			try
			{
				this.CheckState();
			}
			catch (Exception ex) when (ADP.IsCatchableExceptionType(ex))
			{
				throw ExceptionBuilder.BadObjectPropertyAccess(ex.Message);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000094E0 File Offset: 0x000076E0
		private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, string, bool>("<ds.DataRelation.Create|INFO> {0}, relationName='{1}', createConstraints={2}", this.ObjectID, relationName, createConstraints);
			try
			{
				this._parentKey = new DataKey(parentColumns, true);
				this._childKey = new DataKey(childColumns, true);
				if (parentColumns.Length != childColumns.Length)
				{
					throw ExceptionBuilder.KeyLengthMismatch();
				}
				for (int i = 0; i < parentColumns.Length; i++)
				{
					if (parentColumns[i].Table.DataSet == null || childColumns[i].Table.DataSet == null)
					{
						throw ExceptionBuilder.ParentOrChildColumnsDoNotHaveDataSet();
					}
				}
				this.CheckState();
				this._relationName = ((relationName == null) ? "" : relationName);
				this._createConstraints = createConstraints;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000095A0 File Offset: 0x000077A0
		internal DataRelation Clone(DataSet destination)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataRelation.Clone|INFO> {0}, destination={1}", this.ObjectID, (destination != null) ? destination.ObjectID : 0);
			DataTable dataTable = destination.Tables[this.ParentTable.TableName, this.ParentTable.Namespace];
			DataTable dataTable2 = destination.Tables[this.ChildTable.TableName, this.ChildTable.Namespace];
			int num = this._parentKey.ColumnsReference.Length;
			DataColumn[] array = new DataColumn[num];
			DataColumn[] array2 = new DataColumn[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = dataTable.Columns[this.ParentKey.ColumnsReference[i].ColumnName];
				array2[i] = dataTable2.Columns[this.ChildKey.ColumnsReference[i].ColumnName];
			}
			DataRelation dataRelation = new DataRelation(this._relationName, array, array2, false);
			dataRelation.CheckMultipleNested = false;
			dataRelation.Nested = this.Nested;
			dataRelation.CheckMultipleNested = true;
			if (this._extendedProperties != null)
			{
				foreach (object key in this._extendedProperties.Keys)
				{
					dataRelation.ExtendedProperties[key] = this._extendedProperties[key];
				}
			}
			return dataRelation;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="pcevent">Parameter reference.</param>
		// Token: 0x060002B7 RID: 695 RVA: 0x0000972C File Offset: 0x0000792C
		protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
			if (this.PropertyChanging != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelation.OnPropertyChanging|INFO> {0}", this.ObjectID);
				this.PropertyChanging(this, pcevent);
			}
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="name">Parameter reference.</param>
		// Token: 0x060002B8 RID: 696 RVA: 0x00009758 File Offset: 0x00007958
		protected internal void RaisePropertyChanging(string name)
		{
			this.OnPropertyChanging(new PropertyChangedEventArgs(name));
		}

		/// <summary>Gets the <see cref="P:System.Data.DataRelation.RelationName" />, if one exists.</summary>
		/// <returns>The value of the <see cref="P:System.Data.DataRelation.RelationName" /> property.</returns>
		// Token: 0x060002B9 RID: 697 RVA: 0x00009766 File Offset: 0x00007966
		public override string ToString()
		{
			return this.RelationName;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00009770 File Offset: 0x00007970
		internal void ValidateMultipleNestedRelations()
		{
			if (!this.Nested || !this.CheckMultipleNested)
			{
				return;
			}
			if (this.ChildTable.NestedParentRelations.Length != 0)
			{
				DataColumn[] childColumns = this.ChildColumns;
				if (childColumns.Length != 1 || !this.IsAutoGenerated(childColumns[0]))
				{
					throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
				}
				if (!XmlTreeGen.AutoGenerated(this))
				{
					throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
				}
				foreach (object obj in this.ChildTable.Constraints)
				{
					Constraint constraint = (Constraint)obj;
					if (constraint is ForeignKeyConstraint)
					{
						if (!XmlTreeGen.AutoGenerated((ForeignKeyConstraint)constraint, true))
						{
							throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
						}
					}
					else if (!XmlTreeGen.AutoGenerated((UniqueConstraint)constraint))
					{
						throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
					}
				}
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00009870 File Offset: 0x00007A70
		private bool IsAutoGenerated(DataColumn col)
		{
			if (col.ColumnMapping != MappingType.Hidden)
			{
				return false;
			}
			if (col.DataType != typeof(int))
			{
				return false;
			}
			string text = col.Table.TableName + "_Id";
			if (col.ColumnName == text || col.ColumnName == text + "_0")
			{
				return true;
			}
			text = this.ParentColumnsReference[0].Table.TableName + "_Id";
			return col.ColumnName == text || col.ColumnName == text + "_0";
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00009925 File Offset: 0x00007B25
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		// Token: 0x04000063 RID: 99
		private DataSet _dataSet;

		// Token: 0x04000064 RID: 100
		internal PropertyCollection _extendedProperties;

		// Token: 0x04000065 RID: 101
		internal string _relationName;

		// Token: 0x04000066 RID: 102
		private DataKey _childKey;

		// Token: 0x04000067 RID: 103
		private DataKey _parentKey;

		// Token: 0x04000068 RID: 104
		private UniqueConstraint _parentKeyConstraint;

		// Token: 0x04000069 RID: 105
		private ForeignKeyConstraint _childKeyConstraint;

		// Token: 0x0400006A RID: 106
		internal string[] _parentColumnNames;

		// Token: 0x0400006B RID: 107
		internal string[] _childColumnNames;

		// Token: 0x0400006C RID: 108
		internal string _parentTableName;

		// Token: 0x0400006D RID: 109
		internal string _childTableName;

		// Token: 0x0400006E RID: 110
		internal string _parentTableNamespace;

		// Token: 0x0400006F RID: 111
		internal string _childTableNamespace;

		// Token: 0x04000070 RID: 112
		internal bool _nested;

		// Token: 0x04000071 RID: 113
		internal bool _createConstraints;

		// Token: 0x04000072 RID: 114
		private bool _checkMultipleNested;

		// Token: 0x04000073 RID: 115
		private static int s_objectTypeCount;

		// Token: 0x04000074 RID: 116
		private readonly int _objectID;

		// Token: 0x04000075 RID: 117
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanging;
	}
}
