using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.Common;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.V3
{
	// Token: 0x02000062 RID: 98
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/v3/BillingClientBridge", DoNotGenerateAcw = true)]
	public class BillingClientBridge : BillingClientBridgeCommon
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000079C4 File Offset: 0x00005BC4
		internal new static IntPtr class_ref
		{
			get
			{
				return BillingClientBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000079E8 File Offset: 0x00005BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientBridge._members;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x000079F0 File Offset: 0x00005BF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingClientBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00007A14 File Offset: 0x00005C14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000075E4 File Offset: 0x000057E4
		protected BillingClientBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00007A20 File Offset: 0x00005C20
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe BillingClientBridge(Java.Lang.Object billingClientInternalInstance) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingClientInternalInstance == null) ? IntPtr.Zero : billingClientInternalInstance.Handle);
				base.SetHandle(BillingClientBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BillingClientBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(billingClientInternalInstance);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Register("newBuilder", "(Landroid/content/Context;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/v3/BillingClientBridge$BuilderBridge;", "")]
		public unsafe static BillingClientBridge.BuilderBridge NewBuilder(Context context)
		{
			BillingClientBridge.BuilderBridge @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<BillingClientBridge.BuilderBridge>(BillingClientBridge._members.StaticMethods.InvokeObjectMethod("newBuilder.(Landroid/content/Context;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/v3/BillingClientBridge$BuilderBridge;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00007B44 File Offset: 0x00005D44
		private static Delegate GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler()
		{
			if (BillingClientBridge.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ == null)
			{
				BillingClientBridge.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BillingClientBridge.n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_));
			}
			return BillingClientBridge.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00007B68 File Offset: 0x00005D68
		private static void n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseType, IntPtr native_purchasesResponseListenerProxy)
		{
			BillingClientBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_purchaseType, JniHandleOwnership.DoNotTransfer);
			PurchasesResponseListenerProxy object2 = Java.Lang.Object.GetObject<PurchasesResponseListenerProxy>(native_purchasesResponseListenerProxy, JniHandleOwnership.DoNotTransfer);
			@object.QueryPurchasesAsync(@string, object2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00007B94 File Offset: 0x00005D94
		[Register("queryPurchasesAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy;)V", "GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler")]
		public unsafe override void QueryPurchasesAsync(string purchaseType, PurchasesResponseListenerProxy purchasesResponseListenerProxy)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((purchasesResponseListenerProxy == null) ? IntPtr.Zero : purchasesResponseListenerProxy.Handle);
				BillingClientBridge._members.InstanceMethods.InvokeVirtualVoidMethod("queryPurchasesAsync.(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(purchasesResponseListenerProxy);
			}
		}

		// Token: 0x0400007E RID: 126
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/v3/BillingClientBridge", typeof(BillingClientBridge));

		// Token: 0x0400007F RID: 127
		private static Delegate cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;

		// Token: 0x02000063 RID: 99
		[Register("com/unity3d/services/store/gpbl/bridges/billingclient/v3/BillingClientBridge$BuilderBridge", DoNotGenerateAcw = true)]
		public class BuilderBridge : BillingClientBuilderBridgeCommon
		{
			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002CE RID: 718 RVA: 0x00007C34 File Offset: 0x00005E34
			internal new static IntPtr class_ref
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060002CF RID: 719 RVA: 0x00007C58 File Offset: 0x00005E58
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x00007C60 File Offset: 0x00005E60
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002D1 RID: 721 RVA: 0x00007C84 File Offset: 0x00005E84
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members.ManagedPeerType;
				}
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x00007878 File Offset: 0x00005A78
			protected BuilderBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x00007C90 File Offset: 0x00005E90
			[Register(".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe BuilderBridge(Java.Lang.Object billingClientBuilderInternalInstance) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((billingClientBuilderInternalInstance == null) ? IntPtr.Zero : billingClientBuilderInternalInstance.Handle);
					base.SetHandle(BillingClientBridge.BuilderBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					BillingClientBridge.BuilderBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(billingClientBuilderInternalInstance);
				}
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x00007D40 File Offset: 0x00005F40
			private static Delegate GetBuildHandler()
			{
				if (BillingClientBridge.BuilderBridge.cb_build == null)
				{
					BillingClientBridge.BuilderBridge.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingClientBridge.BuilderBridge.n_Build));
				}
				return BillingClientBridge.BuilderBridge.cb_build;
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x00007D64 File Offset: 0x00005F64
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BillingClientBridge.BuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x00007D78 File Offset: 0x00005F78
			[Register("build", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient;", "GetBuildHandler")]
			public override IBillingClient Build()
			{
				return Java.Lang.Object.GetObject<IBillingClient>(BillingClientBridge.BuilderBridge._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000080 RID: 128
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/v3/BillingClientBridge$BuilderBridge", typeof(BillingClientBridge.BuilderBridge));

			// Token: 0x04000081 RID: 129
			private static Delegate cb_build;
		}
	}
}
