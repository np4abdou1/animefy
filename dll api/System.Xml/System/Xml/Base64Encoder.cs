using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x0200000A RID: 10
	internal abstract class Base64Encoder
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002812 File Offset: 0x00000A12
		internal Base64Encoder()
		{
			this.charsLine = new char[76];
		}

		// Token: 0x0600001A RID: 26
		internal abstract void WriteChars(char[] chars, int index, int count);

		// Token: 0x0600001B RID: 27 RVA: 0x00002828 File Offset: 0x00000A28
		internal void Encode(byte[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count > buffer.Length - index)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this.leftOverBytesCount > 0)
			{
				int num = this.leftOverBytesCount;
				while (num < 3 && count > 0)
				{
					this.leftOverBytes[num++] = buffer[index++];
					count--;
				}
				if (count == 0 && num < 3)
				{
					this.leftOverBytesCount = num;
					return;
				}
				int count2 = Convert.ToBase64CharArray(this.leftOverBytes, 0, 3, this.charsLine, 0);
				this.WriteChars(this.charsLine, 0, count2);
			}
			this.leftOverBytesCount = count % 3;
			if (this.leftOverBytesCount > 0)
			{
				count -= this.leftOverBytesCount;
				if (this.leftOverBytes == null)
				{
					this.leftOverBytes = new byte[3];
				}
				for (int i = 0; i < this.leftOverBytesCount; i++)
				{
					this.leftOverBytes[i] = buffer[index + count + i];
				}
			}
			int num2 = index + count;
			int num3 = 57;
			while (index < num2)
			{
				if (index + num3 > num2)
				{
					num3 = num2 - index;
				}
				int count3 = Convert.ToBase64CharArray(buffer, index, num3, this.charsLine, 0);
				this.WriteChars(this.charsLine, 0, count3);
				index += num3;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000296C File Offset: 0x00000B6C
		internal void Flush()
		{
			if (this.leftOverBytesCount > 0)
			{
				int count = Convert.ToBase64CharArray(this.leftOverBytes, 0, this.leftOverBytesCount, this.charsLine, 0);
				this.WriteChars(this.charsLine, 0, count);
				this.leftOverBytesCount = 0;
			}
		}

		// Token: 0x0600001D RID: 29
		internal abstract Task WriteCharsAsync(char[] chars, int index, int count);

		// Token: 0x0600001E RID: 30 RVA: 0x000029B4 File Offset: 0x00000BB4
		internal Task FlushAsync()
		{
			Base64Encoder.<FlushAsync>d__11 <FlushAsync>d__;
			<FlushAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushAsync>d__.<>4__this = this;
			<FlushAsync>d__.<>1__state = -1;
			<FlushAsync>d__.<>t__builder.Start<Base64Encoder.<FlushAsync>d__11>(ref <FlushAsync>d__);
			return <FlushAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000021 RID: 33
		private byte[] leftOverBytes;

		// Token: 0x04000022 RID: 34
		private int leftOverBytesCount;

		// Token: 0x04000023 RID: 35
		private char[] charsLine;
	}
}
