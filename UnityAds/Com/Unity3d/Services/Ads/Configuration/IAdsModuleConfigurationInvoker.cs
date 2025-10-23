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
	// Token: 0x02000220 RID: 544
	[Register("com/unity3d/services/ads/configuration/IAdsModuleConfiguration", DoNotGenerateAcw = true)]
	internal class IAdsModuleConfigurationInvoker : Java.Lang.Object, IAdsModuleConfiguration, IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x000493A4 File Offset: 0x000475A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdsModuleConfigurationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x000493C8 File Offset: 0x000475C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdsModuleConfigurationInvoker._members;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x000493CF File Offset: 0x000475CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x000493D7 File Offset: 0x000475D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdsModuleConfigurationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000493E3 File Offset: 0x000475E3
		public static IAdsModuleConfiguration GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdsModuleConfiguration>(handle, transfer);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000493EC File Offset: 0x000475EC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdsModuleConfigurationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.configuration.IAdsModuleConfiguration'.");
			}
			return handle;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00049417 File Offset: 0x00047617
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00049448 File Offset: 0x00047648
		public IAdsModuleConfigurationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdsModuleConfigurationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00049480 File Offset: 0x00047680
		private static Delegate GetGetAdUnitViewHandlersHandler()
		{
			if (IAdsModuleConfigurationInvoker.cb_getAdUnitViewHandlers == null)
			{
				IAdsModuleConfigurationInvoker.cb_getAdUnitViewHandlers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdsModuleConfigurationInvoker.n_GetAdUnitViewHandlers));
			}
			return IAdsModuleConfigurationInvoker.cb_getAdUnitViewHandlers;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000494A4 File Offset: 0x000476A4
		private static IntPtr n_GetAdUnitViewHandlers(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Class>.ToLocalJniHandle(Java.Lang.Object.GetObject<IAdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitViewHandlers);
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x000494B8 File Offset: 0x000476B8
		public IDictionary<string, Class> AdUnitViewHandlers
		{
			get
			{
				if (this.id_getAdUnitViewHandlers == IntPtr.Zero)
				{
					this.id_getAdUnitViewHandlers = JNIEnv.GetMethodID(this.class_ref, "getAdUnitViewHandlers", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, Class>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdUnitViewHandlers), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00049509 File Offset: 0x00047709
		private static Delegate GetGetWebAppApiClassListHandler()
		{
			if (IAdsModuleConfigurationInvoker.cb_getWebAppApiClassList == null)
			{
				IAdsModuleConfigurationInvoker.cb_getWebAppApiClassList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdsModuleConfigurationInvoker.n_GetWebAppApiClassList));
			}
			return IAdsModuleConfigurationInvoker.cb_getWebAppApiClassList;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0004952D File Offset: 0x0004772D
		private static IntPtr n_GetWebAppApiClassList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IAdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetWebAppApiClassList());
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00049544 File Offset: 0x00047744
		public Class[] GetWebAppApiClassList()
		{
			if (this.id_getWebAppApiClassList == IntPtr.Zero)
			{
				this.id_getWebAppApiClassList = JNIEnv.GetMethodID(this.class_ref, "getWebAppApiClassList", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getWebAppApiClassList), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000495A4 File Offset: 0x000477A4
		private static Delegate GetInitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (IAdsModuleConfigurationInvoker.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				IAdsModuleConfigurationInvoker.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAdsModuleConfigurationInvoker.n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return IAdsModuleConfigurationInvoker.cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000495C8 File Offset: 0x000477C8
		private static bool n_InitCompleteState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IAdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.InitCompleteState(object2);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000495EC File Offset: 0x000477EC
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

		// Token: 0x0600199F RID: 6559 RVA: 0x0004965F File Offset: 0x0004785F
		private static Delegate GetInitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_Handler()
		{
			if (IAdsModuleConfigurationInvoker.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ == null)
			{
				IAdsModuleConfigurationInvoker.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IAdsModuleConfigurationInvoker.n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_));
			}
			return IAdsModuleConfigurationInvoker.cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00049684 File Offset: 0x00047884
		private static bool n_InitErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IAdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			ErrorState object3 = Java.Lang.Object.GetObject<ErrorState>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			return @object.InitErrorState(object2, object3, @string);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000496BC File Offset: 0x000478BC
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

		// Token: 0x060019A2 RID: 6562 RVA: 0x00049774 File Offset: 0x00047974
		private static Delegate GetInitModuleState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (IAdsModuleConfigurationInvoker.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				IAdsModuleConfigurationInvoker.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAdsModuleConfigurationInvoker.n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return IAdsModuleConfigurationInvoker.cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00049798 File Offset: 0x00047998
		private static bool n_InitModuleState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IAdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.InitModuleState(object2);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000497BC File Offset: 0x000479BC
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

		// Token: 0x060019A5 RID: 6565 RVA: 0x0004982F File Offset: 0x00047A2F
		private static Delegate GetResetState_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (IAdsModuleConfigurationInvoker.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				IAdsModuleConfigurationInvoker.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAdsModuleConfigurationInvoker.n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return IAdsModuleConfigurationInvoker.cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00049854 File Offset: 0x00047A54
		private static bool n_ResetState_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModuleConfiguration @object = Java.Lang.Object.GetObject<IAdsModuleConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.ResetState(object2);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00049878 File Offset: 0x00047A78
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

		// Token: 0x0400064A RID: 1610
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/configuration/IAdsModuleConfiguration", typeof(IAdsModuleConfigurationInvoker));

		// Token: 0x0400064B RID: 1611
		private IntPtr class_ref;

		// Token: 0x0400064C RID: 1612
		private static Delegate cb_getAdUnitViewHandlers;

		// Token: 0x0400064D RID: 1613
		private IntPtr id_getAdUnitViewHandlers;

		// Token: 0x0400064E RID: 1614
		private static Delegate cb_getWebAppApiClassList;

		// Token: 0x0400064F RID: 1615
		private IntPtr id_getWebAppApiClassList;

		// Token: 0x04000650 RID: 1616
		private static Delegate cb_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000651 RID: 1617
		private IntPtr id_initCompleteState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000652 RID: 1618
		private static Delegate cb_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x04000653 RID: 1619
		private IntPtr id_initErrorState_Lcom_unity3d_services_core_configuration_Configuration_Lcom_unity3d_services_core_configuration_ErrorState_Ljava_lang_String_;

		// Token: 0x04000654 RID: 1620
		private static Delegate cb_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000655 RID: 1621
		private IntPtr id_initModuleState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000656 RID: 1622
		private static Delegate cb_resetState_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x04000657 RID: 1623
		private IntPtr id_resetState_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
