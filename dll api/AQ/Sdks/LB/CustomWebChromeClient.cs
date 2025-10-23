using System;
using Android.App;
using Android.Content.PM;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Interop;

namespace AQ.Sdks.LB
{
	// Token: 0x02000059 RID: 89
	public class CustomWebChromeClient : WebChromeClient, MediaPlayer.IOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600033E RID: 830 RVA: 0x0000EAE1 File Offset: 0x0000CCE1
		public void OnCompletion(MediaPlayer mp)
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000EAEE File Offset: 0x0000CCEE
		public CustomWebChromeClient(LBWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000EB00 File Offset: 0x0000CD00
		public override View VideoLoadingProgressView
		{
			get
			{
				return new ProgressBar(this.VideoView.Context)
				{
					Indeterminate = true
				};
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000EB28 File Offset: 0x0000CD28
		public override void OnShowCustomView(View view, WebChromeClient.ICustomViewCallback callback)
		{
			base.OnShowCustomView(view, callback);
			((Activity)this.VideoView.Context).VolumeControlStream = Stream.Music;
			this.VideoView.mIsFullscreen = true;
			this.VideoView.mViewCallback = callback;
			if (view is FrameLayout)
			{
				FrameLayout frameLayout = (FrameLayout)view;
				if (frameLayout.FocusedChild is VideoView)
				{
					VideoView videoView = (VideoView)frameLayout.FocusedChild;
					frameLayout.RemoveView(videoView);
					this.VideoView.setupVideoLayout(videoView);
					this.VideoView.mCustomVideoView = videoView;
					this.VideoView.mCustomVideoView.SetOnCompletionListener(this);
					return;
				}
				this.VideoView.setupVideoLayout(view);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public override void OnShowCustomView(View view, ScreenOrientation requestedOrientation, WebChromeClient.ICustomViewCallback callback)
		{
			this.OnShowCustomView(view, callback);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000EAE1 File Offset: 0x0000CCE1
		public override void OnHideCustomView()
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x040001CF RID: 463
		public LBWebVideoView VideoView;
	}
}
