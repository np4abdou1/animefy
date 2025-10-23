﻿using System;

namespace System.Collections.Generic
{
	/// <summary>Defines a key/value pair that can be set or retrieved.</summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	/// <typeparam name="TValue">The type of the value.</typeparam>
	// Token: 0x02000624 RID: 1572
	[Serializable]
	public readonly struct KeyValuePair<TKey, TValue>
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.KeyValuePair`2" /> structure with the specified key and value.</summary>
		/// <param name="key">The object defined in each key/value pair.</param>
		/// <param name="value">The definition associated with <paramref name="key" />.</param>
		// Token: 0x06002FBD RID: 12221 RVA: 0x000C14C3 File Offset: 0x000BF6C3
		public KeyValuePair(TKey key, TValue value)
		{
			this.key = key;
			this.value = value;
		}

		/// <summary>Gets the key in the key/value pair.</summary>
		/// <returns>A <paramref name="TKey" /> that is the key of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />. </returns>
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x000C14D3 File Offset: 0x000BF6D3
		public TKey Key
		{
			get
			{
				return this.key;
			}
		}

		/// <summary>Gets the value in the key/value pair.</summary>
		/// <returns>A <paramref name="TValue" /> that is the value of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />. </returns>
		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x000C14DB File Offset: 0x000BF6DB
		public TValue Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Returns a string representation of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />, using the string representations of the key and value.</summary>
		/// <returns>A string representation of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />, which includes the string representations of the key and value.</returns>
		// Token: 0x06002FC0 RID: 12224 RVA: 0x000C14E3 File Offset: 0x000BF6E3
		public override string ToString()
		{
			return KeyValuePair.PairToString(this.Key, this.Value);
		}

		// Token: 0x0400190E RID: 6414
		private readonly TKey key;

		// Token: 0x0400190F RID: 6415
		private readonly TValue value;
	}
}
