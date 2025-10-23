using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace SQLite
{
	// Token: 0x0200007A RID: 122
	public class AsyncTableQuery<T> where T : new()
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00009937 File Offset: 0x00007B37
		public AsyncTableQuery(TableQuery<T> innerQuery)
		{
			this._innerQuery = innerQuery;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00009948 File Offset: 0x00007B48
		private Task<U> ReadAsync<U>(Func<SQLiteConnectionWithLock, U> read)
		{
			return Task.Factory.StartNew<U>(delegate()
			{
				SQLiteConnectionWithLock sqliteConnectionWithLock = (SQLiteConnectionWithLock)this._innerQuery.Connection;
				U result;
				using (sqliteConnectionWithLock.Lock())
				{
					result = read(sqliteConnectionWithLock);
				}
				return result;
			}, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000998C File Offset: 0x00007B8C
		private Task<U> WriteAsync<U>(Func<SQLiteConnectionWithLock, U> write)
		{
			return Task.Factory.StartNew<U>(delegate()
			{
				SQLiteConnectionWithLock sqliteConnectionWithLock = (SQLiteConnectionWithLock)this._innerQuery.Connection;
				U result;
				using (sqliteConnectionWithLock.Lock())
				{
					result = write(sqliteConnectionWithLock);
				}
				return result;
			}, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000099CE File Offset: 0x00007BCE
		public AsyncTableQuery<T> Where(Expression<Func<T, bool>> predExpr)
		{
			return new AsyncTableQuery<T>(this._innerQuery.Where(predExpr));
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000099E1 File Offset: 0x00007BE1
		public AsyncTableQuery<T> Skip(int n)
		{
			return new AsyncTableQuery<T>(this._innerQuery.Skip(n));
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000099F4 File Offset: 0x00007BF4
		public AsyncTableQuery<T> Take(int n)
		{
			return new AsyncTableQuery<T>(this._innerQuery.Take(n));
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00009A07 File Offset: 0x00007C07
		public AsyncTableQuery<T> OrderBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return new AsyncTableQuery<T>(this._innerQuery.OrderBy<U>(orderExpr));
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00009A1A File Offset: 0x00007C1A
		public AsyncTableQuery<T> OrderByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return new AsyncTableQuery<T>(this._innerQuery.OrderByDescending<U>(orderExpr));
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00009A2D File Offset: 0x00007C2D
		public AsyncTableQuery<T> ThenBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return new AsyncTableQuery<T>(this._innerQuery.ThenBy<U>(orderExpr));
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00009A40 File Offset: 0x00007C40
		public AsyncTableQuery<T> ThenByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return new AsyncTableQuery<T>(this._innerQuery.ThenByDescending<U>(orderExpr));
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00009A53 File Offset: 0x00007C53
		public Task<List<T>> ToListAsync()
		{
			return this.ReadAsync<List<T>>((SQLiteConnectionWithLock conn) => this._innerQuery.ToList());
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009A67 File Offset: 0x00007C67
		public Task<T[]> ToArrayAsync()
		{
			return this.ReadAsync<T[]>((SQLiteConnectionWithLock conn) => this._innerQuery.ToArray());
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009A7B File Offset: 0x00007C7B
		public Task<int> CountAsync()
		{
			return this.ReadAsync<int>((SQLiteConnectionWithLock conn) => this._innerQuery.Count());
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009A90 File Offset: 0x00007C90
		public Task<int> CountAsync(Expression<Func<T, bool>> predExpr)
		{
			return this.ReadAsync<int>((SQLiteConnectionWithLock conn) => this._innerQuery.Count(predExpr));
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00009AC4 File Offset: 0x00007CC4
		public Task<T> ElementAtAsync(int index)
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => this._innerQuery.ElementAt(index));
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00009AF7 File Offset: 0x00007CF7
		public Task<T> FirstAsync()
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => this._innerQuery.First());
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00009B0B File Offset: 0x00007D0B
		public Task<T> FirstOrDefaultAsync()
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => this._innerQuery.FirstOrDefault());
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00009B20 File Offset: 0x00007D20
		public Task<T> FirstAsync(Expression<Func<T, bool>> predExpr)
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => this._innerQuery.First(predExpr));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00009B54 File Offset: 0x00007D54
		public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predExpr)
		{
			return this.ReadAsync<T>((SQLiteConnectionWithLock conn) => this._innerQuery.FirstOrDefault(predExpr));
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00009B88 File Offset: 0x00007D88
		public Task<int> DeleteAsync(Expression<Func<T, bool>> predExpr)
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => this._innerQuery.Delete(predExpr));
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00009BBB File Offset: 0x00007DBB
		public Task<int> DeleteAsync()
		{
			return this.WriteAsync<int>((SQLiteConnectionWithLock conn) => this._innerQuery.Delete());
		}

		// Token: 0x040001AD RID: 429
		private TableQuery<T> _innerQuery;
	}
}
