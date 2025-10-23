using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B4 RID: 180
	internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x00013234 File Offset: 0x00011434
		public MethodCallExpression2(MethodInfo method, Expression arg0, Expression arg1) : base(method)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0001324B File Offset: 0x0001144B
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
		public override int ArgumentCount
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00013273 File Offset: 0x00011473
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00013281 File Offset: 0x00011481
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(base.Method, args[0], args[1]);
			}
			return Expression.Call(base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1);
		}

		// Token: 0x04000195 RID: 405
		private object _arg0;

		// Token: 0x04000196 RID: 406
		private readonly Expression _arg1;
	}
}
