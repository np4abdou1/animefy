using System;

namespace System.Collections.Generic
{
	// Token: 0x0200063E RID: 1598
	[Serializable]
	internal class GenericComparer<T> : Comparer<T> where T : IComparable<T>
	{
		// Token: 0x0600308C RID: 12428 RVA: 0x000C41F1 File Offset: 0x000C23F1
		public override int Compare(T x, T y)
		{
			if (x != null)
			{
				if (y != null)
				{
					return x.CompareTo(y);
				}
				return 1;
			}
			else
			{
				if (y != null)
				{
					return -1;
				}
				return 0;
			}
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000C421F File Offset: 0x000C241F
		public override bool Equals(object obj)
		{
			return obj is GenericComparer<T>;
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
