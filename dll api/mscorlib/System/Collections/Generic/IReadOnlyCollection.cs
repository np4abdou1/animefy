using System;

namespace System.Collections.Generic
{
	/// <summary>Represents a strongly-typed, read-only collection of elements.</summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	// Token: 0x0200061F RID: 1567
	public interface IReadOnlyCollection<out T> : IEnumerable<!0>, IEnumerable
	{
		/// <summary>Gets the number of elements in the collection.</summary>
		/// <returns>The number of elements in the collection. </returns>
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002FB3 RID: 12211
		int Count { get; }
	}
}
