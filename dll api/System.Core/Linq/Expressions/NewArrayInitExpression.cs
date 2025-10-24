using System;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	// Token: 0x020000BD RID: 189
	internal sealed class NewArrayInitExpression : NewArrayExpression
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x000137D2 File Offset: 0x000119D2
		internal NewArrayInitExpression(Type type, ReadOnlyCollection<Expression> expressions) : base(type, expressions)
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000137DC File Offset: 0x000119DC
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.NewArrayInit;
			}
		}
	}
}
