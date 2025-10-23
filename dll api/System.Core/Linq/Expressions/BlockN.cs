using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000074 RID: 116
	internal class BlockN : BlockExpression
	{
		// Token: 0x06000339 RID: 825 RVA: 0x0000F8D2 File Offset: 0x0000DAD2
		internal BlockN(IReadOnlyList<Expression> expressions)
		{
			this._expressions = expressions;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000F8E1 File Offset: 0x0000DAE1
		internal override Expression GetExpression(int index)
		{
			return this._expressions[index];
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000F8EF File Offset: 0x0000DAEF
		internal override int ExpressionCount
		{
			get
			{
				return this._expressions.Count;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return ExpressionUtils.ReturnReadOnly<Expression>(ref this._expressions);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000F909 File Offset: 0x0000DB09
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return new BlockN(args);
		}

		// Token: 0x040000DC RID: 220
		private IReadOnlyList<Expression> _expressions;
	}
}
