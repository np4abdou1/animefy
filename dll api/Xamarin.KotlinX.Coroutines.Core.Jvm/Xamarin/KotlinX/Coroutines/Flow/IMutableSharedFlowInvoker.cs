using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000AE RID: 174
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/MutableSharedFlow", DoNotGenerateAcw = true)]
	internal class IMutableSharedFlowInvoker : Java.Lang.Object, IMutableSharedFlow, IFlowCollector, IJavaObject, IDisposable, IJavaPeerable, ISharedFlow, IFlow
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0001D734 File Offset: 0x0001B934
		private static IntPtr java_class_ref
		{
			get
			{
				return IMutableSharedFlowInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0001D758 File Offset: 0x0001B958
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMutableSharedFlowInvoker._members;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0001D75F File Offset: 0x0001B95F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0001D767 File Offset: 0x0001B967
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMutableSharedFlowInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0001D773 File Offset: 0x0001B973
		[NullableContext(2)]
		public static IMutableSharedFlow GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMutableSharedFlow>(handle, transfer);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0001D77C File Offset: 0x0001B97C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMutableSharedFlowInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.flow.MutableSharedFlow'.");
			}
			return handle;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0001D7A7 File Offset: 0x0001B9A7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		public IMutableSharedFlowInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMutableSharedFlowInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0001D810 File Offset: 0x0001BA10
		private static Delegate GetGetSubscriptionCountHandler()
		{
			if (IMutableSharedFlowInvoker.cb_getSubscriptionCount == null)
			{
				IMutableSharedFlowInvoker.cb_getSubscriptionCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMutableSharedFlowInvoker.n_GetSubscriptionCount));
			}
			return IMutableSharedFlowInvoker.cb_getSubscriptionCount;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0001D834 File Offset: 0x0001BA34
		private static IntPtr n_GetSubscriptionCount(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMutableSharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubscriptionCount);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0001D848 File Offset: 0x0001BA48
		public IStateFlow SubscriptionCount
		{
			get
			{
				if (this.id_getSubscriptionCount == IntPtr.Zero)
				{
					this.id_getSubscriptionCount = JNIEnv.GetMethodID(this.class_ref, "getSubscriptionCount", "()Lkotlinx/coroutines/flow/StateFlow;");
				}
				return Java.Lang.Object.GetObject<IStateFlow>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSubscriptionCount), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0001D899 File Offset: 0x0001BA99
		private static Delegate GetEmit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IMutableSharedFlowInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				IMutableSharedFlowInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMutableSharedFlowInvoker.n_Emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return IMutableSharedFlowInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
		private static IntPtr n_Emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_p1)
		{
			IMutableSharedFlow @object = Java.Lang.Object.GetObject<IMutableSharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Emit(object2, object3));
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		[NullableContext(2)]
		public unsafe Java.Lang.Object Emit(Java.Lang.Object value, [Nullable(1)] IContinuation p1)
		{
			if (this.id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "emit", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0001D992 File Offset: 0x0001BB92
		private static Delegate GetResetReplayCacheHandler()
		{
			if (IMutableSharedFlowInvoker.cb_resetReplayCache == null)
			{
				IMutableSharedFlowInvoker.cb_resetReplayCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMutableSharedFlowInvoker.n_ResetReplayCache));
			}
			return IMutableSharedFlowInvoker.cb_resetReplayCache;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0001D9B6 File Offset: 0x0001BBB6
		private static void n_ResetReplayCache(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMutableSharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetReplayCache();
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0001D9C5 File Offset: 0x0001BBC5
		public void ResetReplayCache()
		{
			if (this.id_resetReplayCache == IntPtr.Zero)
			{
				this.id_resetReplayCache = JNIEnv.GetMethodID(this.class_ref, "resetReplayCache", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_resetReplayCache);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0001DA05 File Offset: 0x0001BC05
		private static Delegate GetTryEmit_Ljava_lang_Object_Handler()
		{
			if (IMutableSharedFlowInvoker.cb_tryEmit_Ljava_lang_Object_ == null)
			{
				IMutableSharedFlowInvoker.cb_tryEmit_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMutableSharedFlowInvoker.n_TryEmit_Ljava_lang_Object_));
			}
			return IMutableSharedFlowInvoker.cb_tryEmit_Ljava_lang_Object_;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0001DA2C File Offset: 0x0001BC2C
		private static bool n_TryEmit_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IMutableSharedFlow @object = Java.Lang.Object.GetObject<IMutableSharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.TryEmit(object2);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0001DA50 File Offset: 0x0001BC50
		[NullableContext(2)]
		public unsafe bool TryEmit(Java.Lang.Object value)
		{
			if (this.id_tryEmit_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_tryEmit_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "tryEmit", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_tryEmit_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0001DAC1 File Offset: 0x0001BCC1
		private static Delegate GetGetReplayCacheHandler()
		{
			if (IMutableSharedFlowInvoker.cb_getReplayCache == null)
			{
				IMutableSharedFlowInvoker.cb_getReplayCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMutableSharedFlowInvoker.n_GetReplayCache));
			}
			return IMutableSharedFlowInvoker.cb_getReplayCache;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0001DAE5 File Offset: 0x0001BCE5
		private static IntPtr n_GetReplayCache(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<IMutableSharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReplayCache);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0001DAFC File Offset: 0x0001BCFC
		public IList ReplayCache
		{
			get
			{
				if (this.id_getReplayCache == IntPtr.Zero)
				{
					this.id_getReplayCache = JNIEnv.GetMethodID(this.class_ref, "getReplayCache", "()Ljava/util/List;");
				}
				return JavaList.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getReplayCache), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0001DB4D File Offset: 0x0001BD4D
		private static Delegate GetCollect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IMutableSharedFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ == null)
			{
				IMutableSharedFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMutableSharedFlowInvoker.n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_));
			}
			return IMutableSharedFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0001DB74 File Offset: 0x0001BD74
		private static IntPtr n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_collector, IntPtr native_p1)
		{
			ISharedFlow @object = Java.Lang.Object.GetObject<IMutableSharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFlowCollector object2 = Java.Lang.Object.GetObject<IFlowCollector>(native_collector, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Collect(object2, object3));
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Collect(IFlowCollector collector, IContinuation p1)
		{
			if (this.id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "collect", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((collector == null) ? IntPtr.Zero : ((Java.Lang.Object)collector).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000281 RID: 641
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/MutableSharedFlow", typeof(IMutableSharedFlowInvoker));

		// Token: 0x04000282 RID: 642
		private IntPtr class_ref;

		// Token: 0x04000283 RID: 643
		[Nullable(2)]
		private static Delegate cb_getSubscriptionCount;

		// Token: 0x04000284 RID: 644
		private IntPtr id_getSubscriptionCount;

		// Token: 0x04000285 RID: 645
		[Nullable(2)]
		private static Delegate cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000286 RID: 646
		private IntPtr id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000287 RID: 647
		[Nullable(2)]
		private static Delegate cb_resetReplayCache;

		// Token: 0x04000288 RID: 648
		private IntPtr id_resetReplayCache;

		// Token: 0x04000289 RID: 649
		[Nullable(2)]
		private static Delegate cb_tryEmit_Ljava_lang_Object_;

		// Token: 0x0400028A RID: 650
		private IntPtr id_tryEmit_Ljava_lang_Object_;

		// Token: 0x0400028B RID: 651
		[Nullable(2)]
		private static Delegate cb_getReplayCache;

		// Token: 0x0400028C RID: 652
		private IntPtr id_getReplayCache;

		// Token: 0x0400028D RID: 653
		[Nullable(2)]
		private static Delegate cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400028E RID: 654
		private IntPtr id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
	}
}
