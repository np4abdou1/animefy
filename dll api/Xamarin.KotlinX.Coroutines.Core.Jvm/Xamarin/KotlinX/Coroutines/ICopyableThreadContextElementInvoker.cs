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
	// Token: 0x0200004C RID: 76
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CopyableThreadContextElement", DoNotGenerateAcw = true)]
	internal class ICopyableThreadContextElementInvoker : Java.Lang.Object, ICopyableThreadContextElement, IThreadContextElement, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000A330 File Offset: 0x00008530
		private static IntPtr java_class_ref
		{
			get
			{
				return ICopyableThreadContextElementInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000A354 File Offset: 0x00008554
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICopyableThreadContextElementInvoker._members;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000A35B File Offset: 0x0000855B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000A363 File Offset: 0x00008563
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICopyableThreadContextElementInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000A36F File Offset: 0x0000856F
		[NullableContext(2)]
		public static ICopyableThreadContextElement GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICopyableThreadContextElement>(handle, transfer);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000A378 File Offset: 0x00008578
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICopyableThreadContextElementInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.CopyableThreadContextElement'.");
			}
			return handle;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000A3A3 File Offset: 0x000085A3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000A3D4 File Offset: 0x000085D4
		public ICopyableThreadContextElementInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICopyableThreadContextElementInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000A40C File Offset: 0x0000860C
		private static Delegate GetCopyForChildHandler()
		{
			if (ICopyableThreadContextElementInvoker.cb_copyForChild == null)
			{
				ICopyableThreadContextElementInvoker.cb_copyForChild = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICopyableThreadContextElementInvoker.n_CopyForChild));
			}
			return ICopyableThreadContextElementInvoker.cb_copyForChild;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000A430 File Offset: 0x00008630
		private static IntPtr n_CopyForChild(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CopyForChild());
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000A444 File Offset: 0x00008644
		public ICopyableThreadContextElement CopyForChild()
		{
			if (this.id_copyForChild == IntPtr.Zero)
			{
				this.id_copyForChild = JNIEnv.GetMethodID(this.class_ref, "copyForChild", "()Lkotlinx/coroutines/CopyableThreadContextElement;");
			}
			return Java.Lang.Object.GetObject<ICopyableThreadContextElement>(JNIEnv.CallObjectMethod(base.Handle, this.id_copyForChild), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000A495 File Offset: 0x00008695
		private static Delegate GetMergeForChild_Lkotlin_coroutines_CoroutineContext_Element_Handler()
		{
			if (ICopyableThreadContextElementInvoker.cb_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_ == null)
			{
				ICopyableThreadContextElementInvoker.cb_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICopyableThreadContextElementInvoker.n_MergeForChild_Lkotlin_coroutines_CoroutineContext_Element_));
			}
			return ICopyableThreadContextElementInvoker.cb_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000A4BC File Offset: 0x000086BC
		private static IntPtr n_MergeForChild_Lkotlin_coroutines_CoroutineContext_Element_(IntPtr jnienv, IntPtr native__this, IntPtr native_overwritingElement)
		{
			ICopyableThreadContextElement @object = Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextElement object2 = Java.Lang.Object.GetObject<ICoroutineContextElement>(native_overwritingElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MergeForChild(object2));
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000A4E4 File Offset: 0x000086E4
		public unsafe ICoroutineContext MergeForChild(ICoroutineContextElement overwritingElement)
		{
			if (this.id_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_ == IntPtr.Zero)
			{
				this.id_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_ = JNIEnv.GetMethodID(this.class_ref, "mergeForChild", "(Lkotlin/coroutines/CoroutineContext$Element;)Lkotlin/coroutines/CoroutineContext;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((overwritingElement == null) ? IntPtr.Zero : ((Java.Lang.Object)overwritingElement).Handle);
			return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000A562 File Offset: 0x00008762
		private static Delegate GetRestoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_Handler()
		{
			if (ICopyableThreadContextElementInvoker.cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_ == null)
			{
				ICopyableThreadContextElementInvoker.cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ICopyableThreadContextElementInvoker.n_RestoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_));
			}
			return ICopyableThreadContextElementInvoker.cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000A588 File Offset: 0x00008788
		private static void n_RestoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_oldState)
		{
			IThreadContextElement @object = Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldState, JniHandleOwnership.DoNotTransfer);
			@object.RestoreThreadContext(object2, object3);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000A5B4 File Offset: 0x000087B4
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

		// Token: 0x060002F1 RID: 753 RVA: 0x0000A64C File Offset: 0x0000884C
		private static Delegate GetUpdateThreadContext_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (ICopyableThreadContextElementInvoker.cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				ICopyableThreadContextElementInvoker.cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICopyableThreadContextElementInvoker.n_UpdateThreadContext_Lkotlin_coroutines_CoroutineContext_));
			}
			return ICopyableThreadContextElementInvoker.cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000A670 File Offset: 0x00008870
		private static IntPtr n_UpdateThreadContext_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			IThreadContextElement @object = Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.UpdateThreadContext(object2));
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000A698 File Offset: 0x00008898
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

		// Token: 0x060002F4 RID: 756 RVA: 0x0000A716 File Offset: 0x00008916
		private static Delegate GetGetKeyHandler()
		{
			if (ICopyableThreadContextElementInvoker.cb_getKey == null)
			{
				ICopyableThreadContextElementInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICopyableThreadContextElementInvoker.n_GetKey));
			}
			return ICopyableThreadContextElementInvoker.cb_getKey;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000A73A File Offset: 0x0000893A
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000A750 File Offset: 0x00008950
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

		// Token: 0x060002F7 RID: 759 RVA: 0x0000A7A1 File Offset: 0x000089A1
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ICopyableThreadContextElementInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				ICopyableThreadContextElementInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICopyableThreadContextElementInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return ICopyableThreadContextElementInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000A7C8 File Offset: 0x000089C8
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000A7FC File Offset: 0x000089FC
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

		// Token: 0x060002FA RID: 762 RVA: 0x0000A89C File Offset: 0x00008A9C
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICopyableThreadContextElementInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICopyableThreadContextElementInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICopyableThreadContextElementInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICopyableThreadContextElementInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000A8E8 File Offset: 0x00008AE8
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

		// Token: 0x060002FD RID: 765 RVA: 0x0000A966 File Offset: 0x00008B66
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICopyableThreadContextElementInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICopyableThreadContextElementInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICopyableThreadContextElementInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICopyableThreadContextElementInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000A98C File Offset: 0x00008B8C
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000A9B4 File Offset: 0x00008BB4
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

		// Token: 0x06000300 RID: 768 RVA: 0x0000AA32 File Offset: 0x00008C32
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (ICopyableThreadContextElementInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				ICopyableThreadContextElementInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICopyableThreadContextElementInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return ICopyableThreadContextElementInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000AA58 File Offset: 0x00008C58
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICopyableThreadContextElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000AA80 File Offset: 0x00008C80
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

		// Token: 0x040000E9 RID: 233
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CopyableThreadContextElement", typeof(ICopyableThreadContextElementInvoker));

		// Token: 0x040000EA RID: 234
		private IntPtr class_ref;

		// Token: 0x040000EB RID: 235
		[Nullable(2)]
		private static Delegate cb_copyForChild;

		// Token: 0x040000EC RID: 236
		private IntPtr id_copyForChild;

		// Token: 0x040000ED RID: 237
		[Nullable(2)]
		private static Delegate cb_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_;

		// Token: 0x040000EE RID: 238
		private IntPtr id_mergeForChild_Lkotlin_coroutines_CoroutineContext_Element_;

		// Token: 0x040000EF RID: 239
		[Nullable(2)]
		private static Delegate cb_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_;

		// Token: 0x040000F0 RID: 240
		private IntPtr id_restoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_;

		// Token: 0x040000F1 RID: 241
		[Nullable(2)]
		private static Delegate cb_updateThreadContext_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040000F2 RID: 242
		private IntPtr id_updateThreadContext_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040000F3 RID: 243
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x040000F4 RID: 244
		private IntPtr id_getKey;

		// Token: 0x040000F5 RID: 245
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040000F6 RID: 246
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040000F7 RID: 247
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000F8 RID: 248
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000F9 RID: 249
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000FA RID: 250
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000FB RID: 251
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040000FC RID: 252
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
