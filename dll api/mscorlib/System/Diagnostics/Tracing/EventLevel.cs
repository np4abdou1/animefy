using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Identifies the level of an event.</summary>
	// Token: 0x020005C6 RID: 1478
	public enum EventLevel
	{
		/// <summary>No level filtering is done on the event.</summary>
		// Token: 0x0400183B RID: 6203
		LogAlways,
		/// <summary>This level corresponds to a critical error, which is a serious error that has caused a major failure.</summary>
		// Token: 0x0400183C RID: 6204
		Critical,
		/// <summary>This level adds standard errors that signify a problem.</summary>
		// Token: 0x0400183D RID: 6205
		Error,
		/// <summary>This level adds warning events (for example, events that are published because a disk is nearing full capacity).</summary>
		// Token: 0x0400183E RID: 6206
		Warning,
		/// <summary>This level adds informational events or messages that are not errors. These events can help trace the progress or state of an application.</summary>
		// Token: 0x0400183F RID: 6207
		Informational,
		/// <summary>This level adds lengthy events or messages. It causes all events to be logged.</summary>
		// Token: 0x04001840 RID: 6208
		Verbose
	}
}
