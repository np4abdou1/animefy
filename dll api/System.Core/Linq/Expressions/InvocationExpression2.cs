using System;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000095 RID: 149
	internal sealed class InvocationExpression2 : InvocationExpression
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x0001257E File Offset: 0x0001077E
		public InvocationExpression2(Expression lambda, Type returnType, Expression arg0, Expression arg1) : base(lambda, returnType)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00012597 File Offset: 0x00010797
		public override Expression GetArgument(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<Expression>(this._arg0);
			}
			if (index != 1)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return this._arg1;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
		public override int ArgumentCount
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000125BF File Offset: 0x000107BF
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			if (arguments != null)
			{
				return Expression.Invoke(lambda, arguments[0], arguments[1]);
			}
			return Expression.Invoke(lambda, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1);
		}

		// Token: 0x04000161 RID: 353
		private object _arg0;

		// Token: 0x04000162 RID: 354
		private readonly Expression _arg1;
	}
}
