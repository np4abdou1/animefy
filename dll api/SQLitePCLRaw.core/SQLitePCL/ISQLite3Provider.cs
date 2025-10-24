using System;

namespace SQLitePCL
{
	// Token: 0x02000027 RID: 39
	public interface ISQLite3Provider
	{
		// Token: 0x0600012E RID: 302
		string GetNativeLibraryName();

		// Token: 0x0600012F RID: 303
		int sqlite3_open(utf8z filename, out IntPtr db);

		// Token: 0x06000130 RID: 304
		int sqlite3_open_v2(utf8z filename, out IntPtr db, int flags, utf8z vfs);

		// Token: 0x06000131 RID: 305
		int sqlite3_close_v2(IntPtr db);

		// Token: 0x06000132 RID: 306
		int sqlite3_close(IntPtr db);

		// Token: 0x06000133 RID: 307
		int sqlite3_enable_shared_cache(int enable);

		// Token: 0x06000134 RID: 308
		void sqlite3_interrupt(sqlite3 db);

		// Token: 0x06000135 RID: 309
		int sqlite3__vfs__delete(utf8z vfs, utf8z pathname, int syncDir);

		// Token: 0x06000136 RID: 310
		int sqlite3_threadsafe();

		// Token: 0x06000137 RID: 311
		utf8z sqlite3_libversion();

		// Token: 0x06000138 RID: 312
		int sqlite3_libversion_number();

		// Token: 0x06000139 RID: 313
		utf8z sqlite3_sourceid();

		// Token: 0x0600013A RID: 314
		long sqlite3_memory_used();

		// Token: 0x0600013B RID: 315
		long sqlite3_memory_highwater(int resetFlag);

		// Token: 0x0600013C RID: 316
		int sqlite3_status(int op, out int current, out int highwater, int resetFlag);

		// Token: 0x0600013D RID: 317
		int sqlite3_db_readonly(sqlite3 db, utf8z dbName);

		// Token: 0x0600013E RID: 318
		utf8z sqlite3_db_filename(sqlite3 db, utf8z att);

		// Token: 0x0600013F RID: 319
		utf8z sqlite3_errmsg(sqlite3 db);

		// Token: 0x06000140 RID: 320
		long sqlite3_last_insert_rowid(sqlite3 db);

		// Token: 0x06000141 RID: 321
		int sqlite3_changes(sqlite3 db);

		// Token: 0x06000142 RID: 322
		int sqlite3_total_changes(sqlite3 db);

		// Token: 0x06000143 RID: 323
		int sqlite3_get_autocommit(sqlite3 db);

		// Token: 0x06000144 RID: 324
		int sqlite3_busy_timeout(sqlite3 db, int ms);

		// Token: 0x06000145 RID: 325
		int sqlite3_extended_result_codes(sqlite3 db, int onoff);

		// Token: 0x06000146 RID: 326
		int sqlite3_errcode(sqlite3 db);

		// Token: 0x06000147 RID: 327
		int sqlite3_extended_errcode(sqlite3 db);

		// Token: 0x06000148 RID: 328
		utf8z sqlite3_errstr(int rc);

		// Token: 0x06000149 RID: 329
		int sqlite3_prepare_v2(sqlite3 db, ReadOnlySpan<byte> sql, out IntPtr stmt, out ReadOnlySpan<byte> remain);

		// Token: 0x0600014A RID: 330
		int sqlite3_prepare_v3(sqlite3 db, ReadOnlySpan<byte> sql, uint flags, out IntPtr stmt, out ReadOnlySpan<byte> remain);

		// Token: 0x0600014B RID: 331
		int sqlite3_prepare_v2(sqlite3 db, utf8z sql, out IntPtr stmt, out utf8z remain);

		// Token: 0x0600014C RID: 332
		int sqlite3_prepare_v3(sqlite3 db, utf8z sql, uint flags, out IntPtr stmt, out utf8z remain);

		// Token: 0x0600014D RID: 333
		int sqlite3_step(sqlite3_stmt stmt);

		// Token: 0x0600014E RID: 334
		int sqlite3_finalize(IntPtr stmt);

		// Token: 0x0600014F RID: 335
		int sqlite3_reset(sqlite3_stmt stmt);

