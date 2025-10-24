using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader.Pii
{
	// Token: 0x02000146 RID: 326
	[Register("com/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader", DoNotGenerateAcw = true)]
	public class PiiTrackingStatusReader : Java.Lang.Object
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00024A7C File Offset: 0x00022C7C
		internal static IntPtr class_ref
		{
			get
			{
				return PiiTrackingStatusReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00024AA0 File Offset: 0x00022CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PiiTrackingStatusReader._members;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00024AA8 File Offset: 0x00022CA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PiiTrackingStatusReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00024ACC File Offset: 0x00022CCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PiiTrackingStatusReader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PiiTrackingStatusReader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00024AD8 File Offset: 0x00022CD8
		[Register(".ctor", "(Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", "")]
		public unsafe PiiTrackingStatusReader(IJsonStorageReader jsonStorageReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((jsonStorageReader == null) ? IntPtr.Zero : ((Java.Lang.Object)jsonStorageReader).Handle);
				base.SetHandle(PiiTrackingStatusReader._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PiiTrackingStatusReader._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/misc/IJsonStorageReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(jsonStorageReader);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00024B8C File Offset: 0x00022D8C
		private static Delegate GetGetPrivacyModeHandler()
		{
			if (PiiTrackingStatusReader.cb_getPrivacyMode == null)
			{
				PiiTrackingStatusReader.cb_getPrivacyMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PiiTrackingStatusReader.n_GetPrivacyMode));
			}
			return PiiTrackingStatusReader.cb_getPrivacyMode;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00024BB0 File Offset: 0x00022DB0
		private static IntPtr n_GetPrivacyMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PiiTrackingStatusReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyMode);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00024BC4 File Offset: 0x00022DC4
		public virtual PiiPrivacyMode PrivacyMode
		{
			[Register("getPrivacyMode", "()Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", "GetGetPrivacyModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiTrackingStatusReader._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivacyMode.()Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00024BF6 File Offset: 0x00022DF6
		private static Delegate GetGetUserNonBehavioralFlagHandler()
		{
			if (PiiTrackingStatusReader.cb_getUserNonBehavioralFlag == null)
			{
				PiiTrackingStatusReader.cb_getUserNonBehavioralFlag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(PiiTrackingStatusReader.n_GetUserNonBehavioralFlag));
			}
			return PiiTrackingStatusReader.cb_getUserNonBehavioralFlag;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00024C1A File Offset: 0x00022E1A
		private static bool n_GetUserNonBehavioralFlag(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PiiTrackingStatusReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserNonBehavioralFlag;
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00024C29 File Offset: 0x00022E29
		public virtual bool UserNonBehavioralFlag
		{
			[Register("getUserNonBehavioralFlag", "()Z", "GetGetUserNonBehavioralFlagHandler")]
			get
			{
				return PiiTrackingStatusReader._members.InstanceMethods.InvokeVirtualBooleanMethod("getUserNonBehavioralFlag.()Z", this, null);
			}
		}

		// Token: 0x04000302 RID: 770
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader", typeof(PiiTrackingStatusReader));

		// Token: 0x04000303 RID: 771
		private static Delegate cb_getPrivacyMode;

		// Token: 0x04000304 RID: 772
		private static Delegate cb_getUserNonBehavioralFlag;
	}
}
