using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000B7 RID: 183
	internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00013460 File Offset: 0x00011660
		public MethodCallExpression5(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) : base(method)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
			this._arg4 = arg4;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00013490 File Offset: 0x00011690
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
			case 4:
				return this._arg4;
			default:
				throw new ArgumentOutOfRangeException("index");
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0000F8AB File Offset: 0x0000DAAB
		public override int ArgumentCount
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000134EB File Offset: 0x000116EB
		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return ExpressionUtils.ReturnReadOnly(this, ref this._arg0);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000134FC File Offset: 0x000116FC
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			if (args != null)
			{
				return Expression.Call(base.Method, args[0], args[1], args[2], args[3], args[4]);
			}
			return Expression.Call(base.Method, ExpressionUtils.ReturnObject<Expression>(this._arg0), this._arg1, this._arg2, this._arg3, this._arg4);
		}

		// Token: 0x0400019E RID: 414
		private object _arg0;

		// Token: 0x0400019F RID: 415
		private readonly Expression _arg1;

		// Token: 0x040001A0 RID: 416
		private readonly Expression _arg2;

		// Token: 0x040001A1 RID: 417
		private readonly Expression _arg3;

		// Token: 0x040001A2 RID: 418
		private readonly Expression _arg4;
	}
}
