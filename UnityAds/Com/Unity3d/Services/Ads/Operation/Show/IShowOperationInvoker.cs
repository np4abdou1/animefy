using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Show
{
	// Token: 0x020001F0 RID: 496
	[Register("com/unity3d/services/ads/operation/show/IShowOperation", DoNotGenerateAcw = true)]
	internal class IShowOperationInvoker : Java.Lang.Object, IShowOperation, IUnityAdsShowListener, IJavaObject, IDisposable, IJavaPeerable, IAdOperation, IWebViewSharedObject
	{
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00040E5C File Offset: 0x0003F05C
		private static IntPtr java_class_ref
		{
			get
			{
				return IShowOperationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00040E80 File Offset: 0x0003F080
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IShowOperationInvoker._members;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00040E87 File Offset: 0x0003F087
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x00040E8F File Offset: 0x0003F08F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IShowOperationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00040E9B File Offset: 0x0003F09B
		public static IShowOperation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IShowOperation>(handle, transfer);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00040EA4 File Offset: 0x0003F0A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IShowOperationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.operation.show.IShowOperation'.");
			}
			return handle;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00040ECF File Offset: 0x0003F0CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00040F00 File Offset: 0x0003F100
		public IShowOperationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IShowOperationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00040F38 File Offset: 0x0003F138
		private static Delegate GetGetShowOperationStateHandler()
		{
			if (IShowOperationInvoker.cb_getShowOperationState == null)
			{
				IShowOperationInvoker.cb_getShowOperationState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IShowOperationInvoker.n_GetShowOperationState));
			}
			return IShowOperationInvoker.cb_getShowOperationState;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00040F5C File Offset: 0x0003F15C
		private static IntPtr n_GetShowOperationState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowOperationState);
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00040F70 File Offset: 0x0003F170
		public ShowOperationState ShowOperationState
		{
			get
			{
				if (this.id_getShowOperationState == IntPtr.Zero)
				{
					this.id_getShowOperationState = JNIEnv.GetMethodID(this.class_ref, "getShowOperationState", "()Lcom/unity3d/services/ads/operation/show/ShowOperationState;");
				}
				return Java.Lang.Object.GetObject<ShowOperationState>(JNIEnv.CallObjectMethod(base.Handle, this.id_getShowOperationState), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00040FC1 File Offset: 0x0003F1C1
		private static Delegate GetOnUnityAdsShowClick_Ljava_lang_String_Handler()
		{
			if (IShowOperationInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_ == null)
			{
				IShowOperationInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShowOperationInvoker.n_OnUnityAdsShowClick_Ljava_lang_String_));
			}
			return IShowOperationInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00040FE8 File Offset: 0x0003F1E8
		private static void n_OnUnityAdsShowClick_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowClick(@string);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0004100C File Offset: 0x0003F20C
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

		// Token: 0x060016B1 RID: 5809 RVA: 0x0004107D File Offset: 0x0003F27D
		private static Delegate GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler()
		{
			if (IShowOperationInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == null)
			{
				IShowOperationInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IShowOperationInvoker.n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_));
			}
			return IShowOperationInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000410A4 File Offset: 0x0003F2A4
		private static void n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowCompletionState object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowComplete(@string, object2);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000410D0 File Offset: 0x0003F2D0
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

		// Token: 0x060016B4 RID: 5812 RVA: 0x00041163 File Offset: 0x0003F363
		private static Delegate GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler()
		{
			if (IShowOperationInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == null)
			{
				IShowOperationInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IShowOperationInvoker.n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_));
			}
			return IShowOperationInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00041188 File Offset: 0x0003F388
		private static void n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowFailure(@string, object2, string2);
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000411C0 File Offset: 0x0003F3C0
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

		// Token: 0x060016B7 RID: 5815 RVA: 0x00041276 File Offset: 0x0003F476
		private static Delegate GetOnUnityAdsShowStart_Ljava_lang_String_Handler()
		{
			if (IShowOperationInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_ == null)
			{
				IShowOperationInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShowOperationInvoker.n_OnUnityAdsShowStart_Ljava_lang_String_));
			}
			return IShowOperationInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0004129C File Offset: 0x0003F49C
		private static void n_OnUnityAdsShowStart_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAdsShowListener @object = Java.Lang.Object.GetObject<IShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowStart(@string);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x000412C0 File Offset: 0x0003F4C0
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

		// Token: 0x060016BA RID: 5818 RVA: 0x00041331 File Offset: 0x0003F531
		private static Delegate GetInvoke_IarrayLjava_lang_Object_Handler()
		{
			if (IShowOperationInvoker.cb_invoke_IarrayLjava_lang_Object_ == null)
			{
				IShowOperationInvoker.cb_invoke_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IShowOperationInvoker.n_Invoke_IarrayLjava_lang_Object_));
			}
			return IShowOperationInvoker.cb_invoke_IarrayLjava_lang_Object_;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00041358 File Offset: 0x0003F558
		private static void n_Invoke_IarrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IAdOperation @object = Java.Lang.Object.GetObject<IShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(p0, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_p1);
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00041398 File Offset: 0x0003F598
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

		// Token: 0x060016BD RID: 5821 RVA: 0x00041426 File Offset: 0x0003F626
		private static Delegate GetGetIdHandler()
		{
			if (IShowOperationInvoker.cb_getId == null)
			{
				IShowOperationInvoker.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IShowOperationInvoker.n_GetId));
			}
			return IShowOperationInvoker.cb_getId;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0004144A File Offset: 0x0003F64A
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00041460 File Offset: 0x0003F660
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

		// Token: 0x0400056B RID: 1387
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/show/IShowOperation", typeof(IShowOperationInvoker));

		// Token: 0x0400056C RID: 1388
		private IntPtr class_ref;

		// Token: 0x0400056D RID: 1389
		private static Delegate cb_getShowOperationState;

		// Token: 0x0400056E RID: 1390
		private IntPtr id_getShowOperationState;

		// Token: 0x0400056F RID: 1391
		private static Delegate cb_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000570 RID: 1392
		private IntPtr id_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000571 RID: 1393
		private static Delegate cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x04000572 RID: 1394
		private IntPtr id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x04000573 RID: 1395
		private static Delegate cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x04000574 RID: 1396
		private IntPtr id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x04000575 RID: 1397
		private static Delegate cb_onUnityAdsShowStart_Ljava_lang_String_;

		// Token: 0x04000576 RID: 1398
		private IntPtr id_onUnityAdsShowStart_Ljava_lang_String_;

		// Token: 0x04000577 RID: 1399
		private static Delegate cb_invoke_IarrayLjava_lang_Object_;

		// Token: 0x04000578 RID: 1400
		private IntPtr id_invoke_IarrayLjava_lang_Object_;

		// Token: 0x04000579 RID: 1401
		private static Delegate cb_getId;

		// Token: 0x0400057A RID: 1402
		private IntPtr id_getId;
	}
}
