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
	// Token: 0x02000076 RID: 118
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ThreadContextElement", DoNotGenerateAcw = true)]
	internal class IThreadContextElementInvoker : Java.Lang.Object, IThreadContextElement, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00010C98 File Offset: 0x0000EE98
		private static IntPtr java_class_ref
		{
			get
			{
				return IThreadContextElementInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00010CBC File Offset: 0x0000EEBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IThreadContextElementInvoker._members;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00010CC3 File Offset: 0x0000EEC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00010CCB File Offset: 0x0000EECB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IThreadContextElementInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00010CD7 File Offset: 0x0000EED7
		[NullableContext(2)]
		public static IThreadContextElement GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IThreadContextElement>(handle, transfer);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IThreadContextElementInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.ThreadContextElement'.");
			}
			return handle;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00010D0B File Offset: 0x0000EF0B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00010D3C File Offset: 0x0000EF3C
		public IThreadContextElementInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IThreadContextElementInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00010D74 File Offset: 0x0000EF74
		private static Delegate GetRestoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_Handler()
		{
			if (IThreadContextElementInvoker.cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_ == null)
			{
				IThreadContextElementInvoker.cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IThreadContextElementInvoker.n_RestoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_));
			}
			return IThreadContextElementInvoker.cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00010D98 File Offset: 0x0000EF98
		private static void n_RestoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_oldState)
		{
			IThreadContextElement @object = Java.Lang.Object.GetObject<IThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldState, JniHandleOwnership.DoNotTransfer);
			@object.RestoreThreadContext(object2, object3);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		public unsafe void RestoreThreadContext(ICoroutineContext context, [Nullable(2)] Java.Lang.Object oldState)
		{
			if (this.id_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "restoreThreadContext", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(oldState);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00010E5C File Offset: 0x0000F05C
		private static Delegate GetUpdateThreadContext_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IThreadContextElementInvoker.cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IThreadContextElementInvoker.cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IThreadContextElementInvoker.n_UpdateThreadContext_Lkotlin_coroutines_CoroutineContext_));
			}
			return IThreadContextElementInvoker.cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00010E80 File Offset: 0x0000F080
		private static IntPtr n_UpdateThreadContext_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			IThreadContextElement @object = Java.Lang.Object.GetObject<IThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.UpdateThreadContext(object2));
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[return: Nullable(2)]
		public unsafe Java.Lang.Object UpdateThreadContext(ICoroutineContext context)
		{
			if (this.id_updateThreadContext_Lkotlin_coroutines_CoroutineContext_ == IntPtr.Zero)
			{
				this.id_updateThreadContext_Lkotlin_coroutines_CoroutineContext_ = JNIEnv.GetMethodID(this.class_ref, "updateThreadContext", "(Lkotlin/coroutines/CoroutineContext;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_updateThreadContext_Lkotlin_coroutines_CoroutineContext_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00010F26 File Offset: 0x0000F126
		private static Delegate GetGetKeyHandler()
		{
			if (IThreadContextElementInvoker.cb_getKey == null)
			{
				IThreadContextElementInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IThreadContextElementInvoker.n_GetKey));
			}
			return IThreadContextElementInvoker.cb_getKey;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00010F4A File Offset: 0x0000F14A
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00010F60 File Offset: 0x0000F160
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

		// Token: 0x06000517 RID: 1303 RVA: 0x00010FB1 File Offset: 0x0000F1B1
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IThreadContextElementInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				IThreadContextElementInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IThreadContextElementInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return IThreadContextElementInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00010FD8 File Offset: 0x0000F1D8
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001100C File Offset: 0x0000F20C
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

		// Token: 0x0600051A RID: 1306 RVA: 0x000110AC File Offset: 0x0000F2AC
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IThreadContextElementInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IThreadContextElementInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IThreadContextElementInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IThreadContextElementInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000110D0 File Offset: 0x0000F2D0
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000110F8 File Offset: 0x0000F2F8
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

		// Token: 0x0600051D RID: 1309 RVA: 0x00011176 File Offset: 0x0000F376
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IThreadContextElementInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IThreadContextElementInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IThreadContextElementInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IThreadContextElementInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001119C File Offset: 0x0000F39C
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000111C4 File Offset: 0x0000F3C4
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

		// Token: 0x06000520 RID: 1312 RVA: 0x00011242 File Offset: 0x0000F442
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IThreadContextElementInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IThreadContextElementInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IThreadContextElementInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return IThreadContextElementInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00011268 File Offset: 0x0000F468
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<IThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00011290 File Offset: 0x0000F490
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

		// Token: 0x040001DE RID: 478
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ThreadContextElement", typeof(IThreadContextElementInvoker));

		// Token: 0x040001DF RID: 479
		private IntPtr class_ref;

		// Token: 0x040001E0 RID: 480
		[Nullable(2)]
		private static Delegate cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_;

		// Token: 0x040001E1 RID: 481
		private IntPtr id_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_;

		// Token: 0x040001E2 RID: 482
		[Nullable(2)]
		private static Delegate cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040001E3 RID: 483
		private IntPtr id_updateThreadContext_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040001E4 RID: 484
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x040001E5 RID: 485
		private IntPtr id_getKey;

		// Token: 0x040001E6 RID: 486
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040001E7 RID: 487
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040001E8 RID: 488
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001E9 RID: 489
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001EA RID: 490
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001EB RID: 491
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001EC RID: 492
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040001ED RID: 493
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
