using System;
using Android.App;
using Android.Content.PM;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Interop;

namespace AQ.Sdks.MA
{
	// Token: 0x02000055 RID: 85
	public class CustomWebChromeClient : WebChromeClient, MediaPlayer.IOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000323 RID: 803 RVA: 0x0000E6D9 File Offset: 0x0000C8D9
		public void OnCompletion(MediaPlayer mp)
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000E6E6 File Offset: 0x0000C8E6
		public CustomWebChromeClient(MaWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
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

		// Token: 0x06000326 RID: 806 RVA: 0x0000E720 File Offset: 0x0000C920
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

		// Token: 0x06000327 RID: 807 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public override void OnShowCustomView(View view, ScreenOrientation requestedOrientation, WebChromeClient.ICustomViewCallback callback)
		{
			this.OnShowCustomView(view, callback);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000E6D9 File Offset: 0x0000C8D9
		public override void OnHideCustomView()
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x040001C2 RID: 450
		public MaWebVideoView VideoView;
	}
}
