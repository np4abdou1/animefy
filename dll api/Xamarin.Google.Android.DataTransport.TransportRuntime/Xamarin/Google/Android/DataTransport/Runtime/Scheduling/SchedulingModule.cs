using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x0200004C RID: 76
	[Register("com/google/android/datatransport/runtime/scheduling/SchedulingModule", DoNotGenerateAcw = true)]
	public abstract class SchedulingModule : Java.Lang.Object
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000074CC File Offset: 0x000056CC
		internal static IntPtr class_ref
		{
			get
			{
				return SchedulingModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000074F0 File Offset: 0x000056F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulingModule._members;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000074F8 File Offset: 0x000056F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SchedulingModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000751C File Offset: 0x0000571C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulingModule._members.ManagedPeerType;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000026C4 File Offset: 0x000008C4
		protected SchedulingModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007528 File Offset: 0x00005728
		[Register(".ctor", "()V", "")]
		public SchedulingModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SchedulingModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SchedulingModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000087 RID: 135
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/SchedulingModule", typeof(SchedulingModule));
	}
}
