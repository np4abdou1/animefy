using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B8 RID: 184
	internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider
	{
		// Token: 0x06000592 RID: 1426 RVA: 0x00013569 File Offset: 0x00011769
		public InstanceMethodCallExpression0(MethodInfo method, Expression instance) : base(method, instance)
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0001251E File Offset: 0x0001071E
		public override Expression GetArgument(int index)
		{
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00008049 File Offset: 0x00006249
		public override int ArgumentCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000131B9 File Offset: 0x000113B9
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return EmptyReadOnlyCollection<Expression>.Instance;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00013573 File Offset: 0x00011773
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return Expression.Call(instance, base.Method);
		}
	}
}
