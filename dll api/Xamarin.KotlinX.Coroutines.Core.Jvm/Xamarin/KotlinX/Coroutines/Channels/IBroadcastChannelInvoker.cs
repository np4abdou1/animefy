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
	// Token: 0x020000CF RID: 207
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/BroadcastChannel", DoNotGenerateAcw = true)]
	internal class IBroadcastChannelInvoker : Java.Lang.Object, IBroadcastChannel, ISendChannel, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x000225F4 File Offset: 0x000207F4
		private static IntPtr java_class_ref
		{
			get
			{
				return IBroadcastChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00022618 File Offset: 0x00020818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBroadcastChannelInvoker._members;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0002261F File Offset: 0x0002081F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00022627 File Offset: 0x00020827
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBroadcastChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00022633 File Offset: 0x00020833
		[NullableContext(2)]
		public static IBroadcastChannel GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBroadcastChannel>(handle, transfer);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0002263C File Offset: 0x0002083C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBroadcastChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.channels.BroadcastChannel'.");
			}
			return handle;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00022667 File Offset: 0x00020867
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00022698 File Offset: 0x00020898
		public IBroadcastChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBroadcastChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000226D0 File Offset: 0x000208D0
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IBroadcastChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IBroadcastChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IBroadcastChannelInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IBroadcastChannelInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000226F4 File Offset: 0x000208F4
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IBroadcastChannel @object = Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00022718 File Offset: 0x00020918
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

		// Token: 0x0600096A RID: 2410 RVA: 0x0002278B File Offset: 0x0002098B
		private static Delegate GetOpenSubscriptionHandler()
		{
			if (IBroadcastChannelInvoker.cb_openSubscription == null)
			{
				IBroadcastChannelInvoker.cb_openSubscription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBroadcastChannelInvoker.n_OpenSubscription));
			}
			return IBroadcastChannelInvoker.cb_openSubscription;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000227AF File Offset: 0x000209AF
		private static IntPtr n_OpenSubscription(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenSubscription());
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000227C4 File Offset: 0x000209C4
		public IReceiveChannel OpenSubscription()
		{
			if (this.id_openSubscription == IntPtr.Zero)
			{
				this.id_openSubscription = JNIEnv.GetMethodID(this.class_ref, "openSubscription", "()Lkotlinx/coroutines/channels/ReceiveChannel;");
			}
			return Java.Lang.Object.GetObject<IReceiveChannel>(JNIEnv.CallObjectMethod(base.Handle, this.id_openSubscription), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00022815 File Offset: 0x00020A15
		private static Delegate GetIsClosedForSendHandler()
		{
			if (IBroadcastChannelInvoker.cb_isClosedForSend == null)
			{
				IBroadcastChannelInvoker.cb_isClosedForSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBroadcastChannelInvoker.n_IsClosedForSend));
			}
			return IBroadcastChannelInvoker.cb_isClosedForSend;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00022839 File Offset: 0x00020A39
		private static bool n_IsClosedForSend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosedForSend;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00022848 File Offset: 0x00020A48
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

		// Token: 0x06000970 RID: 2416 RVA: 0x00022888 File Offset: 0x00020A88
		private static Delegate GetGetOnSendHandler()
		{
			if (IBroadcastChannelInvoker.cb_getOnSend == null)
			{
				IBroadcastChannelInvoker.cb_getOnSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBroadcastChannelInvoker.n_GetOnSend));
			}
			return IBroadcastChannelInvoker.cb_getOnSend;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000228AC File Offset: 0x00020AAC
		private static IntPtr n_GetOnSend(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSend);
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x000228C0 File Offset: 0x00020AC0
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

		// Token: 0x06000973 RID: 2419 RVA: 0x00022911 File Offset: 0x00020B11
		private static Delegate GetClose_Ljava_lang_Throwable_Handler()
		{
			if (IBroadcastChannelInvoker.cb_close_Ljava_lang_Throwable_ == null)
			{
				IBroadcastChannelInvoker.cb_close_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBroadcastChannelInvoker.n_Close_Ljava_lang_Throwable_));
			}
			return IBroadcastChannelInvoker.cb_close_Ljava_lang_Throwable_;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00022938 File Offset: 0x00020B38
		private static bool n_Close_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			return @object.Close(object2);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0002295C File Offset: 0x00020B5C
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

		// Token: 0x06000976 RID: 2422 RVA: 0x000229CF File Offset: 0x00020BCF
		private static Delegate GetInvokeOnClose_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (IBroadcastChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ == null)
			{
				IBroadcastChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IBroadcastChannelInvoker.n_InvokeOnClose_Lkotlin_jvm_functions_Function1_));
			}
			return IBroadcastChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000229F4 File Offset: 0x00020BF4
		private static void n_InvokeOnClose_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			@object.InvokeOnClose(object2);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00022A18 File Offset: 0x00020C18
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

		// Token: 0x06000979 RID: 2425 RVA: 0x00022A90 File Offset: 0x00020C90
		[Obsolete]
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (IBroadcastChannelInvoker.cb_offer_Ljava_lang_Object_ == null)
			{
				IBroadcastChannelInvoker.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBroadcastChannelInvoker.n_Offer_Ljava_lang_Object_));
			}
			return IBroadcastChannelInvoker.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00022AB4 File Offset: 0x00020CB4
		[Obsolete]
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00022AD8 File Offset: 0x00020CD8
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

		// Token: 0x0600097C RID: 2428 RVA: 0x00022B49 File Offset: 0x00020D49
		private static Delegate GetSend_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IBroadcastChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				IBroadcastChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IBroadcastChannelInvoker.n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return IBroadcastChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00022B70 File Offset: 0x00020D70
		private static IntPtr n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_element, IntPtr native_p1)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Send(object2, object3));
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00022BA4 File Offset: 0x00020DA4
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

		// Token: 0x0600097F RID: 2431 RVA: 0x00022C42 File Offset: 0x00020E42
		private static Delegate GetTrySend_Ljava_lang_Object_Handler()
		{
			if (IBroadcastChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ == null)
			{
				IBroadcastChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBroadcastChannelInvoker.n_TrySend_Ljava_lang_Object_));
			}
			return IBroadcastChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00022C68 File Offset: 0x00020E68
		private static IntPtr n_TrySend_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IBroadcastChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TrySend(object2));
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00022C90 File Offset: 0x00020E90
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

		// Token: 0x040002E9 RID: 745
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/BroadcastChannel", typeof(IBroadcastChannelInvoker));

		// Token: 0x040002EA RID: 746
		private IntPtr class_ref;

		// Token: 0x040002EB RID: 747
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040002EC RID: 748
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040002ED RID: 749
		[Nullable(2)]
		private static Delegate cb_openSubscription;

		// Token: 0x040002EE RID: 750
		private IntPtr id_openSubscription;

		// Token: 0x040002EF RID: 751
		[Nullable(2)]
		private static Delegate cb_isClosedForSend;

		// Token: 0x040002F0 RID: 752
		private IntPtr id_isClosedForSend;

		// Token: 0x040002F1 RID: 753
		[Nullable(2)]
		private static Delegate cb_getOnSend;

		// Token: 0x040002F2 RID: 754
		private IntPtr id_getOnSend;

		// Token: 0x040002F3 RID: 755
		[Nullable(2)]
		private static Delegate cb_close_Ljava_lang_Throwable_;

		// Token: 0x040002F4 RID: 756
		private IntPtr id_close_Ljava_lang_Throwable_;

		// Token: 0x040002F5 RID: 757
		[Nullable(2)]
		private static Delegate cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040002F6 RID: 758
		private IntPtr id_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040002F7 RID: 759
		[Nullable(2)]
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x040002F8 RID: 760
		private IntPtr id_offer_Ljava_lang_Object_;

		// Token: 0x040002F9 RID: 761
		[Nullable(2)]
		private static Delegate cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002FA RID: 762
		private IntPtr id_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002FB RID: 763
		[Nullable(2)]
		private static Delegate cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;

		// Token: 0x040002FC RID: 764
		private IntPtr id_trySend_x45_JP2dKIU_Ljava_lang_Object_;
	}
}
