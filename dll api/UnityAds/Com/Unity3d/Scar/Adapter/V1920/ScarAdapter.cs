using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920
{
	// Token: 0x02000289 RID: 649
	[Register("com/unity3d/scar/adapter/v1920/ScarAdapter", DoNotGenerateAcw = true)]
	public class ScarAdapter : ScarAdapterBase, IScarAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0006035C File Offset: 0x0005E55C
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x00060380 File Offset: 0x0005E580
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapter._members;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x00060388 File Offset: 0x0005E588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000603AC File Offset: 0x0005E5AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x000544B4 File Offset: 0x000526B4
		protected ScarAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000603B8 File Offset: 0x0005E5B8
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", "")]
		public unsafe ScarAdapter(IAdsErrorHandler adsErrorHandler) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adsErrorHandler == null) ? IntPtr.Zero : ((Java.Lang.Object)adsErrorHandler).Handle);
				base.SetHandle(ScarAdapter._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarAdapter._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adsErrorHandler);
			}
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x0006046C File Offset: 0x0005E66C
		private static Delegate GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00060490 File Offset: 0x0005E690
		private static void n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarInterstitialAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000604C8 File Offset: 0x0005E6C8
		[Register("loadInterstitialAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper;)V", "GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler")]
		public unsafe override void LoadInterstitialAd(Context context, ScarAdMetadata scarAd, IScarInterstitialAdListenerWrapper adListenerWrapper)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((scarAd == null) ? IntPtr.Zero : scarAd.Handle);
				ptr[2] = new JniArgumentValue((adListenerWrapper == null) ? IntPtr.Zero : ((Java.Lang.Object)adListenerWrapper).Handle);
				ScarAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("loadInterstitialAd.(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(scarAd);
				GC.KeepAlive(adListenerWrapper);
			}
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00060584 File Offset: 0x0005E784
		private static Delegate GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000605A8 File Offset: 0x0005E7A8
		private static void n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarRewardedAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000605E0 File Offset: 0x0005E7E0
		[Register("loadRewardedAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper;)V", "GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler")]
		public unsafe override void LoadRewardedAd(Context context, ScarAdMetadata scarAd, IScarRewardedAdListenerWrapper adListenerWrapper)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((scarAd == null) ? IntPtr.Zero : scarAd.Handle);
				ptr[2] = new JniArgumentValue((adListenerWrapper == null) ? IntPtr.Zero : ((Java.Lang.Object)adListenerWrapper).Handle);
				ScarAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("loadRewardedAd.(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(scarAd);
				GC.KeepAlive(adListenerWrapper);
			}
		}

		// Token: 0x0400073D RID: 1853
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/ScarAdapter", typeof(ScarAdapter));

		// Token: 0x0400073E RID: 1854
		private static Delegate cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;

		// Token: 0x0400073F RID: 1855
		private static Delegate cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
	}
}
