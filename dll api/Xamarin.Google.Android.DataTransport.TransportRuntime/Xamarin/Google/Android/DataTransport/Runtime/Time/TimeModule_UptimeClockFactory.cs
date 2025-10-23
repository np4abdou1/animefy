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
	// Token: 0x0200003C RID: 60
	[Register("com/google/android/datatransport/runtime/time/TimeModule_UptimeClockFactory", DoNotGenerateAcw = true)]
	public sealed class TimeModule_UptimeClockFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00005F18 File Offset: 0x00004118
		internal static IntPtr class_ref
		{
			get
			{
				return TimeModule_UptimeClockFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00005F3C File Offset: 0x0000413C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeModule_UptimeClockFactory._members;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00005F44 File Offset: 0x00004144
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeModule_UptimeClockFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00005F68 File Offset: 0x00004168
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeModule_UptimeClockFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000026C4 File Offset: 0x000008C4
		internal TimeModule_UptimeClockFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00005F74 File Offset: 0x00004174
		[Register(".ctor", "()V", "")]
		public TimeModule_UptimeClockFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TimeModule_UptimeClockFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TimeModule_UptimeClockFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00005FE4 File Offset: 0x000041E4
		[Register("create", "()Lcom/google/android/datatransport/runtime/time/TimeModule_UptimeClockFactory;", "")]
		public static TimeModule_UptimeClockFactory Create()
		{
			return Java.Lang.Object.GetObject<TimeModule_UptimeClockFactory>(TimeModule_UptimeClockFactory._members.StaticMethods.InvokeObjectMethod("create.()Lcom/google/android/datatransport/runtime/time/TimeModule_UptimeClockFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00006018 File Offset: 0x00004218
		[Register("get", "()Lcom/google/android/datatransport/runtime/time/Clock;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TimeModule_UptimeClockFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/time/Clock;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000604C File Offset: 0x0000424C
		[Register("uptimeClock", "()Lcom/google/android/datatransport/runtime/time/Clock;", "")]
		public static IClock UptimeClock()
		{
			return Java.Lang.Object.GetObject<IClock>(TimeModule_UptimeClockFactory._members.StaticMethods.InvokeObjectMethod("uptimeClock.()Lcom/google/android/datatransport/runtime/time/Clock;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400006F RID: 111
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/TimeModule_UptimeClockFactory", typeof(TimeModule_UptimeClockFactory));
	}
}
