using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Com.Applovin.Mediation.Adapter;
using Com.Applovin.Mediation.Adapter.Listeners;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapters
{
	// Token: 0x020000F5 RID: 245
	[Register("com/applovin/mediation/adapters/MediationAdapterRouter", DoNotGenerateAcw = true)]
	public abstract class MediationAdapterRouter : Java.Lang.Object
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0001BB28 File Offset: 0x00019D28
		[Register("mOnCompletionListener")]
		protected IMaxAdapterOnCompletionListener MOnCompletionListener
		{
			get
			{
				return Java.Lang.Object.GetObject<IMaxAdapterOnCompletionListener>(MediationAdapterRouter._members.InstanceFields.GetObjectValue("mOnCompletionListener.Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					MediationAdapterRouter._members.InstanceFields.SetValue("mOnCompletionListener.Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0001BB74 File Offset: 0x00019D74
		internal static IntPtr class_ref
		{
			get
			{
				return MediationAdapterRouter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0001BB98 File Offset: 0x00019D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediationAdapterRouter._members;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediationAdapterRouter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0001BBC4 File Offset: 0x00019DC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediationAdapterRouter._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MediationAdapterRouter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[Register(".ctor", "()V", "")]
		protected MediationAdapterRouter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MediationAdapterRouter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MediationAdapterRouter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001BC3E File Offset: 0x00019E3E
		private static Delegate GetAddAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_Handler()
		{
			if (MediationAdapterRouter.cb_addAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_ == null)
			{
				MediationAdapterRouter.cb_addAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(MediationAdapterRouter.n_AddAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_));
			}
			return MediationAdapterRouter.cb_addAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001BC64 File Offset: 0x00019E64
		private static void n_AddAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapter object2 = Java.Lang.Object.GetObject<IMaxAdapter>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxAdViewAdapterListener object3 = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.AddAdViewAdapter(object2, object3, @string, object4);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		[Register("addAdViewAdapter", "(Lcom/applovin/mediation/adapter/MaxAdapter;Lcom/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener;Ljava/lang/String;Landroid/view/View;)V", "GetAddAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_Handler")]
		public unsafe virtual void AddAdViewAdapter(IMaxAdapter p0, IMaxAdViewAdapterListener p1, string p2, View p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("addAdViewAdapter.(Lcom/applovin/mediation/adapter/MaxAdapter;Lcom/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener;Ljava/lang/String;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0001BD8C File Offset: 0x00019F8C
		private static Delegate GetAddInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_addInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_addInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MediationAdapterRouter.n_AddInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_addInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		private static void n_AddInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapter object2 = Java.Lang.Object.GetObject<IMaxAdapter>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxInterstitialAdapterListener object3 = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.AddInterstitialAdapter(object2, object3, @string);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0001BDE8 File Offset: 0x00019FE8
		[Register("addInterstitialAdapter", "(Lcom/applovin/mediation/adapter/MaxAdapter;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;Ljava/lang/String;)V", "GetAddInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_Handler")]
		public unsafe virtual void AddInterstitialAdapter(IMaxAdapter p0, IMaxInterstitialAdapterListener p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("addInterstitialAdapter.(Lcom/applovin/mediation/adapter/MaxAdapter;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0001BEA0 File Offset: 0x0001A0A0
		private static Delegate GetAddRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_addRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_addRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MediationAdapterRouter.n_AddRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_addRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0001BEC4 File Offset: 0x0001A0C4
		private static void n_AddRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapter object2 = Java.Lang.Object.GetObject<IMaxAdapter>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedAdapterListener object3 = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.AddRewardedAdapter(object2, object3, @string);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0001BEFC File Offset: 0x0001A0FC
		[Register("addRewardedAdapter", "(Lcom/applovin/mediation/adapter/MaxAdapter;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;Ljava/lang/String;)V", "GetAddRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_Handler")]
		public unsafe virtual void AddRewardedAdapter(IMaxAdapter p0, IMaxRewardedAdapterListener p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("addRewardedAdapter.(Lcom/applovin/mediation/adapter/MaxAdapter;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001BFB4 File Offset: 0x0001A1B4
		private static Delegate GetAddShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Handler()
		{
			if (MediationAdapterRouter.cb_addShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_ == null)
			{
				MediationAdapterRouter.cb_addShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_AddShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_));
			}
			return MediationAdapterRouter.cb_addShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		private static void n_AddShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapter object2 = Java.Lang.Object.GetObject<IMaxAdapter>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddShowingAdapter(object2);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		[Register("addShowingAdapter", "(Lcom/applovin/mediation/adapter/MaxAdapter;)V", "GetAddShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Handler")]
		public unsafe virtual void AddShowingAdapter(IMaxAdapter p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("addShowingAdapter.(Lcom/applovin/mediation/adapter/MaxAdapter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001C064 File Offset: 0x0001A264
		private static Delegate GetGetReward_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_getReward_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_getReward_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MediationAdapterRouter.n_GetReward_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_getReward_Ljava_lang_String_;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001C088 File Offset: 0x0001A288
		private static IntPtr n_GetReward_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetReward(@string));
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		[Register("getReward", "(Ljava/lang/String;)Lcom/applovin/mediation/MaxReward;", "GetGetReward_Ljava_lang_String_Handler")]
		protected unsafe virtual IMaxReward GetReward(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IMaxReward @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMaxReward>(MediationAdapterRouter._members.InstanceMethods.InvokeVirtualObjectMethod("getReward.(Ljava/lang/String;)Lcom/applovin/mediation/MaxReward;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001C11C File Offset: 0x0001A31C
		private static Delegate GetLog_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_log_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_log_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_Log_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_log_Ljava_lang_String_;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0001C140 File Offset: 0x0001A340
		private static void n_Log_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Log(@string);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0001C164 File Offset: 0x0001A364
		[Register("log", "(Ljava/lang/String;)V", "GetLog_Ljava_lang_String_Handler")]
		protected unsafe virtual void Log(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("log.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0001C1C0 File Offset: 0x0001A3C0
		private static Delegate GetLog_Ljava_lang_String_Ljava_lang_Throwable_Handler()
		{
			if (MediationAdapterRouter.cb_log_Ljava_lang_String_Ljava_lang_Throwable_ == null)
			{
				MediationAdapterRouter.cb_log_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_Log_Ljava_lang_String_Ljava_lang_Throwable_));
			}
			return MediationAdapterRouter.cb_log_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
		private static void n_Log_Ljava_lang_String_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Log(@string, object2);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0001C210 File Offset: 0x0001A410
		[Register("log", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		protected unsafe virtual void Log(string p0, Throwable p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("log.(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0001C294 File Offset: 0x0001A494
		private static Delegate GetOnAdClicked_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onAdClicked_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onAdClicked_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnAdClicked_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onAdClicked_Ljava_lang_String_;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
		private static void n_OnAdClicked_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdClicked(@string);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0001C2DC File Offset: 0x0001A4DC
		[Register("onAdClicked", "(Ljava/lang/String;)V", "GetOnAdClicked_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnAdClicked(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdClicked.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0001C338 File Offset: 0x0001A538
		private static Delegate GetOnAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (MediationAdapterRouter.cb_onAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				MediationAdapterRouter.cb_onAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_OnAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return MediationAdapterRouter.cb_onAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0001C35C File Offset: 0x0001A55C
		private static void n_OnAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayFailed(@string, object2);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0001C388 File Offset: 0x0001A588
		[Register("onAdDisplayFailed", "(Ljava/lang/String;Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler")]
		protected unsafe virtual void OnAdDisplayFailed(string p0, MaxAdapterError p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdDisplayFailed.(Ljava/lang/String;Lcom/applovin/mediation/adapter/MaxAdapterError;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0001C40C File Offset: 0x0001A60C
		private static Delegate GetOnAdDisplayed_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onAdDisplayed_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onAdDisplayed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnAdDisplayed_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onAdDisplayed_Ljava_lang_String_;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001C430 File Offset: 0x0001A630
		private static void n_OnAdDisplayed_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayed(@string);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0001C454 File Offset: 0x0001A654
		[Register("onAdDisplayed", "(Ljava/lang/String;)V", "GetOnAdDisplayed_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnAdDisplayed(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdDisplayed.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0001C4B0 File Offset: 0x0001A6B0
		private static Delegate GetOnAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_Handler()
		{
			if (MediationAdapterRouter.cb_onAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_ == null)
			{
				MediationAdapterRouter.cb_onAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_OnAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_));
			}
			return MediationAdapterRouter.cb_onAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
		private static void n_OnAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayed(@string, object2);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0001C500 File Offset: 0x0001A700
		[Register("onAdDisplayed", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetOnAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		protected unsafe virtual void OnAdDisplayed(string p0, Bundle p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdDisplayed.(Ljava/lang/String;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0001C584 File Offset: 0x0001A784
		private static Delegate GetOnAdHidden_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onAdHidden_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onAdHidden_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnAdHidden_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onAdHidden_Ljava_lang_String_;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		private static void n_OnAdHidden_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdHidden(@string);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0001C5CC File Offset: 0x0001A7CC
		[Register("onAdHidden", "(Ljava/lang/String;)V", "GetOnAdHidden_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnAdHidden(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdHidden.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0001C628 File Offset: 0x0001A828
		private static Delegate GetOnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (MediationAdapterRouter.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				MediationAdapterRouter.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return MediationAdapterRouter.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0001C64C File Offset: 0x0001A84C
		private static void n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoadFailed(@string, object2);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0001C678 File Offset: 0x0001A878
		[Register("onAdLoadFailed", "(Ljava/lang/String;Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler")]
		protected unsafe virtual void OnAdLoadFailed(string p0, MaxAdapterError p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdLoadFailed.(Ljava/lang/String;Lcom/applovin/mediation/adapter/MaxAdapterError;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0001C6FC File Offset: 0x0001A8FC
		private static Delegate GetOnAdLoaded_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onAdLoaded_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnAdLoaded_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onAdLoaded_Ljava_lang_String_;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001C720 File Offset: 0x0001A920
		private static void n_OnAdLoaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoaded(@string);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001C744 File Offset: 0x0001A944
		[Register("onAdLoaded", "(Ljava/lang/String;)V", "GetOnAdLoaded_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnAdLoaded(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdLoaded.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		private static Delegate GetOnAdLoaded_Ljava_lang_String_Landroid_os_Bundle_Handler()
		{
			if (MediationAdapterRouter.cb_onAdLoaded_Ljava_lang_String_Landroid_os_Bundle_ == null)
			{
				MediationAdapterRouter.cb_onAdLoaded_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_OnAdLoaded_Ljava_lang_String_Landroid_os_Bundle_));
			}
			return MediationAdapterRouter.cb_onAdLoaded_Ljava_lang_String_Landroid_os_Bundle_;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0001C7C4 File Offset: 0x0001A9C4
		private static void n_OnAdLoaded_Ljava_lang_String_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoaded(@string, object2);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
		[Register("onAdLoaded", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetOnAdLoaded_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		protected unsafe virtual void OnAdLoaded(string p0, Bundle p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdLoaded.(Ljava/lang/String;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0001C874 File Offset: 0x0001AA74
		private static Delegate GetOnAdViewAdCollapsed_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onAdViewAdCollapsed_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onAdViewAdCollapsed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnAdViewAdCollapsed_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onAdViewAdCollapsed_Ljava_lang_String_;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0001C898 File Offset: 0x0001AA98
		private static void n_OnAdViewAdCollapsed_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdCollapsed(@string);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0001C8BC File Offset: 0x0001AABC
		[Register("onAdViewAdCollapsed", "(Ljava/lang/String;)V", "GetOnAdViewAdCollapsed_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnAdViewAdCollapsed(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdViewAdCollapsed.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0001C918 File Offset: 0x0001AB18
		private static Delegate GetOnAdViewAdExpanded_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onAdViewAdExpanded_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onAdViewAdExpanded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnAdViewAdExpanded_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onAdViewAdExpanded_Ljava_lang_String_;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0001C93C File Offset: 0x0001AB3C
		private static void n_OnAdViewAdExpanded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdExpanded(@string);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001C960 File Offset: 0x0001AB60
		[Register("onAdViewAdExpanded", "(Ljava/lang/String;)V", "GetOnAdViewAdExpanded_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnAdViewAdExpanded(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onAdViewAdExpanded.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001C9BC File Offset: 0x0001ABBC
		private static Delegate GetOnRewardedAdVideoCompleted_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onRewardedAdVideoCompleted_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onRewardedAdVideoCompleted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnRewardedAdVideoCompleted_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onRewardedAdVideoCompleted_Ljava_lang_String_;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		private static void n_OnRewardedAdVideoCompleted_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdVideoCompleted(@string);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0001CA04 File Offset: 0x0001AC04
		[Register("onRewardedAdVideoCompleted", "(Ljava/lang/String;)V", "GetOnRewardedAdVideoCompleted_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnRewardedAdVideoCompleted(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onRewardedAdVideoCompleted.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0001CA60 File Offset: 0x0001AC60
		private static Delegate GetOnRewardedAdVideoStarted_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_onRewardedAdVideoStarted_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_onRewardedAdVideoStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterRouter.n_OnRewardedAdVideoStarted_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_onRewardedAdVideoStarted_Ljava_lang_String_;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0001CA84 File Offset: 0x0001AC84
		private static void n_OnRewardedAdVideoStarted_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdVideoStarted(@string);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		[Register("onRewardedAdVideoStarted", "(Ljava/lang/String;)V", "GetOnRewardedAdVideoStarted_Ljava_lang_String_Handler")]
		protected unsafe virtual void OnRewardedAdVideoStarted(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onRewardedAdVideoStarted.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001CB04 File Offset: 0x0001AD04
		private static Delegate GetOnUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_Handler()
		{
			if (MediationAdapterRouter.cb_onUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_ == null)
			{
				MediationAdapterRouter.cb_onUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_OnUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_));
			}
			return MediationAdapterRouter.cb_onUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0001CB28 File Offset: 0x0001AD28
		private static void n_OnUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxReward object2 = Java.Lang.Object.GetObject<IMaxReward>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnUserRewarded(@string, object2);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0001CB54 File Offset: 0x0001AD54
		[Register("onUserRewarded", "(Ljava/lang/String;Lcom/applovin/mediation/MaxReward;)V", "GetOnUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_Handler")]
		protected unsafe virtual void OnUserRewarded(string p0, IMaxReward p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("onUserRewarded.(Ljava/lang/String;Lcom/applovin/mediation/MaxReward;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		private static Delegate GetRemoveAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_removeAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_removeAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_RemoveAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_removeAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001CC00 File Offset: 0x0001AE00
		private static void n_RemoveAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapter object2 = Java.Lang.Object.GetObject<IMaxAdapter>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.RemoveAdapter(object2, @string);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001CC2C File Offset: 0x0001AE2C
		[Register("removeAdapter", "(Lcom/applovin/mediation/adapter/MaxAdapter;Ljava/lang/String;)V", "GetRemoveAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_Handler")]
		public unsafe virtual void RemoveAdapter(IMaxAdapter p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("removeAdapter.(Lcom/applovin/mediation/adapter/MaxAdapter;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		private static Delegate GetShouldAlwaysRewardUser_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_shouldAlwaysRewardUser_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_shouldAlwaysRewardUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MediationAdapterRouter.n_ShouldAlwaysRewardUser_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_shouldAlwaysRewardUser_Ljava_lang_String_;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		private static bool n_ShouldAlwaysRewardUser_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.ShouldAlwaysRewardUser(@string);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0001CCFC File Offset: 0x0001AEFC
		[Register("shouldAlwaysRewardUser", "(Ljava/lang/String;)Z", "GetShouldAlwaysRewardUser_Ljava_lang_String_Handler")]
		protected unsafe virtual bool ShouldAlwaysRewardUser(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = MediationAdapterRouter._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldAlwaysRewardUser.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		private static Delegate GetUpdateAdView_Landroid_view_View_Ljava_lang_String_Handler()
		{
			if (MediationAdapterRouter.cb_updateAdView_Landroid_view_View_Ljava_lang_String_ == null)
			{
				MediationAdapterRouter.cb_updateAdView_Landroid_view_View_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterRouter.n_UpdateAdView_Landroid_view_View_Ljava_lang_String_));
			}
			return MediationAdapterRouter.cb_updateAdView_Landroid_view_View_Ljava_lang_String_;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0001CD80 File Offset: 0x0001AF80
		private static void n_UpdateAdView_Landroid_view_View_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterRouter @object = Java.Lang.Object.GetObject<MediationAdapterRouter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.UpdateAdView(object2, @string);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		[Register("updateAdView", "(Landroid/view/View;Ljava/lang/String;)V", "GetUpdateAdView_Landroid_view_View_Ljava_lang_String_Handler")]
		public unsafe virtual void UpdateAdView(View p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				MediationAdapterRouter._members.InstanceMethods.InvokeVirtualVoidMethod("updateAdView.(Landroid/view/View;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000362 RID: 866
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapters/MediationAdapterRouter", typeof(MediationAdapterRouter));

		// Token: 0x04000363 RID: 867
		private static Delegate cb_addAdViewAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Ljava_lang_String_Landroid_view_View_;

		// Token: 0x04000364 RID: 868
		private static Delegate cb_addInterstitialAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Ljava_lang_String_;

		// Token: 0x04000365 RID: 869
		private static Delegate cb_addRewardedAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Ljava_lang_String_;

		// Token: 0x04000366 RID: 870
		private static Delegate cb_addShowingAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_;

		// Token: 0x04000367 RID: 871
		private static Delegate cb_getReward_Ljava_lang_String_;

		// Token: 0x04000368 RID: 872
		private static Delegate cb_log_Ljava_lang_String_;

		// Token: 0x04000369 RID: 873
		private static Delegate cb_log_Ljava_lang_String_Ljava_lang_Throwable_;

		// Token: 0x0400036A RID: 874
		private static Delegate cb_onAdClicked_Ljava_lang_String_;

		// Token: 0x0400036B RID: 875
		private static Delegate cb_onAdDisplayFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x0400036C RID: 876
		private static Delegate cb_onAdDisplayed_Ljava_lang_String_;

		// Token: 0x0400036D RID: 877
		private static Delegate cb_onAdDisplayed_Ljava_lang_String_Landroid_os_Bundle_;

		// Token: 0x0400036E RID: 878
		private static Delegate cb_onAdHidden_Ljava_lang_String_;

		// Token: 0x0400036F RID: 879
		private static Delegate cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000370 RID: 880
		private static Delegate cb_onAdLoaded_Ljava_lang_String_;

		// Token: 0x04000371 RID: 881
		private static Delegate cb_onAdLoaded_Ljava_lang_String_Landroid_os_Bundle_;

		// Token: 0x04000372 RID: 882
		private static Delegate cb_onAdViewAdCollapsed_Ljava_lang_String_;

		// Token: 0x04000373 RID: 883
		private static Delegate cb_onAdViewAdExpanded_Ljava_lang_String_;

		// Token: 0x04000374 RID: 884
		private static Delegate cb_onRewardedAdVideoCompleted_Ljava_lang_String_;

		// Token: 0x04000375 RID: 885
		private static Delegate cb_onRewardedAdVideoStarted_Ljava_lang_String_;

		// Token: 0x04000376 RID: 886
		private static Delegate cb_onUserRewarded_Ljava_lang_String_Lcom_applovin_mediation_MaxReward_;

		// Token: 0x04000377 RID: 887
		private static Delegate cb_removeAdapter_Lcom_applovin_mediation_adapter_MaxAdapter_Ljava_lang_String_;

		// Token: 0x04000378 RID: 888
		private static Delegate cb_shouldAlwaysRewardUser_Ljava_lang_String_;

		// Token: 0x04000379 RID: 889
		private static Delegate cb_updateAdView_Landroid_view_View_Ljava_lang_String_;
	}
}
