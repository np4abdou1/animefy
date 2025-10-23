using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000084 RID: 132
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/TimeoutCancellationException", DoNotGenerateAcw = true)]
	public sealed class TimeoutCancellationException : CancellationException, ICopyableThrowable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00013DAC File Offset: 0x00011FAC
		internal static IntPtr class_ref
		{
			get
			{
				return TimeoutCancellationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeoutCancellationException._members;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00013DD8 File Offset: 0x00011FD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeoutCancellationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00013DFC File Offset: 0x00011FFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeoutCancellationException._members.ManagedPeerType;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00013E08 File Offset: 0x00012008
		internal TimeoutCancellationException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00013E14 File Offset: 0x00012014
		[Register("createCopy", "()Lkotlinx/coroutines/TimeoutCancellationException;", "")]
		public TimeoutCancellationException CreateCopy()
		{
			return Java.Lang.Object.GetObject<TimeoutCancellationException>(TimeoutCancellationException._members.InstanceMethods.InvokeAbstractObjectMethod("createCopy.()Lkotlinx/coroutines/TimeoutCancellationException;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00013E46 File Offset: 0x00012046
		[NullableContext(2)]
		Java.Lang.Object ICopyableThrowable.CreateCopy()
		{
			return this.CreateCopy().JavaCast<Java.Lang.Object>();
		}

		// Token: 0x0400020D RID: 525
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/TimeoutCancellationException", typeof(TimeoutCancellationException));
	}
}
