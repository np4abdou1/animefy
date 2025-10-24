using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	// Token: 0x02000078 RID: 120
	internal sealed class ScopeWithType : ScopeN
	{
		// Token: 0x0600034E RID: 846 RVA: 0x0000FA2F File Offset: 0x0000DC2F
		internal ScopeWithType(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type) : base(variables, expressions)
		{
			this.Type = type;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000FA40 File Offset: 0x0000DC40
		public sealed override Type Type { get; }

		// Token: 0x06000350 RID: 848 RVA: 0x0000FA48 File Offset: 0x0000DC48
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			if (args == null)
			{
				Expression.ValidateVariables(variables, "variables");
				return new ScopeWithType(variables, base.Body, this.Type);
			}
			return new ScopeWithType(base.ReuseOrValidateVariables(variables), args, this.Type);
		}
	}
}
