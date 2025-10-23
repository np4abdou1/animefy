using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200016F RID: 367
	[Register("com/unity3d/services/core/configuration/IModuleConfiguration", DoNotGenerateAcw = true)]
	internal class IModuleConfigurationInvoker : Java.Lang.Object, IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0002B5E4 File Offset: 0x000297E4
		private static IntPtr java_class_ref
		{
			get
			{
				return IModuleConfigurationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0002B608 File Offset: 0x00029808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IModuleConfigurationInvoker._members;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0002B60F File Offset: 0x0002980F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0002B617 File Offset: 0x00029817
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IModuleConfigurationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0002B623 File Offset: 0x00029823
		public static IModuleConfiguration GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IModuleConfiguration>(handle, transfer);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0002B62C File Offset: 0x0002982C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IModuleConfigurationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IModuleConfiguration'.");
			}
			return handle;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0002B657 File Offset: 0x00029857
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0002B688 File Offset: 0x00029888
		public IModuleConfigurationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IModuleConfigurationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002B6C0 File Offset: 0x000298C0
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (IModuleConfigurationInvoker.cb_getWebAppApiClassList == null)
			{
				IModuleConfigurationInvoker.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IModuleConfigurationInvoker.n_GetWebAppApiClassList));
			}
			return IModuleConfigurationInvoker.cb_getWebAppApiClassList;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0002B6E4 File Offset: 0x000298E4
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0002B6F8 File Offset: 0x000298F8
		public Class[] GetWebAppApiClassList()
		{
			if (this.id_getWebAppApiClassList == IntPtr.Zero)
			{
				this.id_getWebAppApiClassList = JNIEnv.GetMethodID(this.class_ref, "getWebAppApiClassList", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getWebAppApiClassList), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0002B758 File Offset: 0x00029958
		private static Delegate GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (IModuleConfigurationInvoker.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				IModuleConfigurationInvoker.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IModuleConfigurationInvoker.n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return IModuleConfigurationInvoker.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0002B77C File Offset: 0x0002997C
		private static bool n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.InitCompleteState(object2);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0002B7A0 File Offset: 0x000299A0
		public unsafe bool InitCompleteState(Configuration p0)
		{
			if (this.id_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == IntPtr.Zero)
			{
				this.id_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNIEnv.GetMethodID(this.class_ref, "initCompleteState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_, ptr);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0002B813 File Offset: 0x00029A13
		private static Delegate GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler()
		{
			if (IModuleConfigurationInvoker.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == null)
			{
				IModuleConfigurationInvoker.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IModuleConfigurationInvoker.n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_));
			}
			return IModuleConfigurationInvoker.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0002B838 File Offset: 0x00029A38
		private static bool n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			ErrorState object3 = Java.Lang.Object.GetObject<ErrorState>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			return @object.InitErrorState(object2, object3, @string);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0002B870 File Offset: 0x00029A70
		public unsafe bool InitErrorState(Configuration p0, ErrorState p1, string p2)
		{
			if (this.id_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "initErrorState", "(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0002B928 File Offset: 0x00029B28
		private static Delegate GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (IModuleConfigurationInvoker.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				IModuleConfigurationInvoker.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IModuleConfigurationInvoker.n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return IModuleConfigurationInvoker.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0002B94C File Offset: 0x00029B4C
		private static bool n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.InitModuleState(object2);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0002B970 File Offset: 0x00029B70
		public unsafe bool InitModuleState(Configuration p0)
		{
			if (this.id_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == IntPtr.Zero)
			{
				this.id_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNIEnv.GetMethodID(this.class_ref, "initModuleState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_, ptr);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0002B9E3 File Offset: 0x00029BE3
		private static Delegate GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (IModuleConfigurationInvoker.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				IModuleConfigurationInvoker.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IModuleConfigurationInvoker.n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return IModuleConfigurationInvoker.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0002BA08 File Offset: 0x00029C08
		private static bool n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.ResetState(object2);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0002BA2C File Offset: 0x00029C2C
		public unsafe bool ResetState(Configuration p0)
		{
			if (this.id_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == IntPtr.Zero)
			{
				this.id_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNIEnv.GetMethodID(this.class_ref, "resetState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_resetState_Lcom_unity3d_services_core_configuration_Configuration_, ptr);
		}

		// Token: 0x040003FA RID: 1018
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IModuleConfiguration", typeof(IModuleConfigurationInvoker));

		// Token: 0x040003FB RID: 1019
		private IntPtr class_ref;

		// Token: 0x040003FC RID: 1020
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x040003FD RID: 1021
		private IntPtr id_getWebAppApiClassList;

		// Token: 0x040003FE RID: 1022
		private static Delegate cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040003FF RID: 1023
		private IntPtr id_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000400 RID: 1024
		private static Delegate cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x04000401 RID: 1025
		private IntPtr id_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x04000402 RID: 1026
		private static Delegate cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000403 RID: 1027
		private IntPtr id_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000404 RID: 1028
		private static Delegate cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000405 RID: 1029
		private IntPtr id_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
