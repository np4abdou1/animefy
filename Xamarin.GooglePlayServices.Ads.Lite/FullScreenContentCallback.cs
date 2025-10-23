using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x02000014 RID: 20
	[Register("com/google/android/gms/ads/FullScreenContentCallback", DoNotGenerateAcw = true)]
	public abstract class FullScreenContentCallback : Java.Lang.Object
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003B30 File Offset: 0x00001D30
		internal static IntPtr class_ref
		{
			get
			{
				return FullScreenContentCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00003B54 File Offset: 0x00001D54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FullScreenContentCallback._members;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003B5C File Offset: 0x00001D5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FullScreenContentCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00003B80 File Offset: 0x00001D80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FullScreenContentCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000020AC File Offset: 0x000002AC
		protected FullScreenContentCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003B8C File Offset: 0x00001D8C
		[Register(".ctor", "()V", "")]
		public FullScreenContentCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FullScreenContentCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FullScreenContentCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003BFA File Offset: 0x00001DFA
		private static Delegate GetOnAdClickedHandler()
		{
			if (FullScreenContentCallback.cb_onAdClicked == null)
			{
				FullScreenContentCallback.cb_onAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FullScreenContentCallback.n_OnAdClicked));
			}
			return FullScreenContentCallback.cb_onAdClicked;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003C1E File Offset: 0x00001E1E
		private static void n_OnAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FullScreenContentCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClicked();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003C2D File Offset: 0x00001E2D
		[Register("onAdClicked", "()V", "GetOnAdClickedHandler")]
		public virtual void OnAdClicked()
		{
			FullScreenContentCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAdClicked.()V", this, null);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003C46 File Offset: 0x00001E46
		private static Delegate GetOnAdDismissedFullScreenContentHandler()
		{
			if (FullScreenContentCallback.cb_onAdDismissedFullScreenContent == null)
			{
				FullScreenContentCallback.cb_onAdDismissedFullScreenContent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FullScreenContentCallback.n_OnAdDismissedFullScreenContent));
			}
			return FullScreenContentCallback.cb_onAdDismissedFullScreenContent;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003C6A File Offset: 0x00001E6A
		private static void n_OnAdDismissedFullScreenContent(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FullScreenContentCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdDismissedFullScreenContent();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003C79 File Offset: 0x00001E79
		[Register("onAdDismissedFullScreenContent", "()V", "GetOnAdDismissedFullScreenContentHandler")]
		public virtual void OnAdDismissedFullScreenContent()
		{
			FullScreenContentCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAdDismissedFullScreenContent.()V", this, null);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003C92 File Offset: 0x00001E92
		private static Delegate GetOnAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_Handler()
		{
			if (FullScreenContentCallback.cb_onAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_ == null)
			{
				FullScreenContentCallback.cb_onAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FullScreenContentCallback.n_OnAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_));
			}
			return FullScreenContentCallback.cb_onAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003CB8 File Offset: 0x00001EB8
		private static void n_OnAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			FullScreenContentCallback @object = Java.Lang.Object.GetObject<FullScreenContentCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdError object2 = Java.Lang.Object.GetObject<AdError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToShowFullScreenContent(object2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003CDC File Offset: 0x00001EDC
		[Register("onAdFailedToShowFullScreenContent", "(Lcom/google/android/gms/ads/AdError;)V", "GetOnAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_Handler")]
		public unsafe virtual void OnAdFailedToShowFullScreenContent(AdError p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				FullScreenContentCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAdFailedToShowFullScreenContent.(Lcom/google/android/gms/ads/AdError;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003D40 File Offset: 0x00001F40
		private static Delegate GetOnAdImpressionHandler()
		{
			if (FullScreenContentCallback.cb_onAdImpression == null)
			{
				FullScreenContentCallback.cb_onAdImpression = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FullScreenContentCallback.n_OnAdImpression));
			}
			return FullScreenContentCallback.cb_onAdImpression;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003D64 File Offset: 0x00001F64
		private static void n_OnAdImpression(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FullScreenContentCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdImpression();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003D73 File Offset: 0x00001F73
		[Register("onAdImpression", "()V", "GetOnAdImpressionHandler")]
		public virtual void OnAdImpression()
		{
			FullScreenContentCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAdImpression.()V", this, null);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003D8C File Offset: 0x00001F8C
		private static Delegate GetOnAdShowedFullScreenContentHandler()
		{
			if (FullScreenContentCallback.cb_onAdShowedFullScreenContent == null)
			{
				FullScreenContentCallback.cb_onAdShowedFullScreenContent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FullScreenContentCallback.n_OnAdShowedFullScreenContent));
			}
			return FullScreenContentCallback.cb_onAdShowedFullScreenContent;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003DB0 File Offset: 0x00001FB0
		private static void n_OnAdShowedFullScreenContent(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FullScreenContentCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdShowedFullScreenContent();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003DBF File Offset: 0x00001FBF
		[Register("onAdShowedFullScreenContent", "()V", "GetOnAdShowedFullScreenContentHandler")]
		public virtual void OnAdShowedFullScreenContent()
		{
			FullScreenContentCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAdShowedFullScreenContent.()V", this, null);
		}

		// Token: 0x04000022 RID: 34
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/FullScreenContentCallback", typeof(FullScreenContentCallback));

		// Token: 0x04000023 RID: 35
		private static Delegate cb_onAdClicked;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_onAdDismissedFullScreenContent;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_onAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_onAdImpression;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_onAdShowedFullScreenContent;
	}
}
