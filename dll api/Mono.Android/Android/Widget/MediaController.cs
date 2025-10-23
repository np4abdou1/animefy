using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000DC RID: 220
	[Register("android/widget/MediaController", DoNotGenerateAcw = true)]
	public class MediaController : FrameLayout
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00009EAA File Offset: 0x000080AA
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaController._members;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00009EB4 File Offset: 0x000080B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaController._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00009ED8 File Offset: 0x000080D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaController._members.ManagedPeerType;
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000710C File Offset: 0x0000530C
		protected MediaController(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00009EE4 File Offset: 0x000080E4
		public unsafe MediaController(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MediaController._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediaController._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00009F94 File Offset: 0x00008194
		public unsafe MediaController(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MediaController._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediaController._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0400010B RID: 267
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/MediaController", typeof(MediaController));

		// Token: 0x020000DD RID: 221
		[Register("android/widget/MediaController$MediaPlayerControl", "", "Android.Widget.MediaController/IMediaPlayerControlInvoker")]
		public interface IMediaPlayerControl : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x060004D4 RID: 1236
			int AudioSessionId { [Register("getAudioSessionId", "()I", "GetGetAudioSessionIdHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")] get; }

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x060004D5 RID: 1237
			int BufferPercentage { [Register("getBufferPercentage", "()I", "GetGetBufferPercentageHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")] get; }

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x060004D6 RID: 1238
			int CurrentPosition { [Register("getCurrentPosition", "()I", "GetGetCurrentPositionHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")] get; }

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060004D7 RID: 1239
			int Duration { [Register("getDuration", "()I", "GetGetDurationHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")] get; }

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060004D8 RID: 1240
			bool IsPlaying { [Register("isPlaying", "()Z", "GetIsPlayingHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")] get; }

			// Token: 0x060004D9 RID: 1241
			[Register("canPause", "()Z", "GetCanPauseHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool CanPause();

			// Token: 0x060004DA RID: 1242
			[Register("canSeekBackward", "()Z", "GetCanSeekBackwardHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool CanSeekBackward();

			// Token: 0x060004DB RID: 1243
			[Register("canSeekForward", "()Z", "GetCanSeekForwardHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool CanSeekForward();

			// Token: 0x060004DC RID: 1244
			[Register("pause", "()V", "GetPauseHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void Pause();

			// Token: 0x060004DD RID: 1245
			[Register("seekTo", "(I)V", "GetSeekTo_IHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void SeekTo(int pos);

			// Token: 0x060004DE RID: 1246
			[Register("start", "()V", "GetStartHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void Start();
		}

		// Token: 0x020000DE RID: 222
		[Register("android/widget/MediaController$MediaPlayerControl", DoNotGenerateAcw = true)]
		internal class IMediaPlayerControlInvoker : Java.Lang.Object, MediaController.IMediaPlayerControl, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x0000A08C File Offset: 0x0000828C
			private static IntPtr java_class_ref
			{
				get
				{
					return MediaController.IMediaPlayerControlInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0000A0B0 File Offset: 0x000082B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MediaController.IMediaPlayerControlInvoker._members;
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0000A0B7 File Offset: 0x000082B7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000A0BF File Offset: 0x000082BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MediaController.IMediaPlayerControlInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x0000A0CB File Offset: 0x000082CB
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, MediaController.IMediaPlayerControlInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.MediaController.MediaPlayerControl'.");
				}
				return handle;
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x0000A0F6 File Offset: 0x000082F6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060004E5 RID: 1253 RVA: 0x0000A128 File Offset: 0x00008328
			public IMediaPlayerControlInvoker(IntPtr handle, JniHandleOwnership transfer) : base(MediaController.IMediaPlayerControlInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x0000A160 File Offset: 0x00008360
			private static Delegate GetGetAudioSessionIdHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_getAudioSessionId == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_getAudioSessionId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MediaController.IMediaPlayerControlInvoker.n_GetAudioSessionId));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_getAudioSessionId;
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x0000A184 File Offset: 0x00008384
			private static int n_GetAudioSessionId(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AudioSessionId;
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000A193 File Offset: 0x00008393
			public int AudioSessionId
			{
				get
				{
					if (this.id_getAudioSessionId == IntPtr.Zero)
					{
						this.id_getAudioSessionId = JNIEnv.GetMethodID(this.class_ref, "getAudioSessionId", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getAudioSessionId);
				}
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x0000A1D3 File Offset: 0x000083D3
			private static Delegate GetGetBufferPercentageHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_getBufferPercentage == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_getBufferPercentage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MediaController.IMediaPlayerControlInvoker.n_GetBufferPercentage));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_getBufferPercentage;
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x0000A1F7 File Offset: 0x000083F7
			private static int n_GetBufferPercentage(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BufferPercentage;
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060004EB RID: 1259 RVA: 0x0000A206 File Offset: 0x00008406
			public int BufferPercentage
			{
				get
				{
					if (this.id_getBufferPercentage == IntPtr.Zero)
					{
						this.id_getBufferPercentage = JNIEnv.GetMethodID(this.class_ref, "getBufferPercentage", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getBufferPercentage);
				}
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x0000A246 File Offset: 0x00008446
			private static Delegate GetGetCurrentPositionHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_getCurrentPosition == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_getCurrentPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MediaController.IMediaPlayerControlInvoker.n_GetCurrentPosition));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_getCurrentPosition;
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x0000A26A File Offset: 0x0000846A
			private static int n_GetCurrentPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentPosition;
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060004EE RID: 1262 RVA: 0x0000A279 File Offset: 0x00008479
			public int CurrentPosition
			{
				get
				{
					if (this.id_getCurrentPosition == IntPtr.Zero)
					{
						this.id_getCurrentPosition = JNIEnv.GetMethodID(this.class_ref, "getCurrentPosition", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getCurrentPosition);
				}
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x0000A2B9 File Offset: 0x000084B9
			private static Delegate GetGetDurationHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_getDuration == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_getDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MediaController.IMediaPlayerControlInvoker.n_GetDuration));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_getDuration;
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x0000A2DD File Offset: 0x000084DD
			private static int n_GetDuration(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration;
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0000A2EC File Offset: 0x000084EC
			public int Duration
			{
				get
				{
					if (this.id_getDuration == IntPtr.Zero)
					{
						this.id_getDuration = JNIEnv.GetMethodID(this.class_ref, "getDuration", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getDuration);
				}
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x0000A32C File Offset: 0x0000852C
			private static Delegate GetIsPlayingHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_isPlaying == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_isPlaying = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MediaController.IMediaPlayerControlInvoker.n_IsPlaying));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_isPlaying;
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x0000A350 File Offset: 0x00008550
			private static bool n_IsPlaying(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPlaying;
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0000A35F File Offset: 0x0000855F
			public bool IsPlaying
			{
				get
				{
					if (this.id_isPlaying == IntPtr.Zero)
					{
						this.id_isPlaying = JNIEnv.GetMethodID(this.class_ref, "isPlaying", "()Z");
					}
					return JNIEnv.CallBooleanMethod(base.Handle, this.id_isPlaying);
				}
			}

			// Token: 0x060004F5 RID: 1269 RVA: 0x0000A39F File Offset: 0x0000859F
			private static Delegate GetCanPauseHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_canPause == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_canPause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MediaController.IMediaPlayerControlInvoker.n_CanPause));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_canPause;
			}

			// Token: 0x060004F6 RID: 1270 RVA: 0x0000A3C3 File Offset: 0x000085C3
			private static bool n_CanPause(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanPause();
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x0000A3D2 File Offset: 0x000085D2
			public bool CanPause()
			{
				if (this.id_canPause == IntPtr.Zero)
				{
					this.id_canPause = JNIEnv.GetMethodID(this.class_ref, "canPause", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_canPause);
			}

			// Token: 0x060004F8 RID: 1272 RVA: 0x0000A412 File Offset: 0x00008612
			private static Delegate GetCanSeekBackwardHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_canSeekBackward == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_canSeekBackward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MediaController.IMediaPlayerControlInvoker.n_CanSeekBackward));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_canSeekBackward;
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x0000A436 File Offset: 0x00008636
			private static bool n_CanSeekBackward(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanSeekBackward();
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x0000A445 File Offset: 0x00008645
			public bool CanSeekBackward()
			{
				if (this.id_canSeekBackward == IntPtr.Zero)
				{
					this.id_canSeekBackward = JNIEnv.GetMethodID(this.class_ref, "canSeekBackward", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_canSeekBackward);
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x0000A485 File Offset: 0x00008685
			private static Delegate GetCanSeekForwardHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_canSeekForward == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_canSeekForward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MediaController.IMediaPlayerControlInvoker.n_CanSeekForward));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_canSeekForward;
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x0000A4A9 File Offset: 0x000086A9
			private static bool n_CanSeekForward(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanSeekForward();
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x0000A4B8 File Offset: 0x000086B8
			public bool CanSeekForward()
			{
				if (this.id_canSeekForward == IntPtr.Zero)
				{
					this.id_canSeekForward = JNIEnv.GetMethodID(this.class_ref, "canSeekForward", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_canSeekForward);
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x0000A4F8 File Offset: 0x000086F8
			private static Delegate GetPauseHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_pause == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MediaController.IMediaPlayerControlInvoker.n_Pause));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_pause;
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x0000A51C File Offset: 0x0000871C
			private static void n_Pause(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x0000A52B File Offset: 0x0000872B
			public void Pause()
			{
				if (this.id_pause == IntPtr.Zero)
				{
					this.id_pause = JNIEnv.GetMethodID(this.class_ref, "pause", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_pause);
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x0000A56B File Offset: 0x0000876B
			private static Delegate GetSeekTo_IHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_seekTo_I == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_seekTo_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MediaController.IMediaPlayerControlInvoker.n_SeekTo_I));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_seekTo_I;
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x0000A58F File Offset: 0x0000878F
			private static void n_SeekTo_I(IntPtr jnienv, IntPtr native__this, int pos)
			{
				Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SeekTo(pos);
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x0000A5A0 File Offset: 0x000087A0
			public unsafe void SeekTo(int pos)
			{
				if (this.id_seekTo_I == IntPtr.Zero)
				{
					this.id_seekTo_I = JNIEnv.GetMethodID(this.class_ref, "seekTo", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(pos);
				JNIEnv.CallVoidMethod(base.Handle, this.id_seekTo_I, ptr);
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x0000A604 File Offset: 0x00008804
			private static Delegate GetStartHandler()
			{
				if (MediaController.IMediaPlayerControlInvoker.cb_start == null)
				{
					MediaController.IMediaPlayerControlInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MediaController.IMediaPlayerControlInvoker.n_Start));
				}
				return MediaController.IMediaPlayerControlInvoker.cb_start;
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x0000A628 File Offset: 0x00008828
			private static void n_Start(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<MediaController.IMediaPlayerControl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x0000A637 File Offset: 0x00008837
			public void Start()
			{
				if (this.id_start == IntPtr.Zero)
				{
					this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_start);
			}

			// Token: 0x0400010C RID: 268
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/MediaController$MediaPlayerControl", typeof(MediaController.IMediaPlayerControlInvoker));

			// Token: 0x0400010D RID: 269
			private IntPtr class_ref;

			// Token: 0x0400010E RID: 270
			private static Delegate cb_getAudioSessionId;

			// Token: 0x0400010F RID: 271
			private IntPtr id_getAudioSessionId;

			// Token: 0x04000110 RID: 272
			private static Delegate cb_getBufferPercentage;

			// Token: 0x04000111 RID: 273
			private IntPtr id_getBufferPercentage;

			// Token: 0x04000112 RID: 274
			private static Delegate cb_getCurrentPosition;

			// Token: 0x04000113 RID: 275
			private IntPtr id_getCurrentPosition;

			// Token: 0x04000114 RID: 276
			private static Delegate cb_getDuration;

			// Token: 0x04000115 RID: 277
			private IntPtr id_getDuration;

			// Token: 0x04000116 RID: 278
			private static Delegate cb_isPlaying;

			// Token: 0x04000117 RID: 279
			private IntPtr id_isPlaying;

			// Token: 0x04000118 RID: 280
			private static Delegate cb_canPause;

			// Token: 0x04000119 RID: 281
			private IntPtr id_canPause;

			// Token: 0x0400011A RID: 282
			private static Delegate cb_canSeekBackward;

			// Token: 0x0400011B RID: 283
			private IntPtr id_canSeekBackward;

			// Token: 0x0400011C RID: 284
			private static Delegate cb_canSeekForward;

			// Token: 0x0400011D RID: 285
			private IntPtr id_canSeekForward;

			// Token: 0x0400011E RID: 286
			private static Delegate cb_pause;

			// Token: 0x0400011F RID: 287
			private IntPtr id_pause;

			// Token: 0x04000120 RID: 288
			private static Delegate cb_seekTo_I;

			// Token: 0x04000121 RID: 289
			private IntPtr id_seekTo_I;

			// Token: 0x04000122 RID: 290
			private static Delegate cb_start;

			// Token: 0x04000123 RID: 291
			private IntPtr id_start;
		}
	}
}
