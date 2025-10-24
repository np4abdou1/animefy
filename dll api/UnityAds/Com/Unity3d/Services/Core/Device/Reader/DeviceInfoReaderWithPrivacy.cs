using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Com.Unity3d.Services.Core.Device.Reader.Pii;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000133 RID: 307
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderWithPrivacy", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderWithPrivacy : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00022CB8 File Offset: 0x00020EB8
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderWithPrivacy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00022CDC File Offset: 0x00020EDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderWithPrivacy._members;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00022CE4 File Offset: 0x00020EE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderWithPrivacy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00022D08 File Offset: 0x00020F08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderWithPrivacy._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderWithPrivacy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00022D14 File Offset: 0x00020F14
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/pii/PiiDataProvider;Lcom/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader;)V", "")]
		public unsafe DeviceInfoReaderWithPrivacy(IDeviceInfoReader deviceInfoReader, PrivacyConfigStorage privacyConfigStorage, PiiDataProvider piiDataProvider, PiiTrackingStatusReader piiTrackingStatusReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				ptr[1] = new JniArgumentValue((privacyConfigStorage == null) ? IntPtr.Zero : privacyConfigStorage.Handle);
				ptr[2] = new JniArgumentValue((piiDataProvider == null) ? IntPtr.Zero : piiDataProvider.Handle);
				ptr[3] = new JniArgumentValue((piiTrackingStatusReader == null) ? IntPtr.Zero : piiTrackingStatusReader.Handle);
				base.SetHandle(DeviceInfoReaderWithPrivacy._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/pii/PiiDataProvider;Lcom/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderWithPrivacy._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/pii/PiiDataProvider;Lcom/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoReader);
				GC.KeepAlive(privacyConfigStorage);
				GC.KeepAlive(piiDataProvider);
				GC.KeepAlive(piiTrackingStatusReader);
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00022E48 File Offset: 0x00021048
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderWithPrivacy.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderWithPrivacy.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderWithPrivacy.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderWithPrivacy.cb_getDeviceInfoData;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00022E6C File Offset: 0x0002106C
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderWithPrivacy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00022E80 File Offset: 0x00021080
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderWithPrivacy._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002C7 RID: 711
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderWithPrivacy", typeof(DeviceInfoReaderWithPrivacy));

		// Token: 0x040002C8 RID: 712
		private static Delegate cb_getDeviceInfoData;
	}
}
