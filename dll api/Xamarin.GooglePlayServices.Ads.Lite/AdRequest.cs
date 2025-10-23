using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Android.Gms.Ads
{
	// Token: 0x02000011 RID: 17
	[Register("com/google/android/gms/ads/AdRequest", DoNotGenerateAcw = true)]
	public class AdRequest : Java.Lang.Object
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002ABC File Offset: 0x00000CBC
		internal static IntPtr class_ref
		{
			get
			{
				return AdRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002AE0 File Offset: 0x00000CE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdRequest._members;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002AE8 File Offset: 0x00000CE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002B0C File Offset: 0x00000D0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdRequest._members.ManagedPeerType;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000020AC File Offset: 0x000002AC
		protected AdRequest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002B18 File Offset: 0x00000D18
		[Register(".ctor", "(Lcom/google/android/gms/ads/AdRequest$Builder;)V", "")]
		protected unsafe AdRequest(AdRequest.Builder p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AdRequest._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/ads/AdRequest$Builder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdRequest._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/ads/AdRequest$Builder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private static Delegate GetGetAdStringHandler()
		{
			if (AdRequest.cb_getAdString == null)
			{
				AdRequest.cb_getAdString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdRequest.n_GetAdString));
			}
			return AdRequest.cb_getAdString;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002BEC File Offset: 0x00000DEC
		private static IntPtr n_GetAdString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdString);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002C00 File Offset: 0x00000E00
		public virtual string AdString
		{
			[Register("getAdString", "()Ljava/lang/String;", "GetGetAdStringHandler")]
			get
			{
				return JNIEnv.GetString(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getAdString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002C32 File Offset: 0x00000E32
		private static Delegate GetGetContentUrlHandler()
		{
			if (AdRequest.cb_getContentUrl == null)
			{
				AdRequest.cb_getContentUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdRequest.n_GetContentUrl));
			}
			return AdRequest.cb_getContentUrl;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002C56 File Offset: 0x00000E56
		private static IntPtr n_GetContentUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentUrl);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002C6C File Offset: 0x00000E6C
		public virtual string ContentUrl
		{
			[Register("getContentUrl", "()Ljava/lang/String;", "GetGetContentUrlHandler")]
			get
			{
				return JNIEnv.GetString(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getContentUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002C9E File Offset: 0x00000E9E
		private static Delegate GetGetCustomTargetingHandler()
		{
			if (AdRequest.cb_getCustomTargeting == null)
			{
				AdRequest.cb_getCustomTargeting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdRequest.n_GetCustomTargeting));
			}
			return AdRequest.cb_getCustomTargeting;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002CC2 File Offset: 0x00000EC2
		private static IntPtr n_GetCustomTargeting(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomTargeting);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public virtual Bundle CustomTargeting
		{
			[Register("getCustomTargeting", "()Landroid/os/Bundle;", "GetGetCustomTargetingHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getCustomTargeting.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002D0A File Offset: 0x00000F0A
		private static Delegate GetGetKeywordsHandler()
		{
			if (AdRequest.cb_getKeywords == null)
			{
				AdRequest.cb_getKeywords = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdRequest.n_GetKeywords));
			}
			return AdRequest.cb_getKeywords;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002D2E File Offset: 0x00000F2E
		private static IntPtr n_GetKeywords(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Keywords);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002D44 File Offset: 0x00000F44
		public virtual ICollection<string> Keywords
		{
			[Register("getKeywords", "()Ljava/util/Set;", "GetGetKeywordsHandler")]
			get
			{
				return JavaSet<string>.FromJniHandle(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getKeywords.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002D76 File Offset: 0x00000F76
		private static Delegate GetGetNeighboringContentUrlsHandler()
		{
			if (AdRequest.cb_getNeighboringContentUrls == null)
			{
				AdRequest.cb_getNeighboringContentUrls = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdRequest.n_GetNeighboringContentUrls));
			}
			return AdRequest.cb_getNeighboringContentUrls;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002D9A File Offset: 0x00000F9A
		private static IntPtr n_GetNeighboringContentUrls(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NeighboringContentUrls);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002DB0 File Offset: 0x00000FB0
		public virtual IList<string> NeighboringContentUrls
		{
			[Register("getNeighboringContentUrls", "()Ljava/util/List;", "GetGetNeighboringContentUrlsHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getNeighboringContentUrls.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002DE2 File Offset: 0x00000FE2
		private static Delegate GetGetRequestAgentHandler()
		{
			if (AdRequest.cb_getRequestAgent == null)
			{
				AdRequest.cb_getRequestAgent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdRequest.n_GetRequestAgent));
			}
			return AdRequest.cb_getRequestAgent;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002E06 File Offset: 0x00001006
		private static IntPtr n_GetRequestAgent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestAgent);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002E1C File Offset: 0x0000101C
		public virtual string RequestAgent
		{
			[Register("getRequestAgent", "()Ljava/lang/String;", "GetGetRequestAgentHandler")]
			get
			{
				return JNIEnv.GetString(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestAgent.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002E4E File Offset: 0x0000104E
		private static Delegate GetGetCustomEventExtrasBundle_Ljava_lang_Class_Handler()
		{
			if (AdRequest.cb_getCustomEventExtrasBundle_Ljava_lang_Class_ == null)
			{
				AdRequest.cb_getCustomEventExtrasBundle_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdRequest.n_GetCustomEventExtrasBundle_Ljava_lang_Class_));
			}
			return AdRequest.cb_getCustomEventExtrasBundle_Ljava_lang_Class_;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002E74 File Offset: 0x00001074
		private static IntPtr n_GetCustomEventExtrasBundle_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterClass)
		{
			AdRequest @object = Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_adapterClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetCustomEventExtrasBundle(object2));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002E9C File Offset: 0x0000109C
		[Register("getCustomEventExtrasBundle", "(Ljava/lang/Class;)Landroid/os/Bundle;", "GetGetCustomEventExtrasBundle_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T extends com.google.android.gms.ads.mediation.customevent.CustomEvent"
		})]
		public unsafe virtual Bundle GetCustomEventExtrasBundle(Class adapterClass)
		{
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapterClass == null) ? IntPtr.Zero : adapterClass.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getCustomEventExtrasBundle.(Ljava/lang/Class;)Landroid/os/Bundle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(adapterClass);
			}
			return @object;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002F10 File Offset: 0x00001110
		private static Delegate GetGetNetworkExtrasBundle_Ljava_lang_Class_Handler()
		{
			if (AdRequest.cb_getNetworkExtrasBundle_Ljava_lang_Class_ == null)
			{
				AdRequest.cb_getNetworkExtrasBundle_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdRequest.n_GetNetworkExtrasBundle_Ljava_lang_Class_));
			}
			return AdRequest.cb_getNetworkExtrasBundle_Ljava_lang_Class_;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002F34 File Offset: 0x00001134
		private static IntPtr n_GetNetworkExtrasBundle_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterClass)
		{
			AdRequest @object = Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_adapterClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetNetworkExtrasBundle(object2));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002F5C File Offset: 0x0000115C
		[Register("getNetworkExtrasBundle", "(Ljava/lang/Class;)Landroid/os/Bundle;", "GetGetNetworkExtrasBundle_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T extends com.google.android.gms.ads.mediation.MediationExtrasReceiver"
		})]
		public unsafe virtual Bundle GetNetworkExtrasBundle(Class adapterClass)
		{
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapterClass == null) ? IntPtr.Zero : adapterClass.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(AdRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getNetworkExtrasBundle.(Ljava/lang/Class;)Landroid/os/Bundle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(adapterClass);
			}
			return @object;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002FD0 File Offset: 0x000011D0
		private static Delegate GetIsTestDevice_Landroid_content_Context_Handler()
		{
			if (AdRequest.cb_isTestDevice_Landroid_content_Context_ == null)
			{
				AdRequest.cb_isTestDevice_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AdRequest.n_IsTestDevice_Landroid_content_Context_));
			}
			return AdRequest.cb_isTestDevice_Landroid_content_Context_;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002FF4 File Offset: 0x000011F4
		private static bool n_IsTestDevice_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			AdRequest @object = Java.Lang.Object.GetObject<AdRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return @object.IsTestDevice(object2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003018 File Offset: 0x00001218
		[Register("isTestDevice", "(Landroid/content/Context;)Z", "GetIsTestDevice_Landroid_content_Context_Handler")]
		public unsafe virtual bool IsTestDevice(Context context)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = AdRequest._members.InstanceMethods.InvokeVirtualBooleanMethod("isTestDevice.(Landroid/content/Context;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x0400000D RID: 13
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdRequest", typeof(AdRequest));

		// Token: 0x0400000E RID: 14
		private static Delegate cb_getAdString;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_getContentUrl;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_getCustomTargeting;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_getKeywords;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_getNeighboringContentUrls;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_getRequestAgent;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_getCustomEventExtrasBundle_Ljava_lang_Class_;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_getNetworkExtrasBundle_Ljava_lang_Class_;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_isTestDevice_Landroid_content_Context_;

		// Token: 0x02000012 RID: 18
		[Register("com/google/android/gms/ads/AdRequest$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000089 RID: 137 RVA: 0x0000309C File Offset: 0x0000129C
			internal static IntPtr class_ref
			{
				get
				{
					return AdRequest.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600008A RID: 138 RVA: 0x000030C0 File Offset: 0x000012C0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AdRequest.Builder._members;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600008B RID: 139 RVA: 0x000030C8 File Offset: 0x000012C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AdRequest.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600008C RID: 140 RVA: 0x000030EC File Offset: 0x000012EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AdRequest.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000020AC File Offset: 0x000002AC
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600008E RID: 142 RVA: 0x000030F8 File Offset: 0x000012F8
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(AdRequest.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				AdRequest.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00003166 File Offset: 0x00001366
			private static Delegate GetAddCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_Handler()
			{
				if (AdRequest.Builder.cb_addCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_ == null)
				{
					AdRequest.Builder.cb_addCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdRequest.Builder.n_AddCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_));
				}
				return AdRequest.Builder.cb_addCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_;
			}

			// Token: 0x06000090 RID: 144 RVA: 0x0000318C File Offset: 0x0000138C
			private static IntPtr n_AddCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterClass, IntPtr native_customEventExtras)
			{
				AdRequest.Builder @object = Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Class object2 = Java.Lang.Object.GetObject<Class>(native_adapterClass, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_customEventExtras, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddCustomEventExtrasBundle(object2, object3));
			}

			// Token: 0x06000091 RID: 145 RVA: 0x000031C0 File Offset: 0x000013C0
			[Register("addCustomEventExtrasBundle", "(Ljava/lang/Class;Landroid/os/Bundle;)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetAddCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_Handler")]
			public unsafe virtual AdRequest.Builder AddCustomEventExtrasBundle(Class adapterClass, Bundle customEventExtras)
			{
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((adapterClass == null) ? IntPtr.Zero : adapterClass.Handle);
					ptr[1] = new JniArgumentValue((customEventExtras == null) ? IntPtr.Zero : customEventExtras.Handle);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addCustomEventExtrasBundle.(Ljava/lang/Class;Landroid/os/Bundle;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(adapterClass);
					GC.KeepAlive(customEventExtras);
				}
				return @object;
			}

			// Token: 0x06000092 RID: 146 RVA: 0x0000325C File Offset: 0x0000145C
			private static Delegate GetAddKeyword_Ljava_lang_String_Handler()
			{
				if (AdRequest.Builder.cb_addKeyword_Ljava_lang_String_ == null)
				{
					AdRequest.Builder.cb_addKeyword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdRequest.Builder.n_AddKeyword_Ljava_lang_String_));
				}
				return AdRequest.Builder.cb_addKeyword_Ljava_lang_String_;
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00003280 File Offset: 0x00001480
			private static IntPtr n_AddKeyword_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_keyword)
			{
				AdRequest.Builder @object = Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_keyword, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddKeyword(@string));
			}

			// Token: 0x06000094 RID: 148 RVA: 0x000032A8 File Offset: 0x000014A8
			[Register("addKeyword", "(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetAddKeyword_Ljava_lang_String_Handler")]
			public unsafe virtual AdRequest.Builder AddKeyword(string keyword)
			{
				IntPtr intPtr = JNIEnv.NewString(keyword);
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addKeyword.(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00003314 File Offset: 0x00001514
			private static Delegate GetAddNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_Handler()
			{
				if (AdRequest.Builder.cb_addNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_ == null)
				{
					AdRequest.Builder.cb_addNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdRequest.Builder.n_AddNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_));
				}
				return AdRequest.Builder.cb_addNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_;
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00003338 File Offset: 0x00001538
			private static IntPtr n_AddNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterClass, IntPtr native_networkExtras)
			{
				AdRequest.Builder @object = Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Class object2 = Java.Lang.Object.GetObject<Class>(native_adapterClass, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_networkExtras, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddNetworkExtrasBundle(object2, object3));
			}

			// Token: 0x06000097 RID: 151 RVA: 0x0000336C File Offset: 0x0000156C
			[Register("addNetworkExtrasBundle", "(Ljava/lang/Class;Landroid/os/Bundle;)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetAddNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_Handler")]
			public unsafe virtual AdRequest.Builder AddNetworkExtrasBundle(Class adapterClass, Bundle networkExtras)
			{
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((adapterClass == null) ? IntPtr.Zero : adapterClass.Handle);
					ptr[1] = new JniArgumentValue((networkExtras == null) ? IntPtr.Zero : networkExtras.Handle);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addNetworkExtrasBundle.(Ljava/lang/Class;Landroid/os/Bundle;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(adapterClass);
					GC.KeepAlive(networkExtras);
				}
				return @object;
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00003408 File Offset: 0x00001608
			private static Delegate GetBuildHandler()
			{
				if (AdRequest.Builder.cb_build == null)
				{
					AdRequest.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdRequest.Builder.n_Build));
				}
				return AdRequest.Builder.cb_build;
			}

			// Token: 0x06000099 RID: 153 RVA: 0x0000342C File Offset: 0x0000162C
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00003440 File Offset: 0x00001640
			[Register("build", "()Lcom/google/android/gms/ads/AdRequest;", "GetBuildHandler")]
			public virtual AdRequest Build()
			{
				return Java.Lang.Object.GetObject<AdRequest>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/google/android/gms/ads/AdRequest;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00003472 File Offset: 0x00001672
			private static Delegate GetSetAdString_Ljava_lang_String_Handler()
			{
				if (AdRequest.Builder.cb_setAdString_Ljava_lang_String_ == null)
				{
					AdRequest.Builder.cb_setAdString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdRequest.Builder.n_SetAdString_Ljava_lang_String_));
				}
				return AdRequest.Builder.cb_setAdString_Ljava_lang_String_;
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00003498 File Offset: 0x00001698
			private static IntPtr n_SetAdString_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_adString)
			{
				AdRequest.Builder @object = Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_adString, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetAdString(@string));
			}

			// Token: 0x0600009D RID: 157 RVA: 0x000034C0 File Offset: 0x000016C0
			[Register("setAdString", "(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetSetAdString_Ljava_lang_String_Handler")]
			public unsafe virtual AdRequest.Builder SetAdString(string adString)
			{
				IntPtr intPtr = JNIEnv.NewString(adString);
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAdString.(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600009E RID: 158 RVA: 0x0000352C File Offset: 0x0000172C
			private static Delegate GetSetContentUrl_Ljava_lang_String_Handler()
			{
				if (AdRequest.Builder.cb_setContentUrl_Ljava_lang_String_ == null)
				{
					AdRequest.Builder.cb_setContentUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdRequest.Builder.n_SetContentUrl_Ljava_lang_String_));
				}
				return AdRequest.Builder.cb_setContentUrl_Ljava_lang_String_;
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00003550 File Offset: 0x00001750
			private static IntPtr n_SetContentUrl_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentUrl)
			{
				AdRequest.Builder @object = Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_contentUrl, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentUrl(@string));
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00003578 File Offset: 0x00001778
			[Register("setContentUrl", "(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetSetContentUrl_Ljava_lang_String_Handler")]
			public unsafe virtual AdRequest.Builder SetContentUrl(string contentUrl)
			{
				IntPtr intPtr = JNIEnv.NewString(contentUrl);
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setContentUrl.(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x000035E4 File Offset: 0x000017E4
			private static Delegate GetSetHttpTimeoutMillis_IHandler()
			{
				if (AdRequest.Builder.cb_setHttpTimeoutMillis_I == null)
				{
					AdRequest.Builder.cb_setHttpTimeoutMillis_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AdRequest.Builder.n_SetHttpTimeoutMillis_I));
				}
				return AdRequest.Builder.cb_setHttpTimeoutMillis_I;
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00003608 File Offset: 0x00001808
			private static IntPtr n_SetHttpTimeoutMillis_I(IntPtr jnienv, IntPtr native__this, int httpTimeoutMillis)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHttpTimeoutMillis(httpTimeoutMillis));
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00003620 File Offset: 0x00001820
			[Register("setHttpTimeoutMillis", "(I)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetSetHttpTimeoutMillis_IHandler")]
			public unsafe virtual AdRequest.Builder SetHttpTimeoutMillis(int httpTimeoutMillis)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(httpTimeoutMillis);
				return Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setHttpTimeoutMillis.(I)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00003669 File Offset: 0x00001869
			private static Delegate GetSetNeighboringContentUrls_Ljava_util_List_Handler()
			{
				if (AdRequest.Builder.cb_setNeighboringContentUrls_Ljava_util_List_ == null)
				{
					AdRequest.Builder.cb_setNeighboringContentUrls_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdRequest.Builder.n_SetNeighboringContentUrls_Ljava_util_List_));
				}
				return AdRequest.Builder.cb_setNeighboringContentUrls_Ljava_util_List_;
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00003690 File Offset: 0x00001890
			private static IntPtr n_SetNeighboringContentUrls_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_neighboringContentUrls)
			{
				AdRequest.Builder @object = Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IList<string> neighboringContentUrls = JavaList<string>.FromJniHandle(native_neighboringContentUrls, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNeighboringContentUrls(neighboringContentUrls));
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x000036B8 File Offset: 0x000018B8
			[Register("setNeighboringContentUrls", "(Ljava/util/List;)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetSetNeighboringContentUrls_Ljava_util_List_Handler")]
			public unsafe virtual AdRequest.Builder SetNeighboringContentUrls(IList<string> neighboringContentUrls)
			{
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(neighboringContentUrls);
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNeighboringContentUrls.(Ljava/util/List;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(neighboringContentUrls);
				}
				return @object;
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x0000372C File Offset: 0x0000192C
			private static Delegate GetSetRequestAgent_Ljava_lang_String_Handler()
			{
				if (AdRequest.Builder.cb_setRequestAgent_Ljava_lang_String_ == null)
				{
					AdRequest.Builder.cb_setRequestAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdRequest.Builder.n_SetRequestAgent_Ljava_lang_String_));
				}
				return AdRequest.Builder.cb_setRequestAgent_Ljava_lang_String_;
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00003750 File Offset: 0x00001950
			private static IntPtr n_SetRequestAgent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestAgent)
			{
				AdRequest.Builder @object = Java.Lang.Object.GetObject<AdRequest.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_requestAgent, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetRequestAgent(@string));
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00003778 File Offset: 0x00001978
			[Register("setRequestAgent", "(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", "GetSetRequestAgent_Ljava_lang_String_Handler")]
			public unsafe virtual AdRequest.Builder SetRequestAgent(string requestAgent)
			{
				IntPtr intPtr = JNIEnv.NewString(requestAgent);
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setRequestAgent.(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000AA RID: 170 RVA: 0x000037E4 File Offset: 0x000019E4
			[Register("zza", "(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", "")]
			public unsafe AdRequest.Builder Zza(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("zza.(Ljava/lang/String;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00003850 File Offset: 0x00001A50
			[Register("zzb", "(Ljava/util/Date;)Lcom/google/android/gms/ads/AdRequest$Builder;", "")]
			public unsafe AdRequest.Builder Zzb(Date p0)
			{
				AdRequest.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("zzb.(Ljava/util/Date;)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x060000AC RID: 172 RVA: 0x000038C4 File Offset: 0x00001AC4
			[Register("zzc", "(I)Lcom/google/android/gms/ads/AdRequest$Builder;", "")]
			public unsafe AdRequest.Builder Zzc(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("zzc.(I)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00003910 File Offset: 0x00001B10
			[Register("zzd", "(Z)Lcom/google/android/gms/ads/AdRequest$Builder;", "")]
			public unsafe AdRequest.Builder Zzd(bool p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("zzd.(Z)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000AE RID: 174 RVA: 0x0000395C File Offset: 0x00001B5C
			[Register("zze", "(Z)Lcom/google/android/gms/ads/AdRequest$Builder;", "")]
			public unsafe AdRequest.Builder Zze(bool p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<AdRequest.Builder>(AdRequest.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("zze.(Z)Lcom/google/android/gms/ads/AdRequest$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000017 RID: 23
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdRequest$Builder", typeof(AdRequest.Builder));

			// Token: 0x04000018 RID: 24
			private static Delegate cb_addCustomEventExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_;

			// Token: 0x04000019 RID: 25
			private static Delegate cb_addKeyword_Ljava_lang_String_;

			// Token: 0x0400001A RID: 26
			private static Delegate cb_addNetworkExtrasBundle_Ljava_lang_Class_Landroid_os_Bundle_;

			// Token: 0x0400001B RID: 27
			private static Delegate cb_build;

			// Token: 0x0400001C RID: 28
			private static Delegate cb_setAdString_Ljava_lang_String_;

			// Token: 0x0400001D RID: 29
			private static Delegate cb_setContentUrl_Ljava_lang_String_;

			// Token: 0x0400001E RID: 30
			private static Delegate cb_setHttpTimeoutMillis_I;

			// Token: 0x0400001F RID: 31
			private static Delegate cb_setNeighboringContentUrls_Ljava_util_List_;

			// Token: 0x04000020 RID: 32
			private static Delegate cb_setRequestAgent_Ljava_lang_String_;
		}
	}
}
