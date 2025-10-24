using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader.Pii
{
	// Token: 0x02000142 RID: 322
	[Register("com/unity3d/services/core/device/reader/pii/PiiDataProvider", DoNotGenerateAcw = true)]
	public class PiiDataProvider : Java.Lang.Object
	{
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000240CC File Offset: 0x000222CC
		internal static IntPtr class_ref
		{
			get
			{
				return PiiDataProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x000240F0 File Offset: 0x000222F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PiiDataProvider._members;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000240F8 File Offset: 0x000222F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PiiDataProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0002411C File Offset: 0x0002231C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PiiDataProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PiiDataProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00024128 File Offset: 0x00022328
		[Register(".ctor", "()V", "")]
		public PiiDataProvider() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PiiDataProvider._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PiiDataProvider._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00024196 File Offset: 0x00022396
		private static Delegate GetGetAdvertisingTrackingIdHandler()
		{
			if (PiiDataProvider.cb_getAdvertisingTrackingId == null)
			{
				PiiDataProvider.cb_getAdvertisingTrackingId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PiiDataProvider.n_GetAdvertisingTrackingId));
			}
			return PiiDataProvider.cb_getAdvertisingTrackingId;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000241BA File Offset: 0x000223BA
		private static IntPtr n_GetAdvertisingTrackingId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<PiiDataProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdvertisingTrackingId);
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000241D0 File Offset: 0x000223D0
		public virtual string AdvertisingTrackingId
		{
			[Register("getAdvertisingTrackingId", "()Ljava/lang/String;", "GetGetAdvertisingTrackingIdHandler")]
			get
			{
				return JNIEnv.GetString(PiiDataProvider._members.InstanceMethods.InvokeVirtualObjectMethod("getAdvertisingTrackingId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002F8 RID: 760
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/pii/PiiDataProvider", typeof(PiiDataProvider));

		// Token: 0x040002F9 RID: 761
		private static Delegate cb_getAdvertisingTrackingId;
	}
}
