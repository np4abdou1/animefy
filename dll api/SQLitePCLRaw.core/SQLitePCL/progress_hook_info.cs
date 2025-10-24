using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000037 RID: 55
	public class progress_hook_info
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00003929 File Offset: 0x00001B29
		public progress_hook_info(delegate_progress func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00003940 File Offset: 0x00001B40
		public static progress_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as progress_hook_info;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00003960 File Offset: 0x00001B60
		public int call()
		{
			return this._func(this._user_data);
		}

		// Token: 0x040000FD RID: 253
		private delegate_progress _func;

		// Token: 0x040000FE RID: 254
		private object _user_data;
	}
}
