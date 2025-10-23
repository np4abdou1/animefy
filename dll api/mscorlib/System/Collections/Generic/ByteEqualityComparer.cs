using System;
using System.Security;

namespace System.Collections.Generic
{
	// Token: 0x02000646 RID: 1606
	[Serializable]
	internal class ByteEqualityComparer : EqualityComparer<byte>
	{
		// Token: 0x060030B8 RID: 12472 RVA: 0x000C48EE File Offset: 0x000C2AEE
		public override bool Equals(byte x, byte y)
		{
			return x == y;
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x000C48F4 File Offset: 0x000C2AF4
		public override int GetHashCode(byte b)
		{
			return b.GetHashCode();
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000C4900 File Offset: 0x000C2B00
		[SecuritySafeCritical]
		internal unsafe override int IndexOf(byte[] array, byte value, int startIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("Index was out of range. Must be non-negative and less than the size of the collection."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Count must be positive and count must refer to a location within the string/array/collection."));
			}
			if (count > array.Length - startIndex)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			if (count == 0)
			{
				return -1;
			}
			byte* src;
			if (array == null || array.Length == 0)
			{
				src = null;
			}
			else
			{
				src = &array[0];
			}
			return Buffer.IndexOfByte(src, value, startIndex, count);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000C4990 File Offset: 0x000C2B90
		internal override int LastIndexOf(byte[] array, byte value, int startIndex, int count)
		{
			int num = startIndex - count + 1;
			for (int i = startIndex; i >= num; i--)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x000C49B9 File Offset: 0x000C2BB9
		public override bool Equals(object obj)
		{
			return obj is ByteEqualityComparer;
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
