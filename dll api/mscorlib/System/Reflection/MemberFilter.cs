﻿using System;

namespace System.Reflection
{
	/// <summary>Represents a delegate that is used to filter a list of members represented in an array of <see cref="T:System.Reflection.MemberInfo" /> objects.</summary>
	/// <param name="m">The <see cref="T:System.Reflection.MemberInfo" /> object to which the filter is applied. </param>
	/// <param name="filterCriteria">An arbitrary object used to filter the list. </param>
	/// <returns>
	///     <see langword="true" /> to include the member in the filtered list; otherwise <see langword="false" />.</returns>
	// Token: 0x020004A5 RID: 1189
	// (Invoke) Token: 0x06002127 RID: 8487
	public delegate bool MemberFilter(MemberInfo m, object filterCriteria);
}
