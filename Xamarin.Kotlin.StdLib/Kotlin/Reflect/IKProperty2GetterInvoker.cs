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
	// Token: 0x0200012F RID: 303
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty2$Getter", DoNotGenerateAcw = true)]
	internal class IKProperty2GetterInvoker : Java.Lang.Object, IKProperty2Getter, IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKPropertyGetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00035448 File Offset: 0x00033648
		private static IntPtr java_class_ref
		{
			get
			{
				return IKProperty2GetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0003546C File Offset: 0x0003366C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKProperty2GetterInvoker._members;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00035473 File Offset: 0x00033673
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0003547B File Offset: 0x0003367B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKProperty2GetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00035487 File Offset: 0x00033687
		[NullableContext(2)]
		public static IKProperty2Getter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(handle, transfer);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00035490 File Offset: 0x00033690
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKProperty2GetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty2.Getter'.");
			}
			return handle;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000354BB File Offset: 0x000336BB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x000354EC File Offset: 0x000336EC
		public IKProperty2GetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKProperty2GetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00035524 File Offset: 0x00033724
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKProperty2GetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKProperty2GetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKProperty2GetterInvoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKProperty2GetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00035548 File Offset: 0x00033748
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFunction2 @object = Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3));
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0003557C File Offset: 0x0003377C
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00035613 File Offset: 0x00033813
		private static Delegate GetIsExternalHandler()
		{
			if (IKProperty2GetterInvoker.cb_isExternal == null)
			{
				IKProperty2GetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsExternal));
			}
			return IKProperty2GetterInvoker.cb_isExternal;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00035637 File Offset: 0x00033837
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00035646 File Offset: 0x00033846
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

		// Token: 0x06000FCB RID: 4043 RVA: 0x00035686 File Offset: 0x00033886
		private static Delegate GetIsInfixHandler()
		{
			if (IKProperty2GetterInvoker.cb_isInfix == null)
			{
				IKProperty2GetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsInfix));
			}
			return IKProperty2GetterInvoker.cb_isInfix;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000356AA File Offset: 0x000338AA
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x000356B9 File Offset: 0x000338B9
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

		// Token: 0x06000FCE RID: 4046 RVA: 0x000356F9 File Offset: 0x000338F9
		private static Delegate GetIsInlineHandler()
		{
			if (IKProperty2GetterInvoker.cb_isInline == null)
			{
				IKProperty2GetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsInline));
			}
			return IKProperty2GetterInvoker.cb_isInline;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0003571D File Offset: 0x0003391D
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0003572C File Offset: 0x0003392C
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

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0003576C File Offset: 0x0003396C
		private static Delegate GetIsOperatorHandler()
		{
			if (IKProperty2GetterInvoker.cb_isOperator == null)
			{
				IKProperty2GetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsOperator));
			}
			return IKProperty2GetterInvoker.cb_isOperator;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00035790 File Offset: 0x00033990
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0003579F File Offset: 0x0003399F
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

		// Token: 0x06000FD4 RID: 4052 RVA: 0x000357DF File Offset: 0x000339DF
		private static Delegate GetIsSuspendHandler()
		{
			if (IKProperty2GetterInvoker.cb_isSuspend == null)
			{
				IKProperty2GetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsSuspend));
			}
			return IKProperty2GetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00035803 File Offset: 0x00033A03
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00035812 File Offset: 0x00033A12
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

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00035852 File Offset: 0x00033A52
		private static Delegate GetIsAbstractHandler()
		{
			if (IKProperty2GetterInvoker.cb_isAbstract == null)
			{
				IKProperty2GetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsAbstract));
			}
			return IKProperty2GetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00035876 File Offset: 0x00033A76
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00035885 File Offset: 0x00033A85
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

		// Token: 0x06000FDA RID: 4058 RVA: 0x000358C5 File Offset: 0x00033AC5
		private static Delegate GetIsFinalHandler()
		{
			if (IKProperty2GetterInvoker.cb_isFinal == null)
			{
				IKProperty2GetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsFinal));
			}
			return IKProperty2GetterInvoker.cb_isFinal;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000358E9 File Offset: 0x00033AE9
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x000358F8 File Offset: 0x00033AF8
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

		// Token: 0x06000FDD RID: 4061 RVA: 0x00035938 File Offset: 0x00033B38
		private static Delegate GetIsOpenHandler()
		{
			if (IKProperty2GetterInvoker.cb_isOpen == null)
			{
				IKProperty2GetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2GetterInvoker.n_IsOpen));
			}
			return IKProperty2GetterInvoker.cb_isOpen;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0003595C File Offset: 0x00033B5C
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0003596B File Offset: 0x00033B6B
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

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000359AB File Offset: 0x00033BAB
		private static Delegate GetGetNameHandler()
		{
			if (IKProperty2GetterInvoker.cb_getName == null)
			{
				IKProperty2GetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2GetterInvoker.n_GetName));
			}
			return IKProperty2GetterInvoker.cb_getName;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000359CF File Offset: 0x00033BCF
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x000359E4 File Offset: 0x00033BE4
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

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00035A35 File Offset: 0x00033C35
		private static Delegate GetGetParametersHandler()
		{
			if (IKProperty2GetterInvoker.cb_getParameters == null)
			{
				IKProperty2GetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2GetterInvoker.n_GetParameters));
			}
			return IKProperty2GetterInvoker.cb_getParameters;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00035A59 File Offset: 0x00033C59
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00035A70 File Offset: 0x00033C70
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

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00035AC1 File Offset: 0x00033CC1
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKProperty2GetterInvoker.cb_getReturnType == null)
			{
				IKProperty2GetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2GetterInvoker.n_GetReturnType));
			}
			return IKProperty2GetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00035AE5 File Offset: 0x00033CE5
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00035AFC File Offset: 0x00033CFC
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

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00035B4D File Offset: 0x00033D4D
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKProperty2GetterInvoker.cb_getTypeParameters == null)
			{
				IKProperty2GetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2GetterInvoker.n_GetTypeParameters));
			}
			return IKProperty2GetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00035B71 File Offset: 0x00033D71
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00035B88 File Offset: 0x00033D88
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

		// Token: 0x06000FEC RID: 4076 RVA: 0x00035BD9 File Offset: 0x00033DD9
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKProperty2GetterInvoker.cb_getVisibility == null)
			{
				IKProperty2GetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2GetterInvoker.n_GetVisibility));
			}
			return IKProperty2GetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00035BFD File Offset: 0x00033DFD
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00035C14 File Offset: 0x00033E14
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

		// Token: 0x06000FEF RID: 4079 RVA: 0x00035C65 File Offset: 0x00033E65
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKProperty2GetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKProperty2GetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty2GetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKProperty2GetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00035C8C File Offset: 0x00033E8C
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00035CD0 File Offset: 0x00033ED0
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

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00035D51 File Offset: 0x00033F51
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKProperty2GetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKProperty2GetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty2GetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKProperty2GetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00035D78 File Offset: 0x00033F78
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00035DA0 File Offset: 0x00033FA0
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

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00035E17 File Offset: 0x00034017
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKProperty2GetterInvoker.cb_getAnnotations == null)
			{
				IKProperty2GetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2GetterInvoker.n_GetAnnotations));
			}
			return IKProperty2GetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00035E3B File Offset: 0x0003403B
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00035E50 File Offset: 0x00034050
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

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00035EA1 File Offset: 0x000340A1
		private static Delegate GetGetPropertyHandler()
		{
			if (IKProperty2GetterInvoker.cb_getProperty == null)
			{
				IKProperty2GetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2GetterInvoker.n_GetProperty));
			}
			return IKProperty2GetterInvoker.cb_getProperty;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00035EC5 File Offset: 0x000340C5
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00035EDC File Offset: 0x000340DC
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

		// Token: 0x0400050A RID: 1290
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty2$Getter", typeof(IKProperty2GetterInvoker));

		// Token: 0x0400050B RID: 1291
		private IntPtr class_ref;

		// Token: 0x0400050C RID: 1292
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400050D RID: 1293
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400050E RID: 1294
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x0400050F RID: 1295
		private IntPtr id_isExternal;

		// Token: 0x04000510 RID: 1296
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x04000511 RID: 1297
		private IntPtr id_isInfix;

		// Token: 0x04000512 RID: 1298
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x04000513 RID: 1299
		private IntPtr id_isInline;

		// Token: 0x04000514 RID: 1300
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x04000515 RID: 1301
		private IntPtr id_isOperator;

		// Token: 0x04000516 RID: 1302
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000517 RID: 1303
		private IntPtr id_isSuspend;

		// Token: 0x04000518 RID: 1304
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x04000519 RID: 1305
		private IntPtr id_isAbstract;

		// Token: 0x0400051A RID: 1306
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x0400051B RID: 1307
		private IntPtr id_isFinal;

		// Token: 0x0400051C RID: 1308
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x0400051D RID: 1309
		private IntPtr id_isOpen;

		// Token: 0x0400051E RID: 1310
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x0400051F RID: 1311
		private IntPtr id_getName;

		// Token: 0x04000520 RID: 1312
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x04000521 RID: 1313
		private IntPtr id_getParameters;

		// Token: 0x04000522 RID: 1314
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x04000523 RID: 1315
		private IntPtr id_getReturnType;

		// Token: 0x04000524 RID: 1316
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000525 RID: 1317
		private IntPtr id_getTypeParameters;

		// Token: 0x04000526 RID: 1318
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x04000527 RID: 1319
		private IntPtr id_getVisibility;

		// Token: 0x04000528 RID: 1320
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000529 RID: 1321
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x0400052A RID: 1322
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x0400052B RID: 1323
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x0400052C RID: 1324
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x0400052D RID: 1325
		private IntPtr id_getAnnotations;

		// Token: 0x0400052E RID: 1326
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x0400052F RID: 1327
		private IntPtr id_getProperty;
	}
}
