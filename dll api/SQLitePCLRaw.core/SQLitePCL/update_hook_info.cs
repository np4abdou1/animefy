using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000038 RID: 56
	public class update_hook_info
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00003973 File Offset: 0x00001B73
		public update_hook_info(delegate_update func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000398C File Offset: 0x00001B8C
		public static update_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as update_hook_info;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000039AC File Offset: 0x00001BAC
		public void call(int typ, utf8z db, utf8z tbl, long rowid)
		{
			this._func(this._user_data, typ, db, tbl, rowid);
		}

		// Token: 0x040000FF RID: 255
		private delegate_update _func;

		// Token: 0x04000100 RID: 256
		private object _user_data;
	}
}
