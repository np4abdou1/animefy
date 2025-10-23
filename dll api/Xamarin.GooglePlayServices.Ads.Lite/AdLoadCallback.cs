using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x0200000F RID: 15
	[Register("com/google/android/gms/ads/AdLoadCallback", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"AdT"
	})]
	public abstract class AdLoadCallback : Java.Lang.Object
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002844 File Offset: 0x00000A44
		internal static IntPtr class_ref
		{
			get
			{
				return AdLoadCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002868 File Offset: 0x00000A68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdLoadCallback._members;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002870 File Offset: 0x00000A70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdLoadCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002894 File Offset: 0x00000A94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdLoadCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000020AC File Offset: 0x000002AC
		protected AdLoadCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000028A0 File Offset: 0x00000AA0
		[Register(".ctor", "()V", "")]
		public AdLoadCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdLoadCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdLoadCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000290E File Offset: 0x00000B0E
		private static Delegate GetOnAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_Handler()
		{
			if (AdLoadCallback.cb_onAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_ == null)
			{
				AdLoadCallback.cb_onAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdLoadCallback.n_OnAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_));
			}
			return AdLoadCallback.cb_onAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002934 File Offset: 0x00000B34
		private static void n_OnAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdLoadCallback @object = Java.Lang.Object.GetObject<AdLoadCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LoadAdError object2 = Java.Lang.Object.GetObject<LoadAdError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToLoad(object2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002958 File Offset: 0x00000B58
		[Register("onAdFailedToLoad", "(Lcom/google/android/gms/ads/LoadAdError;)V", "GetOnAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_Handler")]
		public unsafe virtual void OnAdFailedToLoad(LoadAdError p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdLoadCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAdFailedToLoad.(Lcom/google/android/gms/ads/LoadAdError;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000029BC File Offset: 0x00000BBC
		private static Delegate GetOnAdLoaded_Ljava_lang_Object_Handler()
		{
			if (AdLoadCallback.cb_onAdLoaded_Ljava_lang_Object_ == null)
			{
				AdLoadCallback.cb_onAdLoaded_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdLoadCallback.n_OnAdLoaded_Ljava_lang_Object_));
			}
			return AdLoadCallback.cb_onAdLoaded_Ljava_lang_Object_;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000029E0 File Offset: 0x00000BE0
		private static void n_OnAdLoaded_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdLoadCallback @object = Java.Lang.Object.GetObject<AdLoadCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoaded(object2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002A04 File Offset: 0x00000C04
		[Register("onAdLoaded", "(Ljava/lang/Object;)V", "GetOnAdLoaded_Ljava_lang_Object_Handler")]
		public unsafe virtual void OnAdLoaded(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdLoadCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAdLoaded.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdLoadCallback", typeof(AdLoadCallback));

		// Token: 0x0400000A RID: 10
		private static Delegate cb_onAdFailedToLoad_Lcom_google_android_gms_ads_LoadAdError_;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_onAdLoaded_Ljava_lang_Object_;
	}
}
