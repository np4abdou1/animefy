using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000131 RID: 305
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderWithMetrics", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderWithMetrics : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00022934 File Offset: 0x00020B34
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderWithMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00022958 File Offset: 0x00020B58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderWithMetrics._members;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00022960 File Offset: 0x00020B60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderWithMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00022984 File Offset: 0x00020B84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderWithMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderWithMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00022990 File Offset: 0x00020B90
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", "")]
		public unsafe DeviceInfoReaderWithMetrics(IDeviceInfoReader deviceInfoReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				base.SetHandle(DeviceInfoReaderWithMetrics._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderWithMetrics._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoReader);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00022A44 File Offset: 0x00020C44
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderWithMetrics.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderWithMetrics.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderWithMetrics.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderWithMetrics.cb_getDeviceInfoData;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00022A68 File Offset: 0x00020C68
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderWithMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00022A7C File Offset: 0x00020C7C
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderWithMetrics._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002C3 RID: 707
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderWithMetrics", typeof(DeviceInfoReaderWithMetrics));

		// Token: 0x040002C4 RID: 708
		private static Delegate cb_getDeviceInfoData;
	}
}
