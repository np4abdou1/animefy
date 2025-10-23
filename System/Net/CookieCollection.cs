using System;
using System.Collections;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
	// Token: 0x02000185 RID: 389
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.CookieCollection" /> class.</summary>
		// Token: 0x06000A8E RID: 2702 RVA: 0x00037D9C File Offset: 0x00035F9C
		public CookieCollection()
		{
			this.m_IsReadOnly = true;
		}

		/// <summary>Gets the <see cref="T:System.Net.Cookie" /> with a specific index from a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Net.Cookie" /> to be found. </param>
		/// <returns>A <see cref="T:System.Net.Cookie" /> with a specific index from a <see cref="T:System.Net.CookieCollection" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0 or <paramref name="index" /> is greater than or equal to <see cref="P:System.Net.CookieCollection.Count" />. </exception>
		// Token: 0x170001FC RID: 508
		public Cookie this[int index]
		{
			get
			{
				if (index < 0 || index >= this.m_list.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return (Cookie)this.m_list[index];
			}
		}

		/// <summary>Adds a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to a <see cref="T:System.Net.CookieCollection" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="cookie" /> is <see langword="null" />. </exception>
		// Token: 0x06000A90 RID: 2704 RVA: 0x00037DF4 File Offset: 0x00035FF4
		public void Add(Cookie cookie)
		{
			if (cookie == null)
			{
				throw new ArgumentNullException("cookie");
			}
			this.m_version++;
			int num = this.IndexOf(cookie);
			if (num == -1)
			{
				this.m_list.Add(cookie);
				return;
			}
			this.m_list[num] = cookie;
		}

		/// <summary>Adds the contents of a <see cref="T:System.Net.CookieCollection" /> to the current instance.</summary>
		/// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="cookies" /> is <see langword="null" />. </exception>
		// Token: 0x06000A91 RID: 2705 RVA: 0x00037E44 File Offset: 0x00036044
		public void Add(CookieCollection cookies)
		{
			if (cookies == null)
			{
				throw new ArgumentNullException("cookies");
			}
			foreach (object obj in cookies)
			{
				Cookie cookie = (Cookie)obj;
				this.Add(cookie);
			}
		}

		/// <summary>Gets the number of cookies contained in a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>The number of cookies contained in a <see cref="T:System.Net.CookieCollection" />.</returns>
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00037EA8 File Offset: 0x000360A8
		public int Count
		{
			get
			{
				return this.m_list.Count;
			}
		}

		/// <summary>Gets a value that indicates whether access to a <see cref="T:System.Net.CookieCollection" /> is thread safe.</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Net.CookieCollection" /> is thread safe; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object to synchronize access to the <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>An object to synchronize access to the <see cref="T:System.Net.CookieCollection" />.</returns>
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00014B09 File Offset: 0x00012D09
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Copies the elements of a <see cref="T:System.Net.CookieCollection" /> to an instance of the <see cref="T:System.Array" /> class, starting at a particular index.</summary>
		/// <param name="array">The target <see cref="T:System.Array" /> to which the <see cref="T:System.Net.CookieCollection" /> will be copied. </param>
		/// <param name="index">The zero-based index in the target <see cref="T:System.Array" /> where copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in this <see cref="T:System.Net.CookieCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The elements in this <see cref="T:System.Net.CookieCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06000A95 RID: 2709 RVA: 0x00037EB5 File Offset: 0x000360B5
		public void CopyTo(Array array, int index)
		{
			this.m_list.CopyTo(array, index);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00037EC4 File Offset: 0x000360C4
		internal DateTime TimeStamp(CookieCollection.Stamp how)
		{
			switch (how)
			{
			case CookieCollection.Stamp.Set:
				this.m_TimeStamp = DateTime.Now;
				break;
			case CookieCollection.Stamp.SetToUnused:
				this.m_TimeStamp = DateTime.MinValue;
				break;
			case CookieCollection.Stamp.SetToMaxUsed:
				this.m_TimeStamp = DateTime.MaxValue;
				break;
			}
			return this.m_TimeStamp;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00037F14 File Offset: 0x00036114
		internal bool IsOtherVersionSeen
		{
			get
			{
				return this.m_has_other_versions;
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00037F1C File Offset: 0x0003611C
		internal int InternalAdd(Cookie cookie, bool isStrict)
		{
			int result = 1;
			if (isStrict)
			{
				IComparer comparer = Cookie.GetComparer();
				int num = 0;
				foreach (object obj in this.m_list)
				{
					Cookie cookie2 = (Cookie)obj;
					if (comparer.Compare(cookie, cookie2) == 0)
					{
						result = 0;
						if (cookie2.Variant <= cookie.Variant)
						{
							this.m_list[num] = cookie;
							break;
						}
						break;
					}
					else
					{
						num++;
					}
				}
				if (num == this.m_list.Count)
				{
					this.m_list.Add(cookie);
				}
			}
			else
			{
				this.m_list.Add(cookie);
			}
			if (cookie.Version != 1)
			{
				this.m_has_other_versions = true;
			}
			return result;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00037FEC File Offset: 0x000361EC
		internal int IndexOf(Cookie cookie)
		{
			IComparer comparer = Cookie.GetComparer();
			int num = 0;
			foreach (object obj in this.m_list)
			{
				Cookie y = (Cookie)obj;
				if (comparer.Compare(cookie, y) == 0)
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00038060 File Offset: 0x00036260
		internal void RemoveAt(int idx)
		{
			this.m_list.RemoveAt(idx);
		}

		/// <summary>Gets an enumerator that can iterate through a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>An instance of an implementation of an <see cref="T:System.Collections.IEnumerator" /> interface that can iterate through a <see cref="T:System.Net.CookieCollection" />.</returns>
		// Token: 0x06000A9B RID: 2715 RVA: 0x0003806E File Offset: 0x0003626E
		public IEnumerator GetEnumerator()
		{
			return new CookieCollection.CookieCollectionEnumerator(this);
		}

		// Token: 0x040007C3 RID: 1987
		internal int m_version;

		// Token: 0x040007C4 RID: 1988
		private ArrayList m_list = new ArrayList();

		// Token: 0x040007C5 RID: 1989
		private DateTime m_TimeStamp = DateTime.MinValue;

		// Token: 0x040007C6 RID: 1990
		private bool m_has_other_versions;

		// Token: 0x040007C7 RID: 1991
		[OptionalField]
		private bool m_IsReadOnly;

		// Token: 0x02000186 RID: 390
		internal enum Stamp
		{
			// Token: 0x040007C9 RID: 1993
			Check,
			// Token: 0x040007CA RID: 1994
			Set,
			// Token: 0x040007CB RID: 1995
			SetToUnused,
			// Token: 0x040007CC RID: 1996
			SetToMaxUsed
		}

		// Token: 0x02000187 RID: 391
		private class CookieCollectionEnumerator : IEnumerator
		{
			// Token: 0x06000A9C RID: 2716 RVA: 0x00038076 File Offset: 0x00036276
			internal CookieCollectionEnumerator(CookieCollection cookies)
			{
				this.m_cookies = cookies;
				this.m_count = cookies.Count;
				this.m_version = cookies.m_version;
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000380A4 File Offset: 0x000362A4
			object IEnumerator.Current
			{
				get
				{
					if (this.m_index < 0 || this.m_index >= this.m_count)
					{
						throw new InvalidOperationException(SR.GetString("Enumeration has either not started or has already finished."));
					}
					if (this.m_version != this.m_cookies.m_version)
					{
						throw new InvalidOperationException(SR.GetString("Collection was modified; enumeration operation may not execute."));
					}
					return this.m_cookies[this.m_index];
				}
			}

			// Token: 0x06000A9E RID: 2718 RVA: 0x0003810C File Offset: 0x0003630C
			bool IEnumerator.MoveNext()
			{
				if (this.m_version != this.m_cookies.m_version)
				{
					throw new InvalidOperationException(SR.GetString("Collection was modified; enumeration operation may not execute."));
				}
				int num = this.m_index + 1;
				this.m_index = num;
				if (num < this.m_count)
				{
					return true;
				}
				this.m_index = this.m_count;
				return false;
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x00038164 File Offset: 0x00036364
			void IEnumerator.Reset()
			{
				this.m_index = -1;
			}

			// Token: 0x040007CD RID: 1997
			private CookieCollection m_cookies;

			// Token: 0x040007CE RID: 1998
			private int m_count;

			// Token: 0x040007CF RID: 1999
			private int m_index = -1;

			// Token: 0x040007D0 RID: 2000
			private int m_version;
		}
	}
}
