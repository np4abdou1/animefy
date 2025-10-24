﻿using System;

namespace System.Collections.Generic
{
	/// <summary>Defines methods to support the comparison of objects for equality.</summary>
	/// <typeparam name="T">The type of objects to compare.</typeparam>
	// Token: 0x0200061D RID: 1565
	public interface IEqualityComparer<in T>
	{
		/// <summary>Determines whether the specified objects are equal.</summary>
		/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
		/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
		/// <returns>
		///     <see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002FAC RID: 12204
		bool Equals(T x, T y);

		/// <summary>Returns a hash code for the specified object.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
		/// <returns>A hash code for the specified object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The type of <paramref name="obj" /> is a reference type and <paramref name="obj" /> is <see langword="null" />.</exception>
		// Token: 0x06002FAD RID: 12205
		int GetHashCode(T obj);
	}
}
