using System;

namespace System.Collections
{
	/// <summary>Represents a nongeneric collection of key/value pairs.</summary>
	// Token: 0x020005D4 RID: 1492
	public interface IDictionary : ICollection, IEnumerable
	{
		/// <summary>Gets or sets the element with the specified key.</summary>
		/// <param name="key">The key of the element to get or set. </param>
		/// <returns>The element with the specified key, or <see langword="null" /> if the key does not exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.IDictionary" /> object is read-only.-or- The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.IDictionary" /> has a fixed size. </exception>
		// Token: 0x170006C8 RID: 1736
		object this[object key]
		{
			get;
			set;
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> object containing the keys of the <see cref="T:System.Collections.IDictionary" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the keys of the <see cref="T:System.Collections.IDictionary" /> object.</returns>
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002C86 RID: 11398
		ICollection Keys { get; }

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.IDictionary" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.IDictionary" /> object.</returns>
		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002C87 RID: 11399
		ICollection Values { get; }

		/// <summary>Determines whether the <see cref="T:System.Collections.IDictionary" /> object contains an element with the specified key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.IDictionary" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> contains an element with the key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x06002C88 RID: 11400
		bool Contains(object key);

		/// <summary>Adds an element with the provided key and value to the <see cref="T:System.Collections.IDictionary" /> object.</summary>
		/// <param name="key">The <see cref="T:System.Object" /> to use as the key of the element to add. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to use as the value of the element to add. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.IDictionary" /> object. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IDictionary" /> is read-only.-or- The <see cref="T:System.Collections.IDictionary" /> has a fixed size. </exception>
		// Token: 0x06002C89 RID: 11401
		void Add(object key, object value);

		/// <summary>Removes all elements from the <see cref="T:System.Collections.IDictionary" /> object.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IDictionary" /> object is read-only. </exception>
		// Token: 0x06002C8A RID: 11402
		void Clear();

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> object is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> object is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002C8B RID: 11403
		bool IsReadOnly { get; }

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> object has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> object has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002C8C RID: 11404
		bool IsFixedSize { get; }

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.IDictionary" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.IDictionary" /> object.</returns>
		// Token: 0x06002C8D RID: 11405
		IDictionaryEnumerator GetEnumerator();

		/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.IDictionary" /> object.</summary>
		/// <param name="key">The key of the element to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IDictionary" /> object is read-only.-or- The <see cref="T:System.Collections.IDictionary" /> has a fixed size. </exception>
		// Token: 0x06002C8E RID: 11406
		void Remove(object key);
	}
}
