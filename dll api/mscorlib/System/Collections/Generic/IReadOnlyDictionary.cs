using System;

namespace System.Collections.Generic
{
	/// <summary>Represents a generic read-only collection of key/value pairs.</summary>
	/// <typeparam name="TKey">The type of keys in the read-only dictionary. </typeparam>
	/// <typeparam name="TValue">The type of values in the read-only dictionary. </typeparam>
	// Token: 0x02000620 RID: 1568
	public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable
	{
		/// <summary>Determines whether the read-only dictionary contains an element that has the specified key.</summary>
		/// <param name="key">The key to locate.</param>
		/// <returns>
		///     <see langword="true" /> if the read-only dictionary contains an element that has the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002FB4 RID: 12212
		bool ContainsKey(TKey key);

		/// <summary>Gets the element that has the specified key in the read-only dictionary.</summary>
		/// <param name="key">The key to locate.</param>
		/// <returns>The element that has the specified key in the read-only dictionary.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key" /> is not found. </exception>
		// Token: 0x170007B7 RID: 1975
		TValue this[TKey key]
		{
			get;
		}

		/// <summary>Gets an enumerable collection that contains the keys in the read-only dictionary. </summary>
		/// <returns>An enumerable collection that contains the keys in the read-only dictionary.</returns>
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002FB6 RID: 12214
		IEnumerable<TKey> Keys { get; }

		/// <summary>Gets an enumerable collection that contains the values in the read-only dictionary.</summary>
		/// <returns>An enumerable collection that contains the values in the read-only dictionary.</returns>
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002FB7 RID: 12215
		IEnumerable<TValue> Values { get; }
	}
}
