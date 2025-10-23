using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000179 RID: 377
	[Register("com/unity3d/services/core/configuration/PrivacyConfigStorage", DoNotGenerateAcw = true)]
	public class PrivacyConfigStorage : Observable
	{
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0002D3E8 File Offset: 0x0002B5E8
		internal new static IntPtr class_ref
		{
			get
			{
				return PrivacyConfigStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0002D40C File Offset: 0x0002B60C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PrivacyConfigStorage._members;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0002D414 File Offset: 0x0002B614
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PrivacyConfigStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0002D438 File Offset: 0x0002B638
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PrivacyConfigStorage._members.ManagedPeerType;
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0001A297 File Offset: 0x00018497
		protected PrivacyConfigStorage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0002D444 File Offset: 0x0002B644
		public static PrivacyConfigStorage Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;", "")]
			get
			{
				return Java.Lang.Object.GetObject<PrivacyConfigStorage>(PrivacyConfigStorage._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0002D475 File Offset: 0x0002B675
		private static Delegate GetGetPrivacyConfigHandler()
		{
			if (PrivacyConfigStorage.cb_getPrivacyConfig == null)
			{
				PrivacyConfigStorage.cb_getPrivacyConfig = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PrivacyConfigStorage.n_GetPrivacyConfig));
			}
			return PrivacyConfigStorage.cb_getPrivacyConfig;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0002D499 File Offset: 0x0002B699
		private static IntPtr n_GetPrivacyConfig(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PrivacyConfigStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyConfig);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0002D4AD File Offset: 0x0002B6AD
		private static Delegate GetSetPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_Handler()
		{
			if (PrivacyConfigStorage.cb_setPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_ == null)
			{
				PrivacyConfigStorage.cb_setPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PrivacyConfigStorage.n_SetPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_));
			}
			return PrivacyConfigStorage.cb_setPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0002D4D4 File Offset: 0x0002B6D4
		private static void n_SetPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_(IntPtr jnienv, IntPtr native__this, IntPtr native_privacyConfig)
		{
			PrivacyConfigStorage @object = Java.Lang.Object.GetObject<PrivacyConfigStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PrivacyConfig object2 = Java.Lang.Object.GetObject<PrivacyConfig>(native_privacyConfig, JniHandleOwnership.DoNotTransfer);
			@object.PrivacyConfig = object2;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0002D52C File Offset: 0x0002B72C
		public unsafe virtual PrivacyConfig PrivacyConfig
		{
			[Register("getPrivacyConfig", "()Lcom/unity3d/services/core/configuration/PrivacyConfig;", "GetGetPrivacyConfigHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PrivacyConfig>(PrivacyConfigStorage._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivacyConfig.()Lcom/unity3d/services/core/configuration/PrivacyConfig;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPrivacyConfig", "(Lcom/unity3d/services/core/configuration/PrivacyConfig;)V", "GetSetPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					PrivacyConfigStorage._members.InstanceMethods.InvokeVirtualVoidMethod("setPrivacyConfig.(Lcom/unity3d/services/core/configuration/PrivacyConfig;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0002D590 File Offset: 0x0002B790
		private static Delegate GetRegisterObserver_Lcom_unity3d_services_core_misc_IObserver_Handler()
		{
			if (PrivacyConfigStorage.cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_ == null)
			{
				PrivacyConfigStorage.cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PrivacyConfigStorage.n_RegisterObserver_Lcom_unity3d_services_core_misc_IObserver_));
			}
			return PrivacyConfigStorage.cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0002D5B4 File Offset: 0x0002B7B4
		private static void n_RegisterObserver_Lcom_unity3d_services_core_misc_IObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			Observable @object = Java.Lang.Object.GetObject<PrivacyConfigStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IObserver object2 = Java.Lang.Object.GetObject<IObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RegisterObserver(object2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
		[Register("registerObserver", "(Lcom/unity3d/services/core/misc/IObserver;)V", "GetRegisterObserver_Lcom_unity3d_services_core_misc_IObserver_Handler")]
		public unsafe override void RegisterObserver(IObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				PrivacyConfigStorage._members.InstanceMethods.InvokeVirtualVoidMethod("registerObserver.(Lcom/unity3d/services/core/misc/IObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x04000431 RID: 1073
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/PrivacyConfigStorage", typeof(PrivacyConfigStorage));

		// Token: 0x04000432 RID: 1074
		private static Delegate cb_getPrivacyConfig;

		// Token: 0x04000433 RID: 1075
		private static Delegate cb_setPrivacyConfig_Lcom_unity3d_services_core_configuration_PrivacyConfig_;

		// Token: 0x04000434 RID: 1076
		private static Delegate cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_;
	}
}
