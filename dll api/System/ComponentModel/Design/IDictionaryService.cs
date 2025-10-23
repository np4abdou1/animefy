using System;

namespace System.ComponentModel.Design
{
	/// <summary>Provides a basic, component site-specific, key-value pair dictionary through a service that a designer can use to store user-defined data.</summary>
	// Token: 0x020002B9 RID: 697
	public interface IDictionaryService
	{
		/// <summary>Gets the value corresponding to the specified key.</summary>
		/// <param name="key">The key to look up the value for. </param>
		/// <returns>The associated value, or <see langword="null" /> if no value exists.</returns>
		// Token: 0x0600129C RID: 4764
		object GetValue(object key);

		/// <summary>Sets the specified key-value pair.</summary>
		/// <param name="key">An object to use as the key to associate the value with. </param>
		/// <param name="value">The value to store. </param>
		// Token: 0x0600129D RID: 4765
		void SetValue(object key, object value);
	}
}
