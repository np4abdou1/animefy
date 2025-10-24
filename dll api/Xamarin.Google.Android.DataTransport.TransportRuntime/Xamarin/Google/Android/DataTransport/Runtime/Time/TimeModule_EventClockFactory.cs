using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x0200003B RID: 59
	[Register("com/google/android/datatransport/runtime/time/TimeModule_EventClockFactory", DoNotGenerateAcw = true)]
	public sealed class TimeModule_EventClockFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00005D94 File Offset: 0x00003F94
		internal static IntPtr class_ref
		{
			get
			{
				return TimeModule_EventClockFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00005DB8 File Offset: 0x00003FB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeModule_EventClockFactory._members;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeModule_EventClockFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00005DE4 File Offset: 0x00003FE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeModule_EventClockFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000026C4 File Offset: 0x000008C4
		internal TimeModule_EventClockFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Register(".ctor", "()V", "")]
		public TimeModule_EventClockFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TimeModule_EventClockFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TimeModule_EventClockFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00005E60 File Offset: 0x00004060
		[Register("create", "()Lcom/google/android/datatransport/runtime/time/TimeModule_EventClockFactory;", "")]
		public static TimeModule_EventClockFactory Create()
		{
			return Java.Lang.Object.GetObject<TimeModule_EventClockFactory>(TimeModule_EventClockFactory._members.StaticMethods.InvokeObjectMethod("create.()Lcom/google/android/datatransport/runtime/time/TimeModule_EventClockFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00005E94 File Offset: 0x00004094
		[Register("eventClock", "()Lcom/google/android/datatransport/runtime/time/Clock;", "")]
		public static IClock EventClock()
		{
			return Java.Lang.Object.GetObject<IClock>(TimeModule_EventClockFactory._members.StaticMethods.InvokeObjectMethod("eventClock.()Lcom/google/android/datatransport/runtime/time/Clock;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Register("get", "()Lcom/google/android/datatransport/runtime/time/Clock;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TimeModule_EventClockFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/time/Clock;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400006E RID: 110
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/TimeModule_EventClockFactory", typeof(TimeModule_EventClockFactory));
	}
}
