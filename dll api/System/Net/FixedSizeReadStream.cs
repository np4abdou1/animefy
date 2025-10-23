using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001A9 RID: 425
	internal class FixedSizeReadStream : WebReadStream
	{
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0003BCA3 File Offset: 0x00039EA3
		public long ContentLength { get; }

		// Token: 0x06000B6A RID: 2922 RVA: 0x0003BCAB File Offset: 0x00039EAB
		public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength) : base(operation, innerStream)
		{
			this.ContentLength = contentLength;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0003BCBC File Offset: 0x00039EBC
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			FixedSizeReadStream.<ProcessReadAsync>d__5 <ProcessReadAsync>d__;
			<ProcessReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ProcessReadAsync>d__.<>4__this = this;
			<ProcessReadAsync>d__.buffer = buffer;
			<ProcessReadAsync>d__.offset = offset;
			<ProcessReadAsync>d__.size = size;
			<ProcessReadAsync>d__.cancellationToken = cancellationToken;
			<ProcessReadAsync>d__.<>1__state = -1;
			<ProcessReadAsync>d__.<>t__builder.Start<FixedSizeReadStream.<ProcessReadAsync>d__5>(ref <ProcessReadAsync>d__);
			return <ProcessReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0400082A RID: 2090
		private long position;
	}
}
