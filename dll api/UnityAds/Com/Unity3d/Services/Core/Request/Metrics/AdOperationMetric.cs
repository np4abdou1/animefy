using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000BA RID: 186
	[Register("com/unity3d/services/core/request/metrics/AdOperationMetric", DoNotGenerateAcw = true)]
	public class AdOperationMetric : Java.Lang.Object
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x000132FC File Offset: 0x000114FC
		internal static IntPtr class_ref
		{
			get
			{
				return AdOperationMetric._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00013320 File Offset: 0x00011520
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdOperationMetric._members;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00013328 File Offset: 0x00011528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdOperationMetric._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0001334C File Offset: 0x0001154C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdOperationMetric._members.ManagedPeerType;
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdOperationMetric(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00013358 File Offset: 0x00011558
		[Register(".ctor", "()V", "")]
		public AdOperationMetric() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdOperationMetric._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdOperationMetric._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000133C8 File Offset: 0x000115C8
		[Register("newAdLoadFailure", "(Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAdLoadFailure(UnityAds.UnityAdsLoadError error, Long durationMs)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue((durationMs == null) ? IntPtr.Zero : durationMs.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdLoadFailure.(Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(error);
				GC.KeepAlive(durationMs);
			}
			return @object;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00013464 File Offset: 0x00011664
		[Register("newAdLoadFailure", "(Lcom/unity3d/services/core/request/metrics/AdOperationError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAdLoadFailure(AdOperationError error, Long durationMs)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue((durationMs == null) ? IntPtr.Zero : durationMs.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdLoadFailure.(Lcom/unity3d/services/core/request/metrics/AdOperationError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(error);
				GC.KeepAlive(durationMs);
			}
			return @object;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00013500 File Offset: 0x00011700
		[Register("newAdLoadStart", "()Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public static Metric NewAdLoadStart()
		{
			return Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdLoadStart.()Lcom/unity3d/services/core/request/metrics/Metric;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00013534 File Offset: 0x00011734
		[Register("newAdLoadSuccess", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAdLoadSuccess(Long durationMs)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((durationMs == null) ? IntPtr.Zero : durationMs.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdLoadSuccess.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(durationMs);
			}
			return @object;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000135A8 File Offset: 0x000117A8
		[Register("newAdShowFailure", "(Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAdShowFailure(UnityAds.UnityAdsShowError error, Long durationMs)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue((durationMs == null) ? IntPtr.Zero : durationMs.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdShowFailure.(Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(error);
				GC.KeepAlive(durationMs);
			}
			return @object;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00013644 File Offset: 0x00011844
		[Register("newAdShowFailure", "(Lcom/unity3d/services/core/request/metrics/AdOperationError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAdShowFailure(AdOperationError error, Long durationMs)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue((durationMs == null) ? IntPtr.Zero : durationMs.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdShowFailure.(Lcom/unity3d/services/core/request/metrics/AdOperationError;Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(error);
				GC.KeepAlive(durationMs);
			}
			return @object;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000136E0 File Offset: 0x000118E0
		[Register("newAdShowStart", "()Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public static Metric NewAdShowStart()
		{
			return Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdShowStart.()Lcom/unity3d/services/core/request/metrics/Metric;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00013714 File Offset: 0x00011914
		[Register("newAdShowSuccess", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAdShowSuccess(Long durationMs)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((durationMs == null) ? IntPtr.Zero : durationMs.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(AdOperationMetric._members.StaticMethods.InvokeObjectMethod("newAdShowSuccess.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(durationMs);
			}
			return @object;
		}

		// Token: 0x040001A2 RID: 418
		[Register("INIT_STATE")]
		public const string InitState = "state";

		// Token: 0x040001A3 RID: 419
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/AdOperationMetric", typeof(AdOperationMetric));
	}
}
