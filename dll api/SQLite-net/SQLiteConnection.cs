using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using SQLitePCL;

namespace SQLite
{
	// Token: 0x02000007 RID: 7
	[Preserve(AllMembers = true)]
	public class SQLiteConnection : IDisposable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000212F File Offset: 0x0000032F
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002137 File Offset: 0x00000337
		public sqlite3 Handle { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002140 File Offset: 0x00000340
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002148 File Offset: 0x00000348
		public string DatabasePath { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002151 File Offset: 0x00000351
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002159 File Offset: 0x00000359
		public int LibVersionNumber { get; private set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002162 File Offset: 0x00000362
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000216A File Offset: 0x0000036A
		public bool TimeExecution { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002173 File Offset: 0x00000373
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000217B File Offset: 0x0000037B
		public bool Trace { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002184 File Offset: 0x00000384
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000218C File Offset: 0x0000038C
		public Action<string> Tracer { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002195 File Offset: 0x00000395
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000219D File Offset: 0x0000039D
		public bool StoreDateTimeAsTicks { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000021A6 File Offset: 0x000003A6
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000021AE File Offset: 0x000003AE
		public bool StoreTimeSpanAsTicks { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000021B7 File Offset: 0x000003B7
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000021BF File Offset: 0x000003BF
		public string DateTimeStringFormat { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000021C8 File Offset: 0x000003C8
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000021D0 File Offset: 0x000003D0
		internal DateTimeStyles DateTimeStyle { get; private set; }

		// Token: 0x06000022 RID: 34 RVA: 0x000021D9 File Offset: 0x000003D9
		static SQLiteConnection()
		{
			Batteries_V2.Init();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021F8 File Offset: 0x000003F8
		public SQLiteConnection(string databasePath, bool storeDateTimeAsTicks = true) : this(new SQLiteConnectionString(databasePath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create, storeDateTimeAsTicks, null, null, null, null, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", true))
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002220 File Offset: 0x00000420
		public SQLiteConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = true) : this(new SQLiteConnectionString(databasePath, openFlags, storeDateTimeAsTicks, null, null, null, null, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", true))
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002248 File Offset: 0x00000448
		public SQLiteConnection(SQLiteConnectionString connectionString)
		{
			if (connectionString == null)
			{
				throw new ArgumentNullException("connectionString");
			}
			if (connectionString.DatabasePath == null)
			{
				throw new InvalidOperationException("DatabasePath must be specified");
			}
			this.DatabasePath = connectionString.DatabasePath;
			this.LibVersionNumber = SQLite3.LibVersionNumber();
			sqlite3 handle;
			SQLite3.Result result = SQLite3.Open(connectionString.DatabasePath, out handle, (int)connectionString.OpenFlags, connectionString.VfsName);
			this.Handle = handle;
			if (result != SQLite3.Result.OK)
			{
				throw SQLiteException.New(result, string.Format("Could not open database file: {0} ({1})", this.DatabasePath, result));
			}
			this._open = true;
			this.StoreDateTimeAsTicks = connectionString.StoreDateTimeAsTicks;
			this.StoreTimeSpanAsTicks = connectionString.StoreTimeSpanAsTicks;
			this.DateTimeStringFormat = connectionString.DateTimeStringFormat;
			this.DateTimeStyle = connectionString.DateTimeStyle;
			this.BusyTimeout = TimeSpan.FromSeconds(1.0);
			this.Tracer = delegate(string line)
			{
			};
			Action<SQLiteConnection> preKeyAction = connectionString.PreKeyAction;
			if (preKeyAction != null)
			{
				preKeyAction(this);
			}
			string text = connectionString.Key as string;
			if (text != null)
			{
				this.SetKey(text);
			}
			else
			{
				byte[] array = connectionString.Key as byte[];
				if (array != null)
				{
					this.SetKey(array);
				}
				else if (connectionString.Key != null)
				{
					throw new InvalidOperationException("Encryption keys must be strings or byte arrays");
				}
			}
			Action<SQLiteConnection> postKeyAction = connectionString.PostKeyAction;
			if (postKeyAction == null)
			{
				return;
			}
			postKeyAction(this);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000023C0 File Offset: 0x000005C0
		public void EnableWriteAheadLogging()
		{
			this.ExecuteScalar<string>("PRAGMA journal_mode=WAL", Array.Empty<object>());
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000023D4 File Offset: 0x000005D4
		private static string Quote(string unsafeString)
		{
			if (unsafeString == null)
			{
				return "NULL";
			}
			string str = unsafeString.Replace("'", "''");
			return "'" + str + "'";
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000240C File Offset: 0x0000060C
		private void SetKey(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			string str = SQLiteConnection.Quote(key);
			this.ExecuteScalar<string>("pragma key = " + str, Array.Empty<object>());
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002448 File Offset: 0x00000648
		private void SetKey(byte[] key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (key.Length != 32 && key.Length != 48)
			{
				throw new ArgumentException("Key must be 32 bytes (256-bit) or 48 bytes (384-bit)", "key");
			}
			string str = string.Join("", from x in key
			select x.ToString("X2"));
			this.ExecuteScalar<string>("pragma key = \"x'" + str + "'\"", Array.Empty<object>());
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024D0 File Offset: 0x000006D0
		public void EnableLoadExtension(bool enabled)
		{
			SQLite3.Result result = SQLite3.EnableLoadExtension(this.Handle, enabled ? 1 : 0);
			if (result != SQLite3.Result.OK)
			{
				string errmsg = SQLite3.GetErrmsg(this.Handle);
				throw SQLiteException.New(result, errmsg);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002507 File Offset: 0x00000707
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000250F File Offset: 0x0000070F
		public TimeSpan BusyTimeout
		{
			get
			{
				return this._busyTimeout;
			}
			set
			{
				this._busyTimeout = value;
				if (this.Handle != SQLiteConnection.NullHandle)
				{
					SQLite3.BusyTimeout(this.Handle, (int)this._busyTimeout.TotalMilliseconds);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002540 File Offset: 0x00000740
		public IEnumerable<TableMapping> TableMappings
		{
			get
			{
				Dictionary<string, TableMapping> mappings = SQLiteConnection._mappings;
				IEnumerable<TableMapping> result;
				lock (mappings)
				{
					result = new List<TableMapping>(SQLiteConnection._mappings.Values);
				}
				return result;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000258C File Offset: 0x0000078C
		public TableMapping GetMapping(Type type, CreateFlags createFlags = CreateFlags.None)
		{
			string fullName = type.FullName;
			Dictionary<string, TableMapping> mappings = SQLiteConnection._mappings;
			TableMapping tableMapping;
			lock (mappings)
			{
				if (SQLiteConnection._mappings.TryGetValue(fullName, out tableMapping))
				{
					if (createFlags != CreateFlags.None && createFlags != tableMapping.CreateFlags)
					{
						tableMapping = new TableMapping(type, createFlags);
						SQLiteConnection._mappings[fullName] = tableMapping;
					}
				}
				else
				{
					tableMapping = new TableMapping(type, createFlags);
					SQLiteConnection._mappings.Add(fullName, tableMapping);
				}
			}
			return tableMapping;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002614 File Offset: 0x00000814
		public TableMapping GetMapping<T>(CreateFlags createFlags = CreateFlags.None)
		{
			return this.GetMapping(typeof(T), createFlags);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002627 File Offset: 0x00000827
		public int DropTable<T>()
		{
			return this.DropTable(this.GetMapping(typeof(T), CreateFlags.None));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002640 File Offset: 0x00000840
		public int DropTable(TableMapping map)
		{
			string query = string.Format("drop table if exists \"{0}\"", map.TableName);
			return this.Execute(query, Array.Empty<object>());
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000266A File Offset: 0x0000086A
		public CreateTableResult CreateTable<T>(CreateFlags createFlags = CreateFlags.None)
		{
			return this.CreateTable(typeof(T), createFlags);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002680 File Offset: 0x00000880
		public CreateTableResult CreateTable(Type ty, CreateFlags createFlags = CreateFlags.None)
		{
			TableMapping mapping = this.GetMapping(ty, createFlags);
			if (mapping.Columns.Length == 0)
			{
				throw new Exception(string.Format("Cannot create a table without columns (does '{0}' have public properties?)", ty.FullName));
			}
			CreateTableResult result = CreateTableResult.Created;
			List<SQLiteConnection.ColumnInfo> tableInfo = this.GetTableInfo(mapping.TableName);
			if (tableInfo.Count == 0)
			{
				bool flag = (createFlags & CreateFlags.FullTextSearch3) > CreateFlags.None;
				bool flag2 = (createFlags & CreateFlags.FullTextSearch4) > CreateFlags.None;
				string text = (flag || flag2) ? "virtual " : string.Empty;
				string text2 = flag ? "using fts3 " : (flag2 ? "using fts4 " : string.Empty);
				string text3 = string.Concat(new string[]
				{
					"create ",
					text,
					"table if not exists \"",
					mapping.TableName,
					"\" ",
					text2,
					"(\n"
				});
				IEnumerable<string> source = from p in mapping.Columns
				select Orm.SqlDecl(p, this.StoreDateTimeAsTicks, this.StoreTimeSpanAsTicks);
				string str = string.Join(",\n", source.ToArray<string>());
				text3 += str;
				text3 += ")";
				if (mapping.WithoutRowId)
				{
					text3 += " without rowid";
				}
				this.Execute(text3, Array.Empty<object>());
			}
			else
			{
				result = CreateTableResult.Migrated;
				this.MigrateTable(mapping, tableInfo);
			}
			Dictionary<string, SQLiteConnection.IndexInfo> dictionary = new Dictionary<string, SQLiteConnection.IndexInfo>();
			foreach (TableMapping.Column column in mapping.Columns)
			{
				foreach (IndexedAttribute indexedAttribute in column.Indices)
				{
					string text4 = indexedAttribute.Name ?? (mapping.TableName + "_" + column.Name);
					SQLiteConnection.IndexInfo indexInfo;
					if (!dictionary.TryGetValue(text4, out indexInfo))
					{
						indexInfo = new SQLiteConnection.IndexInfo
						{
							IndexName = text4,
							TableName = mapping.TableName,
							Unique = indexedAttribute.Unique,
							Columns = new List<SQLiteConnection.IndexedColumn>()
						};
						dictionary.Add(text4, indexInfo);
					}
					if (indexedAttribute.Unique != indexInfo.Unique)
					{
						throw new Exception("All the columns in an index must have the same value for their Unique property");
					}
					indexInfo.Columns.Add(new SQLiteConnection.IndexedColumn
					{
						Order = indexedAttribute.Order,
						ColumnName = column.Name
					});
				}
			}
			foreach (string text5 in dictionary.Keys)
			{
				SQLiteConnection.IndexInfo indexInfo2 = dictionary[text5];
				string[] columnNames = (from i in indexInfo2.Columns
				orderby i.Order
				select i.ColumnName).ToArray<string>();
				this.CreateIndex(text5, indexInfo2.TableName, columnNames, indexInfo2.Unique);
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029C0 File Offset: 0x00000BC0
		public CreateTablesResult CreateTables<T, T2>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new()
		{
			return this.CreateTables(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2)
			});
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000029E9 File Offset: 0x00000BE9
		public CreateTablesResult CreateTables<T, T2, T3>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new() where T3 : new()
		{
			return this.CreateTables(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2),
				typeof(T3)
			});
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A20 File Offset: 0x00000C20
		public CreateTablesResult CreateTables<T, T2, T3, T4>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new() where T3 : new() where T4 : new()
		{
			return this.CreateTables(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2),
				typeof(T3),
				typeof(T4)
			});
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002A70 File Offset: 0x00000C70
		public CreateTablesResult CreateTables<T, T2, T3, T4, T5>(CreateFlags createFlags = CreateFlags.None) where T : new() where T2 : new() where T3 : new() where T4 : new() where T5 : new()
		{
			return this.CreateTables(createFlags, new Type[]
			{
				typeof(T),
				typeof(T2),
				typeof(T3),
				typeof(T4),
				typeof(T5)
			});
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002ACC File Offset: 0x00000CCC
		public CreateTablesResult CreateTables(CreateFlags createFlags = CreateFlags.None, params Type[] types)
		{
			CreateTablesResult createTablesResult = new CreateTablesResult();
			foreach (Type type in types)
			{
				CreateTableResult value = this.CreateTable(type, createFlags);
				createTablesResult.Results[type] = value;
			}
			return createTablesResult;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002B0C File Offset: 0x00000D0C
		public int CreateIndex(string indexName, string tableName, string[] columnNames, bool unique = false)
		{
			string query = string.Format("create {2} index if not exists \"{3}\" on \"{0}\"(\"{1}\")", new object[]
			{
				tableName,
				string.Join("\", \"", columnNames),
				unique ? "unique" : "",
				indexName
			});
			return this.Execute(query, Array.Empty<object>());
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002B5F File Offset: 0x00000D5F
		public int CreateIndex(string indexName, string tableName, string columnName, bool unique = false)
		{
			return this.CreateIndex(indexName, tableName, new string[]
			{
				columnName
			}, unique);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002B75 File Offset: 0x00000D75
		public int CreateIndex(string tableName, string columnName, bool unique = false)
		{
			return this.CreateIndex(tableName + "_" + columnName, tableName, columnName, unique);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002B8C File Offset: 0x00000D8C
		public int CreateIndex(string tableName, string[] columnNames, bool unique = false)
		{
			return this.CreateIndex(tableName + "_" + string.Join("_", columnNames), tableName, columnNames, unique);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public int CreateIndex<T>(Expression<Func<T, object>> property, bool unique = false)
		{
			MemberExpression memberExpression;
			if (property.Body.NodeType == ExpressionType.Convert)
			{
				memberExpression = (((UnaryExpression)property.Body).Operand as MemberExpression);
			}
			else
			{
				memberExpression = (property.Body as MemberExpression);
			}
			PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
			if (propertyInfo == null)
			{
				throw new ArgumentException("The lambda expression 'property' should point to a valid Property");
			}
			string name = propertyInfo.Name;
			TableMapping mapping = this.GetMapping<T>(CreateFlags.None);
			string name2 = mapping.FindColumnWithPropertyName(name).Name;
			return this.CreateIndex(mapping.TableName, name2, unique);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002C38 File Offset: 0x00000E38
		public List<SQLiteConnection.ColumnInfo> GetTableInfo(string tableName)
		{
			string query = "pragma table_info(\"" + tableName + "\")";
			return this.Query<SQLiteConnection.ColumnInfo>(query, Array.Empty<object>());
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002C64 File Offset: 0x00000E64
		private void MigrateTable(TableMapping map, List<SQLiteConnection.ColumnInfo> existingCols)
		{
			List<TableMapping.Column> list = new List<TableMapping.Column>();
			foreach (TableMapping.Column column in map.Columns)
			{
				bool flag = false;
				foreach (SQLiteConnection.ColumnInfo columnInfo in existingCols)
				{
					flag = (string.Compare(column.Name, columnInfo.Name, StringComparison.OrdinalIgnoreCase) == 0);
					if (flag)
					{
						break;
					}
				}
				if (!flag)
				{
					list.Add(column);
				}
			}
			foreach (TableMapping.Column p in list)
			{
				string query = "alter table \"" + map.TableName + "\" add column " + Orm.SqlDecl(p, this.StoreDateTimeAsTicks, this.StoreTimeSpanAsTicks);
				this.Execute(query, Array.Empty<object>());
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002D68 File Offset: 0x00000F68
		protected virtual SQLiteCommand NewCommand()
		{
			return new SQLiteCommand(this);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D70 File Offset: 0x00000F70
		public SQLiteCommand CreateCommand(string cmdText, params object[] ps)
		{
			if (!this._open)
			{
				throw SQLiteException.New(SQLite3.Result.Error, "Cannot create commands from unopened database");
			}
			SQLiteCommand sqliteCommand = this.NewCommand();
			sqliteCommand.CommandText = cmdText;
			foreach (object val in ps)
			{
				sqliteCommand.Bind(val);
			}
			return sqliteCommand;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002DBC File Offset: 0x00000FBC
		public SQLiteCommand CreateCommand(string cmdText, Dictionary<string, object> args)
		{
			if (!this._open)
			{
				throw SQLiteException.New(SQLite3.Result.Error, "Cannot create commands from unopened database");
			}
			SQLiteCommand sqliteCommand = this.NewCommand();
			sqliteCommand.CommandText = cmdText;
			foreach (KeyValuePair<string, object> keyValuePair in args)
			{
				sqliteCommand.Bind(keyValuePair.Key, keyValuePair.Value);
			}
			return sqliteCommand;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002E3C File Offset: 0x0000103C
		public int Execute(string query, params object[] args)
		{
			SQLiteCommand sqliteCommand = this.CreateCommand(query, args);
			if (this.TimeExecution)
			{
				if (this._sw == null)
				{
					this._sw = new Stopwatch();
				}
				this._sw.Reset();
				this._sw.Start();
			}
			int result = sqliteCommand.ExecuteNonQuery();
			if (this.TimeExecution)
			{
				this._sw.Stop();
				this._elapsedMilliseconds += this._sw.ElapsedMilliseconds;
				Action<string> tracer = this.Tracer;
				if (tracer == null)
				{
					return result;
				}
				tracer(string.Format("Finished in {0} ms ({1:0.0} s total)", this._sw.ElapsedMilliseconds, (double)this._elapsedMilliseconds / 1000.0));
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002EF4 File Offset: 0x000010F4
		public T ExecuteScalar<T>(string query, params object[] args)
		{
			SQLiteCommand sqliteCommand = this.CreateCommand(query, args);
			if (this.TimeExecution)
			{
				if (this._sw == null)
				{
					this._sw = new Stopwatch();
				}
				this._sw.Reset();
				this._sw.Start();
			}
			T result = sqliteCommand.ExecuteScalar<T>();
			if (this.TimeExecution)
			{
				this._sw.Stop();
				this._elapsedMilliseconds += this._sw.ElapsedMilliseconds;
				Action<string> tracer = this.Tracer;
				if (tracer == null)
				{
					return result;
				}
				tracer(string.Format("Finished in {0} ms ({1:0.0} s total)", this._sw.ElapsedMilliseconds, (double)this._elapsedMilliseconds / 1000.0));
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002FAA File Offset: 0x000011AA
		public List<T> Query<T>(string query, params object[] args) where T : new()
		{
			return this.CreateCommand(query, args).ExecuteQuery<T>();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002FB9 File Offset: 0x000011B9
		public List<T> QueryScalars<T>(string query, params object[] args)
		{
			return this.CreateCommand(query, args).ExecuteQueryScalars<T>().ToList<T>();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002FCD File Offset: 0x000011CD
		public IEnumerable<T> DeferredQuery<T>(string query, params object[] args) where T : new()
		{
			return this.CreateCommand(query, args).ExecuteDeferredQuery<T>();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002FDC File Offset: 0x000011DC
		public List<object> Query(TableMapping map, string query, params object[] args)
		{
			return this.CreateCommand(query, args).ExecuteQuery<object>(map);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002FEC File Offset: 0x000011EC
		public IEnumerable<object> DeferredQuery(TableMapping map, string query, params object[] args)
		{
			return this.CreateCommand(query, args).ExecuteDeferredQuery<object>(map);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002FFC File Offset: 0x000011FC
		public TableQuery<T> Table<T>() where T : new()
		{
			return new TableQuery<T>(this);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003004 File Offset: 0x00001204
		public T Get<T>(object pk) where T : new()
		{
			TableMapping mapping = this.GetMapping(typeof(T), CreateFlags.None);
			return this.Query<T>(mapping.GetByPrimaryKeySql, new object[]
			{
				pk
			}).First<T>();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000303E File Offset: 0x0000123E
		public object Get(object pk, TableMapping map)
		{
			return this.Query(map, map.GetByPrimaryKeySql, new object[]
			{
				pk
			}).First<object>();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000305C File Offset: 0x0000125C
		public T Get<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return this.Table<T>().Where(predicate).First();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003070 File Offset: 0x00001270
		public T Find<T>(object pk) where T : new()
		{
			TableMapping mapping = this.GetMapping(typeof(T), CreateFlags.None);
			return this.Query<T>(mapping.GetByPrimaryKeySql, new object[]
			{
				pk
			}).FirstOrDefault<T>();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000030AA File Offset: 0x000012AA
		public object Find(object pk, TableMapping map)
		{
			return this.Query(map, map.GetByPrimaryKeySql, new object[]
			{
				pk
			}).FirstOrDefault<object>();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000030C8 File Offset: 0x000012C8
		public T Find<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return this.Table<T>().Where(predicate).FirstOrDefault();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000030DB File Offset: 0x000012DB
		public T FindWithQuery<T>(string query, params object[] args) where T : new()
		{
			return this.Query<T>(query, args).FirstOrDefault<T>();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000030EA File Offset: 0x000012EA
		public object FindWithQuery(TableMapping map, string query, params object[] args)
		{
			return this.Query(map, query, args).FirstOrDefault<object>();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000030FA File Offset: 0x000012FA
		public bool IsInTransaction
		{
			get
			{
				return this._transactionDepth > 0;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003108 File Offset: 0x00001308
		public void BeginTransaction()
		{
			if (Interlocked.CompareExchange(ref this._transactionDepth, 1, 0) == 0)
			{
				try
				{
					this.Execute("begin transaction", Array.Empty<object>());
					return;
				}
				catch (Exception ex)
				{
					SQLiteException ex2 = ex as SQLiteException;
					if (ex2 != null)
					{
						switch (ex2.Result)
						{
						case SQLite3.Result.Busy:
						case SQLite3.Result.NoMem:
						case SQLite3.Result.Interrupt:
						case SQLite3.Result.IOError:
						case SQLite3.Result.Full:
							this.RollbackTo(null, true);
							break;
						}
					}
					else
					{
						Interlocked.Decrement(ref this._transactionDepth);
					}
					throw;
				}
			}
			throw new InvalidOperationException("Cannot begin a transaction while already in a transaction.");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000031A8 File Offset: 0x000013A8
		public string SaveTransactionPoint()
		{
			int num = Interlocked.Increment(ref this._transactionDepth) - 1;
			string text = "S" + this._rand.Next(32767).ToString() + "D" + num.ToString();
			try
			{
				this.Execute("savepoint " + text, Array.Empty<object>());
			}
			catch (Exception ex)
			{
				SQLiteException ex2 = ex as SQLiteException;
				if (ex2 != null)
				{
					switch (ex2.Result)
					{
					case SQLite3.Result.Busy:
					case SQLite3.Result.NoMem:
					case SQLite3.Result.Interrupt:
					case SQLite3.Result.IOError:
					case SQLite3.Result.Full:
						this.RollbackTo(null, true);
						break;
					}
				}
				else
				{
					Interlocked.Decrement(ref this._transactionDepth);
				}
				throw;
			}
			return text;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003274 File Offset: 0x00001474
		public void Rollback()
		{
			this.RollbackTo(null, false);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000327E File Offset: 0x0000147E
		public void RollbackTo(string savepoint)
		{
			this.RollbackTo(savepoint, false);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003288 File Offset: 0x00001488
		private void RollbackTo(string savepoint, bool noThrow)
		{
			try
			{
				if (string.IsNullOrEmpty(savepoint))
				{
					if (Interlocked.Exchange(ref this._transactionDepth, 0) > 0)
					{
						this.Execute("rollback", Array.Empty<object>());
					}
				}
				else
				{
					this.DoSavePointExecute(savepoint, "rollback to ");
				}
			}
			catch (SQLiteException)
			{
				if (!noThrow)
				{
					throw;
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000032E8 File Offset: 0x000014E8
		public void Release(string savepoint)
		{
			try
			{
				this.DoSavePointExecute(savepoint, "release ");
			}
			catch (SQLiteException ex)
			{
				if (ex.Result == SQLite3.Result.Busy)
				{
					try
					{
						this.Execute("rollback", Array.Empty<object>());
					}
					catch
					{
					}
				}
				throw;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003340 File Offset: 0x00001540
		private void DoSavePointExecute(string savepoint, string cmd)
		{
			int num = savepoint.IndexOf('D');
			int num2;
			if (num >= 2 && savepoint.Length > num + 1 && int.TryParse(savepoint.Substring(num + 1), out num2) && 0 <= num2 && num2 < this._transactionDepth)
			{
				Volatile.Write(ref this._transactionDepth, num2);
				this.Execute(cmd + savepoint, Array.Empty<object>());
				return;
			}
			throw new ArgumentException("savePoint is not valid, and should be the result of a call to SaveTransactionPoint.", "savePoint");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000033B4 File Offset: 0x000015B4
		public void Commit()
		{
			if (Interlocked.Exchange(ref this._transactionDepth, 0) != 0)
			{
				try
				{
					this.Execute("commit", Array.Empty<object>());
				}
				catch
				{
					try
					{
						this.Execute("rollback", Array.Empty<object>());
					}
					catch
					{
					}
					throw;
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003418 File Offset: 0x00001618
		public void RunInTransaction(Action action)
		{
			try
			{
				string savepoint = this.SaveTransactionPoint();
				action();
				this.Release(savepoint);
			}
			catch (Exception)
			{
				this.Rollback();
				throw;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003454 File Offset: 0x00001654
		public int InsertAll(IEnumerable objects, bool runInTransaction = true)
		{
			int c = 0;
			if (runInTransaction)
			{
				this.RunInTransaction(delegate
				{
					foreach (object obj2 in objects)
					{
						c += this.Insert(obj2);
					}
				});
			}
			else
			{
				foreach (object obj in objects)
				{
					c += this.Insert(obj);
				}
			}
			return c;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000034F0 File Offset: 0x000016F0
		public int InsertAll(IEnumerable objects, string extra, bool runInTransaction = true)
		{
			int c = 0;
			if (runInTransaction)
			{
				this.RunInTransaction(delegate
				{
					foreach (object obj2 in objects)
					{
						c += this.Insert(obj2, extra);
					}
				});
			}
			else
			{
				foreach (object obj in objects)
				{
					c += this.Insert(obj, extra);
				}
			}
			return c;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003598 File Offset: 0x00001798
		public int InsertAll(IEnumerable objects, Type objType, bool runInTransaction = true)
		{
			int c = 0;
			if (runInTransaction)
			{
				this.RunInTransaction(delegate
				{
					foreach (object obj2 in objects)
					{
						c += this.Insert(obj2, objType);
					}
				});
			}
			else
			{
				foreach (object obj in objects)
				{
					c += this.Insert(obj, objType);
				}
			}
			return c;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003640 File Offset: 0x00001840
		public int Insert(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return this.Insert(obj, "", Orm.GetType(obj));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003659 File Offset: 0x00001859
		public int InsertOrReplace(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return this.Insert(obj, "OR REPLACE", Orm.GetType(obj));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003672 File Offset: 0x00001872
		public int Insert(object obj, Type objType)
		{
			return this.Insert(obj, "", objType);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003681 File Offset: 0x00001881
		public int InsertOrReplace(object obj, Type objType)
		{
			return this.Insert(obj, "OR REPLACE", objType);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003690 File Offset: 0x00001890
		public int Insert(object obj, string extra)
		{
			if (obj == null)
			{
				return 0;
			}
			return this.Insert(obj, extra, Orm.GetType(obj));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000036A8 File Offset: 0x000018A8
		public int Insert(object obj, string extra, Type objType)
		{
			if (obj == null || objType == null)
			{
				return 0;
			}
			TableMapping mapping = this.GetMapping(objType, CreateFlags.None);
			if (mapping.PK != null && mapping.PK.IsAutoGuid && mapping.PK.GetValue(obj).Equals(Guid.Empty))
			{
				mapping.PK.SetValue(obj, Guid.NewGuid());
			}
			TableMapping.Column[] array = (string.Compare(extra, "OR REPLACE", StringComparison.OrdinalIgnoreCase) == 0) ? mapping.InsertOrReplaceColumns : mapping.InsertColumns;
			object[] array2 = new object[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = array[i].GetValue(obj);
			}
			PreparedSqlLiteInsertCommand insertCommand = this.GetInsertCommand(mapping, extra);
			PreparedSqlLiteInsertCommand obj2 = insertCommand;
			int num;
			lock (obj2)
			{
				try
				{
					num = insertCommand.ExecuteNonQuery(array2);
				}
				catch (SQLiteException ex)
				{
					if (SQLite3.ExtendedErrCode(this.Handle) == SQLite3.ExtendedResult.ConstraintNotNull)
					{
						throw NotNullConstraintViolationException.New(ex.Result, ex.Message, mapping, obj);
					}
					throw;
				}
				if (mapping.HasAutoIncPK)
				{
					long id = SQLite3.LastInsertRowid(this.Handle);
					mapping.SetAutoIncPK(obj, id);
				}
			}
			if (num > 0)
			{
				this.OnTableChanged(mapping, NotifyTableChangedAction.Insert);
			}
			return num;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003804 File Offset: 0x00001A04
		private PreparedSqlLiteInsertCommand GetInsertCommand(TableMapping map, string extra)
		{
			Tuple<string, string> key = Tuple.Create<string, string>(map.MappedType.FullName, extra);
			Dictionary<Tuple<string, string>, PreparedSqlLiteInsertCommand> insertCommandMap = this._insertCommandMap;
			PreparedSqlLiteInsertCommand preparedSqlLiteInsertCommand;
			lock (insertCommandMap)
			{
				if (this._insertCommandMap.TryGetValue(key, out preparedSqlLiteInsertCommand))
				{
					return preparedSqlLiteInsertCommand;
				}
			}
			preparedSqlLiteInsertCommand = this.CreateInsertCommand(map, extra);
			insertCommandMap = this._insertCommandMap;
			lock (insertCommandMap)
			{
				PreparedSqlLiteInsertCommand result;
				if (this._insertCommandMap.TryGetValue(key, out result))
				{
					preparedSqlLiteInsertCommand.Dispose();
					return result;
				}
				this._insertCommandMap.Add(key, preparedSqlLiteInsertCommand);
			}
			return preparedSqlLiteInsertCommand;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000038C4 File Offset: 0x00001AC4
		private PreparedSqlLiteInsertCommand CreateInsertCommand(TableMapping map, string extra)
		{
			TableMapping.Column[] array = map.InsertColumns;
			string commandText;
			if (array.Length == 0 && map.Columns.Length == 1 && map.Columns[0].IsAutoInc)
			{
				commandText = string.Format("insert {1} into \"{0}\" default values", map.TableName, extra);
			}
			else
			{
				if (string.Compare(extra, "OR REPLACE", StringComparison.OrdinalIgnoreCase) == 0)
				{
					array = map.InsertOrReplaceColumns;
				}
				string format = "insert {3} into \"{0}\"({1}) values ({2})";
				object[] array2 = new object[4];
				array2[0] = map.TableName;
				array2[1] = string.Join(",", (from c in array
				select "\"" + c.Name + "\"").ToArray<string>());
				array2[2] = string.Join(",", (from c in array
				select "?").ToArray<string>());
				array2[3] = extra;
				commandText = string.Format(format, array2);
			}
			return new PreparedSqlLiteInsertCommand(this, commandText);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000039B8 File Offset: 0x00001BB8
		public int Update(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return this.Update(obj, Orm.GetType(obj));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000039CC File Offset: 0x00001BCC
		public int Update(object obj, Type objType)
		{
			int num = 0;
			if (obj == null || objType == null)
			{
				return 0;
			}
			TableMapping mapping = this.GetMapping(objType, CreateFlags.None);
			TableMapping.Column pk = mapping.PK;
			if (pk == null)
			{
				throw new NotSupportedException("Cannot update " + mapping.TableName + ": it has no PK");
			}
			IEnumerable<TableMapping.Column> source = from p in mapping.Columns
			where p != pk
			select p;
			List<object> list = new List<object>(from c in source
			select c.GetValue(obj));
			if (list.Count == 0)
			{
				source = mapping.Columns;
				list = new List<object>(from c in source
				select c.GetValue(obj));
			}
			list.Add(pk.GetValue(obj));
			string query = string.Format("update \"{0}\" set {1} where \"{2}\" = ? ", mapping.TableName, string.Join(",", (from c in source
			select "\"" + c.Name + "\" = ? ").ToArray<string>()), pk.Name);
			try
			{
				num = this.Execute(query, list.ToArray());
			}
			catch (SQLiteException ex)
			{
				if (ex.Result == SQLite3.Result.Constraint && SQLite3.ExtendedErrCode(this.Handle) == SQLite3.ExtendedResult.ConstraintNotNull)
				{
					throw NotNullConstraintViolationException.New(ex, mapping, obj);
				}
				throw ex;
			}
			if (num > 0)
			{
				this.OnTableChanged(mapping, NotifyTableChangedAction.Update);
			}
			return num;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003B58 File Offset: 0x00001D58
		public int UpdateAll(IEnumerable objects, bool runInTransaction = true)
		{
			int c = 0;
			if (runInTransaction)
			{
				this.RunInTransaction(delegate
				{
					foreach (object obj2 in objects)
					{
						c += this.Update(obj2);
					}
				});
			}
			else
			{
				foreach (object obj in objects)
				{
					c += this.Update(obj);
				}
			}
			return c;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public int Delete(object objectToDelete)
		{
			TableMapping mapping = this.GetMapping(Orm.GetType(objectToDelete), CreateFlags.None);
			TableMapping.Column pk = mapping.PK;
			if (pk == null)
			{
				throw new NotSupportedException("Cannot delete " + mapping.TableName + ": it has no PK");
			}
			string query = string.Format("delete from \"{0}\" where \"{1}\" = ?", mapping.TableName, pk.Name);
			int num = this.Execute(query, new object[]
			{
				pk.GetValue(objectToDelete)
			});
			if (num > 0)
			{
				this.OnTableChanged(mapping, NotifyTableChangedAction.Delete);
			}
			return num;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003C6E File Offset: 0x00001E6E
		public int Delete<T>(object primaryKey)
		{
			return this.Delete(primaryKey, this.GetMapping(typeof(T), CreateFlags.None));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003C88 File Offset: 0x00001E88
		public int Delete(object primaryKey, TableMapping map)
		{
			TableMapping.Column pk = map.PK;
			if (pk == null)
			{
				throw new NotSupportedException("Cannot delete " + map.TableName + ": it has no PK");
			}
			string query = string.Format("delete from \"{0}\" where \"{1}\" = ?", map.TableName, pk.Name);
			int num = this.Execute(query, new object[]
			{
				primaryKey
			});
			if (num > 0)
			{
				this.OnTableChanged(map, NotifyTableChangedAction.Delete);
			}
			return num;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003CF0 File Offset: 0x00001EF0
		public int DeleteAll<T>()
		{
			TableMapping mapping = this.GetMapping(typeof(T), CreateFlags.None);
			return this.DeleteAll(mapping);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003D18 File Offset: 0x00001F18
		public int DeleteAll(TableMapping map)
		{
			string query = string.Format("delete from \"{0}\"", map.TableName);
			int num = this.Execute(query, Array.Empty<object>());
			if (num > 0)
			{
				this.OnTableChanged(map, NotifyTableChangedAction.Delete);
			}
			return num;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003D50 File Offset: 0x00001F50
		public void Backup(string destinationDatabasePath, string databaseName = "main")
		{
			sqlite3 sqlite;
			SQLite3.Result result = SQLite3.Open(destinationDatabasePath, out sqlite);
			if (result != SQLite3.Result.OK)
			{
				throw SQLiteException.New(result, "Failed to open destination database");
			}
			sqlite3_backup sqlite3_backup = SQLite3.BackupInit(sqlite, databaseName, this.Handle, databaseName);
			if (sqlite3_backup == SQLiteConnection.NullBackupHandle)
			{
				SQLite3.Close(sqlite);
				throw new Exception("Failed to create backup");
			}
			SQLite3.BackupStep(sqlite3_backup, -1);
			SQLite3.BackupFinish(sqlite3_backup);
			result = SQLite3.GetResult(sqlite);
			string message = "";
			if (result != SQLite3.Result.OK)
			{
				message = SQLite3.GetErrmsg(sqlite);
			}
			SQLite3.Close(sqlite);
			if (result != SQLite3.Result.OK)
			{
				throw SQLiteException.New(result, message);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003DD4 File Offset: 0x00001FD4
		~SQLiteConnection()
		{
			this.Dispose(false);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003E04 File Offset: 0x00002004
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003E13 File Offset: 0x00002013
		public void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003E1C File Offset: 0x0000201C
		protected virtual void Dispose(bool disposing)
		{
			bool flag = this.LibVersionNumber >= 3007014;
			if (this._open && this.Handle != SQLiteConnection.NullHandle)
			{
				try
				{
					if (disposing)
					{
						Dictionary<Tuple<string, string>, PreparedSqlLiteInsertCommand> insertCommandMap = this._insertCommandMap;
						lock (insertCommandMap)
						{
							foreach (PreparedSqlLiteInsertCommand preparedSqlLiteInsertCommand in this._insertCommandMap.Values)
							{
								preparedSqlLiteInsertCommand.Dispose();
							}
							this._insertCommandMap.Clear();
						}
						SQLite3.Result result = flag ? SQLite3.Close2(this.Handle) : SQLite3.Close(this.Handle);
						if (result != SQLite3.Result.OK)
						{
							string errmsg = SQLite3.GetErrmsg(this.Handle);
							throw SQLiteException.New(result, errmsg);
						}
					}
					else if (!flag)
					{
						SQLite3.Close(this.Handle);
					}
					else
					{
						SQLite3.Close2(this.Handle);
					}
				}
				finally
				{
					this.Handle = SQLiteConnection.NullHandle;
					this._open = false;
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003F4C File Offset: 0x0000214C
		private void OnTableChanged(TableMapping table, NotifyTableChangedAction action)
		{
			EventHandler<NotifyTableChangedEventArgs> tableChanged = this.TableChanged;
			if (tableChanged != null)
			{
				tableChanged(this, new NotifyTableChangedEventArgs(table, action));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000076 RID: 118 RVA: 0x00003F74 File Offset: 0x00002174
		// (remove) Token: 0x06000077 RID: 119 RVA: 0x00003FAC File Offset: 0x000021AC
		public event EventHandler<NotifyTableChangedEventArgs> TableChanged;

		// Token: 0x04000018 RID: 24
		private bool _open;

		// Token: 0x04000019 RID: 25
		private TimeSpan _busyTimeout;

		// Token: 0x0400001A RID: 26
		private static readonly Dictionary<string, TableMapping> _mappings = new Dictionary<string, TableMapping>();

		// Token: 0x0400001B RID: 27
		private Stopwatch _sw;

		// Token: 0x0400001C RID: 28
		private long _elapsedMilliseconds;

		// Token: 0x0400001D RID: 29
		private int _transactionDepth;

		// Token: 0x0400001E RID: 30
		private Random _rand = new Random();

		// Token: 0x04000020 RID: 32
		private static readonly sqlite3 NullHandle = null;

		// Token: 0x04000021 RID: 33
		private static readonly sqlite3_backup NullBackupHandle = null;

		// Token: 0x0400002B RID: 43
		private readonly Dictionary<Tuple<string, string>, PreparedSqlLiteInsertCommand> _insertCommandMap = new Dictionary<Tuple<string, string>, PreparedSqlLiteInsertCommand>();

		// Token: 0x02000008 RID: 8
		private struct IndexedColumn
		{
			// Token: 0x0400002D RID: 45
			public int Order;

			// Token: 0x0400002E RID: 46
			public string ColumnName;
		}

		// Token: 0x02000009 RID: 9
		private struct IndexInfo
		{
			// Token: 0x0400002F RID: 47
			public string IndexName;

			// Token: 0x04000030 RID: 48
			public string TableName;

			// Token: 0x04000031 RID: 49
			public bool Unique;

			// Token: 0x04000032 RID: 50
			public List<SQLiteConnection.IndexedColumn> Columns;
		}

		// Token: 0x0200000A RID: 10
		[Preserve(AllMembers = true)]
		public class ColumnInfo
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000079 RID: 121 RVA: 0x00003FF5 File Offset: 0x000021F5
			// (set) Token: 0x0600007A RID: 122 RVA: 0x00003FFD File Offset: 0x000021FD
			[Column("name")]
			public string Name { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600007B RID: 123 RVA: 0x00004006 File Offset: 0x00002206
			// (set) Token: 0x0600007C RID: 124 RVA: 0x0000400E File Offset: 0x0000220E
			public int notnull { get; set; }

			// Token: 0x0600007D RID: 125 RVA: 0x00004017 File Offset: 0x00002217
			public override string ToString()
			{
				return this.Name;
			}
		}
	}
}
