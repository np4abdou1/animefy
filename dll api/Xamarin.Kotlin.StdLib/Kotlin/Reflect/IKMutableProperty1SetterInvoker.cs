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
	// Token: 0x02000114 RID: 276
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty1$Setter", DoNotGenerateAcw = true)]
	internal class IKMutableProperty1SetterInvoker : Java.Lang.Object, IKMutableProperty1Setter, IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKMutablePropertySetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0002DBB4 File Offset: 0x0002BDB4
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableProperty1SetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0002DBD8 File Offset: 0x0002BDD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutableProperty1SetterInvoker._members;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0002DBDF File Offset: 0x0002BDDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0002DBE7 File Offset: 0x0002BDE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutableProperty1SetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0002DBF3 File Offset: 0x0002BDF3
		[NullableContext(2)]
		public static IKMutableProperty1Setter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(handle, transfer);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableProperty1SetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty1.Setter'.");
			}
			return handle;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0002DC27 File Offset: 0x0002BE27
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0002DC58 File Offset: 0x0002BE58
		public IKMutableProperty1SetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableProperty1SetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0002DC90 File Offset: 0x0002BE90
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty1SetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKMutableProperty1SetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKMutableProperty1SetterInvoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKMutableProperty1SetterInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0002DCB4 File Offset: 0x0002BEB4
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFunction2 @object = Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3));
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0002DCE8 File Offset: 0x0002BEE8
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

		// Token: 0x06000CFC RID: 3324 RVA: 0x0002DD7F File Offset: 0x0002BF7F
		private static Delegate GetIsExternalHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isExternal == null)
			{
				IKMutableProperty1SetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsExternal));
			}
			return IKMutableProperty1SetterInvoker.cb_isExternal;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0002DDA3 File Offset: 0x0002BFA3
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0002DDB2 File Offset: 0x0002BFB2
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

		// Token: 0x06000CFF RID: 3327 RVA: 0x0002DDF2 File Offset: 0x0002BFF2
		private static Delegate GetIsInfixHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isInfix == null)
			{
				IKMutableProperty1SetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsInfix));
			}
			return IKMutableProperty1SetterInvoker.cb_isInfix;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0002DE16 File Offset: 0x0002C016
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0002DE25 File Offset: 0x0002C025
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

		// Token: 0x06000D02 RID: 3330 RVA: 0x0002DE65 File Offset: 0x0002C065
		private static Delegate GetIsInlineHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isInline == null)
			{
				IKMutableProperty1SetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsInline));
			}
			return IKMutableProperty1SetterInvoker.cb_isInline;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0002DE89 File Offset: 0x0002C089
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0002DE98 File Offset: 0x0002C098
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

		// Token: 0x06000D05 RID: 3333 RVA: 0x0002DED8 File Offset: 0x0002C0D8
		private static Delegate GetIsOperatorHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isOperator == null)
			{
				IKMutableProperty1SetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsOperator));
			}
			return IKMutableProperty1SetterInvoker.cb_isOperator;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0002DEFC File Offset: 0x0002C0FC
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0002DF0B File Offset: 0x0002C10B
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

		// Token: 0x06000D08 RID: 3336 RVA: 0x0002DF4B File Offset: 0x0002C14B
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isSuspend == null)
			{
				IKMutableProperty1SetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsSuspend));
			}
			return IKMutableProperty1SetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0002DF6F File Offset: 0x0002C16F
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0002DF7E File Offset: 0x0002C17E
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

		// Token: 0x06000D0B RID: 3339 RVA: 0x0002DFBE File Offset: 0x0002C1BE
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isAbstract == null)
			{
				IKMutableProperty1SetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsAbstract));
			}
			return IKMutableProperty1SetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0002DFE2 File Offset: 0x0002C1E2
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0002DFF1 File Offset: 0x0002C1F1
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

		// Token: 0x06000D0E RID: 3342 RVA: 0x0002E031 File Offset: 0x0002C231
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isFinal == null)
			{
				IKMutableProperty1SetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsFinal));
			}
			return IKMutableProperty1SetterInvoker.cb_isFinal;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0002E055 File Offset: 0x0002C255
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0002E064 File Offset: 0x0002C264
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

		// Token: 0x06000D11 RID: 3345 RVA: 0x0002E0A4 File Offset: 0x0002C2A4
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_isOpen == null)
			{
				IKMutableProperty1SetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1SetterInvoker.n_IsOpen));
			}
			return IKMutableProperty1SetterInvoker.cb_isOpen;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0002E0C8 File Offset: 0x0002C2C8
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0002E0D7 File Offset: 0x0002C2D7
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

		// Token: 0x06000D14 RID: 3348 RVA: 0x0002E117 File Offset: 0x0002C317
		private static Delegate GetGetNameHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_getName == null)
			{
				IKMutableProperty1SetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1SetterInvoker.n_GetName));
			}
			return IKMutableProperty1SetterInvoker.cb_getName;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0002E13B File Offset: 0x0002C33B
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0002E150 File Offset: 0x0002C350
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

		// Token: 0x06000D17 RID: 3351 RVA: 0x0002E1A1 File Offset: 0x0002C3A1
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_getParameters == null)
			{
				IKMutableProperty1SetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1SetterInvoker.n_GetParameters));
			}
			return IKMutableProperty1SetterInvoker.cb_getParameters;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0002E1C5 File Offset: 0x0002C3C5
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0002E1DC File Offset: 0x0002C3DC
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

		// Token: 0x06000D1A RID: 3354 RVA: 0x0002E22D File Offset: 0x0002C42D
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_getReturnType == null)
			{
				IKMutableProperty1SetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1SetterInvoker.n_GetReturnType));
			}
			return IKMutableProperty1SetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0002E251 File Offset: 0x0002C451
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0002E268 File Offset: 0x0002C468
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

		// Token: 0x06000D1D RID: 3357 RVA: 0x0002E2B9 File Offset: 0x0002C4B9
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_getTypeParameters == null)
			{
				IKMutableProperty1SetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1SetterInvoker.n_GetTypeParameters));
			}
			return IKMutableProperty1SetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0002E2DD File Offset: 0x0002C4DD
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0002E2F4 File Offset: 0x0002C4F4
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

		// Token: 0x06000D20 RID: 3360 RVA: 0x0002E345 File Offset: 0x0002C545
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_getVisibility == null)
			{
				IKMutableProperty1SetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1SetterInvoker.n_GetVisibility));
			}
			return IKMutableProperty1SetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0002E369 File Offset: 0x0002C569
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0002E380 File Offset: 0x0002C580
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

		// Token: 0x06000D23 RID: 3363 RVA: 0x0002E3D1 File Offset: 0x0002C5D1
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutableProperty1SetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutableProperty1SetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty1SetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutableProperty1SetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0002E43C File Offset: 0x0002C63C
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

		// Token: 0x06000D26 RID: 3366 RVA: 0x0002E4BD File Offset: 0x0002C6BD
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutableProperty1SetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutableProperty1SetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty1SetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutableProperty1SetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0002E4E4 File Offset: 0x0002C6E4
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0002E50C File Offset: 0x0002C70C
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

		// Token: 0x06000D29 RID: 3369 RVA: 0x0002E583 File Offset: 0x0002C783
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_getAnnotations == null)
			{
				IKMutableProperty1SetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1SetterInvoker.n_GetAnnotations));
			}
			return IKMutableProperty1SetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0002E5A7 File Offset: 0x0002C7A7
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0002E5BC File Offset: 0x0002C7BC
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

		// Token: 0x06000D2C RID: 3372 RVA: 0x0002E60D File Offset: 0x0002C80D
		private static Delegate GetGetPropertyHandler()
		{
			if (IKMutableProperty1SetterInvoker.cb_getProperty == null)
			{
				IKMutableProperty1SetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1SetterInvoker.n_GetProperty));
			}
			return IKMutableProperty1SetterInvoker.cb_getProperty;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0002E631 File Offset: 0x0002C831
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1Setter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0002E648 File Offset: 0x0002C848
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

		// Token: 0x04000377 RID: 887
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty1$Setter", typeof(IKMutableProperty1SetterInvoker));

		// Token: 0x04000378 RID: 888
		private IntPtr class_ref;

		// Token: 0x04000379 RID: 889
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400037A RID: 890
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400037B RID: 891
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x0400037C RID: 892
		private IntPtr id_isExternal;

		// Token: 0x0400037D RID: 893
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x0400037E RID: 894
		private IntPtr id_isInfix;

		// Token: 0x0400037F RID: 895
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x04000380 RID: 896
		private IntPtr id_isInline;

		// Token: 0x04000381 RID: 897
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x04000382 RID: 898
		private IntPtr id_isOperator;

		// Token: 0x04000383 RID: 899
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000384 RID: 900
		private IntPtr id_isSuspend;

		// Token: 0x04000385 RID: 901
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x04000386 RID: 902
		private IntPtr id_isAbstract;

		// Token: 0x04000387 RID: 903
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x04000388 RID: 904
		private IntPtr id_isFinal;

		// Token: 0x04000389 RID: 905
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x0400038A RID: 906
		private IntPtr id_isOpen;

		// Token: 0x0400038B RID: 907
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x0400038C RID: 908
		private IntPtr id_getName;

		// Token: 0x0400038D RID: 909
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x0400038E RID: 910
		private IntPtr id_getParameters;

		// Token: 0x0400038F RID: 911
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x04000390 RID: 912
		private IntPtr id_getReturnType;

		// Token: 0x04000391 RID: 913
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000392 RID: 914
		private IntPtr id_getTypeParameters;

		// Token: 0x04000393 RID: 915
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x04000394 RID: 916
		private IntPtr id_getVisibility;

		// Token: 0x04000395 RID: 917
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000396 RID: 918
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x04000397 RID: 919
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000398 RID: 920
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000399 RID: 921
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x0400039A RID: 922
		private IntPtr id_getAnnotations;

		// Token: 0x0400039B RID: 923
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x0400039C RID: 924
		private IntPtr id_getProperty;
	}
}
