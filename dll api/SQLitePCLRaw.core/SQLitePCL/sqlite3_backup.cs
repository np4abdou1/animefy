using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000014 RID: 20
	public class sqlite3_backup : SafeHandle
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00002F58 File Offset: 0x00001158
		private sqlite3_backup() : base(IntPtr.Zero, true)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002F66 File Offset: 0x00001166
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002F78 File Offset: 0x00001178
		protected override bool ReleaseHandle()
		{
			raw.internal_sqlite3_backup_finish(this.handle);
			return true;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002F87 File Offset: 0x00001187
		public int manual_close()
		{
			int result = raw.internal_sqlite3_backup_finish(this.handle);
			this.handle = IntPtr.Zero;
			return result;
		}
	}
}
