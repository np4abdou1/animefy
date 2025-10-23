using System;

namespace System.Linq.Expressions
{
	// Token: 0x02000093 RID: 147
	internal sealed class InvocationExpression0 : InvocationExpression
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00012514 File Offset: 0x00010714
		public InvocationExpression0(Expression lambda, Type returnType) : base(lambda, returnType)
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001251E File Offset: 0x0001071E
		public override Expression GetArgument(int index)
		{
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00008049 File Offset: 0x00006249
		public override int ArgumentCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001252A File Offset: 0x0001072A
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return Expression.Invoke(lambda);
		}
	}
}
