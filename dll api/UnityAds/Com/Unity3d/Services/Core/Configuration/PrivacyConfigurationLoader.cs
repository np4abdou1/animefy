using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200017A RID: 378
	[Register("com/unity3d/services/core/configuration/PrivacyConfigurationLoader", DoNotGenerateAcw = true)]
	public class PrivacyConfigurationLoader : Java.Lang.Object, IConfigurationLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0002D65C File Offset: 0x0002B85C
		internal static IntPtr class_ref
		{
			get
			{
				return PrivacyConfigurationLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x0002D680 File Offset: 0x0002B880
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PrivacyConfigurationLoader._members;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x0002D688 File Offset: 0x0002B888
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PrivacyConfigurationLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0002D6AC File Offset: 0x0002B8AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PrivacyConfigurationLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PrivacyConfigurationLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0002D6B8 File Offset: 0x0002B8B8
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/IConfigurationLoader;Lcom/unity3d/services/core/configuration/ConfigurationRequestFactory;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;)V", "")]
		public unsafe PrivacyConfigurationLoader(IConfigurationLoader configurationLoader, ConfigurationRequestFactory configurationRequestFactory, PrivacyConfigStorage privacyConfigStorage) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configurationLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)configurationLoader).Handle);
				ptr[1] = new JniArgumentValue((configurationRequestFactory == null) ? IntPtr.Zero : configurationRequestFactory.Handle);
				ptr[2] = new JniArgumentValue((privacyConfigStorage == null) ? IntPtr.Zero : privacyConfigStorage.Handle);
				base.SetHandle(PrivacyConfigurationLoader._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/IConfigurationLoader;Lcom/unity3d/services/core/configuration/ConfigurationRequestFactory;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PrivacyConfigurationLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/IConfigurationLoader;Lcom/unity3d/services/core/configuration/ConfigurationRequestFactory;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configurationLoader);
				GC.KeepAlive(configurationRequestFactory);
				GC.KeepAlive(privacyConfigStorage);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0002D7C0 File Offset: 0x0002B9C0
		private static Delegate GetGetLocalConfigurationHandler()
		{
			if (PrivacyConfigurationLoader.cb_getLocalConfiguration == null)
			{
				PrivacyConfigurationLoader.cb_getLocalConfiguration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PrivacyConfigurationLoader.n_GetLocalConfiguration));
			}
			return PrivacyConfigurationLoader.cb_getLocalConfiguration;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0002D7E4 File Offset: 0x0002B9E4
		private static IntPtr n_GetLocalConfiguration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PrivacyConfigurationLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalConfiguration);
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
		public virtual Configuration LocalConfiguration
		{
			[Register("getLocalConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;", "GetGetLocalConfigurationHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(PrivacyConfigurationLoader._members.InstanceMethods.InvokeVirtualObjectMethod("getLocalConfiguration.()Lcom/unity3d/services/core/configuration/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0002D82A File Offset: 0x0002BA2A
		private static Delegate GetLoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_Handler()
		{
			if (PrivacyConfigurationLoader.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ == null)
			{
				PrivacyConfigurationLoader.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PrivacyConfigurationLoader.n_LoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_));
			}
			return PrivacyConfigurationLoader.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0002D850 File Offset: 0x0002BA50
		private static void n_LoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_configurationLoaderListener)
		{
			PrivacyConfigurationLoader @object = Java.Lang.Object.GetObject<PrivacyConfigurationLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConfigurationLoaderListener object2 = Java.Lang.Object.GetObject<IConfigurationLoaderListener>(native_configurationLoaderListener, JniHandleOwnership.DoNotTransfer);
			@object.LoadConfiguration(object2);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0002D874 File Offset: 0x0002BA74
		[Register("loadConfiguration", "(Lcom/unity3d/services/core/configuration/IConfigurationLoaderListener;)V", "GetLoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_Handler")]
		public unsafe virtual void LoadConfiguration(IConfigurationLoaderListener configurationLoaderListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configurationLoaderListener == null) ? IntPtr.Zero : ((Java.Lang.Object)configurationLoaderListener).Handle);
				PrivacyConfigurationLoader._members.InstanceMethods.InvokeVirtualVoidMethod("loadConfiguration.(Lcom/unity3d/services/core/configuration/IConfigurationLoaderListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configurationLoaderListener);
			}
		}

		// Token: 0x04000435 RID: 1077
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/PrivacyConfigurationLoader", typeof(PrivacyConfigurationLoader));

		// Token: 0x04000436 RID: 1078
		private static Delegate cb_getLocalConfiguration;

		// Token: 0x04000437 RID: 1079
		private static Delegate cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_;
	}
}
