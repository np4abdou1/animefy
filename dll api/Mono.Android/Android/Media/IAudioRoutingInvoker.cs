using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x02000202 RID: 514
	[Register("android/media/AudioRouting", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IAudioRoutingInvoker : Java.Lang.Object, IAudioRouting, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00030A4C File Offset: 0x0002EC4C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAudioRoutingInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00030A70 File Offset: 0x0002EC70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAudioRoutingInvoker._members;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x00030A77 File Offset: 0x0002EC77
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00030A7F File Offset: 0x0002EC7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAudioRoutingInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00030A8B File Offset: 0x0002EC8B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAudioRoutingInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.media.AudioRouting'.");
			}
			return handle;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00030AB6 File Offset: 0x0002ECB6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00030AE8 File Offset: 0x0002ECE8
		public IAudioRoutingInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAudioRoutingInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00030B20 File Offset: 0x0002ED20
		private static Delegate GetGetPreferredDeviceHandler()
		{
			if (IAudioRoutingInvoker.cb_getPreferredDevice == null)
			{
				IAudioRoutingInvoker.cb_getPreferredDevice = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAudioRoutingInvoker.n_GetPreferredDevice));
			}
			return IAudioRoutingInvoker.cb_getPreferredDevice;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00030B44 File Offset: 0x0002ED44
		private static IntPtr n_GetPreferredDevice(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAudioRouting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreferredDevice);
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00030B58 File Offset: 0x0002ED58
		public AudioDeviceInfo PreferredDevice
		{
			get
			{
				if (this.id_getPreferredDevice == IntPtr.Zero)
				{
					this.id_getPreferredDevice = JNIEnv.GetMethodID(this.class_ref, "getPreferredDevice", "()Landroid/media/AudioDeviceInfo;");
				}
				return Java.Lang.Object.GetObject<AudioDeviceInfo>(JNIEnv.CallObjectMethod(base.Handle, this.id_getPreferredDevice), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00030BA9 File Offset: 0x0002EDA9
		private static Delegate GetGetRoutedDeviceHandler()
		{
			if (IAudioRoutingInvoker.cb_getRoutedDevice == null)
			{
				IAudioRoutingInvoker.cb_getRoutedDevice = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAudioRoutingInvoker.n_GetRoutedDevice));
			}
			return IAudioRoutingInvoker.cb_getRoutedDevice;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00030BCD File Offset: 0x0002EDCD
		private static IntPtr n_GetRoutedDevice(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAudioRouting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RoutedDevice);
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00030BE4 File Offset: 0x0002EDE4
		public AudioDeviceInfo RoutedDevice
		{
			get
			{
				if (this.id_getRoutedDevice == IntPtr.Zero)
				{
					this.id_getRoutedDevice = JNIEnv.GetMethodID(this.class_ref, "getRoutedDevice", "()Landroid/media/AudioDeviceInfo;");
				}
				return Java.Lang.Object.GetObject<AudioDeviceInfo>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRoutedDevice), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00030C35 File Offset: 0x0002EE35
		private static Delegate GetAddOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_Handler()
		{
			if (IAudioRoutingInvoker.cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_ == null)
			{
				IAudioRoutingInvoker.cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAudioRoutingInvoker.n_AddOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_));
			}
			return IAudioRoutingInvoker.cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00030C5C File Offset: 0x0002EE5C
		private static void n_AddOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener, IntPtr native_handler)
		{
			IAudioRouting @object = Java.Lang.Object.GetObject<IAudioRouting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAudioRoutingOnRoutingChangedListener object2 = Java.Lang.Object.GetObject<IAudioRoutingOnRoutingChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			Handler object3 = Java.Lang.Object.GetObject<Handler>(native_handler, JniHandleOwnership.DoNotTransfer);
			@object.AddOnRoutingChangedListener(object2, object3);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00030C88 File Offset: 0x0002EE88
		public unsafe void AddOnRoutingChangedListener(IAudioRoutingOnRoutingChangedListener listener, Handler handler)
		{
			if (this.id_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_ == IntPtr.Zero)
			{
				this.id_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_ = JNIEnv.GetMethodID(this.class_ref, "addOnRoutingChangedListener", "(Landroid/media/AudioRouting$OnRoutingChangedListener;Landroid/os/Handler;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			ptr[1] = new JValue((handler == null) ? IntPtr.Zero : handler.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_, ptr);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00030D22 File Offset: 0x0002EF22
		private static Delegate GetRemoveOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Handler()
		{
			if (IAudioRoutingInvoker.cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_ == null)
			{
				IAudioRoutingInvoker.cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAudioRoutingInvoker.n_RemoveOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_));
			}
			return IAudioRoutingInvoker.cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00030D48 File Offset: 0x0002EF48
		private static void n_RemoveOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IAudioRouting @object = Java.Lang.Object.GetObject<IAudioRouting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAudioRoutingOnRoutingChangedListener object2 = Java.Lang.Object.GetObject<IAudioRoutingOnRoutingChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnRoutingChangedListener(object2);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00030D6C File Offset: 0x0002EF6C
		public unsafe void RemoveOnRoutingChangedListener(IAudioRoutingOnRoutingChangedListener listener)
		{
			if (this.id_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_ == IntPtr.Zero)
			{
				this.id_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_ = JNIEnv.GetMethodID(this.class_ref, "removeOnRoutingChangedListener", "(Landroid/media/AudioRouting$OnRoutingChangedListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_, ptr);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00030DE4 File Offset: 0x0002EFE4
		private static Delegate GetSetPreferredDevice_Landroid_media_AudioDeviceInfo_Handler()
		{
			if (IAudioRoutingInvoker.cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_ == null)
			{
				IAudioRoutingInvoker.cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAudioRoutingInvoker.n_SetPreferredDevice_Landroid_media_AudioDeviceInfo_));
			}
			return IAudioRoutingInvoker.cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00030E08 File Offset: 0x0002F008
		private static bool n_SetPreferredDevice_Landroid_media_AudioDeviceInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_deviceInfo)
		{
			IAudioRouting @object = Java.Lang.Object.GetObject<IAudioRouting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AudioDeviceInfo object2 = Java.Lang.Object.GetObject<AudioDeviceInfo>(native_deviceInfo, JniHandleOwnership.DoNotTransfer);
			return @object.SetPreferredDevice(object2);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00030E2C File Offset: 0x0002F02C
		public unsafe bool SetPreferredDevice(AudioDeviceInfo deviceInfo)
		{
			if (this.id_setPreferredDevice_Landroid_media_AudioDeviceInfo_ == IntPtr.Zero)
			{
				this.id_setPreferredDevice_Landroid_media_AudioDeviceInfo_ = JNIEnv.GetMethodID(this.class_ref, "setPreferredDevice", "(Landroid/media/AudioDeviceInfo;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((deviceInfo == null) ? IntPtr.Zero : deviceInfo.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_setPreferredDevice_Landroid_media_AudioDeviceInfo_, ptr);
		}

		// Token: 0x0400084B RID: 2123
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/AudioRouting", typeof(IAudioRoutingInvoker));

		// Token: 0x0400084C RID: 2124
		private IntPtr class_ref;

		// Token: 0x0400084D RID: 2125
		private static Delegate cb_getPreferredDevice;

		// Token: 0x0400084E RID: 2126
		private IntPtr id_getPreferredDevice;

		// Token: 0x0400084F RID: 2127
		private static Delegate cb_getRoutedDevice;

		// Token: 0x04000850 RID: 2128
		private IntPtr id_getRoutedDevice;

		// Token: 0x04000851 RID: 2129
		private static Delegate cb_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_;

		// Token: 0x04000852 RID: 2130
		private IntPtr id_addOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_Landroid_os_Handler_;

		// Token: 0x04000853 RID: 2131
		private static Delegate cb_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_;

		// Token: 0x04000854 RID: 2132
		private IntPtr id_removeOnRoutingChangedListener_Landroid_media_AudioRouting_OnRoutingChangedListener_;

		// Token: 0x04000855 RID: 2133
		private static Delegate cb_setPreferredDevice_Landroid_media_AudioDeviceInfo_;

		// Token: 0x04000856 RID: 2134
		private IntPtr id_setPreferredDevice_Landroid_media_AudioDeviceInfo_;
	}
}
