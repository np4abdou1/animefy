using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B3 RID: 179
	internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x000131CD File Offset: 0x000113CD
		public MethodCallExpression1(MethodInfo method, Expression arg0) : base(method)
		{
			this._arg0 = arg0;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000131DD File Offset: 0x000113DD
		public override Expression GetArgument(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<Expression>(this._arg0);
			}
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00007357 File Offset: 0x00005557
		public override int ArgumentCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000131F8 File Offset: 0x000113F8
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00013206 File Offset: 0x00011406
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(base.Method, args[0]);
			}
			return Expression.Call(base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0));
		}

		// Token: 0x04000194 RID: 404
		private object _arg0;
	}
}
