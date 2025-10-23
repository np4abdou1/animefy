using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A7 RID: 679
	[Register("com/unity3d/scar/adapter/common/ScarAdapterBase", DoNotGenerateAcw = true)]
	internal class ScarAdapterBaseInvoker : ScarAdapterBase
	{
		// Token: 0x060026E1 RID: 9953 RVA: 0x000544B4 File Offset: 0x000526B4
		public ScarAdapterBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000642F1 File Offset: 0x000624F1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapterBaseInvoker._members;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000642F8 File Offset: 0x000624F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapterBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00064304 File Offset: 0x00062504
		[Register("loadInterstitialAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper;)V", "GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler")]
		public unsafe override void LoadInterstitialAd(Context p0, ScarAdMetadata p1, IScarInterstitialAdListenerWrapper p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ScarAdapterBaseInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("loadInterstitialAd.(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000643C0 File Offset: 0x000625C0
		[Register("loadRewardedAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper;)V", "GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler")]
		public unsafe override void LoadRewardedAd(Context p0, ScarAdMetadata p1, IScarRewardedAdListenerWrapper p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ScarAdapterBaseInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("loadRewardedAd.(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x040007B4 RID: 1972
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/ScarAdapterBase", typeof(ScarAdapterBaseInvoker));
	}
}
