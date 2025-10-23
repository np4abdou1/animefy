using System;

namespace System.Diagnostics
{
	/// <summary>Specifies what messages to output for the <see cref="T:System.Diagnostics.Debug" />, <see cref="T:System.Diagnostics.Trace" /> and <see cref="T:System.Diagnostics.TraceSwitch" /> classes.</summary>
	// Token: 0x020000C5 RID: 197
	public enum TraceLevel
	{
		/// <summary>Output no tracing and debugging messages.</summary>
		// Token: 0x040003BD RID: 957
		Off,
		/// <summary>Output error-handling messages.</summary>
		// Token: 0x040003BE RID: 958
		Error,
		/// <summary>Output warnings and error-handling messages.</summary>
		// Token: 0x040003BF RID: 959
		Warning,
		/// <summary>Output informational messages, warnings, and error-handling messages.</summary>
		// Token: 0x040003C0 RID: 960
		Info,
		/// <summary>Output all debugging and tracing messages.</summary>
		// Token: 0x040003C1 RID: 961
		Verbose
	}
}
