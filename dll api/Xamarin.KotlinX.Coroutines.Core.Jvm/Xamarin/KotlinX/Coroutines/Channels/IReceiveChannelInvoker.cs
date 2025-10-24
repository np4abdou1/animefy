using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000DE RID: 222
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ReceiveChannel", DoNotGenerateAcw = true)]
	internal class IReceiveChannelInvoker : Java.Lang.Object, IReceiveChannel, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00024B2C File Offset: 0x00022D2C
		private static IntPtr java_class_ref
		{
			get
			{
				return IReceiveChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00024B50 File Offset: 0x00022D50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IReceiveChannelInvoker._members;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00024B57 File Offset: 0x00022D57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00024B5F File Offset: 0x00022D5F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IReceiveChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00024B6B File Offset: 0x00022D6B
		[NullableContext(2)]
		public static IReceiveChannel GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IReceiveChannel>(handle, transfer);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00024B74 File Offset: 0x00022D74
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReceiveChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.channels.ReceiveChannel'.");
			}
			return handle;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00024B9F File Offset: 0x00022D9F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00024BD0 File Offset: 0x00022DD0
		public IReceiveChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReceiveChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00024C08 File Offset: 0x00022E08
		private static Delegate GetIsClosedForReceiveHandler()
		{
			if (IReceiveChannelInvoker.cb_isClosedForReceive == null)
			{
				IReceiveChannelInvoker.cb_isClosedForReceive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IReceiveChannelInvoker.n_IsClosedForReceive));
			}
			return IReceiveChannelInvoker.cb_isClosedForReceive;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00024C2C File Offset: 0x00022E2C
		private static bool n_IsClosedForReceive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosedForReceive;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00024C3B File Offset: 0x00022E3B
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

		// Token: 0x06000A3E RID: 2622 RVA: 0x00024C7B File Offset: 0x00022E7B
		private static Delegate GetIsEmptyHandler()
		{
			if (IReceiveChannelInvoker.cb_isEmpty == null)
			{
				IReceiveChannelInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IReceiveChannelInvoker.n_IsEmpty));
			}
			return IReceiveChannelInvoker.cb_isEmpty;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00024C9F File Offset: 0x00022E9F
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00024CAE File Offset: 0x00022EAE
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

		// Token: 0x06000A41 RID: 2625 RVA: 0x00024CEE File Offset: 0x00022EEE
		private static Delegate GetGetOnReceiveHandler()
		{
			if (IReceiveChannelInvoker.cb_getOnReceive == null)
			{
				IReceiveChannelInvoker.cb_getOnReceive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReceiveChannelInvoker.n_GetOnReceive));
			}
			return IReceiveChannelInvoker.cb_getOnReceive;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00024D12 File Offset: 0x00022F12
		private static IntPtr n_GetOnReceive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceive);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00024D28 File Offset: 0x00022F28
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

		// Token: 0x06000A44 RID: 2628 RVA: 0x00024D79 File Offset: 0x00022F79
		private static Delegate GetGetOnReceiveCatchingHandler()
		{
			if (IReceiveChannelInvoker.cb_getOnReceiveCatching == null)
			{
				IReceiveChannelInvoker.cb_getOnReceiveCatching = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReceiveChannelInvoker.n_GetOnReceiveCatching));
			}
			return IReceiveChannelInvoker.cb_getOnReceiveCatching;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00024D9D File Offset: 0x00022F9D
		private static IntPtr n_GetOnReceiveCatching(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceiveCatching);
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00024DB4 File Offset: 0x00022FB4
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

		// Token: 0x06000A47 RID: 2631 RVA: 0x00024E05 File Offset: 0x00023005
		[Obsolete]
		private static Delegate GetGetOnReceiveOrNullHandler()
		{
			if (IReceiveChannelInvoker.cb_getOnReceiveOrNull == null)
			{
				IReceiveChannelInvoker.cb_getOnReceiveOrNull = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReceiveChannelInvoker.n_GetOnReceiveOrNull));
			}
			return IReceiveChannelInvoker.cb_getOnReceiveOrNull;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00024E29 File Offset: 0x00023029
		[Obsolete]
		private static IntPtr n_GetOnReceiveOrNull(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceiveOrNull);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00024E40 File Offset: 0x00023040
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

		// Token: 0x06000A4A RID: 2634 RVA: 0x00024E91 File Offset: 0x00023091
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IReceiveChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IReceiveChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IReceiveChannelInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IReceiveChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00024EB8 File Offset: 0x000230B8
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00024EDC File Offset: 0x000230DC
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

		// Token: 0x06000A4D RID: 2637 RVA: 0x00024F4F File Offset: 0x0002314F
		private static Delegate GetIteratorHandler()
		{
			if (IReceiveChannelInvoker.cb_iterator == null)
			{
				IReceiveChannelInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReceiveChannelInvoker.n_Iterator));
			}
			return IReceiveChannelInvoker.cb_iterator;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00024F73 File Offset: 0x00023173
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00024F88 File Offset: 0x00023188
		public IChannelIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Lkotlinx/coroutines/channels/ChannelIterator;");
			}
			return Java.Lang.Object.GetObject<IChannelIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00024FD9 File Offset: 0x000231D9
		[Obsolete]
		private static Delegate GetPollHandler()
		{
			if (IReceiveChannelInvoker.cb_poll == null)
			{
				IReceiveChannelInvoker.cb_poll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReceiveChannelInvoker.n_Poll));
			}
			return IReceiveChannelInvoker.cb_poll;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00024FFD File Offset: 0x000231FD
		[Obsolete]
		private static IntPtr n_Poll(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Poll());
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00025014 File Offset: 0x00023214
		[NullableContext(2)]
		public Java.Lang.Object Poll()
		{
			if (this.id_poll == IntPtr.Zero)
			{
				this.id_poll = JNIEnv.GetMethodID(this.class_ref, "poll", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00025065 File Offset: 0x00023265
		private static Delegate GetReceive_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IReceiveChannelInvoker.cb_receive_Lkotlin_coroutines_Continuation_ == null)
			{
				IReceiveChannelInvoker.cb_receive_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IReceiveChannelInvoker.n_Receive_Lkotlin_coroutines_Continuation_));
			}
			return IReceiveChannelInvoker.cb_receive_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0002508C File Offset: 0x0002328C
		private static IntPtr n_Receive_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Receive(object2));
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000250B4 File Offset: 0x000232B4
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

		// Token: 0x06000A56 RID: 2646 RVA: 0x00025132 File Offset: 0x00023332
		private static Delegate GetReceiveCatching_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IReceiveChannelInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ == null)
			{
				IReceiveChannelInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IReceiveChannelInvoker.n_ReceiveCatching_Lkotlin_coroutines_Continuation_));
			}
			return IReceiveChannelInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00025158 File Offset: 0x00023358
		private static IntPtr n_ReceiveCatching_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ReceiveCatching(object2));
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00025180 File Offset: 0x00023380
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

		// Token: 0x06000A59 RID: 2649 RVA: 0x000251FE File Offset: 0x000233FE
		[Obsolete]
		private static Delegate GetReceiveOrNull_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IReceiveChannelInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_ == null)
			{
				IReceiveChannelInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IReceiveChannelInvoker.n_ReceiveOrNull_Lkotlin_coroutines_Continuation_));
			}
			return IReceiveChannelInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00025224 File Offset: 0x00023424
		[Obsolete]
		private static IntPtr n_ReceiveOrNull_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ReceiveOrNull(object2));
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002524C File Offset: 0x0002344C
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

		// Token: 0x06000A5C RID: 2652 RVA: 0x000252CA File Offset: 0x000234CA
		private static Delegate GetTryReceiveHandler()
		{
			if (IReceiveChannelInvoker.cb_tryReceive_x45_PtdJZtk == null)
			{
				IReceiveChannelInvoker.cb_tryReceive_x45_PtdJZtk = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReceiveChannelInvoker.n_TryReceive));
			}
			return IReceiveChannelInvoker.cb_tryReceive_x45_PtdJZtk;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000252EE File Offset: 0x000234EE
		private static IntPtr n_TryReceive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReceiveChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TryReceive());
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00025304 File Offset: 0x00023504
		public Java.Lang.Object TryReceive()
		{
			if (this.id_tryReceive_x45_PtdJZtk == IntPtr.Zero)
			{
				this.id_tryReceive_x45_PtdJZtk = JNIEnv.GetMethodID(this.class_ref, "tryReceive-PtdJZtk", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_tryReceive_x45_PtdJZtk), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000351 RID: 849
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ReceiveChannel", typeof(IReceiveChannelInvoker));

		// Token: 0x04000352 RID: 850
		private IntPtr class_ref;

		// Token: 0x04000353 RID: 851
		[Nullable(2)]
		private static Delegate cb_isClosedForReceive;

		// Token: 0x04000354 RID: 852
		private IntPtr id_isClosedForReceive;

		// Token: 0x04000355 RID: 853
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x04000356 RID: 854
		private IntPtr id_isEmpty;

		// Token: 0x04000357 RID: 855
		[Nullable(2)]
		private static Delegate cb_getOnReceive;

		// Token: 0x04000358 RID: 856
		private IntPtr id_getOnReceive;

		// Token: 0x04000359 RID: 857
		[Nullable(2)]
		private static Delegate cb_getOnReceiveCatching;

		// Token: 0x0400035A RID: 858
		private IntPtr id_getOnReceiveCatching;

		// Token: 0x0400035B RID: 859
		[Nullable(2)]
		private static Delegate cb_getOnReceiveOrNull;

		// Token: 0x0400035C RID: 860
		private IntPtr id_getOnReceiveOrNull;

		// Token: 0x0400035D RID: 861
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x0400035E RID: 862
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x0400035F RID: 863
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x04000360 RID: 864
		private IntPtr id_iterator;

		// Token: 0x04000361 RID: 865
		[Nullable(2)]
		private static Delegate cb_poll;

		// Token: 0x04000362 RID: 866
		private IntPtr id_poll;

		// Token: 0x04000363 RID: 867
		[Nullable(2)]
		private static Delegate cb_receive_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000364 RID: 868
		private IntPtr id_receive_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000365 RID: 869
		[Nullable(2)]
		private static Delegate cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000366 RID: 870
		private IntPtr id_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000367 RID: 871
		[Nullable(2)]
		private static Delegate cb_receiveOrNull_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000368 RID: 872
		private IntPtr id_receiveOrNull_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000369 RID: 873
		[Nullable(2)]
		private static Delegate cb_tryReceive_x45_PtdJZtk;

		// Token: 0x0400036A RID: 874
		private IntPtr id_tryReceive_x45_PtdJZtk;
	}
}
