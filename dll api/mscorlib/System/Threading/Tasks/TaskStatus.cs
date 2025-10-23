using System;

namespace System.Threading.Tasks
{
	/// <summary>Represents the current stage in the lifecycle of a <see cref="T:System.Threading.Tasks.Task" />.</summary>
	// Token: 0x02000217 RID: 535
	public enum TaskStatus
	{
		/// <summary>The task has been initialized but has not yet been scheduled.</summary>
		// Token: 0x04000771 RID: 1905
		Created,
		/// <summary>The task is waiting to be activated and scheduled internally by the .NET Framework infrastructure.</summary>
		// Token: 0x04000772 RID: 1906
		WaitingForActivation,
		/// <summary>The task has been scheduled for execution but has not yet begun executing.</summary>
		// Token: 0x04000773 RID: 1907
		WaitingToRun,
		/// <summary>The task is running but has not yet completed.</summary>
		// Token: 0x04000774 RID: 1908
		Running,
		/// <summary>The task has finished executing and is implicitly waiting for attached child tasks to complete.</summary>
		// Token: 0x04000775 RID: 1909
		WaitingForChildrenToComplete,
		/// <summary>The task completed execution successfully.</summary>
		// Token: 0x04000776 RID: 1910
		RanToCompletion,
		/// <summary>The task acknowledged cancellation by throwing an OperationCanceledException with its own CancellationToken while the token was in signaled state, or the task's CancellationToken was already signaled before the task started executing. For more information, see Task Cancellation.</summary>
		// Token: 0x04000777 RID: 1911
		Canceled,
		/// <summary>The task completed due to an unhandled exception.</summary>
		// Token: 0x04000778 RID: 1912
		Faulted
	}
}
