using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000076 RID: 118
	internal sealed class Scope1 : ScopeExpression
	{
		// Token: 0x06000342 RID: 834 RVA: 0x0000F956 File Offset: 0x0000DB56
		internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body) : this(variables, body)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000F960 File Offset: 0x0000DB60
		private Scope1(IReadOnlyList<ParameterExpression> variables, object body) : base(variables)
		{
			this._body = body;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000F970 File Offset: 0x0000DB70
		internal override Expression GetExpression(int index)
		{
			if (index == 0)
			{
				return ExpressionUtils.ReturnObject<Expression>(this._body);
			}
			throw Error.ArgumentOutOfRange("index");
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00007357 File Offset: 0x00005557
		internal override int ExpressionCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000F98B File Offset: 0x0000DB8B
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return BlockExpression.ReturnReadOnlyExpressions(this, ref this._body);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000F999 File Offset: 0x0000DB99
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			if (args == null)
			{
				Expression.ValidateVariables(variables, "variables");
				return new Scope1(variables, this._body);
			}
			return new Scope1(base.ReuseOrValidateVariables(variables), args[0]);
		}

		// Token: 0x040000DE RID: 222
		private object _body;
	}
}
