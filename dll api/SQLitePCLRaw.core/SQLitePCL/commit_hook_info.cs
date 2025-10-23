using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000033 RID: 51
	public class commit_hook_info
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000037D9 File Offset: 0x000019D9
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000037E1 File Offset: 0x000019E1
		public delegate_commit _func { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000037EA File Offset: 0x000019EA
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000037F2 File Offset: 0x000019F2
		public object _user_data { get; private set; }

		// Token: 0x060001E2 RID: 482 RVA: 0x000037FB File Offset: 0x000019FB
		public commit_hook_info(delegate_commit func, object v)
		{
			this._func = func;
			this._user_data = v;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003811 File Offset: 0x00001A11
		public int call()
		{
			return this._func(this._user_data);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00003824 File Offset: 0x00001A24
		public static commit_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as commit_hook_info;
		}
	}
}
