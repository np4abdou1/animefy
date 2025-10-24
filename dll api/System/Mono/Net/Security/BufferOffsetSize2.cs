using System;

namespace Mono.Net.Security
{
	// Token: 0x02000008 RID: 8
	internal class BufferOffsetSize2 : BufferOffsetSize
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000025ED File Offset: 0x000007ED
		public BufferOffsetSize2(int size) : base(new byte[size], 0, 0)
		{
			this.InitialSize = size;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002604 File Offset: 0x00000804
		public void Reset()
		{
			this.Offset = (this.Size = 0);
			this.TotalBytes = 0;
			this.Buffer = new byte[this.InitialSize];
			this.Complete = false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002640 File Offset: 0x00000840
		public void MakeRoom(int size)
		{
			if (base.Remaining >= size)
			{
				return;
			}
			int num = size - base.Remaining;
			if (this.Offset == 0 && this.Size == 0)
			{
				this.Buffer = new byte[size];
				return;
			}
			byte[] array = new byte[this.Buffer.Length + num];
			this.Buffer.CopyTo(array, 0);
			this.Buffer = array;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000026A1 File Offset: 0x000008A1
		public void AppendData(byte[] buffer, int offset, int size)
		{
			this.MakeRoom(size);
			System.Buffer.BlockCopy(buffer, offset, this.Buffer, base.EndOffset, size);
			this.Size += size;
		}

		// Token: 0x0400000E RID: 14
		public readonly int InitialSize;
	}
}
