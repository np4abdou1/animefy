using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Coroutines
{
	// Token: 0x02000258 RID: 600
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/ContinuationInterceptor", DoNotGenerateAcw = true)]
	internal class IContinuationInterceptorInvoker : Java.Lang.Object, IContinuationInterceptor, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0005C268 File Offset: 0x0005A468
		private static IntPtr java_class_ref
		{
			get
			{
				return IContinuationInterceptorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0005C28C File Offset: 0x0005A48C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContinuationInterceptorInvoker._members;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0005C293 File Offset: 0x0005A493
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0005C29B File Offset: 0x0005A49B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContinuationInterceptorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0005C2A7 File Offset: 0x0005A4A7
		[NullableContext(2)]
		public static IContinuationInterceptor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContinuationInterceptor>(handle, transfer);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContinuationInterceptorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.coroutines.ContinuationInterceptor'.");
			}
			return handle;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0005C2DB File Offset: 0x0005A4DB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0005C30C File Offset: 0x0005A50C
		public IContinuationInterceptorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContinuationInterceptorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0005C344 File Offset: 0x0005A544
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IContinuationInterceptorInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IContinuationInterceptorInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContinuationInterceptorInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IContinuationInterceptorInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0005C368 File Offset: 0x0005A568
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			IContinuationInterceptor @object = Java.Lang.Object.GetObject<IContinuationInterceptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0005C390 File Offset: 0x0005A590
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

		// Token: 0x06001B8C RID: 7052 RVA: 0x0005C40E File Offset: 0x0005A60E
		private static Delegate GetInterceptContinuation_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IContinuationInterceptorInvoker.cb_interceptContinuation_Lkotlin_coroutines_Continuation_ == null)
			{
				IContinuationInterceptorInvoker.cb_interceptContinuation_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContinuationInterceptorInvoker.n_InterceptContinuation_Lkotlin_coroutines_Continuation_));
			}
			return IContinuationInterceptorInvoker.cb_interceptContinuation_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0005C434 File Offset: 0x0005A634
		private static IntPtr n_InterceptContinuation_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_continuation)
		{
			IContinuationInterceptor @object = Java.Lang.Object.GetObject<IContinuationInterceptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_continuation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InterceptContinuation(object2));
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0005C45C File Offset: 0x0005A65C
		public unsafe IContinuation InterceptContinuation(IContinuation continuation)
		{
			if (this.id_interceptContinuation_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_interceptContinuation_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "interceptContinuation", "(Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((continuation == null) ? IntPtr.Zero : ((Java.Lang.Object)continuation).Handle);
			return Java.Lang.Object.GetObject<IContinuation>(JNIEnv.CallObjectMethod(base.Handle, this.id_interceptContinuation_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0005C4DA File Offset: 0x0005A6DA
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IContinuationInterceptorInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IContinuationInterceptorInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContinuationInterceptorInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IContinuationInterceptorInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0005C500 File Offset: 0x0005A700
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			IContinuationInterceptor @object = Java.Lang.Object.GetObject<IContinuationInterceptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0005C528 File Offset: 0x0005A728
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

		// Token: 0x06001B92 RID: 7058 RVA: 0x0005C5A6 File Offset: 0x0005A7A6
		private static Delegate GetReleaseInterceptedContinuation_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IContinuationInterceptorInvoker.cb_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_ == null)
			{
				IContinuationInterceptorInvoker.cb_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IContinuationInterceptorInvoker.n_ReleaseInterceptedContinuation_Lkotlin_coroutines_Continuation_));
			}
			return IContinuationInterceptorInvoker.cb_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0005C5CC File Offset: 0x0005A7CC
		private static void n_ReleaseInterceptedContinuation_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_continuation)
		{
			IContinuationInterceptor @object = Java.Lang.Object.GetObject<IContinuationInterceptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_continuation, JniHandleOwnership.DoNotTransfer);
			@object.ReleaseInterceptedContinuation(object2);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0005C5F0 File Offset: 0x0005A7F0
		public unsafe void ReleaseInterceptedContinuation(IContinuation continuation)
		{
			if (this.id_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "releaseInterceptedContinuation", "(Lkotlin/coroutines/Continuation;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((continuation == null) ? IntPtr.Zero : ((Java.Lang.Object)continuation).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_, ptr);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0005C668 File Offset: 0x0005A868
		private static Delegate GetGetKeyHandler()
		{
			if (IContinuationInterceptorInvoker.cb_getKey == null)
			{
				IContinuationInterceptorInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContinuationInterceptorInvoker.n_GetKey));
			}
			return IContinuationInterceptorInvoker.cb_getKey;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0005C68C File Offset: 0x0005A88C
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContinuationInterceptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0005C6A0 File Offset: 0x0005A8A0
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

		// Token: 0x06001B98 RID: 7064 RVA: 0x0005C6F1 File Offset: 0x0005A8F1
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IContinuationInterceptorInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				IContinuationInterceptorInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IContinuationInterceptorInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return IContinuationInterceptorInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0005C718 File Offset: 0x0005A918
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IContinuationInterceptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0005C74C File Offset: 0x0005A94C
		[NullableContext(2)]
		public unsafe Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation)
		{
			if (this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0005C7EA File Offset: 0x0005A9EA
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IContinuationInterceptorInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IContinuationInterceptorInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContinuationInterceptorInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return IContinuationInterceptorInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0005C810 File Offset: 0x0005AA10
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<IContinuationInterceptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0005C838 File Offset: 0x0005AA38
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

		// Token: 0x04000873 RID: 2163
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/ContinuationInterceptor", typeof(IContinuationInterceptorInvoker));

		// Token: 0x04000874 RID: 2164
		private IntPtr class_ref;

		// Token: 0x04000875 RID: 2165
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000876 RID: 2166
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000877 RID: 2167
		[Nullable(2)]
		private static Delegate cb_interceptContinuation_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000878 RID: 2168
		private IntPtr id_interceptContinuation_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000879 RID: 2169
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x0400087A RID: 2170
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x0400087B RID: 2171
		[Nullable(2)]
		private static Delegate cb_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400087C RID: 2172
		private IntPtr id_releaseInterceptedContinuation_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400087D RID: 2173
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x0400087E RID: 2174
		private IntPtr id_getKey;

		// Token: 0x0400087F RID: 2175
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000880 RID: 2176
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000881 RID: 2177
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x04000882 RID: 2178
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
