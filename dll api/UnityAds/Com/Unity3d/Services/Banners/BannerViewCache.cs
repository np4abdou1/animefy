using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A2 RID: 418
	[Register("com/unity3d/services/banners/BannerViewCache", DoNotGenerateAcw = true)]
	public class BannerViewCache : Java.Lang.Object
	{
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00035FCC File Offset: 0x000341CC
		internal static IntPtr class_ref
		{
			get
			{
				return BannerViewCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00035FF0 File Offset: 0x000341F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerViewCache._members;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00035FF8 File Offset: 0x000341F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerViewCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0003601C File Offset: 0x0003421C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerViewCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BannerViewCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00036028 File Offset: 0x00034228
		[Register(".ctor", "()V", "")]
		public BannerViewCache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BannerViewCache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BannerViewCache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00036098 File Offset: 0x00034298
		public static BannerViewCache Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/banners/BannerViewCache;", "")]
			get
			{
				return Java.Lang.Object.GetObject<BannerViewCache>(BannerViewCache._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/banners/BannerViewCache;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000360C9 File Offset: 0x000342C9
		private static Delegate GetAddBannerView_Lcom_unity3d_services_banners_BannerView_Handler()
		{
			if (BannerViewCache.cb_addBannerView_Lcom_unity3d_services_banners_BannerView_ == null)
			{
				BannerViewCache.cb_addBannerView_Lcom_unity3d_services_banners_BannerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BannerViewCache.n_AddBannerView_Lcom_unity3d_services_banners_BannerView_));
			}
			return BannerViewCache.cb_addBannerView_Lcom_unity3d_services_banners_BannerView_;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000360F0 File Offset: 0x000342F0
		private static IntPtr n_AddBannerView_Lcom_unity3d_services_banners_BannerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdView)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BannerView object2 = Java.Lang.Object.GetObject<BannerView>(native_bannerAdView, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.AddBannerView(object2));
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00036118 File Offset: 0x00034318
		[Register("addBannerView", "(Lcom/unity3d/services/banners/BannerView;)Ljava/lang/String;", "GetAddBannerView_Lcom_unity3d_services_banners_BannerView_Handler")]
		public unsafe virtual string AddBannerView(BannerView bannerAdView)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bannerAdView == null) ? IntPtr.Zero : bannerAdView.Handle);
				@string = JNIEnv.GetString(BannerViewCache._members.InstanceMethods.InvokeVirtualObjectMethod("addBannerView.(Lcom/unity3d/services/banners/BannerView;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bannerAdView);
			}
			return @string;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0003618C File Offset: 0x0003438C
		private static Delegate GetGetBannerView_Ljava_lang_String_Handler()
		{
			if (BannerViewCache.cb_getBannerView_Ljava_lang_String_ == null)
			{
				BannerViewCache.cb_getBannerView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BannerViewCache.n_GetBannerView_Ljava_lang_String_));
			}
			return BannerViewCache.cb_getBannerView_Ljava_lang_String_;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000361B0 File Offset: 0x000343B0
		private static IntPtr n_GetBannerView_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdId)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bannerAdId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetBannerView(@string));
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000361D8 File Offset: 0x000343D8
		[Register("getBannerView", "(Ljava/lang/String;)Lcom/unity3d/services/banners/BannerView;", "GetGetBannerView_Ljava_lang_String_Handler")]
		public unsafe virtual BannerView GetBannerView(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			BannerView @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BannerView>(BannerViewCache._members.InstanceMethods.InvokeVirtualObjectMethod("getBannerView.(Ljava/lang/String;)Lcom/unity3d/services/banners/BannerView;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00036244 File Offset: 0x00034444
		private static Delegate GetLoadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_Handler()
		{
			if (BannerViewCache.cb_loadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_ == null)
			{
				BannerViewCache.cb_loadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(BannerViewCache.n_LoadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_));
			}
			return BannerViewCache.cb_loadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00036268 File Offset: 0x00034468
		private static bool n_LoadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdId, IntPtr native_size)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bannerAdId, JniHandleOwnership.DoNotTransfer);
			UnityBannerSize object2 = Java.Lang.Object.GetObject<UnityBannerSize>(native_size, JniHandleOwnership.DoNotTransfer);
			return @object.LoadWebPlayer(@string, object2);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00036294 File Offset: 0x00034494
		[Register("loadWebPlayer", "(Ljava/lang/String;Lcom/unity3d/services/banners/UnityBannerSize;)Z", "GetLoadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_Handler")]
		public unsafe virtual bool LoadWebPlayer(string bannerAdId, UnityBannerSize size)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((size == null) ? IntPtr.Zero : size.Handle);
				result = BannerViewCache._members.InstanceMethods.InvokeVirtualBooleanMethod("loadWebPlayer.(Ljava/lang/String;Lcom/unity3d/services/banners/UnityBannerSize;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(size);
			}
			return result;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0003631C File Offset: 0x0003451C
		private static Delegate GetRemoveBannerView_Ljava_lang_String_Handler()
		{
			if (BannerViewCache.cb_removeBannerView_Ljava_lang_String_ == null)
			{
				BannerViewCache.cb_removeBannerView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerViewCache.n_RemoveBannerView_Ljava_lang_String_));
			}
			return BannerViewCache.cb_removeBannerView_Ljava_lang_String_;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00036340 File Offset: 0x00034540
		private static void n_RemoveBannerView_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdId)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bannerAdId, JniHandleOwnership.DoNotTransfer);
			@object.RemoveBannerView(@string);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00036364 File Offset: 0x00034564
		[Register("removeBannerView", "(Ljava/lang/String;)V", "GetRemoveBannerView_Ljava_lang_String_Handler")]
		public unsafe virtual void RemoveBannerView(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerViewCache._members.InstanceMethods.InvokeVirtualVoidMethod("removeBannerView.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000363C0 File Offset: 0x000345C0
		private static Delegate GetTriggerBannerClickEvent_Ljava_lang_String_Handler()
		{
			if (BannerViewCache.cb_triggerBannerClickEvent_Ljava_lang_String_ == null)
			{
				BannerViewCache.cb_triggerBannerClickEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerViewCache.n_TriggerBannerClickEvent_Ljava_lang_String_));
			}
			return BannerViewCache.cb_triggerBannerClickEvent_Ljava_lang_String_;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000363E4 File Offset: 0x000345E4
		private static void n_TriggerBannerClickEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdId)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bannerAdId, JniHandleOwnership.DoNotTransfer);
			@object.TriggerBannerClickEvent(@string);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00036408 File Offset: 0x00034608
		[Register("triggerBannerClickEvent", "(Ljava/lang/String;)V", "GetTriggerBannerClickEvent_Ljava_lang_String_Handler")]
		public unsafe virtual void TriggerBannerClickEvent(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerViewCache._members.InstanceMethods.InvokeVirtualVoidMethod("triggerBannerClickEvent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00036464 File Offset: 0x00034664
		private static Delegate GetTriggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_Handler()
		{
			if (BannerViewCache.cb_triggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_ == null)
			{
				BannerViewCache.cb_triggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BannerViewCache.n_TriggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_));
			}
			return BannerViewCache.cb_triggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00036488 File Offset: 0x00034688
		private static void n_TriggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdId, IntPtr native_bannerErrorInfo)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bannerAdId, JniHandleOwnership.DoNotTransfer);
			BannerErrorInfo object2 = Java.Lang.Object.GetObject<BannerErrorInfo>(native_bannerErrorInfo, JniHandleOwnership.DoNotTransfer);
			@object.TriggerBannerErrorEvent(@string, object2);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000364B4 File Offset: 0x000346B4
		[Register("triggerBannerErrorEvent", "(Ljava/lang/String;Lcom/unity3d/services/banners/BannerErrorInfo;)V", "GetTriggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_Handler")]
		public unsafe virtual void TriggerBannerErrorEvent(string bannerAdId, BannerErrorInfo bannerErrorInfo)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((bannerErrorInfo == null) ? IntPtr.Zero : bannerErrorInfo.Handle);
				BannerViewCache._members.InstanceMethods.InvokeVirtualVoidMethod("triggerBannerErrorEvent.(Ljava/lang/String;Lcom/unity3d/services/banners/BannerErrorInfo;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(bannerErrorInfo);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00036538 File Offset: 0x00034738
		private static Delegate GetTriggerBannerLeftApplicationEvent_Ljava_lang_String_Handler()
		{
			if (BannerViewCache.cb_triggerBannerLeftApplicationEvent_Ljava_lang_String_ == null)
			{
				BannerViewCache.cb_triggerBannerLeftApplicationEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerViewCache.n_TriggerBannerLeftApplicationEvent_Ljava_lang_String_));
			}
			return BannerViewCache.cb_triggerBannerLeftApplicationEvent_Ljava_lang_String_;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0003655C File Offset: 0x0003475C
		private static void n_TriggerBannerLeftApplicationEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdId)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bannerAdId, JniHandleOwnership.DoNotTransfer);
			@object.TriggerBannerLeftApplicationEvent(@string);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00036580 File Offset: 0x00034780
		[Register("triggerBannerLeftApplicationEvent", "(Ljava/lang/String;)V", "GetTriggerBannerLeftApplicationEvent_Ljava_lang_String_Handler")]
		public unsafe virtual void TriggerBannerLeftApplicationEvent(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerViewCache._members.InstanceMethods.InvokeVirtualVoidMethod("triggerBannerLeftApplicationEvent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000365DC File Offset: 0x000347DC
		private static Delegate GetTriggerBannerLoadEvent_Ljava_lang_String_Handler()
		{
			if (BannerViewCache.cb_triggerBannerLoadEvent_Ljava_lang_String_ == null)
			{
				BannerViewCache.cb_triggerBannerLoadEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerViewCache.n_TriggerBannerLoadEvent_Ljava_lang_String_));
			}
			return BannerViewCache.cb_triggerBannerLoadEvent_Ljava_lang_String_;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00036600 File Offset: 0x00034800
		private static void n_TriggerBannerLoadEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdId)
		{
			BannerViewCache @object = Java.Lang.Object.GetObject<BannerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bannerAdId, JniHandleOwnership.DoNotTransfer);
			@object.TriggerBannerLoadEvent(@string);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00036624 File Offset: 0x00034824
		[Register("triggerBannerLoadEvent", "(Ljava/lang/String;)V", "GetTriggerBannerLoadEvent_Ljava_lang_String_Handler")]
		public unsafe virtual void TriggerBannerLoadEvent(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerViewCache._members.InstanceMethods.InvokeVirtualVoidMethod("triggerBannerLoadEvent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400047C RID: 1148
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/BannerViewCache", typeof(BannerViewCache));

		// Token: 0x0400047D RID: 1149
		private static Delegate cb_addBannerView_Lcom_unity3d_services_banners_BannerView_;

		// Token: 0x0400047E RID: 1150
		private static Delegate cb_getBannerView_Ljava_lang_String_;

		// Token: 0x0400047F RID: 1151
		private static Delegate cb_loadWebPlayer_Ljava_lang_String_Lcom_unity3d_services_banners_UnityBannerSize_;

		// Token: 0x04000480 RID: 1152
		private static Delegate cb_removeBannerView_Ljava_lang_String_;

		// Token: 0x04000481 RID: 1153
		private static Delegate cb_triggerBannerClickEvent_Ljava_lang_String_;

		// Token: 0x04000482 RID: 1154
		private static Delegate cb_triggerBannerErrorEvent_Ljava_lang_String_Lcom_unity3d_services_banners_BannerErrorInfo_;

		// Token: 0x04000483 RID: 1155
		private static Delegate cb_triggerBannerLeftApplicationEvent_Ljava_lang_String_;

		// Token: 0x04000484 RID: 1156
		private static Delegate cb_triggerBannerLoadEvent_Ljava_lang_String_;
	}
}
