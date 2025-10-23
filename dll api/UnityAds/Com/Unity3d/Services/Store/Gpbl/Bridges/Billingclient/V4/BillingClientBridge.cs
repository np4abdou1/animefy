using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.Common;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.V4
{
	// Token: 0x02000060 RID: 96
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/v4/BillingClientBridge", DoNotGenerateAcw = true)]
	public class BillingClientBridge : BillingClientBridgeCommon
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00007588 File Offset: 0x00005788
		internal new static IntPtr class_ref
		{
			get
			{
				return BillingClientBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000075AC File Offset: 0x000057AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingClientBridge._members;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000075B4 File Offset: 0x000057B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingClientBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002AF RID: 687 RVA: 0x000075D8 File Offset: 0x000057D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingClientBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000075E4 File Offset: 0x000057E4
		protected BillingClientBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000075F0 File Offset: 0x000057F0
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000076A0 File Offset: 0x000058A0
		public static bool IsAvailable
		{
			[Register("isAvailable", "()Z", "")]
			get
			{
				return BillingClientBridge._members.StaticMethods.InvokeBooleanMethod("isAvailable.()Z", null);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000076B8 File Offset: 0x000058B8
		[Register("newBuilder", "(Landroid/content/Context;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/v4/BillingClientBridge$BuilderBridge;", "")]
		public unsafe static BillingClientBridge.BuilderBridge NewBuilder(Context context)
		{
			BillingClientBridge.BuilderBridge @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<BillingClientBridge.BuilderBridge>(BillingClientBridge._members.StaticMethods.InvokeObjectMethod("newBuilder.(Landroid/content/Context;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/v4/BillingClientBridge$BuilderBridge;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000772C File Offset: 0x0000592C
		private static Delegate GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler()
		{
			if (BillingClientBridge.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ == null)
			{
				BillingClientBridge.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BillingClientBridge.n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_));
			}
			return BillingClientBridge.cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00007750 File Offset: 0x00005950
		private static void n_QueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_(IntPtr jnienv, IntPtr native__this, IntPtr native_purchaseType, IntPtr native_purchasesResponseListenerProxy)
		{
			BillingClientBridgeCommon @object = Java.Lang.Object.GetObject<BillingClientBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_purchaseType, JniHandleOwnership.DoNotTransfer);
			PurchasesResponseListenerProxy object2 = Java.Lang.Object.GetObject<PurchasesResponseListenerProxy>(native_purchasesResponseListenerProxy, JniHandleOwnership.DoNotTransfer);
			@object.QueryPurchasesAsync(@string, object2);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000777C File Offset: 0x0000597C
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

		// Token: 0x0400007A RID: 122
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/v4/BillingClientBridge", typeof(BillingClientBridge));

		// Token: 0x0400007B RID: 123
		private static Delegate cb_queryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_;

		// Token: 0x02000061 RID: 97
		[Register("com/unity3d/services/store/gpbl/bridges/billingclient/v4/BillingClientBridge$BuilderBridge", DoNotGenerateAcw = true)]
		public class BuilderBridge : BillingClientBuilderBridgeCommon
		{
			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000781C File Offset: 0x00005A1C
			internal new static IntPtr class_ref
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002B9 RID: 697 RVA: 0x00007840 File Offset: 0x00005A40
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002BA RID: 698 RVA: 0x00007848 File Offset: 0x00005A48
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002BB RID: 699 RVA: 0x0000786C File Offset: 0x00005A6C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BillingClientBridge.BuilderBridge._members.ManagedPeerType;
				}
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00007878 File Offset: 0x00005A78
			protected BuilderBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00007884 File Offset: 0x00005A84
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

			// Token: 0x060002BE RID: 702 RVA: 0x00007934 File Offset: 0x00005B34
			private static Delegate GetBuildHandler()
			{
				if (BillingClientBridge.BuilderBridge.cb_build == null)
				{
					BillingClientBridge.BuilderBridge.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingClientBridge.BuilderBridge.n_Build));
				}
				return BillingClientBridge.BuilderBridge.cb_build;
			}

			// Token: 0x060002BF RID: 703 RVA: 0x00007958 File Offset: 0x00005B58
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BillingClientBridge.BuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build(""));
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x00007974 File Offset: 0x00005B74
			[Register("build", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBridgeCommon;", "GetBuildHandler")]
			public virtual BillingClientBridgeCommon Build(string P1 = "")
			{
				return Java.Lang.Object.GetObject<BillingClientBridgeCommon>(BillingClientBridge.BuilderBridge._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/unity3d/services/store/gpbl/bridges/billingclient/common/BillingClientBridgeCommon;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x00002226 File Offset: 0x00000426
			public override IBillingClient Build()
			{
				throw new NotImplementedException();
			}

			// Token: 0x0400007C RID: 124
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/billingclient/v4/BillingClientBridge$BuilderBridge", typeof(BillingClientBridge.BuilderBridge));

			// Token: 0x0400007D RID: 125
			private static Delegate cb_build;
		}
	}
}
