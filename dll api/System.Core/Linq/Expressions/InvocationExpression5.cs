using System;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000098 RID: 152
	internal sealed class InvocationExpression5 : InvocationExpression
	{
		// Token: 0x060004D6 RID: 1238 RVA: 0x0001272B File Offset: 0x0001092B
		public InvocationExpression5(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) : base(lambda, returnType)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
			this._arg4 = arg4;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0001275C File Offset: 0x0001095C
		public override Expression GetArgument(int index)
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
				throw new ArgumentOutOfRangeException("index");
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000F8AB File Offset: 0x0000DAAB
		public override int ArgumentCount
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000127B8 File Offset: 0x000109B8
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			if (arguments != null)
			{
				return Expression.Invoke(lambda, arguments[0], arguments[1], arguments[2], arguments[3], arguments[4]);
			}
			return Expression.Invoke(lambda, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1, this._arg2, this._arg3, this._arg4);
		}

		// Token: 0x0400016A RID: 362
		private object _arg0;

		// Token: 0x0400016B RID: 363
		private readonly Expression _arg1;

		// Token: 0x0400016C RID: 364
		private readonly Expression _arg2;

		// Token: 0x0400016D RID: 365
		private readonly Expression _arg3;

		// Token: 0x0400016E RID: 366
		private readonly Expression _arg4;
	}
}
