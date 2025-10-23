using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000041 RID: 65
	[Register("com/adcolony/sdk/AdColonyAppOptions", DoNotGenerateAcw = true)]
	public class AdColonyAppOptions : Java.Lang.Object
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00008360 File Offset: 0x00006560
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyAppOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00008384 File Offset: 0x00006584
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyAppOptions._members;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000838C File Offset: 0x0000658C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyAppOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000083B0 File Offset: 0x000065B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyAppOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyAppOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000083BC File Offset: 0x000065BC
		[Register(".ctor", "()V", "")]
		public AdColonyAppOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColonyAppOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonyAppOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000842A File Offset: 0x0000662A
		private static Delegate GetGetAppOrientationHandler()
		{
			if (AdColonyAppOptions.cb_getAppOrientation == null)
			{
				AdColonyAppOptions.cb_getAppOrientation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyAppOptions.n_GetAppOrientation));
			}
			return AdColonyAppOptions.cb_getAppOrientation;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000844E File Offset: 0x0000664E
		private static int n_GetAppOrientation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AppOrientation;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000845D File Offset: 0x0000665D
		public virtual int AppOrientation
		{
			[Register("getAppOrientation", "()I", "GetGetAppOrientationHandler")]
			get
			{
				return AdColonyAppOptions._members.InstanceMethods.InvokeVirtualInt32Method("getAppOrientation.()I", this, null);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008476 File Offset: 0x00006676
		private static Delegate GetGetAppVersionHandler()
		{
			if (AdColonyAppOptions.cb_getAppVersion == null)
			{
				AdColonyAppOptions.cb_getAppVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAppOptions.n_GetAppVersion));
			}
			return AdColonyAppOptions.cb_getAppVersion;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000849A File Offset: 0x0000669A
		private static IntPtr n_GetAppVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AppVersion);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000084B0 File Offset: 0x000066B0
		public virtual string AppVersion
		{
			[Register("getAppVersion", "()Ljava/lang/String;", "GetGetAppVersionHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getAppVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000084E2 File Offset: 0x000066E2
		[Obsolete]
		private static Delegate GetGetGDPRConsentStringHandler()
		{
			if (AdColonyAppOptions.cb_getGDPRConsentString == null)
			{
				AdColonyAppOptions.cb_getGDPRConsentString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAppOptions.n_GetGDPRConsentString));
			}
			return AdColonyAppOptions.cb_getGDPRConsentString;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00008506 File Offset: 0x00006706
		[Obsolete]
		private static IntPtr n_GetGDPRConsentString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GDPRConsentString);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000851C File Offset: 0x0000671C
		[Obsolete("deprecated")]
		public virtual string GDPRConsentString
		{
			[Register("getGDPRConsentString", "()Ljava/lang/String;", "GetGetGDPRConsentStringHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getGDPRConsentString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000854E File Offset: 0x0000674E
		[Obsolete]
		private static Delegate GetGetGDPRRequiredHandler()
		{
			if (AdColonyAppOptions.cb_getGDPRRequired == null)
			{
				AdColonyAppOptions.cb_getGDPRRequired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyAppOptions.n_GetGDPRRequired));
			}
			return AdColonyAppOptions.cb_getGDPRRequired;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00008572 File Offset: 0x00006772
		[Obsolete]
		private static bool n_GetGDPRRequired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GDPRRequired;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00008581 File Offset: 0x00006781
		[Obsolete("deprecated")]
		public virtual bool GDPRRequired
		{
			[Register("getGDPRRequired", "()Z", "GetGetGDPRRequiredHandler")]
			get
			{
				return AdColonyAppOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("getGDPRRequired.()Z", this, null);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000859A File Offset: 0x0000679A
		private static Delegate GetGetIsChildDirectedAppHandler()
		{
			if (AdColonyAppOptions.cb_getIsChildDirectedApp == null)
			{
				AdColonyAppOptions.cb_getIsChildDirectedApp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyAppOptions.n_GetIsChildDirectedApp));
			}
			return AdColonyAppOptions.cb_getIsChildDirectedApp;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000085BE File Offset: 0x000067BE
		private static bool n_GetIsChildDirectedApp(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsChildDirectedApp;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000085CD File Offset: 0x000067CD
		public virtual bool IsChildDirectedApp
		{
			[Register("getIsChildDirectedApp", "()Z", "GetGetIsChildDirectedAppHandler")]
			get
			{
				return AdColonyAppOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("getIsChildDirectedApp.()Z", this, null);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000085E6 File Offset: 0x000067E6
		private static Delegate GetGetKeepScreenOnHandler()
		{
			if (AdColonyAppOptions.cb_getKeepScreenOn == null)
			{
				AdColonyAppOptions.cb_getKeepScreenOn = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyAppOptions.n_GetKeepScreenOn));
			}
			return AdColonyAppOptions.cb_getKeepScreenOn;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000860A File Offset: 0x0000680A
		private static bool n_GetKeepScreenOn(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).KeepScreenOn;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00008619 File Offset: 0x00006819
		public virtual bool KeepScreenOn
		{
			[Register("getKeepScreenOn", "()Z", "GetGetKeepScreenOnHandler")]
			get
			{
				return AdColonyAppOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("getKeepScreenOn.()Z", this, null);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00008632 File Offset: 0x00006832
		private static Delegate GetGetMediationInfoHandler()
		{
			if (AdColonyAppOptions.cb_getMediationInfo == null)
			{
				AdColonyAppOptions.cb_getMediationInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAppOptions.n_GetMediationInfo));
			}
			return AdColonyAppOptions.cb_getMediationInfo;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00008656 File Offset: 0x00006856
		private static IntPtr n_GetMediationInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediationInfo);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000866C File Offset: 0x0000686C
		public virtual JSONObject MediationInfo
		{
			[Register("getMediationInfo", "()Lorg/json/JSONObject;", "GetGetMediationInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getMediationInfo.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000869E File Offset: 0x0000689E
		private static Delegate GetGetMultiWindowEnabledHandler()
		{
			if (AdColonyAppOptions.cb_getMultiWindowEnabled == null)
			{
				AdColonyAppOptions.cb_getMultiWindowEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyAppOptions.n_GetMultiWindowEnabled));
			}
			return AdColonyAppOptions.cb_getMultiWindowEnabled;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000086C2 File Offset: 0x000068C2
		private static bool n_GetMultiWindowEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MultiWindowEnabled;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000086D1 File Offset: 0x000068D1
		public virtual bool MultiWindowEnabled
		{
			[Register("getMultiWindowEnabled", "()Z", "GetGetMultiWindowEnabledHandler")]
			get
			{
				return AdColonyAppOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("getMultiWindowEnabled.()Z", this, null);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000086EA File Offset: 0x000068EA
		private static Delegate GetGetOriginStoreHandler()
		{
			if (AdColonyAppOptions.cb_getOriginStore == null)
			{
				AdColonyAppOptions.cb_getOriginStore = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAppOptions.n_GetOriginStore));
			}
			return AdColonyAppOptions.cb_getOriginStore;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000870E File Offset: 0x0000690E
		private static IntPtr n_GetOriginStore(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OriginStore);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00008724 File Offset: 0x00006924
		public virtual string OriginStore
		{
			[Register("getOriginStore", "()Ljava/lang/String;", "GetGetOriginStoreHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getOriginStore.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008756 File Offset: 0x00006956
		private static Delegate GetGetPluginInfoHandler()
		{
			if (AdColonyAppOptions.cb_getPluginInfo == null)
			{
				AdColonyAppOptions.cb_getPluginInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAppOptions.n_GetPluginInfo));
			}
			return AdColonyAppOptions.cb_getPluginInfo;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000877A File Offset: 0x0000697A
		private static IntPtr n_GetPluginInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PluginInfo);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00008790 File Offset: 0x00006990
		public virtual JSONObject PluginInfo
		{
			[Register("getPluginInfo", "()Lorg/json/JSONObject;", "GetGetPluginInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getPluginInfo.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000087C2 File Offset: 0x000069C2
		[Obsolete]
		private static Delegate GetGetRequestedAdOrientationHandler()
		{
			if (AdColonyAppOptions.cb_getRequestedAdOrientation == null)
			{
				AdColonyAppOptions.cb_getRequestedAdOrientation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyAppOptions.n_GetRequestedAdOrientation));
			}
			return AdColonyAppOptions.cb_getRequestedAdOrientation;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000087E6 File Offset: 0x000069E6
		[Obsolete]
		private static int n_GetRequestedAdOrientation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestedAdOrientation;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000087F5 File Offset: 0x000069F5
		[Obsolete("deprecated")]
		public virtual int RequestedAdOrientation
		{
			[Register("getRequestedAdOrientation", "()I", "GetGetRequestedAdOrientationHandler")]
			get
			{
				return AdColonyAppOptions._members.InstanceMethods.InvokeVirtualInt32Method("getRequestedAdOrientation.()I", this, null);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000880E File Offset: 0x00006A0E
		private static Delegate GetGetTestModeEnabledHandler()
		{
			if (AdColonyAppOptions.cb_getTestModeEnabled == null)
			{
				AdColonyAppOptions.cb_getTestModeEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyAppOptions.n_GetTestModeEnabled));
			}
			return AdColonyAppOptions.cb_getTestModeEnabled;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00008832 File Offset: 0x00006A32
		private static bool n_GetTestModeEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TestModeEnabled;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00008841 File Offset: 0x00006A41
		public virtual bool TestModeEnabled
		{
			[Register("getTestModeEnabled", "()Z", "GetGetTestModeEnabledHandler")]
			get
			{
				return AdColonyAppOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("getTestModeEnabled.()Z", this, null);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000885A File Offset: 0x00006A5A
		private static Delegate GetGetUserIDHandler()
		{
			if (AdColonyAppOptions.cb_getUserID == null)
			{
				AdColonyAppOptions.cb_getUserID = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAppOptions.n_GetUserID));
			}
			return AdColonyAppOptions.cb_getUserID;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000887E File Offset: 0x00006A7E
		private static IntPtr n_GetUserID(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserID);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00008894 File Offset: 0x00006A94
		public virtual string UserID
		{
			[Register("getUserID", "()Ljava/lang/String;", "GetGetUserIDHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getUserID.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000088C6 File Offset: 0x00006AC6
		[Obsolete]
		private static Delegate GetGetUserMetadataHandler()
		{
			if (AdColonyAppOptions.cb_getUserMetadata == null)
			{
				AdColonyAppOptions.cb_getUserMetadata = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAppOptions.n_GetUserMetadata));
			}
			return AdColonyAppOptions.cb_getUserMetadata;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000088EA File Offset: 0x00006AEA
		[Obsolete]
		private static IntPtr n_GetUserMetadata(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserMetadata);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00008900 File Offset: 0x00006B00
		[Obsolete("deprecated")]
		public virtual AdColonyUserMetadata UserMetadata
		{
			[Register("getUserMetadata", "()Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetGetUserMetadataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getUserMetadata.()Lcom/adcolony/sdk/AdColonyUserMetadata;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00008934 File Offset: 0x00006B34
		[Register("getMoPubAppOptions", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "")]
		public unsafe static AdColonyAppOptions GetMoPubAppOptions(string clientOptions)
		{
			IntPtr intPtr = JNIEnv.NewString(clientOptions);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.StaticMethods.InvokeObjectMethod("getMoPubAppOptions.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000089A0 File Offset: 0x00006BA0
		private static Delegate GetGetOption_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_getOption_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_getOption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAppOptions.n_GetOption_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_getOption_Ljava_lang_String_;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000089C4 File Offset: 0x00006BC4
		private static IntPtr n_GetOption_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOption(@string));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000089EC File Offset: 0x00006BEC
		[Register("getOption", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetOption_Ljava_lang_String_Handler")]
		public unsafe virtual Java.Lang.Object GetOption(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getOption.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00008A58 File Offset: 0x00006C58
		private static Delegate GetGetPrivacyConsentString_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_getPrivacyConsentString_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_getPrivacyConsentString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAppOptions.n_GetPrivacyConsentString_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_getPrivacyConsentString_Ljava_lang_String_;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00008A7C File Offset: 0x00006C7C
		private static IntPtr n_GetPrivacyConsentString_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetPrivacyConsentString(@string));
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00008AA4 File Offset: 0x00006CA4
		[Register("getPrivacyConsentString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetPrivacyConsentString_Ljava_lang_String_Handler")]
		public unsafe virtual string GetPrivacyConsentString(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivacyConsentString.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00008B10 File Offset: 0x00006D10
		private static Delegate GetGetPrivacyFrameworkRequired_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_getPrivacyFrameworkRequired_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_getPrivacyFrameworkRequired_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AdColonyAppOptions.n_GetPrivacyFrameworkRequired_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_getPrivacyFrameworkRequired_Ljava_lang_String_;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00008B34 File Offset: 0x00006D34
		private static bool n_GetPrivacyFrameworkRequired_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			return @object.GetPrivacyFrameworkRequired(@string);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008B58 File Offset: 0x00006D58
		[Register("getPrivacyFrameworkRequired", "(Ljava/lang/String;)Z", "GetGetPrivacyFrameworkRequired_Ljava_lang_String_Handler")]
		public unsafe virtual bool GetPrivacyFrameworkRequired(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AdColonyAppOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("getPrivacyFrameworkRequired.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00008BB8 File Offset: 0x00006DB8
		private static Delegate GetIsPrivacyFrameworkRequiredSet_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_isPrivacyFrameworkRequiredSet_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_isPrivacyFrameworkRequiredSet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AdColonyAppOptions.n_IsPrivacyFrameworkRequiredSet_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_isPrivacyFrameworkRequiredSet_Ljava_lang_String_;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00008BDC File Offset: 0x00006DDC
		private static bool n_IsPrivacyFrameworkRequiredSet_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			return @object.IsPrivacyFrameworkRequiredSet(@string);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00008C00 File Offset: 0x00006E00
		[Register("isPrivacyFrameworkRequiredSet", "(Ljava/lang/String;)Z", "GetIsPrivacyFrameworkRequiredSet_Ljava_lang_String_Handler")]
		public unsafe virtual bool IsPrivacyFrameworkRequiredSet(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AdColonyAppOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("isPrivacyFrameworkRequiredSet.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00008C60 File Offset: 0x00006E60
		private static Delegate GetSetAppOrientation_IHandler()
		{
			if (AdColonyAppOptions.cb_setAppOrientation_I == null)
			{
				AdColonyAppOptions.cb_setAppOrientation_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AdColonyAppOptions.n_SetAppOrientation_I));
			}
			return AdColonyAppOptions.cb_setAppOrientation_I;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00008C84 File Offset: 0x00006E84
		private static IntPtr n_SetAppOrientation_I(IntPtr jnienv, IntPtr native__this, int orientation)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAppOrientation(orientation));
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00008C9C File Offset: 0x00006E9C
		[Register("setAppOrientation", "(I)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetAppOrientation_IHandler")]
		public unsafe virtual AdColonyAppOptions SetAppOrientation(int orientation)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(orientation);
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setAppOrientation.(I)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00008CE5 File Offset: 0x00006EE5
		private static Delegate GetSetAppVersion_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setAppVersion_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setAppVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAppOptions.n_SetAppVersion_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setAppVersion_Ljava_lang_String_;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00008D0C File Offset: 0x00006F0C
		private static IntPtr n_SetAppVersion_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_app_version)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_app_version, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetAppVersion(@string));
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00008D34 File Offset: 0x00006F34
		[Register("setAppVersion", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetAppVersion_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetAppVersion(string app_version)
		{
			IntPtr intPtr = JNIEnv.NewString(app_version);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setAppVersion.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00008DA0 File Offset: 0x00006FA0
		[Obsolete]
		private static Delegate GetSetGDPRConsentString_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setGDPRConsentString_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setGDPRConsentString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAppOptions.n_SetGDPRConsentString_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setGDPRConsentString_Ljava_lang_String_;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00008DC4 File Offset: 0x00006FC4
		[Obsolete]
		private static IntPtr n_SetGDPRConsentString_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_consentString)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_consentString, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetGDPRConsentString(@string));
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00008DEC File Offset: 0x00006FEC
		[Obsolete("deprecated")]
		[Register("setGDPRConsentString", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetGDPRConsentString_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetGDPRConsentString(string consentString)
		{
			IntPtr intPtr = JNIEnv.NewString(consentString);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setGDPRConsentString.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00008E58 File Offset: 0x00007058
		[Obsolete]
		private static Delegate GetSetGDPRRequired_ZHandler()
		{
			if (AdColonyAppOptions.cb_setGDPRRequired_Z == null)
			{
				AdColonyAppOptions.cb_setGDPRRequired_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AdColonyAppOptions.n_SetGDPRRequired_Z));
			}
			return AdColonyAppOptions.cb_setGDPRRequired_Z;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00008E7C File Offset: 0x0000707C
		[Obsolete]
		private static IntPtr n_SetGDPRRequired_Z(IntPtr jnienv, IntPtr native__this, bool required)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGDPRRequired(required));
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00008E94 File Offset: 0x00007094
		[Obsolete("deprecated")]
		[Register("setGDPRRequired", "(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetGDPRRequired_ZHandler")]
		public unsafe virtual AdColonyAppOptions SetGDPRRequired(bool required)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(required);
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setGDPRRequired.(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00008EDD File Offset: 0x000070DD
		private static Delegate GetSetIsChildDirectedApp_ZHandler()
		{
			if (AdColonyAppOptions.cb_setIsChildDirectedApp_Z == null)
			{
				AdColonyAppOptions.cb_setIsChildDirectedApp_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AdColonyAppOptions.n_SetIsChildDirectedApp_Z));
			}
			return AdColonyAppOptions.cb_setIsChildDirectedApp_Z;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00008F01 File Offset: 0x00007101
		private static IntPtr n_SetIsChildDirectedApp_Z(IntPtr jnienv, IntPtr native__this, bool isChildDirectedApp)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIsChildDirectedApp(isChildDirectedApp));
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00008F18 File Offset: 0x00007118
		[Register("setIsChildDirectedApp", "(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetIsChildDirectedApp_ZHandler")]
		public unsafe virtual AdColonyAppOptions SetIsChildDirectedApp(bool isChildDirectedApp)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isChildDirectedApp);
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setIsChildDirectedApp.(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00008F61 File Offset: 0x00007161
		private static Delegate GetSetKeepScreenOn_ZHandler()
		{
			if (AdColonyAppOptions.cb_setKeepScreenOn_Z == null)
			{
				AdColonyAppOptions.cb_setKeepScreenOn_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AdColonyAppOptions.n_SetKeepScreenOn_Z));
			}
			return AdColonyAppOptions.cb_setKeepScreenOn_Z;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00008F85 File Offset: 0x00007185
		private static IntPtr n_SetKeepScreenOn_Z(IntPtr jnienv, IntPtr native__this, bool keepScreenOn)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetKeepScreenOn(keepScreenOn));
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00008F9C File Offset: 0x0000719C
		[Register("setKeepScreenOn", "(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetKeepScreenOn_ZHandler")]
		public unsafe virtual AdColonyAppOptions SetKeepScreenOn(bool keepScreenOn)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(keepScreenOn);
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setKeepScreenOn.(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00008FE5 File Offset: 0x000071E5
		private static Delegate GetSetMediationNetwork_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setMediationNetwork_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setMediationNetwork_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdColonyAppOptions.n_SetMediationNetwork_Ljava_lang_String_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setMediationNetwork_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000900C File Offset: 0x0000720C
		private static IntPtr n_SetMediationNetwork_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_version)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_version, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetMediationNetwork(@string, string2));
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00009040 File Offset: 0x00007240
		[Register("setMediationNetwork", "(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetMediationNetwork_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetMediationNetwork(string name, string version)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(version);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setMediationNetwork.(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000090D0 File Offset: 0x000072D0
		private static Delegate GetSetMultiWindowEnabled_ZHandler()
		{
			if (AdColonyAppOptions.cb_setMultiWindowEnabled_Z == null)
			{
				AdColonyAppOptions.cb_setMultiWindowEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AdColonyAppOptions.n_SetMultiWindowEnabled_Z));
			}
			return AdColonyAppOptions.cb_setMultiWindowEnabled_Z;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000090F4 File Offset: 0x000072F4
		private static IntPtr n_SetMultiWindowEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMultiWindowEnabled(enabled));
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000910C File Offset: 0x0000730C
		[Register("setMultiWindowEnabled", "(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetMultiWindowEnabled_ZHandler")]
		public unsafe virtual AdColonyAppOptions SetMultiWindowEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setMultiWindowEnabled.(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00009155 File Offset: 0x00007355
		private static Delegate GetSetOption_Ljava_lang_String_ZHandler()
		{
			if (AdColonyAppOptions.cb_setOption_Ljava_lang_String_Z == null)
			{
				AdColonyAppOptions.cb_setOption_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(AdColonyAppOptions.n_SetOption_Ljava_lang_String_Z));
			}
			return AdColonyAppOptions.cb_setOption_Ljava_lang_String_Z;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000917C File Offset: 0x0000737C
		private static IntPtr n_SetOption_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool value)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOption(@string, value));
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000091A8 File Offset: 0x000073A8
		[Register("setOption", "(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetOption_Ljava_lang_String_ZHandler")]
		public unsafe virtual AdColonyAppOptions SetOption(string key, bool value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setOption.(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00009228 File Offset: 0x00007428
		private static Delegate GetSetOption_Ljava_lang_String_DHandler()
		{
			if (AdColonyAppOptions.cb_setOption_Ljava_lang_String_D == null)
			{
				AdColonyAppOptions.cb_setOption_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLD_L(AdColonyAppOptions.n_SetOption_Ljava_lang_String_D));
			}
			return AdColonyAppOptions.cb_setOption_Ljava_lang_String_D;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000924C File Offset: 0x0000744C
		private static IntPtr n_SetOption_Ljava_lang_String_D(IntPtr jnienv, IntPtr native__this, IntPtr native_key, double value)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOption(@string, value));
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00009278 File Offset: 0x00007478
		[Register("setOption", "(Ljava/lang/String;D)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetOption_Ljava_lang_String_DHandler")]
		public unsafe virtual AdColonyAppOptions SetOption(string key, double value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setOption.(Ljava/lang/String;D)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000092F8 File Offset: 0x000074F8
		private static Delegate GetSetOption_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setOption_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setOption_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdColonyAppOptions.n_SetOption_Ljava_lang_String_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setOption_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000931C File Offset: 0x0000751C
		private static IntPtr n_SetOption_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOption(@string, string2));
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00009350 File Offset: 0x00007550
		[Register("setOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetOption_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetOption(string key, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setOption.(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000093E0 File Offset: 0x000075E0
		private static Delegate GetSetOriginStore_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setOriginStore_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setOriginStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAppOptions.n_SetOriginStore_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setOriginStore_Ljava_lang_String_;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00009404 File Offset: 0x00007604
		private static IntPtr n_SetOriginStore_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_origin_store)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_origin_store, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOriginStore(@string));
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000942C File Offset: 0x0000762C
		[Register("setOriginStore", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetOriginStore_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetOriginStore(string origin_store)
		{
			IntPtr intPtr = JNIEnv.NewString(origin_store);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setOriginStore.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00009498 File Offset: 0x00007698
		private static Delegate GetSetPlugin_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setPlugin_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setPlugin_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdColonyAppOptions.n_SetPlugin_Ljava_lang_String_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setPlugin_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000094BC File Offset: 0x000076BC
		private static IntPtr n_SetPlugin_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_version)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_version, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetPlugin(@string, string2));
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000094F0 File Offset: 0x000076F0
		[Register("setPlugin", "(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetPlugin_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetPlugin(string name, string version)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(version);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setPlugin.(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00009580 File Offset: 0x00007780
		private static Delegate GetSetPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdColonyAppOptions.n_SetPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000095A4 File Offset: 0x000077A4
		private static IntPtr n_SetPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_consentString)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_consentString, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetPrivacyConsentString(@string, string2));
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000095D8 File Offset: 0x000077D8
		[Register("setPrivacyConsentString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetPrivacyConsentString(string type, string consentString)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(consentString);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setPrivacyConsentString.(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00009668 File Offset: 0x00007868
		private static Delegate GetSetPrivacyFrameworkRequired_Ljava_lang_String_ZHandler()
		{
			if (AdColonyAppOptions.cb_setPrivacyFrameworkRequired_Ljava_lang_String_Z == null)
			{
				AdColonyAppOptions.cb_setPrivacyFrameworkRequired_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(AdColonyAppOptions.n_SetPrivacyFrameworkRequired_Ljava_lang_String_Z));
			}
			return AdColonyAppOptions.cb_setPrivacyFrameworkRequired_Ljava_lang_String_Z;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000968C File Offset: 0x0000788C
		private static IntPtr n_SetPrivacyFrameworkRequired_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_type, bool required)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetPrivacyFrameworkRequired(@string, required));
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000096B8 File Offset: 0x000078B8
		[Register("setPrivacyFrameworkRequired", "(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetPrivacyFrameworkRequired_Ljava_lang_String_ZHandler")]
		public unsafe virtual AdColonyAppOptions SetPrivacyFrameworkRequired(string type, bool required)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(required);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setPrivacyFrameworkRequired.(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00009738 File Offset: 0x00007938
		[Obsolete]
		private static Delegate GetSetRequestedAdOrientation_IHandler()
		{
			if (AdColonyAppOptions.cb_setRequestedAdOrientation_I == null)
			{
				AdColonyAppOptions.cb_setRequestedAdOrientation_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AdColonyAppOptions.n_SetRequestedAdOrientation_I));
			}
			return AdColonyAppOptions.cb_setRequestedAdOrientation_I;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000975C File Offset: 0x0000795C
		[Obsolete]
		private static IntPtr n_SetRequestedAdOrientation_I(IntPtr jnienv, IntPtr native__this, int orientation)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetRequestedAdOrientation(orientation));
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00009774 File Offset: 0x00007974
		[Obsolete("deprecated")]
		[Register("setRequestedAdOrientation", "(I)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetRequestedAdOrientation_IHandler")]
		public unsafe virtual AdColonyAppOptions SetRequestedAdOrientation(int orientation)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(orientation);
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setRequestedAdOrientation.(I)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000097BD File Offset: 0x000079BD
		private static Delegate GetSetTestModeEnabled_ZHandler()
		{
			if (AdColonyAppOptions.cb_setTestModeEnabled_Z == null)
			{
				AdColonyAppOptions.cb_setTestModeEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AdColonyAppOptions.n_SetTestModeEnabled_Z));
			}
			return AdColonyAppOptions.cb_setTestModeEnabled_Z;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000097E1 File Offset: 0x000079E1
		private static IntPtr n_SetTestModeEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTestModeEnabled(enabled));
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000097F8 File Offset: 0x000079F8
		[Register("setTestModeEnabled", "(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetTestModeEnabled_ZHandler")]
		public unsafe virtual AdColonyAppOptions SetTestModeEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setTestModeEnabled.(Z)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00009841 File Offset: 0x00007A41
		private static Delegate GetSetUserID_Ljava_lang_String_Handler()
		{
			if (AdColonyAppOptions.cb_setUserID_Ljava_lang_String_ == null)
			{
				AdColonyAppOptions.cb_setUserID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAppOptions.n_SetUserID_Ljava_lang_String_));
			}
			return AdColonyAppOptions.cb_setUserID_Ljava_lang_String_;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00009868 File Offset: 0x00007A68
		private static IntPtr n_SetUserID_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_user_id)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_user_id, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserID(@string));
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00009890 File Offset: 0x00007A90
		[Register("setUserID", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetUserID_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAppOptions SetUserID(string user_id)
		{
			IntPtr intPtr = JNIEnv.NewString(user_id);
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setUserID.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000098FC File Offset: 0x00007AFC
		[Obsolete]
		private static Delegate GetSetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_Handler()
		{
			if (AdColonyAppOptions.cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_ == null)
			{
				AdColonyAppOptions.cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAppOptions.n_SetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_));
			}
			return AdColonyAppOptions.cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009920 File Offset: 0x00007B20
		[Obsolete]
		private static IntPtr n_SetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_(IntPtr jnienv, IntPtr native__this, IntPtr native_metadata)
		{
			AdColonyAppOptions @object = Java.Lang.Object.GetObject<AdColonyAppOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyUserMetadata object2 = Java.Lang.Object.GetObject<AdColonyUserMetadata>(native_metadata, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserMetadata(object2));
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00009948 File Offset: 0x00007B48
		[Obsolete("deprecated")]
		[Register("setUserMetadata", "(Lcom/adcolony/sdk/AdColonyUserMetadata;)Lcom/adcolony/sdk/AdColonyAppOptions;", "GetSetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_Handler")]
		public unsafe virtual AdColonyAppOptions SetUserMetadata(AdColonyUserMetadata metadata)
		{
			AdColonyAppOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((metadata == null) ? IntPtr.Zero : metadata.Handle);
				@object = Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColonyAppOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setUserMetadata.(Lcom/adcolony/sdk/AdColonyUserMetadata;)Lcom/adcolony/sdk/AdColonyAppOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(metadata);
			}
			return @object;
		}

		// Token: 0x04000074 RID: 116
		[Register("ADMARVEL")]
		public const string Admarvel = "AdMarvel";

		// Token: 0x04000075 RID: 117
		[Register("ADMOB")]
		public const string Admob = "AdMob";

		// Token: 0x04000076 RID: 118
		[Register("ADOBEAIR")]
		public const string Adobeair = "Adobe AIR";

		// Token: 0x04000077 RID: 119
		[Register("AERSERVE")]
		public const string Aerserve = "AerServe";

		// Token: 0x04000078 RID: 120
		[Register("ALL")]
		[Obsolete("deprecated")]
		public const int All = 2;

		// Token: 0x04000079 RID: 121
		[Register("APPODEAL")]
		public const string Appodeal = "Appodeal";

		// Token: 0x0400007A RID: 122
		[Register("CCPA")]
		public const string Ccpa = "CCPA";

		// Token: 0x0400007B RID: 123
		[Register("COCOS2DX")]
		public const string Cocos2dx = "Cocos2d-x";

		// Token: 0x0400007C RID: 124
		[Register("COPPA")]
		public const string Coppa = "COPPA";

		// Token: 0x0400007D RID: 125
		[Register("CORONA")]
		public const string Corona = "Corona";

		// Token: 0x0400007E RID: 126
		[Register("FUSEPOWERED")]
		public const string Fusepowered = "Fuse Powered";

		// Token: 0x0400007F RID: 127
		[Register("FYBER")]
		public const string Fyber = "Fyber";

		// Token: 0x04000080 RID: 128
		[Register("GDPR")]
		public const string Gdpr = "GDPR";

		// Token: 0x04000081 RID: 129
		[Register("IRONSOURCE")]
		public const string Ironsource = "ironSource";

		// Token: 0x04000082 RID: 130
		[Register("LANDSCAPE")]
		[Obsolete("deprecated")]
		public const int Landscape = 1;

		// Token: 0x04000083 RID: 131
		[Register("MOPUB")]
		public const string Mopub = "MoPub";

		// Token: 0x04000084 RID: 132
		[Register("PORTRAIT")]
		[Obsolete("deprecated")]
		public const int Portrait = 0;

		// Token: 0x04000085 RID: 133
		[Register("SENSOR")]
		[Obsolete("deprecated")]
		public const int Sensor = 2;

		// Token: 0x04000086 RID: 134
		[Register("UNITY")]
		public const string Unity = "Unity";

		// Token: 0x04000087 RID: 135
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyAppOptions", typeof(AdColonyAppOptions));

		// Token: 0x04000088 RID: 136
		private static Delegate cb_getAppOrientation;

		// Token: 0x04000089 RID: 137
		private static Delegate cb_getAppVersion;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_getGDPRConsentString;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_getGDPRRequired;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_getIsChildDirectedApp;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_getKeepScreenOn;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_getMediationInfo;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_getMultiWindowEnabled;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_getOriginStore;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_getPluginInfo;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_getRequestedAdOrientation;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_getTestModeEnabled;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_getUserID;

		// Token: 0x04000095 RID: 149
		private static Delegate cb_getUserMetadata;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_getOption_Ljava_lang_String_;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_getPrivacyConsentString_Ljava_lang_String_;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_getPrivacyFrameworkRequired_Ljava_lang_String_;

		// Token: 0x04000099 RID: 153
		private static Delegate cb_isPrivacyFrameworkRequiredSet_Ljava_lang_String_;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_setAppOrientation_I;

		// Token: 0x0400009B RID: 155
		private static Delegate cb_setAppVersion_Ljava_lang_String_;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_setGDPRConsentString_Ljava_lang_String_;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_setGDPRRequired_Z;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_setIsChildDirectedApp_Z;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_setKeepScreenOn_Z;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_setMediationNetwork_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_setMultiWindowEnabled_Z;

		// Token: 0x040000A2 RID: 162
		private static Delegate cb_setOption_Ljava_lang_String_Z;

		// Token: 0x040000A3 RID: 163
		private static Delegate cb_setOption_Ljava_lang_String_D;

		// Token: 0x040000A4 RID: 164
		private static Delegate cb_setOption_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040000A5 RID: 165
		private static Delegate cb_setOriginStore_Ljava_lang_String_;

		// Token: 0x040000A6 RID: 166
		private static Delegate cb_setPlugin_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_setPrivacyConsentString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_setPrivacyFrameworkRequired_Ljava_lang_String_Z;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_setRequestedAdOrientation_I;

		// Token: 0x040000AA RID: 170
		private static Delegate cb_setTestModeEnabled_Z;

		// Token: 0x040000AB RID: 171
		private static Delegate cb_setUserID_Ljava_lang_String_;

		// Token: 0x040000AC RID: 172
		private static Delegate cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_;
	}
}
