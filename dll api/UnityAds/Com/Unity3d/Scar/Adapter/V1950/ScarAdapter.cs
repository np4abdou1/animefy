using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950
{
	// Token: 0x02000271 RID: 625
	[Register("com/unity3d/scar/adapter/v1950/ScarAdapter", DoNotGenerateAcw = true)]
	public class ScarAdapter : ScarAdapterBase, IScarAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x0005CA98 File Offset: 0x0005AC98
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0005CABC File Offset: 0x0005ACBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapter._members;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x0005CAC4 File Offset: 0x0005ACC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x0005CAE8 File Offset: 0x0005ACE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x000544B4 File Offset: 0x000526B4
		protected ScarAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0005CAF4 File Offset: 0x0005ACF4
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

		// Token: 0x06002349 RID: 9033 RVA: 0x0005CBA8 File Offset: 0x0005ADA8
		private static Delegate GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0005CBCC File Offset: 0x0005ADCC
		private static void n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarInterstitialAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0005CC04 File Offset: 0x0005AE04
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

		// Token: 0x0600234C RID: 9036 RVA: 0x0005CCC0 File Offset: 0x0005AEC0
		private static Delegate GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0005CCE4 File Offset: 0x0005AEE4
		private static void n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarRewardedAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0005CD1C File Offset: 0x0005AF1C
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

		// Token: 0x04000715 RID: 1813
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/ScarAdapter", typeof(ScarAdapter));

		// Token: 0x04000716 RID: 1814
		private static Delegate cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;

		// Token: 0x04000717 RID: 1815
		private static Delegate cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
	}
}
