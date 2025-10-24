using System;

namespace System.Linq.Expressions
{
	// Token: 0x0200004D RID: 77
	internal class ByRefAssignBinaryExpression : AssignBinaryExpression
	{
		// Token: 0x0600021A RID: 538 RVA: 0x000095B4 File Offset: 0x000077B4
		internal ByRefAssignBinaryExpression(Expression left, Expression right) : base(left, right)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00007357 File Offset: 0x00005557
		internal override bool IsByRef
		{
			get
			{
				return true;
			}
		}
	}
}
