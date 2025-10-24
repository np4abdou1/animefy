using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Determines if and how a member is displayed in the debugger variable windows. This class cannot be inherited.</summary>
	// Token: 0x020005BD RID: 1469
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	[ComVisible(true)]
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerBrowsableAttribute" /> class. </summary>
		/// <param name="state">One of the <see cref="T:System.Diagnostics.DebuggerBrowsableState" /> values that specifies how to display the member.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="state" /> is not one of the <see cref="T:System.Diagnostics.DebuggerBrowsableState" /> values.</exception>
		// Token: 0x06002C2B RID: 11307 RVA: 0x000B749E File Offset: 0x000B569E
		public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		{
			if (state < DebuggerBrowsableState.Never || state > DebuggerBrowsableState.RootHidden)
			{
				throw new ArgumentOutOfRangeException("state");
			}
			this.state = state;
		}

		// Token: 0x04001822 RID: 6178
		private DebuggerBrowsableState state;
	}
}
