using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B0 RID: 176
	internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x0001310E File Offset: 0x0001130E
		public MethodCallExpressionN(MethodInfo method, IReadOnlyList<Expression> args) : base(method)
		{
			this._arguments = args;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001311E File Offset: 0x0001131E
		public override Expression GetArgument(int index)
		{
			return this._arguments[index];
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001312C File Offset: 0x0001132C
		public override int ArgumentCount
		{
			get
			{
				return this._arguments.Count;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00013139 File Offset: 0x00011339
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly<Expression>(ref this._arguments);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00013146 File Offset: 0x00011346
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return Expression.Call(base.Method, args ?? this._arguments);
		}

		// Token: 0x04000192 RID: 402
		private IReadOnlyList<Expression> _arguments;
	}
}
