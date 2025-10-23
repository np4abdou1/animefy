using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2000
{
	// Token: 0x0200025B RID: 603
	[Register("com/unity3d/scar/adapter/v2000/ScarAdapter", DoNotGenerateAcw = true)]
	public class ScarAdapter : ScarAdapterBase, IScarAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0005895C File Offset: 0x00056B5C
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x00058980 File Offset: 0x00056B80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapter._members;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00058988 File Offset: 0x00056B88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x000589AC File Offset: 0x00056BAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000544B4 File Offset: 0x000526B4
		protected ScarAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000589B8 File Offset: 0x00056BB8
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

		// Token: 0x060020C8 RID: 8392 RVA: 0x00058A6C File Offset: 0x00056C6C
		private static Delegate GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00058A90 File Offset: 0x00056C90
		private static void n_LoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarInterstitialAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00058AC8 File Offset: 0x00056CC8
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

		// Token: 0x060020CB RID: 8395 RVA: 0x00058B84 File Offset: 0x00056D84
		private static Delegate GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler()
		{
			if (ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ == null)
			{
				ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ScarAdapter.n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_));
			}
			return ScarAdapter.cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00058BA8 File Offset: 0x00056DA8
		private static void n_LoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_scarAd, IntPtr native_adListenerWrapper)
		{
			ScarAdapterBase @object = Java.Lang.Object.GetObject<ScarAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ScarAdMetadata object3 = Java.Lang.Object.GetObject<ScarAdMetadata>(native_scarAd, JniHandleOwnership.DoNotTransfer);
			IScarRewardedAdListenerWrapper object4 = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(native_adListenerWrapper, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00058BE0 File Offset: 0x00056DE0
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

		// Token: 0x040006F3 RID: 1779
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/ScarAdapter", typeof(ScarAdapter));

		// Token: 0x040006F4 RID: 1780
		private static Delegate cb_loadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_;

		// Token: 0x040006F5 RID: 1781
		private static Delegate cb_loadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_;
	}
}
