using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D7 RID: 727
	[Register("com/unity3d/ads/UnityAds", DoNotGenerateAcw = true)]
	public sealed class UnityAds : Java.Lang.Object
	{
		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x00067F08 File Offset: 0x00066108
		internal static IntPtr class_ref
		{
			get
			{
				return UnityAds._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x00067F2C File Offset: 0x0006612C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityAds._members;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x00067F34 File Offset: 0x00066134
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityAds._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x00067F58 File Offset: 0x00066158
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityAds._members.ManagedPeerType;
			}
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x000021E8 File Offset: 0x000003E8
		internal UnityAds(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00067F64 File Offset: 0x00066164
		[Register(".ctor", "()V", "")]
		public UnityAds() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnityAds._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnityAds._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x00067FD2 File Offset: 0x000661D2
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x00067FEC File Offset: 0x000661EC
		public unsafe static bool DebugMode
		{
			[Register("getDebugMode", "()Z", "")]
			get
			{
				return UnityAds._members.StaticMethods.InvokeBooleanMethod("getDebugMode.()Z", null);
			}
			[Register("setDebugMode", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				UnityAds._members.StaticMethods.InvokeVoidMethod("setDebugMode.(Z)V", ptr);
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x00068026 File Offset: 0x00066226
		public static bool IsInitialized
		{
			[Register("isInitialized", "()Z", "")]
			get
			{
				return UnityAds._members.StaticMethods.InvokeBooleanMethod("isInitialized.()Z", null);
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x0006803E File Offset: 0x0006623E
		public static bool IsSupported
		{
			[Register("isSupported", "()Z", "")]
			get
			{
				return UnityAds._members.StaticMethods.InvokeBooleanMethod("isSupported.()Z", null);
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x00068058 File Offset: 0x00066258
		public static string Token
		{
			[Register("getToken", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(UnityAds._members.StaticMethods.InvokeObjectMethod("getToken.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x0006808C File Offset: 0x0006628C
		public static string Version
		{
			[Register("getVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(UnityAds._members.StaticMethods.InvokeObjectMethod("getVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000680C0 File Offset: 0x000662C0
		[Register("getToken", "(Lcom/unity3d/ads/IUnityAdsTokenListener;)V", "")]
		public unsafe static void GetToken(IUnityAdsTokenListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("getToken.(Lcom/unity3d/ads/IUnityAdsTokenListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00068128 File Offset: 0x00066328
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe static void Initialize(Context context, string gameId)
		{
			IntPtr intPtr = JNIEnv.NewString(gameId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				UnityAds._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000681AC File Offset: 0x000663AC
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public unsafe static void Initialize(Context context, string gameId, bool testMode)
		{
			IntPtr intPtr = JNIEnv.NewString(gameId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(testMode);
				UnityAds._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;Ljava/lang/String;Z)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00068244 File Offset: 0x00066444
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V", "")]
		public unsafe static void Initialize(Context context, string gameId, bool testMode, IUnityAdsInitializationListener initializationListener)
		{
			IntPtr intPtr = JNIEnv.NewString(gameId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(testMode);
				ptr[3] = new JniArgumentValue((initializationListener == null) ? IntPtr.Zero : ((Java.Lang.Object)initializationListener).Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(initializationListener);
			}
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0006830C File Offset: 0x0006650C
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsInitializationListener;)V", "")]
		public unsafe static void Initialize(Context context, string gameId, IUnityAdsInitializationListener initializationListener)
		{
			IntPtr intPtr = JNIEnv.NewString(gameId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((initializationListener == null) ? IntPtr.Zero : ((Java.Lang.Object)initializationListener).Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsInitializationListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(initializationListener);
			}
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x000683C0 File Offset: 0x000665C0
		[Obsolete("deprecated")]
		[Register("load", "(Ljava/lang/String;)V", "")]
		public unsafe static void Load(string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UnityAds._members.StaticMethods.InvokeVoidMethod("load.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0006841C File Offset: 0x0006661C
		[Register("load", "(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsLoadListener;)V", "")]
		public unsafe static void Load(string placementId, IUnityAdsLoadListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("load.(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsLoadListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000684A4 File Offset: 0x000666A4
		[Register("load", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/ads/IUnityAdsLoadListener;)V", "")]
		public unsafe static void Load(string placementId, UnityAdsLoadOptions loadOptions, IUnityAdsLoadListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((loadOptions == null) ? IntPtr.Zero : loadOptions.Handle);
				ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("load.(Ljava/lang/String;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/ads/IUnityAdsLoadListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(loadOptions);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00068558 File Offset: 0x00066758
		[Obsolete("deprecated")]
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public unsafe static void Show(Activity activity, string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				UnityAds._members.StaticMethods.InvokeVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000685DC File Offset: 0x000667DC
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsShowListener;)V", "")]
		public unsafe static void Show(Activity activity, string placementId, IUnityAdsShowListener showListener)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((showListener == null) ? IntPtr.Zero : ((Java.Lang.Object)showListener).Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsShowListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(showListener);
			}
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00068690 File Offset: 0x00066890
		[Obsolete("deprecated")]
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;)V", "")]
		public unsafe static void Show(Activity activity, string placementId, UnityAdsShowOptions options)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00068740 File Offset: 0x00066940
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/ads/IUnityAdsShowListener;)V", "")]
		public unsafe static void Show(Activity activity, string placementId, UnityAdsShowOptions options, IUnityAdsShowListener showListener)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ptr[3] = new JniArgumentValue((showListener == null) ? IntPtr.Zero : ((Java.Lang.Object)showListener).Handle);
				UnityAds._members.StaticMethods.InvokeVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/ads/IUnityAdsShowListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(options);
				GC.KeepAlive(showListener);
			}
		}

		// Token: 0x0400083A RID: 2106
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAds", typeof(UnityAds));

		// Token: 0x020002D8 RID: 728
		[Register("com/unity3d/ads/UnityAds$UnityAdsInitializationError", DoNotGenerateAcw = true)]
		public sealed class UnityAdsInitializationError : Java.Lang.Enum
		{
			// Token: 0x17000F3E RID: 3902
			// (get) Token: 0x06002867 RID: 10343 RVA: 0x0006883C File Offset: 0x00066A3C
			[Register("AD_BLOCKER_DETECTED")]
			public static UnityAds.UnityAdsInitializationError AdBlockerDetected
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsInitializationError>(UnityAds.UnityAdsInitializationError._members.StaticFields.GetObjectValue("AD_BLOCKER_DETECTED.Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F3F RID: 3903
			// (get) Token: 0x06002868 RID: 10344 RVA: 0x0006886C File Offset: 0x00066A6C
			[Register("INTERNAL_ERROR")]
			public static UnityAds.UnityAdsInitializationError InternalError
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsInitializationError>(UnityAds.UnityAdsInitializationError._members.StaticFields.GetObjectValue("INTERNAL_ERROR.Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F40 RID: 3904
			// (get) Token: 0x06002869 RID: 10345 RVA: 0x0006889C File Offset: 0x00066A9C
			[Register("INVALID_ARGUMENT")]
			public static UnityAds.UnityAdsInitializationError InvalidArgument
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsInitializationError>(UnityAds.UnityAdsInitializationError._members.StaticFields.GetObjectValue("INVALID_ARGUMENT.Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F41 RID: 3905
			// (get) Token: 0x0600286A RID: 10346 RVA: 0x000688CC File Offset: 0x00066ACC
			internal static IntPtr class_ref
			{
				get
				{
					return UnityAds.UnityAdsInitializationError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F42 RID: 3906
			// (get) Token: 0x0600286B RID: 10347 RVA: 0x000688F0 File Offset: 0x00066AF0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UnityAds.UnityAdsInitializationError._members;
				}
			}

			// Token: 0x17000F43 RID: 3907
			// (get) Token: 0x0600286C RID: 10348 RVA: 0x000688F8 File Offset: 0x00066AF8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UnityAds.UnityAdsInitializationError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F44 RID: 3908
			// (get) Token: 0x0600286D RID: 10349 RVA: 0x0006891C File Offset: 0x00066B1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UnityAds.UnityAdsInitializationError._members.ManagedPeerType;
				}
			}

			// Token: 0x0600286E RID: 10350 RVA: 0x0000256C File Offset: 0x0000076C
			internal UnityAdsInitializationError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600286F RID: 10351 RVA: 0x00068928 File Offset: 0x00066B28
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;", "")]
			public unsafe static UnityAds.UnityAdsInitializationError ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				UnityAds.UnityAdsInitializationError @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<UnityAds.UnityAdsInitializationError>(UnityAds.UnityAdsInitializationError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06002870 RID: 10352 RVA: 0x00068994 File Offset: 0x00066B94
			[Register("values", "()[Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;", "")]
			public static UnityAds.UnityAdsInitializationError[] Values()
			{
				return (UnityAds.UnityAdsInitializationError[])JNIEnv.GetArray(UnityAds.UnityAdsInitializationError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(UnityAds.UnityAdsInitializationError));
			}

			// Token: 0x0400083B RID: 2107
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAds$UnityAdsInitializationError", typeof(UnityAds.UnityAdsInitializationError));
		}

		// Token: 0x020002D9 RID: 729
		[Register("com/unity3d/ads/UnityAds$UnityAdsLoadError", DoNotGenerateAcw = true)]
		public sealed class UnityAdsLoadError : Java.Lang.Enum
		{
			// Token: 0x17000F45 RID: 3909
			// (get) Token: 0x06002872 RID: 10354 RVA: 0x000689F0 File Offset: 0x00066BF0
			[Register("INITIALIZE_FAILED")]
			public static UnityAds.UnityAdsLoadError InitializeFailed
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(UnityAds.UnityAdsLoadError._members.StaticFields.GetObjectValue("INITIALIZE_FAILED.Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F46 RID: 3910
			// (get) Token: 0x06002873 RID: 10355 RVA: 0x00068A20 File Offset: 0x00066C20
			[Register("INTERNAL_ERROR")]
			public static UnityAds.UnityAdsLoadError InternalError
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(UnityAds.UnityAdsLoadError._members.StaticFields.GetObjectValue("INTERNAL_ERROR.Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F47 RID: 3911
			// (get) Token: 0x06002874 RID: 10356 RVA: 0x00068A50 File Offset: 0x00066C50
			[Register("INVALID_ARGUMENT")]
			public static UnityAds.UnityAdsLoadError InvalidArgument
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(UnityAds.UnityAdsLoadError._members.StaticFields.GetObjectValue("INVALID_ARGUMENT.Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F48 RID: 3912
			// (get) Token: 0x06002875 RID: 10357 RVA: 0x00068A80 File Offset: 0x00066C80
			[Register("NO_FILL")]
			public static UnityAds.UnityAdsLoadError NoFill
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(UnityAds.UnityAdsLoadError._members.StaticFields.GetObjectValue("NO_FILL.Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F49 RID: 3913
			// (get) Token: 0x06002876 RID: 10358 RVA: 0x00068AB0 File Offset: 0x00066CB0
			[Register("TIMEOUT")]
			public static UnityAds.UnityAdsLoadError Timeout
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(UnityAds.UnityAdsLoadError._members.StaticFields.GetObjectValue("TIMEOUT.Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F4A RID: 3914
			// (get) Token: 0x06002877 RID: 10359 RVA: 0x00068AE0 File Offset: 0x00066CE0
			internal static IntPtr class_ref
			{
				get
				{
					return UnityAds.UnityAdsLoadError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F4B RID: 3915
			// (get) Token: 0x06002878 RID: 10360 RVA: 0x00068B04 File Offset: 0x00066D04
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UnityAds.UnityAdsLoadError._members;
				}
			}

			// Token: 0x17000F4C RID: 3916
			// (get) Token: 0x06002879 RID: 10361 RVA: 0x00068B0C File Offset: 0x00066D0C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UnityAds.UnityAdsLoadError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F4D RID: 3917
			// (get) Token: 0x0600287A RID: 10362 RVA: 0x00068B30 File Offset: 0x00066D30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UnityAds.UnityAdsLoadError._members.ManagedPeerType;
				}
			}

			// Token: 0x0600287B RID: 10363 RVA: 0x0000256C File Offset: 0x0000076C
			internal UnityAdsLoadError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600287C RID: 10364 RVA: 0x00068B3C File Offset: 0x00066D3C
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;", "")]
			public unsafe static UnityAds.UnityAdsLoadError ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				UnityAds.UnityAdsLoadError @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(UnityAds.UnityAdsLoadError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600287D RID: 10365 RVA: 0x00068BA8 File Offset: 0x00066DA8
			[Register("values", "()[Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;", "")]
			public static UnityAds.UnityAdsLoadError[] Values()
			{
				return (UnityAds.UnityAdsLoadError[])JNIEnv.GetArray(UnityAds.UnityAdsLoadError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(UnityAds.UnityAdsLoadError));
			}

			// Token: 0x0400083C RID: 2108
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAds$UnityAdsLoadError", typeof(UnityAds.UnityAdsLoadError));
		}

		// Token: 0x020002DA RID: 730
		[Register("com/unity3d/ads/UnityAds$UnityAdsShowCompletionState", DoNotGenerateAcw = true)]
		public sealed class UnityAdsShowCompletionState : Java.Lang.Enum
		{
			// Token: 0x17000F4E RID: 3918
			// (get) Token: 0x0600287F RID: 10367 RVA: 0x00068C04 File Offset: 0x00066E04
			[Register("COMPLETED")]
			public static UnityAds.UnityAdsShowCompletionState Completed
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(UnityAds.UnityAdsShowCompletionState._members.StaticFields.GetObjectValue("COMPLETED.Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F4F RID: 3919
			// (get) Token: 0x06002880 RID: 10368 RVA: 0x00068C34 File Offset: 0x00066E34
			[Register("SKIPPED")]
			public static UnityAds.UnityAdsShowCompletionState Skipped
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(UnityAds.UnityAdsShowCompletionState._members.StaticFields.GetObjectValue("SKIPPED.Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F50 RID: 3920
			// (get) Token: 0x06002881 RID: 10369 RVA: 0x00068C64 File Offset: 0x00066E64
			internal static IntPtr class_ref
			{
				get
				{
					return UnityAds.UnityAdsShowCompletionState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F51 RID: 3921
			// (get) Token: 0x06002882 RID: 10370 RVA: 0x00068C88 File Offset: 0x00066E88
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UnityAds.UnityAdsShowCompletionState._members;
				}
			}

			// Token: 0x17000F52 RID: 3922
			// (get) Token: 0x06002883 RID: 10371 RVA: 0x00068C90 File Offset: 0x00066E90
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UnityAds.UnityAdsShowCompletionState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F53 RID: 3923
			// (get) Token: 0x06002884 RID: 10372 RVA: 0x00068CB4 File Offset: 0x00066EB4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UnityAds.UnityAdsShowCompletionState._members.ManagedPeerType;
				}
			}

			// Token: 0x06002885 RID: 10373 RVA: 0x0000256C File Offset: 0x0000076C
			internal UnityAdsShowCompletionState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002886 RID: 10374 RVA: 0x00068CC0 File Offset: 0x00066EC0
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;", "")]
			public unsafe static UnityAds.UnityAdsShowCompletionState ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				UnityAds.UnityAdsShowCompletionState @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(UnityAds.UnityAdsShowCompletionState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06002887 RID: 10375 RVA: 0x00068D2C File Offset: 0x00066F2C
			[Register("values", "()[Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;", "")]
			public static UnityAds.UnityAdsShowCompletionState[] Values()
			{
				return (UnityAds.UnityAdsShowCompletionState[])JNIEnv.GetArray(UnityAds.UnityAdsShowCompletionState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(UnityAds.UnityAdsShowCompletionState));
			}

			// Token: 0x0400083D RID: 2109
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAds$UnityAdsShowCompletionState", typeof(UnityAds.UnityAdsShowCompletionState));
		}

		// Token: 0x020002DB RID: 731
		[Register("com/unity3d/ads/UnityAds$UnityAdsShowError", DoNotGenerateAcw = true)]
		public sealed class UnityAdsShowError : Java.Lang.Enum
		{
			// Token: 0x17000F54 RID: 3924
			// (get) Token: 0x06002889 RID: 10377 RVA: 0x00068D88 File Offset: 0x00066F88
			[Register("ALREADY_SHOWING")]
			public static UnityAds.UnityAdsShowError AlreadyShowing
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("ALREADY_SHOWING.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F55 RID: 3925
			// (get) Token: 0x0600288A RID: 10378 RVA: 0x00068DB8 File Offset: 0x00066FB8
			[Register("INTERNAL_ERROR")]
			public static UnityAds.UnityAdsShowError InternalError
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("INTERNAL_ERROR.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F56 RID: 3926
			// (get) Token: 0x0600288B RID: 10379 RVA: 0x00068DE8 File Offset: 0x00066FE8
			[Register("INVALID_ARGUMENT")]
			public static UnityAds.UnityAdsShowError InvalidArgument
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("INVALID_ARGUMENT.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F57 RID: 3927
			// (get) Token: 0x0600288C RID: 10380 RVA: 0x00068E18 File Offset: 0x00067018
			[Register("NOT_INITIALIZED")]
			public static UnityAds.UnityAdsShowError NotInitialized
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("NOT_INITIALIZED.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F58 RID: 3928
			// (get) Token: 0x0600288D RID: 10381 RVA: 0x00068E48 File Offset: 0x00067048
			[Register("NOT_READY")]
			public static UnityAds.UnityAdsShowError NotReady
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("NOT_READY.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F59 RID: 3929
			// (get) Token: 0x0600288E RID: 10382 RVA: 0x00068E78 File Offset: 0x00067078
			[Register("NO_CONNECTION")]
			public static UnityAds.UnityAdsShowError NoConnection
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("NO_CONNECTION.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F5A RID: 3930
			// (get) Token: 0x0600288F RID: 10383 RVA: 0x00068EA8 File Offset: 0x000670A8
			[Register("TIMEOUT")]
			public static UnityAds.UnityAdsShowError Timeout
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("TIMEOUT.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F5B RID: 3931
			// (get) Token: 0x06002890 RID: 10384 RVA: 0x00068ED8 File Offset: 0x000670D8
			[Register("VIDEO_PLAYER_ERROR")]
			public static UnityAds.UnityAdsShowError VideoPlayerError
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticFields.GetObjectValue("VIDEO_PLAYER_ERROR.Lcom/unity3d/ads/UnityAds$UnityAdsShowError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000F5C RID: 3932
			// (get) Token: 0x06002891 RID: 10385 RVA: 0x00068F08 File Offset: 0x00067108
			internal static IntPtr class_ref
			{
				get
				{
					return UnityAds.UnityAdsShowError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F5D RID: 3933
			// (get) Token: 0x06002892 RID: 10386 RVA: 0x00068F2C File Offset: 0x0006712C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UnityAds.UnityAdsShowError._members;
				}
			}

			// Token: 0x17000F5E RID: 3934
			// (get) Token: 0x06002893 RID: 10387 RVA: 0x00068F34 File Offset: 0x00067134
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UnityAds.UnityAdsShowError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000F5F RID: 3935
			// (get) Token: 0x06002894 RID: 10388 RVA: 0x00068F58 File Offset: 0x00067158
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UnityAds.UnityAdsShowError._members.ManagedPeerType;
				}
			}

			// Token: 0x06002895 RID: 10389 RVA: 0x0000256C File Offset: 0x0000076C
			internal UnityAdsShowError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002896 RID: 10390 RVA: 0x00068F64 File Offset: 0x00067164
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsShowError;", "")]
			public unsafe static UnityAds.UnityAdsShowError ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				UnityAds.UnityAdsShowError @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(UnityAds.UnityAdsShowError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/ads/UnityAds$UnityAdsShowError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06002897 RID: 10391 RVA: 0x00068FD0 File Offset: 0x000671D0
			[Register("values", "()[Lcom/unity3d/ads/UnityAds$UnityAdsShowError;", "")]
			public static UnityAds.UnityAdsShowError[] Values()
			{
				return (UnityAds.UnityAdsShowError[])JNIEnv.GetArray(UnityAds.UnityAdsShowError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/ads/UnityAds$UnityAdsShowError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(UnityAds.UnityAdsShowError));
			}

			// Token: 0x0400083E RID: 2110
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAds$UnityAdsShowError", typeof(UnityAds.UnityAdsShowError));
		}
	}
}
