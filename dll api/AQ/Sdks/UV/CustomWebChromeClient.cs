using System;
using Android.App;
using Android.Content.PM;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Interop;

namespace AQ.Sdks.UV
{
	// Token: 0x02000049 RID: 73
	public class CustomWebChromeClient : WebChromeClient, MediaPlayer.IOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public void OnCompletion(MediaPlayer mp)
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000DB55 File Offset: 0x0000BD55
		public CustomWebChromeClient(UVWebVideoView videoView)
		{
			this.VideoView = videoView;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000DB64 File Offset: 0x0000BD64
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

		// Token: 0x060002D6 RID: 726 RVA: 0x0000DB8C File Offset: 0x0000BD8C
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

		// Token: 0x060002D7 RID: 727 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public override void OnShowCustomView(View view, ScreenOrientation requestedOrientation, WebChromeClient.ICustomViewCallback callback)
		{
			this.OnShowCustomView(view, callback);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public override void OnHideCustomView()
		{
			this.VideoView.hideVideoView();
		}

		// Token: 0x0400019B RID: 411
		public UVWebVideoView VideoView;
	}
}
