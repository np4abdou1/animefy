using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000130 RID: 304
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderWithLifecycle", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderWithLifecycle : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00022774 File Offset: 0x00020974
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderWithLifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00022798 File Offset: 0x00020998
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderWithLifecycle._members;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000227A0 File Offset: 0x000209A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderWithLifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000227C4 File Offset: 0x000209C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderWithLifecycle._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderWithLifecycle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000227D0 File Offset: 0x000209D0
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", "")]
		public unsafe DeviceInfoReaderWithLifecycle(IDeviceInfoReader deviceInfoReader, LifecycleCache lifecycleCache) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				ptr[1] = new JniArgumentValue((lifecycleCache == null) ? IntPtr.Zero : lifecycleCache.Handle);
				base.SetHandle(DeviceInfoReaderWithLifecycle._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderWithLifecycle._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoReader);
				GC.KeepAlive(lifecycleCache);
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000228AC File Offset: 0x00020AAC
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderWithLifecycle.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderWithLifecycle.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderWithLifecycle.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderWithLifecycle.cb_getDeviceInfoData;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000228D0 File Offset: 0x00020AD0
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderWithLifecycle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x000228E4 File Offset: 0x00020AE4
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderWithLifecycle._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002C1 RID: 705
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderWithLifecycle", typeof(DeviceInfoReaderWithLifecycle));

		// Token: 0x040002C2 RID: 706
		private static Delegate cb_getDeviceInfoData;
	}
}
