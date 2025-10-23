using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Com.Iab.Omid.Library.Applovin.Publisher;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000039 RID: 57
	[Register("com/iab/omid/library/applovin/adsession/AdSession", DoNotGenerateAcw = true)]
	public abstract class AdSession : Java.Lang.Object
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00003800 File Offset: 0x00001A00
		internal static IntPtr class_ref
		{
			get
			{
				return AdSession._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00003824 File Offset: 0x00001A24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdSession._members;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000382C File Offset: 0x00001A2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdSession._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00003850 File Offset: 0x00001A50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSession._members.ManagedPeerType;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AdSession(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000385C File Offset: 0x00001A5C
		[Register(".ctor", "()V", "")]
		public AdSession() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdSession._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdSession._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000038CA File Offset: 0x00001ACA
		private static Delegate GetGetAdSessionIdHandler()
		{
			if (AdSession.cb_getAdSessionId == null)
			{
				AdSession.cb_getAdSessionId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSession.n_GetAdSessionId));
			}
			return AdSession.cb_getAdSessionId;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000038EE File Offset: 0x00001AEE
		private static IntPtr n_GetAdSessionId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdSessionId);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600014B RID: 331
		public abstract string AdSessionId { [Register("getAdSessionId", "()Ljava/lang/String;", "GetGetAdSessionIdHandler")] get; }

		// Token: 0x0600014C RID: 332 RVA: 0x00003902 File Offset: 0x00001B02
		private static Delegate GetGetAdSessionStatePublisherHandler()
		{
			if (AdSession.cb_getAdSessionStatePublisher == null)
			{
				AdSession.cb_getAdSessionStatePublisher = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSession.n_GetAdSessionStatePublisher));
			}
			return AdSession.cb_getAdSessionStatePublisher;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003926 File Offset: 0x00001B26
		private static IntPtr n_GetAdSessionStatePublisher(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdSessionStatePublisher);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600014E RID: 334
		public abstract AdSessionStatePublisher AdSessionStatePublisher { [Register("getAdSessionStatePublisher", "()Lcom/iab/omid/library/applovin/publisher/AdSessionStatePublisher;", "GetGetAdSessionStatePublisherHandler")] get; }

		// Token: 0x0600014F RID: 335 RVA: 0x0000393A File Offset: 0x00001B3A
		private static Delegate GetAddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_Handler()
		{
			if (AdSession.cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_ == null)
			{
				AdSession.cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AdSession.n_AddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_));
			}
			return AdSession.cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003960 File Offset: 0x00001B60
		private static void n_AddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			FriendlyObstructionPurpose object3 = Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.AddFriendlyObstruction(object2, object3, @string);
		}

		// Token: 0x06000151 RID: 337
		[Register("addFriendlyObstruction", "(Landroid/view/View;Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;Ljava/lang/String;)V", "GetAddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_Handler")]
		public abstract void AddFriendlyObstruction(View p0, FriendlyObstructionPurpose p1, string p2);

		// Token: 0x06000152 RID: 338 RVA: 0x00003998 File Offset: 0x00001B98
		[Register("createAdSession", "(Lcom/iab/omid/library/applovin/adsession/AdSessionConfiguration;Lcom/iab/omid/library/applovin/adsession/AdSessionContext;)Lcom/iab/omid/library/applovin/adsession/AdSession;", "")]
		public unsafe static AdSession CreateAdSession(AdSessionConfiguration p0, AdSessionContext p1)
		{
			AdSession @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<AdSession>(AdSession._members.StaticMethods.InvokeObjectMethod("createAdSession.(Lcom/iab/omid/library/applovin/adsession/AdSessionConfiguration;Lcom/iab/omid/library/applovin/adsession/AdSessionContext;)Lcom/iab/omid/library/applovin/adsession/AdSession;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003A34 File Offset: 0x00001C34
		private static Delegate GetError_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_Handler()
		{
			if (AdSession.cb_error_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_ == null)
			{
				AdSession.cb_error_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AdSession.n_Error_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_));
			}
			return AdSession.cb_error_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00003A58 File Offset: 0x00001C58
		private static void n_Error_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ErrorType object2 = Java.Lang.Object.GetObject<ErrorType>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Error(object2, @string);
		}

		// Token: 0x06000155 RID: 341
		[Register("error", "(Lcom/iab/omid/library/applovin/adsession/ErrorType;Ljava/lang/String;)V", "GetError_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_Handler")]
		public abstract void Error(ErrorType p0, string p1);

		// Token: 0x06000156 RID: 342 RVA: 0x00003A84 File Offset: 0x00001C84
		private static Delegate GetFinishHandler()
		{
			if (AdSession.cb_finish == null)
			{
				AdSession.cb_finish = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSession.n_Finish));
			}
			return AdSession.cb_finish;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00003AA8 File Offset: 0x00001CA8
		private static void n_Finish(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Finish();
		}

		// Token: 0x06000158 RID: 344
		[Register("finish", "()V", "GetFinishHandler")]
		public abstract void Finish();

		// Token: 0x06000159 RID: 345 RVA: 0x00003AB7 File Offset: 0x00001CB7
		private static Delegate GetRegisterAdView_Landroid_view_View_Handler()
		{
			if (AdSession.cb_registerAdView_Landroid_view_View_ == null)
			{
				AdSession.cb_registerAdView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSession.n_RegisterAdView_Landroid_view_View_));
			}
			return AdSession.cb_registerAdView_Landroid_view_View_;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00003ADC File Offset: 0x00001CDC
		private static void n_RegisterAdView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RegisterAdView(object2);
		}

		// Token: 0x0600015B RID: 347
		[Register("registerAdView", "(Landroid/view/View;)V", "GetRegisterAdView_Landroid_view_View_Handler")]
		public abstract void RegisterAdView(View p0);

		// Token: 0x0600015C RID: 348 RVA: 0x00003AFF File Offset: 0x00001CFF
		private static Delegate GetRemoveAllFriendlyObstructionsHandler()
		{
			if (AdSession.cb_removeAllFriendlyObstructions == null)
			{
				AdSession.cb_removeAllFriendlyObstructions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSession.n_RemoveAllFriendlyObstructions));
			}
			return AdSession.cb_removeAllFriendlyObstructions;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003B23 File Offset: 0x00001D23
		private static void n_RemoveAllFriendlyObstructions(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAllFriendlyObstructions();
		}

		// Token: 0x0600015E RID: 350
		[Register("removeAllFriendlyObstructions", "()V", "GetRemoveAllFriendlyObstructionsHandler")]
		public abstract void RemoveAllFriendlyObstructions();

		// Token: 0x0600015F RID: 351 RVA: 0x00003B32 File Offset: 0x00001D32
		private static Delegate GetRemoveFriendlyObstruction_Landroid_view_View_Handler()
		{
			if (AdSession.cb_removeFriendlyObstruction_Landroid_view_View_ == null)
			{
				AdSession.cb_removeFriendlyObstruction_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSession.n_RemoveFriendlyObstruction_Landroid_view_View_));
			}
			return AdSession.cb_removeFriendlyObstruction_Landroid_view_View_;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00003B58 File Offset: 0x00001D58
		private static void n_RemoveFriendlyObstruction_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveFriendlyObstruction(object2);
		}

		// Token: 0x06000161 RID: 353
		[Register("removeFriendlyObstruction", "(Landroid/view/View;)V", "GetRemoveFriendlyObstruction_Landroid_view_View_Handler")]
		public abstract void RemoveFriendlyObstruction(View p0);

		// Token: 0x06000162 RID: 354 RVA: 0x00003B7B File Offset: 0x00001D7B
		private static Delegate GetSetPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_Handler()
		{
			if (AdSession.cb_setPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_ == null)
			{
				AdSession.cb_setPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSession.n_SetPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_));
			}
			return AdSession.cb_setPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003BA0 File Offset: 0x00001DA0
		private static void n_SetPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPossibleObstructionListener object2 = Java.Lang.Object.GetObject<IPossibleObstructionListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetPossibleObstructionListener(object2);
		}

		// Token: 0x06000164 RID: 356
		[Register("setPossibleObstructionListener", "(Lcom/iab/omid/library/applovin/adsession/PossibleObstructionListener;)V", "GetSetPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_Handler")]
		public abstract void SetPossibleObstructionListener(IPossibleObstructionListener p0);

		// Token: 0x06000165 RID: 357 RVA: 0x00003BC3 File Offset: 0x00001DC3
		private static Delegate GetStartHandler()
		{
			if (AdSession.cb_start == null)
			{
				AdSession.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSession.n_Start));
			}
			return AdSession.cb_start;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00003BE7 File Offset: 0x00001DE7
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x06000167 RID: 359
		[Register("start", "()V", "GetStartHandler")]
		public abstract void Start();

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000168 RID: 360 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// (remove) Token: 0x06000169 RID: 361 RVA: 0x00003C44 File Offset: 0x00001E44
		public event EventHandler<PossibleObstructionEventArgs> PossibleObstruction
		{
			add
			{
				EventHelper.AddEventHandler<IPossibleObstructionListener, IPossibleObstructionListenerImplementor>(ref this.weak_implementor_SetPossibleObstructionListener, new Func<IPossibleObstructionListenerImplementor>(this.__CreateIPossibleObstructionListenerImplementor), new Action<IPossibleObstructionListener>(this.SetPossibleObstructionListener), delegate(IPossibleObstructionListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PossibleObstructionEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IPossibleObstructionListener, IPossibleObstructionListenerImplementor>(ref this.weak_implementor_SetPossibleObstructionListener, new Func<IPossibleObstructionListenerImplementor, bool>(IPossibleObstructionListenerImplementor.__IsEmpty), delegate(IPossibleObstructionListener __v)
				{
					this.SetPossibleObstructionListener(null);
				}, delegate(IPossibleObstructionListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PossibleObstructionEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00003C94 File Offset: 0x00001E94
		private IPossibleObstructionListenerImplementor __CreateIPossibleObstructionListenerImplementor()
		{
			return new IPossibleObstructionListenerImplementor(this);
		}

		// Token: 0x04000030 RID: 48
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/AdSession", typeof(AdSession));

		// Token: 0x04000031 RID: 49
		private static Delegate cb_getAdSessionId;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_getAdSessionStatePublisher;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_error_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_finish;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_registerAdView_Landroid_view_View_;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_removeAllFriendlyObstructions;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_removeFriendlyObstruction_Landroid_view_View_;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_setPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_start;

		// Token: 0x0400003B RID: 59
		private WeakReference weak_implementor_SetPossibleObstructionListener;
	}
}
