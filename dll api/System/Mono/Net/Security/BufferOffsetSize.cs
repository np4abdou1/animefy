using System;

namespace Mono.Net.Security
{
	// Token: 0x02000007 RID: 7
	internal class BufferOffsetSize
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002541 File Offset: 0x00000741
		public int EndOffset
		{
			get
			{
				return this.Offset + this.Size;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002550 File Offset: 0x00000750
		public int Remaining
		{
			get
			{
				return this.Buffer.Length - this.Offset - this.Size;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002568 File Offset: 0x00000768
		public BufferOffsetSize(byte[] buffer, int offset, int size)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || offset + size > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("size");
			}
			this.Buffer = buffer;
			this.Offset = offset;
			this.Size = size;
			this.Complete = false;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025CB File Offset: 0x000007CB
		public override string ToString()
		{
			return string.Format("[BufferOffsetSize: {0} {1}]", this.Offset, this.Size);
		}

		// Token: 0x04000009 RID: 9
		public byte[] Buffer;

		// Token: 0x0400000A RID: 10
		public int Offset;

		// Token: 0x0400000B RID: 11
		public int Size;

		// Token: 0x0400000C RID: 12
		public int TotalBytes;

		// Token: 0x0400000D RID: 13
		public bool Complete;
	}
}
