﻿using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace System
{
	/// <summary>Represents text as a sequence of UTF-16 code units.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x00025EBF File Offset: 0x000240BF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool EqualsHelper(string strA, string strB)
		{
			return SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(strA.GetRawStringData()), Unsafe.As<char, byte>(strB.GetRawStringData()), (ulong)((long)strA.Length * 2L));
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00025EE6 File Offset: 0x000240E6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
		{
			return SpanHelpers.SequenceCompareTo(Unsafe.Add<char>(strA.GetRawStringData(), indexA), countA, Unsafe.Add<char>(strB.GetRawStringData(), indexB), countB);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00025F0C File Offset: 0x0002410C
		private unsafe static int CompareOrdinalHelper(string strA, string strB)
		{
			int i = Math.Min(strA.Length, strB.Length);
			fixed (char* ptr = &strA._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &strB._firstChar)
				{
					char* ptr4 = ptr3;
					char* ptr5 = ptr2;
					char* ptr6 = ptr4;
					if (ptr5[1] == ptr6[1])
					{
						i -= 2;
						ptr5 += 2;
						ptr6 += 2;
						while (i >= 12)
						{
							if (*(long*)ptr5 == *(long*)ptr6)
							{
								if (*(long*)(ptr5 + 4) == *(long*)(ptr6 + 4))
								{
									if (*(long*)(ptr5 + 8) == *(long*)(ptr6 + 8))
									{
										i -= 12;
										ptr5 += 12;
										ptr6 += 12;
										continue;
									}
									ptr5 += 4;
									ptr6 += 4;
								}
								ptr5 += 4;
								ptr6 += 4;
							}
							if (*(int*)ptr5 == *(int*)ptr6)
							{
								ptr5 += 2;
								ptr6 += 2;
							}
							IL_10E:
							if (*ptr5 != *ptr6)
							{
								return (int)(*ptr5 - *ptr6);
							}
							goto IL_11E;
						}
						while (i > 0)
						{
							if (*(int*)ptr5 != *(int*)ptr6)
							{
								goto IL_10E;
							}
							i -= 2;
							ptr5 += 2;
							ptr6 += 2;
						}
						return strA.Length - strB.Length;
					}
					IL_11E:
					return (int)(ptr5[1] - ptr6[1]);
				}
			}
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order.</summary>
		/// <param name="strA">The first string to compare. </param>
		/// <param name="strB">The second string to compare. </param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> to ignore case during the comparison; otherwise, <see langword="false" />.</param>
		/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero 
		///             <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order. Zero 
		///             <paramref name="strA" /> occurs in the same position as <paramref name="strB" /> in the sort order. Greater than zero 
		///             <paramref name="strA" /> follows <paramref name="strB" /> in the sort order. </returns>
		// Token: 0x0600086F RID: 2159 RVA: 0x00026044 File Offset: 0x00024244
		public static int Compare(string strA, string strB, bool ignoreCase)
		{
			StringComparison comparisonType = ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
			return string.Compare(strA, strB, comparisonType);
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects using the specified rules, and returns an integer that indicates their relative position in the sort order.</summary>
		/// <param name="strA">The first string to compare.</param>
		/// <param name="strB">The second string to compare. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules to use in the comparison. </param>
		/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero 
		///             <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order. Zero 
		///             <paramref name="strA" /> is in the same position as <paramref name="strB" /> in the sort order. Greater than zero 
		///             <paramref name="strA" /> follows <paramref name="strB" /> in the sort order. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <see cref="T:System.StringComparison" /> is not supported.</exception>
		// Token: 0x06000870 RID: 2160 RVA: 0x00026064 File Offset: 0x00024264
		public static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			if (strA == strB)
			{
				string.CheckStringComparison(comparisonType);
				return 0;
			}
			if (strA == null)
			{
				string.CheckStringComparison(comparisonType);
				return -1;
			}
			if (strB == null)
			{
				string.CheckStringComparison(comparisonType);
				return 1;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.Compare(strA, strB, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(strA, strB, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				if (strA._firstChar != strB._firstChar)
				{
					return (int)(strA._firstChar - strB._firstChar);
				}
				return string.CompareOrdinalHelper(strA, strB);
			case StringComparison.OrdinalIgnoreCase:
				return CompareInfo.CompareOrdinalIgnoreCase(strA, 0, strA.Length, strB, 0, strB.Length);
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects using the specified comparison options and culture-specific information to influence the comparison, and returns an integer that indicates the relationship of the two strings to each other in the sort order.</summary>
		/// <param name="strA">The first string to compare.  </param>
		/// <param name="strB">The second string to compare.</param>
		/// <param name="culture">The culture that supplies culture-specific comparison information.</param>
		/// <param name="options">Options to use when performing the comparison (such as ignoring case or symbols).  </param>
		/// <returns>A 32-bit signed integer that indicates the lexical relationship between <paramref name="strA" /> and <paramref name="strB" />, as shown in the following tableValueConditionLess than zero
		///             <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order. Zero
		///             <paramref name="strA" /> occurs in the same position as <paramref name="strB" /> in the sort order. Greater than zero
		///             <paramref name="strA" /> follows <paramref name="strB" /> in the sort order.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> is not a <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />.</exception>
		// Token: 0x06000871 RID: 2161 RVA: 0x0002613E File Offset: 0x0002433E
		public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.CompareInfo.Compare(strA, strB, options);
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and using culture-specific information to influence the comparison, and returns an integer that indicates their relative position in the sort order.</summary>
		/// <param name="strA">The first string to compare. </param>
		/// <param name="strB">The second string to compare. </param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> to ignore case during the comparison; otherwise, <see langword="false" />. </param>
		/// <param name="culture">An object that supplies culture-specific comparison information. </param>
		/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero 
		///             <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order. Zero 
		///             <paramref name="strA" /> occurs in the same position as <paramref name="strB" /> in the sort order. Greater than zero 
		///             <paramref name="strA" /> follows <paramref name="strB" /> in the sort order. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />. </exception>
		// Token: 0x06000872 RID: 2162 RVA: 0x0002615C File Offset: 0x0002435C
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			CompareOptions options = ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None;
			return string.Compare(strA, strB, culture, options);
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects using the specified rules, and returns an integer that indicates their relative position in the sort order. </summary>
		/// <param name="strA">The first string to use in the comparison. </param>
		/// <param name="indexA">The position of the substring within <paramref name="strA" />. </param>
		/// <param name="strB">The second string to use in the comparison.</param>
		/// <param name="indexB">The position of the substring within <paramref name="strB" />. </param>
		/// <param name="length">The maximum number of characters in the substrings to compare. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules to use in the comparison. </param>
		/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero The substring in <paramref name="strA" /> precedes the substring in <paramref name="strB" /> in the sort order.Zero The substrings occur in the same position in the sort order, or the <paramref name="length" /> parameter is zero. Greater than zero The substring in <paramref name="strA" /> follllows the substring in <paramref name="strB" /> in the sort order. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- 
		///         <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- 
		///         <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="indexA" /> or <paramref name="indexB" /> is <see langword="null" />, and <paramref name="length" /> is greater than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		// Token: 0x06000873 RID: 2163 RVA: 0x0002617C File Offset: 0x0002437C
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			if (strA == null || strB == null)
			{
				if (strA == strB)
				{
					return 0;
				}
				if (strA != null)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (length < 0)
				{
					throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
				}
				if (indexA < 0 || indexB < 0)
				{
					throw new ArgumentOutOfRangeException((indexA < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (strA.Length - indexA < 0 || strB.Length - indexB < 0)
				{
					throw new ArgumentOutOfRangeException((strA.Length - indexA < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (length == 0 || (strA == strB && indexA == indexB))
				{
					return 0;
				}
				int num = Math.Min(length, strA.Length - indexA);
				int num2 = Math.Min(length, strB.Length - indexB);
				switch (comparisonType)
				{
				case StringComparison.CurrentCulture:
					return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None);
				case StringComparison.CurrentCultureIgnoreCase:
					return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase);
				case StringComparison.InvariantCulture:
					return CompareInfo.Invariant.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None);
				case StringComparison.InvariantCultureIgnoreCase:
					return CompareInfo.Invariant.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase);
				case StringComparison.Ordinal:
					return string.CompareOrdinalHelper(strA, indexA, num, strB, indexB, num2);
				case StringComparison.OrdinalIgnoreCase:
					return CompareInfo.CompareOrdinalIgnoreCase(strA, indexA, num, strB, indexB, num2);
				default:
					throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
				}
			}
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each string.</summary>
		/// <param name="strA">The first string to compare. </param>
		/// <param name="strB">The second string to compare. </param>
		/// <returns>An integer that indicates the lexical relationship between the two comparands.ValueCondition Less than zero 
		///             <paramref name="strA" /> is less than <paramref name="strB" />. Zero 
		///             <paramref name="strA" /> and <paramref name="strB" /> are equal. Greater than zero 
		///             <paramref name="strA" /> is greater than <paramref name="strB" />. </returns>
		// Token: 0x06000874 RID: 2164 RVA: 0x000262DB File Offset: 0x000244DB
		public static int CompareOrdinal(string strA, string strB)
		{
			if (strA == strB)
			{
				return 0;
			}
			if (strA == null)
			{
				return -1;
			}
			if (strB == null)
			{
				return 1;
			}
			if (strA._firstChar != strB._firstChar)
			{
				return (int)(strA._firstChar - strB._firstChar);
			}
			return string.CompareOrdinalHelper(strA, strB);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00026310 File Offset: 0x00024510
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			return SpanHelpers.SequenceCompareTo(MemoryMarshal.GetReference<char>(strA), strA.Length, MemoryMarshal.GetReference<char>(strB), strB.Length);
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each substring. </summary>
		/// <param name="strA">The first string to use in the comparison. </param>
		/// <param name="indexA">The starting index of the substring in <paramref name="strA" />. </param>
		/// <param name="strB">The second string to use in the comparison. </param>
		/// <param name="indexB">The starting index of the substring in <paramref name="strB" />. </param>
		/// <param name="length">The maximum number of characters in the substrings to compare. </param>
		/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.ValueConditionLess than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="strA" /> is not <see langword="null" /> and <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- 
		///         <paramref name="strB" /> is not <see langword="null" /> and<paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- 
		///         <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. </exception>
		// Token: 0x06000876 RID: 2166 RVA: 0x00026334 File Offset: 0x00024534
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			if (strA == null || strB == null)
			{
				if (strA == strB)
				{
					return 0;
				}
				if (strA != null)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (length < 0)
				{
					throw new ArgumentOutOfRangeException("length", "Count cannot be less than zero.");
				}
				if (indexA < 0 || indexB < 0)
				{
					throw new ArgumentOutOfRangeException((indexA < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				int num = Math.Min(length, strA.Length - indexA);
				int num2 = Math.Min(length, strB.Length - indexB);
				if (num < 0 || num2 < 0)
				{
					throw new ArgumentOutOfRangeException((num < 0) ? "indexA" : "indexB", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (length == 0 || (strA == strB && indexA == indexB))
				{
					return 0;
				}
				return string.CompareOrdinalHelper(strA, indexA, num, strB, indexB, num2);
			}
		}

		/// <summary>Compares this instance with a specified <see cref="T:System.Object" /> and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary>
		/// <param name="value">An object that evaluates to a <see cref="T:System.String" />. </param>
		/// <returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="value" /> parameter.Value Condition Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />.-or- 
		///             <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.String" />. </exception>
		// Token: 0x06000877 RID: 2167 RVA: 0x000263E8 File Offset: 0x000245E8
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			string text = value as string;
			if (text == null)
			{
				throw new ArgumentException("Object must be of type String.");
			}
			return this.CompareTo(text);
		}

		/// <summary>Compares this instance with a specified <see cref="T:System.String" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified string. </summary>
		/// <param name="strB">The string to compare with this instance. </param>
		/// <returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="strB" /> parameter.Value Condition Less than zero This instance precedes <paramref name="strB" />. Zero This instance has the same position in the sort order as <paramref name="strB" />. Greater than zero This instance follows <paramref name="strB" />.-or- 
		///             <paramref name="strB" /> is <see langword="null" />. </returns>
		// Token: 0x06000878 RID: 2168 RVA: 0x00026416 File Offset: 0x00024616
		public int CompareTo(string strB)
		{
			return string.Compare(this, strB, StringComparison.CurrentCulture);
		}

		/// <summary>Determines whether the end of this string instance matches the specified string.</summary>
		/// <param name="value">The string to compare to the substring at the end of this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> matches the end of this instance; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x06000879 RID: 2169 RVA: 0x00026420 File Offset: 0x00024620
		public bool EndsWith(string value)
		{
			return this.EndsWith(value, StringComparison.CurrentCulture);
		}

		/// <summary>Determines whether the end of this string instance matches the specified string when compared using the specified comparison option.</summary>
		/// <param name="value">The string to compare to the substring at the end of this instance. </param>
		/// <param name="comparisonType">One of the enumeration values that determines how this string and <paramref name="value" /> are compared. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter matches the end of this string; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
		// Token: 0x0600087A RID: 2170 RVA: 0x0002642C File Offset: 0x0002462C
		public bool EndsWith(string value, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value.Length == 0)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(this, value, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.IsSuffix(this, value, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsSuffix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return this.Length >= value.Length && string.CompareOrdinalHelper(this, this.Length - value.Length, value.Length, value, 0, value.Length) == 0;
			case StringComparison.OrdinalIgnoreCase:
				return this.Length >= value.Length && CompareInfo.CompareOrdinalIgnoreCase(this, this.Length - value.Length, value.Length, value, 0, value.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Determines whether this instance and a specified object, which must also be a <see cref="T:System.String" /> object, have the same value.</summary>
		/// <param name="obj">The string to compare to this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.String" /> and its value is the same as this instance; otherwise, <see langword="false" />.  If <paramref name="obj" /> is <see langword="null" />, the method returns <see langword="false" />.</returns>
		// Token: 0x0600087B RID: 2171 RVA: 0x00026544 File Offset: 0x00024744
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			string text = obj as string;
			return text != null && this.Length == text.Length && string.EqualsHelper(this, text);
		}

		/// <summary>Determines whether this instance and another specified <see cref="T:System.String" /> object have the same value.</summary>
		/// <param name="value">The string to compare to this instance. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the <paramref name="value" /> parameter is the same as the value of this instance; otherwise, <see langword="false" />. If <paramref name="value" /> is <see langword="null" />, the method returns <see langword="false" />. </returns>
		// Token: 0x0600087C RID: 2172 RVA: 0x0002657A File Offset: 0x0002477A
		public bool Equals(string value)
		{
			return this == value || (value != null && this.Length == value.Length && string.EqualsHelper(this, value));
		}

		/// <summary>Determines whether this string and a specified <see cref="T:System.String" /> object have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary>
		/// <param name="value">The string to compare to this instance.</param>
		/// <param name="comparisonType">One of the enumeration values that specifies how the strings will be compared. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the <paramref name="value" /> parameter is the same as this string; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		// Token: 0x0600087D RID: 2173 RVA: 0x000265A0 File Offset: 0x000247A0
		public bool Equals(string value, StringComparison comparisonType)
		{
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value == null)
			{
				string.CheckStringComparison(comparisonType);
				return false;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(this, value, CompareOptions.None) == 0;
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(this, value, CompareOptions.IgnoreCase) == 0;
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.Compare(this, value, CompareOptions.None) == 0;
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(this, value, CompareOptions.IgnoreCase) == 0;
			case StringComparison.Ordinal:
				return this.Length == value.Length && string.EqualsHelper(this, value);
			case StringComparison.OrdinalIgnoreCase:
				return this.Length == value.Length && CompareInfo.CompareOrdinalIgnoreCase(this, 0, this.Length, value, 0, value.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value.</summary>
		/// <param name="a">The first string to compare, or <see langword="null" />. </param>
		/// <param name="b">The second string to compare, or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, <see langword="false" />. If both <paramref name="a" /> and <paramref name="b" /> are <see langword="null" />, the method returns <see langword="true" />.</returns>
		// Token: 0x0600087E RID: 2174 RVA: 0x00026685 File Offset: 0x00024885
		public static bool Equals(string a, string b)
		{
			return a == b || (a != null && b != null && a.Length == b.Length && string.EqualsHelper(a, b));
		}

		/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary>
		/// <param name="a">The first string to compare, or <see langword="null" />. </param>
		/// <param name="b">The second string to compare, or <see langword="null" />. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules for the comparison. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the <paramref name="a" /> parameter is equal to the value of the <paramref name="b" /> parameter; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		// Token: 0x0600087F RID: 2175 RVA: 0x000266AC File Offset: 0x000248AC
		public static bool Equals(string a, string b, StringComparison comparisonType)
		{
			if (a == b)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (a == null || b == null)
			{
				string.CheckStringComparison(comparisonType);
				return false;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(a, b, CompareOptions.None) == 0;
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(a, b, CompareOptions.IgnoreCase) == 0;
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.Compare(a, b, CompareOptions.None) == 0;
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(a, b, CompareOptions.IgnoreCase) == 0;
			case StringComparison.Ordinal:
				return a.Length == b.Length && string.EqualsHelper(a, b);
			case StringComparison.OrdinalIgnoreCase:
				return a.Length == b.Length && CompareInfo.CompareOrdinalIgnoreCase(a, 0, a.Length, b, 0, b.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Determines whether two specified strings have the same value.</summary>
		/// <param name="a">The first string to compare, or <see langword="null" />. </param>
		/// <param name="b">The second string to compare, or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000880 RID: 2176 RVA: 0x00026794 File Offset: 0x00024994
		public static bool operator ==(string a, string b)
		{
			return string.Equals(a, b);
		}

		/// <summary>Determines whether two specified strings have different values.</summary>
		/// <param name="a">The first string to compare, or <see langword="null" />. </param>
		/// <param name="b">The second string to compare, or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="a" /> is different from the value of <paramref name="b" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000881 RID: 2177 RVA: 0x0002679D File Offset: 0x0002499D
		public static bool operator !=(string a, string b)
		{
			return !string.Equals(a, b);
		}

		/// <summary>Returns the hash code for this string.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000882 RID: 2178 RVA: 0x000267A9 File Offset: 0x000249A9
		public override int GetHashCode()
		{
			return Marvin.ComputeHash32(Unsafe.As<char, byte>(ref this._firstChar), this._stringLength * 2, Marvin.DefaultSeed);
		}

		/// <summary>Determines whether the beginning of this string instance matches the specified string.</summary>
		/// <param name="value">The string to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> matches the beginning of this string; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x06000883 RID: 2179 RVA: 0x000267C8 File Offset: 0x000249C8
		public bool StartsWith(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return this.StartsWith(value, StringComparison.CurrentCulture);
		}

		/// <summary>Determines whether the beginning of this string instance matches the specified string when compared using the specified comparison option.</summary>
		/// <param name="value">The string to compare. </param>
		/// <param name="comparisonType">One of the enumeration values that determines how this string and <paramref name="value" /> are compared. </param>
		/// <returns>
		///     <see langword="true" /> if this instance begins with <paramref name="value" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
		// Token: 0x06000884 RID: 2180 RVA: 0x000267E0 File Offset: 0x000249E0
		public bool StartsWith(string value, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value.Length == 0)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(this, value, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.IsPrefix(this, value, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsPrefix(this, value, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return this.Length >= value.Length && this._firstChar == value._firstChar && (value.Length == 1 || SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(this.GetRawStringData()), Unsafe.As<char, byte>(value.GetRawStringData()), (ulong)((long)value.Length * 2L)));
			case StringComparison.OrdinalIgnoreCase:
				return this.Length >= value.Length && CompareInfo.CompareOrdinalIgnoreCase(this, 0, value.Length, value, 0, value.Length) == 0;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00026903 File Offset: 0x00024B03
		internal static void CheckStringComparison(StringComparison comparisonType)
		{
			if (comparisonType - StringComparison.CurrentCulture > 5)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.NotSupported_StringComparison, ExceptionArgument.comparisonType);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00026914 File Offset: 0x00024B14
		private unsafe static void FillStringChecked(string dest, int destPos, string src)
		{
			if (src.Length > dest.Length - destPos)
			{
				throw new IndexOutOfRangeException();
			}
			fixed (char* ptr = &dest._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &src._firstChar)
				{
					char* smem = ptr3;
					string.wstrcpy(ptr2 + destPos, smem, src.Length);
				}
			}
		}

		/// <summary>Concatenates the members of an <see cref="T:System.Collections.Generic.IEnumerable`1" /> implementation.</summary>
		/// <param name="values">A collection object that implements the <see cref="T:System.Collections.Generic.IEnumerable`1" /> interface.</param>
		/// <typeparam name="T">The type of the members of <paramref name="values" />.</typeparam>
		/// <returns>The concatenated members in <paramref name="values" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="values" /> is <see langword="null" />. </exception>
		// Token: 0x06000887 RID: 2183 RVA: 0x00026964 File Offset: 0x00024B64
		public static string Concat<T>(IEnumerable<T> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (typeof(T) == typeof(char))
			{
				using (IEnumerator<char> enumerator = Unsafe.As<IEnumerable<char>>(values).GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
						return string.Empty;
					}
					char c = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						return string.CreateFromChar(c);
					}
					StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
					stringBuilder.Append(c);
					do
					{
						c = enumerator.Current;
						stringBuilder.Append(c);
					}
					while (enumerator.MoveNext());
					return StringBuilderCache.GetStringAndRelease(stringBuilder);
				}
			}
			string result;
			using (IEnumerator<T> enumerator2 = values.GetEnumerator())
			{
				if (!enumerator2.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					T t = enumerator2.Current;
					string text = (t != null) ? t.ToString() : null;
					if (!enumerator2.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						StringBuilder stringBuilder2 = StringBuilderCache.Acquire(16);
						stringBuilder2.Append(text);
						do
						{
							t = enumerator2.Current;
							if (t != null)
							{
								stringBuilder2.Append(t.ToString());
							}
						}
						while (enumerator2.MoveNext());
						result = StringBuilderCache.GetStringAndRelease(stringBuilder2);
					}
				}
			}
			return result;
		}

		/// <summary>Concatenates two specified instances of <see cref="T:System.String" />.</summary>
		/// <param name="str0">The first string to concatenate. </param>
		/// <param name="str1">The second string to concatenate. </param>
		/// <returns>The concatenation of <paramref name="str0" /> and <paramref name="str1" />.</returns>
		// Token: 0x06000888 RID: 2184 RVA: 0x00026AE0 File Offset: 0x00024CE0
		public static string Concat(string str0, string str1)
		{
			if (string.IsNullOrEmpty(str0))
			{
				if (string.IsNullOrEmpty(str1))
				{
					return string.Empty;
				}
				return str1;
			}
			else
			{
				if (string.IsNullOrEmpty(str1))
				{
					return str0;
				}
				int length = str0.Length;
				string text = string.FastAllocateString(length + str1.Length);
				string.FillStringChecked(text, 0, str0);
				string.FillStringChecked(text, length, str1);
				return text;
			}
		}

		/// <summary>Concatenates three specified instances of <see cref="T:System.String" />.</summary>
		/// <param name="str0">The first string to concatenate. </param>
		/// <param name="str1">The second string to concatenate. </param>
		/// <param name="str2">The third string to concatenate. </param>
		/// <returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, and <paramref name="str2" />.</returns>
		// Token: 0x06000889 RID: 2185 RVA: 0x00026B34 File Offset: 0x00024D34
		public static string Concat(string str0, string str1, string str2)
		{
			if (string.IsNullOrEmpty(str0))
			{
				return str1 + str2;
			}
			if (string.IsNullOrEmpty(str1))
			{
				return str0 + str2;
			}
			if (string.IsNullOrEmpty(str2))
			{
				return str0 + str1;
			}
			string text = string.FastAllocateString(str0.Length + str1.Length + str2.Length);
			string.FillStringChecked(text, 0, str0);
			string.FillStringChecked(text, str0.Length, str1);
			string.FillStringChecked(text, str0.Length + str1.Length, str2);
			return text;
		}

		/// <summary>Concatenates four specified instances of <see cref="T:System.String" />.</summary>
		/// <param name="str0">The first string to concatenate. </param>
		/// <param name="str1">The second string to concatenate. </param>
		/// <param name="str2">The third string to concatenate. </param>
		/// <param name="str3">The fourth string to concatenate. </param>
		/// <returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, <paramref name="str2" />, and <paramref name="str3" />.</returns>
		// Token: 0x0600088A RID: 2186 RVA: 0x00026BB4 File Offset: 0x00024DB4
		public static string Concat(string str0, string str1, string str2, string str3)
		{
			if (string.IsNullOrEmpty(str0))
			{
				return str1 + str2 + str3;
			}
			if (string.IsNullOrEmpty(str1))
			{
				return str0 + str2 + str3;
			}
			if (string.IsNullOrEmpty(str2))
			{
				return str0 + str1 + str3;
			}
			if (string.IsNullOrEmpty(str3))
			{
				return str0 + str1 + str2;
			}
			string text = string.FastAllocateString(str0.Length + str1.Length + str2.Length + str3.Length);
			string.FillStringChecked(text, 0, str0);
			string.FillStringChecked(text, str0.Length, str1);
			string.FillStringChecked(text, str0.Length + str1.Length, str2);
			string.FillStringChecked(text, str0.Length + str1.Length + str2.Length, str3);
			return text;
		}

		/// <summary>Concatenates the elements of a specified <see cref="T:System.String" /> array.</summary>
		/// <param name="values">An array of string instances. </param>
		/// <returns>The concatenated elements of <paramref name="values" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="values" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
		// Token: 0x0600088B RID: 2187 RVA: 0x00026C6C File Offset: 0x00024E6C
		public static string Concat(params string[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length <= 1)
			{
				string result;
				if (values.Length != 0)
				{
					if ((result = values[0]) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			long num = 0L;
			foreach (string text in values)
			{
				if (text != null)
				{
					num += (long)text.Length;
				}
			}
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			int num2 = (int)num;
			if (num2 == 0)
			{
				return string.Empty;
			}
			string text2 = string.FastAllocateString(num2);
			int num3 = 0;
			foreach (string text3 in values)
			{
				if (!string.IsNullOrEmpty(text3))
				{
					int length = text3.Length;
					if (length > num2 - num3)
					{
						num3 = -1;
						break;
					}
					string.FillStringChecked(text2, num3, text3);
					num3 += length;
				}
			}
			if (num3 != num2)
			{
				return string.Concat((string[])values.Clone());
			}
			return text2;
		}

		/// <summary>Replaces one or more format items in a specified string with the string representation of a specified object.</summary>
		/// <param name="format">A composite format string. </param>
		/// <param name="arg0">The object to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which any format items are replaced by the string representation of <paramref name="arg0" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">The format item in <paramref name="format" /> is invalid.-or- The index of a format item is not zero. </exception>
		// Token: 0x0600088C RID: 2188 RVA: 0x00026D4B File Offset: 0x00024F4B
		public static string Format(string format, object arg0)
		{
			return string.FormatHelper(null, format, new ParamsArray(arg0));
		}

		/// <summary>Replaces the format items in a specified string with the string representation of two specified objects.</summary>
		/// <param name="format">A composite format string. </param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which format items are replaced by the string representations of <paramref name="arg0" /> and <paramref name="arg1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid.-or- The index of a format item is not zero or one. </exception>
		// Token: 0x0600088D RID: 2189 RVA: 0x00026D5A File Offset: 0x00024F5A
		public static string Format(string format, object arg0, object arg1)
		{
			return string.FormatHelper(null, format, new ParamsArray(arg0, arg1));
		}

		/// <summary>Replaces the format items in a specified string with the string representation of three specified objects.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <param name="arg2">The third object to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representations of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than two. </exception>
		// Token: 0x0600088E RID: 2190 RVA: 0x00026D6A File Offset: 0x00024F6A
		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			return string.FormatHelper(null, format, new ParamsArray(arg0, arg1, arg2));
		}

		/// <summary>Replaces the format item in a specified string with the string representation of a corresponding object in a specified array.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An object array that contains zero or more objects to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> or <paramref name="args" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array. </exception>
		// Token: 0x0600088F RID: 2191 RVA: 0x00026D7B File Offset: 0x00024F7B
		public static string Format(string format, params object[] args)
		{
			if (args == null)
			{
				throw new ArgumentNullException((format == null) ? "format" : "args");
			}
			return string.FormatHelper(null, format, new ParamsArray(args));
		}

		/// <summary>Replaces the format item or items in a specified string with the string representation of the corresponding object. A parameter supplies culture-specific formatting information. </summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <param name="format">A composite format string. </param>
		/// <param name="arg0">The object to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which the format item or items have been replaced by the string representation of <paramref name="arg0" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> or <paramref name="arg0" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to one. </exception>
		// Token: 0x06000890 RID: 2192 RVA: 0x00026DA2 File Offset: 0x00024FA2
		public static string Format(IFormatProvider provider, string format, object arg0)
		{
			return string.FormatHelper(provider, format, new ParamsArray(arg0));
		}

		/// <summary>Replaces the format items in a specified string with the string representation of two specified objects. A parameter supplies culture-specific formatting information.</summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <param name="format">A composite format string. </param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which format items are replaced by the string representations of <paramref name="arg0" /> and <paramref name="arg1" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" />, <paramref name="arg0" />, or <paramref name="arg1" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to two. </exception>
		// Token: 0x06000891 RID: 2193 RVA: 0x00026DB1 File Offset: 0x00024FB1
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1)
		{
			return string.FormatHelper(provider, format, new ParamsArray(arg0, arg1));
		}

		/// <summary>Replaces the format items in a specified string with the string representation of three specified objects. An parameter supplies culture-specific formatting information. </summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <param name="format">A composite format string. </param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <param name="arg2">The third object to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representations of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" />, <paramref name="arg0" />, <paramref name="arg1" />, or <paramref name="arg2" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to three. </exception>
		// Token: 0x06000892 RID: 2194 RVA: 0x00026DC1 File Offset: 0x00024FC1
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
		{
			return string.FormatHelper(provider, format, new ParamsArray(arg0, arg1, arg2));
		}

		/// <summary>Replaces the format items in a specified string with the string representations of corresponding objects in a specified array. A parameter supplies culture-specific formatting information.</summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <param name="format">A composite format string. </param>
		/// <param name="args">An object array that contains zero or more objects to format. </param>
		/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> or <paramref name="args" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array. </exception>
		// Token: 0x06000893 RID: 2195 RVA: 0x00026DD3 File Offset: 0x00024FD3
		public static string Format(IFormatProvider provider, string format, params object[] args)
		{
			if (args == null)
			{
				throw new ArgumentNullException((format == null) ? "format" : "args");
			}
			return string.FormatHelper(provider, format, new ParamsArray(args));
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00026DFA File Offset: 0x00024FFA
		private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			return StringBuilderCache.GetStringAndRelease(StringBuilderCache.Acquire(format.Length + args.Length * 8).AppendFormatHelper(provider, format, args));
		}

		/// <summary>
		///     Returns a new string in which a specified string is inserted at a specified index position in this instance.</summary>
		/// <param name="startIndex">The zero-based index position of the insertion. </param>
		/// <param name="value">The string to insert. </param>
		/// <returns>A new string that is equivalent to this instance, but with <paramref name="value" /> inserted at position <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is negative or greater than the length of this instance. </exception>
		// Token: 0x06000895 RID: 2197 RVA: 0x00026E2C File Offset: 0x0002502C
		public unsafe string Insert(int startIndex, string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0 || startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex");
			}
			int length = this.Length;
			int length2 = value.Length;
			if (length == 0)
			{
				return value;
			}
			if (length2 == 0)
			{
				return this;
			}
			string text = string.FastAllocateString(length + length2);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &value._firstChar)
				{
					char* smem = ptr3;
					fixed (char* ptr4 = &text._firstChar)
					{
						char* ptr5 = ptr4;
						string.wstrcpy(ptr5, ptr2, startIndex);
						string.wstrcpy(ptr5 + startIndex, smem, length2);
						string.wstrcpy(ptr5 + startIndex + length2, ptr2 + startIndex, length - startIndex);
					}
				}
			}
			return text;
		}

		/// <summary>Concatenates all the elements of a string array, using the specified separator between each element. </summary>
		/// <param name="separator">The string to use as a separator. <paramref name="separator" /> is included in the returned string only if <paramref name="value" /> has more than one element.</param>
		/// <param name="value">An array that contains the elements to concatenate. </param>
		/// <returns>A string that consists of the elements in <paramref name="value" /> delimited by the <paramref name="separator" /> string. If <paramref name="value" /> is an empty array, the method returns <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x06000896 RID: 2198 RVA: 0x00026EDA File Offset: 0x000250DA
		public static string Join(string separator, params string[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return string.Join(separator, value, 0, value.Length);
		}

		/// <summary>Concatenates the members of a constructed <see cref="T:System.Collections.Generic.IEnumerable`1" /> collection of type <see cref="T:System.String" />, using the specified separator between each member.</summary>
		/// <param name="separator">The string to use as a separator.<paramref name="separator" /> is included in the returned string only if <paramref name="values" /> has more than one element.</param>
		/// <param name="values">A collection that contains the strings to concatenate.</param>
		/// <returns>A string that consists of the members of <paramref name="values" /> delimited by the <paramref name="separator" /> string. If <paramref name="values" /> has no members, the method returns <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="values" /> is <see langword="null" />. </exception>
		// Token: 0x06000897 RID: 2199 RVA: 0x00026EF8 File Offset: 0x000250F8
		public static string Join(string separator, IEnumerable<string> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			string result;
			using (IEnumerator<string> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					string text = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
						stringBuilder.Append(text);
						do
						{
							stringBuilder.Append(separator);
							stringBuilder.Append(enumerator.Current);
						}
						while (enumerator.MoveNext());
						result = StringBuilderCache.GetStringAndRelease(stringBuilder);
					}
				}
			}
			return result;
		}

		/// <summary>Concatenates the specified elements of a string array, using the specified separator between each element. </summary>
		/// <param name="separator">The string to use as a separator. <paramref name="separator" /> is included in the returned string only if <paramref name="value" /> has more than one element.</param>
		/// <param name="value">An array that contains the elements to concatenate. </param>
		/// <param name="startIndex">The first element in <paramref name="value" /> to use. </param>
		/// <param name="count">The number of elements of <paramref name="value" /> to use. </param>
		/// <returns>A string that consists of the strings in <paramref name="value" /> delimited by the <paramref name="separator" /> string. -or-
		///     <see cref="F:System.String.Empty" /> if <paramref name="count" /> is zero, <paramref name="value" /> has no elements, or <paramref name="separator" /> and all the elements of <paramref name="value" /> are <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> or <paramref name="count" /> is less than 0.-or- 
		///         <paramref name="startIndex" /> plus <paramref name="count" /> is greater than the number of elements in <paramref name="value" />. </exception>
		/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
		// Token: 0x06000898 RID: 2200 RVA: 0x00026F98 File Offset: 0x00025198
		public unsafe static string Join(string separator, string[] value, int startIndex, int count)
		{
			separator = (separator ?? string.Empty);
			fixed (char* ptr = &separator._firstChar)
			{
				return string.JoinCore(ptr, separator.Length, value, startIndex, count);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00026FC8 File Offset: 0x000251C8
		private unsafe static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (startIndex > value.Length - count)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index and count must refer to a location within the buffer.");
			}
			if (count <= 1)
			{
				string result;
				if (count != 0)
				{
					if ((result = value[startIndex]) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			long num = (long)(count - 1) * (long)separatorLength;
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			int num2 = (int)num;
			int i = startIndex;
			int num3 = startIndex + count;
			while (i < num3)
			{
				string text = value[i];
				if (text != null)
				{
					num2 += text.Length;
					if (num2 < 0)
					{
						throw new OutOfMemoryException();
					}
				}
				i++;
			}
			string text2 = string.FastAllocateString(num2);
			int num4 = 0;
			int j = startIndex;
			int num5 = startIndex + count;
			while (j < num5)
			{
				string text3 = value[j];
				if (text3 != null)
				{
					int length = text3.Length;
					if (length > num2 - num4)
					{
						num4 = -1;
						break;
					}
					string.FillStringChecked(text2, num4, text3);
					num4 += length;
				}
				if (j < num5 - 1)
				{
					fixed (char* ptr = &text2._firstChar)
					{
						char* ptr2 = ptr;
						if (separatorLength == 1)
						{
							ptr2[num4] = *separator;
						}
						else
						{
							string.wstrcpy(ptr2 + num4, separator, separatorLength);
						}
					}
					num4 += separatorLength;
				}
				j++;
			}
			if (num4 != num2)
			{
				return string.JoinCore(separator, separatorLength, (string[])value.Clone(), startIndex, count);
			}
			return text2;
		}

		/// <summary>Returns a new string that left-aligns the characters in this string by padding them on the right with a specified Unicode character, for a specified total length.</summary>
		/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param>
		/// <param name="paddingChar">A Unicode padding character. </param>
		/// <returns>A new string that is equivalent to this instance, but left-aligned and padded on the right with as many <paramref name="paddingChar" /> characters as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="totalWidth" /> is less than zero. </exception>
		// Token: 0x0600089A RID: 2202 RVA: 0x0002712C File Offset: 0x0002532C
		public unsafe string PadRight(int totalWidth, char paddingChar)
		{
			if (totalWidth < 0)
			{
				throw new ArgumentOutOfRangeException("totalWidth", "Non-negative number required.");
			}
			int length = this.Length;
			int num = totalWidth - length;
			if (num <= 0)
			{
				return this;
			}
			string text = string.FastAllocateString(totalWidth);
			fixed (char* ptr = &text._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &this._firstChar)
				{
					char* smem = ptr3;
					string.wstrcpy(ptr2, smem, length);
				}
				for (int i = 0; i < num; i++)
				{
					ptr2[length + i] = paddingChar;
				}
			}
			return text;
		}

		/// <summary>
		///     Returns a new string in which a specified number of characters in the current instance beginning at a specified position have been deleted.</summary>
		/// <param name="startIndex">The zero-based position to begin deleting characters. </param>
		/// <param name="count">The number of characters to delete. </param>
		/// <returns>A new string that is equivalent to this instance except for the removed characters.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="startIndex" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="startIndex" /> plus <paramref name="count" /> specify a position outside this instance. </exception>
		// Token: 0x0600089B RID: 2203 RVA: 0x000271AC File Offset: 0x000253AC
		public unsafe string Remove(int startIndex, int count)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			int length = this.Length;
			if (count > length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Index and count must refer to a location within the string.");
			}
			if (count == 0)
			{
				return this;
			}
			int num = length - count;
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &text._firstChar)
				{
					char* ptr4 = ptr3;
					string.wstrcpy(ptr4, ptr2, startIndex);
					string.wstrcpy(ptr4 + startIndex, ptr2 + startIndex + count, num - startIndex);
				}
			}
			return text;
		}

		/// <summary>
		///     Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.</summary>
		/// <param name="startIndex">The zero-based position to begin deleting characters. </param>
		/// <returns>A new string that is equivalent to this string except for the removed characters.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is less than zero.-or- 
		///         <paramref name="startIndex" /> specifies a position that is not within this string. </exception>
		// Token: 0x0600089C RID: 2204 RVA: 0x00027252 File Offset: 0x00025452
		public string Remove(int startIndex)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (startIndex >= this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "startIndex must be less than length of string.");
			}
			return this.Substring(0, startIndex);
		}

		/// <summary>Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.</summary>
		/// <param name="oldChar">The Unicode character to be replaced. </param>
		/// <param name="newChar">The Unicode character to replace all occurrences of <paramref name="oldChar" />. </param>
		/// <returns>A string that is equivalent to this instance except that all instances of <paramref name="oldChar" /> are replaced with <paramref name="newChar" />. If <paramref name="oldChar" /> is not found in the current instance, the method returns the current instance unchanged. </returns>
		// Token: 0x0600089D RID: 2205 RVA: 0x0002728C File Offset: 0x0002548C
		public unsafe string Replace(char oldChar, char newChar)
		{
			if (oldChar == newChar)
			{
				return this;
			}
			int num = this.Length;
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				while (num > 0 && *ptr2 != oldChar)
				{
					num--;
					ptr2++;
				}
			}
			if (num == 0)
			{
				return this;
			}
			string text = string.FastAllocateString(this.Length);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr3 = ptr;
				fixed (char* ptr4 = &text._firstChar)
				{
					char* ptr5 = ptr4;
					int num2 = this.Length - num;
					if (num2 > 0)
					{
						string.wstrcpy(ptr5, ptr3, num2);
					}
					char* ptr6 = ptr3 + num2;
					char* ptr7 = ptr5 + num2;
					do
					{
						char c = *ptr6;
						if (c == oldChar)
						{
							c = newChar;
						}
						*ptr7 = c;
						num--;
						ptr6++;
						ptr7++;
					}
					while (num > 0);
				}
			}
			return text;
		}

		/// <summary>Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.</summary>
		/// <param name="oldValue">The string to be replaced. </param>
		/// <param name="newValue">The string to replace all occurrences of <paramref name="oldValue" />. </param>
		/// <returns>A string that is equivalent to the current string except that all instances of <paramref name="oldValue" /> are replaced with <paramref name="newValue" />. If <paramref name="oldValue" /> is not found in the current instance, the method returns the current instance unchanged. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="oldValue" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="oldValue" /> is the empty string (""). </exception>
		// Token: 0x0600089E RID: 2206 RVA: 0x0002734C File Offset: 0x0002554C
		public unsafe string Replace(string oldValue, string newValue)
		{
			if (oldValue == null)
			{
				throw new ArgumentNullException("oldValue");
			}
			if (oldValue.Length == 0)
			{
				throw new ArgumentException("String cannot be of zero length.", "oldValue");
			}
			if (newValue == null)
			{
				newValue = string.Empty;
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				int i = 0;
				int num = this.Length - oldValue.Length;
				IL_B6:
				while (i <= num)
				{
					char* ptr3 = ptr2 + i;
					for (int j = 0; j < oldValue.Length; j++)
					{
						if (ptr3[j] != oldValue[j])
						{
							i++;
							goto IL_B6;
						}
					}
					valueListBuilder.Append(i);
					i += oldValue.Length;
				}
			}
			if (valueListBuilder.Length == 0)
			{
				return this;
			}
			string result = this.ReplaceHelper(oldValue.Length, newValue, valueListBuilder.AsSpan());
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00027440 File Offset: 0x00025640
		private unsafe string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
		{
			long num = (long)this.Length + (long)(newValue.Length - oldValueLength) * (long)indices.Length;
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			string text = string.FastAllocateString((int)num);
			Span<char> span = new Span<char>(text.GetRawStringData(), text.Length);
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < indices.Length; i++)
			{
				int num4 = *indices[i];
				int num5 = num4 - num2;
				if (num5 != 0)
				{
					this.AsSpan(num2, num5).CopyTo(span.Slice(num3));
					num3 += num5;
				}
				num2 = num4 + oldValueLength;
				newValue.AsSpan().CopyTo(span.Slice(num3));
				num3 += newValue.Length;
			}
			this.AsSpan(num2).CopyTo(span.Slice(num3));
			return text;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00027517 File Offset: 0x00025717
		public string[] Split(char separator, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(new ReadOnlySpan<char>(ref separator, 1), int.MaxValue, options);
		}

		/// <summary>Splits a string into substrings that are based on the characters in an array. </summary>
		/// <param name="separator">A character array that delimits the substrings in this string, an empty array that contains no delimiters, or <see langword="null" />. </param>
		/// <returns>An array whose elements contain the substrings from this instance that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		// Token: 0x060008A1 RID: 2209 RVA: 0x0002752D File Offset: 0x0002572D
		public string[] Split(params char[] separator)
		{
			return this.SplitInternal(separator, int.MaxValue, StringSplitOptions.None);
		}

		/// <summary>Splits a string into substrings based on the characters in an array. You can specify whether the substrings include empty array elements.</summary>
		/// <param name="separator">A character array that delimits the substrings in this string, an empty array that contains no delimiters, or <see langword="null" />. </param>
		/// <param name="options">
		///       <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
		// Token: 0x060008A2 RID: 2210 RVA: 0x00027541 File Offset: 0x00025741
		public string[] Split(char[] separator, StringSplitOptions options)
		{
			return this.SplitInternal(separator, int.MaxValue, options);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00027558 File Offset: 0x00025758
		private unsafe string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (options < StringSplitOptions.None || options > StringSplitOptions.RemoveEmptyEntries)
			{
				throw new ArgumentException(SR.Format("Illegal enum value: {0}.", options));
			}
			bool flag = options == StringSplitOptions.RemoveEmptyEntries;
			if (count == 0 || (flag && this.Length == 0))
			{
				return Array.Empty<string>();
			}
			if (count == 1)
			{
				return new string[]
				{
					this
				};
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			this.MakeSeparatorList(separators, ref valueListBuilder);
			ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
			if (sepList.Length == 0)
			{
				return new string[]
				{
					this
				};
			}
			string[] result = flag ? this.SplitOmitEmptyEntries(sepList, default(ReadOnlySpan<int>), 1, count) : this.SplitKeepEmptyEntries(sepList, default(ReadOnlySpan<int>), 1, count);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00027631 File Offset: 0x00025831
		public string[] Split(string separator, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(separator ?? string.Empty, null, int.MaxValue, options);
		}

		/// <summary>Splits a string into substrings based on the strings in an array. You can specify whether the substrings include empty array elements.</summary>
		/// <param name="separator">A string array that delimits the substrings in this string, an empty array that contains no delimiters, or <see langword="null" />. </param>
		/// <param name="options">
		///       <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more strings in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
		// Token: 0x060008A5 RID: 2213 RVA: 0x0002764A File Offset: 0x0002584A
		public string[] Split(string[] separator, StringSplitOptions options)
		{
			return this.SplitInternal(null, separator, int.MaxValue, options);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0002765C File Offset: 0x0002585C
		private unsafe string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (options < StringSplitOptions.None || options > StringSplitOptions.RemoveEmptyEntries)
			{
				throw new ArgumentException(SR.Format("Illegal enum value: {0}.", (int)options));
			}
			bool flag = options == StringSplitOptions.RemoveEmptyEntries;
			bool flag2 = separator != null;
			if (!flag2 && (separators == null || separators.Length == 0))
			{
				return this.SplitInternal(null, count, options);
			}
			if (count == 0 || (flag && this.Length == 0))
			{
				return Array.Empty<string>();
			}
			if (count == 1 || (flag2 && separator.Length == 0))
			{
				return new string[]
				{
					this
				};
			}
			if (flag2)
			{
				return this.SplitInternal(separator, count, options);
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			Span<int> initialSpan2 = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder2 = new ValueListBuilder<int>(initialSpan2);
			this.MakeSeparatorList(separators, ref valueListBuilder, ref valueListBuilder2);
			ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
			ReadOnlySpan<int> lengthList = valueListBuilder2.AsSpan();
			if (sepList.Length == 0)
			{
				return new string[]
				{
					this
				};
			}
			string[] result = flag ? this.SplitOmitEmptyEntries(sepList, lengthList, 0, count) : this.SplitKeepEmptyEntries(sepList, lengthList, 0, count);
			valueListBuilder.Dispose();
			valueListBuilder2.Dispose();
			return result;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00027794 File Offset: 0x00025994
		private unsafe string[] SplitInternal(string separator, int count, StringSplitOptions options)
		{
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			this.MakeSeparatorList(separator, ref valueListBuilder);
			ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
			if (sepList.Length == 0)
			{
				return new string[]
				{
					this
				};
			}
			string[] result = (options == StringSplitOptions.RemoveEmptyEntries) ? this.SplitOmitEmptyEntries(sepList, default(ReadOnlySpan<int>), separator.Length, count) : this.SplitKeepEmptyEntries(sepList, default(ReadOnlySpan<int>), separator.Length, count);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0002781C File Offset: 0x00025A1C
		private unsafe string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			int num = 0;
			int num2 = 0;
			count--;
			int num3 = (sepList.Length < count) ? sepList.Length : count;
			string[] array = new string[num3 + 1];
			int num4 = 0;
			while (num4 < num3 && num < this.Length)
			{
				array[num2++] = this.Substring(num, *sepList[num4] - num);
				num = *sepList[num4] + (lengthList.IsEmpty ? defaultLength : (*lengthList[num4]));
				num4++;
			}
			if (num < this.Length && num3 >= 0)
			{
				array[num2] = this.Substring(num);
			}
			else if (num2 == num3)
			{
				array[num2] = string.Empty;
			}
			return array;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000278D0 File Offset: 0x00025AD0
		private unsafe string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			int length = sepList.Length;
			int num = (length < count) ? (length + 1) : count;
			string[] array = new string[num];
			int num2 = 0;
			int num3 = 0;
			int i = 0;
			while (i < length && num2 < this.Length)
			{
				if (*sepList[i] - num2 > 0)
				{
					array[num3++] = this.Substring(num2, *sepList[i] - num2);
				}
				num2 = *sepList[i] + (lengthList.IsEmpty ? defaultLength : (*lengthList[i]));
				if (num3 == count - 1)
				{
					while (i < length - 1)
					{
						if (num2 != *sepList[++i])
						{
							break;
						}
						num2 += (lengthList.IsEmpty ? defaultLength : (*lengthList[i]));
					}
					break;
				}
				i++;
			}
			if (num2 < this.Length)
			{
				array[num3++] = this.Substring(num2);
			}
			string[] array2 = array;
			if (num3 != num)
			{
				array2 = new string[num3];
				for (int j = 0; j < num3; j++)
				{
					array2[j] = array[j];
				}
			}
			return array2;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000279F0 File Offset: 0x00025BF0
		private unsafe void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
		{
			switch (separators.Length)
			{
			case 0:
				for (int i = 0; i < this.Length; i++)
				{
					if (char.IsWhiteSpace(this[i]))
					{
						sepListBuilder.Append(i);
					}
				}
				return;
			case 1:
			{
				char c = (char)(*separators[0]);
				for (int j = 0; j < this.Length; j++)
				{
					if (this[j] == c)
					{
						sepListBuilder.Append(j);
					}
				}
				return;
			}
			case 2:
			{
				char c = (char)(*separators[0]);
				char c2 = (char)(*separators[1]);
				for (int k = 0; k < this.Length; k++)
				{
					char c3 = this[k];
					if (c3 == c || c3 == c2)
					{
						sepListBuilder.Append(k);
					}
				}
				return;
			}
			case 3:
			{
				char c = (char)(*separators[0]);
				char c2 = (char)(*separators[1]);
				char c4 = (char)(*separators[2]);
				for (int l = 0; l < this.Length; l++)
				{
					char c5 = this[l];
					if (c5 == c || c5 == c2 || c5 == c4)
					{
						sepListBuilder.Append(l);
					}
				}
				return;
			}
			default:
			{
				string.ProbabilisticMap probabilisticMap = default(string.ProbabilisticMap);
				uint* charMap = (uint*)(&probabilisticMap);
				string.InitializeProbabilisticMap(charMap, separators);
				for (int m = 0; m < this.Length; m++)
				{
					char c6 = this[m];
					if (string.IsCharBitSet(charMap, (byte)c6) && string.IsCharBitSet(charMap, (byte)(c6 >> 8)) && separators.Contains(c6))
					{
						sepListBuilder.Append(m);
					}
				}
				return;
			}
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00027B7C File Offset: 0x00025D7C
		private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder)
		{
			int length = separator.Length;
			for (int i = 0; i < this.Length; i++)
			{
				if (this[i] == separator[0] && length <= this.Length - i && (length == 1 || this.AsSpan(i, length).SequenceEqual(separator)))
				{
					sepListBuilder.Append(i);
					i += length - 1;
				}
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00027BE4 File Offset: 0x00025DE4
		private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
		{
			int num = separators.Length;
			for (int i = 0; i < this.Length; i++)
			{
				foreach (string text in separators)
				{
					if (!string.IsNullOrEmpty(text))
					{
						int length = text.Length;
						if (this[i] == text[0] && length <= this.Length - i && (length == 1 || this.AsSpan(i, length).SequenceEqual(text)))
						{
							sepListBuilder.Append(i);
							lengthListBuilder.Append(length);
							i += length - 1;
							break;
						}
					}
				}
			}
		}

		/// <summary>Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.</summary>
		/// <param name="startIndex">The zero-based starting character position of a substring in this instance. </param>
		/// <returns>A string that is equivalent to the substring that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is less than zero or greater than the length of this instance. </exception>
		// Token: 0x060008AD RID: 2221 RVA: 0x00027C71 File Offset: 0x00025E71
		public string Substring(int startIndex)
		{
			return this.Substring(startIndex, this.Length - startIndex);
		}

		/// <summary>Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.</summary>
		/// <param name="startIndex">The zero-based starting character position of a substring in this instance. </param>
		/// <param name="length">The number of characters in the substring. </param>
		/// <returns>A string that is equivalent to the substring of length <paramref name="length" /> that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance and <paramref name="length" /> is zero.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> plus <paramref name="length" /> indicates a position not within this instance.-or- 
		///         <paramref name="startIndex" /> or <paramref name="length" /> is less than zero. </exception>
		// Token: 0x060008AE RID: 2222 RVA: 0x00027C84 File Offset: 0x00025E84
		public string Substring(int startIndex, int length)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "startIndex cannot be larger than length of string.");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (startIndex > this.Length - length)
			{
				throw new ArgumentOutOfRangeException("length", "Index and length must refer to a location within the string.");
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (startIndex == 0 && length == this.Length)
			{
				return this;
			}
			return this.InternalSubString(startIndex, length);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00027D0C File Offset: 0x00025F0C
		private unsafe string InternalSubString(int startIndex, int length)
		{
			string text = string.FastAllocateString(length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char* ptr2 = &this._firstChar)
				{
					char* ptr3 = ptr2;
					string.wstrcpy(dmem, ptr3 + startIndex, length);
				}
			}
			return text;
		}

		/// <summary>Returns a copy of this string converted to lowercase.</summary>
		/// <returns>A string in lowercase.</returns>
		// Token: 0x060008B0 RID: 2224 RVA: 0x00027D44 File Offset: 0x00025F44
		public string ToLower()
		{
			return CultureInfo.CurrentCulture.TextInfo.ToLower(this);
		}

		/// <summary>Returns a copy of this string converted to lowercase, using the casing rules of the specified culture.</summary>
		/// <param name="culture">An object that supplies culture-specific casing rules. </param>
		/// <returns>The lowercase equivalent of the current string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />. </exception>
		// Token: 0x060008B1 RID: 2225 RVA: 0x00027D56 File Offset: 0x00025F56
		public string ToLower(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToLower(this);
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> object converted to lowercase using the casing rules of the invariant culture.</summary>
		/// <returns>The lowercase equivalent of the current string.</returns>
		// Token: 0x060008B2 RID: 2226 RVA: 0x00027D72 File Offset: 0x00025F72
		public string ToLowerInvariant()
		{
			return CultureInfo.InvariantCulture.TextInfo.ToLower(this);
		}

		/// <summary>Returns a copy of this string converted to uppercase.</summary>
		/// <returns>The uppercase equivalent of the current string.</returns>
		// Token: 0x060008B3 RID: 2227 RVA: 0x00027D84 File Offset: 0x00025F84
		public string ToUpper()
		{
			return CultureInfo.CurrentCulture.TextInfo.ToUpper(this);
		}

		/// <summary>Returns a copy of this string converted to uppercase, using the casing rules of the specified culture.</summary>
		/// <param name="culture">An object that supplies culture-specific casing rules. </param>
		/// <returns>The uppercase equivalent of the current string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />. </exception>
		// Token: 0x060008B4 RID: 2228 RVA: 0x00027D96 File Offset: 0x00025F96
		public string ToUpper(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToUpper(this);
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> object converted to uppercase using the casing rules of the invariant culture.</summary>
		/// <returns>The uppercase equivalent of the current string.</returns>
		// Token: 0x060008B5 RID: 2229 RVA: 0x00027DB2 File Offset: 0x00025FB2
		public string ToUpperInvariant()
		{
			return CultureInfo.InvariantCulture.TextInfo.ToUpper(this);
		}

		/// <summary>Removes all leading and trailing white-space characters from the current <see cref="T:System.String" /> object.</summary>
		/// <returns>The string that remains after all white-space characters are removed from the start and end of the current string. If no characters can be trimmed from the current instance, the method returns the current instance unchanged. </returns>
		// Token: 0x060008B6 RID: 2230 RVA: 0x00027DC4 File Offset: 0x00025FC4
		public string Trim()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Both);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00027DCD File Offset: 0x00025FCD
		public unsafe string Trim(char trimChar)
		{
			return this.TrimHelper(&trimChar, 1, string.TrimType.Both);
		}

		/// <summary>Removes all leading and trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
		/// <param name="trimChars">An array of Unicode characters to remove, or <see langword="null" />. </param>
		/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the start and end of the current string. If <paramref name="trimChars" /> is <see langword="null" /> or an empty array, white-space characters are removed instead. If no characters can be trimmed from the current instance, the method returns the current instance unchanged.</returns>
		// Token: 0x060008B8 RID: 2232 RVA: 0x00027DDC File Offset: 0x00025FDC
		public unsafe string Trim(params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(string.TrimType.Both);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, string.TrimType.Both);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00027E0E File Offset: 0x0002600E
		public string TrimStart()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Head);
		}

		/// <summary>Removes all leading occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
		/// <param name="trimChars">An array of Unicode characters to remove, or <see langword="null" />. </param>
		/// <returns>The string that remains after all occurrences of characters in the <paramref name="trimChars" /> parameter are removed from the start of the current string. If <paramref name="trimChars" /> is <see langword="null" /> or an empty array, white-space characters are removed instead.</returns>
		// Token: 0x060008BA RID: 2234 RVA: 0x00027E18 File Offset: 0x00026018
		public unsafe string TrimStart(params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(string.TrimType.Head);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, string.TrimType.Head);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00027E4A File Offset: 0x0002604A
		public string TrimEnd()
		{
			return this.TrimWhiteSpaceHelper(string.TrimType.Tail);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00027E53 File Offset: 0x00026053
		public unsafe string TrimEnd(char trimChar)
		{
			return this.TrimHelper(&trimChar, 1, string.TrimType.Tail);
		}

		/// <summary>Removes all trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
		/// <param name="trimChars">An array of Unicode characters to remove, or <see langword="null" />. </param>
		/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the end of the current string. If <paramref name="trimChars" /> is <see langword="null" /> or an empty array, Unicode white-space characters are removed instead. If no characters can be trimmed from the current instance, the method returns the current instance unchanged. </returns>
		// Token: 0x060008BD RID: 2237 RVA: 0x00027E60 File Offset: 0x00026060
		public unsafe string TrimEnd(params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(string.TrimType.Tail);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, string.TrimType.Tail);
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00027E94 File Offset: 0x00026094
		private string TrimWhiteSpaceHelper(string.TrimType trimType)
		{
			int num = this.Length - 1;
			int num2 = 0;
			if (trimType != string.TrimType.Tail)
			{
				num2 = 0;
				while (num2 < this.Length && char.IsWhiteSpace(this[num2]))
				{
					num2++;
				}
			}
			if (trimType != string.TrimType.Head)
			{
				num = this.Length - 1;
				while (num >= num2 && char.IsWhiteSpace(this[num]))
				{
					num--;
				}
			}
			return this.CreateTrimmedString(num2, num);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00027EFC File Offset: 0x000260FC
		private unsafe string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType)
		{
			int i = this.Length - 1;
			int j = 0;
			if (trimType != string.TrimType.Tail)
			{
				for (j = 0; j < this.Length; j++)
				{
					char c = this[j];
					int num = 0;
					while (num < trimCharsLength && trimChars[num] != c)
					{
						num++;
					}
					if (num == trimCharsLength)
					{
						break;
					}
				}
			}
			if (trimType != string.TrimType.Head)
			{
				for (i = this.Length - 1; i >= j; i--)
				{
					char c2 = this[i];
					int num2 = 0;
					while (num2 < trimCharsLength && trimChars[num2] != c2)
					{
						num2++;
					}
					if (num2 == trimCharsLength)
					{
						break;
					}
				}
			}
			return this.CreateTrimmedString(j, i);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00027F98 File Offset: 0x00026198
		private string CreateTrimmedString(int start, int end)
		{
			int num = end - start + 1;
			if (num == this.Length)
			{
				return this;
			}
			if (num != 0)
			{
				return this.InternalSubString(start, num);
			}
			return string.Empty;
		}

		/// <summary>Returns a value indicating whether a specified substring occurs within this string.</summary>
		/// <param name="value">The string to seek. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter occurs within this string, or if <paramref name="value" /> is the empty string (""); otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x060008C1 RID: 2241 RVA: 0x00027FC7 File Offset: 0x000261C7
		public bool Contains(string value)
		{
			return this.IndexOf(value, StringComparison.Ordinal) >= 0;
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified Unicode character in this string.</summary>
		/// <param name="value">A Unicode character to seek. </param>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
		// Token: 0x060008C2 RID: 2242 RVA: 0x00027FD7 File Offset: 0x000261D7
		public int IndexOf(char value)
		{
			return SpanHelpers.IndexOf(ref this._firstChar, value, this.Length);
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified Unicode character in this string. The search starts at a specified character position.</summary>
		/// <param name="value">A Unicode character to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <returns>The zero-based index position of <paramref name="value" /> from the start of the string if that character is found, or -1 if it is not.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is less than 0 (zero) or greater than the length of the string. </exception>
		// Token: 0x060008C3 RID: 2243 RVA: 0x00027FEB File Offset: 0x000261EB
		public int IndexOf(char value, int startIndex)
		{
			return this.IndexOf(value, startIndex, this.Length - startIndex);
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified character in this instance. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <param name="value">A Unicode character to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <returns>The zero-based index position of <paramref name="value" /> from the start of the string if that character is found, or -1 if it is not.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- 
		///         <paramref name="startIndex" /> is greater than the length of this string.-or-
		///         <paramref name="count" /> is greater than the length of this string minus <paramref name="startIndex" />.</exception>
		// Token: 0x060008C4 RID: 2244 RVA: 0x00028000 File Offset: 0x00026200
		public int IndexOf(char value, int startIndex, int count)
		{
			if (startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > this.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			int num = SpanHelpers.IndexOf(Unsafe.Add<char>(ref this._firstChar, startIndex), value, count);
			if (num != -1)
			{
				return num + startIndex;
			}
			return num;
		}

		/// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.</summary>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="anyOf" /> is <see langword="null" />. </exception>
		// Token: 0x060008C5 RID: 2245 RVA: 0x0002805E File Offset: 0x0002625E
		public int IndexOfAny(char[] anyOf)
		{
			return this.IndexOfAny(anyOf, 0, this.Length);
		}

		/// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position.</summary>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="anyOf" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is negative.-or- 
		///         <paramref name="startIndex" /> is greater than the number of characters in this instance. </exception>
		// Token: 0x060008C6 RID: 2246 RVA: 0x0002806E File Offset: 0x0002626E
		public int IndexOfAny(char[] anyOf, int startIndex)
		{
			return this.IndexOfAny(anyOf, startIndex, this.Length - startIndex);
		}

		/// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="anyOf" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- 
		///         <paramref name="count" /> + <paramref name="startIndex" /> is greater than the number of characters in this instance. </exception>
		// Token: 0x060008C7 RID: 2247 RVA: 0x00028080 File Offset: 0x00026280
		public int IndexOfAny(char[] anyOf, int startIndex, int count)
		{
			if (anyOf == null)
			{
				throw new ArgumentNullException("anyOf");
			}
			if (startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > this.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			if (anyOf.Length == 2)
			{
				return this.IndexOfAny(anyOf[0], anyOf[1], startIndex, count);
			}
			if (anyOf.Length == 3)
			{
				return this.IndexOfAny(anyOf[0], anyOf[1], anyOf[2], startIndex, count);
			}
			if (anyOf.Length > 3)
			{
				return this.IndexOfCharArray(anyOf, startIndex, count);
			}
			if (anyOf.Length == 1)
			{
				return this.IndexOf(anyOf[0], startIndex, count);
			}
			return -1;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00028120 File Offset: 0x00026320
		private unsafe int IndexOfAny(char value1, char value2, int startIndex, int count)
		{
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					char c = *ptr3;
					if (c == value1 || c == value2)
					{
						return (int)((long)(ptr3 - ptr2));
					}
					c = ptr3[1];
					if (c == value1 || c == value2)
					{
						if (count != 1)
						{
							return (int)((long)(ptr3 - ptr2)) + 1;
						}
						return -1;
					}
					else
					{
						ptr3 += 2;
						count -= 2;
					}
				}
				return -1;
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00028184 File Offset: 0x00026384
		private unsafe int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
		{
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					char c = *ptr3;
					if (c == value1 || c == value2 || c == value3)
					{
						return (int)((long)(ptr3 - ptr2));
					}
					ptr3++;
					count--;
				}
				return -1;
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000281CC File Offset: 0x000263CC
		private unsafe int IndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			string.ProbabilisticMap probabilisticMap = default(string.ProbabilisticMap);
			uint* charMap = (uint*)(&probabilisticMap);
			string.InitializeProbabilisticMap(charMap, anyOf);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					int num = (int)(*ptr3);
					if (string.IsCharBitSet(charMap, (byte)num) && string.IsCharBitSet(charMap, (byte)(num >> 8)) && string.ArrayContains((char)num, anyOf))
					{
						return (int)((long)(ptr3 - ptr2));
					}
					count--;
					ptr3++;
				}
				return -1;
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00028248 File Offset: 0x00026448
		private unsafe static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf)
		{
			bool flag = false;
			for (int i = 0; i < anyOf.Length; i++)
			{
				int num = (int)(*anyOf[i]);
				string.SetCharBit(charMap, (byte)num);
				num >>= 8;
				if (num == 0)
				{
					flag = true;
				}
				else
				{
					string.SetCharBit(charMap, (byte)num);
				}
			}
			if (flag)
			{
				*charMap |= 1U;
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002829C File Offset: 0x0002649C
		private static bool ArrayContains(char searchChar, char[] anyOf)
		{
			for (int i = 0; i < anyOf.Length; i++)
			{
				if (anyOf[i] == searchChar)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000282C0 File Offset: 0x000264C0
		private unsafe static bool IsCharBitSet(uint* charMap, byte value)
		{
			return (charMap[value & 7] & 1U << (value >> 3)) > 0U;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000282D7 File Offset: 0x000264D7
		private unsafe static void SetCharBit(uint* charMap, byte value)
		{
			charMap[value & 7] |= 1U << (value >> 3);
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified string in this instance.</summary>
		/// <param name="value">The string to seek. </param>
		/// <returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x060008CF RID: 2255 RVA: 0x000282ED File Offset: 0x000264ED
		public int IndexOf(string value)
		{
			return this.IndexOf(value, StringComparison.CurrentCulture);
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position.</summary>
		/// <param name="value">The string to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <returns>The zero-based index position of <paramref name="value" /> from the start of the current instance if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is less than 0 (zero) or greater than the length of this string.</exception>
		// Token: 0x060008D0 RID: 2256 RVA: 0x000282F7 File Offset: 0x000264F7
		public int IndexOf(string value, int startIndex)
		{
			return this.IndexOf(value, startIndex, StringComparison.CurrentCulture);
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary>
		/// <param name="value">The string to seek. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param>
		/// <returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		// Token: 0x060008D1 RID: 2257 RVA: 0x00028302 File Offset: 0x00026502
		public int IndexOf(string value, StringComparison comparisonType)
		{
			return this.IndexOf(value, 0, this.Length, comparisonType);
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string and the type of search to use for the specified string.</summary>
		/// <param name="value">The string to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param>
		/// <returns>The zero-based index position of the <paramref name="value" /> parameter from the start of the current instance if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is less than 0 (zero) or greater than the length of this string. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		// Token: 0x060008D2 RID: 2258 RVA: 0x00028313 File Offset: 0x00026513
		public int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			return this.IndexOf(value, startIndex, this.Length - startIndex, comparisonType);
		}

		/// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.</summary>
		/// <param name="value">The string to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param>
		/// <returns>The zero-based index position of the <paramref name="value" /> parameter from the start of the current instance if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- 
		///         <paramref name="startIndex" /> is greater than the length of this instance.-or-
		///         <paramref name="count" /> is greater than the length of this string minus <paramref name="startIndex" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		// Token: 0x060008D3 RID: 2259 RVA: 0x00028328 File Offset: 0x00026528
		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0 || startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || startIndex > this.Length - count)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CompareInfo.Invariant.IndexOf(this, value, startIndex, count, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return CompareInfo.Invariant.IndexOfOrdinal(this, value, startIndex, count, false);
			case StringComparison.OrdinalIgnoreCase:
				return CompareInfo.Invariant.IndexOfOrdinal(this, value, startIndex, count, true);
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.</summary>
		/// <param name="value">The Unicode character to seek. </param>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
		// Token: 0x060008D4 RID: 2260 RVA: 0x00028419 File Offset: 0x00026619
		public int LastIndexOf(char value)
		{
			return SpanHelpers.LastIndexOf(ref this._firstChar, value, this.Length);
		}

		/// <summary>Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string.</summary>
		/// <param name="value">The Unicode character to seek. </param>
		/// <param name="startIndex">The starting position of the search. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than or equal to the length of this instance.</exception>
		// Token: 0x060008D5 RID: 2261 RVA: 0x0002842D File Offset: 0x0002662D
		public int LastIndexOf(char value, int startIndex)
		{
			return this.LastIndexOf(value, startIndex, startIndex + 1);
		}

		/// <summary>Reports the zero-based index position of the last occurrence of the specified Unicode character in a substring within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.</summary>
		/// <param name="value">The Unicode character to seek. </param>
		/// <param name="startIndex">The starting position of the search. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than or equal to the length of this instance.-or-
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> - <paramref name="count" /> + 1 is less than zero.</exception>
		// Token: 0x060008D6 RID: 2262 RVA: 0x0002843C File Offset: 0x0002663C
		public int LastIndexOf(char value, int startIndex, int count)
		{
			if (this.Length == 0)
			{
				return -1;
			}
			if (startIndex >= this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > startIndex + 1)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			int num = startIndex + 1 - count;
			int num2 = SpanHelpers.LastIndexOf(Unsafe.Add<char>(ref this._firstChar, num), value, count);
			if (num2 != -1)
			{
				return num2 + num;
			}
			return num2;
		}

		/// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.</summary>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="anyOf" /> is <see langword="null" />. </exception>
		// Token: 0x060008D7 RID: 2263 RVA: 0x000284A5 File Offset: 0x000266A5
		public int LastIndexOfAny(char[] anyOf)
		{
			return this.LastIndexOfAny(anyOf, this.Length - 1, this.Length);
		}

		/// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.</summary>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="anyOf" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- 
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> minus <paramref name="count" /> + 1 is less than zero. </exception>
		// Token: 0x060008D8 RID: 2264 RVA: 0x000284BC File Offset: 0x000266BC
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
		{
			if (anyOf == null)
			{
				throw new ArgumentNullException("anyOf");
			}
			if (this.Length == 0)
			{
				return -1;
			}
			if (startIndex >= this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || count - 1 > startIndex)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			if (anyOf.Length > 1)
			{
				return this.LastIndexOfCharArray(anyOf, startIndex, count);
			}
			if (anyOf.Length == 1)
			{
				return this.LastIndexOf(anyOf[0], startIndex, count);
			}
			return -1;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00028538 File Offset: 0x00026738
		private unsafe int LastIndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			string.ProbabilisticMap probabilisticMap = default(string.ProbabilisticMap);
			uint* charMap = (uint*)(&probabilisticMap);
			string.InitializeProbabilisticMap(charMap, anyOf);
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + startIndex;
				while (count > 0)
				{
					int num = (int)(*ptr3);
					if (string.IsCharBitSet(charMap, (byte)num) && string.IsCharBitSet(charMap, (byte)(num >> 8)) && string.ArrayContains((char)num, anyOf))
					{
						return (int)((long)(ptr3 - ptr2));
					}
					count--;
					ptr3--;
				}
				return -1;
			}
		}

		/// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance.</summary>
		/// <param name="value">The string to seek. </param>
		/// <returns>The zero-based starting index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x060008DA RID: 2266 RVA: 0x000285B2 File Offset: 0x000267B2
		public int LastIndexOf(string value)
		{
			return this.LastIndexOf(value, this.Length - 1, this.Length, StringComparison.CurrentCulture);
		}

		/// <summary>Reports the zero-based index of the last occurrence of a specified string within the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary>
		/// <param name="value">The string to seek. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param>
		/// <returns>The zero-based starting index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		// Token: 0x060008DB RID: 2267 RVA: 0x000285CA File Offset: 0x000267CA
		public int LastIndexOf(string value, StringComparison comparisonType)
		{
			return this.LastIndexOf(value, this.Length - 1, this.Length, comparisonType);
		}

		/// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for the specified number of character positions. A parameter specifies the type of comparison to perform when searching for the specified string.</summary>
		/// <param name="value">The string to seek. </param>
		/// <param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param>
		/// <returns>The zero-based starting index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the smaller of <paramref name="startIndex" /> and the last index position in this instance.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is negative.-or-
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is negative.-or- 
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is greater than the length of this instance.-or-
		///         The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> + 1 - <paramref name="count" /> specifies a position that is not within this instance. -or-The current instance equals <see cref="F:System.String.Empty" /> and <paramref name="start" /> is less than -1 or greater than zero. -or-The current instance equals <see cref="F:System.String.Empty" /> and <paramref name="count" /> is greater than 1. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		// Token: 0x060008DC RID: 2268 RVA: 0x000285E4 File Offset: 0x000267E4
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.Length == 0 && (startIndex == -1 || startIndex == 0))
			{
				if (value.Length != 0)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (startIndex < 0 || startIndex > this.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (startIndex == this.Length)
				{
					startIndex--;
					if (count > 0)
					{
						count--;
					}
				}
				if (count < 0 || startIndex - count + 1 < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				if (value.Length == 0)
				{
					return startIndex;
				}
				switch (comparisonType)
				{
				case StringComparison.CurrentCulture:
					return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.None);
				case StringComparison.CurrentCultureIgnoreCase:
					return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
				case StringComparison.InvariantCulture:
					return CompareInfo.Invariant.LastIndexOf(this, value, startIndex, count, CompareOptions.None);
				case StringComparison.InvariantCultureIgnoreCase:
					return CompareInfo.Invariant.LastIndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
				case StringComparison.Ordinal:
					return CompareInfo.Invariant.LastIndexOfOrdinal(this, value, startIndex, count, false);
				case StringComparison.OrdinalIgnoreCase:
					return CompareInfo.Invariant.LastIndexOfOrdinal(this, value, startIndex, count, true);
				default:
					throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
				}
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters.</summary>
		/// <param name="value">An array of Unicode characters. </param>
		// Token: 0x060008DD RID: 2269
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char[] value);

		// Token: 0x060008DE RID: 2270 RVA: 0x00028710 File Offset: 0x00026910
		private unsafe static string Ctor(char[] value)
		{
			if (value == null || value.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(value.Length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char[] array = value)
				{
					char* smem;
					if (value == null || array.Length == 0)
					{
						smem = null;
					}
					else
					{
						smem = &array[0];
					}
					string.wstrcpy(dmem, smem, value.Length);
					ptr = null;
				}
				return text;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters, a starting character position within that array, and a length.</summary>
		/// <param name="value">An array of Unicode characters. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or- The sum of <paramref name="startIndex" /> and <paramref name="length" /> is greater than the number of elements in <paramref name="value" />. </exception>
		// Token: 0x060008DF RID: 2271
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char[] value, int startIndex, int length);

		// Token: 0x060008E0 RID: 2272 RVA: 0x00028764 File Offset: 0x00026964
		private unsafe static string Ctor(char[] value, int startIndex, int length)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (startIndex > value.Length - length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char[] array = value)
				{
					char* ptr2;
					if (value == null || array.Length == 0)
					{
						ptr2 = null;
					}
					else
					{
						ptr2 = &array[0];
					}
					string.wstrcpy(dmem, ptr2 + startIndex, length);
					ptr = null;
				}
				return text;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of Unicode characters, a starting character position within that array, and a length.</summary>
		/// <param name="value">A pointer to an array of Unicode characters. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> or <paramref name="length" /> is less than zero, <paramref name="value" /> + <paramref name="startIndex" /> cause a pointer overflow, or the current process does not have read access to all the addressed characters.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> specifies an array that contains an invalid Unicode character, or <paramref name="value" /> + <paramref name="startIndex" /> specifies an address less than 64000.</exception>
		// Token: 0x060008E1 RID: 2273
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(char* value, int startIndex, int length);

		// Token: 0x060008E2 RID: 2274 RVA: 0x00028800 File Offset: 0x00026A00
		private unsafe static string Ctor(char* ptr, int startIndex, int length)
		{
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			char* ptr2 = ptr + startIndex;
			if (ptr2 < ptr)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Pointer startIndex and length do not refer to a valid string.");
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (ptr == null)
			{
				throw new ArgumentOutOfRangeException("ptr", "Pointer startIndex and length do not refer to a valid string.");
			}
			string text = string.FastAllocateString(length);
			fixed (char* ptr3 = &text._firstChar)
			{
				string.wstrcpy(ptr3, ptr2, length);
			}
			return text;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting position within that array, and a length.</summary>
		/// <param name="value">A pointer to an array of 8-bit signed integers. The integers are interpreted using the current system code page encoding (that is, the encoding specified by <see cref="P:System.Text.Encoding.Default" />). </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> or <paramref name="length" /> is less than zero. -or-The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed. -or-The length of the new string to initialize is too large to allocate.</exception>
		/// <exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.-or- A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded in ANSI.</exception>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
		// Token: 0x060008E3 RID: 2275
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value, int startIndex, int length);

		// Token: 0x060008E4 RID: 2276 RVA: 0x00028888 File Offset: 0x00026A88
		private unsafe static string Ctor(sbyte* value, int startIndex, int length)
		{
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
			}
			if (value == null)
			{
				if (length == 0)
				{
					return string.Empty;
				}
				throw new ArgumentNullException("value");
			}
			else
			{
				byte* ptr = (byte*)(value + startIndex);
				if (ptr < (byte*)value)
				{
					throw new ArgumentOutOfRangeException("value", "Pointer startIndex and length do not refer to a valid string.");
				}
				return string.CreateStringForSByteConstructor(ptr, length);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000288F5 File Offset: 0x00026AF5
		private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
		{
			if (numBytes == 0)
			{
				return string.Empty;
			}
			return Encoding.UTF8.GetString(pb, numBytes);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting position within that array, a length, and an <see cref="T:System.Text.Encoding" /> object.</summary>
		/// <param name="value">A pointer to an array of 8-bit signed integers. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <param name="enc">An object that specifies how the array referenced by <paramref name="value" /> is encoded. If <paramref name="enc" /> is <see langword="null" />, ANSI encoding is assumed.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> or <paramref name="length" /> is less than zero. -or-The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed. -or-The length of the new string to initialize is too large to allocate.</exception>
		/// <exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.-or- A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded as specified by <paramref name="enc" />. </exception>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
		// Token: 0x060008E6 RID: 2278
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value, int startIndex, int length, Encoding enc);

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002890C File Offset: 0x00026B0C
		private unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
		{
			if (enc == null)
			{
				return new string(value, startIndex, length);
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Non-negative number required.");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "StartIndex cannot be less than zero.");
			}
			if (value == null)
			{
				if (length == 0)
				{
					return string.Empty;
				}
				throw new ArgumentNullException("value");
			}
			else
			{
				byte* ptr = (byte*)(value + startIndex);
				if (ptr < (byte*)value)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Pointer startIndex and length do not refer to a valid string.");
				}
				return enc.GetString(new ReadOnlySpan<byte>((void*)ptr, length));
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified Unicode character repeated a specified number of times.</summary>
		/// <param name="c">A Unicode character. </param>
		/// <param name="count">The number of times <paramref name="c" /> occurs. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero. </exception>
		// Token: 0x060008E8 RID: 2280
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char c, int count);

		// Token: 0x060008E9 RID: 2281 RVA: 0x0002898C File Offset: 0x00026B8C
		private unsafe static string Ctor(char c, int count)
		{
			if (count > 0)
			{
				string text = string.FastAllocateString(count);
				if (c != '\0')
				{
					fixed (char* ptr = &text._firstChar)
					{
						uint* ptr2 = (uint*)ptr;
						uint num = (uint)((uint)c << 16 | c);
						uint* ptr3 = ptr2;
						if (count >= 4)
						{
							count -= 4;
							do
							{
								*ptr3 = num;
								ptr3[1] = num;
								ptr3 += 2;
								count -= 4;
							}
							while (count >= 0);
						}
						if ((count & 2) != 0)
						{
							*ptr3 = num;
							ptr3++;
						}
						if ((count & 1) != 0)
						{
							*(short*)ptr3 = (short)c;
						}
					}
				}
				return text;
			}
			if (count == 0)
			{
				return string.Empty;
			}
			throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
		}

		// Token: 0x060008EA RID: 2282
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(ReadOnlySpan<char> value);

		// Token: 0x060008EB RID: 2283 RVA: 0x00028A0C File Offset: 0x00026C0C
		private unsafe static string Ctor(ReadOnlySpan<char> value)
		{
			if (value.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(value.Length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char* reference = MemoryMarshal.GetReference<char>(value))
				{
					char* smem = reference;
					string.wstrcpy(dmem, smem, value.Length);
					ptr = null;
				}
				return text;
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00028A5C File Offset: 0x00026C5C
		public static string Create<TState>(int length, TState state, SpanAction<char, TState> action)
		{
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			if (length > 0)
			{
				string text = string.FastAllocateString(length);
				action(new Span<char>(text.GetRawStringData(), length), state);
				return text;
			}
			if (length == 0)
			{
				return string.Empty;
			}
			throw new ArgumentOutOfRangeException("length");
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00028AAC File Offset: 0x00026CAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator ReadOnlySpan<char>(string value)
		{
			if (value == null)
			{
				return default(ReadOnlySpan<char>);
			}
			return new ReadOnlySpan<char>(value.GetRawStringData(), value.Length);
		}

		/// <summary>Returns a reference to this instance of <see cref="T:System.String" />.</summary>
		/// <returns>This instance of <see cref="T:System.String" />.</returns>
		// Token: 0x060008EE RID: 2286 RVA: 0x0000245A File Offset: 0x0000065A
		public object Clone()
		{
			return this;
		}

		/// <summary>Creates a new instance of <see cref="T:System.String" /> with the same value as a specified <see cref="T:System.String" />.</summary>
		/// <param name="str">The string to copy. </param>
		/// <returns>A new string with the same value as <paramref name="str" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="str" /> is <see langword="null" />. </exception>
		// Token: 0x060008EF RID: 2287 RVA: 0x00028AD8 File Offset: 0x00026CD8
		public unsafe static string Copy(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			string text = string.FastAllocateString(str.Length);
			fixed (char* ptr = &text._firstChar)
			{
				char* dmem = ptr;
				fixed (char* ptr2 = &str._firstChar)
				{
					char* smem = ptr2;
					string.wstrcpy(dmem, smem, str.Length);
					ptr = null;
				}
				return text;
			}
		}

		/// <summary>Copies a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters.</summary>
		/// <param name="sourceIndex">The index of the first character in this instance to copy. </param>
		/// <param name="destination">An array of Unicode characters to which characters in this instance are copied. </param>
		/// <param name="destinationIndex">The index in <paramref name="destination" /> at which the copy operation begins. </param>
		/// <param name="count">The number of characters in this instance to copy to <paramref name="destination" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destination" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="sourceIndex" />, <paramref name="destinationIndex" />, or <paramref name="count" /> is negative -or- 
		///         <paramref name="sourceIndex" /> does not identify a position in the current instance. -or-
		///         <paramref name="destinationIndex" /> does not identify a valid index in the <paramref name="destination" /> array. -or-
		///         <paramref name="count" /> is greater than the length of the substring from <paramref name="startIndex" /> to the end of this instance -or- 
		///         <paramref name="count" /> is greater than the length of the subarray from <paramref name="destinationIndex" /> to the end of the <paramref name="destination" /> array. </exception>
		// Token: 0x060008F0 RID: 2288 RVA: 0x00028B24 File Offset: 0x00026D24
		public unsafe void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			if (destination == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
			}
			if (sourceIndex < 0)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > this.Length - sourceIndex)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", "Index and count must refer to a location within the string.");
			}
			if (destinationIndex > destination.Length - count || destinationIndex < 0)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", "Index and count must refer to a location within the string.");
			}
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char[] array = destination)
				{
					char* ptr3;
					if (destination == null || array.Length == 0)
					{
						ptr3 = null;
					}
					else
					{
						ptr3 = &array[0];
					}
					string.wstrcpy(ptr3 + destinationIndex, ptr2 + sourceIndex, count);
					ptr = null;
				}
				return;
			}
		}

		/// <summary>Copies the characters in this instance to a Unicode character array. </summary>
		/// <returns>A Unicode character array whose elements are the individual characters of this instance. If this instance is an empty string, the returned array is empty and has a zero length.</returns>
		// Token: 0x060008F1 RID: 2289 RVA: 0x00028BDC File Offset: 0x00026DDC
		public unsafe char[] ToCharArray()
		{
			if (this.Length == 0)
			{
				return Array.Empty<char>();
			}
			char[] array = new char[this.Length];
			fixed (char* ptr = &this._firstChar)
			{
				char* smem = ptr;
				fixed (char* ptr2 = &array[0])
				{
					string.wstrcpy(ptr2, smem, this.Length);
					ptr = null;
				}
				return array;
			}
		}

		/// <summary>Indicates whether the specified string is <see langword="null" /> or an <see cref="F:System.String.Empty" /> string.</summary>
		/// <param name="value">The string to test. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter is <see langword="null" /> or an empty string (""); otherwise, <see langword="false" />.</returns>
		// Token: 0x060008F2 RID: 2290 RVA: 0x00028C28 File Offset: 0x00026E28
		[NonVersionable]
		public static bool IsNullOrEmpty(string value)
		{
			return value == null || 0 >= value.Length;
		}

		/// <summary>Indicates whether a specified string is <see langword="null" />, empty, or consists only of white-space characters.</summary>
		/// <param name="value">The string to test.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, or if <paramref name="value" /> consists exclusively of white-space characters. </returns>
		// Token: 0x060008F3 RID: 2291 RVA: 0x00028C3C File Offset: 0x00026E3C
		public static bool IsNullOrWhiteSpace(string value)
		{
			if (value == null)
			{
				return true;
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (!char.IsWhiteSpace(value[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00028C70 File Offset: 0x00026E70
		internal ref char GetRawStringData()
		{
			return ref this._firstChar;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00028C78 File Offset: 0x00026E78
		internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
		{
			int charCount = encoding.GetCharCount(bytes, byteLength, null);
			if (charCount == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(charCount);
			fixed (char* ptr = &text._firstChar)
			{
				char* chars = ptr;
				encoding.GetChars(bytes, byteLength, chars, charCount, null);
			}
			return text;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00028CB7 File Offset: 0x00026EB7
		internal static string CreateFromChar(char c)
		{
			string text = string.FastAllocateString(1);
			text._firstChar = c;
			return text;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00028CC6 File Offset: 0x00026EC6
		internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
			Buffer.Memmove((byte*)dmem, (byte*)smem, (uint)(charCount * 2));
		}

		/// <summary>Returns this instance of <see cref="T:System.String" />; no actual conversion is performed.</summary>
		/// <returns>The current string.</returns>
		// Token: 0x060008F8 RID: 2296 RVA: 0x0000245A File Offset: 0x0000065A
		public override string ToString()
		{
			return this;
		}

		/// <summary>Returns this instance of <see cref="T:System.String" />; no actual conversion is performed.</summary>
		/// <param name="provider">(Reserved) An object that supplies culture-specific formatting information. </param>
		/// <returns>The current string.</returns>
		// Token: 0x060008F9 RID: 2297 RVA: 0x0000245A File Offset: 0x0000065A
		public string ToString(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00028CD2 File Offset: 0x00026ED2
		IEnumerator<char> IEnumerable<char>.GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		/// <summary>Returns an enumerator that iterates through the current <see cref="T:System.String" /> object. </summary>
		/// <returns>An enumerator that can be used to iterate through the current string.</returns>
		// Token: 0x060008FB RID: 2299 RVA: 0x00028CD2 File Offset: 0x00026ED2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00028CDC File Offset: 0x00026EDC
		internal unsafe static int wcslen(char* ptr)
		{
			char* ptr2 = ptr;
			int num = IntPtr.Size - 1;
			while ((ptr2 & (uint)num) != 0U)
			{
				if (*ptr2 != '\0')
				{
					ptr2++;
				}
				else
				{
					IL_6E:
					int num2 = (int)((long)(ptr2 - ptr));
					if (ptr + num2 != ptr2)
					{
						throw new ArgumentException("The string must be null-terminated.");
					}
					return num2;
				}
			}
			for (;;)
			{
				if ((*(long*)ptr2 + 9223231297218904063L | 9223231297218904063L) == -1L)
				{
					ptr2 += 4;
				}
				else
				{
					if (*ptr2 == '\0')
					{
						goto IL_6E;
					}
					if (ptr2[1] == '\0')
					{
						goto IL_6A;
					}
					if (ptr2[2] == '\0')
					{
						goto IL_66;
					}
					if (ptr2[3] == '\0')
					{
						break;
					}
					ptr2 += 4;
				}
			}
			ptr2++;
			IL_66:
			ptr2++;
			IL_6A:
			ptr2++;
			goto IL_6E;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for class <see cref="T:System.String" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.String" />.</returns>
		// Token: 0x060008FD RID: 2301 RVA: 0x00028D74 File Offset: 0x00026F74
		public TypeCode GetTypeCode()
		{
			return TypeCode.String;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>
		///     <see langword="true" /> if the value of the current string is <see cref="F:System.Boolean.TrueString" />; <see langword="false" /> if the value of the current string is <see cref="F:System.Boolean.FalseString" />.</returns>
		/// <exception cref="T:System.FormatException">The value of the current string is not <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
		// Token: 0x060008FE RID: 2302 RVA: 0x00028D78 File Offset: 0x00026F78
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The character at index 0 in the current <see cref="T:System.String" /> object.</returns>
		// Token: 0x060008FF RID: 2303 RVA: 0x00028D81 File Offset: 0x00026F81
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x06000900 RID: 2304 RVA: 0x00028D8A File Offset: 0x00026F8A
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
		// Token: 0x06000901 RID: 2305 RVA: 0x00028D93 File Offset: 0x00026F93
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
		// Token: 0x06000902 RID: 2306 RVA: 0x00028D9C File Offset: 0x00026F9C
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.UInt16.MaxValue" /> or less than <see cref="F:System.UInt16.MinValue" />.</exception>
		// Token: 0x06000903 RID: 2307 RVA: 0x00028DA5 File Offset: 0x00026FA5
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		// Token: 0x06000904 RID: 2308 RVA: 0x00028DAE File Offset: 0x00026FAE
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater <see cref="F:System.UInt32.MaxValue" /> or less than <see cref="F:System.UInt32.MinValue" /></exception>
		// Token: 0x06000905 RID: 2309 RVA: 0x00028DB7 File Offset: 0x00026FB7
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		// Token: 0x06000906 RID: 2310 RVA: 0x00028DC0 File Offset: 0x00026FC0
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		// Token: 0x06000907 RID: 2311 RVA: 0x00028DC9 File Offset: 0x00026FC9
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		// Token: 0x06000908 RID: 2312 RVA: 0x00028DD2 File Offset: 0x00026FD2
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
		// Token: 0x06000909 RID: 2313 RVA: 0x00028DDB File Offset: 0x00026FDB
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number less than <see cref="F:System.Decimal.MinValue" /> or than <see cref="F:System.Decimal.MaxValue" /> greater. </exception>
		// Token: 0x0600090A RID: 2314 RVA: 0x00028DE4 File Offset: 0x00026FE4
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDateTime(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An object that provides culture-specific formatting information. </param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		// Token: 0x0600090B RID: 2315 RVA: 0x00028DED File Offset: 0x00026FED
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this, provider);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">The type of the returned object. </param>
		/// <param name="provider">An object that provides culture-specific formatting information.</param>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The value of the current <see cref="T:System.String" /> object cannot be converted to the type specified by the <paramref name="type" /> parameter. </exception>
		// Token: 0x0600090C RID: 2316 RVA: 0x00011C2E File Offset: 0x0000FE2E
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Returns a new string whose textual value is the same as this string, but whose binary representation is in the specified Unicode normalization form.</summary>
		/// <param name="normalizationForm">A Unicode normalization form. </param>
		/// <returns>A new string whose textual value is the same as this string, but whose binary representation is in the normalization form specified by the <paramref name="normalizationForm" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception>
		// Token: 0x0600090D RID: 2317 RVA: 0x00028DF6 File Offset: 0x00026FF6
		public string Normalize(NormalizationForm normalizationForm)
		{
			return Normalization.Normalize(this, normalizationForm);
		}

		/// <summary>Gets the number of characters in the current <see cref="T:System.String" /> object.</summary>
		/// <returns>The number of characters in the current string.</returns>
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00028DFF File Offset: 0x00026FFF
		public int Length
		{
			get
			{
				return this._stringLength;
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00028E08 File Offset: 0x00027008
		internal unsafe int IndexOfUnchecked(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 + count - length + 1;
					while (ptr4 != ptr5)
					{
						if (*ptr4 == *ptr3)
						{
							for (int i = 1; i < length; i++)
							{
								if (ptr4[i] != ptr3[i])
								{
									goto IL_7B;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_7B:
						ptr4++;
					}
					ptr = null;
				}
				return -1;
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00028EA4 File Offset: 0x000270A4
		internal unsafe int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 + count - length + 1;
					char c = textInfo.ToUpper(*ptr3);
					while (ptr4 != ptr5)
					{
						if (textInfo.ToUpper(*ptr4) == c)
						{
							for (int i = 1; i < length; i++)
							{
								if (textInfo.ToUpper(ptr4[i]) != textInfo.ToUpper(ptr3[i]))
								{
									goto IL_A4;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_A4:
						ptr4++;
					}
					ptr = null;
				}
				return -1;
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00028F6C File Offset: 0x0002716C
		internal unsafe int LastIndexOfUnchecked(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 - count + length - 1;
					char* ptr6 = ptr3 + length - 1;
					while (ptr4 != ptr5)
					{
						if (*ptr4 == *ptr6)
						{
							char* ptr7 = ptr4;
							while (ptr3 != ptr6)
							{
								ptr6--;
								ptr4--;
								if (*ptr4 != *ptr6)
								{
									ptr6 = ptr3 + length - 1;
									ptr4 = ptr7;
									goto IL_92;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_92:
						ptr4--;
					}
					ptr = null;
				}
				return -1;
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00029020 File Offset: 0x00027220
		internal unsafe int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			int length = value.Length;
			if (count < length)
			{
				return -1;
			}
			if (length == 0)
			{
				return startIndex;
			}
			TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
			fixed (char* ptr = &this._firstChar)
			{
				char* ptr2 = ptr;
				fixed (string text = value)
				{
					char* ptr3 = text;
					if (ptr3 != null)
					{
						ptr3 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr4 = ptr2 + startIndex;
					char* ptr5 = ptr4 - count + length - 1;
					char* ptr6 = ptr3 + length - 1;
					char c = textInfo.ToUpper(*ptr6);
					while (ptr4 != ptr5)
					{
						if (textInfo.ToUpper(*ptr4) == c)
						{
							char* ptr7 = ptr4;
							while (ptr3 != ptr6)
							{
								ptr6--;
								ptr4--;
								if (textInfo.ToUpper(*ptr4) != textInfo.ToUpper(*ptr6))
								{
									ptr6 = ptr3 + length - 1;
									ptr4 = ptr7;
									goto IL_BB;
								}
							}
							return (int)((long)(ptr4 - ptr2));
						}
						IL_BB:
						ptr4--;
					}
					ptr = null;
				}
				return -1;
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000290FC File Offset: 0x000272FC
		internal bool StartsWithOrdinalUnchecked(string value)
		{
			return this.Length >= value.Length && this._firstChar == value._firstChar && (value.Length == 1 || SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(this.GetRawStringData()), Unsafe.As<char, byte>(value.GetRawStringData()), (ulong)((long)value.Length * 2L)));
		}

		// Token: 0x06000914 RID: 2324
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string FastAllocateString(int length);

		// Token: 0x06000915 RID: 2325 RVA: 0x00029158 File Offset: 0x00027358
		private unsafe static void memset(byte* dest, int val, int len)
		{
			if (len < 8)
			{
				while (len != 0)
				{
					*dest = (byte)val;
					dest++;
					len--;
				}
				return;
			}
			if (val != 0)
			{
				val |= val << 8;
				val |= val << 16;
			}
			int num = dest & 3;
			if (num != 0)
			{
				num = 4 - num;
				len -= num;
				do
				{
					*dest = (byte)val;
					dest++;
					num--;
				}
				while (num != 0);
			}
			while (len >= 16)
			{
				*(int*)dest = val;
				*(int*)(dest + 4) = val;
				*(int*)(dest + (IntPtr)2 * 4) = val;
				*(int*)(dest + (IntPtr)3 * 4) = val;
				dest += 16;
				len -= 16;
			}
			while (len >= 4)
			{
				*(int*)dest = val;
				dest += 4;
				len -= 4;
			}
			while (len > 0)
			{
				*dest = (byte)val;
				dest++;
				len--;
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00029202 File Offset: 0x00027402
		private unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			Buffer.Memcpy(dest, src, size);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002920C File Offset: 0x0002740C
		internal unsafe static void bzero(byte* dest, int len)
		{
			string.memset(dest, 0, len);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00029216 File Offset: 0x00027416
		internal unsafe static void bzero_aligned_1(byte* dest, int len)
		{
			*dest = 0;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002921B File Offset: 0x0002741B
		internal unsafe static void bzero_aligned_2(byte* dest, int len)
		{
			*(short*)dest = 0;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00029220 File Offset: 0x00027420
		internal unsafe static void bzero_aligned_4(byte* dest, int len)
		{
			*(int*)dest = 0;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00029225 File Offset: 0x00027425
		internal unsafe static void bzero_aligned_8(byte* dest, int len)
		{
			*(long*)dest = 0L;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0002922B File Offset: 0x0002742B
		internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
			*dest = *src;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00029231 File Offset: 0x00027431
		internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
			*(short*)dest = *(short*)src;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00029237 File Offset: 0x00027437
		internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
			*(int*)dest = *(int*)src;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0002923D File Offset: 0x0002743D
		internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
			*(long*)dest = *(long*)src;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00029243 File Offset: 0x00027443
		private unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			return string.Ctor(value, startIndex, length);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0002924D File Offset: 0x0002744D
		private unsafe string CreateString(char* value, int startIndex, int length)
		{
			return string.Ctor(value, startIndex, length);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00029257 File Offset: 0x00027457
		private string CreateString(char[] val, int startIndex, int length)
		{
			return string.Ctor(val, startIndex, length);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00029261 File Offset: 0x00027461
		private string CreateString(char[] val)
		{
			return string.Ctor(val);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00029269 File Offset: 0x00027469
		private string CreateString(char c, int count)
		{
			return string.Ctor(c, count);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00029272 File Offset: 0x00027472
		private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
		{
			return string.Ctor(value, startIndex, length, enc);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0002927E File Offset: 0x0002747E
		private string CreateString(ReadOnlySpan<char> value)
		{
			return string.Ctor(value);
		}

		/// <summary>Gets the <see cref="T:System.Char" /> object at a specified position in the current <see cref="T:System.String" /> object.</summary>
		/// <param name="index">A position in the current string. </param>
		/// <returns>The object at position <paramref name="index" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is greater than or equal to the length of this object or less than zero. </exception>
		// Token: 0x1700008F RID: 143
		[IndexerName("Chars")]
		public unsafe char this[int index]
		{
			[Intrinsic]
			get
			{
				if ((ulong)index >= (ulong)((long)this._stringLength))
				{
					ThrowHelper.ThrowIndexOutOfRangeException();
				}
				return *Unsafe.Add<char>(ref this._firstChar, index);
			}
		}

		// Token: 0x04000360 RID: 864
		private const int StackallocIntBufferSizeLimit = 128;

		// Token: 0x04000361 RID: 865
		private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;

		// Token: 0x04000362 RID: 866
		private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;

		// Token: 0x04000363 RID: 867
		private const int PROBABILISTICMAP_SIZE = 8;

		// Token: 0x04000364 RID: 868
		[NonSerialized]
		private int _stringLength;

		// Token: 0x04000365 RID: 869
		[NonSerialized]
		private char _firstChar;

		/// <summary>Represents the empty string. This field is read-only.</summary>
		// Token: 0x04000366 RID: 870
		public static readonly string Empty;

		// Token: 0x020000F9 RID: 249
		private enum TrimType
		{
			// Token: 0x04000368 RID: 872
			Head,
			// Token: 0x04000369 RID: 873
			Tail,
			// Token: 0x0400036A RID: 874
			Both
		}

		// Token: 0x020000FA RID: 250
		[StructLayout(2, Size = 32)]
		private struct ProbabilisticMap
		{
		}
	}
}
