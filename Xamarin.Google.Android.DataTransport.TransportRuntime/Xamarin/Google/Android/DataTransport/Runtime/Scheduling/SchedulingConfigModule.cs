using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x02000049 RID: 73
	[Register("com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule", DoNotGenerateAcw = true)]
	public abstract class SchedulingConfigModule : Java.Lang.Object
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000715C File Offset: 0x0000535C
		internal static IntPtr class_ref
		{
			get
			{
				return SchedulingConfigModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007180 File Offset: 0x00005380
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulingConfigModule._members;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00007188 File Offset: 0x00005388
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SchedulingConfigModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000071AC File Offset: 0x000053AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulingConfigModule._members.ManagedPeerType;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000026C4 File Offset: 0x000008C4
		protected SchedulingConfigModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000071B8 File Offset: 0x000053B8
		[Register(".ctor", "()V", "")]
		public SchedulingConfigModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SchedulingConfigModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SchedulingConfigModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000084 RID: 132
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule", typeof(SchedulingConfigModule));
	}
}
