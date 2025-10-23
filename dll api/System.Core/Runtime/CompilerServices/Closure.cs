using System;
using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
	/// <summary>Represents the runtime state of a dynamically generated method.</summary>
	// Token: 0x02000108 RID: 264
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerStepThrough]
	public sealed class Closure
	{
		/// <summary>Creates an object to hold state of a dynamically generated method.</summary>
		/// <param name="constants">The constant values that are used by the method.</param>
		/// <param name="locals">The hoisted local variables from the parent context.</param>
		// Token: 0x060008C2 RID: 2242 RVA: 0x00022401 File Offset: 0x00020601
		public Closure(object[] constants, object[] locals)
		{
			this.Constants = constants;
			this.Locals = locals;
		}

		/// <summary>Represents the non-trivial constants and locally executable expressions that are referenced by a dynamically generated method.</summary>
		// Token: 0x0400029E RID: 670
		public readonly object[] Constants;

		/// <summary>Represents the hoisted local variables from the parent context.</summary>
		// Token: 0x0400029F RID: 671
		public readonly object[] Locals;
	}
}
