using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B5 RID: 181
	internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x000132BC File Offset: 0x000114BC
		public MethodCallExpression3(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) : base(method)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000132DB File Offset: 0x000114DB
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0000F766 File Offset: 0x0000D966
		public override int ArgumentCount
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00013315 File Offset: 0x00011515
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00013324 File Offset: 0x00011524
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(base.Method, args[0], args[1], args[2]);
			}
			return Expression.Call(base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1, this._arg2);
		}

		// Token: 0x04000197 RID: 407
		private object _arg0;

		// Token: 0x04000198 RID: 408
		private readonly Expression _arg1;

		// Token: 0x04000199 RID: 409
		private readonly Expression _arg2;
	}
}
