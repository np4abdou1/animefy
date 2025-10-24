using System;
using System.Collections.Generic;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000D1 RID: 209
	internal sealed class AnalyzedTree
	{
		// Token: 0x040001E8 RID: 488
		internal readonly Dictionary<object, CompilerScope> Scopes = new Dictionary<object, CompilerScope>();

		// Token: 0x040001E9 RID: 489
		internal readonly Dictionary<LambdaExpression, BoundConstants> Constants = new Dictionary<LambdaExpression, BoundConstants>();
	}
}
