using System;
using SQLitePCL;

namespace SQLite
{
	// Token: 0x0200003F RID: 63
	public static class SQLite3
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x000084C2 File Offset: 0x000066C2
		public static SQLite3.Result Open(string filename, out sqlite3 db)
		{
			return (SQLite3.Result)raw.sqlite3_open(filename, out db);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000084CB File Offset: 0x000066CB
		public static SQLite3.Result Open(string filename, out sqlite3 db, int flags, string vfsName)
		{
			return (SQLite3.Result)raw.sqlite3_open_v2(filename, out db, flags, vfsName);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000084D6 File Offset: 0x000066D6
		public static SQLite3.Result Close(sqlite3 db)
		{
			return (SQLite3.Result)raw.sqlite3_close(db);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000084DE File Offset: 0x000066DE
		public static SQLite3.Result Close2(sqlite3 db)
		{
			return (SQLite3.Result)raw.sqlite3_close_v2(db);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000084E6 File Offset: 0x000066E6
		public static SQLite3.Result BusyTimeout(sqlite3 db, int milliseconds)
		{
			return (SQLite3.Result)raw.sqlite3_busy_timeout(db, milliseconds);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000084EF File Offset: 0x000066EF
		public static int Changes(sqlite3 db)
		{
			return raw.sqlite3_changes(db);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000084F8 File Offset: 0x000066F8
		public static sqlite3_stmt Prepare2(sqlite3 db, string query)
		{
			sqlite3_stmt result = null;
			int num = raw.sqlite3_prepare_v2(db, query, out result);
			if (num != 0)
			{
				throw SQLiteException.New((SQLite3.Result)num, SQLite3.GetErrmsg(db));
			}
			return result;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008522 File Offset: 0x00006722
		public static SQLite3.Result Step(sqlite3_stmt stmt)
		{
			return (SQLite3.Result)raw.sqlite3_step(stmt);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000852A File Offset: 0x0000672A
		public static SQLite3.Result Reset(sqlite3_stmt stmt)
		{
			return (SQLite3.Result)raw.sqlite3_reset(stmt);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008532 File Offset: 0x00006732
		public static SQLite3.Result Finalize(sqlite3_stmt stmt)
		{
			return (SQLite3.Result)raw.sqlite3_finalize(stmt);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000853A File Offset: 0x0000673A
		public static long LastInsertRowid(sqlite3 db)
		{
			return raw.sqlite3_last_insert_rowid(db);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008544 File Offset: 0x00006744
		public static string GetErrmsg(sqlite3 db)
		{
			return raw.sqlite3_errmsg(db).utf8_to_string();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000855F File Offset: 0x0000675F
		public static int BindParameterIndex(sqlite3_stmt stmt, string name)
		{
			return raw.sqlite3_bind_parameter_index(stmt, name);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00008568 File Offset: 0x00006768
		public static int BindNull(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_bind_null(stmt, index);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00008571 File Offset: 0x00006771
		public static int BindInt(sqlite3_stmt stmt, int index, int val)
		{
			return raw.sqlite3_bind_int(stmt, index, val);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000857B File Offset: 0x0000677B
		public static int BindInt64(sqlite3_stmt stmt, int index, long val)
		{
			return raw.sqlite3_bind_int64(stmt, index, val);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008585 File Offset: 0x00006785
		public static int BindDouble(sqlite3_stmt stmt, int index, double val)
		{
			return raw.sqlite3_bind_double(stmt, index, val);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000858F File Offset: 0x0000678F
		public static int BindText(sqlite3_stmt stmt, int index, string val, int n, IntPtr free)
		{
			return raw.sqlite3_bind_text(stmt, index, val);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008599 File Offset: 0x00006799
		public static int BindBlob(sqlite3_stmt stmt, int index, byte[] val, int n, IntPtr free)
		{
			return raw.sqlite3_bind_blob(stmt, index, val);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000085A8 File Offset: 0x000067A8
		public static int ColumnCount(sqlite3_stmt stmt)
		{
			return raw.sqlite3_column_count(stmt);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000085B0 File Offset: 0x000067B0
		public static string ColumnName(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_name(stmt, index).utf8_to_string();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000085CC File Offset: 0x000067CC
		public static string ColumnName16(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_name(stmt, index).utf8_to_string();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000085E8 File Offset: 0x000067E8
		public static SQLite3.ColType ColumnType(sqlite3_stmt stmt, int index)
		{
			return (SQLite3.ColType)raw.sqlite3_column_type(stmt, index);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000085F1 File Offset: 0x000067F1
		public static int ColumnInt(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_int(stmt, index);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000085FA File Offset: 0x000067FA
		public static long ColumnInt64(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_int64(stmt, index);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008603 File Offset: 0x00006803
		public static double ColumnDouble(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_double(stmt, index);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000860C File Offset: 0x0000680C
		public static string ColumnText(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_text(stmt, index).utf8_to_string();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008628 File Offset: 0x00006828
		public static string ColumnText16(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_text(stmt, index).utf8_to_string();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00008644 File Offset: 0x00006844
		public static byte[] ColumnBlob(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_blob(stmt, index).ToArray();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00008660 File Offset: 0x00006860
		public static int ColumnBytes(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_bytes(stmt, index);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000866C File Offset: 0x0000686C
		public static string ColumnString(sqlite3_stmt stmt, int index)
		{
			return raw.sqlite3_column_text(stmt, index).utf8_to_string();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00008688 File Offset: 0x00006888
		public static byte[] ColumnByteArray(sqlite3_stmt stmt, int index)
		{
			if (SQLite3.ColumnBytes(stmt, index) > 0)
			{
				return SQLite3.ColumnBlob(stmt, index);
			}
			return new byte[0];
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000086A2 File Offset: 0x000068A2
		public static SQLite3.Result EnableLoadExtension(sqlite3 db, int onoff)
		{
			return (SQLite3.Result)raw.sqlite3_enable_load_extension(db, onoff);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000086AB File Offset: 0x000068AB
		public static int LibVersionNumber()
		{
			return raw.sqlite3_libversion_number();
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000086B2 File Offset: 0x000068B2
		public static SQLite3.Result GetResult(sqlite3 db)
		{
			return (SQLite3.Result)raw.sqlite3_errcode(db);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000086BA File Offset: 0x000068BA
		public static SQLite3.ExtendedResult ExtendedErrCode(sqlite3 db)
		{
			return (SQLite3.ExtendedResult)raw.sqlite3_extended_errcode(db);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000086C2 File Offset: 0x000068C2
		public static sqlite3_backup BackupInit(sqlite3 destDb, string destName, sqlite3 sourceDb, string sourceName)
		{
			return raw.sqlite3_backup_init(destDb, destName, sourceDb, sourceName);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000086CD File Offset: 0x000068CD
		public static SQLite3.Result BackupStep(sqlite3_backup backup, int numPages)
		{
			return (SQLite3.Result)raw.sqlite3_backup_step(backup, numPages);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000086D6 File Offset: 0x000068D6
		public static SQLite3.Result BackupFinish(sqlite3_backup backup)
		{
			return (SQLite3.Result)raw.sqlite3_backup_finish(backup);
		}

		// Token: 0x040000EE RID: 238
		private const string LibraryPath = "sqlite3";

		// Token: 0x02000040 RID: 64
		public enum Result
		{
			// Token: 0x040000F0 RID: 240
			OK,
			// Token: 0x040000F1 RID: 241
			Error,
			// Token: 0x040000F2 RID: 242
			Internal,
			// Token: 0x040000F3 RID: 243
			Perm,
			// Token: 0x040000F4 RID: 244
			Abort,
			// Token: 0x040000F5 RID: 245
			Busy,
			// Token: 0x040000F6 RID: 246
			Locked,
			// Token: 0x040000F7 RID: 247
			NoMem,
			// Token: 0x040000F8 RID: 248
			ReadOnly,
			// Token: 0x040000F9 RID: 249
			Interrupt,
			// Token: 0x040000FA RID: 250
			IOError,
			// Token: 0x040000FB RID: 251
			Corrupt,
			// Token: 0x040000FC RID: 252
			NotFound,
			// Token: 0x040000FD RID: 253
			Full,
			// Token: 0x040000FE RID: 254
			CannotOpen,
			// Token: 0x040000FF RID: 255
			LockErr,
			// Token: 0x04000100 RID: 256
			Empty,
			// Token: 0x04000101 RID: 257
			SchemaChngd,
			// Token: 0x04000102 RID: 258
			TooBig,
			// Token: 0x04000103 RID: 259
			Constraint,
			// Token: 0x04000104 RID: 260
			Mismatch,
			// Token: 0x04000105 RID: 261
			Misuse,
			// Token: 0x04000106 RID: 262
			NotImplementedLFS,
			// Token: 0x04000107 RID: 263
			AccessDenied,
			// Token: 0x04000108 RID: 264
			Format,
			// Token: 0x04000109 RID: 265
			Range,
			// Token: 0x0400010A RID: 266
			NonDBFile,
			// Token: 0x0400010B RID: 267
			Notice,
			// Token: 0x0400010C RID: 268
			Warning,
			// Token: 0x0400010D RID: 269
			Row = 100,
			// Token: 0x0400010E RID: 270
			Done
		}

		// Token: 0x02000041 RID: 65
		public enum ExtendedResult
		{
			// Token: 0x04000110 RID: 272
			IOErrorRead = 266,
			// Token: 0x04000111 RID: 273
			IOErrorShortRead = 522,
			// Token: 0x04000112 RID: 274
			IOErrorWrite = 778,
			// Token: 0x04000113 RID: 275
			IOErrorFsync = 1034,
			// Token: 0x04000114 RID: 276
			IOErrorDirFSync = 1290,
			// Token: 0x04000115 RID: 277
			IOErrorTruncate = 1546,
			// Token: 0x04000116 RID: 278
			IOErrorFStat = 1802,
			// Token: 0x04000117 RID: 279
			IOErrorUnlock = 2058,
			// Token: 0x04000118 RID: 280
			IOErrorRdlock = 2314,
			// Token: 0x04000119 RID: 281
			IOErrorDelete = 2570,
			// Token: 0x0400011A RID: 282
			IOErrorBlocked = 2826,
			// Token: 0x0400011B RID: 283
			IOErrorNoMem = 3082,
			// Token: 0x0400011C RID: 284
			IOErrorAccess = 3338,
			// Token: 0x0400011D RID: 285
			IOErrorCheckReservedLock = 3594,
			// Token: 0x0400011E RID: 286
			IOErrorLock = 3850,
			// Token: 0x0400011F RID: 287
			IOErrorClose = 4106,
			// Token: 0x04000120 RID: 288
			IOErrorDirClose = 4362,
			// Token: 0x04000121 RID: 289
			IOErrorSHMOpen = 4618,
			// Token: 0x04000122 RID: 290
			IOErrorSHMSize = 4874,
			// Token: 0x04000123 RID: 291
			IOErrorSHMLock = 5130,
			// Token: 0x04000124 RID: 292
			IOErrorSHMMap = 5386,
			// Token: 0x04000125 RID: 293
			IOErrorSeek = 5642,
			// Token: 0x04000126 RID: 294
			IOErrorDeleteNoEnt = 5898,
			// Token: 0x04000127 RID: 295
			IOErrorMMap = 6154,
			// Token: 0x04000128 RID: 296
			LockedSharedcache = 262,
			// Token: 0x04000129 RID: 297
			BusyRecovery = 261,
			// Token: 0x0400012A RID: 298
			CannottOpenNoTempDir = 270,
			// Token: 0x0400012B RID: 299
			CannotOpenIsDir = 526,
			// Token: 0x0400012C RID: 300
			CannotOpenFullPath = 782,
			// Token: 0x0400012D RID: 301
			CorruptVTab = 267,
			// Token: 0x0400012E RID: 302
			ReadonlyRecovery = 264,
			// Token: 0x0400012F RID: 303
			ReadonlyCannotLock = 520,
			// Token: 0x04000130 RID: 304
			ReadonlyRollback = 776,
			// Token: 0x04000131 RID: 305
			AbortRollback = 516,
			// Token: 0x04000132 RID: 306
			ConstraintCheck = 275,
			// Token: 0x04000133 RID: 307
			ConstraintCommitHook = 531,
			// Token: 0x04000134 RID: 308
			ConstraintForeignKey = 787,
			// Token: 0x04000135 RID: 309
			ConstraintFunction = 1043,
			// Token: 0x04000136 RID: 310
			ConstraintNotNull = 1299,
			// Token: 0x04000137 RID: 311
			ConstraintPrimaryKey = 1555,
			// Token: 0x04000138 RID: 312
			ConstraintTrigger = 1811,
			// Token: 0x04000139 RID: 313
			ConstraintUnique = 2067,
			// Token: 0x0400013A RID: 314
			ConstraintVTab = 2323,
			// Token: 0x0400013B RID: 315
			NoticeRecoverWAL = 283,
			// Token: 0x0400013C RID: 316
			NoticeRecoverRollback = 539
		}

		// Token: 0x02000042 RID: 66
		public enum ConfigOption
		{
			// Token: 0x0400013E RID: 318
			SingleThread = 1,
			// Token: 0x0400013F RID: 319
			MultiThread,
			// Token: 0x04000140 RID: 320
			Serialized
		}

		// Token: 0x02000043 RID: 67
		public enum ColType
		{
			// Token: 0x04000142 RID: 322
			Integer = 1,
			// Token: 0x04000143 RID: 323
			Float,
			// Token: 0x04000144 RID: 324
			Text,
			// Token: 0x04000145 RID: 325
			Blob,
			// Token: 0x04000146 RID: 326
			Null
		}
	}
}
