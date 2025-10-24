﻿using System;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	/// <summary>Emits or clears a sequence point for debug information. This allows the debugger to highlight the correct source code when debugging.</summary>
	// Token: 0x02000084 RID: 132
	[DebuggerTypeProxy(typeof(Expression.DebugInfoExpressionProxy))]
	public class DebugInfoExpression : Expression
	{
	}
}
