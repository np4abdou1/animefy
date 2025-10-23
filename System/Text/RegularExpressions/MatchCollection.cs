using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the set of successful matches found by iteratively applying a regular expression pattern to the input string.</summary>
	// Token: 0x0200009F RID: 159
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
	[Serializable]
	public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x00016470 File Offset: 0x00014670
		internal MatchCollection(Regex regex, string input, int beginning, int length, int startat)
		{
			if (startat < 0 || startat > input.Length)
			{
				throw new ArgumentOutOfRangeException("startat", "Start index cannot be less than 0 or greater than input length.");
			}
			this._regex = regex;
			this._input = input;
			this._beginning = beginning;
			this._length = length;
			this._startat = startat;
			this._prevlen = -1;
			this._matches = new List<Match>();
			this._done = false;
		}

		/// <summary>Gets a value that indicates whether the collection is read only.</summary>
		/// <returns>
		///     <see langword="true" /> in all cases. </returns>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00009518 File Offset: 0x00007718
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets the number of matches.</summary>
		/// <returns>The number of matches.</returns>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000164E0 File Offset: 0x000146E0
		public int Count
		{
			get
			{
				this.EnsureInitialized();
				return this._matches.Count;
			}
		}

		/// <summary>Gets an individual member of the collection.</summary>
		/// <param name="i">Index into the <see cref="T:System.Text.RegularExpressions.Match" /> collection. </param>
		/// <returns>The captured substring at position <paramref name="i" /> in the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="i" /> is less than 0 or greater than or equal to <see cref="P:System.Text.RegularExpressions.MatchCollection.Count" />. </exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
		// Token: 0x170000A7 RID: 167
		public virtual Match this[int i]
		{
			get
			{
				if (i < 0)
				{
					throw new ArgumentOutOfRangeException("i");
				}
				Match match = this.GetMatch(i);
				if (match == null)
				{
					throw new ArgumentOutOfRangeException("i");
				}
				return match;
			}
		}

		/// <summary>Provides an enumerator that iterates through the collection.</summary>
		/// <returns>An object that contains all <see cref="T:System.Text.RegularExpressions.Match" /> objects within the <see cref="T:System.Text.RegularExpressions.MatchCollection" />.</returns>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
		// Token: 0x060003F5 RID: 1013 RVA: 0x00016519 File Offset: 0x00014719
		public IEnumerator GetEnumerator()
		{
			return new MatchCollection.Enumerator(this);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00016519 File Offset: 0x00014719
		IEnumerator<Match> IEnumerable<Match>.GetEnumerator()
		{
			return new MatchCollection.Enumerator(this);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00016524 File Offset: 0x00014724
		private Match GetMatch(int i)
		{
			if (this._matches.Count > i)
			{
				return this._matches[i];
			}
			if (this._done)
			{
				return null;
			}
			for (;;)
			{
				Match match = this._regex.Run(false, this._prevlen, this._input, this._beginning, this._length, this._startat);
				if (!match.Success)
				{
					break;
				}
				this._matches.Add(match);
				this._prevlen = match.Length;
				this._startat = match._textpos;
				if (this._matches.Count > i)
				{
					return match;
				}
			}
			this._done = true;
			return null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000165C5 File Offset: 0x000147C5
		private void EnsureInitialized()
		{
			if (!this._done)
			{
				this.GetMatch(int.MaxValue);
			}
		}

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread-safe).</summary>
		/// <returns>
		///     <see langword="false" /> in all cases.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection. This property always returns the object itself.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00014B09 File Offset: 0x00012D09
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Copies all the elements of the collection to the given array starting at the given index.</summary>
		/// <param name="array">The array the collection is to be copied into. </param>
		/// <param name="arrayIndex">The position in the array where copying is to begin. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is a multi-dimensional array.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />.-or-
		///         <paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.MatchCollection.Count" /> is outside the bounds of <paramref name="array" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
		// Token: 0x060003FB RID: 1019 RVA: 0x000165DB File Offset: 0x000147DB
		public void CopyTo(Array array, int arrayIndex)
		{
			this.EnsureInitialized();
			((ICollection)this._matches).CopyTo(array, arrayIndex);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000165F0 File Offset: 0x000147F0
		public void CopyTo(Match[] array, int arrayIndex)
		{
			this.EnsureInitialized();
			this._matches.CopyTo(array, arrayIndex);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00016605 File Offset: 0x00014805
		int IList<Match>.IndexOf(Match item)
		{
			this.EnsureInitialized();
			return this._matches.IndexOf(item);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00016619 File Offset: 0x00014819
		void IList<Match>.Insert(int index, Match item)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00016619 File Offset: 0x00014819
		void IList<Match>.RemoveAt(int index)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x170000AA RID: 170
		Match IList<Match>.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new NotSupportedException("Collection is read-only.");
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00016619 File Offset: 0x00014819
		void ICollection<Match>.Add(Match item)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00016619 File Offset: 0x00014819
		void ICollection<Match>.Clear()
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001662E File Offset: 0x0001482E
		bool ICollection<Match>.Contains(Match item)
		{
			this.EnsureInitialized();
			return this._matches.Contains(item);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00016619 File Offset: 0x00014819
		bool ICollection<Match>.Remove(Match item)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00016619 File Offset: 0x00014819
		int IList.Add(object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00016619 File Offset: 0x00014819
		void IList.Clear()
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00016642 File Offset: 0x00014842
		bool IList.Contains(object value)
		{
			return value is Match && ((ICollection<Match>)this).Contains((Match)value);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001665A File Offset: 0x0001485A
		int IList.IndexOf(object value)
		{
			if (!(value is Match))
			{
				return -1;
			}
			return ((IList<Match>)this).IndexOf((Match)value);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00016619 File Offset: 0x00014819
		void IList.Insert(int index, object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00009518 File Offset: 0x00007718
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00016619 File Offset: 0x00014819
		void IList.Remove(object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00016619 File Offset: 0x00014819
		void IList.RemoveAt(int index)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x170000AC RID: 172
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new NotSupportedException("Collection is read-only.");
			}
		}

		// Token: 0x040002A7 RID: 679
		private readonly Regex _regex;

		// Token: 0x040002A8 RID: 680
		private readonly List<Match> _matches;

		// Token: 0x040002A9 RID: 681
		private bool _done;

		// Token: 0x040002AA RID: 682
		private readonly string _input;

		// Token: 0x040002AB RID: 683
		private readonly int _beginning;

		// Token: 0x040002AC RID: 684
		private readonly int _length;

		// Token: 0x040002AD RID: 685
		private int _startat;

		// Token: 0x040002AE RID: 686
		private int _prevlen;

		// Token: 0x020000A0 RID: 160
		[Serializable]
		private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
		{
			// Token: 0x06000410 RID: 1040 RVA: 0x00016672 File Offset: 0x00014872
			internal Enumerator(MatchCollection collection)
			{
				this._collection = collection;
				this._index = -1;
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x00016688 File Offset: 0x00014888
			public bool MoveNext()
			{
				if (this._index == -2)
				{
					return false;
				}
				this._index++;
				if (this._collection.GetMatch(this._index) == null)
				{
					this._index = -2;
					return false;
				}
				return true;
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x000166C2 File Offset: 0x000148C2
			public Match Current
			{
				get
				{
					if (this._index < 0)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._collection.GetMatch(this._index);
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x000166E9 File Offset: 0x000148E9
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x000166F1 File Offset: 0x000148F1
			void IEnumerator.Reset()
			{
				this._index = -1;
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00004D67 File Offset: 0x00002F67
			void IDisposable.Dispose()
			{
			}

			// Token: 0x040002AF RID: 687
			private readonly MatchCollection _collection;

			// Token: 0x040002B0 RID: 688
			private int _index;
		}
	}
}
