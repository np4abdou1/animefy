using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Listeners;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges
{
	// Token: 0x02000213 RID: 531
	[Register("com/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge", DoNotGenerateAcw = true)]
	public class InitializeListenerBridge : GenericBridge
	{
		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0004793C File Offset: 0x00045B3C
		internal new static IntPtr class_ref
		{
			get
			{
				return InitializeListenerBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00047960 File Offset: 0x00045B60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitializeListenerBridge._members;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00047968 File Offset: 0x00045B68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitializeListenerBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0004798C File Offset: 0x00045B8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitializeListenerBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected InitializeListenerBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00047998 File Offset: 0x00045B98
		[Register(".ctor", "()V", "")]
		public InitializeListenerBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InitializeListenerBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InitializeListenerBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00047A06 File Offset: 0x00045C06
		private static Delegate GetGetClassNameHandler()
		{
			if (InitializeListenerBridge.cb_getClassName == null)
			{
				InitializeListenerBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeListenerBridge.n_GetClassName));
			}
			return InitializeListenerBridge.cb_getClassName;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00047A2A File Offset: 0x00045C2A
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<InitializeListenerBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00047A40 File Offset: 0x00045C40
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(InitializeListenerBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00047A72 File Offset: 0x00045C72
		private static Delegate GetCreateInitializeListenerProxyHandler()
		{
			if (InitializeListenerBridge.cb_createInitializeListenerProxy == null)
			{
				InitializeListenerBridge.cb_createInitializeListenerProxy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeListenerBridge.n_CreateInitializeListenerProxy));
			}
			return InitializeListenerBridge.cb_createInitializeListenerProxy;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00047A96 File Offset: 0x00045C96
		private static IntPtr n_CreateInitializeListenerProxy(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InitializeListenerBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateInitializeListenerProxy());
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00047AAC File Offset: 0x00045CAC
		[Register("createInitializeListenerProxy", "()Ljava/lang/Object;", "GetCreateInitializeListenerProxyHandler")]
		public virtual Java.Lang.Object CreateInitializeListenerProxy()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(InitializeListenerBridge._members.InstanceMethods.InvokeVirtualObjectMethod("createInitializeListenerProxy.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00047ADE File Offset: 0x00045CDE
		private static Delegate GetSetStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_Handler()
		{
			if (InitializeListenerBridge.cb_setStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_ == null)
			{
				InitializeListenerBridge.cb_setStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InitializeListenerBridge.n_SetStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_));
			}
			return InitializeListenerBridge.cb_setStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00047B04 File Offset: 0x00045D04
		private static void n_SetStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_initializationStatusListener)
		{
			InitializeListenerBridge @object = Java.Lang.Object.GetObject<InitializeListenerBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInitializationStatusListener object2 = Java.Lang.Object.GetObject<IInitializationStatusListener>(native_initializationStatusListener, JniHandleOwnership.DoNotTransfer);
			@object.SetStatusListener(object2);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00047B28 File Offset: 0x00045D28
		[Register("setStatusListener", "(Lcom/unity3d/services/ads/gmascar/listeners/IInitializationStatusListener;)V", "GetSetStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_Handler")]
		public unsafe virtual void SetStatusListener(IInitializationStatusListener initializationStatusListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initializationStatusListener == null) ? IntPtr.Zero : ((Java.Lang.Object)initializationStatusListener).Handle);
				InitializeListenerBridge._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusListener.(Lcom/unity3d/services/ads/gmascar/listeners/IInitializationStatusListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(initializationStatusListener);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060018E5 RID: 6373 RVA: 0x00047B90 File Offset: 0x00045D90
		// (remove) Token: 0x060018E6 RID: 6374 RVA: 0x00047BDC File Offset: 0x00045DDC
		public event EventHandler<InitializationStatusEventArgs> Status
		{
			add
			{
				EventHelper.AddEventHandler<IInitializationStatusListener, IInitializationStatusListenerImplementor>(ref this.weak_implementor_SetStatusListener, new Func<IInitializationStatusListenerImplementor>(this.__CreateIInitializationStatusListenerImplementor), new Action<IInitializationStatusListener>(this.SetStatusListener), delegate(IInitializationStatusListenerImplementor __h)
				{
					__h.Handler = (EventHandler<InitializationStatusEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IInitializationStatusListener, IInitializationStatusListenerImplementor>(ref this.weak_implementor_SetStatusListener, new Func<IInitializationStatusListenerImplementor, bool>(IInitializationStatusListenerImplementor.__IsEmpty), delegate(IInitializationStatusListener __v)
				{
					this.SetStatusListener(null);
				}, delegate(IInitializationStatusListenerImplementor __h)
				{
					__h.Handler = (EventHandler<InitializationStatusEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00047C2C File Offset: 0x00045E2C
		private IInitializationStatusListenerImplementor __CreateIInitializationStatusListenerImplementor()
		{
			return new IInitializationStatusListenerImplementor(this);
		}

		// Token: 0x0400060A RID: 1546
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/InitializeListenerBridge", typeof(InitializeListenerBridge));

		// Token: 0x0400060B RID: 1547
		private static Delegate cb_getClassName;

		// Token: 0x0400060C RID: 1548
		private static Delegate cb_createInitializeListenerProxy;

		// Token: 0x0400060D RID: 1549
		private static Delegate cb_setStatusListener_Lcom_unity3d_services_ads_gmascar_listeners_IInitializationStatusListener_;

		// Token: 0x0400060E RID: 1550
		private WeakReference weak_implementor_SetStatusListener;
	}
}
