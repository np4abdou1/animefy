using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads
{
	// Token: 0x020001CD RID: 461
	[Register("com/unity3d/services/ads/UnityAdsImplementation", DoNotGenerateAcw = true)]
	public sealed class UnityAdsImplementation : Java.Lang.Object, IUnityAds, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0003B1F0 File Offset: 0x000393F0
		internal static IntPtr class_ref
		{
			get
			{
				return UnityAdsImplementation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0003B214 File Offset: 0x00039414
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityAdsImplementation._members;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0003B21C File Offset: 0x0003941C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityAdsImplementation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0003B240 File Offset: 0x00039440
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityAdsImplementation._members.ManagedPeerType;
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000021E8 File Offset: 0x000003E8
		internal UnityAdsImplementation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0003B24C File Offset: 0x0003944C
		[Register(".ctor", "()V", "")]
		public UnityAdsImplementation() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnityAdsImplementation._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnityAdsImplementation._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0003B2BA File Offset: 0x000394BA
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0003B2D4 File Offset: 0x000394D4
		public unsafe bool DebugMode
		{
			[Register("getDebugMode", "()Z", "")]
			get
			{
				return UnityAdsImplementation._members.InstanceMethods.InvokeAbstractBooleanMethod("getDebugMode.()Z", this, null);
			}
			[Register("setDebugMode", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				UnityAdsImplementation._members.InstanceMethods.InvokeAbstractVoidMethod("setDebugMode.(Z)V", this, ptr);
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0003B310 File Offset: 0x00039510
		public static IUnityAds Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/ads/IUnityAds;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IUnityAds>(UnityAdsImplementation._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/ads/IUnityAds;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0003B341 File Offset: 0x00039541
		public bool IsInitialized
		{
			[Register("isInitialized", "()Z", "")]
			get
			{
				return UnityAdsImplementation._members.InstanceMethods.InvokeAbstractBooleanMethod("isInitialized.()Z", this, null);
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0003B35A File Offset: 0x0003955A
		public bool IsSupported
		{
			[Register("isSupported", "()Z", "")]
			get
			{
				return UnityAdsImplementation._members.InstanceMethods.InvokeAbstractBooleanMethod("isSupported.()Z", this, null);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0003B374 File Offset: 0x00039574
		public string Token
		{
			[Register("getToken", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(UnityAdsImplementation._members.InstanceMethods.InvokeAbstractObjectMethod("getToken.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x0003B3A8 File Offset: 0x000395A8
		public string Version
		{
			[Register("getVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(UnityAdsImplementation._members.InstanceMethods.InvokeAbstractObjectMethod("getVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0003B3DC File Offset: 0x000395DC
		[Register("getToken", "(Lcom/unity3d/ads/IUnityAdsTokenListener;)V", "")]
		public unsafe void GetToken(IUnityAdsTokenListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				UnityAdsImplementation._members.InstanceMethods.InvokeAbstractVoidMethod("getToken.(Lcom/unity3d/ads/IUnityAdsTokenListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0003B444 File Offset: 0x00039644
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V", "")]
		public unsafe void Initialize(Context context, string gameId, bool testMode, IUnityAdsInitializationListener initializationListener)
		{
			IntPtr intPtr = JNIEnv.NewString(gameId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(testMode);
				ptr[3] = new JniArgumentValue((initializationListener == null) ? IntPtr.Zero : ((Java.Lang.Object)initializationListener).Handle);
				UnityAdsImplementation._members.InstanceMethods.InvokeAbstractVoidMethod("initialize.(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(initializationListener);
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0003B510 File Offset: 0x00039710
		[Register("load", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/ads/IUnityAdsLoadListener;)V", "")]
		public unsafe void Load(string placementId, UnityAdsLoadOptions loadOptions, IUnityAdsLoadListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((loadOptions == null) ? IntPtr.Zero : loadOptions.Handle);
				ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				UnityAdsImplementation._members.InstanceMethods.InvokeAbstractVoidMethod("load.(Ljava/lang/String;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/ads/IUnityAdsLoadListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(loadOptions);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0003B5C4 File Offset: 0x000397C4
		[Register("setConfiguration", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe static void SetConfiguration(Configuration configuration)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				UnityAdsImplementation._members.StaticMethods.InvokeVoidMethod("setConfiguration.(Lcom/unity3d/services/core/configuration/Configuration;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0003B628 File Offset: 0x00039828
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public unsafe void Show(Activity activity, string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				UnityAdsImplementation._members.InstanceMethods.InvokeAbstractVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0003B6AC File Offset: 0x000398AC
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsShowListener;)V", "")]
		public unsafe void Show(Activity activity, string placementId, IUnityAdsShowListener showListener)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((showListener == null) ? IntPtr.Zero : ((Java.Lang.Object)showListener).Handle);
				UnityAdsImplementation._members.InstanceMethods.InvokeAbstractVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsShowListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(showListener);
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0003B760 File Offset: 0x00039960
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/ads/IUnityAdsShowListener;)V", "")]
		public unsafe void Show(Activity activity, string placementId, UnityAdsShowOptions showOptions, IUnityAdsShowListener showListener)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((showOptions == null) ? IntPtr.Zero : showOptions.Handle);
				ptr[3] = new JniArgumentValue((showListener == null) ? IntPtr.Zero : ((Java.Lang.Object)showListener).Handle);
				UnityAdsImplementation._members.InstanceMethods.InvokeAbstractVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/ads/IUnityAdsShowListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(showOptions);
				GC.KeepAlive(showListener);
			}
		}

		// Token: 0x040004F8 RID: 1272
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/UnityAdsImplementation", typeof(UnityAdsImplementation));
	}
}
