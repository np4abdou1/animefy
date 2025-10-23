using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x02000051 RID: 81
	internal class MethodBinaryExpression : SimpleBinaryExpression
	{
		// Token: 0x06000225 RID: 549 RVA: 0x0000962F File Offset: 0x0000782F
		internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method) : base(nodeType, left, right, type)
		{
			this._method = method;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00009644 File Offset: 0x00007844
		internal override MethodInfo GetMethod()
		{
			return this._method;
		}

		// Token: 0x040000C6 RID: 198
		private readonly MethodInfo _method;
	}
}
