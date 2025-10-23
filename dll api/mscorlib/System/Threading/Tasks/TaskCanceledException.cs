using System;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
	/// <summary>Represents an exception used to communicate task cancellation.</summary>
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class TaskCanceledException : OperationCanceledException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskCanceledException" /> class with a system-supplied message that describes the error.</summary>
		// Token: 0x06001251 RID: 4689 RVA: 0x0004A0E6 File Offset: 0x000482E6
		public TaskCanceledException() : base("A task was canceled.")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskCanceledException" /> class with a reference to the <see cref="T:System.Threading.Tasks.Task" /> that has been canceled.</summary>
		/// <param name="task">A task that has been canceled.</param>
		// Token: 0x06001252 RID: 4690 RVA: 0x0004A0F4 File Offset: 0x000482F4
		public TaskCanceledException(Task task) : base("A task was canceled.", (task != null) ? task.CancellationToken : default(CancellationToken))
		{
			this._canceledTask = task;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskCanceledException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06001253 RID: 4691 RVA: 0x0004A127 File Offset: 0x00048327
		protected TaskCanceledException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0400073B RID: 1851
		[NonSerialized]
		private readonly Task _canceledTask;
	}
}
