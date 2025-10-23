using System;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000097 RID: 151
	internal sealed class InvocationExpression4 : InvocationExpression
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x00012675 File Offset: 0x00010875
		public InvocationExpression4(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) : base(lambda, returnType)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000126A0 File Offset: 0x000108A0
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
			default:
				throw new ArgumentOutOfRangeException("index");
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public override int ArgumentCount
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000126F0 File Offset: 0x000108F0
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			if (arguments != null)
			{
				return Expression.Invoke(lambda, arguments[0], arguments[1], arguments[2], arguments[3]);
			}
			return Expression.Invoke(lambda, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1, this._arg2, this._arg3);
		}

		// Token: 0x04000166 RID: 358
		private object _arg0;

		// Token: 0x04000167 RID: 359
		private readonly Expression _arg1;

		// Token: 0x04000168 RID: 360
		private readonly Expression _arg2;

		// Token: 0x04000169 RID: 361
		private readonly Expression _arg3;
	}
}
