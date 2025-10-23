using System;

namespace System.Linq.Expressions
{
	// Token: 0x0200004C RID: 76
	internal class AssignBinaryExpression : BinaryExpression
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00009585 File Offset: 0x00007785
		internal AssignBinaryExpression(Expression left, Expression right) : base(left, right)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000958F File Offset: 0x0000778F
		public static AssignBinaryExpression Make(Expression left, Expression right, bool byRef)
		{
			if (byRef)
			{
				return new ByRefAssignBinaryExpression(left, right);
			}
			return new AssignBinaryExpression(left, right);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00008049 File Offset: 0x00006249
		internal virtual bool IsByRef
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000095A3 File Offset: 0x000077A3
		public sealed override Type Type
		{
			get
			{
				return base.Left.Type;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000219 RID: 537 RVA: 0x000095B0 File Offset: 0x000077B0
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Assign;
			}
		}
	}
}
