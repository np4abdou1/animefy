using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Com.Unity3d.Services.Store.Listeners;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Proxies
{
	// Token: 0x02000051 RID: 81
	[Register("com/unity3d/services/store/gpbl/proxies/SkuDetailsResponseListenerProxy", DoNotGenerateAcw = true)]
	public class SkuDetailsResponseListenerProxy : GenericListenerProxy
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000055BC File Offset: 0x000037BC
		internal new static IntPtr class_ref
		{
			get
			{
				return SkuDetailsResponseListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000055E0 File Offset: 0x000037E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SkuDetailsResponseListenerProxy._members;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000055E8 File Offset: 0x000037E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SkuDetailsResponseListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000560C File Offset: 0x0000380C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SkuDetailsResponseListenerProxy._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00004BCC File Offset: 0x00002DCC
		protected SkuDetailsResponseListenerProxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00005618 File Offset: 0x00003818
		[Register(".ctor", "(Lcom/unity3d/services/store/listeners/ISkuDetailsResponseListener;)V", "")]
		public unsafe SkuDetailsResponseListenerProxy(ISkuDetailsResponseListener skuDetailsResponseListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((skuDetailsResponseListener == null) ? IntPtr.Zero : ((Java.Lang.Object)skuDetailsResponseListener).Handle);
				base.SetHandle(SkuDetailsResponseListenerProxy._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/store/listeners/ISkuDetailsResponseListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SkuDetailsResponseListenerProxy._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/store/listeners/ISkuDetailsResponseListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(skuDetailsResponseListener);
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000056CC File Offset: 0x000038CC
		private static Delegate GetGetProxyClassHandler()
		{
			if (SkuDetailsResponseListenerProxy.cb_getProxyClass == null)
			{
				SkuDetailsResponseListenerProxy.cb_getProxyClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SkuDetailsResponseListenerProxy.n_GetProxyClass));
			}
			return SkuDetailsResponseListenerProxy.cb_getProxyClass;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000056F0 File Offset: 0x000038F0
		private static IntPtr n_GetProxyClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SkuDetailsResponseListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProxyClass);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00005704 File Offset: 0x00003904
		public override Class ProxyClass
		{
			[Register("getProxyClass", "()Ljava/lang/Class;", "GetGetProxyClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(SkuDetailsResponseListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("getProxyClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00005738 File Offset: 0x00003938
		public static Class ProxyListenerClass
		{
			[Register("getProxyListenerClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(SkuDetailsResponseListenerProxy._members.StaticMethods.InvokeObjectMethod("getProxyListenerClass.()Ljava/lang/Class;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00005769 File Offset: 0x00003969
		private static Delegate GetOnSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_Handler()
		{
			if (SkuDetailsResponseListenerProxy.cb_onSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_ == null)
			{
				SkuDetailsResponseListenerProxy.cb_onSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(SkuDetailsResponseListenerProxy.n_OnSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_));
			}
			return SkuDetailsResponseListenerProxy.cb_onSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00005790 File Offset: 0x00003990
		private static void n_OnSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_billingResult, IntPtr native_skuDetailsList)
		{
			SkuDetailsResponseListenerProxy @object = Java.Lang.Object.GetObject<SkuDetailsResponseListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_billingResult, JniHandleOwnership.DoNotTransfer);
			IList<Java.Lang.Object> skuDetailsList = JavaList<Java.Lang.Object>.FromJniHandle(native_skuDetailsList, JniHandleOwnership.DoNotTransfer);
			@object.OnSkuDetailsResponse(object2, skuDetailsList);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000057BC File Offset: 0x000039BC
		[Register("onSkuDetailsResponse", "(Ljava/lang/Object;Ljava/util/List;)V", "GetOnSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_Handler")]
		public unsafe virtual void OnSkuDetailsResponse(Java.Lang.Object billingResult, IList<Java.Lang.Object> skuDetailsList)
		{
			IntPtr intPtr = JavaList<Java.Lang.Object>.ToLocalJniHandle(skuDetailsList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingResult == null) ? IntPtr.Zero : billingResult.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				SkuDetailsResponseListenerProxy._members.InstanceMethods.InvokeVirtualVoidMethod("onSkuDetailsResponse.(Ljava/lang/Object;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(billingResult);
				GC.KeepAlive(skuDetailsList);
			}
		}

		// Token: 0x04000046 RID: 70
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/proxies/SkuDetailsResponseListenerProxy", typeof(SkuDetailsResponseListenerProxy));

		// Token: 0x04000047 RID: 71
		private static Delegate cb_getProxyClass;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_onSkuDetailsResponse_Ljava_lang_Object_Ljava_util_List_;
	}
}
