using System;

namespace System.Collections.Generic
{
	// Token: 0x02000643 RID: 1603
	[Serializable]
	internal class GenericEqualityComparer<T> : EqualityComparer<T> where T : IEquatable<T>
	{
		// Token: 0x060030A3 RID: 12451 RVA: 0x000C4544 File Offset: 0x000C2744
		public override bool Equals(T x, T y)
		{
			if (x != null)
			{
				return y != null && x.Equals(y);
			}
			return y == null;
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x000C4572 File Offset: 0x000C2772
		public override int GetHashCode(T obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x000C458C File Offset: 0x000C278C
		internal override int IndexOf(T[] array, T value, int startIndex, int count)
		{
			int num = startIndex + count;
			if (value == null)
			{
				for (int i = startIndex; i < num; i++)
				{
					if (array[i] == null)
					{
						return i;
					}
				}
			}
			else
			{
				for (int j = startIndex; j < num; j++)
				{
					if (array[j] != null && array[j].Equals(value))
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x000C45F8 File Offset: 0x000C27F8
		internal override int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			int num = startIndex - count + 1;
			if (value == null)
			{
				for (int i = startIndex; i >= num; i--)
				{
					if (array[i] == null)
					{
						return i;
					}
				}
			}
			else
			{
				for (int j = startIndex; j >= num; j--)
				{
					if (array[j] != null && array[j].Equals(value))
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x000C4666 File Offset: 0x000C2866
		public override bool Equals(object obj)
		{
			return obj is GenericEqualityComparer<T>;
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
