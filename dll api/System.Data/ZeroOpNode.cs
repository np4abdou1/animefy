using System;
using System.Collections.Generic;

namespace System.Data
{
	// Token: 0x0200006D RID: 109
	internal sealed class ZeroOpNode : ExpressionNode
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x00024669 File Offset: 0x00022869
		internal ZeroOpNode(int op) : base(null)
		{
			this._op = op;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000057B2 File Offset: 0x000039B2
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0002467C File Offset: 0x0002287C
		internal override object Eval()
		{
			switch (this._op)
			{
			case 32:
				return DBNull.Value;
			case 33:
				return true;
			case 34:
				return false;
			default:
				return DBNull.Value;
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0002050A File Offset: 0x0001E70A
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return this.Eval();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0002050A File Offset: 0x0001E70A
		internal override object Eval(int[] recordNos)
		{
			return this.Eval();
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002317 File Offset: 0x00000517
		internal override bool IsConstant()
		{
			return true;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002317 File Offset: 0x00000517
		internal override bool IsTableConstant()
		{
			return true;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool HasLocalAggregate()
		{
			return false;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool HasRemoteAggregate()
		{
			return false;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		internal override ExpressionNode Optimize()
		{
			return this;
		}

		// Token: 0x04000257 RID: 599
		internal readonly int _op;
	}
}
