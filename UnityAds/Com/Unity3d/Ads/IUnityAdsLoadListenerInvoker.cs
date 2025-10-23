using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C8 RID: 712
	[Register("com/unity3d/ads/IUnityAdsLoadListener", DoNotGenerateAcw = true)]
	internal class IUnityAdsLoadListenerInvoker : Java.Lang.Object, IUnityAdsLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x00067320 File Offset: 0x00065520
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnityAdsLoadListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x00067344 File Offset: 0x00065544
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnityAdsLoadListenerInvoker._members;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x0006734B File Offset: 0x0006554B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x00067353 File Offset: 0x00065553
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnityAdsLoadListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x0006735F File Offset: 0x0006555F
		public static IUnityAdsLoadListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnityAdsLoadListener>(handle, transfer);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00067368 File Offset: 0x00065568
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnityAdsLoadListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.ads.IUnityAdsLoadListener'.");
			}
			return handle;
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00067393 File Offset: 0x00065593
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000673C4 File Offset: 0x000655C4
		public IUnityAdsLoadListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnityAdsLoadListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000673FC File Offset: 0x000655FC
		private static Delegate GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler()
		{
			if (IUnityAdsLoadListenerInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_ == null)
			{
				IUnityAdsLoadListenerInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityAdsLoadListenerInvoker.n_OnUnityAdsAdLoaded_Ljava_lang_String_));
			}
			return IUnityAdsLoadListenerInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_;
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00067420 File Offset: 0x00065620
		private static void n_OnUnityAdsAdLoaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAdsLoadListener @object = Java.Lang.Object.GetObject<IUnityAdsLoadListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsAdLoaded(@string);
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00067444 File Offset: 0x00065644
		public unsafe void OnUnityAdsAdLoaded(string p0)
		{
			if (this.id_onUnityAdsAdLoaded_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsAdLoaded_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsAdLoaded", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsAdLoaded_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000674B5 File Offset: 0x000656B5
		private static Delegate GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler()
		{
			if (IUnityAdsLoadListenerInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == null)
			{
				IUnityAdsLoadListenerInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IUnityAdsLoadListenerInvoker.n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_));
			}
			return IUnityAdsLoadListenerInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000674DC File Offset: 0x000656DC
		private static void n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IUnityAdsLoadListener @object = Java.Lang.Object.GetObject<IUnityAdsLoadListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsLoadError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsFailedToLoad(@string, object2, string2);
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00067514 File Offset: 0x00065714
		public unsafe void OnUnityAdsFailedToLoad(string p0, UnityAds.UnityAdsLoadError p1, string p2)
		{
			if (this.id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsFailedToLoad", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x04000810 RID: 2064
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/IUnityAdsLoadListener", typeof(IUnityAdsLoadListenerInvoker));

		// Token: 0x04000811 RID: 2065
		private IntPtr class_ref;

		// Token: 0x04000812 RID: 2066
		private static Delegate cb_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x04000813 RID: 2067
		private IntPtr id_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x04000814 RID: 2068
		private static Delegate cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;

		// Token: 0x04000815 RID: 2069
		private IntPtr id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
	}
}
