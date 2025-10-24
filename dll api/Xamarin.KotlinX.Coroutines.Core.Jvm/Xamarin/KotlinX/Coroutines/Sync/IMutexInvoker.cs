using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Sync
{
	// Token: 0x0200008A RID: 138
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/sync/Mutex", DoNotGenerateAcw = true)]
	internal class IMutexInvoker : Java.Lang.Object, IMutex, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00014270 File Offset: 0x00012470
		private static IntPtr java_class_ref
		{
			get
			{
				return IMutexInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00014294 File Offset: 0x00012494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMutexInvoker._members;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001429B File Offset: 0x0001249B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x000142A3 File Offset: 0x000124A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMutexInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000142AF File Offset: 0x000124AF
		[NullableContext(2)]
		public static IMutex GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMutex>(handle, transfer);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000142B8 File Offset: 0x000124B8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMutexInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.sync.Mutex'.");
			}
			return handle;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000142E3 File Offset: 0x000124E3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00014314 File Offset: 0x00012514
		public IMutexInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMutexInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001434C File Offset: 0x0001254C
		private static Delegate GetIsLockedHandler()
		{
			if (IMutexInvoker.cb_isLocked == null)
			{
				IMutexInvoker.cb_isLocked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMutexInvoker.n_IsLocked));
			}
			return IMutexInvoker.cb_isLocked;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00014370 File Offset: 0x00012570
		private static bool n_IsLocked(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMutex>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLocked;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001437F File Offset: 0x0001257F
		public bool IsLocked
		{
			get
			{
				if (this.id_isLocked == IntPtr.Zero)
				{
					this.id_isLocked = JNIEnv.GetMethodID(this.class_ref, "isLocked", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isLocked);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000143BF File Offset: 0x000125BF
		[Obsolete]
		private static Delegate GetGetOnLockHandler()
		{
			if (IMutexInvoker.cb_getOnLock == null)
			{
				IMutexInvoker.cb_getOnLock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMutexInvoker.n_GetOnLock));
			}
			return IMutexInvoker.cb_getOnLock;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000143E3 File Offset: 0x000125E3
		[Obsolete]
		private static IntPtr n_GetOnLock(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMutex>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLock);
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x000143F8 File Offset: 0x000125F8
		public ISelectClause2 OnLock
		{
			get
			{
				if (this.id_getOnLock == IntPtr.Zero)
				{
					this.id_getOnLock = JNIEnv.GetMethodID(this.class_ref, "getOnLock", "()Lkotlinx/coroutines/selects/SelectClause2;");
				}
				return Java.Lang.Object.GetObject<ISelectClause2>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnLock), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00014449 File Offset: 0x00012649
		private static Delegate GetHoldsLock_Ljava_lang_Object_Handler()
		{
			if (IMutexInvoker.cb_holdsLock_Ljava_lang_Object_ == null)
			{
				IMutexInvoker.cb_holdsLock_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMutexInvoker.n_HoldsLock_Ljava_lang_Object_));
			}
			return IMutexInvoker.cb_holdsLock_Ljava_lang_Object_;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00014470 File Offset: 0x00012670
		private static bool n_HoldsLock_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_owner)
		{
			IMutex @object = Java.Lang.Object.GetObject<IMutex>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_owner, JniHandleOwnership.DoNotTransfer);
			return @object.HoldsLock(object2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00014494 File Offset: 0x00012694
		public unsafe bool HoldsLock(Java.Lang.Object owner)
		{
			if (this.id_holdsLock_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_holdsLock_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "holdsLock", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((owner == null) ? IntPtr.Zero : owner.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_holdsLock_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00014507 File Offset: 0x00012707
		private static Delegate GetLock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IMutexInvoker.cb_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				IMutexInvoker.cb_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMutexInvoker.n_Lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return IMutexInvoker.cb_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001452C File Offset: 0x0001272C
		private static IntPtr n_Lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_owner, IntPtr native_p1)
		{
			IMutex @object = Java.Lang.Object.GetObject<IMutex>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_owner, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Lock(object2, object3));
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00014560 File Offset: 0x00012760
		[NullableContext(2)]
		public unsafe Java.Lang.Object Lock(Java.Lang.Object owner, [Nullable(1)] IContinuation p1)
		{
			if (this.id_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "lock", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((owner == null) ? IntPtr.Zero : owner.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00014600 File Offset: 0x00012800
		private static Delegate GetTryLock_Ljava_lang_Object_Handler()
		{
			if (IMutexInvoker.cb_tryLock_Ljava_lang_Object_ == null)
			{
				IMutexInvoker.cb_tryLock_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMutexInvoker.n_TryLock_Ljava_lang_Object_));
			}
			return IMutexInvoker.cb_tryLock_Ljava_lang_Object_;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00014624 File Offset: 0x00012824
		private static bool n_TryLock_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_owner)
		{
			IMutex @object = Java.Lang.Object.GetObject<IMutex>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_owner, JniHandleOwnership.DoNotTransfer);
			return @object.TryLock(object2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00014648 File Offset: 0x00012848
		[NullableContext(2)]
		public unsafe bool TryLock(Java.Lang.Object owner)
		{
			if (this.id_tryLock_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_tryLock_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "tryLock", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((owner == null) ? IntPtr.Zero : owner.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_tryLock_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000146BB File Offset: 0x000128BB
		private static Delegate GetUnlock_Ljava_lang_Object_Handler()
		{
			if (IMutexInvoker.cb_unlock_Ljava_lang_Object_ == null)
			{
				IMutexInvoker.cb_unlock_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMutexInvoker.n_Unlock_Ljava_lang_Object_));
			}
			return IMutexInvoker.cb_unlock_Ljava_lang_Object_;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000146E0 File Offset: 0x000128E0
		private static void n_Unlock_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_owner)
		{
			IMutex @object = Java.Lang.Object.GetObject<IMutex>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_owner, JniHandleOwnership.DoNotTransfer);
			@object.Unlock(object2);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00014704 File Offset: 0x00012904
		[NullableContext(2)]
		public unsafe void Unlock(Java.Lang.Object owner)
		{
			if (this.id_unlock_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_unlock_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "unlock", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((owner == null) ? IntPtr.Zero : owner.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_unlock_Ljava_lang_Object_, ptr);
		}

		// Token: 0x04000212 RID: 530
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/sync/Mutex", typeof(IMutexInvoker));

		// Token: 0x04000213 RID: 531
		private IntPtr class_ref;

		// Token: 0x04000214 RID: 532
		[Nullable(2)]
		private static Delegate cb_isLocked;

		// Token: 0x04000215 RID: 533
		private IntPtr id_isLocked;

		// Token: 0x04000216 RID: 534
		[Nullable(2)]
		private static Delegate cb_getOnLock;

		// Token: 0x04000217 RID: 535
		private IntPtr id_getOnLock;

		// Token: 0x04000218 RID: 536
		[Nullable(2)]
		private static Delegate cb_holdsLock_Ljava_lang_Object_;

		// Token: 0x04000219 RID: 537
		private IntPtr id_holdsLock_Ljava_lang_Object_;

		// Token: 0x0400021A RID: 538
		[Nullable(2)]
		private static Delegate cb_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400021B RID: 539
		private IntPtr id_lock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400021C RID: 540
		[Nullable(2)]
		private static Delegate cb_tryLock_Ljava_lang_Object_;

		// Token: 0x0400021D RID: 541
		private IntPtr id_tryLock_Ljava_lang_Object_;

		// Token: 0x0400021E RID: 542
		[Nullable(2)]
		private static Delegate cb_unlock_Ljava_lang_Object_;

		// Token: 0x0400021F RID: 543
		private IntPtr id_unlock_Ljava_lang_Object_;
	}
}
