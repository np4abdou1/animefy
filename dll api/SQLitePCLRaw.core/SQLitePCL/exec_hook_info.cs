using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x0200003A RID: 58
	public class exec_hook_info
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00003A11 File Offset: 0x00001C11
		public exec_hook_info(delegate_exec func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00003A28 File Offset: 0x00001C28
		public static exec_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as exec_hook_info;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00003A48 File Offset: 0x00001C48
		public int call(int n, IntPtr values_ptr, IntPtr names_ptr)
		{
			IntPtr[] array = new IntPtr[n];
			IntPtr[] array2 = new IntPtr[n];
			int num = Marshal.SizeOf(typeof(IntPtr));
			for (int i = 0; i < n; i++)
			{
				IntPtr intPtr = Marshal.ReadIntPtr(values_ptr, i * num);
				array[i] = intPtr;
				intPtr = Marshal.ReadIntPtr(names_ptr, i * num);
				array2[i] = intPtr;
			}
			return this._func(this._user_data, array, array2);
		}

		// Token: 0x04000103 RID: 259
		private delegate_exec _func;

		// Token: 0x04000104 RID: 260
		private object _user_data;
	}
}
