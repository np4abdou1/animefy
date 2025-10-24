using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000DB RID: 219
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ProducerScope", DoNotGenerateAcw = true)]
	internal class IProducerScopeInvoker : Java.Lang.Object, IProducerScope, ICoroutineScope, IJavaObject, IDisposable, IJavaPeerable, ISendChannel
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00024214 File Offset: 0x00022414
		private static IntPtr java_class_ref
		{
			get
			{
				return IProducerScopeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00024238 File Offset: 0x00022438
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IProducerScopeInvoker._members;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0002423F File Offset: 0x0002243F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00024247 File Offset: 0x00022447
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IProducerScopeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00024253 File Offset: 0x00022453
		[NullableContext(2)]
		public static IProducerScope GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IProducerScope>(handle, transfer);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002425C File Offset: 0x0002245C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IProducerScopeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.channels.ProducerScope'.");
			}
			return handle;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00024287 File Offset: 0x00022487
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000242B8 File Offset: 0x000224B8
		public IProducerScopeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IProducerScopeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000242F0 File Offset: 0x000224F0
		private static Delegate GetGetChannelHandler()
		{
			if (IProducerScopeInvoker.cb_getChannel == null)
			{
				IProducerScopeInvoker.cb_getChannel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IProducerScopeInvoker.n_GetChannel));
			}
			return IProducerScopeInvoker.cb_getChannel;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00024314 File Offset: 0x00022514
		private static IntPtr n_GetChannel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Channel);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00024328 File Offset: 0x00022528
		public ISendChannel Channel
		{
			get
			{
				if (this.id_getChannel == IntPtr.Zero)
				{
					this.id_getChannel = JNIEnv.GetMethodID(this.class_ref, "getChannel", "()Lkotlinx/coroutines/channels/SendChannel;");
				}
				return Java.Lang.Object.GetObject<ISendChannel>(JNIEnv.CallObjectMethod(base.Handle, this.id_getChannel), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00024379 File Offset: 0x00022579
		private static Delegate GetGetCoroutineContextHandler()
		{
			if (IProducerScopeInvoker.cb_getCoroutineContext == null)
			{
				IProducerScopeInvoker.cb_getCoroutineContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IProducerScopeInvoker.n_GetCoroutineContext));
			}
			return IProducerScopeInvoker.cb_getCoroutineContext;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002439D File Offset: 0x0002259D
		private static IntPtr n_GetCoroutineContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CoroutineContext);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000243B4 File Offset: 0x000225B4
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

		// Token: 0x06000A08 RID: 2568 RVA: 0x00024405 File Offset: 0x00022605
		private static Delegate GetIsClosedForSendHandler()
		{
			if (IProducerScopeInvoker.cb_isClosedForSend == null)
			{
				IProducerScopeInvoker.cb_isClosedForSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IProducerScopeInvoker.n_IsClosedForSend));
			}
			return IProducerScopeInvoker.cb_isClosedForSend;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00024429 File Offset: 0x00022629
		private static bool n_IsClosedForSend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosedForSend;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00024438 File Offset: 0x00022638
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

		// Token: 0x06000A0B RID: 2571 RVA: 0x00024478 File Offset: 0x00022678
		private static Delegate GetGetOnSendHandler()
		{
			if (IProducerScopeInvoker.cb_getOnSend == null)
			{
				IProducerScopeInvoker.cb_getOnSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IProducerScopeInvoker.n_GetOnSend));
			}
			return IProducerScopeInvoker.cb_getOnSend;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002449C File Offset: 0x0002269C
		private static IntPtr n_GetOnSend(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSend);
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x000244B0 File Offset: 0x000226B0
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

		// Token: 0x06000A0E RID: 2574 RVA: 0x00024501 File Offset: 0x00022701
		private static Delegate GetClose_Ljava_lang_Throwable_Handler()
		{
			if (IProducerScopeInvoker.cb_close_Ljava_lang_Throwable_ == null)
			{
				IProducerScopeInvoker.cb_close_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IProducerScopeInvoker.n_Close_Ljava_lang_Throwable_));
			}
			return IProducerScopeInvoker.cb_close_Ljava_lang_Throwable_;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00024528 File Offset: 0x00022728
		private static bool n_Close_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			return @object.Close(object2);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002454C File Offset: 0x0002274C
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

		// Token: 0x06000A11 RID: 2577 RVA: 0x000245BF File Offset: 0x000227BF
		private static Delegate GetInvokeOnClose_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (IProducerScopeInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ == null)
			{
				IProducerScopeInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IProducerScopeInvoker.n_InvokeOnClose_Lkotlin_jvm_functions_Function1_));
			}
			return IProducerScopeInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000245E4 File Offset: 0x000227E4
		private static void n_InvokeOnClose_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			@object.InvokeOnClose(object2);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00024608 File Offset: 0x00022808
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

		// Token: 0x06000A14 RID: 2580 RVA: 0x00024680 File Offset: 0x00022880
		[Obsolete]
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (IProducerScopeInvoker.cb_offer_Ljava_lang_Object_ == null)
			{
				IProducerScopeInvoker.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IProducerScopeInvoker.n_Offer_Ljava_lang_Object_));
			}
			return IProducerScopeInvoker.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000246A4 File Offset: 0x000228A4
		[Obsolete]
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000246C8 File Offset: 0x000228C8
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

		// Token: 0x06000A17 RID: 2583 RVA: 0x00024739 File Offset: 0x00022939
		private static Delegate GetSend_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IProducerScopeInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				IProducerScopeInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IProducerScopeInvoker.n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return IProducerScopeInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00024760 File Offset: 0x00022960
		private static IntPtr n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_element, IntPtr native_p1)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Send(object2, object3));
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00024794 File Offset: 0x00022994
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

		// Token: 0x06000A1A RID: 2586 RVA: 0x00024832 File Offset: 0x00022A32
		private static Delegate GetTrySend_Ljava_lang_Object_Handler()
		{
			if (IProducerScopeInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ == null)
			{
				IProducerScopeInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IProducerScopeInvoker.n_TrySend_Ljava_lang_Object_));
			}
			return IProducerScopeInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00024858 File Offset: 0x00022A58
		private static IntPtr n_TrySend_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<IProducerScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TrySend(object2));
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00024880 File Offset: 0x00022A80
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

		// Token: 0x0400033C RID: 828
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ProducerScope", typeof(IProducerScopeInvoker));

		// Token: 0x0400033D RID: 829
		private IntPtr class_ref;

		// Token: 0x0400033E RID: 830
		[Nullable(2)]
		private static Delegate cb_getChannel;

		// Token: 0x0400033F RID: 831
		private IntPtr id_getChannel;

		// Token: 0x04000340 RID: 832
		[Nullable(2)]
		private static Delegate cb_getCoroutineContext;

		// Token: 0x04000341 RID: 833
		private IntPtr id_getCoroutineContext;

		// Token: 0x04000342 RID: 834
		[Nullable(2)]
		private static Delegate cb_isClosedForSend;

		// Token: 0x04000343 RID: 835
		private IntPtr id_isClosedForSend;

		// Token: 0x04000344 RID: 836
		[Nullable(2)]
		private static Delegate cb_getOnSend;

		// Token: 0x04000345 RID: 837
		private IntPtr id_getOnSend;

		// Token: 0x04000346 RID: 838
		[Nullable(2)]
		private static Delegate cb_close_Ljava_lang_Throwable_;

		// Token: 0x04000347 RID: 839
		private IntPtr id_close_Ljava_lang_Throwable_;

		// Token: 0x04000348 RID: 840
		[Nullable(2)]
		private static Delegate cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000349 RID: 841
		private IntPtr id_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x0400034A RID: 842
		[Nullable(2)]
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x0400034B RID: 843
		private IntPtr id_offer_Ljava_lang_Object_;

		// Token: 0x0400034C RID: 844
		[Nullable(2)]
		private static Delegate cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400034D RID: 845
		private IntPtr id_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400034E RID: 846
		[Nullable(2)]
		private static Delegate cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;

		// Token: 0x0400034F RID: 847
		private IntPtr id_trySend_x45_JP2dKIU_Ljava_lang_Object_;
	}
}
