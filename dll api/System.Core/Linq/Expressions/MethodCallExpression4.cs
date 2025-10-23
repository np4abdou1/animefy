using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B6 RID: 182
	internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x00013377 File Offset: 0x00011577
		public MethodCallExpression4(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) : base(method)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000133A0 File Offset: 0x000115A0
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
			case 3:
				return this._arg3;
			default:
				throw new ArgumentOutOfRangeException("index");
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public override int ArgumentCount
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000133F0 File Offset: 0x000115F0
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00013400 File Offset: 0x00011600
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(base.Method, args[0], args[1], args[2], args[3]);
			}
			return Expression.Call(base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1, this._arg2, this._arg3);
		}

		// Token: 0x0400019A RID: 410
		private object _arg0;

		// Token: 0x0400019B RID: 411
		private readonly Expression _arg1;

		// Token: 0x0400019C RID: 412
		private readonly Expression _arg2;

		// Token: 0x0400019D RID: 413
		private readonly Expression _arg3;
	}
}
