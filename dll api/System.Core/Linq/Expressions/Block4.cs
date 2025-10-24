using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000072 RID: 114
	internal sealed class Block4 : BlockExpression
	{
		// Token: 0x0600032F RID: 815 RVA: 0x0000F787 File Offset: 0x0000D987
		internal Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000F7AC File Offset: 0x0000D9AC
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
			default:
				throw Error.ArgumentOutOfRange("index");
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		internal override int ExpressionCount
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000F7FF File Offset: 0x0000D9FF
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return BlockExpression.ReturnReadOnlyExpressions(this, ref this._arg0);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000F80D File Offset: 0x0000DA0D
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return new Block4(args[0], args[1], args[2], args[3]);
		}

		// Token: 0x040000D3 RID: 211
		private object _arg0;

		// Token: 0x040000D4 RID: 212
		private readonly Expression _arg1;

		// Token: 0x040000D5 RID: 213
		private readonly Expression _arg2;

		// Token: 0x040000D6 RID: 214
		private readonly Expression _arg3;
	}
}
