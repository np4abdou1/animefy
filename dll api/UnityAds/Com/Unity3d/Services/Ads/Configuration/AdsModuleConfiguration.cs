using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Configuration
{
	// Token: 0x0200021E RID: 542
	[Register("com/unity3d/services/ads/configuration/AdsModuleConfiguration", DoNotGenerateAcw = true)]
	public class AdsModuleConfiguration : Java.Lang.Object, IAdsModuleConfiguration, IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x00048EB8 File Offset: 0x000470B8
		internal static IntPtr class_ref
		{
			get
			{
				return AdsModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x00048EDC File Offset: 0x000470DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdsModuleConfiguration._members;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x00048EE4 File Offset: 0x000470E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdsModuleConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x00048F08 File Offset: 0x00047108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdsModuleConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdsModuleConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00048F14 File Offset: 0x00047114
		[Register(".ctor", "()V", "")]
		public AdsModuleConfiguration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdsModuleConfiguration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdsModuleConfiguration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00048F82 File Offset: 0x00047182
		private static Delegate GetGetAdUnitViewHandlersHandler()
		{
			if (AdsModuleConfiguration.cb_getAdUnitViewHandlers == null)
			{
				AdsModuleConfiguration.cb_getAdUnitViewHandlers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdsModuleConfiguration.n_GetAdUnitViewHandlers));
			}
			return AdsModuleConfiguration.cb_getAdUnitViewHandlers;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00048FA6 File Offset: 0x000471A6
		private static IntPtr n_GetAdUnitViewHandlers(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Class>.ToLocalJniHandle(Java.Lang.Object.GetObject<AdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitViewHandlers);
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00048FBC File Offset: 0x000471BC
		public virtual IDictionary<string, Class> AdUnitViewHandlers
		{
			[Register("getAdUnitViewHandlers", "()Ljava/util/Map;", "GetGetAdUnitViewHandlersHandler")]
			get
			{
				return JavaDictionary<string, Class>.FromJniHandle(AdsModuleConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitViewHandlers.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00048FEE File Offset: 0x000471EE
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (AdsModuleConfiguration.cb_getWebAppApiClassList == null)
			{
				AdsModuleConfiguration.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdsModuleConfiguration.n_GetWebAppApiClassList));
			}
			return AdsModuleConfiguration.cb_getWebAppApiClassList;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00049012 File Offset: 0x00047212
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<AdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00049028 File Offset: 0x00047228
		[Register("getWebAppApiClassList", "()[Ljava/lang/Class;", "GetGetWebAppApiClassListHandler")]
		public virtual Class[] GetWebAppApiClassList()
		{
			return (Class[])JNIEnv.GetArray(AdsModuleConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getWebAppApiClassList.()[Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00049069 File Offset: 0x00047269
		private static Delegate GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (AdsModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				AdsModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AdsModuleConfiguration.n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return AdsModuleConfiguration.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00049090 File Offset: 0x00047290
		private static bool n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			AdsModuleConfiguration @object = Java.Lang.Object.GetObject<AdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitCompleteState(object2);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000490B4 File Offset: 0x000472B4
		[Register("initCompleteState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitCompleteState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = AdsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initCompleteState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0004911C File Offset: 0x0004731C
		private static Delegate GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler()
		{
			if (AdsModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == null)
			{
				AdsModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(AdsModuleConfiguration.n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_));
			}
			return AdsModuleConfiguration.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00049140 File Offset: 0x00047340
		private static bool n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration, IntPtr native_state, IntPtr native_errorMessage)
		{
			AdsModuleConfiguration @object = Java.Lang.Object.GetObject<AdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			ErrorState object3 = Java.Lang.Object.GetObject<ErrorState>(native_state, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorMessage, JniHandleOwnership.DoNotTransfer);
			return @object.InitErrorState(object2, object3, @string);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00049178 File Offset: 0x00047378
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
				result = AdsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initErrorState.(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(configuration);
				GC.KeepAlive(state);
			}
			return result;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00049228 File Offset: 0x00047428
		private static Delegate GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (AdsModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				AdsModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AdsModuleConfiguration.n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return AdsModuleConfiguration.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0004924C File Offset: 0x0004744C
		private static bool n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			AdsModuleConfiguration @object = Java.Lang.Object.GetObject<AdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.InitModuleState(object2);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00049270 File Offset: 0x00047470
		[Register("initModuleState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool InitModuleState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = AdsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("initModuleState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000492D8 File Offset: 0x000474D8
		private static Delegate GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (AdsModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				AdsModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AdsModuleConfiguration.n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return AdsModuleConfiguration.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000492FC File Offset: 0x000474FC
		private static bool n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			AdsModuleConfiguration @object = Java.Lang.Object.GetObject<AdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return @object.ResetState(object2);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00049320 File Offset: 0x00047520
		[Register("resetState", "(Lcom/unity3d/services/core/configuration/Configuration;)Z", "GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual bool ResetState(Configuration configuration)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				result = AdsModuleConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("resetState.(Lcom/unity3d/services/core/configuration/Configuration;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return result;
		}

		// Token: 0x04000643 RID: 1603
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/configuration/AdsModuleConfiguration", typeof(AdsModuleConfiguration));

		// Token: 0x04000644 RID: 1604
		private static Delegate cb_getAdUnitViewHandlers;

		// Token: 0x04000645 RID: 1605
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x04000646 RID: 1606
		private static Delegate cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000647 RID: 1607
		private static Delegate cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x04000648 RID: 1608
		private static Delegate cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000649 RID: 1609
		private static Delegate cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
