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
	// Token: 0x0200012B RID: 299
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty1$Getter", DoNotGenerateAcw = true)]
	internal class IKProperty1GetterInvoker : Java.Lang.Object, IKProperty1Getter, IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKPropertyGetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00033DFC File Offset: 0x00031FFC
		private static IntPtr java_class_ref
		{
			get
			{
				return IKProperty1GetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00033E20 File Offset: 0x00032020
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKProperty1GetterInvoker._members;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00033E27 File Offset: 0x00032027
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00033E2F File Offset: 0x0003202F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKProperty1GetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00033E3B File Offset: 0x0003203B
		[NullableContext(2)]
		public static IKProperty1Getter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(handle, transfer);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00033E44 File Offset: 0x00032044
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKProperty1GetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty1.Getter'.");
			}
			return handle;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00033E6F File Offset: 0x0003206F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00033EA0 File Offset: 0x000320A0
		public IKProperty1GetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKProperty1GetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00033ED8 File Offset: 0x000320D8
		private static Delegate GetInvoke_Ljava_lang_Object_Handler()
		{
			if (IKProperty1GetterInvoker.cb_invoke_Ljava_lang_Object_ == null)
			{
				IKProperty1GetterInvoker.cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1GetterInvoker.n_Invoke_Ljava_lang_Object_));
			}
			return IKProperty1GetterInvoker.cb_invoke_Ljava_lang_Object_;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00033EFC File Offset: 0x000320FC
		private static IntPtr n_Invoke_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFunction1 @object = Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2));
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00033F24 File Offset: 0x00032124
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0)
		{
			if (this.id_invoke_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00033F9B File Offset: 0x0003219B
		private static Delegate GetIsExternalHandler()
		{
			if (IKProperty1GetterInvoker.cb_isExternal == null)
			{
				IKProperty1GetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsExternal));
			}
			return IKProperty1GetterInvoker.cb_isExternal;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00033FBF File Offset: 0x000321BF
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00033FCE File Offset: 0x000321CE
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

		// Token: 0x06000F4A RID: 3914 RVA: 0x0003400E File Offset: 0x0003220E
		private static Delegate GetIsInfixHandler()
		{
			if (IKProperty1GetterInvoker.cb_isInfix == null)
			{
				IKProperty1GetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsInfix));
			}
			return IKProperty1GetterInvoker.cb_isInfix;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00034032 File Offset: 0x00032232
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00034041 File Offset: 0x00032241
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

		// Token: 0x06000F4D RID: 3917 RVA: 0x00034081 File Offset: 0x00032281
		private static Delegate GetIsInlineHandler()
		{
			if (IKProperty1GetterInvoker.cb_isInline == null)
			{
				IKProperty1GetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsInline));
			}
			return IKProperty1GetterInvoker.cb_isInline;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000340A5 File Offset: 0x000322A5
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000340B4 File Offset: 0x000322B4
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

		// Token: 0x06000F50 RID: 3920 RVA: 0x000340F4 File Offset: 0x000322F4
		private static Delegate GetIsOperatorHandler()
		{
			if (IKProperty1GetterInvoker.cb_isOperator == null)
			{
				IKProperty1GetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsOperator));
			}
			return IKProperty1GetterInvoker.cb_isOperator;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00034118 File Offset: 0x00032318
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00034127 File Offset: 0x00032327
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

		// Token: 0x06000F53 RID: 3923 RVA: 0x00034167 File Offset: 0x00032367
		private static Delegate GetIsSuspendHandler()
		{
			if (IKProperty1GetterInvoker.cb_isSuspend == null)
			{
				IKProperty1GetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsSuspend));
			}
			return IKProperty1GetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0003418B File Offset: 0x0003238B
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x0003419A File Offset: 0x0003239A
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

		// Token: 0x06000F56 RID: 3926 RVA: 0x000341DA File Offset: 0x000323DA
		private static Delegate GetIsAbstractHandler()
		{
			if (IKProperty1GetterInvoker.cb_isAbstract == null)
			{
				IKProperty1GetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsAbstract));
			}
			return IKProperty1GetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000341FE File Offset: 0x000323FE
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0003420D File Offset: 0x0003240D
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

		// Token: 0x06000F59 RID: 3929 RVA: 0x0003424D File Offset: 0x0003244D
		private static Delegate GetIsFinalHandler()
		{
			if (IKProperty1GetterInvoker.cb_isFinal == null)
			{
				IKProperty1GetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsFinal));
			}
			return IKProperty1GetterInvoker.cb_isFinal;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00034271 File Offset: 0x00032471
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00034280 File Offset: 0x00032480
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

		// Token: 0x06000F5C RID: 3932 RVA: 0x000342C0 File Offset: 0x000324C0
		private static Delegate GetIsOpenHandler()
		{
			if (IKProperty1GetterInvoker.cb_isOpen == null)
			{
				IKProperty1GetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1GetterInvoker.n_IsOpen));
			}
			return IKProperty1GetterInvoker.cb_isOpen;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000342E4 File Offset: 0x000324E4
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000342F3 File Offset: 0x000324F3
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

		// Token: 0x06000F5F RID: 3935 RVA: 0x00034333 File Offset: 0x00032533
		private static Delegate GetGetNameHandler()
		{
			if (IKProperty1GetterInvoker.cb_getName == null)
			{
				IKProperty1GetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1GetterInvoker.n_GetName));
			}
			return IKProperty1GetterInvoker.cb_getName;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00034357 File Offset: 0x00032557
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0003436C File Offset: 0x0003256C
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

		// Token: 0x06000F62 RID: 3938 RVA: 0x000343BD File Offset: 0x000325BD
		private static Delegate GetGetParametersHandler()
		{
			if (IKProperty1GetterInvoker.cb_getParameters == null)
			{
				IKProperty1GetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1GetterInvoker.n_GetParameters));
			}
			return IKProperty1GetterInvoker.cb_getParameters;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000343E1 File Offset: 0x000325E1
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000343F8 File Offset: 0x000325F8
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

		// Token: 0x06000F65 RID: 3941 RVA: 0x00034449 File Offset: 0x00032649
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKProperty1GetterInvoker.cb_getReturnType == null)
			{
				IKProperty1GetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1GetterInvoker.n_GetReturnType));
			}
			return IKProperty1GetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0003446D File Offset: 0x0003266D
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00034484 File Offset: 0x00032684
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

		// Token: 0x06000F68 RID: 3944 RVA: 0x000344D5 File Offset: 0x000326D5
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKProperty1GetterInvoker.cb_getTypeParameters == null)
			{
				IKProperty1GetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1GetterInvoker.n_GetTypeParameters));
			}
			return IKProperty1GetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000344F9 File Offset: 0x000326F9
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00034510 File Offset: 0x00032710
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

		// Token: 0x06000F6B RID: 3947 RVA: 0x00034561 File Offset: 0x00032761
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKProperty1GetterInvoker.cb_getVisibility == null)
			{
				IKProperty1GetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1GetterInvoker.n_GetVisibility));
			}
			return IKProperty1GetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00034585 File Offset: 0x00032785
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0003459C File Offset: 0x0003279C
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

		// Token: 0x06000F6E RID: 3950 RVA: 0x000345ED File Offset: 0x000327ED
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKProperty1GetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKProperty1GetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1GetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKProperty1GetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00034614 File Offset: 0x00032814
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00034658 File Offset: 0x00032858
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

		// Token: 0x06000F71 RID: 3953 RVA: 0x000346D9 File Offset: 0x000328D9
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKProperty1GetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKProperty1GetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1GetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKProperty1GetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00034700 File Offset: 0x00032900
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00034728 File Offset: 0x00032928
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

		// Token: 0x06000F74 RID: 3956 RVA: 0x0003479F File Offset: 0x0003299F
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKProperty1GetterInvoker.cb_getAnnotations == null)
			{
				IKProperty1GetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1GetterInvoker.n_GetAnnotations));
			}
			return IKProperty1GetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000347C3 File Offset: 0x000329C3
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000347D8 File Offset: 0x000329D8
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

		// Token: 0x06000F77 RID: 3959 RVA: 0x00034829 File Offset: 0x00032A29
		private static Delegate GetGetPropertyHandler()
		{
			if (IKProperty1GetterInvoker.cb_getProperty == null)
			{
				IKProperty1GetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1GetterInvoker.n_GetProperty));
			}
			return IKProperty1GetterInvoker.cb_getProperty;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0003484D File Offset: 0x00032A4D
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00034864 File Offset: 0x00032A64
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

		// Token: 0x040004BE RID: 1214
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty1$Getter", typeof(IKProperty1GetterInvoker));

		// Token: 0x040004BF RID: 1215
		private IntPtr class_ref;

		// Token: 0x040004C0 RID: 1216
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_;

		// Token: 0x040004C1 RID: 1217
		private IntPtr id_invoke_Ljava_lang_Object_;

		// Token: 0x040004C2 RID: 1218
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x040004C3 RID: 1219
		private IntPtr id_isExternal;

		// Token: 0x040004C4 RID: 1220
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x040004C5 RID: 1221
		private IntPtr id_isInfix;

		// Token: 0x040004C6 RID: 1222
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x040004C7 RID: 1223
		private IntPtr id_isInline;

		// Token: 0x040004C8 RID: 1224
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x040004C9 RID: 1225
		private IntPtr id_isOperator;

		// Token: 0x040004CA RID: 1226
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x040004CB RID: 1227
		private IntPtr id_isSuspend;

		// Token: 0x040004CC RID: 1228
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040004CD RID: 1229
		private IntPtr id_isAbstract;

		// Token: 0x040004CE RID: 1230
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040004CF RID: 1231
		private IntPtr id_isFinal;

		// Token: 0x040004D0 RID: 1232
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040004D1 RID: 1233
		private IntPtr id_isOpen;

		// Token: 0x040004D2 RID: 1234
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x040004D3 RID: 1235
		private IntPtr id_getName;

		// Token: 0x040004D4 RID: 1236
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x040004D5 RID: 1237
		private IntPtr id_getParameters;

		// Token: 0x040004D6 RID: 1238
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x040004D7 RID: 1239
		private IntPtr id_getReturnType;

		// Token: 0x040004D8 RID: 1240
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x040004D9 RID: 1241
		private IntPtr id_getTypeParameters;

		// Token: 0x040004DA RID: 1242
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x040004DB RID: 1243
		private IntPtr id_getVisibility;

		// Token: 0x040004DC RID: 1244
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x040004DD RID: 1245
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x040004DE RID: 1246
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x040004DF RID: 1247
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x040004E0 RID: 1248
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x040004E1 RID: 1249
		private IntPtr id_getAnnotations;

		// Token: 0x040004E2 RID: 1250
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x040004E3 RID: 1251
		private IntPtr id_getProperty;
	}
}
