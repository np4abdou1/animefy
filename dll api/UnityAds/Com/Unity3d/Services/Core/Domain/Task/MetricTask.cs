using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.DI;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000109 RID: 265
	[Register("com/unity3d/services/core/domain/task/MetricTask", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"P extends com.unity3d.services.core.domain.task.BaseParams",
		"R"
	})]
	public abstract class MetricTask : Java.Lang.Object, IBaseTask, IServiceComponent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0001E010 File Offset: 0x0001C210
		internal static IntPtr class_ref
		{
			get
			{
				return MetricTask._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0001E034 File Offset: 0x0001C234
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricTask._members;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0001E03C File Offset: 0x0001C23C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetricTask._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0001E060 File Offset: 0x0001C260
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricTask._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MetricTask(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0001E06C File Offset: 0x0001C26C
		[Register(".ctor", "()V", "")]
		public MetricTask() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MetricTask._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MetricTask._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0001E0DA File Offset: 0x0001C2DA
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
		public unsafe long Duration
		{
			[Register("getDuration", "()J", "")]
			get
			{
				return MetricTask._members.InstanceMethods.InvokeNonvirtualInt64Method("getDuration.()J", this, null);
			}
			[Register("setDuration", "(J)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MetricTask._members.InstanceMethods.InvokeNonvirtualVoidMethod("setDuration.(J)V", this, ptr);
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001E12F File Offset: 0x0001C32F
		private static Delegate GetGetMetricNameHandler()
		{
			if (MetricTask.cb_getMetricName == null)
			{
				MetricTask.cb_getMetricName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MetricTask.n_GetMetricName));
			}
			return MetricTask.cb_getMetricName;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0001E153 File Offset: 0x0001C353
		private static IntPtr n_GetMetricName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MetricTask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricName);
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0001E168 File Offset: 0x0001C368
		public virtual string MetricName
		{
			[Register("getMetricName", "()Ljava/lang/String;", "GetGetMetricNameHandler")]
			get
			{
				return JNIEnv.GetString(MetricTask._members.InstanceMethods.InvokeVirtualObjectMethod("getMetricName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0001E19A File Offset: 0x0001C39A
		private static Delegate GetGetServiceProviderHandler()
		{
			if (MetricTask.cb_getServiceProvider == null)
			{
				MetricTask.cb_getServiceProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MetricTask.n_GetServiceProvider));
			}
			return MetricTask.cb_getServiceProvider;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0001E1BE File Offset: 0x0001C3BE
		private static IntPtr n_GetServiceProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MetricTask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServiceProvider);
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0001E1D4 File Offset: 0x0001C3D4
		public virtual Com.Unity3d.Services.Core.DI.IServiceProvider ServiceProvider
		{
			[Register("getServiceProvider", "()Lcom/unity3d/services/core/di/IServiceProvider;", "GetGetServiceProviderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Com.Unity3d.Services.Core.DI.IServiceProvider>(MetricTask._members.InstanceMethods.InvokeVirtualObjectMethod("getServiceProvider.()Lcom/unity3d/services/core/di/IServiceProvider;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0001E208 File Offset: 0x0001C408
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0001E23C File Offset: 0x0001C43C
		public unsafe string TaskStatus
		{
			[Register("getTaskStatus", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(MetricTask._members.InstanceMethods.InvokeNonvirtualObjectMethod("getTaskStatus.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTaskStatus", "(Ljava/lang/String;)V", "")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					MetricTask._members.InstanceMethods.InvokeNonvirtualVoidMethod("setTaskStatus.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00002226 File Offset: 0x00000426
		ServiceProvider IServiceComponent.ServiceProvider
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0001E298 File Offset: 0x0001C498
		[Register("getMetricNameForInitializeTask", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetMetricNameForInitializeTask(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(MetricTask._members.InstanceMethods.InvokeNonvirtualObjectMethod("getMetricNameForInitializeTask.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0001E304 File Offset: 0x0001C504
		[Register("getMetricNameForTask", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string GetMetricNameForTask(Java.Lang.Object task)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((task == null) ? IntPtr.Zero : task.Handle);
				@string = JNIEnv.GetString(MetricTask._members.InstanceMethods.InvokeNonvirtualObjectMethod("getMetricNameForTask.(Ljava/lang/Object;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(task);
			}
			return @string;
		}

		// Token: 0x04000271 RID: 625
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/task/MetricTask", typeof(MetricTask));

		// Token: 0x04000272 RID: 626
		private static Delegate cb_getMetricName;

		// Token: 0x04000273 RID: 627
		private static Delegate cb_getServiceProvider;
	}
}
