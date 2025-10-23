using System;

namespace System.Xml
{
	// Token: 0x0200001C RID: 28
	internal class BitStack
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x0000804E File Offset: 0x0000624E
		public BitStack()
		{
			this.curr = 1U;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000805D File Offset: 0x0000625D
		public void PushBit(bool bit)
		{
			if ((this.curr & 2147483648U) != 0U)
			{
				this.PushCurr();
			}
			this.curr = (this.curr << 1 | (bit ? 1U : 0U));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00008089 File Offset: 0x00006289
		public bool PopBit()
		{
			bool result = (this.curr & 1U) > 0U;
			this.curr >>= 1;
			if (this.curr == 1U)
			{
				this.PopCurr();
			}
			return result;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000080B3 File Offset: 0x000062B3
		public bool PeekBit()
		{
			return (this.curr & 1U) > 0U;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000080C0 File Offset: 0x000062C0
		private void PushCurr()
		{
			if (this.bitStack == null)
			{
				this.bitStack = new uint[16];
			}
			uint[] array = this.bitStack;
			int num = this.stackPos;
			this.stackPos = num + 1;
			array[num] = this.curr;
			this.curr = 1U;
			int num2 = this.bitStack.Length;
			if (this.stackPos >= num2)
			{
				uint[] destinationArray = new uint[2 * num2];
				Array.Copy(this.bitStack, destinationArray, num2);
				this.bitStack = destinationArray;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00008138 File Offset: 0x00006338
		private void PopCurr()
		{
			if (this.stackPos > 0)
			{
				uint[] array = this.bitStack;
				int num = this.stackPos - 1;
				this.stackPos = num;
				this.curr = array[num];
			}
		}

		// Token: 0x040000E8 RID: 232
		private uint[] bitStack;

		// Token: 0x040000E9 RID: 233
		private int stackPos;

		// Token: 0x040000EA RID: 234
		private uint curr;
	}
}
