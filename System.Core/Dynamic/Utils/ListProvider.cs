using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace System.Dynamic.Utils
{
	// Token: 0x0200013D RID: 317
	internal abstract class ListProvider<T> : IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable where T : class
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060009F7 RID: 2551
		protected abstract T First { get; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060009F8 RID: 2552
		protected abstract int ElementCount { get; }

		// Token: 0x060009F9 RID: 2553
		protected abstract T GetElement(int index);

		// Token: 0x060009FA RID: 2554 RVA: 0x00025874 File Offset: 0x00023A74
		public int IndexOf(T item)
		{
			if (this.First == item)
			{
				return 0;
			}
			int i = 1;
			int elementCount = this.ElementCount;
			while (i < elementCount)
			{
				if (this.GetElement(i) == item)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void Insert(int index, T item)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void RemoveAt(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x170001B9 RID: 441
		public T this[int index]
		{
			get
			{
				if (index == 0)
				{
					return this.First;
				}
				return this.GetElement(index);
			}
			[ExcludeFromCodeCoverage]
			set
			{
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void Add(T item)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void Clear()
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000258D3 File Offset: 0x00023AD3
		public bool Contains(T item)
		{
			return this.IndexOf(item) != -1;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000258E4 File Offset: 0x00023AE4
		public void CopyTo(T[] array, int index)
		{
			ContractUtils.RequiresNotNull(array, "array");
			if (index < 0)
			{
				throw Error.ArgumentOutOfRange("index");
			}
			int elementCount = this.ElementCount;
			if (index + elementCount > array.Length)
			{
				throw new ArgumentException();
			}
			array[index++] = this.First;
			for (int i = 1; i < elementCount; i++)
			{
				array[index++] = this.GetElement(i);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00025951 File Offset: 0x00023B51
		public int Count
		{
			get
			{
				return this.ElementCount;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00007357 File Offset: 0x00005557
		[ExcludeFromCodeCoverage]
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public bool Remove(T item)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00025959 File Offset: 0x00023B59
		public IEnumerator<T> GetEnumerator()
		{
			yield return this.First;
			int i = 1;
			int j = this.ElementCount;
			while (i < j)
			{
				yield return this.GetElement(i);
				int num = i;
				i = num + 1;
			}
			yield break;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00025968 File Offset: 0x00023B68
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
