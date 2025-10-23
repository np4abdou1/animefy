using System;

namespace System.Linq.Expressions
{
	// Token: 0x0200004B RID: 75
	internal sealed class LogicalBinaryExpression : BinaryExpression
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00009560 File Offset: 0x00007760
		internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right) : base(left, right)
		{
			this.NodeType = nodeType;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00009571 File Offset: 0x00007771
		public sealed override Type Type
		{
			get
			{
				return typeof(bool);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000957D File Offset: 0x0000777D
		public sealed override ExpressionType NodeType { get; }
	}
}
