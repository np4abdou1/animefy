using System;

namespace System
{
	/// <summary>Encapsulates a method that has a single parameter and does not return a value.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <param name="obj">The parameter of the method that this delegate encapsulates.</param>
	/// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates.</typeparam>
	// Token: 0x02000062 RID: 98
	// (Invoke) Token: 0x0600021D RID: 541
	public delegate void Action<in T>(T obj);
}
