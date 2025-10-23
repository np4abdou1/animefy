using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000170 RID: 368
	[Register("com/unity3d/services/core/configuration/InitializationNotificationCenter", DoNotGenerateAcw = true)]
	public class InitializationNotificationCenter : Java.Lang.Object, IInitializationNotificationCenter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0002BABC File Offset: 0x00029CBC
		internal static IntPtr class_ref
		{
			get
			{
				return InitializationNotificationCenter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0002BAE0 File Offset: 0x00029CE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitializationNotificationCenter._members;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitializationNotificationCenter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0002BB0C File Offset: 0x00029D0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitializationNotificationCenter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000021E8 File Offset: 0x000003E8
		protected InitializationNotificationCenter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0002BB18 File Offset: 0x00029D18
		[Register(".ctor", "()V", "")]
		public InitializationNotificationCenter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InitializationNotificationCenter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InitializationNotificationCenter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0002BB88 File Offset: 0x00029D88
		public static InitializationNotificationCenter Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/core/configuration/InitializationNotificationCenter;", "")]
			get
			{
				return Java.Lang.Object.GetObject<InitializationNotificationCenter>(InitializationNotificationCenter._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/core/configuration/InitializationNotificationCenter;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0002BBB9 File Offset: 0x00029DB9
		private static Delegate GetAddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler()
		{
			if (InitializationNotificationCenter.cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ == null)
			{
				InitializationNotificationCenter.cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InitializationNotificationCenter.n_AddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_));
			}
			return InitializationNotificationCenter.cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0002BBE0 File Offset: 0x00029DE0
		private static void n_AddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			InitializationNotificationCenter @object = Java.Lang.Object.GetObject<InitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInitializationListener object2 = Java.Lang.Object.GetObject<IInitializationListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddListener(object2);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0002BC04 File Offset: 0x00029E04
		[Register("addListener", "(Lcom/unity3d/services/core/configuration/IInitializationListener;)V", "GetAddListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler")]
		public unsafe virtual void AddListener(IInitializationListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				InitializationNotificationCenter._members.InstanceMethods.InvokeVirtualVoidMethod("addListener.(Lcom/unity3d/services/core/configuration/IInitializationListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0002BC6C File Offset: 0x00029E6C
		private static Delegate GetRemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler()
		{
			if (InitializationNotificationCenter.cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ == null)
			{
				InitializationNotificationCenter.cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InitializationNotificationCenter.n_RemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_));
			}
			return InitializationNotificationCenter.cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0002BC90 File Offset: 0x00029E90
		private static void n_RemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			InitializationNotificationCenter @object = Java.Lang.Object.GetObject<InitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInitializationListener object2 = Java.Lang.Object.GetObject<IInitializationListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveListener(object2);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0002BCB4 File Offset: 0x00029EB4
		[Register("removeListener", "(Lcom/unity3d/services/core/configuration/IInitializationListener;)V", "GetRemoveListener_Lcom_unity3d_services_core_configuration_IInitializationListener_Handler")]
		public unsafe virtual void RemoveListener(IInitializationListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				InitializationNotificationCenter._members.InstanceMethods.InvokeVirtualVoidMethod("removeListener.(Lcom/unity3d/services/core/configuration/IInitializationListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0002BD1C File Offset: 0x00029F1C
		private static Delegate GetTriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler()
		{
			if (InitializationNotificationCenter.cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I == null)
			{
				InitializationNotificationCenter.cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(InitializationNotificationCenter.n_TriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I));
			}
			return InitializationNotificationCenter.cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0002BD40 File Offset: 0x00029F40
		private static void n_TriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I(IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_errorState, int code)
		{
			InitializationNotificationCenter @object = Java.Lang.Object.GetObject<InitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_errorState, JniHandleOwnership.DoNotTransfer);
			@object.TriggerOnSdkInitializationFailed(@string, object2, code);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0002BD70 File Offset: 0x00029F70
		[Register("triggerOnSdkInitializationFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", "GetTriggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler")]
		public unsafe virtual void TriggerOnSdkInitializationFailed(string message, ErrorState errorState, int code)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((errorState == null) ? IntPtr.Zero : errorState.Handle);
				ptr[2] = new JniArgumentValue(code);
				InitializationNotificationCenter._members.InstanceMethods.InvokeVirtualVoidMethod("triggerOnSdkInitializationFailed.(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(errorState);
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0002BE0C File Offset: 0x0002A00C
		private static Delegate GetTriggerOnSdkInitializedHandler()
		{
			if (InitializationNotificationCenter.cb_triggerOnSdkInitialized == null)
			{
				InitializationNotificationCenter.cb_triggerOnSdkInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializationNotificationCenter.n_TriggerOnSdkInitialized));
			}
			return InitializationNotificationCenter.cb_triggerOnSdkInitialized;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0002BE30 File Offset: 0x0002A030
		private static void n_TriggerOnSdkInitialized(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializationNotificationCenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TriggerOnSdkInitialized();
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0002BE3F File Offset: 0x0002A03F
		[Register("triggerOnSdkInitialized", "()V", "GetTriggerOnSdkInitializedHandler")]
		public virtual void TriggerOnSdkInitialized()
		{
			InitializationNotificationCenter._members.InstanceMethods.InvokeVirtualVoidMethod("triggerOnSdkInitialized.()V", this, null);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0002BE58 File Offset: 0x0002A058
		private IInitializationListenerImplementor __CreateIInitializationListenerImplementor()
		{
			return new IInitializationListenerImplementor(this);
		}

		// Token: 0x04000406 RID: 1030
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/InitializationNotificationCenter", typeof(InitializationNotificationCenter));

		// Token: 0x04000407 RID: 1031
		private static Delegate cb_addListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;

		// Token: 0x04000408 RID: 1032
		private static Delegate cb_removeListener_Lcom_unity3d_services_core_configuration_IInitializationListener_;

		// Token: 0x04000409 RID: 1033
		private static Delegate cb_triggerOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;

		// Token: 0x0400040A RID: 1034
		private static Delegate cb_triggerOnSdkInitialized;
	}
}
