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
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D5 RID: 213
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/Channel", DoNotGenerateAcw = true)]
	internal class IChannelInvoker : Java.Lang.Object, IChannel, IReceiveChannel, IJavaObject, IDisposable, IJavaPeerable, ISendChannel
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x000230F8 File Offset: 0x000212F8
		private static IntPtr java_class_ref
		{
			get
			{
				return IChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002311C File Offset: 0x0002131C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IChannelInvoker._members;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00023123 File Offset: 0x00021323
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002312B File Offset: 0x0002132B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00023137 File Offset: 0x00021337
		[NullableContext(2)]
		public static IChannel GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IChannel>(handle, transfer);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00023140 File Offset: 0x00021340
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.channels.Channel'.");
			}
			return handle;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0002316B File Offset: 0x0002136B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0002319C File Offset: 0x0002139C
		public IChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000231D4 File Offset: 0x000213D4
		private static Delegate GetIsClosedForReceiveHandler()
		{
			if (IChannelInvoker.cb_isClosedForReceive == null)
			{
				IChannelInvoker.cb_isClosedForReceive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChannelInvoker.n_IsClosedForReceive));
			}
			return IChannelInvoker.cb_isClosedForReceive;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000231F8 File Offset: 0x000213F8
		private static bool n_IsClosedForReceive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosedForReceive;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00023207 File Offset: 0x00021407
		public bool IsClosedForReceive
		{
			get
			{
				if (this.id_isClosedForReceive == IntPtr.Zero)
				{
					this.id_isClosedForReceive = JNIEnv.GetMethodID(this.class_ref, "isClosedForReceive", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isClosedForReceive);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00023247 File Offset: 0x00021447
		private static Delegate GetIsEmptyHandler()
		{
			if (IChannelInvoker.cb_isEmpty == null)
			{
				IChannelInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChannelInvoker.n_IsEmpty));
			}
			return IChannelInvoker.cb_isEmpty;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0002326B File Offset: 0x0002146B
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0002327A File Offset: 0x0002147A
		public bool IsEmpty
		{
			get
			{
				if (this.id_isEmpty == IntPtr.Zero)
				{
					this.id_isEmpty = JNIEnv.GetMethodID(this.class_ref, "isEmpty", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEmpty);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000232BA File Offset: 0x000214BA
		private static Delegate GetGetOnReceiveHandler()
		{
			if (IChannelInvoker.cb_getOnReceive == null)
			{
				IChannelInvoker.cb_getOnReceive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelInvoker.n_GetOnReceive));
			}
			return IChannelInvoker.cb_getOnReceive;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000232DE File Offset: 0x000214DE
		private static IntPtr n_GetOnReceive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceive);
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000232F4 File Offset: 0x000214F4
		public ISelectClause1 OnReceive
		{
			get
			{
				if (this.id_getOnReceive == IntPtr.Zero)
				{
					this.id_getOnReceive = JNIEnv.GetMethodID(this.class_ref, "getOnReceive", "()Lkotlinx/coroutines/selects/SelectClause1;");
				}
				return Java.Lang.Object.GetObject<ISelectClause1>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnReceive), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00023345 File Offset: 0x00021545
		private static Delegate GetGetOnReceiveCatchingHandler()
		{
			if (IChannelInvoker.cb_getOnReceiveCatching == null)
			{
				IChannelInvoker.cb_getOnReceiveCatching = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelInvoker.n_GetOnReceiveCatching));
			}
			return IChannelInvoker.cb_getOnReceiveCatching;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00023369 File Offset: 0x00021569
		private static IntPtr n_GetOnReceiveCatching(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceiveCatching);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00023380 File Offset: 0x00021580
		public ISelectClause1 OnReceiveCatching
		{
			get
			{
				if (this.id_getOnReceiveCatching == IntPtr.Zero)
				{
					this.id_getOnReceiveCatching = JNIEnv.GetMethodID(this.class_ref, "getOnReceiveCatching", "()Lkotlinx/coroutines/selects/SelectClause1;");
				}
				return Java.Lang.Object.GetObject<ISelectClause1>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnReceiveCatching), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000233D1 File Offset: 0x000215D1
		[Obsolete]
		private static Delegate GetGetOnReceiveOrNullHandler()
		{
			if (IChannelInvoker.cb_getOnReceiveOrNull == null)
			{
				IChannelInvoker.cb_getOnReceiveOrNull = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelInvoker.n_GetOnReceiveOrNull));
			}
			return IChannelInvoker.cb_getOnReceiveOrNull;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000233F5 File Offset: 0x000215F5
		[Obsolete]
		private static IntPtr n_GetOnReceiveOrNull(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceiveOrNull);
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0002340C File Offset: 0x0002160C
		public ISelectClause1 OnReceiveOrNull
		{
			get
			{
				if (this.id_getOnReceiveOrNull == IntPtr.Zero)
				{
					this.id_getOnReceiveOrNull = JNIEnv.GetMethodID(this.class_ref, "getOnReceiveOrNull", "()Lkotlinx/coroutines/selects/SelectClause1;");
				}
				return Java.Lang.Object.GetObject<ISelectClause1>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnReceiveOrNull), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002345D File Offset: 0x0002165D
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IChannelInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00023484 File Offset: 0x00021684
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000234A8 File Offset: 0x000216A8
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

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002351B File Offset: 0x0002171B
		private static Delegate GetIteratorHandler()
		{
			if (IChannelInvoker.cb_iterator == null)
			{
				IChannelInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelInvoker.n_Iterator));
			}
			return IChannelInvoker.cb_iterator;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0002353F File Offset: 0x0002173F
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00023554 File Offset: 0x00021754
		public IChannelIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Lkotlinx/coroutines/channels/ChannelIterator;");
			}
			return Java.Lang.Object.GetObject<IChannelIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000235A5 File Offset: 0x000217A5
		[Obsolete]
		private static Delegate GetPollHandler()
		{
			if (IChannelInvoker.cb_poll == null)
			{
				IChannelInvoker.cb_poll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelInvoker.n_Poll));
			}
			return IChannelInvoker.cb_poll;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000235C9 File Offset: 0x000217C9
		[Obsolete]
		private static IntPtr n_Poll(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Poll());
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000235E0 File Offset: 0x000217E0
		[NullableContext(2)]
		public Java.Lang.Object Poll()
		{
			if (this.id_poll == IntPtr.Zero)
			{
				this.id_poll = JNIEnv.GetMethodID(this.class_ref, "poll", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00023631 File Offset: 0x00021831
		private static Delegate GetReceive_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IChannelInvoker.cb_receive_Lkotlin_coroutines_Continuation_ == null)
			{
				IChannelInvoker.cb_receive_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChannelInvoker.n_Receive_Lkotlin_coroutines_Continuation_));
			}
			return IChannelInvoker.cb_receive_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00023658 File Offset: 0x00021858
		private static IntPtr n_Receive_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Receive(object2));
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00023680 File Offset: 0x00021880
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Receive(IContinuation p0)
		{
			if (this.id_receive_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_receive_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "receive", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_receive_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000236FE File Offset: 0x000218FE
		private static Delegate GetReceiveCatching_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IChannelInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ == null)
			{
				IChannelInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChannelInvoker.n_ReceiveCatching_Lkotlin_coroutines_Continuation_));
			}
			return IChannelInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00023724 File Offset: 0x00021924
		private static IntPtr n_ReceiveCatching_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ReceiveCatching(object2));
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0002374C File Offset: 0x0002194C
		[return: Nullable(2)]
		public unsafe Java.Lang.Object ReceiveCatching(IContinuation p0)
		{
			if (this.id_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "receiveCatching-JP2dKIU", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000237CA File Offset: 0x000219CA
		[Obsolete]
		private static Delegate GetReceiveOrNull_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IChannelInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_ == null)
			{
				IChannelInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChannelInvoker.n_ReceiveOrNull_Lkotlin_coroutines_Continuation_));
			}
			return IChannelInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000237F0 File Offset: 0x000219F0
		[Obsolete]
		private static IntPtr n_ReceiveOrNull_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ReceiveOrNull(object2));
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00023818 File Offset: 0x00021A18
		[return: Nullable(2)]
		public unsafe Java.Lang.Object ReceiveOrNull(IContinuation p0)
		{
			if (this.id_receiveOrNull_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_receiveOrNull_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "receiveOrNull", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_receiveOrNull_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00023896 File Offset: 0x00021A96
		private static Delegate GetTryReceiveHandler()
		{
			if (IChannelInvoker.cb_tryReceive_x45_PtdJZtk == null)
			{
				IChannelInvoker.cb_tryReceive_x45_PtdJZtk = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelInvoker.n_TryReceive));
			}
			return IChannelInvoker.cb_tryReceive_x45_PtdJZtk;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000238BA File Offset: 0x00021ABA
		private static IntPtr n_TryReceive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TryReceive());
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000238D0 File Offset: 0x00021AD0
		public Java.Lang.Object TryReceive()
		{
			if (this.id_tryReceive_x45_PtdJZtk == IntPtr.Zero)
			{
				this.id_tryReceive_x45_PtdJZtk = JNIEnv.GetMethodID(this.class_ref, "tryReceive-PtdJZtk", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_tryReceive_x45_PtdJZtk), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00023921 File Offset: 0x00021B21
		private static Delegate GetIsClosedForSendHandler()
		{
			if (IChannelInvoker.cb_isClosedForSend == null)
			{
				IChannelInvoker.cb_isClosedForSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChannelInvoker.n_IsClosedForSend));
			}
			return IChannelInvoker.cb_isClosedForSend;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00023945 File Offset: 0x00021B45
		private static bool n_IsClosedForSend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosedForSend;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00023954 File Offset: 0x00021B54
		public bool IsClosedForSend
		{
			get
			{
				if (this.id_isClosedForSend == IntPtr.Zero)
				{
					this.id_isClosedForSend = JNIEnv.GetMethodID(this.class_ref, "isClosedForSend", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isClosedForSend);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00023994 File Offset: 0x00021B94
		private static Delegate GetGetOnSendHandler()
		{
			if (IChannelInvoker.cb_getOnSend == null)
			{
				IChannelInvoker.cb_getOnSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChannelInvoker.n_GetOnSend));
			}
			return IChannelInvoker.cb_getOnSend;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000239B8 File Offset: 0x00021BB8
		private static IntPtr n_GetOnSend(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSend);
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000239CC File Offset: 0x00021BCC
		public ISelectClause2 OnSend
		{
			get
			{
				if (this.id_getOnSend == IntPtr.Zero)
				{
					this.id_getOnSend = JNIEnv.GetMethodID(this.class_ref, "getOnSend", "()Lkotlinx/coroutines/selects/SelectClause2;");
				}
				return Java.Lang.Object.GetObject<ISelectClause2>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnSend), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00023A1D File Offset: 0x00021C1D
		private static Delegate GetClose_Ljava_lang_Throwable_Handler()
		{
			if (IChannelInvoker.cb_close_Ljava_lang_Throwable_ == null)
			{
				IChannelInvoker.cb_close_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IChannelInvoker.n_Close_Ljava_lang_Throwable_));
			}
			return IChannelInvoker.cb_close_Ljava_lang_Throwable_;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00023A44 File Offset: 0x00021C44
		private static bool n_Close_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			return @object.Close(object2);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00023A68 File Offset: 0x00021C68
		[NullableContext(2)]
		public unsafe bool Close(Throwable cause)
		{
			if (this.id_close_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_close_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "close", "(Ljava/lang/Throwable;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((cause == null) ? IntPtr.Zero : cause.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_close_Ljava_lang_Throwable_, ptr);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00023ADB File Offset: 0x00021CDB
		private static Delegate GetInvokeOnClose_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (IChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ == null)
			{
				IChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IChannelInvoker.n_InvokeOnClose_Lkotlin_jvm_functions_Function1_));
			}
			return IChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00023B00 File Offset: 0x00021D00
		private static void n_InvokeOnClose_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			@object.InvokeOnClose(object2);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00023B24 File Offset: 0x00021D24
		public unsafe void InvokeOnClose(IFunction1 handler)
		{
			if (this.id_invokeOnClose_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_invokeOnClose_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "invokeOnClose", "(Lkotlin/jvm/functions/Function1;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invokeOnClose_Lkotlin_jvm_functions_Function1_, ptr);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00023B9C File Offset: 0x00021D9C
		[Obsolete]
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (IChannelInvoker.cb_offer_Ljava_lang_Object_ == null)
			{
				IChannelInvoker.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IChannelInvoker.n_Offer_Ljava_lang_Object_));
			}
			return IChannelInvoker.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00023BC0 File Offset: 0x00021DC0
		[Obsolete]
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00023BE4 File Offset: 0x00021DE4
		[NullableContext(2)]
		public unsafe bool Offer(Java.Lang.Object element)
		{
			if (this.id_offer_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "offer", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_offer_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00023C55 File Offset: 0x00021E55
		private static Delegate GetSend_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				IChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IChannelInvoker.n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return IChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00023C7C File Offset: 0x00021E7C
		private static IntPtr n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_element, IntPtr native_p1)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Send(object2, object3));
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00023CB0 File Offset: 0x00021EB0
		[NullableContext(2)]
		public unsafe Java.Lang.Object Send(Java.Lang.Object element, [Nullable(1)] IContinuation p1)
		{
			if (this.id_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "send", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00023D4E File Offset: 0x00021F4E
		private static Delegate GetTrySend_Ljava_lang_Object_Handler()
		{
			if (IChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ == null)
			{
				IChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChannelInvoker.n_TrySend_Ljava_lang_Object_));
			}
			return IChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00023D74 File Offset: 0x00021F74
		private static IntPtr n_TrySend_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TrySend(object2));
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00023D9C File Offset: 0x00021F9C
		public unsafe Java.Lang.Object TrySend([Nullable(2)] Java.Lang.Object element)
		{
			if (this.id_trySend_x45_JP2dKIU_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_trySend_x45_JP2dKIU_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "trySend-JP2dKIU", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_trySend_x45_JP2dKIU_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0400030C RID: 780
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/Channel", typeof(IChannelInvoker));

		// Token: 0x0400030D RID: 781
		private IntPtr class_ref;

		// Token: 0x0400030E RID: 782
		[Nullable(2)]
		private static Delegate cb_isClosedForReceive;

		// Token: 0x0400030F RID: 783
		private IntPtr id_isClosedForReceive;

		// Token: 0x04000310 RID: 784
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x04000311 RID: 785
		private IntPtr id_isEmpty;

		// Token: 0x04000312 RID: 786
		[Nullable(2)]
		private static Delegate cb_getOnReceive;

		// Token: 0x04000313 RID: 787
		private IntPtr id_getOnReceive;

		// Token: 0x04000314 RID: 788
		[Nullable(2)]
		private static Delegate cb_getOnReceiveCatching;

		// Token: 0x04000315 RID: 789
		private IntPtr id_getOnReceiveCatching;

		// Token: 0x04000316 RID: 790
		[Nullable(2)]
		private static Delegate cb_getOnReceiveOrNull;

		// Token: 0x04000317 RID: 791
		private IntPtr id_getOnReceiveOrNull;

		// Token: 0x04000318 RID: 792
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x04000319 RID: 793
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x0400031A RID: 794
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x0400031B RID: 795
		private IntPtr id_iterator;

		// Token: 0x0400031C RID: 796
		[Nullable(2)]
		private static Delegate cb_poll;

		// Token: 0x0400031D RID: 797
		private IntPtr id_poll;

		// Token: 0x0400031E RID: 798
		[Nullable(2)]
		private static Delegate cb_receive_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400031F RID: 799
		private IntPtr id_receive_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000320 RID: 800
		[Nullable(2)]
		private static Delegate cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000321 RID: 801
		private IntPtr id_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000322 RID: 802
		[Nullable(2)]
		private static Delegate cb_receiveOrNull_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000323 RID: 803
		private IntPtr id_receiveOrNull_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000324 RID: 804
		[Nullable(2)]
		private static Delegate cb_tryReceive_x45_PtdJZtk;

		// Token: 0x04000325 RID: 805
		private IntPtr id_tryReceive_x45_PtdJZtk;

		// Token: 0x04000326 RID: 806
		[Nullable(2)]
		private static Delegate cb_isClosedForSend;

		// Token: 0x04000327 RID: 807
		private IntPtr id_isClosedForSend;

		// Token: 0x04000328 RID: 808
		[Nullable(2)]
		private static Delegate cb_getOnSend;

		// Token: 0x04000329 RID: 809
		private IntPtr id_getOnSend;

		// Token: 0x0400032A RID: 810
		[Nullable(2)]
		private static Delegate cb_close_Ljava_lang_Throwable_;

		// Token: 0x0400032B RID: 811
		private IntPtr id_close_Ljava_lang_Throwable_;

		// Token: 0x0400032C RID: 812
		[Nullable(2)]
		private static Delegate cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x0400032D RID: 813
		private IntPtr id_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x0400032E RID: 814
		[Nullable(2)]
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x0400032F RID: 815
		private IntPtr id_offer_Ljava_lang_Object_;

		// Token: 0x04000330 RID: 816
		[Nullable(2)]
		private static Delegate cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000331 RID: 817
		private IntPtr id_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000332 RID: 818
		[Nullable(2)]
		private static Delegate cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;

		// Token: 0x04000333 RID: 819
		private IntPtr id_trySend_x45_JP2dKIU_Ljava_lang_Object_;
	}
}
