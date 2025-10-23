using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000075 RID: 117
	internal class ScopeExpression : BlockExpression
	{
		// Token: 0x0600033E RID: 830 RVA: 0x0000F911 File Offset: 0x0000DB11
		internal ScopeExpression(IReadOnlyList<ParameterExpression> variables)
		{
			this._variables = variables;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000F920 File Offset: 0x0000DB20
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			return ExpressionUtils.ReturnReadOnly<ParameterExpression>(ref this._variables);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000F92D File Offset: 0x0000DB2D
		protected IReadOnlyList<ParameterExpression> VariablesList
		{
			get
			{
				return this._variables;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000F935 File Offset: 0x0000DB35
		internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables)
		{
			if (variables != null && variables != this.VariablesList)
			{
				Expression.ValidateVariables(variables, "variables");
				return variables;
			}
			return this.VariablesList;
		}

		// Token: 0x040000DD RID: 221
		private IReadOnlyList<ParameterExpression> _variables;
	}
}
