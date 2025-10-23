using System;
using System.Reflection;
using System.Threading;

namespace System
{
	// Token: 0x02000167 RID: 359
	internal class AndroidPlatform
	{
		// Token: 0x06000E66 RID: 3686 RVA: 0x0003CEDC File Offset: 0x0003B0DC
		static AndroidPlatform()
		{
			Type type = Type.GetType("Android.Runtime.AndroidEnvironment, Mono.Android", true);
			AndroidPlatform.getDefaultSyncContext = (Func<SynchronizationContext>)Delegate.CreateDelegate(typeof(Func<SynchronizationContext>), type.GetMethod("GetDefaultSyncContext", BindingFlags.Static | BindingFlags.NonPublic));
			AndroidPlatform.getDefaultTimeZone = (Func<string>)Delegate.CreateDelegate(typeof(Func<string>), type.GetMethod("GetDefaultTimeZone", BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0003CF41 File Offset: 0x0003B141
		internal static SynchronizationContext GetDefaultSyncContext()
		{
			return AndroidPlatform.getDefaultSyncContext();
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0003CF4D File Offset: 0x0003B14D
		internal static string GetDefaultTimeZone()
		{
			return AndroidPlatform.getDefaultTimeZone();
		}

		// Token: 0x04000556 RID: 1366
		private static readonly Func<SynchronizationContext> getDefaultSyncContext;

		// Token: 0x04000557 RID: 1367
		private static readonly Func<string> getDefaultTimeZone;
	}
}
