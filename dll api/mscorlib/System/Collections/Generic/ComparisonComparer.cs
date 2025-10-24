using System;

namespace System.Collections.Generic
{
	// Token: 0x02000641 RID: 1601
	[Serializable]
	internal class ComparisonComparer<T> : Comparer<T>
	{
		// Token: 0x06003098 RID: 12440 RVA: 0x000C42B5 File Offset: 0x000C24B5
		public ComparisonComparer(Comparison<T> comparison)
		{
			this._comparison = comparison;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000C42C4 File Offset: 0x000C24C4
		public override int Compare(T x, T y)
		{
			return this._comparison(x, y);
		}

		// Token: 0x04001949 RID: 6473
		private readonly Comparison<T> _comparison;
	}
}
