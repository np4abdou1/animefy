using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Linq.Expressions
{
	// Token: 0x020000C6 RID: 198
	internal sealed class StackGuard
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x00013A4E File Offset: 0x00011C4E
		public bool TryEnterOnCurrentStack()
		{
			if (RuntimeHelpers.TryEnsureSufficientExecutionStack())
			{
				return true;
			}
			if (this._executionStackCount < 1024)
			{
				return false;
			}
			throw new InsufficientExecutionStackException();
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00013A6D File Offset: 0x00011C6D
		public void RunOnEmptyStack<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
		{
			this.RunOnEmptyStackCore<object>(delegate(object s)
			{
				Tuple<Action<T1, T2, T3>, T1, T2, T3> tuple = (Tuple<Action<T1, T2, T3>, T1, T2, T3>)s;
				tuple.Item1(tuple.Item2, tuple.Item3, tuple.Item4);
				return null;
			}, Tuple.Create<Action<T1, T2, T3>, T1, T2, T3>(action, arg1, arg2, arg3));
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00013A9F File Offset: 0x00011C9F
		public R RunOnEmptyStack<T1, T2, R>(Func<T1, T2, R> action, T1 arg1, T2 arg2)
		{
			return this.RunOnEmptyStackCore<R>(delegate(object s)
			{
				Tuple<Func<T1, T2, R>, T1, T2> tuple = (Tuple<Func<T1, T2, R>, T1, T2>)s;
				return tuple.Item1(tuple.Item2, tuple.Item3);
			}, Tuple.Create<Func<T1, T2, R>, T1, T2>(action, arg1, arg2));
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00013ACE File Offset: 0x00011CCE
		public R RunOnEmptyStack<T1, T2, T3, R>(Func<T1, T2, T3, R> action, T1 arg1, T2 arg2, T3 arg3)
		{
			return this.RunOnEmptyStackCore<R>(delegate(object s)
			{
				Tuple<Func<T1, T2, T3, R>, T1, T2, T3> tuple = (Tuple<Func<T1, T2, T3, R>, T1, T2, T3>)s;
				return tuple.Item1(tuple.Item2, tuple.Item3, tuple.Item4);
			}, Tuple.Create<Func<T1, T2, T3, R>, T1, T2, T3>(action, arg1, arg2, arg3));
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00013B00 File Offset: 0x00011D00
		private R RunOnEmptyStackCore<R>(Func<object, R> action, object state)
		{
			this._executionStackCount++;
			R result;
			try
			{
				Task<R> task = Task.Factory.StartNew<R>(action, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
				TaskAwaiter<R> awaiter = task.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					((IAsyncResult)task).AsyncWaitHandle.WaitOne();
				}
				result = awaiter.GetResult();
			}
			finally
			{
				this._executionStackCount--;
			}
			return result;
		}

		// Token: 0x040001B2 RID: 434
		private int _executionStackCount;
	}
}
