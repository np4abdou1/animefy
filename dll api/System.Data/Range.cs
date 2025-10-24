using System;

namespace System.Data
{
	// Token: 0x0200007C RID: 124
	internal struct Range
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x00026ABC File Offset: 0x00024CBC
		public Range(int min, int max)
		{
			if (min > max)
			{
				throw ExceptionBuilder.RangeArgument(min, max);
			}
			this._min = min;
			this._max = max;
			this._isNotNull = true;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00026ADF File Offset: 0x00024CDF
		public int Count
		{
			get
			{
				if (!this.IsNull)
				{
					return this._max - this._min + 1;
				}
				return 0;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00026AFA File Offset: 0x00024CFA
		public bool IsNull
		{
			get
			{
				return !this._isNotNull;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00026B05 File Offset: 0x00024D05
		public int Max
		{
			get
			{
				this.CheckNull();
				return this._max;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00026B13 File Offset: 0x00024D13
		public int Min
		{
			get
			{
				this.CheckNull();
				return this._min;
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00026B21 File Offset: 0x00024D21
		internal void CheckNull()
		{
			if (this.IsNull)
			{
				throw ExceptionBuilder.NullRange();
			}
		}

		// Token: 0x0400027C RID: 636
		private int _min;

		// Token: 0x0400027D RID: 637
		private int _max;

		// Token: 0x0400027E RID: 638
		private bool _isNotNull;
	}
}
