using System;

namespace System.Threading
{
	// Token: 0x020001C2 RID: 450
	internal class SparselyPopulatedArray<T> where T : class
	{
		// Token: 0x060010C7 RID: 4295 RVA: 0x00045508 File Offset: 0x00043708
		internal SparselyPopulatedArray(int initialSize)
		{
			this._head = (this._tail = new SparselyPopulatedArrayFragment<T>(initialSize));
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00045532 File Offset: 0x00043732
		internal SparselyPopulatedArrayFragment<T> Tail
		{
			get
			{
				return this._tail;
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0004553C File Offset: 0x0004373C
		internal SparselyPopulatedArrayAddInfo<T> Add(T element)
		{
			SparselyPopulatedArrayFragment<T> sparselyPopulatedArrayFragment2;
			int num2;
			for (;;)
			{
				SparselyPopulatedArrayFragment<T> sparselyPopulatedArrayFragment = this._tail;
				while (sparselyPopulatedArrayFragment._next != null)
				{
					sparselyPopulatedArrayFragment = (this._tail = sparselyPopulatedArrayFragment._next);
				}
				for (sparselyPopulatedArrayFragment2 = sparselyPopulatedArrayFragment; sparselyPopulatedArrayFragment2 != null; sparselyPopulatedArrayFragment2 = sparselyPopulatedArrayFragment2._prev)
				{
					if (sparselyPopulatedArrayFragment2._freeCount < 1)
					{
						sparselyPopulatedArrayFragment2._freeCount--;
					}
					if (sparselyPopulatedArrayFragment2._freeCount > 0 || sparselyPopulatedArrayFragment2._freeCount < -10)
					{
						int length = sparselyPopulatedArrayFragment2.Length;
						int num = (length - sparselyPopulatedArrayFragment2._freeCount) % length;
						if (num < 0)
						{
							num = 0;
							sparselyPopulatedArrayFragment2._freeCount--;
						}
						for (int i = 0; i < length; i++)
						{
							num2 = (num + i) % length;
							if (sparselyPopulatedArrayFragment2._elements[num2] == null && Interlocked.CompareExchange<T>(ref sparselyPopulatedArrayFragment2._elements[num2], element, default(T)) == null)
							{
								goto Block_5;
							}
						}
					}
				}
				SparselyPopulatedArrayFragment<T> sparselyPopulatedArrayFragment3 = new SparselyPopulatedArrayFragment<T>((sparselyPopulatedArrayFragment._elements.Length == 4096) ? 4096 : (sparselyPopulatedArrayFragment._elements.Length * 2), sparselyPopulatedArrayFragment);
				if (Interlocked.CompareExchange<SparselyPopulatedArrayFragment<T>>(ref sparselyPopulatedArrayFragment._next, sparselyPopulatedArrayFragment3, null) == null)
				{
					this._tail = sparselyPopulatedArrayFragment3;
				}
			}
			Block_5:
			int num3 = sparselyPopulatedArrayFragment2._freeCount - 1;
			sparselyPopulatedArrayFragment2._freeCount = ((num3 > 0) ? num3 : 0);
			return new SparselyPopulatedArrayAddInfo<T>(sparselyPopulatedArrayFragment2, num2);
		}

		// Token: 0x04000667 RID: 1639
		private readonly SparselyPopulatedArrayFragment<T> _head;

		// Token: 0x04000668 RID: 1640
		private volatile SparselyPopulatedArrayFragment<T> _tail;
	}
}
