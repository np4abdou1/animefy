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

namespace AQ.Sdks.LB
{
	// Token: 0x0200005B RID: 91
	public class LBWebVideoView : WebView
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0000EC84 File Offset: 0x0000CE84
		public LBWebVideoView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			this.Init();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000EC9C File Offset: 0x0000CE9C
		public LBWebVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			this.Init();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000ECB3 File Offset: 0x0000CEB3
		public LBWebVideoView(Context context) : base(context)
		{
			this.Init();
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000ECCC File Offset: 0x0000CECC
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

		// Token: 0x0600034C RID: 844 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public void callPlayerMethod(string method)
		{
			this.LoadUrl("javascript:player.api(\"" + method + "\")");
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		public void setVideoId(string videoId, bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
			string url = string.Format("https://filelions.online/v/{0}", videoId);
			this.LoadUrl(url);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
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

		// Token: 0x0600034F RID: 847 RVA: 0x0000EE04 File Offset: 0x0000D004
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

		// Token: 0x06000350 RID: 848 RVA: 0x0000EE6D File Offset: 0x0000D06D
		public bool isFullscreen()
		{
			return this.mIsFullscreen;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000EE75 File Offset: 0x0000D075
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

		// Token: 0x06000352 RID: 850 RVA: 0x0000EE97 File Offset: 0x0000D097
		public void setAllowAutomaticNativeFullscreen(bool allowAutomaticNativeFullscreen)
		{
			this.mAllowAutomaticNativeFullscreen = allowAutomaticNativeFullscreen;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		public bool isAutoPlaying()
		{
			return this.mAutoPlay;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		public void setAutoPlay(bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
		}

		// Token: 0x040001D1 RID: 465
		private WebSettings mWebSettings;

		// Token: 0x040001D2 RID: 466
		private CustomWebChromeClient mChromeClient;

		// Token: 0x040001D3 RID: 467
		public VideoView mCustomVideoView;

		// Token: 0x040001D4 RID: 468
		public WebChromeClient.ICustomViewCallback mViewCallback;

		// Token: 0x040001D5 RID: 469
		private const string mEmbedUrl = "https://filelions.online/v/{0}";

		// Token: 0x040001D6 RID: 470
		private FrameLayout mVideoLayout;

		// Token: 0x040001D7 RID: 471
		public bool mIsFullscreen;

		// Token: 0x040001D8 RID: 472
		private FrameLayout mRootLayout;

		// Token: 0x040001D9 RID: 473
		private bool mAllowAutomaticNativeFullscreen = true;

		// Token: 0x040001DA RID: 474
		private bool mAutoPlay;
	}
}