		// Token: 0x06000150 RID: 336
		int sqlite3_clear_bindings(sqlite3_stmt stmt);

		// Token: 0x06000151 RID: 337
		int sqlite3_stmt_status(sqlite3_stmt stmt, int op, int resetFlg);

		// Token: 0x06000152 RID: 338
		utf8z sqlite3_sql(sqlite3_stmt stmt);

		// Token: 0x06000153 RID: 339
		IntPtr sqlite3_db_handle(IntPtr stmt);

		// Token: 0x06000154 RID: 340
		IntPtr sqlite3_next_stmt(sqlite3 db, IntPtr stmt);

		// Token: 0x06000155 RID: 341
		int sqlite3_bind_zeroblob(sqlite3_stmt stmt, int index, int size);

		// Token: 0x06000156 RID: 342
		utf8z sqlite3_bind_parameter_name(sqlite3_stmt stmt, int index);

		// Token: 0x06000157 RID: 343
		int sqlite3_bind_blob(sqlite3_stmt stmt, int index, ReadOnlySpan<byte> blob);

		// Token: 0x06000158 RID: 344
		int sqlite3_bind_double(sqlite3_stmt stmt, int index, double val);

		// Token: 0x06000159 RID: 345
		int sqlite3_bind_int(sqlite3_stmt stmt, int index, int val);

		// Token: 0x0600015A RID: 346
		int sqlite3_bind_int64(sqlite3_stmt stmt, int index, long val);

		// Token: 0x0600015B RID: 347
		int sqlite3_bind_null(sqlite3_stmt stmt, int index);

		// Token: 0x0600015C RID: 348
		int sqlite3_bind_text(sqlite3_stmt stmt, int index, ReadOnlySpan<byte> text);

		// Token: 0x0600015D RID: 349
		int sqlite3_bind_text(sqlite3_stmt stmt, int index, utf8z text);

		// Token: 0x0600015E RID: 350
		int sqlite3_bind_parameter_count(sqlite3_stmt stmt);

		// Token: 0x0600015F RID: 351
		int sqlite3_bind_parameter_index(sqlite3_stmt stmt, utf8z strName);

		// Token: 0x06000160 RID: 352
		utf8z sqlite3_column_database_name(sqlite3_stmt stmt, int index);

		// Token: 0x06000161 RID: 353
		utf8z sqlite3_column_name(sqlite3_stmt stmt, int index);

		// Token: 0x06000162 RID: 354
		utf8z sqlite3_column_origin_name(sqlite3_stmt stmt, int index);

		// Token: 0x06000163 RID: 355
		utf8z sqlite3_column_table_name(sqlite3_stmt stmt, int index);

		// Token: 0x06000164 RID: 356
		utf8z sqlite3_column_text(sqlite3_stmt stmt, int index);

		// Token: 0x06000165 RID: 357
		int sqlite3_data_count(sqlite3_stmt stmt);

		// Token: 0x06000166 RID: 358
		int sqlite3_column_count(sqlite3_stmt stmt);

		// Token: 0x06000167 RID: 359
		double sqlite3_column_double(sqlite3_stmt stmt, int index);

		// Token: 0x06000168 RID: 360
		int sqlite3_column_int(sqlite3_stmt stmt, int index);

		// Token: 0x06000169 RID: 361
		long sqlite3_column_int64(sqlite3_stmt stmt, int index);

		// Token: 0x0600016A RID: 362
		ReadOnlySpan<byte> sqlite3_column_blob(sqlite3_stmt stmt, int index);

		// Token: 0x0600016B RID: 363
		int sqlite3_column_bytes(sqlite3_stmt stmt, int index);

		// Token: 0x0600016C RID: 364
		int sqlite3_column_type(sqlite3_stmt stmt, int index);

		// Token: 0x0600016D RID: 365
		utf8z sqlite3_column_decltype(sqlite3_stmt stmt, int index);

		// Token: 0x0600016E RID: 366
		sqlite3_backup sqlite3_backup_init(sqlite3 destDb, utf8z destName, sqlite3 sourceDb, utf8z sourceName);

