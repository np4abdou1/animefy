using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000032 RID: 50
	public class log_hook_info
	{
		// Token: 0x060001DB RID: 475 RVA: 0x0000378C File Offset: 0x0000198C
		public log_hook_info(delegate_log func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000037A4 File Offset: 0x000019A4
		public static log_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as log_hook_info;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000037C4 File Offset: 0x000019C4
		public void call(int rc, utf8z msg)
		{
			this._func(this._user_data, rc, msg);
		}

		// Token: 0x040000F3 RID: 243
		private delegate_log _func;

		// Token: 0x040000F4 RID: 244
		private object _user_data;
	}
}
