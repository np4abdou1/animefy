using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x02000198 RID: 408
	[Register("com/unity3d/services/banners/BannerView", DoNotGenerateAcw = true)]
	public class BannerView : RelativeLayout
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00035230 File Offset: 0x00033430
		internal static IntPtr class_ref
		{
			get
			{
				return BannerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00035254 File Offset: 0x00033454
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerView._members;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0003525C File Offset: 0x0003345C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00035280 File Offset: 0x00033480
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerView._members.ManagedPeerType;
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0003528C File Offset: 0x0003348C
		protected BannerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00035298 File Offset: 0x00033498
		[Register(".ctor", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/services/banners/UnityBannerSize;)V", "")]
		public unsafe BannerView(Activity activity, string placementId, UnityBannerSize size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((size == null) ? IntPtr.Zero : size.Handle);
				base.SetHandle(BannerView._members.InstanceMethods.StartCreateInstance("(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/services/banners/UnityBannerSize;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BannerView._members.InstanceMethods.FinishCreateInstance("(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/services/banners/UnityBannerSize;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(size);
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00035390 File Offset: 0x00033590
		private static Delegate GetGetPlacementIdHandler()
		{
			if (BannerView.cb_getPlacementId == null)
			{
				BannerView.cb_getPlacementId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BannerView.n_GetPlacementId));
			}
			return BannerView.cb_getPlacementId;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000353B4 File Offset: 0x000335B4
		private static IntPtr n_GetPlacementId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<BannerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PlacementId);
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000353C8 File Offset: 0x000335C8
		public virtual string PlacementId
		{
			[Register("getPlacementId", "()Ljava/lang/String;", "GetGetPlacementIdHandler")]
			get
			{
				return JNIEnv.GetString(BannerView._members.InstanceMethods.InvokeVirtualObjectMethod("getPlacementId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000353FA File Offset: 0x000335FA
		private static Delegate GetGetSizeHandler()
		{
			if (BannerView.cb_getSize == null)
			{
				BannerView.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BannerView.n_GetSize));
			}
			return BannerView.cb_getSize;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003541E File Offset: 0x0003361E
		private static IntPtr n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BannerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size);
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00035434 File Offset: 0x00033634
		public virtual UnityBannerSize Size
		{
			[Register("getSize", "()Lcom/unity3d/services/banners/UnityBannerSize;", "GetGetSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<UnityBannerSize>(BannerView._members.InstanceMethods.InvokeVirtualObjectMethod("getSize.()Lcom/unity3d/services/banners/UnityBannerSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00035466 File Offset: 0x00033666
		private static Delegate GetDestroyHandler()
		{
			if (BannerView.cb_destroy == null)
			{
				BannerView.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BannerView.n_Destroy));
			}
			return BannerView.cb_destroy;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0003548A File Offset: 0x0003368A
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BannerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00035499 File Offset: 0x00033699
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			BannerView._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000354B2 File Offset: 0x000336B2
		private static Delegate GetGetListenerHandler()
		{
			if (BannerView.cb_getListener == null)
			{
				BannerView.cb_getListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BannerView.n_GetListener));
			}
			return BannerView.cb_getListener;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000354D6 File Offset: 0x000336D6
		private static IntPtr n_GetListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BannerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetListener());
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000354EC File Offset: 0x000336EC
		[Register("getListener", "()Lcom/unity3d/services/banners/BannerView$IListener;", "GetGetListenerHandler")]
		public virtual BannerView.IListener GetListener()
		{
			return Java.Lang.Object.GetObject<BannerView.IListener>(BannerView._members.InstanceMethods.InvokeVirtualObjectMethod("getListener.()Lcom/unity3d/services/banners/BannerView$IListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0003551E File Offset: 0x0003371E
		private static Delegate GetLoadHandler()
		{
			if (BannerView.cb_load == null)
			{
				BannerView.cb_load = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BannerView.n_Load));
			}
			return BannerView.cb_load;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00035542 File Offset: 0x00033742
		private static void n_Load(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BannerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Load();
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00035551 File Offset: 0x00033751
		[Register("load", "()V", "GetLoadHandler")]
		public virtual void Load()
		{
			BannerView._members.InstanceMethods.InvokeVirtualVoidMethod("load.()V", this, null);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0003556A File Offset: 0x0003376A
		private static Delegate GetSetListener_Lcom_unity3d_services_banners_BannerView_IListener_Handler()
		{
			if (BannerView.cb_setListener_Lcom_unity3d_services_banners_BannerView_IListener_ == null)
			{
				BannerView.cb_setListener_Lcom_unity3d_services_banners_BannerView_IListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerView.n_SetListener_Lcom_unity3d_services_banners_BannerView_IListener_));
			}
			return BannerView.cb_setListener_Lcom_unity3d_services_banners_BannerView_IListener_;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00035590 File Offset: 0x00033790
		private static void n_SetListener_Lcom_unity3d_services_banners_BannerView_IListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			BannerView @object = Java.Lang.Object.GetObject<BannerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BannerView.IListener object2 = Java.Lang.Object.GetObject<BannerView.IListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetListener(object2);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000355B4 File Offset: 0x000337B4
		[Register("setListener", "(Lcom/unity3d/services/banners/BannerView$IListener;)V", "GetSetListener_Lcom_unity3d_services_banners_BannerView_IListener_Handler")]
		public unsafe virtual void SetListener(BannerView.IListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				BannerView._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/unity3d/services/banners/BannerView$IListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0003561C File Offset: 0x0003381C
		private BannerView.IListenerImplementor __CreateIListenerImplementor()
		{
			return new BannerView.IListenerImplementor(this);
		}

		// Token: 0x0400045B RID: 1115
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/BannerView", typeof(BannerView));

		// Token: 0x0400045C RID: 1116
		private static Delegate cb_getPlacementId;

		// Token: 0x0400045D RID: 1117
		private static Delegate cb_getSize;

		// Token: 0x0400045E RID: 1118
		private static Delegate cb_destroy;

		// Token: 0x0400045F RID: 1119
		private static Delegate cb_getListener;

		// Token: 0x04000460 RID: 1120
		private static Delegate cb_load;

		// Token: 0x04000461 RID: 1121
		private static Delegate cb_setListener_Lcom_unity3d_services_banners_BannerView_IListener_;

		// Token: 0x02000199 RID: 409
		[Register("com/unity3d/services/banners/BannerView$IListener", "", "Com.Unity3d.Services.Banners.BannerView/IListenerInvoker")]
		public interface IListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060012C6 RID: 4806
			[Register("onBannerClick", "(Lcom/unity3d/services/banners/BannerView;)V", "GetOnBannerClick_Lcom_unity3d_services_banners_BannerView_Handler:Com.Unity3d.Services.Banners.BannerView/IListenerInvoker, UnityAds")]
			void OnBannerClick(BannerView p0);

			// Token: 0x060012C7 RID: 4807
			[Register("onBannerFailedToLoad", "(Lcom/unity3d/services/banners/BannerView;Lcom/unity3d/services/banners/BannerErrorInfo;)V", "GetOnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_Handler:Com.Unity3d.Services.Banners.BannerView/IListenerInvoker, UnityAds")]
			void OnBannerFailedToLoad(BannerView p0, BannerErrorInfo p1);

			// Token: 0x060012C8 RID: 4808
			[Register("onBannerLeftApplication", "(Lcom/unity3d/services/banners/BannerView;)V", "GetOnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_Handler:Com.Unity3d.Services.Banners.BannerView/IListenerInvoker, UnityAds")]
			void OnBannerLeftApplication(BannerView p0);

			// Token: 0x060012C9 RID: 4809
			[Register("onBannerLoaded", "(Lcom/unity3d/services/banners/BannerView;)V", "GetOnBannerLoaded_Lcom_unity3d_services_banners_BannerView_Handler:Com.Unity3d.Services.Banners.BannerView/IListenerInvoker, UnityAds")]
			void OnBannerLoaded(BannerView p0);
		}

		// Token: 0x0200019A RID: 410
		[Register("com/unity3d/services/banners/BannerView$IListener", DoNotGenerateAcw = true)]
		internal class IListenerInvoker : Java.Lang.Object, BannerView.IListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x060012CA RID: 4810 RVA: 0x00035640 File Offset: 0x00033840
			private static IntPtr java_class_ref
			{
				get
				{
					return BannerView.IListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x060012CB RID: 4811 RVA: 0x00035664 File Offset: 0x00033864
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BannerView.IListenerInvoker._members;
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x060012CC RID: 4812 RVA: 0x0003566B File Offset: 0x0003386B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x060012CD RID: 4813 RVA: 0x00035673 File Offset: 0x00033873
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BannerView.IListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060012CE RID: 4814 RVA: 0x0003567F File Offset: 0x0003387F
			public static BannerView.IListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<BannerView.IListener>(handle, transfer);
			}

			// Token: 0x060012CF RID: 4815 RVA: 0x00035688 File Offset: 0x00033888
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, BannerView.IListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.banners.BannerView.IListener'.");
				}
				return handle;
			}

			// Token: 0x060012D0 RID: 4816 RVA: 0x000356B3 File Offset: 0x000338B3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060012D1 RID: 4817 RVA: 0x000356E4 File Offset: 0x000338E4
			public IListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(BannerView.IListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060012D2 RID: 4818 RVA: 0x0003571C File Offset: 0x0003391C
			private static Delegate GetOnBannerClick_Lcom_unity3d_services_banners_BannerView_Handler()
			{
				if (BannerView.IListenerInvoker.cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_ == null)
				{
					BannerView.IListenerInvoker.cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerView.IListenerInvoker.n_OnBannerClick_Lcom_unity3d_services_banners_BannerView_));
				}
				return BannerView.IListenerInvoker.cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_;
			}

			// Token: 0x060012D3 RID: 4819 RVA: 0x00035740 File Offset: 0x00033940
			private static void n_OnBannerClick_Lcom_unity3d_services_banners_BannerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BannerView.IListener @object = Java.Lang.Object.GetObject<BannerView.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerClick(object2);
			}

			// Token: 0x060012D4 RID: 4820 RVA: 0x00035764 File Offset: 0x00033964
			public unsafe void OnBannerClick(BannerView p0)
			{
				if (this.id_onBannerClick_Lcom_unity3d_services_banners_BannerView_ == IntPtr.Zero)
				{
					this.id_onBannerClick_Lcom_unity3d_services_banners_BannerView_ = JNIEnv.GetMethodID(this.class_ref, "onBannerClick", "(Lcom/unity3d/services/banners/BannerView;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onBannerClick_Lcom_unity3d_services_banners_BannerView_, ptr);
			}

			// Token: 0x060012D5 RID: 4821 RVA: 0x000357D7 File Offset: 0x000339D7
			private static Delegate GetOnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_Handler()
			{
				if (BannerView.IListenerInvoker.cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_ == null)
				{
					BannerView.IListenerInvoker.cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BannerView.IListenerInvoker.n_OnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_));
				}
				return BannerView.IListenerInvoker.cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_;
			}

			// Token: 0x060012D6 RID: 4822 RVA: 0x000357FC File Offset: 0x000339FC
			private static void n_OnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				BannerView.IListener @object = Java.Lang.Object.GetObject<BannerView.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_p0, JniHandleOwnership.DoNotTransfer);
				BannerErrorInfo object3 = Java.Lang.Object.GetObject<BannerErrorInfo>(native_p1, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerFailedToLoad(object2, object3);
			}

			// Token: 0x060012D7 RID: 4823 RVA: 0x00035828 File Offset: 0x00033A28
			public unsafe void OnBannerFailedToLoad(BannerView p0, BannerErrorInfo p1)
			{
				if (this.id_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_ == IntPtr.Zero)
				{
					this.id_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_ = JNIEnv.GetMethodID(this.class_ref, "onBannerFailedToLoad", "(Lcom/unity3d/services/banners/BannerView;Lcom/unity3d/services/banners/BannerErrorInfo;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_, ptr);
			}

			// Token: 0x060012D8 RID: 4824 RVA: 0x000358BD File Offset: 0x00033ABD
			private static Delegate GetOnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_Handler()
			{
				if (BannerView.IListenerInvoker.cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_ == null)
				{
					BannerView.IListenerInvoker.cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerView.IListenerInvoker.n_OnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_));
				}
				return BannerView.IListenerInvoker.cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_;
			}

			// Token: 0x060012D9 RID: 4825 RVA: 0x000358E4 File Offset: 0x00033AE4
			private static void n_OnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BannerView.IListener @object = Java.Lang.Object.GetObject<BannerView.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerLeftApplication(object2);
			}

			// Token: 0x060012DA RID: 4826 RVA: 0x00035908 File Offset: 0x00033B08
			public unsafe void OnBannerLeftApplication(BannerView p0)
			{
				if (this.id_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_ == IntPtr.Zero)
				{
					this.id_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_ = JNIEnv.GetMethodID(this.class_ref, "onBannerLeftApplication", "(Lcom/unity3d/services/banners/BannerView;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_, ptr);
			}

			// Token: 0x060012DB RID: 4827 RVA: 0x0003597B File Offset: 0x00033B7B
			private static Delegate GetOnBannerLoaded_Lcom_unity3d_services_banners_BannerView_Handler()
			{
				if (BannerView.IListenerInvoker.cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_ == null)
				{
					BannerView.IListenerInvoker.cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerView.IListenerInvoker.n_OnBannerLoaded_Lcom_unity3d_services_banners_BannerView_));
				}
				return BannerView.IListenerInvoker.cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_;
			}

			// Token: 0x060012DC RID: 4828 RVA: 0x000359A0 File Offset: 0x00033BA0
			private static void n_OnBannerLoaded_Lcom_unity3d_services_banners_BannerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BannerView.IListener @object = Java.Lang.Object.GetObject<BannerView.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerLoaded(object2);
			}

			// Token: 0x060012DD RID: 4829 RVA: 0x000359C4 File Offset: 0x00033BC4
			public unsafe void OnBannerLoaded(BannerView p0)
			{
				if (this.id_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_ == IntPtr.Zero)
				{
					this.id_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_ = JNIEnv.GetMethodID(this.class_ref, "onBannerLoaded", "(Lcom/unity3d/services/banners/BannerView;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_, ptr);
			}

			// Token: 0x04000462 RID: 1122
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/BannerView$IListener", typeof(BannerView.IListenerInvoker));

			// Token: 0x04000463 RID: 1123
			private IntPtr class_ref;

			// Token: 0x04000464 RID: 1124
			private static Delegate cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_;

			// Token: 0x04000465 RID: 1125
			private IntPtr id_onBannerClick_Lcom_unity3d_services_banners_BannerView_;

			// Token: 0x04000466 RID: 1126
			private static Delegate cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_;

			// Token: 0x04000467 RID: 1127
			private IntPtr id_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_;

			// Token: 0x04000468 RID: 1128
			private static Delegate cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_;

			// Token: 0x04000469 RID: 1129
			private IntPtr id_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_;

			// Token: 0x0400046A RID: 1130
			private static Delegate cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_;

			// Token: 0x0400046B RID: 1131
			private IntPtr id_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_;
		}

		// Token: 0x0200019B RID: 411
		public class BannerClickEventArgs : EventArgs
		{
			// Token: 0x060012DF RID: 4831 RVA: 0x00035A52 File Offset: 0x00033C52
			public BannerClickEventArgs(BannerView p0)
			{
				this.p0 = p0;
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00035A61 File Offset: 0x00033C61
			public BannerView P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x0400046C RID: 1132
			private BannerView p0;
		}

		// Token: 0x0200019C RID: 412
		public class BannerFailedToLoadEventArgs : EventArgs
		{
			// Token: 0x060012E1 RID: 4833 RVA: 0x00035A69 File Offset: 0x00033C69
			public BannerFailedToLoadEventArgs(BannerView p0, BannerErrorInfo p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00035A7F File Offset: 0x00033C7F
			public BannerView P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00035A87 File Offset: 0x00033C87
			public BannerErrorInfo P1
			{
				get
				{
					return this.p1;
				}
			}

			// Token: 0x0400046D RID: 1133
			private BannerView p0;

			// Token: 0x0400046E RID: 1134
			private BannerErrorInfo p1;
		}

		// Token: 0x0200019D RID: 413
		public class BannerLeftApplicationEventArgs : EventArgs
		{
			// Token: 0x060012E4 RID: 4836 RVA: 0x00035A8F File Offset: 0x00033C8F
			public BannerLeftApplicationEventArgs(BannerView p0)
			{
				this.p0 = p0;
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00035A9E File Offset: 0x00033C9E
			public BannerView P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x0400046F RID: 1135
			private BannerView p0;
		}

		// Token: 0x0200019E RID: 414
		public class BannerLoadedEventArgs : EventArgs
		{
			// Token: 0x060012E6 RID: 4838 RVA: 0x00035AA6 File Offset: 0x00033CA6
			public BannerLoadedEventArgs(BannerView p0)
			{
				this.p0 = p0;
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00035AB5 File Offset: 0x00033CB5
			public BannerView P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x04000470 RID: 1136
			private BannerView p0;
		}

		// Token: 0x0200019F RID: 415
		[Register("mono/com/unity3d/services/banners/BannerView_IListenerImplementor")]
		internal sealed class IListenerImplementor : Java.Lang.Object, BannerView.IListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060012E8 RID: 4840 RVA: 0x00035ABD File Offset: 0x00033CBD
			public IListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/banners/BannerView_IListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060012E9 RID: 4841 RVA: 0x00035AF8 File Offset: 0x00033CF8
			public void OnBannerClick(BannerView p0)
			{
				EventHandler<BannerView.BannerClickEventArgs> onBannerClickHandler = this.OnBannerClickHandler;
				if (onBannerClickHandler != null)
				{
					onBannerClickHandler(this.sender, new BannerView.BannerClickEventArgs(p0));
				}
			}

			// Token: 0x060012EA RID: 4842 RVA: 0x00035B24 File Offset: 0x00033D24
			public void OnBannerFailedToLoad(BannerView p0, BannerErrorInfo p1)
			{
				EventHandler<BannerView.BannerFailedToLoadEventArgs> onBannerFailedToLoadHandler = this.OnBannerFailedToLoadHandler;
				if (onBannerFailedToLoadHandler != null)
				{
					onBannerFailedToLoadHandler(this.sender, new BannerView.BannerFailedToLoadEventArgs(p0, p1));
				}
			}

			// Token: 0x060012EB RID: 4843 RVA: 0x00035B50 File Offset: 0x00033D50
			public void OnBannerLeftApplication(BannerView p0)
			{
				EventHandler<BannerView.BannerLeftApplicationEventArgs> onBannerLeftApplicationHandler = this.OnBannerLeftApplicationHandler;
				if (onBannerLeftApplicationHandler != null)
				{
					onBannerLeftApplicationHandler(this.sender, new BannerView.BannerLeftApplicationEventArgs(p0));
				}
			}

			// Token: 0x060012EC RID: 4844 RVA: 0x00035B7C File Offset: 0x00033D7C
			public void OnBannerLoaded(BannerView p0)
			{
				EventHandler<BannerView.BannerLoadedEventArgs> onBannerLoadedHandler = this.OnBannerLoadedHandler;
				if (onBannerLoadedHandler != null)
				{
					onBannerLoadedHandler(this.sender, new BannerView.BannerLoadedEventArgs(p0));
				}
			}

			// Token: 0x060012ED RID: 4845 RVA: 0x00035BA5 File Offset: 0x00033DA5
			internal static bool __IsEmpty(BannerView.IListenerImplementor value)
			{
				return value.OnBannerClickHandler == null && value.OnBannerFailedToLoadHandler == null && value.OnBannerLeftApplicationHandler == null && value.OnBannerLoadedHandler == null;
			}

			// Token: 0x04000471 RID: 1137
			private object sender;

			// Token: 0x04000472 RID: 1138
			public EventHandler<BannerView.BannerClickEventArgs> OnBannerClickHandler;

			// Token: 0x04000473 RID: 1139
			public EventHandler<BannerView.BannerFailedToLoadEventArgs> OnBannerFailedToLoadHandler;

			// Token: 0x04000474 RID: 1140
			public EventHandler<BannerView.BannerLeftApplicationEventArgs> OnBannerLeftApplicationHandler;

			// Token: 0x04000475 RID: 1141
			public EventHandler<BannerView.BannerLoadedEventArgs> OnBannerLoadedHandler;
		}

		// Token: 0x020001A0 RID: 416
		[Register("com/unity3d/services/banners/BannerView$Listener", DoNotGenerateAcw = true)]
		public abstract class Listener : Java.Lang.Object, BannerView.IListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x060012EE RID: 4846 RVA: 0x00035BCC File Offset: 0x00033DCC
			internal static IntPtr class_ref
			{
				get
				{
					return BannerView.Listener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x060012EF RID: 4847 RVA: 0x00035BF0 File Offset: 0x00033DF0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BannerView.Listener._members;
				}
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00035BF8 File Offset: 0x00033DF8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BannerView.Listener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00035C1C File Offset: 0x00033E1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BannerView.Listener._members.ManagedPeerType;
				}
			}

			// Token: 0x060012F2 RID: 4850 RVA: 0x000021E8 File Offset: 0x000003E8
			protected Listener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060012F3 RID: 4851 RVA: 0x00035C28 File Offset: 0x00033E28
			[Register(".ctor", "()V", "")]
			public Listener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(BannerView.Listener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				BannerView.Listener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060012F4 RID: 4852 RVA: 0x00035C96 File Offset: 0x00033E96
			private static Delegate GetOnBannerClick_Lcom_unity3d_services_banners_BannerView_Handler()
			{
				if (BannerView.Listener.cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_ == null)
				{
					BannerView.Listener.cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerView.Listener.n_OnBannerClick_Lcom_unity3d_services_banners_BannerView_));
				}
				return BannerView.Listener.cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_;
			}

			// Token: 0x060012F5 RID: 4853 RVA: 0x00035CBC File Offset: 0x00033EBC
			private static void n_OnBannerClick_Lcom_unity3d_services_banners_BannerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdView)
			{
				BannerView.Listener @object = Java.Lang.Object.GetObject<BannerView.Listener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_bannerAdView, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerClick(object2);
			}

			// Token: 0x060012F6 RID: 4854 RVA: 0x00035CE0 File Offset: 0x00033EE0
			[Register("onBannerClick", "(Lcom/unity3d/services/banners/BannerView;)V", "GetOnBannerClick_Lcom_unity3d_services_banners_BannerView_Handler")]
			public unsafe virtual void OnBannerClick(BannerView bannerAdView)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bannerAdView == null) ? IntPtr.Zero : bannerAdView.Handle);
					BannerView.Listener._members.InstanceMethods.InvokeVirtualVoidMethod("onBannerClick.(Lcom/unity3d/services/banners/BannerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(bannerAdView);
				}
			}

			// Token: 0x060012F7 RID: 4855 RVA: 0x00035D44 File Offset: 0x00033F44
			private static Delegate GetOnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_Handler()
			{
				if (BannerView.Listener.cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_ == null)
				{
					BannerView.Listener.cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BannerView.Listener.n_OnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_));
				}
				return BannerView.Listener.cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_;
			}

			// Token: 0x060012F8 RID: 4856 RVA: 0x00035D68 File Offset: 0x00033F68
			private static void n_OnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdView, IntPtr native_errorInfo)
			{
				BannerView.Listener @object = Java.Lang.Object.GetObject<BannerView.Listener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_bannerAdView, JniHandleOwnership.DoNotTransfer);
				BannerErrorInfo object3 = Java.Lang.Object.GetObject<BannerErrorInfo>(native_errorInfo, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerFailedToLoad(object2, object3);
			}

			// Token: 0x060012F9 RID: 4857 RVA: 0x00035D94 File Offset: 0x00033F94
			[Register("onBannerFailedToLoad", "(Lcom/unity3d/services/banners/BannerView;Lcom/unity3d/services/banners/BannerErrorInfo;)V", "GetOnBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_Handler")]
			public unsafe virtual void OnBannerFailedToLoad(BannerView bannerAdView, BannerErrorInfo errorInfo)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bannerAdView == null) ? IntPtr.Zero : bannerAdView.Handle);
					ptr[1] = new JniArgumentValue((errorInfo == null) ? IntPtr.Zero : errorInfo.Handle);
					BannerView.Listener._members.InstanceMethods.InvokeVirtualVoidMethod("onBannerFailedToLoad.(Lcom/unity3d/services/banners/BannerView;Lcom/unity3d/services/banners/BannerErrorInfo;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(bannerAdView);
					GC.KeepAlive(errorInfo);
				}
			}

			// Token: 0x060012FA RID: 4858 RVA: 0x00035E20 File Offset: 0x00034020
			private static Delegate GetOnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_Handler()
			{
				if (BannerView.Listener.cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_ == null)
				{
					BannerView.Listener.cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerView.Listener.n_OnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_));
				}
				return BannerView.Listener.cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_;
			}

			// Token: 0x060012FB RID: 4859 RVA: 0x00035E44 File Offset: 0x00034044
			private static void n_OnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdView)
			{
				BannerView.Listener @object = Java.Lang.Object.GetObject<BannerView.Listener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_bannerAdView, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerLeftApplication(object2);
			}

			// Token: 0x060012FC RID: 4860 RVA: 0x00035E68 File Offset: 0x00034068
			[Register("onBannerLeftApplication", "(Lcom/unity3d/services/banners/BannerView;)V", "GetOnBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_Handler")]
			public unsafe virtual void OnBannerLeftApplication(BannerView bannerAdView)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bannerAdView == null) ? IntPtr.Zero : bannerAdView.Handle);
					BannerView.Listener._members.InstanceMethods.InvokeVirtualVoidMethod("onBannerLeftApplication.(Lcom/unity3d/services/banners/BannerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(bannerAdView);
				}
			}

			// Token: 0x060012FD RID: 4861 RVA: 0x00035ECC File Offset: 0x000340CC
			private static Delegate GetOnBannerLoaded_Lcom_unity3d_services_banners_BannerView_Handler()
			{
				if (BannerView.Listener.cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_ == null)
				{
					BannerView.Listener.cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerView.Listener.n_OnBannerLoaded_Lcom_unity3d_services_banners_BannerView_));
				}
				return BannerView.Listener.cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_;
			}

			// Token: 0x060012FE RID: 4862 RVA: 0x00035EF0 File Offset: 0x000340F0
			private static void n_OnBannerLoaded_Lcom_unity3d_services_banners_BannerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdView)
			{
				BannerView.Listener @object = Java.Lang.Object.GetObject<BannerView.Listener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_bannerAdView, JniHandleOwnership.DoNotTransfer);
				@object.OnBannerLoaded(object2);
			}

			// Token: 0x060012FF RID: 4863 RVA: 0x00035F14 File Offset: 0x00034114
			[Register("onBannerLoaded", "(Lcom/unity3d/services/banners/BannerView;)V", "GetOnBannerLoaded_Lcom_unity3d_services_banners_BannerView_Handler")]
			public unsafe virtual void OnBannerLoaded(BannerView bannerAdView)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bannerAdView == null) ? IntPtr.Zero : bannerAdView.Handle);
					BannerView.Listener._members.InstanceMethods.InvokeVirtualVoidMethod("onBannerLoaded.(Lcom/unity3d/services/banners/BannerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(bannerAdView);
				}
			}

			// Token: 0x04000476 RID: 1142
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/BannerView$Listener", typeof(BannerView.Listener));

			// Token: 0x04000477 RID: 1143
			private static Delegate cb_onBannerClick_Lcom_unity3d_services_banners_BannerView_;

			// Token: 0x04000478 RID: 1144
			private static Delegate cb_onBannerFailedToLoad_Lcom_unity3d_services_banners_BannerView_Lcom_unity3d_services_banners_BannerErrorInfo_;

			// Token: 0x04000479 RID: 1145
			private static Delegate cb_onBannerLeftApplication_Lcom_unity3d_services_banners_BannerView_;

			// Token: 0x0400047A RID: 1146
			private static Delegate cb_onBannerLoaded_Lcom_unity3d_services_banners_BannerView_;
		}

		// Token: 0x020001A1 RID: 417
		[Register("com/unity3d/services/banners/BannerView$Listener", DoNotGenerateAcw = true)]
		internal class ListenerInvoker : BannerView.Listener
		{
			// Token: 0x06001301 RID: 4865 RVA: 0x00035F93 File Offset: 0x00034193
			public ListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x06001302 RID: 4866 RVA: 0x00035F9D File Offset: 0x0003419D
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BannerView.ListenerInvoker._members;
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06001303 RID: 4867 RVA: 0x00035FA4 File Offset: 0x000341A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BannerView.ListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0400047B RID: 1147
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/BannerView$Listener", typeof(BannerView.ListenerInvoker));
		}
	}
}
