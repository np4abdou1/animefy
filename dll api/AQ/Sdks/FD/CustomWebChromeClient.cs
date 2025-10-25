using System;
using Android.App;
using Android.Content.PM;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Interop;

namespace AQ.Sdks.FD
{
	// Token: 0x0200005D RID: 93
	public class CustomWebChromeClient : WebChromeClient, MediaPlayer.IOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000359 RID: 857 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
		public void OnCompletion(MediaPlayer mp)
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000EEF6 File Offset: 0x0000D0F6
		public CustomWebChromeClient(FDWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000EF08 File Offset: 0x0000D108
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

		// Token: 0x0600035C RID: 860 RVA: 0x0000EF30 File Offset: 0x0000D130
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

		// Token: 0x0600035D RID: 861 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public override void OnShowCustomView(View view, ScreenOrientation requestedOrientation, WebChromeClient.ICustomViewCallback callback)
		{
			this.OnShowCustomView(view, callback);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
		public override void OnHideCustomView()
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x040001DC RID: 476
		public FDWebVideoView VideoView;
	}
}
