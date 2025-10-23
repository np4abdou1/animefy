using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Properties;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000BB RID: 187
	[Register("com/unity3d/services/core/request/metrics/IMetricSenderWithBatch", DoNotGenerateAcw = true)]
	public abstract class IMetricSenderWithBatch : Java.Lang.Object
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000137A4 File Offset: 0x000119A4
		internal static IntPtr class_ref
		{
			get
			{
				return IMetricSenderWithBatch._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000137C8 File Offset: 0x000119C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMetricSenderWithBatch._members;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000137D0 File Offset: 0x000119D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IMetricSenderWithBatch._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x000137F4 File Offset: 0x000119F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMetricSenderWithBatch._members.ManagedPeerType;
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000021E8 File Offset: 0x000003E8
		protected IMetricSenderWithBatch(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00013800 File Offset: 0x00011A00
		[Register(".ctor", "(Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", "")]
		public unsafe IMetricSenderWithBatch(InitializationStatusReader initializationStatusReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initializationStatusReader == null) ? IntPtr.Zero : initializationStatusReader.Handle);
				base.SetHandle(IMetricSenderWithBatch._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IMetricSenderWithBatch._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/properties/InitializationStatusReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(initializationStatusReader);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000138B0 File Offset: 0x00011AB0
		private static Delegate GetSendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (IMetricSenderWithBatch.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				IMetricSenderWithBatch.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMetricSenderWithBatch.n_SendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return IMetricSenderWithBatch.cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000138D4 File Offset: 0x00011AD4
		private static void n_SendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMetricSenderWithBatch @object = Java.Lang.Object.GetObject<IMetricSenderWithBatch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SendMetricWithInitState(object2);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000138F8 File Offset: 0x00011AF8
		[Register("sendMetricWithInitState", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_Handler")]
		public unsafe virtual void SendMetricWithInitState(Metric p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				IMetricSenderWithBatch._members.InstanceMethods.InvokeVirtualVoidMethod("sendMetricWithInitState.(Lcom/unity3d/services/core/request/metrics/Metric;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x040001A4 RID: 420
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/IMetricSenderWithBatch", typeof(IMetricSenderWithBatch));

		// Token: 0x040001A5 RID: 421
		private static Delegate cb_sendMetricWithInitState_Lcom_unity3d_services_core_request_metrics_Metric_;
	}
}
