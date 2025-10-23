using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000017 RID: 23
	public class sqlite3_blob : SafeHandle
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00002F58 File Offset: 0x00001158
		private sqlite3_blob() : base(IntPtr.Zero, true)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002F66 File Offset: 0x00001166
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002FDE File Offset: 0x000011DE
		protected override bool ReleaseHandle()
		{
			raw.internal_sqlite3_blob_close(this.handle);
			return true;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002FED File Offset: 0x000011ED
		public int manual_close()
		{
			int result = raw.internal_sqlite3_blob_close(this.handle);
			this.handle = IntPtr.Zero;
			return result;
		}
	}
}
