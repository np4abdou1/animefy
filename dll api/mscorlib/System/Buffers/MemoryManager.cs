using System;

namespace System.Buffers
{
	// Token: 0x02000654 RID: 1620
	public abstract class MemoryManager<T>
	{
		// Token: 0x060030F6 RID: 12534
		public abstract Span<T> GetSpan();

		// Token: 0x060030F7 RID: 12535
		public abstract MemoryHandle Pin(int elementIndex = 0);

		// Token: 0x060030F8 RID: 12536 RVA: 0x000C5197 File Offset: 0x000C3397
		protected internal virtual bool TryGetArray(out ArraySegment<T> segment)
		{
			segment = default(ArraySegment<T>);
			return false;
		}
	}
}
