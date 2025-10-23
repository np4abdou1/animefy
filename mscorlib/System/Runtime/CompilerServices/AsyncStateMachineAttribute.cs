using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Indicates whether a method is marked with either the Async (Visual Basic) or async (C# Reference) modifier.</summary>
	// Token: 0x02000437 RID: 1079
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class AsyncStateMachineAttribute : StateMachineAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.AsyncStateMachineAttribute" /> class.</summary>
		/// <param name="stateMachineType">The type object for the underlying state machine type that's used to implement a state machine method.</param>
		// Token: 0x06001FE9 RID: 8169 RVA: 0x00087C47 File Offset: 0x00085E47
		public AsyncStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
		{
		}
	}
}
