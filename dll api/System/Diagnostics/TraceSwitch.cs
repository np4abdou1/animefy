using System;

namespace System.Diagnostics
{
	/// <summary>Provides a multilevel switch to control tracing and debug output without recompiling your code.</summary>
	// Token: 0x020000C9 RID: 201
	[SwitchLevel(typeof(TraceLevel))]
	public class TraceSwitch : Switch
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TraceSwitch" /> class, using the specified display name and description.</summary>
		/// <param name="displayName">The name to display on a user interface. </param>
		/// <param name="description">The description of the switch. </param>
		// Token: 0x060005EF RID: 1519 RVA: 0x00023E55 File Offset: 0x00022055
		public TraceSwitch(string displayName, string description) : base(displayName, description)
		{
		}
	}
}
