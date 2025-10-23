using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000071 RID: 113
	internal sealed class Block3 : BlockExpression
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0000F70F File Offset: 0x0000D90F
		internal Block3(Expression arg0, Expression arg1, Expression arg2)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000F72C File Offset: 0x0000D92C
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
			default:
				throw Error.ArgumentOutOfRange("index");
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000F766 File Offset: 0x0000D966
		internal override int ExpressionCount
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000F769 File Offset: 0x0000D969
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return BlockExpression.ReturnReadOnlyExpressions(this, ref this._arg0);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000F777 File Offset: 0x0000D977
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return new Block3(args[0], args[1], args[2]);
		}

		// Token: 0x040000D0 RID: 208
		private object _arg0;

		// Token: 0x040000D1 RID: 209
		private readonly Expression _arg1;

		// Token: 0x040000D2 RID: 210
		private readonly Expression _arg2;
	}
}
