using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Core.Configuration
{
	// Token: 0x0200006B RID: 107
	[Register("com/unity3d/services/store/core/configuration/StoreModuleConfiguration", DoNotGenerateAcw = true)]
	public class StoreModuleConfiguration : Java.Lang.Object, IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00009358 File Offset: 0x00007558
		internal static IntPtr class_ref
		{
			get
			{
				return StoreModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000937C File Offset: 0x0000757C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreModuleConfiguration._members;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00009384 File Offset: 0x00007584
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000093A8 File Offset: 0x000075A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreModuleConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000021E8 File Offset: 0x000003E8
		protected StoreModuleConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000093B4 File Offset: 0x000075B4
		[Register(".ctor", "()V", "")]
		public StoreModuleConfiguration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(StoreModuleConfiguration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			StoreModuleConfiguration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00009422 File Offset: 0x00007622
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (StoreModuleConfiguration.cb_getWebAppApiClassList == null)
			{
				StoreModuleConfiguration.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(StoreModuleConfiguration.n_GetWebAppApiClassList));
			}
			return StoreModuleConfiguration.cb_getWebAppApiClassList;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00009446 File Offset: 0x00007646
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<StoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000945C File Offset: 0x0000765C
		[Register("getWebAppApiClassList", "()[Ljava/lang/Class;", "GetGetWebAppApiClassListHandler")]
		public virtual Class[] GetWebAppApiClassList()
		{
			return (Class[])JNIEnv.GetArray(StoreModuleConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebAppApiClassList.()[Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000949D File Offset: 0x0000769D
		private static Delegate GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (StoreModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				StoreModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(StoreModuleConfiguration.n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return StoreModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000094C4 File Offset: 0x000076C4
		private static bool n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			StoreModuleConfiguration @object = Java.Lang.Object.GetObject<StoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitCompleteState(object2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000094E8 File Offset: 0x000076E8
		[Register("initCompleteState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitCompleteState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = StoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initCompleteState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00009550 File Offset: 0x00007750
		private static Delegate GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler()
		{
			if (StoreModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == null)
			{
				StoreModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(StoreModuleConfiguration.n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_));
			}
			return StoreModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00009574 File Offset: 0x00007774
		private static bool n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration, IntPtr native_state, IntPtr native_message)
		{
			StoreModuleConfiguration @object = Java.Lang.Object.GetObject<StoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			ErrorState object3 = Java.Lang.Object.GetObject<ErrorState>(native_state, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			return @object.InitErrorState(object2, object3, @string);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000095AC File Offset: 0x000077AC
		[Register("initErrorState", "(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", "GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler")]
		public unsafe virtual bool InitErrorState(Configuration configuration, ErrorState state, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				result = StoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initErrorState.(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(configuration);
				GC.KeepAlive(state);
			}
			return result;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000965C File Offset: 0x0000785C
		private static Delegate GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (StoreModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				StoreModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(StoreModuleConfiguration.n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return StoreModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00009680 File Offset: 0x00007880
		private static bool n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			StoreModuleConfiguration @object = Java.Lang.Object.GetObject<StoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitModuleState(object2);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000096A4 File Offset: 0x000078A4
		[Register("initModuleState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitModuleState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = StoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initModuleState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000970C File Offset: 0x0000790C
		private static Delegate GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (StoreModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				StoreModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(StoreModuleConfiguration.n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return StoreModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00009730 File Offset: 0x00007930
		private static bool n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			StoreModuleConfiguration @object = Java.Lang.Object.GetObject<StoreModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.ResetState(object2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00009754 File Offset: 0x00007954
		[Register("resetState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool ResetState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = StoreModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("resetState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x040000A5 RID: 165
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/core/configuration/StoreModuleConfiguration", typeof(StoreModuleConfiguration));

		// Token: 0x040000A6 RID: 166
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040000AA RID: 170
		private static Delegate cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
