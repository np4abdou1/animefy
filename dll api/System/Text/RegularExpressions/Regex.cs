using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents an immutable regular expression.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020000A2 RID: 162
	public class Regex : ISerializable
	{
		// Token: 0x06000419 RID: 1049 RVA: 0x0001679C File Offset: 0x0001499C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			Regex.CachedCodeEntry cachedCodeEntry = Regex.s_cacheFirst;
			if (cachedCodeEntry != null && cachedCodeEntry.Key == key)
			{
				return cachedCodeEntry;
			}
			if (Regex.s_cacheSize == 0)
			{
				return null;
			}
			return this.GetCachedCodeEntryInternal(key, isToAdd);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000167D4 File Offset: 0x000149D4
		private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> obj = Regex.s_cache;
			Regex.CachedCodeEntry result;
			lock (obj)
			{
				Regex.CachedCodeEntry cachedCodeEntry = Regex.LookupCachedAndPromote(key);
				if (cachedCodeEntry == null && isToAdd && Regex.s_cacheSize != 0)
				{
					cachedCodeEntry = new Regex.CachedCodeEntry(key, this.capnames, this.capslist, this._code, this.caps, this.capsize, this._runnerref, this._replref);
					if (Regex.s_cacheFirst != null)
					{
						Regex.s_cacheFirst.Next = cachedCodeEntry;
						cachedCodeEntry.Previous = Regex.s_cacheFirst;
					}
					Regex.s_cacheFirst = cachedCodeEntry;
					Regex.s_cacheCount++;
					if (Regex.s_cacheCount >= 10)
					{
						if (Regex.s_cacheCount == 10)
						{
							this.FillCacheDictionary();
						}
						else
						{
							Regex.s_cache.Add(key, cachedCodeEntry);
						}
					}
					if (Regex.s_cacheLast == null)
					{
						Regex.s_cacheLast = cachedCodeEntry;
					}
					else if (Regex.s_cacheCount > Regex.s_cacheSize)
					{
						Regex.CachedCodeEntry cachedCodeEntry2 = Regex.s_cacheLast;
						if (Regex.s_cacheCount >= 10)
						{
							Regex.s_cache.Remove(cachedCodeEntry2.Key);
						}
						cachedCodeEntry2.Next.Previous = null;
						Regex.s_cacheLast = cachedCodeEntry2.Next;
						Regex.s_cacheCount--;
					}
				}
				result = cachedCodeEntry;
			}
			return result;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00016920 File Offset: 0x00014B20
		private void FillCacheDictionary()
		{
			Regex.s_cache.Clear();
			for (Regex.CachedCodeEntry previous = Regex.s_cacheFirst; previous != null; previous = previous.Previous)
			{
				Regex.s_cache.Add(previous.Key, previous);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001695A File Offset: 0x00014B5A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			if (Regex.s_cacheCount >= 10)
			{
				return Regex.s_cache.TryGetValue(key, out entry);
			}
			return Regex.TryGetCacheValueSmall(key, out entry);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00016979 File Offset: 0x00014B79
		private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			Regex.CachedCodeEntry cachedCodeEntry = Regex.s_cacheFirst;
			for (entry = ((cachedCodeEntry != null) ? cachedCodeEntry.Previous : null); entry != null; entry = entry.Previous)
			{
				if (entry.Key == key)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000169B0 File Offset: 0x00014BB0
		private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key)
		{
			Regex.CachedCodeEntry cachedCodeEntry = Regex.s_cacheFirst;
			if (cachedCodeEntry != null && cachedCodeEntry.Key == key)
			{
				return Regex.s_cacheFirst;
			}
			Regex.CachedCodeEntry cachedCodeEntry2;
			if (Regex.TryGetCacheValue(key, out cachedCodeEntry2))
			{
				if (Regex.s_cacheLast == cachedCodeEntry2)
				{
					Regex.s_cacheLast = cachedCodeEntry2.Next;
				}
				else
				{
					cachedCodeEntry2.Previous.Next = cachedCodeEntry2.Next;
				}
				cachedCodeEntry2.Next.Previous = cachedCodeEntry2.Previous;
				Regex.s_cacheFirst.Next = cachedCodeEntry2;
				cachedCodeEntry2.Previous = Regex.s_cacheFirst;
				cachedCodeEntry2.Next = null;
				Regex.s_cacheFirst = cachedCodeEntry2;
			}
			return cachedCodeEntry2;
		}

		/// <summary>Indicates whether the specified regular expression finds a match in the specified input string.</summary>
		/// <param name="input">The string to search for a match. </param>
		/// <param name="pattern">The regular expression pattern to match. </param>
		/// <returns>
		///     <see langword="true" /> if the regular expression finds a match; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">A regular expression parsing error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> or <paramref name="pattern" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x0600041F RID: 1055 RVA: 0x00016A41 File Offset: 0x00014C41
		public static bool IsMatch(string input, string pattern)
		{
			return Regex.IsMatch(input, pattern, RegexOptions.None, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Indicates whether the specified regular expression finds a match in the specified input string, using the specified matching options and time-out interval.</summary>
		/// <param name="input">The string to search for a match.</param>
		/// <param name="pattern">The regular expression pattern to match.</param>
		/// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
		/// <param name="matchTimeout">A time-out interval, or <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" /> to indicate that the method should not time out.</param>
		/// <returns>
		///     <see langword="true" /> if the regular expression finds a match; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">A regular expression parsing error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> or <paramref name="pattern" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="options" /> is not a valid <see cref="T:System.Text.RegularExpressions.RegexOptions" /> value.-or-
		///         <paramref name="matchTimeout" /> is negative, zero, or greater than approximately 24 days.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
		// Token: 0x06000420 RID: 1056 RVA: 0x00016A50 File Offset: 0x00014C50
		public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).IsMatch(input);
		}

		/// <summary>Indicates whether the regular expression specified in the <see cref="T:System.Text.RegularExpressions.Regex" /> constructor finds a match in a specified input string.</summary>
		/// <param name="input">The string to search for a match. </param>
		/// <returns>
		///     <see langword="true" /> if the regular expression finds a match; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x06000421 RID: 1057 RVA: 0x00016A61 File Offset: 0x00014C61
		public bool IsMatch(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.IsMatch(input, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>Indicates whether the regular expression specified in the <see cref="T:System.Text.RegularExpressions.Regex" /> constructor finds a match in the specified input string, beginning at the specified starting position in the string.</summary>
		/// <param name="input">The string to search for a match. </param>
		/// <param name="startat">The character position at which to start the search. </param>
		/// <returns>
		///     <see langword="true" /> if the regular expression finds a match; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startat" /> is less than zero or greater than the length of <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x06000422 RID: 1058 RVA: 0x00016A89 File Offset: 0x00014C89
		public bool IsMatch(string input, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Run(true, -1, input, 0, input.Length, startat) == null;
		}

		/// <summary>Searches the input string for the first occurrence of a regular expression, beginning at the specified starting position in the string.</summary>
		/// <param name="input">The string to search for a match. </param>
		/// <param name="startat">The zero-based character position at which to start the search. </param>
		/// <returns>An object that contains information about the match.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startat" /> is less than zero or greater than the length of <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x06000423 RID: 1059 RVA: 0x00016AAD File Offset: 0x00014CAD
		public Match Match(string input, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Run(false, -1, input, 0, input.Length, startat);
		}

		/// <summary>Searches the specified input string for all occurrences of a regular expression, beginning at the specified starting position in the string.</summary>
		/// <param name="input">The string to search for a match. </param>
		/// <param name="startat">The character position in the input string at which to start the search. </param>
		/// <returns>A collection of the <see cref="T:System.Text.RegularExpressions.Match" /> objects found by the search. If no matches are found, the method returns an empty collection object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startat" /> is less than zero or greater than the length of <paramref name="input" />.</exception>
		// Token: 0x06000424 RID: 1060 RVA: 0x00016ACE File Offset: 0x00014CCE
		public MatchCollection Matches(string input, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return new MatchCollection(this, input, 0, input.Length, startat);
		}

		/// <summary>In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string. Specified options modify the matching operation. </summary>
		/// <param name="input">The string to search for a match. </param>
		/// <param name="pattern">The regular expression pattern to match. </param>
		/// <param name="replacement">The replacement string. </param>
		/// <param name="options">A bitwise combination of the enumeration values that provide options for matching. </param>
		/// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If <paramref name="pattern" /> is not matched in the current instance, the method returns the current instance unchanged.</returns>
		/// <exception cref="T:System.ArgumentException">A regular expression parsing error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" />, <paramref name="pattern" />, or <paramref name="replacement" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="options" /> is not a valid bitwise combination of <see cref="T:System.Text.RegularExpressions.RegexOptions" /> values.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x06000425 RID: 1061 RVA: 0x00016AED File Offset: 0x00014CED
		public static string Replace(string input, string pattern, string replacement, RegexOptions options)
		{
			return Regex.Replace(input, pattern, replacement, options, Regex.s_defaultMatchTimeout);
		}

		/// <summary>In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string. Additional parameters specify options that modify the matching operation and a time-out interval if no match is found.</summary>
		/// <param name="input">The string to search for a match.</param>
		/// <param name="pattern">The regular expression pattern to match.</param>
		/// <param name="replacement">The replacement string.</param>
		/// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
		/// <param name="matchTimeout">A time-out interval, or <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" /> to indicate that the method should not time out.</param>
		/// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If <paramref name="pattern" /> is not matched in the current instance, the method returns the current instance unchanged. </returns>
		/// <exception cref="T:System.ArgumentException">A regular expression parsing error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" />, <paramref name="pattern" />, or <paramref name="replacement" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="options" /> is not a valid bitwise combination of <see cref="T:System.Text.RegularExpressions.RegexOptions" /> values.-or-
		///         <paramref name="matchTimeout" /> is negative, zero, or greater than approximately 24 days.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x06000426 RID: 1062 RVA: 0x00016AFD File Offset: 0x00014CFD
		public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).Replace(input, replacement);
		}

		/// <summary>In a specified input string, replaces all strings that match a regular expression pattern with a specified replacement string. </summary>
		/// <param name="input">The string to search for a match. </param>
		/// <param name="replacement">The replacement string. </param>
		/// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If the regular expression pattern is not matched in the current instance, the method returns the current instance unchanged. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> or <paramref name="replacement" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x06000427 RID: 1063 RVA: 0x00016B10 File Offset: 0x00014D10
		public string Replace(string input, string replacement)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Replace(input, replacement, -1, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>In a specified input substring, replaces a specified maximum number of strings that match a regular expression pattern with a specified replacement string. </summary>
		/// <param name="input">The string to search for a match. </param>
		/// <param name="replacement">The replacement string. </param>
		/// <param name="count">Maximum number of times the replacement can occur. </param>
		/// <param name="startat">The character position in the input string where the search begins. </param>
		/// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If the regular expression pattern is not matched in the current instance, the method returns the current instance unchanged. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> or <paramref name="replacement" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startat" /> is less than zero or greater than the length of <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
		// Token: 0x06000428 RID: 1064 RVA: 0x00016B3C File Offset: 0x00014D3C
		public string Replace(string input, string replacement, int count, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (replacement == null)
			{
				throw new ArgumentNullException("replacement");
			}
			return RegexReplacement.GetOrCreate(this._replref, replacement, this.caps, this.capsize, this.capnames, this.roptions).Replace(this, input, count, startat);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00016B94 File Offset: 0x00014D94
		static Regex()
		{
			Regex.s_defaultMatchTimeout = Regex.InitDefaultMatchTimeout();
		}

		/// <summary>Checks whether a time-out interval is within an acceptable range.</summary>
		/// <param name="matchTimeout">The time-out interval to check.</param>
		// Token: 0x0600042A RID: 1066 RVA: 0x00016BE4 File Offset: 0x00014DE4
		protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
			if (Regex.InfiniteMatchTimeout == matchTimeout)
			{
				return;
			}
			if (TimeSpan.Zero < matchTimeout && matchTimeout <= Regex.s_maximumMatchTimeout)
			{
				return;
			}
			throw new ArgumentOutOfRangeException("matchTimeout");
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00016C1C File Offset: 0x00014E1C
		private static TimeSpan InitDefaultMatchTimeout()
		{
			object data = AppDomain.CurrentDomain.GetData("REGEX_DEFAULT_MATCH_TIMEOUT");
			if (data == null)
			{
				return Regex.InfiniteMatchTimeout;
			}
			if (data is TimeSpan)
			{
				TimeSpan timeSpan = (TimeSpan)data;
				try
				{
					Regex.ValidateMatchTimeout(timeSpan);
				}
				catch (ArgumentOutOfRangeException)
				{
					throw new ArgumentOutOfRangeException(SR.Format("AppDomain data '{0}' contains an invalid value or object for specifying a default matching timeout for System.Text.RegularExpressions.Regex.", "REGEX_DEFAULT_MATCH_TIMEOUT", timeSpan));
				}
				return timeSpan;
			}
			throw new InvalidCastException(SR.Format("AppDomain data '{0}' contains an invalid value or object for specifying a default matching timeout for System.Text.RegularExpressions.Regex.", "REGEX_DEFAULT_MATCH_TIMEOUT", data));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.RegularExpressions.Regex" /> class for the specified regular expression.</summary>
		/// <param name="pattern">The regular expression pattern to match. </param>
		/// <exception cref="T:System.ArgumentException">A regular expression parsing error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="pattern" /> is <see langword="null" />.</exception>
		// Token: 0x0600042C RID: 1068 RVA: 0x00016C9C File Offset: 0x00014E9C
		public Regex(string pattern) : this(pattern, RegexOptions.None, Regex.s_defaultMatchTimeout, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.RegularExpressions.Regex" /> class for the specified regular expression, with options that modify the pattern.</summary>
		/// <param name="pattern">The regular expression pattern to match. </param>
		/// <param name="options">A bitwise combination of the enumeration values that modify the regular expression. </param>
		/// <exception cref="T:System.ArgumentException">A regular expression parsing error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="pattern" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="options" /> contains an invalid flag.</exception>
		// Token: 0x0600042D RID: 1069 RVA: 0x00016CAC File Offset: 0x00014EAC
		public Regex(string pattern, RegexOptions options) : this(pattern, options, Regex.s_defaultMatchTimeout, false)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data necessary to deserialize the current <see cref="T:System.Text.RegularExpressions.Regex" /> object.</summary>
		/// <param name="si">The object to populate with serialization information.</param>
		/// <param name="context">The place to store and retrieve serialized data. This parameter is reserved for future use.</param>
		// Token: 0x0600042E RID: 1070 RVA: 0x00016CBC File Offset: 0x00014EBC
		void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00016CC4 File Offset: 0x00014EC4
		private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
		{
			if (pattern == null)
			{
				throw new ArgumentNullException("pattern");
			}
			if (options < RegexOptions.None || options >> 10 != RegexOptions.None)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			if ((options & RegexOptions.ECMAScript) != RegexOptions.None && (options & ~(RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.ECMAScript | RegexOptions.CultureInvariant)) != RegexOptions.None)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			Regex.ValidateMatchTimeout(matchTimeout);
			this.pattern = pattern;
			this.roptions = options;
			this.internalMatchTimeout = matchTimeout;
			string cultureKey = ((options & RegexOptions.CultureInvariant) != RegexOptions.None) ? CultureInfo.InvariantCulture.ToString() : CultureInfo.CurrentCulture.ToString();
			Regex.CachedCodeEntryKey key = new Regex.CachedCodeEntryKey(options, cultureKey, pattern);
			Regex.CachedCodeEntry cachedCode = this.GetCachedCode(key, false);
			if (cachedCode == null)
			{
				RegexTree regexTree = RegexParser.Parse(pattern, this.roptions);
				this.capnames = regexTree.CapNames;
				this.capslist = regexTree.CapsList;
				this._code = RegexWriter.Write(regexTree);
				this.caps = this._code.Caps;
				this.capsize = this._code.CapSize;
				this.InitializeReferences();
				if (addToCache)
				{
					cachedCode = this.GetCachedCode(key, true);
				}
			}
			else
			{
				this.caps = cachedCode.Caps;
				this.capnames = cachedCode.Capnames;
				this.capslist = cachedCode.Capslist;
				this.capsize = cachedCode.Capsize;
				this._code = cachedCode.Code;
				this.factory = cachedCode.Factory;
				this._runnerref = cachedCode.Runnerref;
				this._replref = cachedCode.ReplRef;
				this._refsInitialized = true;
			}
			if (this.UseOptionC() && this.factory == null)
			{
				this.factory = this.Compile(this._code, this.roptions);
				if (addToCache && cachedCode != null)
				{
					cachedCode.AddCompiled(this.factory);
				}
				this._code = null;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00016E7B File Offset: 0x0001507B
		[MethodImpl(MethodImplOptions.NoInlining)]
		private RegexRunnerFactory Compile(RegexCode code, RegexOptions roptions)
		{
			return RegexCompiler.Compile(code, roptions);
		}

		/// <summary>Gets the options that were passed into the <see cref="T:System.Text.RegularExpressions.Regex" /> constructor.</summary>
		/// <returns>One or more members of the <see cref="T:System.Text.RegularExpressions.RegexOptions" /> enumeration that represent options that were passed to the <see cref="T:System.Text.RegularExpressions.Regex" /> constructor </returns>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00016E84 File Offset: 0x00015084
		public RegexOptions Options
		{
			get
			{
				return this.roptions;
			}
		}

		/// <summary>Gets a value that indicates whether the regular expression searches from right to left.</summary>
		/// <returns>
		///     <see langword="true" /> if the regular expression searches from right to left; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00016E8C File Offset: 0x0001508C
		public bool RightToLeft
		{
			get
			{
				return this.UseOptionR();
			}
		}

		/// <summary>Returns the regular expression pattern that was passed into the <see langword="Regex" /> constructor.</summary>
		/// <returns>The <paramref name="pattern" /> parameter that was passed into the <see langword="Regex" /> constructor.</returns>
		// Token: 0x06000433 RID: 1075 RVA: 0x00016E94 File Offset: 0x00015094
		public override string ToString()
		{
			return this.pattern;
		}

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		/// <exception cref="T:System.NotSupportedException">References have already been initialized. </exception>
		// Token: 0x06000434 RID: 1076 RVA: 0x00016E9C File Offset: 0x0001509C
		protected void InitializeReferences()
		{
			if (this._refsInitialized)
			{
				throw new NotSupportedException("This operation is only allowed once per object.");
			}
			this._refsInitialized = true;
			this._runnerref = new ExclusiveReference();
			this._replref = new WeakReference<RegexReplacement>(null);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00016ED0 File Offset: 0x000150D0
		internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			if (startat < 0 || startat > input.Length)
			{
				throw new ArgumentOutOfRangeException("startat", "Start index cannot be less than 0 or greater than input length.");
			}
			if (length < 0 || length > input.Length)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than 0 or exceed input length.");
			}
			RegexRunner regexRunner = this._runnerref.Get();
			if (regexRunner == null)
			{
				if (this.factory != null)
				{
					regexRunner = this.factory.CreateInstance();
				}
				else
				{
					regexRunner = new RegexInterpreter(this._code, this.UseOptionInvariant() ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture);
				}
			}
			Match result;
			try
			{
				result = regexRunner.Scan(this, input, beginning, beginning + length, startat, prevlen, quick, this.internalMatchTimeout);
			}
			finally
			{
				this._runnerref.Release(regexRunner);
			}
			return result;
		}

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Text.RegularExpressions.Regex.Options" /> property contains the <see cref="F:System.Text.RegularExpressions.RegexOptions.Compiled" /> option; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000436 RID: 1078 RVA: 0x000023F6 File Offset: 0x000005F6
		protected bool UseOptionC()
		{
			return false;
		}

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Text.RegularExpressions.Regex.Options" /> property contains the <see cref="F:System.Text.RegularExpressions.RegexOptions.RightToLeft" /> option; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000437 RID: 1079 RVA: 0x00016F9C File Offset: 0x0001519C
		protected internal bool UseOptionR()
		{
			return (this.roptions & RegexOptions.RightToLeft) > RegexOptions.None;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00016FAA File Offset: 0x000151AA
		internal bool UseOptionInvariant()
		{
			return (this.roptions & RegexOptions.CultureInvariant) > RegexOptions.None;
		}

		// Token: 0x040002B4 RID: 692
		private static int s_cacheSize = 15;

		// Token: 0x040002B5 RID: 693
		private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache = new Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry>(Regex.s_cacheSize);

		// Token: 0x040002B6 RID: 694
		private static int s_cacheCount = 0;

		// Token: 0x040002B7 RID: 695
		private static Regex.CachedCodeEntry s_cacheFirst;

		// Token: 0x040002B8 RID: 696
		private static Regex.CachedCodeEntry s_cacheLast;

		// Token: 0x040002B9 RID: 697
		private static readonly TimeSpan s_maximumMatchTimeout = TimeSpan.FromMilliseconds(2147483646.0);

		// Token: 0x040002BA RID: 698
		internal static readonly TimeSpan s_defaultMatchTimeout;

		/// <summary>Specifies that a pattern-matching operation should not time out.</summary>
		// Token: 0x040002BB RID: 699
		public static readonly TimeSpan InfiniteMatchTimeout = Timeout.InfiniteTimeSpan;

		/// <summary>The maximum amount of time that can elapse in a pattern-matching operation before the operation times out.</summary>
		// Token: 0x040002BC RID: 700
		protected internal TimeSpan internalMatchTimeout;

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		// Token: 0x040002BD RID: 701
		protected internal string pattern;

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		// Token: 0x040002BE RID: 702
		protected internal RegexOptions roptions;

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		// Token: 0x040002BF RID: 703
		protected internal RegexRunnerFactory factory;

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		// Token: 0x040002C0 RID: 704
		protected internal Hashtable caps;

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		// Token: 0x040002C1 RID: 705
		protected internal Hashtable capnames;

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		// Token: 0x040002C2 RID: 706
		protected internal string[] capslist;

		/// <summary>Used by a <see cref="T:System.Text.RegularExpressions.Regex" /> object generated by the <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" /> method. </summary>
		// Token: 0x040002C3 RID: 707
		protected internal int capsize;

		// Token: 0x040002C4 RID: 708
		internal ExclusiveReference _runnerref;

		// Token: 0x040002C5 RID: 709
		internal WeakReference<RegexReplacement> _replref;

		// Token: 0x040002C6 RID: 710
		internal RegexCode _code;

		// Token: 0x040002C7 RID: 711
		internal bool _refsInitialized;

		// Token: 0x020000A3 RID: 163
		internal readonly struct CachedCodeEntryKey : IEquatable<Regex.CachedCodeEntryKey>
		{
			// Token: 0x06000439 RID: 1081 RVA: 0x00016FBB File Offset: 0x000151BB
			public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern)
			{
				this._options = options;
				this._cultureKey = cultureKey;
				this._pattern = pattern;
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x00016FD2 File Offset: 0x000151D2
			public override bool Equals(object obj)
			{
				return obj is Regex.CachedCodeEntryKey && this.Equals((Regex.CachedCodeEntryKey)obj);
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00016FEA File Offset: 0x000151EA
			public bool Equals(Regex.CachedCodeEntryKey other)
			{
				return this._pattern.Equals(other._pattern) && this._options == other._options && this._cultureKey.Equals(other._cultureKey);
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00017020 File Offset: 0x00015220
			public static bool operator ==(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right)
			{
				return left.Equals(right);
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0001702A File Offset: 0x0001522A
			public override int GetHashCode()
			{
				return (int)(this._options ^ (RegexOptions)this._cultureKey.GetHashCode() ^ (RegexOptions)this._pattern.GetHashCode());
			}

			// Token: 0x040002C8 RID: 712
			private readonly RegexOptions _options;

			// Token: 0x040002C9 RID: 713
			private readonly string _cultureKey;

			// Token: 0x040002CA RID: 714
			private readonly string _pattern;
		}

		// Token: 0x020000A4 RID: 164
		internal sealed class CachedCodeEntry
		{
			// Token: 0x0600043E RID: 1086 RVA: 0x0001704C File Offset: 0x0001524C
			public CachedCodeEntry(Regex.CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
			{
				this.Key = key;
				this.Capnames = capnames;
				this.Capslist = capslist;
				this.Code = code;
				this.Caps = caps;
				this.Capsize = capsize;
				this.Runnerref = runner;
				this.ReplRef = replref;
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x0001709C File Offset: 0x0001529C
			public void AddCompiled(RegexRunnerFactory factory)
			{
				this.Factory = factory;
				this.Code = null;
			}

			// Token: 0x040002CB RID: 715
			public Regex.CachedCodeEntry Next;

			// Token: 0x040002CC RID: 716
			public Regex.CachedCodeEntry Previous;

			// Token: 0x040002CD RID: 717
			public readonly Regex.CachedCodeEntryKey Key;

			// Token: 0x040002CE RID: 718
			public RegexCode Code;

			// Token: 0x040002CF RID: 719
			public readonly Hashtable Caps;

			// Token: 0x040002D0 RID: 720
			public readonly Hashtable Capnames;

			// Token: 0x040002D1 RID: 721
			public readonly string[] Capslist;

			// Token: 0x040002D2 RID: 722
			public RegexRunnerFactory Factory;

			// Token: 0x040002D3 RID: 723
			public readonly int Capsize;

			// Token: 0x040002D4 RID: 724
			public readonly ExclusiveReference Runnerref;

			// Token: 0x040002D5 RID: 725
			public readonly WeakReference<RegexReplacement> ReplRef;
		}
	}
}
