using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x0200002E RID: 46
	[Register("com/google/android/gms/ads/rewarded/RewardedAd", DoNotGenerateAcw = true)]
	internal class RewardedAdInvoker : RewardedAd
	{
		// Token: 0x060001CF RID: 463 RVA: 0x000061C3 File Offset: 0x000043C3
		public RewardedAdInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000061CD File Offset: 0x000043CD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RewardedAdInvoker._members;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000061D4 File Offset: 0x000043D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RewardedAdInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000061E0 File Offset: 0x000043E0
		public override Bundle AdMetadata
		{
			[Register("getAdMetadata", "()Landroid/os/Bundle;", "GetGetAdMetadataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(RewardedAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdMetadata.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00006214 File Offset: 0x00004414
		public override string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(RewardedAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00006248 File Offset: 0x00004448
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000627C File Offset: 0x0000447C
		public unsafe override FullScreenContentCallback FullScreenContentCallback
		{
			[Register("getFullScreenContentCallback", "()Lcom/google/android/gms/ads/FullScreenContentCallback;", "GetGetFullScreenContentCallbackHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FullScreenContentCallback>(RewardedAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getFullScreenContentCallback.()Lcom/google/android/gms/ads/FullScreenContentCallback;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setFullScreenContentCallback", "(Lcom/google/android/gms/ads/FullScreenContentCallback;)V", "GetSetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					RewardedAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setFullScreenContentCallback.(Lcom/google/android/gms/ads/FullScreenContentCallback;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000062E0 File Offset: 0x000044E0
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00006314 File Offset: 0x00004514
		public unsafe override IOnAdMetadataChangedListener OnAdMetadataChangedListener
		{
			[Register("getOnAdMetadataChangedListener", "()Lcom/google/android/gms/ads/rewarded/OnAdMetadataChangedListener;", "GetGetOnAdMetadataChangedListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IOnAdMetadataChangedListener>(RewardedAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getOnAdMetadataChangedListener.()Lcom/google/android/gms/ads/rewarded/OnAdMetadataChangedListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setOnAdMetadataChangedListener", "(Lcom/google/android/gms/ads/rewarded/OnAdMetadataChangedListener;)V", "GetSetOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					RewardedAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setOnAdMetadataChangedListener.(Lcom/google/android/gms/ads/rewarded/OnAdMetadataChangedListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000637C File Offset: 0x0000457C
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000063B0 File Offset: 0x000045B0
		public unsafe override IOnPaidEventListener OnPaidEventListener
		{
			[Register("getOnPaidEventListener", "()Lcom/google/android/gms/ads/OnPaidEventListener;", "GetGetOnPaidEventListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IOnPaidEventListener>(RewardedAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getOnPaidEventListener.()Lcom/google/android/gms/ads/OnPaidEventListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setOnPaidEventListener", "(Lcom/google/android/gms/ads/OnPaidEventListener;)V", "GetSetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					RewardedAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setOnPaidEventListener.(Lcom/google/android/gms/ads/OnPaidEventListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00006418 File Offset: 0x00004618
		public override ResponseInfo ResponseInfo
		{
			[Register("getResponseInfo", "()Lcom/google/android/gms/ads/ResponseInfo;", "GetGetResponseInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ResponseInfo>(RewardedAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getResponseInfo.()Lcom/google/android/gms/ads/ResponseInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000644C File Offset: 0x0000464C
		public override IRewardItem RewardItem
		{
			[Register("getRewardItem", "()Lcom/google/android/gms/ads/rewarded/RewardItem;", "GetGetRewardItemHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IRewardItem>(RewardedAdInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getRewardItem.()Lcom/google/android/gms/ads/rewarded/RewardItem;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006480 File Offset: 0x00004680
		[Register("setImmersiveMode", "(Z)V", "GetSetImmersiveMode_ZHandler")]
		public unsafe override void SetImmersiveMode(bool p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			RewardedAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setImmersiveMode.(Z)V", this, ptr);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000064BC File Offset: 0x000046BC
		[Register("setServerSideVerificationOptions", "(Lcom/google/android/gms/ads/rewarded/ServerSideVerificationOptions;)V", "GetSetServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_Handler")]
		public unsafe override void SetServerSideVerificationOptions(ServerSideVerificationOptions p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				RewardedAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setServerSideVerificationOptions.(Lcom/google/android/gms/ads/rewarded/ServerSideVerificationOptions;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006520 File Offset: 0x00004720
		[Register("show", "(Landroid/app/Activity;Lcom/google/android/gms/ads/OnUserEarnedRewardListener;)V", "GetShow_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_Handler")]
		public unsafe override void Show(Activity p0, IOnUserEarnedRewardListener p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				RewardedAdInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("show.(Landroid/app/Activity;Lcom/google/android/gms/ads/OnUserEarnedRewardListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/RewardedAd", typeof(RewardedAdInvoker));
	}
}
