using System;
using System.Collections.Concurrent;

namespace SQLitePCL
{
	// Token: 0x02000031 RID: 49
	public class hook_handles : IDisposable
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x00003514 File Offset: 0x00001714
		public hook_handles(Func<IntPtr, IntPtr, int, bool> f)
		{
			CompareBuf compareBuf = new CompareBuf(f);
			this.collation = new ConcurrentDictionary<byte[], IDisposable>(compareBuf);
			this.scalar = new ConcurrentDictionary<FuncName, IDisposable>(new CompareFuncName(compareBuf));
			this.agg = new ConcurrentDictionary<FuncName, IDisposable>(new CompareFuncName(compareBuf));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000355C File Offset: 0x0000175C
		public bool RemoveScalarFunction(byte[] name, int nargs)
		{
			FuncName key = new FuncName(name, nargs);
			IDisposable disposable;
			if (this.scalar.TryRemove(key, out disposable))
			{
				disposable.Dispose();
				return true;
			}
			return false;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000358C File Offset: 0x0000178C
		public void AddScalarFunction(byte[] name, int nargs, IDisposable d)
		{
			FuncName key = new FuncName(name, nargs);
			this.scalar[key] = d;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000035B0 File Offset: 0x000017B0
		public bool RemoveAggFunction(byte[] name, int nargs)
		{
			FuncName key = new FuncName(name, nargs);
			IDisposable disposable;
			if (this.agg.TryRemove(key, out disposable))
			{
				disposable.Dispose();
				return true;
			}
			return false;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000035E0 File Offset: 0x000017E0
		public void AddAggFunction(byte[] name, int nargs, IDisposable d)
		{
			FuncName key = new FuncName(name, nargs);
			this.agg[key] = d;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00003604 File Offset: 0x00001804
		public bool RemoveCollation(byte[] name)
		{
			IDisposable disposable;
			if (this.collation.TryRemove(name, out disposable))
			{
				disposable.Dispose();
				return true;
			}
			return false;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000362A File Offset: 0x0000182A
		public void AddCollation(byte[] name, IDisposable d)
		{
			this.collation[name] = d;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000363C File Offset: 0x0000183C
		public void Dispose()
		{
			foreach (IDisposable disposable in this.collation.Values)
			{
				disposable.Dispose();
			}
			foreach (IDisposable disposable2 in this.scalar.Values)
			{
				disposable2.Dispose();
			}
			foreach (IDisposable disposable3 in this.agg.Values)
			{
				disposable3.Dispose();
			}
			if (this.update != null)
			{
				this.update.Dispose();
			}
			if (this.rollback != null)
			{
				this.rollback.Dispose();
			}
			if (this.commit != null)
			{
				this.commit.Dispose();
			}
			if (this.trace != null)
			{
				this.trace.Dispose();
			}
			if (this.profile != null)
			{
				this.profile.Dispose();
			}
			if (this.progress != null)
			{
				this.progress.Dispose();
			}
			if (this.authorizer != null)
			{
				this.authorizer.Dispose();
			}
		}

		// Token: 0x040000E9 RID: 233
		private readonly ConcurrentDictionary<byte[], IDisposable> collation;

		// Token: 0x040000EA RID: 234
		private readonly ConcurrentDictionary<FuncName, IDisposable> scalar;

		// Token: 0x040000EB RID: 235
		private readonly ConcurrentDictionary<FuncName, IDisposable> agg;

		// Token: 0x040000EC RID: 236
		public IDisposable update;

		// Token: 0x040000ED RID: 237
		public IDisposable rollback;

		// Token: 0x040000EE RID: 238
		public IDisposable commit;

		// Token: 0x040000EF RID: 239
		public IDisposable trace;

		// Token: 0x040000F0 RID: 240
		public IDisposable profile;

		// Token: 0x040000F1 RID: 241
		public IDisposable progress;

		// Token: 0x040000F2 RID: 242
		public IDisposable authorizer;
	}
}
