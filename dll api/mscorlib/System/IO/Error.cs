using System;

namespace System.IO
{
	// Token: 0x02000523 RID: 1315
	internal static class Error
	{
		// Token: 0x060026CA RID: 9930 RVA: 0x0009ADF6 File Offset: 0x00098FF6
		internal static Exception GetStreamIsClosed()
		{
			return new ObjectDisposedException(null, "Cannot access a closed Stream.");
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0009AE03 File Offset: 0x00099003
		internal static Exception GetEndOfFile()
		{
			return new EndOfStreamException("Unable to read beyond the end of the stream.");
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0009AE0F File Offset: 0x0009900F
		internal static Exception GetReadNotSupported()
		{
			return new NotSupportedException("Stream does not support reading.");
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0009AE1B File Offset: 0x0009901B
		internal static Exception GetWriteNotSupported()
		{
			return new NotSupportedException("Stream does not support writing.");
		}
	}
}
