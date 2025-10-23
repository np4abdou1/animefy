using System;

namespace System.Collections.Generic
{
	/// <summary>Provides the base interface for the abstraction of sets.</summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	// Token: 0x020002D8 RID: 728
	public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
	}
}
