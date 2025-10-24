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

namespace Kotlin.Reflect
{
	// Token: 0x0200010C RID: 268
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty$Setter", DoNotGenerateAcw = true)]
	internal class IKMutablePropertySetterInvoker : Java.Lang.Object, IKMutablePropertySetter, IKFunction, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0002B108 File Offset: 0x00029308
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutablePropertySetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0002B12C File Offset: 0x0002932C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutablePropertySetterInvoker._members;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0002B133 File Offset: 0x00029333
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0002B13B File Offset: 0x0002933B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutablePropertySetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0002B147 File Offset: 0x00029347
		[NullableContext(2)]
		public static IKMutablePropertySetter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(handle, transfer);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0002B150 File Offset: 0x00029350
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutablePropertySetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty.Setter'.");
			}
			return handle;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0002B17B File Offset: 0x0002937B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0002B1AC File Offset: 0x000293AC
		public IKMutablePropertySetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutablePropertySetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0002B1E4 File Offset: 0x000293E4
		private static Delegate GetIsExternalHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isExternal == null)
			{
				IKMutablePropertySetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsExternal));
			}
			return IKMutablePropertySetterInvoker.cb_isExternal;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002B208 File Offset: 0x00029408
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0002B217 File Offset: 0x00029417
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

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002B257 File Offset: 0x00029457
		private static Delegate GetIsInfixHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isInfix == null)
			{
				IKMutablePropertySetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsInfix));
			}
			return IKMutablePropertySetterInvoker.cb_isInfix;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0002B27B File Offset: 0x0002947B
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0002B28A File Offset: 0x0002948A
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

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002B2CA File Offset: 0x000294CA
		private static Delegate GetIsInlineHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isInline == null)
			{
				IKMutablePropertySetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsInline));
			}
			return IKMutablePropertySetterInvoker.cb_isInline;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002B2EE File Offset: 0x000294EE
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0002B2FD File Offset: 0x000294FD
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

		// Token: 0x06000C06 RID: 3078 RVA: 0x0002B33D File Offset: 0x0002953D
		private static Delegate GetIsOperatorHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isOperator == null)
			{
				IKMutablePropertySetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsOperator));
			}
			return IKMutablePropertySetterInvoker.cb_isOperator;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0002B361 File Offset: 0x00029561
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0002B370 File Offset: 0x00029570
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

		// Token: 0x06000C09 RID: 3081 RVA: 0x0002B3B0 File Offset: 0x000295B0
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isSuspend == null)
			{
				IKMutablePropertySetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsSuspend));
			}
			return IKMutablePropertySetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0002B3D4 File Offset: 0x000295D4
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0002B3E3 File Offset: 0x000295E3
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

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002B423 File Offset: 0x00029623
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isAbstract == null)
			{
				IKMutablePropertySetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsAbstract));
			}
			return IKMutablePropertySetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0002B447 File Offset: 0x00029647
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0002B456 File Offset: 0x00029656
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

		// Token: 0x06000C0F RID: 3087 RVA: 0x0002B496 File Offset: 0x00029696
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isFinal == null)
			{
				IKMutablePropertySetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsFinal));
			}
			return IKMutablePropertySetterInvoker.cb_isFinal;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0002B4BA File Offset: 0x000296BA
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0002B4C9 File Offset: 0x000296C9
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

		// Token: 0x06000C12 RID: 3090 RVA: 0x0002B509 File Offset: 0x00029709
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_isOpen == null)
			{
				IKMutablePropertySetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertySetterInvoker.n_IsOpen));
			}
			return IKMutablePropertySetterInvoker.cb_isOpen;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002B52D File Offset: 0x0002972D
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0002B53C File Offset: 0x0002973C
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

		// Token: 0x06000C15 RID: 3093 RVA: 0x0002B57C File Offset: 0x0002977C
		private static Delegate GetGetNameHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_getName == null)
			{
				IKMutablePropertySetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertySetterInvoker.n_GetName));
			}
			return IKMutablePropertySetterInvoker.cb_getName;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0002B5A0 File Offset: 0x000297A0
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0002B5B4 File Offset: 0x000297B4
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

		// Token: 0x06000C18 RID: 3096 RVA: 0x0002B605 File Offset: 0x00029805
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_getParameters == null)
			{
				IKMutablePropertySetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertySetterInvoker.n_GetParameters));
			}
			return IKMutablePropertySetterInvoker.cb_getParameters;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0002B629 File Offset: 0x00029829
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0002B640 File Offset: 0x00029840
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

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002B691 File Offset: 0x00029891
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_getReturnType == null)
			{
				IKMutablePropertySetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertySetterInvoker.n_GetReturnType));
			}
			return IKMutablePropertySetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0002B6B5 File Offset: 0x000298B5
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0002B6CC File Offset: 0x000298CC
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

		// Token: 0x06000C1E RID: 3102 RVA: 0x0002B71D File Offset: 0x0002991D
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_getTypeParameters == null)
			{
				IKMutablePropertySetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertySetterInvoker.n_GetTypeParameters));
			}
			return IKMutablePropertySetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0002B741 File Offset: 0x00029941
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0002B758 File Offset: 0x00029958
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

		// Token: 0x06000C21 RID: 3105 RVA: 0x0002B7A9 File Offset: 0x000299A9
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_getVisibility == null)
			{
				IKMutablePropertySetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertySetterInvoker.n_GetVisibility));
			}
			return IKMutablePropertySetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002B7CD File Offset: 0x000299CD
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0002B7E4 File Offset: 0x000299E4
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

		// Token: 0x06000C24 RID: 3108 RVA: 0x0002B835 File Offset: 0x00029A35
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutablePropertySetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutablePropertySetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutablePropertySetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutablePropertySetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0002B85C File Offset: 0x00029A5C
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0002B8A0 File Offset: 0x00029AA0
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

		// Token: 0x06000C27 RID: 3111 RVA: 0x0002B921 File Offset: 0x00029B21
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutablePropertySetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutablePropertySetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutablePropertySetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutablePropertySetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0002B948 File Offset: 0x00029B48
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0002B970 File Offset: 0x00029B70
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

		// Token: 0x06000C2A RID: 3114 RVA: 0x0002B9E7 File Offset: 0x00029BE7
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_getAnnotations == null)
			{
				IKMutablePropertySetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertySetterInvoker.n_GetAnnotations));
			}
			return IKMutablePropertySetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0002BA0B File Offset: 0x00029C0B
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0002BA20 File Offset: 0x00029C20
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

		// Token: 0x06000C2D RID: 3117 RVA: 0x0002BA71 File Offset: 0x00029C71
		private static Delegate GetGetPropertyHandler()
		{
			if (IKMutablePropertySetterInvoker.cb_getProperty == null)
			{
				IKMutablePropertySetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertySetterInvoker.n_GetProperty));
			}
			return IKMutablePropertySetterInvoker.cb_getProperty;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0002BA95 File Offset: 0x00029C95
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutablePropertySetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0002BAAC File Offset: 0x00029CAC
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

		// Token: 0x040002E1 RID: 737
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty$Setter", typeof(IKMutablePropertySetterInvoker));

		// Token: 0x040002E2 RID: 738
		private IntPtr class_ref;

		// Token: 0x040002E3 RID: 739
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x040002E4 RID: 740
		private IntPtr id_isExternal;

		// Token: 0x040002E5 RID: 741
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x040002E6 RID: 742
		private IntPtr id_isInfix;

		// Token: 0x040002E7 RID: 743
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x040002E8 RID: 744
		private IntPtr id_isInline;

		// Token: 0x040002E9 RID: 745
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x040002EA RID: 746
		private IntPtr id_isOperator;

		// Token: 0x040002EB RID: 747
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x040002EC RID: 748
		private IntPtr id_isSuspend;

		// Token: 0x040002ED RID: 749
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040002EE RID: 750
		private IntPtr id_isAbstract;

		// Token: 0x040002EF RID: 751
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040002F0 RID: 752
		private IntPtr id_isFinal;

		// Token: 0x040002F1 RID: 753
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040002F2 RID: 754
		private IntPtr id_isOpen;

		// Token: 0x040002F3 RID: 755
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x040002F4 RID: 756
		private IntPtr id_getName;

		// Token: 0x040002F5 RID: 757
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x040002F6 RID: 758
		private IntPtr id_getParameters;

		// Token: 0x040002F7 RID: 759
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x040002F8 RID: 760
		private IntPtr id_getReturnType;

		// Token: 0x040002F9 RID: 761
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x040002FA RID: 762
		private IntPtr id_getTypeParameters;

		// Token: 0x040002FB RID: 763
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x040002FC RID: 764
		private IntPtr id_getVisibility;

		// Token: 0x040002FD RID: 765
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x040002FE RID: 766
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x040002FF RID: 767
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000300 RID: 768
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000301 RID: 769
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000302 RID: 770
		private IntPtr id_getAnnotations;

		// Token: 0x04000303 RID: 771
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x04000304 RID: 772
		private IntPtr id_getProperty;
	}
}
