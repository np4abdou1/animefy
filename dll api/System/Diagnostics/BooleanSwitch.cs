using System;

namespace System.Diagnostics
{
	/// <summary>Provides a simple on/off switch that controls debugging and tracing output.</summary>
	// Token: 0x020000BC RID: 188
	[SwitchLevel(typeof(bool))]
	public class BooleanSwitch : Switch
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.BooleanSwitch" /> class with the specified display name and description.</summary>
		/// <param name="displayName">The name to display on a user interface. </param>
		/// <param name="description">The description of the switch. </param>
		// Token: 0x060005AB RID: 1451 RVA: 0x00023E55 File Offset: 0x00022055
		public BooleanSwitch(string displayName, string description) : base(displayName, description)
		{
		}
	}
}
