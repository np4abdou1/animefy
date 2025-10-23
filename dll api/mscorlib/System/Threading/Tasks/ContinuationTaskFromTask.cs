using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000227 RID: 551
	internal sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x0004DB24 File Offset: 0x0004BD24
		public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) : base(action, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, internalOptions, null)
		{
			this.m_antecedent = antecedent;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0004DB58 File Offset: 0x0004BD58
		internal override void InnerInvoke()
		{
			Task antecedent = this.m_antecedent;
			this.m_antecedent = null;
			antecedent.NotifyDebuggerOfWaitCompletionIfNecessary();
			Action<Task> action = this.m_action as Action<Task>;
			if (action != null)
			{
				action(antecedent);
				return;
			}
			Action<Task, object> action2 = this.m_action as Action<Task, object>;
			if (action2 != null)
			{
				action2(antecedent, this.m_stateObject);
				return;
			}
		}

		// Token: 0x040007C4 RID: 1988
		private Task m_antecedent;
	}
}
