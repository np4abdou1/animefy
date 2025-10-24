using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000358 RID: 856
	[Register("java/util/concurrent/ScheduledFuture", DoNotGenerateAcw = true)]
	internal class IScheduledFutureInvoker : Java.Lang.Object, IScheduledFuture, IDelayed, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable, IFuture
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x0006CAD0 File Offset: 0x0006ACD0
		private static IntPtr java_class_ref
		{
			get
			{
				return IScheduledFutureInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x0006CAF4 File Offset: 0x0006ACF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScheduledFutureInvoker._members;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0006CAFB File Offset: 0x0006ACFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x0006CB03 File Offset: 0x0006AD03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScheduledFutureInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x0006CB0F File Offset: 0x0006AD0F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScheduledFutureInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.ScheduledFuture'.");
			}
			return handle;
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x0006CB3A File Offset: 0x0006AD3A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x0006CB6C File Offset: 0x0006AD6C
		public IScheduledFutureInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScheduledFutureInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x0006CBA4 File Offset: 0x0006ADA4
		public unsafe long GetDelay(TimeUnit unit)
		{
			if (this.id_getDelay_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_getDelay_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return JNIEnv.CallLongMethod(base.Handle, this.id_getDelay_Ljava_util_concurrent_TimeUnit_, ptr);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x0006CC18 File Offset: 0x0006AE18
		public unsafe int CompareTo(Java.Lang.Object o)
		{
			if (this.id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "compareTo", "(Ljava/lang/Object;)I");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(o);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_compareTo_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x0006CC89 File Offset: 0x0006AE89
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x0006CCC9 File Offset: 0x0006AEC9
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

		// Token: 0x060025DB RID: 9691 RVA: 0x0006CD0C File Offset: 0x0006AF0C
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

		// Token: 0x060025DC RID: 9692 RVA: 0x0006CD70 File Offset: 0x0006AF70
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x0006CDC4 File Offset: 0x0006AFC4
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

		// Token: 0x04000FA9 RID: 4009
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/ScheduledFuture", typeof(IScheduledFutureInvoker));

		// Token: 0x04000FAA RID: 4010
		private IntPtr class_ref;

		// Token: 0x04000FAB RID: 4011
		private IntPtr id_getDelay_Ljava_util_concurrent_TimeUnit_;

		// Token: 0x04000FAC RID: 4012
		private IntPtr id_compareTo_Ljava_lang_Object_;

		// Token: 0x04000FAD RID: 4013
		private IntPtr id_isCancelled;

		// Token: 0x04000FAE RID: 4014
		private IntPtr id_isDone;

		// Token: 0x04000FAF RID: 4015
		private IntPtr id_cancel_Z;

		// Token: 0x04000FB0 RID: 4016
		private IntPtr id_get;

		// Token: 0x04000FB1 RID: 4017
		private IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
	}
}
