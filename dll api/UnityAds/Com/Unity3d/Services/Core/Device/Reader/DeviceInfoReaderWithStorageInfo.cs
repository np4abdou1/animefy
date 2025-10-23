using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000135 RID: 309
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderWithStorageInfo", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderWithStorageInfo : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00023090 File Offset: 0x00021290
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderWithStorageInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000230B4 File Offset: 0x000212B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderWithStorageInfo._members;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x000230BC File Offset: 0x000212BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderWithStorageInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000230E0 File Offset: 0x000212E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderWithStorageInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderWithStorageInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000230EC File Offset: 0x000212EC
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/misc/JsonFlattenerRules;[Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", "")]
		public unsafe DeviceInfoReaderWithStorageInfo(IDeviceInfoReader deviceInfoReader, JsonFlattenerRules jsonFlattenerRules, params IJsonStorageReader[] storageReaders) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray<IJsonStorageReader>(storageReaders);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				ptr[1] = new JniArgumentValue((jsonFlattenerRules == null) ? IntPtr.Zero : jsonFlattenerRules.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				base.SetHandle(DeviceInfoReaderWithStorageInfo._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/misc/JsonFlattenerRules;[Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderWithStorageInfo._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/misc/JsonFlattenerRules;[Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", this, ptr);
			}
			finally
			{
				if (storageReaders != null)
				{
					JNIEnv.CopyArray<IJsonStorageReader>(intPtr, storageReaders);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(deviceInfoReader);
				GC.KeepAlive(jsonFlattenerRules);
				GC.KeepAlive(storageReaders);
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000231F8 File Offset: 0x000213F8
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderWithStorageInfo.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderWithStorageInfo.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderWithStorageInfo.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderWithStorageInfo.cb_getDeviceInfoData;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0002321C File Offset: 0x0002141C
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderWithStorageInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00023230 File Offset: 0x00021430
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderWithStorageInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002CB RID: 715
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderWithStorageInfo", typeof(DeviceInfoReaderWithStorageInfo));

		// Token: 0x040002CC RID: 716
		private static Delegate cb_getDeviceInfoData;
	}
}
