using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B1 RID: 177
	internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider
	{
		// Token: 0x0600056F RID: 1391 RVA: 0x0001315E File Offset: 0x0001135E
		public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) : base(method, instance)
		{
			this._arguments = args;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001316F File Offset: 0x0001136F
		public override Expression GetArgument(int index)
		{
			return this._arguments[index];
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0001317D File Offset: 0x0001137D
		public override int ArgumentCount
		{
			get
			{
				return this._arguments.Count;
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001318A File Offset: 0x0001138A
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly<Expression>(ref this._arguments);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00013197 File Offset: 0x00011397
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return Expression.Call(instance, base.Method, args ?? this._arguments);
		}

		// Token: 0x04000193 RID: 403
		private IReadOnlyList<Expression> _arguments;
	}
}
