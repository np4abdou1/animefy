using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000BB RID: 187
	internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x00013677 File Offset: 0x00011877
		public InstanceMethodCallExpression3(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) : base(method, instance)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00013698 File Offset: 0x00011898
		public override Expression GetArgument(int index)
		{
			switch (index)
			{
			case 0:
				return ExpressionUtils.ReturnObject<Expression>(this._arg0);
			case 1:
				return this._arg1;
			case 2:
				return this._arg2;
			default:
				throw new ArgumentOutOfRangeException("index");
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000F766 File Offset: 0x0000D966
		public override int ArgumentCount
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000136D2 File Offset: 0x000118D2
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000136E0 File Offset: 0x000118E0
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(instance, base.Method, args[0], args[1], args[2]);
			}
			return Expression.Call(instance, base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1, this._arg2);
		}

		// Token: 0x040001A6 RID: 422
		private object _arg0;

		// Token: 0x040001A7 RID: 423
		private readonly Expression _arg1;

		// Token: 0x040001A8 RID: 424
		private readonly Expression _arg2;
	}
}
