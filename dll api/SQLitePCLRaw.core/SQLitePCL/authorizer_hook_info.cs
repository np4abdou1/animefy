using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x0200003E RID: 62
	public class authorizer_hook_info
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00003C91 File Offset: 0x00001E91
		public authorizer_hook_info(delegate_authorizer func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public static authorizer_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as authorizer_hook_info;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00003CC8 File Offset: 0x00001EC8
		public int call(int action_code, utf8z param0, utf8z param1, utf8z dbName, utf8z inner_most_trigger_or_view)
		{
			return this._func(this._user_data, action_code, param0, param1, dbName, inner_most_trigger_or_view);
		}

		// Token: 0x04000109 RID: 265
		private delegate_authorizer _func;

		// Token: 0x0400010A RID: 266
		private object _user_data;
	}
}
