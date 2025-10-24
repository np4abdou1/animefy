using System;

namespace System
{
	/// <summary>Encapsulates a method that has one parameter and returns a value of the type specified by the <paramref name="TResult" /> parameter.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <param name="arg">The parameter of the method that this delegate encapsulates.</param>
	/// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates.</typeparam>
	/// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
	/// <returns>The return value of the method that this delegate encapsulates.</returns>
	// Token: 0x0200006B RID: 107
	// (Invoke) Token: 0x06000241 RID: 577
	public delegate TResult Func<in T, out TResult>(T arg);
}
