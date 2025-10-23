using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000046 RID: 70
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletableDeferred", DoNotGenerateAcw = true)]
	internal class ICompletableDeferredInvoker : Java.Lang.Object, ICompletableDeferred, IDeferred, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00007B74 File Offset: 0x00005D74
		private static IntPtr java_class_ref
		{
			get
			{
				return ICompletableDeferredInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00007B98 File Offset: 0x00005D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICompletableDeferredInvoker._members;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00007B9F File Offset: 0x00005D9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00007BA7 File Offset: 0x00005DA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICompletableDeferredInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00007BB3 File Offset: 0x00005DB3
		[NullableContext(2)]
		public static ICompletableDeferred GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICompletableDeferred>(handle, transfer);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00007BBC File Offset: 0x00005DBC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICompletableDeferredInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.CompletableDeferred'.");
			}
			return handle;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00007BE7 File Offset: 0x00005DE7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00007C18 File Offset: 0x00005E18
		public ICompletableDeferredInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICompletableDeferredInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007C50 File Offset: 0x00005E50
		private static Delegate GetComplete_Ljava_lang_Object_Handler()
		{
			if (ICompletableDeferredInvoker.cb_complete_Ljava_lang_Object_ == null)
			{
				ICompletableDeferredInvoker.cb_complete_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICompletableDeferredInvoker.n_Complete_Ljava_lang_Object_));
			}
			return ICompletableDeferredInvoker.cb_complete_Ljava_lang_Object_;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00007C74 File Offset: 0x00005E74
		private static bool n_Complete_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			ICompletableDeferred @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Complete(object2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00007C98 File Offset: 0x00005E98
		[NullableContext(2)]
		public unsafe bool Complete(Java.Lang.Object value)
		{
			if (this.id_complete_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_complete_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "complete", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_complete_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00007D09 File Offset: 0x00005F09
		private static Delegate GetCompleteExceptionally_Ljava_lang_Throwable_Handler()
		{
			if (ICompletableDeferredInvoker.cb_completeExceptionally_Ljava_lang_Throwable_ == null)
			{
				ICompletableDeferredInvoker.cb_completeExceptionally_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICompletableDeferredInvoker.n_CompleteExceptionally_Ljava_lang_Throwable_));
			}
			return ICompletableDeferredInvoker.cb_completeExceptionally_Ljava_lang_Throwable_;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00007D30 File Offset: 0x00005F30
		private static bool n_CompleteExceptionally_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			ICompletableDeferred @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_exception, JniHandleOwnership.DoNotTransfer);
			return @object.CompleteExceptionally(object2);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00007D54 File Offset: 0x00005F54
		public unsafe bool CompleteExceptionally(Throwable exception)
		{
			if (this.id_completeExceptionally_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_completeExceptionally_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "completeExceptionally", "(Ljava/lang/Throwable;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((exception == null) ? IntPtr.Zero : exception.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_completeExceptionally_Ljava_lang_Throwable_, ptr);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00007DC7 File Offset: 0x00005FC7
		private static Delegate GetGetCompletedHandler()
		{
			if (ICompletableDeferredInvoker.cb_getCompleted == null)
			{
				ICompletableDeferredInvoker.cb_getCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetCompleted));
			}
			return ICompletableDeferredInvoker.cb_getCompleted;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00007DEB File Offset: 0x00005FEB
		private static IntPtr n_GetCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Completed);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007E00 File Offset: 0x00006000
		[Nullable(2)]
		public Java.Lang.Object Completed
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getCompleted == IntPtr.Zero)
				{
					this.id_getCompleted = JNIEnv.GetMethodID(this.class_ref, "getCompleted", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCompleted), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00007E51 File Offset: 0x00006051
		private static Delegate GetGetCompletionExceptionOrNullHandler()
		{
			if (ICompletableDeferredInvoker.cb_getCompletionExceptionOrNull == null)
			{
				ICompletableDeferredInvoker.cb_getCompletionExceptionOrNull = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetCompletionExceptionOrNull));
			}
			return ICompletableDeferredInvoker.cb_getCompletionExceptionOrNull;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00007E75 File Offset: 0x00006075
		private static IntPtr n_GetCompletionExceptionOrNull(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompletionExceptionOrNull);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00007E8C File Offset: 0x0000608C
		[Nullable(2)]
		public Throwable CompletionExceptionOrNull
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getCompletionExceptionOrNull == IntPtr.Zero)
				{
					this.id_getCompletionExceptionOrNull = JNIEnv.GetMethodID(this.class_ref, "getCompletionExceptionOrNull", "()Ljava/lang/Throwable;");
				}
				return Java.Lang.Object.GetObject<Throwable>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCompletionExceptionOrNull), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00007EDD File Offset: 0x000060DD
		private static Delegate GetGetOnAwaitHandler()
		{
			if (ICompletableDeferredInvoker.cb_getOnAwait == null)
			{
				ICompletableDeferredInvoker.cb_getOnAwait = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetOnAwait));
			}
			return ICompletableDeferredInvoker.cb_getOnAwait;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00007F01 File Offset: 0x00006101
		private static IntPtr n_GetOnAwait(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAwait);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00007F18 File Offset: 0x00006118
		public ISelectClause1 OnAwait
		{
			get
			{
				if (this.id_getOnAwait == IntPtr.Zero)
				{
					this.id_getOnAwait = JNIEnv.GetMethodID(this.class_ref, "getOnAwait", "()Lkotlinx/coroutines/selects/SelectClause1;");
				}
				return Java.Lang.Object.GetObject<ISelectClause1>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnAwait), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007F69 File Offset: 0x00006169
		private static Delegate GetAwait_Lkotlin_coroutines_Continuation_Handler()
		{
			if (ICompletableDeferredInvoker.cb_await_Lkotlin_coroutines_Continuation_ == null)
			{
				ICompletableDeferredInvoker.cb_await_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_Await_Lkotlin_coroutines_Continuation_));
			}
			return ICompletableDeferredInvoker.cb_await_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00007F90 File Offset: 0x00006190
		private static IntPtr n_Await_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDeferred @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Await(object2));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00007FB8 File Offset: 0x000061B8
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Await(IContinuation p0)
		{
			if (this.id_await_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_await_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "await", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_await_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00008036 File Offset: 0x00006236
		private static Delegate GetGetCancellationExceptionHandler()
		{
			if (ICompletableDeferredInvoker.cb_getCancellationException == null)
			{
				ICompletableDeferredInvoker.cb_getCancellationException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetCancellationException));
			}
			return ICompletableDeferredInvoker.cb_getCancellationException;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000805A File Offset: 0x0000625A
		private static IntPtr n_GetCancellationException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancellationException);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00008070 File Offset: 0x00006270
		public CancellationException CancellationException
		{
			get
			{
				if (this.id_getCancellationException == IntPtr.Zero)
				{
					this.id_getCancellationException = JNIEnv.GetMethodID(this.class_ref, "getCancellationException", "()Ljava/util/concurrent/CancellationException;");
				}
				return Java.Lang.Object.GetObject<CancellationException>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCancellationException), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000080C1 File Offset: 0x000062C1
		private static Delegate GetGetChildrenHandler()
		{
			if (ICompletableDeferredInvoker.cb_getChildren == null)
			{
				ICompletableDeferredInvoker.cb_getChildren = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetChildren));
			}
			return ICompletableDeferredInvoker.cb_getChildren;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000080E5 File Offset: 0x000062E5
		private static IntPtr n_GetChildren(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Children);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000080FC File Offset: 0x000062FC
		public ISequence Children
		{
			get
			{
				if (this.id_getChildren == IntPtr.Zero)
				{
					this.id_getChildren = JNIEnv.GetMethodID(this.class_ref, "getChildren", "()Lkotlin/sequences/Sequence;");
				}
				return Java.Lang.Object.GetObject<ISequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getChildren), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000814D File Offset: 0x0000634D
		private static Delegate GetIsActiveHandler()
		{
			if (ICompletableDeferredInvoker.cb_isActive == null)
			{
				ICompletableDeferredInvoker.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableDeferredInvoker.n_IsActive));
			}
			return ICompletableDeferredInvoker.cb_isActive;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00008171 File Offset: 0x00006371
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00008180 File Offset: 0x00006380
		public bool IsActive
		{
			get
			{
				if (this.id_isActive == IntPtr.Zero)
				{
					this.id_isActive = JNIEnv.GetMethodID(this.class_ref, "isActive", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isActive);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000081C0 File Offset: 0x000063C0
		private static Delegate GetIsCancelledHandler()
		{
			if (ICompletableDeferredInvoker.cb_isCancelled == null)
			{
				ICompletableDeferredInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableDeferredInvoker.n_IsCancelled));
			}
			return ICompletableDeferredInvoker.cb_isCancelled;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000081E4 File Offset: 0x000063E4
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000081F3 File Offset: 0x000063F3
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

		// Token: 0x06000251 RID: 593 RVA: 0x00008233 File Offset: 0x00006433
		private static Delegate GetIsCompletedHandler()
		{
			if (ICompletableDeferredInvoker.cb_isCompleted == null)
			{
				ICompletableDeferredInvoker.cb_isCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableDeferredInvoker.n_IsCompleted));
			}
			return ICompletableDeferredInvoker.cb_isCompleted;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00008257 File Offset: 0x00006457
		private static bool n_IsCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompleted;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00008266 File Offset: 0x00006466
		public bool IsCompleted
		{
			get
			{
				if (this.id_isCompleted == IntPtr.Zero)
				{
					this.id_isCompleted = JNIEnv.GetMethodID(this.class_ref, "isCompleted", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCompleted);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000082A6 File Offset: 0x000064A6
		private static Delegate GetGetOnJoinHandler()
		{
			if (ICompletableDeferredInvoker.cb_getOnJoin == null)
			{
				ICompletableDeferredInvoker.cb_getOnJoin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetOnJoin));
			}
			return ICompletableDeferredInvoker.cb_getOnJoin;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000082CA File Offset: 0x000064CA
		private static IntPtr n_GetOnJoin(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnJoin);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000082E0 File Offset: 0x000064E0
		public ISelectClause0 OnJoin
		{
			get
			{
				if (this.id_getOnJoin == IntPtr.Zero)
				{
					this.id_getOnJoin = JNIEnv.GetMethodID(this.class_ref, "getOnJoin", "()Lkotlinx/coroutines/selects/SelectClause0;");
				}
				return Java.Lang.Object.GetObject<ISelectClause0>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnJoin), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00008331 File Offset: 0x00006531
		private static Delegate GetGetParentHandler()
		{
			if (ICompletableDeferredInvoker.cb_getParent == null)
			{
				ICompletableDeferredInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetParent));
			}
			return ICompletableDeferredInvoker.cb_getParent;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00008355 File Offset: 0x00006555
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000836C File Offset: 0x0000656C
		[Nullable(2)]
		public IJob Parent
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getParent == IntPtr.Zero)
				{
					this.id_getParent = JNIEnv.GetMethodID(this.class_ref, "getParent", "()Lkotlinx/coroutines/Job;");
				}
				return Java.Lang.Object.GetObject<IJob>(JNIEnv.CallObjectMethod(base.Handle, this.id_getParent), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000083BD File Offset: 0x000065BD
		private static Delegate GetAttachChild_Lkotlinx_coroutines_ChildJob_Handler()
		{
			if (ICompletableDeferredInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ == null)
			{
				ICompletableDeferredInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_AttachChild_Lkotlinx_coroutines_ChildJob_));
			}
			return ICompletableDeferredInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000083E4 File Offset: 0x000065E4
		private static IntPtr n_AttachChild_Lkotlinx_coroutines_ChildJob_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IChildJob object2 = Java.Lang.Object.GetObject<IChildJob>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AttachChild(object2));
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000840C File Offset: 0x0000660C
		public unsafe IChildHandle AttachChild(IChildJob child)
		{
			if (this.id_attachChild_Lkotlinx_coroutines_ChildJob_ == IntPtr.Zero)
			{
				this.id_attachChild_Lkotlinx_coroutines_ChildJob_ = JNIEnv.GetMethodID(this.class_ref, "attachChild", "(Lkotlinx/coroutines/ChildJob;)Lkotlinx/coroutines/ChildHandle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : ((Java.Lang.Object)child).Handle);
			return Java.Lang.Object.GetObject<IChildHandle>(JNIEnv.CallObjectMethod(base.Handle, this.id_attachChild_Lkotlinx_coroutines_ChildJob_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000848A File Offset: 0x0000668A
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (ICompletableDeferredInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				ICompletableDeferredInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICompletableDeferredInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return ICompletableDeferredInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000084B0 File Offset: 0x000066B0
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000084D4 File Offset: 0x000066D4
		[NullableContext(2)]
		public unsafe void Cancel(CancellationException cause)
		{
			if (this.id_cancel_Ljava_util_concurrent_CancellationException_ == IntPtr.Zero)
			{
				this.id_cancel_Ljava_util_concurrent_CancellationException_ = JNIEnv.GetMethodID(this.class_ref, "cancel", "(Ljava/util/concurrent/CancellationException;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((cause == null) ? IntPtr.Zero : cause.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_cancel_Ljava_util_concurrent_CancellationException_, ptr);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00008547 File Offset: 0x00006747
		private static Delegate GetInvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_Handler()
		{
			if (ICompletableDeferredInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == null)
			{
				ICompletableDeferredInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZZL_L(ICompletableDeferredInvoker.n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_));
			}
			return ICompletableDeferredInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000856C File Offset: 0x0000676C
		private static IntPtr n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, bool onCancelling, bool invokeImmediately, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(onCancelling, invokeImmediately, object2));
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00008598 File Offset: 0x00006798
		public unsafe IDisposableHandle InvokeOnCompletion(bool onCancelling, bool invokeImmediately, IFunction1 handler)
		{
			if (this.id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "invokeOnCompletion", "(ZZLkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(onCancelling);
			ptr[1] = new JValue(invokeImmediately);
			ptr[2] = new JValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
			return Java.Lang.Object.GetObject<IDisposableHandle>(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000863F File Offset: 0x0000683F
		private static Delegate GetInvokeOnCompletion_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (ICompletableDeferredInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == null)
			{
				ICompletableDeferredInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_));
			}
			return ICompletableDeferredInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00008664 File Offset: 0x00006864
		private static IntPtr n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(object2));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000868C File Offset: 0x0000688C
		public unsafe IDisposableHandle InvokeOnCompletion(IFunction1 handler)
		{
			if (this.id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "invokeOnCompletion", "(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
			return Java.Lang.Object.GetObject<IDisposableHandle>(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000870A File Offset: 0x0000690A
		private static Delegate GetJoin_Lkotlin_coroutines_Continuation_Handler()
		{
			if (ICompletableDeferredInvoker.cb_join_Lkotlin_coroutines_Continuation_ == null)
			{
				ICompletableDeferredInvoker.cb_join_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_Join_Lkotlin_coroutines_Continuation_));
			}
			return ICompletableDeferredInvoker.cb_join_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00008730 File Offset: 0x00006930
		private static IntPtr n_Join_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Join(object2));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00008758 File Offset: 0x00006958
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Join(IContinuation p0)
		{
			if (this.id_join_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_join_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "join", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_join_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000087D6 File Offset: 0x000069D6
		[Obsolete]
		private static Delegate GetPlus_Lkotlinx_coroutines_Job_Handler()
		{
			if (ICompletableDeferredInvoker.cb_plus_Lkotlinx_coroutines_Job_ == null)
			{
				ICompletableDeferredInvoker.cb_plus_Lkotlinx_coroutines_Job_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_Plus_Lkotlinx_coroutines_Job_));
			}
			return ICompletableDeferredInvoker.cb_plus_Lkotlinx_coroutines_Job_;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000087FC File Offset: 0x000069FC
		[Obsolete]
		private static IntPtr n_Plus_Lkotlinx_coroutines_Job_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IJob object2 = Java.Lang.Object.GetObject<IJob>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00008824 File Offset: 0x00006A24
		public unsafe IJob Plus(IJob other)
		{
			if (this.id_plus_Lkotlinx_coroutines_Job_ == IntPtr.Zero)
			{
				this.id_plus_Lkotlinx_coroutines_Job_ = JNIEnv.GetMethodID(this.class_ref, "plus", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return Java.Lang.Object.GetObject<IJob>(JNIEnv.CallObjectMethod(base.Handle, this.id_plus_Lkotlinx_coroutines_Job_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000088A2 File Offset: 0x00006AA2
		private static Delegate GetStartHandler()
		{
			if (ICompletableDeferredInvoker.cb_start == null)
			{
				ICompletableDeferredInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableDeferredInvoker.n_Start));
			}
			return ICompletableDeferredInvoker.cb_start;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000088C6 File Offset: 0x00006AC6
		private static bool n_Start(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000088D5 File Offset: 0x00006AD5
		public bool Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_start);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00008915 File Offset: 0x00006B15
		private static Delegate GetGetKeyHandler()
		{
			if (ICompletableDeferredInvoker.cb_getKey == null)
			{
				ICompletableDeferredInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableDeferredInvoker.n_GetKey));
			}
			return ICompletableDeferredInvoker.cb_getKey;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00008939 File Offset: 0x00006B39
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00008950 File Offset: 0x00006B50
		public ICoroutineContextKey Key
		{
			get
			{
				if (this.id_getKey == IntPtr.Zero)
				{
					this.id_getKey = JNIEnv.GetMethodID(this.class_ref, "getKey", "()Lkotlin/coroutines/CoroutineContext$Key;");
				}
				return Java.Lang.Object.GetObject<ICoroutineContextKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_getKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000089A1 File Offset: 0x00006BA1
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ICompletableDeferredInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				ICompletableDeferredInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletableDeferredInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return ICompletableDeferredInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000089C8 File Offset: 0x00006BC8
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000089FC File Offset: 0x00006BFC
		[NullableContext(2)]
		public unsafe Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation)
		{
			if (this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((initial == null) ? IntPtr.Zero : initial.Handle);
			ptr[1] = new JValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00008A9C File Offset: 0x00006C9C
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICompletableDeferredInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICompletableDeferredInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICompletableDeferredInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00008AC0 File Offset: 0x00006CC0
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00008AE8 File Offset: 0x00006CE8
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Get(ICoroutineContextKey key)
		{
			if (this.id_get_Lkotlin_coroutines_CoroutineContext_Key_ == IntPtr.Zero)
			{
				this.id_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Lkotlin_coroutines_CoroutineContext_Key_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00008B66 File Offset: 0x00006D66
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICompletableDeferredInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICompletableDeferredInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICompletableDeferredInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00008B8C File Offset: 0x00006D8C
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00008BB4 File Offset: 0x00006DB4
		public unsafe ICoroutineContext MinusKey(ICoroutineContextKey key)
		{
			if (this.id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == IntPtr.Zero)
			{
				this.id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNIEnv.GetMethodID(this.class_ref, "minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
			return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00008C32 File Offset: 0x00006E32
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (ICompletableDeferredInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				ICompletableDeferredInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableDeferredInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return ICompletableDeferredInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00008C58 File Offset: 0x00006E58
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICompletableDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008C80 File Offset: 0x00006E80
		public unsafe ICoroutineContext Plus(ICoroutineContext context)
		{
			if (this.id_plus_Lkotlin_coroutines_CoroutineContext_ == IntPtr.Zero)
			{
				this.id_plus_Lkotlin_coroutines_CoroutineContext_ = JNIEnv.GetMethodID(this.class_ref, "plus", "(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
			return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_plus_Lkotlin_coroutines_CoroutineContext_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000087 RID: 135
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletableDeferred", typeof(ICompletableDeferredInvoker));

		// Token: 0x04000088 RID: 136
		private IntPtr class_ref;

		// Token: 0x04000089 RID: 137
		[Nullable(2)]
		private static Delegate cb_complete_Ljava_lang_Object_;

		// Token: 0x0400008A RID: 138
		private IntPtr id_complete_Ljava_lang_Object_;

		// Token: 0x0400008B RID: 139
		[Nullable(2)]
		private static Delegate cb_completeExceptionally_Ljava_lang_Throwable_;

		// Token: 0x0400008C RID: 140
		private IntPtr id_completeExceptionally_Ljava_lang_Throwable_;

		// Token: 0x0400008D RID: 141
		[Nullable(2)]
		private static Delegate cb_getCompleted;

		// Token: 0x0400008E RID: 142
		private IntPtr id_getCompleted;

		// Token: 0x0400008F RID: 143
		[Nullable(2)]
		private static Delegate cb_getCompletionExceptionOrNull;

		// Token: 0x04000090 RID: 144
		private IntPtr id_getCompletionExceptionOrNull;

		// Token: 0x04000091 RID: 145
		[Nullable(2)]
		private static Delegate cb_getOnAwait;

		// Token: 0x04000092 RID: 146
		private IntPtr id_getOnAwait;

		// Token: 0x04000093 RID: 147
		[Nullable(2)]
		private static Delegate cb_await_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000094 RID: 148
		private IntPtr id_await_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000095 RID: 149
		[Nullable(2)]
		private static Delegate cb_getCancellationException;

		// Token: 0x04000096 RID: 150
		private IntPtr id_getCancellationException;

		// Token: 0x04000097 RID: 151
		[Nullable(2)]
		private static Delegate cb_getChildren;

		// Token: 0x04000098 RID: 152
		private IntPtr id_getChildren;

		// Token: 0x04000099 RID: 153
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x0400009A RID: 154
		private IntPtr id_isActive;

		// Token: 0x0400009B RID: 155
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x0400009C RID: 156
		private IntPtr id_isCancelled;

		// Token: 0x0400009D RID: 157
		[Nullable(2)]
		private static Delegate cb_isCompleted;

		// Token: 0x0400009E RID: 158
		private IntPtr id_isCompleted;

		// Token: 0x0400009F RID: 159
		[Nullable(2)]
		private static Delegate cb_getOnJoin;

		// Token: 0x040000A0 RID: 160
		private IntPtr id_getOnJoin;

		// Token: 0x040000A1 RID: 161
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x040000A2 RID: 162
		private IntPtr id_getParent;

		// Token: 0x040000A3 RID: 163
		[Nullable(2)]
		private static Delegate cb_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x040000A4 RID: 164
		private IntPtr id_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x040000A5 RID: 165
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040000A6 RID: 166
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040000A7 RID: 167
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x040000A8 RID: 168
		private IntPtr id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x040000A9 RID: 169
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040000AA RID: 170
		private IntPtr id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040000AB RID: 171
		[Nullable(2)]
		private static Delegate cb_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x040000AC RID: 172
		private IntPtr id_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x040000AD RID: 173
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x040000AE RID: 174
		private IntPtr id_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x040000AF RID: 175
		[Nullable(2)]
		private static Delegate cb_start;

		// Token: 0x040000B0 RID: 176
		private IntPtr id_start;

		// Token: 0x040000B1 RID: 177
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x040000B2 RID: 178
		private IntPtr id_getKey;

		// Token: 0x040000B3 RID: 179
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040000B4 RID: 180
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040000B5 RID: 181
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000B6 RID: 182
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000B7 RID: 183
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000B8 RID: 184
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000B9 RID: 185
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040000BA RID: 186
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
