using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x0200019E RID: 414
	internal class BufferedReadStream : WebReadStream
	{
		// Token: 0x06000B2C RID: 2860 RVA: 0x0003ABE6 File Offset: 0x00038DE6
		public BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) : base(operation, innerStream)
		{
			this.readBuffer = readBuffer;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0003ABF8 File Offset: 0x00038DF8
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			BufferedReadStream.<ProcessReadAsync>d__2 <ProcessReadAsync>d__;
			<ProcessReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ProcessReadAsync>d__.<>4__this = this;
			<ProcessReadAsync>d__.buffer = buffer;
			<ProcessReadAsync>d__.offset = offset;
			<ProcessReadAsync>d__.size = size;
			<ProcessReadAsync>d__.cancellationToken = cancellationToken;
			<ProcessReadAsync>d__.<>1__state = -1;
			<ProcessReadAsync>d__.<>t__builder.Start<BufferedReadStream.<ProcessReadAsync>d__2>(ref <ProcessReadAsync>d__);
			return <ProcessReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0003AC5C File Offset: 0x00038E5C
		internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result)
		{
			BufferOffsetSize bufferOffsetSize = this.readBuffer;
			int num = (bufferOffsetSize != null) ? bufferOffsetSize.Size : 0;
			if (num <= 0)
			{
				result = 0;
				return base.InnerStream == null;
			}
			int num2 = (num > size) ? size : num;
			Buffer.BlockCopy(this.readBuffer.Buffer, this.readBuffer.Offset, buffer, offset, num2);
			this.readBuffer.Offset += num2;
			this.readBuffer.Size -= num2;
			offset += num2;
			size -= num2;
			result = num2;
			return true;
		}

		// Token: 0x0400080C RID: 2060
		private readonly BufferOffsetSize readBuffer;
	}
}
