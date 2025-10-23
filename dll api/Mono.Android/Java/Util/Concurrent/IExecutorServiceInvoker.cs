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
	// Token: 0x02000352 RID: 850
	[Register("java/util/concurrent/ExecutorService", DoNotGenerateAcw = true)]
	internal class IExecutorServiceInvoker : Java.Lang.Object, IExecutorService, IExecutor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x0006B144 File Offset: 0x00069344
		private static IntPtr java_class_ref
		{
			get
			{
				return IExecutorServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0006B168 File Offset: 0x00069368
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExecutorServiceInvoker._members;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x0006B16F File Offset: 0x0006936F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0006B177 File Offset: 0x00069377
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExecutorServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0006B183 File Offset: 0x00069383
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExecutorServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.ExecutorService'.");
			}
			return handle;
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0006B1AE File Offset: 0x000693AE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0006B1E0 File Offset: 0x000693E0
		public IExecutorServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExecutorServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0006B218 File Offset: 0x00069418
		private static Delegate GetIsShutdownHandler()
		{
			if (IExecutorServiceInvoker.cb_isShutdown == null)
			{
				IExecutorServiceInvoker.cb_isShutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExecutorServiceInvoker.n_IsShutdown));
			}
			return IExecutorServiceInvoker.cb_isShutdown;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x0006B23C File Offset: 0x0006943C
		private static bool n_IsShutdown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsShutdown;
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0006B24B File Offset: 0x0006944B
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

		// Token: 0x0600256C RID: 9580 RVA: 0x0006B28B File Offset: 0x0006948B
		private static Delegate GetIsTerminatedHandler()
		{
			if (IExecutorServiceInvoker.cb_isTerminated == null)
			{
				IExecutorServiceInvoker.cb_isTerminated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExecutorServiceInvoker.n_IsTerminated));
			}
			return IExecutorServiceInvoker.cb_isTerminated;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x0006B2AF File Offset: 0x000694AF
		private static bool n_IsTerminated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTerminated;
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x0006B2BE File Offset: 0x000694BE
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

		// Token: 0x0600256F RID: 9583 RVA: 0x0006B2FE File Offset: 0x000694FE
		private static Delegate GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IExecutorServiceInvoker.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IExecutorServiceInvoker.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_Z(IExecutorServiceInvoker.n_AwaitTermination_JLjava_util_concurrent_TimeUnit_));
			}
			return IExecutorServiceInvoker.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x0006B324 File Offset: 0x00069524
		private static bool n_AwaitTermination_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.AwaitTermination(timeout, object2);
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x0006B348 File Offset: 0x00069548
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

		// Token: 0x06002572 RID: 9586 RVA: 0x0006B3CE File Offset: 0x000695CE
		private static Delegate GetInvokeAll_Ljava_util_Collection_Handler()
		{
			if (IExecutorServiceInvoker.cb_invokeAll_Ljava_util_Collection_ == null)
			{
				IExecutorServiceInvoker.cb_invokeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IExecutorServiceInvoker.n_InvokeAll_Ljava_util_Collection_));
			}
			return IExecutorServiceInvoker.cb_invokeAll_Ljava_util_Collection_;
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0006B3F4 File Offset: 0x000695F4
		private static IntPtr n_InvokeAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			return JavaList.ToLocalJniHandle(@object.InvokeAll(tasks));
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x0006B41C File Offset: 0x0006961C
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

		// Token: 0x06002575 RID: 9589 RVA: 0x0006B493 File Offset: 0x00069693
		private static Delegate GetInvokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IExecutorServiceInvoker.cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IExecutorServiceInvoker.cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_L(IExecutorServiceInvoker.n_InvokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_));
			}
			return IExecutorServiceInvoker.cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0006B4B8 File Offset: 0x000696B8
		private static IntPtr n_InvokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JavaList.ToLocalJniHandle(@object.InvokeAll(tasks, timeout, object2));
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x0006B4EC File Offset: 0x000696EC
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

		// Token: 0x06002578 RID: 9592 RVA: 0x0006B59B File Offset: 0x0006979B
		private static Delegate GetInvokeAny_Ljava_util_Collection_Handler()
		{
			if (IExecutorServiceInvoker.cb_invokeAny_Ljava_util_Collection_ == null)
			{
				IExecutorServiceInvoker.cb_invokeAny_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IExecutorServiceInvoker.n_InvokeAny_Ljava_util_Collection_));
			}
			return IExecutorServiceInvoker.cb_invokeAny_Ljava_util_Collection_;
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0006B5C0 File Offset: 0x000697C0
		private static IntPtr n_InvokeAny_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeAny(tasks));
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x0006B5E8 File Offset: 0x000697E8
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

		// Token: 0x0600257B RID: 9595 RVA: 0x0006B65F File Offset: 0x0006985F
		private static Delegate GetInvokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IExecutorServiceInvoker.cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IExecutorServiceInvoker.cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_L(IExecutorServiceInvoker.n_InvokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_));
			}
			return IExecutorServiceInvoker.cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0006B684 File Offset: 0x00069884
		private static IntPtr n_InvokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeAny(tasks, timeout, object2));
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x0006B6B8 File Offset: 0x000698B8
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

		// Token: 0x0600257E RID: 9598 RVA: 0x0006B767 File Offset: 0x00069967
		private static Delegate GetShutdownHandler()
		{
			if (IExecutorServiceInvoker.cb_shutdown == null)
			{
				IExecutorServiceInvoker.cb_shutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IExecutorServiceInvoker.n_Shutdown));
			}
			return IExecutorServiceInvoker.cb_shutdown;
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0006B78B File Offset: 0x0006998B
		private static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Shutdown();
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x0006B79A File Offset: 0x0006999A
		public void Shutdown()
		{
			if (this.id_shutdown == IntPtr.Zero)
			{
				this.id_shutdown = JNIEnv.GetMethodID(this.class_ref, "shutdown", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_shutdown);
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0006B7DA File Offset: 0x000699DA
		private static Delegate GetShutdownNowHandler()
		{
			if (IExecutorServiceInvoker.cb_shutdownNow == null)
			{
				IExecutorServiceInvoker.cb_shutdownNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExecutorServiceInvoker.n_ShutdownNow));
			}
			return IExecutorServiceInvoker.cb_shutdownNow;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0006B7FE File Offset: 0x000699FE
		private static IntPtr n_ShutdownNow(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IRunnable>.ToLocalJniHandle(Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShutdownNow());
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x0006B814 File Offset: 0x00069A14
		public IList<IRunnable> ShutdownNow()
		{
			if (this.id_shutdownNow == IntPtr.Zero)
			{
				this.id_shutdownNow = JNIEnv.GetMethodID(this.class_ref, "shutdownNow", "()Ljava/util/List;");
			}
			return JavaList<IRunnable>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_shutdownNow), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x0006B865 File Offset: 0x00069A65
		private static Delegate GetSubmit_Ljava_lang_Runnable_Handler()
		{
			if (IExecutorServiceInvoker.cb_submit_Ljava_lang_Runnable_ == null)
			{
				IExecutorServiceInvoker.cb_submit_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IExecutorServiceInvoker.n_Submit_Ljava_lang_Runnable_));
			}
			return IExecutorServiceInvoker.cb_submit_Ljava_lang_Runnable_;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0006B88C File Offset: 0x00069A8C
		private static IntPtr n_Submit_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Submit(object2));
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x0006B8B4 File Offset: 0x00069AB4
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

		// Token: 0x06002587 RID: 9607 RVA: 0x0006B932 File Offset: 0x00069B32
		private static Delegate GetSubmit_Ljava_lang_Runnable_Ljava_lang_Object_Handler()
		{
			if (IExecutorServiceInvoker.cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == null)
			{
				IExecutorServiceInvoker.cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IExecutorServiceInvoker.n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_));
			}
			return IExecutorServiceInvoker.cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x0006B958 File Offset: 0x00069B58
		private static IntPtr n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_task, IntPtr native_result)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Submit(object2, object3));
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x0006B98C File Offset: 0x00069B8C
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

		// Token: 0x0600258A RID: 9610 RVA: 0x0006BA2A File Offset: 0x00069C2A
		private static Delegate GetSubmit_Ljava_util_concurrent_Callable_Handler()
		{
			if (IExecutorServiceInvoker.cb_submit_Ljava_util_concurrent_Callable_ == null)
			{
				IExecutorServiceInvoker.cb_submit_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IExecutorServiceInvoker.n_Submit_Ljava_util_concurrent_Callable_));
			}
			return IExecutorServiceInvoker.cb_submit_Ljava_util_concurrent_Callable_;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x0006BA50 File Offset: 0x00069C50
		private static IntPtr n_Submit_Ljava_util_concurrent_Callable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			IExecutorService @object = Java.Lang.Object.GetObject<IExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICallable object2 = Java.Lang.Object.GetObject<ICallable>(native_task, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Submit(object2));
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x0006BA78 File Offset: 0x00069C78
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

		// Token: 0x0600258D RID: 9613 RVA: 0x0006BAF8 File Offset: 0x00069CF8
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

		// Token: 0x04000F6B RID: 3947
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/ExecutorService", typeof(IExecutorServiceInvoker));

		// Token: 0x04000F6C RID: 3948
		private IntPtr class_ref;

		// Token: 0x04000F6D RID: 3949
		private static Delegate cb_isShutdown;

		// Token: 0x04000F6E RID: 3950
		private IntPtr id_isShutdown;

		// Token: 0x04000F6F RID: 3951
		private static Delegate cb_isTerminated;

		// Token: 0x04000F70 RID: 3952
		private IntPtr id_isTerminated;

		// Token: 0x04000F71 RID: 3953
		private static Delegate cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F72 RID: 3954
		private IntPtr id_awaitTermination_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F73 RID: 3955
		private static Delegate cb_invokeAll_Ljava_util_Collection_;

		// Token: 0x04000F74 RID: 3956
		private IntPtr id_invokeAll_Ljava_util_Collection_;

		// Token: 0x04000F75 RID: 3957
		private static Delegate cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F76 RID: 3958
		private IntPtr id_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F77 RID: 3959
		private static Delegate cb_invokeAny_Ljava_util_Collection_;

		// Token: 0x04000F78 RID: 3960
		private IntPtr id_invokeAny_Ljava_util_Collection_;

		// Token: 0x04000F79 RID: 3961
		private static Delegate cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F7A RID: 3962
		private IntPtr id_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000F7B RID: 3963
		private static Delegate cb_shutdown;

		// Token: 0x04000F7C RID: 3964
		private IntPtr id_shutdown;

		// Token: 0x04000F7D RID: 3965
		private static Delegate cb_shutdownNow;

		// Token: 0x04000F7E RID: 3966
		private IntPtr id_shutdownNow;

		// Token: 0x04000F7F RID: 3967
		private static Delegate cb_submit_Ljava_lang_Runnable_;

		// Token: 0x04000F80 RID: 3968
		private IntPtr id_submit_Ljava_lang_Runnable_;

		// Token: 0x04000F81 RID: 3969
		private static Delegate cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;

		// Token: 0x04000F82 RID: 3970
		private IntPtr id_submit_Ljava_lang_Runnable_Ljava_lang_Object_;

		// Token: 0x04000F83 RID: 3971
		private static Delegate cb_submit_Ljava_util_concurrent_Callable_;

		// Token: 0x04000F84 RID: 3972
		private IntPtr id_submit_Ljava_util_concurrent_Callable_;

		// Token: 0x04000F85 RID: 3973
		private IntPtr id_execute_Ljava_lang_Runnable_;
	}
}
