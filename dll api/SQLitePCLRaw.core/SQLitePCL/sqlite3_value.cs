using System;

namespace SQLitePCL
{
	// Token: 0x02000016 RID: 22
	public class sqlite3_value
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002FC7 File Offset: 0x000011C7
		public sqlite3_value(IntPtr p)
		{
			this._p = p;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002FD6 File Offset: 0x000011D6
		internal IntPtr ptr
		{
			get
			{
				return this._p;
			}
		}

		// Token: 0x040000DE RID: 222
		private IntPtr _p;
	}
}
