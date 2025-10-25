using System;
using System.Collections.Generic;
using Android.Webkit;
using Java.Util.Regex;

namespace AQ.Sdks.SV
{
	// Token: 0x0200004E RID: 78
	public class CustomWebViewClient : WebViewClient
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0000E05C File Offset: 0x0000C25C
		public CustomWebViewClient(SVWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000E06B File Offset: 0x0000C26B
		public override bool ShouldOverrideUrlLoading(WebView view, string url)
		{
			return !this.IsValidUrl(url);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000E079 File Offset: 0x0000C279
		public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
		{
			return !this.IsValidUrl(request.Url.ToString());
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000E094 File Offset: 0x0000C294
		private bool IsValidUrl(string url)
		{
			foreach (string regex in new List<string>
			{
				"https://sendvid\\.com/embed/*"
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

		// Token: 0x040001A9 RID: 425
		public SVWebVideoView VideoView;
	}
}
