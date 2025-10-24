using System;
using System.Runtime.InteropServices;

namespace Android.Runtime
{
	// Token: 0x020002EB RID: 747
	internal static class Logger
	{
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000519BF File Offset: 0x0004FBBF
		internal static bool LogAssembly
		{
			get
			{
				return (Logger.Categories & LogCategories.Assembly) > LogCategories.None;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x000519CB File Offset: 0x0004FBCB
		internal static bool LogDebugger
		{
			get
			{
				return (Logger.Categories & LogCategories.Debugger) > LogCategories.None;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000519D7 File Offset: 0x0004FBD7
		internal static bool LogGC
		{
			get
			{
				return (Logger.Categories & LogCategories.GC) > LogCategories.None;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x000519E3 File Offset: 0x0004FBE3
		internal static bool LogGlobalRef
		{
			get
			{
				return (Logger.Categories & LogCategories.GlobalRef) > LogCategories.None;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x000519F0 File Offset: 0x0004FBF0
		internal static bool LogLocalRef
		{
			get
			{
				return (Logger.Categories & LogCategories.LocalRef) > LogCategories.None;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x000519FD File Offset: 0x0004FBFD
		internal static bool LogTiming
		{
			get
			{
				return (Logger.Categories & LogCategories.Timing) > LogCategories.None;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00051A0A File Offset: 0x0004FC0A
		internal static bool LogBundle
		{
			get
			{
				return (Logger.Categories & LogCategories.Bundle) > LogCategories.None;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00051A1A File Offset: 0x0004FC1A
		internal static bool LogNet
		{
			get
			{
				return (Logger.Categories & LogCategories.Net) > LogCategories.None;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00051A2A File Offset: 0x0004FC2A
		internal static bool LogNetlink
		{
			get
			{
				return (Logger.Categories & LogCategories.Netlink) > LogCategories.None;
			}
		}

		// Token: 0x06001DBE RID: 7614
		[DllImport("liblog")]
		private static extern void __android_log_print(LogLevel level, string appname, string format, string args, IntPtr zero);

		// Token: 0x06001DBF RID: 7615 RVA: 0x00051A3C File Offset: 0x0004FC3C
		public static void Log(LogLevel level, string appname, string log)
		{
			foreach (string text in (log ?? "").Split(new string[]
			{
				Environment.NewLine
			}, StringSplitOptions.None))
			{
				if (!Logger.hasNoLibLog)
				{
					try
					{
						Logger.__android_log_print(level, appname, "%s", text, IntPtr.Zero);
					}
					catch (DllNotFoundException)
					{
						Logger.hasNoLibLog = true;
					}
				}
				if (AndroidEnvironment.VSAndroidDesignerIsEnabled && Logger.hasNoLibLog)
				{
					Console.WriteLine("[{0}] {1}: {2}", level, appname, text);
				}
			}
		}

		// Token: 0x06001DC0 RID: 7616
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint monodroid_get_log_categories();

		// Token: 0x04000C47 RID: 3143
		private static bool hasNoLibLog;

		// Token: 0x04000C48 RID: 3144
		internal static LogCategories Categories = (LogCategories)Logger.monodroid_get_log_categories();
	}
}
