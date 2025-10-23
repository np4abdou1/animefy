using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x0200004F RID: 79
	internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
	{
		// Token: 0x06000220 RID: 544 RVA: 0x000095E7 File Offset: 0x000077E7
		internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) : base(nodeType, left, right, type, method)
		{
			this._conversion = conversion;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000095FE File Offset: 0x000077FE
		internal override LambdaExpression GetConversion()
		{
			return this._conversion;
		}

		// Token: 0x040000C3 RID: 195
		private readonly LambdaExpression _conversion;
	}
}
