using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000140 RID: 320
	[Register("com/unity3d/services/core/device/reader/MinimalDeviceInfoReader", DoNotGenerateAcw = true)]
	public class MinimalDeviceInfoReader : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00023D80 File Offset: 0x00021F80
		internal static IntPtr class_ref
		{
			get
			{
				return MinimalDeviceInfoReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00023DA4 File Offset: 0x00021FA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MinimalDeviceInfoReader._members;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00023DAC File Offset: 0x00021FAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MinimalDeviceInfoReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00023DD0 File Offset: 0x00021FD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MinimalDeviceInfoReader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MinimalDeviceInfoReader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00023DDC File Offset: 0x00021FDC
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", "")]
		public unsafe MinimalDeviceInfoReader(IGameSessionIdReader gameSessionIdReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((gameSessionIdReader == null) ? IntPtr.Zero : ((Java.Lang.Object)gameSessionIdReader).Handle);
				base.SetHandle(MinimalDeviceInfoReader._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MinimalDeviceInfoReader._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(gameSessionIdReader);
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00023E90 File Offset: 0x00022090
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (MinimalDeviceInfoReader.cb_getDeviceInfoData == null)
			{
				MinimalDeviceInfoReader.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MinimalDeviceInfoReader.n_GetDeviceInfoData));
			}
			return MinimalDeviceInfoReader.cb_getDeviceInfoData;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00023EB4 File Offset: 0x000220B4
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<MinimalDeviceInfoReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00023EC8 File Offset: 0x000220C8
		public virtual IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			[Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(MinimalDeviceInfoReader._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceInfoData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002F5 RID: 757
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/MinimalDeviceInfoReader", typeof(MinimalDeviceInfoReader));

		// Token: 0x040002F6 RID: 758
		private static Delegate cb_getDeviceInfoData;
	}
}
