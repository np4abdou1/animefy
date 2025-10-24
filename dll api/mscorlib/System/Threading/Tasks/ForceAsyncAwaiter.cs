using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200020C RID: 524
	internal readonly struct ForceAsyncAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x06001299 RID: 4761 RVA: 0x0004AB3D File Offset: 0x00048D3D
		internal ForceAsyncAwaiter(Task task)
		{
			this._task = task;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0004AB46 File Offset: 0x00048D46
		public ForceAsyncAwaiter GetAwaiter()
		{
			return this;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsCompleted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0004AB50 File Offset: 0x00048D50
		public void GetResult()
		{
			this._task.GetAwaiter().GetResult();
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0004AB70 File Offset: 0x00048D70
		public void UnsafeOnCompleted(Action action)
		{
			this._task.ConfigureAwait(false).GetAwaiter().UnsafeOnCompleted(action);
		}

		// Token: 0x04000755 RID: 1877
		private readonly Task _task;
	}
}
