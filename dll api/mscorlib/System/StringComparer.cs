using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System
{
	/// <summary>Represents a string comparison operation that uses specific case and culture-based or ordinal comparison rules.</summary>
	// Token: 0x020000FB RID: 251
	[Serializable]
	public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
	{
		/// <summary>Gets a <see cref="T:System.StringComparer" /> object that performs a case-insensitive string comparison using the word comparison rules of the invariant culture.</summary>
		/// <returns>A new <see cref="T:System.StringComparer" /> object.</returns>
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x000292A5 File Offset: 0x000274A5
		public static StringComparer InvariantCultureIgnoreCase
		{
			get
			{
				return StringComparer.s_invariantCultureIgnoreCase;
			}
		}

		/// <summary>Gets a <see cref="T:System.StringComparer" /> object that performs a case-sensitive ordinal string comparison.</summary>
		/// <returns>A <see cref="T:System.StringComparer" /> object.</returns>
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x000292AC File Offset: 0x000274AC
		public static StringComparer Ordinal
		{
			get
			{
				return StringComparer.s_ordinal;
			}
		}

		/// <summary>Gets a <see cref="T:System.StringComparer" /> object that performs a case-insensitive ordinal string comparison.</summary>
		/// <returns>A <see cref="T:System.StringComparer" /> object.</returns>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x000292B3 File Offset: 0x000274B3
		public static StringComparer OrdinalIgnoreCase
		{
			get
			{
				return StringComparer.s_ordinalIgnoreCase;
			}
		}

		/// <summary>Creates a <see cref="T:System.StringComparer" /> object that compares strings according to the rules of a specified culture.</summary>
		/// <param name="culture">A culture whose linguistic rules are used to perform a string comparison.</param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> to specify that comparison operations be case-insensitive; <see langword="false" /> to specify that comparison operations be case-sensitive.</param>
		/// <returns>A new <see cref="T:System.StringComparer" /> object that performs string comparisons according to the comparison rules used by the <paramref name="culture" /> parameter and the case rule specified by the <paramref name="ignoreCase" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />.</exception>
		// Token: 0x0600092B RID: 2347 RVA: 0x000292BA File Offset: 0x000274BA
		public static StringComparer Create(CultureInfo culture, bool ignoreCase)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return new CultureAwareComparer(culture, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		/// <summary>When overridden in a derived class, compares two objects and returns an indication of their relative sort order.</summary>
		/// <param name="x">An object to compare to <paramref name="y" />.</param>
		/// <param name="y">An object to compare to <paramref name="x" />.</param>
		/// <returns>A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in the following table.ValueMeaningLess than zero
		///             <paramref name="x" /> precedes  <paramref name="y" /> in the sort order. -or-
		///             <paramref name="x" /> is <see langword="null" /> and <paramref name="y" /> is not <see langword="null" />.Zero
		///             <paramref name="x" /> is equal to <paramref name="y" />.-or-
		///             <paramref name="x" /> and <paramref name="y" /> are both <see langword="null" />. Greater than zero
		///             <paramref name="x" /> follows <paramref name="y" /> in the sort order.-or-
		///             <paramref name="y" /> is <see langword="null" /> and <paramref name="x" /> is not <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">Neither <paramref name="x" /> nor <paramref name="y" /> is a <see cref="T:System.String" /> object, and neither <paramref name="x" /> nor <paramref name="y" /> implements the <see cref="T:System.IComparable" /> interface.</exception>
		// Token: 0x0600092C RID: 2348 RVA: 0x000292D8 File Offset: 0x000274D8
		public int Compare(object x, object y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			string text = x as string;
			if (text != null)
			{
				string text2 = y as string;
				if (text2 != null)
				{
					return this.Compare(text, text2);
				}
			}
			IComparable comparable = x as IComparable;
			if (comparable != null)
			{
				return comparable.CompareTo(y);
			}
			throw new ArgumentException("At least one object must implement IComparable.");
		}

		/// <summary>When overridden in a derived class, indicates whether two objects are equal.</summary>
		/// <param name="x">An object to compare to <paramref name="y" />.</param>
		/// <param name="y">An object to compare to <paramref name="x" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="x" /> and <paramref name="y" /> refer to the same object, or <paramref name="x" /> and <paramref name="y" /> are both the same type of object and those objects are equal, or both <paramref name="x" /> and <paramref name="y" /> are <see langword="null" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600092D RID: 2349 RVA: 0x00029330 File Offset: 0x00027530
		public bool Equals(object x, object y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			string text = x as string;
			if (text != null)
			{
				string text2 = y as string;
				if (text2 != null)
				{
					return this.Equals(text, text2);
				}
			}
			return x.Equals(y);
		}

		/// <summary>When overridden in a derived class, gets the hash code for the specified object.</summary>
		/// <param name="obj">An object.</param>
		/// <returns>A 32-bit signed hash code calculated from the value of the <paramref name="obj" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentException">Not enough memory is available to allocate the buffer that is required to compute the hash code.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="obj" /> is <see langword="null" />.</exception>
		// Token: 0x0600092E RID: 2350 RVA: 0x00029370 File Offset: 0x00027570
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			string text = obj as string;
			if (text != null)
			{
				return this.GetHashCode(text);
			}
			return obj.GetHashCode();
		}

		/// <summary>When overridden in a derived class, compares two strings and returns an indication of their relative sort order.</summary>
		/// <param name="x">A string to compare to <paramref name="y" />.</param>
		/// <param name="y">A string to compare to <paramref name="x" />.</param>
		/// <returns>A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in the following table.ValueMeaningLess than zero
		///             <paramref name="x" /> precedes <paramref name="y" /> in the sort order.-or-
		///             <paramref name="x" /> is <see langword="null" /> and <paramref name="y" /> is not <see langword="null" />.Zero
		///             <paramref name="x" /> is equal to <paramref name="y" />.-or-
		///             <paramref name="x" /> and <paramref name="y" /> are both <see langword="null" />. Greater than zero
		///             <paramref name="x" /> follows <paramref name="y" /> in the sort order.-or-
		///             <paramref name="y" /> is <see langword="null" /> and <paramref name="x" /> is not <see langword="null" />. </returns>
		// Token: 0x0600092F RID: 2351
		public abstract int Compare(string x, string y);

		/// <summary>When overridden in a derived class, indicates whether two strings are equal.</summary>
		/// <param name="x">A string to compare to <paramref name="y" />.</param>
		/// <param name="y">A string to compare to <paramref name="x" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="x" /> and <paramref name="y" /> refer to the same object, or <paramref name="x" /> and <paramref name="y" /> are equal, or <paramref name="x" /> and <paramref name="y" /> are <see langword="null" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000930 RID: 2352
		public abstract bool Equals(string x, string y);

		/// <summary>When overridden in a derived class, gets the hash code for the specified string.</summary>
		/// <param name="obj">A string.</param>
		/// <returns>A 32-bit signed hash code calculated from the value of the <paramref name="obj" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentException">Not enough memory is available to allocate the buffer that is required to compute the hash code.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="obj" /> is <see langword="null" />. </exception>
		// Token: 0x06000931 RID: 2353
		public abstract int GetHashCode(string obj);

		// Token: 0x0400036B RID: 875
		private static readonly CultureAwareComparer s_invariantCulture = new CultureAwareComparer(CultureInfo.InvariantCulture, CompareOptions.None);

		// Token: 0x0400036C RID: 876
		private static readonly CultureAwareComparer s_invariantCultureIgnoreCase = new CultureAwareComparer(CultureInfo.InvariantCulture, CompareOptions.IgnoreCase);

		// Token: 0x0400036D RID: 877
		private static readonly OrdinalCaseSensitiveComparer s_ordinal = new OrdinalCaseSensitiveComparer();

		// Token: 0x0400036E RID: 878
		private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase = new OrdinalIgnoreCaseComparer();
	}
}
