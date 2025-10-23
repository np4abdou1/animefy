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
	// Token: 0x02000110 RID: 272
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty0$Setter", DoNotGenerateAcw = true)]
	internal class IKMutableProperty0SetterInvoker : Java.Lang.Object, IKMutableProperty0Setter, IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKMutablePropertySetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0002C4CC File Offset: 0x0002A6CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableProperty0SetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutableProperty0SetterInvoker._members;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0002C4F7 File Offset: 0x0002A6F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x0002C4FF File Offset: 0x0002A6FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutableProperty0SetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0002C50B File Offset: 0x0002A70B
		[NullableContext(2)]
		public static IKMutableProperty0Setter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(handle, transfer);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0002C514 File Offset: 0x0002A714
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableProperty0SetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty0.Setter'.");
			}
			return handle;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0002C53F File Offset: 0x0002A73F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0002C570 File Offset: 0x0002A770
		public IKMutableProperty0SetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableProperty0SetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
		private static Delegate GetInvoke_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty0SetterInvoker.cb_invoke_Ljava_lang_Object_ == null)
			{
				IKMutableProperty0SetterInvoker.cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty0SetterInvoker.n_Invoke_Ljava_lang_Object_));
			}
			return IKMutableProperty0SetterInvoker.cb_invoke_Ljava_lang_Object_;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0002C5CC File Offset: 0x0002A7CC
		private static IntPtr n_Invoke_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFunction1 @object = Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2));
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0002C5F4 File Offset: 0x0002A7F4
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

		// Token: 0x06000C76 RID: 3190 RVA: 0x0002C66B File Offset: 0x0002A86B
		private static Delegate GetIsExternalHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isExternal == null)
			{
				IKMutableProperty0SetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsExternal));
			}
			return IKMutableProperty0SetterInvoker.cb_isExternal;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0002C68F File Offset: 0x0002A88F
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0002C69E File Offset: 0x0002A89E
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

		// Token: 0x06000C79 RID: 3193 RVA: 0x0002C6DE File Offset: 0x0002A8DE
		private static Delegate GetIsInfixHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isInfix == null)
			{
				IKMutableProperty0SetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsInfix));
			}
			return IKMutableProperty0SetterInvoker.cb_isInfix;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0002C702 File Offset: 0x0002A902
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0002C711 File Offset: 0x0002A911
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

		// Token: 0x06000C7C RID: 3196 RVA: 0x0002C751 File Offset: 0x0002A951
		private static Delegate GetIsInlineHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isInline == null)
			{
				IKMutableProperty0SetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsInline));
			}
			return IKMutableProperty0SetterInvoker.cb_isInline;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0002C775 File Offset: 0x0002A975
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0002C784 File Offset: 0x0002A984
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

		// Token: 0x06000C7F RID: 3199 RVA: 0x0002C7C4 File Offset: 0x0002A9C4
		private static Delegate GetIsOperatorHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isOperator == null)
			{
				IKMutableProperty0SetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsOperator));
			}
			return IKMutableProperty0SetterInvoker.cb_isOperator;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0002C7F7 File Offset: 0x0002A9F7
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

		// Token: 0x06000C82 RID: 3202 RVA: 0x0002C837 File Offset: 0x0002AA37
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isSuspend == null)
			{
				IKMutableProperty0SetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsSuspend));
			}
			return IKMutableProperty0SetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0002C85B File Offset: 0x0002AA5B
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0002C86A File Offset: 0x0002AA6A
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

		// Token: 0x06000C85 RID: 3205 RVA: 0x0002C8AA File Offset: 0x0002AAAA
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isAbstract == null)
			{
				IKMutableProperty0SetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsAbstract));
			}
			return IKMutableProperty0SetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0002C8CE File Offset: 0x0002AACE
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0002C8DD File Offset: 0x0002AADD
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

		// Token: 0x06000C88 RID: 3208 RVA: 0x0002C91D File Offset: 0x0002AB1D
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isFinal == null)
			{
				IKMutableProperty0SetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsFinal));
			}
			return IKMutableProperty0SetterInvoker.cb_isFinal;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0002C941 File Offset: 0x0002AB41
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0002C950 File Offset: 0x0002AB50
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

		// Token: 0x06000C8B RID: 3211 RVA: 0x0002C990 File Offset: 0x0002AB90
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_isOpen == null)
			{
				IKMutableProperty0SetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0SetterInvoker.n_IsOpen));
			}
			return IKMutableProperty0SetterInvoker.cb_isOpen;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0002C9B4 File Offset: 0x0002ABB4
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0002C9C3 File Offset: 0x0002ABC3
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

		// Token: 0x06000C8E RID: 3214 RVA: 0x0002CA03 File Offset: 0x0002AC03
		private static Delegate GetGetNameHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_getName == null)
			{
				IKMutableProperty0SetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0SetterInvoker.n_GetName));
			}
			return IKMutableProperty0SetterInvoker.cb_getName;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0002CA27 File Offset: 0x0002AC27
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0002CA3C File Offset: 0x0002AC3C
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

		// Token: 0x06000C91 RID: 3217 RVA: 0x0002CA8D File Offset: 0x0002AC8D
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_getParameters == null)
			{
				IKMutableProperty0SetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0SetterInvoker.n_GetParameters));
			}
			return IKMutableProperty0SetterInvoker.cb_getParameters;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0002CAB1 File Offset: 0x0002ACB1
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
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

		// Token: 0x06000C94 RID: 3220 RVA: 0x0002CB19 File Offset: 0x0002AD19
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_getReturnType == null)
			{
				IKMutableProperty0SetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0SetterInvoker.n_GetReturnType));
			}
			return IKMutableProperty0SetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0002CB3D File Offset: 0x0002AD3D
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0002CB54 File Offset: 0x0002AD54
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

		// Token: 0x06000C97 RID: 3223 RVA: 0x0002CBA5 File Offset: 0x0002ADA5
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_getTypeParameters == null)
			{
				IKMutableProperty0SetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0SetterInvoker.n_GetTypeParameters));
			}
			return IKMutableProperty0SetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0002CBC9 File Offset: 0x0002ADC9
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
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

		// Token: 0x06000C9A RID: 3226 RVA: 0x0002CC31 File Offset: 0x0002AE31
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_getVisibility == null)
			{
				IKMutableProperty0SetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0SetterInvoker.n_GetVisibility));
			}
			return IKMutableProperty0SetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0002CC55 File Offset: 0x0002AE55
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0002CC6C File Offset: 0x0002AE6C
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

		// Token: 0x06000C9D RID: 3229 RVA: 0x0002CCBD File Offset: 0x0002AEBD
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutableProperty0SetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutableProperty0SetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty0SetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutableProperty0SetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0002CD28 File Offset: 0x0002AF28
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

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0002CDA9 File Offset: 0x0002AFA9
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutableProperty0SetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutableProperty0SetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty0SetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutableProperty0SetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
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

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0002CE6F File Offset: 0x0002B06F
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_getAnnotations == null)
			{
				IKMutableProperty0SetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0SetterInvoker.n_GetAnnotations));
			}
			return IKMutableProperty0SetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0002CE93 File Offset: 0x0002B093
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0002CEA8 File Offset: 0x0002B0A8
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

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0002CEF9 File Offset: 0x0002B0F9
		private static Delegate GetGetPropertyHandler()
		{
			if (IKMutableProperty0SetterInvoker.cb_getProperty == null)
			{
				IKMutableProperty0SetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0SetterInvoker.n_GetProperty));
			}
			return IKMutableProperty0SetterInvoker.cb_getProperty;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0002CF1D File Offset: 0x0002B11D
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0002CF34 File Offset: 0x0002B134
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

		// Token: 0x04000327 RID: 807
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty0$Setter", typeof(IKMutableProperty0SetterInvoker));

		// Token: 0x04000328 RID: 808
		private IntPtr class_ref;

		// Token: 0x04000329 RID: 809
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_;

		// Token: 0x0400032A RID: 810
		private IntPtr id_invoke_Ljava_lang_Object_;

		// Token: 0x0400032B RID: 811
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x0400032C RID: 812
		private IntPtr id_isExternal;

		// Token: 0x0400032D RID: 813
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x0400032E RID: 814
		private IntPtr id_isInfix;

		// Token: 0x0400032F RID: 815
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x04000330 RID: 816
		private IntPtr id_isInline;

		// Token: 0x04000331 RID: 817
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x04000332 RID: 818
		private IntPtr id_isOperator;

		// Token: 0x04000333 RID: 819
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000334 RID: 820
		private IntPtr id_isSuspend;

		// Token: 0x04000335 RID: 821
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x04000336 RID: 822
		private IntPtr id_isAbstract;

		// Token: 0x04000337 RID: 823
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x04000338 RID: 824
		private IntPtr id_isFinal;

		// Token: 0x04000339 RID: 825
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x0400033A RID: 826
		private IntPtr id_isOpen;

		// Token: 0x0400033B RID: 827
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x0400033C RID: 828
		private IntPtr id_getName;

		// Token: 0x0400033D RID: 829
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x0400033E RID: 830
		private IntPtr id_getParameters;

		// Token: 0x0400033F RID: 831
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x04000340 RID: 832
		private IntPtr id_getReturnType;

		// Token: 0x04000341 RID: 833
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000342 RID: 834
		private IntPtr id_getTypeParameters;

		// Token: 0x04000343 RID: 835
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x04000344 RID: 836
		private IntPtr id_getVisibility;

		// Token: 0x04000345 RID: 837
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000346 RID: 838
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x04000347 RID: 839
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000348 RID: 840
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000349 RID: 841
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x0400034A RID: 842
		private IntPtr id_getAnnotations;

		// Token: 0x0400034B RID: 843
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x0400034C RID: 844
		private IntPtr id_getProperty;
	}
}
