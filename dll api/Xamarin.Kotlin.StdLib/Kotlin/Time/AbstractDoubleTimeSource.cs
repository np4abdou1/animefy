using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000BB RID: 187
	[NullableContext(1)]
	[Nullable(0)]
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("kotlin/time/AbstractDoubleTimeSource", DoNotGenerateAcw = true)]
	public abstract class AbstractDoubleTimeSource : Java.Lang.Object, ITimeSourceWithComparableMarks, ITimeSource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0000D348 File Offset: 0x0000B548
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractDoubleTimeSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0000D36C File Offset: 0x0000B56C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractDoubleTimeSource._members;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0000D374 File Offset: 0x0000B574
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractDoubleTimeSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0000D398 File Offset: 0x0000B598
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractDoubleTimeSource._members.ManagedPeerType;
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
		protected AbstractDoubleTimeSource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Register(".ctor", "(Lkotlin/time/DurationUnit;)V", "")]
		public unsafe AbstractDoubleTimeSource(DurationUnit unit) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				base.SetHandle(AbstractDoubleTimeSource._members.InstanceMethods.StartCreateInstance("(Lkotlin/time/DurationUnit;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbstractDoubleTimeSource._members.InstanceMethods.FinishCreateInstance("(Lkotlin/time/DurationUnit;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0000D460 File Offset: 0x0000B660
		protected DurationUnit Unit
		{
			[Register("getUnit", "()Lkotlin/time/DurationUnit;", "")]
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(AbstractDoubleTimeSource._members.InstanceMethods.InvokeNonvirtualObjectMethod("getUnit.()Lkotlin/time/DurationUnit;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000D492 File Offset: 0x0000B692
		private static Delegate GetMarkNowHandler()
		{
			if (AbstractDoubleTimeSource.cb_markNow == null)
			{
				AbstractDoubleTimeSource.cb_markNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractDoubleTimeSource.n_MarkNow));
			}
			return AbstractDoubleTimeSource.cb_markNow;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
		private static IntPtr n_MarkNow(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractDoubleTimeSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MarkNow());
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		[Register("markNow", "()Lkotlin/time/ComparableTimeMark;", "GetMarkNowHandler")]
		public virtual ITimeMark MarkNow()
		{
			return Java.Lang.Object.GetObject<ITimeMark>(AbstractDoubleTimeSource._members.InstanceMethods.InvokeVirtualObjectMethod("markNow.()Lkotlin/time/ComparableTimeMark;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000D4FE File Offset: 0x0000B6FE
		private static Delegate GetReadHandler()
		{
			if (AbstractDoubleTimeSource.cb_read == null)
			{
				AbstractDoubleTimeSource.cb_read = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(AbstractDoubleTimeSource.n_Read));
			}
			return AbstractDoubleTimeSource.cb_read;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000D522 File Offset: 0x0000B722
		private static double n_Read(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractDoubleTimeSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Read();
		}

		// Token: 0x06000562 RID: 1378
		[Register("read", "()D", "GetReadHandler")]
		protected abstract double Read();

		// Token: 0x0400017F RID: 383
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/AbstractDoubleTimeSource", typeof(AbstractDoubleTimeSource));

		// Token: 0x04000180 RID: 384
		[Nullable(2)]
		private static Delegate cb_markNow;

		// Token: 0x04000181 RID: 385
		[Nullable(2)]
		private static Delegate cb_read;
	}
}
