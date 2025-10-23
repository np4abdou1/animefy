using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B9 RID: 185
	internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x00013581 File Offset: 0x00011781
		public InstanceMethodCallExpression1(MethodInfo method, Expression instance, Expression arg0) : base(method, instance)
		{
			this._arg0 = arg0;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00013592 File Offset: 0x00011792
		public override Expression GetArgument(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<Expression>(this._arg0);
			}
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00007357 File Offset: 0x00005557
		public override int ArgumentCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000135AD File Offset: 0x000117AD
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000135BB File Offset: 0x000117BB
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(instance, base.Method, args[0]);
			}
			return Expression.Call(instance, base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0));
		}

		// Token: 0x040001A3 RID: 419
		private object _arg0;
	}
}
