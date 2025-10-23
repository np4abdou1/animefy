using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000018 RID: 24
	public class sqlite3_stmt : SafeHandle
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00003008 File Offset: 0x00001208
		internal static sqlite3_stmt From(IntPtr p, sqlite3 db)
		{
			sqlite3_stmt sqlite3_stmt = new sqlite3_stmt();
			sqlite3_stmt.SetHandle(p);
			db.add_stmt(sqlite3_stmt);
			sqlite3_stmt._db = db;
			return sqlite3_stmt;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002F58 File Offset: 0x00001158
		private sqlite3_stmt() : base(IntPtr.Zero, true)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002F66 File Offset: 0x00001166
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003031 File Offset: 0x00001231
		protected override bool ReleaseHandle()
		{
			raw.internal_sqlite3_finalize(this.handle);
			this._db.remove_stmt(this);
			return true;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000304C File Offset: 0x0000124C
		public int manual_close()
		{
			int result = raw.internal_sqlite3_finalize(this.handle);
			this.handle = IntPtr.Zero;
			this._db.remove_stmt(this);
			return result;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00003070 File Offset: 0x00001270
		internal IntPtr ptr
		{
			get
			{
				return this.handle;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00003078 File Offset: 0x00001278
		internal sqlite3 db
		{
			get
			{
				return this._db;
			}
		}

		// Token: 0x040000DF RID: 223
		private sqlite3 _db;
	}
}
