using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200012C RID: 300
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderExtended", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderExtended : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000220FC File Offset: 0x000202FC
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderExtended._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00022120 File Offset: 0x00020320
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderExtended._members;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00022128 File Offset: 0x00020328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderExtended._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0002214C File Offset: 0x0002034C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderExtended._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderExtended(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00022158 File Offset: 0x00020358
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", "")]
		public unsafe DeviceInfoReaderExtended(IDeviceInfoReader deviceInfoReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((deviceInfoReader == null) ? IntPtr.Zero : ((Java.Lang.Object)deviceInfoReader).Handle);
				base.SetHandle(DeviceInfoReaderExtended._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderExtended._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IDeviceInfoReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(deviceInfoReader);
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0002220C File Offset: 0x0002040C
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (DeviceInfoReaderExtended.cb_getDeviceInfoData == null)
			{
				DeviceInfoReaderExtended.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderExtended.n_GetDeviceInfoData));
			}
			return DeviceInfoReaderExtended.cb_getDeviceInfoData;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00022230 File Offset: 0x00020430
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderExtended>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00022244 File Offset: 0x00020444
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(DeviceInfoReaderExtended._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002BA RID: 698
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderExtended", typeof(DeviceInfoReaderExtended));

		// Token: 0x040002BB RID: 699
		private static Delegate cb_getDeviceInfoData;
	}
}
