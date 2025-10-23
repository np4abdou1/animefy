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
	// Token: 0x020000CC RID: 204
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ActorScope", DoNotGenerateAcw = true)]
	internal class IActorScopeInvoker : Java.Lang.Object, IActorScope, ICoroutineScope, IJavaObject, IDisposable, IJavaPeerable, IReceiveChannel
	{
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00021B88 File Offset: 0x0001FD88
		private static IntPtr java_class_ref
		{
			get
			{
				return IActorScopeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00021BAC File Offset: 0x0001FDAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IActorScopeInvoker._members;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00021BB3 File Offset: 0x0001FDB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00021BBB File Offset: 0x0001FDBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IActorScopeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00021BC7 File Offset: 0x0001FDC7
		[NullableContext(2)]
		public static IActorScope GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IActorScope>(handle, transfer);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IActorScopeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.channels.ActorScope'.");
			}
			return handle;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00021BFB File Offset: 0x0001FDFB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00021C2C File Offset: 0x0001FE2C
		public IActorScopeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IActorScopeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00021C64 File Offset: 0x0001FE64
		private static Delegate GetGetChannelHandler()
		{
			if (IActorScopeInvoker.cb_getChannel == null)
			{
				IActorScopeInvoker.cb_getChannel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_GetChannel));
			}
			return IActorScopeInvoker.cb_getChannel;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00021C88 File Offset: 0x0001FE88
		private static IntPtr n_GetChannel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Channel);
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00021C9C File Offset: 0x0001FE9C
		public IChannel Channel
		{
			get
			{
				if (this.id_getChannel == IntPtr.Zero)
				{
					this.id_getChannel = JNIEnv.GetMethodID(this.class_ref, "getChannel", "()Lkotlinx/coroutines/channels/Channel;");
				}
				return Java.Lang.Object.GetObject<IChannel>(JNIEnv.CallObjectMethod(base.Handle, this.id_getChannel), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00021CED File Offset: 0x0001FEED
		private static Delegate GetGetCoroutineContextHandler()
		{
			if (IActorScopeInvoker.cb_getCoroutineContext == null)
			{
				IActorScopeInvoker.cb_getCoroutineContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_GetCoroutineContext));
			}
			return IActorScopeInvoker.cb_getCoroutineContext;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00021D11 File Offset: 0x0001FF11
		private static IntPtr n_GetCoroutineContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CoroutineContext);
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00021D28 File Offset: 0x0001FF28
		public ICoroutineContext CoroutineContext
		{
			get
			{
				if (this.id_getCoroutineContext == IntPtr.Zero)
				{
					this.id_getCoroutineContext = JNIEnv.GetMethodID(this.class_ref, "getCoroutineContext", "()Lkotlin/coroutines/CoroutineContext;");
				}
				return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCoroutineContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00021D79 File Offset: 0x0001FF79
		private static Delegate GetIsClosedForReceiveHandler()
		{
			if (IActorScopeInvoker.cb_isClosedForReceive == null)
			{
				IActorScopeInvoker.cb_isClosedForReceive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IActorScopeInvoker.n_IsClosedForReceive));
			}
			return IActorScopeInvoker.cb_isClosedForReceive;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00021D9D File Offset: 0x0001FF9D
		private static bool n_IsClosedForReceive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosedForReceive;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00021DAC File Offset: 0x0001FFAC
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

		// Token: 0x06000934 RID: 2356 RVA: 0x00021DEC File Offset: 0x0001FFEC
		private static Delegate GetIsEmptyHandler()
		{
			if (IActorScopeInvoker.cb_isEmpty == null)
			{
				IActorScopeInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IActorScopeInvoker.n_IsEmpty));
			}
			return IActorScopeInvoker.cb_isEmpty;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00021E10 File Offset: 0x00020010
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00021E1F File Offset: 0x0002001F
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

		// Token: 0x06000937 RID: 2359 RVA: 0x00021E5F File Offset: 0x0002005F
		private static Delegate GetGetOnReceiveHandler()
		{
			if (IActorScopeInvoker.cb_getOnReceive == null)
			{
				IActorScopeInvoker.cb_getOnReceive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_GetOnReceive));
			}
			return IActorScopeInvoker.cb_getOnReceive;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00021E83 File Offset: 0x00020083
		private static IntPtr n_GetOnReceive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceive);
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00021E98 File Offset: 0x00020098
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

		// Token: 0x0600093A RID: 2362 RVA: 0x00021EE9 File Offset: 0x000200E9
		private static Delegate GetGetOnReceiveCatchingHandler()
		{
			if (IActorScopeInvoker.cb_getOnReceiveCatching == null)
			{
				IActorScopeInvoker.cb_getOnReceiveCatching = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_GetOnReceiveCatching));
			}
			return IActorScopeInvoker.cb_getOnReceiveCatching;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00021F0D File Offset: 0x0002010D
		private static IntPtr n_GetOnReceiveCatching(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceiveCatching);
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00021F24 File Offset: 0x00020124
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

		// Token: 0x0600093D RID: 2365 RVA: 0x00021F75 File Offset: 0x00020175
		[Obsolete]
		private static Delegate GetGetOnReceiveOrNullHandler()
		{
			if (IActorScopeInvoker.cb_getOnReceiveOrNull == null)
			{
				IActorScopeInvoker.cb_getOnReceiveOrNull = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_GetOnReceiveOrNull));
			}
			return IActorScopeInvoker.cb_getOnReceiveOrNull;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00021F99 File Offset: 0x00020199
		[Obsolete]
		private static IntPtr n_GetOnReceiveOrNull(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReceiveOrNull);
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00021FB0 File Offset: 0x000201B0
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

		// Token: 0x06000940 RID: 2368 RVA: 0x00022001 File Offset: 0x00020201
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IActorScopeInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IActorScopeInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IActorScopeInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IActorScopeInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00022028 File Offset: 0x00020228
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002204C File Offset: 0x0002024C
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

		// Token: 0x06000943 RID: 2371 RVA: 0x000220BF File Offset: 0x000202BF
		private static Delegate GetIteratorHandler()
		{
			if (IActorScopeInvoker.cb_iterator == null)
			{
				IActorScopeInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_Iterator));
			}
			return IActorScopeInvoker.cb_iterator;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000220E3 File Offset: 0x000202E3
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000220F8 File Offset: 0x000202F8
		public IChannelIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Lkotlinx/coroutines/channels/ChannelIterator;");
			}
			return Java.Lang.Object.GetObject<IChannelIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00022149 File Offset: 0x00020349
		[Obsolete]
		private static Delegate GetPollHandler()
		{
			if (IActorScopeInvoker.cb_poll == null)
			{
				IActorScopeInvoker.cb_poll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_Poll));
			}
			return IActorScopeInvoker.cb_poll;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0002216D File Offset: 0x0002036D
		[Obsolete]
		private static IntPtr n_Poll(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Poll());
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00022184 File Offset: 0x00020384
		[NullableContext(2)]
		public Java.Lang.Object Poll()
		{
			if (this.id_poll == IntPtr.Zero)
			{
				this.id_poll = JNIEnv.GetMethodID(this.class_ref, "poll", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000221D5 File Offset: 0x000203D5
		private static Delegate GetReceive_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IActorScopeInvoker.cb_receive_Lkotlin_coroutines_Continuation_ == null)
			{
				IActorScopeInvoker.cb_receive_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IActorScopeInvoker.n_Receive_Lkotlin_coroutines_Continuation_));
			}
			return IActorScopeInvoker.cb_receive_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000221FC File Offset: 0x000203FC
		private static IntPtr n_Receive_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Receive(object2));
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00022224 File Offset: 0x00020424
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

		// Token: 0x0600094C RID: 2380 RVA: 0x000222A2 File Offset: 0x000204A2
		private static Delegate GetReceiveCatching_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IActorScopeInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ == null)
			{
				IActorScopeInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IActorScopeInvoker.n_ReceiveCatching_Lkotlin_coroutines_Continuation_));
			}
			return IActorScopeInvoker.cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000222C8 File Offset: 0x000204C8
		private static IntPtr n_ReceiveCatching_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ReceiveCatching(object2));
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000222F0 File Offset: 0x000204F0
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

		// Token: 0x0600094F RID: 2383 RVA: 0x0002236E File Offset: 0x0002056E
		[Obsolete]
		private static Delegate GetReceiveOrNull_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IActorScopeInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_ == null)
			{
				IActorScopeInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IActorScopeInvoker.n_ReceiveOrNull_Lkotlin_coroutines_Continuation_));
			}
			return IActorScopeInvoker.cb_receiveOrNull_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00022394 File Offset: 0x00020594
		[Obsolete]
		private static IntPtr n_ReceiveOrNull_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IReceiveChannel @object = Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ReceiveOrNull(object2));
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000223BC File Offset: 0x000205BC
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

		// Token: 0x06000952 RID: 2386 RVA: 0x0002243A File Offset: 0x0002063A
		private static Delegate GetTryReceiveHandler()
		{
			if (IActorScopeInvoker.cb_tryReceive_x45_PtdJZtk == null)
			{
				IActorScopeInvoker.cb_tryReceive_x45_PtdJZtk = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IActorScopeInvoker.n_TryReceive));
			}
			return IActorScopeInvoker.cb_tryReceive_x45_PtdJZtk;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0002245E File Offset: 0x0002065E
		private static IntPtr n_TryReceive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IActorScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TryReceive());
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00022474 File Offset: 0x00020674
		public Java.Lang.Object TryReceive()
		{
			if (this.id_tryReceive_x45_PtdJZtk == IntPtr.Zero)
			{
				this.id_tryReceive_x45_PtdJZtk = JNIEnv.GetMethodID(this.class_ref, "tryReceive-PtdJZtk", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_tryReceive_x45_PtdJZtk), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002CA RID: 714
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ActorScope", typeof(IActorScopeInvoker));

		// Token: 0x040002CB RID: 715
		private IntPtr class_ref;

		// Token: 0x040002CC RID: 716
		[Nullable(2)]
		private static Delegate cb_getChannel;

		// Token: 0x040002CD RID: 717
		private IntPtr id_getChannel;

		// Token: 0x040002CE RID: 718
		[Nullable(2)]
		private static Delegate cb_getCoroutineContext;

		// Token: 0x040002CF RID: 719
		private IntPtr id_getCoroutineContext;

		// Token: 0x040002D0 RID: 720
		[Nullable(2)]
		private static Delegate cb_isClosedForReceive;

		// Token: 0x040002D1 RID: 721
		private IntPtr id_isClosedForReceive;

		// Token: 0x040002D2 RID: 722
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x040002D3 RID: 723
		private IntPtr id_isEmpty;

		// Token: 0x040002D4 RID: 724
		[Nullable(2)]
		private static Delegate cb_getOnReceive;

		// Token: 0x040002D5 RID: 725
		private IntPtr id_getOnReceive;

		// Token: 0x040002D6 RID: 726
		[Nullable(2)]
		private static Delegate cb_getOnReceiveCatching;

		// Token: 0x040002D7 RID: 727
		private IntPtr id_getOnReceiveCatching;

		// Token: 0x040002D8 RID: 728
		[Nullable(2)]
		private static Delegate cb_getOnReceiveOrNull;

		// Token: 0x040002D9 RID: 729
		private IntPtr id_getOnReceiveOrNull;

		// Token: 0x040002DA RID: 730
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040002DB RID: 731
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040002DC RID: 732
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x040002DD RID: 733
		private IntPtr id_iterator;

		// Token: 0x040002DE RID: 734
		[Nullable(2)]
		private static Delegate cb_poll;

		// Token: 0x040002DF RID: 735
		private IntPtr id_poll;

		// Token: 0x040002E0 RID: 736
		[Nullable(2)]
		private static Delegate cb_receive_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002E1 RID: 737
		private IntPtr id_receive_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002E2 RID: 738
		[Nullable(2)]
		private static Delegate cb_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002E3 RID: 739
		private IntPtr id_receiveCatching_x45_JP2dKIU_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002E4 RID: 740
		[Nullable(2)]
		private static Delegate cb_receiveOrNull_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002E5 RID: 741
		private IntPtr id_receiveOrNull_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002E6 RID: 742
		[Nullable(2)]
		private static Delegate cb_tryReceive_x45_PtdJZtk;

		// Token: 0x040002E7 RID: 743
		private IntPtr id_tryReceive_x45_PtdJZtk;
	}
}
