using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq
{
	// Token: 0x02000042 RID: 66
	internal sealed class EmptyPartition<TElement> : IPartition<TElement>, IIListProvider<TElement>, IEnumerable<TElement>, IEnumerable, IEnumerator<!0>, IDisposable, IEnumerator
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x000072DD File Offset: 0x000054DD
		private EmptyPartition()
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerator<TElement> GetEnumerator()
		{
			return this;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00008049 File Offset: 0x00006249
		public bool MoveNext()
		{
			return false;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000804C File Offset: 0x0000624C
		[ExcludeFromCodeCoverage]
		public TElement Current
		{
			get
			{
				return default(TElement);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00008064 File Offset: 0x00006264
		[ExcludeFromCodeCoverage]
		object IEnumerator.Current
		{
			get
			{
				return default(TElement);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000532B File Offset: 0x0000352B
		void IEnumerator.Reset()
		{
			throw Error.NotSupported();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000073D5 File Offset: 0x000055D5
		void IDisposable.Dispose()
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00008080 File Offset: 0x00006280
		public TElement TryGetFirst(out bool found)
		{
			found = false;
			return default(TElement);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000809C File Offset: 0x0000629C
		public TElement TryGetLast(out bool found)
		{
			found = false;
			return default(TElement);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000080B5 File Offset: 0x000062B5
		public TElement[] ToArray()
		{
			return Array.Empty<TElement>();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000080BC File Offset: 0x000062BC
		public List<TElement> ToList()
		{
			return new List<TElement>();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008049 File Offset: 0x00006249
		public int GetCount(bool onlyIfCheap)
		{
			return 0;
		}

		// Token: 0x04000081 RID: 129
		public static readonly IPartition<TElement> Instance = new EmptyPartition<TElement>();
	}
}
