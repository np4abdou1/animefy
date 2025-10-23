using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x0200003F RID: 63
	[Register("com/google/android/datatransport/runtime/time/WallTimeClock", DoNotGenerateAcw = true)]
	public class WallTimeClock : Java.Lang.Object, IClock, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000061CC File Offset: 0x000043CC
		internal static IntPtr class_ref
		{
			get
			{
				return WallTimeClock._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000061F0 File Offset: 0x000043F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WallTimeClock._members;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000061F8 File Offset: 0x000043F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WallTimeClock._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000621C File Offset: 0x0000441C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WallTimeClock._members.ManagedPeerType;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000026C4 File Offset: 0x000008C4
		protected WallTimeClock(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00006228 File Offset: 0x00004428
		[Register(".ctor", "()V", "")]
		public WallTimeClock() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WallTimeClock._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WallTimeClock._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00006296 File Offset: 0x00004496
		private static Delegate GetGetTimeHandler()
		{
			if (WallTimeClock.cb_getTime == null)
			{
				WallTimeClock.cb_getTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(WallTimeClock.n_GetTime));
			}
			return WallTimeClock.cb_getTime;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000062BA File Offset: 0x000044BA
		private static long n_GetTime(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WallTimeClock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Time;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000062C9 File Offset: 0x000044C9
		public virtual long Time
		{
			[Register("getTime", "()J", "GetGetTimeHandler")]
			get
			{
				return WallTimeClock._members.InstanceMethods.InvokeVirtualInt64Method("getTime.()J", this, null);
			}
		}

		// Token: 0x04000072 RID: 114
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/WallTimeClock", typeof(WallTimeClock));

		// Token: 0x04000073 RID: 115
		private static Delegate cb_getTime;
	}
}
