using System;
using Android.App;
using Android.Content.PM;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Interop;

namespace AQ.Sdks.SV
{
	// Token: 0x0200004D RID: 77
	public class CustomWebChromeClient : WebChromeClient, MediaPlayer.IOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002EE RID: 750 RVA: 0x0000DF6D File Offset: 0x0000C16D
		public void OnCompletion(MediaPlayer mp)
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000DF7A File Offset: 0x0000C17A
		public CustomWebChromeClient(SVWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000DF8C File Offset: 0x0000C18C
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

		// Token: 0x060002F1 RID: 753 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
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

		// Token: 0x060002F2 RID: 754 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public override void OnShowCustomView(View view, ScreenOrientation requestedOrientation, WebChromeClient.ICustomViewCallback callback)
		{
			this.OnShowCustomView(view, callback);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000DF6D File Offset: 0x0000C16D
		public override void OnHideCustomView()
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x040001A8 RID: 424
		public SVWebVideoView VideoView;
	}
}
