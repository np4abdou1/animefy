using System;
using System.Text;

namespace SQLitePCL
{
	// Token: 0x0200000C RID: 12
	public static class raw
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002060 File Offset: 0x00000260
		public static void SetProvider(ISQLite3Provider imp)
		{
			if (raw._frozen)
			{
				return;
			}
			imp.sqlite3_libversion_number();
			raw._imp = imp;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002077 File Offset: 0x00000277
		public static void FreezeProvider(bool b = true)
		{
			raw._frozen = b;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000207F File Offset: 0x0000027F
		private static ISQLite3Provider Provider
		{
			get
			{
				if (raw._imp == null)
				{
					throw new Exception("You need to call SQLitePCL.raw.SetProvider().  If you are using a bundle package, this is done by calling SQLitePCL.Batteries.Init().");
				}
				return raw._imp;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002098 File Offset: 0x00000298
		public static string GetNativeLibraryName()
		{
			return raw.Provider.GetNativeLibraryName();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020A4 File Offset: 0x000002A4
		public static int sqlite3_open(utf8z filename, out sqlite3 db)
		{
			IntPtr p;
			int result = raw.Provider.sqlite3_open(filename, out p);
			db = sqlite3.New(p);
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020C6 File Offset: 0x000002C6
		public static int sqlite3_open(string filename, out sqlite3 db)
		{
			return raw.sqlite3_open(filename.to_utf8z(), out db);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020D4 File Offset: 0x000002D4
		public static int sqlite3_open_v2(utf8z filename, out sqlite3 db, int flags, utf8z vfs)
		{
			IntPtr p;
			int result = raw.Provider.sqlite3_open_v2(filename, out p, flags, vfs);
			db = sqlite3.New(p);
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020F8 File Offset: 0x000002F8
		public static int sqlite3_open_v2(string filename, out sqlite3 db, int flags, string vfs)
		{
			return raw.sqlite3_open_v2(filename.to_utf8z(), out db, flags, vfs.to_utf8z());
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000210D File Offset: 0x0000030D
		public static int sqlite3__vfs__delete(utf8z vfs, utf8z pathname, int syncdir)
		{
			return raw.Provider.sqlite3__vfs__delete(vfs, pathname, syncdir);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000211C File Offset: 0x0000031C
		public static int sqlite3__vfs__delete(string vfs, string pathname, int syncdir)
		{
			return raw.sqlite3__vfs__delete(vfs.to_utf8z(), pathname.to_utf8z(), syncdir);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002130 File Offset: 0x00000330
		internal static int internal_sqlite3_close_v2(IntPtr p)
		{
			return raw.Provider.sqlite3_close_v2(p);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000213D File Offset: 0x0000033D
		internal static int internal_sqlite3_close(IntPtr p)
		{
			return raw.Provider.sqlite3_close(p);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000214A File Offset: 0x0000034A
		public static int sqlite3_close_v2(sqlite3 db)
		{
			return db.manual_close_v2();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002152 File Offset: 0x00000352
		public static int sqlite3_close(sqlite3 db)
		{
			return db.manual_close();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000215A File Offset: 0x0000035A
		public static int sqlite3_enable_shared_cache(int enable)
		{
			return raw.Provider.sqlite3_enable_shared_cache(enable);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002167 File Offset: 0x00000367
		public static void sqlite3_interrupt(sqlite3 db)
		{
			raw.Provider.sqlite3_interrupt(db);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002174 File Offset: 0x00000374
		public static int sqlite3_config_log(delegate_log f, object v)
		{
			return raw.Provider.sqlite3_config_log(f, v);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002184 File Offset: 0x00000384
		public static int sqlite3_config_log(strdelegate_log f, object v)
		{
			delegate_log f2;
			if (f == null)
			{
				f2 = null;
			}
			else
			{
				f2 = delegate(object ob, int e, utf8z msg)
				{
					f(ob, e, msg.utf8_to_string());
				};
			}
			return raw.sqlite3_config_log(f2, v);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000021BE File Offset: 0x000003BE
		public static void sqlite3_log(int errcode, utf8z s)
		{
			raw.Provider.sqlite3_log(errcode, s);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021CC File Offset: 0x000003CC
		public static void sqlite3_log(int errcode, string s)
		{
			raw.sqlite3_log(errcode, s.to_utf8z());
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021DA File Offset: 0x000003DA
		public static void sqlite3_commit_hook(sqlite3 db, delegate_commit f, object v)
		{
			raw.Provider.sqlite3_commit_hook(db, f, v);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021E9 File Offset: 0x000003E9
		public static void sqlite3_rollback_hook(sqlite3 db, delegate_rollback f, object v)
		{
			raw.Provider.sqlite3_rollback_hook(db, f, v);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021F8 File Offset: 0x000003F8
		public static void sqlite3_trace(sqlite3 db, delegate_trace f, object v)
		{
			raw.Provider.sqlite3_trace(db, f, v);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002208 File Offset: 0x00000408
		public static void sqlite3_trace(sqlite3 db, strdelegate_trace f, object v)
		{
			delegate_trace f2;
			if (f == null)
			{
				f2 = null;
			}
			else
			{
				f2 = delegate(object ob, utf8z sp)
				{
					f(v, sp.utf8_to_string());
				};
			}
			raw.sqlite3_trace(db, f2, v);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000224F File Offset: 0x0000044F
		public static void sqlite3_profile(sqlite3 db, delegate_profile f, object v)
		{
			raw.Provider.sqlite3_profile(db, f, v);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002260 File Offset: 0x00000460
		public static void sqlite3_profile(sqlite3 db, strdelegate_profile f, object v)
		{
			delegate_profile f2;
			if (f == null)
			{
				f2 = null;
			}
			else
			{
				f2 = delegate(object ob, utf8z sp, long ns)
				{
					f(v, sp.utf8_to_string(), ns);
				};
			}
			raw.sqlite3_profile(db, f2, v);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000022A7 File Offset: 0x000004A7
		public static void sqlite3_progress_handler(sqlite3 db, int instructions, delegate_progress func, object v)
		{
			raw.Provider.sqlite3_progress_handler(db, instructions, func, v);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000022B7 File Offset: 0x000004B7
		public static void sqlite3_update_hook(sqlite3 db, delegate_update f, object v)
		{
			raw.Provider.sqlite3_update_hook(db, f, v);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022C8 File Offset: 0x000004C8
		public static void sqlite3_update_hook(sqlite3 db, strdelegate_update f, object v)
		{
			delegate_update f2;
			if (f == null)
			{
				f2 = null;
			}
			else
			{
				f2 = delegate(object ob, int typ, utf8z dbname, utf8z tbl, long rowid)
				{
					f(ob, typ, dbname.utf8_to_string(), tbl.utf8_to_string(), rowid);
				};
			}
			raw.sqlite3_update_hook(db, f2, v);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002304 File Offset: 0x00000504
		public static int sqlite3_create_collation(sqlite3 db, string name, object v, strdelegate_collation f)
		{
			byte[] name2 = name.to_utf8_with_z();
			delegate_collation func;
			if (f == null)
			{
				func = null;
			}
			else
			{
				func = ((object ob, ReadOnlySpan<byte> s1, ReadOnlySpan<byte> s2) => f(ob, s1.utf8_span_to_string(), s2.utf8_span_to_string()));
			}
			return raw.Provider.sqlite3_create_collation(db, name2, v, func);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000234C File Offset: 0x0000054C
		public static int sqlite3_create_function(sqlite3 db, string name, int nArg, int flags, object v, delegate_function_scalar func)
		{
			byte[] name2 = name.to_utf8_with_z();
			return raw.Provider.sqlite3_create_function(db, name2, nArg, flags, v, func);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002374 File Offset: 0x00000574
		public static int sqlite3_create_function(sqlite3 db, string name, int nArg, int flags, object v, delegate_function_aggregate_step func_step, delegate_function_aggregate_final func_final)
		{
			byte[] name2 = name.to_utf8_with_z();
			return raw.Provider.sqlite3_create_function(db, name2, nArg, flags, v, func_step, func_final);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000239C File Offset: 0x0000059C
		public static int sqlite3_create_function(sqlite3 db, string name, int nArg, object v, delegate_function_scalar func)
		{
			return raw.sqlite3_create_function(db, name, nArg, 0, v, func);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000023AA File Offset: 0x000005AA
		public static int sqlite3_create_function(sqlite3 db, string name, int nArg, object v, delegate_function_aggregate_step func_step, delegate_function_aggregate_final func_final)
		{
			return raw.sqlite3_create_function(db, name, nArg, 0, v, func_step, func_final);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000023BA File Offset: 0x000005BA
		public static int sqlite3_db_status(sqlite3 db, int op, out int current, out int highest, int resetFlg)
		{
			return raw.Provider.sqlite3_db_status(db, op, out current, out highest, resetFlg);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000023CC File Offset: 0x000005CC
		public unsafe static string utf8_span_to_string(this ReadOnlySpan<byte> p)
		{
			if (p.Length == 0)
			{
				return "";
			}
			fixed (byte* pinnableReference = p.GetPinnableReference())
			{
				byte* bytes = pinnableReference;
				return Encoding.UTF8.GetString(bytes, p.Length);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002405 File Offset: 0x00000605
		public static int sqlite3_key(sqlite3 db, ReadOnlySpan<byte> k)
		{
			return raw.Provider.sqlite3_key(db, k);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002413 File Offset: 0x00000613
		public static int sqlite3_key_v2(sqlite3 db, utf8z name, ReadOnlySpan<byte> k)
		{
			return raw.Provider.sqlite3_key_v2(db, name, k);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002422 File Offset: 0x00000622
		public static int sqlite3_rekey(sqlite3 db, ReadOnlySpan<byte> k)
		{
			return raw.Provider.sqlite3_rekey(db, k);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002430 File Offset: 0x00000630
		public static int sqlite3_rekey_v2(sqlite3 db, utf8z name, ReadOnlySpan<byte> k)
		{
			return raw.Provider.sqlite3_rekey_v2(db, name, k);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000243F File Offset: 0x0000063F
		public static utf8z sqlite3_libversion()
		{
			return raw.Provider.sqlite3_libversion();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000244B File Offset: 0x0000064B
		public static int sqlite3_libversion_number()
		{
			return raw.Provider.sqlite3_libversion_number();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002457 File Offset: 0x00000657
		public static int sqlite3_threadsafe()
		{
			return raw.Provider.sqlite3_threadsafe();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002463 File Offset: 0x00000663
		public static int sqlite3_initialize()
		{
			return raw.Provider.sqlite3_initialize();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000246F File Offset: 0x0000066F
		public static int sqlite3_shutdown()
		{
			return raw.Provider.sqlite3_shutdown();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000247B File Offset: 0x0000067B
		public static int sqlite3_config(int op)
		{
			return raw.Provider.sqlite3_config(op);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002488 File Offset: 0x00000688
		public static int sqlite3_config(int op, int val)
		{
			return raw.Provider.sqlite3_config(op, val);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002496 File Offset: 0x00000696
		public static int sqlite3_enable_load_extension(sqlite3 db, int onoff)
		{
			return raw.Provider.sqlite3_enable_load_extension(db, onoff);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000024A4 File Offset: 0x000006A4
		public static utf8z sqlite3_sourceid()
		{
			return raw.Provider.sqlite3_sourceid();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000024B0 File Offset: 0x000006B0
		public static long sqlite3_memory_used()
		{
			return raw.Provider.sqlite3_memory_used();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000024BC File Offset: 0x000006BC
		public static long sqlite3_memory_highwater(int resetFlag)
		{
			return raw.Provider.sqlite3_memory_highwater(resetFlag);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000024C9 File Offset: 0x000006C9
		public static int sqlite3_status(int op, out int current, out int highwater, int resetFlag)
		{
			return raw.Provider.sqlite3_status(op, out current, out highwater, resetFlag);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000024D9 File Offset: 0x000006D9
		public static utf8z sqlite3_errmsg(sqlite3 db)
		{
			return raw.Provider.sqlite3_errmsg(db);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000024E6 File Offset: 0x000006E6
		public static int sqlite3_db_readonly(sqlite3 db, utf8z dbName)
		{
			return raw.Provider.sqlite3_db_readonly(db, dbName);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000024F4 File Offset: 0x000006F4
		public static int sqlite3_db_readonly(sqlite3 db, string dbName)
		{
			return raw.sqlite3_db_readonly(db, dbName.to_utf8z());
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002502 File Offset: 0x00000702
		public static utf8z sqlite3_db_filename(sqlite3 db, utf8z att)
		{
			return raw.Provider.sqlite3_db_filename(db, att);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002510 File Offset: 0x00000710
		public static utf8z sqlite3_db_filename(sqlite3 db, string att)
		{
			return raw.sqlite3_db_filename(db, att.to_utf8z());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000251E File Offset: 0x0000071E
		public static long sqlite3_last_insert_rowid(sqlite3 db)
		{
			return raw.Provider.sqlite3_last_insert_rowid(db);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000252B File Offset: 0x0000072B
		public static int sqlite3_changes(sqlite3 db)
		{
			return raw.Provider.sqlite3_changes(db);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002538 File Offset: 0x00000738
		public static int sqlite3_total_changes(sqlite3 db)
		{
			return raw.Provider.sqlite3_total_changes(db);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002545 File Offset: 0x00000745
		public static int sqlite3_get_autocommit(sqlite3 db)
		{
			return raw.Provider.sqlite3_get_autocommit(db);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002552 File Offset: 0x00000752
		public static int sqlite3_busy_timeout(sqlite3 db, int ms)
		{
			return raw.Provider.sqlite3_busy_timeout(db, ms);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002560 File Offset: 0x00000760
		public static int sqlite3_extended_result_codes(sqlite3 db, int onoff)
		{
			return raw.Provider.sqlite3_extended_result_codes(db, onoff);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000256E File Offset: 0x0000076E
		public static int sqlite3_errcode(sqlite3 db)
		{
			return raw.Provider.sqlite3_errcode(db);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000257B File Offset: 0x0000077B
		public static int sqlite3_extended_errcode(sqlite3 db)
		{
			return raw.Provider.sqlite3_extended_errcode(db);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002588 File Offset: 0x00000788
		public static utf8z sqlite3_errstr(int rc)
		{
			return raw.Provider.sqlite3_errstr(rc);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002598 File Offset: 0x00000798
		public static int sqlite3_prepare_v2(sqlite3 db, ReadOnlySpan<byte> sql, out sqlite3_stmt stmt)
		{
			IntPtr p;
			ReadOnlySpan<byte> readOnlySpan;
			int result = raw.Provider.sqlite3_prepare_v2(db, sql, out p, out readOnlySpan);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000025C0 File Offset: 0x000007C0
		public static int sqlite3_prepare_v2(sqlite3 db, utf8z sql, out sqlite3_stmt stmt)
		{
			IntPtr p;
			utf8z utf8z;
			int result = raw.Provider.sqlite3_prepare_v2(db, sql, out p, out utf8z);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000025E6 File Offset: 0x000007E6
		public static int sqlite3_prepare_v2(sqlite3 db, string sql, out sqlite3_stmt stmt)
		{
			return raw.sqlite3_prepare_v2(db, sql.to_utf8z(), out stmt);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000025F8 File Offset: 0x000007F8
		public static int sqlite3_prepare_v2(sqlite3 db, ReadOnlySpan<byte> sql, out sqlite3_stmt stmt, out ReadOnlySpan<byte> tail)
		{
			IntPtr p;
			int result = raw.Provider.sqlite3_prepare_v2(db, sql, out p, out tail);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002620 File Offset: 0x00000820
		public static int sqlite3_prepare_v2(sqlite3 db, utf8z sql, out sqlite3_stmt stmt, out utf8z tail)
		{
			IntPtr p;
			int result = raw.Provider.sqlite3_prepare_v2(db, sql, out p, out tail);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002648 File Offset: 0x00000848
		public static int sqlite3_prepare_v2(sqlite3 db, string sql, out sqlite3_stmt stmt, out string tail)
		{
			byte[] array = sql.to_utf8_with_z();
			ReadOnlySpan<byte> sql2 = new ReadOnlySpan<byte>(array);
			ReadOnlySpan<byte> readOnlySpan;
			int result = raw.sqlite3_prepare_v2(db, sql2, out stmt, out readOnlySpan);
			tail = readOnlySpan.Slice(0, readOnlySpan.Length - 1).utf8_span_to_string();
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002688 File Offset: 0x00000888
		public static int sqlite3_prepare_v3(sqlite3 db, ReadOnlySpan<byte> sql, uint flags, out sqlite3_stmt stmt)
		{
			IntPtr p;
			ReadOnlySpan<byte> readOnlySpan;
			int result = raw.Provider.sqlite3_prepare_v3(db, sql, flags, out p, out readOnlySpan);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000026B0 File Offset: 0x000008B0
		public static int sqlite3_prepare_v3(sqlite3 db, utf8z sql, uint flags, out sqlite3_stmt stmt)
		{
			IntPtr p;
			utf8z utf8z;
			int result = raw.Provider.sqlite3_prepare_v3(db, sql, flags, out p, out utf8z);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000026D7 File Offset: 0x000008D7
		public static int sqlite3_prepare_v3(sqlite3 db, string sql, uint flags, out sqlite3_stmt stmt)
		{
			return raw.sqlite3_prepare_v3(db, sql.to_utf8z(), flags, out stmt);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000026E8 File Offset: 0x000008E8
		public static int sqlite3_prepare_v3(sqlite3 db, ReadOnlySpan<byte> sql, uint flags, out sqlite3_stmt stmt, out ReadOnlySpan<byte> tail)
		{
			IntPtr p;
			int result = raw.Provider.sqlite3_prepare_v3(db, sql, flags, out p, out tail);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002710 File Offset: 0x00000910
		public static int sqlite3_prepare_v3(sqlite3 db, utf8z sql, uint flags, out sqlite3_stmt stmt, out utf8z tail)
		{
			IntPtr p;
			int result = raw.Provider.sqlite3_prepare_v3(db, sql, flags, out p, out tail);
			stmt = sqlite3_stmt.From(p, db);
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002738 File Offset: 0x00000938
		public static int sqlite3_prepare_v3(sqlite3 db, string sql, uint flags, out sqlite3_stmt stmt, out string tail)
		{
			utf8z utf8z;
			int result = raw.sqlite3_prepare_v3(db, sql.to_utf8z(), flags, out stmt, out utf8z);
			tail = utf8z.utf8_to_string();
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002760 File Offset: 0x00000960
		public static int sqlite3_exec(sqlite3 db, string sql, strdelegate_exec callback, object user_data, out string errMsg)
		{
			delegate_exec callback2;
			if (callback != null)
			{
				callback2 = delegate(object ob, IntPtr[] values, IntPtr[] names)
				{
					string[] array = new string[values.Length];
					string[] array2 = new string[names.Length];
					for (int i = 0; i < values.Length; i++)
					{
						array[i] = util.from_utf8_z(values[i]);
						array2[i] = util.from_utf8_z(names[i]);
					}
					return callback(ob, array, array2);
				};
			}
			else
			{
				callback2 = null;
			}
			IntPtr intPtr;
			int result = raw.Provider.sqlite3_exec(db, sql.to_utf8z(), callback2, user_data, out intPtr);
			if (intPtr == IntPtr.Zero)
			{
				errMsg = null;
				return result;
			}
			errMsg = util.from_utf8_z(intPtr);
			raw.Provider.sqlite3_free(intPtr);
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000027D0 File Offset: 0x000009D0
		public static int sqlite3_exec(sqlite3 db, string sql, out string errMsg)
		{
			IntPtr intPtr;
			int result = raw.Provider.sqlite3_exec(db, sql.to_utf8z(), null, null, out intPtr);
			if (intPtr == IntPtr.Zero)
			{
				errMsg = null;
				return result;
			}
			errMsg = util.from_utf8_z(intPtr);
			raw.Provider.sqlite3_free(intPtr);
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002818 File Offset: 0x00000A18
		public static int sqlite3_exec(sqlite3 db, string sql)
		{
			IntPtr intPtr;
			int result = raw.Provider.sqlite3_exec(db, sql.to_utf8z(), null, null, out intPtr);
			if (!(intPtr == IntPtr.Zero))
			{
				raw.Provider.sqlite3_free(intPtr);
			}
			return result;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002852 File Offset: 0x00000A52
		public static int sqlite3_step(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_step(stmt);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000285F File Offset: 0x00000A5F
		public static int sqlite3_finalize(sqlite3_stmt stmt)
		{
			return stmt.manual_close();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002867 File Offset: 0x00000A67
		public static int internal_sqlite3_finalize(IntPtr stmt)
		{
			return raw.Provider.sqlite3_finalize(stmt);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002874 File Offset: 0x00000A74
		public static int sqlite3_reset(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_reset(stmt);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002881 File Offset: 0x00000A81
		public static int sqlite3_clear_bindings(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_clear_bindings(stmt);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000288E File Offset: 0x00000A8E
		public static int sqlite3_stmt_status(sqlite3_stmt stmt, int op, int resetFlg)
		{
			return raw.Provider.sqlite3_stmt_status(stmt, op, resetFlg);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000289D File Offset: 0x00000A9D
		public static int sqlite3_complete(utf8z sql)
		{
			return raw.Provider.sqlite3_complete(sql);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000028AA File Offset: 0x00000AAA
		public static int sqlite3_complete(string sql)
		{
			return raw.sqlite3_complete(sql.to_utf8z());
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000028B7 File Offset: 0x00000AB7
		public static int sqlite3_compileoption_used(utf8z s)
		{
			return raw.Provider.sqlite3_compileoption_used(s);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000028C4 File Offset: 0x00000AC4
		public static int sqlite3_compileoption_used(string s)
		{
			return raw.sqlite3_compileoption_used(s.to_utf8z());
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000028D1 File Offset: 0x00000AD1
		public static utf8z sqlite3_compileoption_get(int n)
		{
			return raw.Provider.sqlite3_compileoption_get(n);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000028E0 File Offset: 0x00000AE0
		public static int sqlite3_table_column_metadata(sqlite3 db, utf8z dbName, utf8z tblName, utf8z colName, out utf8z dataType, out utf8z collSeq, out int notNull, out int primaryKey, out int autoInc)
		{
			return raw.Provider.sqlite3_table_column_metadata(db, dbName, tblName, colName, out dataType, out collSeq, out notNull, out primaryKey, out autoInc);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002908 File Offset: 0x00000B08
		public static int sqlite3_table_column_metadata(sqlite3 db, string dbName, string tblName, string colName, out string dataType, out string collSeq, out int notNull, out int primaryKey, out int autoInc)
		{
			utf8z utf8z;
			utf8z utf8z2;
			int result = raw.sqlite3_table_column_metadata(db, dbName.to_utf8z(), tblName.to_utf8z(), colName.to_utf8z(), out utf8z, out utf8z2, out notNull, out primaryKey, out autoInc);
			dataType = utf8z.utf8_to_string();
			collSeq = utf8z2.utf8_to_string();
			return result;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000294B File Offset: 0x00000B4B
		public static utf8z sqlite3_sql(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_sql(stmt);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002958 File Offset: 0x00000B58
		public static sqlite3 sqlite3_db_handle(sqlite3_stmt stmt)
		{
			return stmt.db;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002960 File Offset: 0x00000B60
		public static sqlite3_stmt sqlite3_next_stmt(sqlite3 db, sqlite3_stmt stmt)
		{
			IntPtr intPtr = raw.Provider.sqlite3_next_stmt(db, (stmt != null) ? stmt.ptr : IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return db.find_stmt(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000299F File Offset: 0x00000B9F
		public static int sqlite3_bind_zeroblob(sqlite3_stmt stmt, int index, int size)
		{
			return raw.Provider.sqlite3_bind_zeroblob(stmt, index, size);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000029AE File Offset: 0x00000BAE
		public static utf8z sqlite3_bind_parameter_name(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_bind_parameter_name(stmt, index);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000029BC File Offset: 0x00000BBC
		public static object sqlite3_user_data(sqlite3_context context)
		{
			return context.user_data;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000029C4 File Offset: 0x00000BC4
		public static void sqlite3_result_null(sqlite3_context context)
		{
			raw.Provider.sqlite3_result_null(context.ptr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000029D6 File Offset: 0x00000BD6
		public static void sqlite3_result_blob(sqlite3_context context, ReadOnlySpan<byte> val)
		{
			raw.Provider.sqlite3_result_blob(context.ptr, val);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000029E9 File Offset: 0x00000BE9
		public static void sqlite3_result_error(sqlite3_context context, ReadOnlySpan<byte> val)
		{
			raw.Provider.sqlite3_result_error(context.ptr, val);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000029FC File Offset: 0x00000BFC
		public static void sqlite3_result_error(sqlite3_context context, utf8z val)
		{
			raw.Provider.sqlite3_result_error(context.ptr, val);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002A0F File Offset: 0x00000C0F
		public static void sqlite3_result_error(sqlite3_context context, string val)
		{
			raw.sqlite3_result_error(context, val.to_utf8z());
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002A1D File Offset: 0x00000C1D
		public static void sqlite3_result_text(sqlite3_context context, ReadOnlySpan<byte> val)
		{
			raw.Provider.sqlite3_result_text(context.ptr, val);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002A30 File Offset: 0x00000C30
		public static void sqlite3_result_text(sqlite3_context context, utf8z val)
		{
			raw.Provider.sqlite3_result_text(context.ptr, val);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002A43 File Offset: 0x00000C43
		public static void sqlite3_result_text(sqlite3_context context, string val)
		{
			raw.sqlite3_result_text(context, val.to_utf8z());
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002A51 File Offset: 0x00000C51
		public static void sqlite3_result_double(sqlite3_context context, double val)
		{
			raw.Provider.sqlite3_result_double(context.ptr, val);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002A64 File Offset: 0x00000C64
		public static void sqlite3_result_int(sqlite3_context context, int val)
		{
			raw.Provider.sqlite3_result_int(context.ptr, val);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002A77 File Offset: 0x00000C77
		public static void sqlite3_result_int64(sqlite3_context context, long val)
		{
			raw.Provider.sqlite3_result_int64(context.ptr, val);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002A8A File Offset: 0x00000C8A
		public static void sqlite3_result_zeroblob(sqlite3_context context, int n)
		{
			raw.Provider.sqlite3_result_zeroblob(context.ptr, n);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002A9D File Offset: 0x00000C9D
		public static void sqlite3_result_error_toobig(sqlite3_context context)
		{
			raw.Provider.sqlite3_result_error_toobig(context.ptr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002AAF File Offset: 0x00000CAF
		public static void sqlite3_result_error_nomem(sqlite3_context context)
		{
			raw.Provider.sqlite3_result_error_nomem(context.ptr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002AC1 File Offset: 0x00000CC1
		public static void sqlite3_result_error_code(sqlite3_context context, int code)
		{
			raw.Provider.sqlite3_result_error_code(context.ptr, code);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public static ReadOnlySpan<byte> sqlite3_value_blob(sqlite3_value val)
		{
			return raw.Provider.sqlite3_value_blob(val.ptr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002AE6 File Offset: 0x00000CE6
		public static int sqlite3_value_bytes(sqlite3_value val)
		{
			return raw.Provider.sqlite3_value_bytes(val.ptr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public static double sqlite3_value_double(sqlite3_value val)
		{
			return raw.Provider.sqlite3_value_double(val.ptr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002B0A File Offset: 0x00000D0A
		public static int sqlite3_value_int(sqlite3_value val)
		{
			return raw.Provider.sqlite3_value_int(val.ptr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002B1C File Offset: 0x00000D1C
		public static long sqlite3_value_int64(sqlite3_value val)
		{
			return raw.Provider.sqlite3_value_int64(val.ptr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002B2E File Offset: 0x00000D2E
		public static int sqlite3_value_type(sqlite3_value val)
		{
			return raw.Provider.sqlite3_value_type(val.ptr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002B40 File Offset: 0x00000D40
		public static utf8z sqlite3_value_text(sqlite3_value val)
		{
			return raw.Provider.sqlite3_value_text(val.ptr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002B52 File Offset: 0x00000D52
		public static int sqlite3_bind_blob(sqlite3_stmt stmt, int index, ReadOnlySpan<byte> blob)
		{
			return raw.Provider.sqlite3_bind_blob(stmt, index, blob);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002B61 File Offset: 0x00000D61
		public static int sqlite3_bind_double(sqlite3_stmt stmt, int index, double val)
		{
			return raw.Provider.sqlite3_bind_double(stmt, index, val);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002B70 File Offset: 0x00000D70
		public static int sqlite3_bind_int(sqlite3_stmt stmt, int index, int val)
		{
			return raw.Provider.sqlite3_bind_int(stmt, index, val);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002B7F File Offset: 0x00000D7F
		public static int sqlite3_bind_int64(sqlite3_stmt stmt, int index, long val)
		{
			return raw.Provider.sqlite3_bind_int64(stmt, index, val);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002B8E File Offset: 0x00000D8E
		public static int sqlite3_bind_null(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_bind_null(stmt, index);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002B9C File Offset: 0x00000D9C
		public static int sqlite3_bind_text(sqlite3_stmt stmt, int index, ReadOnlySpan<byte> val)
		{
			return raw.Provider.sqlite3_bind_text(stmt, index, val);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002BAB File Offset: 0x00000DAB
		public static int sqlite3_bind_text(sqlite3_stmt stmt, int index, utf8z val)
		{
			return raw.Provider.sqlite3_bind_text(stmt, index, val);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002BBA File Offset: 0x00000DBA
		public static int sqlite3_bind_text(sqlite3_stmt stmt, int index, string val)
		{
			return raw.sqlite3_bind_text(stmt, index, val.to_utf8z());
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002BC9 File Offset: 0x00000DC9
		public static int sqlite3_bind_parameter_count(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_bind_parameter_count(stmt);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public static int sqlite3_bind_parameter_index(sqlite3_stmt stmt, utf8z strName)
		{
			return raw.Provider.sqlite3_bind_parameter_index(stmt, strName);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public static int sqlite3_bind_parameter_index(sqlite3_stmt stmt, string strName)
		{
			return raw.sqlite3_bind_parameter_index(stmt, strName.to_utf8z());
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public static int sqlite3_stmt_isexplain(sqlite3_stmt stmt)
		{
			return raw._imp.sqlite3_stmt_isexplain(stmt);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002BFF File Offset: 0x00000DFF
		public static int sqlite3_stmt_busy(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_stmt_busy(stmt);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002C0C File Offset: 0x00000E0C
		public static int sqlite3_stmt_readonly(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_stmt_readonly(stmt);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002C19 File Offset: 0x00000E19
		public static utf8z sqlite3_column_database_name(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_database_name(stmt, index);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002C27 File Offset: 0x00000E27
		public static utf8z sqlite3_column_name(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_name(stmt, index);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002C35 File Offset: 0x00000E35
		public static utf8z sqlite3_column_origin_name(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_origin_name(stmt, index);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002C43 File Offset: 0x00000E43
		public static utf8z sqlite3_column_table_name(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_table_name(stmt, index);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002C51 File Offset: 0x00000E51
		public static utf8z sqlite3_column_text(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_text(stmt, index);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002C5F File Offset: 0x00000E5F
		public static int sqlite3_column_count(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_column_count(stmt);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002C6C File Offset: 0x00000E6C
		public static int sqlite3_data_count(sqlite3_stmt stmt)
		{
			return raw.Provider.sqlite3_data_count(stmt);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002C79 File Offset: 0x00000E79
		public static double sqlite3_column_double(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_double(stmt, index);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002C87 File Offset: 0x00000E87
		public static int sqlite3_column_int(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_int(stmt, index);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002C95 File Offset: 0x00000E95
		public static long sqlite3_column_int64(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_int64(stmt, index);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002CA3 File Offset: 0x00000EA3
		public static ReadOnlySpan<byte> sqlite3_column_blob(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_blob(stmt, index);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002CB1 File Offset: 0x00000EB1
		public static int sqlite3_column_bytes(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_bytes(stmt, index);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002CBF File Offset: 0x00000EBF
		public static int sqlite3_column_type(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_type(stmt, index);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002CCD File Offset: 0x00000ECD
		public static utf8z sqlite3_column_decltype(sqlite3_stmt stmt, int index)
		{
			return raw.Provider.sqlite3_column_decltype(stmt, index);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002CDB File Offset: 0x00000EDB
		public static sqlite3_backup sqlite3_backup_init(sqlite3 destDb, string destName, sqlite3 sourceDb, string sourceName)
		{
			return raw.Provider.sqlite3_backup_init(destDb, destName.to_utf8z(), sourceDb, sourceName.to_utf8z());
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002CF5 File Offset: 0x00000EF5
		public static int sqlite3_backup_step(sqlite3_backup backup, int nPage)
		{
			return raw.Provider.sqlite3_backup_step(backup, nPage);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002D03 File Offset: 0x00000F03
		public static int sqlite3_backup_remaining(sqlite3_backup backup)
		{
			return raw.Provider.sqlite3_backup_remaining(backup);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002D10 File Offset: 0x00000F10
		public static int sqlite3_backup_pagecount(sqlite3_backup backup)
		{
			return raw.Provider.sqlite3_backup_pagecount(backup);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002D1D File Offset: 0x00000F1D
		public static int sqlite3_backup_finish(sqlite3_backup backup)
		{
			return backup.manual_close();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002D25 File Offset: 0x00000F25
		internal static int internal_sqlite3_backup_finish(IntPtr p)
		{
			return raw.Provider.sqlite3_backup_finish(p);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002D32 File Offset: 0x00000F32
		public static int sqlite3_blob_open(sqlite3 db, utf8z db_utf8, utf8z table_utf8, utf8z col_utf8, long rowid, int flags, out sqlite3_blob blob)
		{
			return raw.Provider.sqlite3_blob_open(db, db_utf8, table_utf8, col_utf8, rowid, flags, out blob);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002D48 File Offset: 0x00000F48
		public static int sqlite3_blob_open(sqlite3 db, string sdb, string table, string col, long rowid, int flags, out sqlite3_blob blob)
		{
			return raw.sqlite3_blob_open(db, sdb.to_utf8z(), table.to_utf8z(), col.to_utf8z(), rowid, flags, out blob);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002D68 File Offset: 0x00000F68
		public static int sqlite3_blob_bytes(sqlite3_blob blob)
		{
			return raw.Provider.sqlite3_blob_bytes(blob);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002D75 File Offset: 0x00000F75
		public static int sqlite3_blob_reopen(sqlite3_blob blob, long rowid)
		{
			return raw.Provider.sqlite3_blob_reopen(blob, rowid);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002D83 File Offset: 0x00000F83
		public static int sqlite3_blob_write(sqlite3_blob blob, ReadOnlySpan<byte> b, int offset)
		{
			return raw.Provider.sqlite3_blob_write(blob, b, offset);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002D92 File Offset: 0x00000F92
		public static int sqlite3_blob_read(sqlite3_blob blob, Span<byte> b, int offset)
		{
			return raw.Provider.sqlite3_blob_read(blob, b, offset);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002DA1 File Offset: 0x00000FA1
		public static int sqlite3_blob_close(sqlite3_blob blob)
		{
			return blob.manual_close();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002DA9 File Offset: 0x00000FA9
		internal static int internal_sqlite3_blob_close(IntPtr blob)
		{
			return raw.Provider.sqlite3_blob_close(blob);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public static int sqlite3_wal_autocheckpoint(sqlite3 db, int n)
		{
			return raw.Provider.sqlite3_wal_autocheckpoint(db, n);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public static int sqlite3_wal_checkpoint(sqlite3 db, string dbName)
		{
			return raw.Provider.sqlite3_wal_checkpoint(db, dbName.to_utf8z());
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public static int sqlite3_wal_checkpoint_v2(sqlite3 db, string dbName, int eMode, out int logSize, out int framesCheckPointed)
		{
			return raw.Provider.sqlite3_wal_checkpoint_v2(db, dbName.to_utf8z(), eMode, out logSize, out framesCheckPointed);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002DEE File Offset: 0x00000FEE
		public static int sqlite3_set_authorizer(sqlite3 db, delegate_authorizer f, object user_data)
		{
			return raw.Provider.sqlite3_set_authorizer(db, f, user_data);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002E00 File Offset: 0x00001000
		public static int sqlite3_set_authorizer(sqlite3 db, strdelegate_authorizer f, object user_data)
		{
			delegate_authorizer f2;
			if (f == null)
			{
				f2 = null;
			}
			else
			{
				f2 = ((object ob, int a, utf8z p0, utf8z p1, utf8z dbname, utf8z v) => f(ob, a, p0.utf8_to_string(), p1.utf8_to_string(), dbname.utf8_to_string(), v.utf8_to_string()));
			}
			return raw.sqlite3_set_authorizer(db, f2, user_data);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002E3B File Offset: 0x0000103B
		public static int sqlite3_win32_set_directory(int typ, string path)
		{
			return raw.Provider.sqlite3_win32_set_directory(typ, path.to_utf8z());
		}

		// Token: 0x04000001 RID: 1
		private static ISQLite3Provider _imp;

		// Token: 0x04000002 RID: 2
		private static bool _frozen = false;

		// Token: 0x04000003 RID: 3
		public const int SQLITE_UTF8 = 1;

		// Token: 0x04000004 RID: 4
		public const int SQLITE_UTF16LE = 2;

		// Token: 0x04000005 RID: 5
		public const int SQLITE_UTF16BE = 3;

		// Token: 0x04000006 RID: 6
		public const int SQLITE_UTF16 = 4;

		// Token: 0x04000007 RID: 7
		public const int SQLITE_ANY = 5;

		// Token: 0x04000008 RID: 8
		public const int SQLITE_UTF16_ALIGNED = 8;

		// Token: 0x04000009 RID: 9
		public const int SQLITE_DETERMINISTIC = 2048;

		// Token: 0x0400000A RID: 10
		public const int SQLITE_CONFIG_SINGLETHREAD = 1;

		// Token: 0x0400000B RID: 11
		public const int SQLITE_CONFIG_MULTITHREAD = 2;

		// Token: 0x0400000C RID: 12
		public const int SQLITE_CONFIG_SERIALIZED = 3;

		// Token: 0x0400000D RID: 13
		public const int SQLITE_CONFIG_MALLOC = 4;

		// Token: 0x0400000E RID: 14
		public const int SQLITE_CONFIG_GETMALLOC = 5;

		// Token: 0x0400000F RID: 15
		public const int SQLITE_CONFIG_SCRATCH = 6;

		// Token: 0x04000010 RID: 16
		public const int SQLITE_CONFIG_PAGECACHE = 7;

		// Token: 0x04000011 RID: 17
		public const int SQLITE_CONFIG_HEAP = 8;

		// Token: 0x04000012 RID: 18
		public const int SQLITE_CONFIG_MEMSTATUS = 9;

		// Token: 0x04000013 RID: 19
		public const int SQLITE_CONFIG_MUTEX = 10;

		// Token: 0x04000014 RID: 20
		public const int SQLITE_CONFIG_GETMUTEX = 11;

		// Token: 0x04000015 RID: 21
		public const int SQLITE_CONFIG_LOOKASIDE = 13;

		// Token: 0x04000016 RID: 22
		public const int SQLITE_CONFIG_PCACHE = 14;

		// Token: 0x04000017 RID: 23
		public const int SQLITE_CONFIG_GETPCACHE = 15;

		// Token: 0x04000018 RID: 24
		public const int SQLITE_CONFIG_LOG = 16;

		// Token: 0x04000019 RID: 25
		public const int SQLITE_CONFIG_URI = 17;

		// Token: 0x0400001A RID: 26
		public const int SQLITE_CONFIG_PCACHE2 = 18;

		// Token: 0x0400001B RID: 27
		public const int SQLITE_CONFIG_GETPCACHE2 = 19;

		// Token: 0x0400001C RID: 28
		public const int SQLITE_CONFIG_COVERING_INDEX_SCAN = 20;

		// Token: 0x0400001D RID: 29
		public const int SQLITE_CONFIG_SQLLOG = 21;

		// Token: 0x0400001E RID: 30
		public const int SQLITE_OPEN_READONLY = 1;

		// Token: 0x0400001F RID: 31
		public const int SQLITE_OPEN_READWRITE = 2;

		// Token: 0x04000020 RID: 32
		public const int SQLITE_OPEN_CREATE = 4;

		// Token: 0x04000021 RID: 33
		public const int SQLITE_OPEN_DELETEONCLOSE = 8;

		// Token: 0x04000022 RID: 34
		public const int SQLITE_OPEN_EXCLUSIVE = 16;

		// Token: 0x04000023 RID: 35
		public const int SQLITE_OPEN_AUTOPROXY = 32;

		// Token: 0x04000024 RID: 36
		public const int SQLITE_OPEN_URI = 64;

		// Token: 0x04000025 RID: 37
		public const int SQLITE_OPEN_MEMORY = 128;

		// Token: 0x04000026 RID: 38
		public const int SQLITE_OPEN_MAIN_DB = 256;

		// Token: 0x04000027 RID: 39
		public const int SQLITE_OPEN_TEMP_DB = 512;

		// Token: 0x04000028 RID: 40
		public const int SQLITE_OPEN_TRANSIENT_DB = 1024;

		// Token: 0x04000029 RID: 41
		public const int SQLITE_OPEN_MAIN_JOURNAL = 2048;

		// Token: 0x0400002A RID: 42
		public const int SQLITE_OPEN_TEMP_JOURNAL = 4096;

		// Token: 0x0400002B RID: 43
		public const int SQLITE_OPEN_SUBJOURNAL = 8192;

		// Token: 0x0400002C RID: 44
		public const int SQLITE_OPEN_MASTER_JOURNAL = 16384;

		// Token: 0x0400002D RID: 45
		public const int SQLITE_OPEN_NOMUTEX = 32768;

		// Token: 0x0400002E RID: 46
		public const int SQLITE_OPEN_FULLMUTEX = 65536;

		// Token: 0x0400002F RID: 47
		public const int SQLITE_OPEN_SHAREDCACHE = 131072;

		// Token: 0x04000030 RID: 48
		public const int SQLITE_OPEN_PRIVATECACHE = 262144;

		// Token: 0x04000031 RID: 49
		public const int SQLITE_OPEN_WAL = 524288;

		// Token: 0x04000032 RID: 50
		public const int SQLITE_PREPARE_PERSISTENT = 1;

		// Token: 0x04000033 RID: 51
		public const int SQLITE_PREPARE_NORMALIZE = 2;

		// Token: 0x04000034 RID: 52
		public const int SQLITE_PREPARE_NO_VTAB = 4;

		// Token: 0x04000035 RID: 53
		public const int SQLITE_INTEGER = 1;

		// Token: 0x04000036 RID: 54
		public const int SQLITE_FLOAT = 2;

		// Token: 0x04000037 RID: 55
		public const int SQLITE_TEXT = 3;

		// Token: 0x04000038 RID: 56
		public const int SQLITE_BLOB = 4;

		// Token: 0x04000039 RID: 57
		public const int SQLITE_NULL = 5;

		// Token: 0x0400003A RID: 58
		public const int SQLITE_OK = 0;

		// Token: 0x0400003B RID: 59
		public const int SQLITE_ERROR = 1;

		// Token: 0x0400003C RID: 60
		public const int SQLITE_INTERNAL = 2;

		// Token: 0x0400003D RID: 61
		public const int SQLITE_PERM = 3;

		// Token: 0x0400003E RID: 62
		public const int SQLITE_ABORT = 4;

		// Token: 0x0400003F RID: 63
		public const int SQLITE_BUSY = 5;

		// Token: 0x04000040 RID: 64
		public const int SQLITE_LOCKED = 6;

		// Token: 0x04000041 RID: 65
		public const int SQLITE_NOMEM = 7;

		// Token: 0x04000042 RID: 66
		public const int SQLITE_READONLY = 8;

		// Token: 0x04000043 RID: 67
		public const int SQLITE_INTERRUPT = 9;

		// Token: 0x04000044 RID: 68
		public const int SQLITE_IOERR = 10;

		// Token: 0x04000045 RID: 69
		public const int SQLITE_CORRUPT = 11;

		// Token: 0x04000046 RID: 70
		public const int SQLITE_NOTFOUND = 12;

		// Token: 0x04000047 RID: 71
		public const int SQLITE_FULL = 13;

		// Token: 0x04000048 RID: 72
		public const int SQLITE_CANTOPEN = 14;

		// Token: 0x04000049 RID: 73
		public const int SQLITE_PROTOCOL = 15;

		// Token: 0x0400004A RID: 74
		public const int SQLITE_EMPTY = 16;

		// Token: 0x0400004B RID: 75
		public const int SQLITE_SCHEMA = 17;

		// Token: 0x0400004C RID: 76
		public const int SQLITE_TOOBIG = 18;

		// Token: 0x0400004D RID: 77
		public const int SQLITE_CONSTRAINT = 19;

		// Token: 0x0400004E RID: 78
		public const int SQLITE_MISMATCH = 20;

		// Token: 0x0400004F RID: 79
		public const int SQLITE_MISUSE = 21;

		// Token: 0x04000050 RID: 80
		public const int SQLITE_NOLFS = 22;

		// Token: 0x04000051 RID: 81
		public const int SQLITE_AUTH = 23;

		// Token: 0x04000052 RID: 82
		public const int SQLITE_FORMAT = 24;

		// Token: 0x04000053 RID: 83
		public const int SQLITE_RANGE = 25;

		// Token: 0x04000054 RID: 84
		public const int SQLITE_NOTADB = 26;

		// Token: 0x04000055 RID: 85
		public const int SQLITE_NOTICE = 27;

		// Token: 0x04000056 RID: 86
		public const int SQLITE_WARNING = 28;

		// Token: 0x04000057 RID: 87
		public const int SQLITE_ROW = 100;

		// Token: 0x04000058 RID: 88
		public const int SQLITE_DONE = 101;

		// Token: 0x04000059 RID: 89
		public const int SQLITE_IOERR_READ = 266;

		// Token: 0x0400005A RID: 90
		public const int SQLITE_IOERR_SHORT_READ = 522;

		// Token: 0x0400005B RID: 91
		public const int SQLITE_IOERR_WRITE = 778;

		// Token: 0x0400005C RID: 92
		public const int SQLITE_IOERR_FSYNC = 1034;

		// Token: 0x0400005D RID: 93
		public const int SQLITE_IOERR_DIR_FSYNC = 1290;

		// Token: 0x0400005E RID: 94
		public const int SQLITE_IOERR_TRUNCATE = 1546;

		// Token: 0x0400005F RID: 95
		public const int SQLITE_IOERR_FSTAT = 1802;

		// Token: 0x04000060 RID: 96
		public const int SQLITE_IOERR_UNLOCK = 2058;

		// Token: 0x04000061 RID: 97
		public const int SQLITE_IOERR_RDLOCK = 2314;

		// Token: 0x04000062 RID: 98
		public const int SQLITE_IOERR_DELETE = 2570;

		// Token: 0x04000063 RID: 99
		public const int SQLITE_IOERR_BLOCKED = 2826;

		// Token: 0x04000064 RID: 100
		public const int SQLITE_IOERR_NOMEM = 3082;

		// Token: 0x04000065 RID: 101
		public const int SQLITE_IOERR_ACCESS = 3338;

		// Token: 0x04000066 RID: 102
		public const int SQLITE_IOERR_CHECKRESERVEDLOCK = 3594;

		// Token: 0x04000067 RID: 103
		public const int SQLITE_IOERR_LOCK = 3850;

		// Token: 0x04000068 RID: 104
		public const int SQLITE_IOERR_CLOSE = 4106;

		// Token: 0x04000069 RID: 105
		public const int SQLITE_IOERR_DIR_CLOSE = 4362;

		// Token: 0x0400006A RID: 106
		public const int SQLITE_IOERR_SHMOPEN = 4618;

		// Token: 0x0400006B RID: 107
		public const int SQLITE_IOERR_SHMSIZE = 4874;

		// Token: 0x0400006C RID: 108
		public const int SQLITE_IOERR_SHMLOCK = 5130;

		// Token: 0x0400006D RID: 109
		public const int SQLITE_IOERR_SHMMAP = 5386;

		// Token: 0x0400006E RID: 110
		public const int SQLITE_IOERR_SEEK = 5642;

		// Token: 0x0400006F RID: 111
		public const int SQLITE_IOERR_DELETE_NOENT = 5898;

		// Token: 0x04000070 RID: 112
		public const int SQLITE_IOERR_MMAP = 6154;

		// Token: 0x04000071 RID: 113
		public const int SQLITE_IOERR_GETTEMPPATH = 6410;

		// Token: 0x04000072 RID: 114
		public const int SQLITE_IOERR_CONVPATH = 6666;

		// Token: 0x04000073 RID: 115
		public const int SQLITE_LOCKED_SHAREDCACHE = 262;

		// Token: 0x04000074 RID: 116
		public const int SQLITE_BUSY_RECOVERY = 261;

		// Token: 0x04000075 RID: 117
		public const int SQLITE_BUSY_SNAPSHOT = 517;

		// Token: 0x04000076 RID: 118
		public const int SQLITE_CANTOPEN_NOTEMPDIR = 270;

		// Token: 0x04000077 RID: 119
		public const int SQLITE_CANTOPEN_ISDIR = 526;

		// Token: 0x04000078 RID: 120
		public const int SQLITE_CANTOPEN_FULLPATH = 782;

		// Token: 0x04000079 RID: 121
		public const int SQLITE_CANTOPEN_CONVPATH = 1038;

		// Token: 0x0400007A RID: 122
		public const int SQLITE_CORRUPT_VTAB = 267;

		// Token: 0x0400007B RID: 123
		public const int SQLITE_READONLY_RECOVERY = 264;

		// Token: 0x0400007C RID: 124
		public const int SQLITE_READONLY_CANTLOCK = 520;

		// Token: 0x0400007D RID: 125
		public const int SQLITE_READONLY_ROLLBACK = 776;

		// Token: 0x0400007E RID: 126
		public const int SQLITE_READONLY_DBMOVED = 1032;

		// Token: 0x0400007F RID: 127
		public const int SQLITE_ABORT_ROLLBACK = 516;

		// Token: 0x04000080 RID: 128
		public const int SQLITE_CONSTRAINT_CHECK = 275;

		// Token: 0x04000081 RID: 129
		public const int SQLITE_CONSTRAINT_COMMITHOOK = 531;

		// Token: 0x04000082 RID: 130
		public const int SQLITE_CONSTRAINT_FOREIGNKEY = 787;

		// Token: 0x04000083 RID: 131
		public const int SQLITE_CONSTRAINT_FUNCTION = 1043;

		// Token: 0x04000084 RID: 132
		public const int SQLITE_CONSTRAINT_NOTNULL = 1299;

		// Token: 0x04000085 RID: 133
		public const int SQLITE_CONSTRAINT_PRIMARYKEY = 1555;

		// Token: 0x04000086 RID: 134
		public const int SQLITE_CONSTRAINT_TRIGGER = 1811;

		// Token: 0x04000087 RID: 135
		public const int SQLITE_CONSTRAINT_UNIQUE = 2067;

		// Token: 0x04000088 RID: 136
		public const int SQLITE_CONSTRAINT_VTAB = 2323;

		// Token: 0x04000089 RID: 137
		public const int SQLITE_CONSTRAINT_ROWID = 2579;

		// Token: 0x0400008A RID: 138
		public const int SQLITE_NOTICE_RECOVER_WAL = 283;

		// Token: 0x0400008B RID: 139
		public const int SQLITE_NOTICE_RECOVER_ROLLBACK = 539;

		// Token: 0x0400008C RID: 140
		public const int SQLITE_WARNING_AUTOINDEX = 284;

		// Token: 0x0400008D RID: 141
		public const int SQLITE_CREATE_INDEX = 1;

		// Token: 0x0400008E RID: 142
		public const int SQLITE_CREATE_TABLE = 2;

		// Token: 0x0400008F RID: 143
		public const int SQLITE_CREATE_TEMP_INDEX = 3;

		// Token: 0x04000090 RID: 144
		public const int SQLITE_CREATE_TEMP_TABLE = 4;

		// Token: 0x04000091 RID: 145
		public const int SQLITE_CREATE_TEMP_TRIGGER = 5;

		// Token: 0x04000092 RID: 146
		public const int SQLITE_CREATE_TEMP_VIEW = 6;

		// Token: 0x04000093 RID: 147
		public const int SQLITE_CREATE_TRIGGER = 7;

		// Token: 0x04000094 RID: 148
		public const int SQLITE_CREATE_VIEW = 8;

		// Token: 0x04000095 RID: 149
		public const int SQLITE_DELETE = 9;

		// Token: 0x04000096 RID: 150
		public const int SQLITE_DROP_INDEX = 10;

		// Token: 0x04000097 RID: 151
		public const int SQLITE_DROP_TABLE = 11;

		// Token: 0x04000098 RID: 152
		public const int SQLITE_DROP_TEMP_INDEX = 12;

		// Token: 0x04000099 RID: 153
		public const int SQLITE_DROP_TEMP_TABLE = 13;

		// Token: 0x0400009A RID: 154
		public const int SQLITE_DROP_TEMP_TRIGGER = 14;

		// Token: 0x0400009B RID: 155
		public const int SQLITE_DROP_TEMP_VIEW = 15;

		// Token: 0x0400009C RID: 156
		public const int SQLITE_DROP_TRIGGER = 16;

		// Token: 0x0400009D RID: 157
		public const int SQLITE_DROP_VIEW = 17;

		// Token: 0x0400009E RID: 158
		public const int SQLITE_INSERT = 18;

		// Token: 0x0400009F RID: 159
		public const int SQLITE_PRAGMA = 19;

		// Token: 0x040000A0 RID: 160
		public const int SQLITE_READ = 20;

		// Token: 0x040000A1 RID: 161
		public const int SQLITE_SELECT = 21;

		// Token: 0x040000A2 RID: 162
		public const int SQLITE_TRANSACTION = 22;

		// Token: 0x040000A3 RID: 163
		public const int SQLITE_UPDATE = 23;

		// Token: 0x040000A4 RID: 164
		public const int SQLITE_ATTACH = 24;

		// Token: 0x040000A5 RID: 165
		public const int SQLITE_DETACH = 25;

		// Token: 0x040000A6 RID: 166
		public const int SQLITE_ALTER_TABLE = 26;

		// Token: 0x040000A7 RID: 167
		public const int SQLITE_REINDEX = 27;

		// Token: 0x040000A8 RID: 168
		public const int SQLITE_ANALYZE = 28;

		// Token: 0x040000A9 RID: 169
		public const int SQLITE_CREATE_VTABLE = 29;

		// Token: 0x040000AA RID: 170
		public const int SQLITE_DROP_VTABLE = 30;

		// Token: 0x040000AB RID: 171
		public const int SQLITE_FUNCTION = 31;

		// Token: 0x040000AC RID: 172
		public const int SQLITE_SAVEPOINT = 32;

		// Token: 0x040000AD RID: 173
		public const int SQLITE_COPY = 0;

		// Token: 0x040000AE RID: 174
		public const int SQLITE_RECURSIVE = 33;

		// Token: 0x040000AF RID: 175
		public const int SQLITE_CHECKPOINT_PASSIVE = 0;

		// Token: 0x040000B0 RID: 176
		public const int SQLITE_CHECKPOINT_FULL = 1;

		// Token: 0x040000B1 RID: 177
		public const int SQLITE_CHECKPOINT_RESTART = 2;

		// Token: 0x040000B2 RID: 178
		public const int SQLITE_CHECKPOINT_TRUNCATE = 3;

		// Token: 0x040000B3 RID: 179
		public const int SQLITE_DBSTATUS_LOOKASIDE_USED = 0;

		// Token: 0x040000B4 RID: 180
		public const int SQLITE_DBSTATUS_CACHE_USED = 1;

		// Token: 0x040000B5 RID: 181
		public const int SQLITE_DBSTATUS_SCHEMA_USED = 2;

		// Token: 0x040000B6 RID: 182
		public const int SQLITE_DBSTATUS_STMT_USED = 3;

		// Token: 0x040000B7 RID: 183
		public const int SQLITE_DBSTATUS_LOOKASIDE_HIT = 4;

		// Token: 0x040000B8 RID: 184
		public const int SQLITE_DBSTATUS_LOOKASIDE_MISS_SIZE = 5;

		// Token: 0x040000B9 RID: 185
		public const int SQLITE_DBSTATUS_LOOKASIDE_MISS_FULL = 6;

		// Token: 0x040000BA RID: 186
		public const int SQLITE_DBSTATUS_CACHE_HIT = 7;

		// Token: 0x040000BB RID: 187
		public const int SQLITE_DBSTATUS_CACHE_MISS = 8;

		// Token: 0x040000BC RID: 188
		public const int SQLITE_DBSTATUS_CACHE_WRITE = 9;

		// Token: 0x040000BD RID: 189
		public const int SQLITE_DBSTATUS_DEFERRED_FKS = 10;

		// Token: 0x040000BE RID: 190
		public const int SQLITE_STATUS_MEMORY_USED = 0;

		// Token: 0x040000BF RID: 191
		public const int SQLITE_STATUS_PAGECACHE_USED = 1;

		// Token: 0x040000C0 RID: 192
		public const int SQLITE_STATUS_PAGECACHE_OVERFLOW = 2;

		// Token: 0x040000C1 RID: 193
		public const int SQLITE_STATUS_SCRATCH_USED = 3;

		// Token: 0x040000C2 RID: 194
		public const int SQLITE_STATUS_SCRATCH_OVERFLOW = 4;

		// Token: 0x040000C3 RID: 195
		public const int SQLITE_STATUS_MALLOC_SIZE = 5;

		// Token: 0x040000C4 RID: 196
		public const int SQLITE_STATUS_PARSER_STACK = 6;

		// Token: 0x040000C5 RID: 197
		public const int SQLITE_STATUS_PAGECACHE_SIZE = 7;

		// Token: 0x040000C6 RID: 198
		public const int SQLITE_STATUS_SCRATCH_SIZE = 8;

		// Token: 0x040000C7 RID: 199
		public const int SQLITE_STATUS_MALLOC_COUNT = 9;

		// Token: 0x040000C8 RID: 200
		public const int SQLITE_STMTSTATUS_FULLSCAN_STEP = 1;

		// Token: 0x040000C9 RID: 201
		public const int SQLITE_STMTSTATUS_SORT = 2;

		// Token: 0x040000CA RID: 202
		public const int SQLITE_STMTSTATUS_AUTOINDEX = 3;

		// Token: 0x040000CB RID: 203
		public const int SQLITE_STMTSTATUS_VM_STEP = 4;

		// Token: 0x040000CC RID: 204
		public const int SQLITE_DENY = 1;

		// Token: 0x040000CD RID: 205
		public const int SQLITE_IGNORE = 2;

		// Token: 0x040000CE RID: 206
		public const int SQLITE_TRACE_STMT = 1;

		// Token: 0x040000CF RID: 207
		public const int SQLITE_TRACE_PROFILE = 2;

		// Token: 0x040000D0 RID: 208
		public const int SQLITE_TRACE_ROW = 4;

		// Token: 0x040000D1 RID: 209
		public const int SQLITE_TRACE_CLOSE = 8;
	}
}
