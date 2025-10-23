using System;
using System.Text;

namespace System.Xml
{
	// Token: 0x0200001F RID: 31
	internal class CharEntityEncoderFallback : EncoderFallback
	{
		// Token: 0x060000FF RID: 255 RVA: 0x000082F4 File Offset: 0x000064F4
		internal CharEntityEncoderFallback()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000082FC File Offset: 0x000064FC
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			if (this.fallbackBuffer == null)
			{
				this.fallbackBuffer = new CharEntityEncoderFallbackBuffer(this);
			}
			return this.fallbackBuffer;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00008318 File Offset: 0x00006518
		public override int MaxCharCount
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000014 RID: 20
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000831C File Offset: 0x0000651C
		internal int StartOffset
		{
			set
			{
				this.startOffset = value;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00008325 File Offset: 0x00006525
		internal void Reset(int[] textContentMarks, int endMarkPos)
		{
			this.textContentMarks = textContentMarks;
			this.endMarkPos = endMarkPos;
			this.curMarkPos = 0;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000833C File Offset: 0x0000653C
		internal bool CanReplaceAt(int index)
		{
			int num = this.curMarkPos;
			int num2 = this.startOffset + index;
			while (num < this.endMarkPos && num2 >= this.textContentMarks[num + 1])
			{
				num++;
			}
			this.curMarkPos = num;
			return (num & 1) != 0;
		}

		// Token: 0x040000F4 RID: 244
		private CharEntityEncoderFallbackBuffer fallbackBuffer;

		// Token: 0x040000F5 RID: 245
		private int[] textContentMarks;

		// Token: 0x040000F6 RID: 246
		private int endMarkPos;

		// Token: 0x040000F7 RID: 247
		private int curMarkPos;

		// Token: 0x040000F8 RID: 248
		private int startOffset;
	}
}
