using System;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
	// Token: 0x02000092 RID: 146
	internal sealed class InvocationExpressionN : InvocationExpression
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x000124C7 File Offset: 0x000106C7
		public InvocationExpressionN(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType) : base(lambda, returnType)
		{
			this._arguments = arguments;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000124D8 File Offset: 0x000106D8
		public override Expression GetArgument(int index)
		{
			return this._arguments[index];
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000124E6 File Offset: 0x000106E6
		public override int ArgumentCount
		{
			get
			{
				return this._arguments.Count;
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000124F4 File Offset: 0x000106F4
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return Expression.Invoke(lambda, arguments ?? this._arguments);
		}

		// Token: 0x0400015F RID: 351
		private IReadOnlyList<Expression> _arguments;
	}
}
