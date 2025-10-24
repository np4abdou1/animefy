using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000108 RID: 264
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00026F88 File Offset: 0x00025188
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00026F90 File Offset: 0x00025190
		public TraceLevel LevelFilter { get; set; }

		// Token: 0x060007B1 RID: 1969 RVA: 0x00026F99 File Offset: 0x00025199
		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			switch (level)
			{
			case TraceLevel.Error:
				return TraceEventType.Error;
			case TraceLevel.Warning:
				return TraceEventType.Warning;
			case TraceLevel.Info:
				return TraceEventType.Information;
			case TraceLevel.Verbose:
				return TraceEventType.Verbose;
			default:
				throw new ArgumentOutOfRangeException("level");
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00026FC8 File Offset: 0x000251C8
		[NullableContext(1)]
		public void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex)
		{
			if (level == TraceLevel.Off)
			{
				return;
			}
			TraceEventCache eventCache = new TraceEventCache();
			TraceEventType traceEventType = this.GetTraceEventType(level);
			foreach (object obj in System.Diagnostics.Trace.Listeners)
			{
				TraceListener traceListener = (TraceListener)obj;
				if (!traceListener.IsThreadSafe)
				{
					TraceListener obj2 = traceListener;
					lock (obj2)
					{
						traceListener.TraceEvent(eventCache, "Newtonsoft.Json", traceEventType, 0, message);
						goto IL_6E;
					}
					goto IL_5F;
				}
				goto IL_5F;
				IL_6E:
				if (System.Diagnostics.Trace.AutoFlush)
				{
					traceListener.Flush();
					continue;
				}
				continue;
				IL_5F:
				traceListener.TraceEvent(eventCache, "Newtonsoft.Json", traceEventType, 0, message);
				goto IL_6E;
			}
		}
	}
}
