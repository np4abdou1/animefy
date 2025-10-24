using System;

namespace System.Diagnostics
{
	/// <summary>Specifies trace data options to be written to the trace output.</summary>
	// Token: 0x020000C8 RID: 200
	[Flags]
	public enum TraceOptions
	{
		/// <summary>Do not write any elements.</summary>
		// Token: 0x040003CA RID: 970
		None = 0,
		/// <summary>Write the logical operation stack, which is represented by the return value of the <see cref="P:System.Diagnostics.CorrelationManager.LogicalOperationStack" /> property.</summary>
		// Token: 0x040003CB RID: 971
		LogicalOperationStack = 1,
		/// <summary>Write the date and time. </summary>
		// Token: 0x040003CC RID: 972
		DateTime = 2,
		/// <summary>Write the timestamp, which is represented by the return value of the <see cref="M:System.Diagnostics.Stopwatch.GetTimestamp" /> method.</summary>
		// Token: 0x040003CD RID: 973
		Timestamp = 4,
		/// <summary>Write the process identity, which is represented by the return value of the <see cref="P:System.Diagnostics.Process.Id" /> property.</summary>
		// Token: 0x040003CE RID: 974
		ProcessId = 8,
		/// <summary>Write the thread identity, which is represented by the return value of the <see cref="P:System.Threading.Thread.ManagedThreadId" /> property for the current thread.</summary>
		// Token: 0x040003CF RID: 975
		ThreadId = 16,
		/// <summary>Write the call stack, which is represented by the return value of the <see cref="P:System.Environment.StackTrace" /> property.</summary>
		// Token: 0x040003D0 RID: 976
		Callstack = 32
	}
}
