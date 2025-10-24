using System;
using System.Collections.Generic;
using Android.Webkit;
using Java.Util.Regex;

namespace AQ.Sdks.LB
{
	// Token: 0x0200005A RID: 90
	public class CustomWebViewClient : WebViewClient
	{
		// Token: 0x06000344 RID: 836 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		public CustomWebViewClient(LBWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000EBDF File Offset: 0x0000CDDF
		public override bool ShouldOverrideUrlLoading(WebView view, string url)
		{
			return !this.IsValidUrl(url);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000EBED File Offset: 0x0000CDED
		public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
		{
			return !this.IsValidUrl(request.Url.ToString());
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000EC08 File Offset: 0x0000CE08
		private bool IsValidUrl(string url)
		{
			foreach (string regex in new List<string>
			{
				"https://sbchill\\.com\\e/*"
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

		// Token: 0x040001D0 RID: 464
		public LBWebVideoView VideoView;
	}
}
