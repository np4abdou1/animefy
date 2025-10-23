using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>An expression that provides runtime read/write permission for variables.</summary>
	// Token: 0x020000C5 RID: 197
	[DebuggerTypeProxy(typeof(Expression.RuntimeVariablesExpressionProxy))]
	public sealed class RuntimeVariablesExpression : Expression
	{
		/// <summary>The variables or parameters to which to provide runtime access.</summary>
		/// <returns>The read-only collection containing parameters that will be provided the runtime access.</returns>
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00013A46 File Offset: 0x00011C46
		public ReadOnlyCollection<ParameterExpression> Variables { get; }
	}
}
