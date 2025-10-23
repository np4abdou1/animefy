using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B2 RID: 178
	internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x000131B0 File Offset: 0x000113B0
		public MethodCallExpression0(MethodInfo method) : base(method)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001251E File Offset: 0x0001071E
		public override Expression GetArgument(int index)
		{
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00008049 File Offset: 0x00006249
		public override int ArgumentCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000131B9 File Offset: 0x000113B9
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return EmptyReadOnlyCollection<Expression>.Instance;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000131C0 File Offset: 0x000113C0
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return Expression.Call(base.Method);
		}
	}
}
