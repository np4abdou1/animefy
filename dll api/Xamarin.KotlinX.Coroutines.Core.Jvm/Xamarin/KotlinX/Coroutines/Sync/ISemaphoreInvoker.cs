using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Sync
{
	// Token: 0x0200008C RID: 140
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/sync/Semaphore", DoNotGenerateAcw = true)]
	internal class ISemaphoreInvoker : Java.Lang.Object, ISemaphore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00014794 File Offset: 0x00012994
		private static IntPtr java_class_ref
		{
			get
			{
				return ISemaphoreInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x000147B8 File Offset: 0x000129B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISemaphoreInvoker._members;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000147BF File Offset: 0x000129BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x000147C7 File Offset: 0x000129C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISemaphoreInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000147D3 File Offset: 0x000129D3
		[NullableContext(2)]
		public static ISemaphore GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISemaphore>(handle, transfer);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000147DC File Offset: 0x000129DC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISemaphoreInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.sync.Semaphore'.");
			}
			return handle;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00014807 File Offset: 0x00012A07
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00014838 File Offset: 0x00012A38
		public ISemaphoreInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISemaphoreInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00014870 File Offset: 0x00012A70
		private static Delegate GetGetAvailablePermitsHandler()
		{
			if (ISemaphoreInvoker.cb_getAvailablePermits == null)
			{
				ISemaphoreInvoker.cb_getAvailablePermits = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISemaphoreInvoker.n_GetAvailablePermits));
			}
			return ISemaphoreInvoker.cb_getAvailablePermits;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00014894 File Offset: 0x00012A94
		private static int n_GetAvailablePermits(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISemaphore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AvailablePermits;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x000148A3 File Offset: 0x00012AA3
		public int AvailablePermits
		{
			get
			{
				if (this.id_getAvailablePermits == IntPtr.Zero)
				{
					this.id_getAvailablePermits = JNIEnv.GetMethodID(this.class_ref, "getAvailablePermits", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getAvailablePermits);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000148E3 File Offset: 0x00012AE3
		private static Delegate GetAcquire_Lkotlin_coroutines_Continuation_Handler()
		{
			if (ISemaphoreInvoker.cb_acquire_Lkotlin_coroutines_Continuation_ == null)
			{
				ISemaphoreInvoker.cb_acquire_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISemaphoreInvoker.n_Acquire_Lkotlin_coroutines_Continuation_));
			}
			return ISemaphoreInvoker.cb_acquire_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00014908 File Offset: 0x00012B08
		private static IntPtr n_Acquire_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISemaphore @object = Java.Lang.Object.GetObject<ISemaphore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Acquire(object2));
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00014930 File Offset: 0x00012B30
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Acquire(IContinuation p0)
		{
			if (this.id_acquire_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_acquire_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "acquire", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_acquire_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000149AE File Offset: 0x00012BAE
		private static Delegate GetReleaseHandler()
		{
			if (ISemaphoreInvoker.cb_release == null)
			{
				ISemaphoreInvoker.cb_release = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ISemaphoreInvoker.n_Release));
			}
			return ISemaphoreInvoker.cb_release;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000149D2 File Offset: 0x00012BD2
		private static void n_Release(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ISemaphore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Release();
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000149E1 File Offset: 0x00012BE1
		public void Release()
		{
			if (this.id_release == IntPtr.Zero)
			{
				this.id_release = JNIEnv.GetMethodID(this.class_ref, "release", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_release);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00014A21 File Offset: 0x00012C21
		private static Delegate GetTryAcquireHandler()
		{
			if (ISemaphoreInvoker.cb_tryAcquire == null)
			{
				ISemaphoreInvoker.cb_tryAcquire = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISemaphoreInvoker.n_TryAcquire));
			}
			return ISemaphoreInvoker.cb_tryAcquire;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00014A45 File Offset: 0x00012C45
		private static bool n_TryAcquire(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISemaphore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TryAcquire();
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00014A54 File Offset: 0x00012C54
		public bool TryAcquire()
		{
			if (this.id_tryAcquire == IntPtr.Zero)
			{
				this.id_tryAcquire = JNIEnv.GetMethodID(this.class_ref, "tryAcquire", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_tryAcquire);
		}

		// Token: 0x04000220 RID: 544
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/sync/Semaphore", typeof(ISemaphoreInvoker));

		// Token: 0x04000221 RID: 545
		private IntPtr class_ref;

		// Token: 0x04000222 RID: 546
		[Nullable(2)]
		private static Delegate cb_getAvailablePermits;

		// Token: 0x04000223 RID: 547
		private IntPtr id_getAvailablePermits;

		// Token: 0x04000224 RID: 548
		[Nullable(2)]
		private static Delegate cb_acquire_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000225 RID: 549
		private IntPtr id_acquire_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000226 RID: 550
		[Nullable(2)]
		private static Delegate cb_release;

		// Token: 0x04000227 RID: 551
		private IntPtr id_release;

		// Token: 0x04000228 RID: 552
		[Nullable(2)]
		private static Delegate cb_tryAcquire;

		// Token: 0x04000229 RID: 553
		private IntPtr id_tryAcquire;
	}
}
