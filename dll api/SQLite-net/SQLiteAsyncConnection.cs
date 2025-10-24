using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace SQLite
{
	// Token: 0x02000044 RID: 68
	public class SQLiteAsyncConnection
	{
		// Token: 0x060001DF RID: 479 RVA: 0x000086E0 File Offset: 0x000068E0
		public SQLiteAsyncConnection(string databasePath, bool storeDateTimeAsTicks = true) : this(new SQLiteConnectionString(databasePath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex, storeDateTimeAsTicks, null, null, null, null, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", true))
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000870C File Offset: 0x0000690C
		public SQLiteAsyncConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = true) : this(new SQLiteConnectionString(databasePath, openFlags, storeDateTimeAsTicks, null, null, null, null, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", true))
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00008731 File Offset: 0x00006931
		public SQLiteAsyncConnection(SQLiteConnectionString connectionString)
		{
			this._connectionString = connectionString;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00008740 File Offset: 0x00006940
		public string DatabasePath
		{
			get
			{
				return this.GetConnection().DatabasePath;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000874D File Offset: 0x0000694D
		public int LibVersionNumber
		{
			get
			{
				return this.GetConnection().LibVersionNumber;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000875A File Offset: 0x0000695A
		public string DateTimeStringFormat
		{
			get
			{
				return this.GetConnection().DateTimeStringFormat;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00008767 File Offset: 0x00006967
		public TimeSpan GetBusyTimeout()
		{
			return this.GetConnection().BusyTimeout;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008774 File Offset: 0x00006974
		public Task SetBusyTimeoutAsync(TimeSpan value)
		{
			return this.ReadAsync<object>(delegate(SQLiteConnectionWithLock conn)
			{
				conn.BusyTimeout = value;
				return null;
			});
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000087A0 File Offset: 0x000069A0
		public Task EnableWriteAheadLoggingAsync()
		{
			return this.WriteAsync<object>(delegate(SQLiteConnectionWithLock conn)
			{
				conn.EnableWriteAheadLogging();
				return null;
			});
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000087C7 File Offset: 0x000069C7
		public bool StoreDateTimeAsTicks
		{
			get
			{
				return this.GetConnection().StoreDateTimeAsTicks;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000087D4 File Offset: 0x000069D4
		public bool StoreTimeSpanAsTicks
		{
			get
			{
				return this.GetConnection().StoreTimeSpanAsTicks;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000087E1 File Offset: 0x000069E1
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000087EE File Offset: 0x000069EE
		public bool Trace
		{
			get
			{
				return this.GetConnection().Trace;
			}
			set
			{
				this.GetConnection().Trace = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000087FC File Offset: 0x000069FC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00008809 File Offset: 0x00006A09
		public Action<string> Tracer
		{
			get
			{
				return this.GetConnection().Tracer;
			}
			set
			{
				this.GetConnection().Tracer = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00008817 File Offset: 0x00006A17
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00008824 File Offset: 0x00006A24
		public bool TimeExecution
		{
			get
			{
				return this.GetConnection().TimeExecution;
			}
			set
			{
				this.GetConnection().TimeExecution = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00008832 File Offset: 0x00006A32
		public IEnumerable<TableMapping> TableMappings
		{
			get
			{
				return this.GetConnection().TableMappings;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000883F File Offset: 0x00006A3F
		public static void ResetPool()
		{
			SQLiteConnectionPool.Shared.Reset();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000884B File Offset: 0x00006A4B
		public SQLiteConnectionWithLock GetConnection()
		{
			return SQLiteConnectionPool.Shared.GetConnection(this._connectionString);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000885D File Offset: 0x00006A5D
		private SQLiteConnectionWithLock GetConnectionAndTransactionLock(out object transactionLock)
		{
			return SQLiteConnectionPool.Shared.GetConnectionAndTransactionLock(this._connectionString, out transactionLock);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00008870 File Offset: 0x00006A70
		public Task CloseAsync()
		{
			return Task.Factory.StartNew(delegate()
			{
				SQLiteConnectionPool.Shared.CloseConnection(this._connectionString);
			}, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008894 File Offset: 0x00006A94
		private Task<T> ReadAsync<T>(Func<SQLiteConnectionWithLock, T> read)
		{
			return Task.Factory.StartNew<T>(delegate()
			{
				SQLiteConnectionWithLock connection = this.GetConnection();
				T result;
				using (connection.Lock())
				{
					result = read(connection);
				}
				return result;
			}, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000088D8 File Offset: 0x00006AD8
		private Task<T> WriteAsync<T>(Func<SQLiteConnectionWithLock, T> write)
		{
			return Task.Factory.StartNew<T>(delegate()
			{
				SQLiteConnectionWithLock connection = this.GetConnection();
				T result;
				using (connection.Lock())
				{
					result = write(connection);
				}
				return result;
			}, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000891C File Offset: 0x00006B1C
		private Task<T> TransactAsync<T>(Func<SQLiteConnectionWithLock, T> transact)
		{
			return Task.Factory.StartNew<T>(delegate()
			{
				object obj;
				SQLiteConnectionWithLock connectionAndTransactionLock = this.GetConnectionAndTransactionLock(out obj);
				object obj2 = obj;
				T result;
				lock (obj2)
				{
					using (connectionAndTransactionLock.Lock())
					{
						result = transact(connectionAndTransactionLock);
					}
				}
				return result;
			}, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00008960 File Offset: 0x00006B60
		public Task EnableLoadExtensionAsync(bool enabled)
		{
			return this.WriteAsync<object>(delegate(SQLiteConnectionWithLock conn)
			{
				conn.EnableLoadExtension(enabled);
				return null;
			});
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000898C File Offset: 0x00006B8C
		public Task<CreateTableResult> CreateTableAsync<T>(CreateFlags createFlags = CreateFlags.None) where T : new()
		{
			return this.WriteAsync<CreateTableResult>((SQLiteConnectionWithLock conn) => conn.CreateTable<T>(createFlags));
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000089B8 File Offset: 0x00006BB8
		public Task<CreateTableResult> CreateTableAsync(Type ty, CreateFlags createFlags = CreateFlags.None)
		{
			return this.WriteAsync<CreateTableResult>((SQLiteConnectionWithLock conn) => conn.CreateTable(ty, createFlags));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000089EB File Offset: 0x00006BEB
		public Task<CreateTablesResult> CreateTablesAsync<T, T2>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new()
		{
			return this.CreateTablesAsync(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2)
			});
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00008A14 File Offset: 0x00006C14
		public Task<CreateTablesResult> CreateTablesAsync<T, T2, T3>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new() where T3 : new()
		{
			return this.CreateTablesAsync(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2),
				typeof(T3)
			});
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00008A4C File Offset: 0x00006C4C
		public Task<CreateTablesResult> CreateTablesAsync<T, T2, T3, T4>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new() where T3 : new() where T4 : new()
		{
			return this.CreateTablesAsync(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2),
				typeof(T3),
				typeof(T4)
			});
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00008A9C File Offset: 0x00006C9C
		public Task<CreateTablesResult> CreateTablesAsync<T, T2, T3, T4, T5>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new() where T3 : new() where T4 : new() where T5 : new()
		{
			return this.CreateTablesAsync(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2),
				typeof(T3),
				typeof(T4),
				typeof(T5)
			});
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00008AF8 File Offset: 0x00006CF8
		public Task<CreateTablesResult> CreateTablesAsync(CreateFlags createFlags = CreateFlags.None, params Type[] types)
		{
			return this.WriteAsync<CreateTablesResult>((SQLiteConnectionWithLock conn) => conn.CreateTables(createFlags, types));
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00008B2B File Offset: 0x00006D2B
		public Task<int> DropTableAsync<T>() where T : new()
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.DropTable<T>());
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00008B54 File Offset: 0x00006D54
		public Task<int> DropTableAsync(TableMapping map)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.DropTable(map));
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00008B80 File Offset: 0x00006D80
		public Task<int> CreateIndexAsync(string tableName, string columnName, bool unique = false)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.CreateIndex(tableName, columnName, unique));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00008BBC File Offset: 0x00006DBC
		public Task<int> CreateIndexAsync(string indexName, string tableName, string columnName, bool unique = false)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.CreateIndex(indexName, tableName, columnName, unique));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00008C00 File Offset: 0x00006E00
		public Task<int> CreateIndexAsync(string tableName, string[] columnNames, bool unique = false)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.CreateIndex(tableName, columnNames, unique));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00008C3C File Offset: 0x00006E3C
		public Task<int> CreateIndexAsync(string indexName, string tableName, string[] columnNames, bool unique = false)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.CreateIndex(indexName, tableName, columnNames, unique));
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00008C80 File Offset: 0x00006E80
		public Task<int> CreateIndexAsync<T>(Expression<Func<T, object>> property, bool unique = false)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.CreateIndex<T>(property, unique));
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00008CB4 File Offset: 0x00006EB4
		public Task<int> InsertAsync(object obj)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Insert(obj));
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00008CE0 File Offset: 0x00006EE0
		public Task<int> InsertAsync(object obj, Type objType)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Insert(obj, objType));
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008D14 File Offset: 0x00006F14
		public Task<int> InsertAsync(object obj, string extra)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Insert(obj, extra));
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008D48 File Offset: 0x00006F48
		public Task<int> InsertAsync(object obj, string extra, Type objType)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Insert(obj, extra, objType));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008D84 File Offset: 0x00006F84
		public Task<int> InsertOrReplaceAsync(object obj)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.InsertOrReplace(obj));
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008DB0 File Offset: 0x00006FB0
		public Task<int> InsertOrReplaceAsync(object obj, Type objType)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.InsertOrReplace(obj, objType));
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00008DE4 File Offset: 0x00006FE4
		public Task<int> UpdateAsync(object obj)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Update(obj));
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008E10 File Offset: 0x00007010
		public Task<int> UpdateAsync(object obj, Type objType)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Update(obj, objType));
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00008E44 File Offset: 0x00007044
		public Task<int> UpdateAllAsync(IEnumerable objects, bool runInTransaction = true)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.UpdateAll(objects, runInTransaction));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00008E78 File Offset: 0x00007078
		public Task<int> DeleteAsync(object objectToDelete)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Delete(objectToDelete));
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00008EA4 File Offset: 0x000070A4
		public Task<int> DeleteAsync<T>(object primaryKey)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Delete<T>(primaryKey));
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00008ED0 File Offset: 0x000070D0
		public Task<int> DeleteAsync(object primaryKey, TableMapping map)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Delete(primaryKey, map));
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00008F03 File Offset: 0x00007103
		public Task<int> DeleteAllAsync<T>()
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.DeleteAll<T>());
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00008F2C File Offset: 0x0000712C
		public Task<int> DeleteAllAsync(TableMapping map)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.DeleteAll(map));
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00008F58 File Offset: 0x00007158
		public Task BackupAsync(string destinationDatabasePath, string databaseName = "main")
		{
			return this.WriteAsync<int>(delegate(SQLiteConnectionWithLock conn)
			{
				conn.Backup(destinationDatabasePath, databaseName);
				return 0;
			});
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008F8C File Offset: 0x0000718C
		public Task<T> GetAsync<T>(object pk) where T : new()
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => conn.Get<T>(pk));
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00008FB8 File Offset: 0x000071B8
		public Task<object> GetAsync(object pk, TableMapping map)
		{
			return this.ReadAsync<object>((SQLiteConnectionWithLock conn) => conn.Get(pk, map));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00008FEC File Offset: 0x000071EC
		public Task<T> GetAsync<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => conn.Get<T>(predicate));
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00009018 File Offset: 0x00007218
		public Task<T> FindAsync<T>(object pk) where T : new()
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => conn.Find<T>(pk));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00009044 File Offset: 0x00007244
		public Task<object> FindAsync(object pk, TableMapping map)
		{
			return this.ReadAsync<object>((SQLiteConnectionWithLock conn) => conn.Find(pk, map));
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00009078 File Offset: 0x00007278
		public Task<T> FindAsync<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => conn.Find<T>(predicate));
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000090A4 File Offset: 0x000072A4
		public Task<T> FindWithQueryAsync<T>(string query, params object[] args) where T : new()
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => conn.FindWithQuery<T>(query, args));
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000090D8 File Offset: 0x000072D8
		public Task<object> FindWithQueryAsync(TableMapping map, string query, params object[] args)
		{
			return this.ReadAsync<object>((SQLiteConnectionWithLock conn) => conn.FindWithQuery(map, query, args));
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00009114 File Offset: 0x00007314
		public Task<TableMapping> GetMappingAsync(Type type, CreateFlags createFlags = CreateFlags.None)
		{
			return this.ReadAsync<TableMapping>((SQLiteConnectionWithLock conn) => conn.GetMapping(type, createFlags));
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00009148 File Offset: 0x00007348
		public Task<TableMapping> GetMappingAsync<T>(CreateFlags createFlags = CreateFlags.None) where T : new()
		{
			return this.ReadAsync<TableMapping>((SQLiteConnectionWithLock conn) => conn.GetMapping<T>(createFlags));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00009174 File Offset: 0x00007374
		public Task<List<SQLiteConnection.ColumnInfo>> GetTableInfoAsync(string tableName)
		{
			return this.ReadAsync<List<SQLiteConnection.ColumnInfo>>((SQLiteConnectionWithLock conn) => conn.GetTableInfo(tableName));
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000091A0 File Offset: 0x000073A0
		public Task<int> ExecuteAsync(string query, params object[] args)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.Execute(query, args));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000091D4 File Offset: 0x000073D4
		public Task<int> InsertAllAsync(IEnumerable objects, bool runInTransaction = true)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.InsertAll(objects, runInTransaction));
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00009208 File Offset: 0x00007408
		public Task<int> InsertAllAsync(IEnumerable objects, string extra, bool runInTransaction = true)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.InsertAll(objects, extra, runInTransaction));
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00009244 File Offset: 0x00007444
		public Task<int> InsertAllAsync(IEnumerable objects, Type objType, bool runInTransaction = true)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => conn.InsertAll(objects, objType, runInTransaction));
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00009280 File Offset: 0x00007480
		public Task RunInTransactionAsync(Action<SQLiteConnection> action)
		{
			return this.TransactAsync<object>(delegate(SQLiteConnectionWithLock conn)
			{
				conn.BeginTransaction();
				object result;
				try
				{
					action(conn);
					conn.Commit();
					result = null;
				}
				catch (Exception)
				{
					conn.Rollback();
					throw;
				}
				return result;
			});
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000092AC File Offset: 0x000074AC
		public AsyncTableQuery<T> Table<T>() where T : new()
		{
			return new AsyncTableQuery<T>(this.GetConnection().Table<T>());
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000092C0 File Offset: 0x000074C0
		public Task<T> ExecuteScalarAsync<T>(string query, params object[] args)
		{
			return this.WriteAsync<T>((SQLiteConnectionWithLock conn) => conn.CreateCommand(query, args).ExecuteScalar<T>());
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000092F4 File Offset: 0x000074F4
		public Task<List<T>> QueryAsync<T>(string query, params object[] args) where T : new()
		{
			return this.ReadAsync<List<T>>((SQLiteConnectionWithLock conn) => conn.Query<T>(query, args));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00009328 File Offset: 0x00007528
		public Task<List<T>> QueryScalarsAsync<T>(string query, params object[] args)
		{
			return this.ReadAsync<List<T>>((SQLiteConnectionWithLock conn) => conn.QueryScalars<T>(query, args));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000935C File Offset: 0x0000755C
		public Task<List<object>> QueryAsync(TableMapping map, string query, params object[] args)
		{
			return this.ReadAsync<List<object>>((SQLiteConnectionWithLock conn) => conn.Query(map, query, args));
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00009398 File Offset: 0x00007598
		public Task<IEnumerable<T>> DeferredQueryAsync<T>(string query, params object[] args) where T : new()
		{
			return this.ReadAsync<IEnumerable<T>>((SQLiteConnectionWithLock conn) => conn.DeferredQuery<T>(query, args).ToList<T>());
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000093CC File Offset: 0x000075CC
		public Task<IEnumerable<object>> DeferredQueryAsync(TableMapping map, string query, params object[] args)
		{
			return this.ReadAsync<IEnumerable<object>>((SQLiteConnectionWithLock conn) => conn.DeferredQuery(map, query, args).ToList<object>());
		}

		// Token: 0x04000147 RID: 327
		private readonly SQLiteConnectionString _connectionString;
	}
}
