using System;

namespace System.Collections
{
	/// <summary>Supports a simple iteration over a non-generic collection.</summary>
	// Token: 0x020005D7 RID: 1495
	public interface IEnumerator
	{
		/// <summary>Advances the enumerator to the next element of the collection.</summary>
		/// <returns>
		///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06002C93 RID: 11411
		bool MoveNext();

		/// <summary>Gets the element in the collection at the current position of the enumerator.</summary>
		/// <returns>The element in the collection at the current position of the enumerator.</returns>
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002C94 RID: 11412
		object Current { get; }

		/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06002C95 RID: 11413
		void Reset();
	}
}
