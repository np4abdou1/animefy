using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Interstitial
{
	// Token: 0x02000035 RID: 53
	[Register("com/google/android/gms/ads/interstitial/InterstitialAd", DoNotGenerateAcw = true)]
	internal class InterstitialAdInvoker : InterstitialAd
	{
		// Token: 0x06000220 RID: 544 RVA: 0x00006CDF File Offset: 0x00004EDF
		public InterstitialAdInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00006CE9 File Offset: 0x00004EE9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InterstitialAdInvoker._members;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InterstitialAdInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00006CFC File Offset: 0x00004EFC
		public override string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00006D30 File Offset: 0x00004F30
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00006D64 File Offset: 0x00004F64
		public unsafe override FullScreenContentCallback FullScreenContentCallback
		{
			[Register("getFullScreenContentCallback", "()Lcom/google/android/gms/ads/FullScreenContentCallback;", "GetGetFullScreenContentCallbackHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FullScreenContentCallback>(InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getFullScreenContentCallback.()Lcom/google/android/gms/ads/FullScreenContentCallback;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setFullScreenContentCallback", "(Lcom/google/android/gms/ads/FullScreenContentCallback;)V", "GetSetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setFullScreenContentCallback.(Lcom/google/android/gms/ads/FullScreenContentCallback;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00006DC8 File Offset: 0x00004FC8
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00006DFC File Offset: 0x00004FFC
		public unsafe override IOnPaidEventListener OnPaidEventListener
		{
			[Register("getOnPaidEventListener", "()Lcom/google/android/gms/ads/OnPaidEventListener;", "GetGetOnPaidEventListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IOnPaidEventListener>(InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getOnPaidEventListener.()Lcom/google/android/gms/ads/OnPaidEventListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setOnPaidEventListener", "(Lcom/google/android/gms/ads/OnPaidEventListener;)V", "GetSetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setOnPaidEventListener.(Lcom/google/android/gms/ads/OnPaidEventListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00006E64 File Offset: 0x00005064
		public override ResponseInfo ResponseInfo
		{
			[Register("getResponseInfo", "()Lcom/google/android/gms/ads/ResponseInfo;", "GetGetResponseInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ResponseInfo>(InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getResponseInfo.()Lcom/google/android/gms/ads/ResponseInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00006E98 File Offset: 0x00005098
		[Register("setImmersiveMode", "(Z)V", "GetSetImmersiveMode_ZHandler")]
		public unsafe override void SetImmersiveMode(bool p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setImmersiveMode.(Z)V", this, ptr);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00006ED4 File Offset: 0x000050D4
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public unsafe override void Show(Activity p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				InterstitialAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("show.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000084 RID: 132
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/interstitial/InterstitialAd", typeof(InterstitialAdInvoker));
	}
}
