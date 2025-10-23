﻿using System;

namespace System.Collections
{
	/// <summary>Exposes a method that compares two objects.</summary>
	// Token: 0x020005D3 RID: 1491
	public interface IComparer
	{
		/// <summary>Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
		/// <param name="x">The first object to compare. </param>
		/// <param name="y">The second object to compare. </param>
		/// <returns>A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in the following table.Value Meaning Less than zero 
		///             <paramref name="x" /> is less than <paramref name="y" />. Zero 
		///             <paramref name="x" /> equals <paramref name="y" />. Greater than zero 
		///             <paramref name="x" /> is greater than <paramref name="y" />. </returns>
		/// <exception cref="T:System.ArgumentException">Neither <paramref name="x" /> nor <paramref name="y" /> implements the <see cref="T:System.IComparable" /> interface.-or- 
		///         <paramref name="x" /> and <paramref name="y" /> are of different types and neither one can handle comparisons with the other. </exception>
		// Token: 0x06002C83 RID: 11395
		int Compare(object x, object y);
	}
}