		// Token: 0x0600016F RID: 367
		int sqlite3_backup_step(sqlite3_backup backup, int nPage);

		// Token: 0x06000170 RID: 368
		int sqlite3_backup_remaining(sqlite3_backup backup);

		// Token: 0x06000171 RID: 369
		int sqlite3_backup_pagecount(sqlite3_backup backup);

		// Token: 0x06000172 RID: 370
		int sqlite3_backup_finish(IntPtr backup);

		// Token: 0x06000173 RID: 371
		int sqlite3_blob_open(sqlite3 db, utf8z db_utf8, utf8z table_utf8, utf8z col_utf8, long rowid, int flags, out sqlite3_blob blob);

		// Token: 0x06000174 RID: 372
		int sqlite3_blob_bytes(sqlite3_blob blob);

		// Token: 0x06000175 RID: 373
		int sqlite3_blob_reopen(sqlite3_blob blob, long rowid);

		// Token: 0x06000176 RID: 374
		int sqlite3_blob_write(sqlite3_blob blob, ReadOnlySpan<byte> b, int offset);

		// Token: 0x06000177 RID: 375
		int sqlite3_blob_read(sqlite3_blob blob, Span<byte> b, int offset);

		// Token: 0x06000178 RID: 376
		int sqlite3_blob_close(IntPtr blob);

		// Token: 0x06000179 RID: 377
		int sqlite3_config_log(delegate_log func, object v);

		// Token: 0x0600017A RID: 378
		void sqlite3_log(int errcode, utf8z s);

		// Token: 0x0600017B RID: 379
		void sqlite3_commit_hook(sqlite3 db, delegate_commit func, object v);

		// Token: 0x0600017C RID: 380
		void sqlite3_rollback_hook(sqlite3 db, delegate_rollback func, object v);

		// Token: 0x0600017D RID: 381
		void sqlite3_trace(sqlite3 db, delegate_trace func, object v);

		// Token: 0x0600017E RID: 382
		void sqlite3_profile(sqlite3 db, delegate_profile func, object v);

		// Token: 0x0600017F RID: 383
		void sqlite3_progress_handler(sqlite3 db, int instructions, delegate_progress func, object v);

		// Token: 0x06000180 RID: 384
		void sqlite3_update_hook(sqlite3 db, delegate_update func, object v);

		// Token: 0x06000181 RID: 385
		int sqlite3_create_collation(sqlite3 db, byte[] name, object v, delegate_collation func);

		// Token: 0x06000182 RID: 386
		int sqlite3_create_function(sqlite3 db, byte[] name, int nArg, int flags, object v, delegate_function_scalar func);

		// Token: 0x06000183 RID: 387
		int sqlite3_create_function(sqlite3 db, byte[] name, int nArg, int flags, object v, delegate_function_aggregate_step func_step, delegate_function_aggregate_final func_final);

		// Token: 0x06000184 RID: 388
		int sqlite3_db_status(sqlite3 db, int op, out int current, out int highest, int resetFlg);

		// Token: 0x06000185 RID: 389
		void sqlite3_result_blob(IntPtr context, ReadOnlySpan<byte> val);

		// Token: 0x06000186 RID: 390
		void sqlite3_result_double(IntPtr context, double val);

		// Token: 0x06000187 RID: 391
		void sqlite3_result_error(IntPtr context, ReadOnlySpan<byte> strErr);

		// Token: 0x06000188 RID: 392
		void sqlite3_result_error(IntPtr context, utf8z strErr);

		// Token: 0x06000189 RID: 393
		void sqlite3_result_int(IntPtr context, int val);

		// Token: 0x0600018A RID: 394
		void sqlite3_result_int64(IntPtr context, long val);

		// Token: 0x0600018B RID: 395
		void sqlite3_result_null(IntPtr context);

		// Token: 0x0600018C RID: 396
		void sqlite3_result_text(IntPtr context, ReadOnlySpan<byte> val);

		// Token: 0x0600018D RID: 397
		void sqlite3_result_text(IntPtr context, utf8z val);

		// Token: 0x0600018E RID: 398
		void sqlite3_result_zeroblob(IntPtr context, int n);

		// Token: 0x0600018F RID: 399
		void sqlite3_result_error_toobig(IntPtr context);

