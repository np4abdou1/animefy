using System;

namespace System.Collections.Specialized
{
	// Token: 0x020002CE RID: 718
	internal sealed class ReadOnlyList : IList, ICollection, IEnumerable
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x0005A997 File Offset: 0x00058B97
		internal ReadOnlyList(IList list)
		{
			this._list = list;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x0005A9A6 File Offset: 0x00058BA6
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00009518 File Offset: 0x00007718
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00009518 File Offset: 0x00007718
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0005A9B3 File Offset: 0x00058BB3
		public bool IsSynchronized
		{
			get
			{
				return this._list.IsSynchronized;
			}
		}

		// Token: 0x170003E3 RID: 995
		public object this[int index]
		{
			get
			{
				return this._list[index];
			}
			set
			{
				throw new NotSupportedException("Collection is read-only.");
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0005A9CE File Offset: 0x00058BCE
		public object SyncRoot
		{
			get
			{
				return this._list.SyncRoot;
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00016619 File Offset: 0x00014819
		public int Add(object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00016619 File Offset: 0x00014819
		public void Clear()
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0005A9DB File Offset: 0x00058BDB
		public bool Contains(object value)
		{
			return this._list.Contains(value);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0005A9E9 File Offset: 0x00058BE9
		public void CopyTo(Array array, int index)
		{
			this._list.CopyTo(array, index);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0005A9F8 File Offset: 0x00058BF8
		public IEnumerator GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0005AA05 File Offset: 0x00058C05
		public int IndexOf(object value)
		{
			return this._list.IndexOf(value);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00016619 File Offset: 0x00014819
		public void Insert(int index, object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00016619 File Offset: 0x00014819
		public void Remove(object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00016619 File Offset: 0x00014819
		public void RemoveAt(int index)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x04000D40 RID: 3392
		private readonly IList _list;
	}
}
