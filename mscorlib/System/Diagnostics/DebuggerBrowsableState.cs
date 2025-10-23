using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Provides display instructions for the debugger.</summary>
	// Token: 0x020005BC RID: 1468
	[ComVisible(true)]
	public enum DebuggerBrowsableState
	{
		/// <summary>Never show the element.</summary>
		// Token: 0x0400181F RID: 6175
		Never,
		/// <summary>Show the element as collapsed.</summary>
		// Token: 0x04001820 RID: 6176
		Collapsed = 2,
		/// <summary>Do not display the root element; display the child elements if the element is a collection or array of items.</summary>
		// Token: 0x04001821 RID: 6177
		RootHidden
	}
}
