using System;
using System.Collections.Generic;

namespace System.Data
{
	// Token: 0x02000069 RID: 105
	internal sealed class LookupNode : ExpressionNode
	{
		// Token: 0x06000750 RID: 1872 RVA: 0x00023CD3 File Offset: 0x00021ED3
		internal LookupNode(DataTable table, string columnName, string relationName) : base(table)
		{
			this._relationName = relationName;
			this._columnName = columnName;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00023CEC File Offset: 0x00021EEC
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
			base.BindTable(table);
			this._column = null;
			this._relation = null;
			if (table == null)
			{
				throw ExprException.ExpressionUnbound(this.ToString());
			}
			DataRelationCollection parentRelations = table.ParentRelations;
			if (this._relationName == null)
			{
				if (parentRelations.Count > 1)
				{
					throw ExprException.UnresolvedRelation(table.TableName, this.ToString());
				}
				this._relation = parentRelations[0];
			}
			else
			{
				this._relation = parentRelations[this._relationName];
			}
			if (this._relation == null)
			{
				throw ExprException.BindFailure(this._relationName);
			}
			DataTable parentTable = this._relation.ParentTable;
			this._column = parentTable.Columns[this._columnName];
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

		// Token: 0x06000752 RID: 1874 RVA: 0x00023DF6 File Offset: 0x00021FF6
		internal override object Eval()
		{
			throw ExprException.EvalNoContext();
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00023E00 File Offset: 0x00022000
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			if (this._column == null || this._relation == null)
			{
				throw ExprException.ExpressionUnbound(this.ToString());
			}
			DataRow parentRow = row.GetParentRow(this._relation, version);
			if (parentRow == null)
			{
				return DBNull.Value;
			}
			return parentRow[this._column, parentRow.HasVersion(version) ? version : DataRowVersion.Current];
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00022E42 File Offset: 0x00021042
		internal override object Eval(int[] recordNos)
		{
			throw ExprException.ComputeNotAggregate(this.ToString());
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool IsConstant()
		{
			return false;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool IsTableConstant()
		{
			return false;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool HasLocalAggregate()
		{
			return false;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool HasRemoteAggregate()
		{
			return false;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00023E5D File Offset: 0x0002205D
		internal override bool DependsOn(DataColumn column)
		{
			return this._column == column;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		internal override ExpressionNode Optimize()
		{
			return this;
		}

		// Token: 0x0400024C RID: 588
		private readonly string _relationName;

		// Token: 0x0400024D RID: 589
		private readonly string _columnName;

		// Token: 0x0400024E RID: 590
		private DataColumn _column;

		// Token: 0x0400024F RID: 591
		private DataRelation _relation;
	}
}
