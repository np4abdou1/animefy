using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x0200034E RID: 846
	[Register("java/util/concurrent/Delayed", DoNotGenerateAcw = true)]
	internal class IDelayedInvoker : Java.Lang.Object, IDelayed, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x0006AD78 File Offset: 0x00068F78
		private static IntPtr java_class_ref
		{
			get
			{
				return IDelayedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x0006AD9C File Offset: 0x00068F9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDelayedInvoker._members;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x0006ADA3 File Offset: 0x00068FA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x0006ADAB File Offset: 0x00068FAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDelayedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x0006ADB7 File Offset: 0x00068FB7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDelayedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.Delayed'.");
			}
			return handle;
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x0006ADE2 File Offset: 0x00068FE2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x0006AE14 File Offset: 0x00069014
		public IDelayedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDelayedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x0006AE4C File Offset: 0x0006904C
		private static Delegate GetGetDelay_Ljava_util_concurrent_TimeUnit_Handler()
		{
			if (IDelayedInvoker.cb_getDelay_Ljava_util_concurrent_TimeUnit_ == null)
			{
				IDelayedInvoker.cb_getDelay_Ljava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(IDelayedInvoker.n_GetDelay_Ljava_util_concurrent_TimeUnit_));
			}
			return IDelayedInvoker.cb_getDelay_Ljava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x0006AE70 File Offset: 0x00069070
		private static long n_GetDelay_Ljava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_unit)
		{
			IDelayed @object = Java.Lang.Object.GetObject<IDelayed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.GetDelay(object2);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x0006AE94 File Offset: 0x00069094
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

		// Token: 0x06002548 RID: 9544 RVA: 0x0006AF08 File Offset: 0x00069108
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

		// Token: 0x04000F62 RID: 3938
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/Delayed", typeof(IDelayedInvoker));

		// Token: 0x04000F63 RID: 3939
		private IntPtr class_ref;

		// Token: 0x04000F64 RID: 3940
		private static Delegate cb_getDelay_Ljava_util_concurrent_TimeUnit_;

		// Token: 0x04000F65 RID: 3941
		private IntPtr id_getDelay_Ljava_util_concurrent_TimeUnit_;

		// Token: 0x04000F66 RID: 3942
		private IntPtr id_compareTo_Ljava_lang_Object_;
	}
}
