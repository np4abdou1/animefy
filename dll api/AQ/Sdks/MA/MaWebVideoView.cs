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

namespace AQ.Sdks.MA
{
	// Token: 0x02000057 RID: 87
	public class MaWebVideoView : WebView
	{
		// Token: 0x0600032D RID: 813 RVA: 0x0000E87C File Offset: 0x0000CA7C
		public MaWebVideoView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			this.Init();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000E894 File Offset: 0x0000CA94
		public MaWebVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			this.Init();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000E8AB File Offset: 0x0000CAAB
		public MaWebVideoView(Context context) : base(context)
		{
			this.Init();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
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

		// Token: 0x06000331 RID: 817 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public void callPlayerMethod(string method)
		{
			this.LoadUrl("javascript:player.api(\"" + method + "\")");
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000E974 File Offset: 0x0000CB74
		public void setVideoId(string videoId, bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
			string url = string.Format("https://mega.nz/embed/{0}", videoId);
			this.LoadUrl(url);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000E99C File Offset: 0x0000CB9C
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

		// Token: 0x06000334 RID: 820 RVA: 0x0000E9FC File Offset: 0x0000CBFC
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

		// Token: 0x06000335 RID: 821 RVA: 0x0000EA65 File Offset: 0x0000CC65
		public bool isFullscreen()
		{
			return this.mIsFullscreen;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000EA6D File Offset: 0x0000CC6D
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

		// Token: 0x06000337 RID: 823 RVA: 0x0000EA8F File Offset: 0x0000CC8F
		public void setAllowAutomaticNativeFullscreen(bool allowAutomaticNativeFullscreen)
		{
			this.mAllowAutomaticNativeFullscreen = allowAutomaticNativeFullscreen;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000EA98 File Offset: 0x0000CC98
		public bool isAutoPlaying()
		{
			return this.mAutoPlay;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public void setAutoPlay(bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
		}

		// Token: 0x040001C4 RID: 452
		private WebSettings mWebSettings;

		// Token: 0x040001C5 RID: 453
		private CustomWebChromeClient mChromeClient;

		// Token: 0x040001C6 RID: 454
		public VideoView mCustomVideoView;

		// Token: 0x040001C7 RID: 455
		public WebChromeClient.ICustomViewCallback mViewCallback;

		// Token: 0x040001C8 RID: 456
		private const string mEmbedUrl = "https://mega.nz/embed/{0}";

		// Token: 0x040001C9 RID: 457
		private FrameLayout mVideoLayout;

		// Token: 0x040001CA RID: 458
		public bool mIsFullscreen;

		// Token: 0x040001CB RID: 459
		private FrameLayout mRootLayout;

		// Token: 0x040001CC RID: 460
		private bool mAllowAutomaticNativeFullscreen = true;

		// Token: 0x040001CD RID: 461
		private bool mAutoPlay;
	}
}
