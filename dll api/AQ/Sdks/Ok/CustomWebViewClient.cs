using System;
using Android.Webkit;

namespace AQ.Sdks.Ok
{
	// Token: 0x02000052 RID: 82
	public class CustomWebViewClient : WebViewClient
	{
		// Token: 0x0600030F RID: 783 RVA: 0x0000E464 File Offset: 0x0000C664
		public CustomWebViewClient(OkWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000E473 File Offset: 0x0000C673
		public override bool ShouldOverrideUrlLoading(WebView view, string url)
		{
			return true;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000E473 File Offset: 0x0000C673
		public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
		{
			return true;
		}

		// Token: 0x040001B6 RID: 438
		public OkWebVideoView VideoView;
	}
}
