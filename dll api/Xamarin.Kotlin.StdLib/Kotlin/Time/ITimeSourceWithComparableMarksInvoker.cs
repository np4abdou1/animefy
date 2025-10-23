using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000CF RID: 207
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/TimeSource$WithComparableMarks", DoNotGenerateAcw = true)]
	internal class ITimeSourceWithComparableMarksInvoker : Java.Lang.Object, ITimeSourceWithComparableMarks, ITimeSource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		private static IntPtr java_class_ref
		{
			get
			{
				return ITimeSourceWithComparableMarksInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0000F9CC File Offset: 0x0000DBCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITimeSourceWithComparableMarksInvoker._members;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0000F9D3 File Offset: 0x0000DBD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0000F9DB File Offset: 0x0000DBDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITimeSourceWithComparableMarksInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000F9E7 File Offset: 0x0000DBE7
		[NullableContext(2)]
		public static ITimeSourceWithComparableMarks GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITimeSourceWithComparableMarks>(handle, transfer);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITimeSourceWithComparableMarksInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.time.TimeSource.WithComparableMarks'.");
			}
			return handle;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000FA1B File Offset: 0x0000DC1B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		public ITimeSourceWithComparableMarksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITimeSourceWithComparableMarksInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000FA84 File Offset: 0x0000DC84
		private static Delegate GetMarkNowHandler()
		{
			if (ITimeSourceWithComparableMarksInvoker.cb_markNow == null)
			{
				ITimeSourceWithComparableMarksInvoker.cb_markNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITimeSourceWithComparableMarksInvoker.n_MarkNow));
			}
			return ITimeSourceWithComparableMarksInvoker.cb_markNow;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		private static IntPtr n_MarkNow(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITimeSourceWithComparableMarks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MarkNow());
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000FABC File Offset: 0x0000DCBC
		public ITimeMark MarkNow()
		{
			if (this.id_markNow == IntPtr.Zero)
			{
				this.id_markNow = JNIEnv.GetMethodID(this.class_ref, "markNow", "()Lkotlin/time/ComparableTimeMark;");
			}
			return Java.Lang.Object.GetObject<ITimeMark>(JNIEnv.CallObjectMethod(base.Handle, this.id_markNow), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001BB RID: 443
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TimeSource$WithComparableMarks", typeof(ITimeSourceWithComparableMarksInvoker));

		// Token: 0x040001BC RID: 444
		private IntPtr class_ref;

		// Token: 0x040001BD RID: 445
		[Nullable(2)]
		private static Delegate cb_markNow;

		// Token: 0x040001BE RID: 446
		private IntPtr id_markNow;
	}
}
