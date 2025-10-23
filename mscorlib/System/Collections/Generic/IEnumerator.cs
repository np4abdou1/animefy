using System;

namespace System.Collections.Generic
{
	/// <summary>Supports a simple iteration over a generic collection.</summary>
	/// <typeparam name="T">The type of objects to enumerate.</typeparam>
	// Token: 0x0200061C RID: 1564
	public interface IEnumerator<out T> : IDisposable, IEnumerator
	{
		/// <summary>Gets the element in the collection at the current position of the enumerator.</summary>
		/// <returns>The element in the collection at the current position of the enumerator.</returns>
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06002FAB RID: 12203
		T Current { get; }
	}
}
