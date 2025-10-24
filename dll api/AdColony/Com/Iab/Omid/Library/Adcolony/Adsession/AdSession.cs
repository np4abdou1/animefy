using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Com.Iab.Omid.Library.Adcolony.Publisher;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000024 RID: 36
	[Register("com/iab/omid/library/adcolony/adsession/AdSession", DoNotGenerateAcw = true)]
	public abstract class AdSession : Java.Lang.Object
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00003738 File Offset: 0x00001938
		internal static IntPtr class_ref
		{
			get
			{
				return AdSession._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000375C File Offset: 0x0000195C
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
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00003764 File Offset: 0x00001964
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
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00003788 File Offset: 0x00001988
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSession._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002128 File Offset: 0x00000328
		protected AdSession(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003794 File Offset: 0x00001994
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

		// Token: 0x060000F2 RID: 242 RVA: 0x00003802 File Offset: 0x00001A02
		private static Delegate GetGetAdSessionIdHandler()
		{
			if (AdSession.cb_getAdSessionId == null)
			{
				AdSession.cb_getAdSessionId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSession.n_GetAdSessionId));
			}
			return AdSession.cb_getAdSessionId;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003826 File Offset: 0x00001A26
		private static IntPtr n_GetAdSessionId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdSessionId);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000F4 RID: 244
		public abstract string AdSessionId { [Register("getAdSessionId", "()Ljava/lang/String;", "GetGetAdSessionIdHandler")] get; }

		// Token: 0x060000F5 RID: 245 RVA: 0x0000383A File Offset: 0x00001A3A
		private static Delegate GetGetAdSessionStatePublisherHandler()
		{
			if (AdSession.cb_getAdSessionStatePublisher == null)
			{
				AdSession.cb_getAdSessionStatePublisher = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSession.n_GetAdSessionStatePublisher));
			}
			return AdSession.cb_getAdSessionStatePublisher;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000385E File Offset: 0x00001A5E
		private static IntPtr n_GetAdSessionStatePublisher(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdSessionStatePublisher);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F7 RID: 247
		public abstract AdSessionStatePublisher AdSessionStatePublisher { [Register("getAdSessionStatePublisher", "()Lcom/iab/omid/library/adcolony/publisher/AdSessionStatePublisher;", "GetGetAdSessionStatePublisherHandler")] get; }

		// Token: 0x060000F8 RID: 248 RVA: 0x00003872 File Offset: 0x00001A72
		private static Delegate GetAddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_Handler()
		{
			if (AdSession.cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_ == null)
			{
				AdSession.cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AdSession.n_AddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_));
			}
			return AdSession.cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003898 File Offset: 0x00001A98
		private static void n_AddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			FriendlyObstructionPurpose object3 = Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.AddFriendlyObstruction(object2, object3, @string);
		}

		// Token: 0x060000FA RID: 250
		[Register("addFriendlyObstruction", "(Landroid/view/View;Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;Ljava/lang/String;)V", "GetAddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_Handler")]
		public abstract void AddFriendlyObstruction(View p0, FriendlyObstructionPurpose p1, string p2);

		// Token: 0x060000FB RID: 251 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Register("createAdSession", "(Lcom/iab/omid/library/adcolony/adsession/AdSessionConfiguration;Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;)Lcom/iab/omid/library/adcolony/adsession/AdSession;", "")]
		public unsafe static AdSession CreateAdSession(AdSessionConfiguration p0, AdSessionContext p1)
		{
			AdSession @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<AdSession>(AdSession._members.StaticMethods.InvokeObjectMethod("createAdSession.(Lcom/iab/omid/library/adcolony/adsession/AdSessionConfiguration;Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;)Lcom/iab/omid/library/adcolony/adsession/AdSession;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000396C File Offset: 0x00001B6C
		private static Delegate GetError_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_Handler()
		{
			if (AdSession.cb_error_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_ == null)
			{
				AdSession.cb_error_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AdSession.n_Error_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_));
			}
			return AdSession.cb_error_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003990 File Offset: 0x00001B90
		private static void n_Error_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ErrorType object2 = Java.Lang.Object.GetObject<ErrorType>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Error(object2, @string);
		}

		// Token: 0x060000FE RID: 254
		[Register("error", "(Lcom/iab/omid/library/adcolony/adsession/ErrorType;Ljava/lang/String;)V", "GetError_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_Handler")]
		public abstract void Error(ErrorType p0, string p1);

		// Token: 0x060000FF RID: 255 RVA: 0x000039BC File Offset: 0x00001BBC
		private static Delegate GetFinishHandler()
		{
			if (AdSession.cb_finish == null)
			{
				AdSession.cb_finish = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSession.n_Finish));
			}
			return AdSession.cb_finish;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000039E0 File Offset: 0x00001BE0
		private static void n_Finish(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Finish();
		}

		// Token: 0x06000101 RID: 257
		[Register("finish", "()V", "GetFinishHandler")]
		public abstract void Finish();

		// Token: 0x06000102 RID: 258 RVA: 0x000039EF File Offset: 0x00001BEF
		private static Delegate GetRegisterAdView_Landroid_view_View_Handler()
		{
			if (AdSession.cb_registerAdView_Landroid_view_View_ == null)
			{
				AdSession.cb_registerAdView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSession.n_RegisterAdView_Landroid_view_View_));
			}
			return AdSession.cb_registerAdView_Landroid_view_View_;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003A14 File Offset: 0x00001C14
		private static void n_RegisterAdView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RegisterAdView(object2);
		}

		// Token: 0x06000104 RID: 260
		[Register("registerAdView", "(Landroid/view/View;)V", "GetRegisterAdView_Landroid_view_View_Handler")]
		public abstract void RegisterAdView(View p0);

		// Token: 0x06000105 RID: 261 RVA: 0x00003A37 File Offset: 0x00001C37
		private static Delegate GetRemoveAllFriendlyObstructionsHandler()
		{
			if (AdSession.cb_removeAllFriendlyObstructions == null)
			{
				AdSession.cb_removeAllFriendlyObstructions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSession.n_RemoveAllFriendlyObstructions));
			}
			return AdSession.cb_removeAllFriendlyObstructions;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003A5B File Offset: 0x00001C5B
		private static void n_RemoveAllFriendlyObstructions(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAllFriendlyObstructions();
		}

		// Token: 0x06000107 RID: 263
		[Register("removeAllFriendlyObstructions", "()V", "GetRemoveAllFriendlyObstructionsHandler")]
		public abstract void RemoveAllFriendlyObstructions();

		// Token: 0x06000108 RID: 264 RVA: 0x00003A6A File Offset: 0x00001C6A
		private static Delegate GetRemoveFriendlyObstruction_Landroid_view_View_Handler()
		{
			if (AdSession.cb_removeFriendlyObstruction_Landroid_view_View_ == null)
			{
				AdSession.cb_removeFriendlyObstruction_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSession.n_RemoveFriendlyObstruction_Landroid_view_View_));
			}
			return AdSession.cb_removeFriendlyObstruction_Landroid_view_View_;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003A90 File Offset: 0x00001C90
		private static void n_RemoveFriendlyObstruction_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveFriendlyObstruction(object2);
		}

		// Token: 0x0600010A RID: 266
		[Register("removeFriendlyObstruction", "(Landroid/view/View;)V", "GetRemoveFriendlyObstruction_Landroid_view_View_Handler")]
		public abstract void RemoveFriendlyObstruction(View p0);

		// Token: 0x0600010B RID: 267 RVA: 0x00003AB3 File Offset: 0x00001CB3
		private static Delegate GetSetPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_Handler()
		{
			if (AdSession.cb_setPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_ == null)
			{
				AdSession.cb_setPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSession.n_SetPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_));
			}
			return AdSession.cb_setPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003AD8 File Offset: 0x00001CD8
		private static void n_SetPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSession @object = Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPossibleObstructionListener object2 = Java.Lang.Object.GetObject<IPossibleObstructionListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetPossibleObstructionListener(object2);
		}

		// Token: 0x0600010D RID: 269
		[Register("setPossibleObstructionListener", "(Lcom/iab/omid/library/adcolony/adsession/PossibleObstructionListener;)V", "GetSetPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_Handler")]
		public abstract void SetPossibleObstructionListener(IPossibleObstructionListener p0);

		// Token: 0x0600010E RID: 270 RVA: 0x00003AFB File Offset: 0x00001CFB
		private static Delegate GetStartHandler()
		{
			if (AdSession.cb_start == null)
			{
				AdSession.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSession.n_Start));
			}
			return AdSession.cb_start;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00003B1F File Offset: 0x00001D1F
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSession>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x06000110 RID: 272
		[Register("start", "()V", "GetStartHandler")]
		public abstract void Start();

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000111 RID: 273 RVA: 0x00003B30 File Offset: 0x00001D30
		// (remove) Token: 0x06000112 RID: 274 RVA: 0x00003B7C File Offset: 0x00001D7C
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

		// Token: 0x06000113 RID: 275 RVA: 0x00003BCC File Offset: 0x00001DCC
		private IPossibleObstructionListenerImplementor __CreateIPossibleObstructionListenerImplementor()
		{
			return new IPossibleObstructionListenerImplementor(this);
		}

		// Token: 0x0400002D RID: 45
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/AdSession", typeof(AdSession));

		// Token: 0x0400002E RID: 46
		private static Delegate cb_getAdSessionId;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_getAdSessionStatePublisher;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_addFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_error_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_finish;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_registerAdView_Landroid_view_View_;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_removeAllFriendlyObstructions;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_removeFriendlyObstruction_Landroid_view_View_;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_setPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_start;

		// Token: 0x04000038 RID: 56
		private WeakReference weak_implementor_SetPossibleObstructionListener;
	}
}
