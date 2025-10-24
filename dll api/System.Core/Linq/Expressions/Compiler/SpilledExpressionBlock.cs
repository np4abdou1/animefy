using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000FB RID: 251
	internal sealed class SpilledExpressionBlock : BlockN
	{
		// Token: 0x06000875 RID: 2165 RVA: 0x00020D87 File Offset: 0x0001EF87
		internal SpilledExpressionBlock(IReadOnlyList<Expression> expressions) : base(expressions)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			throw ContractUtils.Unreachable;
		}
	}
}
