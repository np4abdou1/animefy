using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000039 RID: 57
	public class collation_hook_info
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x000039C4 File Offset: 0x00001BC4
		public collation_hook_info(delegate_collation func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000039DC File Offset: 0x00001BDC
		public static collation_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as collation_hook_info;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000039FC File Offset: 0x00001BFC
		public int call(ReadOnlySpan<byte> s1, ReadOnlySpan<byte> s2)
		{
			return this._func(this._user_data, s1, s2);
		}

		// Token: 0x04000101 RID: 257
		private delegate_collation _func;

		// Token: 0x04000102 RID: 258
		private object _user_data;
	}
}
