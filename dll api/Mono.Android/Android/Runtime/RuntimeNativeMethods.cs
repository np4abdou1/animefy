using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Android.Runtime
{
	// Token: 0x020002F5 RID: 757
	internal static class RuntimeNativeMethods
	{
		// Token: 0x06001DEF RID: 7663
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void monodroid_log(LogLevel level, LogCategories category, string message);

		// Token: 0x06001DF0 RID: 7664
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void monodroid_free(IntPtr ptr);

		// Token: 0x06001DF1 RID: 7665
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr _monodroid_get_identity_hash_code(IntPtr env, IntPtr value);

		// Token: 0x06001DF2 RID: 7666
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int _monodroid_gref_get();

		// Token: 0x06001DF3 RID: 7667
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int _monodroid_weak_gref_get();

		// Token: 0x06001DF4 RID: 7668
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr _monodroid_timezone_get_default_id();

		// Token: 0x06001DF5 RID: 7669
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int _monodroid_getifaddrs(out IntPtr ifap);

		// Token: 0x06001DF6 RID: 7670
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void _monodroid_freeifaddrs(IntPtr ifap);

		// Token: 0x06001DF7 RID: 7671
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void _monodroid_detect_cpu_and_architecture(ref ushort built_for_cpu, ref ushort running_on_cpu, ref byte is64bit);

		// Token: 0x06001DF8 RID: 7672
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void _monodroid_gc_wait_for_bridge_processing();

		// Token: 0x06001DF9 RID: 7673
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int _monodroid_gref_log(string message);

		// Token: 0x06001DFA RID: 7674
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int _monodroid_gref_log_new(IntPtr curHandle, byte curType, IntPtr newHandle, byte newType, string threadName, int threadId, [In] StringBuilder from, int from_writable);

		// Token: 0x06001DFB RID: 7675
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void _monodroid_gref_log_delete(IntPtr handle, byte type, string threadName, int threadId, [In] StringBuilder from, int from_writable);

		// Token: 0x06001DFC RID: 7676
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void _monodroid_weak_gref_delete(IntPtr handle, byte type, string threadName, int threadId, [In] StringBuilder from, int from_writable);

		// Token: 0x06001DFD RID: 7677
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int _monodroid_lref_log_new(int lrefc, IntPtr handle, byte type, string threadName, int threadId, [In] StringBuilder from, int from_writable);

		// Token: 0x06001DFE RID: 7678
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void _monodroid_lref_log_delete(int lrefc, IntPtr handle, byte type, string threadName, int threadId, [In] StringBuilder from, int from_writable);

		// Token: 0x06001DFF RID: 7679
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr monodroid_TypeManager_get_java_class_name(IntPtr klass);

		// Token: 0x06001E00 RID: 7680
		[DllImport("xa-internal-api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int _monodroid_max_gref_get();
	}
}
