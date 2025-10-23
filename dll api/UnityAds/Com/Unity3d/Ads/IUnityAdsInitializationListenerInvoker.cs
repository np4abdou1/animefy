using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C4 RID: 708
	[Register("com/unity3d/ads/IUnityAdsInitializationListener", DoNotGenerateAcw = true)]
	internal class IUnityAdsInitializationListenerInvoker : Java.Lang.Object, IUnityAdsInitializationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00067008 File Offset: 0x00065208
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnityAdsInitializationListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0006702C File Offset: 0x0006522C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnityAdsInitializationListenerInvoker._members;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x00067033 File Offset: 0x00065233
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0006703B File Offset: 0x0006523B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnityAdsInitializationListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00067047 File Offset: 0x00065247
		public static IUnityAdsInitializationListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnityAdsInitializationListener>(handle, transfer);
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00067050 File Offset: 0x00065250
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnityAdsInitializationListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.ads.IUnityAdsInitializationListener'.");
			}
			return handle;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0006707B File Offset: 0x0006527B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000670AC File Offset: 0x000652AC
		public IUnityAdsInitializationListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnityAdsInitializationListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000670E4 File Offset: 0x000652E4
		private static Delegate GetOnInitializationCompleteHandler()
		{
			if (IUnityAdsInitializationListenerInvoker.cb_onInitializationComplete == null)
			{
				IUnityAdsInitializationListenerInvoker.cb_onInitializationComplete = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IUnityAdsInitializationListenerInvoker.n_OnInitializationComplete));
			}
			return IUnityAdsInitializationListenerInvoker.cb_onInitializationComplete;
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00067108 File Offset: 0x00065308
		private static void n_OnInitializationComplete(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IUnityAdsInitializationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnInitializationComplete();
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00067117 File Offset: 0x00065317
		public void OnInitializationComplete()
		{
			if (this.id_onInitializationComplete == IntPtr.Zero)
			{
				this.id_onInitializationComplete = JNIEnv.GetMethodID(this.class_ref, "onInitializationComplete", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInitializationComplete);
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00067157 File Offset: 0x00065357
		private static Delegate GetOnInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_Handler()
		{
			if (IUnityAdsInitializationListenerInvoker.cb_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_ == null)
			{
				IUnityAdsInitializationListenerInvoker.cb_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IUnityAdsInitializationListenerInvoker.n_OnInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_));
			}
			return IUnityAdsInitializationListenerInvoker.cb_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x0006717C File Offset: 0x0006537C
		private static void n_OnInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IUnityAdsInitializationListener @object = Java.Lang.Object.GetObject<IUnityAdsInitializationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsInitializationError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsInitializationError>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnInitializationFailed(object2, @string);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000671A8 File Offset: 0x000653A8
		public unsafe void OnInitializationFailed(UnityAds.UnityAdsInitializationError p0, string p1)
		{
			if (this.id_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onInitializationFailed", "(Lcom/unity3d/ads/UnityAds$UnityAdsInitializationError;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000805 RID: 2053
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/IUnityAdsInitializationListener", typeof(IUnityAdsInitializationListenerInvoker));

		// Token: 0x04000806 RID: 2054
		private IntPtr class_ref;

		// Token: 0x04000807 RID: 2055
		private static Delegate cb_onInitializationComplete;

		// Token: 0x04000808 RID: 2056
		private IntPtr id_onInitializationComplete;

		// Token: 0x04000809 RID: 2057
		private static Delegate cb_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_;

		// Token: 0x0400080A RID: 2058
		private IntPtr id_onInitializationFailed_Lcom_unity3d_ads_UnityAds_UnityAdsInitializationError_Ljava_lang_String_;
	}
}
