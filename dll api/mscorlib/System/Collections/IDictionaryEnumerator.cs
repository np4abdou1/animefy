using System;

namespace System.Collections
{
	/// <summary>Enumerates the elements of a nongeneric dictionary.</summary>
	// Token: 0x020005D5 RID: 1493
	public interface IDictionaryEnumerator : IEnumerator
	{
		/// <summary>Gets the key of the current dictionary entry.</summary>
		/// <returns>The key of the current element of the enumeration.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.IDictionaryEnumerator" /> is positioned before the first entry of the dictionary or after the last entry. </exception>
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002C8F RID: 11407
		object Key { get; }

		/// <summary>Gets the value of the current dictionary entry.</summary>
		/// <returns>The value of the current element of the enumeration.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.IDictionaryEnumerator" /> is positioned before the first entry of the dictionary or after the last entry. </exception>
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002C90 RID: 11408
		object Value { get; }

		/// <summary>Gets both the key and the value of the current dictionary entry.</summary>
		/// <returns>A <see cref="T:System.Collections.DictionaryEntry" /> containing both the key and the value of the current dictionary entry.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.IDictionaryEnumerator" /> is positioned before the first entry of the dictionary or after the last entry. </exception>
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002C91 RID: 11409
		DictionaryEntry Entry { get; }
	}
}
