using System;

namespace System.Linq
{
	// Token: 0x0200003E RID: 62
	internal abstract class EnumerableSorter<TElement>
	{
		// Token: 0x0600019A RID: 410
		internal abstract void ComputeKeys(TElement[] elements, int count);

		// Token: 0x0600019B RID: 411
		internal abstract int CompareAnyKeys(int index1, int index2);

		// Token: 0x0600019C RID: 412 RVA: 0x00007EFC File Offset: 0x000060FC
		private int[] ComputeMap(TElement[] elements, int count)
		{
			this.ComputeKeys(elements, count);
			int[] array = new int[count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}
			return array;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007F2C File Offset: 0x0000612C
		internal int[] Sort(TElement[] elements, int count)
		{
			int[] array = this.ComputeMap(elements, count);
			this.QuickSort(array, 0, count - 1);
			return array;
		}

		// Token: 0x0600019E RID: 414
		protected abstract void QuickSort(int[] map, int left, int right);
	}
}
