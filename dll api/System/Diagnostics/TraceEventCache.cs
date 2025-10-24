using System;
using System.Collections;
using System.Globalization;
using System.Threading;

namespace System.Diagnostics
{
	/// <summary>Provides trace event data specific to a thread and a process.</summary>
	// Token: 0x020000C1 RID: 193
	public class TraceEventCache
	{
		/// <summary>Gets the call stack for the current thread.</summary>
		/// <returns>A string containing stack trace information. This value can be an empty string ("").</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00024064 File Offset: 0x00022264
		public string Callstack
		{
			get
			{
				if (this.stackTrace == null)
				{
					this.stackTrace = Environment.StackTrace;
				}
				return this.stackTrace;
			}
		}

		/// <summary>Gets the correlation data, contained in a stack. </summary>
		/// <returns>A <see cref="T:System.Collections.Stack" /> containing correlation data.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0002407F File Offset: 0x0002227F
		public Stack LogicalOperationStack
		{
			get
			{
				return Trace.CorrelationManager.LogicalOperationStack;
			}
		}

		/// <summary>Gets the date and time at which the event trace occurred.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> structure whose value is a date and time expressed in Coordinated Universal Time (UTC).</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0002408B File Offset: 0x0002228B
		public DateTime DateTime
		{
			get
			{
				if (this.dateTime == DateTime.MinValue)
				{
					this.dateTime = DateTime.UtcNow;
				}
				return this.dateTime;
			}
		}

		/// <summary>Gets the unique identifier of the current process.</summary>
		/// <returns>The system-generated unique identifier of the current process.</returns>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000240B0 File Offset: 0x000222B0
		public int ProcessId
		{
			get
			{
				return TraceEventCache.GetProcessId();
			}
		}

		/// <summary>Gets a unique identifier for the current managed thread.  </summary>
		/// <returns>A string that represents a unique integer identifier for this managed thread.</returns>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000240B8 File Offset: 0x000222B8
		public string ThreadId
		{
			get
			{
				return TraceEventCache.GetThreadId().ToString(CultureInfo.InvariantCulture);
			}
		}

		/// <summary>Gets the current number of ticks in the timer mechanism.</summary>
		/// <returns>The tick counter value of the underlying timer mechanism.</returns>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x000240D7 File Offset: 0x000222D7
		public long Timestamp
		{
			get
			{
				if (this.timeStamp == -1L)
				{
					this.timeStamp = Stopwatch.GetTimestamp();
				}
				return this.timeStamp;
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000240F4 File Offset: 0x000222F4
		private static void InitProcessInfo()
		{
			if (TraceEventCache.processName == null)
			{
				Process currentProcess = Process.GetCurrentProcess();
				try
				{
					TraceEventCache.processId = currentProcess.Id;
					TraceEventCache.processName = currentProcess.ProcessName;
				}
				finally
				{
					currentProcess.Dispose();
				}
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00024144 File Offset: 0x00022344
		internal static int GetProcessId()
		{
			TraceEventCache.InitProcessInfo();
			return TraceEventCache.processId;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00024152 File Offset: 0x00022352
		internal static int GetThreadId()
		{
			return Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x040003A6 RID: 934
		private static volatile int processId;

		// Token: 0x040003A7 RID: 935
		private static volatile string processName;

		// Token: 0x040003A8 RID: 936
		private long timeStamp = -1L;

		// Token: 0x040003A9 RID: 937
		private DateTime dateTime = DateTime.MinValue;

		// Token: 0x040003AA RID: 938
		private string stackTrace;
	}
}
