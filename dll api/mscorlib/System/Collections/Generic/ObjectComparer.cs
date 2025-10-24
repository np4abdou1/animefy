using System;

namespace System.Collections.Generic
{
	// Token: 0x02000640 RID: 1600
	[Serializable]
	internal class ObjectComparer<T> : Comparer<T>
	{
		// Token: 0x06003094 RID: 12436 RVA: 0x000C4292 File Offset: 0x000C2492
		public override int Compare(T x, T y)
		{
			return Comparer.Default.Compare(x, y);
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x000C42AA File Offset: 0x000C24AA
		public override bool Equals(object obj)
		{
			return obj is ObjectComparer<T>;
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
