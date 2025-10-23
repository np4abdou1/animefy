using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners.Configuration
{
	// Token: 0x020001BE RID: 446
	[Register("com/unity3d/services/banners/configuration/BannersModuleConfiguration", DoNotGenerateAcw = true)]
	public class BannersModuleConfiguration : Java.Lang.Object, IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0003843C File Offset: 0x0003663C
		internal static IntPtr class_ref
		{
			get
			{
				return BannersModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x00038460 File Offset: 0x00036660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannersModuleConfiguration._members;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x00038468 File Offset: 0x00036668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannersModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0003848C File Offset: 0x0003668C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannersModuleConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BannersModuleConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00038498 File Offset: 0x00036698
		[Register(".ctor", "()V", "")]
		public BannersModuleConfiguration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BannersModuleConfiguration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BannersModuleConfiguration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00038506 File Offset: 0x00036706
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (BannersModuleConfiguration.cb_getWebAppApiClassList == null)
			{
				BannersModuleConfiguration.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BannersModuleConfiguration.n_GetWebAppApiClassList));
			}
			return BannersModuleConfiguration.cb_getWebAppApiClassList;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0003852A File Offset: 0x0003672A
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<BannersModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00038540 File Offset: 0x00036740
		[Register("getWebAppApiClassList", "()[Ljava/lang/Class;", "GetGetWebAppApiClassListHandler")]
		public virtual Class[] GetWebAppApiClassList()
		{
			return (Class[])JNIEnv.GetArray(BannersModuleConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebAppApiClassList.()[Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00038581 File Offset: 0x00036781
		private static Delegate GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (BannersModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				BannersModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(BannersModuleConfiguration.n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return BannersModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000385A8 File Offset: 0x000367A8
		private static bool n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			BannersModuleConfiguration @object = Java.Lang.Object.GetObject<BannersModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitCompleteState(object2);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000385CC File Offset: 0x000367CC
		[Register("initCompleteState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitCompleteState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = BannersModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initCompleteState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00038634 File Offset: 0x00036834
		private static Delegate GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler()
		{
			if (BannersModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == null)
			{
				BannersModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BannersModuleConfiguration.n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_));
			}
			return BannersModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00038658 File Offset: 0x00036858
		private static bool n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration, IntPtr native_state, IntPtr native_message)
		{
			BannersModuleConfiguration @object = Java.Lang.Object.GetObject<BannersModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			ErrorState object3 = Java.Lang.Object.GetObject<ErrorState>(native_state, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			return @object.InitErrorState(object2, object3, @string);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00038690 File Offset: 0x00036890
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
				result = BannersModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initErrorState.(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(configuration);
				GC.KeepAlive(state);
			}
			return result;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00038740 File Offset: 0x00036940
		private static Delegate GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (BannersModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				BannersModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(BannersModuleConfiguration.n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return BannersModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00038764 File Offset: 0x00036964
		private static bool n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			BannersModuleConfiguration @object = Java.Lang.Object.GetObject<BannersModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitModuleState(object2);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00038788 File Offset: 0x00036988
		[Register("initModuleState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitModuleState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = BannersModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initModuleState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000387F0 File Offset: 0x000369F0
		private static Delegate GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (BannersModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				BannersModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(BannersModuleConfiguration.n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return BannersModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00038814 File Offset: 0x00036A14
		private static bool n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			BannersModuleConfiguration @object = Java.Lang.Object.GetObject<BannersModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.ResetState(object2);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00038838 File Offset: 0x00036A38
		[Register("resetState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool ResetState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = BannersModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("resetState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x040004C9 RID: 1225
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/configuration/BannersModuleConfiguration", typeof(BannersModuleConfiguration));

		// Token: 0x040004CA RID: 1226
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x040004CB RID: 1227
		private static Delegate cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040004CC RID: 1228
		private static Delegate cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x040004CD RID: 1229
		private static Delegate cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040004CE RID: 1230
		private static Delegate cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
