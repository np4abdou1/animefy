using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001F9 RID: 505
	[Register("com/unity3d/services/ads/operation/load/ILoadOperation", DoNotGenerateAcw = true)]
	internal class ILoadOperationInvoker : Java.Lang.Object, ILoadOperation, IUnityAdsLoadListener, IJavaObject, IDisposable, IJavaPeerable, IAdOperation, IWebViewSharedObject
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x00043670 File Offset: 0x00041870
		private static IntPtr java_class_ref
		{
			get
			{
				return ILoadOperationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x00043694 File Offset: 0x00041894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILoadOperationInvoker._members;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0004369B File Offset: 0x0004189B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x000436A3 File Offset: 0x000418A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILoadOperationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000436AF File Offset: 0x000418AF
		public static ILoadOperation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILoadOperation>(handle, transfer);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000436B8 File Offset: 0x000418B8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILoadOperationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.operation.load.ILoadOperation'.");
			}
			return handle;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000436E3 File Offset: 0x000418E3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00043714 File Offset: 0x00041914
		public ILoadOperationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILoadOperationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0004374C File Offset: 0x0004194C
		private static Delegate GetGetLoadOperationStateHandler()
		{
			if (ILoadOperationInvoker.cb_getLoadOperationState == null)
			{
				ILoadOperationInvoker.cb_getLoadOperationState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILoadOperationInvoker.n_GetLoadOperationState));
			}
			return ILoadOperationInvoker.cb_getLoadOperationState;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00043770 File Offset: 0x00041970
		private static IntPtr n_GetLoadOperationState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadOperationState);
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00043784 File Offset: 0x00041984
		public LoadOperationState LoadOperationState
		{
			get
			{
				if (this.id_getLoadOperationState == IntPtr.Zero)
				{
					this.id_getLoadOperationState = JNIEnv.GetMethodID(this.class_ref, "getLoadOperationState", "()Lcom/unity3d/services/ads/operation/load/LoadOperationState;");
				}
				return Java.Lang.Object.GetObject<LoadOperationState>(JNIEnv.CallObjectMethod(base.Handle, this.id_getLoadOperationState), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x000437D5 File Offset: 0x000419D5
		private static Delegate GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler()
		{
			if (ILoadOperationInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_ == null)
			{
				ILoadOperationInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ILoadOperationInvoker.n_OnUnityAdsAdLoaded_Ljava_lang_String_));
			}
			return ILoadOperationInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000437FC File Offset: 0x000419FC
		private static void n_OnUnityAdsAdLoaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAdsLoadListener @object = Java.Lang.Object.GetObject<ILoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsAdLoaded(@string);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00043820 File Offset: 0x00041A20
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

		// Token: 0x0600176D RID: 5997 RVA: 0x00043891 File Offset: 0x00041A91
		private static Delegate GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler()
		{
			if (ILoadOperationInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == null)
			{
				ILoadOperationInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ILoadOperationInvoker.n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_));
			}
			return ILoadOperationInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000438B8 File Offset: 0x00041AB8
		private static void n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IUnityAdsLoadListener @object = Java.Lang.Object.GetObject<ILoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsLoadError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsFailedToLoad(@string, object2, string2);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000438F0 File Offset: 0x00041AF0
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

		// Token: 0x06001770 RID: 6000 RVA: 0x000439A6 File Offset: 0x00041BA6
		private static Delegate GetInvoke_IarrayLjava_lang_Object_Handler()
		{
			if (ILoadOperationInvoker.cb_invoke_IarrayLjava_lang_Object_ == null)
			{
				ILoadOperationInvoker.cb_invoke_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(ILoadOperationInvoker.n_Invoke_IarrayLjava_lang_Object_));
			}
			return ILoadOperationInvoker.cb_invoke_IarrayLjava_lang_Object_;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x000439CC File Offset: 0x00041BCC
		private static void n_Invoke_IarrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IAdOperation @object = Java.Lang.Object.GetObject<ILoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(p0, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_p1);
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00043A0C File Offset: 0x00041C0C
		public unsafe void Invoke(int p0, params Java.Lang.Object[] p1)
		{
			if (this.id_invoke_IarrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(I[Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invoke_IarrayLjava_lang_Object_, ptr);
			if (p1 != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr, p1);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00043A9A File Offset: 0x00041C9A
		private static Delegate GetGetIdHandler()
		{
			if (ILoadOperationInvoker.cb_getId == null)
			{
				ILoadOperationInvoker.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILoadOperationInvoker.n_GetId));
			}
			return ILoadOperationInvoker.cb_getId;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00043ABE File Offset: 0x00041CBE
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x00043AD4 File Offset: 0x00041CD4
		public string Id
		{
			get
			{
				if (this.id_getId == IntPtr.Zero)
				{
					this.id_getId = JNIEnv.GetMethodID(this.class_ref, "getId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040005AA RID: 1450
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/ILoadOperation", typeof(ILoadOperationInvoker));

		// Token: 0x040005AB RID: 1451
		private IntPtr class_ref;

		// Token: 0x040005AC RID: 1452
		private static Delegate cb_getLoadOperationState;

		// Token: 0x040005AD RID: 1453
		private IntPtr id_getLoadOperationState;

		// Token: 0x040005AE RID: 1454
		private static Delegate cb_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x040005AF RID: 1455
		private IntPtr id_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x040005B0 RID: 1456
		private static Delegate cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;

		// Token: 0x040005B1 RID: 1457
		private IntPtr id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;

		// Token: 0x040005B2 RID: 1458
		private static Delegate cb_invoke_IarrayLjava_lang_Object_;

		// Token: 0x040005B3 RID: 1459
		private IntPtr id_invoke_IarrayLjava_lang_Object_;

		// Token: 0x040005B4 RID: 1460
		private static Delegate cb_getId;

		// Token: 0x040005B5 RID: 1461
		private IntPtr id_getId;
	}
}
