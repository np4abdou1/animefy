using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Represents an awaiter that schedules continuations when an await operation completes.</summary>
	// Token: 0x02000448 RID: 1096
	public interface ICriticalNotifyCompletion
	{
		/// <summary>Schedules the continuation action that's invoked when the instance completes.</summary>
		/// <param name="continuation">The action to invoke when the operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuation" /> argument is null (Nothing in Visual Basic).</exception>
		// Token: 0x0600200F RID: 8207
		void UnsafeOnCompleted(Action continuation);
	}
}
