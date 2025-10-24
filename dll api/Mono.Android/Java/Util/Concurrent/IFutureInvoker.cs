using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000354 RID: 852
	[Register("java/util/concurrent/Future", DoNotGenerateAcw = true)]
	internal class IFutureInvoker : Java.Lang.Object, IFuture, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x0006BB8C File Offset: 0x00069D8C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFutureInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x0006BBB0 File Offset: 0x00069DB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFutureInvoker._members;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x0006BBB7 File Offset: 0x00069DB7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x0006BBBF File Offset: 0x00069DBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFutureInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0006BBCB File Offset: 0x00069DCB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFutureInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.Future'.");
			}
			return handle;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x0006BBF6 File Offset: 0x00069DF6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x0006BC28 File Offset: 0x00069E28
		public IFutureInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFutureInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0006BC60 File Offset: 0x00069E60
		private static Delegate GetIsCancelledHandler()
		{
			if (IFutureInvoker.cb_isCancelled == null)
			{
				IFutureInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IFutureInvoker.n_IsCancelled));
			}
			return IFutureInvoker.cb_isCancelled;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0006BC84 File Offset: 0x00069E84
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x0006BC93 File Offset: 0x00069E93
		public bool IsCancelled
		{
			get
			{
				if (this.id_isCancelled == IntPtr.Zero)
				{
					this.id_isCancelled = JNIEnv.GetMethodID(this.class_ref, "isCancelled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCancelled);
			}
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x0006BCD3 File Offset: 0x00069ED3
		private static Delegate GetIsDoneHandler()
		{
			if (IFutureInvoker.cb_isDone == null)
			{
				IFutureInvoker.cb_isDone = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IFutureInvoker.n_IsDone));
			}
			return IFutureInvoker.cb_isDone;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0006BCF7 File Offset: 0x00069EF7
		private static bool n_IsDone(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDone;
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x0006BD06 File Offset: 0x00069F06
		public bool IsDone
		{
			get
			{
				if (this.id_isDone == IntPtr.Zero)
				{
					this.id_isDone = JNIEnv.GetMethodID(this.class_ref, "isDone", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isDone);
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0006BD46 File Offset: 0x00069F46
		private static Delegate GetCancel_ZHandler()
		{
			if (IFutureInvoker.cb_cancel_Z == null)
			{
				IFutureInvoker.cb_cancel_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(IFutureInvoker.n_Cancel_Z));
			}
			return IFutureInvoker.cb_cancel_Z;
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0006BD6A File Offset: 0x00069F6A
		private static bool n_Cancel_Z(IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			return Java.Lang.Object.GetObject<IFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel(mayInterruptIfRunning);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0006BD7C File Offset: 0x00069F7C
		public unsafe bool Cancel(bool mayInterruptIfRunning)
		{
			if (this.id_cancel_Z == IntPtr.Zero)
			{
				this.id_cancel_Z = JNIEnv.GetMethodID(this.class_ref, "cancel", "(Z)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(mayInterruptIfRunning);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_cancel_Z, ptr);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x0006BDE0 File Offset: 0x00069FE0
		private static Delegate GetGetHandler()
		{
			if (IFutureInvoker.cb_get == null)
			{
				IFutureInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFutureInvoker.n_Get));
			}
			return IFutureInvoker.cb_get;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0006BE04 File Offset: 0x0006A004
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0006BE18 File Offset: 0x0006A018
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x0006BE69 File Offset: 0x0006A069
		private static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IFutureInvoker.cb_get_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IFutureInvoker.cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(IFutureInvoker.n_Get_JLjava_util_concurrent_TimeUnit_));
			}
			return IFutureInvoker.cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0006BE90 File Offset: 0x0006A090
		private static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			IFuture @object = Java.Lang.Object.GetObject<IFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(timeout, object2));
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0006BEBC File Offset: 0x0006A0BC
		public unsafe Java.Lang.Object Get(long timeout, TimeUnit unit)
		{
			if (this.id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeout);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000F86 RID: 3974
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/Future", typeof(IFutureInvoker));

		// Token: 0x04000F87 RID: 3975
		private IntPtr class_ref;

		// Token: 0x04000F88 RID: 3976
		private static Delegate cb_isCancelled;

		// Token: 0x04000F89 RID: 3977
		private IntPtr id_isCancelled;

		// Token: 0x04000F8A RID: 3978
		private static Delegate cb_isDone;

		// Token: 0x04000F8B RID: 3979
		private IntPtr id_isDone;

		// Token: 0x04000F8C RID: 3980
		private static Delegate cb_cancel_Z;

		// Token: 0x04000F8D RID: 3981
		private IntPtr id_cancel_Z;

		// Token: 0x04000F8E RID: 3982
		private static Delegate cb_get;

		// Token: 0x04000F8F RID: 3983
		private IntPtr id_get;

		// Token: 0x04000F90 RID: 3984
		private static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F91 RID: 3985
		private IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
	}
}
