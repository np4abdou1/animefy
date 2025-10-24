using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x0200005F RID: 95
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer", DoNotGenerateAcw = true)]
	public class WorkInitializer : Java.Lang.Object
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000A180 File Offset: 0x00008380
		internal static IntPtr class_ref
		{
			get
			{
				return WorkInitializer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000A1A4 File Offset: 0x000083A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WorkInitializer._members;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000A1AC File Offset: 0x000083AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WorkInitializer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WorkInitializer._members.ManagedPeerType;
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000026C4 File Offset: 0x000008C4
		protected WorkInitializer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000A1DC File Offset: 0x000083DC
		private static Delegate GetEnsureContextsScheduledHandler()
		{
			if (WorkInitializer.cb_ensureContextsScheduled == null)
			{
				WorkInitializer.cb_ensureContextsScheduled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WorkInitializer.n_EnsureContextsScheduled));
			}
			return WorkInitializer.cb_ensureContextsScheduled;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000A200 File Offset: 0x00008400
		private static void n_EnsureContextsScheduled(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WorkInitializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EnsureContextsScheduled();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000A20F File Offset: 0x0000840F
		[Register("ensureContextsScheduled", "()V", "GetEnsureContextsScheduledHandler")]
		public virtual void EnsureContextsScheduled()
		{
			WorkInitializer._members.InstanceMethods.InvokeVirtualVoidMethod("ensureContextsScheduled.()V", this, null);
		}

		// Token: 0x040000B2 RID: 178
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer", typeof(WorkInitializer));

		// Token: 0x040000B3 RID: 179
		private static Delegate cb_ensureContextsScheduled;
	}
}
