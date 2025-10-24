using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent.Locks
{
	// Token: 0x0200035F RID: 863
	[Register("java/util/concurrent/locks/Lock", DoNotGenerateAcw = true)]
	internal class ILockInvoker : Java.Lang.Object, ILock, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x0006DFB0 File Offset: 0x0006C1B0
		private static IntPtr java_class_ref
		{
			get
			{
				return ILockInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x0006DFD4 File Offset: 0x0006C1D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILockInvoker._members;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x0006DFDB File Offset: 0x0006C1DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x0006DFE3 File Offset: 0x0006C1E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILockInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0006DFEF File Offset: 0x0006C1EF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILockInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.locks.Lock'.");
			}
			return handle;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x0006E01A File Offset: 0x0006C21A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x0006E04C File Offset: 0x0006C24C
		public ILockInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILockInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x0006E084 File Offset: 0x0006C284
		private static Delegate GetLockHandler()
		{
			if (ILockInvoker.cb_lock == null)
			{
				ILockInvoker.cb_lock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ILockInvoker.n_Lock));
			}
			return ILockInvoker.cb_lock;
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x0006E0A8 File Offset: 0x0006C2A8
		private static void n_Lock(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ILock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lock();
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x0006E0B7 File Offset: 0x0006C2B7
		public void Lock()
		{
			if (this.id_lock == IntPtr.Zero)
			{
				this.id_lock = JNIEnv.GetMethodID(this.class_ref, "lock", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_lock);
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0006E0F7 File Offset: 0x0006C2F7
		private static Delegate GetLockInterruptiblyHandler()
		{
			if (ILockInvoker.cb_lockInterruptibly == null)
			{
				ILockInvoker.cb_lockInterruptibly = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ILockInvoker.n_LockInterruptibly));
			}
			return ILockInvoker.cb_lockInterruptibly;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x0006E11B File Offset: 0x0006C31B
		private static void n_LockInterruptibly(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ILock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LockInterruptibly();
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0006E12A File Offset: 0x0006C32A
		public void LockInterruptibly()
		{
			if (this.id_lockInterruptibly == IntPtr.Zero)
			{
				this.id_lockInterruptibly = JNIEnv.GetMethodID(this.class_ref, "lockInterruptibly", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_lockInterruptibly);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x0006E16A File Offset: 0x0006C36A
		private static Delegate GetNewConditionHandler()
		{
			if (ILockInvoker.cb_newCondition == null)
			{
				ILockInvoker.cb_newCondition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILockInvoker.n_NewCondition));
			}
			return ILockInvoker.cb_newCondition;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x0006E18E File Offset: 0x0006C38E
		private static IntPtr n_NewCondition(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NewCondition());
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x0006E1A4 File Offset: 0x0006C3A4
		public ICondition NewCondition()
		{
			if (this.id_newCondition == IntPtr.Zero)
			{
				this.id_newCondition = JNIEnv.GetMethodID(this.class_ref, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
			}
			return Java.Lang.Object.GetObject<ICondition>(JNIEnv.CallObjectMethod(base.Handle, this.id_newCondition), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x0006E1F5 File Offset: 0x0006C3F5
		private static Delegate GetTryLockHandler()
		{
			if (ILockInvoker.cb_tryLock == null)
			{
				ILockInvoker.cb_tryLock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ILockInvoker.n_TryLock));
			}
			return ILockInvoker.cb_tryLock;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x0006E219 File Offset: 0x0006C419
		private static bool n_TryLock(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TryLock();
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x0006E228 File Offset: 0x0006C428
		public bool TryLock()
		{
			if (this.id_tryLock == IntPtr.Zero)
			{
				this.id_tryLock = JNIEnv.GetMethodID(this.class_ref, "tryLock", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_tryLock);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x0006E268 File Offset: 0x0006C468
		private static Delegate GetTryLock_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (ILockInvoker.cb_tryLock_JLjava_util_concurrent_TimeUnit_ == null)
			{
				ILockInvoker.cb_tryLock_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_Z(ILockInvoker.n_TryLock_JLjava_util_concurrent_TimeUnit_));
			}
			return ILockInvoker.cb_tryLock_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x0006E28C File Offset: 0x0006C48C
		private static bool n_TryLock_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long time, IntPtr native_unit)
		{
			ILock @object = Java.Lang.Object.GetObject<ILock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.TryLock(time, object2);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x0006E2B0 File Offset: 0x0006C4B0
		public unsafe bool TryLock(long time, TimeUnit unit)
		{
			if (this.id_tryLock_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_tryLock_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(time);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_tryLock_JLjava_util_concurrent_TimeUnit_, ptr);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0006E336 File Offset: 0x0006C536
		private static Delegate GetUnlockHandler()
		{
			if (ILockInvoker.cb_unlock == null)
			{
				ILockInvoker.cb_unlock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ILockInvoker.n_Unlock));
			}
			return ILockInvoker.cb_unlock;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x0006E35A File Offset: 0x0006C55A
		private static void n_Unlock(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ILock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Unlock();
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0006E369 File Offset: 0x0006C569
		public void Unlock()
		{
			if (this.id_unlock == IntPtr.Zero)
			{
				this.id_unlock = JNIEnv.GetMethodID(this.class_ref, "unlock", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_unlock);
		}

		// Token: 0x04000FDA RID: 4058
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/locks/Lock", typeof(ILockInvoker));

		// Token: 0x04000FDB RID: 4059
		private IntPtr class_ref;

		// Token: 0x04000FDC RID: 4060
		private static Delegate cb_lock;

		// Token: 0x04000FDD RID: 4061
		private IntPtr id_lock;

		// Token: 0x04000FDE RID: 4062
		private static Delegate cb_lockInterruptibly;

		// Token: 0x04000FDF RID: 4063
		private IntPtr id_lockInterruptibly;

		// Token: 0x04000FE0 RID: 4064
		private static Delegate cb_newCondition;

		// Token: 0x04000FE1 RID: 4065
		private IntPtr id_newCondition;

		// Token: 0x04000FE2 RID: 4066
		private static Delegate cb_tryLock;

		// Token: 0x04000FE3 RID: 4067
		private IntPtr id_tryLock;

		// Token: 0x04000FE4 RID: 4068
		private static Delegate cb_tryLock_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FE5 RID: 4069
		private IntPtr id_tryLock_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FE6 RID: 4070
		private static Delegate cb_unlock;

		// Token: 0x04000FE7 RID: 4071
		private IntPtr id_unlock;
	}
}
