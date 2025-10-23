using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000134 RID: 308
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderWithRequestType", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderWithRequestType : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00022ED0 File Offset: 0x000210D0
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderWithRequestType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00022EF4 File Offset: 0x000210F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderWithRequestType._members;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00022EFC File Offset: 0x000210FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderWithRequestType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00022F20 File Offset: 0x00021120
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderWithRequestType._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderWithRequestType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00022F2C File Offset: 0x0002112C
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/configuration/InitRequestType;)V", "")]
		public unsafe DeviceInfoReaderWithRequestType(IDeviceInfoReader deviceInfoReader, InitRequestType initRequestType) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				ptr[1] = new JniArgumentValue((initRequestType == null) ? IntPtr.Zero : initRequestType.Handle);
				base.SetHandle(DeviceInfoReaderWithRequestType._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/configuration/InitRequestType;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderWithRequestType._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/configuration/InitRequestType;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoReader);
				GC.KeepAlive(initRequestType);
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00023008 File Offset: 0x00021208
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderWithRequestType.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderWithRequestType.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderWithRequestType.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderWithRequestType.cb_getDeviceInfoData;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0002302C File Offset: 0x0002122C
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderWithRequestType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00023040 File Offset: 0x00021240
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderWithRequestType._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002C9 RID: 713
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderWithRequestType", typeof(DeviceInfoReaderWithRequestType));

		// Token: 0x040002CA RID: 714
		private static Delegate cb_getDeviceInfoData;
	}
}
