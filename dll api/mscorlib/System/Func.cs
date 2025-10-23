using System;

namespace System
{
	/// <summary>Encapsulates a method that has no parameters and returns a value of the type specified by the <paramref name="TResult" /> parameter.</summary>
	/// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
	/// <returns>The return value of the method that this delegate encapsulates.</returns>
	// Token: 0x0200006A RID: 106
	// (Invoke) Token: 0x0600023D RID: 573
	public delegate TResult Func<out TResult>();
}
