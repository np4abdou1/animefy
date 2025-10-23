using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads;
using Com.Unity3d.Services.Ads.Gmascar.Listeners;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Finder
{
	// Token: 0x0200020F RID: 527
	[Register("com/unity3d/services/ads/gmascar/finder/ScarVersionFinder", DoNotGenerateAcw = true)]
	public class ScarVersionFinder : Java.Lang.Object, IInitializationStatusListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x00047020 File Offset: 0x00045220
		internal static IntPtr class_ref
		{
			get
			{
				return ScarVersionFinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00047044 File Offset: 0x00045244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarVersionFinder._members;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x0004704C File Offset: 0x0004524C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarVersionFinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00047070 File Offset: 0x00045270
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarVersionFinder._members.ManagedPeerType;
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarVersionFinder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0004707C File Offset: 0x0004527C
		[Register(".ctor", "(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/IMobileAdsBridge;Lcom/unity3d/services/ads/gmascar/finder/PresenceDetector;Lcom/unity3d/services/ads/gmascar/finder/GMAInitializer;)V", "")]
		public unsafe ScarVersionFinder(IMobileAdsBridge mobileAdsBridge, PresenceDetector presenceDetector, GMAInitializer gmaInitializer) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mobileAdsBridge == null) ? IntPtr.Zero : ((Java.Lang.Object)mobileAdsBridge).Handle);
				ptr[1] = new JniArgumentValue((presenceDetector == null) ? IntPtr.Zero : presenceDetector.Handle);
				ptr[2] = new JniArgumentValue((gmaInitializer == null) ? IntPtr.Zero : gmaInitializer.Handle);
				base.SetHandle(ScarVersionFinder._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/IMobileAdsBridge;Lcom/unity3d/services/ads/gmascar/finder/PresenceDetector;Lcom/unity3d/services/ads/gmascar/finder/GMAInitializer;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarVersionFinder._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/gmascar/bridges/mobileads/IMobileAdsBridge;Lcom/unity3d/services/ads/gmascar/finder/PresenceDetector;Lcom/unity3d/services/ads/gmascar/finder/GMAInitializer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mobileAdsBridge);
				GC.KeepAlive(presenceDetector);
				GC.KeepAlive(gmaInitializer);
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00047184 File Offset: 0x00045384
		private static Delegate GetGetVersionCodeHandler()
		{
			if (ScarVersionFinder.cb_getVersionCode == null)
			{
				ScarVersionFinder.cb_getVersionCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ScarVersionFinder.n_GetVersionCode));
			}
			return ScarVersionFinder.cb_getVersionCode;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000471A8 File Offset: 0x000453A8
		private static int n_GetVersionCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ScarVersionFinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionCode;
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x000471B7 File Offset: 0x000453B7
		public virtual int VersionCode
		{
			[Register("getVersionCode", "()I", "GetGetVersionCodeHandler")]
			get
			{
				return ScarVersionFinder._members.InstanceMethods.InvokeVirtualInt32Method("getVersionCode.()I", this, null);
			}
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000471D0 File Offset: 0x000453D0
		private static Delegate GetFindAndSendVersion_ZHandler()
		{
			if (ScarVersionFinder.cb_findAndSendVersion_Z == null)
			{
				ScarVersionFinder.cb_findAndSendVersion_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ScarVersionFinder.n_FindAndSendVersion_Z));
			}
			return ScarVersionFinder.cb_findAndSendVersion_Z;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000471F4 File Offset: 0x000453F4
		private static void n_FindAndSendVersion_Z(IntPtr jnienv, IntPtr native__this, bool canGetVersion)
		{
			Java.Lang.Object.GetObject<ScarVersionFinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindAndSendVersion(canGetVersion);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00047204 File Offset: 0x00045404
		[Register("findAndSendVersion", "(Z)V", "GetFindAndSendVersion_ZHandler")]
		public unsafe virtual void FindAndSendVersion(bool canGetVersion)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(canGetVersion);
			ScarVersionFinder._members.InstanceMethods.InvokeVirtualVoidMethod("findAndSendVersion.(Z)V", this, ptr);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0004723F File Offset: 0x0004543F
		private static Delegate GetGetVersionHandler()
		{
			if (ScarVersionFinder.cb_getVersion == null)
			{
				ScarVersionFinder.cb_getVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarVersionFinder.n_GetVersion));
			}
			return ScarVersionFinder.cb_getVersion;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00047263 File Offset: 0x00045463
		private static void n_GetVersion(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarVersionFinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetVersion();
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00047272 File Offset: 0x00045472
		[Register("getVersion", "()V", "GetGetVersionHandler")]
		public virtual void GetVersion()
		{
			ScarVersionFinder._members.InstanceMethods.InvokeVirtualVoidMethod("getVersion.()V", this, null);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0004728B File Offset: 0x0004548B
		private static Delegate GetOnInitializationComplete_Ljava_lang_Object_Handler()
		{
			if (ScarVersionFinder.cb_onInitializationComplete_Ljava_lang_Object_ == null)
			{
				ScarVersionFinder.cb_onInitializationComplete_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarVersionFinder.n_OnInitializationComplete_Ljava_lang_Object_));
			}
			return ScarVersionFinder.cb_onInitializationComplete_Ljava_lang_Object_;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x000472B0 File Offset: 0x000454B0
		private static void n_OnInitializationComplete_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_initStatus)
		{
			ScarVersionFinder @object = Java.Lang.Object.GetObject<ScarVersionFinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initStatus, JniHandleOwnership.DoNotTransfer);
			@object.OnInitializationComplete(object2);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x000472D4 File Offset: 0x000454D4
		[Register("onInitializationComplete", "(Ljava/lang/Object;)V", "GetOnInitializationComplete_Ljava_lang_Object_Handler")]
		public unsafe virtual void OnInitializationComplete(Java.Lang.Object initStatus)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initStatus == null) ? IntPtr.Zero : initStatus.Handle);
				ScarVersionFinder._members.InstanceMethods.InvokeVirtualVoidMethod("onInitializationComplete.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(initStatus);
			}
		}

		// Token: 0x040005FC RID: 1532
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/finder/ScarVersionFinder", typeof(ScarVersionFinder));

		// Token: 0x040005FD RID: 1533
		private static Delegate cb_getVersionCode;

		// Token: 0x040005FE RID: 1534
		private static Delegate cb_findAndSendVersion_Z;

		// Token: 0x040005FF RID: 1535
		private static Delegate cb_getVersion;

		// Token: 0x04000600 RID: 1536
		private static Delegate cb_onInitializationComplete_Ljava_lang_Object_;
	}
}
