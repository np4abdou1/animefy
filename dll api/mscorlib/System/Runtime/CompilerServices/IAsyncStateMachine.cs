using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Represents state machines that are generated for asynchronous methods. This type is intended for compiler use only.</summary>
	// Token: 0x02000447 RID: 1095
	public interface IAsyncStateMachine
	{
		/// <summary>Moves the state machine to its next state.</summary>
		// Token: 0x0600200D RID: 8205
		void MoveNext();

		/// <summary>Configures the state machine with a heap-allocated replica.</summary>
		/// <param name="stateMachine">The heap-allocated replica.</param>
		// Token: 0x0600200E RID: 8206
		void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
