using System;
using System.IO;

namespace System.Data.SqlTypes
{
	// Token: 0x020000C6 RID: 198
	internal abstract class SqlStreamChars : INullable, IDisposable
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000DCA RID: 3530
		public abstract bool IsNull { get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000DCB RID: 3531
		public abstract long Length { get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000DCC RID: 3532
		public abstract long Position { get; }

		// Token: 0x06000DCD RID: 3533
		public abstract int Read(char[] buffer, int offset, int count);

		// Token: 0x06000DCE RID: 3534
		public abstract void Write(char[] buffer, int offset, int count);

		// Token: 0x06000DCF RID: 3535
		public abstract long Seek(long offset, SeekOrigin origin);

		// Token: 0x06000DD0 RID: 3536
		public abstract void SetLength(long value);

		// Token: 0x06000DD1 RID: 3537 RVA: 0x000464C0 File Offset: 0x000446C0
		void IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000057B2 File Offset: 0x000039B2
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
