using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Proxies
{
	// Token: 0x0200004D RID: 77
	[Register("com/unity3d/services/store/gpbl/proxies/BillingClientStateListenerProxy", DoNotGenerateAcw = true)]
	public class BillingClientStateListenerProxy : GenericListenerProxy
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00004B70 File Offset: 0x00002D70
		internal new static IntPtr class_ref
		{
			get
			{
				return BillingClientStateListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00004B94 File Offset: 0x00002D94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientStateListenerProxy._members;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00004B9C File Offset: 0x00002D9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingClientStateListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientStateListenerProxy._members.ManagedPeerType;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00004BCC File Offset: 0x00002DCC
		protected BillingClientStateListenerProxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Register(".ctor", "(Lcom/unity3d/services/store/gpbl/IBillingClientStateListener;)V", "")]
		public unsafe BillingClientStateListenerProxy(IBillingClientStateListener billingClientStateListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingClientStateListener == null) ? IntPtr.Zero : ((Java.Lang.Object)billingClientStateListener).Handle);
				base.SetHandle(BillingClientStateListenerProxy._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/store/gpbl/IBillingClientStateListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BillingClientStateListenerProxy._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/store/gpbl/IBillingClientStateListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(billingClientStateListener);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00004C8C File Offset: 0x00002E8C
		private static Delegate GetGetProxyClassHandler()
		{
			if (BillingClientStateListenerProxy.cb_getProxyClass == null)
			{
				BillingClientStateListenerProxy.cb_getProxyClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingClientStateListenerProxy.n_GetProxyClass));
			}
			return BillingClientStateListenerProxy.cb_getProxyClass;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00004CB0 File Offset: 0x00002EB0
		private static IntPtr n_GetProxyClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BillingClientStateListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProxyClass);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public override Class ProxyClass
		{
			[Register("getProxyClass", "()Ljava/lang/Class;", "GetGetProxyClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(BillingClientStateListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("getProxyClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public static Class ProxyListenerClass
		{
			[Register("getProxyListenerClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(BillingClientStateListenerProxy._members.StaticMethods.InvokeObjectMethod("getProxyListenerClass.()Ljava/lang/Class;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400003A RID: 58
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/proxies/BillingClientStateListenerProxy", typeof(BillingClientStateListenerProxy));

		// Token: 0x0400003B RID: 59
		private static Delegate cb_getProxyClass;
	}
}
