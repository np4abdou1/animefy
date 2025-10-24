using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Media;
using Android.Net;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000FE RID: 254
	[Register("android/widget/VideoView", DoNotGenerateAcw = true)]
	public class VideoView : SurfaceView, MediaController.IMediaPlayerControl, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0000D663 File Offset: 0x0000B863
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoView._members;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0000D66C File Offset: 0x0000B86C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0000D690 File Offset: 0x0000B890
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000D69C File Offset: 0x0000B89C
		protected VideoView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public unsafe VideoView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(VideoView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VideoView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000D784 File Offset: 0x0000B984
		public unsafe VideoView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(VideoView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VideoView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000D874 File Offset: 0x0000BA74
		private static Delegate GetGetAudioSessionIdHandler()
		{
			if (VideoView.cb_getAudioSessionId == null)
			{
				VideoView.cb_getAudioSessionId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VideoView.n_GetAudioSessionId));
			}
			return VideoView.cb_getAudioSessionId;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000D898 File Offset: 0x0000BA98
		private static int n_GetAudioSessionId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AudioSessionId;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0000D8A7 File Offset: 0x0000BAA7
		public virtual int AudioSessionId
		{
			get
			{
				return VideoView._members.InstanceMethods.InvokeVirtualInt32Method("getAudioSessionId.()I", this, null);
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		private static Delegate GetGetBufferPercentageHandler()
		{
			if (VideoView.cb_getBufferPercentage == null)
			{
				VideoView.cb_getBufferPercentage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VideoView.n_GetBufferPercentage));
			}
			return VideoView.cb_getBufferPercentage;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		private static int n_GetBufferPercentage(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BufferPercentage;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0000D8F3 File Offset: 0x0000BAF3
		public virtual int BufferPercentage
		{
			get
			{
				return VideoView._members.InstanceMethods.InvokeVirtualInt32Method("getBufferPercentage.()I", this, null);
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000D90C File Offset: 0x0000BB0C
		private static Delegate GetGetCurrentPositionHandler()
		{
			if (VideoView.cb_getCurrentPosition == null)
			{
				VideoView.cb_getCurrentPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VideoView.n_GetCurrentPosition));
			}
			return VideoView.cb_getCurrentPosition;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000D930 File Offset: 0x0000BB30
		private static int n_GetCurrentPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentPosition;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0000D93F File Offset: 0x0000BB3F
		public virtual int CurrentPosition
		{
			get
			{
				return VideoView._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentPosition.()I", this, null);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000D958 File Offset: 0x0000BB58
		private static Delegate GetGetDurationHandler()
		{
			if (VideoView.cb_getDuration == null)
			{
				VideoView.cb_getDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VideoView.n_GetDuration));
			}
			return VideoView.cb_getDuration;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000D97C File Offset: 0x0000BB7C
		private static int n_GetDuration(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0000D98B File Offset: 0x0000BB8B
		public virtual int Duration
		{
			get
			{
				return VideoView._members.InstanceMethods.InvokeVirtualInt32Method("getDuration.()I", this, null);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		private static Delegate GetIsPlayingHandler()
		{
			if (VideoView.cb_isPlaying == null)
			{
				VideoView.cb_isPlaying = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(VideoView.n_IsPlaying));
			}
			return VideoView.cb_isPlaying;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		private static bool n_IsPlaying(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPlaying;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0000D9D7 File Offset: 0x0000BBD7
		public virtual bool IsPlaying
		{
			get
			{
				return VideoView._members.InstanceMethods.InvokeVirtualBooleanMethod("isPlaying.()Z", this, null);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		private static Delegate GetCanPauseHandler()
		{
			if (VideoView.cb_canPause == null)
			{
				VideoView.cb_canPause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(VideoView.n_CanPause));
			}
			return VideoView.cb_canPause;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000DA14 File Offset: 0x0000BC14
		private static bool n_CanPause(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanPause();
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000DA23 File Offset: 0x0000BC23
		public virtual bool CanPause()
		{
			return VideoView._members.InstanceMethods.InvokeVirtualBooleanMethod("canPause.()Z", this, null);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		private static Delegate GetCanSeekBackwardHandler()
		{
			if (VideoView.cb_canSeekBackward == null)
			{
				VideoView.cb_canSeekBackward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(VideoView.n_CanSeekBackward));
			}
			return VideoView.cb_canSeekBackward;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000DA60 File Offset: 0x0000BC60
		private static bool n_CanSeekBackward(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanSeekBackward();
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000DA6F File Offset: 0x0000BC6F
		public virtual bool CanSeekBackward()
		{
			return VideoView._members.InstanceMethods.InvokeVirtualBooleanMethod("canSeekBackward.()Z", this, null);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000DA88 File Offset: 0x0000BC88
		private static Delegate GetCanSeekForwardHandler()
		{
			if (VideoView.cb_canSeekForward == null)
			{
				VideoView.cb_canSeekForward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(VideoView.n_CanSeekForward));
			}
			return VideoView.cb_canSeekForward;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		private static bool n_CanSeekForward(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanSeekForward();
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000DABB File Offset: 0x0000BCBB
		public virtual bool CanSeekForward()
		{
			return VideoView._members.InstanceMethods.InvokeVirtualBooleanMethod("canSeekForward.()Z", this, null);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		private static Delegate GetPauseHandler()
		{
			if (VideoView.cb_pause == null)
			{
				VideoView.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VideoView.n_Pause));
			}
			return VideoView.cb_pause;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		private static void n_Pause(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000DB07 File Offset: 0x0000BD07
		public virtual void Pause()
		{
			VideoView._members.InstanceMethods.InvokeVirtualVoidMethod("pause.()V", this, null);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000DB20 File Offset: 0x0000BD20
		private static Delegate GetSeekTo_IHandler()
		{
			if (VideoView.cb_seekTo_I == null)
			{
				VideoView.cb_seekTo_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(VideoView.n_SeekTo_I));
			}
			return VideoView.cb_seekTo_I;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000DB44 File Offset: 0x0000BD44
		private static void n_SeekTo_I(IntPtr jnienv, IntPtr native__this, int msec)
		{
			Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SeekTo(msec);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000DB54 File Offset: 0x0000BD54
		public unsafe virtual void SeekTo(int msec)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(msec);
			VideoView._members.InstanceMethods.InvokeVirtualVoidMethod("seekTo.(I)V", this, ptr);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000DB8F File Offset: 0x0000BD8F
		private static Delegate GetSetMediaController_Landroid_widget_MediaController_Handler()
		{
			if (VideoView.cb_setMediaController_Landroid_widget_MediaController_ == null)
			{
				VideoView.cb_setMediaController_Landroid_widget_MediaController_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoView.n_SetMediaController_Landroid_widget_MediaController_));
			}
			return VideoView.cb_setMediaController_Landroid_widget_MediaController_;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		private static void n_SetMediaController_Landroid_widget_MediaController_(IntPtr jnienv, IntPtr native__this, IntPtr native_controller)
		{
			VideoView @object = Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MediaController object2 = Java.Lang.Object.GetObject<MediaController>(native_controller, JniHandleOwnership.DoNotTransfer);
			@object.SetMediaController(object2);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		public unsafe virtual void SetMediaController(MediaController controller)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((controller == null) ? IntPtr.Zero : controller.Handle);
				VideoView._members.InstanceMethods.InvokeVirtualVoidMethod("setMediaController.(Landroid/widget/MediaController;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(controller);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		private static Delegate GetSetOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_Handler()
		{
			if (VideoView.cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_ == null)
			{
				VideoView.cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoView.n_SetOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_));
			}
			return VideoView.cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000DC60 File Offset: 0x0000BE60
		private static void n_SetOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			VideoView @object = Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MediaPlayer.IOnCompletionListener object2 = Java.Lang.Object.GetObject<MediaPlayer.IOnCompletionListener>(native_l, JniHandleOwnership.DoNotTransfer);
			@object.SetOnCompletionListener(object2);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000DC84 File Offset: 0x0000BE84
		public unsafe virtual void SetOnCompletionListener(MediaPlayer.IOnCompletionListener l)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((l == null) ? IntPtr.Zero : ((Java.Lang.Object)l).Handle);
				VideoView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnCompletionListener.(Landroid/media/MediaPlayer$OnCompletionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(l);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		private static Delegate GetSetVideoURI_Landroid_net_Uri_Handler()
		{
			if (VideoView.cb_setVideoURI_Landroid_net_Uri_ == null)
			{
				VideoView.cb_setVideoURI_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoView.n_SetVideoURI_Landroid_net_Uri_));
			}
			return VideoView.cb_setVideoURI_Landroid_net_Uri_;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000DD10 File Offset: 0x0000BF10
		private static void n_SetVideoURI_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			VideoView @object = Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			@object.SetVideoURI(object2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000DD34 File Offset: 0x0000BF34
		public unsafe virtual void SetVideoURI(Android.Net.Uri uri)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				VideoView._members.InstanceMethods.InvokeVirtualVoidMethod("setVideoURI.(Landroid/net/Uri;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000DD98 File Offset: 0x0000BF98
		private static Delegate GetStartHandler()
		{
			if (VideoView.cb_start == null)
			{
				VideoView.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VideoView.n_Start));
			}
			return VideoView.cb_start;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000DDCB File Offset: 0x0000BFCB
		public virtual void Start()
		{
			VideoView._members.InstanceMethods.InvokeVirtualVoidMethod("start.()V", this, null);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		private static Delegate GetStopPlaybackHandler()
		{
			if (VideoView.cb_stopPlayback == null)
			{
				VideoView.cb_stopPlayback = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VideoView.n_StopPlayback));
			}
			return VideoView.cb_stopPlayback;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000DE08 File Offset: 0x0000C008
		private static void n_StopPlayback(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopPlayback();
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000DE17 File Offset: 0x0000C017
		public virtual void StopPlayback()
		{
			VideoView._members.InstanceMethods.InvokeVirtualVoidMethod("stopPlayback.()V", this, null);
		}

		// Token: 0x04000176 RID: 374
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/VideoView", typeof(VideoView));

		// Token: 0x04000177 RID: 375
		private static Delegate cb_getAudioSessionId;

		// Token: 0x04000178 RID: 376
		private static Delegate cb_getBufferPercentage;

		// Token: 0x04000179 RID: 377
		private static Delegate cb_getCurrentPosition;

		// Token: 0x0400017A RID: 378
		private static Delegate cb_getDuration;

		// Token: 0x0400017B RID: 379
		private static Delegate cb_isPlaying;

		// Token: 0x0400017C RID: 380
		private static Delegate cb_canPause;

		// Token: 0x0400017D RID: 381
		private static Delegate cb_canSeekBackward;

		// Token: 0x0400017E RID: 382
		private static Delegate cb_canSeekForward;

		// Token: 0x0400017F RID: 383
		private static Delegate cb_pause;

		// Token: 0x04000180 RID: 384
		private static Delegate cb_seekTo_I;

		// Token: 0x04000181 RID: 385
		private static Delegate cb_setMediaController_Landroid_widget_MediaController_;

		// Token: 0x04000182 RID: 386
		private static Delegate cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_;

		// Token: 0x04000183 RID: 387
		private static Delegate cb_setVideoURI_Landroid_net_Uri_;

		// Token: 0x04000184 RID: 388
		private static Delegate cb_start;

		// Token: 0x04000185 RID: 389
		private static Delegate cb_stopPlayback;
	}
}
