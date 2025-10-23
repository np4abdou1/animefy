using System;

namespace System.Collections
{
	/// <summary>Defines a dictionary key/value pair that can be set or retrieved.</summary>
	// Token: 0x020005D0 RID: 1488
	[Serializable]
	public struct DictionaryEntry
	{
		/// <summary>Initializes an instance of the <see cref="T:System.Collections.DictionaryEntry" /> type with the specified key and value.</summary>
		/// <param name="key">The object defined in each key/value pair. </param>
		/// <param name="value">The definition associated with <paramref name="key" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" /> and the .NET Framework version is 1.0 or 1.1. </exception>
		// Token: 0x06002C77 RID: 11383 RVA: 0x000B805A File Offset: 0x000B625A
		public DictionaryEntry(object key, object value)
		{
			this._key = key;
			this._value = value;
		}

		/// <summary>Gets or sets the key in the key/value pair.</summary>
		/// <returns>The key in the key/value pair.</returns>
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000B806A File Offset: 0x000B626A
		public object Key
		{
			get
			{
				return this._key;
			}
		}

		/// <summary>Gets or sets the value in the key/value pair.</summary>
		/// <returns>The value in the key/value pair.</returns>
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x000B8072 File Offset: 0x000B6272
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x04001864 RID: 6244
		private object _key;

		// Token: 0x04001865 RID: 6245
		private object _value;
	}
}
