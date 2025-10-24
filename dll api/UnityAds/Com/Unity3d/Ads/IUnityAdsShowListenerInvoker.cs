using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002CD RID: 717
	[Register("com/unity3d/ads/IUnityAdsShowListener", DoNotGenerateAcw = true)]
	internal class IUnityAdsShowListenerInvoker : Java.Lang.Object, IUnityAdsShowListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x000676D8 File Offset: 0x000658D8
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnityAdsShowListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x000676FC File Offset: 0x000658FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnityAdsShowListenerInvoker._members;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x00067703 File Offset: 0x00065903
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x0006770B File Offset: 0x0006590B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnityAdsShowListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00067717 File Offset: 0x00065917
		public static IUnityAdsShowListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnityAdsShowListener>(handle, transfer);
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00067720 File Offset: 0x00065920
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnityAdsShowListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.ads.IUnityAdsShowListener'.");
			}
			return handle;
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0006774B File Offset: 0x0006594B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0006777C File Offset: 0x0006597C
		public IUnityAdsShowListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnityAdsShowListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x000677B4 File Offset: 0x000659B4
		private static Delegate GetOnUnityAdsShowClick_Ljava_lang_String_Handler()
		{
			if (IUnityAdsShowListenerInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_ == null)
			{
				IUnityAdsShowListenerInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityAdsShowListenerInvoker.n_OnUnityAdsShowClick_Ljava_lang_String_));
			}
			return IUnityAdsShowListenerInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_;
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000677D8 File Offset: 0x000659D8
		private static void n_OnUnityAdsShowClick_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IUnityAdsShowListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowClick(@string);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000677FC File Offset: 0x000659FC
		public unsafe void OnUnityAdsShowClick(string p0)
		{
			if (this.id_onUnityAdsShowClick_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowClick_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowClick", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowClick_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0006786D File Offset: 0x00065A6D
		private static Delegate GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler()
		{
			if (IUnityAdsShowListenerInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == null)
			{
				IUnityAdsShowListenerInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IUnityAdsShowListenerInvoker.n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_));
			}
			return IUnityAdsShowListenerInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00067894 File Offset: 0x00065A94
		private static void n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IUnityAdsShowListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowCompletionState object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowComplete(@string, object2);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000678C0 File Offset: 0x00065AC0
		public unsafe void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1)
		{
			if (this.id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowComplete", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00067953 File Offset: 0x00065B53
		private static Delegate GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler()
		{
			if (IUnityAdsShowListenerInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == null)
			{
				IUnityAdsShowListenerInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IUnityAdsShowListenerInvoker.n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_));
			}
			return IUnityAdsShowListenerInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00067978 File Offset: 0x00065B78
		private static void n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IUnityAdsShowListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowFailure(@string, object2, string2);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000679B0 File Offset: 0x00065BB0
		public unsafe void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2)
		{
			if (this.id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowFailure", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00067A66 File Offset: 0x00065C66
		private static Delegate GetOnUnityAdsShowStart_Ljava_lang_String_Handler()
		{
			if (IUnityAdsShowListenerInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_ == null)
			{
				IUnityAdsShowListenerInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityAdsShowListenerInvoker.n_OnUnityAdsShowStart_Ljava_lang_String_));
			}
			return IUnityAdsShowListenerInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00067A8C File Offset: 0x00065C8C
		private static void n_OnUnityAdsShowStart_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IUnityAdsShowListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowStart(@string);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00067AB0 File Offset: 0x00065CB0
		public unsafe void OnUnityAdsShowStart(string p0)
		{
			if (this.id_onUnityAdsShowStart_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowStart_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowStart", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowStart_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400081D RID: 2077
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/IUnityAdsShowListener", typeof(IUnityAdsShowListenerInvoker));

		// Token: 0x0400081E RID: 2078
		private IntPtr class_ref;

		// Token: 0x0400081F RID: 2079
		private static Delegate cb_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000820 RID: 2080
		private IntPtr id_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000821 RID: 2081
		private static Delegate cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x04000822 RID: 2082
		private IntPtr id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x04000823 RID: 2083
		private static Delegate cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x04000824 RID: 2084
		private IntPtr id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x04000825 RID: 2085
		private static Delegate cb_onUnityAdsShowStart_Ljava_lang_String_;

		// Token: 0x04000826 RID: 2086
		private IntPtr id_onUnityAdsShowStart_Ljava_lang_String_;
	}
}
