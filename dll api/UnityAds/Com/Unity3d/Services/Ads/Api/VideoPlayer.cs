using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Video;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Api
{
	// Token: 0x02000226 RID: 550
	[Register("com/unity3d/services/ads/api/VideoPlayer", DoNotGenerateAcw = true)]
	public class VideoPlayer : Java.Lang.Object
	{
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x0004BA18 File Offset: 0x00049C18
		internal static IntPtr class_ref
		{
			get
			{
				return VideoPlayer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0004BA3C File Offset: 0x00049C3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoPlayer._members;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x0004BA44 File Offset: 0x00049C44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoPlayer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0004BA68 File Offset: 0x00049C68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoPlayer._members.ManagedPeerType;
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x000021E8 File Offset: 0x000003E8
		protected VideoPlayer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0004BA74 File Offset: 0x00049C74
		[Register(".ctor", "()V", "")]
		public VideoPlayer() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(VideoPlayer._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			VideoPlayer._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x0004BB18 File Offset: 0x00049D18
		public unsafe static VideoPlayerView VideoPlayerView
		{
			[Register("getVideoPlayerView", "()Lcom/unity3d/services/ads/video/VideoPlayerView;", "")]
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerView>(VideoPlayer._members.StaticMethods.InvokeObjectMethod("getVideoPlayerView.()Lcom/unity3d/services/ads/video/VideoPlayerView;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setVideoPlayerView", "(Lcom/unity3d/services/ads/video/VideoPlayerView;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					VideoPlayer._members.StaticMethods.InvokeVoidMethod("setVideoPlayerView.(Lcom/unity3d/services/ads/video/VideoPlayerView;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0004BB7C File Offset: 0x00049D7C
		[Register("getCurrentPosition", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetCurrentPosition(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("getCurrentPosition.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0004BBE0 File Offset: 0x00049DE0
		[Register("getProgressEventInterval", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetProgressEventInterval(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("getProgressEventInterval.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0004BC44 File Offset: 0x00049E44
		[Register("getVideoViewRectangle", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetVideoViewRectangle(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("getVideoViewRectangle.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0004BCA8 File Offset: 0x00049EA8
		[Register("getVolume", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetVolume(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("getVolume.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0004BD0C File Offset: 0x00049F0C
		[Register("pause", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Pause(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("pause.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0004BD70 File Offset: 0x00049F70
		[Register("play", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Play(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("play.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0004BDD4 File Offset: 0x00049FD4
		[Register("prepare", "(Ljava/lang/String;Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Prepare(string url, Java.Lang.Double initialVolume, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((initialVolume == null) ? IntPtr.Zero : initialVolume.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("prepare.(Ljava/lang/String;Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initialVolume);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0004BE84 File Offset: 0x0004A084
		[Register("prepare", "(Ljava/lang/String;Ljava/lang/Double;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Prepare(string url, Java.Lang.Double initialVolume, Integer timeout, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((initialVolume == null) ? IntPtr.Zero : initialVolume.Handle);
				ptr[2] = new JniArgumentValue((timeout == null) ? IntPtr.Zero : timeout.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("prepare.(Ljava/lang/String;Ljava/lang/Double;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initialVolume);
				GC.KeepAlive(timeout);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0004BF5C File Offset: 0x0004A15C
		[Register("seekTo", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SeekTo(Integer time, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((time == null) ? IntPtr.Zero : time.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("seekTo.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(time);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		[Register("setInfoListenerEnabled", "(ZLcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetInfoListenerEnabled(bool enabled, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(enabled);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("setInfoListenerEnabled.(ZLcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0004C060 File Offset: 0x0004A260
		[Register("setProgressEventInterval", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetProgressEventInterval(Integer milliseconds, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((milliseconds == null) ? IntPtr.Zero : milliseconds.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("setProgressEventInterval.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(milliseconds);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0004C0EC File Offset: 0x0004A2EC
		[Register("setVolume", "(Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetVolume(Java.Lang.Double volume, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((volume == null) ? IntPtr.Zero : volume.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("setVolume.(Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(volume);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0004C178 File Offset: 0x0004A378
		[Register("stop", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Stop(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				VideoPlayer._members.StaticMethods.InvokeVoidMethod("stop.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400065D RID: 1629
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/api/VideoPlayer", typeof(VideoPlayer));
	}
}
