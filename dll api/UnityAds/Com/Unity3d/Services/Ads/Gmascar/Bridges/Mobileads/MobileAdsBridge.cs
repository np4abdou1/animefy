using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Finder;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads
{
	// Token: 0x02000218 RID: 536
	[Register("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridge", DoNotGenerateAcw = true)]
	public class MobileAdsBridge : MobileAdsBridgeBase
	{
		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x000481A4 File Offset: 0x000463A4
		internal new static IntPtr class_ref
		{
			get
			{
				return MobileAdsBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x000481C8 File Offset: 0x000463C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MobileAdsBridge._members;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x000481D0 File Offset: 0x000463D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MobileAdsBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x000481F4 File Offset: 0x000463F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MobileAdsBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00048200 File Offset: 0x00046400
		protected MobileAdsBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0004820C File Offset: 0x0004640C
		[Register(".ctor", "()V", "")]
		public MobileAdsBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MobileAdsBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MobileAdsBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0004827A File Offset: 0x0004647A
		private static Delegate GetGetVersionCodeIndexHandler()
		{
			if (MobileAdsBridge.cb_getVersionCodeIndex == null)
			{
				MobileAdsBridge.cb_getVersionCodeIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MobileAdsBridge.n_GetVersionCodeIndex));
			}
			return MobileAdsBridge.cb_getVersionCodeIndex;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0004829E File Offset: 0x0004649E
		private static int n_GetVersionCodeIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionCodeIndex;
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x000482AD File Offset: 0x000464AD
		public override int VersionCodeIndex
		{
			[Register("getVersionCodeIndex", "()I", "GetGetVersionCodeIndexHandler")]
			get
			{
				return MobileAdsBridge._members.InstanceMethods.InvokeVirtualInt32Method("getVersionCodeIndex.()I", this, null);
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000482C6 File Offset: 0x000464C6
		private static Delegate GetGetVersionMethodNameHandler()
		{
			if (MobileAdsBridge.cb_getVersionMethodName == null)
			{
				MobileAdsBridge.cb_getVersionMethodName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MobileAdsBridge.n_GetVersionMethodName));
			}
			return MobileAdsBridge.cb_getVersionMethodName;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000482EA File Offset: 0x000464EA
		private static IntPtr n_GetVersionMethodName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionMethodName);
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00048300 File Offset: 0x00046500
		public override string VersionMethodName
		{
			[Register("getVersionMethodName", "()Ljava/lang/String;", "GetGetVersionMethodNameHandler")]
			get
			{
				return JNIEnv.GetString(MobileAdsBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getVersionMethodName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00048332 File Offset: 0x00046532
		private static Delegate GetGetAdapterVersion_IHandler()
		{
			if (MobileAdsBridge.cb_getAdapterVersion_I == null)
			{
				MobileAdsBridge.cb_getAdapterVersion_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MobileAdsBridge.n_GetAdapterVersion_I));
			}
			return MobileAdsBridge.cb_getAdapterVersion_I;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00048356 File Offset: 0x00046556
		private static IntPtr n_GetAdapterVersion_I(IntPtr jnienv, IntPtr native__this, int versionCode)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdapterVersion(versionCode));
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0004836C File Offset: 0x0004656C
		[Register("getAdapterVersion", "(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", "GetGetAdapterVersion_IHandler")]
		public unsafe override ScarAdapterVersion GetAdapterVersion(int versionCode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(versionCode);
			return Java.Lang.Object.GetObject<ScarAdapterVersion>(MobileAdsBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapterVersion.(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000483B5 File Offset: 0x000465B5
		private static Delegate GetShouldInitializeHandler()
		{
			if (MobileAdsBridge.cb_shouldInitialize == null)
			{
				MobileAdsBridge.cb_shouldInitialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MobileAdsBridge.n_ShouldInitialize));
			}
			return MobileAdsBridge.cb_shouldInitialize;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000483D9 File Offset: 0x000465D9
		private static bool n_ShouldInitialize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldInitialize();
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000483E8 File Offset: 0x000465E8
		[Register("shouldInitialize", "()Z", "GetShouldInitializeHandler")]
		public override bool ShouldInitialize()
		{
			return MobileAdsBridge._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldInitialize.()Z", this, null);
		}

		// Token: 0x04000622 RID: 1570
		[Register("CODE_21")]
		public const int Code21 = 21;

		// Token: 0x04000623 RID: 1571
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridge", typeof(MobileAdsBridge));

		// Token: 0x04000624 RID: 1572
		private static Delegate cb_getVersionCodeIndex;

		// Token: 0x04000625 RID: 1573
		private static Delegate cb_getVersionMethodName;

		// Token: 0x04000626 RID: 1574
		private static Delegate cb_getAdapterVersion_I;

		// Token: 0x04000627 RID: 1575
		private static Delegate cb_shouldInitialize;
	}
}
