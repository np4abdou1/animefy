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
	// Token: 0x02000078 RID: 120
	[NullableContext(1)]
	[Nullable(0)]
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("kotlinx/coroutines/JobSupport", DoNotGenerateAcw = true)]
	public class JobSupport : Java.Lang.Object, IChildJob, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable, IParentJob
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		internal static IntPtr class_ref
		{
			get
			{
				return JobSupport._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobSupport._members;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00011AEC File Offset: 0x0000FCEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobSupport._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00011B10 File Offset: 0x0000FD10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobSupport._members.ManagedPeerType;
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00011B1C File Offset: 0x0000FD1C
		protected JobSupport(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00011B28 File Offset: 0x0000FD28
		[Register(".ctor", "(Z)V", "")]
		public unsafe JobSupport(bool active) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(active);
			base.SetHandle(JobSupport._members.InstanceMethods.StartCreateInstance("(Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			JobSupport._members.InstanceMethods.FinishCreateInstance("(Z)V", this, ptr);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00011BAC File Offset: 0x0000FDAC
		public CancellationException CancellationException
		{
			[Register("getCancellationException", "()Ljava/util/concurrent/CancellationException;", "")]
			get
			{
				return Java.Lang.Object.GetObject<CancellationException>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("getCancellationException.()Ljava/util/concurrent/CancellationException;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00011BDE File Offset: 0x0000FDDE
		private static Delegate GetGetChildJobCancellationCauseHandler()
		{
			if (JobSupport.cb_getChildJobCancellationCause == null)
			{
				JobSupport.cb_getChildJobCancellationCause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JobSupport.n_GetChildJobCancellationCause));
			}
			return JobSupport.cb_getChildJobCancellationCause;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00011C02 File Offset: 0x0000FE02
		private static IntPtr n_GetChildJobCancellationCause(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChildJobCancellationCause);
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00011C18 File Offset: 0x0000FE18
		public virtual CancellationException ChildJobCancellationCause
		{
			[Register("getChildJobCancellationCause", "()Ljava/util/concurrent/CancellationException;", "GetGetChildJobCancellationCauseHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CancellationException>(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("getChildJobCancellationCause.()Ljava/util/concurrent/CancellationException;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00011C4C File Offset: 0x0000FE4C
		public ISequence Children
		{
			[Register("getChildren", "()Lkotlin/sequences/Sequence;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISequence>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("getChildren.()Lkotlin/sequences/Sequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00011C80 File Offset: 0x0000FE80
		[Nullable(2)]
		protected Throwable CompletionCause
		{
			[NullableContext(2)]
			[Register("getCompletionCause", "()Ljava/lang/Throwable;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Throwable>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("getCompletionCause.()Ljava/lang/Throwable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00011CB2 File Offset: 0x0000FEB2
		protected bool CompletionCauseHandled
		{
			[Register("getCompletionCauseHandled", "()Z", "")]
			get
			{
				return JobSupport._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getCompletionCauseHandled.()Z", this, null);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00011CCC File Offset: 0x0000FECC
		[Nullable(2)]
		public Throwable CompletionExceptionOrNull
		{
			[NullableContext(2)]
			[Register("getCompletionExceptionOrNull", "()Ljava/lang/Throwable;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Throwable>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("getCompletionExceptionOrNull.()Ljava/lang/Throwable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00011CFE File Offset: 0x0000FEFE
		private static Delegate GetIsActiveHandler()
		{
			if (JobSupport.cb_isActive == null)
			{
				JobSupport.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(JobSupport.n_IsActive));
			}
			return JobSupport.cb_isActive;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00011D22 File Offset: 0x0000FF22
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00011D31 File Offset: 0x0000FF31
		public virtual bool IsActive
		{
			[Register("isActive", "()Z", "GetIsActiveHandler")]
			get
			{
				return JobSupport._members.InstanceMethods.InvokeVirtualBooleanMethod("isActive.()Z", this, null);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00011D4A File Offset: 0x0000FF4A
		public bool IsCancelled
		{
			[Register("isCancelled", "()Z", "")]
			get
			{
				return JobSupport._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isCancelled.()Z", this, null);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00011D63 File Offset: 0x0000FF63
		public bool IsCompleted
		{
			[Register("isCompleted", "()Z", "")]
			get
			{
				return JobSupport._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isCompleted.()Z", this, null);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00011D7C File Offset: 0x0000FF7C
		public bool IsCompletedExceptionally
		{
			[Register("isCompletedExceptionally", "()Z", "")]
			get
			{
				return JobSupport._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isCompletedExceptionally.()Z", this, null);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00011D95 File Offset: 0x0000FF95
		private static Delegate GetIsScopedCoroutineHandler()
		{
			if (JobSupport.cb_isScopedCoroutine == null)
			{
				JobSupport.cb_isScopedCoroutine = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(JobSupport.n_IsScopedCoroutine));
			}
			return JobSupport.cb_isScopedCoroutine;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00011DB9 File Offset: 0x0000FFB9
		private static bool n_IsScopedCoroutine(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsScopedCoroutine;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00011DC8 File Offset: 0x0000FFC8
		protected virtual bool IsScopedCoroutine
		{
			[Register("isScopedCoroutine", "()Z", "GetIsScopedCoroutineHandler")]
			get
			{
				return JobSupport._members.InstanceMethods.InvokeVirtualBooleanMethod("isScopedCoroutine.()Z", this, null);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		public ICoroutineContextKey Key
		{
			[Register("getKey", "()Lkotlin/coroutines/CoroutineContext$Key;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ICoroutineContextKey>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("getKey.()Lkotlin/coroutines/CoroutineContext$Key;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00011E18 File Offset: 0x00010018
		protected ISelectClause1 OnAwaitInternal
		{
			[Register("getOnAwaitInternal", "()Lkotlinx/coroutines/selects/SelectClause1;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISelectClause1>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOnAwaitInternal.()Lkotlinx/coroutines/selects/SelectClause1;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00011E4C File Offset: 0x0001004C
		public ISelectClause0 OnJoin
		{
			[Register("getOnJoin", "()Lkotlinx/coroutines/selects/SelectClause0;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISelectClause0>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOnJoin.()Lkotlinx/coroutines/selects/SelectClause0;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00011E7E File Offset: 0x0001007E
		private static Delegate GetGetParentHandler()
		{
			if (JobSupport.cb_getParent == null)
			{
				JobSupport.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JobSupport.n_GetParent));
			}
			return JobSupport.cb_getParent;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00011EA2 File Offset: 0x000100A2
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00011EB8 File Offset: 0x000100B8
		[Nullable(2)]
		public virtual IJob Parent
		{
			[NullableContext(2)]
			[Register("getParent", "()Lkotlinx/coroutines/Job;", "GetGetParentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IJob>(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("getParent.()Lkotlinx/coroutines/Job;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00011EEA File Offset: 0x000100EA
		private static Delegate GetAfterCompletion_Ljava_lang_Object_Handler()
		{
			if (JobSupport.cb_afterCompletion_Ljava_lang_Object_ == null)
			{
				JobSupport.cb_afterCompletion_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(JobSupport.n_AfterCompletion_Ljava_lang_Object_));
			}
			return JobSupport.cb_afterCompletion_Ljava_lang_Object_;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00011F10 File Offset: 0x00010110
		private static void n_AfterCompletion_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.AfterCompletion(object2);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00011F34 File Offset: 0x00010134
		[NullableContext(2)]
		[Register("afterCompletion", "(Ljava/lang/Object;)V", "GetAfterCompletion_Ljava_lang_Object_Handler")]
		protected unsafe virtual void AfterCompletion(Java.Lang.Object state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				JobSupport._members.InstanceMethods.InvokeVirtualVoidMethod("afterCompletion.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00011F98 File Offset: 0x00010198
		[Register("attachChild", "(Lkotlinx/coroutines/ChildJob;)Lkotlinx/coroutines/ChildHandle;", "")]
		public unsafe IChildHandle AttachChild(IChildJob child)
		{
			IChildHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : ((Java.Lang.Object)child).Handle);
				@object = Java.Lang.Object.GetObject<IChildHandle>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("attachChild.(Lkotlinx/coroutines/ChildJob;)Lkotlinx/coroutines/ChildHandle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return @object;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00012010 File Offset: 0x00010210
		[Register("awaitInternal", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		protected unsafe Java.Lang.Object AwaitInternal(IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("awaitInternal.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00012088 File Offset: 0x00010288
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (JobSupport.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				JobSupport.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(JobSupport.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return JobSupport.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000120AC File Offset: 0x000102AC
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000120D0 File Offset: 0x000102D0
		[NullableContext(2)]
		[Register("cancel", "(Ljava/util/concurrent/CancellationException;)V", "GetCancel_Ljava_util_concurrent_CancellationException_Handler")]
		public unsafe virtual void Cancel(CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				JobSupport._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.(Ljava/util/concurrent/CancellationException;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00012134 File Offset: 0x00010334
		[NullableContext(2)]
		[Register("cancelCoroutine", "(Ljava/lang/Throwable;)Z", "")]
		public unsafe bool CancelCoroutine(Throwable cause)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				result = JobSupport._members.InstanceMethods.InvokeNonvirtualBooleanMethod("cancelCoroutine.(Ljava/lang/Throwable;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
			return result;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001219C File Offset: 0x0001039C
		private static Delegate GetCancelInternal_Ljava_lang_Throwable_Handler()
		{
			if (JobSupport.cb_cancelInternal_Ljava_lang_Throwable_ == null)
			{
				JobSupport.cb_cancelInternal_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(JobSupport.n_CancelInternal_Ljava_lang_Throwable_));
			}
			return JobSupport.cb_cancelInternal_Ljava_lang_Throwable_;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000121C0 File Offset: 0x000103C0
		private static void n_CancelInternal_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.CancelInternal(object2);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000121E4 File Offset: 0x000103E4
		[Register("cancelInternal", "(Ljava/lang/Throwable;)V", "GetCancelInternal_Ljava_lang_Throwable_Handler")]
		public unsafe virtual void CancelInternal(Throwable cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				JobSupport._members.InstanceMethods.InvokeVirtualVoidMethod("cancelInternal.(Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00012248 File Offset: 0x00010448
		private static Delegate GetCancellationExceptionMessageHandler()
		{
			if (JobSupport.cb_cancellationExceptionMessage == null)
			{
				JobSupport.cb_cancellationExceptionMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JobSupport.n_CancellationExceptionMessage));
			}
			return JobSupport.cb_cancellationExceptionMessage;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001226C File Offset: 0x0001046C
		private static IntPtr n_CancellationExceptionMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancellationExceptionMessage());
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00012280 File Offset: 0x00010480
		[Register("cancellationExceptionMessage", "()Ljava/lang/String;", "GetCancellationExceptionMessageHandler")]
		protected virtual string CancellationExceptionMessage()
		{
			return JNIEnv.GetString(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("cancellationExceptionMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000122B2 File Offset: 0x000104B2
		private static Delegate GetChildCancelled_Ljava_lang_Throwable_Handler()
		{
			if (JobSupport.cb_childCancelled_Ljava_lang_Throwable_ == null)
			{
				JobSupport.cb_childCancelled_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JobSupport.n_ChildCancelled_Ljava_lang_Throwable_));
			}
			return JobSupport.cb_childCancelled_Ljava_lang_Throwable_;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000122D8 File Offset: 0x000104D8
		private static bool n_ChildCancelled_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			return @object.ChildCancelled(object2);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000122FC File Offset: 0x000104FC
		[Register("childCancelled", "(Ljava/lang/Throwable;)Z", "GetChildCancelled_Ljava_lang_Throwable_Handler")]
		public unsafe virtual bool ChildCancelled(Throwable cause)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				result = JobSupport._members.InstanceMethods.InvokeVirtualBooleanMethod("childCancelled.(Ljava/lang/Throwable;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
			return result;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00012364 File Offset: 0x00010564
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (JobSupport.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				JobSupport.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(JobSupport.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return JobSupport.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00012388 File Offset: 0x00010588
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000123BC File Offset: 0x000105BC
		[NullableContext(2)]
		[Register("fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe virtual Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("fold.(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001245C File Offset: 0x0001065C
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (JobSupport.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				JobSupport.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(JobSupport.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return JobSupport.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00012480 File Offset: 0x00010680
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000124A8 File Offset: 0x000106A8
		[Register("get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe virtual Java.Lang.Object Get(ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00012520 File Offset: 0x00010720
		private static Delegate GetHandleJobException_Ljava_lang_Throwable_Handler()
		{
			if (JobSupport.cb_handleJobException_Ljava_lang_Throwable_ == null)
			{
				JobSupport.cb_handleJobException_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JobSupport.n_HandleJobException_Ljava_lang_Throwable_));
			}
			return JobSupport.cb_handleJobException_Ljava_lang_Throwable_;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00012544 File Offset: 0x00010744
		private static bool n_HandleJobException_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_exception, JniHandleOwnership.DoNotTransfer);
			return @object.HandleJobException(object2);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00012568 File Offset: 0x00010768
		[Register("handleJobException", "(Ljava/lang/Throwable;)Z", "GetHandleJobException_Ljava_lang_Throwable_Handler")]
		protected unsafe virtual bool HandleJobException(Throwable exception)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((exception == null) ? IntPtr.Zero : exception.Handle);
				result = JobSupport._members.InstanceMethods.InvokeVirtualBooleanMethod("handleJobException.(Ljava/lang/Throwable;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(exception);
			}
			return result;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000125D0 File Offset: 0x000107D0
		[NullableContext(2)]
		[Register("initParentJob", "(Lkotlinx/coroutines/Job;)V", "")]
		protected unsafe void InitParentJob(IJob parent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((Java.Lang.Object)parent).Handle);
				JobSupport._members.InstanceMethods.InvokeNonvirtualVoidMethod("initParentJob.(Lkotlinx/coroutines/Job;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parent);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00012638 File Offset: 0x00010838
		[Register("invokeOnCompletion", "(ZZLkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", "")]
		public unsafe IDisposableHandle InvokeOnCompletion(bool onCancelling, bool invokeImmediately, IFunction1 handler)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(onCancelling);
				ptr[1] = new JniArgumentValue(invokeImmediately);
				ptr[2] = new JniArgumentValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("invokeOnCompletion.(ZZLkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(handler);
			}
			return @object;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000126DC File Offset: 0x000108DC
		[Register("invokeOnCompletion", "(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", "")]
		public unsafe IDisposableHandle InvokeOnCompletion(IFunction1 handler)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("invokeOnCompletion.(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(handler);
			}
			return @object;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00012754 File Offset: 0x00010954
		[Register("join", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Join(IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("join.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000127CC File Offset: 0x000109CC
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (JobSupport.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				JobSupport.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(JobSupport.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return JobSupport.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000127F0 File Offset: 0x000109F0
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00012818 File Offset: 0x00010A18
		[Register("minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler")]
		public unsafe virtual ICoroutineContext MinusKey(ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("minusKey.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00012890 File Offset: 0x00010A90
		private static Delegate GetOnCancelling_Ljava_lang_Throwable_Handler()
		{
			if (JobSupport.cb_onCancelling_Ljava_lang_Throwable_ == null)
			{
				JobSupport.cb_onCancelling_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(JobSupport.n_OnCancelling_Ljava_lang_Throwable_));
			}
			return JobSupport.cb_onCancelling_Ljava_lang_Throwable_;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000128B4 File Offset: 0x00010AB4
		private static void n_OnCancelling_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.OnCancelling(object2);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000128D8 File Offset: 0x00010AD8
		[NullableContext(2)]
		[Register("onCancelling", "(Ljava/lang/Throwable;)V", "GetOnCancelling_Ljava_lang_Throwable_Handler")]
		protected unsafe virtual void OnCancelling(Throwable cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				JobSupport._members.InstanceMethods.InvokeVirtualVoidMethod("onCancelling.(Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0001293C File Offset: 0x00010B3C
		private static Delegate GetOnCompletionInternal_Ljava_lang_Object_Handler()
		{
			if (JobSupport.cb_onCompletionInternal_Ljava_lang_Object_ == null)
			{
				JobSupport.cb_onCompletionInternal_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(JobSupport.n_OnCompletionInternal_Ljava_lang_Object_));
			}
			return JobSupport.cb_onCompletionInternal_Ljava_lang_Object_;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00012960 File Offset: 0x00010B60
		private static void n_OnCompletionInternal_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnCompletionInternal(object2);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00012984 File Offset: 0x00010B84
		[NullableContext(2)]
		[Register("onCompletionInternal", "(Ljava/lang/Object;)V", "GetOnCompletionInternal_Ljava_lang_Object_Handler")]
		protected unsafe virtual void OnCompletionInternal(Java.Lang.Object state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				JobSupport._members.InstanceMethods.InvokeVirtualVoidMethod("onCompletionInternal.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000129E8 File Offset: 0x00010BE8
		private static Delegate GetOnStartHandler()
		{
			if (JobSupport.cb_onStart == null)
			{
				JobSupport.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(JobSupport.n_OnStart));
			}
			return JobSupport.cb_onStart;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00012A0C File Offset: 0x00010C0C
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00012A1B File Offset: 0x00010C1B
		[Register("onStart", "()V", "GetOnStartHandler")]
		protected virtual void OnStart()
		{
			JobSupport._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00012A34 File Offset: 0x00010C34
		[Register("parentCancelled", "(Lkotlinx/coroutines/ParentJob;)V", "")]
		public unsafe void ParentCancelled(IParentJob parentJob)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parentJob == null) ? IntPtr.Zero : ((Java.Lang.Object)parentJob).Handle);
				JobSupport._members.InstanceMethods.InvokeNonvirtualVoidMethod("parentCancelled.(Lkotlinx/coroutines/ParentJob;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parentJob);
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00012A9C File Offset: 0x00010C9C
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (JobSupport.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				JobSupport.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(JobSupport.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return JobSupport.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00012AC0 File Offset: 0x00010CC0
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00012AE8 File Offset: 0x00010CE8
		[Register("plus", "(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "GetPlus_Lkotlin_coroutines_CoroutineContext_Handler")]
		public unsafe virtual ICoroutineContext Plus(ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("plus.(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00012B60 File Offset: 0x00010D60
		[Obsolete]
		private static Delegate GetPlus_Lkotlinx_coroutines_Job_Handler()
		{
			if (JobSupport.cb_plus_Lkotlinx_coroutines_Job_ == null)
			{
				JobSupport.cb_plus_Lkotlinx_coroutines_Job_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(JobSupport.n_Plus_Lkotlinx_coroutines_Job_));
			}
			return JobSupport.cb_plus_Lkotlinx_coroutines_Job_;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00012B84 File Offset: 0x00010D84
		[Obsolete]
		private static IntPtr n_Plus_Lkotlinx_coroutines_Job_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			JobSupport @object = Java.Lang.Object.GetObject<JobSupport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IJob object2 = Java.Lang.Object.GetObject<IJob>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00012BAC File Offset: 0x00010DAC
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "GetPlus_Lkotlinx_coroutines_Job_Handler")]
		public unsafe virtual IJob Plus(IJob other)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(JobSupport._members.InstanceMethods.InvokeVirtualObjectMethod("plus.(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00012C24 File Offset: 0x00010E24
		[Register("start", "()Z", "")]
		public bool Start()
		{
			return JobSupport._members.InstanceMethods.InvokeNonvirtualBooleanMethod("start.()Z", this, null);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00012C40 File Offset: 0x00010E40
		[Register("toCancellationException", "(Ljava/lang/Throwable;Ljava/lang/String;)Ljava/util/concurrent/CancellationException;", "")]
		protected unsafe CancellationException ToCancellationException(Throwable _this_toCancellationException, [Nullable(2)] string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			CancellationException @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toCancellationException == null) ? IntPtr.Zero : _this_toCancellationException.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CancellationException>(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("toCancellationException.(Ljava/lang/Throwable;Ljava/lang/String;)Ljava/util/concurrent/CancellationException;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toCancellationException);
			}
			return @object;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00012CD4 File Offset: 0x00010ED4
		[Register("toDebugString", "()Ljava/lang/String;", "")]
		public string ToDebugString()
		{
			return JNIEnv.GetString(JobSupport._members.InstanceMethods.InvokeNonvirtualObjectMethod("toDebugString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001EF RID: 495
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/JobSupport", typeof(JobSupport));

		// Token: 0x040001F0 RID: 496
		[Nullable(2)]
		private static Delegate cb_getChildJobCancellationCause;

		// Token: 0x040001F1 RID: 497
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x040001F2 RID: 498
		[Nullable(2)]
		private static Delegate cb_isScopedCoroutine;

		// Token: 0x040001F3 RID: 499
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x040001F4 RID: 500
		[Nullable(2)]
		private static Delegate cb_afterCompletion_Ljava_lang_Object_;

		// Token: 0x040001F5 RID: 501
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040001F6 RID: 502
		[Nullable(2)]
		private static Delegate cb_cancelInternal_Ljava_lang_Throwable_;

		// Token: 0x040001F7 RID: 503
		[Nullable(2)]
		private static Delegate cb_cancellationExceptionMessage;

		// Token: 0x040001F8 RID: 504
		[Nullable(2)]
		private static Delegate cb_childCancelled_Ljava_lang_Throwable_;

		// Token: 0x040001F9 RID: 505
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040001FA RID: 506
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001FB RID: 507
		[Nullable(2)]
		private static Delegate cb_handleJobException_Ljava_lang_Throwable_;

		// Token: 0x040001FC RID: 508
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001FD RID: 509
		[Nullable(2)]
		private static Delegate cb_onCancelling_Ljava_lang_Throwable_;

		// Token: 0x040001FE RID: 510
		[Nullable(2)]
		private static Delegate cb_onCompletionInternal_Ljava_lang_Object_;

		// Token: 0x040001FF RID: 511
		[Nullable(2)]
		private static Delegate cb_onStart;

		// Token: 0x04000200 RID: 512
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x04000201 RID: 513
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlinx_coroutines_Job_;
	}
}
