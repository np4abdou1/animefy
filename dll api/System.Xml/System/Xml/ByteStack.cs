using System;

namespace System.Xml
{
	// Token: 0x0200001E RID: 30
	internal class ByteStack
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00008219 File Offset: 0x00006419
		public ByteStack(int growthRate)
		{
			this.growthRate = growthRate;
			this.top = 0;
			this.stack = new byte[growthRate];
			this.size = growthRate;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00008244 File Offset: 0x00006444
		public void Push(byte data)
		{
			if (this.size == this.top)
			{
				byte[] dst = new byte[this.size + this.growthRate];
				if (this.top > 0)
				{
					Buffer.BlockCopy(this.stack, 0, dst, 0, this.top);
				}
				this.stack = dst;
				this.size += this.growthRate;
			}
			byte[] array = this.stack;
			int num = this.top;
			this.top = num + 1;
			array[num] = data;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000082C4 File Offset: 0x000064C4
		public byte Pop()
		{
			if (this.top > 0)
			{
				byte[] array = this.stack;
				int num = this.top - 1;
				this.top = num;
				return array[num];
			}
			return 0;
		}

		// Token: 0x040000F0 RID: 240
		private byte[] stack;

		// Token: 0x040000F1 RID: 241
		private int growthRate;

		// Token: 0x040000F2 RID: 242
		private int top;

		// Token: 0x040000F3 RID: 243
		private int size;
	}
}
