using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200016B RID: 363
	[Register("com/unity3d/services/core/configuration/IInitializationNotificationCenter", DoNotGenerateAcw = true)]
	internal class IInitializationNotificationCenterInvoker : Java.Lang.Object, IInitializationNotificationCenter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x0002A710 File Offset: 0x00028910
		private static IntPtr java_class_ref
		{
			get
			{
				return IInitializationNotificationCenterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0002A734 File Offset: 0x00028934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInitializationNotificationCenterInvoker._members;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0002A73B File Offset: 0x0002893B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0002A743 File Offset: 0x00028943
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInitializationNotificationCenterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0002A74F File Offset: 0x0002894F
		public static IInitializationNotificationCenter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInitializationNotificationCenter>(handle, transfer);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0002A758 File Offset: 0x00028958
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInitializationNotificationCenterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IInitializationNotificationCenter'.");
			}
			return handle;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0002A783 File Offset: 0x00028983
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0002A7B4 File Offset: 0x000289B4
		public IInitializationNotificationCenterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInitializationNotificationCenterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0002A7EC File Offset: 0x000289EC
		private static Delegate GetAddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler()
		{
			if (IInitializationNotificationCenterInvoker.cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ == null)
			{
				IInitializationNotificationCenterInvoker.cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IInitializationNotificationCenterInvoker.n_AddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_));
			}
			return IInitializationNotificationCenterInvoker.cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0002A810 File Offset: 0x00028A10
		private static void n_AddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IInitializationNotificationCenter @object = Java.Lang.Object.GetObject<IInitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInitializationListener object2 = Java.Lang.Object.GetObject<IInitializationListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddListener(object2);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0002A834 File Offset: 0x00028A34
		public unsafe void AddListener(IInitializationListener p0)
		{
			if (this.id_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ == IntPtr.Zero)
			{
				this.id_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ = JNIEnv.GetMethodID(this.class_ref, "addListener", "(Lcom/unity3d/services/core/configuration/IInitializationListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_, ptr);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0002A8AC File Offset: 0x00028AAC
		private static Delegate GetRemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler()
		{
			if (IInitializationNotificationCenterInvoker.cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ == null)
			{
				IInitializationNotificationCenterInvoker.cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IInitializationNotificationCenterInvoker.n_RemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_));
			}
			return IInitializationNotificationCenterInvoker.cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0002A8D0 File Offset: 0x00028AD0
		private static void n_RemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IInitializationNotificationCenter @object = Java.Lang.Object.GetObject<IInitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInitializationListener object2 = Java.Lang.Object.GetObject<IInitializationListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveListener(object2);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		public unsafe void RemoveListener(IInitializationListener p0)
		{
			if (this.id_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ == IntPtr.Zero)
			{
				this.id_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ = JNIEnv.GetMethodID(this.class_ref, "removeListener", "(Lcom/unity3d/services/core/configuration/IInitializationListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_, ptr);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0002A96C File Offset: 0x00028B6C
		private static Delegate GetTriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler()
		{
			if (IInitializationNotificationCenterInvoker.cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I == null)
			{
				IInitializationNotificationCenterInvoker.cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(IInitializationNotificationCenterInvoker.n_TriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I));
			}
			return IInitializationNotificationCenterInvoker.cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0002A990 File Offset: 0x00028B90
		private static void n_TriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			IInitializationNotificationCenter @object = Java.Lang.Object.GetObject<IInitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.TriggerOnSdkInitializationFailed(@string, object2, p2);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		public unsafe void TriggerOnSdkInitializationFailed(string p0, ErrorState p1, int p2)
		{
			if (this.id_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I == IntPtr.Zero)
			{
				this.id_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I = JNIEnv.GetMethodID(this.class_ref, "triggerOnSdkInitializationFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0002AA69 File Offset: 0x00028C69
		private static Delegate GetTriggerOnSdkInitializedHandler()
		{
			if (IInitializationNotificationCenterInvoker.cb_triggerOnSdkInitialized == null)
			{
				IInitializationNotificationCenterInvoker.cb_triggerOnSdkInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializationNotificationCenterInvoker.n_TriggerOnSdkInitialized));
			}
			return IInitializationNotificationCenterInvoker.cb_triggerOnSdkInitialized;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0002AA8D File Offset: 0x00028C8D
		private static void n_TriggerOnSdkInitialized(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TriggerOnSdkInitialized();
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0002AA9C File Offset: 0x00028C9C
		public void TriggerOnSdkInitialized()
		{
			if (this.id_triggerOnSdkInitialized == IntPtr.Zero)
			{
				this.id_triggerOnSdkInitialized = JNIEnv.GetMethodID(this.class_ref, "triggerOnSdkInitialized", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_triggerOnSdkInitialized);
		}

		// Token: 0x040003CA RID: 970
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IInitializationNotificationCenter", typeof(IInitializationNotificationCenterInvoker));

		// Token: 0x040003CB RID: 971
		private IntPtr class_ref;

		// Token: 0x040003CC RID: 972
		private static Delegate cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;

		// Token: 0x040003CD RID: 973
		private IntPtr id_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;

		// Token: 0x040003CE RID: 974
		private static Delegate cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;

		// Token: 0x040003CF RID: 975
		private IntPtr id_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;

		// Token: 0x040003D0 RID: 976
		private static Delegate cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;

		// Token: 0x040003D1 RID: 977
		private IntPtr id_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;

		// Token: 0x040003D2 RID: 978
		private static Delegate cb_triggerOnSdkInitialized;

		// Token: 0x040003D3 RID: 979
		private IntPtr id_triggerOnSdkInitialized;
	}
}
