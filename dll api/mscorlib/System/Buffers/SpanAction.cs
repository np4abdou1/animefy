using System;

namespace System.Buffers
{
	// Token: 0x0200064C RID: 1612
	// (Invoke) Token: 0x060030D8 RID: 12504
	public delegate void SpanAction<T, in TArg>(Span<T> span, TArg arg);
}
