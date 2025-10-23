using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001D2 RID: 466
	internal class WebConnectionTunnel
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0004236E File Offset: 0x0004056E
		public HttpWebRequest Request { get; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00042376 File Offset: 0x00040576
		public Uri ConnectUri { get; }

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0004237E File Offset: 0x0004057E
		public WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
		{
			this.Request = request;
			this.ConnectUri = connectUri;
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00042394 File Offset: 0x00040594
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x0004239C File Offset: 0x0004059C
		public bool Success { get; private set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000423A5 File Offset: 0x000405A5
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x000423AD File Offset: 0x000405AD
		public bool CloseConnection { get; private set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000423B6 File Offset: 0x000405B6
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x000423BE File Offset: 0x000405BE
		public int StatusCode { get; private set; }

		// Token: 0x17000291 RID: 657
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x000423C7 File Offset: 0x000405C7
		private string StatusDescription
		{
			[CompilerGenerated]
			set
			{
				this.<StatusDescription>k__BackingField = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000423D0 File Offset: 0x000405D0
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x000423D8 File Offset: 0x000405D8
		public string[] Challenge { get; private set; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000423E1 File Offset: 0x000405E1
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x000423E9 File Offset: 0x000405E9
		public WebHeaderCollection Headers { get; private set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x000423F2 File Offset: 0x000405F2
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x000423FA File Offset: 0x000405FA
		public Version ProxyVersion { get; private set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00042403 File Offset: 0x00040603
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0004240B File Offset: 0x0004060B
		public byte[] Data { get; private set; }

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00042414 File Offset: 0x00040614
		internal Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			WebConnectionTunnel.<Initialize>d__42 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.stream = stream;
			<Initialize>d__.cancellationToken = cancellationToken;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<WebConnectionTunnel.<Initialize>d__42>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00042468 File Offset: 0x00040668
		private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			WebConnectionTunnel.<ReadHeaders>d__43 <ReadHeaders>d__;
			<ReadHeaders>d__.<>t__builder = AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.Create();
			<ReadHeaders>d__.<>4__this = this;
			<ReadHeaders>d__.stream = stream;
			<ReadHeaders>d__.cancellationToken = cancellationToken;
			<ReadHeaders>d__.<>1__state = -1;
			<ReadHeaders>d__.<>t__builder.Start<WebConnectionTunnel.<ReadHeaders>d__43>(ref <ReadHeaders>d__);
			return <ReadHeaders>d__.<>t__builder.Task;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000424BC File Offset: 0x000406BC
		private void FlushContents(Stream stream, int contentLength)
		{
			while (contentLength > 0)
			{
				byte[] buffer = new byte[contentLength];
				int num = stream.Read(buffer, 0, contentLength);
				if (num <= 0)
				{
					break;
				}
				contentLength -= num;
			}
		}

		// Token: 0x04000963 RID: 2403
		private HttpWebRequest connectRequest;

		// Token: 0x04000964 RID: 2404
		private WebConnectionTunnel.NtlmAuthState ntlmAuthState;

		// Token: 0x020001D3 RID: 467
		private enum NtlmAuthState
		{
			// Token: 0x0400096E RID: 2414
			None,
			// Token: 0x0400096F RID: 2415
			Challenge,
			// Token: 0x04000970 RID: 2416
			Response
		}
	}
}
