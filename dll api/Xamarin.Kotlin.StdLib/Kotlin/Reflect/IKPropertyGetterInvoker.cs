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
	// Token: 0x02000123 RID: 291
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty$Getter", DoNotGenerateAcw = true)]
	internal class IKPropertyGetterInvoker : Java.Lang.Object, IKPropertyGetter, IKFunction, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x0003155C File Offset: 0x0002F75C
		private static IntPtr java_class_ref
		{
			get
			{
				return IKPropertyGetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00031580 File Offset: 0x0002F780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKPropertyGetterInvoker._members;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00031587 File Offset: 0x0002F787
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0003158F File Offset: 0x0002F78F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKPropertyGetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0003159B File Offset: 0x0002F79B
		[NullableContext(2)]
		public static IKPropertyGetter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(handle, transfer);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000315A4 File Offset: 0x0002F7A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKPropertyGetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty.Getter'.");
			}
			return handle;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000315CF File Offset: 0x0002F7CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00031600 File Offset: 0x0002F800
		public IKPropertyGetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKPropertyGetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00031638 File Offset: 0x0002F838
		private static Delegate GetIsExternalHandler()
		{
			if (IKPropertyGetterInvoker.cb_isExternal == null)
			{
				IKPropertyGetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsExternal));
			}
			return IKPropertyGetterInvoker.cb_isExternal;
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0003165C File Offset: 0x0002F85C
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0003166B File Offset: 0x0002F86B
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

		// Token: 0x06000E51 RID: 3665 RVA: 0x000316AB File Offset: 0x0002F8AB
		private static Delegate GetIsInfixHandler()
		{
			if (IKPropertyGetterInvoker.cb_isInfix == null)
			{
				IKPropertyGetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsInfix));
			}
			return IKPropertyGetterInvoker.cb_isInfix;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000316CF File Offset: 0x0002F8CF
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000316DE File Offset: 0x0002F8DE
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

		// Token: 0x06000E54 RID: 3668 RVA: 0x0003171E File Offset: 0x0002F91E
		private static Delegate GetIsInlineHandler()
		{
			if (IKPropertyGetterInvoker.cb_isInline == null)
			{
				IKPropertyGetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsInline));
			}
			return IKPropertyGetterInvoker.cb_isInline;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00031742 File Offset: 0x0002F942
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00031751 File Offset: 0x0002F951
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

		// Token: 0x06000E57 RID: 3671 RVA: 0x00031791 File Offset: 0x0002F991
		private static Delegate GetIsOperatorHandler()
		{
			if (IKPropertyGetterInvoker.cb_isOperator == null)
			{
				IKPropertyGetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsOperator));
			}
			return IKPropertyGetterInvoker.cb_isOperator;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000317B5 File Offset: 0x0002F9B5
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x000317C4 File Offset: 0x0002F9C4
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

		// Token: 0x06000E5A RID: 3674 RVA: 0x00031804 File Offset: 0x0002FA04
		private static Delegate GetIsSuspendHandler()
		{
			if (IKPropertyGetterInvoker.cb_isSuspend == null)
			{
				IKPropertyGetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsSuspend));
			}
			return IKPropertyGetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00031828 File Offset: 0x0002FA28
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00031837 File Offset: 0x0002FA37
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

		// Token: 0x06000E5D RID: 3677 RVA: 0x00031877 File Offset: 0x0002FA77
		private static Delegate GetIsAbstractHandler()
		{
			if (IKPropertyGetterInvoker.cb_isAbstract == null)
			{
				IKPropertyGetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsAbstract));
			}
			return IKPropertyGetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0003189B File Offset: 0x0002FA9B
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x000318AA File Offset: 0x0002FAAA
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

		// Token: 0x06000E60 RID: 3680 RVA: 0x000318EA File Offset: 0x0002FAEA
		private static Delegate GetIsFinalHandler()
		{
			if (IKPropertyGetterInvoker.cb_isFinal == null)
			{
				IKPropertyGetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsFinal));
			}
			return IKPropertyGetterInvoker.cb_isFinal;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0003190E File Offset: 0x0002FB0E
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0003191D File Offset: 0x0002FB1D
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

		// Token: 0x06000E63 RID: 3683 RVA: 0x0003195D File Offset: 0x0002FB5D
		private static Delegate GetIsOpenHandler()
		{
			if (IKPropertyGetterInvoker.cb_isOpen == null)
			{
				IKPropertyGetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyGetterInvoker.n_IsOpen));
			}
			return IKPropertyGetterInvoker.cb_isOpen;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00031981 File Offset: 0x0002FB81
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00031990 File Offset: 0x0002FB90
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

		// Token: 0x06000E66 RID: 3686 RVA: 0x000319D0 File Offset: 0x0002FBD0
		private static Delegate GetGetNameHandler()
		{
			if (IKPropertyGetterInvoker.cb_getName == null)
			{
				IKPropertyGetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyGetterInvoker.n_GetName));
			}
			return IKPropertyGetterInvoker.cb_getName;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000319F4 File Offset: 0x0002FBF4
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00031A08 File Offset: 0x0002FC08
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

		// Token: 0x06000E69 RID: 3689 RVA: 0x00031A59 File Offset: 0x0002FC59
		private static Delegate GetGetParametersHandler()
		{
			if (IKPropertyGetterInvoker.cb_getParameters == null)
			{
				IKPropertyGetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyGetterInvoker.n_GetParameters));
			}
			return IKPropertyGetterInvoker.cb_getParameters;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00031A7D File Offset: 0x0002FC7D
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00031A94 File Offset: 0x0002FC94
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

		// Token: 0x06000E6C RID: 3692 RVA: 0x00031AE5 File Offset: 0x0002FCE5
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKPropertyGetterInvoker.cb_getReturnType == null)
			{
				IKPropertyGetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyGetterInvoker.n_GetReturnType));
			}
			return IKPropertyGetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00031B09 File Offset: 0x0002FD09
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00031B20 File Offset: 0x0002FD20
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

		// Token: 0x06000E6F RID: 3695 RVA: 0x00031B71 File Offset: 0x0002FD71
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKPropertyGetterInvoker.cb_getTypeParameters == null)
			{
				IKPropertyGetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyGetterInvoker.n_GetTypeParameters));
			}
			return IKPropertyGetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00031B95 File Offset: 0x0002FD95
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00031BAC File Offset: 0x0002FDAC
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

		// Token: 0x06000E72 RID: 3698 RVA: 0x00031BFD File Offset: 0x0002FDFD
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKPropertyGetterInvoker.cb_getVisibility == null)
			{
				IKPropertyGetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyGetterInvoker.n_GetVisibility));
			}
			return IKPropertyGetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00031C21 File Offset: 0x0002FE21
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00031C38 File Offset: 0x0002FE38
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

		// Token: 0x06000E75 RID: 3701 RVA: 0x00031C89 File Offset: 0x0002FE89
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKPropertyGetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKPropertyGetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKPropertyGetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKPropertyGetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00031CF4 File Offset: 0x0002FEF4
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

		// Token: 0x06000E78 RID: 3704 RVA: 0x00031D75 File Offset: 0x0002FF75
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKPropertyGetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKPropertyGetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKPropertyGetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKPropertyGetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00031D9C File Offset: 0x0002FF9C
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00031DC4 File Offset: 0x0002FFC4
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

		// Token: 0x06000E7B RID: 3707 RVA: 0x00031E3B File Offset: 0x0003003B
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKPropertyGetterInvoker.cb_getAnnotations == null)
			{
				IKPropertyGetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyGetterInvoker.n_GetAnnotations));
			}
			return IKPropertyGetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00031E5F File Offset: 0x0003005F
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00031E74 File Offset: 0x00030074
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

		// Token: 0x06000E7E RID: 3710 RVA: 0x00031EC5 File Offset: 0x000300C5
		private static Delegate GetGetPropertyHandler()
		{
			if (IKPropertyGetterInvoker.cb_getProperty == null)
			{
				IKPropertyGetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyGetterInvoker.n_GetProperty));
			}
			return IKPropertyGetterInvoker.cb_getProperty;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00031EE9 File Offset: 0x000300E9
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKPropertyGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00031F00 File Offset: 0x00030100
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

		// Token: 0x0400042E RID: 1070
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty$Getter", typeof(IKPropertyGetterInvoker));

		// Token: 0x0400042F RID: 1071
		private IntPtr class_ref;

		// Token: 0x04000430 RID: 1072
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x04000431 RID: 1073
		private IntPtr id_isExternal;

		// Token: 0x04000432 RID: 1074
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x04000433 RID: 1075
		private IntPtr id_isInfix;

		// Token: 0x04000434 RID: 1076
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x04000435 RID: 1077
		private IntPtr id_isInline;

		// Token: 0x04000436 RID: 1078
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x04000437 RID: 1079
		private IntPtr id_isOperator;

		// Token: 0x04000438 RID: 1080
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000439 RID: 1081
		private IntPtr id_isSuspend;

		// Token: 0x0400043A RID: 1082
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x0400043B RID: 1083
		private IntPtr id_isAbstract;

		// Token: 0x0400043C RID: 1084
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x0400043D RID: 1085
		private IntPtr id_isFinal;

		// Token: 0x0400043E RID: 1086
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x0400043F RID: 1087
		private IntPtr id_isOpen;

		// Token: 0x04000440 RID: 1088
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000441 RID: 1089
		private IntPtr id_getName;

		// Token: 0x04000442 RID: 1090
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x04000443 RID: 1091
		private IntPtr id_getParameters;

		// Token: 0x04000444 RID: 1092
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x04000445 RID: 1093
		private IntPtr id_getReturnType;

		// Token: 0x04000446 RID: 1094
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000447 RID: 1095
		private IntPtr id_getTypeParameters;

		// Token: 0x04000448 RID: 1096
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x04000449 RID: 1097
		private IntPtr id_getVisibility;

		// Token: 0x0400044A RID: 1098
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x0400044B RID: 1099
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x0400044C RID: 1100
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x0400044D RID: 1101
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x0400044E RID: 1102
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x0400044F RID: 1103
		private IntPtr id_getAnnotations;

		// Token: 0x04000450 RID: 1104
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x04000451 RID: 1105
		private IntPtr id_getProperty;
	}
}
