using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads
{
	// Token: 0x0200021B RID: 539
	[Register("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeFactory", DoNotGenerateAcw = true)]
	public class MobileAdsBridgeFactory : Java.Lang.Object
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00048918 File Offset: 0x00046B18
		internal static IntPtr class_ref
		{
			get
			{
				return MobileAdsBridgeFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x0004893C File Offset: 0x00046B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MobileAdsBridgeFactory._members;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x00048944 File Offset: 0x00046B44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MobileAdsBridgeFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00048968 File Offset: 0x00046B68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MobileAdsBridgeFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MobileAdsBridgeFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00048974 File Offset: 0x00046B74
		[Register(".ctor", "()V", "")]
		public MobileAdsBridgeFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MobileAdsBridgeFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MobileAdsBridgeFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000489E2 File Offset: 0x00046BE2
		private static Delegate GetCreateMobileAdsBridgeHandler()
		{
			if (MobileAdsBridgeFactory.cb_createMobileAdsBridge == null)
			{
				MobileAdsBridgeFactory.cb_createMobileAdsBridge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MobileAdsBridgeFactory.n_CreateMobileAdsBridge));
			}
			return MobileAdsBridgeFactory.cb_createMobileAdsBridge;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00048A06 File Offset: 0x00046C06
		private static IntPtr n_CreateMobileAdsBridge(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MobileAdsBridgeFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateMobileAdsBridge());
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00048A1C File Offset: 0x00046C1C
		[Register("createMobileAdsBridge", "()Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;", "GetCreateMobileAdsBridgeHandler")]
		public virtual MobileAdsBridgeBase CreateMobileAdsBridge()
		{
			return Java.Lang.Object.GetObject<MobileAdsBridgeBase>(MobileAdsBridgeFactory._members.InstanceMethods.InvokeVirtualObjectMethod("createMobileAdsBridge.()Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000634 RID: 1588
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeFactory", typeof(MobileAdsBridgeFactory));

		// Token: 0x04000635 RID: 1589
		private static Delegate cb_createMobileAdsBridge;
	}
}
