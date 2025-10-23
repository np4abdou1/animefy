using System;
using System.Collections.Generic;

namespace SQLite
{
	// Token: 0x02000082 RID: 130
	internal class SQLiteConnectionPool
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00009D40 File Offset: 0x00007F40
		public static SQLiteConnectionPool Shared
		{
			get
			{
				return SQLiteConnectionPool._shared;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009D48 File Offset: 0x00007F48
		public SQLiteConnectionWithLock GetConnection(SQLiteConnectionString connectionString)
		{
			object obj;
			return this.GetConnectionAndTransactionLock(connectionString, out obj);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009D60 File Offset: 0x00007F60
		public SQLiteConnectionWithLock GetConnectionAndTransactionLock(SQLiteConnectionString connectionString, out object transactionLock)
		{
			string uniqueKey = connectionString.UniqueKey;
			object entriesLock = this._entriesLock;
			SQLiteConnectionWithLock connection;
			lock (entriesLock)
			{
				SQLiteConnectionPool.Entry entry;
				if (!this._entries.TryGetValue(uniqueKey, out entry))
				{
					entry = new SQLiteConnectionPool.Entry(connectionString);
					this._entries[uniqueKey] = entry;
				}
				transactionLock = entry.TransactionLock;
				connection = entry.Connection;
			}
			return connection;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009DD8 File Offset: 0x00007FD8
		public void CloseConnection(SQLiteConnectionString connectionString)
		{
			string uniqueKey = connectionString.UniqueKey;
			object entriesLock = this._entriesLock;
			SQLiteConnectionPool.Entry entry;
			lock (entriesLock)
			{
				if (this._entries.TryGetValue(uniqueKey, out entry))
				{
					this._entries.Remove(uniqueKey);
				}
			}
			if (entry != null)
			{
				entry.Close();
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009E40 File Offset: 0x00008040
		public void Reset()
		{
			object entriesLock = this._entriesLock;
			List<SQLiteConnectionPool.Entry> list;
			lock (entriesLock)
			{
				list = new List<SQLiteConnectionPool.Entry>(this._entries.Values);
				this._entries.Clear();
			}
			foreach (SQLiteConnectionPool.Entry entry in list)
			{
				entry.Close();
			}
		}

		// Token: 0x040001BC RID: 444
		private readonly Dictionary<string, SQLiteConnectionPool.Entry> _entries = new Dictionary<string, SQLiteConnectionPool.Entry>();

		// Token: 0x040001BD RID: 445
		private readonly object _entriesLock = new object();

		// Token: 0x040001BE RID: 446
		private static readonly SQLiteConnectionPool _shared = new SQLiteConnectionPool();

		// Token: 0x02000083 RID: 131
		private class Entry
		{
			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060002CB RID: 715 RVA: 0x00009EFA File Offset: 0x000080FA
			// (set) Token: 0x060002CC RID: 716 RVA: 0x00009F02 File Offset: 0x00008102
			public SQLiteConnectionWithLock Connection { get; private set; }

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060002CD RID: 717 RVA: 0x00009F0B File Offset: 0x0000810B
			public SQLiteConnectionString ConnectionString { get; }

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060002CE RID: 718 RVA: 0x00009F13 File Offset: 0x00008113
			public object TransactionLock { get; } = new object();

			// Token: 0x060002CF RID: 719 RVA: 0x00009F1C File Offset: 0x0000811C
			public Entry(SQLiteConnectionString connectionString)
			{
				this.ConnectionString = connectionString;
				this.Connection = new SQLiteConnectionWithLock(this.ConnectionString);
				if (this.ConnectionString.OpenFlags.HasFlag(SQLiteOpenFlags.FullMutex))
				{
					this.Connection.SkipLock = true;
				}
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x00009F80 File Offset: 0x00008180
			public void Close()
			{
				SQLiteConnectionWithLock connection = this.Connection;
				this.Connection = null;
				if (connection != null)
				{
					connection.Close();
				}
			}
		}
	}
}
