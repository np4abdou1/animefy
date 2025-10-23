using System;

namespace System.Linq.Expressions
{
	// Token: 0x02000081 RID: 129
	internal sealed class FullConditionalExpressionWithType : FullConditionalExpression
	{
		// Token: 0x0600037D RID: 893 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		internal FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, Type type) : base(test, ifTrue, ifFalse)
		{
			this.Type = type;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000FEB3 File Offset: 0x0000E0B3
		public sealed override Type Type { get; }
	}
}
