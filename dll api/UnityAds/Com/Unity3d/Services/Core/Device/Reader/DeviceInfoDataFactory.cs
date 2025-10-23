using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000128 RID: 296
	[Register("com/unity3d/services/core/device/reader/DeviceInfoDataFactory", DoNotGenerateAcw = true)]
	public class DeviceInfoDataFactory : Java.Lang.Object
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x000216F0 File Offset: 0x0001F8F0
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoDataFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00021714 File Offset: 0x0001F914
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoDataFactory._members;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0002171C File Offset: 0x0001F91C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoDataFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00021740 File Offset: 0x0001F940
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoDataFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoDataFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0002174C File Offset: 0x0001F94C
		[Register(".ctor", "()V", "")]
		public DeviceInfoDataFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DeviceInfoDataFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DeviceInfoDataFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000217BA File Offset: 0x0001F9BA
		private static Delegate GetGetDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_Handler()
		{
			if (DeviceInfoDataFactory.cb_getDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_ == null)
			{
				DeviceInfoDataFactory.cb_getDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DeviceInfoDataFactory.n_GetDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_));
			}
			return DeviceInfoDataFactory.cb_getDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000217E0 File Offset: 0x0001F9E0
		private static IntPtr n_GetDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_(IntPtr jnienv, IntPtr native__this, IntPtr native_callType)
		{
			DeviceInfoDataFactory @object = Java.Lang.Object.GetObject<DeviceInfoDataFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			InitRequestType object2 = Java.Lang.Object.GetObject<InitRequestType>(native_callType, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDeviceInfoData(object2));
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00021808 File Offset: 0x0001FA08
		[Register("getDeviceInfoData", "(Lcom/unity3d/services/core/configuration/InitRequestType;)Lcom/unity3d/services/core/device/reader/IDeviceInfoDataContainer;", "GetGetDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_Handler")]
		public unsafe virtual IDeviceInfoDataContainer GetDeviceInfoData(InitRequestType callType)
		{
			IDeviceInfoDataContainer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callType == null) ? IntPtr.Zero : callType.Handle);
				@object = Java.Lang.Object.GetObject<IDeviceInfoDataContainer>(DeviceInfoDataFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.(Lcom/unity3d/services/core/configuration/InitRequestType;)Lcom/unity3d/services/core/device/reader/IDeviceInfoDataContainer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callType);
			}
			return @object;
		}

		// Token: 0x040002AD RID: 685
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoDataFactory", typeof(DeviceInfoDataFactory));

		// Token: 0x040002AE RID: 686
		private static Delegate cb_getDeviceInfoData_Lcom_unity3d_services_core_configuration_InitRequestType_;
	}
}
