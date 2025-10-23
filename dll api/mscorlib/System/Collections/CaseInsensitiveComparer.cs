﻿using System;
using System.Globalization;

namespace System.Collections
{
	/// <summary>Compares two objects for equivalence, ignoring the case of strings.</summary>
	// Token: 0x020005DD RID: 1501
	[Serializable]
	public class CaseInsensitiveComparer : IComparer
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveComparer" /> class using the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</summary>
		// Token: 0x06002CAC RID: 11436 RVA: 0x000B8226 File Offset: 0x000B6426
		public CaseInsensitiveComparer()
		{
			this._compareInfo = CultureInfo.CurrentCulture.CompareInfo;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveComparer" /> class using the specified <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for the new <see cref="T:System.Collections.CaseInsensitiveComparer" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />. </exception>
		// Token: 0x06002CAD RID: 11437 RVA: 0x000B823E File Offset: 0x000B643E
		public CaseInsensitiveComparer(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			this._compareInfo = culture.CompareInfo;
		}

		/// <summary>Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
		/// <param name="a">The first object to compare. </param>
		/// <param name="b">The second object to compare. </param>
		/// <returns>A signed integer that indicates the relative values of <paramref name="a" /> and <paramref name="b" />, as shown in the following table.Value Meaning Less than zero 
		///             <paramref name="a" /> is less than <paramref name="b" />, with casing ignored. Zero 
		///             <paramref name="a" /> equals <paramref name="b" />, with casing ignored. Greater than zero 
		///             <paramref name="a" /> is greater than <paramref name="b" />, with casing ignored. </returns>
		/// <exception cref="T:System.ArgumentException">Neither <paramref name="a" /> nor <paramref name="b" /> implements the <see cref="T:System.IComparable" /> interface.-or- 
		///         <paramref name="a" /> and <paramref name="b" /> are of different types. </exception>
		// Token: 0x06002CAE RID: 11438 RVA: 0x000B8260 File Offset: 0x000B6460
		public int Compare(object a, object b)
		{
			string text = a as string;
			string text2 = b as string;
			if (text != null && text2 != null)
			{
				return this._compareInfo.Compare(text, text2, CompareOptions.IgnoreCase);
			}
			return Comparer.Default.Compare(a, b);
		}

		// Token: 0x0400186A RID: 6250
		private CompareInfo _compareInfo;
	}
}
