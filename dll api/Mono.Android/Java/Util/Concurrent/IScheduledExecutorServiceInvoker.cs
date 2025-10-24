using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000356 RID: 854
	[Register("java/util/concurrent/ScheduledExecutorService", DoNotGenerateAcw = true)]
	internal class IScheduledExecutorServiceInvoker : Java.Lang.Object, IScheduledExecutorService, IExecutorService, IExecutor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x0006BF64 File Offset: 0x0006A164
		private static IntPtr java_class_ref
		{
			get
			{
				return IScheduledExecutorServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x0006BF88 File Offset: 0x0006A188
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScheduledExecutorServiceInvoker._members;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0006BF8F File Offset: 0x0006A18F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x0006BF97 File Offset: 0x0006A197
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScheduledExecutorServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0006BFA3 File Offset: 0x0006A1A3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScheduledExecutorServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.ScheduledExecutorService'.");
			}
			return handle;
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x0006BFCE File Offset: 0x0006A1CE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0006C000 File Offset: 0x0006A200
		public IScheduledExecutorServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScheduledExecutorServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x0006C038 File Offset: 0x0006A238
		private static Delegate GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IScheduledExecutorServiceInvoker.cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IScheduledExecutorServiceInvoker.cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_L(IScheduledExecutorServiceInvoker.n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_));
			}
			return IScheduledExecutorServiceInvoker.cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0006C05C File Offset: 0x0006A25C
		private static IntPtr n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long delay, IntPtr native_unit)
		{
			IScheduledExecutorService @object = Java.Lang.Object.GetObject<IScheduledExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			TimeUnit object3 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Schedule(object2, delay, object3));
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0006C090 File Offset: 0x0006A290
		public unsafe IScheduledFuture Schedule(IRunnable command, long delay, TimeUnit unit)
		{
			if (this.id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
			ptr[1] = new JValue(delay);
			ptr[2] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<IScheduledFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x0006C146 File Offset: 0x0006A346
		private static Delegate GetSchedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IScheduledExecutorServiceInvoker.cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IScheduledExecutorServiceInvoker.cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_L(IScheduledExecutorServiceInvoker.n_Schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_));
			}
			return IScheduledExecutorServiceInvoker.cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x0006C16C File Offset: 0x0006A36C
		private static IntPtr n_Schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_callable, long delay, IntPtr native_unit)
		{
			IScheduledExecutorService @object = Java.Lang.Object.GetObject<IScheduledExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICallable object2 = Java.Lang.Object.GetObject<ICallable>(native_callable, JniHandleOwnership.DoNotTransfer);
			TimeUnit object3 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Schedule(object2, delay, object3));
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x0006C1A0 File Offset: 0x0006A3A0
		public unsafe IScheduledFuture Schedule(ICallable callable, long delay, TimeUnit unit)
		{
			if (this.id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((callable == null) ? IntPtr.Zero : ((Java.Lang.Object)callable).Handle);
			ptr[1] = new JValue(delay);
			ptr[2] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<IScheduledFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x0006C256 File Offset: 0x0006A456
		private static Delegate GetScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IScheduledExecutorServiceInvoker.cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
			{
				IScheduledExecutorServiceInvoker.cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJJL_L(IScheduledExecutorServiceInvoker.n_ScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_));
			}
			return IScheduledExecutorServiceInvoker.cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x0006C27C File Offset: 0x0006A47C
		private static IntPtr n_ScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long initialDelay, long period, IntPtr native_unit)
		{
			IScheduledExecutorService @object = Java.Lang.Object.GetObject<IScheduledExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			TimeUnit object3 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ScheduleAtFixedRate(object2, initialDelay, period, object3));
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0006C2B4 File Offset: 0x0006A4B4
		public unsafe IScheduledFuture ScheduleAtFixedRate(IRunnable command, long initialDelay, long period, TimeUnit unit)
		{
			if (this.id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
			ptr[1] = new JValue(initialDelay);
			ptr[2] = new JValue(period);
			ptr[3] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<IScheduledFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0006C382 File Offset: 0x0006A582
		private static Delegate GetScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IScheduledExecutorServiceInvoker.cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
			{
				IScheduledExecutorServiceInvoker.cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJJL_L(IScheduledExecutorServiceInvoker.n_ScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_));
			}
			return IScheduledExecutorServiceInvoker.cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		private static IntPtr n_ScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long initialDelay, long delay, IntPtr native_unit)
		{
			IScheduledExecutorService @object = Java.Lang.Object.GetObject<IScheduledExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			TimeUnit object3 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ScheduleWithFixedDelay(object2, initialDelay, delay, object3));
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
		public unsafe IScheduledFuture ScheduleWithFixedDelay(IRunnable command, long initialDelay, long delay, TimeUnit unit)
		{
			if (this.id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
			ptr[1] = new JValue(initialDelay);
			ptr[2] = new JValue(delay);
			ptr[3] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<IScheduledFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x0006C4AE File Offset: 0x0006A6AE
		public bool IsShutdown
		{
			get
			{
				if (this.id_isShutdown == IntPtr.Zero)
				{
					this.id_isShutdown = JNIEnv.GetMethodID(this.class_ref, "isShutdown", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isShutdown);
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x0006C4EE File Offset: 0x0006A6EE
		public bool IsTerminated
		{
			get
			{
				if (this.id_isTerminated == IntPtr.Zero)
				{
					this.id_isTerminated = JNIEnv.GetMethodID(this.class_ref, "isTerminated", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isTerminated);
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0006C530 File Offset: 0x0006A730
		public unsafe bool AwaitTermination(long timeout, TimeUnit unit)
		{
			if (this.id_awaitTermination_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeout);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_awaitTermination_JLjava_util_concurrent_TimeUnit_, ptr);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0006C5B8 File Offset: 0x0006A7B8
		public unsafe IList InvokeAll(ICollection tasks)
		{
			if (this.id_invokeAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_invokeAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IList result = JavaList.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeAll_Ljava_util_Collection_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0006C630 File Offset: 0x0006A830
		public unsafe IList InvokeAll(ICollection tasks, long timeout, TimeUnit unit)
		{
			if (this.id_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(timeout);
			ptr[2] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			IList result = JavaList.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0006C6E0 File Offset: 0x0006A8E0
		public unsafe Java.Lang.Object InvokeAny(ICollection tasks)
		{
			if (this.id_invokeAny_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_invokeAny_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeAny_Ljava_util_Collection_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0006C758 File Offset: 0x0006A958
		public unsafe Java.Lang.Object InvokeAny(ICollection tasks, long timeout, TimeUnit unit)
		{
			if (this.id_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(timeout);
			ptr[2] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x0006C807 File Offset: 0x0006AA07
		public void Shutdown()
		{
			if (this.id_shutdown == IntPtr.Zero)
			{
				this.id_shutdown = JNIEnv.GetMethodID(this.class_ref, "shutdown", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_shutdown);
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x0006C848 File Offset: 0x0006AA48
		public IList<IRunnable> ShutdownNow()
		{
			if (this.id_shutdownNow == IntPtr.Zero)
			{
				this.id_shutdownNow = JNIEnv.GetMethodID(this.class_ref, "shutdownNow", "()Ljava/util/List;");
			}
			return JavaList<IRunnable>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_shutdownNow), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x0006C89C File Offset: 0x0006AA9C
		public unsafe IFuture Submit(IRunnable task)
		{
			if (this.id_submit_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_submit_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
			return Java.Lang.Object.GetObject<IFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_submit_Ljava_lang_Runnable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x0006C91C File Offset: 0x0006AB1C
		public unsafe IFuture Submit(IRunnable task, Java.Lang.Object result)
		{
			if (this.id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
			ptr[1] = new JValue(intPtr);
			IFuture @object = Java.Lang.Object.GetObject<IFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_submit_Ljava_lang_Runnable_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x0006C9BC File Offset: 0x0006ABBC
		public unsafe IFuture Submit(ICallable task)
		{
			if (this.id_submit_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
			{
				this.id_submit_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID(this.class_ref, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
			return Java.Lang.Object.GetObject<IFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_submit_Ljava_util_concurrent_Callable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x0006CA3C File Offset: 0x0006AC3C
		public unsafe void Execute(IRunnable command)
		{
			if (this.id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_execute_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "execute", "(Ljava/lang/Runnable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_execute_Ljava_lang_Runnable_, ptr);
		}

		// Token: 0x04000F92 RID: 3986
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/ScheduledExecutorService", typeof(IScheduledExecutorServiceInvoker));

		// Token: 0x04000F93 RID: 3987
		private IntPtr class_ref;

		// Token: 0x04000F94 RID: 3988
		private static Delegate cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F95 RID: 3989
		private IntPtr id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F96 RID: 3990
		private static Delegate cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F97 RID: 3991
		private IntPtr id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F98 RID: 3992
		private static Delegate cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F99 RID: 3993
		private IntPtr id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F9A RID: 3994
		private static Delegate cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F9B RID: 3995
		private IntPtr id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F9C RID: 3996
		private IntPtr id_isShutdown;

		// Token: 0x04000F9D RID: 3997
		private IntPtr id_isTerminated;

		// Token: 0x04000F9E RID: 3998
		private IntPtr id_awaitTermination_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F9F RID: 3999
		private IntPtr id_invokeAll_Ljava_util_Collection_;

		// Token: 0x04000FA0 RID: 4000
		private IntPtr id_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FA1 RID: 4001
		private IntPtr id_invokeAny_Ljava_util_Collection_;

		// Token: 0x04000FA2 RID: 4002
		private IntPtr id_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FA3 RID: 4003
		private IntPtr id_shutdown;

		// Token: 0x04000FA4 RID: 4004
		private IntPtr id_shutdownNow;

		// Token: 0x04000FA5 RID: 4005
		private IntPtr id_submit_Ljava_lang_Runnable_;

		// Token: 0x04000FA6 RID: 4006
		private IntPtr id_submit_Ljava_lang_Runnable_Ljava_lang_Object_;

		// Token: 0x04000FA7 RID: 4007
		private IntPtr id_submit_Ljava_util_concurrent_Callable_;

		// Token: 0x04000FA8 RID: 4008
		private IntPtr id_execute_Ljava_lang_Runnable_;
	}
}
