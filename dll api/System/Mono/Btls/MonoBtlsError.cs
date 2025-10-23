using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x02000036 RID: 54
	internal static class MonoBtlsError
	{
		// Token: 0x06000137 RID: 311
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_error_clear_error();

		// Token: 0x06000138 RID: 312
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_error_get_error_line(out IntPtr file, out int line);

		// Token: 0x06000139 RID: 313
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len);

		// Token: 0x0600013A RID: 314
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_error_get_reason(int error);

		// Token: 0x0600013B RID: 315 RVA: 0x000063EE File Offset: 0x000045EE
		public static void ClearError()
		{
			MonoBtlsError.mono_btls_error_clear_error();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000063F8 File Offset: 0x000045F8
		public static string GetErrorString(int error)
		{
			int num = 1024;
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			string result;
			try
			{
				MonoBtlsError.mono_btls_error_get_error_string_n(error, intPtr, num);
				result = Marshal.PtrToStringAnsi(intPtr);
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006450 File Offset: 0x00004650
		public static int GetError(out string file, out int line)
		{
			IntPtr intPtr;
			int result = MonoBtlsError.mono_btls_error_get_error_line(out intPtr, out line);
			if (intPtr != IntPtr.Zero)
			{
				file = Marshal.PtrToStringAnsi(intPtr);
				return result;
			}
			file = null;
			return result;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000647E File Offset: 0x0000467E
		public static int GetErrorReason(int error)
		{
			return MonoBtlsError.mono_btls_error_get_reason(error);
		}
	}
}
