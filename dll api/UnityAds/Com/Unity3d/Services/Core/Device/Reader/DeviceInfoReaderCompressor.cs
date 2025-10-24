using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200012A RID: 298
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderCompressor", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderCompressor : Java.Lang.Object, IDeviceInfoDataCompressor, IDeviceInfoDataContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00021B44 File Offset: 0x0001FD44
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderCompressor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00021B68 File Offset: 0x0001FD68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderCompressor._members;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00021B70 File Offset: 0x0001FD70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderCompressor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00021B94 File Offset: 0x0001FD94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderCompressor._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderCompressor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", "")]
		public unsafe DeviceInfoReaderCompressor(IDeviceInfoReader deviceInfoReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				base.SetHandle(DeviceInfoReaderCompressor._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderCompressor._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoReader);
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00021C54 File Offset: 0x0001FE54
		private static Delegate GetGetDeviceInfoHandler()
		{
			if (DeviceInfoReaderCompressor.cb_getDeviceInfo == null)
			{
				DeviceInfoReaderCompressor.cb_getDeviceInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderCompressor.n_GetDeviceInfo));
			}
			return DeviceInfoReaderCompressor.cb_getDeviceInfo;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00021C78 File Offset: 0x0001FE78
		private static IntPtr n_GetDeviceInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderCompressor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfo);
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00021C8C File Offset: 0x0001FE8C
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfo
		{
			[Register("getDeviceInfo", "()Ljava/util/Map;", "GetGetDeviceInfoHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderCompressor._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfo.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00021CBE File Offset: 0x0001FEBE
		private static Delegate GetCompressDeviceInfo_Ljava_util_Map_Handler()
		{
			if (DeviceInfoReaderCompressor.cb_compressDeviceInfo_Ljava_util_Map_ == null)
			{
				DeviceInfoReaderCompressor.cb_compressDeviceInfo_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DeviceInfoReaderCompressor.n_CompressDeviceInfo_Ljava_util_Map_));
			}
			return DeviceInfoReaderCompressor.cb_compressDeviceInfo_Ljava_util_Map_;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00021CE4 File Offset: 0x0001FEE4
		private static IntPtr n_CompressDeviceInfo_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_deviceData)
		{
			DeviceInfoReaderCompressor @object = Java.Lang.Object.GetObject<DeviceInfoReaderCompressor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> deviceData = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_deviceData, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(@object.CompressDeviceInfo(deviceData));
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00021D0C File Offset: 0x0001FF0C
		[Register("compressDeviceInfo", "(Ljava/util/Map;)[B", "GetCompressDeviceInfo_Ljava_util_Map_Handler")]
		public unsafe virtual byte[] CompressDeviceInfo(IDictionary<string, Java.Lang.Object> deviceData)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(deviceData);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(DeviceInfoReaderCompressor._members.InstanceMethods.InvokeVirtualObjectMethod("compressDeviceInfo.(Ljava/util/Map;)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(deviceData);
			}
			return result;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00021D8C File Offset: 0x0001FF8C
		private static Delegate GetGetDeviceDataHandler()
		{
			if (DeviceInfoReaderCompressor.cb_getDeviceData == null)
			{
				DeviceInfoReaderCompressor.cb_getDeviceData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderCompressor.n_GetDeviceData));
			}
			return DeviceInfoReaderCompressor.cb_getDeviceData;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		private static IntPtr n_GetDeviceData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<DeviceInfoReaderCompressor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDeviceData());
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00021DC4 File Offset: 0x0001FFC4
		[Register("getDeviceData", "()[B", "GetGetDeviceDataHandler")]
		public virtual byte[] GetDeviceData()
		{
			return (byte[])JNIEnv.GetArray(DeviceInfoReaderCompressor._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceData.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x040002B2 RID: 690
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderCompressor", typeof(DeviceInfoReaderCompressor));

		// Token: 0x040002B3 RID: 691
		private static Delegate cb_getDeviceInfo;

		// Token: 0x040002B4 RID: 692
		private static Delegate cb_compressDeviceInfo_Ljava_util_Map_;

		// Token: 0x040002B5 RID: 693
		private static Delegate cb_getDeviceData;
	}
}
