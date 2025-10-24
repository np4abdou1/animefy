using System;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000094 RID: 148
	internal sealed class InvocationExpression1 : InvocationExpression
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00012532 File Offset: 0x00010732
		public InvocationExpression1(Expression lambda, Type returnType, Expression arg0) : base(lambda, returnType)
		{
			this._arg0 = arg0;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00012543 File Offset: 0x00010743
		public override Expression GetArgument(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<Expression>(this._arg0);
			}
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00007357 File Offset: 0x00005557
		public override int ArgumentCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001255E File Offset: 0x0001075E
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			if (arguments != null)
			{
				return Expression.Invoke(lambda, arguments[0]);
			}
			return Expression.Invoke(lambda, ExpressionUtils.ReturnObject<Expression>(this._arg0));
		}

		// Token: 0x04000160 RID: 352
		private object _arg0;
	}
}
