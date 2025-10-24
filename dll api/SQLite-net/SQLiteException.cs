using System;

namespace SQLite
{
	// Token: 0x02000002 RID: 2
	public class SQLiteException : Exception
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public SQLite3.Result Result { get; private set; }

		// Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		protected SQLiteException(SQLite3.Result r, string message) : base(message)
		{
			this.Result = r;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002071 File Offset: 0x00000271
		public static SQLiteException New(SQLite3.Result r, string message)
		{
			return new SQLiteException(r, message);
		}
	}
}
