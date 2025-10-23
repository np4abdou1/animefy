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
	// Token: 0x0200024C RID: 588
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/AbstractCoroutineContextElement", DoNotGenerateAcw = true)]
	public abstract class AbstractCoroutineContextElement : Java.Lang.Object, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x0005AEB0 File Offset: 0x000590B0
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractCoroutineContextElement._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0005AED4 File Offset: 0x000590D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractCoroutineContextElement._members;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x0005AEDC File Offset: 0x000590DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractCoroutineContextElement._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0005AF00 File Offset: 0x00059100
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractCoroutineContextElement._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0005AF0C File Offset: 0x0005910C
		protected AbstractCoroutineContextElement(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0005AF18 File Offset: 0x00059118
		[Register(".ctor", "(Lkotlin/coroutines/CoroutineContext$Key;)V", "")]
		public unsafe AbstractCoroutineContextElement(ICoroutineContextKey key) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				base.SetHandle(AbstractCoroutineContextElement._members.InstanceMethods.StartCreateInstance("(Lkotlin/coroutines/CoroutineContext$Key;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbstractCoroutineContextElement._members.InstanceMethods.FinishCreateInstance("(Lkotlin/coroutines/CoroutineContext$Key;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
			}
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0005AFCC File Offset: 0x000591CC
		private static Delegate GetGetKeyHandler()
		{
			if (AbstractCoroutineContextElement.cb_getKey == null)
			{
				AbstractCoroutineContextElement.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractCoroutineContextElement.n_GetKey));
			}
			return AbstractCoroutineContextElement.cb_getKey;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0005AFF0 File Offset: 0x000591F0
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractCoroutineContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0005B004 File Offset: 0x00059204
		public virtual ICoroutineContextKey Key
		{
			[Register("getKey", "()Lkotlin/coroutines/CoroutineContext$Key;", "GetGetKeyHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICoroutineContextKey>(AbstractCoroutineContextElement._members.InstanceMethods.InvokeVirtualObjectMethod("getKey.()Lkotlin/coroutines/CoroutineContext$Key;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0005B036 File Offset: 0x00059236
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (AbstractCoroutineContextElement.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				AbstractCoroutineContextElement.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AbstractCoroutineContextElement.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return AbstractCoroutineContextElement.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0005B05C File Offset: 0x0005925C
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			AbstractCoroutineContextElement @object = Java.Lang.Object.GetObject<AbstractCoroutineContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0005B090 File Offset: 0x00059290
		[NullableContext(2)]
		[Register("fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe virtual Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractCoroutineContextElement._members.InstanceMethods.InvokeVirtualObjectMethod("fold.(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0005B130 File Offset: 0x00059330
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (AbstractCoroutineContextElement.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				AbstractCoroutineContextElement.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractCoroutineContextElement.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return AbstractCoroutineContextElement.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0005B154 File Offset: 0x00059354
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractCoroutineContextElement @object = Java.Lang.Object.GetObject<AbstractCoroutineContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0005B17C File Offset: 0x0005937C
		[Register("get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe virtual Java.Lang.Object Get(ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractCoroutineContextElement._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0005B1F4 File Offset: 0x000593F4
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (AbstractCoroutineContextElement.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				AbstractCoroutineContextElement.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractCoroutineContextElement.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return AbstractCoroutineContextElement.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0005B218 File Offset: 0x00059418
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractCoroutineContextElement @object = Java.Lang.Object.GetObject<AbstractCoroutineContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0005B240 File Offset: 0x00059440
		[Register("minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler")]
		public unsafe virtual ICoroutineContext MinusKey(ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(AbstractCoroutineContextElement._members.InstanceMethods.InvokeVirtualObjectMethod("minusKey.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0005B2B8 File Offset: 0x000594B8
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (AbstractCoroutineContextElement.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				AbstractCoroutineContextElement.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractCoroutineContextElement.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return AbstractCoroutineContextElement.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0005B2DC File Offset: 0x000594DC
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			AbstractCoroutineContextElement @object = Java.Lang.Object.GetObject<AbstractCoroutineContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0005B304 File Offset: 0x00059504
		[Register("plus", "(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "GetPlus_Lkotlin_coroutines_CoroutineContext_Handler")]
		public unsafe virtual ICoroutineContext Plus(ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(AbstractCoroutineContextElement._members.InstanceMethods.InvokeVirtualObjectMethod("plus.(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x04000860 RID: 2144
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/AbstractCoroutineContextElement", typeof(AbstractCoroutineContextElement));

		// Token: 0x04000861 RID: 2145
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x04000862 RID: 2146
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000863 RID: 2147
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000864 RID: 2148
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000865 RID: 2149
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
