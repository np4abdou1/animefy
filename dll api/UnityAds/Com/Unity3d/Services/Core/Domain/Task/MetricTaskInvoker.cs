using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.DI;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x0200010A RID: 266
	[Register("com/unity3d/services/core/domain/task/MetricTask", DoNotGenerateAcw = true)]
	internal class MetricTaskInvoker : MetricTask, IBaseTask, IServiceComponent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000A75 RID: 2677 RVA: 0x0001E393 File Offset: 0x0001C593
		public MetricTaskInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0001E39D File Offset: 0x0001C59D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricTaskInvoker._members;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0001E3A4 File Offset: 0x0001C5A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricTaskInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000274 RID: 628
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/task/MetricTask", typeof(MetricTaskInvoker));
	}
}
