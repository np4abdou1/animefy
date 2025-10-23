using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000228 RID: 552
	internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task
	{
		// Token: 0x06001387 RID: 4999 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		public ContinuationTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) : base(action, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, internalOptions, null)
		{
			this.m_antecedent = antecedent;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0004DBE4 File Offset: 0x0004BDE4
		internal override void InnerInvoke()
		{
			Task<TAntecedentResult> antecedent = this.m_antecedent;
			this.m_antecedent = null;
			antecedent.NotifyDebuggerOfWaitCompletionIfNecessary();
			Action<Task<TAntecedentResult>> action = this.m_action as Action<Task<TAntecedentResult>>;
			if (action != null)
			{
				action(antecedent);
				return;
			}
			Action<Task<TAntecedentResult>, object> action2 = this.m_action as Action<Task<TAntecedentResult>, object>;
			if (action2 != null)
			{
				action2(antecedent, this.m_stateObject);
				return;
			}
		}

		// Token: 0x040007C5 RID: 1989
		private Task<TAntecedentResult> m_antecedent;
	}
}
