using System;
using System.Collections;
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
	// Token: 0x020002A6 RID: 678
	[Register("com/unity3d/scar/adapter/common/ScarAdapterBase", DoNotGenerateAcw = true)]
	public abstract class ScarAdapterBase : Java.Lang.Object, IScarAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x00063C88 File Offset: 0x00061E88
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x00063CB8 File Offset: 0x00061EB8
		[Register("_adsErrorHandler")]
		protected IAdsErrorHandler AdsErrorHandler
		{
			get
			{
				return Java.Lang.Object.GetObject<IAdsErrorHandler>(ScarAdapterBase._members.InstanceFields.GetObjectValue("_adsErrorHandler.Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdapterBase._members.InstanceFields.SetValue("_adsErrorHandler.Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x00063D04 File Offset: 0x00061F04
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x00063D34 File Offset: 0x00061F34
		[Register("_currentAdReference")]
		protected IScarAd CurrentAdReference
		{
			get
			{
				return Java.Lang.Object.GetObject<IScarAd>(ScarAdapterBase._members.InstanceFields.GetObjectValue("_currentAdReference.Lcom/unity3d/scar/adapter/common/scarads/IScarAd;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdapterBase._members.InstanceFields.SetValue("_currentAdReference.Lcom/unity3d/scar/adapter/common/scarads/IScarAd;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x00063D80 File Offset: 0x00061F80
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x00063DB0 File Offset: 0x00061FB0
		[Register("_loadedAds")]
		protected IDictionary LoadedAds
		{
			get
			{
				return JavaDictionary.FromJniHandle(ScarAdapterBase._members.InstanceFields.GetObjectValue("_loadedAds.Ljava/util/Map;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JavaDictionary.ToLocalJniHandle(value);
				try
				{
					ScarAdapterBase._members.InstanceFields.SetValue("_loadedAds.Ljava/util/Map;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x00063DFC File Offset: 0x00061FFC
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x00063E2C File Offset: 0x0006202C
		[Register("_signalCollector")]
		protected ISignalsCollector SignalCollector
		{
			get
			{
				return Java.Lang.Object.GetObject<ISignalsCollector>(ScarAdapterBase._members.InstanceFields.GetObjectValue("_signalCollector.Lcom/unity3d/scar/adapter/common/signals/ISignalsCollector;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdapterBase._members.InstanceFields.SetValue("_signalCollector.Lcom/unity3d/scar/adapter/common/signals/ISignalsCollector;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x00063E78 File Offset: 0x00062078
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdapterBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x00063E9C File Offset: 0x0006209C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapterBase._members;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x00063EA4 File Offset: 0x000620A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdapterBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x00063EC8 File Offset: 0x000620C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapterBase._members.ManagedPeerType;
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdapterBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00063ED4 File Offset: 0x000620D4
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", "")]
		public unsafe ScarAdapterBase(IAdsErrorHandler adsErrorHandler) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adsErrorHandler == null) ? IntPtr.Zero : ((Java.Lang.Object)adsErrorHandler).Handle);
				base.SetHandle(ScarAdapterBase._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarAdapterBase._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adsErrorHandler);
			}
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x00063F88 File Offset: 0x00062188
		private static Delegate GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler()
		{
			if (ScarAdapterBase.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ == null)
			{
				ScarAdapterBase.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(ScarAdapterBase.n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_));
			}
			return ScarAdapterBase.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00063FAC File Offset: 0x000621AC
		private static void n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_interstitialList, IntPtr native_rewardedList, IntPtr native_signalCompletionListener)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_interstitialList, JniHandleOwnership.DoNotTransfer, typeof(string));
			string[] array2 = (string[])JNIEnv.GetArray(native_rewardedList, JniHandleOwnership.DoNotTransfer, typeof(string));
			ISignalCollectionListener object3 = Java.Lang.Object.GetObject<ISignalCollectionListener>(native_signalCompletionListener, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignals(object2, array, array2, object3);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_interstitialList);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_rewardedList);
			}
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00064020 File Offset: 0x00062220
		[Register("getSCARSignals", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V", "GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler")]
		public unsafe virtual void GetSCARSignals(Context context, string[] interstitialList, string[] rewardedList, ISignalCollectionListener signalCompletionListener)
		{
			IntPtr intPtr = JNIEnv.NewArray(interstitialList);
			IntPtr intPtr2 = JNIEnv.NewArray(rewardedList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((signalCompletionListener == null) ? IntPtr.Zero : ((Java.Lang.Object)signalCompletionListener).Handle);
				ScarAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("getSCARSignals.(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V", this, ptr);
			}
			finally
			{
				if (interstitialList != null)
				{
					JNIEnv.CopyArray(intPtr, interstitialList);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (rewardedList != null)
				{
					JNIEnv.CopyArray(intPtr2, rewardedList);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(context);
				GC.KeepAlive(interstitialList);
				GC.KeepAlive(rewardedList);
				GC.KeepAlive(signalCompletionListener);
			}
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0006411C File Offset: 0x0006231C
		private static Delegate GetShow_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (ScarAdapterBase.cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				ScarAdapterBase.cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapterBase.n_Show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_));
			}
			return ScarAdapterBase.cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00064140 File Offset: 0x00062340
		private static void n_Show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_queryId, IntPtr native_placementId)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_queryId, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, @string, string2);
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00064178 File Offset: 0x00062378
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)V", "GetShow_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void Show(Activity activity, string queryId, string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(queryId);
			IntPtr intPtr2 = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ScarAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00064220 File Offset: 0x00062420
		private static Delegate GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler()
		{
			if (ScarAdapterBase.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ == null)
			{
				ScarAdapterBase.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapterBase.n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_));
			}
			return ScarAdapterBase.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00064244 File Offset: 0x00062444
		private static void n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_p1, JniHandleOwnership.DoNotTransfer);
			IScarInterstitialAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x060026DC RID: 9948
		[Register("loadInterstitialAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper;)V", "GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler")]
		public abstract void LoadInterstitialAd(Context p0, ScarAdMetadata p1, IScarInterstitialAdListenerWrapper p2);

		// Token: 0x060026DD RID: 9949 RVA: 0x0006427A File Offset: 0x0006247A
		private static Delegate GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler()
		{
			if (ScarAdapterBase.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ == null)
			{
				ScarAdapterBase.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapterBase.n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_));
			}
			return ScarAdapterBase.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x000642A0 File Offset: 0x000624A0
		private static void n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_p1, JniHandleOwnership.DoNotTransfer);
			IScarRewardedAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x060026DF RID: 9951
		[Register("loadRewardedAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper;)V", "GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler")]
		public abstract void LoadRewardedAd(Context p0, ScarAdMetadata p1, IScarRewardedAdListenerWrapper p2);

		// Token: 0x040007AF RID: 1967
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/ScarAdapterBase", typeof(ScarAdapterBase));

		// Token: 0x040007B0 RID: 1968
		private static Delegate cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;

		// Token: 0x040007B1 RID: 1969
		private static Delegate cb_show_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040007B2 RID: 1970
		private static Delegate cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;

		// Token: 0x040007B3 RID: 1971
		private static Delegate cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
	}
}
