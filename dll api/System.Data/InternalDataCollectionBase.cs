using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace System.Data
{
	/// <summary>Provides the base functionality for creating collections.</summary>
	// Token: 0x02000005 RID: 5
	public class InternalDataCollectionBase : ICollection, IEnumerable
	{
		/// <summary>Gets the total number of elements in a collection.</summary>
		/// <returns>The total number of elements in a collection.</returns>
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002093 File Offset: 0x00000293
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				return this.List.Count;
			}
		}

		/// <summary>Copies all the elements of the current <see cref="T:System.Data.InternalDataCollectionBase" /> to a one-dimensional <see cref="T:System.Array" />, starting at the specified <see cref="T:System.Data.InternalDataCollectionBase" /> index.</summary>
		/// <param name="ar">The one-dimensional <see cref="T:System.Array" /> to copy the current <see cref="T:System.Data.InternalDataCollectionBase" /> object's elements into. </param>
		/// <param name="index">The destination <see cref="T:System.Array" /> index to start copying into. </param>
		// Token: 0x06000007 RID: 7 RVA: 0x000020A0 File Offset: 0x000002A0
		public virtual void CopyTo(Array ar, int index)
		{
			this.List.CopyTo(ar, index);
		}

		/// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> for the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the collection.</returns>
		// Token: 0x06000008 RID: 8 RVA: 0x000020AF File Offset: 0x000002AF
		public virtual IEnumerator GetEnumerator()
		{
			return this.List.GetEnumerator();
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Data.InternalDataCollectionBase" /> is synchonized.</summary>
		/// <returns>
		///     <see langword="true" /> if the collection is synchronized; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020BC File Offset: 0x000002BC
		[Browsable(false)]
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020BF File Offset: 0x000002BF
		internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale)
		{
			if (fCaseSensitive)
			{
				if (string.Compare(s1, s2, false, locale) != 0)
				{
					return 0;
				}
				return 1;
			}
			else
			{
				if (locale.CompareInfo.Compare(s1, s2, CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth) != 0)
				{
					return 0;
				}
				if (string.Compare(s1, s2, false, locale) != 0)
				{
					return -1;
				}
				return 1;
			}
		}

		/// <summary>Gets an object that can be used to synchronize the collection.</summary>
		/// <returns>The <see cref="T:System.object" /> used to synchronize the collection.</returns>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Browsable(false)]
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets the items of the collection as a list.</summary>
		/// <returns>An <see cref="T:System.Collections.ArrayList" /> that contains the collection.</returns>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020F7 File Offset: 0x000002F7
		protected virtual ArrayList List
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400000E RID: 14
		internal static readonly CollectionChangeEventArgs s_refreshEventArgs = new CollectionChangeEventArgs(CollectionChangeAction.Refresh, null);
	}
}
