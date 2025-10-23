using System;
using System.Threading;

namespace SQLite
{
	// Token: 0x02000084 RID: 132
	public class SQLiteConnectionWithLock : SQLiteConnection
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00009FA4 File Offset: 0x000081A4
		public SQLiteConnectionWithLock(SQLiteConnectionString connectionString) : base(connectionString)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00009FB8 File Offset: 0x000081B8
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00009FC0 File Offset: 0x000081C0
		public bool SkipLock { get; set; }

		// Token: 0x060002D4 RID: 724 RVA: 0x00009FCC File Offset: 0x000081CC
		public IDisposable Lock()
		{
			if (!this.SkipLock)
			{
				return new SQLiteConnectionWithLock.LockWrapper(this._lockPoint);
			}
			return new SQLiteConnectionWithLock.FakeLockWrapper();
		}

		// Token: 0x040001C2 RID: 450
		private readonly object _lockPoint = new object();

		// Token: 0x02000085 RID: 133
		private class LockWrapper : IDisposable
		{
			// Token: 0x060002D5 RID: 725 RVA: 0x00009FF6 File Offset: 0x000081F6
			public LockWrapper(object lockPoint)
			{
				this._lockPoint = lockPoint;
				Monitor.Enter(this._lockPoint);
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x0000A010 File Offset: 0x00008210
			public void Dispose()
			{
				Monitor.Exit(this._lockPoint);
			}

			// Token: 0x040001C4 RID: 452
			private object _lockPoint;
		}

		// Token: 0x02000086 RID: 134
		private class FakeLockWrapper : IDisposable
		{
			// Token: 0x060002D7 RID: 727 RVA: 0x0000402B File Offset: 0x0000222B
			public void Dispose()
			{
			}
		}
	}
}
