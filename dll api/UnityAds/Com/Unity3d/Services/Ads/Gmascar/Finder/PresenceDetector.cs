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
	// Token: 0x0200020D RID: 525
	[Register("com/unity3d/services/ads/gmascar/finder/PresenceDetector", DoNotGenerateAcw = true)]
	public class PresenceDetector : Java.Lang.Object
	{
		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00046C18 File Offset: 0x00044E18
		internal static IntPtr class_ref
		{
			get
			{
				return PresenceDetector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00046C3C File Offset: 0x00044E3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PresenceDetector._members;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00046C44 File Offset: 0x00044E44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PresenceDetector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00046C68 File Offset: 0x00044E68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PresenceDetector._members.ManagedPeerType;
			}
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PresenceDetector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00046C74 File Offset: 0x00044E74
		[Register(".ctor", "(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;Lcom/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge;Lcom/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge;)V", "")]
		public unsafe PresenceDetector(MobileAdsBridgeBase mobileAdsBridge, InitializeListenerBridge initializeListenerBridge, InitializationStatusBridge initializationStatusBridge, AdapterStatusBridge adapterStatusBridge) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(PresenceDetector._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;Lcom/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge;Lcom/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PresenceDetector._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase;Lcom/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge;Lcom/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge;Lcom/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mobileAdsBridge);
				GC.KeepAlive(initializeListenerBridge);
				GC.KeepAlive(initializationStatusBridge);
				GC.KeepAlive(adapterStatusBridge);
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00046DA4 File Offset: 0x00044FA4
		private static Delegate GetAreGMAClassesPresentHandler()
		{
			if (PresenceDetector.cb_areGMAClassesPresent == null)
			{
				PresenceDetector.cb_areGMAClassesPresent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(PresenceDetector.n_AreGMAClassesPresent));
			}
			return PresenceDetector.cb_areGMAClassesPresent;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00046DC8 File Offset: 0x00044FC8
		private static bool n_AreGMAClassesPresent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PresenceDetector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AreGMAClassesPresent();
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00046DD7 File Offset: 0x00044FD7
		[Register("areGMAClassesPresent", "()Z", "GetAreGMAClassesPresentHandler")]
		public virtual bool AreGMAClassesPresent()
		{
			return PresenceDetector._members.InstanceMethods.InvokeVirtualBooleanMethod("areGMAClassesPresent.()Z", this, null);
		}

		// Token: 0x040005F9 RID: 1529
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/finder/PresenceDetector", typeof(PresenceDetector));

		// Token: 0x040005FA RID: 1530
		private static Delegate cb_areGMAClassesPresent;
	}
}
