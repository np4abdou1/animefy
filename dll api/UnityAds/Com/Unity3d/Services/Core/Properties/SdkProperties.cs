using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Cache;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Properties
{
	// Token: 0x020000CD RID: 205
	[Register("com/unity3d/services/core/properties/SdkProperties", DoNotGenerateAcw = true)]
	public class SdkProperties : Java.Lang.Object
	{
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00016F98 File Offset: 0x00015198
		internal static IntPtr class_ref
		{
			get
			{
				return SdkProperties._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00016FBC File Offset: 0x000151BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SdkProperties._members;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00016FC4 File Offset: 0x000151C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SdkProperties._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00016FE8 File Offset: 0x000151E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SdkProperties._members.ManagedPeerType;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SdkProperties(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00016FF4 File Offset: 0x000151F4
		[Register(".ctor", "()V", "")]
		public SdkProperties() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SdkProperties._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SdkProperties._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00017064 File Offset: 0x00015264
		public static File CacheDirectory
		{
			[Register("getCacheDirectory", "()Ljava/io/File;", "")]
			get
			{
				return Java.Lang.Object.GetObject<File>(SdkProperties._members.StaticMethods.InvokeObjectMethod("getCacheDirectory.()Ljava/io/File;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00017098 File Offset: 0x00015298
		public static string CacheDirectoryName
		{
			[Register("getCacheDirectoryName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getCacheDirectoryName.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x000170CC File Offset: 0x000152CC
		public static CacheDirectory CacheDirectoryObject
		{
			[Register("getCacheDirectoryObject", "()Lcom/unity3d/services/core/cache/CacheDirectory;", "")]
			get
			{
				return Java.Lang.Object.GetObject<CacheDirectory>(SdkProperties._members.StaticMethods.InvokeObjectMethod("getCacheDirectoryObject.()Lcom/unity3d/services/core/cache/CacheDirectory;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00017100 File Offset: 0x00015300
		public static string CacheFilePrefix
		{
			[Register("getCacheFilePrefix", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getCacheFilePrefix.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00017134 File Offset: 0x00015334
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00017168 File Offset: 0x00015368
		public unsafe static string ConfigUrl
		{
			[Register("getConfigUrl", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getConfigUrl.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setConfigUrl", "(Ljava/lang/String;)V", "")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					SdkProperties._members.StaticMethods.InvokeVoidMethod("setConfigUrl.(Ljava/lang/String;)V", ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000171C4 File Offset: 0x000153C4
		public static SdkProperties.InitializationState CurrentInitializationState
		{
			[Register("getCurrentInitializationState", "()Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;", "")]
			get
			{
				return Java.Lang.Object.GetObject<SdkProperties.InitializationState>(SdkProperties._members.StaticMethods.InvokeObjectMethod("getCurrentInitializationState.()Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000171F5 File Offset: 0x000153F5
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00017210 File Offset: 0x00015410
		public unsafe static bool DebugMode
		{
			[Register("getDebugMode", "()Z", "")]
			get
			{
				return SdkProperties._members.StaticMethods.InvokeBooleanMethod("getDebugMode.()Z", null);
			}
			[Register("setDebugMode", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("setDebugMode.(Z)V", ptr);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0001724A File Offset: 0x0001544A
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00017264 File Offset: 0x00015464
		public unsafe static long InitializationTime
		{
			[Register("getInitializationTime", "()J", "")]
			get
			{
				return SdkProperties._members.StaticMethods.InvokeInt64Method("getInitializationTime.()J", null);
			}
			[Register("setInitializationTime", "(J)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("setInitializationTime.(J)V", ptr);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0001729E File Offset: 0x0001549E
		public static long InitializationTimeEpoch
		{
			[Register("getInitializationTimeEpoch", "()J", "")]
			get
			{
				return SdkProperties._members.StaticMethods.InvokeInt64Method("getInitializationTimeEpoch.()J", null);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000172B6 File Offset: 0x000154B6
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x000172D0 File Offset: 0x000154D0
		public unsafe static bool Initialized
		{
			[Register("isInitialized", "()Z", "")]
			get
			{
				return SdkProperties._members.StaticMethods.InvokeBooleanMethod("isInitialized.()Z", null);
			}
			[Register("setInitialized", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("setInitialized.(Z)V", ptr);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0001730C File Offset: 0x0001550C
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00017340 File Offset: 0x00015540
		public unsafe static Configuration LatestConfiguration
		{
			[Register("getLatestConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(SdkProperties._members.StaticMethods.InvokeObjectMethod("getLatestConfiguration.()Lcom/unity3d/services/core/configuration/Configuration;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setLatestConfiguration", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SdkProperties._members.StaticMethods.InvokeVoidMethod("setLatestConfiguration.(Lcom/unity3d/services/core/configuration/Configuration;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000173A4 File Offset: 0x000155A4
		public static string LocalConfigurationFilepath
		{
			[Register("getLocalConfigurationFilepath", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getLocalConfigurationFilepath.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000173D8 File Offset: 0x000155D8
		public static string LocalStorageFilePrefix
		{
			[Register("getLocalStorageFilePrefix", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getLocalStorageFilePrefix.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0001740C File Offset: 0x0001560C
		public static string LocalWebViewFile
		{
			[Register("getLocalWebViewFile", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getLocalWebViewFile.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00017440 File Offset: 0x00015640
		public static string LocalWebViewFileUpdated
		{
			[Register("getLocalWebViewFileUpdated", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getLocalWebViewFileUpdated.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00017471 File Offset: 0x00015671
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x0001748C File Offset: 0x0001568C
		public unsafe static bool Reinitialized
		{
			[Register("isReinitialized", "()Z", "")]
			get
			{
				return SdkProperties._members.StaticMethods.InvokeBooleanMethod("isReinitialized.()Z", null);
			}
			[Register("setReinitialized", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("setReinitialized.(Z)V", ptr);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x000174C6 File Offset: 0x000156C6
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x000174E0 File Offset: 0x000156E0
		public unsafe static bool TestMode
		{
			[Register("isTestMode", "()Z", "")]
			get
			{
				return SdkProperties._members.StaticMethods.InvokeBooleanMethod("isTestMode.()Z", null);
			}
			[Register("setTestMode", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("setTestMode.(Z)V", ptr);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0001751A File Offset: 0x0001571A
		public static int VersionCode
		{
			[Register("getVersionCode", "()I", "")]
			get
			{
				return SdkProperties._members.StaticMethods.InvokeInt32Method("getVersionCode.()I", null);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00017534 File Offset: 0x00015734
		public static string VersionName
		{
			[Register("getVersionName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getVersionName.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00017568 File Offset: 0x00015768
		[Register("addInitializationListener", "(Lcom/unity3d/ads/IUnityAdsInitializationListener;)V", "")]
		public unsafe static void AddInitializationListener(IUnityAdsInitializationListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("addInitializationListener.(Lcom/unity3d/ads/IUnityAdsInitializationListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000175D0 File Offset: 0x000157D0
		[Register("getCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public unsafe static File GetCacheDirectory(Context context)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<File>(SdkProperties._members.StaticMethods.InvokeObjectMethod("getCacheDirectory.(Landroid/content/Context;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00017644 File Offset: 0x00015844
		[Register("getConfigVersion", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe static string GetConfigVersion(Context context)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@string = JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getConfigVersion.(Landroid/content/Context;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @string;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000176B8 File Offset: 0x000158B8
		[Register("getDefaultConfigUrl", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string GetDefaultConfigUrl(string flavor)
		{
			IntPtr intPtr = JNIEnv.NewString(flavor);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(SdkProperties._members.StaticMethods.InvokeObjectMethod("getDefaultConfigUrl.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00017724 File Offset: 0x00015924
		[Register("getInitializationListeners", "()[Lcom/unity3d/ads/IUnityAdsInitializationListener;", "")]
		public static IUnityAdsInitializationListener[] GetInitializationListeners()
		{
			return (IUnityAdsInitializationListener[])JNIEnv.GetArray(SdkProperties._members.StaticMethods.InvokeObjectMethod("getInitializationListeners.()[Lcom/unity3d/ads/IUnityAdsInitializationListener;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(IUnityAdsInitializationListener));
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00017764 File Offset: 0x00015964
		[Register("isChinaLocale", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool IsChinaLocale(string networkISOCode)
		{
			IntPtr intPtr = JNIEnv.NewString(networkISOCode);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = SdkProperties._members.StaticMethods.InvokeBooleanMethod("isChinaLocale.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000177C0 File Offset: 0x000159C0
		[Register("notifyInitializationComplete", "()V", "")]
		public static void NotifyInitializationComplete()
		{
			SdkProperties._members.StaticMethods.InvokeVoidMethod("notifyInitializationComplete.()V", null);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000177D8 File Offset: 0x000159D8
		[Register("notifyInitializationFailed", "(Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;Ljava/lang/String;)V", "")]
		public unsafe static void NotifyInitializationFailed(UnityAds.UnityAdsInitializationError error, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("notifyInitializationFailed.(Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0001785C File Offset: 0x00015A5C
		[Register("resetInitializationListeners", "()V", "")]
		public static void ResetInitializationListeners()
		{
			SdkProperties._members.StaticMethods.InvokeVoidMethod("resetInitializationListeners.()V", null);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00017874 File Offset: 0x00015A74
		[Register("setCacheDirectory", "(Lcom/unity3d/services/core/cache/CacheDirectory;)V", "")]
		public unsafe static void SetCacheDirectory(CacheDirectory cacheDirectory)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cacheDirectory == null) ? IntPtr.Zero : cacheDirectory.Handle);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("setCacheDirectory.(Lcom/unity3d/services/core/cache/CacheDirectory;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(cacheDirectory);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000178D8 File Offset: 0x00015AD8
		[Register("setInitializationTimeSinceEpoch", "(J)V", "")]
		public unsafe static void SetInitializationTimeSinceEpoch(long initializationTimeEpochMs)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(initializationTimeEpochMs);
			SdkProperties._members.StaticMethods.InvokeVoidMethod("setInitializationTimeSinceEpoch.(J)V", ptr);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00017914 File Offset: 0x00015B14
		[Register("setInitializeState", "(Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;)V", "")]
		public unsafe static void SetInitializeState(SdkProperties.InitializationState initializeState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initializeState == null) ? IntPtr.Zero : initializeState.Handle);
				SdkProperties._members.StaticMethods.InvokeVoidMethod("setInitializeState.(Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(initializeState);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600082F RID: 2095 RVA: 0x00017978 File Offset: 0x00015B78
		// (remove) Token: 0x06000830 RID: 2096 RVA: 0x000179C4 File Offset: 0x00015BC4
		public event EventHandler InitializationComplete
		{
			add
			{
				EventHelper.AddEventHandler<IUnityAdsInitializationListener, IUnityAdsInitializationListenerImplementor>(ref this.weak_implementor_AddInitializationListener, new Func<IUnityAdsInitializationListenerImplementor>(this.__CreateIUnityAdsInitializationListenerImplementor), new Action<IUnityAdsInitializationListener>(SdkProperties.AddInitializationListener), delegate(IUnityAdsInitializationListenerImplementor __h)
				{
					__h.OnInitializationCompleteHandler = (EventHandler)Delegate.Combine(__h.OnInitializationCompleteHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityAdsInitializationListener, IUnityAdsInitializationListenerImplementor>(ref this.weak_implementor_AddInitializationListener, new Func<IUnityAdsInitializationListenerImplementor, bool>(IUnityAdsInitializationListenerImplementor.__IsEmpty), delegate(IUnityAdsInitializationListener __v)
				{
					throw new NotSupportedException("Cannot unregister from Com.Unity3d.Ads.IUnityAdsInitializationListener.AddInitializationListener");
				}, delegate(IUnityAdsInitializationListenerImplementor __h)
				{
					__h.OnInitializationCompleteHandler = (EventHandler)Delegate.Remove(__h.OnInitializationCompleteHandler, value);
				});
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000831 RID: 2097 RVA: 0x00017A20 File Offset: 0x00015C20
		// (remove) Token: 0x06000832 RID: 2098 RVA: 0x00017A6C File Offset: 0x00015C6C
		public event EventHandler<InitializationFailedEventArgs> InitializationFailed
		{
			add
			{
				EventHelper.AddEventHandler<IUnityAdsInitializationListener, IUnityAdsInitializationListenerImplementor>(ref this.weak_implementor_AddInitializationListener, new Func<IUnityAdsInitializationListenerImplementor>(this.__CreateIUnityAdsInitializationListenerImplementor), new Action<IUnityAdsInitializationListener>(SdkProperties.AddInitializationListener), delegate(IUnityAdsInitializationListenerImplementor __h)
				{
					__h.OnInitializationFailedHandler = (EventHandler<InitializationFailedEventArgs>)Delegate.Combine(__h.OnInitializationFailedHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IUnityAdsInitializationListener, IUnityAdsInitializationListenerImplementor>(ref this.weak_implementor_AddInitializationListener, new Func<IUnityAdsInitializationListenerImplementor, bool>(IUnityAdsInitializationListenerImplementor.__IsEmpty), delegate(IUnityAdsInitializationListener __v)
				{
					throw new NotSupportedException("Cannot unregister from Com.Unity3d.Ads.IUnityAdsInitializationListener.AddInitializationListener");
				}, delegate(IUnityAdsInitializationListenerImplementor __h)
				{
					__h.OnInitializationFailedHandler = (EventHandler<InitializationFailedEventArgs>)Delegate.Remove(__h.OnInitializationFailedHandler, value);
				});
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00017AC8 File Offset: 0x00015CC8
		private IUnityAdsInitializationListenerImplementor __CreateIUnityAdsInitializationListenerImplementor()
		{
			return new IUnityAdsInitializationListenerImplementor(this);
		}

		// Token: 0x040001EB RID: 491
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/properties/SdkProperties", typeof(SdkProperties));

		// Token: 0x040001EC RID: 492
		private WeakReference weak_implementor_AddInitializationListener;

		// Token: 0x020000CE RID: 206
		[Register("com/unity3d/services/core/properties/SdkProperties$InitializationState", DoNotGenerateAcw = true)]
		public sealed class InitializationState : Java.Lang.Enum
		{
			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000835 RID: 2101 RVA: 0x00017AEC File Offset: 0x00015CEC
			[Register("INITIALIZED_FAILED")]
			public static SdkProperties.InitializationState InitializedFailed
			{
				get
				{
					return Java.Lang.Object.GetObject<SdkProperties.InitializationState>(SdkProperties.InitializationState._members.StaticFields.GetObjectValue("INITIALIZED_FAILED.Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000836 RID: 2102 RVA: 0x00017B1C File Offset: 0x00015D1C
			[Register("INITIALIZED_SUCCESSFULLY")]
			public static SdkProperties.InitializationState InitializedSuccessfully
			{
				get
				{
					return Java.Lang.Object.GetObject<SdkProperties.InitializationState>(SdkProperties.InitializationState._members.StaticFields.GetObjectValue("INITIALIZED_SUCCESSFULLY.Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000837 RID: 2103 RVA: 0x00017B4C File Offset: 0x00015D4C
			[Register("INITIALIZING")]
			public static SdkProperties.InitializationState Initializing
			{
				get
				{
					return Java.Lang.Object.GetObject<SdkProperties.InitializationState>(SdkProperties.InitializationState._members.StaticFields.GetObjectValue("INITIALIZING.Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000838 RID: 2104 RVA: 0x00017B7C File Offset: 0x00015D7C
			[Register("NOT_INITIALIZED")]
			public static SdkProperties.InitializationState NotInitialized
			{
				get
				{
					return Java.Lang.Object.GetObject<SdkProperties.InitializationState>(SdkProperties.InitializationState._members.StaticFields.GetObjectValue("NOT_INITIALIZED.Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000839 RID: 2105 RVA: 0x00017BAC File Offset: 0x00015DAC
			internal static IntPtr class_ref
			{
				get
				{
					return SdkProperties.InitializationState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x0600083A RID: 2106 RVA: 0x00017BD0 File Offset: 0x00015DD0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SdkProperties.InitializationState._members;
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x0600083B RID: 2107 RVA: 0x00017BD8 File Offset: 0x00015DD8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return SdkProperties.InitializationState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x0600083C RID: 2108 RVA: 0x00017BFC File Offset: 0x00015DFC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SdkProperties.InitializationState._members.ManagedPeerType;
				}
			}

			// Token: 0x0600083D RID: 2109 RVA: 0x0000256C File Offset: 0x0000076C
			internal InitializationState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600083E RID: 2110 RVA: 0x00017C08 File Offset: 0x00015E08
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;", "")]
			public unsafe static SdkProperties.InitializationState ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				SdkProperties.InitializationState @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<SdkProperties.InitializationState>(SdkProperties.InitializationState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600083F RID: 2111 RVA: 0x00017C74 File Offset: 0x00015E74
			[Register("values", "()[Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;", "")]
			public static SdkProperties.InitializationState[] Values()
			{
				return (SdkProperties.InitializationState[])JNIEnv.GetArray(SdkProperties.InitializationState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(SdkProperties.InitializationState));
			}

			// Token: 0x040001ED RID: 493
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/properties/SdkProperties$InitializationState", typeof(SdkProperties.InitializationState));
		}
	}
}