		// Token: 0x06000190 RID: 400
		void sqlite3_result_error_nomem(IntPtr context);

		// Token: 0x06000191 RID: 401
		void sqlite3_result_error_code(IntPtr context, int code);

		// Token: 0x06000192 RID: 402
		ReadOnlySpan<byte> sqlite3_value_blob(IntPtr p);

		// Token: 0x06000193 RID: 403
		int sqlite3_value_bytes(IntPtr p);

		// Token: 0x06000194 RID: 404
		double sqlite3_value_double(IntPtr p);

		// Token: 0x06000195 RID: 405
		int sqlite3_value_int(IntPtr p);

		// Token: 0x06000196 RID: 406
		long sqlite3_value_int64(IntPtr p);

		// Token: 0x06000197 RID: 407
		int sqlite3_value_type(IntPtr p);

		// Token: 0x06000198 RID: 408
		utf8z sqlite3_value_text(IntPtr p);

		// Token: 0x06000199 RID: 409
		int sqlite3_stmt_isexplain(sqlite3_stmt stmt);

		// Token: 0x0600019A RID: 410
		int sqlite3_stmt_busy(sqlite3_stmt stmt);

		// Token: 0x0600019B RID: 411
		int sqlite3_stmt_readonly(sqlite3_stmt stmt);

		// Token: 0x0600019C RID: 412
		int sqlite3_exec(sqlite3 db, utf8z sql, delegate_exec callback, object user_data, out IntPtr errMsg);

		// Token: 0x0600019D RID: 413
		int sqlite3_complete(utf8z sql);

		// Token: 0x0600019E RID: 414
		int sqlite3_compileoption_used(utf8z sql);

		// Token: 0x0600019F RID: 415
		utf8z sqlite3_compileoption_get(int n);

		// Token: 0x060001A0 RID: 416
		int sqlite3_wal_autocheckpoint(sqlite3 db, int n);

		// Token: 0x060001A1 RID: 417
		int sqlite3_wal_checkpoint(sqlite3 db, utf8z dbName);

		// Token: 0x060001A2 RID: 418
		int sqlite3_wal_checkpoint_v2(sqlite3 db, utf8z dbName, int eMode, out int logSize, out int framesCheckPointed);

		// Token: 0x060001A3 RID: 419
		int sqlite3_table_column_metadata(sqlite3 db, utf8z dbName, utf8z tblName, utf8z colName, out utf8z dataType, out utf8z collSeq, out int notNull, out int primaryKey, out int autoInc);

		// Token: 0x060001A4 RID: 420
		int sqlite3_set_authorizer(sqlite3 db, delegate_authorizer authorizer, object user_data);

		// Token: 0x060001A5 RID: 421
		int sqlite3_stricmp(IntPtr p, IntPtr q);

		// Token: 0x060001A6 RID: 422
		int sqlite3_strnicmp(IntPtr p, IntPtr q, int n);

		// Token: 0x060001A7 RID: 423
		void sqlite3_free(IntPtr p);

		// Token: 0x060001A8 RID: 424
		int sqlite3_key(sqlite3 db, ReadOnlySpan<byte> key);

		// Token: 0x060001A9 RID: 425
		int sqlite3_key_v2(sqlite3 db, utf8z dbname, ReadOnlySpan<byte> key);

		// Token: 0x060001AA RID: 426
		int sqlite3_rekey(sqlite3 db, ReadOnlySpan<byte> key);

		// Token: 0x060001AB RID: 427
		int sqlite3_rekey_v2(sqlite3 db, utf8z dbname, ReadOnlySpan<byte> key);

		// Token: 0x060001AC RID: 428
		int sqlite3_initialize();

		// Token: 0x060001AD RID: 429
		int sqlite3_shutdown();

		// Token: 0x060001AE RID: 430
		int sqlite3_config(int op);

		// Token: 0x060001AF RID: 431
		int sqlite3_config(int op, int val);

		// Token: 0x060001B0 RID: 432
		int sqlite3_enable_load_extension(sqlite3 db, int enable);

		// Token: 0x060001B1 RID: 433
		int sqlite3_win32_set_directory(int typ, utf8z path);
	}
}
