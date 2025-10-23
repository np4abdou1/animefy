using System;

namespace System.Collections.Generic
{
	/// <summary>Exposes the enumerator, which supports a simple iteration over a collection of a specified type.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <typeparam name="T">The type of objects to enumerate.</typeparam>
	// Token: 0x0200061B RID: 1563
	public interface IEnumerable<out T> : IEnumerable
	{
		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		// Token: 0x06002FAA RID: 12202
		IEnumerator<T> GetEnumerator();
	}
}
