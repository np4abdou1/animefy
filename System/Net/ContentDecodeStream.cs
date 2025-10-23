using System;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001A0 RID: 416
	internal class ContentDecodeStream : WebReadStream
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x0003AEAC File Offset: 0x000390AC
		public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode)
		{
			Stream decodeStream;
			if (mode == ContentDecodeStream.Mode.GZip)
			{
				decodeStream = new GZipStream(innerStream, CompressionMode.Decompress);
			}
			else
			{
				decodeStream = new DeflateStream(innerStream, CompressionMode.Decompress);
			}
			return new ContentDecodeStream(operation, decodeStream, innerStream);
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0003AED6 File Offset: 0x000390D6
		private Stream OriginalInnerStream { get; }

		// Token: 0x06000B33 RID: 2867 RVA: 0x0003AEDE File Offset: 0x000390DE
		private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream) : base(operation, decodeStream)
		{
			this.OriginalInnerStream = originalInnerStream;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0003AEEF File Offset: 0x000390EF
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return base.InnerStream.ReadAsync(buffer, offset, size, cancellationToken);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0003AF04 File Offset: 0x00039104
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			WebReadStream webReadStream = this.OriginalInnerStream as WebReadStream;
			if (webReadStream != null)
			{
				return webReadStream.FinishReading(cancellationToken);
			}
			return Task.CompletedTask;
		}

		// Token: 0x020001A1 RID: 417
		internal enum Mode
		{
			// Token: 0x04000817 RID: 2071
			GZip,
			// Token: 0x04000818 RID: 2072
			Deflate
		}
	}
}
