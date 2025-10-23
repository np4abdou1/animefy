using System;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Provides concurrency management for classes that support asynchronous method calls. This class cannot be inherited.</summary>
	// Token: 0x02000234 RID: 564
	public static class AsyncOperationManager
	{
		/// <summary>Returns an <see cref="T:System.ComponentModel.AsyncOperation" /> for tracking the duration of a particular asynchronous operation.</summary>
		/// <param name="userSuppliedState">An object used to associate a piece of client state, such as a task ID, with a particular asynchronous operation. </param>
		/// <returns>An <see cref="T:System.ComponentModel.AsyncOperation" /> that you can use to track the duration of an asynchronous method invocation.</returns>
		// Token: 0x06000F72 RID: 3954 RVA: 0x0004D12B File Offset: 0x0004B32B
		public static AsyncOperation CreateOperation(object userSuppliedState)
		{
			return AsyncOperation.CreateOperation(userSuppliedState, AsyncOperationManager.SynchronizationContext);
		}

		/// <summary>Gets or sets the synchronization context for the asynchronous operation.</summary>
		/// <returns>The synchronization context for the asynchronous operation.</returns>
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0004D138 File Offset: 0x0004B338
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static SynchronizationContext SynchronizationContext
		{
			get
			{
				if (SynchronizationContext.Current == null)
				{
					SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
				}
				return SynchronizationContext.Current;
			}
		}
	}
}
