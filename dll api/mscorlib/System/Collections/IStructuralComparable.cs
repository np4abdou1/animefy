﻿using System;

namespace System.Collections
{
	/// <summary>Supports the structural comparison of collection objects.</summary>
	// Token: 0x020005DA RID: 1498
	public interface IStructuralComparable
	{
		/// <summary>Determines whether the current collection object precedes, occurs in the same position as, or follows another object in the sort order.</summary>
		/// <param name="other">The object to compare with the current instance.</param>
		/// <param name="comparer">An object that compares members of the current collection object with the corresponding members of <paramref name="other" />.</param>
		/// <returns>An integer that indicates the relationship of the current collection object to <paramref name="other" />, as shown in the following table.Return valueDescription-1The current instance precedes <paramref name="other" />.0The current instance and <paramref name="other" /> are equal.1The current instance follows <paramref name="other" />.</returns>
		/// <exception cref="T:System.ArgumentException">This instance and <paramref name="other" /> are not the same type.</exception>
		// Token: 0x06002CA3 RID: 11427
		int CompareTo(object other, IComparer comparer);
	}
}
