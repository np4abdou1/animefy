using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace System.Diagnostics
{
	/// <summary>Correlates traces that are part of a logical transaction.</summary>
	// Token: 0x020000BD RID: 189
	public class CorrelationManager
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x0000222D File Offset: 0x0000042D
		internal CorrelationManager()
		{
		}

		/// <summary>Gets the logical operation stack from the call context.</summary>
		/// <returns>A <see cref="T:System.Collections.Stack" /> object that represents the logical operation stack for the call context.</returns>
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00023E5F File Offset: 0x0002205F
		public Stack LogicalOperationStack
		{
			get
			{
				return this.GetLogicalOperationStack();
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00023E68 File Offset: 0x00022068
		private Stack GetLogicalOperationStack()
		{
			Stack stack = CallContext.LogicalGetData("System.Diagnostics.Trace.CorrelationManagerSlot") as Stack;
			if (stack == null)
			{
				stack = new Stack();
				CallContext.LogicalSetData("System.Diagnostics.Trace.CorrelationManagerSlot", stack);
			}
			return stack;
		}
	}
}
