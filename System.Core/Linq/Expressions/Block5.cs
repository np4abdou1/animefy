using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000073 RID: 115
	internal sealed class Block5 : BlockExpression
	{
		// Token: 0x06000334 RID: 820 RVA: 0x0000F820 File Offset: 0x0000DA20
		internal Block5(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
			this._arg4 = arg4;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000F850 File Offset: 0x0000DA50
		internal override Expression GetExpression(int index)
		{
			switch (index)
			{
			case 0:
				return ExpressionUtils.ReturnObject<Expression>(this._arg0);
			case 1:
				return this._arg1;
			case 2:
				return this._arg2;
			case 3:
				return this._arg3;
			case 4:
				return this._arg4;
			default:
				throw Error.ArgumentOutOfRange("index");
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000F8AB File Offset: 0x0000DAAB
		internal override int ExpressionCount
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000F8AE File Offset: 0x0000DAAE
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return BlockExpression.ReturnReadOnlyExpressions(this, ref this._arg0);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000F8BC File Offset: 0x0000DABC
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return new Block5(args[0], args[1], args[2], args[3], args[4]);
		}

		// Token: 0x040000D7 RID: 215
		private object _arg0;

		// Token: 0x040000D8 RID: 216
		private readonly Expression _arg1;

		// Token: 0x040000D9 RID: 217
		private readonly Expression _arg2;

		// Token: 0x040000DA RID: 218
		private readonly Expression _arg3;

		// Token: 0x040000DB RID: 219
		private readonly Expression _arg4;
	}
}
