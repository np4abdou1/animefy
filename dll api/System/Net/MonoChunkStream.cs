using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001B9 RID: 441
	internal class MonoChunkStream : WebReadStream
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0003F1C1 File Offset: 0x0003D3C1
		protected MonoChunkParser Decoder { get; }

		// Token: 0x06000BFD RID: 3069 RVA: 0x0003F1C9 File Offset: 0x0003D3C9
		public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers) : base(operation, innerStream)
		{
			this.<Headers>k__BackingField = headers;
			this.Decoder = new MonoChunkParser(headers);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			MonoChunkStream.<ProcessReadAsync>d__7 <ProcessReadAsync>d__;
			<ProcessReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ProcessReadAsync>d__.<>4__this = this;
			<ProcessReadAsync>d__.buffer = buffer;
			<ProcessReadAsync>d__.offset = offset;
			<ProcessReadAsync>d__.size = size;
			<ProcessReadAsync>d__.cancellationToken = cancellationToken;
			<ProcessReadAsync>d__.<>1__state = -1;
			<ProcessReadAsync>d__.<>t__builder.Start<MonoChunkStream.<ProcessReadAsync>d__7>(ref <ProcessReadAsync>d__);
			return <ProcessReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0003F24C File Offset: 0x0003D44C
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			MonoChunkStream.<FinishReading>d__8 <FinishReading>d__;
			<FinishReading>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishReading>d__.<>4__this = this;
			<FinishReading>d__.cancellationToken = cancellationToken;
			<FinishReading>d__.<>1__state = -1;
			<FinishReading>d__.<>t__builder.Start<MonoChunkStream.<FinishReading>d__8>(ref <FinishReading>d__);
			return <FinishReading>d__.<>t__builder.Task;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0003F297 File Offset: 0x0003D497
		private static void ThrowExpectingChunkTrailer()
		{
			throw new WebException("Expecting chunk trailer.", null, WebExceptionStatus.ServerProtocolViolation, null);
		}
	}
}
