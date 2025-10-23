using System;

namespace System.Linq.Expressions
{
	// Token: 0x02000080 RID: 128
	internal class FullConditionalExpression : ConditionalExpression
	{
		// Token: 0x0600037B RID: 891 RVA: 0x0000FE87 File Offset: 0x0000E087
		internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse) : base(test, ifTrue)
		{
			this._false = ifFalse;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000FE98 File Offset: 0x0000E098
		internal override Expression GetFalse()
		{
			return this._false;
		}

		// Token: 0x040000F2 RID: 242
		private readonly Expression _false;
	}
}
