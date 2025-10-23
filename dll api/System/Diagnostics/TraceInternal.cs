using System;

namespace System.Diagnostics
{
	// Token: 0x020000C4 RID: 196
	internal static class TraceInternal
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0002419C File Offset: 0x0002239C
		public static TraceListenerCollection Listeners
		{
			get
			{
				TraceInternal.InitializeSettings();
				if (TraceInternal.listeners == null)
				{
					object obj = TraceInternal.critSec;
					lock (obj)
					{
						if (TraceInternal.listeners == null)
						{
							TraceInternal.listeners = new TraceListenerCollection();
							TraceListener traceListener = new DefaultTraceListener();
							traceListener.IndentLevel = TraceInternal.indentLevel;
							traceListener.IndentSize = TraceInternal.indentSize;
							TraceInternal.listeners.Add(traceListener);
						}
					}
				}
				return TraceInternal.listeners;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0002422C File Offset: 0x0002242C
		public static bool AutoFlush
		{
			get
			{
				TraceInternal.InitializeSettings();
				return TraceInternal.autoFlush;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0002423A File Offset: 0x0002243A
		public static int IndentLevel
		{
			get
			{
				return TraceInternal.indentLevel;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00024241 File Offset: 0x00022441
		public static int IndentSize
		{
			get
			{
				TraceInternal.InitializeSettings();
				return TraceInternal.indentSize;
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00004D67 File Offset: 0x00002F67
		private static void InitializeSettings()
		{
		}

		// Token: 0x040003B6 RID: 950
		private static volatile string appName = null;

		// Token: 0x040003B7 RID: 951
		private static volatile TraceListenerCollection listeners;

		// Token: 0x040003B8 RID: 952
		private static volatile bool autoFlush;

		// Token: 0x040003B9 RID: 953
		[ThreadStatic]
		private static int indentLevel;

		// Token: 0x040003BA RID: 954
		private static volatile int indentSize;

		// Token: 0x040003BB RID: 955
		internal static readonly object critSec = new object();
	}
}
