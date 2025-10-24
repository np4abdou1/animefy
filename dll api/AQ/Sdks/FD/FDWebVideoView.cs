using System;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Media;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace AQ.Sdks.FD
{
	// Token: 0x0200005F RID: 95
	public class FDWebVideoView : WebView
	{
		// Token: 0x06000363 RID: 867 RVA: 0x0000F08C File Offset: 0x0000D28C
		public FDWebVideoView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			this.Init();
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		public FDWebVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			this.Init();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000F0BB File Offset: 0x0000D2BB
		public FDWebVideoView(Context context) : base(context)
		{
			this.Init();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		private void Init()
		{
			this.mRootLayout = (FrameLayout)((Activity)base.Context).Window.DecorView;
			this.mWebSettings = this.Settings;
			this.mWebSettings.JavaScriptEnabled = true;
			this.mWebSettings.DomStorageEnabled = true;
			this.mWebSettings.SetPluginState(WebSettings.PluginState.On);
			this.mWebSettings.UserAgentString = this.mWebSettings.UserAgentString;
			if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean)
			{
				this.mWebSettings.MediaPlaybackRequiresUserGesture = false;
			}
			this.mChromeClient = new CustomWebChromeClient(this);
			this.SetWebChromeClient(this.mChromeClient);
			this.SetWebViewClient(new CustomWebViewClient(this));
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public void callPlayerMethod(string method)
		{
			this.LoadUrl("javascript:player.api(\"" + method + "\")");
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000F184 File Offset: 0x0000D384
		public void setVideoId(string videoId, bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
			string url = string.Format("https://vanfem.com/v/{0}", videoId);
			this.LoadUrl(url);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public void hideVideoView()
		{
			if (this.isFullscreen())
			{
				if (this.mCustomVideoView != null)
				{
					this.mCustomVideoView.StopPlayback();
				}
				this.mRootLayout.RemoveView(this.mVideoLayout);
				this.mViewCallback.OnCustomViewHidden();
				((Activity)base.Context).VolumeControlStream = (Stream)(-2147483648);
				this.mIsFullscreen = false;
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000F20C File Offset: 0x0000D40C
		public void setupVideoLayout(View video)
		{
			this.mVideoLayout = new CustomFrameLayout(base.Context, this);
			this.mVideoLayout.Background = new ColorDrawable(Color.Black);
			this.mVideoLayout.AddView(video);
			FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
			layoutParams.Gravity = GravityFlags.Center;
			this.mRootLayout.AddView(this.mVideoLayout, layoutParams);
			this.mIsFullscreen = true;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000F275 File Offset: 0x0000D475
		public bool isFullscreen()
		{
			return this.mIsFullscreen;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000F27D File Offset: 0x0000D47D
		public void handleBackPress(Activity activity)
		{
			if (this.isFullscreen())
			{
				this.hideVideoView();
				return;
			}
			this.LoadUrl("");
			activity.Finish();
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000F29F File Offset: 0x0000D49F
		public void setAllowAutomaticNativeFullscreen(bool allowAutomaticNativeFullscreen)
		{
			this.mAllowAutomaticNativeFullscreen = allowAutomaticNativeFullscreen;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		public bool isAutoPlaying()
		{
			return this.mAutoPlay;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
		public void setAutoPlay(bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
		}

		// Token: 0x040001DE RID: 478
		private WebSettings mWebSettings;

		// Token: 0x040001DF RID: 479
		private CustomWebChromeClient mChromeClient;

		// Token: 0x040001E0 RID: 480
		public VideoView mCustomVideoView;

		// Token: 0x040001E1 RID: 481
		public WebChromeClient.ICustomViewCallback mViewCallback;

		// Token: 0x040001E2 RID: 482
		private const string mEmbedUrl = "https://vanfem.com/v/{0}";

		// Token: 0x040001E3 RID: 483
		private FrameLayout mVideoLayout;

		// Token: 0x040001E4 RID: 484
		public bool mIsFullscreen;

		// Token: 0x040001E5 RID: 485
		private FrameLayout mRootLayout;

		// Token: 0x040001E6 RID: 486
		private bool mAllowAutomaticNativeFullscreen = true;

		// Token: 0x040001E7 RID: 487
		private bool mAutoPlay;
	}
}
