using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Device.Reader;
using Com.Unity3d.Services.Core.Request;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000152 RID: 338
	[Register("com/unity3d/services/core/configuration/ConfigurationRequestFactory", DoNotGenerateAcw = true)]
	public class ConfigurationRequestFactory : Java.Lang.Object
	{
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00026EC8 File Offset: 0x000250C8
		internal static IntPtr class_ref
		{
			get
			{
				return ConfigurationRequestFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00026EEC File Offset: 0x000250EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConfigurationRequestFactory._members;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00026EF4 File Offset: 0x000250F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConfigurationRequestFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00026F18 File Offset: 0x00025118
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConfigurationRequestFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ConfigurationRequestFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00026F24 File Offset: 0x00025124
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe ConfigurationRequestFactory(Configuration configuration) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				base.SetHandle(ConfigurationRequestFactory._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/Configuration;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ConfigurationRequestFactory._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00026FD4 File Offset: 0x000251D4
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/device/reader/IDeviceInfoDataContainer;)V", "")]
		public unsafe ConfigurationRequestFactory(Configuration configuration, IDeviceInfoDataContainer deviceInfoDataContainer) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				ptr[1] = new JniArgumentValue((deviceInfoDataContainer == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoDataContainer).Handle);
				base.SetHandle(ConfigurationRequestFactory._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/device/reader/IDeviceInfoDataContainer;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ConfigurationRequestFactory._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/Configuration;Lcom/unity3d/services/core/device/reader/IDeviceInfoDataContainer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
				GC.KeepAlive(deviceInfoDataContainer);
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000270B0 File Offset: 0x000252B0
		private static Delegate GetGetConfigurationHandler()
		{
			if (ConfigurationRequestFactory.cb_getConfiguration == null)
			{
				ConfigurationRequestFactory.cb_getConfiguration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConfigurationRequestFactory.n_GetConfiguration));
			}
			return ConfigurationRequestFactory.cb_getConfiguration;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000270D4 File Offset: 0x000252D4
		private static IntPtr n_GetConfiguration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConfigurationRequestFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Configuration);
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x000270E8 File Offset: 0x000252E8
		public virtual Configuration Configuration
		{
			[Register("getConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;", "GetGetConfigurationHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(ConfigurationRequestFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getConfiguration.()Lcom/unity3d/services/core/configuration/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0002711A File Offset: 0x0002531A
		private static Delegate GetGetWebRequestHandler()
		{
			if (ConfigurationRequestFactory.cb_getWebRequest == null)
			{
				ConfigurationRequestFactory.cb_getWebRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConfigurationRequestFactory.n_GetWebRequest));
			}
			return ConfigurationRequestFactory.cb_getWebRequest;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0002713E File Offset: 0x0002533E
		private static IntPtr n_GetWebRequest(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConfigurationRequestFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebRequest);
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00027154 File Offset: 0x00025354
		public virtual WebRequest WebRequest
		{
			[Register("getWebRequest", "()Lcom/unity3d/services/core/request/WebRequest;", "GetGetWebRequestHandler")]
			get
			{
				return Java.Lang.Object.GetObject<WebRequest>(ConfigurationRequestFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getWebRequest.()Lcom/unity3d/services/core/request/WebRequest;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000341 RID: 833
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ConfigurationRequestFactory", typeof(ConfigurationRequestFactory));

		// Token: 0x04000342 RID: 834
		private static Delegate cb_getConfiguration;

		// Token: 0x04000343 RID: 835
		private static Delegate cb_getWebRequest;
	}
}
