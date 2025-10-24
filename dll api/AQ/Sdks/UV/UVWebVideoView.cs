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

namespace AQ.Sdks.UV
{
	// Token: 0x0200004B RID: 75
	public class UVWebVideoView : WebView
	{
		// Token: 0x060002DD RID: 733 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		public UVWebVideoView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			this.Init();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000DD08 File Offset: 0x0000BF08
		public UVWebVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			this.Init();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000DD1F File Offset: 0x0000BF1F
		public UVWebVideoView(Context context) : base(context)
		{
			this.Init();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000DD38 File Offset: 0x0000BF38
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

		// Token: 0x060002E1 RID: 737 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public void callPlayerMethod(string method)
		{
			this.LoadUrl("javascript:player.api(\"" + method + "\")");
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000DE00 File Offset: 0x0000C000
		public void setVideoId(string videoId, bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
			string url = string.Format("https://www.4shared.com/web/embed/file/{0}", videoId);
			this.LoadUrl(url);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000DE28 File Offset: 0x0000C028
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

		// Token: 0x060002E4 RID: 740 RVA: 0x0000DE88 File Offset: 0x0000C088
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

		// Token: 0x060002E5 RID: 741 RVA: 0x0000DEF1 File Offset: 0x0000C0F1
		public bool isFullscreen()
		{
			return this.mIsFullscreen;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000DEF9 File Offset: 0x0000C0F9
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

		// Token: 0x060002E7 RID: 743 RVA: 0x0000DF1B File Offset: 0x0000C11B
		public void setAllowAutomaticNativeFullscreen(bool allowAutomaticNativeFullscreen)
		{
			this.mAllowAutomaticNativeFullscreen = allowAutomaticNativeFullscreen;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000DF24 File Offset: 0x0000C124
		public bool isAutoPlaying()
		{
			return this.mAutoPlay;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000DF2C File Offset: 0x0000C12C
		public void setAutoPlay(bool autoPlay)
		{
			this.mAutoPlay = autoPlay;
		}

		// Token: 0x0400019D RID: 413
		private WebSettings mWebSettings;

		// Token: 0x0400019E RID: 414
		private CustomWebChromeClient mChromeClient;

		// Token: 0x0400019F RID: 415
		public VideoView mCustomVideoView;

		// Token: 0x040001A0 RID: 416
		public WebChromeClient.ICustomViewCallback mViewCallback;

		// Token: 0x040001A1 RID: 417
		private const string mEmbedUrl = "https://www.4shared.com/web/embed/file/{0}";

		// Token: 0x040001A2 RID: 418
		private FrameLayout mVideoLayout;

		// Token: 0x040001A3 RID: 419
		public bool mIsFullscreen;

		// Token: 0x040001A4 RID: 420
		private FrameLayout mRootLayout;

		// Token: 0x040001A5 RID: 421
		private bool mAllowAutomaticNativeFullscreen = true;

		// Token: 0x040001A6 RID: 422
		private bool mAutoPlay;
	}
}
