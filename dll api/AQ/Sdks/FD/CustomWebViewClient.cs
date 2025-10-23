using System;
using System.Collections.Generic;
using Android.Webkit;
using Java.Util.Regex;

namespace AQ.Sdks.FD
{
	// Token: 0x0200005E RID: 94
	public class CustomWebViewClient : WebViewClient
	{
		// Token: 0x0600035F RID: 863 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
		public CustomWebViewClient(FDWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000EFE7 File Offset: 0x0000D1E7
		public override bool ShouldOverrideUrlLoading(WebView view, string url)
		{
			return !this.IsValidUrl(url);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000EFF5 File Offset: 0x0000D1F5
		public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
		{
			return !this.IsValidUrl(request.Url.ToString());
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000F010 File Offset: 0x0000D210
		private bool IsValidUrl(string url)
		{
			foreach (string regex in new List<string>
			{
				"https://embed\\.mystream\\.to/*"
			})
			{
				Pattern pattern = Pattern.Compile(regex, RegexOptions.Multiline);
				Matcher matcher = pattern.Matcher(url);
				if (matcher.Find())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040001DD RID: 477
		public FDWebVideoView VideoView;
	}
}
