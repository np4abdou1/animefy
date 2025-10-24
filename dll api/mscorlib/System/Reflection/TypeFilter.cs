using System;

namespace System.Reflection
{
	/// <summary>Filters the classes represented in an array of <see cref="T:System.Type" /> objects.</summary>
	/// <param name="m">The <see langword="Type" /> object to which the filter is applied. </param>
	/// <param name="filterCriteria">An arbitrary object used to filter the list. </param>
	/// <returns>
	///     <see langword="true" /> to include the <see cref="T:System.Type" /> in the filtered list; otherwise <see langword="false" />.</returns>
	// Token: 0x020004C4 RID: 1220
	// (Invoke) Token: 0x06002284 RID: 8836
	public delegate bool TypeFilter(Type m, object filterCriteria);
}
