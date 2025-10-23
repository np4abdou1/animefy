using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000070 RID: 112
	internal sealed class Block2 : BlockExpression
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0000F6B3 File Offset: 0x0000D8B3
		internal Block2(Expression arg0, Expression arg1)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000F6C9 File Offset: 0x0000D8C9
		internal override Expression GetExpression(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<Expression>(this._arg0);
			}
			if (index != 1)
			{
				throw Error.ArgumentOutOfRange("index");
			}
			return this._arg1;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
		internal override int ExpressionCount
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return BlockExpression.ReturnReadOnlyExpressions(this, ref this._arg0);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000F702 File Offset: 0x0000D902
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return new Block2(args[0], args[1]);
		}

		// Token: 0x040000CE RID: 206
		private object _arg0;

		// Token: 0x040000CF RID: 207
		private readonly Expression _arg1;
	}
}
