using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000BD RID: 189
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/AbstractLongTimeSource", DoNotGenerateAcw = true)]
	public abstract class AbstractLongTimeSource : Java.Lang.Object, ITimeSourceWithComparableMarks, ITimeSource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractLongTimeSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0000D5C4 File Offset: 0x0000B7C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractLongTimeSource._members;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0000D5CC File Offset: 0x0000B7CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractLongTimeSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractLongTimeSource._members.ManagedPeerType;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		protected AbstractLongTimeSource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000D608 File Offset: 0x0000B808
		[Register(".ctor", "(Lkotlin/time/DurationUnit;)V", "")]
		public unsafe AbstractLongTimeSource(DurationUnit unit) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				base.SetHandle(AbstractLongTimeSource._members.InstanceMethods.StartCreateInstance("(Lkotlin/time/DurationUnit;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbstractLongTimeSource._members.InstanceMethods.FinishCreateInstance("(Lkotlin/time/DurationUnit;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		protected DurationUnit Unit
		{
			[Register("getUnit", "()Lkotlin/time/DurationUnit;", "")]
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(AbstractLongTimeSource._members.InstanceMethods.InvokeNonvirtualObjectMethod("getUnit.()Lkotlin/time/DurationUnit;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000D6EA File Offset: 0x0000B8EA
		private static Delegate GetMarkNowHandler()
		{
			if (AbstractLongTimeSource.cb_markNow == null)
			{
				AbstractLongTimeSource.cb_markNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractLongTimeSource.n_MarkNow));
			}
			return AbstractLongTimeSource.cb_markNow;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000D70E File Offset: 0x0000B90E
		private static IntPtr n_MarkNow(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractLongTimeSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MarkNow());
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000D724 File Offset: 0x0000B924
		[Register("markNow", "()Lkotlin/time/ComparableTimeMark;", "GetMarkNowHandler")]
		public virtual ITimeMark MarkNow()
		{
			return Java.Lang.Object.GetObject<ITimeMark>(AbstractLongTimeSource._members.InstanceMethods.InvokeVirtualObjectMethod("markNow.()Lkotlin/time/ComparableTimeMark;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000D756 File Offset: 0x0000B956
		private static Delegate GetReadHandler()
		{
			if (AbstractLongTimeSource.cb_read == null)
			{
				AbstractLongTimeSource.cb_read = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AbstractLongTimeSource.n_Read));
			}
			return AbstractLongTimeSource.cb_read;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000D77A File Offset: 0x0000B97A
		private static long n_Read(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractLongTimeSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Read();
		}

		// Token: 0x06000575 RID: 1397
		[Register("read", "()J", "GetReadHandler")]
		protected abstract long Read();

		// Token: 0x04000183 RID: 387
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/AbstractLongTimeSource", typeof(AbstractLongTimeSource));

		// Token: 0x04000184 RID: 388
		[Nullable(2)]
		private static Delegate cb_markNow;

		// Token: 0x04000185 RID: 389
		[Nullable(2)]
		private static Delegate cb_read;
	}
}
