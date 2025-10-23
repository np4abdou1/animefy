using System;

namespace System
{
	// Token: 0x020000C1 RID: 193
	internal interface ISpanFormattable
	{
		// Token: 0x0600063B RID: 1595
		bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
	}
}
