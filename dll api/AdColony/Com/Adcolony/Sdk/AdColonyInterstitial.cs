using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000044 RID: 68
	[Register("com/adcolony/sdk/AdColonyInterstitial", DoNotGenerateAcw = true)]
	public class AdColonyInterstitial : Java.Lang.Object
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000A5F4 File Offset: 0x000087F4
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyInterstitial._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000A618 File Offset: 0x00008818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyInterstitial._members;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000A620 File Offset: 0x00008820
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyInterstitial._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000A644 File Offset: 0x00008844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyInterstitial._members.ManagedPeerType;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyInterstitial(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000A650 File Offset: 0x00008850
		private static Delegate GetIsExpiredHandler()
		{
			if (AdColonyInterstitial.cb_isExpired == null)
			{
				AdColonyInterstitial.cb_isExpired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyInterstitial.n_IsExpired));
			}
			return AdColonyInterstitial.cb_isExpired;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000A674 File Offset: 0x00008874
		private static bool n_IsExpired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExpired;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000A683 File Offset: 0x00008883
		public virtual bool IsExpired
		{
			[Register("isExpired", "()Z", "GetIsExpiredHandler")]
			get
			{
				return AdColonyInterstitial._members.InstanceMethods.InvokeVirtualBooleanMethod("isExpired.()Z", this, null);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000A69C File Offset: 0x0000889C
		private static Delegate GetGetListenerHandler()
		{
			if (AdColonyInterstitial.cb_getListener == null)
			{
				AdColonyInterstitial.cb_getListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyInterstitial.n_GetListener));
			}
			return AdColonyInterstitial.cb_getListener;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000A6C0 File Offset: 0x000088C0
		private static IntPtr n_GetListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Listener);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000A6D4 File Offset: 0x000088D4
		private static Delegate GetSetListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_Handler()
		{
			if (AdColonyInterstitial.cb_setListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_ == null)
			{
				AdColonyInterstitial.cb_setListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitial.n_SetListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_));
			}
			return AdColonyInterstitial.cb_setListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000A6F8 File Offset: 0x000088F8
		private static void n_SetListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			AdColonyInterstitial @object = Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitialListener object2 = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.Listener = object2;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000A71C File Offset: 0x0000891C
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000A750 File Offset: 0x00008950
		public unsafe virtual AdColonyInterstitialListener Listener
		{
			[Register("getListener", "()Lcom/adcolony/sdk/AdColonyInterstitialListener;", "GetGetListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdColonyInterstitialListener>(AdColonyInterstitial._members.InstanceMethods.InvokeVirtualObjectMethod("getListener.()Lcom/adcolony/sdk/AdColonyInterstitialListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setListener", "(Lcom/adcolony/sdk/AdColonyInterstitialListener;)V", "GetSetListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AdColonyInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/adcolony/sdk/AdColonyInterstitialListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000A7B4 File Offset: 0x000089B4
		private static Delegate GetGetViewNetworkPassFilterHandler()
		{
			if (AdColonyInterstitial.cb_getViewNetworkPassFilter == null)
			{
				AdColonyInterstitial.cb_getViewNetworkPassFilter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyInterstitial.n_GetViewNetworkPassFilter));
			}
			return AdColonyInterstitial.cb_getViewNetworkPassFilter;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000A7D8 File Offset: 0x000089D8
		private static IntPtr n_GetViewNetworkPassFilter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewNetworkPassFilter);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000A7EC File Offset: 0x000089EC
		private static Delegate GetSetViewNetworkPassFilter_Ljava_lang_String_Handler()
		{
			if (AdColonyInterstitial.cb_setViewNetworkPassFilter_Ljava_lang_String_ == null)
			{
				AdColonyInterstitial.cb_setViewNetworkPassFilter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitial.n_SetViewNetworkPassFilter_Ljava_lang_String_));
			}
			return AdColonyInterstitial.cb_setViewNetworkPassFilter_Ljava_lang_String_;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000A810 File Offset: 0x00008A10
		private static void n_SetViewNetworkPassFilter_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewNetworkPassFilter)
		{
			AdColonyInterstitial @object = Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewNetworkPassFilter, JniHandleOwnership.DoNotTransfer);
			@object.ViewNetworkPassFilter = @string;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000A834 File Offset: 0x00008A34
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0000A868 File Offset: 0x00008A68
		public unsafe virtual string ViewNetworkPassFilter
		{
			[Register("getViewNetworkPassFilter", "()Ljava/lang/String;", "GetGetViewNetworkPassFilterHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyInterstitial._members.InstanceMethods.InvokeVirtualObjectMethod("getViewNetworkPassFilter.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setViewNetworkPassFilter", "(Ljava/lang/String;)V", "GetSetViewNetworkPassFilter_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AdColonyInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("setViewNetworkPassFilter.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		private static Delegate GetGetZoneIDHandler()
		{
			if (AdColonyInterstitial.cb_getZoneID == null)
			{
				AdColonyInterstitial.cb_getZoneID = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyInterstitial.n_GetZoneID));
			}
			return AdColonyInterstitial.cb_getZoneID;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000A8E8 File Offset: 0x00008AE8
		private static IntPtr n_GetZoneID(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneID);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000A8FC File Offset: 0x00008AFC
		public virtual string ZoneID
		{
			[Register("getZoneID", "()Ljava/lang/String;", "GetGetZoneIDHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyInterstitial._members.InstanceMethods.InvokeVirtualObjectMethod("getZoneID.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000A92E File Offset: 0x00008B2E
		private static Delegate GetCancelHandler()
		{
			if (AdColonyInterstitial.cb_cancel == null)
			{
				AdColonyInterstitial.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyInterstitial.n_Cancel));
			}
			return AdColonyInterstitial.cb_cancel;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000A952 File Offset: 0x00008B52
		private static bool n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000A961 File Offset: 0x00008B61
		[Register("cancel", "()Z", "GetCancelHandler")]
		public virtual bool Cancel()
		{
			return AdColonyInterstitial._members.InstanceMethods.InvokeVirtualBooleanMethod("cancel.()Z", this, null);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000A97A File Offset: 0x00008B7A
		private static Delegate GetDestroyHandler()
		{
			if (AdColonyInterstitial.cb_destroy == null)
			{
				AdColonyInterstitial.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyInterstitial.n_Destroy));
			}
			return AdColonyInterstitial.cb_destroy;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000A99E File Offset: 0x00008B9E
		private static bool n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000A9AD File Offset: 0x00008BAD
		[Register("destroy", "()Z", "GetDestroyHandler")]
		public virtual bool Destroy()
		{
			return AdColonyInterstitial._members.InstanceMethods.InvokeVirtualBooleanMethod("destroy.()Z", this, null);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000A9C6 File Offset: 0x00008BC6
		private static Delegate GetShowHandler()
		{
			if (AdColonyInterstitial.cb_show == null)
			{
				AdColonyInterstitial.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyInterstitial.n_Show));
			}
			return AdColonyInterstitial.cb_show;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000A9EA File Offset: 0x00008BEA
		private static bool n_Show(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000A9F9 File Offset: 0x00008BF9
		[Register("show", "()Z", "GetShowHandler")]
		public virtual bool Show()
		{
			return AdColonyInterstitial._members.InstanceMethods.InvokeVirtualBooleanMethod("show.()Z", this, null);
		}

		// Token: 0x040000D3 RID: 211
		[Register("ADCOLONY_IAP_ENGAGEMENT_END_CARD")]
		public const int AdcolonyIapEngagementEndCard = 0;

		// Token: 0x040000D4 RID: 212
		[Register("ADCOLONY_IAP_ENGAGEMENT_OVERLAY")]
		public const int AdcolonyIapEngagementOverlay = 1;

		// Token: 0x040000D5 RID: 213
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyInterstitial", typeof(AdColonyInterstitial));

		// Token: 0x040000D6 RID: 214
		private static Delegate cb_isExpired;

		// Token: 0x040000D7 RID: 215
		private static Delegate cb_getListener;

		// Token: 0x040000D8 RID: 216
		private static Delegate cb_setListener_Lcom_adcolony_sdk_AdColonyInterstitialListener_;

		// Token: 0x040000D9 RID: 217
		private static Delegate cb_getViewNetworkPassFilter;

		// Token: 0x040000DA RID: 218
		private static Delegate cb_setViewNetworkPassFilter_Ljava_lang_String_;

		// Token: 0x040000DB RID: 219
		private static Delegate cb_getZoneID;

		// Token: 0x040000DC RID: 220
		private static Delegate cb_cancel;

		// Token: 0x040000DD RID: 221
		private static Delegate cb_destroy;

		// Token: 0x040000DE RID: 222
		private static Delegate cb_show;
	}
}
