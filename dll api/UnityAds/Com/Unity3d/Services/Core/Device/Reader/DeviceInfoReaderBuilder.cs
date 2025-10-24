using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000129 RID: 297
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderBuilder", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderBuilder : Java.Lang.Object
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00021898 File Offset: 0x0001FA98
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000218BC File Offset: 0x0001FABC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderBuilder._members;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x000218C4 File Offset: 0x0001FAC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x000218E8 File Offset: 0x0001FAE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000218F4 File Offset: 0x0001FAF4
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/ConfigurationReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", "")]
		public unsafe DeviceInfoReaderBuilder(ConfigurationReader configurationReader, PrivacyConfigStorage privacyConfigStorage, IGameSessionIdReader gameSessionIdReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configurationReader == null) ? IntPtr.Zero : configurationReader.Handle);
				ptr[1] = new JniArgumentValue((privacyConfigStorage == null) ? IntPtr.Zero : privacyConfigStorage.Handle);
				ptr[2] = new JniArgumentValue((gameSessionIdReader == null) ? IntPtr.Zero : ((Java.Lang.Object)gameSessionIdReader).Handle);
				base.SetHandle(DeviceInfoReaderBuilder._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/ConfigurationReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderBuilder._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/ConfigurationReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configurationReader);
				GC.KeepAlive(privacyConfigStorage);
				GC.KeepAlive(gameSessionIdReader);
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000219FC File Offset: 0x0001FBFC
		private static Delegate GetBuildHandler()
		{
			if (DeviceInfoReaderBuilder.cb_build == null)
			{
				DeviceInfoReaderBuilder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderBuilder.n_Build));
			}
			return DeviceInfoReaderBuilder.cb_build;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00021A20 File Offset: 0x0001FC20
		private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00021A34 File Offset: 0x0001FC34
		[Register("build", "()Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;", "GetBuildHandler")]
		public virtual IDeviceInfoReader Build()
		{
			return Java.Lang.Object.GetObject<IDeviceInfoReader>(DeviceInfoReaderBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00021A66 File Offset: 0x0001FC66
		private static Delegate GetBuildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_Handler()
		{
			if (DeviceInfoReaderBuilder.cb_buildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_ == null)
			{
				DeviceInfoReaderBuilder.cb_buildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DeviceInfoReaderBuilder.n_BuildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_));
			}
			return DeviceInfoReaderBuilder.cb_buildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00021A8C File Offset: 0x0001FC8C
		private static IntPtr n_BuildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_(IntPtr jnienv, IntPtr native__this, IntPtr native_initRequestType)
		{
			DeviceInfoReaderBuilder @object = Java.Lang.Object.GetObject<DeviceInfoReaderBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			InitRequestType object2 = Java.Lang.Object.GetObject<InitRequestType>(native_initRequestType, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildWithRequestType(object2));
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00021AB4 File Offset: 0x0001FCB4
		[Register("buildWithRequestType", "(Lcom/unity3d/services/core/configuration/InitRequestType;)Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;", "GetBuildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_Handler")]
		protected unsafe virtual IDeviceInfoReader BuildWithRequestType(InitRequestType initRequestType)
		{
			IDeviceInfoReader @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initRequestType == null) ? IntPtr.Zero : initRequestType.Handle);
				@object = Java.Lang.Object.GetObject<IDeviceInfoReader>(DeviceInfoReaderBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("buildWithRequestType.(Lcom/unity3d/services/core/configuration/InitRequestType;)Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(initRequestType);
			}
			return @object;
		}

		// Token: 0x040002AF RID: 687
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderBuilder", typeof(DeviceInfoReaderBuilder));

		// Token: 0x040002B0 RID: 688
		private static Delegate cb_build;

		// Token: 0x040002B1 RID: 689
		private static Delegate cb_buildWithRequestType_Lcom_unity3d_services_core_configuration_InitRequestType_;
	}
}
