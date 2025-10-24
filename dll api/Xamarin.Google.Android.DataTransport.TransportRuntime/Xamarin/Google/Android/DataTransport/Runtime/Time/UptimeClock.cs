using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x0200003D RID: 61
	[Register("com/google/android/datatransport/runtime/time/UptimeClock", DoNotGenerateAcw = true)]
	public class UptimeClock : Java.Lang.Object, IClock, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00006098 File Offset: 0x00004298
		internal static IntPtr class_ref
		{
			get
			{
				return UptimeClock._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000060BC File Offset: 0x000042BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UptimeClock._members;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000060C4 File Offset: 0x000042C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UptimeClock._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000060E8 File Offset: 0x000042E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UptimeClock._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000026C4 File Offset: 0x000008C4
		protected UptimeClock(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000060F4 File Offset: 0x000042F4
		[Register(".ctor", "()V", "")]
		public UptimeClock() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UptimeClock._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UptimeClock._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00006162 File Offset: 0x00004362
		private static Delegate GetGetTimeHandler()
		{
			if (UptimeClock.cb_getTime == null)
			{
				UptimeClock.cb_getTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(UptimeClock.n_GetTime));
			}
			return UptimeClock.cb_getTime;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00006186 File Offset: 0x00004386
		private static long n_GetTime(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<UptimeClock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Time;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00006195 File Offset: 0x00004395
		public virtual long Time
		{
			[Register("getTime", "()J", "GetGetTimeHandler")]
			get
			{
				return UptimeClock._members.InstanceMethods.InvokeVirtualInt64Method("getTime.()J", this, null);
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/UptimeClock", typeof(UptimeClock));

		// Token: 0x04000071 RID: 113
		private static Delegate cb_getTime;
	}
}
