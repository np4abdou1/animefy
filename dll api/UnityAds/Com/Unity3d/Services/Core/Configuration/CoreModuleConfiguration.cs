using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000153 RID: 339
	[Register("com/unity3d/services/core/configuration/CoreModuleConfiguration", DoNotGenerateAcw = true)]
	public class CoreModuleConfiguration : Java.Lang.Object, IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x000271A4 File Offset: 0x000253A4
		internal static IntPtr class_ref
		{
			get
			{
				return CoreModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000271C8 File Offset: 0x000253C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoreModuleConfiguration._members;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x000271D0 File Offset: 0x000253D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoreModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x000271F4 File Offset: 0x000253F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoreModuleConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000021E8 File Offset: 0x000003E8
		protected CoreModuleConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00027200 File Offset: 0x00025400
		[Register(".ctor", "()V", "")]
		public CoreModuleConfiguration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CoreModuleConfiguration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CoreModuleConfiguration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0002726E File Offset: 0x0002546E
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (CoreModuleConfiguration.cb_getWebAppApiClassList == null)
			{
				CoreModuleConfiguration.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CoreModuleConfiguration.n_GetWebAppApiClassList));
			}
			return CoreModuleConfiguration.cb_getWebAppApiClassList;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00027292 File Offset: 0x00025492
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<CoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000272A8 File Offset: 0x000254A8
		[Register("getWebAppApiClassList", "()[Ljava/lang/Class;", "GetGetWebAppApiClassListHandler")]
		public virtual Class[] GetWebAppApiClassList()
		{
			return (Class[])JNIEnv.GetArray(CoreModuleConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebAppApiClassList.()[Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000272E9 File Offset: 0x000254E9
		private static Delegate GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (CoreModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				CoreModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(CoreModuleConfiguration.n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return CoreModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00027310 File Offset: 0x00025510
		private static bool n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			CoreModuleConfiguration @object = Java.Lang.Object.GetObject<CoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitCompleteState(object2);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00027334 File Offset: 0x00025534
		[Register("initCompleteState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitCompleteState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = CoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initCompleteState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0002739C File Offset: 0x0002559C
		private static Delegate GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler()
		{
			if (CoreModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == null)
			{
				CoreModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(CoreModuleConfiguration.n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_));
			}
			return CoreModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000273C0 File Offset: 0x000255C0
		private static bool n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration, IntPtr native_state, IntPtr native_errorMessage)
		{
			CoreModuleConfiguration @object = Java.Lang.Object.GetObject<CoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			ErrorState object3 = Java.Lang.Object.GetObject<ErrorState>(native_state, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorMessage, JniHandleOwnership.DoNotTransfer);
			return @object.InitErrorState(object2, object3, @string);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000273F8 File Offset: 0x000255F8
		[Register("initErrorState", "(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", "GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler")]
		public unsafe virtual bool InitErrorState(Configuration configuration, ErrorState state, string errorMessage)
		{
			IntPtr intPtr = JNIEnv.NewString(errorMessage);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				result = CoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initErrorState.(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(configuration);
				GC.KeepAlive(state);
			}
			return result;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000274A8 File Offset: 0x000256A8
		private static Delegate GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (CoreModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				CoreModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(CoreModuleConfiguration.n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return CoreModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000274CC File Offset: 0x000256CC
		private static bool n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			CoreModuleConfiguration @object = Java.Lang.Object.GetObject<CoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitModuleState(object2);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000274F0 File Offset: 0x000256F0
		[Register("initModuleState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitModuleState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = CoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initModuleState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00027558 File Offset: 0x00025758
		private static Delegate GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (CoreModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				CoreModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(CoreModuleConfiguration.n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return CoreModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0002757C File Offset: 0x0002577C
		private static bool n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			CoreModuleConfiguration @object = Java.Lang.Object.GetObject<CoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.ResetState(object2);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000275A0 File Offset: 0x000257A0
		[Register("resetState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool ResetState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = CoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("resetState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x04000344 RID: 836
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/CoreModuleConfiguration", typeof(CoreModuleConfiguration));

		// Token: 0x04000345 RID: 837
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x04000346 RID: 838
		private static Delegate cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000347 RID: 839
		private static Delegate cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x04000348 RID: 840
		private static Delegate cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000349 RID: 841
		private static Delegate cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
