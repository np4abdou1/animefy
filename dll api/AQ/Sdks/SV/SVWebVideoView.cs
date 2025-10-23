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

namespace AQ.Sdks.SV
{
	// Token: 0x0200004F RID: 79
	public class SVWebVideoView : WebView
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0000E110 File Offset: 0x0000C310
		public SVWebVideoView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			this.Init();
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000E128 File Offset: 0x0000C328
		public SVWebVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			this.Init();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000E13F File Offset: 0x0000C33F
		public SVWebVideoView(Context context) : base(context)
		{
			this.Init();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000E158 File Offset: 0x0000C358
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

		// Token: 0x060002FC RID: 764 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public void callPlayerMethod(string method)
		{
			this.LoadUrl("javascript:player.api(\"" + method + "\")");
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000E208 File Offset: 0x0000C408
		public void setVideoId(string videoId, bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
			string url = string.Format("https://sendvid.com/embed/{0}", videoId);
			this.LoadUrl(url);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000E230 File Offset: 0x0000C430
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

		// Token: 0x060002FF RID: 767 RVA: 0x0000E290 File Offset: 0x0000C490
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

		// Token: 0x06000300 RID: 768 RVA: 0x0000E2F9 File Offset: 0x0000C4F9
		public bool isFullscreen()
		{
			return this.mIsFullscreen;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000E301 File Offset: 0x0000C501
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

		// Token: 0x06000302 RID: 770 RVA: 0x0000E323 File Offset: 0x0000C523
		public void setAllowAutomaticNativeFullscreen(bool allowAutomaticNativeFullscreen)
		{
			this.mAllowAutomaticNativeFullscreen = allowAutomaticNativeFullscreen;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000E32C File Offset: 0x0000C52C
		public bool isAutoPlaying()
		{
			return this.mAutoPlay;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000E334 File Offset: 0x0000C534
		public void setAutoPlay(bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
		}

		// Token: 0x040001AA RID: 426
		private WebSettings mWebSettings;

		// Token: 0x040001AB RID: 427
		private CustomWebChromeClient mChromeClient;

		// Token: 0x040001AC RID: 428
		public VideoView mCustomVideoView;

		// Token: 0x040001AD RID: 429
		public WebChromeClient.ICustomViewCallback mViewCallback;

		// Token: 0x040001AE RID: 430
		private const string mEmbedUrl = "https://sendvid.com/embed/{0}";

		// Token: 0x040001AF RID: 431
		private FrameLayout mVideoLayout;

		// Token: 0x040001B0 RID: 432
		public bool mIsFullscreen;

		// Token: 0x040001B1 RID: 433
		private FrameLayout mRootLayout;

		// Token: 0x040001B2 RID: 434
		private bool mAllowAutomaticNativeFullscreen = true;

		// Token: 0x040001B3 RID: 435
		private bool mAutoPlay;
	}
}
