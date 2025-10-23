using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000019 RID: 25
	public class sqlite3 : SafeHandle
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00002F58 File Offset: 0x00001158
		private sqlite3() : base(IntPtr.Zero, true)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002F66 File Offset: 0x00001166
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003080 File Offset: 0x00001280
		protected override bool ReleaseHandle()
		{
			raw.internal_sqlite3_close_v2(this.handle);
			this.dispose_extra();
			return true;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003095 File Offset: 0x00001295
		public int manual_close_v2()
		{
			int result = raw.internal_sqlite3_close_v2(this.handle);
			this.handle = IntPtr.Zero;
			this.dispose_extra();
			return result;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000030B3 File Offset: 0x000012B3
		public int manual_close()
		{
			int result = raw.internal_sqlite3_close(this.handle);
			this.handle = IntPtr.Zero;
			this.dispose_extra();
			return result;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000030D1 File Offset: 0x000012D1
		internal static sqlite3 New(IntPtr p)
		{
			sqlite3 sqlite = new sqlite3();
			sqlite.SetHandle(p);
			return sqlite;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000030DF File Offset: 0x000012DF
		public void enable_sqlite3_next_stmt(bool enabled)
		{
			if (enabled)
			{
				if (this._stmts == null)
				{
					this._stmts = new ConcurrentDictionary<IntPtr, sqlite3_stmt>();
					return;
				}
			}
			else
			{
				this._stmts = null;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000030FF File Offset: 0x000012FF
		internal void add_stmt(sqlite3_stmt stmt)
		{
			if (this._stmts != null)
			{
				this._stmts[stmt.ptr] = stmt;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000311B File Offset: 0x0000131B
		internal sqlite3_stmt find_stmt(IntPtr p)
		{
			if (this._stmts != null)
			{
				return this._stmts[p];
			}
			throw new Exception("The sqlite3_next_stmt() function is disabled.  To enable it, call sqlite3.enable_sqlite3_next_stmt(true) immediately after opening the sqlite3 connection.");
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000313C File Offset: 0x0000133C
		internal void remove_stmt(sqlite3_stmt s)
		{
			if (this._stmts != null)
			{
				sqlite3_stmt sqlite3_stmt;
				this._stmts.TryRemove(s.ptr, out sqlite3_stmt);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003168 File Offset: 0x00001368
		public T GetOrCreateExtra<T>(Func<T> f) where T : class, IDisposable
		{
			if (this.extra != null)
			{
				return (T)((object)this.extra);
			}
			T t = f();
			this.extra = t;
			return t;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000319D File Offset: 0x0000139D
		private void dispose_extra()
		{
			if (this.extra != null)
			{
				this.extra.Dispose();
				this.extra = null;
			}
		}

		// Token: 0x040000E0 RID: 224
		private ConcurrentDictionary<IntPtr, sqlite3_stmt> _stmts;

		// Token: 0x040000E1 RID: 225
		private IDisposable extra;
	}
}
