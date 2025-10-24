using System;
using System.Collections.Generic;

namespace System.Data
{
	// Token: 0x02000054 RID: 84
	internal sealed class AggregateNode : ExpressionNode
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x0001D8B1 File Offset: 0x0001BAB1
		internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName) : this(table, aggregateType, columnName, true, null)
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
		internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) : base(table)
		{
			this._aggregate = (Aggregate)aggregateType;
			if (aggregateType == FunctionId.Sum)
			{
				this._type = AggregateType.Sum;
			}
			else if (aggregateType == FunctionId.Avg)
			{
				this._type = AggregateType.Mean;
			}
			else if (aggregateType == FunctionId.Min)
			{
				this._type = AggregateType.Min;
			}
			else if (aggregateType == FunctionId.Max)
			{
				this._type = AggregateType.Max;
			}
			else if (aggregateType == FunctionId.Count)
			{
				this._type = AggregateType.Count;
			}
			else if (aggregateType == FunctionId.Var)
			{
				this._type = AggregateType.Var;
			}
			else
			{
				if (aggregateType != FunctionId.StDev)
				{
					throw ExprException.UndefinedFunction(Function.s_functionName[(int)aggregateType]);
				}
				this._type = AggregateType.StDev;
			}
			this._local = local;
			this._relationName = relationName;
			this._columnName = columnName;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001D964 File Offset: 0x0001BB64
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
			base.BindTable(table);
			if (table == null)
			{
				throw ExprException.AggregateUnbound(this.ToString());
			}
			if (this._local)
			{
				this._relation = null;
			}
			else
			{
				DataRelationCollection childRelations = table.ChildRelations;
				if (this._relationName == null)
				{
					if (childRelations.Count > 1)
					{
						throw ExprException.UnresolvedRelation(table.TableName, this.ToString());
					}
					if (childRelations.Count != 1)
					{
						throw ExprException.AggregateUnbound(this.ToString());
					}
					this._relation = childRelations[0];
				}
				else
				{
					this._relation = childRelations[this._relationName];
				}
			}
			this._childTable = ((this._relation == null) ? table : this._relation.ChildTable);
			this._column = this._childTable.Columns[this._columnName];
			if (this._column == null)
			{
				throw ExprException.UnboundName(this._columnName);
			}
			int i;
			for (i = 0; i < list.Count; i++)
			{
				DataColumn dataColumn = list[i];
				if (this._column == dataColumn)
				{
					break;
				}
			}
			if (i >= list.Count)
			{
				list.Add(this._column);
			}
			AggregateNode.Bind(this._relation, list);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001DA88 File Offset: 0x0001BC88
		internal static void Bind(DataRelation relation, List<DataColumn> list)
		{
			if (relation != null)
			{
				foreach (DataColumn item in relation.ChildColumnsReference)
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
				foreach (DataColumn item2 in relation.ParentColumnsReference)
				{
					if (!list.Contains(item2))
					{
						list.Add(item2);
					}
				}
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001DAEA File Offset: 0x0001BCEA
		internal override object Eval()
		{
			return this.Eval(null, DataRowVersion.Default);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			if (this._childTable == null)
			{
				throw ExprException.AggregateUnbound(this.ToString());
			}
			DataRow[] array;
			if (this._local)
			{
				array = new DataRow[this._childTable.Rows.Count];
				this._childTable.Rows.CopyTo(array, 0);
			}
			else
			{
				if (row == null)
				{
					throw ExprException.EvalNoContext();
				}
				if (this._relation == null)
				{
					throw ExprException.AggregateUnbound(this.ToString());
				}
				array = row.GetChildRows(this._relation, version);
			}
			if (version == DataRowVersion.Proposed)
			{
				version = DataRowVersion.Default;
			}
			List<int> list = new List<int>();
			int i = 0;
			while (i < array.Length)
			{
				if (array[i].RowState == DataRowState.Deleted)
				{
					if (DataRowAction.Rollback == array[i]._action)
					{
						version = DataRowVersion.Original;
						goto IL_BF;
					}
				}
				else if (DataRowAction.Rollback != array[i]._action || array[i].RowState != DataRowState.Added)
				{
					goto IL_BF;
				}
				IL_E1:
				i++;
				continue;
				IL_BF:
				if (version != DataRowVersion.Original || array[i]._oldRecord != -1)
				{
					list.Add(array[i].GetRecordFromVersion(version));
					goto IL_E1;
				}
				goto IL_E1;
			}
			int[] records = list.ToArray();
			return this._column.GetAggregateValue(records, this._type);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001DC09 File Offset: 0x0001BE09
		internal override object Eval(int[] records)
		{
			if (this._childTable == null)
			{
				throw ExprException.AggregateUnbound(this.ToString());
			}
			if (!this._local)
			{
				throw ExprException.ComputeNotAggregate(this.ToString());
			}
			return this._column.GetAggregateValue(records, this._type);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool IsConstant()
		{
			return false;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001DC45 File Offset: 0x0001BE45
		internal override bool IsTableConstant()
		{
			return this._local;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001DC45 File Offset: 0x0001BE45
		internal override bool HasLocalAggregate()
		{
			return this._local;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001DC4D File Offset: 0x0001BE4D
		internal override bool HasRemoteAggregate()
		{
			return !this._local;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001DC58 File Offset: 0x0001BE58
		internal override bool DependsOn(DataColumn column)
		{
			return this._column == column || (this._column.Computed && this._column.DataExpression.DependsOn(column));
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
		internal override ExpressionNode Optimize()
		{
			return this;
		}

		// Token: 0x0400019B RID: 411
		private readonly AggregateType _type;

		// Token: 0x0400019C RID: 412
		private readonly Aggregate _aggregate;

		// Token: 0x0400019D RID: 413
		private readonly bool _local;

		// Token: 0x0400019E RID: 414
		private readonly string _relationName;

		// Token: 0x0400019F RID: 415
		private readonly string _columnName;

		// Token: 0x040001A0 RID: 416
		private DataTable _childTable;

		// Token: 0x040001A1 RID: 417
		private DataColumn _column;

		// Token: 0x040001A2 RID: 418
		private DataRelation _relation;
	}
}
