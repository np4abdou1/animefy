using System;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000096 RID: 150
	internal sealed class InvocationExpression3 : InvocationExpression
	{
		// Token: 0x060004CE RID: 1230 RVA: 0x000125E8 File Offset: 0x000107E8
		public InvocationExpression3(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2) : base(lambda, returnType)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00012609 File Offset: 0x00010809
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
			default:
				throw new ArgumentOutOfRangeException("index");
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0000F766 File Offset: 0x0000D966
		public override int ArgumentCount
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00012643 File Offset: 0x00010843
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			if (arguments != null)
			{
				return Expression.Invoke(lambda, arguments[0], arguments[1], arguments[2]);
			}
			return Expression.Invoke(lambda, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1, this._arg2);
		}

		// Token: 0x04000163 RID: 355
		private object _arg0;

		// Token: 0x04000164 RID: 356
		private readonly Expression _arg1;

		// Token: 0x04000165 RID: 357
		private readonly Expression _arg2;
	}
}
