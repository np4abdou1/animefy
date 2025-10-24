using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000118 RID: 280
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty2$Setter", DoNotGenerateAcw = true)]
	internal class IKMutableProperty2SetterInvoker : Java.Lang.Object, IKMutableProperty2Setter, IFunction3, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKMutablePropertySetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0002F39C File Offset: 0x0002D59C
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableProperty2SetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0002F3C0 File Offset: 0x0002D5C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutableProperty2SetterInvoker._members;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0002F3C7 File Offset: 0x0002D5C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0002F3CF File Offset: 0x0002D5CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutableProperty2SetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0002F3DB File Offset: 0x0002D5DB
		[NullableContext(2)]
		public static IKMutableProperty2Setter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(handle, transfer);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableProperty2SetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty2.Setter'.");
			}
			return handle;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0002F40F File Offset: 0x0002D60F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0002F440 File Offset: 0x0002D640
		public IKMutableProperty2SetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableProperty2SetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0002F478 File Offset: 0x0002D678
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty2SetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKMutableProperty2SetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IKMutableProperty2SetterInvoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKMutableProperty2SetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0002F49C File Offset: 0x0002D69C
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IFunction3 @object = Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, object4));
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
			return @object;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0002F592 File Offset: 0x0002D792
		private static Delegate GetIsExternalHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isExternal == null)
			{
				IKMutableProperty2SetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsExternal));
			}
			return IKMutableProperty2SetterInvoker.cb_isExternal;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0002F5B6 File Offset: 0x0002D7B6
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0002F5C5 File Offset: 0x0002D7C5
		public bool IsExternal
		{
			get
			{
				if (this.id_isExternal == IntPtr.Zero)
				{
					this.id_isExternal = JNIEnv.GetMethodID(this.class_ref, "isExternal", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isExternal);
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0002F605 File Offset: 0x0002D805
		private static Delegate GetIsInfixHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isInfix == null)
			{
				IKMutableProperty2SetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsInfix));
			}
			return IKMutableProperty2SetterInvoker.cb_isInfix;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0002F629 File Offset: 0x0002D829
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0002F638 File Offset: 0x0002D838
		public bool IsInfix
		{
			get
			{
				if (this.id_isInfix == IntPtr.Zero)
				{
					this.id_isInfix = JNIEnv.GetMethodID(this.class_ref, "isInfix", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isInfix);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0002F678 File Offset: 0x0002D878
		private static Delegate GetIsInlineHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isInline == null)
			{
				IKMutableProperty2SetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsInline));
			}
			return IKMutableProperty2SetterInvoker.cb_isInline;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002F69C File Offset: 0x0002D89C
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0002F6AB File Offset: 0x0002D8AB
		public bool IsInline
		{
			get
			{
				if (this.id_isInline == IntPtr.Zero)
				{
					this.id_isInline = JNIEnv.GetMethodID(this.class_ref, "isInline", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isInline);
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0002F6EB File Offset: 0x0002D8EB
		private static Delegate GetIsOperatorHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isOperator == null)
			{
				IKMutableProperty2SetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsOperator));
			}
			return IKMutableProperty2SetterInvoker.cb_isOperator;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0002F70F File Offset: 0x0002D90F
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0002F71E File Offset: 0x0002D91E
		public bool IsOperator
		{
			get
			{
				if (this.id_isOperator == IntPtr.Zero)
				{
					this.id_isOperator = JNIEnv.GetMethodID(this.class_ref, "isOperator", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOperator);
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0002F75E File Offset: 0x0002D95E
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isSuspend == null)
			{
				IKMutableProperty2SetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsSuspend));
			}
			return IKMutableProperty2SetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0002F782 File Offset: 0x0002D982
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0002F791 File Offset: 0x0002D991
		public bool IsSuspend
		{
			get
			{
				if (this.id_isSuspend == IntPtr.Zero)
				{
					this.id_isSuspend = JNIEnv.GetMethodID(this.class_ref, "isSuspend", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isSuspend);
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0002F7D1 File Offset: 0x0002D9D1
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isAbstract == null)
			{
				IKMutableProperty2SetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsAbstract));
			}
			return IKMutableProperty2SetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0002F7F5 File Offset: 0x0002D9F5
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0002F804 File Offset: 0x0002DA04
		public bool IsAbstract
		{
			get
			{
				if (this.id_isAbstract == IntPtr.Zero)
				{
					this.id_isAbstract = JNIEnv.GetMethodID(this.class_ref, "isAbstract", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isAbstract);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0002F844 File Offset: 0x0002DA44
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isFinal == null)
			{
				IKMutableProperty2SetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsFinal));
			}
			return IKMutableProperty2SetterInvoker.cb_isFinal;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0002F868 File Offset: 0x0002DA68
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0002F877 File Offset: 0x0002DA77
		public bool IsFinal
		{
			get
			{
				if (this.id_isFinal == IntPtr.Zero)
				{
					this.id_isFinal = JNIEnv.GetMethodID(this.class_ref, "isFinal", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isFinal);
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0002F8B7 File Offset: 0x0002DAB7
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_isOpen == null)
			{
				IKMutableProperty2SetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2SetterInvoker.n_IsOpen));
			}
			return IKMutableProperty2SetterInvoker.cb_isOpen;
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0002F8DB File Offset: 0x0002DADB
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0002F8EA File Offset: 0x0002DAEA
		public bool IsOpen
		{
			get
			{
				if (this.id_isOpen == IntPtr.Zero)
				{
					this.id_isOpen = JNIEnv.GetMethodID(this.class_ref, "isOpen", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOpen);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0002F92A File Offset: 0x0002DB2A
		private static Delegate GetGetNameHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_getName == null)
			{
				IKMutableProperty2SetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2SetterInvoker.n_GetName));
			}
			return IKMutableProperty2SetterInvoker.cb_getName;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0002F94E File Offset: 0x0002DB4E
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0002F964 File Offset: 0x0002DB64
		public string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0002F9B5 File Offset: 0x0002DBB5
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_getParameters == null)
			{
				IKMutableProperty2SetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2SetterInvoker.n_GetParameters));
			}
			return IKMutableProperty2SetterInvoker.cb_getParameters;
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0002F9D9 File Offset: 0x0002DBD9
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
		public IList<IKParameter> Parameters
		{
			get
			{
				if (this.id_getParameters == IntPtr.Zero)
				{
					this.id_getParameters = JNIEnv.GetMethodID(this.class_ref, "getParameters", "()Ljava/util/List;");
				}
				return JavaList<IKParameter>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002FA41 File Offset: 0x0002DC41
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_getReturnType == null)
			{
				IKMutableProperty2SetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2SetterInvoker.n_GetReturnType));
			}
			return IKMutableProperty2SetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0002FA65 File Offset: 0x0002DC65
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0002FA7C File Offset: 0x0002DC7C
		public IKType ReturnType
		{
			get
			{
				if (this.id_getReturnType == IntPtr.Zero)
				{
					this.id_getReturnType = JNIEnv.GetMethodID(this.class_ref, "getReturnType", "()Lkotlin/reflect/KType;");
				}
				return Java.Lang.Object.GetObject<IKType>(JNIEnv.CallObjectMethod(base.Handle, this.id_getReturnType), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0002FACD File Offset: 0x0002DCCD
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_getTypeParameters == null)
			{
				IKMutableProperty2SetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2SetterInvoker.n_GetTypeParameters));
			}
			return IKMutableProperty2SetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0002FAF1 File Offset: 0x0002DCF1
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0002FB08 File Offset: 0x0002DD08
		public IList<IKTypeParameter> TypeParameters
		{
			get
			{
				if (this.id_getTypeParameters == IntPtr.Zero)
				{
					this.id_getTypeParameters = JNIEnv.GetMethodID(this.class_ref, "getTypeParameters", "()Ljava/util/List;");
				}
				return JavaList<IKTypeParameter>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getTypeParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002FB59 File Offset: 0x0002DD59
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_getVisibility == null)
			{
				IKMutableProperty2SetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2SetterInvoker.n_GetVisibility));
			}
			return IKMutableProperty2SetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0002FB7D File Offset: 0x0002DD7D
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x0002FB94 File Offset: 0x0002DD94
		[Nullable(2)]
		public KVisibility Visibility
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getVisibility == IntPtr.Zero)
				{
					this.id_getVisibility = JNIEnv.GetMethodID(this.class_ref, "getVisibility", "()Lkotlin/reflect/KVisibility;");
				}
				return Java.Lang.Object.GetObject<KVisibility>(JNIEnv.CallObjectMethod(base.Handle, this.id_getVisibility), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0002FBE5 File Offset: 0x0002DDE5
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutableProperty2SetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutableProperty2SetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty2SetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutableProperty2SetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002FC0C File Offset: 0x0002DE0C
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0002FC50 File Offset: 0x0002DE50
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Call(params Java.Lang.Object[] args)
		{
			if (this.id_call_arrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_call_arrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "call", "([Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(args);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_call_arrayLjava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			if (args != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr, args);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0002FCD1 File Offset: 0x0002DED1
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutableProperty2SetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutableProperty2SetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty2SetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutableProperty2SetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0002FD20 File Offset: 0x0002DF20
		[return: Nullable(2)]
		public unsafe Java.Lang.Object CallBy(IDictionary args)
		{
			if (this.id_callBy_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_callBy_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "callBy", "(Ljava/util/Map;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(args);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_callBy_Ljava_util_Map_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0002FD97 File Offset: 0x0002DF97
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_getAnnotations == null)
			{
				IKMutableProperty2SetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2SetterInvoker.n_GetAnnotations));
			}
			return IKMutableProperty2SetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0002FDBB File Offset: 0x0002DFBB
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		public IList<IAnnotation> Annotations
		{
			get
			{
				if (this.id_getAnnotations == IntPtr.Zero)
				{
					this.id_getAnnotations = JNIEnv.GetMethodID(this.class_ref, "getAnnotations", "()Ljava/util/List;");
				}
				return JavaList<IAnnotation>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getAnnotations), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0002FE21 File Offset: 0x0002E021
		private static Delegate GetGetPropertyHandler()
		{
			if (IKMutableProperty2SetterInvoker.cb_getProperty == null)
			{
				IKMutableProperty2SetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2SetterInvoker.n_GetProperty));
			}
			return IKMutableProperty2SetterInvoker.cb_getProperty;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002FE45 File Offset: 0x0002E045
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0002FE5C File Offset: 0x0002E05C
		public IKProperty Property
		{
			get
			{
				if (this.id_getProperty == IntPtr.Zero)
				{
					this.id_getProperty = JNIEnv.GetMethodID(this.class_ref, "getProperty", "()Lkotlin/reflect/KProperty;");
				}
				return Java.Lang.Object.GetObject<IKProperty>(JNIEnv.CallObjectMethod(base.Handle, this.id_getProperty), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040003C7 RID: 967
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty2$Setter", typeof(IKMutableProperty2SetterInvoker));

		// Token: 0x040003C8 RID: 968
		private IntPtr class_ref;

		// Token: 0x040003C9 RID: 969
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040003CA RID: 970
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040003CB RID: 971
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x040003CC RID: 972
		private IntPtr id_isExternal;

		// Token: 0x040003CD RID: 973
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x040003CE RID: 974
		private IntPtr id_isInfix;

		// Token: 0x040003CF RID: 975
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x040003D0 RID: 976
		private IntPtr id_isInline;

		// Token: 0x040003D1 RID: 977
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x040003D2 RID: 978
		private IntPtr id_isOperator;

		// Token: 0x040003D3 RID: 979
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x040003D4 RID: 980
		private IntPtr id_isSuspend;

		// Token: 0x040003D5 RID: 981
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040003D6 RID: 982
		private IntPtr id_isAbstract;

		// Token: 0x040003D7 RID: 983
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040003D8 RID: 984
		private IntPtr id_isFinal;

		// Token: 0x040003D9 RID: 985
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040003DA RID: 986
		private IntPtr id_isOpen;

		// Token: 0x040003DB RID: 987
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x040003DC RID: 988
		private IntPtr id_getName;

		// Token: 0x040003DD RID: 989
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x040003DE RID: 990
		private IntPtr id_getParameters;

		// Token: 0x040003DF RID: 991
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x040003E0 RID: 992
		private IntPtr id_getReturnType;

		// Token: 0x040003E1 RID: 993
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x040003E2 RID: 994
		private IntPtr id_getTypeParameters;

		// Token: 0x040003E3 RID: 995
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x040003E4 RID: 996
		private IntPtr id_getVisibility;

		// Token: 0x040003E5 RID: 997
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x040003E6 RID: 998
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x040003E7 RID: 999
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x040003E8 RID: 1000
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x040003E9 RID: 1001
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x040003EA RID: 1002
		private IntPtr id_getAnnotations;

		// Token: 0x040003EB RID: 1003
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x040003EC RID: 1004
		private IntPtr id_getProperty;
	}
}
