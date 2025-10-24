using System;

namespace System.Net
{
	// Token: 0x0200016C RID: 364
	internal class BufferOffsetSize
	{
		// Token: 0x06000A04 RID: 2564 RVA: 0x000352D8 File Offset: 0x000334D8
		internal BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer)
		{
			if (copyBuffer)
			{
				byte[] array = new byte[size];
				System.Buffer.BlockCopy(buffer, offset, array, 0, size);
				offset = 0;
				buffer = array;
			}
			this.Buffer = buffer;
			this.Offset = offset;
			this.Size = size;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0003531B File Offset: 0x0003351B
		internal BufferOffsetSize(byte[] buffer, bool copyBuffer) : this(buffer, 0, buffer.Length, copyBuffer)
		{
		}

		// Token: 0x0400074D RID: 1869
		internal byte[] Buffer;

		// Token: 0x0400074E RID: 1870
		internal int Offset;

		// Token: 0x0400074F RID: 1871
		internal int Size;
	}
}
