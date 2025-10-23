﻿using System;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data
{
	/// <summary>Represents an action restriction enforced on a set of columns in a primary key/foreign key relationship when a value or row is either deleted or updated.</summary>
	// Token: 0x0200006E RID: 110
	[DefaultProperty("ConstraintName")]
	public class ForeignKeyConstraint : Constraint
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> class with the specified parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="parentColumn">The parent <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <param name="childColumn">The child <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.-Or - The tables don't belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000785 RID: 1925 RVA: 0x000246C0 File Offset: 0x000228C0
		public ForeignKeyConstraint(DataColumn parentColumn, DataColumn childColumn) : this(null, parentColumn, childColumn)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> class with the specified name, parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="constraintName">The name of the constraint. </param>
		/// <param name="parentColumn">The parent <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <param name="childColumn">The child <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.-Or - The tables don't belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000786 RID: 1926 RVA: 0x000246CC File Offset: 0x000228CC
		public ForeignKeyConstraint(string constraintName, DataColumn parentColumn, DataColumn childColumn)
		{
			this._deleteRule = Rule.Cascade;
			this._updateRule = Rule.Cascade;
			base..ctor();
			DataColumn[] parentColumns = new DataColumn[]
			{
				parentColumn
			};
			DataColumn[] childColumns = new DataColumn[]
			{
				childColumn
			};
			this.Create(constraintName, parentColumns, childColumns);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> class with the specified arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.-Or - The tables don't belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000787 RID: 1927 RVA: 0x0002470C File Offset: 0x0002290C
		public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) : this(null, parentColumns, childColumns)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> class with the specified name, and arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="constraintName">The name of the <see cref="T:System.Data.ForeignKeyConstraint" />. If <see langword="null" /> or empty string, a default name will be given when added to the constraints collection. </param>
		/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> in the constraint. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.-Or - The tables don't belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000788 RID: 1928 RVA: 0x00024717 File Offset: 0x00022917
		public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
			this._deleteRule = Rule.Cascade;
			this._updateRule = Rule.Cascade;
			base..ctor();
			this.Create(constraintName, parentColumns, childColumns);
		}

		/// <summary>This constructor is provided for design time support in the Visual Studio  environment. <see cref="T:System.Data.ForeignKeyConstraint" /> objects created by using this constructor must then be added to the collection via <see cref="M:System.Data.ConstraintCollection.AddRange(System.Data.Constraint[])" />. Tables and columns with the specified names must exist at the time the method is called, or if <see cref="M:System.Data.DataTable.BeginInit" /> has been called prior to calling this constructor, the tables and columns with the specified names must exist at the time that <see cref="M:System.Data.DataTable.EndInit" /> is called.</summary>
		/// <param name="constraintName">The name of the constraint. </param>
		/// <param name="parentTableName">The name of the parent <see cref="T:System.Data.DataTable" /> that contains parent <see cref="T:System.Data.DataColumn" /> objects in the constraint. </param>
		/// <param name="parentColumnNames">An array of the names of parent <see cref="T:System.Data.DataColumn" /> objects in the constraint. </param>
		/// <param name="childColumnNames">An array of the names of child <see cref="T:System.Data.DataColumn" /> objects in the constraint. </param>
		/// <param name="acceptRejectRule">One of the <see cref="T:System.Data.AcceptRejectRule" /> values. Possible values include <see langword="None" />, <see langword="Cascade" />, and <see langword="Default" />. </param>
		/// <param name="deleteRule">One of the <see cref="T:System.Data.Rule" /> values to use when a row is deleted. The default is <see langword="Cascade" />. Possible values include: <see langword="None" />, <see langword="Cascade" />, <see langword="SetNull" />, <see langword="SetDefault" />, and <see langword="Default" />. </param>
		/// <param name="updateRule">One of the <see cref="T:System.Data.Rule" /> values to use when a row is updated. The default is <see langword="Cascade" />. Possible values include: <see langword="None" />, <see langword="Cascade" />, <see langword="SetNull" />, <see langword="SetDefault" />, and <see langword="Default" />. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.-Or - The tables don't belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x06000789 RID: 1929 RVA: 0x00024738 File Offset: 0x00022938
		[Browsable(false)]
		public ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule)
		{
			this._deleteRule = Rule.Cascade;
			this._updateRule = Rule.Cascade;
			base..ctor();
			this._constraintName = constraintName;
			this._parentColumnNames = parentColumnNames;
			this._childColumnNames = childColumnNames;
			this._parentTableName = parentTableName;
			this._acceptRejectRule = acceptRejectRule;
			this._deleteRule = deleteRule;
			this._updateRule = updateRule;
		}

		/// <summary>This constructor is provided for design time support in the Visual Studio  environment. <see cref="T:System.Data.ForeignKeyConstraint" /> objects created by using this constructor must then be added to the collection via <see cref="M:System.Data.ConstraintCollection.AddRange(System.Data.Constraint[])" />. Tables and columns with the specified names must exist at the time the method is called, or if <see cref="M:System.Data.DataTable.BeginInit" /> has been called prior to calling this constructor, the tables and columns with the specified names must exist at the time that <see cref="M:System.Data.DataTable.EndInit" /> is called.</summary>
		/// <param name="constraintName">The name of the constraint. </param>
		/// <param name="parentTableName">The name of the parent <see cref="T:System.Data.DataTable" /> that contains parent <see cref="T:System.Data.DataColumn" /> objects in the constraint. </param>
		/// <param name="parentTableNamespace">The name of the <see cref="P:System.Data.DataTable.Namespace" />. </param>
		/// <param name="parentColumnNames">An array of the names of parent <see cref="T:System.Data.DataColumn" /> objects in the constraint. </param>
		/// <param name="childColumnNames">An array of the names of child <see cref="T:System.Data.DataColumn" /> objects in the constraint. </param>
		/// <param name="acceptRejectRule">One of the <see cref="T:System.Data.AcceptRejectRule" /> values. Possible values include <see langword="None" />, <see langword="Cascade" />, and <see langword="Default" />. </param>
		/// <param name="deleteRule">One of the <see cref="T:System.Data.Rule" /> values to use when a row is deleted. The default is <see langword="Cascade" />. Possible values include: <see langword="None" />, <see langword="Cascade" />, <see langword="SetNull" />, <see langword="SetDefault" />, and <see langword="Default" />. </param>
		/// <param name="updateRule">One of the <see cref="T:System.Data.Rule" /> values to use when a row is updated. The default is <see langword="Cascade" />. Possible values include: <see langword="None" />, <see langword="Cascade" />, <see langword="SetNull" />, <see langword="SetDefault" />, and <see langword="Default" />. </param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />. </exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.-Or - The tables don't belong to the same <see cref="T:System.Data.DataSet" />. </exception>
		// Token: 0x0600078A RID: 1930 RVA: 0x00024790 File Offset: 0x00022990
		[Browsable(false)]
		public ForeignKeyConstraint(string constraintName, string parentTableName, string parentTableNamespace, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule)
		{
			this._deleteRule = Rule.Cascade;
			this._updateRule = Rule.Cascade;
			base..ctor();
			this._constraintName = constraintName;
			this._parentColumnNames = parentColumnNames;
			this._childColumnNames = childColumnNames;
			this._parentTableName = parentTableName;
			this._parentTableNamespace = parentTableNamespace;
			this._acceptRejectRule = acceptRejectRule;
			this._deleteRule = deleteRule;
			this._updateRule = updateRule;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x000247EE File Offset: 0x000229EE
		internal DataKey ChildKey
		{
			get
			{
				base.CheckStateForProperty();
				return this._childKey;
			}
		}

		/// <summary>Gets the child columns of this constraint.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that are the child columns of the constraint.</returns>
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x000247FC File Offset: 0x000229FC
		[ReadOnly(true)]
		public virtual DataColumn[] Columns
		{
			get
			{
				base.CheckStateForProperty();
				return this._childKey.ToArray();
			}
		}

		/// <summary>Gets the child table of this constraint.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> that is the child table in the constraint.</returns>
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0002480F File Offset: 0x00022A0F
		[ReadOnly(true)]
		public override DataTable Table
		{
			get
			{
				base.CheckStateForProperty();
				return this._childKey.Table;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00024822 File Offset: 0x00022A22
		internal string[] ParentColumnNames
		{
			get
			{
				return this._parentKey.GetColumnNames();
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0002482F File Offset: 0x00022A2F
		internal string[] ChildColumnNames
		{
			get
			{
				return this._childKey.GetColumnNames();
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0002483C File Offset: 0x00022A3C
		internal override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
			if (this.Table != constraints.Table)
			{
				throw ExceptionBuilder.ConstraintAddFailed(constraints.Table);
			}
			if (this.Table.Locale.LCID != this.RelatedTable.Locale.LCID || this.Table.CaseSensitive != this.RelatedTable.CaseSensitive)
			{
				throw ExceptionBuilder.CaseLocaleMismatch();
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002317 File Offset: 0x00000517
		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
		{
			return true;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000248A4 File Offset: 0x00022AA4
		internal bool IsKeyNull(object[] values)
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

		// Token: 0x06000793 RID: 1939 RVA: 0x000248CC File Offset: 0x00022ACC
		internal override bool IsConstraintViolated()
		{
			Index sortIndex = this._childKey.GetSortIndex();
			object[] uniqueKeyValues = sortIndex.GetUniqueKeyValues();
			bool result = false;
			Index sortIndex2 = this._parentKey.GetSortIndex();
			foreach (object[] array in uniqueKeyValues)
			{
				if (!this.IsKeyNull(array) && !sortIndex2.IsKeyInIndex(array))
				{
					DataRow[] rows = sortIndex.GetRows(sortIndex.FindRecords(array));
					string rowError = SR.Format("ForeignKeyConstraint {0} requires the child key values ({1}) to exist in the parent table.", this.ConstraintName, ExceptionBuilder.KeysToString(array));
					for (int j = 0; j < rows.Length; j++)
					{
						rows[j].RowError = rowError;
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00024978 File Offset: 0x00022B78
		internal override bool CanEnableConstraint()
		{
			if (this.Table.DataSet == null || !this.Table.DataSet.EnforceConstraints)
			{
				return true;
			}
			object[] uniqueKeyValues = this._childKey.GetSortIndex().GetUniqueKeyValues();
			Index sortIndex = this._parentKey.GetSortIndex();
			foreach (object[] array in uniqueKeyValues)
			{
				if (!this.IsKeyNull(array) && !sortIndex.IsKeyInIndex(array))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000249F0 File Offset: 0x00022BF0
		internal void CascadeCommit(DataRow row)
		{
			if (row.RowState == DataRowState.Detached)
			{
				return;
			}
			if (this._acceptRejectRule == AcceptRejectRule.Cascade)
			{
				Index sortIndex = this._childKey.GetSortIndex((row.RowState == DataRowState.Deleted) ? DataViewRowState.Deleted : DataViewRowState.CurrentRows);
				object[] keyValues = row.GetKeyValues(this._parentKey, (row.RowState == DataRowState.Deleted) ? DataRowVersion.Original : DataRowVersion.Default);
				if (this.IsKeyNull(keyValues))
				{
					return;
				}
				Range range = sortIndex.FindRecords(keyValues);
				if (!range.IsNull)
				{
					foreach (DataRow dataRow in sortIndex.GetRows(range))
					{
						if (DataRowState.Detached != dataRow.RowState && !dataRow._inCascade)
						{
							dataRow.AcceptChanges();
						}
					}
				}
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00024AA4 File Offset: 0x00022CA4
		internal void CascadeDelete(DataRow row)
		{
			if (-1 == row._newRecord)
			{
				return;
			}
			object[] keyValues = row.GetKeyValues(this._parentKey, DataRowVersion.Current);
			if (this.IsKeyNull(keyValues))
			{
				return;
			}
			Index sortIndex = this._childKey.GetSortIndex();
			switch (this.DeleteRule)
			{
			case Rule.None:
				if (row.Table.DataSet.EnforceConstraints)
				{
					Range range = sortIndex.FindRecords(keyValues);
					if (!range.IsNull)
					{
						if (range.Count == 1 && sortIndex.GetRow(range.Min) == row)
						{
							return;
						}
						throw ExceptionBuilder.FailedCascadeDelete(this.ConstraintName);
					}
				}
				break;
			case Rule.Cascade:
			{
				object[] keyValues2 = row.GetKeyValues(this._parentKey, DataRowVersion.Default);
				Range range2 = sortIndex.FindRecords(keyValues2);
				if (!range2.IsNull)
				{
					foreach (DataRow dataRow in sortIndex.GetRows(range2))
					{
						if (!dataRow._inCascade)
						{
							dataRow.Table.DeleteRow(dataRow);
						}
					}
					return;
				}
				break;
			}
			case Rule.SetNull:
			{
				object[] array = new object[this._childKey.ColumnsReference.Length];
				for (int j = 0; j < this._childKey.ColumnsReference.Length; j++)
				{
					array[j] = DBNull.Value;
				}
				Range range3 = sortIndex.FindRecords(keyValues);
				if (!range3.IsNull)
				{
					DataRow[] rows2 = sortIndex.GetRows(range3);
					for (int k = 0; k < rows2.Length; k++)
					{
						if (row != rows2[k])
						{
							rows2[k].SetKeyValues(this._childKey, array);
						}
					}
					return;
				}
				break;
			}
			case Rule.SetDefault:
			{
				object[] array2 = new object[this._childKey.ColumnsReference.Length];
				for (int l = 0; l < this._childKey.ColumnsReference.Length; l++)
				{
					array2[l] = this._childKey.ColumnsReference[l].DefaultValue;
				}
				Range range4 = sortIndex.FindRecords(keyValues);
				if (!range4.IsNull)
				{
					DataRow[] rows3 = sortIndex.GetRows(range4);
					for (int m = 0; m < rows3.Length; m++)
					{
						if (row != rows3[m])
						{
							rows3[m].SetKeyValues(this._childKey, array2);
						}
					}
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00024CD0 File Offset: 0x00022ED0
		internal void CascadeRollback(DataRow row)
		{
			Index sortIndex = this._childKey.GetSortIndex((row.RowState == DataRowState.Deleted) ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows);
			object[] keyValues = row.GetKeyValues(this._parentKey, (row.RowState == DataRowState.Modified) ? DataRowVersion.Current : DataRowVersion.Default);
			if (this.IsKeyNull(keyValues))
			{
				return;
			}
			Range range = sortIndex.FindRecords(keyValues);
			if (this._acceptRejectRule == AcceptRejectRule.Cascade)
			{
				if (!range.IsNull)
				{
					DataRow[] rows = sortIndex.GetRows(range);
					for (int i = 0; i < rows.Length; i++)
					{
						if (!rows[i]._inCascade)
						{
							rows[i].RejectChanges();
						}
					}
					return;
				}
			}
			else if (row.RowState != DataRowState.Deleted && row.Table.DataSet.EnforceConstraints && !range.IsNull)
			{
				if (range.Count == 1 && sortIndex.GetRow(range.Min) == row)
				{
					return;
				}
				if (row.HasKeyChanged(this._parentKey))
				{
					throw ExceptionBuilder.FailedCascadeUpdate(this.ConstraintName);
				}
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00024DCC File Offset: 0x00022FCC
		internal void CascadeUpdate(DataRow row)
		{
			if (-1 == row._newRecord)
			{
				return;
			}
			object[] keyValues = row.GetKeyValues(this._parentKey, DataRowVersion.Current);
			if (!this.Table.DataSet._fInReadXml && this.IsKeyNull(keyValues))
			{
				return;
			}
			Index sortIndex = this._childKey.GetSortIndex();
			switch (this.UpdateRule)
			{
			case Rule.None:
				if (row.Table.DataSet.EnforceConstraints && !sortIndex.FindRecords(keyValues).IsNull)
				{
					throw ExceptionBuilder.FailedCascadeUpdate(this.ConstraintName);
				}
				break;
			case Rule.Cascade:
			{
				Range range = sortIndex.FindRecords(keyValues);
				if (!range.IsNull)
				{
					object[] keyValues2 = row.GetKeyValues(this._parentKey, DataRowVersion.Proposed);
					DataRow[] rows = sortIndex.GetRows(range);
					for (int i = 0; i < rows.Length; i++)
					{
						rows[i].SetKeyValues(this._childKey, keyValues2);
					}
					return;
				}
				break;
			}
			case Rule.SetNull:
			{
				object[] array = new object[this._childKey.ColumnsReference.Length];
				for (int j = 0; j < this._childKey.ColumnsReference.Length; j++)
				{
					array[j] = DBNull.Value;
				}
				Range range2 = sortIndex.FindRecords(keyValues);
				if (!range2.IsNull)
				{
					DataRow[] rows2 = sortIndex.GetRows(range2);
					for (int k = 0; k < rows2.Length; k++)
					{
						rows2[k].SetKeyValues(this._childKey, array);
					}
					return;
				}
				break;
			}
			case Rule.SetDefault:
			{
				object[] array2 = new object[this._childKey.ColumnsReference.Length];
				for (int l = 0; l < this._childKey.ColumnsReference.Length; l++)
				{
					array2[l] = this._childKey.ColumnsReference[l].DefaultValue;
				}
				Range range3 = sortIndex.FindRecords(keyValues);
				if (!range3.IsNull)
				{
					DataRow[] rows3 = sortIndex.GetRows(range3);
					for (int m = 0; m < rows3.Length; m++)
					{
						rows3[m].SetKeyValues(this._childKey, array2);
					}
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00024FD0 File Offset: 0x000231D0
		internal void CheckCanClearParentTable(DataTable table)
		{
			if (this.Table.DataSet.EnforceConstraints && this.Table.Rows.Count > 0)
			{
				throw ExceptionBuilder.FailedClearParentTable(table.TableName, this.ConstraintName, this.Table.TableName);
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002501F File Offset: 0x0002321F
		internal void CheckCanRemoveParentRow(DataRow row)
		{
			if (!this.Table.DataSet.EnforceConstraints)
			{
				return;
			}
			if (DataRelation.GetChildRows(this.ParentKey, this.ChildKey, row, DataRowVersion.Default).Length != 0)
			{
				throw ExceptionBuilder.RemoveParentRow(this);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00025058 File Offset: 0x00023258
		internal void CheckCascade(DataRow row, DataRowAction action)
		{
			if (row._inCascade)
			{
				return;
			}
			row._inCascade = true;
			try
			{
				if (action == DataRowAction.Change)
				{
					if (row.HasKeyChanged(this._parentKey))
					{
						this.CascadeUpdate(row);
					}
				}
				else if (action == DataRowAction.Delete)
				{
					this.CascadeDelete(row);
				}
				else if (action == DataRowAction.Commit)
				{
					this.CascadeCommit(row);
				}
				else if (action == DataRowAction.Rollback)
				{
					this.CascadeRollback(row);
				}
			}
			finally
			{
				row._inCascade = false;
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000250D8 File Offset: 0x000232D8
		internal override void CheckConstraint(DataRow childRow, DataRowAction action)
		{
			if ((action == DataRowAction.Change || action == DataRowAction.Add || action == DataRowAction.Rollback) && this.Table.DataSet != null && this.Table.DataSet.EnforceConstraints && childRow.HasKeyChanged(this._childKey))
			{
				DataRowVersion dataRowVersion = (action == DataRowAction.Rollback) ? DataRowVersion.Original : DataRowVersion.Current;
				object[] keyValues = childRow.GetKeyValues(this._childKey);
				if (childRow.HasVersion(dataRowVersion))
				{
					DataRow parentRow = DataRelation.GetParentRow(this.ParentKey, this.ChildKey, childRow, dataRowVersion);
					if (parentRow != null && parentRow._inCascade)
					{
						object[] keyValues2 = parentRow.GetKeyValues(this._parentKey, (action == DataRowAction.Rollback) ? dataRowVersion : DataRowVersion.Default);
						int num = childRow.Table.NewRecord();
						childRow.Table.SetKeyValues(this._childKey, keyValues2, num);
						if (this._childKey.RecordsEqual(childRow._tempRecord, num))
						{
							return;
						}
					}
				}
				object[] keyValues3 = childRow.GetKeyValues(this._childKey);
				if (!this.IsKeyNull(keyValues3) && !this._parentKey.GetSortIndex().IsKeyInIndex(keyValues3))
				{
					if (this._childKey.Table == this._parentKey.Table && childRow._tempRecord != -1)
					{
						int i;
						for (i = 0; i < keyValues3.Length; i++)
						{
							DataColumn dataColumn = this._parentKey.ColumnsReference[i];
							object value = dataColumn.ConvertValue(keyValues3[i]);
							if (dataColumn.CompareValueTo(childRow._tempRecord, value) != 0)
							{
								break;
							}
						}
						if (i == keyValues3.Length)
						{
							return;
						}
					}
					throw ExceptionBuilder.ForeignKeyViolation(this.ConstraintName, keyValues);
				}
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00025268 File Offset: 0x00023468
		private void NonVirtualCheckState()
		{
			if (this._DataSet == null)
			{
				this._parentKey.CheckState();
				this._childKey.CheckState();
				if (this._parentKey.Table.DataSet != this._childKey.Table.DataSet)
				{
					throw ExceptionBuilder.TablesInDifferentSets();
				}
				for (int i = 0; i < this._parentKey.ColumnsReference.Length; i++)
				{
					if (this._parentKey.ColumnsReference[i].DataType != this._childKey.ColumnsReference[i].DataType || (this._parentKey.ColumnsReference[i].DataType == typeof(DateTime) && this._parentKey.ColumnsReference[i].DateTimeMode != this._childKey.ColumnsReference[i].DateTimeMode && (this._parentKey.ColumnsReference[i].DateTimeMode & this._childKey.ColumnsReference[i].DateTimeMode) != DataSetDateTime.Unspecified))
					{
						throw ExceptionBuilder.ColumnsTypeMismatch();
					}
				}
				if (this._childKey.ColumnsEqual(this._parentKey))
				{
					throw ExceptionBuilder.KeyColumnsIdentical();
				}
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00025397 File Offset: 0x00023597
		internal override void CheckState()
		{
			this.NonVirtualCheckState();
		}

		/// <summary>Indicates the action that should take place across this constraint when <see cref="M:System.Data.DataTable.AcceptChanges" /> is invoked.</summary>
		/// <returns>One of the <see cref="T:System.Data.AcceptRejectRule" /> values. Possible values include <see langword="None" />, and <see langword="Cascade" />. The default is <see langword="None" />.</returns>
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0002539F File Offset: 0x0002359F
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x000253AD File Offset: 0x000235AD
		[DefaultValue(AcceptRejectRule.None)]
		public virtual AcceptRejectRule AcceptRejectRule
		{
			get
			{
				base.CheckStateForProperty();
				return this._acceptRejectRule;
			}
			set
			{
				if (value <= AcceptRejectRule.Cascade)
				{
					this._acceptRejectRule = value;
					return;
				}
				throw ADP.InvalidAcceptRejectRule(value);
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000253C1 File Offset: 0x000235C1
		internal override bool ContainsColumn(DataColumn column)
		{
			return this._parentKey.ContainsColumn(column) || this._childKey.ContainsColumn(column);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000253DF File Offset: 0x000235DF
		internal override Constraint Clone(DataSet destination)
		{
			return this.Clone(destination, false);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000253EC File Offset: 0x000235EC
		internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
		{
			int num;
			if (ignorNSforTableLookup)
			{
				num = destination.Tables.IndexOf(this.Table.TableName);
			}
			else
			{
				num = destination.Tables.IndexOf(this.Table.TableName, this.Table.Namespace, false);
			}
			if (num < 0)
			{
				return null;
			}
			DataTable dataTable = destination.Tables[num];
			if (ignorNSforTableLookup)
			{
				num = destination.Tables.IndexOf(this.RelatedTable.TableName);
			}
			else
			{
				num = destination.Tables.IndexOf(this.RelatedTable.TableName, this.RelatedTable.Namespace, false);
			}
			if (num < 0)
			{
				return null;
			}
			DataTable dataTable2 = destination.Tables[num];
			int num2 = this.Columns.Length;
			DataColumn[] array = new DataColumn[num2];
			DataColumn[] array2 = new DataColumn[num2];
			for (int i = 0; i < num2; i++)
			{
				DataColumn dataColumn = this.Columns[i];
				num = dataTable.Columns.IndexOf(dataColumn.ColumnName);
				if (num < 0)
				{
					return null;
				}
				array[i] = dataTable.Columns[num];
				dataColumn = this.RelatedColumnsReference[i];
				num = dataTable2.Columns.IndexOf(dataColumn.ColumnName);
				if (num < 0)
				{
					return null;
				}
				array2[i] = dataTable2.Columns[num];
			}
			ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint(this.ConstraintName, array2, array);
			foreignKeyConstraint.UpdateRule = this.UpdateRule;
			foreignKeyConstraint.DeleteRule = this.DeleteRule;
			foreignKeyConstraint.AcceptRejectRule = this.AcceptRejectRule;
			foreach (object key in base.ExtendedProperties.Keys)
			{
				foreignKeyConstraint.ExtendedProperties[key] = base.ExtendedProperties[key];
			}
			return foreignKeyConstraint;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000255D4 File Offset: 0x000237D4
		internal ForeignKeyConstraint Clone(DataTable destination)
		{
			int num = this.Columns.Length;
			DataColumn[] array = new DataColumn[num];
			DataColumn[] array2 = new DataColumn[num];
			for (int i = 0; i < num; i++)
			{
				DataColumn dataColumn = this.Columns[i];
				int num2 = destination.Columns.IndexOf(dataColumn.ColumnName);
				if (num2 < 0)
				{
					return null;
				}
				array[i] = destination.Columns[num2];
				dataColumn = this.RelatedColumnsReference[i];
				num2 = destination.Columns.IndexOf(dataColumn.ColumnName);
				if (num2 < 0)
				{
					return null;
				}
				array2[i] = destination.Columns[num2];
			}
			ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint(this.ConstraintName, array2, array);
			foreignKeyConstraint.UpdateRule = this.UpdateRule;
			foreignKeyConstraint.DeleteRule = this.DeleteRule;
			foreignKeyConstraint.AcceptRejectRule = this.AcceptRejectRule;
			foreach (object key in base.ExtendedProperties.Keys)
			{
				foreignKeyConstraint.ExtendedProperties[key] = base.ExtendedProperties[key];
			}
			return foreignKeyConstraint;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00025714 File Offset: 0x00023914
		private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
			if (parentColumns.Length == 0 || childColumns.Length == 0)
			{
				throw ExceptionBuilder.KeyLengthZero();
			}
			if (parentColumns.Length != childColumns.Length)
			{
				throw ExceptionBuilder.KeyLengthMismatch();
			}
			for (int i = 0; i < parentColumns.Length; i++)
			{
				if (parentColumns[i].Computed)
				{
					throw ExceptionBuilder.ExpressionInConstraint(parentColumns[i]);
				}
				if (childColumns[i].Computed)
				{
					throw ExceptionBuilder.ExpressionInConstraint(childColumns[i]);
				}
			}
			this._parentKey = new DataKey(parentColumns, true);
			this._childKey = new DataKey(childColumns, true);
			this.ConstraintName = relationName;
			this.NonVirtualCheckState();
		}

		/// <summary>Gets or sets the action that occurs across this constraint when a row is deleted.</summary>
		/// <returns>One of the <see cref="T:System.Data.Rule" /> values. The default is <see langword="Cascade" />.</returns>
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00025798 File Offset: 0x00023998
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x000257A6 File Offset: 0x000239A6
		[DefaultValue(Rule.Cascade)]
		public virtual Rule DeleteRule
		{
			get
			{
				base.CheckStateForProperty();
				return this._deleteRule;
			}
			set
			{
				if (value <= Rule.SetDefault)
				{
					this._deleteRule = value;
					return;
				}
				throw ADP.InvalidRule(value);
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Data.ForeignKeyConstraint" /> is identical to the specified object.</summary>
		/// <param name="key">The object to which this <see cref="T:System.Data.ForeignKeyConstraint" /> is compared. Two <see cref="T:System.Data.ForeignKeyConstraint" /> are equal if they constrain the same columns. </param>
		/// <returns>
		///     <see langword="true" />, if the objects are identical; otherwise, <see langword="false" />.</returns>
		// Token: 0x060007A8 RID: 1960 RVA: 0x000257BC File Offset: 0x000239BC
		public override bool Equals(object key)
		{
			if (!(key is ForeignKeyConstraint))
			{
				return false;
			}
			ForeignKeyConstraint foreignKeyConstraint = (ForeignKeyConstraint)key;
			return this.ParentKey.ColumnsEqual(foreignKeyConstraint.ParentKey) && this.ChildKey.ColumnsEqual(foreignKeyConstraint.ChildKey);
		}

		/// <summary>Gets the hash code of this instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060007A9 RID: 1961 RVA: 0x00025806 File Offset: 0x00023A06
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>The parent columns of this constraint.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that are the parent columns of the constraint.</returns>
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0002580E File Offset: 0x00023A0E
		[ReadOnly(true)]
		public virtual DataColumn[] RelatedColumns
		{
			get
			{
				base.CheckStateForProperty();
				return this._parentKey.ToArray();
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00025821 File Offset: 0x00023A21
		internal DataColumn[] RelatedColumnsReference
		{
			get
			{
				base.CheckStateForProperty();
				return this._parentKey.ColumnsReference;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00025834 File Offset: 0x00023A34
		internal DataKey ParentKey
		{
			get
			{
				base.CheckStateForProperty();
				return this._parentKey;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00025844 File Offset: 0x00023A44
		internal DataRelation FindParentRelation()
		{
			DataRelationCollection parentRelations = this.Table.ParentRelations;
			for (int i = 0; i < parentRelations.Count; i++)
			{
				if (parentRelations[i].ChildKeyConstraint == this)
				{
					return parentRelations[i];
				}
			}
			return null;
		}

		/// <summary>Gets the parent table of this constraint.</summary>
		/// <returns>The parent <see cref="T:System.Data.DataTable" /> of this constraint.</returns>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00025886 File Offset: 0x00023A86
		[ReadOnly(true)]
		public virtual DataTable RelatedTable
		{
			get
			{
				base.CheckStateForProperty();
				return this._parentKey.Table;
			}
		}

		/// <summary>Gets or sets the action that occurs across this constraint on when a row is updated.</summary>
		/// <returns>One of the <see cref="T:System.Data.Rule" /> values. The default is <see langword="Cascade" />.</returns>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00025899 File Offset: 0x00023A99
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x000258A7 File Offset: 0x00023AA7
		[DefaultValue(Rule.Cascade)]
		public virtual Rule UpdateRule
		{
			get
			{
				base.CheckStateForProperty();
				return this._updateRule;
			}
			set
			{
				if (value <= Rule.SetDefault)
				{
					this._updateRule = value;
					return;
				}
				throw ADP.InvalidRule(value);
			}
		}

		// Token: 0x04000258 RID: 600
		internal Rule _deleteRule;

		// Token: 0x04000259 RID: 601
		internal Rule _updateRule;

		// Token: 0x0400025A RID: 602
		internal AcceptRejectRule _acceptRejectRule;

		// Token: 0x0400025B RID: 603
		private DataKey _childKey;

		// Token: 0x0400025C RID: 604
		private DataKey _parentKey;

		// Token: 0x0400025D RID: 605
		internal string _constraintName;

		// Token: 0x0400025E RID: 606
		internal string[] _parentColumnNames;

		// Token: 0x0400025F RID: 607
		internal string[] _childColumnNames;

		// Token: 0x04000260 RID: 608
		internal string _parentTableName;

		// Token: 0x04000261 RID: 609
		internal string _parentTableNamespace;
	}
}
