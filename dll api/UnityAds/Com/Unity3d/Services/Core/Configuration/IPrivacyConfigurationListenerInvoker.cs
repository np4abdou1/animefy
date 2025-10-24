using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000175 RID: 373
	[Register("com/unity3d/services/core/configuration/IPrivacyConfigurationListener", DoNotGenerateAcw = true)]
	internal class IPrivacyConfigurationListenerInvoker : Java.Lang.Object, IPrivacyConfigurationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0002CBEC File Offset: 0x0002ADEC
		private static IntPtr java_class_ref
		{
			get
			{
				return IPrivacyConfigurationListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0002CC10 File Offset: 0x0002AE10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPrivacyConfigurationListenerInvoker._members;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0002CC17 File Offset: 0x0002AE17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0002CC1F File Offset: 0x0002AE1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPrivacyConfigurationListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0002CC2B File Offset: 0x0002AE2B
		public static IPrivacyConfigurationListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPrivacyConfigurationListener>(handle, transfer);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0002CC34 File Offset: 0x0002AE34
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPrivacyConfigurationListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IPrivacyConfigurationListener'.");
			}
			return handle;
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0002CC5F File Offset: 0x0002AE5F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0002CC90 File Offset: 0x0002AE90
		public IPrivacyConfigurationListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPrivacyConfigurationListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0002CCC8 File Offset: 0x0002AEC8
		private static Delegate GetOnError_Ljava_lang_String_Handler()
		{
			if (IPrivacyConfigurationListenerInvoker.cb_onError_Ljava_lang_String_ == null)
			{
				IPrivacyConfigurationListenerInvoker.cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IPrivacyConfigurationListenerInvoker.n_OnError_Ljava_lang_String_));
			}
			return IPrivacyConfigurationListenerInvoker.cb_onError_Ljava_lang_String_;
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0002CCEC File Offset: 0x0002AEEC
		private static void n_OnError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IPrivacyConfigurationListener @object = Java.Lang.Object.GetObject<IPrivacyConfigurationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnError(@string);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0002CD10 File Offset: 0x0002AF10
		public unsafe void OnError(string p0)
		{
			if (this.id_onError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onError", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0002CD81 File Offset: 0x0002AF81
		private static Delegate GetOnSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_Handler()
		{
			if (IPrivacyConfigurationListenerInvoker.cb_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_ == null)
			{
				IPrivacyConfigurationListenerInvoker.cb_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IPrivacyConfigurationListenerInvoker.n_OnSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_));
			}
			return IPrivacyConfigurationListenerInvoker.cb_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		private static void n_OnSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IPrivacyConfigurationListener @object = Java.Lang.Object.GetObject<IPrivacyConfigurationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PrivacyConfig object2 = Java.Lang.Object.GetObject<PrivacyConfig>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSuccess(object2);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0002CDCC File Offset: 0x0002AFCC
		public unsafe void OnSuccess(PrivacyConfig p0)
		{
			if (this.id_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_ == IntPtr.Zero)
			{
				this.id_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_ = JNIEnv.GetMethodID(this.class_ref, "onSuccess", "(Lcom/unity3d/services/core/configuration/PrivacyConfig;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_, ptr);
		}

		// Token: 0x04000424 RID: 1060
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IPrivacyConfigurationListener", typeof(IPrivacyConfigurationListenerInvoker));

		// Token: 0x04000425 RID: 1061
		private IntPtr class_ref;

		// Token: 0x04000426 RID: 1062
		private static Delegate cb_onError_Ljava_lang_String_;

		// Token: 0x04000427 RID: 1063
		private IntPtr id_onError_Ljava_lang_String_;

		// Token: 0x04000428 RID: 1064
		private static Delegate cb_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_;

		// Token: 0x04000429 RID: 1065
		private IntPtr id_onSuccess_Lcom_unity3d_services_core_configuration_PrivacyConfig_;
	}
}
