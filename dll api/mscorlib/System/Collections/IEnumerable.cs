using System;

namespace System.Collections
{
	/// <summary>Exposes an enumerator, which supports a simple iteration over a non-generic collection.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020005D6 RID: 1494
	public interface IEnumerable
	{
		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		// Token: 0x06002C92 RID: 11410
		IEnumerator GetEnumerator();
	}
}
