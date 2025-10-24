using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent.Locks
{
	// Token: 0x0200035D RID: 861
	[Register("java/util/concurrent/locks/Condition", DoNotGenerateAcw = true)]
	internal class IConditionInvoker : Java.Lang.Object, ICondition, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x0006DAD0 File Offset: 0x0006BCD0
		private static IntPtr java_class_ref
		{
			get
			{
				return IConditionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x0006DAF4 File Offset: 0x0006BCF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConditionInvoker._members;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x0006DAFB File Offset: 0x0006BCFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x0006DB03 File Offset: 0x0006BD03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConditionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0006DB0F File Offset: 0x0006BD0F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConditionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.locks.Condition'.");
			}
			return handle;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0006DB3A File Offset: 0x0006BD3A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0006DB6C File Offset: 0x0006BD6C
		public IConditionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConditionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x0006DBA4 File Offset: 0x0006BDA4
		private static Delegate GetAwaitHandler()
		{
			if (IConditionInvoker.cb_await == null)
			{
				IConditionInvoker.cb_await = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConditionInvoker.n_Await));
			}
			return IConditionInvoker.cb_await;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x0006DBC8 File Offset: 0x0006BDC8
		private static void n_Await(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICondition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Await();
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0006DBD7 File Offset: 0x0006BDD7
		public void Await()
		{
			if (this.id_await == IntPtr.Zero)
			{
				this.id_await = JNIEnv.GetMethodID(this.class_ref, "await", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_await);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0006DC17 File Offset: 0x0006BE17
		private static Delegate GetAwait_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IConditionInvoker.cb_await_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IConditionInvoker.cb_await_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_Z(IConditionInvoker.n_Await_JLjava_util_concurrent_TimeUnit_));
			}
			return IConditionInvoker.cb_await_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0006DC3C File Offset: 0x0006BE3C
		private static bool n_Await_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long time, IntPtr native_unit)
		{
			ICondition @object = Java.Lang.Object.GetObject<ICondition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.Await(time, object2);
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0006DC60 File Offset: 0x0006BE60
		public unsafe bool Await(long time, TimeUnit unit)
		{
			if (this.id_await_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_await_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(time);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_await_JLjava_util_concurrent_TimeUnit_, ptr);
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0006DCE6 File Offset: 0x0006BEE6
		private static Delegate GetAwaitNanos_JHandler()
		{
			if (IConditionInvoker.cb_awaitNanos_J == null)
			{
				IConditionInvoker.cb_awaitNanos_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_J(IConditionInvoker.n_AwaitNanos_J));
			}
			return IConditionInvoker.cb_awaitNanos_J;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x0006DD0A File Offset: 0x0006BF0A
		private static long n_AwaitNanos_J(IntPtr jnienv, IntPtr native__this, long nanosTimeout)
		{
			return Java.Lang.Object.GetObject<ICondition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AwaitNanos(nanosTimeout);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x0006DD1C File Offset: 0x0006BF1C
		public unsafe long AwaitNanos(long nanosTimeout)
		{
			if (this.id_awaitNanos_J == IntPtr.Zero)
			{
				this.id_awaitNanos_J = JNIEnv.GetMethodID(this.class_ref, "awaitNanos", "(J)J");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(nanosTimeout);
			return JNIEnv.CallLongMethod(base.Handle, this.id_awaitNanos_J, ptr);
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x0006DD80 File Offset: 0x0006BF80
		private static Delegate GetAwaitUninterruptiblyHandler()
		{
			if (IConditionInvoker.cb_awaitUninterruptibly == null)
			{
				IConditionInvoker.cb_awaitUninterruptibly = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConditionInvoker.n_AwaitUninterruptibly));
			}
			return IConditionInvoker.cb_awaitUninterruptibly;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x0006DDA4 File Offset: 0x0006BFA4
		private static void n_AwaitUninterruptibly(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICondition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AwaitUninterruptibly();
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x0006DDB3 File Offset: 0x0006BFB3
		public void AwaitUninterruptibly()
		{
			if (this.id_awaitUninterruptibly == IntPtr.Zero)
			{
				this.id_awaitUninterruptibly = JNIEnv.GetMethodID(this.class_ref, "awaitUninterruptibly", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_awaitUninterruptibly);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0006DDF3 File Offset: 0x0006BFF3
		private static Delegate GetAwaitUntil_Ljava_util_Date_Handler()
		{
			if (IConditionInvoker.cb_awaitUntil_Ljava_util_Date_ == null)
			{
				IConditionInvoker.cb_awaitUntil_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IConditionInvoker.n_AwaitUntil_Ljava_util_Date_));
			}
			return IConditionInvoker.cb_awaitUntil_Ljava_util_Date_;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0006DE18 File Offset: 0x0006C018
		private static bool n_AwaitUntil_Ljava_util_Date_(IntPtr jnienv, IntPtr native__this, IntPtr native_deadline)
		{
			ICondition @object = Java.Lang.Object.GetObject<ICondition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Date object2 = Java.Lang.Object.GetObject<Date>(native_deadline, JniHandleOwnership.DoNotTransfer);
			return @object.AwaitUntil(object2);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0006DE3C File Offset: 0x0006C03C
		public unsafe bool AwaitUntil(Date deadline)
		{
			if (this.id_awaitUntil_Ljava_util_Date_ == IntPtr.Zero)
			{
				this.id_awaitUntil_Ljava_util_Date_ = JNIEnv.GetMethodID(this.class_ref, "awaitUntil", "(Ljava/util/Date;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((deadline == null) ? IntPtr.Zero : deadline.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_awaitUntil_Ljava_util_Date_, ptr);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x0006DEAF File Offset: 0x0006C0AF
		private static Delegate GetSignalHandler()
		{
			if (IConditionInvoker.cb_signal == null)
			{
				IConditionInvoker.cb_signal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConditionInvoker.n_Signal));
			}
			return IConditionInvoker.cb_signal;
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0006DED3 File Offset: 0x0006C0D3
		private static void n_Signal(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICondition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Signal();
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x0006DEE2 File Offset: 0x0006C0E2
		public void Signal()
		{
			if (this.id_signal == IntPtr.Zero)
			{
				this.id_signal = JNIEnv.GetMethodID(this.class_ref, "signal", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_signal);
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x0006DF22 File Offset: 0x0006C122
		private static Delegate GetSignalAllHandler()
		{
			if (IConditionInvoker.cb_signalAll == null)
			{
				IConditionInvoker.cb_signalAll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConditionInvoker.n_SignalAll));
			}
			return IConditionInvoker.cb_signalAll;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0006DF46 File Offset: 0x0006C146
		private static void n_SignalAll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICondition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SignalAll();
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0006DF55 File Offset: 0x0006C155
		public void SignalAll()
		{
			if (this.id_signalAll == IntPtr.Zero)
			{
				this.id_signalAll = JNIEnv.GetMethodID(this.class_ref, "signalAll", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_signalAll);
		}

		// Token: 0x04000FCA RID: 4042
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/locks/Condition", typeof(IConditionInvoker));

		// Token: 0x04000FCB RID: 4043
		private IntPtr class_ref;

		// Token: 0x04000FCC RID: 4044
		private static Delegate cb_await;

		// Token: 0x04000FCD RID: 4045
		private IntPtr id_await;

		// Token: 0x04000FCE RID: 4046
		private static Delegate cb_await_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FCF RID: 4047
		private IntPtr id_await_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FD0 RID: 4048
		private static Delegate cb_awaitNanos_J;

		// Token: 0x04000FD1 RID: 4049
		private IntPtr id_awaitNanos_J;

		// Token: 0x04000FD2 RID: 4050
		private static Delegate cb_awaitUninterruptibly;

		// Token: 0x04000FD3 RID: 4051
		private IntPtr id_awaitUninterruptibly;

		// Token: 0x04000FD4 RID: 4052
		private static Delegate cb_awaitUntil_Ljava_util_Date_;

		// Token: 0x04000FD5 RID: 4053
		private IntPtr id_awaitUntil_Ljava_util_Date_;

		// Token: 0x04000FD6 RID: 4054
		private static Delegate cb_signal;

		// Token: 0x04000FD7 RID: 4055
		private IntPtr id_signal;

		// Token: 0x04000FD8 RID: 4056
		private static Delegate cb_signalAll;

		// Token: 0x04000FD9 RID: 4057
		private IntPtr id_signalAll;
	}
}
