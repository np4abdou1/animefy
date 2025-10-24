using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Finder;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads
{
	// Token: 0x0200021C RID: 540
	[Register("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeLegacy", DoNotGenerateAcw = true)]
	public class MobileAdsBridgeLegacy : MobileAdsBridgeBase
	{
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00048A6C File Offset: 0x00046C6C
		internal new static IntPtr class_ref
		{
			get
			{
				return MobileAdsBridgeLegacy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00048A90 File Offset: 0x00046C90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MobileAdsBridgeLegacy._members;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00048A98 File Offset: 0x00046C98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MobileAdsBridgeLegacy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00048ABC File Offset: 0x00046CBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MobileAdsBridgeLegacy._members.ManagedPeerType;
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00048200 File Offset: 0x00046400
		protected MobileAdsBridgeLegacy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00048AC8 File Offset: 0x00046CC8
		[Register(".ctor", "()V", "")]
		public MobileAdsBridgeLegacy() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MobileAdsBridgeLegacy._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MobileAdsBridgeLegacy._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00048B36 File Offset: 0x00046D36
		private static Delegate GetGetVersionCodeIndexHandler()
		{
			if (MobileAdsBridgeLegacy.cb_getVersionCodeIndex == null)
			{
				MobileAdsBridgeLegacy.cb_getVersionCodeIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MobileAdsBridgeLegacy.n_GetVersionCodeIndex));
			}
			return MobileAdsBridgeLegacy.cb_getVersionCodeIndex;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00048B5A File Offset: 0x00046D5A
		private static int n_GetVersionCodeIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MobileAdsBridgeLegacy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionCodeIndex;
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x00048B69 File Offset: 0x00046D69
		public override int VersionCodeIndex
		{
			[Register("getVersionCodeIndex", "()I", "GetGetVersionCodeIndexHandler")]
			get
			{
				return MobileAdsBridgeLegacy._members.InstanceMethods.InvokeVirtualInt32Method("getVersionCodeIndex.()I", this, null);
			}
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00048B82 File Offset: 0x00046D82
		private static Delegate GetGetVersionMethodNameHandler()
		{
			if (MobileAdsBridgeLegacy.cb_getVersionMethodName == null)
			{
				MobileAdsBridgeLegacy.cb_getVersionMethodName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MobileAdsBridgeLegacy.n_GetVersionMethodName));
			}
			return MobileAdsBridgeLegacy.cb_getVersionMethodName;
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00048BA6 File Offset: 0x00046DA6
		private static IntPtr n_GetVersionMethodName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MobileAdsBridgeLegacy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionMethodName);
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00048BBC File Offset: 0x00046DBC
		public override string VersionMethodName
		{
			[Register("getVersionMethodName", "()Ljava/lang/String;", "GetGetVersionMethodNameHandler")]
			get
			{
				return JNIEnv.GetString(MobileAdsBridgeLegacy._members.InstanceMethods.InvokeVirtualObjectMethod("getVersionMethodName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00048BEE File Offset: 0x00046DEE
		private static Delegate GetGetAdapterVersion_IHandler()
		{
			if (MobileAdsBridgeLegacy.cb_getAdapterVersion_I == null)
			{
				MobileAdsBridgeLegacy.cb_getAdapterVersion_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MobileAdsBridgeLegacy.n_GetAdapterVersion_I));
			}
			return MobileAdsBridgeLegacy.cb_getAdapterVersion_I;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00048C12 File Offset: 0x00046E12
		private static IntPtr n_GetAdapterVersion_I(IntPtr jnienv, IntPtr native__this, int versionCode)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MobileAdsBridgeLegacy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdapterVersion(versionCode));
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00048C28 File Offset: 0x00046E28
		[Register("getAdapterVersion", "(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", "GetGetAdapterVersion_IHandler")]
		public unsafe override ScarAdapterVersion GetAdapterVersion(int versionCode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(versionCode);
			return Java.Lang.Object.GetObject<ScarAdapterVersion>(MobileAdsBridgeLegacy._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapterVersion.(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00048C71 File Offset: 0x00046E71
		private static Delegate GetShouldInitializeHandler()
		{
			if (MobileAdsBridgeLegacy.cb_shouldInitialize == null)
			{
				MobileAdsBridgeLegacy.cb_shouldInitialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MobileAdsBridgeLegacy.n_ShouldInitialize));
			}
			return MobileAdsBridgeLegacy.cb_shouldInitialize;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00048C95 File Offset: 0x00046E95
		private static bool n_ShouldInitialize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MobileAdsBridgeLegacy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldInitialize();
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00048CA4 File Offset: 0x00046EA4
		[Register("shouldInitialize", "()Z", "GetShouldInitializeHandler")]
		public override bool ShouldInitialize()
		{
			return MobileAdsBridgeLegacy._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldInitialize.()Z", this, null);
		}

		// Token: 0x04000636 RID: 1590
		[Register("CODE_19_2")]
		public const int Code192 = 201604000;

		// Token: 0x04000637 RID: 1591
		[Register("CODE_19_5")]
		public const int Code195 = 203404000;

		// Token: 0x04000638 RID: 1592
		[Register("CODE_19_8")]
		public const int Code198 = 204890000;

		// Token: 0x04000639 RID: 1593
		[Register("CODE_20_0")]
		public const int Code200 = 210402000;

		// Token: 0x0400063A RID: 1594
		[Register("CODE_21_0")]
		public const int Code210 = 221310000;

		// Token: 0x0400063B RID: 1595
		[Register("versionStringMethodName")]
		public const string VersionStringMethodName = "getVersionString";

		// Token: 0x0400063C RID: 1596
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeLegacy", typeof(MobileAdsBridgeLegacy));

		// Token: 0x0400063D RID: 1597
		private static Delegate cb_getVersionCodeIndex;

		// Token: 0x0400063E RID: 1598
		private static Delegate cb_getVersionMethodName;

		// Token: 0x0400063F RID: 1599
		private static Delegate cb_getAdapterVersion_I;

		// Token: 0x04000640 RID: 1600
		private static Delegate cb_shouldInitialize;
	}
}
