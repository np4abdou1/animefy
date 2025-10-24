using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000054 RID: 84
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineExceptionHandler", DoNotGenerateAcw = true)]
	internal class ICoroutineExceptionHandlerInvoker : Java.Lang.Object, ICoroutineExceptionHandler, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000B08C File Offset: 0x0000928C
		private static IntPtr java_class_ref
		{
			get
			{
				return ICoroutineExceptionHandlerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000B0B0 File Offset: 0x000092B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICoroutineExceptionHandlerInvoker._members;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000B0B7 File Offset: 0x000092B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000B0BF File Offset: 0x000092BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICoroutineExceptionHandlerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000B0CB File Offset: 0x000092CB
		[NullableContext(2)]
		public static ICoroutineExceptionHandler GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(handle, transfer);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000B0D4 File Offset: 0x000092D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICoroutineExceptionHandlerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.CoroutineExceptionHandler'.");
			}
			return handle;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000B0FF File Offset: 0x000092FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000B130 File Offset: 0x00009330
		public ICoroutineExceptionHandlerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICoroutineExceptionHandlerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000B168 File Offset: 0x00009368
		private static Delegate GetHandleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_Handler()
		{
			if (ICoroutineExceptionHandlerInvoker.cb_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_ == null)
			{
				ICoroutineExceptionHandlerInvoker.cb_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ICoroutineExceptionHandlerInvoker.n_HandleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_));
			}
			return ICoroutineExceptionHandlerInvoker.cb_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000B18C File Offset: 0x0000938C
		private static void n_HandleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_exception)
		{
			ICoroutineExceptionHandler @object = Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			Throwable object3 = Java.Lang.Object.GetObject<Throwable>(native_exception, JniHandleOwnership.DoNotTransfer);
			@object.HandleException(object2, object3);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000B1B8 File Offset: 0x000093B8
		public unsafe void HandleException(ICoroutineContext context, Throwable exception)
		{
			if (this.id_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "handleException", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Throwable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
			ptr[1] = new JValue((exception == null) ? IntPtr.Zero : exception.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_, ptr);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000B252 File Offset: 0x00009452
		private static Delegate GetGetKeyHandler()
		{
			if (ICoroutineExceptionHandlerInvoker.cb_getKey == null)
			{
				ICoroutineExceptionHandlerInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICoroutineExceptionHandlerInvoker.n_GetKey));
			}
			return ICoroutineExceptionHandlerInvoker.cb_getKey;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000B276 File Offset: 0x00009476
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000B28C File Offset: 0x0000948C
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

		// Token: 0x06000333 RID: 819 RVA: 0x0000B2DD File Offset: 0x000094DD
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ICoroutineExceptionHandlerInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				ICoroutineExceptionHandlerInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICoroutineExceptionHandlerInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return ICoroutineExceptionHandlerInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000B304 File Offset: 0x00009504
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000B338 File Offset: 0x00009538
		[NullableContext(2)]
		public unsafe Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation)
		{
			if (this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((initial == null) ? IntPtr.Zero : initial.Handle);
			ptr[1] = new JValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B3D8 File Offset: 0x000095D8
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICoroutineExceptionHandlerInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICoroutineExceptionHandlerInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICoroutineExceptionHandlerInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICoroutineExceptionHandlerInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000B3FC File Offset: 0x000095FC
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000B424 File Offset: 0x00009624
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

		// Token: 0x06000339 RID: 825 RVA: 0x0000B4A2 File Offset: 0x000096A2
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICoroutineExceptionHandlerInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICoroutineExceptionHandlerInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICoroutineExceptionHandlerInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICoroutineExceptionHandlerInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000B4C8 File Offset: 0x000096C8
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000B4F0 File Offset: 0x000096F0
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

		// Token: 0x0600033C RID: 828 RVA: 0x0000B56E File Offset: 0x0000976E
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (ICoroutineExceptionHandlerInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				ICoroutineExceptionHandlerInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICoroutineExceptionHandlerInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return ICoroutineExceptionHandlerInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000B594 File Offset: 0x00009794
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICoroutineExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000B5BC File Offset: 0x000097BC
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

		// Token: 0x04000104 RID: 260
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineExceptionHandler", typeof(ICoroutineExceptionHandlerInvoker));

		// Token: 0x04000105 RID: 261
		private IntPtr class_ref;

		// Token: 0x04000106 RID: 262
		[Nullable(2)]
		private static Delegate cb_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_;

		// Token: 0x04000107 RID: 263
		private IntPtr id_handleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_;

		// Token: 0x04000108 RID: 264
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x04000109 RID: 265
		private IntPtr id_getKey;

		// Token: 0x0400010A RID: 266
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x0400010B RID: 267
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x0400010C RID: 268
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x0400010D RID: 269
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x0400010E RID: 270
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x0400010F RID: 271
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000110 RID: 272
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x04000111 RID: 273
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
