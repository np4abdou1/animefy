using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Device.Reader.Pii;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000132 RID: 306
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderWithPII", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderWithPII : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00022ACC File Offset: 0x00020CCC
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderWithPII._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00022AF0 File Offset: 0x00020CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderWithPII._members;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00022AF8 File Offset: 0x00020CF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderWithPII._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00022B1C File Offset: 0x00020D1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderWithPII._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderWithPII(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00022B28 File Offset: 0x00020D28
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/device/reader/pii/PiiDataSelector;Lcom/unity3d/services/core/device/reader/pii/PiiDataProvider;)V", "")]
		public unsafe DeviceInfoReaderWithPII(IDeviceInfoReader deviceInfoReader, PiiDataSelector piiDataSelector, PiiDataProvider piiDataProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				ptr[1] = new JniArgumentValue((piiDataSelector == null) ? IntPtr.Zero : piiDataSelector.Handle);
				ptr[2] = new JniArgumentValue((piiDataProvider == null) ? IntPtr.Zero : piiDataProvider.Handle);
				base.SetHandle(DeviceInfoReaderWithPII._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/device/reader/pii/PiiDataSelector;Lcom/unity3d/services/core/device/reader/pii/PiiDataProvider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderWithPII._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/device/reader/pii/PiiDataSelector;Lcom/unity3d/services/core/device/reader/pii/PiiDataProvider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoReader);
				GC.KeepAlive(piiDataSelector);
				GC.KeepAlive(piiDataProvider);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00022C30 File Offset: 0x00020E30
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderWithPII.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderWithPII.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderWithPII.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderWithPII.cb_getDeviceInfoData;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00022C54 File Offset: 0x00020E54
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderWithPII>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00022C68 File Offset: 0x00020E68
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderWithPII._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002C5 RID: 709
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderWithPII", typeof(DeviceInfoReaderWithPII));

		// Token: 0x040002C6 RID: 710
		private static Delegate cb_getDeviceInfoData;
	}
}
