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
	// Token: 0x0200012D RID: 301
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderFilterProvider", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderFilterProvider : Java.Lang.Object
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00022294 File Offset: 0x00020494
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderFilterProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x000222B8 File Offset: 0x000204B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderFilterProvider._members;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x000222C0 File Offset: 0x000204C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderFilterProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x000222E4 File Offset: 0x000204E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderFilterProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfoReaderFilterProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000222F0 File Offset: 0x000204F0
		[Register(".ctor", "(Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", "")]
		public unsafe DeviceInfoReaderFilterProvider(IJsonStorageReader jsonStorageReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((jsonStorageReader == null) ? IntPtr.Zero : ((Java.Lang.Object)jsonStorageReader).Handle);
				base.SetHandle(DeviceInfoReaderFilterProvider._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderFilterProvider._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(jsonStorageReader);
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000223A4 File Offset: 0x000205A4
		private static Delegate GetGetFilterListHandler()
		{
			if (DeviceInfoReaderFilterProvider.cb_getFilterList == null)
			{
				DeviceInfoReaderFilterProvider.cb_getFilterList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceInfoReaderFilterProvider.n_GetFilterList));
			}
			return DeviceInfoReaderFilterProvider.cb_getFilterList;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000223C8 File Offset: 0x000205C8
		private static IntPtr n_GetFilterList(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<DeviceInfoReaderFilterProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FilterList);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000223DC File Offset: 0x000205DC
		public virtual IList<string> FilterList
		{
			[Register("getFilterList", "()Ljava/util/List;", "GetGetFilterListHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(DeviceInfoReaderFilterProvider._members.InstanceMethods.InvokeVirtualObjectMethod("getFilterList.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002BC RID: 700
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderFilterProvider", typeof(DeviceInfoReaderFilterProvider));

		// Token: 0x040002BD RID: 701
		private static Delegate cb_getFilterList;
	}
}
