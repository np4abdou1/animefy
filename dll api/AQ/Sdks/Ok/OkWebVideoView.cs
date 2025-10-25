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

namespace AQ.Sdks.Ok
{
	// Token: 0x02000053 RID: 83
	public class OkWebVideoView : WebView
	{
		// Token: 0x06000312 RID: 786 RVA: 0x0000E476 File Offset: 0x0000C676
		public OkWebVideoView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			this.Init();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000E48E File Offset: 0x0000C68E
		public OkWebVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			this.Init();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000E4A5 File Offset: 0x0000C6A5
		public OkWebVideoView(Context context) : base(context)
		{
			this.Init();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000E4BC File Offset: 0x0000C6BC
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

		// Token: 0x06000316 RID: 790 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public void callPlayerMethod(string method)
		{
			this.LoadUrl("javascript:player.api(\"" + method + "\")");
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000E56C File Offset: 0x0000C76C
		public void setVideoId(string videoId, bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
			string url = string.Format("https://ok.ru/videoembed/{0}", videoId);
			this.LoadUrl(url);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000E594 File Offset: 0x0000C794
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

		// Token: 0x06000319 RID: 793 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
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

		// Token: 0x0600031A RID: 794 RVA: 0x0000E65D File Offset: 0x0000C85D
		public bool isFullscreen()
		{
			return this.mIsFullscreen;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000E665 File Offset: 0x0000C865
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

		// Token: 0x0600031C RID: 796 RVA: 0x0000E687 File Offset: 0x0000C887
		public void setAllowAutomaticNativeFullscreen(bool allowAutomaticNativeFullscreen)
		{
			this.mAllowAutomaticNativeFullscreen = allowAutomaticNativeFullscreen;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000E690 File Offset: 0x0000C890
		public bool isAutoPlaying()
		{
			return this.mAutoPlay;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000E698 File Offset: 0x0000C898
		public void setAutoPlay(bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
		}

		// Token: 0x040001B7 RID: 439
		private WebSettings mWebSettings;

		// Token: 0x040001B8 RID: 440
		private CustomWebChromeClient mChromeClient;

		// Token: 0x040001B9 RID: 441
		public VideoView mCustomVideoView;

		// Token: 0x040001BA RID: 442
		public WebChromeClient.ICustomViewCallback mViewCallback;

		// Token: 0x040001BB RID: 443
		private const string mEmbedUrl = "https://ok.ru/videoembed/{0}";

		// Token: 0x040001BC RID: 444
		private FrameLayout mVideoLayout;

		// Token: 0x040001BD RID: 445
		public bool mIsFullscreen;

		// Token: 0x040001BE RID: 446
		private FrameLayout mRootLayout;

		// Token: 0x040001BF RID: 447
		private bool mAllowAutomaticNativeFullscreen = true;

		// Token: 0x040001C0 RID: 448
		private bool mAutoPlay;
	}
}
