using System;

namespace System.Threading
{
	// Token: 0x020001C4 RID: 452
	internal class SparselyPopulatedArrayFragment<T> where T : class
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x000456CA File Offset: 0x000438CA
		internal SparselyPopulatedArrayFragment(int size) : this(size, null)
		{
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000456D4 File Offset: 0x000438D4
		internal SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
		{
			this._elements = new T[size];
			this._freeCount = size;
			this._prev = prev;
		}

		// Token: 0x17000195 RID: 405
		internal T this[int index]
		{
			get
			{
				return Volatile.Read<T>(ref this._elements[index]);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0004570D File Offset: 0x0004390D
		internal int Length
		{
			get
			{
				return this._elements.Length;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00045717 File Offset: 0x00043917
		internal SparselyPopulatedArrayFragment<T> Prev
		{
			get
			{
				return this._prev;
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00045724 File Offset: 0x00043924
		internal T SafeAtomicRemove(int index, T expectedElement)
		{
			T t = Interlocked.CompareExchange<T>(ref this._elements[index], default(T), expectedElement);
			if (t != null)
			{
				this._freeCount++;
			}
			return t;
		}

		// Token: 0x0400066B RID: 1643
		internal readonly T[] _elements;

		// Token: 0x0400066C RID: 1644
		internal volatile int _freeCount;

		// Token: 0x0400066D RID: 1645
		internal volatile SparselyPopulatedArrayFragment<T> _next;

		// Token: 0x0400066E RID: 1646
		internal volatile SparselyPopulatedArrayFragment<T> _prev;
	}
}
