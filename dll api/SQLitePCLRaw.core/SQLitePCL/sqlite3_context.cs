using System;

namespace SQLitePCL
{
	// Token: 0x02000015 RID: 21
	public class sqlite3_context
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00002F9F File Offset: 0x0000119F
		protected sqlite3_context(object user_data)
		{
			this._user_data = user_data;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002FAE File Offset: 0x000011AE
		internal object user_data
		{
			get
			{
				return this._user_data;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002FB6 File Offset: 0x000011B6
		internal IntPtr ptr
		{
			get
			{
				return this._p;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002FBE File Offset: 0x000011BE
		protected void set_context_ptr(IntPtr p)
		{
			this._p = p;
		}

		// Token: 0x040000DB RID: 219
		private IntPtr _p;

		// Token: 0x040000DC RID: 220
		private object _user_data;

		// Token: 0x040000DD RID: 221
		public object state;
	}
}
