using System;
using System.Diagnostics;
using System.Reflection;

namespace Android.Runtime
{
	// Token: 0x020002C2 RID: 706
	public static class AndroidRuntimeInternal
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x0004646C File Offset: 0x0004466C
		internal static void InitializeUnhandledExceptionMethod()
		{
			if (AndroidRuntimeInternal.mono_unhandled_exception == null)
			{
				AndroidRuntimeInternal.mono_unhandled_exception_method = typeof(Debugger).GetMethod("Mono_UnhandledException", BindingFlags.Static | BindingFlags.NonPublic);
				if (AndroidRuntimeInternal.mono_unhandled_exception_method != null)
				{
					AndroidRuntimeInternal.mono_unhandled_exception = (Action<Exception>)Delegate.CreateDelegate(typeof(Action<Exception>), AndroidRuntimeInternal.mono_unhandled_exception_method);
				}
			}
			if (AndroidRuntimeInternal.mono_unhandled_exception_method == null && AndroidRuntimeInternal.mono_unhandled_exception != null)
			{
				AndroidRuntimeInternal.mono_unhandled_exception_method = AndroidRuntimeInternal.mono_unhandled_exception.Method;
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000464E9 File Offset: 0x000446E9
		public static void WaitForBridgeProcessing()
		{
			if (!AndroidRuntimeInternal.BridgeProcessing)
			{
				return;
			}
			RuntimeNativeMethods._monodroid_gc_wait_for_bridge_processing();
		}

		// Token: 0x04000B7C RID: 2940
		internal static MethodInfo mono_unhandled_exception_method;

		// Token: 0x04000B7D RID: 2941
		internal static Action<Exception> mono_unhandled_exception;

		// Token: 0x04000B7E RID: 2942
		internal static volatile bool BridgeProcessing;
	}
}
