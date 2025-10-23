using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000160 RID: 352
	[Register("com/unity3d/services/core/configuration/IConfigurationLoaderListener", DoNotGenerateAcw = true)]
	internal class IConfigurationLoaderListenerInvoker : Java.Lang.Object, IConfigurationLoaderListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000297D0 File Offset: 0x000279D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IConfigurationLoaderListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000297F4 File Offset: 0x000279F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConfigurationLoaderListenerInvoker._members;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000297FB File Offset: 0x000279FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00029803 File Offset: 0x00027A03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConfigurationLoaderListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0002980F File Offset: 0x00027A0F
		public static IConfigurationLoaderListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConfigurationLoaderListener>(handle, transfer);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00029818 File Offset: 0x00027A18
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConfigurationLoaderListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IConfigurationLoaderListener'.");
			}
			return handle;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00029843 File Offset: 0x00027A43
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00029874 File Offset: 0x00027A74
		public IConfigurationLoaderListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConfigurationLoaderListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000298AC File Offset: 0x00027AAC
		private static Delegate GetOnError_Ljava_lang_String_Handler()
		{
			if (IConfigurationLoaderListenerInvoker.cb_onError_Ljava_lang_String_ == null)
			{
				IConfigurationLoaderListenerInvoker.cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConfigurationLoaderListenerInvoker.n_OnError_Ljava_lang_String_));
			}
			return IConfigurationLoaderListenerInvoker.cb_onError_Ljava_lang_String_;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000298D0 File Offset: 0x00027AD0
		private static void n_OnError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IConfigurationLoaderListener @object = Java.Lang.Object.GetObject<IConfigurationLoaderListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnError(@string);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000298F4 File Offset: 0x00027AF4
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

		// Token: 0x06000F41 RID: 3905 RVA: 0x00029965 File Offset: 0x00027B65
		private static Delegate GetOnSuccess_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (IConfigurationLoaderListenerInvoker.cb_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				IConfigurationLoaderListenerInvoker.cb_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConfigurationLoaderListenerInvoker.n_OnSuccess_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return IConfigurationLoaderListenerInvoker.cb_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0002998C File Offset: 0x00027B8C
		private static void n_OnSuccess_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IConfigurationLoaderListener @object = Java.Lang.Object.GetObject<IConfigurationLoaderListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSuccess(object2);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000299B0 File Offset: 0x00027BB0
		public unsafe void OnSuccess(Configuration p0)
		{
			if (this.id_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_ == IntPtr.Zero)
			{
				this.id_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_ = JNIEnv.GetMethodID(this.class_ref, "onSuccess", "(Lcom/unity3d/services/core/configuration/Configuration;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_, ptr);
		}

		// Token: 0x0400038F RID: 911
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IConfigurationLoaderListener", typeof(IConfigurationLoaderListenerInvoker));

		// Token: 0x04000390 RID: 912
		private IntPtr class_ref;

		// Token: 0x04000391 RID: 913
		private static Delegate cb_onError_Ljava_lang_String_;

		// Token: 0x04000392 RID: 914
		private IntPtr id_onError_Ljava_lang_String_;

		// Token: 0x04000393 RID: 915
		private static Delegate cb_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000394 RID: 916
		private IntPtr id_onSuccess_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
