using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Video
{
	// Token: 0x020001D7 RID: 471
	[Register("com/unity3d/services/ads/video/VideoPlayerView", DoNotGenerateAcw = true)]
	public class VideoPlayerView : VideoView
	{
		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0003DCF4 File Offset: 0x0003BEF4
		internal static IntPtr class_ref
		{
			get
			{
				return VideoPlayerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0003DD18 File Offset: 0x0003BF18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoPlayerView._members;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0003DD20 File Offset: 0x0003BF20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoPlayerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0003DD44 File Offset: 0x0003BF44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoPlayerView._members.ManagedPeerType;
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0003DD50 File Offset: 0x0003BF50
		protected VideoPlayerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0003DD5C File Offset: 0x0003BF5C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VideoPlayerView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(VideoPlayerView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VideoPlayerView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0003DE0C File Offset: 0x0003C00C
		private static Delegate GetGetProgressEventIntervalHandler()
		{
			if (VideoPlayerView.cb_getProgressEventInterval == null)
			{
				VideoPlayerView.cb_getProgressEventInterval = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VideoPlayerView.n_GetProgressEventInterval));
			}
			return VideoPlayerView.cb_getProgressEventInterval;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0003DE30 File Offset: 0x0003C030
		private static int n_GetProgressEventInterval(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProgressEventInterval;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0003DE3F File Offset: 0x0003C03F
		private static Delegate GetSetProgressEventInterval_IHandler()
		{
			if (VideoPlayerView.cb_setProgressEventInterval_I == null)
			{
				VideoPlayerView.cb_setProgressEventInterval_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(VideoPlayerView.n_SetProgressEventInterval_I));
			}
			return VideoPlayerView.cb_setProgressEventInterval_I;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0003DE63 File Offset: 0x0003C063
		private static void n_SetProgressEventInterval_I(IntPtr jnienv, IntPtr native__this, int ms)
		{
			Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProgressEventInterval = ms;
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x0003DE73 File Offset: 0x0003C073
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0003DE8C File Offset: 0x0003C08C
		public unsafe virtual int ProgressEventInterval
		{
			[Register("getProgressEventInterval", "()I", "GetGetProgressEventIntervalHandler")]
			get
			{
				return VideoPlayerView._members.InstanceMethods.InvokeVirtualInt32Method("getProgressEventInterval.()I", this, null);
			}
			[Register("setProgressEventInterval", "(I)V", "GetSetProgressEventInterval_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				VideoPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("setProgressEventInterval.(I)V", this, ptr);
			}
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0003DEC7 File Offset: 0x0003C0C7
		private static Delegate GetGetVolumeHandler()
		{
			if (VideoPlayerView.cb_getVolume == null)
			{
				VideoPlayerView.cb_getVolume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(VideoPlayerView.n_GetVolume));
			}
			return VideoPlayerView.cb_getVolume;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0003DEEB File Offset: 0x0003C0EB
		private static float n_GetVolume(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Volume;
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0003DEFA File Offset: 0x0003C0FA
		public virtual float Volume
		{
			[Register("getVolume", "()F", "GetGetVolumeHandler")]
			get
			{
				return VideoPlayerView._members.InstanceMethods.InvokeVirtualSingleMethod("getVolume.()F", this, null);
			}
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0003DF13 File Offset: 0x0003C113
		private static Delegate GetGetVideoViewRectangleHandler()
		{
			if (VideoPlayerView.cb_getVideoViewRectangle == null)
			{
				VideoPlayerView.cb_getVideoViewRectangle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(VideoPlayerView.n_GetVideoViewRectangle));
			}
			return VideoPlayerView.cb_getVideoViewRectangle;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0003DF37 File Offset: 0x0003C137
		private static IntPtr n_GetVideoViewRectangle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetVideoViewRectangle());
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0003DF4C File Offset: 0x0003C14C
		[Register("getVideoViewRectangle", "()[I", "GetGetVideoViewRectangleHandler")]
		public virtual int[] GetVideoViewRectangle()
		{
			return (int[])JNIEnv.GetArray(VideoPlayerView._members.InstanceMethods.InvokeVirtualObjectMethod("getVideoViewRectangle.()[I", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0003DF8D File Offset: 0x0003C18D
		private static Delegate GetPlayHandler()
		{
			if (VideoPlayerView.cb_play == null)
			{
				VideoPlayerView.cb_play = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VideoPlayerView.n_Play));
			}
			return VideoPlayerView.cb_play;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0003DFB1 File Offset: 0x0003C1B1
		private static void n_Play(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Play();
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0003DFC0 File Offset: 0x0003C1C0
		[Register("play", "()V", "GetPlayHandler")]
		public virtual void Play()
		{
			VideoPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("play.()V", this, null);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0003DFD9 File Offset: 0x0003C1D9
		private static Delegate GetPrepare_Ljava_lang_String_FIHandler()
		{
			if (VideoPlayerView.cb_prepare_Ljava_lang_String_FI == null)
			{
				VideoPlayerView.cb_prepare_Ljava_lang_String_FI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFI_Z(VideoPlayerView.n_Prepare_Ljava_lang_String_FI));
			}
			return VideoPlayerView.cb_prepare_Ljava_lang_String_FI;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0003E000 File Offset: 0x0003C200
		private static bool n_Prepare_Ljava_lang_String_FI(IntPtr jnienv, IntPtr native__this, IntPtr native_url, float initialVolume, int timeout)
		{
			VideoPlayerView @object = Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_url, JniHandleOwnership.DoNotTransfer);
			return @object.Prepare(@string, initialVolume, timeout);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0003E028 File Offset: 0x0003C228
		[Register("prepare", "(Ljava/lang/String;FI)Z", "GetPrepare_Ljava_lang_String_FIHandler")]
		public unsafe virtual bool Prepare(string url, float initialVolume, int timeout)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(initialVolume);
				ptr[2] = new JniArgumentValue(timeout);
				result = VideoPlayerView._members.InstanceMethods.InvokeVirtualBooleanMethod("prepare.(Ljava/lang/String;FI)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0003E0B0 File Offset: 0x0003C2B0
		private static Delegate GetSetInfoListenerEnabled_ZHandler()
		{
			if (VideoPlayerView.cb_setInfoListenerEnabled_Z == null)
			{
				VideoPlayerView.cb_setInfoListenerEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(VideoPlayerView.n_SetInfoListenerEnabled_Z));
			}
			return VideoPlayerView.cb_setInfoListenerEnabled_Z;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0003E0D4 File Offset: 0x0003C2D4
		private static void n_SetInfoListenerEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetInfoListenerEnabled(enabled);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0003E0E4 File Offset: 0x0003C2E4
		[Register("setInfoListenerEnabled", "(Z)V", "GetSetInfoListenerEnabled_ZHandler")]
		public unsafe virtual void SetInfoListenerEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			VideoPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("setInfoListenerEnabled.(Z)V", this, ptr);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0003E11F File Offset: 0x0003C31F
		private static Delegate GetSetVolume_Ljava_lang_Float_Handler()
		{
			if (VideoPlayerView.cb_setVolume_Ljava_lang_Float_ == null)
			{
				VideoPlayerView.cb_setVolume_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoPlayerView.n_SetVolume_Ljava_lang_Float_));
			}
			return VideoPlayerView.cb_setVolume_Ljava_lang_Float_;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0003E144 File Offset: 0x0003C344
		private static void n_SetVolume_Ljava_lang_Float_(IntPtr jnienv, IntPtr native__this, IntPtr native_volume)
		{
			VideoPlayerView @object = Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Float object2 = Java.Lang.Object.GetObject<Float>(native_volume, JniHandleOwnership.DoNotTransfer);
			@object.SetVolume(object2);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0003E168 File Offset: 0x0003C368
		[Register("setVolume", "(Ljava/lang/Float;)V", "GetSetVolume_Ljava_lang_Float_Handler")]
		public unsafe virtual void SetVolume(Float volume)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((volume == null) ? IntPtr.Zero : volume.Handle);
				VideoPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("setVolume.(Ljava/lang/Float;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(volume);
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0003E1CC File Offset: 0x0003C3CC
		private static Delegate GetStopHandler()
		{
			if (VideoPlayerView.cb_stop == null)
			{
				VideoPlayerView.cb_stop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VideoPlayerView.n_Stop));
			}
			return VideoPlayerView.cb_stop;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0003E1F0 File Offset: 0x0003C3F0
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Stop();
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0003E1FF File Offset: 0x0003C3FF
		[Register("stop", "()V", "GetStopHandler")]
		public virtual void Stop()
		{
			VideoPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("stop.()V", this, null);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0003E218 File Offset: 0x0003C418
		private static Delegate GetStopPrepareTimerHandler()
		{
			if (VideoPlayerView.cb_stopPrepareTimer == null)
			{
				VideoPlayerView.cb_stopPrepareTimer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VideoPlayerView.n_StopPrepareTimer));
			}
			return VideoPlayerView.cb_stopPrepareTimer;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0003E23C File Offset: 0x0003C43C
		private static void n_StopPrepareTimer(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopPrepareTimer();
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0003E24B File Offset: 0x0003C44B
		[Register("stopPrepareTimer", "()V", "GetStopPrepareTimerHandler")]
		public virtual void StopPrepareTimer()
		{
			VideoPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("stopPrepareTimer.()V", this, null);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0003E264 File Offset: 0x0003C464
		private static Delegate GetStopVideoProgressTimerHandler()
		{
			if (VideoPlayerView.cb_stopVideoProgressTimer == null)
			{
				VideoPlayerView.cb_stopVideoProgressTimer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VideoPlayerView.n_StopVideoProgressTimer));
			}
			return VideoPlayerView.cb_stopVideoProgressTimer;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0003E288 File Offset: 0x0003C488
		private static void n_StopVideoProgressTimer(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VideoPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopVideoProgressTimer();
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0003E297 File Offset: 0x0003C497
		[Register("stopVideoProgressTimer", "()V", "GetStopVideoProgressTimerHandler")]
		public virtual void StopVideoProgressTimer()
		{
			VideoPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("stopVideoProgressTimer.()V", this, null);
		}

		// Token: 0x04000516 RID: 1302
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/video/VideoPlayerView", typeof(VideoPlayerView));

		// Token: 0x04000517 RID: 1303
		private static Delegate cb_getProgressEventInterval;

		// Token: 0x04000518 RID: 1304
		private static Delegate cb_setProgressEventInterval_I;

		// Token: 0x04000519 RID: 1305
		private static Delegate cb_getVolume;

		// Token: 0x0400051A RID: 1306
		private static Delegate cb_getVideoViewRectangle;

		// Token: 0x0400051B RID: 1307
		private static Delegate cb_play;

		// Token: 0x0400051C RID: 1308
		private static Delegate cb_prepare_Ljava_lang_String_FI;

		// Token: 0x0400051D RID: 1309
		private static Delegate cb_setInfoListenerEnabled_Z;

		// Token: 0x0400051E RID: 1310
		private static Delegate cb_setVolume_Ljava_lang_Float_;

		// Token: 0x0400051F RID: 1311
		private static Delegate cb_stop;

		// Token: 0x04000520 RID: 1312
		private static Delegate cb_stopPrepareTimer;

		// Token: 0x04000521 RID: 1313
		private static Delegate cb_stopVideoProgressTimer;
	}
}
