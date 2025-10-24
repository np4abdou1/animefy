using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000BA RID: 186
	internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x000135EB File Offset: 0x000117EB
		public InstanceMethodCallExpression2(MethodInfo method, Expression instance, Expression arg0, Expression arg1) : base(method, instance)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00013604 File Offset: 0x00011804
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
		public override int ArgumentCount
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001362C File Offset: 0x0001182C
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001363A File Offset: 0x0001183A
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(instance, base.Method, args[0], args[1]);
			}
			return Expression.Call(instance, base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1);
		}

		// Token: 0x040001A4 RID: 420
		private object _arg0;

		// Token: 0x040001A5 RID: 421
		private readonly Expression _arg1;
	}
}
