using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Indicates whether a method in Visual Basic is marked with the <see langword="Iterator" /> modifier.</summary>
	// Token: 0x0200044E RID: 1102
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class IteratorStateMachineAttribute : StateMachineAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.IteratorStateMachineAttribute" /> class.</summary>
		/// <param name="stateMachineType">The type object for the underlying state machine type that's used to implement a state machine method.</param>
		// Token: 0x06002014 RID: 8212 RVA: 0x00087C47 File Offset: 0x00085E47
		public IteratorStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
		{
		}
	}
}
