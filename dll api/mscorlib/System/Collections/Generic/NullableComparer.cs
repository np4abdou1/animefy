using System;

namespace System.Collections.Generic
{
	// Token: 0x0200063F RID: 1599
	[Serializable]
	internal class NullableComparer<T> : Comparer<T?> where T : struct, IComparable<T>
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x000C4244 File Offset: 0x000C2444
		public override int Compare(T? x, T? y)
		{
			if (x != null)
			{
				if (y != null)
				{
					return x.value.CompareTo(y.value);
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

		// Token: 0x06003091 RID: 12433 RVA: 0x000C427F File Offset: 0x000C247F
		public override bool Equals(object obj)
		{
			return obj is NullableComparer<T>;
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
