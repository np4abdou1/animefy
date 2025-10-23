using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000038 RID: 56
	[Register("com/google/android/datatransport/runtime/time/TestClock", DoNotGenerateAcw = true)]
	public class TestClock : Java.Lang.Object, IClock, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00005A70 File Offset: 0x00003C70
		internal static IntPtr class_ref
		{
			get
			{
				return TestClock._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00005A94 File Offset: 0x00003C94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TestClock._members;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00005A9C File Offset: 0x00003C9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TestClock._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TestClock._members.ManagedPeerType;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000026C4 File Offset: 0x000008C4
		protected TestClock(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00005ACC File Offset: 0x00003CCC
		[Register(".ctor", "(J)V", "")]
		public unsafe TestClock(long initialTimestamp) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(initialTimestamp);
			base.SetHandle(TestClock._members.InstanceMethods.StartCreateInstance("(J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			TestClock._members.InstanceMethods.FinishCreateInstance("(J)V", this, ptr);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00005B50 File Offset: 0x00003D50
		private static Delegate GetGetTimeHandler()
		{
			if (TestClock.cb_getTime == null)
			{
				TestClock.cb_getTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(TestClock.n_GetTime));
			}
			return TestClock.cb_getTime;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005B74 File Offset: 0x00003D74
		private static long n_GetTime(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TestClock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Time;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00005B83 File Offset: 0x00003D83
		public virtual long Time
		{
			[Register("getTime", "()J", "GetGetTimeHandler")]
			get
			{
				return TestClock._members.InstanceMethods.InvokeVirtualInt64Method("getTime.()J", this, null);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00005B9C File Offset: 0x00003D9C
		private static Delegate GetAdvance_JHandler()
		{
			if (TestClock.cb_advance_J == null)
			{
				TestClock.cb_advance_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(TestClock.n_Advance_J));
			}
			return TestClock.cb_advance_J;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00005BC0 File Offset: 0x00003DC0
		private static void n_Advance_J(IntPtr jnienv, IntPtr native__this, long value)
		{
			Java.Lang.Object.GetObject<TestClock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Advance(value);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00005BD0 File Offset: 0x00003DD0
		[Register("advance", "(J)V", "GetAdvance_JHandler")]
		public unsafe virtual void Advance(long value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			TestClock._members.InstanceMethods.InvokeVirtualVoidMethod("advance.(J)V", this, ptr);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00005C0B File Offset: 0x00003E0B
		private static Delegate GetTickHandler()
		{
			if (TestClock.cb_tick == null)
			{
				TestClock.cb_tick = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TestClock.n_Tick));
			}
			return TestClock.cb_tick;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00005C2F File Offset: 0x00003E2F
		private static void n_Tick(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TestClock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Tick();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00005C3E File Offset: 0x00003E3E
		[Register("tick", "()V", "GetTickHandler")]
		public virtual void Tick()
		{
			TestClock._members.InstanceMethods.InvokeVirtualVoidMethod("tick.()V", this, null);
		}

		// Token: 0x04000068 RID: 104
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/TestClock", typeof(TestClock));

		// Token: 0x04000069 RID: 105
		private static Delegate cb_getTime;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_advance_J;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_tick;
	}
}
