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
	// Token: 0x0200010A RID: 266
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KFunction", DoNotGenerateAcw = true)]
	internal class IKFunctionInvoker : Java.Lang.Object, IKFunction, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKCallable, IKAnnotatedElement
	{
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0002A784 File Offset: 0x00028984
		private static IntPtr java_class_ref
		{
			get
			{
				return IKFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002A7A8 File Offset: 0x000289A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKFunctionInvoker._members;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0002A7AF File Offset: 0x000289AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0002A7B7 File Offset: 0x000289B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0002A7C3 File Offset: 0x000289C3
		[NullableContext(2)]
		public static IKFunction GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKFunction>(handle, transfer);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0002A7CC File Offset: 0x000289CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KFunction'.");
			}
			return handle;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0002A7F7 File Offset: 0x000289F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0002A828 File Offset: 0x00028A28
		public IKFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0002A860 File Offset: 0x00028A60
		private static Delegate GetIsExternalHandler()
		{
			if (IKFunctionInvoker.cb_isExternal == null)
			{
				IKFunctionInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsExternal));
			}
			return IKFunctionInvoker.cb_isExternal;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002A884 File Offset: 0x00028A84
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0002A893 File Offset: 0x00028A93
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

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0002A8D3 File Offset: 0x00028AD3
		private static Delegate GetIsInfixHandler()
		{
			if (IKFunctionInvoker.cb_isInfix == null)
			{
				IKFunctionInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsInfix));
			}
			return IKFunctionInvoker.cb_isInfix;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0002A8F7 File Offset: 0x00028AF7
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0002A906 File Offset: 0x00028B06
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

		// Token: 0x06000BCA RID: 3018 RVA: 0x0002A946 File Offset: 0x00028B46
		private static Delegate GetIsInlineHandler()
		{
			if (IKFunctionInvoker.cb_isInline == null)
			{
				IKFunctionInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsInline));
			}
			return IKFunctionInvoker.cb_isInline;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0002A96A File Offset: 0x00028B6A
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0002A979 File Offset: 0x00028B79
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

		// Token: 0x06000BCD RID: 3021 RVA: 0x0002A9B9 File Offset: 0x00028BB9
		private static Delegate GetIsOperatorHandler()
		{
			if (IKFunctionInvoker.cb_isOperator == null)
			{
				IKFunctionInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsOperator));
			}
			return IKFunctionInvoker.cb_isOperator;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0002A9DD File Offset: 0x00028BDD
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0002A9EC File Offset: 0x00028BEC
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

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0002AA2C File Offset: 0x00028C2C
		private static Delegate GetIsSuspendHandler()
		{
			if (IKFunctionInvoker.cb_isSuspend == null)
			{
				IKFunctionInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsSuspend));
			}
			return IKFunctionInvoker.cb_isSuspend;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0002AA50 File Offset: 0x00028C50
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0002AA5F File Offset: 0x00028C5F
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

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0002AA9F File Offset: 0x00028C9F
		private static Delegate GetIsAbstractHandler()
		{
			if (IKFunctionInvoker.cb_isAbstract == null)
			{
				IKFunctionInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsAbstract));
			}
			return IKFunctionInvoker.cb_isAbstract;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0002AAC3 File Offset: 0x00028CC3
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0002AAD2 File Offset: 0x00028CD2
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

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0002AB12 File Offset: 0x00028D12
		private static Delegate GetIsFinalHandler()
		{
			if (IKFunctionInvoker.cb_isFinal == null)
			{
				IKFunctionInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsFinal));
			}
			return IKFunctionInvoker.cb_isFinal;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0002AB36 File Offset: 0x00028D36
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0002AB45 File Offset: 0x00028D45
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

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002AB85 File Offset: 0x00028D85
		private static Delegate GetIsOpenHandler()
		{
			if (IKFunctionInvoker.cb_isOpen == null)
			{
				IKFunctionInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKFunctionInvoker.n_IsOpen));
			}
			return IKFunctionInvoker.cb_isOpen;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0002ABA9 File Offset: 0x00028DA9
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0002ABB8 File Offset: 0x00028DB8
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

		// Token: 0x06000BDC RID: 3036 RVA: 0x0002ABF8 File Offset: 0x00028DF8
		private static Delegate GetGetNameHandler()
		{
			if (IKFunctionInvoker.cb_getName == null)
			{
				IKFunctionInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKFunctionInvoker.n_GetName));
			}
			return IKFunctionInvoker.cb_getName;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002AC1C File Offset: 0x00028E1C
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0002AC30 File Offset: 0x00028E30
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

		// Token: 0x06000BDF RID: 3039 RVA: 0x0002AC81 File Offset: 0x00028E81
		private static Delegate GetGetParametersHandler()
		{
			if (IKFunctionInvoker.cb_getParameters == null)
			{
				IKFunctionInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKFunctionInvoker.n_GetParameters));
			}
			return IKFunctionInvoker.cb_getParameters;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0002ACA5 File Offset: 0x00028EA5
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0002ACBC File Offset: 0x00028EBC
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

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0002AD0D File Offset: 0x00028F0D
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKFunctionInvoker.cb_getReturnType == null)
			{
				IKFunctionInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKFunctionInvoker.n_GetReturnType));
			}
			return IKFunctionInvoker.cb_getReturnType;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0002AD31 File Offset: 0x00028F31
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0002AD48 File Offset: 0x00028F48
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

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0002AD99 File Offset: 0x00028F99
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKFunctionInvoker.cb_getTypeParameters == null)
			{
				IKFunctionInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKFunctionInvoker.n_GetTypeParameters));
			}
			return IKFunctionInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0002ADBD File Offset: 0x00028FBD
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0002ADD4 File Offset: 0x00028FD4
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

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0002AE25 File Offset: 0x00029025
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKFunctionInvoker.cb_getVisibility == null)
			{
				IKFunctionInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKFunctionInvoker.n_GetVisibility));
			}
			return IKFunctionInvoker.cb_getVisibility;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0002AE49 File Offset: 0x00029049
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0002AE60 File Offset: 0x00029060
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

		// Token: 0x06000BEB RID: 3051 RVA: 0x0002AEB1 File Offset: 0x000290B1
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKFunctionInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKFunctionInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKFunctionInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKFunctionInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0002AED8 File Offset: 0x000290D8
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0002AF1C File Offset: 0x0002911C
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

		// Token: 0x06000BEE RID: 3054 RVA: 0x0002AF9D File Offset: 0x0002919D
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKFunctionInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKFunctionInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKFunctionInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKFunctionInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0002AFC4 File Offset: 0x000291C4
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002AFEC File Offset: 0x000291EC
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

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0002B063 File Offset: 0x00029263
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKFunctionInvoker.cb_getAnnotations == null)
			{
				IKFunctionInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKFunctionInvoker.n_GetAnnotations));
			}
			return IKFunctionInvoker.cb_getAnnotations;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0002B087 File Offset: 0x00029287
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0002B09C File Offset: 0x0002929C
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

		// Token: 0x040002BF RID: 703
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KFunction", typeof(IKFunctionInvoker));

		// Token: 0x040002C0 RID: 704
		private IntPtr class_ref;

		// Token: 0x040002C1 RID: 705
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x040002C2 RID: 706
		private IntPtr id_isExternal;

		// Token: 0x040002C3 RID: 707
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x040002C4 RID: 708
		private IntPtr id_isInfix;

		// Token: 0x040002C5 RID: 709
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x040002C6 RID: 710
		private IntPtr id_isInline;

		// Token: 0x040002C7 RID: 711
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x040002C8 RID: 712
		private IntPtr id_isOperator;

		// Token: 0x040002C9 RID: 713
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x040002CA RID: 714
		private IntPtr id_isSuspend;

		// Token: 0x040002CB RID: 715
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040002CC RID: 716
		private IntPtr id_isAbstract;

		// Token: 0x040002CD RID: 717
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040002CE RID: 718
		private IntPtr id_isFinal;

		// Token: 0x040002CF RID: 719
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040002D0 RID: 720
		private IntPtr id_isOpen;

		// Token: 0x040002D1 RID: 721
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x040002D2 RID: 722
		private IntPtr id_getName;

		// Token: 0x040002D3 RID: 723
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x040002D4 RID: 724
		private IntPtr id_getParameters;

		// Token: 0x040002D5 RID: 725
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x040002D6 RID: 726
		private IntPtr id_getReturnType;

		// Token: 0x040002D7 RID: 727
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x040002D8 RID: 728
		private IntPtr id_getTypeParameters;

		// Token: 0x040002D9 RID: 729
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x040002DA RID: 730
		private IntPtr id_getVisibility;

		// Token: 0x040002DB RID: 731
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x040002DC RID: 732
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x040002DD RID: 733
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x040002DE RID: 734
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x040002DF RID: 735
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x040002E0 RID: 736
		private IntPtr id_getAnnotations;
	}
}
