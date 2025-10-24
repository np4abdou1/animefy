﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Mono.Globalization.Unicode;

namespace System.Globalization
{
	/// <summary>Implements a set of methods for culture-sensitive string comparisons.</summary>
	// Token: 0x02000577 RID: 1399
	[Serializable]
	public class CompareInfo : IDeserializationCallback
	{
		// Token: 0x060029BF RID: 10687 RVA: 0x000A68D0 File Offset: 0x000A4AD0
		internal unsafe static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			char* ptr = source;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = value;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			int num = CompareInfo.InvariantFindString(ptr + startIndex, count, ptr2, value.Length, ignoreCase, true);
			if (num >= 0)
			{
				return num + startIndex;
			}
			return -1;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000A6924 File Offset: 0x000A4B24
		internal unsafe static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			char* ptr = source;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = value;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			int num = CompareInfo.InvariantFindString(ptr + (startIndex - count + 1), count, ptr2, value.Length, ignoreCase, false);
			if (num >= 0)
			{
				return num + startIndex - count + 1;
			}
			return -1;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000A6980 File Offset: 0x000A4B80
		private unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
		{
			if (valueCount == 0)
			{
				if (!start)
				{
					return sourceCount - 1;
				}
				return 0;
			}
			else
			{
				if (sourceCount < valueCount)
				{
					return -1;
				}
				if (start)
				{
					int num = sourceCount - valueCount;
					if (ignoreCase)
					{
						char c = CompareInfo.InvariantToUpper(*value);
						for (int i = 0; i <= num; i++)
						{
							if (CompareInfo.InvariantToUpper(source[i]) == c)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c2 = CompareInfo.InvariantToUpper(source[i + j]);
									char c3 = CompareInfo.InvariantToUpper(value[j]);
									if (c2 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
					else
					{
						char c4 = *value;
						for (int i = 0; i <= num; i++)
						{
							if (source[i] == c4)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c5 = source[i + j];
									char c3 = value[j];
									if (c5 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
				}
				else
				{
					int num = sourceCount - valueCount;
					if (ignoreCase)
					{
						char c6 = CompareInfo.InvariantToUpper(*value);
						for (int i = num; i >= 0; i--)
						{
							if (CompareInfo.InvariantToUpper(source[i]) == c6)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c7 = CompareInfo.InvariantToUpper(source[i + j]);
									char c3 = CompareInfo.InvariantToUpper(value[j]);
									if (c7 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
					else
					{
						char c8 = *value;
						for (int i = num; i >= 0; i--)
						{
							if (source[i] == c8)
							{
								int j;
								for (j = 1; j < valueCount; j++)
								{
									char c9 = source[i + j];
									char c3 = value[j];
									if (c9 != c3)
									{
										break;
									}
								}
								if (j == valueCount)
								{
									return i;
								}
							}
						}
					}
				}
				return -1;
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000A6AF4 File Offset: 0x000A4CF4
		private static char InvariantToUpper(char c)
		{
			if (c - 'a' > '\u0019')
			{
				return c;
			}
			return c - ' ';
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000A6B08 File Offset: 0x000A4D08
		private unsafe SortKey InvariantCreateSortKey(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			byte[] array;
			if (source.Length == 0)
			{
				array = Array.Empty<byte>();
			}
			else
			{
				array = new byte[source.Length * 2];
				fixed (string text = source)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					byte[] array2;
					byte* ptr2;
					if ((array2 = array) == null || array2.Length == 0)
					{
						ptr2 = null;
					}
					else
					{
						ptr2 = &array2[0];
					}
					if ((options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) != CompareOptions.None)
					{
						short* ptr3 = (short*)ptr2;
						for (int i = 0; i < source.Length; i++)
						{
							ptr3[i] = (short)CompareInfo.InvariantToUpper(source[i]);
						}
					}
					else
					{
						Buffer.MemoryCopy((void*)ptr, (void*)ptr2, (long)array.Length, (long)array.Length);
					}
					array2 = null;
				}
			}
			return new SortKey(this.Name, source, options, array);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000A6BE4 File Offset: 0x000A4DE4
		internal CompareInfo(CultureInfo culture)
		{
			this.m_name = culture._name;
			this.InitSort(culture);
		}

		/// <summary>Initializes a new <see cref="T:System.Globalization.CompareInfo" /> object that is associated with the culture with the specified name.</summary>
		/// <param name="name">A string representing the culture name. </param>
		/// <returns>A new <see cref="T:System.Globalization.CompareInfo" /> object associated with the culture with the specified identifier and using string comparison methods in the current <see cref="T:System.Reflection.Assembly" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is an invalid culture name. </exception>
		// Token: 0x060029C5 RID: 10693 RVA: 0x000A6BFF File Offset: 0x000A4DFF
		public static CompareInfo GetCompareInfo(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return CultureInfo.GetCultureInfo(name).CompareInfo;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000A6C1A File Offset: 0x000A4E1A
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.m_name = null;
		}

		/// <summary>Runs when the entire object graph has been deserialized.</summary>
		/// <param name="sender">The object that initiated the callback. </param>
		// Token: 0x060029C7 RID: 10695 RVA: 0x000A6C23 File Offset: 0x000A4E23
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialized();
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000A6C23 File Offset: 0x000A4E23
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000A6C2C File Offset: 0x000A4E2C
		private void OnDeserialized()
		{
			if (this.m_name == null)
			{
				CultureInfo cultureInfo = CultureInfo.GetCultureInfo(this.culture);
				this.m_name = cultureInfo._name;
				return;
			}
			this.InitSort(CultureInfo.GetCultureInfo(this.m_name));
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000A6C6B File Offset: 0x000A4E6B
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.culture = CultureInfo.GetCultureInfo(this.Name).LCID;
		}

		/// <summary>Gets the name of the culture used for sorting operations by this <see cref="T:System.Globalization.CompareInfo" /> object.</summary>
		/// <returns>The name of a culture.</returns>
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x000A6C83 File Offset: 0x000A4E83
		public virtual string Name
		{
			get
			{
				if (this.m_name == "zh-CHT" || this.m_name == "zh-CHS")
				{
					return this.m_name;
				}
				return this._sortName;
			}
		}

		/// <summary>Compares two strings. </summary>
		/// <param name="string1">The first string to compare. </param>
		/// <param name="string2">The second string to compare. </param>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero 
		///             <paramref name="string1" /> is less than <paramref name="string2" />. greater than zero 
		///             <paramref name="string1" /> is greater than <paramref name="string2" />. </returns>
		// Token: 0x060029CC RID: 10700 RVA: 0x000A6CB6 File Offset: 0x000A4EB6
		public virtual int Compare(string string1, string string2)
		{
			return this.Compare(string1, string2, CompareOptions.None);
		}

		/// <summary>Compares two strings using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="string1">The first string to compare. </param>
		/// <param name="string2">The second string to compare. </param>
		/// <param name="options">A value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero 
		///             <paramref name="string1" /> is less than <paramref name="string2" />. greater than zero 
		///             <paramref name="string1" /> is greater than <paramref name="string2" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029CD RID: 10701 RVA: 0x000A6CC4 File Offset: 0x000A4EC4
		public virtual int Compare(string string1, string string2, CompareOptions options)
		{
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return string.Compare(string1, string2, StringComparison.OrdinalIgnoreCase);
			}
			if ((options & CompareOptions.Ordinal) != CompareOptions.None)
			{
				if (options != CompareOptions.Ordinal)
				{
					throw new ArgumentException("CompareOption.Ordinal cannot be used with other options.", "options");
				}
				return string.CompareOrdinal(string1, string2);
			}
			else
			{
				if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (string1 == null)
				{
					if (string2 == null)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (string2 == null)
					{
						return 1;
					}
					if (!GlobalizationMode.Invariant)
					{
						return this.internal_compare_switch(string1, 0, string1.Length, string2, 0, string2.Length, options);
					}
					if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
					{
						return CompareInfo.CompareOrdinalIgnoreCase(string1, string2);
					}
					return string.CompareOrdinal(string1, string2);
				}
			}
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000A6D70 File Offset: 0x000A4F70
		internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return CompareInfo.CompareOrdinalIgnoreCase(string1, string2.AsSpan());
			}
			if ((options & CompareOptions.Ordinal) != CompareOptions.None)
			{
				if (options != CompareOptions.Ordinal)
				{
					throw new ArgumentException("CompareOption.Ordinal cannot be used with other options.", "options");
				}
				return string.CompareOrdinal(string1, string2.AsSpan());
			}
			else
			{
				if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (string2 == null)
				{
					return 1;
				}
				if (!GlobalizationMode.Invariant)
				{
					return this.CompareString(string1, string2, options);
				}
				if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
				{
					return string.CompareOrdinal(string1, string2.AsSpan());
				}
				return CompareInfo.CompareOrdinalIgnoreCase(string1, string2.AsSpan());
			}
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000A6E0D File Offset: 0x000A500D
		internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
		{
			if (string1.Length == 0 || string2.Length == 0)
			{
				return string1.Length - string2.Length;
			}
			if (!GlobalizationMode.Invariant)
			{
				return this.CompareString(string1, string2, CompareOptions.IgnoreCase);
			}
			return CompareInfo.CompareOrdinalIgnoreCase(string1, string2);
		}

		/// <summary>Compares a section of one string with a section of another string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="string1">The first string to compare. </param>
		/// <param name="offset1">The zero-based index of the character in <paramref name="string1" /> at which to start comparing. </param>
		/// <param name="length1">The number of consecutive characters in <paramref name="string1" /> to compare. </param>
		/// <param name="string2">The second string to compare. </param>
		/// <param name="offset2">The zero-based index of the character in <paramref name="string2" /> at which to start comparing. </param>
		/// <param name="length2">The number of consecutive characters in <paramref name="string2" /> to compare. </param>
		/// <param name="options">A value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero The specified section of <paramref name="string1" /> is less than the specified section of <paramref name="string2" />. greater than zero The specified section of <paramref name="string1" /> is greater than the specified section of <paramref name="string2" />. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset1" /> or <paramref name="length1" /> or <paramref name="offset2" /> or <paramref name="length2" /> is less than zero.-or- 
		///         <paramref name="offset1" /> is greater than or equal to the number of characters in <paramref name="string1" />.-or- 
		///         <paramref name="offset2" /> is greater than or equal to the number of characters in <paramref name="string2" />.-or- 
		///         <paramref name="length1" /> is greater than the number of characters from <paramref name="offset1" /> to the end of <paramref name="string1" />.-or- 
		///         <paramref name="length2" /> is greater than the number of characters from <paramref name="offset2" /> to the end of <paramref name="string2" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029D0 RID: 10704 RVA: 0x000A6E4C File Offset: 0x000A504C
		public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				int num = string.Compare(string1, offset1, string2, offset2, (length1 < length2) ? length1 : length2, StringComparison.OrdinalIgnoreCase);
				if (length1 == length2 || num != 0)
				{
					return num;
				}
				if (length1 <= length2)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (length1 < 0 || length2 < 0)
				{
					throw new ArgumentOutOfRangeException((length1 < 0) ? "length1" : "length2", "Positive number required.");
				}
				if (offset1 < 0 || offset2 < 0)
				{
					throw new ArgumentOutOfRangeException((offset1 < 0) ? "offset1" : "offset2", "Positive number required.");
				}
				if (offset1 > ((string1 == null) ? 0 : string1.Length) - length1)
				{
					throw new ArgumentOutOfRangeException("string1", "Offset and length must refer to a position in the string.");
				}
				if (offset2 > ((string2 == null) ? 0 : string2.Length) - length2)
				{
					throw new ArgumentOutOfRangeException("string2", "Offset and length must refer to a position in the string.");
				}
				if ((options & CompareOptions.Ordinal) != CompareOptions.None)
				{
					if (options != CompareOptions.Ordinal)
					{
						throw new ArgumentException("CompareOption.Ordinal cannot be used with other options.", "options");
					}
				}
				else if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (string1 == null)
				{
					if (string2 == null)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (string2 == null)
					{
						return 1;
					}
					ReadOnlySpan<char> strA = string1.AsSpan(offset1, length1);
					ReadOnlySpan<char> strB = string2.AsSpan(offset2, length2);
					if (options == CompareOptions.Ordinal)
					{
						return string.CompareOrdinal(strA, strB);
					}
					if (!GlobalizationMode.Invariant)
					{
						return this.internal_compare_switch(string1, offset1, length1, string2, offset2, length2, options);
					}
					if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
					{
						return CompareInfo.CompareOrdinalIgnoreCase(strA, strB);
					}
					return string.CompareOrdinal(strA, strB);
				}
			}
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000A6FBC File Offset: 0x000A51BC
		internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
		{
			return CompareInfo.CompareOrdinalIgnoreCase(strA.AsSpan(indexA, lengthA), strB.AsSpan(indexB, lengthB));
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000A6FD8 File Offset: 0x000A51D8
		internal unsafe static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			int num = Math.Min(strA.Length, strB.Length);
			int num2 = num;
			fixed (char* reference = MemoryMarshal.GetReference<char>(strA))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(strB))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					char c = GlobalizationMode.Invariant ? char.MaxValue : '\u007f';
					while (num != 0 && *ptr3 <= c && *ptr4 <= c)
					{
						int num3 = (int)(*ptr3);
						int num4 = (int)(*ptr4);
						if (num3 == num4)
						{
							ptr3++;
							ptr4++;
							num--;
						}
						else
						{
							if (num3 - 97 <= 25)
							{
								num3 -= 32;
							}
							if (num4 - 97 <= 25)
							{
								num4 -= 32;
							}
							if (num3 != num4)
							{
								return num3 - num4;
							}
							ptr3++;
							ptr4++;
							num--;
						}
					}
					if (num == 0)
					{
						return strA.Length - strB.Length;
					}
					num2 -= num;
					return CompareInfo.CompareStringOrdinalIgnoreCase(ptr3, strA.Length - num2, ptr4, strB.Length - num2);
				}
			}
		}

		/// <summary>Determines whether the specified source string starts with the specified prefix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="source">The string to search in. </param>
		/// <param name="prefix">The string to compare with the beginning of <paramref name="source" />. </param>
		/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="prefix" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>
		///     <see langword="true" /> if the length of <paramref name="prefix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> starts with <paramref name="prefix" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.-or- 
		///         <paramref name="prefix" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029D3 RID: 10707 RVA: 0x000A70CC File Offset: 0x000A52CC
		public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			if (source == null || prefix == null)
			{
				throw new ArgumentNullException((source == null) ? "source" : "prefix", "String reference not set to an instance of a String.");
			}
			if (prefix.Length == 0)
			{
				return true;
			}
			if (source.Length == 0)
			{
				return false;
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return source.StartsWith(prefix, StringComparison.OrdinalIgnoreCase);
			}
			if (options == CompareOptions.Ordinal)
			{
				return source.StartsWith(prefix, StringComparison.Ordinal);
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (GlobalizationMode.Invariant)
			{
				return source.StartsWith(prefix, ((options & CompareOptions.IgnoreCase) != CompareOptions.None) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
			}
			return this.StartsWith(source, prefix, options);
		}

		/// <summary>Determines whether the specified source string ends with the specified suffix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="source">The string to search in. </param>
		/// <param name="suffix">The string to compare with the end of <paramref name="source" />. </param>
		/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="suffix" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>
		///     <see langword="true" /> if the length of <paramref name="suffix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> ends with <paramref name="suffix" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.-or- 
		///         <paramref name="suffix" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029D4 RID: 10708 RVA: 0x000A7168 File Offset: 0x000A5368
		public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			if (source == null || suffix == null)
			{
				throw new ArgumentNullException((source == null) ? "source" : "suffix", "String reference not set to an instance of a String.");
			}
			if (suffix.Length == 0)
			{
				return true;
			}
			if (source.Length == 0)
			{
				return false;
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return source.EndsWith(suffix, StringComparison.OrdinalIgnoreCase);
			}
			if (options == CompareOptions.Ordinal)
			{
				return source.EndsWith(suffix, StringComparison.Ordinal);
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (GlobalizationMode.Invariant)
			{
				return source.EndsWith(suffix, ((options & CompareOptions.IgnoreCase) != CompareOptions.None) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
			}
			return this.EndsWith(source, suffix, options);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000A7202 File Offset: 0x000A5402
		internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			return this.EndsWith(source, suffix, options);
		}

		/// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the entire source string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="source">The string to search. </param>
		/// <param name="value">The string to locate within <paramref name="source" />. </param>
		/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within <paramref name="source" />, using the specified comparison options; otherwise, -1. Returns 0 (zero) if <paramref name="value" /> is an ignorable character.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.-or- 
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029D6 RID: 10710 RVA: 0x000A720D File Offset: 0x000A540D
		public virtual int IndexOf(string source, string value, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return this.IndexOf(source, value, 0, source.Length, options);
		}

		/// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="source">The string to search. </param>
		/// <param name="value">The string to locate within <paramref name="source" />. </param>
		/// <param name="startIndex">The zero-based starting index of the search. </param>
		/// <param name="count">The number of elements in the section to search. </param>
		/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.-or- 
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- 
		///         <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029D7 RID: 10711 RVA: 0x000A7230 File Offset: 0x000A5430
		public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (startIndex > source.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (source.Length == 0)
			{
				if (value.Length == 0)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (startIndex < 0)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count < 0 || startIndex > source.Length - count)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return this.IndexOfOrdinal(source, value, startIndex, count, true);
				}
				if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal)
				{
					throw new ArgumentException("Value of flags is invalid.", "options");
				}
				if (GlobalizationMode.Invariant)
				{
					return this.IndexOfOrdinal(source, value, startIndex, count, (options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) > CompareOptions.None);
				}
				return this.IndexOfCore(source, value, startIndex, count, options, null);
			}
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000A731E File Offset: 0x000A551E
		internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (GlobalizationMode.Invariant)
			{
				return CompareInfo.InvariantIndexOf(source, value, startIndex, count, ignoreCase);
			}
			return CompareInfo.IndexOfOrdinalCore(source, value, startIndex, count, ignoreCase);
		}

		/// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="source">The string to search. </param>
		/// <param name="value">The string to locate within <paramref name="source" />. </param>
		/// <param name="startIndex">The zero-based starting index of the backward search. </param>
		/// <param name="count">The number of elements in the section to search. </param>
		/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and that ends at <paramref name="startIndex" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.-or- 
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- 
		///         <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029D9 RID: 10713 RVA: 0x000A7340 File Offset: 0x000A5540
		public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal && options != CompareOptions.OrdinalIgnoreCase)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (source.Length == 0 && (startIndex == -1 || startIndex == 0))
			{
				if (value.Length != 0)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (startIndex < 0 || startIndex > source.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (startIndex == source.Length)
				{
					startIndex--;
					if (count > 0)
					{
						count--;
					}
					if (value.Length == 0 && count >= 0 && startIndex - count + 1 >= 0)
					{
						return startIndex;
					}
				}
				if (count < 0 || startIndex - count + 1 < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return this.LastIndexOfOrdinal(source, value, startIndex, count, true);
				}
				if (GlobalizationMode.Invariant)
				{
					return CompareInfo.InvariantLastIndexOf(source, value, startIndex, count, (options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) > CompareOptions.None);
				}
				return this.LastIndexOfCore(source, value, startIndex, count, options);
			}
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000A7459 File Offset: 0x000A5659
		internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (GlobalizationMode.Invariant)
			{
				return CompareInfo.InvariantLastIndexOf(source, value, startIndex, count, ignoreCase);
			}
			return CompareInfo.LastIndexOfOrdinalCore(source, value, startIndex, count, ignoreCase);
		}

		/// <summary>Gets a <see cref="T:System.Globalization.SortKey" /> object for the specified string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <param name="source">The string for which a <see cref="T:System.Globalization.SortKey" /> object is obtained. </param>
		/// <param name="options">A bitwise combination of one or more of the following enumeration values that define how the sort key is calculated: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <returns>The <see cref="T:System.Globalization.SortKey" /> object that contains the sort key for the specified string.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		// Token: 0x060029DB RID: 10715 RVA: 0x000A747B File Offset: 0x000A567B
		public virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			if (GlobalizationMode.Invariant)
			{
				return this.InvariantCreateSortKey(source, options);
			}
			return this.CreateSortKey(source, options);
		}

		/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" /> object.</summary>
		/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.CompareInfo" />. </param>
		/// <returns>
		///     <see langword="true" /> if the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060029DC RID: 10716 RVA: 0x000A7498 File Offset: 0x000A5698
		public override bool Equals(object value)
		{
			CompareInfo compareInfo = value as CompareInfo;
			return compareInfo != null && this.Name == compareInfo.Name;
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.CompareInfo" /> for hashing algorithms and data structures, such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Globalization.CompareInfo" />.</returns>
		// Token: 0x060029DD RID: 10717 RVA: 0x000A74C2 File Offset: 0x000A56C2
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000A74D0 File Offset: 0x000A56D0
		internal unsafe static int GetIgnoreCaseHash(string source)
		{
			if (source.Length == 0)
			{
				return source.GetHashCode();
			}
			char[] array = null;
			Span<char> span;
			if (source.Length <= 255)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)510], 255);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(source.Length));
			}
			Span<char> destination = span;
			int length = source.AsSpan().ToUpperInvariant(destination);
			int result = Marvin.ComputeHash32(MemoryMarshal.AsBytes<char>(destination.Slice(0, length)), Marvin.DefaultSeed);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000A7564 File Offset: 0x000A5764
		internal int GetHashCodeOfString(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			if (!GlobalizationMode.Invariant)
			{
				return this.GetHashCodeOfStringCore(source, options);
			}
			if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
			{
				return source.GetHashCode();
			}
			return CompareInfo.GetIgnoreCaseHash(source);
		}

		/// <summary>Gets the hash code for a string based on specified comparison options. </summary>
		/// <param name="source">The string whose hash code is to be returned. </param>
		/// <param name="options">A value that determines how strings are compared. </param>
		/// <returns>A 32-bit signed integer hash code. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />. </exception>
		// Token: 0x060029E0 RID: 10720 RVA: 0x000A75B7 File Offset: 0x000A57B7
		public virtual int GetHashCode(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (options == CompareOptions.Ordinal)
			{
				return source.GetHashCode();
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return CompareInfo.GetIgnoreCaseHash(source);
			}
			return this.GetHashCodeOfString(source, options);
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.CompareInfo" /> object.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Globalization.CompareInfo" /> object.</returns>
		// Token: 0x060029E1 RID: 10721 RVA: 0x000A75ED File Offset: 0x000A57ED
		public override string ToString()
		{
			return "CompareInfo - " + this.Name;
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x000A75FF File Offset: 0x000A57FF
		private static bool UseManagedCollation
		{
			get
			{
				if (!CompareInfo.managedCollationChecked)
				{
					CompareInfo.managedCollation = (Environment.internalGetEnvironmentVariable("MONO_DISABLE_MANAGED_COLLATION") != "yes" && MSCompatUnicodeTable.IsReady);
					CompareInfo.managedCollationChecked = true;
				}
				return CompareInfo.managedCollation;
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000A7638 File Offset: 0x000A5838
		private ISimpleCollator GetCollator()
		{
			if (this.collator != null)
			{
				return this.collator;
			}
			if (CompareInfo.collators == null)
			{
				Interlocked.CompareExchange<Dictionary<string, ISimpleCollator>>(ref CompareInfo.collators, new Dictionary<string, ISimpleCollator>(StringComparer.Ordinal), null);
			}
			Dictionary<string, ISimpleCollator> obj = CompareInfo.collators;
			lock (obj)
			{
				if (!CompareInfo.collators.TryGetValue(this._sortName, out this.collator))
				{
					this.collator = new SimpleCollator(CultureInfo.GetCultureInfo(this.m_name));
					CompareInfo.collators[this._sortName] = this.collator;
				}
			}
			return this.collator;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000A76E8 File Offset: 0x000A58E8
		private SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			if (CompareInfo.UseManagedCollation)
			{
				return this.GetCollator().GetSortKey(source, options);
			}
			return new SortKey(this.culture, source, options);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000A770C File Offset: 0x000A590C
		private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			if (opt == CompareOptions.Ordinal)
			{
				if (!first)
				{
					return s1.LastIndexOfUnchecked(s2, sindex, count);
				}
				return s1.IndexOfUnchecked(s2, sindex, count);
			}
			else
			{
				if (!CompareInfo.UseManagedCollation)
				{
					return CompareInfo.internal_index(s1, sindex, count, s2, first);
				}
				return this.internal_index_managed(s1, sindex, count, s2, opt, first);
			}
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000A775F File Offset: 0x000A595F
		private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			if (!CompareInfo.UseManagedCollation)
			{
				return CompareInfo.internal_compare(str1, offset1, length1, str2, offset2, length2, options);
			}
			return this.internal_compare_managed(str1, offset1, length1, str2, offset2, length2, options);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x000A778A File Offset: 0x000A598A
		private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			return this.GetCollator().Compare(str1, offset1, length1, str2, offset2, length2, options);
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000A77A2 File Offset: 0x000A59A2
		private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			if (!first)
			{
				return this.GetCollator().LastIndexOf(s1, s2, sindex, count, opt);
			}
			return this.GetCollator().IndexOf(s1, s2, sindex, count, opt);
		}

		// Token: 0x060029E9 RID: 10729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options);

		// Token: 0x060029EA RID: 10730 RVA: 0x000A77D0 File Offset: 0x000A59D0
		private unsafe static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			char* ptr = str1;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = str2;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return CompareInfo.internal_compare_icall(ptr + offset1, length1, ptr2 + offset2, length2, options);
		}

		// Token: 0x060029EB RID: 10731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first);

		// Token: 0x060029EC RID: 10732 RVA: 0x000A7814 File Offset: 0x000A5A14
		private unsafe static int internal_index(string source, int sindex, int count, string value, bool first)
		{
			char* ptr = source;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = value;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return CompareInfo.internal_index_icall(ptr, sindex, count, ptr2, (value != null) ? value.Length : 0, first);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000A7858 File Offset: 0x000A5A58
		private void InitSort(CultureInfo culture)
		{
			this._sortName = culture.SortName;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000A7868 File Offset: 0x000A5A68
		private unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
		{
			TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
			int num = 0;
			while (num < length1 && num < length2 && textInfo.ToUpper(*pString1) == textInfo.ToUpper(*pString2))
			{
				num++;
				pString1++;
				pString2++;
			}
			if (num >= length1)
			{
				if (num >= length2)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (num >= length2)
				{
					return 1;
				}
				return (int)(textInfo.ToUpper(*pString1) - textInfo.ToUpper(*pString2));
			}
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000A78CF File Offset: 0x000A5ACF
		internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (!ignoreCase)
			{
				return source.IndexOfUnchecked(value, startIndex, count);
			}
			return source.IndexOfUncheckedIgnoreCase(value, startIndex, count);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x000A78E8 File Offset: 0x000A5AE8
		internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (!ignoreCase)
			{
				return source.LastIndexOfUnchecked(value, startIndex, count);
			}
			return source.LastIndexOfUncheckedIgnoreCase(value, startIndex, count);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000A7901 File Offset: 0x000A5B01
		private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
		{
			return this.internal_index_switch(source, startIndex, count, target, options, false);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000A7911 File Offset: 0x000A5B11
		private unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
		{
			if (matchLengthPtr != null)
			{
				*matchLengthPtr = target.Length;
			}
			return this.internal_index_switch(source, startIndex, count, target, options, true);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000A7930 File Offset: 0x000A5B30
		private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			string text = new string(string1);
			return this.internal_compare_switch(text, 0, text.Length, string2, 0, string2.Length, options);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000A795C File Offset: 0x000A5B5C
		private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
		{
			string text = new string(string1);
			string text2 = new string(string2);
			return this.internal_compare_switch(text, 0, text.Length, new string(text2), 0, text2.Length, options);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000A7998 File Offset: 0x000A5B98
		private SortKey CreateSortKey(string source, CompareOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			return this.CreateSortKeyCore(source, options);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000A79CC File Offset: 0x000A5BCC
		private bool StartsWith(string source, string prefix, CompareOptions options)
		{
			if (CompareInfo.UseManagedCollation)
			{
				return this.GetCollator().IsPrefix(source, prefix, options);
			}
			return source.Length >= prefix.Length && this.Compare(source, 0, prefix.Length, prefix, 0, prefix.Length, options) == 0;
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000A7A1C File Offset: 0x000A5C1C
		private bool EndsWith(string source, string suffix, CompareOptions options)
		{
			if (CompareInfo.UseManagedCollation)
			{
				return this.GetCollator().IsSuffix(source, suffix, options);
			}
			return source.Length >= suffix.Length && this.Compare(source, source.Length - suffix.Length, suffix.Length, suffix, 0, suffix.Length, options) == 0;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000A7A75 File Offset: 0x000A5C75
		private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			return this.EndsWith(new string(source), new string(suffix), options);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000A7A8A File Offset: 0x000A5C8A
		internal int GetHashCodeOfStringCore(string source, CompareOptions options)
		{
			return this.GetSortKey(source, options).GetHashCode();
		}

		// Token: 0x040015BE RID: 5566
		private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x040015BF RID: 5567
		private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x040015C0 RID: 5568
		private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x040015C1 RID: 5569
		private const CompareOptions ValidSortkeyCtorMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x040015C2 RID: 5570
		internal static readonly CompareInfo Invariant = CultureInfo.InvariantCulture.CompareInfo;

		// Token: 0x040015C3 RID: 5571
		[OptionalField(VersionAdded = 2)]
		private string m_name;

		// Token: 0x040015C4 RID: 5572
		[NonSerialized]
		private string _sortName;

		// Token: 0x040015C5 RID: 5573
		[OptionalField(VersionAdded = 3)]
		private SortVersion m_SortVersion;

		// Token: 0x040015C6 RID: 5574
		private int culture;

		// Token: 0x040015C7 RID: 5575
		[NonSerialized]
		private ISimpleCollator collator;

		// Token: 0x040015C8 RID: 5576
		private static Dictionary<string, ISimpleCollator> collators;

		// Token: 0x040015C9 RID: 5577
		private static bool managedCollation;

		// Token: 0x040015CA RID: 5578
		private static bool managedCollationChecked;
	}
}
