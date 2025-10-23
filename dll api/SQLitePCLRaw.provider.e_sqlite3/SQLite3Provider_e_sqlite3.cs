using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x02000002 RID: 2
	[Preserve(AllMembers = true)]
	public sealed class SQLite3Provider_e_sqlite3 : ISQLite3Provider
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		string ISQLite3Provider.GetNativeLibraryName()
		{
			return "e_sqlite3";
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		private bool my_streq(IntPtr p, IntPtr q, int len)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_strnicmp(p, q, len) == 0;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002064 File Offset: 0x00000264
		private hook_handles get_hooks(sqlite3 db)
		{
			return db.GetOrCreateExtra<hook_handles>(() => new hook_handles(new Func<IntPtr, IntPtr, int, bool>(this.my_streq)));
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002078 File Offset: 0x00000278
		int ISQLite3Provider.sqlite3_win32_set_directory(int typ, utf8z path)
		{
			return 1;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000207C File Offset: 0x0000027C
		unsafe int ISQLite3Provider.sqlite3_open(utf8z filename, out IntPtr db)
		{
			fixed (byte* pinnableReference = filename.GetPinnableReference())
			{
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_open(pinnableReference, out db);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
		unsafe int ISQLite3Provider.sqlite3_open_v2(utf8z filename, out IntPtr db, int flags, utf8z vfs)
		{
			fixed (byte* pinnableReference = filename.GetPinnableReference())
			{
				byte* filename2 = pinnableReference;
				fixed (byte* pinnableReference2 = vfs.GetPinnableReference())
				{
					byte* vfs2 = pinnableReference2;
					return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_open_v2(filename2, out db, flags, vfs2);
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C8 File Offset: 0x000002C8
		unsafe int ISQLite3Provider.sqlite3__vfs__delete(utf8z vfs, utf8z filename, int syncDir)
		{
			fixed (byte* pinnableReference = vfs.GetPinnableReference())
			{
				byte* vfs2 = pinnableReference;
				fixed (byte* pinnableReference2 = filename.GetPinnableReference())
				{
					byte* zName = pinnableReference2;
					IntPtr intPtr = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_vfs_find(vfs2);
					return ((SQLite3Provider_e_sqlite3.sqlite3_vfs)Marshal.PtrToStructure(intPtr, typeof(SQLite3Provider_e_sqlite3.sqlite3_vfs))).xDelete(intPtr, zName, 1);
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002112 File Offset: 0x00000312
		int ISQLite3Provider.sqlite3_close_v2(IntPtr db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_close_v2(db);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000211A File Offset: 0x0000031A
		int ISQLite3Provider.sqlite3_close(IntPtr db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_close(db);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002122 File Offset: 0x00000322
		void ISQLite3Provider.sqlite3_free(IntPtr p)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_free(p);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000212A File Offset: 0x0000032A
		int ISQLite3Provider.sqlite3_stricmp(IntPtr p, IntPtr q)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_stricmp(p, q);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002133 File Offset: 0x00000333
		int ISQLite3Provider.sqlite3_strnicmp(IntPtr p, IntPtr q, int n)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_strnicmp(p, q, n);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000213D File Offset: 0x0000033D
		int ISQLite3Provider.sqlite3_enable_shared_cache(int enable)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_enable_shared_cache(enable);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002145 File Offset: 0x00000345
		void ISQLite3Provider.sqlite3_interrupt(sqlite3 db)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_interrupt(db);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000214D File Offset: 0x0000034D
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_exec))]
		private static int exec_hook_bridge(IntPtr p, int n, IntPtr values_ptr, IntPtr names_ptr)
		{
			return exec_hook_info.from_ptr(p).call(n, values_ptr, names_ptr);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002160 File Offset: 0x00000360
		unsafe int ISQLite3Provider.sqlite3_exec(sqlite3 db, utf8z sql, delegate_exec func, object user_data, out IntPtr errMsg)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.callback_exec cb;
			exec_hook_info target;
			if (func != null)
			{
				cb = new SQLite3Provider_e_sqlite3.NativeMethods.callback_exec(SQLite3Provider_e_sqlite3.exec_hook_bridge);
				target = new exec_hook_info(func, user_data);
			}
			else
			{
				cb = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			int result;
			fixed (byte* pinnableReference = sql.GetPinnableReference())
			{
				byte* strSql = pinnableReference;
				result = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_exec(db, strSql, cb, hook_handle, out errMsg);
			}
			hook_handle.Dispose();
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021B8 File Offset: 0x000003B8
		unsafe int ISQLite3Provider.sqlite3_complete(utf8z sql)
		{
			fixed (byte* pinnableReference = sql.GetPinnableReference())
			{
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_complete(pinnableReference);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021D4 File Offset: 0x000003D4
		utf8z ISQLite3Provider.sqlite3_compileoption_get(int n)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_compileoption_get(n));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021E4 File Offset: 0x000003E4
		unsafe int ISQLite3Provider.sqlite3_compileoption_used(utf8z s)
		{
			fixed (byte* pinnableReference = s.GetPinnableReference())
			{
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_compileoption_used(pinnableReference);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002200 File Offset: 0x00000400
		unsafe int ISQLite3Provider.sqlite3_table_column_metadata(sqlite3 db, utf8z dbName, utf8z tblName, utf8z colName, out utf8z dataType, out utf8z collSeq, out int notNull, out int primaryKey, out int autoInc)
		{
			fixed (byte* pinnableReference = dbName.GetPinnableReference())
			{
				byte* dbName2 = pinnableReference;
				fixed (byte* pinnableReference2 = tblName.GetPinnableReference())
				{
					byte* tblName2 = pinnableReference2;
					fixed (byte* pinnableReference3 = colName.GetPinnableReference())
					{
						byte* colName2 = pinnableReference3;
						byte* p;
						byte* p2;
						int result = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_table_column_metadata(db, dbName2, tblName2, colName2, out p, out p2, out notNull, out primaryKey, out autoInc);
						dataType = utf8z.FromPtr(p);
						collSeq = utf8z.FromPtr(p2);
						return result;
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002078 File Offset: 0x00000278
		int ISQLite3Provider.sqlite3_key(sqlite3 db, ReadOnlySpan<byte> k)
		{
			return 1;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002078 File Offset: 0x00000278
		int ISQLite3Provider.sqlite3_key_v2(sqlite3 db, utf8z name, ReadOnlySpan<byte> k)
		{
			return 1;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002078 File Offset: 0x00000278
		int ISQLite3Provider.sqlite3_rekey(sqlite3 db, ReadOnlySpan<byte> k)
		{
			return 1;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002078 File Offset: 0x00000278
		int ISQLite3Provider.sqlite3_rekey_v2(sqlite3 db, utf8z name, ReadOnlySpan<byte> k)
		{
			return 1;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002264 File Offset: 0x00000464
		unsafe int ISQLite3Provider.sqlite3_prepare_v2(sqlite3 db, ReadOnlySpan<byte> sql, out IntPtr stm, out ReadOnlySpan<byte> tail)
		{
			fixed (byte* pinnableReference = sql.GetPinnableReference())
			{
				byte* ptr = pinnableReference;
				byte* ptr2;
				int result = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_prepare_v2(db, ptr, sql.Length, out stm, out ptr2);
				int num = (int)((long)(ptr2 - ptr));
				int num2 = sql.Length - num;
				if (num2 > 0)
				{
					tail = sql.Slice(num, num2);
					return result;
				}
				tail = ReadOnlySpan<byte>.Empty;
				return result;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022C4 File Offset: 0x000004C4
		unsafe int ISQLite3Provider.sqlite3_prepare_v2(sqlite3 db, utf8z sql, out IntPtr stm, out utf8z tail)
		{
			fixed (byte* pinnableReference = sql.GetPinnableReference())
			{
				byte* pSql = pinnableReference;
				byte* p;
				int result = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_prepare_v2(db, pSql, -1, out stm, out p);
				tail = utf8z.FromPtr(p);
				return result;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022F4 File Offset: 0x000004F4
		unsafe int ISQLite3Provider.sqlite3_prepare_v3(sqlite3 db, ReadOnlySpan<byte> sql, uint flags, out IntPtr stm, out ReadOnlySpan<byte> tail)
		{
			fixed (byte* pinnableReference = sql.GetPinnableReference())
			{
				byte* ptr = pinnableReference;
				byte* ptr2;
				int result = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_prepare_v3(db, ptr, sql.Length, flags, out stm, out ptr2);
				int num = (int)((long)(ptr2 - ptr));
				int num2 = sql.Length - num;
				if (num2 > 0)
				{
					tail = sql.Slice(num, num2);
					return result;
				}
				tail = ReadOnlySpan<byte>.Empty;
				return result;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002358 File Offset: 0x00000558
		unsafe int ISQLite3Provider.sqlite3_prepare_v3(sqlite3 db, utf8z sql, uint flags, out IntPtr stm, out utf8z tail)
		{
			fixed (byte* pinnableReference = sql.GetPinnableReference())
			{
				byte* pSql = pinnableReference;
				byte* p;
				int result = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_prepare_v3(db, pSql, -1, flags, out stm, out p);
				tail = utf8z.FromPtr(p);
				return result;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000238A File Offset: 0x0000058A
		int ISQLite3Provider.sqlite3_db_status(sqlite3 db, int op, out int current, out int highest, int resetFlg)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_db_status(db, op, out current, out highest, resetFlg);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002398 File Offset: 0x00000598
		utf8z ISQLite3Provider.sqlite3_sql(sqlite3_stmt stmt)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_sql(stmt));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000023A5 File Offset: 0x000005A5
		IntPtr ISQLite3Provider.sqlite3_db_handle(IntPtr stmt)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_db_handle(stmt);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023B0 File Offset: 0x000005B0
		unsafe int ISQLite3Provider.sqlite3_blob_open(sqlite3 db, utf8z db_utf8, utf8z table_utf8, utf8z col_utf8, long rowid, int flags, out sqlite3_blob blob)
		{
			fixed (byte* pinnableReference = db_utf8.GetPinnableReference())
			{
				byte* sdb = pinnableReference;
				fixed (byte* pinnableReference2 = table_utf8.GetPinnableReference())
				{
					byte* table = pinnableReference2;
					fixed (byte* pinnableReference3 = col_utf8.GetPinnableReference())
					{
						byte* col = pinnableReference3;
						return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_blob_open(db, sdb, table, col, rowid, flags, out blob);
					}
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000023F1 File Offset: 0x000005F1
		int ISQLite3Provider.sqlite3_blob_bytes(sqlite3_blob blob)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_blob_bytes(blob);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000023F9 File Offset: 0x000005F9
		int ISQLite3Provider.sqlite3_blob_reopen(sqlite3_blob blob, long rowid)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_blob_reopen(blob, rowid);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002404 File Offset: 0x00000604
		unsafe int ISQLite3Provider.sqlite3_blob_read(sqlite3_blob blob, Span<byte> b, int offset)
		{
			fixed (byte* pinnableReference = b.GetPinnableReference())
			{
				byte* b2 = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_blob_read(blob, b2, b.Length, offset);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000242C File Offset: 0x0000062C
		unsafe int ISQLite3Provider.sqlite3_blob_write(sqlite3_blob blob, ReadOnlySpan<byte> b, int offset)
		{
			fixed (byte* pinnableReference = b.GetPinnableReference())
			{
				byte* b2 = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_blob_write(blob, b2, b.Length, offset);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002453 File Offset: 0x00000653
		int ISQLite3Provider.sqlite3_blob_close(IntPtr blob)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_blob_close(blob);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000245C File Offset: 0x0000065C
		unsafe sqlite3_backup ISQLite3Provider.sqlite3_backup_init(sqlite3 destDb, utf8z destName, sqlite3 sourceDb, utf8z sourceName)
		{
			fixed (byte* pinnableReference = destName.GetPinnableReference())
			{
				byte* zDestName = pinnableReference;
				fixed (byte* pinnableReference2 = sourceName.GetPinnableReference())
				{
					byte* zSourceName = pinnableReference2;
					return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_backup_init(destDb, zDestName, sourceDb, zSourceName);
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002488 File Offset: 0x00000688
		int ISQLite3Provider.sqlite3_backup_step(sqlite3_backup backup, int nPage)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_backup_step(backup, nPage);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002491 File Offset: 0x00000691
		int ISQLite3Provider.sqlite3_backup_remaining(sqlite3_backup backup)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_backup_remaining(backup);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002499 File Offset: 0x00000699
		int ISQLite3Provider.sqlite3_backup_pagecount(sqlite3_backup backup)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_backup_pagecount(backup);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024A1 File Offset: 0x000006A1
		int ISQLite3Provider.sqlite3_backup_finish(IntPtr backup)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_backup_finish(backup);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000024A9 File Offset: 0x000006A9
		IntPtr ISQLite3Provider.sqlite3_next_stmt(sqlite3 db, IntPtr stmt)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_next_stmt(db, stmt);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024B2 File Offset: 0x000006B2
		long ISQLite3Provider.sqlite3_last_insert_rowid(sqlite3 db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_last_insert_rowid(db);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024BA File Offset: 0x000006BA
		int ISQLite3Provider.sqlite3_changes(sqlite3 db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_changes(db);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024C2 File Offset: 0x000006C2
		int ISQLite3Provider.sqlite3_total_changes(sqlite3 db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_total_changes(db);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024CA File Offset: 0x000006CA
		int ISQLite3Provider.sqlite3_extended_result_codes(sqlite3 db, int onoff)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_extended_result_codes(db, onoff);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000024D3 File Offset: 0x000006D3
		utf8z ISQLite3Provider.sqlite3_errstr(int rc)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_errstr(rc));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000024E0 File Offset: 0x000006E0
		int ISQLite3Provider.sqlite3_errcode(sqlite3 db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_errcode(db);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000024E8 File Offset: 0x000006E8
		int ISQLite3Provider.sqlite3_extended_errcode(sqlite3 db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_extended_errcode(db);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000024F0 File Offset: 0x000006F0
		int ISQLite3Provider.sqlite3_busy_timeout(sqlite3 db, int ms)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_busy_timeout(db, ms);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000024F9 File Offset: 0x000006F9
		int ISQLite3Provider.sqlite3_get_autocommit(sqlite3 db)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_get_autocommit(db);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002504 File Offset: 0x00000704
		unsafe int ISQLite3Provider.sqlite3_db_readonly(sqlite3 db, utf8z dbName)
		{
			fixed (byte* pinnableReference = dbName.GetPinnableReference())
			{
				byte* dbName2 = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_db_readonly(db, dbName2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002524 File Offset: 0x00000724
		unsafe utf8z ISQLite3Provider.sqlite3_db_filename(sqlite3 db, utf8z att)
		{
			fixed (byte* pinnableReference = att.GetPinnableReference())
			{
				byte* att2 = pinnableReference;
				return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_db_filename(db, att2));
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002548 File Offset: 0x00000748
		utf8z ISQLite3Provider.sqlite3_errmsg(sqlite3 db)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_errmsg(db));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002555 File Offset: 0x00000755
		utf8z ISQLite3Provider.sqlite3_libversion()
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_libversion());
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002561 File Offset: 0x00000761
		int ISQLite3Provider.sqlite3_libversion_number()
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_libversion_number();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002568 File Offset: 0x00000768
		int ISQLite3Provider.sqlite3_threadsafe()
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_threadsafe();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000256F File Offset: 0x0000076F
		int ISQLite3Provider.sqlite3_config(int op)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_config_none(op);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002577 File Offset: 0x00000777
		int ISQLite3Provider.sqlite3_config(int op, int val)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_config_int(op, val);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002580 File Offset: 0x00000780
		int ISQLite3Provider.sqlite3_initialize()
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_initialize();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002587 File Offset: 0x00000787
		int ISQLite3Provider.sqlite3_shutdown()
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_shutdown();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000258E File Offset: 0x0000078E
		int ISQLite3Provider.sqlite3_enable_load_extension(sqlite3 db, int onoff)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_enable_load_extension(db, onoff);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002597 File Offset: 0x00000797
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_commit))]
		private static int commit_hook_bridge_impl(IntPtr p)
		{
			return commit_hook_info.from_ptr(p).call();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000025A4 File Offset: 0x000007A4
		void ISQLite3Provider.sqlite3_commit_hook(sqlite3 db, delegate_commit func, object v)
		{
			hook_handles hook_handles = this.get_hooks(db);
			if (hook_handles.commit != null)
			{
				hook_handles.commit.Dispose();
				hook_handles.commit = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_commit func2;
			commit_hook_info target;
			if (func != null)
			{
				func2 = this.commit_hook_bridge;
				target = new commit_hook_info(func, v);
			}
			else
			{
				func2 = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_commit_hook(db, func2, hook_handle);
			hook_handles.commit = hook_handle.ForDispose();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002607 File Offset: 0x00000807
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_scalar_function))]
		private static void scalar_function_hook_bridge_impl(IntPtr context, int num_args, IntPtr argsptr)
		{
			function_hook_info.from_ptr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_user_data(context)).call_scalar(context, num_args, argsptr);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000261C File Offset: 0x0000081C
		int ISQLite3Provider.sqlite3_create_function(sqlite3 db, byte[] name, int nargs, int flags, object v, delegate_function_scalar func)
		{
			hook_handles hook_handles = this.get_hooks(db);
			hook_handles.RemoveScalarFunction(name, nargs);
			int nType = 1 | flags;
			SQLite3Provider_e_sqlite3.NativeMethods.callback_scalar_function callback_scalar_function;
			function_hook_info target;
			if (func != null)
			{
				callback_scalar_function = this.scalar_function_hook_bridge;
				target = new function_hook_info(func, v);
			}
			else
			{
				callback_scalar_function = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			int num = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_create_function_v2(db, name, nargs, nType, hook_handle, callback_scalar_function, null, null, null);
			if (num == 0 && callback_scalar_function != null)
			{
				hook_handles.AddScalarFunction(name, nargs, hook_handle.ForDispose());
			}
			return num;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002686 File Offset: 0x00000886
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_log))]
		private static void log_hook_bridge_impl(IntPtr p, int rc, IntPtr s)
		{
			log_hook_info.from_ptr(p).call(rc, utf8z.FromIntPtr(s));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000269C File Offset: 0x0000089C
		int ISQLite3Provider.sqlite3_config_log(delegate_log func, object v)
		{
			if (SQLite3Provider_e_sqlite3.disp_log_hook_handle != null)
			{
				SQLite3Provider_e_sqlite3.disp_log_hook_handle.Dispose();
				SQLite3Provider_e_sqlite3.disp_log_hook_handle = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_log func2;
			log_hook_info target;
			if (func != null)
			{
				func2 = this.log_hook_bridge;
				target = new log_hook_info(func, v);
			}
			else
			{
				func2 = null;
				target = null;
			}
			hook_handle pvUser = new hook_handle(target);
			SQLite3Provider_e_sqlite3.disp_log_hook_handle = pvUser;
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_config_log(16, func2, pvUser);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000026F0 File Offset: 0x000008F0
		unsafe void ISQLite3Provider.sqlite3_log(int errcode, utf8z s)
		{
			fixed (byte* pinnableReference = s.GetPinnableReference())
			{
				byte* zFormat = pinnableReference;
				SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_log(errcode, zFormat);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002714 File Offset: 0x00000914
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_step))]
		private static void agg_function_hook_bridge_step_impl(IntPtr context, int num_args, IntPtr argsptr)
		{
			IntPtr agg_context = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_aggregate_context(context, 8);
			function_hook_info.from_ptr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_user_data(context)).call_step(context, agg_context, num_args, argsptr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002740 File Offset: 0x00000940
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_final))]
		private static void agg_function_hook_bridge_final_impl(IntPtr context)
		{
			IntPtr agg_context = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_aggregate_context(context, 8);
			function_hook_info.from_ptr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_user_data(context)).call_final(context, agg_context);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002768 File Offset: 0x00000968
		int ISQLite3Provider.sqlite3_create_function(sqlite3 db, byte[] name, int nargs, int flags, object v, delegate_function_aggregate_step func_step, delegate_function_aggregate_final func_final)
		{
			hook_handles hook_handles = this.get_hooks(db);
			hook_handles.RemoveAggFunction(name, nargs);
			int nType = 1 | flags;
			SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_step callback_agg_function_step;
			SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_final ffinal;
			function_hook_info target;
			if (func_step != null)
			{
				callback_agg_function_step = this.agg_function_hook_bridge_step;
				ffinal = this.agg_function_hook_bridge_final;
				target = new function_hook_info(func_step, func_final, v);
			}
			else
			{
				callback_agg_function_step = null;
				ffinal = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			int num = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_create_function_v2(db, name, nargs, nType, hook_handle, null, callback_agg_function_step, ffinal, null);
			if (num == 0 && callback_agg_function_step != null)
			{
				hook_handles.AddAggFunction(name, nargs, hook_handle.ForDispose());
			}
			return num;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000027E0 File Offset: 0x000009E0
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_collation))]
		private static int collation_hook_bridge_impl(IntPtr p, int len1, IntPtr pv1, int len2, IntPtr pv2)
		{
			collation_hook_info collation_hook_info = collation_hook_info.from_ptr(p);
			ReadOnlySpan<byte> s = new ReadOnlySpan<byte>(pv1.ToPointer(), len1);
			ReadOnlySpan<byte> s2 = new ReadOnlySpan<byte>(pv2.ToPointer(), len2);
			return collation_hook_info.call(s, s2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002818 File Offset: 0x00000A18
		int ISQLite3Provider.sqlite3_create_collation(sqlite3 db, byte[] name, object v, delegate_collation func)
		{
			hook_handles hook_handles = this.get_hooks(db);
			hook_handles.RemoveCollation(name);
			SQLite3Provider_e_sqlite3.NativeMethods.callback_collation callback_collation;
			collation_hook_info target;
			if (func != null)
			{
				callback_collation = this.collation_hook_bridge;
				target = new collation_hook_info(func, v);
			}
			else
			{
				callback_collation = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			int num = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_create_collation(db, name, 1, hook_handle, callback_collation);
			if (num == 0 && callback_collation != null)
			{
				hook_handles.AddCollation(name, hook_handle.ForDispose());
			}
			return num;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002873 File Offset: 0x00000A73
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_update))]
		private static void update_hook_bridge_impl(IntPtr p, int typ, IntPtr db, IntPtr tbl, long rowid)
		{
			update_hook_info.from_ptr(p).call(typ, utf8z.FromIntPtr(db), utf8z.FromIntPtr(tbl), rowid);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002890 File Offset: 0x00000A90
		void ISQLite3Provider.sqlite3_update_hook(sqlite3 db, delegate_update func, object v)
		{
			hook_handles hook_handles = this.get_hooks(db);
			if (hook_handles.update != null)
			{
				hook_handles.update.Dispose();
				hook_handles.update = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_update func2;
			update_hook_info target;
			if (func != null)
			{
				func2 = this.update_hook_bridge;
				target = new update_hook_info(func, v);
			}
			else
			{
				func2 = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			hook_handles.update = hook_handle.ForDispose();
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_update_hook(db, func2, hook_handle);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000028F3 File Offset: 0x00000AF3
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_rollback))]
		private static void rollback_hook_bridge_impl(IntPtr p)
		{
			rollback_hook_info.from_ptr(p).call();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002900 File Offset: 0x00000B00
		void ISQLite3Provider.sqlite3_rollback_hook(sqlite3 db, delegate_rollback func, object v)
		{
			hook_handles hook_handles = this.get_hooks(db);
			if (hook_handles.rollback != null)
			{
				hook_handles.rollback.Dispose();
				hook_handles.rollback = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_rollback func2;
			rollback_hook_info target;
			if (func != null)
			{
				func2 = this.rollback_hook_bridge;
				target = new rollback_hook_info(func, v);
			}
			else
			{
				func2 = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			hook_handles.rollback = hook_handle.ForDispose();
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_rollback_hook(db, func2, hook_handle);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002963 File Offset: 0x00000B63
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_trace))]
		private static void trace_hook_bridge_impl(IntPtr p, IntPtr s)
		{
			trace_hook_info.from_ptr(p).call(utf8z.FromIntPtr(s));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002978 File Offset: 0x00000B78
		void ISQLite3Provider.sqlite3_trace(sqlite3 db, delegate_trace func, object v)
		{
			hook_handles hook_handles = this.get_hooks(db);
			if (hook_handles.trace != null)
			{
				hook_handles.trace.Dispose();
				hook_handles.trace = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_trace func2;
			trace_hook_info target;
			if (func != null)
			{
				func2 = this.trace_hook_bridge;
				target = new trace_hook_info(func, v);
			}
			else
			{
				func2 = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			hook_handles.trace = hook_handle.ForDispose();
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_trace(db, func2, hook_handle);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000029DB File Offset: 0x00000BDB
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_profile))]
		private static void profile_hook_bridge_impl(IntPtr p, IntPtr s, long elapsed)
		{
			profile_hook_info.from_ptr(p).call(utf8z.FromIntPtr(s), elapsed);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000029F0 File Offset: 0x00000BF0
		void ISQLite3Provider.sqlite3_profile(sqlite3 db, delegate_profile func, object v)
		{
			hook_handles hook_handles = this.get_hooks(db);
			if (hook_handles.profile != null)
			{
				hook_handles.profile.Dispose();
				hook_handles.profile = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_profile func2;
			profile_hook_info target;
			if (func != null)
			{
				func2 = this.profile_hook_bridge;
				target = new profile_hook_info(func, v);
			}
			else
			{
				func2 = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			hook_handles.profile = hook_handle.ForDispose();
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_profile(db, func2, hook_handle);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002A53 File Offset: 0x00000C53
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_progress_handler))]
		private static int progress_hook_bridge_impl(IntPtr p)
		{
			return progress_hook_info.from_ptr(p).call();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A60 File Offset: 0x00000C60
		void ISQLite3Provider.sqlite3_progress_handler(sqlite3 db, int instructions, delegate_progress func, object v)
		{
			hook_handles hook_handles = this.get_hooks(db);
			if (hook_handles.progress != null)
			{
				hook_handles.progress.Dispose();
				hook_handles.progress = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_progress_handler func2;
			progress_hook_info target;
			if (func != null)
			{
				func2 = this.progress_hook_bridge;
				target = new progress_hook_info(func, v);
			}
			else
			{
				func2 = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			hook_handles.progress = hook_handle.ForDispose();
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_progress_handler(db, instructions, func2, hook_handle);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002AC5 File Offset: 0x00000CC5
		[MonoPInvokeCallback(typeof(SQLite3Provider_e_sqlite3.NativeMethods.callback_authorizer))]
		private static int authorizer_hook_bridge_impl(IntPtr p, int action_code, IntPtr param0, IntPtr param1, IntPtr dbName, IntPtr inner_most_trigger_or_view)
		{
			return authorizer_hook_info.from_ptr(p).call(action_code, utf8z.FromIntPtr(param0), utf8z.FromIntPtr(param1), utf8z.FromIntPtr(dbName), utf8z.FromIntPtr(inner_most_trigger_or_view));
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002AF0 File Offset: 0x00000CF0
		int ISQLite3Provider.sqlite3_set_authorizer(sqlite3 db, delegate_authorizer func, object v)
		{
			hook_handles hook_handles = this.get_hooks(db);
			if (hook_handles.authorizer != null)
			{
				hook_handles.authorizer.Dispose();
				hook_handles.authorizer = null;
			}
			SQLite3Provider_e_sqlite3.NativeMethods.callback_authorizer cb;
			authorizer_hook_info target;
			if (func != null)
			{
				cb = this.authorizer_hook_bridge;
				target = new authorizer_hook_info(func, v);
			}
			else
			{
				cb = null;
				target = null;
			}
			hook_handle hook_handle = new hook_handle(target);
			hook_handles.authorizer = hook_handle.ForDispose();
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_set_authorizer(db, cb, hook_handle);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002B52 File Offset: 0x00000D52
		long ISQLite3Provider.sqlite3_memory_used()
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_memory_used();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002B59 File Offset: 0x00000D59
		long ISQLite3Provider.sqlite3_memory_highwater(int resetFlag)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_memory_highwater(resetFlag);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002B61 File Offset: 0x00000D61
		int ISQLite3Provider.sqlite3_status(int op, out int current, out int highwater, int resetFlag)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_status(op, out current, out highwater, resetFlag);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002B6D File Offset: 0x00000D6D
		utf8z ISQLite3Provider.sqlite3_sourceid()
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_sourceid());
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002B79 File Offset: 0x00000D79
		void ISQLite3Provider.sqlite3_result_int64(IntPtr ctx, long val)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_int64(ctx, val);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002B82 File Offset: 0x00000D82
		void ISQLite3Provider.sqlite3_result_int(IntPtr ctx, int val)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_int(ctx, val);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002B8B File Offset: 0x00000D8B
		void ISQLite3Provider.sqlite3_result_double(IntPtr ctx, double val)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_double(ctx, val);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002B94 File Offset: 0x00000D94
		void ISQLite3Provider.sqlite3_result_null(IntPtr stm)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_null(stm);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002B9C File Offset: 0x00000D9C
		unsafe void ISQLite3Provider.sqlite3_result_error(IntPtr ctx, ReadOnlySpan<byte> val)
		{
			fixed (byte* pinnableReference = val.GetPinnableReference())
			{
				byte* strErr = pinnableReference;
				SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_error(ctx, strErr, val.Length);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002BC8 File Offset: 0x00000DC8
		unsafe void ISQLite3Provider.sqlite3_result_error(IntPtr ctx, utf8z val)
		{
			fixed (byte* pinnableReference = val.GetPinnableReference())
			{
				byte* strErr = pinnableReference;
				SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_error(ctx, strErr, -1);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002BEC File Offset: 0x00000DEC
		unsafe void ISQLite3Provider.sqlite3_result_text(IntPtr ctx, ReadOnlySpan<byte> val)
		{
			fixed (byte* pinnableReference = val.GetPinnableReference())
			{
				byte* val2 = pinnableReference;
				SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_text(ctx, val2, val.Length, new IntPtr(-1));
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002C1C File Offset: 0x00000E1C
		unsafe void ISQLite3Provider.sqlite3_result_text(IntPtr ctx, utf8z val)
		{
			fixed (byte* pinnableReference = val.GetPinnableReference())
			{
				byte* val2 = pinnableReference;
				SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_text(ctx, val2, -1, new IntPtr(-1));
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002C48 File Offset: 0x00000E48
		unsafe void ISQLite3Provider.sqlite3_result_blob(IntPtr ctx, ReadOnlySpan<byte> blob)
		{
			fixed (byte* pinnableReference = blob.GetPinnableReference())
			{
				byte* value = pinnableReference;
				SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_blob(ctx, (IntPtr)((void*)value), blob.Length, new IntPtr(-1));
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002C7C File Offset: 0x00000E7C
		void ISQLite3Provider.sqlite3_result_zeroblob(IntPtr ctx, int n)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_zeroblob(ctx, n);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002C85 File Offset: 0x00000E85
		void ISQLite3Provider.sqlite3_result_error_toobig(IntPtr ctx)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_error_toobig(ctx);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002C8D File Offset: 0x00000E8D
		void ISQLite3Provider.sqlite3_result_error_nomem(IntPtr ctx)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_error_nomem(ctx);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002C95 File Offset: 0x00000E95
		void ISQLite3Provider.sqlite3_result_error_code(IntPtr ctx, int code)
		{
			SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_result_error_code(ctx, code);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002CA0 File Offset: 0x00000EA0
		ReadOnlySpan<byte> ISQLite3Provider.sqlite3_value_blob(IntPtr p)
		{
			IntPtr value = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_blob(p);
			if (value == IntPtr.Zero)
			{
				return null;
			}
			int length = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_bytes(p);
			return new ReadOnlySpan<byte>(value.ToPointer(), length);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002CDC File Offset: 0x00000EDC
		int ISQLite3Provider.sqlite3_value_bytes(IntPtr p)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_bytes(p);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002CE4 File Offset: 0x00000EE4
		double ISQLite3Provider.sqlite3_value_double(IntPtr p)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_double(p);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002CEC File Offset: 0x00000EEC
		int ISQLite3Provider.sqlite3_value_int(IntPtr p)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_int(p);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002CF4 File Offset: 0x00000EF4
		long ISQLite3Provider.sqlite3_value_int64(IntPtr p)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_int64(p);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002CFC File Offset: 0x00000EFC
		int ISQLite3Provider.sqlite3_value_type(IntPtr p)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_type(p);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002D04 File Offset: 0x00000F04
		utf8z ISQLite3Provider.sqlite3_value_text(IntPtr p)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_value_text(p));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002D11 File Offset: 0x00000F11
		int ISQLite3Provider.sqlite3_bind_int(sqlite3_stmt stm, int paramIndex, int val)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_int(stm, paramIndex, val);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002D1B File Offset: 0x00000F1B
		int ISQLite3Provider.sqlite3_bind_int64(sqlite3_stmt stm, int paramIndex, long val)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_int64(stm, paramIndex, val);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002D28 File Offset: 0x00000F28
		unsafe int ISQLite3Provider.sqlite3_bind_text(sqlite3_stmt stm, int paramIndex, ReadOnlySpan<byte> t)
		{
			fixed (byte* pinnableReference = t.GetPinnableReference())
			{
				byte* val = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_text(stm, paramIndex, val, t.Length, new IntPtr(-1));
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002D58 File Offset: 0x00000F58
		unsafe int ISQLite3Provider.sqlite3_bind_text(sqlite3_stmt stm, int paramIndex, utf8z t)
		{
			fixed (byte* pinnableReference = t.GetPinnableReference())
			{
				byte* val = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_text(stm, paramIndex, val, -1, new IntPtr(-1));
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002D7F File Offset: 0x00000F7F
		int ISQLite3Provider.sqlite3_bind_double(sqlite3_stmt stm, int paramIndex, double val)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_double(stm, paramIndex, val);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002D8C File Offset: 0x00000F8C
		unsafe int ISQLite3Provider.sqlite3_bind_blob(sqlite3_stmt stm, int paramIndex, ReadOnlySpan<byte> blob)
		{
			if (blob.Length == 0)
			{
				fixed (byte* pinnableReference = new byte[]
				{
					42
				}.GetPinnableReference())
				{
					byte* val = pinnableReference;
					return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_blob(stm, paramIndex, val, 0, new IntPtr(-1));
				}
			}
			fixed (byte* pinnableReference = blob.GetPinnableReference())
			{
				byte* val2 = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_blob(stm, paramIndex, val2, blob.Length, new IntPtr(-1));
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002DEE File Offset: 0x00000FEE
		int ISQLite3Provider.sqlite3_bind_zeroblob(sqlite3_stmt stm, int paramIndex, int size)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_zeroblob(stm, paramIndex, size);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002DF8 File Offset: 0x00000FF8
		int ISQLite3Provider.sqlite3_bind_null(sqlite3_stmt stm, int paramIndex)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_null(stm, paramIndex);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002E01 File Offset: 0x00001001
		int ISQLite3Provider.sqlite3_bind_parameter_count(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_parameter_count(stm);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002E09 File Offset: 0x00001009
		utf8z ISQLite3Provider.sqlite3_bind_parameter_name(sqlite3_stmt stm, int paramIndex)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_parameter_name(stm, paramIndex));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002E18 File Offset: 0x00001018
		unsafe int ISQLite3Provider.sqlite3_bind_parameter_index(sqlite3_stmt stm, utf8z paramName)
		{
			fixed (byte* pinnableReference = paramName.GetPinnableReference())
			{
				byte* strName = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_bind_parameter_index(stm, strName);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002E37 File Offset: 0x00001037
		int ISQLite3Provider.sqlite3_step(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_step(stm);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002E3F File Offset: 0x0000103F
		int ISQLite3Provider.sqlite3_stmt_isexplain(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_stmt_isexplain(stm);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002E47 File Offset: 0x00001047
		int ISQLite3Provider.sqlite3_stmt_busy(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_stmt_busy(stm);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002E4F File Offset: 0x0000104F
		int ISQLite3Provider.sqlite3_stmt_readonly(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_stmt_readonly(stm);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002E57 File Offset: 0x00001057
		int ISQLite3Provider.sqlite3_column_int(sqlite3_stmt stm, int columnIndex)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_int(stm, columnIndex);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002E60 File Offset: 0x00001060
		long ISQLite3Provider.sqlite3_column_int64(sqlite3_stmt stm, int columnIndex)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_int64(stm, columnIndex);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002E6C File Offset: 0x0000106C
		unsafe utf8z ISQLite3Provider.sqlite3_column_text(sqlite3_stmt stm, int columnIndex)
		{
			byte* p = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_text(stm, columnIndex);
			int len = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_bytes(stm, columnIndex);
			return utf8z.FromPtrLen(p, len);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002E8E File Offset: 0x0000108E
		utf8z ISQLite3Provider.sqlite3_column_decltype(sqlite3_stmt stm, int columnIndex)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_decltype(stm, columnIndex));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002E9C File Offset: 0x0000109C
		double ISQLite3Provider.sqlite3_column_double(sqlite3_stmt stm, int columnIndex)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_double(stm, columnIndex);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002EA8 File Offset: 0x000010A8
		ReadOnlySpan<byte> ISQLite3Provider.sqlite3_column_blob(sqlite3_stmt stm, int columnIndex)
		{
			IntPtr value = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_blob(stm, columnIndex);
			if (value == IntPtr.Zero)
			{
				return null;
			}
			int length = SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_bytes(stm, columnIndex);
			return new ReadOnlySpan<byte>(value.ToPointer(), length);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002EE6 File Offset: 0x000010E6
		int ISQLite3Provider.sqlite3_column_type(sqlite3_stmt stm, int columnIndex)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_type(stm, columnIndex);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002EEF File Offset: 0x000010EF
		int ISQLite3Provider.sqlite3_column_bytes(sqlite3_stmt stm, int columnIndex)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_bytes(stm, columnIndex);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002EF8 File Offset: 0x000010F8
		int ISQLite3Provider.sqlite3_column_count(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_count(stm);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002F00 File Offset: 0x00001100
		int ISQLite3Provider.sqlite3_data_count(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_data_count(stm);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002F08 File Offset: 0x00001108
		utf8z ISQLite3Provider.sqlite3_column_name(sqlite3_stmt stm, int columnIndex)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_name(stm, columnIndex));
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002F16 File Offset: 0x00001116
		utf8z ISQLite3Provider.sqlite3_column_origin_name(sqlite3_stmt stm, int columnIndex)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_origin_name(stm, columnIndex));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002F24 File Offset: 0x00001124
		utf8z ISQLite3Provider.sqlite3_column_table_name(sqlite3_stmt stm, int columnIndex)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_table_name(stm, columnIndex));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002F32 File Offset: 0x00001132
		utf8z ISQLite3Provider.sqlite3_column_database_name(sqlite3_stmt stm, int columnIndex)
		{
			return utf8z.FromPtr(SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_column_database_name(stm, columnIndex));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002F40 File Offset: 0x00001140
		int ISQLite3Provider.sqlite3_reset(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_reset(stm);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002F48 File Offset: 0x00001148
		int ISQLite3Provider.sqlite3_clear_bindings(sqlite3_stmt stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_clear_bindings(stm);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002F50 File Offset: 0x00001150
		int ISQLite3Provider.sqlite3_stmt_status(sqlite3_stmt stm, int op, int resetFlg)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_stmt_status(stm, op, resetFlg);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002F5A File Offset: 0x0000115A
		int ISQLite3Provider.sqlite3_finalize(IntPtr stm)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_finalize(stm);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002F62 File Offset: 0x00001162
		int ISQLite3Provider.sqlite3_wal_autocheckpoint(sqlite3 db, int n)
		{
			return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_wal_autocheckpoint(db, n);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002F6C File Offset: 0x0000116C
		unsafe int ISQLite3Provider.sqlite3_wal_checkpoint(sqlite3 db, utf8z dbName)
		{
			fixed (byte* pinnableReference = dbName.GetPinnableReference())
			{
				byte* dbName2 = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_wal_checkpoint(db, dbName2);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002F8C File Offset: 0x0000118C
		unsafe int ISQLite3Provider.sqlite3_wal_checkpoint_v2(sqlite3 db, utf8z dbName, int eMode, out int logSize, out int framesCheckPointed)
		{
			fixed (byte* pinnableReference = dbName.GetPinnableReference())
			{
				byte* dbName2 = pinnableReference;
				return SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_wal_checkpoint_v2(db, dbName2, eMode, out logSize, out framesCheckPointed);
			}
		}

		// Token: 0x04000001 RID: 1
		private const CallingConvention CALLING_CONVENTION = CallingConvention.Cdecl;

		// Token: 0x04000002 RID: 2
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_commit commit_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_commit(SQLite3Provider_e_sqlite3.commit_hook_bridge_impl);

		// Token: 0x04000003 RID: 3
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_scalar_function scalar_function_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_scalar_function(SQLite3Provider_e_sqlite3.scalar_function_hook_bridge_impl);

		// Token: 0x04000004 RID: 4
		private static IDisposable disp_log_hook_handle;

		// Token: 0x04000005 RID: 5
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_log log_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_log(SQLite3Provider_e_sqlite3.log_hook_bridge_impl);

		// Token: 0x04000006 RID: 6
		private SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_step agg_function_hook_bridge_step = new SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_step(SQLite3Provider_e_sqlite3.agg_function_hook_bridge_step_impl);

		// Token: 0x04000007 RID: 7
		private SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_final agg_function_hook_bridge_final = new SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_final(SQLite3Provider_e_sqlite3.agg_function_hook_bridge_final_impl);

		// Token: 0x04000008 RID: 8
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_collation collation_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_collation(SQLite3Provider_e_sqlite3.collation_hook_bridge_impl);

		// Token: 0x04000009 RID: 9
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_update update_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_update(SQLite3Provider_e_sqlite3.update_hook_bridge_impl);

		// Token: 0x0400000A RID: 10
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_rollback rollback_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_rollback(SQLite3Provider_e_sqlite3.rollback_hook_bridge_impl);

		// Token: 0x0400000B RID: 11
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_trace trace_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_trace(SQLite3Provider_e_sqlite3.trace_hook_bridge_impl);

		// Token: 0x0400000C RID: 12
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_profile profile_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_profile(SQLite3Provider_e_sqlite3.profile_hook_bridge_impl);

		// Token: 0x0400000D RID: 13
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_progress_handler progress_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_progress_handler(SQLite3Provider_e_sqlite3.progress_hook_bridge_impl);

		// Token: 0x0400000E RID: 14
		private readonly SQLite3Provider_e_sqlite3.NativeMethods.callback_authorizer authorizer_hook_bridge = new SQLite3Provider_e_sqlite3.NativeMethods.callback_authorizer(SQLite3Provider_e_sqlite3.authorizer_hook_bridge_impl);

		// Token: 0x02000003 RID: 3
		private struct sqlite3_vfs
		{
			// Token: 0x0400000F RID: 15
			public int iVersion;

			// Token: 0x04000010 RID: 16
			public int szOsFile;

			// Token: 0x04000011 RID: 17
			public int mxPathname;

			// Token: 0x04000012 RID: 18
			public IntPtr pNext;

			// Token: 0x04000013 RID: 19
			public IntPtr zName;

			// Token: 0x04000014 RID: 20
			public IntPtr pAppData;

			// Token: 0x04000015 RID: 21
			public IntPtr xOpen;

			// Token: 0x04000016 RID: 22
			public SQLite3Provider_e_sqlite3.sqlite3_vfs.SQLiteDeleteDelegate xDelete;

			// Token: 0x04000017 RID: 23
			public IntPtr xAccess;

			// Token: 0x04000018 RID: 24
			public IntPtr xFullPathname;

			// Token: 0x04000019 RID: 25
			public IntPtr xDlOpen;

			// Token: 0x0400001A RID: 26
			public IntPtr xDlError;

			// Token: 0x0400001B RID: 27
			public IntPtr xDlSym;

			// Token: 0x0400001C RID: 28
			public IntPtr xDlClose;

			// Token: 0x0400001D RID: 29
			public IntPtr xRandomness;

			// Token: 0x0400001E RID: 30
			public IntPtr xSleep;

			// Token: 0x0400001F RID: 31
			public IntPtr xCurrentTime;

			// Token: 0x04000020 RID: 32
			public IntPtr xGetLastError;

			// Token: 0x02000004 RID: 4
			// (Invoke) Token: 0x06000097 RID: 151
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate int SQLiteDeleteDelegate(IntPtr pVfs, byte* zName, int syncDir);
		}

		// Token: 0x02000005 RID: 5
		private static class NativeMethods
		{
			// Token: 0x0600009A RID: 154
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_close(IntPtr db);

			// Token: 0x0600009B RID: 155
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_close_v2(IntPtr db);

			// Token: 0x0600009C RID: 156
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_enable_shared_cache(int enable);

			// Token: 0x0600009D RID: 157
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_interrupt(sqlite3 db);

			// Token: 0x0600009E RID: 158
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_finalize(IntPtr stmt);

			// Token: 0x0600009F RID: 159
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_reset(sqlite3_stmt stmt);

			// Token: 0x060000A0 RID: 160
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_clear_bindings(sqlite3_stmt stmt);

			// Token: 0x060000A1 RID: 161
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_stmt_status(sqlite3_stmt stm, int op, int resetFlg);

			// Token: 0x060000A2 RID: 162
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_bind_parameter_name(sqlite3_stmt stmt, int index);

			// Token: 0x060000A3 RID: 163
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_column_database_name(sqlite3_stmt stmt, int index);

			// Token: 0x060000A4 RID: 164
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_column_decltype(sqlite3_stmt stmt, int index);

			// Token: 0x060000A5 RID: 165
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_column_name(sqlite3_stmt stmt, int index);

			// Token: 0x060000A6 RID: 166
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_column_origin_name(sqlite3_stmt stmt, int index);

			// Token: 0x060000A7 RID: 167
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_column_table_name(sqlite3_stmt stmt, int index);

			// Token: 0x060000A8 RID: 168
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_column_text(sqlite3_stmt stmt, int index);

			// Token: 0x060000A9 RID: 169
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_errmsg(sqlite3 db);

			// Token: 0x060000AA RID: 170
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_db_readonly(sqlite3 db, byte* dbName);

			// Token: 0x060000AB RID: 171
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_db_filename(sqlite3 db, byte* att);

			// Token: 0x060000AC RID: 172
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_prepare_v2(sqlite3 db, byte* pSql, int nBytes, out IntPtr stmt, out byte* ptrRemain);

			// Token: 0x060000AD RID: 173
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_prepare_v3(sqlite3 db, byte* pSql, int nBytes, uint flags, out IntPtr stmt, out byte* ptrRemain);

			// Token: 0x060000AE RID: 174
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_db_status(sqlite3 db, int op, out int current, out int highest, int resetFlg);

			// Token: 0x060000AF RID: 175
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_complete(byte* pSql);

			// Token: 0x060000B0 RID: 176
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_compileoption_used(byte* pSql);

			// Token: 0x060000B1 RID: 177
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_compileoption_get(int n);

			// Token: 0x060000B2 RID: 178
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_table_column_metadata(sqlite3 db, byte* dbName, byte* tblName, byte* colName, out byte* ptrDataType, out byte* ptrCollSeq, out int notNull, out int primaryKey, out int autoInc);

			// Token: 0x060000B3 RID: 179
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_value_text(IntPtr p);

			// Token: 0x060000B4 RID: 180
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_enable_load_extension(sqlite3 db, int enable);

			// Token: 0x060000B5 RID: 181
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_load_extension(sqlite3 db, byte[] fileName, byte[] procName, ref IntPtr pError);

			// Token: 0x060000B6 RID: 182
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_initialize();

			// Token: 0x060000B7 RID: 183
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_shutdown();

			// Token: 0x060000B8 RID: 184
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_libversion();

			// Token: 0x060000B9 RID: 185
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_libversion_number();

			// Token: 0x060000BA RID: 186
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_threadsafe();

			// Token: 0x060000BB RID: 187
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_sourceid();

			// Token: 0x060000BC RID: 188
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_malloc(int n);

			// Token: 0x060000BD RID: 189
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_realloc(IntPtr p, int n);

			// Token: 0x060000BE RID: 190
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_free(IntPtr p);

			// Token: 0x060000BF RID: 191
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_stricmp(IntPtr p, IntPtr q);

			// Token: 0x060000C0 RID: 192
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_strnicmp(IntPtr p, IntPtr q, int n);

			// Token: 0x060000C1 RID: 193
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_open(byte* filename, out IntPtr db);

			// Token: 0x060000C2 RID: 194
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_open_v2(byte* filename, out IntPtr db, int flags, byte* vfs);

			// Token: 0x060000C3 RID: 195
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern IntPtr sqlite3_vfs_find(byte* vfs);

			// Token: 0x060000C4 RID: 196
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern long sqlite3_last_insert_rowid(sqlite3 db);

			// Token: 0x060000C5 RID: 197
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_changes(sqlite3 db);

			// Token: 0x060000C6 RID: 198
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_total_changes(sqlite3 db);

			// Token: 0x060000C7 RID: 199
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern long sqlite3_memory_used();

			// Token: 0x060000C8 RID: 200
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern long sqlite3_memory_highwater(int resetFlag);

			// Token: 0x060000C9 RID: 201
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_status(int op, out int current, out int highwater, int resetFlag);

			// Token: 0x060000CA RID: 202
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_busy_timeout(sqlite3 db, int ms);

			// Token: 0x060000CB RID: 203
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_bind_blob(sqlite3_stmt stmt, int index, byte* val, int nSize, IntPtr nTransient);

			// Token: 0x060000CC RID: 204
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_bind_zeroblob(sqlite3_stmt stmt, int index, int size);

			// Token: 0x060000CD RID: 205
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_bind_double(sqlite3_stmt stmt, int index, double val);

			// Token: 0x060000CE RID: 206
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_bind_int(sqlite3_stmt stmt, int index, int val);

			// Token: 0x060000CF RID: 207
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_bind_int64(sqlite3_stmt stmt, int index, long val);

			// Token: 0x060000D0 RID: 208
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_bind_null(sqlite3_stmt stmt, int index);

			// Token: 0x060000D1 RID: 209
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_bind_text(sqlite3_stmt stmt, int index, byte* val, int nlen, IntPtr pvReserved);

			// Token: 0x060000D2 RID: 210
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_bind_parameter_count(sqlite3_stmt stmt);

			// Token: 0x060000D3 RID: 211
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_bind_parameter_index(sqlite3_stmt stmt, byte* strName);

			// Token: 0x060000D4 RID: 212
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_column_count(sqlite3_stmt stmt);

			// Token: 0x060000D5 RID: 213
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_data_count(sqlite3_stmt stmt);

			// Token: 0x060000D6 RID: 214
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_step(sqlite3_stmt stmt);

			// Token: 0x060000D7 RID: 215
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_sql(sqlite3_stmt stmt);

			// Token: 0x060000D8 RID: 216
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern double sqlite3_column_double(sqlite3_stmt stmt, int index);

			// Token: 0x060000D9 RID: 217
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_column_int(sqlite3_stmt stmt, int index);

			// Token: 0x060000DA RID: 218
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern long sqlite3_column_int64(sqlite3_stmt stmt, int index);

			// Token: 0x060000DB RID: 219
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_column_blob(sqlite3_stmt stmt, int index);

			// Token: 0x060000DC RID: 220
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_column_bytes(sqlite3_stmt stmt, int index);

			// Token: 0x060000DD RID: 221
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_column_type(sqlite3_stmt stmt, int index);

			// Token: 0x060000DE RID: 222
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_aggregate_count(IntPtr context);

			// Token: 0x060000DF RID: 223
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_value_blob(IntPtr p);

			// Token: 0x060000E0 RID: 224
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_value_bytes(IntPtr p);

			// Token: 0x060000E1 RID: 225
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern double sqlite3_value_double(IntPtr p);

			// Token: 0x060000E2 RID: 226
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_value_int(IntPtr p);

			// Token: 0x060000E3 RID: 227
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern long sqlite3_value_int64(IntPtr p);

			// Token: 0x060000E4 RID: 228
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_value_type(IntPtr p);

			// Token: 0x060000E5 RID: 229
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_user_data(IntPtr context);

			// Token: 0x060000E6 RID: 230
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_blob(IntPtr context, IntPtr val, int nSize, IntPtr pvReserved);

			// Token: 0x060000E7 RID: 231
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_double(IntPtr context, double val);

			// Token: 0x060000E8 RID: 232
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern void sqlite3_result_error(IntPtr context, byte* strErr, int nLen);

			// Token: 0x060000E9 RID: 233
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_int(IntPtr context, int val);

			// Token: 0x060000EA RID: 234
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_int64(IntPtr context, long val);

			// Token: 0x060000EB RID: 235
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_null(IntPtr context);

			// Token: 0x060000EC RID: 236
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern void sqlite3_result_text(IntPtr context, byte* val, int nLen, IntPtr pvReserved);

			// Token: 0x060000ED RID: 237
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_zeroblob(IntPtr context, int n);

			// Token: 0x060000EE RID: 238
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_error_toobig(IntPtr context);

			// Token: 0x060000EF RID: 239
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_error_nomem(IntPtr context);

			// Token: 0x060000F0 RID: 240
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern void sqlite3_result_error_code(IntPtr context, int code);

			// Token: 0x060000F1 RID: 241
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes);

			// Token: 0x060000F2 RID: 242
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_config", ExactSpelling = true)]
			public static extern int sqlite3_config_none(int op);

			// Token: 0x060000F3 RID: 243
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_config", ExactSpelling = true)]
			public static extern int sqlite3_config_int(int op, int val);

			// Token: 0x060000F4 RID: 244
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_config", ExactSpelling = true)]
			public static extern int sqlite3_config_log(int op, SQLite3Provider_e_sqlite3.NativeMethods.callback_log func, hook_handle pvUser);

			// Token: 0x060000F5 RID: 245
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_create_collation(sqlite3 db, byte[] strName, int nType, hook_handle pvUser, SQLite3Provider_e_sqlite3.NativeMethods.callback_collation func);

			// Token: 0x060000F6 RID: 246
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_update_hook(sqlite3 db, SQLite3Provider_e_sqlite3.NativeMethods.callback_update func, hook_handle pvUser);

			// Token: 0x060000F7 RID: 247
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_commit_hook(sqlite3 db, SQLite3Provider_e_sqlite3.NativeMethods.callback_commit func, hook_handle pvUser);

			// Token: 0x060000F8 RID: 248
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_profile(sqlite3 db, SQLite3Provider_e_sqlite3.NativeMethods.callback_profile func, hook_handle pvUser);

			// Token: 0x060000F9 RID: 249
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_progress_handler(sqlite3 db, int instructions, SQLite3Provider_e_sqlite3.NativeMethods.callback_progress_handler func, hook_handle pvUser);

			// Token: 0x060000FA RID: 250
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_trace(sqlite3 db, SQLite3Provider_e_sqlite3.NativeMethods.callback_trace func, hook_handle pvUser);

			// Token: 0x060000FB RID: 251
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_rollback_hook(sqlite3 db, SQLite3Provider_e_sqlite3.NativeMethods.callback_rollback func, hook_handle pvUser);

			// Token: 0x060000FC RID: 252
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_db_handle(IntPtr stmt);

			// Token: 0x060000FD RID: 253
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern IntPtr sqlite3_next_stmt(sqlite3 db, IntPtr stmt);

			// Token: 0x060000FE RID: 254
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_stmt_isexplain(sqlite3_stmt stmt);

			// Token: 0x060000FF RID: 255
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_stmt_busy(sqlite3_stmt stmt);

			// Token: 0x06000100 RID: 256
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_stmt_readonly(sqlite3_stmt stmt);

			// Token: 0x06000101 RID: 257
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_exec(sqlite3 db, byte* strSql, SQLite3Provider_e_sqlite3.NativeMethods.callback_exec cb, hook_handle pvParam, out IntPtr errMsg);

			// Token: 0x06000102 RID: 258
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_get_autocommit(sqlite3 db);

			// Token: 0x06000103 RID: 259
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_extended_result_codes(sqlite3 db, int onoff);

			// Token: 0x06000104 RID: 260
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_errcode(sqlite3 db);

			// Token: 0x06000105 RID: 261
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_extended_errcode(sqlite3 db);

			// Token: 0x06000106 RID: 262
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern byte* sqlite3_errstr(int rc);

			// Token: 0x06000107 RID: 263
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern void sqlite3_log(int iErrCode, byte* zFormat);

			// Token: 0x06000108 RID: 264
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_file_control(sqlite3 db, byte[] zDbName, int op, IntPtr pArg);

			// Token: 0x06000109 RID: 265
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern sqlite3_backup sqlite3_backup_init(sqlite3 destDb, byte* zDestName, sqlite3 sourceDb, byte* zSourceName);

			// Token: 0x0600010A RID: 266
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_backup_step(sqlite3_backup backup, int nPage);

			// Token: 0x0600010B RID: 267
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_backup_remaining(sqlite3_backup backup);

			// Token: 0x0600010C RID: 268
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_backup_pagecount(sqlite3_backup backup);

			// Token: 0x0600010D RID: 269
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_backup_finish(IntPtr backup);

			// Token: 0x0600010E RID: 270
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_blob_open(sqlite3 db, byte* sdb, byte* table, byte* col, long rowid, int flags, out sqlite3_blob blob);

			// Token: 0x0600010F RID: 271
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_blob_write(sqlite3_blob blob, byte* b, int n, int offset);

			// Token: 0x06000110 RID: 272
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_blob_read(sqlite3_blob blob, byte* b, int n, int offset);

			// Token: 0x06000111 RID: 273
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_blob_bytes(sqlite3_blob blob);

			// Token: 0x06000112 RID: 274
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_blob_reopen(sqlite3_blob blob, long rowid);

			// Token: 0x06000113 RID: 275
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_blob_close(IntPtr blob);

			// Token: 0x06000114 RID: 276
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_wal_autocheckpoint(sqlite3 db, int n);

			// Token: 0x06000115 RID: 277
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_wal_checkpoint(sqlite3 db, byte* dbName);

			// Token: 0x06000116 RID: 278
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public unsafe static extern int sqlite3_wal_checkpoint_v2(sqlite3 db, byte* dbName, int eMode, out int logSize, out int framesCheckPointed);

			// Token: 0x06000117 RID: 279
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_set_authorizer(sqlite3 db, SQLite3Provider_e_sqlite3.NativeMethods.callback_authorizer cb, hook_handle pvUser);

			// Token: 0x06000118 RID: 280
			[DllImport("e_sqlite3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
			public static extern int sqlite3_create_function_v2(sqlite3 db, byte[] strName, int nArgs, int nType, hook_handle pvUser, SQLite3Provider_e_sqlite3.NativeMethods.callback_scalar_function func, SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_step fstep, SQLite3Provider_e_sqlite3.NativeMethods.callback_agg_function_final ffinal, SQLite3Provider_e_sqlite3.NativeMethods.callback_destroy fdestroy);

			// Token: 0x04000021 RID: 33
			private const string SQLITE_DLL = "e_sqlite3";

			// Token: 0x02000006 RID: 6
			// (Invoke) Token: 0x0600011A RID: 282
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_log(IntPtr pUserData, int errorCode, IntPtr pMessage);

			// Token: 0x02000007 RID: 7
			// (Invoke) Token: 0x0600011E RID: 286
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_scalar_function(IntPtr context, int nArgs, IntPtr argsptr);

			// Token: 0x02000008 RID: 8
			// (Invoke) Token: 0x06000122 RID: 290
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_agg_function_step(IntPtr context, int nArgs, IntPtr argsptr);

			// Token: 0x02000009 RID: 9
			// (Invoke) Token: 0x06000126 RID: 294
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_agg_function_final(IntPtr context);

			// Token: 0x0200000A RID: 10
			// (Invoke) Token: 0x0600012A RID: 298
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_destroy(IntPtr p);

			// Token: 0x0200000B RID: 11
			// (Invoke) Token: 0x0600012E RID: 302
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate int callback_collation(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2);

			// Token: 0x0200000C RID: 12
			// (Invoke) Token: 0x06000132 RID: 306
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_update(IntPtr p, int typ, IntPtr db, IntPtr tbl, long rowid);

			// Token: 0x0200000D RID: 13
			// (Invoke) Token: 0x06000136 RID: 310
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate int callback_commit(IntPtr puser);

			// Token: 0x0200000E RID: 14
			// (Invoke) Token: 0x0600013A RID: 314
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_profile(IntPtr puser, IntPtr statement, long elapsed);

			// Token: 0x0200000F RID: 15
			// (Invoke) Token: 0x0600013E RID: 318
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate int callback_progress_handler(IntPtr puser);

			// Token: 0x02000010 RID: 16
			// (Invoke) Token: 0x06000142 RID: 322
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate int callback_authorizer(IntPtr puser, int action_code, IntPtr param0, IntPtr param1, IntPtr dbName, IntPtr inner_most_trigger_or_view);

			// Token: 0x02000011 RID: 17
			// (Invoke) Token: 0x06000146 RID: 326
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_trace(IntPtr puser, IntPtr statement);

			// Token: 0x02000012 RID: 18
			// (Invoke) Token: 0x0600014A RID: 330
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void callback_rollback(IntPtr puser);

			// Token: 0x02000013 RID: 19
			// (Invoke) Token: 0x0600014E RID: 334
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate int callback_exec(IntPtr db, int n, IntPtr values, IntPtr names);
		}
	}
}
