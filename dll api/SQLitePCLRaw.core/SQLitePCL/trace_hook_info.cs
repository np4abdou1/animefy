using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000035 RID: 53
	public class trace_hook_info
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x0000388F File Offset: 0x00001A8F
		public trace_hook_info(delegate_trace func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000038A8 File Offset: 0x00001AA8
		public static trace_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as trace_hook_info;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000038C8 File Offset: 0x00001AC8
		public void call(utf8z s)
		{
			this._func(this._user_data, s);
		}

		// Token: 0x040000F9 RID: 249
		private delegate_trace _func;

		// Token: 0x040000FA RID: 250
		private object _user_data;
	}
}
