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
	// Token: 0x020000E1 RID: 225
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/SendChannel", DoNotGenerateAcw = true)]
	internal class ISendChannelInvoker : Java.Lang.Object, ISendChannel, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00025484 File Offset: 0x00023684
		private static IntPtr java_class_ref
		{
			get
			{
				return ISendChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000254A8 File Offset: 0x000236A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISendChannelInvoker._members;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x000254AF File Offset: 0x000236AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x000254B7 File Offset: 0x000236B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISendChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000254C3 File Offset: 0x000236C3
		[NullableContext(2)]
		public static ISendChannel GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISendChannel>(handle, transfer);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x000254CC File Offset: 0x000236CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISendChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.channels.SendChannel'.");
			}
			return handle;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000254F7 File Offset: 0x000236F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00025528 File Offset: 0x00023728
		public ISendChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISendChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00025560 File Offset: 0x00023760
		private static Delegate GetIsClosedForSendHandler()
		{
			if (ISendChannelInvoker.cb_isClosedForSend == null)
			{
				ISendChannelInvoker.cb_isClosedForSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISendChannelInvoker.n_IsClosedForSend));
			}
			return ISendChannelInvoker.cb_isClosedForSend;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00025584 File Offset: 0x00023784
		private static bool n_IsClosedForSend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISendChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsClosedForSend;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00025593 File Offset: 0x00023793
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

		// Token: 0x06000A79 RID: 2681 RVA: 0x000255D3 File Offset: 0x000237D3
		private static Delegate GetGetOnSendHandler()
		{
			if (ISendChannelInvoker.cb_getOnSend == null)
			{
				ISendChannelInvoker.cb_getOnSend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISendChannelInvoker.n_GetOnSend));
			}
			return ISendChannelInvoker.cb_getOnSend;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000255F7 File Offset: 0x000237F7
		private static IntPtr n_GetOnSend(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISendChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSend);
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0002560C File Offset: 0x0002380C
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

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002565D File Offset: 0x0002385D
		private static Delegate GetClose_Ljava_lang_Throwable_Handler()
		{
			if (ISendChannelInvoker.cb_close_Ljava_lang_Throwable_ == null)
			{
				ISendChannelInvoker.cb_close_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISendChannelInvoker.n_Close_Ljava_lang_Throwable_));
			}
			return ISendChannelInvoker.cb_close_Ljava_lang_Throwable_;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00025684 File Offset: 0x00023884
		private static bool n_Close_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<ISendChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			return @object.Close(object2);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000256A8 File Offset: 0x000238A8
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

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002571B File Offset: 0x0002391B
		private static Delegate GetInvokeOnClose_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (ISendChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ == null)
			{
				ISendChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISendChannelInvoker.n_InvokeOnClose_Lkotlin_jvm_functions_Function1_));
			}
			return ISendChannelInvoker.cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00025740 File Offset: 0x00023940
		private static void n_InvokeOnClose_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<ISendChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			@object.InvokeOnClose(object2);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00025764 File Offset: 0x00023964
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

		// Token: 0x06000A82 RID: 2690 RVA: 0x000257DC File Offset: 0x000239DC
		[Obsolete]
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (ISendChannelInvoker.cb_offer_Ljava_lang_Object_ == null)
			{
				ISendChannelInvoker.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISendChannelInvoker.n_Offer_Ljava_lang_Object_));
			}
			return ISendChannelInvoker.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00025800 File Offset: 0x00023A00
		[Obsolete]
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<ISendChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00025824 File Offset: 0x00023A24
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

		// Token: 0x06000A85 RID: 2693 RVA: 0x00025895 File Offset: 0x00023A95
		private static Delegate GetSend_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (ISendChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				ISendChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ISendChannelInvoker.n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return ISendChannelInvoker.cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000258BC File Offset: 0x00023ABC
		private static IntPtr n_Send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_element, IntPtr native_p1)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<ISendChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Send(object2, object3));
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000258F0 File Offset: 0x00023AF0
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

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002598E File Offset: 0x00023B8E
		private static Delegate GetTrySend_Ljava_lang_Object_Handler()
		{
			if (ISendChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ == null)
			{
				ISendChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISendChannelInvoker.n_TrySend_Ljava_lang_Object_));
			}
			return ISendChannelInvoker.cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000259B4 File Offset: 0x00023BB4
		private static IntPtr n_TrySend_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			ISendChannel @object = Java.Lang.Object.GetObject<ISendChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TrySend(object2));
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000259DC File Offset: 0x00023BDC
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

		// Token: 0x0400036C RID: 876
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/SendChannel", typeof(ISendChannelInvoker));

		// Token: 0x0400036D RID: 877
		private IntPtr class_ref;

		// Token: 0x0400036E RID: 878
		[Nullable(2)]
		private static Delegate cb_isClosedForSend;

		// Token: 0x0400036F RID: 879
		private IntPtr id_isClosedForSend;

		// Token: 0x04000370 RID: 880
		[Nullable(2)]
		private static Delegate cb_getOnSend;

		// Token: 0x04000371 RID: 881
		private IntPtr id_getOnSend;

		// Token: 0x04000372 RID: 882
		[Nullable(2)]
		private static Delegate cb_close_Ljava_lang_Throwable_;

		// Token: 0x04000373 RID: 883
		private IntPtr id_close_Ljava_lang_Throwable_;

		// Token: 0x04000374 RID: 884
		[Nullable(2)]
		private static Delegate cb_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000375 RID: 885
		private IntPtr id_invokeOnClose_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000376 RID: 886
		[Nullable(2)]
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x04000377 RID: 887
		private IntPtr id_offer_Ljava_lang_Object_;

		// Token: 0x04000378 RID: 888
		[Nullable(2)]
		private static Delegate cb_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000379 RID: 889
		private IntPtr id_send_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400037A RID: 890
		[Nullable(2)]
		private static Delegate cb_trySend_x45_JP2dKIU_Ljava_lang_Object_;

		// Token: 0x0400037B RID: 891
		private IntPtr id_trySend_x45_JP2dKIU_Ljava_lang_Object_;
	}
}
