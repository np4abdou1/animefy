using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000C1 RID: 193
	[Register("com/unity3d/services/core/request/metrics/MetricsContainer", DoNotGenerateAcw = true)]
	public class MetricsContainer : Java.Lang.Object
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00014584 File Offset: 0x00012784
		internal static IntPtr class_ref
		{
			get
			{
				return MetricsContainer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x000145A8 File Offset: 0x000127A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricsContainer._members;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x000145B0 File Offset: 0x000127B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetricsContainer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000145D4 File Offset: 0x000127D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricsContainer._members.ManagedPeerType;
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MetricsContainer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000145E0 File Offset: 0x000127E0
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/services/core/request/metrics/MetricCommonTags;Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe MetricsContainer(string metricSampleRate, MetricCommonTags commonTags, IList<Metric> metrics, string sTkn) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(metricSampleRate);
			IntPtr intPtr2 = JavaList<Metric>.ToLocalJniHandle(metrics);
			IntPtr intPtr3 = JNIEnv.NewString(sTkn);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((commonTags == null) ? IntPtr.Zero : commonTags.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				base.SetHandle(MetricsContainer._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/request/metrics/MetricCommonTags;Ljava/util/List;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MetricsContainer._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/request/metrics/MetricCommonTags;Ljava/util/List;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(commonTags);
				GC.KeepAlive(metrics);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000146FC File Offset: 0x000128FC
		private static Delegate GetAsMapHandler()
		{
			if (MetricsContainer.cb_asMap == null)
			{
				MetricsContainer.cb_asMap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MetricsContainer.n_AsMap));
			}
			return MetricsContainer.cb_asMap;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00014720 File Offset: 0x00012920
		private static IntPtr n_AsMap(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<MetricsContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsMap());
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00014734 File Offset: 0x00012934
		[Register("asMap", "()Ljava/util/Map;", "GetAsMapHandler")]
		public virtual IDictionary<string, Java.Lang.Object> AsMap()
		{
			return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(MetricsContainer._members.InstanceMethods.InvokeVirtualObjectMethod("asMap.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001C2 RID: 450
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/MetricsContainer", typeof(MetricsContainer));

		// Token: 0x040001C3 RID: 451
		private static Delegate cb_asMap;
	}
}
