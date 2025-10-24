using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200021D RID: 541
	internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
	{
		// Token: 0x06001372 RID: 4978 RVA: 0x0004D801 File Offset: 0x0004BA01
		internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
		{
			this.m_action = action;
			this.m_completingTask = completingTask;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0004D817 File Offset: 0x0004BA17
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			this.m_action.Invoke(this.m_completingTask);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x0400079D RID: 1949
		private readonly ITaskCompletionAction m_action;

		// Token: 0x0400079E RID: 1950
		private readonly Task m_completingTask;
	}
}
