using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001E0 RID: 480
	[Register("com/unity3d/services/ads/token/NativeTokenGeneratorWithPrivacyAwait", DoNotGenerateAcw = true)]
	public class NativeTokenGeneratorWithPrivacyAwait : Java.Lang.Object, INativeTokenGenerator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0003ED18 File Offset: 0x0003CF18
		internal static IntPtr class_ref
		{
			get
			{
				return NativeTokenGeneratorWithPrivacyAwait._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0003ED3C File Offset: 0x0003CF3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NativeTokenGeneratorWithPrivacyAwait._members;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0003ED44 File Offset: 0x0003CF44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NativeTokenGeneratorWithPrivacyAwait._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x0003ED68 File Offset: 0x0003CF68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NativeTokenGeneratorWithPrivacyAwait._members.ManagedPeerType;
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x000021E8 File Offset: 0x000003E8
		protected NativeTokenGeneratorWithPrivacyAwait(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0003ED74 File Offset: 0x0003CF74
		[Register(".ctor", "(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/ads/token/INativeTokenGenerator;I)V", "")]
		public unsafe NativeTokenGeneratorWithPrivacyAwait(IExecutorService executorService, INativeTokenGenerator nativeTokenGenerator, int privacyAwaitTimeout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executorService == null) ? IntPtr.Zero : ((Java.Lang.Object)executorService).Handle);
				ptr[1] = new JniArgumentValue((nativeTokenGenerator == null) ? IntPtr.Zero : ((Java.Lang.Object)nativeTokenGenerator).Handle);
				ptr[2] = new JniArgumentValue(privacyAwaitTimeout);
				base.SetHandle(NativeTokenGeneratorWithPrivacyAwait._members.InstanceMethods.StartCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/ads/token/INativeTokenGenerator;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NativeTokenGeneratorWithPrivacyAwait._members.InstanceMethods.FinishCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/ads/token/INativeTokenGenerator;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(executorService);
				GC.KeepAlive(nativeTokenGenerator);
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0003EE6C File Offset: 0x0003D06C
		private static Delegate GetGenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_Handler()
		{
			if (NativeTokenGeneratorWithPrivacyAwait.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ == null)
			{
				NativeTokenGeneratorWithPrivacyAwait.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NativeTokenGeneratorWithPrivacyAwait.n_GenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_));
			}
			return NativeTokenGeneratorWithPrivacyAwait.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0003EE90 File Offset: 0x0003D090
		private static void n_GenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			NativeTokenGeneratorWithPrivacyAwait @object = Java.Lang.Object.GetObject<NativeTokenGeneratorWithPrivacyAwait>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			INativeTokenGeneratorListener object2 = Java.Lang.Object.GetObject<INativeTokenGeneratorListener>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.GenerateToken(object2);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0003EEB4 File Offset: 0x0003D0B4
		[Register("generateToken", "(Lcom/unity3d/services/ads/token/INativeTokenGeneratorListener;)V", "GetGenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_Handler")]
		public unsafe virtual void GenerateToken(INativeTokenGeneratorListener callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				NativeTokenGeneratorWithPrivacyAwait._members.InstanceMethods.InvokeVirtualVoidMethod("generateToken.(Lcom/unity3d/services/ads/token/INativeTokenGeneratorListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000533 RID: 1331
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/NativeTokenGeneratorWithPrivacyAwait", typeof(NativeTokenGeneratorWithPrivacyAwait));

		// Token: 0x04000534 RID: 1332
		private static Delegate cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_;
	}
}
