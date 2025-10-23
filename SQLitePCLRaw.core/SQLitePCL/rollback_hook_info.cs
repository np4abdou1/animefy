using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000034 RID: 52
	public class rollback_hook_info
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00003844 File Offset: 0x00001A44
		public rollback_hook_info(delegate_rollback func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000385C File Offset: 0x00001A5C
		public static rollback_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as rollback_hook_info;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000387C File Offset: 0x00001A7C
		public void call()
		{
			this._func(this._user_data);
		}

		// Token: 0x040000F7 RID: 247
		private delegate_rollback _func;

		// Token: 0x040000F8 RID: 248
		private object _user_data;
	}
}
