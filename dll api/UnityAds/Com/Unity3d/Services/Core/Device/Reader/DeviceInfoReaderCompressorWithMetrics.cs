using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200012B RID: 299
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderCompressorWithMetrics", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderCompressorWithMetrics : Java.Lang.Object, IDeviceInfoDataCompressor, IDeviceInfoDataContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00021E20 File Offset: 0x00020020
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderCompressorWithMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00021E44 File Offset: 0x00020044
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderCompressorWithMetrics._members;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00021E4C File Offset: 0x0002004C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderCompressorWithMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00021E70 File Offset: 0x00020070
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderCompressorWithMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderCompressorWithMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00021E7C File Offset: 0x0002007C
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoDataCompressor;)V", "")]
		public unsafe DeviceInfoReaderCompressorWithMetrics(IDeviceInfoDataCompressor deviceInfoDataCompressor) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoDataCompressor == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoDataCompressor).Handle);
				base.SetHandle(DeviceInfoReaderCompressorWithMetrics._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoDataCompressor;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderCompressorWithMetrics._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoDataCompressor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoDataCompressor);
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00021F30 File Offset: 0x00020130
		private static Delegate GetGetDeviceInfoHandler()
		{
			if (DeviceInfoReaderCompressorWithMetrics.cb_getDeviceInfo == null)
			{
				DeviceInfoReaderCompressorWithMetrics.cb_getDeviceInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderCompressorWithMetrics.n_GetDeviceInfo));
			}
			return DeviceInfoReaderCompressorWithMetrics.cb_getDeviceInfo;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00021F54 File Offset: 0x00020154
		private static IntPtr n_GetDeviceInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderCompressorWithMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfo);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00021F68 File Offset: 0x00020168
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfo
		{
			[Register("getDeviceInfo", "()Ljava/util/Map;", "GetGetDeviceInfoHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderCompressorWithMetrics._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfo.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00021F9A File Offset: 0x0002019A
		private static Delegate GetCompressDeviceInfo_Ljava_util_Map_Handler()
		{
			if (DeviceInfoReaderCompressorWithMetrics.cb_compressDeviceInfo_Ljava_util_Map_ == null)
			{
				DeviceInfoReaderCompressorWithMetrics.cb_compressDeviceInfo_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DeviceInfoReaderCompressorWithMetrics.n_CompressDeviceInfo_Ljava_util_Map_));
			}
			return DeviceInfoReaderCompressorWithMetrics.cb_compressDeviceInfo_Ljava_util_Map_;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00021FC0 File Offset: 0x000201C0
		private static IntPtr n_CompressDeviceInfo_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_deviceData)
		{
			DeviceInfoReaderCompressorWithMetrics @object = Java.Lang.Object.GetObject<DeviceInfoReaderCompressorWithMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> deviceData = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_deviceData, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(@object.CompressDeviceInfo(deviceData));
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00021FE8 File Offset: 0x000201E8
		[Register("compressDeviceInfo", "(Ljava/util/Map;)[B", "GetCompressDeviceInfo_Ljava_util_Map_Handler")]
		public unsafe virtual byte[] CompressDeviceInfo(IDictionary<string, Java.Lang.Object> deviceData)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(deviceData);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(DeviceInfoReaderCompressorWithMetrics._members.InstanceMethods.InvokeVirtualObjectMethod("compressDeviceInfo.(Ljava/util/Map;)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(deviceData);
			}
			return result;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00022068 File Offset: 0x00020268
		private static Delegate GetGetDeviceDataHandler()
		{
			if (DeviceInfoReaderCompressorWithMetrics.cb_getDeviceData == null)
			{
				DeviceInfoReaderCompressorWithMetrics.cb_getDeviceData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderCompressorWithMetrics.n_GetDeviceData));
			}
			return DeviceInfoReaderCompressorWithMetrics.cb_getDeviceData;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002208C File Offset: 0x0002028C
		private static IntPtr n_GetDeviceData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<DeviceInfoReaderCompressorWithMetrics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDeviceData());
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000220A0 File Offset: 0x000202A0
		[Register("getDeviceData", "()[B", "GetGetDeviceDataHandler")]
		public virtual byte[] GetDeviceData()
		{
			return (byte[])JNIEnv.GetArray(DeviceInfoReaderCompressorWithMetrics._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceData.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x040002B6 RID: 694
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderCompressorWithMetrics", typeof(DeviceInfoReaderCompressorWithMetrics));

		// Token: 0x040002B7 RID: 695
		private static Delegate cb_getDeviceInfo;

		// Token: 0x040002B8 RID: 696
		private static Delegate cb_compressDeviceInfo_Ljava_util_Map_;

		// Token: 0x040002B9 RID: 697
		private static Delegate cb_getDeviceData;
	}
}
