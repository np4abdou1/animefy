using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x020001F2 RID: 498
	internal static class NativeEventCalls
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x00049548 File Offset: 0x00047748
		public unsafe static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode)
		{
			char* ptr = name;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return NativeEventCalls.CreateEvent_icall(manual, initial, ptr, (name != null) ? name.Length : 0, out errorCode);
		}

		// Token: 0x0600121F RID: 4639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode);

		// Token: 0x06001220 RID: 4640 RVA: 0x0004957C File Offset: 0x0004777C
		public static bool SetEvent(SafeWaitHandle handle)
		{
			bool flag = false;
			bool result;
			try
			{
				handle.DangerousAddRef(ref flag);
				result = NativeEventCalls.SetEvent_internal(handle.DangerousGetHandle());
			}
			finally
			{
				if (flag)
				{
					handle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06001221 RID: 4641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SetEvent_internal(IntPtr handle);

		// Token: 0x06001222 RID: 4642 RVA: 0x000495BC File Offset: 0x000477BC
		public static bool ResetEvent(SafeWaitHandle handle)
		{
			bool flag = false;
			bool result;
			try
			{
				handle.DangerousAddRef(ref flag);
				result = NativeEventCalls.ResetEvent_internal(handle.DangerousGetHandle());
			}
			finally
			{
				if (flag)
				{
					handle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06001223 RID: 4643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ResetEvent_internal(IntPtr handle);

		// Token: 0x06001224 RID: 4644
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseEvent_internal(IntPtr handle);
	}
}
