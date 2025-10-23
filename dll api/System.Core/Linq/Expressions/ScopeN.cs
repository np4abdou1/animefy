using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000077 RID: 119
	internal class ScopeN : ScopeExpression
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0000F9C5 File Offset: 0x0000DBC5
		internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) : base(variables)
		{
			this._body = body;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000F9D5 File Offset: 0x0000DBD5
		protected IReadOnlyList<Expression> Body
		{
			get
			{
				return this._body;
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000F9DD File Offset: 0x0000DBDD
		internal override Expression GetExpression(int index)
		{
			return this._body[index];
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000F9EB File Offset: 0x0000DBEB
		internal override int ExpressionCount
		{
			get
			{
				return this._body.Count;
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return ExpressionUtils.ReturnReadOnly<Expression>(ref this._body);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000FA05 File Offset: 0x0000DC05
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			if (args == null)
			{
				Expression.ValidateVariables(variables, "variables");
				return new ScopeN(variables, this._body);
			}
			return new ScopeN(base.ReuseOrValidateVariables(variables), args);
		}

		// Token: 0x040000DF RID: 223
		private IReadOnlyList<Expression> _body;
	}
}
