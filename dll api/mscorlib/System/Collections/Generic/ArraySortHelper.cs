using System;
using System.Threading;

namespace System.Collections.Generic
{
	// Token: 0x0200063B RID: 1595
	internal class ArraySortHelper<T>
	{
		// Token: 0x0600306B RID: 12395 RVA: 0x000C381C File Offset: 0x000C1A1C
		public void Sort(T[] keys, int index, int length, IComparer<T> comparer)
		{
			try
			{
				if (comparer == null)
				{
					comparer = Comparer<T>.Default;
				}
				ArraySortHelper<T>.IntrospectiveSort(keys, index, length, new Comparison<T>(comparer.Compare));
			}
			catch (IndexOutOfRangeException)
			{
				IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(comparer);
			}
			catch (ThreadAbortException)
			{
				throw;
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
			}
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x000C3890 File Offset: 0x000C1A90
		public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			int result;
			try
			{
				if (comparer == null)
				{
					comparer = Comparer<T>.Default;
				}
				result = ArraySortHelper<T>.InternalBinarySearch(array, index, length, value, comparer);
			}
			catch (ThreadAbortException)
			{
				throw;
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
			}
			return result;
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x000C38E4 File Offset: 0x000C1AE4
		internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer)
		{
			try
			{
				ArraySortHelper<T>.IntrospectiveSort(keys, index, length, comparer);
			}
			catch (IndexOutOfRangeException)
			{
				IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(comparer);
			}
			catch (ThreadAbortException)
			{
				throw;
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Failed to compare two elements in the array.", innerException);
			}
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x000C3940 File Offset: 0x000C1B40
		internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			int i = index;
			int num = index + length - 1;
			while (i <= num)
			{
				int num2 = i + (num - i >> 1);
				int num3 = comparer.Compare(array[num2], value);
				if (num3 == 0)
				{
					return num2;
				}
				if (num3 < 0)
				{
					i = num2 + 1;
				}
				else
				{
					num = num2 - 1;
				}
			}
			return ~i;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000C3988 File Offset: 0x000C1B88
		private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b)
		{
			if (a != b && comparer(keys[a], keys[b]) > 0)
			{
				T t = keys[a];
				keys[a] = keys[b];
				keys[b] = t;
			}
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000C39D0 File Offset: 0x000C1BD0
		private static void Swap(T[] a, int i, int j)
		{
			if (i != j)
			{
				T t = a[i];
				a[i] = a[j];
				a[j] = t;
			}
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x000C39FF File Offset: 0x000C1BFF
		internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer)
		{
			if (length < 2)
			{
				return;
			}
			ArraySortHelper<T>.IntroSort(keys, left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2PlusOne(length), comparer);
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x000C3A1C File Offset: 0x000C1C1C
		private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer)
		{
			while (hi > lo)
			{
				int num = hi - lo + 1;
				if (num <= 16)
				{
					if (num == 1)
					{
						return;
					}
					if (num == 2)
					{
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, lo, hi);
						return;
					}
					if (num == 3)
					{
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, lo, hi - 1);
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, lo, hi);
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, hi - 1, hi);
						return;
					}
					ArraySortHelper<T>.InsertionSort(keys, lo, hi, comparer);
					return;
				}
				else
				{
					if (depthLimit == 0)
					{
						ArraySortHelper<T>.Heapsort(keys, lo, hi, comparer);
						return;
					}
					depthLimit--;
					int num2 = ArraySortHelper<T>.PickPivotAndPartition(keys, lo, hi, comparer);
					ArraySortHelper<T>.IntroSort(keys, num2 + 1, hi, depthLimit, comparer);
					hi = num2 - 1;
				}
			}
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x000C3AB8 File Offset: 0x000C1CB8
		private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer)
		{
			int num = lo + (hi - lo) / 2;
			ArraySortHelper<T>.SwapIfGreater(keys, comparer, lo, num);
			ArraySortHelper<T>.SwapIfGreater(keys, comparer, lo, hi);
			ArraySortHelper<T>.SwapIfGreater(keys, comparer, num, hi);
			T t = keys[num];
			ArraySortHelper<T>.Swap(keys, num, hi - 1);
			int i = lo;
			int num2 = hi - 1;
			while (i < num2)
			{
				while (comparer(keys[++i], t) < 0)
				{
				}
				while (comparer(t, keys[--num2]) < 0)
				{
				}
				if (i >= num2)
				{
					break;
				}
				ArraySortHelper<T>.Swap(keys, i, num2);
			}
			ArraySortHelper<T>.Swap(keys, i, hi - 1);
			return i;
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000C3B48 File Offset: 0x000C1D48
		private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer)
		{
			int num = hi - lo + 1;
			for (int i = num / 2; i >= 1; i--)
			{
				ArraySortHelper<T>.DownHeap(keys, i, num, lo, comparer);
			}
			for (int j = num; j > 1; j--)
			{
				ArraySortHelper<T>.Swap(keys, lo, lo + j - 1);
				ArraySortHelper<T>.DownHeap(keys, 1, j - 1, lo, comparer);
			}
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x000C3B98 File Offset: 0x000C1D98
		private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer)
		{
			T t = keys[lo + i - 1];
			while (i <= n / 2)
			{
				int num = 2 * i;
				if (num < n && comparer(keys[lo + num - 1], keys[lo + num]) < 0)
				{
					num++;
				}
				if (comparer(t, keys[lo + num - 1]) >= 0)
				{
					break;
				}
				keys[lo + i - 1] = keys[lo + num - 1];
				i = num;
			}
			keys[lo + i - 1] = t;
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x000C3C20 File Offset: 0x000C1E20
		private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer)
		{
			for (int i = lo; i < hi; i++)
			{
				int num = i;
				T t = keys[i + 1];
				while (num >= lo && comparer(t, keys[num]) < 0)
				{
					keys[num + 1] = keys[num];
					num--;
				}
				keys[num + 1] = t;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x000C3C7A File Offset: 0x000C1E7A
		public static ArraySortHelper<T> Default
		{
			get
			{
				return ArraySortHelper<T>.s_defaultArraySortHelper;
			}
		}

		// Token: 0x04001946 RID: 6470
		private static readonly ArraySortHelper<T> s_defaultArraySortHelper = new ArraySortHelper<T>();
	}
}
