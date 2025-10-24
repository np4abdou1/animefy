using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000036 RID: 54
	public class profile_hook_info
	{
		// Token: 0x060001EB RID: 491 RVA: 0x000038DC File Offset: 0x00001ADC
		public profile_hook_info(delegate_profile func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000038F4 File Offset: 0x00001AF4
		public static profile_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as profile_hook_info;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00003914 File Offset: 0x00001B14
		public void call(utf8z s, long elapsed)
		{
			this._func(this._user_data, s, elapsed);
		}

		// Token: 0x040000FB RID: 251
		private delegate_profile _func;

		// Token: 0x040000FC RID: 252
		private object _user_data;
	}
}
