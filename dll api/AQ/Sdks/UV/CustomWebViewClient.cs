using System;
using System.Collections.Generic;
using Android.Webkit;
using Java.Util.Regex;

namespace AQ.Sdks.UV
{
	// Token: 0x0200004A RID: 74
	internal class CustomWebViewClient : WebViewClient
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x0000DC3E File Offset: 0x0000BE3E
		public CustomWebViewClient(UVWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000DC4D File Offset: 0x0000BE4D
		public override bool ShouldOverrideUrlLoading(WebView view, string url)
		{
			return !this.IsValidUrl(url);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000DC5B File Offset: 0x0000BE5B
		public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
		{
			return !this.IsValidUrl(request.Url.ToString());
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000DC74 File Offset: 0x0000BE74
		private bool IsValidUrl(string url)
		{
			foreach (string regex in new List<string>
			{
				"https://www\\.4shared\\.com/web/embed/file/*"
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

		// Token: 0x0400019C RID: 412
		public UVWebVideoView VideoView;
	}
}
