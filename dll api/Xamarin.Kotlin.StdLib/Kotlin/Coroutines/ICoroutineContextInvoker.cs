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
	// Token: 0x02000260 RID: 608
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/CoroutineContext", DoNotGenerateAcw = true)]
	internal class ICoroutineContextInvoker : Java.Lang.Object, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x0005D314 File Offset: 0x0005B514
		private static IntPtr java_class_ref
		{
			get
			{
				return ICoroutineContextInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x0005D338 File Offset: 0x0005B538
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICoroutineContextInvoker._members;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0005D33F File Offset: 0x0005B53F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x0005D347 File Offset: 0x0005B547
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICoroutineContextInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0005D353 File Offset: 0x0005B553
		[NullableContext(2)]
		public static ICoroutineContext GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICoroutineContext>(handle, transfer);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0005D35C File Offset: 0x0005B55C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICoroutineContextInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.coroutines.CoroutineContext'.");
			}
			return handle;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0005D387 File Offset: 0x0005B587
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0005D3B8 File Offset: 0x0005B5B8
		public ICoroutineContextInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICoroutineContextInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0005D3F0 File Offset: 0x0005B5F0
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ICoroutineContextInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				ICoroutineContextInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICoroutineContextInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return ICoroutineContextInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0005D414 File Offset: 0x0005B614
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICoroutineContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0005D448 File Offset: 0x0005B648
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

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0005D4E6 File Offset: 0x0005B6E6
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICoroutineContextInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICoroutineContextInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICoroutineContextInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICoroutineContextInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0005D50C File Offset: 0x0005B70C
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICoroutineContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0005D534 File Offset: 0x0005B734
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

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0005D5B2 File Offset: 0x0005B7B2
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICoroutineContextInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICoroutineContextInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICoroutineContextInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICoroutineContextInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0005D5D8 File Offset: 0x0005B7D8
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICoroutineContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0005D600 File Offset: 0x0005B800
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

		// Token: 0x06001BEA RID: 7146 RVA: 0x0005D67E File Offset: 0x0005B87E
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (ICoroutineContextInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				ICoroutineContextInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICoroutineContextInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return ICoroutineContextInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0005D6A4 File Offset: 0x0005B8A4
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICoroutineContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0005D6CC File Offset: 0x0005B8CC
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

		// Token: 0x04000893 RID: 2195
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/CoroutineContext", typeof(ICoroutineContextInvoker));

		// Token: 0x04000894 RID: 2196
		private IntPtr class_ref;

		// Token: 0x04000895 RID: 2197
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000896 RID: 2198
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000897 RID: 2199
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000898 RID: 2200
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000899 RID: 2201
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x0400089A RID: 2202
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x0400089B RID: 2203
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x0400089C RID: 2204
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
