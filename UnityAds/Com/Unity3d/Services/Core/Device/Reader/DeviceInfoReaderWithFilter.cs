using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200012F RID: 303
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderWithFilter", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderWithFilter : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x000225B8 File Offset: 0x000207B8
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderWithFilter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x000225DC File Offset: 0x000207DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderWithFilter._members;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000225E4 File Offset: 0x000207E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderWithFilter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00022608 File Offset: 0x00020808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderWithFilter._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderWithFilter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00022614 File Offset: 0x00020814
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Ljava/util/List;)V", "")]
		public unsafe DeviceInfoReaderWithFilter(IDeviceInfoReader deviceInfoReader, IList<string> keysToExclude) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(keysToExclude);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(DeviceInfoReaderWithFilter._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Ljava/util/List;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderWithFilter._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(deviceInfoReader);
				GC.KeepAlive(keysToExclude);
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000226EC File Offset: 0x000208EC
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderWithFilter.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderWithFilter.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderWithFilter.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderWithFilter.cb_getDeviceInfoData;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00022710 File Offset: 0x00020910
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderWithFilter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00022724 File Offset: 0x00020924
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderWithFilter._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002BF RID: 703
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderWithFilter", typeof(DeviceInfoReaderWithFilter));

		// Token: 0x040002C0 RID: 704
		private static Delegate cb_getDeviceInfoData;
	}
}
