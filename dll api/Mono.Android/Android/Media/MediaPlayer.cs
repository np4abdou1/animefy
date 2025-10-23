using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x02000206 RID: 518
	[Register("android/media/MediaPlayer", DoNotGenerateAcw = true)]
	public class MediaPlayer : Java.Lang.Object, IAudioRouting, IJavaObject, IDisposable, IJavaPeerable, IVolumeAutomation
	{
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000310C3 File Offset: 0x0002F2C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaPlayer._members;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x000310CC File Offset: 0x0002F2CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaPlayer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000310F0 File Offset: 0x0002F2F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaPlayer._members.ManagedPeerType;
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000021E0 File Offset: 0x000003E0
		protected MediaPlayer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000310FC File Offset: 0x0002F2FC
		private static Delegate GetGetPreferredDeviceHandler()
		{
			if (MediaPlayer.cb_getPreferredDevice == null)
			{
				MediaPlayer.cb_getPreferredDevice = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediaPlayer.n_GetPreferredDevice));
			}
			return MediaPlayer.cb_getPreferredDevice;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00031120 File Offset: 0x0002F320
		private static IntPtr n_GetPreferredDevice(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MediaPlayer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreferredDevice);
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00031134 File Offset: 0x0002F334
		public virtual AudioDeviceInfo PreferredDevice
		{
			get
			{
				return Java.Lang.Object.GetObject<AudioDeviceInfo>(MediaPlayer._members.InstanceMethods.InvokeVirtualObjectMethod("getPreferredDevice.()Landroid/media/AudioDeviceInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00031166 File Offset: 0x0002F366
		private static Delegate GetGetRoutedDeviceHandler()
		{
			if (MediaPlayer.cb_getRoutedDevice == null)
			{
				MediaPlayer.cb_getRoutedDevice = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediaPlayer.n_GetRoutedDevice));
			}
			return MediaPlayer.cb_getRoutedDevice;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0003118A File Offset: 0x0002F38A
		private static IntPtr n_GetRoutedDevice(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MediaPlayer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RoutedDevice);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000311A0 File Offset: 0x0002F3A0
		public virtual AudioDeviceInfo RoutedDevice
		{
			get
			{
				return Java.Lang.Object.GetObject<AudioDeviceInfo>(MediaPlayer._members.InstanceMethods.InvokeVirtualObjectMethod("getRoutedDevice.()Landroid/media/AudioDeviceInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000311D2 File Offset: 0x0002F3D2
		private static Delegate GetAddOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_Handler()
		{
			if (MediaPlayer.cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_ == null)
			{
				MediaPlayer.cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediaPlayer.n_AddOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_));
			}
			return MediaPlayer.cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000311F8 File Offset: 0x0002F3F8
		private static void n_AddOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener, IntPtr native_handler)
		{
			MediaPlayer @object = Java.Lang.Object.GetObject<MediaPlayer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAudioRoutingOnRoutingChangedListener object2 = Java.Lang.Object.GetObject<IAudioRoutingOnRoutingChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			Handler object3 = Java.Lang.Object.GetObject<Handler>(native_handler, JniHandleOwnership.DoNotTransfer);
			@object.AddOnRoutingChangedListener(object2, object3);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00031224 File Offset: 0x0002F424
		public unsafe virtual void AddOnRoutingChangedListener(IAudioRoutingOnRoutingChangedListener listener, Handler handler)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ptr[1] = new JniArgumentValue((handler == null) ? IntPtr.Zero : handler.Handle);
				MediaPlayer._members.InstanceMethods.InvokeVirtualVoidMethod("addOnRoutingChangedListener.(Landroid/media/AudioRouting$OnRoutingChangedListener;Landroid/os/Handler;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
				GC.KeepAlive(handler);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000312B4 File Offset: 0x0002F4B4
		private static Delegate GetCreateVolumeShaper_Landroid_media_VolumeShaper_Configuration_Handler()
		{
			if (MediaPlayer.cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_ == null)
			{
				MediaPlayer.cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MediaPlayer.n_CreateVolumeShaper_Landroid_media_VolumeShaper_Configuration_));
			}
			return MediaPlayer.cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000312D8 File Offset: 0x0002F4D8
		private static IntPtr n_CreateVolumeShaper_Landroid_media_VolumeShaper_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			MediaPlayer @object = Java.Lang.Object.GetObject<MediaPlayer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			VolumeShaper.Configuration object2 = Java.Lang.Object.GetObject<VolumeShaper.Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateVolumeShaper(object2));
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00031300 File Offset: 0x0002F500
		public unsafe virtual VolumeShaper CreateVolumeShaper(VolumeShaper.Configuration configuration)
		{
			VolumeShaper @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				@object = Java.Lang.Object.GetObject<VolumeShaper>(MediaPlayer._members.InstanceMethods.InvokeVirtualObjectMethod("createVolumeShaper.(Landroid/media/VolumeShaper$Configuration;)Landroid/media/VolumeShaper;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return @object;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00031374 File Offset: 0x0002F574
		private static Delegate GetRemoveOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Handler()
		{
			if (MediaPlayer.cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_ == null)
			{
				MediaPlayer.cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediaPlayer.n_RemoveOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_));
			}
			return MediaPlayer.cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00031398 File Offset: 0x0002F598
		private static void n_RemoveOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			MediaPlayer @object = Java.Lang.Object.GetObject<MediaPlayer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAudioRoutingOnRoutingChangedListener object2 = Java.Lang.Object.GetObject<IAudioRoutingOnRoutingChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnRoutingChangedListener(object2);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000313BC File Offset: 0x0002F5BC
		public unsafe virtual void RemoveOnRoutingChangedListener(IAudioRoutingOnRoutingChangedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				MediaPlayer._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnRoutingChangedListener.(Landroid/media/AudioRouting$OnRoutingChangedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00031424 File Offset: 0x0002F624
		private static Delegate GetSetPreferredDevice_Landroid_media_AudioDeviceInfo_Handler()
		{
			if (MediaPlayer.cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_ == null)
			{
				MediaPlayer.cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MediaPlayer.n_SetPreferredDevice_Landroid_media_AudioDeviceInfo_));
			}
			return MediaPlayer.cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00031448 File Offset: 0x0002F648
		private static bool n_SetPreferredDevice_Landroid_media_AudioDeviceInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_deviceInfo)
		{
			MediaPlayer @object = Java.Lang.Object.GetObject<MediaPlayer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AudioDeviceInfo object2 = Java.Lang.Object.GetObject<AudioDeviceInfo>(native_deviceInfo, JniHandleOwnership.DoNotTransfer);
			return @object.SetPreferredDevice(object2);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0003146C File Offset: 0x0002F66C
		public unsafe virtual bool SetPreferredDevice(AudioDeviceInfo deviceInfo)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfo == null) ? IntPtr.Zero : deviceInfo.Handle);
				result = MediaPlayer._members.InstanceMethods.InvokeVirtualBooleanMethod("setPreferredDevice.(Landroid/media/AudioDeviceInfo;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfo);
			}
			return result;
		}

		// Token: 0x0400085C RID: 2140
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/MediaPlayer", typeof(MediaPlayer));

		// Token: 0x0400085D RID: 2141
		private static Delegate cb_getPreferredDevice;

		// Token: 0x0400085E RID: 2142
		private static Delegate cb_getRoutedDevice;

		// Token: 0x0400085F RID: 2143
		private static Delegate cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_;

		// Token: 0x04000860 RID: 2144
		private static Delegate cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_;

		// Token: 0x04000861 RID: 2145
		private static Delegate cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_;

		// Token: 0x04000862 RID: 2146
		private static Delegate cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_;

		// Token: 0x02000207 RID: 519
		[Register("android/media/MediaPlayer$OnCompletionListener", "", "Android.Media.MediaPlayer/IOnCompletionListenerInvoker")]
		public interface IOnCompletionListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060012C7 RID: 4807
			[Register("onCompletion", "(Landroid/media/MediaPlayer;)V", "GetOnCompletion_Landroid_media_MediaPlayer_Handler:Android.Media.MediaPlayer/IOnCompletionListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnCompletion(MediaPlayer mp);
		}

		// Token: 0x02000208 RID: 520
		[Register("android/media/MediaPlayer$OnCompletionListener", DoNotGenerateAcw = true)]
		internal class IOnCompletionListenerInvoker : Java.Lang.Object, MediaPlayer.IOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x060012C8 RID: 4808 RVA: 0x000314F0 File Offset: 0x0002F6F0
			private static IntPtr java_class_ref
			{
				get
				{
					return MediaPlayer.IOnCompletionListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00031514 File Offset: 0x0002F714
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MediaPlayer.IOnCompletionListenerInvoker._members;
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x060012CA RID: 4810 RVA: 0x0003151B File Offset: 0x0002F71B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x060012CB RID: 4811 RVA: 0x00031523 File Offset: 0x0002F723
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MediaPlayer.IOnCompletionListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060012CC RID: 4812 RVA: 0x0003152F File Offset: 0x0002F72F
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, MediaPlayer.IOnCompletionListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.media.MediaPlayer.OnCompletionListener'.");
				}
				return handle;
			}

			// Token: 0x060012CD RID: 4813 RVA: 0x0003155A File Offset: 0x0002F75A
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060012CE RID: 4814 RVA: 0x0003158C File Offset: 0x0002F78C
			public IOnCompletionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(MediaPlayer.IOnCompletionListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060012CF RID: 4815 RVA: 0x000315C4 File Offset: 0x0002F7C4
			private static Delegate GetOnCompletion_Landroid_media_MediaPlayer_Handler()
			{
				if (MediaPlayer.IOnCompletionListenerInvoker.cb_onCompletion_Landroid_media_MediaPlayer_ == null)
				{
					MediaPlayer.IOnCompletionListenerInvoker.cb_onCompletion_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediaPlayer.IOnCompletionListenerInvoker.n_OnCompletion_Landroid_media_MediaPlayer_));
				}
				return MediaPlayer.IOnCompletionListenerInvoker.cb_onCompletion_Landroid_media_MediaPlayer_;
			}

			// Token: 0x060012D0 RID: 4816 RVA: 0x000315E8 File Offset: 0x0002F7E8
			private static void n_OnCompletion_Landroid_media_MediaPlayer_(IntPtr jnienv, IntPtr native__this, IntPtr native_mp)
			{
				MediaPlayer.IOnCompletionListener @object = Java.Lang.Object.GetObject<MediaPlayer.IOnCompletionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MediaPlayer object2 = Java.Lang.Object.GetObject<MediaPlayer>(native_mp, JniHandleOwnership.DoNotTransfer);
				@object.OnCompletion(object2);
			}

			// Token: 0x060012D1 RID: 4817 RVA: 0x0003160C File Offset: 0x0002F80C
			public unsafe void OnCompletion(MediaPlayer mp)
			{
				if (this.id_onCompletion_Landroid_media_MediaPlayer_ == IntPtr.Zero)
				{
					this.id_onCompletion_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID(this.class_ref, "onCompletion", "(Landroid/media/MediaPlayer;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mp == null) ? IntPtr.Zero : mp.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onCompletion_Landroid_media_MediaPlayer_, ptr);
			}

			// Token: 0x04000863 RID: 2147
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/MediaPlayer$OnCompletionListener", typeof(MediaPlayer.IOnCompletionListenerInvoker));

			// Token: 0x04000864 RID: 2148
			private IntPtr class_ref;

			// Token: 0x04000865 RID: 2149
			private static Delegate cb_onCompletion_Landroid_media_MediaPlayer_;

			// Token: 0x04000866 RID: 2150
			private IntPtr id_onCompletion_Landroid_media_MediaPlayer_;
		}
	}
}
