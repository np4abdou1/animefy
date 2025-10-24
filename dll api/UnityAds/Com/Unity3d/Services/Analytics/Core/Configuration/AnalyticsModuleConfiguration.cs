using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Analytics.Core.Configuration
{
	// Token: 0x020001C9 RID: 457
	[Register("com/unity3d/services/analytics/core/configuration/AnalyticsModuleConfiguration", DoNotGenerateAcw = true)]
	public class AnalyticsModuleConfiguration : Java.Lang.Object, IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0003A2C8 File Offset: 0x000384C8
		internal static IntPtr class_ref
		{
			get
			{
				return AnalyticsModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0003A2EC File Offset: 0x000384EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnalyticsModuleConfiguration._members;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0003A2F4 File Offset: 0x000384F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnalyticsModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0003A318 File Offset: 0x00038518
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnalyticsModuleConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AnalyticsModuleConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0003A324 File Offset: 0x00038524
		[Register(".ctor", "()V", "")]
		public AnalyticsModuleConfiguration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AnalyticsModuleConfiguration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AnalyticsModuleConfiguration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0003A392 File Offset: 0x00038592
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (AnalyticsModuleConfiguration.cb_getWebAppApiClassList == null)
			{
				AnalyticsModuleConfiguration.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AnalyticsModuleConfiguration.n_GetWebAppApiClassList));
			}
			return AnalyticsModuleConfiguration.cb_getWebAppApiClassList;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0003A3B6 File Offset: 0x000385B6
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<AnalyticsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0003A3CC File Offset: 0x000385CC
		[Register("getWebAppApiClassList", "()[Ljava/lang/Class;", "GetGetWebAppApiClassListHandler")]
		public virtual Class[] GetWebAppApiClassList()
		{
			return (Class[])JNIEnv.GetArray(AnalyticsModuleConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebAppApiClassList.()[Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0003A40D File Offset: 0x0003860D
		private static Delegate GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (AnalyticsModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				AnalyticsModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AnalyticsModuleConfiguration.n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return AnalyticsModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0003A434 File Offset: 0x00038634
		private static bool n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			AnalyticsModuleConfiguration @object = Java.Lang.Object.GetObject<AnalyticsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitCompleteState(object2);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0003A458 File Offset: 0x00038658
		[Register("initCompleteState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitCompleteState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = AnalyticsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initCompleteState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0003A4C0 File Offset: 0x000386C0
		private static Delegate GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler()
		{
			if (AnalyticsModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == null)
			{
				AnalyticsModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(AnalyticsModuleConfiguration.n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_));
			}
			return AnalyticsModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0003A4E4 File Offset: 0x000386E4
		private static bool n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration, IntPtr native_state, IntPtr native_message)
		{
			AnalyticsModuleConfiguration @object = Java.Lang.Object.GetObject<AnalyticsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			ErrorState object3 = Java.Lang.Object.GetObject<ErrorState>(native_state, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			return @object.InitErrorState(object2, object3, @string);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0003A51C File Offset: 0x0003871C
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
				result = AnalyticsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initErrorState.(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(configuration);
				GC.KeepAlive(state);
			}
			return result;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0003A5CC File Offset: 0x000387CC
		private static Delegate GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (AnalyticsModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				AnalyticsModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AnalyticsModuleConfiguration.n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return AnalyticsModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0003A5F0 File Offset: 0x000387F0
		private static bool n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			AnalyticsModuleConfiguration @object = Java.Lang.Object.GetObject<AnalyticsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitModuleState(object2);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0003A614 File Offset: 0x00038814
		[Register("initModuleState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitModuleState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = AnalyticsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initModuleState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0003A67C File Offset: 0x0003887C
		private static Delegate GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (AnalyticsModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				AnalyticsModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AnalyticsModuleConfiguration.n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return AnalyticsModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0003A6A0 File Offset: 0x000388A0
		private static bool n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			AnalyticsModuleConfiguration @object = Java.Lang.Object.GetObject<AnalyticsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.ResetState(object2);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0003A6C4 File Offset: 0x000388C4
		[Register("resetState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool ResetState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = AnalyticsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("resetState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x040004DB RID: 1243
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/analytics/core/configuration/AnalyticsModuleConfiguration", typeof(AnalyticsModuleConfiguration));

		// Token: 0x040004DC RID: 1244
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x040004DD RID: 1245
		private static Delegate cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040004DE RID: 1246
		private static Delegate cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x040004DF RID: 1247
		private static Delegate cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040004E0 RID: 1248
		private static Delegate cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
