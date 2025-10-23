using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Defines the standard keywords that apply to events.</summary>
	// Token: 0x020005C7 RID: 1479
	[Flags]
	public enum EventKeywords : long
	{
		/// <summary>No filtering on keywords is performed when the event is published.</summary>
		// Token: 0x04001842 RID: 6210
		None = 0L,
		/// <summary>All the bits are set to 1, representing every possible group of events.</summary>
		// Token: 0x04001843 RID: 6211
		All = -1L,
		/// <summary>Attached to all Microsoft telemetry events.</summary>
		// Token: 0x04001844 RID: 6212
		MicrosoftTelemetry = 562949953421312L,
		/// <summary>Attached to all Windows Diagnostics Infrastructure (WDI) context events.</summary>
		// Token: 0x04001845 RID: 6213
		WdiContext = 562949953421312L,
		/// <summary>Attached to all Windows Diagnostics Infrastructure (WDI) diagnostic events.</summary>
		// Token: 0x04001846 RID: 6214
		WdiDiagnostic = 1125899906842624L,
		/// <summary>Attached to all Service Quality Mechanism (SQM) events.</summary>
		// Token: 0x04001847 RID: 6215
		Sqm = 2251799813685248L,
		/// <summary>Attached to all failed security audit events. Use this keyword only  for events in the security log.</summary>
		// Token: 0x04001848 RID: 6216
		AuditFailure = 4503599627370496L,
		/// <summary>Attached to all successful security audit events. Use this keyword only for events in the security log.</summary>
		// Token: 0x04001849 RID: 6217
		AuditSuccess = 9007199254740992L,
		/// <summary>Attached to transfer events where the related activity ID (correlation ID) is a computed value and is not guaranteed to be unique (that is, it is not a real GUID).</summary>
		// Token: 0x0400184A RID: 6218
		CorrelationHint = 4503599627370496L,
		/// <summary>Attached to events that are raised by using the <see langword="RaiseEvent" /> function.</summary>
		// Token: 0x0400184B RID: 6219
		EventLogClassic = 36028797018963968L
	}
}
