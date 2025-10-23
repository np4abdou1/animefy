using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000229 RID: 553
	internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult>
	{
		// Token: 0x06001389 RID: 5001 RVA: 0x0004DC3C File Offset: 0x0004BE3C
		public ContinuationResultTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) : base(function, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, internalOptions, null)
		{
			this.m_antecedent = antecedent;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0004DC70 File Offset: 0x0004BE70
		internal override void InnerInvoke()
		{
			Task<TAntecedentResult> antecedent = this.m_antecedent;
			this.m_antecedent = null;
			antecedent.NotifyDebuggerOfWaitCompletionIfNecessary();
			Func<Task<TAntecedentResult>, TResult> func = this.m_action as Func<Task<TAntecedentResult>, TResult>;
			if (func != null)
			{
				this.m_result = func(antecedent);
				return;
			}
			Func<Task<TAntecedentResult>, object, TResult> func2 = this.m_action as Func<Task<TAntecedentResult>, object, TResult>;
			if (func2 != null)
			{
				this.m_result = func2(antecedent, this.m_stateObject);
				return;
			}
		}

		// Token: 0x040007C6 RID: 1990
		private Task<TAntecedentResult> m_antecedent;
	}
}
