using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2100
{
	// Token: 0x02000244 RID: 580
	[Register("com/unity3d/scar/adapter/v2100/ScarAdapter", DoNotGenerateAcw = true)]
	public class ScarAdapter : ScarAdapterBase, IScarAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00054458 File Offset: 0x00052658
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0005447C File Offset: 0x0005267C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapter._members;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00054484 File Offset: 0x00052684
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000544A8 File Offset: 0x000526A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x000544B4 File Offset: 0x000526B4
		protected ScarAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x000544C0 File Offset: 0x000526C0
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;Ljava/lang/String;)V", "")]
		public unsafe ScarAdapter(IAdsErrorHandler adsErrorHandler, string unityVersionName) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(unityVersionName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adsErrorHandler == null) ? IntPtr.Zero : ((Java.Lang.Object)adsErrorHandler).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(ScarAdapter._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarAdapter._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(adsErrorHandler);
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00054594 File Offset: 0x00052794
		private static Delegate GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000545B8 File Offset: 0x000527B8
		private static void n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarInterstitialAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000545F0 File Offset: 0x000527F0
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

		// Token: 0x06001E3F RID: 7743 RVA: 0x000546AC File Offset: 0x000528AC
		private static Delegate GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x000546D0 File Offset: 0x000528D0
		private static void n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarRewardedAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00054708 File Offset: 0x00052908
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

		// Token: 0x040006D0 RID: 1744
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/ScarAdapter", typeof(ScarAdapter));

		// Token: 0x040006D1 RID: 1745
		private static Delegate cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;

		// Token: 0x040006D2 RID: 1746
		private static Delegate cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
	}
}
