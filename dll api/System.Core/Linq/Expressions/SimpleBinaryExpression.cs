using System;

namespace System.Linq.Expressions
{
	// Token: 0x02000050 RID: 80
	internal class SimpleBinaryExpression : BinaryExpression
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00009606 File Offset: 0x00007806
		internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type) : base(left, right)
		{
			this.NodeType = nodeType;
			this.Type = type;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000961F File Offset: 0x0000781F
		public sealed override ExpressionType NodeType { get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00009627 File Offset: 0x00007827
		public sealed override Type Type { get; }
	}
}
