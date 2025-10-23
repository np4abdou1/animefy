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
	// Token: 0x020000B0 RID: 176
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/MutableStateFlow", DoNotGenerateAcw = true)]
	internal class IMutableStateFlowInvoker : Java.Lang.Object, IMutableStateFlow, IMutableSharedFlow, IFlowCollector, IJavaObject, IDisposable, IJavaPeerable, ISharedFlow, IFlow, IStateFlow
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0001DC68 File Offset: 0x0001BE68
		private static IntPtr java_class_ref
		{
			get
			{
				return IMutableStateFlowInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0001DC8C File Offset: 0x0001BE8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMutableStateFlowInvoker._members;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0001DC93 File Offset: 0x0001BE93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0001DC9B File Offset: 0x0001BE9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMutableStateFlowInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0001DCA7 File Offset: 0x0001BEA7
		[NullableContext(2)]
		public static IMutableStateFlow GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMutableStateFlow>(handle, transfer);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMutableStateFlowInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.flow.MutableStateFlow'.");
			}
			return handle;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0001DCDB File Offset: 0x0001BEDB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0001DD0C File Offset: 0x0001BF0C
		public IMutableStateFlowInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMutableStateFlowInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0001DD44 File Offset: 0x0001BF44
		private static Delegate GetGetValueHandler()
		{
			if (IMutableStateFlowInvoker.cb_getValue == null)
			{
				IMutableStateFlowInvoker.cb_getValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMutableStateFlowInvoker.n_GetValue));
			}
			return IMutableStateFlowInvoker.cb_getValue;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0001DD68 File Offset: 0x0001BF68
		private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0001DD7C File Offset: 0x0001BF7C
		private static Delegate GetSetValue_Ljava_lang_Object_Handler()
		{
			if (IMutableStateFlowInvoker.cb_setValue_Ljava_lang_Object_ == null)
			{
				IMutableStateFlowInvoker.cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMutableStateFlowInvoker.n_SetValue_Ljava_lang_Object_));
			}
			return IMutableStateFlowInvoker.cb_setValue_Ljava_lang_Object_;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0001DDA0 File Offset: 0x0001BFA0
		private static void n_SetValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IMutableStateFlow @object = Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Value = object2;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x0001DE18 File Offset: 0x0001C018
		[Nullable(2)]
		public unsafe Java.Lang.Object Value
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getValue == IntPtr.Zero)
				{
					this.id_getValue = JNIEnv.GetMethodID(this.class_ref, "getValue", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getValue), JniHandleOwnership.TransferLocalRef);
			}
			[NullableContext(2)]
			set
			{
				if (this.id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "setValue", "(Ljava/lang/Object;)V");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setValue_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0001DE89 File Offset: 0x0001C089
		private static Delegate GetCompareAndSet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IMutableStateFlowInvoker.cb_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IMutableStateFlowInvoker.cb_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IMutableStateFlowInvoker.n_CompareAndSet_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IMutableStateFlowInvoker.cb_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		private static bool n_CompareAndSet_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_expect, IntPtr native_update)
		{
			IMutableStateFlow @object = Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_expect, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_update, JniHandleOwnership.DoNotTransfer);
			return @object.CompareAndSet(object2, object3);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		[NullableContext(2)]
		public unsafe bool CompareAndSet(Java.Lang.Object expect, Java.Lang.Object update)
		{
			if (this.id_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(expect);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(update);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0001DF6D File Offset: 0x0001C16D
		private static Delegate GetGetSubscriptionCountHandler()
		{
			if (IMutableStateFlowInvoker.cb_getSubscriptionCount == null)
			{
				IMutableStateFlowInvoker.cb_getSubscriptionCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMutableStateFlowInvoker.n_GetSubscriptionCount));
			}
			return IMutableStateFlowInvoker.cb_getSubscriptionCount;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0001DF91 File Offset: 0x0001C191
		private static IntPtr n_GetSubscriptionCount(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubscriptionCount);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x0001DFA8 File Offset: 0x0001C1A8
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

		// Token: 0x06000826 RID: 2086 RVA: 0x0001DFF9 File Offset: 0x0001C1F9
		private static Delegate GetEmit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IMutableStateFlowInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				IMutableStateFlowInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMutableStateFlowInvoker.n_Emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return IMutableStateFlowInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0001E020 File Offset: 0x0001C220
		private static IntPtr n_Emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_p1)
		{
			IMutableSharedFlow @object = Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Emit(object2, object3));
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0001E054 File Offset: 0x0001C254
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

		// Token: 0x06000829 RID: 2089 RVA: 0x0001E0F2 File Offset: 0x0001C2F2
		private static Delegate GetResetReplayCacheHandler()
		{
			if (IMutableStateFlowInvoker.cb_resetReplayCache == null)
			{
				IMutableStateFlowInvoker.cb_resetReplayCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMutableStateFlowInvoker.n_ResetReplayCache));
			}
			return IMutableStateFlowInvoker.cb_resetReplayCache;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001E116 File Offset: 0x0001C316
		private static void n_ResetReplayCache(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetReplayCache();
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0001E125 File Offset: 0x0001C325
		public void ResetReplayCache()
		{
			if (this.id_resetReplayCache == IntPtr.Zero)
			{
				this.id_resetReplayCache = JNIEnv.GetMethodID(this.class_ref, "resetReplayCache", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_resetReplayCache);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001E165 File Offset: 0x0001C365
		private static Delegate GetTryEmit_Ljava_lang_Object_Handler()
		{
			if (IMutableStateFlowInvoker.cb_tryEmit_Ljava_lang_Object_ == null)
			{
				IMutableStateFlowInvoker.cb_tryEmit_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMutableStateFlowInvoker.n_TryEmit_Ljava_lang_Object_));
			}
			return IMutableStateFlowInvoker.cb_tryEmit_Ljava_lang_Object_;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0001E18C File Offset: 0x0001C38C
		private static bool n_TryEmit_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IMutableSharedFlow @object = Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.TryEmit(object2);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
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

		// Token: 0x0600082F RID: 2095 RVA: 0x0001E221 File Offset: 0x0001C421
		private static Delegate GetGetReplayCacheHandler()
		{
			if (IMutableStateFlowInvoker.cb_getReplayCache == null)
			{
				IMutableStateFlowInvoker.cb_getReplayCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMutableStateFlowInvoker.n_GetReplayCache));
			}
			return IMutableStateFlowInvoker.cb_getReplayCache;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0001E245 File Offset: 0x0001C445
		private static IntPtr n_GetReplayCache(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReplayCache);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0001E25C File Offset: 0x0001C45C
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

		// Token: 0x06000832 RID: 2098 RVA: 0x0001E2AD File Offset: 0x0001C4AD
		private static Delegate GetCollect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IMutableStateFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ == null)
			{
				IMutableStateFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMutableStateFlowInvoker.n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_));
			}
			return IMutableStateFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001E2D4 File Offset: 0x0001C4D4
		private static IntPtr n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_collector, IntPtr native_p1)
		{
			ISharedFlow @object = Java.Lang.Object.GetObject<IMutableStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFlowCollector object2 = Java.Lang.Object.GetObject<IFlowCollector>(native_collector, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Collect(object2, object3));
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0001E308 File Offset: 0x0001C508
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

		// Token: 0x0400028F RID: 655
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/MutableStateFlow", typeof(IMutableStateFlowInvoker));

		// Token: 0x04000290 RID: 656
		private IntPtr class_ref;

		// Token: 0x04000291 RID: 657
		[Nullable(2)]
		private static Delegate cb_getValue;

		// Token: 0x04000292 RID: 658
		[Nullable(2)]
		private static Delegate cb_setValue_Ljava_lang_Object_;

		// Token: 0x04000293 RID: 659
		private IntPtr id_getValue;

		// Token: 0x04000294 RID: 660
		private IntPtr id_setValue_Ljava_lang_Object_;

		// Token: 0x04000295 RID: 661
		[Nullable(2)]
		private static Delegate cb_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000296 RID: 662
		private IntPtr id_compareAndSet_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000297 RID: 663
		[Nullable(2)]
		private static Delegate cb_getSubscriptionCount;

		// Token: 0x04000298 RID: 664
		private IntPtr id_getSubscriptionCount;

		// Token: 0x04000299 RID: 665
		[Nullable(2)]
		private static Delegate cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400029A RID: 666
		private IntPtr id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400029B RID: 667
		[Nullable(2)]
		private static Delegate cb_resetReplayCache;

		// Token: 0x0400029C RID: 668
		private IntPtr id_resetReplayCache;

		// Token: 0x0400029D RID: 669
		[Nullable(2)]
		private static Delegate cb_tryEmit_Ljava_lang_Object_;

		// Token: 0x0400029E RID: 670
		private IntPtr id_tryEmit_Ljava_lang_Object_;

		// Token: 0x0400029F RID: 671
		[Nullable(2)]
		private static Delegate cb_getReplayCache;

		// Token: 0x040002A0 RID: 672
		private IntPtr id_getReplayCache;

		// Token: 0x040002A1 RID: 673
		[Nullable(2)]
		private static Delegate cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002A2 RID: 674
		private IntPtr id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
	}
}
