using System;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	// Token: 0x020000BE RID: 190
	internal sealed class NewArrayBoundsExpression : NewArrayExpression
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x000137D2 File Offset: 0x000119D2
		internal NewArrayBoundsExpression(Type type, ReadOnlyCollection<Expression> expressions) : base(type, expressions)
		{
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x000137E0 File Offset: 0x000119E0
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.NewArrayBounds;
			}
		}
	}
}
