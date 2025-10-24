using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Com.Unity3d.Scar.Adapter.Common.Signals;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x0200029C RID: 668
	[Register("com/unity3d/scar/adapter/common/IScarAdapter", DoNotGenerateAcw = true)]
	internal class IScarAdapterInvoker : Java.Lang.Object, IScarAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x00062450 File Offset: 0x00060650
		private static IntPtr java_class_ref
		{
			get
			{
				return IScarAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00062474 File Offset: 0x00060674
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScarAdapterInvoker._members;
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x0006247B File Offset: 0x0006067B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x00062483 File Offset: 0x00060683
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScarAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0006248F File Offset: 0x0006068F
		public static IScarAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScarAdapter>(handle, transfer);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00062498 File Offset: 0x00060698
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScarAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.IScarAdapter'.");
			}
			return handle;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000624C3 File Offset: 0x000606C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000624F4 File Offset: 0x000606F4
		public IScarAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScarAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0006252C File Offset: 0x0006072C
		private static Delegate GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler()
		{
			if (IScarAdapterInvoker.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ == null)
			{
				IScarAdapterInvoker.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(IScarAdapterInvoker.n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_));
			}
			return IScarAdapterInvoker.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00062550 File Offset: 0x00060750
		private static void n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			IScarAdapter @object = Java.Lang.Object.GetObject<IScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(string));
			string[] array2 = (string[])JNIEnv.GetArray(native_p2, JniHandleOwnership.DoNotTransfer, typeof(string));
			ISignalCollectionListener object3 = Java.Lang.Object.GetObject<ISignalCollectionListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignals(object2, array, array2, object3);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p1);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_p2);
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000625C4 File Offset: 0x000607C4
		public unsafe void GetSCARSignals(Context p0, string[] p1, string[] p2, ISignalCollectionListener p3)
		{
			if (this.id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ == IntPtr.Zero)
			{
				this.id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ = JNIEnv.GetMethodID(this.class_ref, "getSCARSignals", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(p1);
			IntPtr intPtr2 = JNIEnv.NewArray(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(intPtr2);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_, ptr);
			if (p1 != null)
			{
				JNIEnv.CopyArray(intPtr, p1);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (p2 != null)
			{
				JNIEnv.CopyArray(intPtr2, p2);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000626BA File Offset: 0x000608BA
		private static Delegate GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler()
		{
			if (IScarAdapterInvoker.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ == null)
			{
				IScarAdapterInvoker.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IScarAdapterInvoker.n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_));
			}
			return IScarAdapterInvoker.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000626E0 File Offset: 0x000608E0
		private static void n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IScarAdapter @object = Java.Lang.Object.GetObject<IScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_p1, JniHandleOwnership.DoNotTransfer);
			IScarInterstitialAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00062718 File Offset: 0x00060918
		public unsafe void LoadInterstitialAd(Context p0, ScarAdMetadata p1, IScarInterstitialAdListenerWrapper p2)
		{
			if (this.id_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ == IntPtr.Zero)
			{
				this.id_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ = JNIEnv.GetMethodID(this.class_ref, "loadInterstitialAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_, ptr);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000627D7 File Offset: 0x000609D7
		private static Delegate GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler()
		{
			if (IScarAdapterInvoker.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ == null)
			{
				IScarAdapterInvoker.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IScarAdapterInvoker.n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_));
			}
			return IScarAdapterInvoker.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000627FC File Offset: 0x000609FC
		private static void n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IScarAdapter @object = Java.Lang.Object.GetObject<IScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_p1, JniHandleOwnership.DoNotTransfer);
			IScarRewardedAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00062834 File Offset: 0x00060A34
		public unsafe void LoadRewardedAd(Context p0, ScarAdMetadata p1, IScarRewardedAdListenerWrapper p2)
		{
			if (this.id_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ == IntPtr.Zero)
			{
				this.id_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ = JNIEnv.GetMethodID(this.class_ref, "loadRewardedAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_, ptr);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000628F3 File Offset: 0x00060AF3
		private static Delegate GetShow_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (IScarAdapterInvoker.cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				IScarAdapterInvoker.cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IScarAdapterInvoker.n_Show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_));
			}
			return IScarAdapterInvoker.cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00062918 File Offset: 0x00060B18
		private static void n_Show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IScarAdapter @object = Java.Lang.Object.GetObject<IScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, @string, string2);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00062950 File Offset: 0x00060B50
		public unsafe void Show(Activity p0, string p1, string p2)
		{
			if (this.id_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "show", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x04000766 RID: 1894
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/IScarAdapter", typeof(IScarAdapterInvoker));

		// Token: 0x04000767 RID: 1895
		private IntPtr class_ref;

		// Token: 0x04000768 RID: 1896
		private static Delegate cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;

		// Token: 0x04000769 RID: 1897
		private IntPtr id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;

		// Token: 0x0400076A RID: 1898
		private static Delegate cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;

		// Token: 0x0400076B RID: 1899
		private IntPtr id_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;

		// Token: 0x0400076C RID: 1900
		private static Delegate cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;

		// Token: 0x0400076D RID: 1901
		private IntPtr id_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;

		// Token: 0x0400076E RID: 1902
		private static Delegate cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x0400076F RID: 1903
		private IntPtr id_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
	}
}
