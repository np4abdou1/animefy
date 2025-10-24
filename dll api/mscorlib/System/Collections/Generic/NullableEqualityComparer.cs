using System;

namespace System.Collections.Generic
{
	// Token: 0x02000644 RID: 1604
	[Serializable]
	internal class NullableEqualityComparer<T> : EqualityComparer<T?> where T : struct, IEquatable<T>
	{
		// Token: 0x060030AA RID: 12458 RVA: 0x000C4679 File Offset: 0x000C2879
		public override bool Equals(T? x, T? y)
		{
			if (x != null)
			{
				return y != null && x.value.Equals(y.value);
			}
			return y == null;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x000C46B4 File Offset: 0x000C28B4
		public override int GetHashCode(T? obj)
		{
			return obj.GetHashCode();
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x000C46C4 File Offset: 0x000C28C4
		internal override int IndexOf(T?[] array, T? value, int startIndex, int count)
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
					if (array[j] != null && array[j].value.Equals(value.value))
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x000C473C File Offset: 0x000C293C
		internal override int LastIndexOf(T?[] array, T? value, int startIndex, int count)
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
					if (array[j] != null && array[j].value.Equals(value.value))
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x000C47B3 File Offset: 0x000C29B3
		public override bool Equals(object obj)
		{
			return obj is NullableEqualityComparer<T>;
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
