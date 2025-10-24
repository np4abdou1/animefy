using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Provides functionality to an object to return a list that can be bound to a data source.</summary>
	// Token: 0x0200026B RID: 619
	[MergableProperty(false)]
	public interface IListSource
	{
		/// <summary>Gets a value indicating whether the collection is a collection of <see cref="T:System.Collections.IList" /> objects.</summary>
		/// <returns>
		///     <see langword="true" /> if the collection is a collection of <see cref="T:System.Collections.IList" /> objects; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060010A4 RID: 4260
		bool ContainsListCollection { get; }

		/// <summary>Returns an <see cref="T:System.Collections.IList" /> that can be bound to a data source from an object that does not implement an <see cref="T:System.Collections.IList" /> itself.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> that can be bound to a data source from the object.</returns>
		// Token: 0x060010A5 RID: 4261
		IList GetList();
	}
}
