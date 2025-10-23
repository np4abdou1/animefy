using System;

namespace System.Threading
{
	// Token: 0x020001C3 RID: 451
	internal struct SparselyPopulatedArrayAddInfo<T> where T : class
	{
		// Token: 0x060010CA RID: 4298 RVA: 0x000456AA File Offset: 0x000438AA
		internal SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
		{
			this._source = source;
			this._index = index;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x000456BA File Offset: 0x000438BA
		internal SparselyPopulatedArrayFragment<T> Source
		{
			get
			{
				return this._source;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x000456C2 File Offset: 0x000438C2
		internal int Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x04000669 RID: 1641
		private SparselyPopulatedArrayFragment<T> _source;

		// Token: 0x0400066A RID: 1642
		private int _index;
	}
}
