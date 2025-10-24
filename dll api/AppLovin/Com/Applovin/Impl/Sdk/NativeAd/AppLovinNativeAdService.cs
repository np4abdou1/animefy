using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000144 RID: 324
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdService", DoNotGenerateAcw = true)]
	public class AppLovinNativeAdService : Java.Lang.Object
	{
		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0002E518 File Offset: 0x0002C718
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinNativeAdService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0002E53C File Offset: 0x0002C73C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinNativeAdService._members;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0002E544 File Offset: 0x0002C744
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinNativeAdService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0002E568 File Offset: 0x0002C768
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinNativeAdService._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinNativeAdService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0002E574 File Offset: 0x0002C774
		private static Delegate GetLoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_Handler()
		{
			if (AppLovinNativeAdService.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_ == null)
			{
				AppLovinNativeAdService.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinNativeAdService.n_LoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_));
			}
			return AppLovinNativeAdService.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0002E598 File Offset: 0x0002C798
		private static void n_LoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinNativeAdService @object = Java.Lang.Object.GetObject<AppLovinNativeAdService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinNativeAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinNativeAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAdForAdToken(@string, object2);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0002E5C4 File Offset: 0x0002C7C4
		[Register("loadNextAdForAdToken", "(Ljava/lang/String;Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdLoadListener;)V", "GetLoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_Handler")]
		public unsafe virtual void LoadNextAdForAdToken(string p0, IAppLovinNativeAdLoadListener p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinNativeAdService._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextAdForAdToken.(Ljava/lang/String;Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdLoadListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x04000530 RID: 1328
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdService", typeof(AppLovinNativeAdService));

		// Token: 0x04000531 RID: 1329
		private static Delegate cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdLoadListener_;
	}
}
