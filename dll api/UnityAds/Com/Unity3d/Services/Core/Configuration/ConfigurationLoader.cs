using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000150 RID: 336
	[Register("com/unity3d/services/core/configuration/ConfigurationLoader", DoNotGenerateAcw = true)]
	public class ConfigurationLoader : Java.Lang.Object, IConfigurationLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00026B30 File Offset: 0x00024D30
		internal static IntPtr class_ref
		{
			get
			{
				return ConfigurationLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00026B54 File Offset: 0x00024D54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConfigurationLoader._members;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00026B5C File Offset: 0x00024D5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConfigurationLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00026B80 File Offset: 0x00024D80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConfigurationLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ConfigurationLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00026B8C File Offset: 0x00024D8C
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/ConfigurationRequestFactory;)V", "")]
		public unsafe ConfigurationLoader(ConfigurationRequestFactory configurationRequestFactory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configurationRequestFactory == null) ? IntPtr.Zero : configurationRequestFactory.Handle);
				base.SetHandle(ConfigurationLoader._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/ConfigurationRequestFactory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ConfigurationLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/ConfigurationRequestFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configurationRequestFactory);
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00026C3C File Offset: 0x00024E3C
		private static Delegate GetGetLocalConfigurationHandler()
		{
			if (ConfigurationLoader.cb_getLocalConfiguration == null)
			{
				ConfigurationLoader.cb_getLocalConfiguration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConfigurationLoader.n_GetLocalConfiguration));
			}
			return ConfigurationLoader.cb_getLocalConfiguration;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00026C60 File Offset: 0x00024E60
		private static IntPtr n_GetLocalConfiguration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConfigurationLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalConfiguration);
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00026C74 File Offset: 0x00024E74
		public virtual Configuration LocalConfiguration
		{
			[Register("getLocalConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;", "GetGetLocalConfigurationHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(ConfigurationLoader._members.InstanceMethods.InvokeVirtualObjectMethod("getLocalConfiguration.()Lcom/unity3d/services/core/configuration/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00026CA6 File Offset: 0x00024EA6
		private static Delegate GetLoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_Handler()
		{
			if (ConfigurationLoader.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ == null)
			{
				ConfigurationLoader.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ConfigurationLoader.n_LoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_));
			}
			return ConfigurationLoader.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00026CCC File Offset: 0x00024ECC
		private static void n_LoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_configurationLoaderListener)
		{
			ConfigurationLoader @object = Java.Lang.Object.GetObject<ConfigurationLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConfigurationLoaderListener object2 = Java.Lang.Object.GetObject<IConfigurationLoaderListener>(native_configurationLoaderListener, JniHandleOwnership.DoNotTransfer);
			@object.LoadConfiguration(object2);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00026CF0 File Offset: 0x00024EF0
		[Register("loadConfiguration", "(Lcom/unity3d/services/core/configuration/IConfigurationLoaderListener;)V", "GetLoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_Handler")]
		public unsafe virtual void LoadConfiguration(IConfigurationLoaderListener configurationLoaderListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configurationLoaderListener == null) ? IntPtr.Zero : ((Java.Lang.Object)configurationLoaderListener).Handle);
				ConfigurationLoader._members.InstanceMethods.InvokeVirtualVoidMethod("loadConfiguration.(Lcom/unity3d/services/core/configuration/IConfigurationLoaderListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configurationLoaderListener);
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ConfigurationLoader", typeof(ConfigurationLoader));

		// Token: 0x0400033D RID: 829
		private static Delegate cb_getLocalConfiguration;

		// Token: 0x0400033E RID: 830
		private static Delegate cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_;
	}
}
