using System;
using System.Diagnostics.Tracing;
using System.Threading;

namespace System.Data
{
	// Token: 0x02000007 RID: 7
	[EventSource(Name = "System.Data.DataCommonEventSource")]
	internal class DataCommonEventSource : EventSource
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002516 File Offset: 0x00000716
		[Event(1, Level = EventLevel.Informational)]
		internal void Trace(string message)
		{
			base.WriteEvent(1, message);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002520 File Offset: 0x00000720
		[NonEvent]
		internal void Trace<T0>(string format, T0 arg0)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return;
			}
			this.Trace(string.Format(format, arg0));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002541 File Offset: 0x00000741
		[NonEvent]
		internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return;
			}
			this.Trace(string.Format(format, arg0, arg1));
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002568 File Offset: 0x00000768
		[NonEvent]
		internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return;
			}
			this.Trace(string.Format(format, arg0, arg1, arg2));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002598 File Offset: 0x00000798
		[NonEvent]
		internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return;
			}
			this.Trace(string.Format(format, new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3
			}));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025EC File Offset: 0x000007EC
		[NonEvent]
		internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return;
			}
			this.Trace(string.Format(format, new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3,
				arg4
			}));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002648 File Offset: 0x00000848
		[NonEvent]
		internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return;
			}
			this.Trace(string.Format(format, new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6
			}));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000026B8 File Offset: 0x000008B8
		[Event(2, Level = EventLevel.Verbose)]
		internal long EnterScope(string message)
		{
			long num = 0L;
			if (DataCommonEventSource.Log.IsEnabled())
			{
				num = Interlocked.Increment(ref DataCommonEventSource.s_nextScopeId);
				base.WriteEvent(2, num, message);
			}
			return num;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000026E9 File Offset: 0x000008E9
		[NonEvent]
		internal long EnterScope<T1>(string format, T1 arg1)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return 0L;
			}
			return this.EnterScope(string.Format(format, arg1));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000270C File Offset: 0x0000090C
		[NonEvent]
		internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return 0L;
			}
			return this.EnterScope(string.Format(format, arg1, arg2));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002735 File Offset: 0x00000935
		[NonEvent]
		internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return 0L;
			}
			return this.EnterScope(string.Format(format, arg1, arg2, arg3));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002768 File Offset: 0x00000968
		[NonEvent]
		internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			if (!DataCommonEventSource.Log.IsEnabled())
			{
				return 0L;
			}
			return this.EnterScope(string.Format(format, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4
			}));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000027BC File Offset: 0x000009BC
		[Event(3, Level = EventLevel.Verbose)]
		internal void ExitScope(long scopeId)
		{
			base.WriteEvent(3, scopeId);
		}

		// Token: 0x04000011 RID: 17
		internal static readonly DataCommonEventSource Log = new DataCommonEventSource();

		// Token: 0x04000012 RID: 18
		private static long s_nextScopeId = 0L;
	}
}
