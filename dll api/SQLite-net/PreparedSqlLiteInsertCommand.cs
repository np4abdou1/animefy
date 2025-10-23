using System;
using SQLitePCL;

namespace SQLite
{
	// Token: 0x02000037 RID: 55
	internal class PreparedSqlLiteInsertCommand : IDisposable
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00006F86 File Offset: 0x00005186
		public PreparedSqlLiteInsertCommand(SQLiteConnection conn, string commandText)
		{
			this.Connection = conn;
			this.CommandText = commandText;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006F9C File Offset: 0x0000519C
		public int ExecuteNonQuery(object[] source)
		{
			if (this.Initialized && this.Statement == PreparedSqlLiteInsertCommand.NullStatement)
			{
				throw new ObjectDisposedException("PreparedSqlLiteInsertCommand");
			}
			if (this.Connection.Trace)
			{
				Action<string> tracer = this.Connection.Tracer;
				if (tracer != null)
				{
					tracer("Executing: " + this.CommandText);
				}
			}
			if (!this.Initialized)
			{
				this.Statement = SQLite3.Prepare2(this.Connection.Handle, this.CommandText);
				this.Initialized = true;
			}
			if (source != null)
			{
				for (int i = 0; i < source.Length; i++)
				{
					SQLiteCommand.BindParameter(this.Statement, i + 1, source[i], this.Connection.StoreDateTimeAsTicks, this.Connection.DateTimeStringFormat, this.Connection.StoreTimeSpanAsTicks);
				}
			}
			SQLite3.Result result = SQLite3.Step(this.Statement);
			if (result == SQLite3.Result.Done)
			{
				int result2 = SQLite3.Changes(this.Connection.Handle);
				SQLite3.Reset(this.Statement);
				return result2;
			}
			if (result == SQLite3.Result.Error)
			{
				string errmsg = SQLite3.GetErrmsg(this.Connection.Handle);
				SQLite3.Reset(this.Statement);
				throw SQLiteException.New(result, errmsg);
			}
			if (result == SQLite3.Result.Constraint && SQLite3.ExtendedErrCode(this.Connection.Handle) == SQLite3.ExtendedResult.ConstraintNotNull)
			{
				SQLite3.Reset(this.Statement);
				throw NotNullConstraintViolationException.New(result, SQLite3.GetErrmsg(this.Connection.Handle));
			}
			SQLite3.Reset(this.Statement);
			throw SQLiteException.New(result, SQLite3.GetErrmsg(this.Connection.Handle));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007124 File Offset: 0x00005324
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007134 File Offset: 0x00005334
		private void Dispose(bool disposing)
		{
			sqlite3_stmt statement = this.Statement;
			this.Statement = PreparedSqlLiteInsertCommand.NullStatement;
			this.Connection = null;
			if (statement != PreparedSqlLiteInsertCommand.NullStatement)
			{
				SQLite3.Finalize(statement);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000716C File Offset: 0x0000536C
		~PreparedSqlLiteInsertCommand()
		{
			this.Dispose(false);
		}

		// Token: 0x040000D1 RID: 209
		private bool Initialized;

		// Token: 0x040000D2 RID: 210
		private SQLiteConnection Connection;

		// Token: 0x040000D3 RID: 211
		private string CommandText;

		// Token: 0x040000D4 RID: 212
		private sqlite3_stmt Statement;

		// Token: 0x040000D5 RID: 213
		private static readonly sqlite3_stmt NullStatement;
	}
}
