using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x0200018A RID: 394
	[Serializable]
	internal class PathList
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000390B2 File Offset: 0x000372B2
		public int Count
		{
			get
			{
				return this.m_list.Count;
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000390C0 File Offset: 0x000372C0
		public int GetCookiesCount()
		{
			int num = 0;
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				foreach (object obj in this.m_list.Values)
				{
					CookieCollection cookieCollection = (CookieCollection)obj;
					num += cookieCollection.Count;
				}
			}
			return num;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00039150 File Offset: 0x00037350
		public ICollection Values
		{
			get
			{
				return this.m_list.Values;
			}
		}

		// Token: 0x17000206 RID: 518
		public object this[string s]
		{
			get
			{
				return this.m_list[s];
			}
			set
			{
				object syncRoot = this.SyncRoot;
				lock (syncRoot)
				{
					this.m_list[s] = value;
				}
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000391B4 File Offset: 0x000373B4
		public IEnumerator GetEnumerator()
		{
			return this.m_list.GetEnumerator();
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x000391C1 File Offset: 0x000373C1
		public object SyncRoot
		{
			get
			{
				return this.m_list.SyncRoot;
			}
		}

		// Token: 0x040007DA RID: 2010
		private SortedList m_list = SortedList.Synchronized(new SortedList(PathList.PathListComparer.StaticInstance));

		// Token: 0x0200018B RID: 395
		[Serializable]
		private class PathListComparer : IComparer
		{
			// Token: 0x06000AB8 RID: 2744 RVA: 0x000391D0 File Offset: 0x000373D0
			int IComparer.Compare(object ol, object or)
			{
				string text = CookieParser.CheckQuoted((string)ol);
				string text2 = CookieParser.CheckQuoted((string)or);
				int length = text.Length;
				int length2 = text2.Length;
				int num = Math.Min(length, length2);
				for (int i = 0; i < num; i++)
				{
					if (text[i] != text2[i])
					{
						return (int)(text[i] - text2[i]);
					}
				}
				return length2 - length;
			}

			// Token: 0x040007DB RID: 2011
			internal static readonly PathList.PathListComparer StaticInstance = new PathList.PathListComparer();
		}
	}
}
