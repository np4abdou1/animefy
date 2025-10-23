using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Bridges;
using Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Finder
{
	// Token: 0x0200020C RID: 524
	[Register("com/unity3d/services/ads/gmascar/finder/GMAInitializer", DoNotGenerateAcw = true)]
	public class GMAInitializer : Java.Lang.Object
	{
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x00046870 File Offset: 0x00044A70
		internal static IntPtr class_ref
		{
			get
			{
				return GMAInitializer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00046894 File Offset: 0x00044A94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GMAInitializer._members;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0004689C File Offset: 0x00044A9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GMAInitializer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x000468C0 File Offset: 0x00044AC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GMAInitializer._members.ManagedPeerType;
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000021E8 File Offset: 0x000003E8
		protected GMAInitializer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000468CC File Offset: 0x00044ACC
		[Register(".ctor", "(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;Lcom/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge;Lcom/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge;)V", "")]
		public unsafe GMAInitializer(MobileAdsBridgeBase mobileAdsBridge, InitializeListenerBridge initializeListenerBridge, InitializationStatusBridge initializationStatusBridge, AdapterStatusBridge adapterStatusBridge) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mobileAdsBridge == null) ? IntPtr.Zero : mobileAdsBridge.Handle);
				ptr[1] = new JniArgumentValue((initializeListenerBridge == null) ? IntPtr.Zero : initializeListenerBridge.Handle);
				ptr[2] = new JniArgumentValue((initializationStatusBridge == null) ? IntPtr.Zero : initializationStatusBridge.Handle);
				ptr[3] = new JniArgumentValue((adapterStatusBridge == null) ? IntPtr.Zero : adapterStatusBridge.Handle);
				base.SetHandle(GMAInitializer._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;Lcom/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge;Lcom/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GMAInitializer._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;Lcom/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge;Lcom/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mobileAdsBridge);
				GC.KeepAlive(initializeListenerBridge);
				GC.KeepAlive(initializationStatusBridge);
				GC.KeepAlive(adapterStatusBridge);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000469FC File Offset: 0x00044BFC
		private static Delegate GetGetInitializeListenerBridgeHandler()
		{
			if (GMAInitializer.cb_getInitializeListenerBridge == null)
			{
				GMAInitializer.cb_getInitializeListenerBridge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GMAInitializer.n_GetInitializeListenerBridge));
			}
			return GMAInitializer.cb_getInitializeListenerBridge;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00046A20 File Offset: 0x00044C20
		private static IntPtr n_GetInitializeListenerBridge(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GMAInitializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializeListenerBridge);
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x00046A34 File Offset: 0x00044C34
		public virtual InitializeListenerBridge InitializeListenerBridge
		{
			[Register("getInitializeListenerBridge", "()Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;", "GetGetInitializeListenerBridgeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<InitializeListenerBridge>(GMAInitializer._members.InstanceMethods.InvokeVirtualObjectMethod("getInitializeListenerBridge.()Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00046A66 File Offset: 0x00044C66
		private static Delegate GetIsInitializedHandler()
		{
			if (GMAInitializer.cb_isInitialized == null)
			{
				GMAInitializer.cb_isInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GMAInitializer.n_IsInitialized));
			}
			return GMAInitializer.cb_isInitialized;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00046A8A File Offset: 0x00044C8A
		private static bool n_IsInitialized(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GMAInitializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInitialized;
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00046A99 File Offset: 0x00044C99
		public virtual bool IsInitialized
		{
			[Register("isInitialized", "()Z", "GetIsInitializedHandler")]
			get
			{
				return GMAInitializer._members.InstanceMethods.InvokeVirtualBooleanMethod("isInitialized.()Z", this, null);
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00046AB2 File Offset: 0x00044CB2
		private static Delegate GetInitSuccessful_Ljava_lang_Object_Handler()
		{
			if (GMAInitializer.cb_initSuccessful_Ljava_lang_Object_ == null)
			{
				GMAInitializer.cb_initSuccessful_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GMAInitializer.n_InitSuccessful_Ljava_lang_Object_));
			}
			return GMAInitializer.cb_initSuccessful_Ljava_lang_Object_;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00046AD8 File Offset: 0x00044CD8
		private static bool n_InitSuccessful_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_initStatus)
		{
			GMAInitializer @object = Java.Lang.Object.GetObject<GMAInitializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initStatus, JniHandleOwnership.DoNotTransfer);
			return @object.InitSuccessful(object2);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00046AFC File Offset: 0x00044CFC
		[Register("initSuccessful", "(Ljava/lang/Object;)Z", "GetInitSuccessful_Ljava_lang_Object_Handler")]
		public unsafe virtual bool InitSuccessful(Java.Lang.Object initStatus)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initStatus == null) ? IntPtr.Zero : initStatus.Handle);
				result = GMAInitializer._members.InstanceMethods.InvokeVirtualBooleanMethod("initSuccessful.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(initStatus);
			}
			return result;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00046B64 File Offset: 0x00044D64
		private static Delegate GetInitializeGMAHandler()
		{
			if (GMAInitializer.cb_initializeGMA == null)
			{
				GMAInitializer.cb_initializeGMA = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GMAInitializer.n_InitializeGMA));
			}
			return GMAInitializer.cb_initializeGMA;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00046B88 File Offset: 0x00044D88
		private static void n_InitializeGMA(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GMAInitializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializeGMA();
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00046B97 File Offset: 0x00044D97
		[Register("initializeGMA", "()V", "GetInitializeGMAHandler")]
		public virtual void InitializeGMA()
		{
			GMAInitializer._members.InstanceMethods.InvokeVirtualVoidMethod("initializeGMA.()V", this, null);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00046BB0 File Offset: 0x00044DB0
		private static Delegate GetShouldInitializeHandler()
		{
			if (GMAInitializer.cb_shouldInitialize == null)
			{
				GMAInitializer.cb_shouldInitialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GMAInitializer.n_ShouldInitialize));
			}
			return GMAInitializer.cb_shouldInitialize;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00046BD4 File Offset: 0x00044DD4
		private static bool n_ShouldInitialize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GMAInitializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldInitialize();
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00046BE3 File Offset: 0x00044DE3
		[Register("shouldInitialize", "()Z", "GetShouldInitializeHandler")]
		public virtual bool ShouldInitialize()
		{
			return GMAInitializer._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldInitialize.()Z", this, null);
		}

		// Token: 0x040005F3 RID: 1523
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/finder/GMAInitializer", typeof(GMAInitializer));

		// Token: 0x040005F4 RID: 1524
		private static Delegate cb_getInitializeListenerBridge;

		// Token: 0x040005F5 RID: 1525
		private static Delegate cb_isInitialized;

		// Token: 0x040005F6 RID: 1526
		private static Delegate cb_initSuccessful_Ljava_lang_Object_;

		// Token: 0x040005F7 RID: 1527
		private static Delegate cb_initializeGMA;

		// Token: 0x040005F8 RID: 1528
		private static Delegate cb_shouldInitialize;
	}
}
