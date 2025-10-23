using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000039 RID: 57
	[Register("com/google/android/datatransport/runtime/time/TimeModule", DoNotGenerateAcw = true)]
	public abstract class TimeModule : Java.Lang.Object
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00005C74 File Offset: 0x00003E74
		internal static IntPtr class_ref
		{
			get
			{
				return TimeModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00005C98 File Offset: 0x00003E98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeModule._members;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00005CC4 File Offset: 0x00003EC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeModule._members.ManagedPeerType;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000026C4 File Offset: 0x000008C4
		protected TimeModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Register(".ctor", "()V", "")]
		public TimeModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TimeModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TimeModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0400006C RID: 108
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/TimeModule", typeof(TimeModule));
	}
}
