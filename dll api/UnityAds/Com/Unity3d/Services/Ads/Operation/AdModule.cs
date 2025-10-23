using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Request.Metrics;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001E4 RID: 484
	[Register("com/unity3d/services/ads/operation/AdModule", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends com.unity3d.services.core.webview.bridge.IWebViewSharedObject",
		"T2"
	})]
	public abstract class AdModule : WebViewBridgeSharedObjectStore, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0003F4EC File Offset: 0x0003D6EC
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x0003F51C File Offset: 0x0003D71C
		[Register("_executorService")]
		protected IExecutorService ExecutorService
		{
			get
			{
				return Java.Lang.Object.GetObject<IExecutorService>(AdModule._members.InstanceFields.GetObjectValue("_executorService.Ljava/util/concurrent/ExecutorService;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					AdModule._members.InstanceFields.SetValue("_executorService.Ljava/util/concurrent/ExecutorService;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0003F568 File Offset: 0x0003D768
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x0003F598 File Offset: 0x0003D798
		[Register("_sdkMetrics")]
		protected ISDKMetrics SdkMetrics
		{
			get
			{
				return Java.Lang.Object.GetObject<ISDKMetrics>(AdModule._members.InstanceFields.GetObjectValue("_sdkMetrics.Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					AdModule._members.InstanceFields.SetValue("_sdkMetrics.Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x0003F5E4 File Offset: 0x0003D7E4
		internal new static IntPtr class_ref
		{
			get
			{
				return AdModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x0003F608 File Offset: 0x0003D808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdModule._members;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x0003F610 File Offset: 0x0003D810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x0003F634 File Offset: 0x0003D834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdModule._members.ManagedPeerType;
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0000D69F File Offset: 0x0000B89F
		protected AdModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0003F640 File Offset: 0x0003D840
		[Register(".ctor", "(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", "")]
		protected unsafe AdModule(ISDKMetrics sdkMetrics) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sdkMetrics == null) ? IntPtr.Zero : ((Java.Lang.Object)sdkMetrics).Handle);
				base.SetHandle(AdModule._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdModule._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sdkMetrics);
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
		private static Delegate GetGetMetricSenderHandler()
		{
			if (AdModule.cb_getMetricSender == null)
			{
				AdModule.cb_getMetricSender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdModule.n_GetMetricSender));
			}
			return AdModule.cb_getMetricSender;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0003F718 File Offset: 0x0003D918
		private static IntPtr n_GetMetricSender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricSender);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00002226 File Offset: 0x00000426
		public void ExecuteAdOperation(IWebViewBridgeInvoker p0, Java.Lang.Object p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x0003F72C File Offset: 0x0003D92C
		public virtual ISDKMetrics MetricSender
		{
			[Register("getMetricSender", "()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", "GetGetMetricSenderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ISDKMetrics>(AdModule._members.InstanceMethods.InvokeVirtualObjectMethod("getMetricSender.()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000538 RID: 1336
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/AdModule", typeof(AdModule));

		// Token: 0x04000539 RID: 1337
		private static Delegate cb_getMetricSender;
	}
}
