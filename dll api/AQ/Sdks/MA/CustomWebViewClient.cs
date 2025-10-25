using System;
using System.Collections.Generic;
using Android.Webkit;
using Java.Util.Regex;

namespace AQ.Sdks.MA
{
	// Token: 0x02000056 RID: 86
	public class CustomWebViewClient : WebViewClient
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		public CustomWebViewClient(MaWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000E7D7 File Offset: 0x0000C9D7
		public override bool ShouldOverrideUrlLoading(WebView view, string url)
		{
			return !this.IsValidUrl(url);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000E7E5 File Offset: 0x0000C9E5
		public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
		{
			return !this.IsValidUrl(request.Url.ToString());
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000E800 File Offset: 0x0000CA00
		private bool IsValidUrl(string url)
		{
			foreach (string regex in new List<string>
			{
				"https://mega\\.nz\\.embed#!/*"
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

		// Token: 0x040001C3 RID: 451
		public MaWebVideoView VideoView;
	}
}
