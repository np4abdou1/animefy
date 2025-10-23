using System;
using System.Collections.Generic;
using System.Data.Common;

namespace System.Data
{
	// Token: 0x0200006A RID: 106
	internal sealed class NameNode : ExpressionNode
	{
		// Token: 0x0600075B RID: 1883 RVA: 0x00023E6B File Offset: 0x0002206B
		internal NameNode(DataTable table, char[] text, int start, int pos) : base(table)
		{
			this._name = NameNode.ParseName(text, start, pos);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00023E83 File Offset: 0x00022083
		internal NameNode(DataTable table, string name) : base(table)
		{
			this._name = name;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00023E93 File Offset: 0x00022093
		internal override bool IsSqlColumn
		{
			get
			{
				return this._column.IsSqlType;
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00023EA0 File Offset: 0x000220A0
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
			base.BindTable(table);
			if (table == null)
			{
				throw ExprException.UnboundName(this._name);
			}
			try
			{
				this._column = table.Columns[this._name];
			}
			catch (Exception e)
			{
				this._found = false;
				if (!ADP.IsCatchableExceptionType(e))
				{
					throw;
				}
				throw ExprException.UnboundName(this._name);
			}
			if (this._column == null)
			{
				throw ExprException.UnboundName(this._name);
			}
			this._name = this._column.ColumnName;
			this._found = true;
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
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00023DF6 File Offset: 0x00021FF6
		internal override object Eval()
		{
			throw ExprException.EvalNoContext();
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00023F6C File Offset: 0x0002216C
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			if (!this._found)
			{
				throw ExprException.UnboundName(this._name);
			}
			if (row != null)
			{
				return this._column[row.GetRecordFromVersion(version)];
			}
			if (this.IsTableConstant())
			{
				return this._column.DataExpression.Evaluate();
			}
			throw ExprException.UnboundName(this._name);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00022E42 File Offset: 0x00021042
		internal override object Eval(int[] records)
		{
			throw ExprException.ComputeNotAggregate(this.ToString());
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool IsConstant()
		{
			return false;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00023FC7 File Offset: 0x000221C7
		internal override bool IsTableConstant()
		{
			return this._column != null && this._column.Computed && this._column.DataExpression.IsTableAggregate();
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00023FF0 File Offset: 0x000221F0
		internal override bool HasLocalAggregate()
		{
			return this._column != null && this._column.Computed && this._column.DataExpression.HasLocalAggregate();
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00024019 File Offset: 0x00022219
		internal override bool HasRemoteAggregate()
		{
			return this._column != null && this._column.Computed && this._column.DataExpression.HasRemoteAggregate();
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00024042 File Offset: 0x00022242
		internal override bool DependsOn(DataColumn column)
		{
			return this._column == column || (this._column.Computed && this._column.DataExpression.DependsOn(column));
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002050 File Offset: 0x00000250
		internal override ExpressionNode Optimize()
		{
			return this;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00024070 File Offset: 0x00022270
		internal static string ParseName(char[] text, int start, int pos)
		{
			char c = '\0';
			string text2 = string.Empty;
			int num = start;
			int num2 = pos;
			checked
			{
				if (text[start] == '`')
				{
					start++;
					pos--;
					c = '\\';
					text2 = "`";
				}
				else if (text[start] == '[')
				{
					start++;
					pos--;
					c = '\\';
					text2 = "]\\";
				}
			}
			if (c != '\0')
			{
				int num3 = start;
				for (int i = start; i < pos; i++)
				{
					if (text[i] == c && i + 1 < pos && text2.IndexOf(text[i + 1]) >= 0)
					{
						i++;
					}
					text[num3] = text[i];
					num3++;
				}
				pos = num3;
			}
			if (pos == start)
			{
				throw ExprException.InvalidName(new string(text, num, num2 - num));
			}
			return new string(text, start, pos - start);
		}

		// Token: 0x04000250 RID: 592
		internal string _name;

		// Token: 0x04000251 RID: 593
		internal bool _found;

		// Token: 0x04000252 RID: 594
		internal DataColumn _column;
	}
}
