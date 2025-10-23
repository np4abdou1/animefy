using System;

namespace System.Collections.Generic
{
	// Token: 0x02000645 RID: 1605
	[Serializable]
	internal class ObjectEqualityComparer<T> : EqualityComparer<T>
	{
		// Token: 0x060030B1 RID: 12465 RVA: 0x000C47C6 File Offset: 0x000C29C6
		public override bool Equals(T x, T y)
		{
			if (x != null)
			{
				return y != null && x.Equals(y);
			}
			return y == null;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000C4572 File Offset: 0x000C2772
		public override int GetHashCode(T obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000C47FC File Offset: 0x000C29FC
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

		// Token: 0x060030B4 RID: 12468 RVA: 0x000C4870 File Offset: 0x000C2A70
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

		// Token: 0x060030B5 RID: 12469 RVA: 0x000C48E3 File Offset: 0x000C2AE3
		public override bool Equals(object obj)
		{
			return obj is ObjectEqualityComparer<T>;
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
