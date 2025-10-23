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
	// Token: 0x02000116 RID: 278
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty1", DoNotGenerateAcw = true)]
	internal class IKMutableProperty1Invoker : Java.Lang.Object, IKMutableProperty1, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty1, IFunction1, IFunction
	{
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableProperty1Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x0002E6D8 File Offset: 0x0002C8D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutableProperty1Invoker._members;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0002E6DF File Offset: 0x0002C8DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0002E6E7 File Offset: 0x0002C8E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutableProperty1Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0002E6F3 File Offset: 0x0002C8F3
		[NullableContext(2)]
		public static IKMutableProperty1 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1>(handle, transfer);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0002E6FC File Offset: 0x0002C8FC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableProperty1Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty1'.");
			}
			return handle;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0002E727 File Offset: 0x0002C927
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0002E758 File Offset: 0x0002C958
		public IKMutableProperty1Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableProperty1Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0002E790 File Offset: 0x0002C990
		private static Delegate GetGetSetterHandler()
		{
			if (IKMutableProperty1Invoker.cb_getSetter == null)
			{
				IKMutableProperty1Invoker.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetSetter));
			}
			return IKMutableProperty1Invoker.cb_getSetter;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0002E7B4 File Offset: 0x0002C9B4
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0002E7C8 File Offset: 0x0002C9C8
		public IKMutablePropertySetter Setter
		{
			get
			{
				if (this.id_getSetter == IntPtr.Zero)
				{
					this.id_getSetter = JNIEnv.GetMethodID(this.class_ref, "getSetter", "()Lkotlin/reflect/KMutableProperty1$Setter;");
				}
				return Java.Lang.Object.GetObject<IKMutableProperty1Setter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0002E819 File Offset: 0x0002CA19
		private static Delegate GetSet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty1Invoker.cb_set_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKMutableProperty1Invoker.cb_set_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IKMutableProperty1Invoker.n_Set_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKMutableProperty1Invoker.cb_set_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0002E840 File Offset: 0x0002CA40
		private static void n_Set_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver, IntPtr native_value)
		{
			IKMutableProperty1 @object = Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2, object3);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0002E86C File Offset: 0x0002CA6C
		[NullableContext(2)]
		public unsafe void Set(Java.Lang.Object receiver, Java.Lang.Object value)
		{
			if (this.id_set_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_set_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_set_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0002E8FD File Offset: 0x0002CAFD
		private static Delegate GetGetGetterHandler()
		{
			if (IKMutableProperty1Invoker.cb_getGetter == null)
			{
				IKMutableProperty1Invoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetGetter));
			}
			return IKMutableProperty1Invoker.cb_getGetter;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0002E921 File Offset: 0x0002CB21
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0002E938 File Offset: 0x0002CB38
		public IKPropertyGetter Getter
		{
			get
			{
				if (this.id_getGetter == IntPtr.Zero)
				{
					this.id_getGetter = JNIEnv.GetMethodID(this.class_ref, "getGetter", "()Lkotlin/reflect/KProperty$Getter;");
				}
				return Java.Lang.Object.GetObject<IKPropertyGetter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0002E989 File Offset: 0x0002CB89
		private static Delegate GetIsConstHandler()
		{
			if (IKMutableProperty1Invoker.cb_isConst == null)
			{
				IKMutableProperty1Invoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1Invoker.n_IsConst));
			}
			return IKMutableProperty1Invoker.cb_isConst;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0002E9AD File Offset: 0x0002CBAD
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0002E9BC File Offset: 0x0002CBBC
		public bool IsConst
		{
			get
			{
				if (this.id_isConst == IntPtr.Zero)
				{
					this.id_isConst = JNIEnv.GetMethodID(this.class_ref, "isConst", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isConst);
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0002E9FC File Offset: 0x0002CBFC
		private static Delegate GetIsLateinitHandler()
		{
			if (IKMutableProperty1Invoker.cb_isLateinit == null)
			{
				IKMutableProperty1Invoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1Invoker.n_IsLateinit));
			}
			return IKMutableProperty1Invoker.cb_isLateinit;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0002EA20 File Offset: 0x0002CC20
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0002EA2F File Offset: 0x0002CC2F
		public bool IsLateinit
		{
			get
			{
				if (this.id_isLateinit == IntPtr.Zero)
				{
					this.id_isLateinit = JNIEnv.GetMethodID(this.class_ref, "isLateinit", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isLateinit);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0002EA6F File Offset: 0x0002CC6F
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutableProperty1Invoker.cb_isAbstract == null)
			{
				IKMutableProperty1Invoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1Invoker.n_IsAbstract));
			}
			return IKMutableProperty1Invoker.cb_isAbstract;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0002EA93 File Offset: 0x0002CC93
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x0002EAA2 File Offset: 0x0002CCA2
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

		// Token: 0x06000D4C RID: 3404 RVA: 0x0002EAE2 File Offset: 0x0002CCE2
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutableProperty1Invoker.cb_isFinal == null)
			{
				IKMutableProperty1Invoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1Invoker.n_IsFinal));
			}
			return IKMutableProperty1Invoker.cb_isFinal;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0002EB06 File Offset: 0x0002CD06
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0002EB15 File Offset: 0x0002CD15
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

		// Token: 0x06000D4F RID: 3407 RVA: 0x0002EB55 File Offset: 0x0002CD55
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutableProperty1Invoker.cb_isOpen == null)
			{
				IKMutableProperty1Invoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1Invoker.n_IsOpen));
			}
			return IKMutableProperty1Invoker.cb_isOpen;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0002EB79 File Offset: 0x0002CD79
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0002EB88 File Offset: 0x0002CD88
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

		// Token: 0x06000D52 RID: 3410 RVA: 0x0002EBC8 File Offset: 0x0002CDC8
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutableProperty1Invoker.cb_isSuspend == null)
			{
				IKMutableProperty1Invoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty1Invoker.n_IsSuspend));
			}
			return IKMutableProperty1Invoker.cb_isSuspend;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0002EBEC File Offset: 0x0002CDEC
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0002EBFB File Offset: 0x0002CDFB
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

		// Token: 0x06000D55 RID: 3413 RVA: 0x0002EC3B File Offset: 0x0002CE3B
		private static Delegate GetGetNameHandler()
		{
			if (IKMutableProperty1Invoker.cb_getName == null)
			{
				IKMutableProperty1Invoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetName));
			}
			return IKMutableProperty1Invoker.cb_getName;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0002EC5F File Offset: 0x0002CE5F
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0002EC74 File Offset: 0x0002CE74
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

		// Token: 0x06000D58 RID: 3416 RVA: 0x0002ECC5 File Offset: 0x0002CEC5
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutableProperty1Invoker.cb_getParameters == null)
			{
				IKMutableProperty1Invoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetParameters));
			}
			return IKMutableProperty1Invoker.cb_getParameters;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0002ECE9 File Offset: 0x0002CEE9
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0002ED00 File Offset: 0x0002CF00
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

		// Token: 0x06000D5B RID: 3419 RVA: 0x0002ED51 File Offset: 0x0002CF51
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutableProperty1Invoker.cb_getReturnType == null)
			{
				IKMutableProperty1Invoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetReturnType));
			}
			return IKMutableProperty1Invoker.cb_getReturnType;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0002ED75 File Offset: 0x0002CF75
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0002ED8C File Offset: 0x0002CF8C
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

		// Token: 0x06000D5E RID: 3422 RVA: 0x0002EDDD File Offset: 0x0002CFDD
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutableProperty1Invoker.cb_getTypeParameters == null)
			{
				IKMutableProperty1Invoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetTypeParameters));
			}
			return IKMutableProperty1Invoker.cb_getTypeParameters;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0002EE01 File Offset: 0x0002D001
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0002EE18 File Offset: 0x0002D018
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

		// Token: 0x06000D61 RID: 3425 RVA: 0x0002EE69 File Offset: 0x0002D069
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutableProperty1Invoker.cb_getVisibility == null)
			{
				IKMutableProperty1Invoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetVisibility));
			}
			return IKMutableProperty1Invoker.cb_getVisibility;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0002EE8D File Offset: 0x0002D08D
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0002EEA4 File Offset: 0x0002D0A4
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

		// Token: 0x06000D64 RID: 3428 RVA: 0x0002EEF5 File Offset: 0x0002D0F5
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutableProperty1Invoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutableProperty1Invoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty1Invoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutableProperty1Invoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0002EF1C File Offset: 0x0002D11C
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0002EF60 File Offset: 0x0002D160
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

		// Token: 0x06000D67 RID: 3431 RVA: 0x0002EFE1 File Offset: 0x0002D1E1
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutableProperty1Invoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutableProperty1Invoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty1Invoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutableProperty1Invoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0002F008 File Offset: 0x0002D208
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0002F030 File Offset: 0x0002D230
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

		// Token: 0x06000D6A RID: 3434 RVA: 0x0002F0A7 File Offset: 0x0002D2A7
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutableProperty1Invoker.cb_getAnnotations == null)
			{
				IKMutableProperty1Invoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty1Invoker.n_GetAnnotations));
			}
			return IKMutableProperty1Invoker.cb_getAnnotations;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0002F0CB File Offset: 0x0002D2CB
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0002F0E0 File Offset: 0x0002D2E0
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

		// Token: 0x06000D6D RID: 3437 RVA: 0x0002F131 File Offset: 0x0002D331
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty1Invoker.cb_get_Ljava_lang_Object_ == null)
			{
				IKMutableProperty1Invoker.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty1Invoker.n_Get_Ljava_lang_Object_));
			}
			return IKMutableProperty1Invoker.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0002F158 File Offset: 0x0002D358
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			IKProperty1 @object = Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0002F180 File Offset: 0x0002D380
		[NullableContext(2)]
		public unsafe Java.Lang.Object Get(Java.Lang.Object receiver)
		{
			if (this.id_get_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0002F1F7 File Offset: 0x0002D3F7
		private static Delegate GetGetDelegate_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty1Invoker.cb_getDelegate_Ljava_lang_Object_ == null)
			{
				IKMutableProperty1Invoker.cb_getDelegate_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty1Invoker.n_GetDelegate_Ljava_lang_Object_));
			}
			return IKMutableProperty1Invoker.cb_getDelegate_Ljava_lang_Object_;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0002F21C File Offset: 0x0002D41C
		private static IntPtr n_GetDelegate_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			IKProperty1 @object = Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2));
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0002F244 File Offset: 0x0002D444
		[NullableContext(2)]
		public unsafe Java.Lang.Object GetDelegate(Java.Lang.Object receiver)
		{
			if (this.id_getDelegate_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_getDelegate_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "getDelegate", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDelegate_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0002F2BB File Offset: 0x0002D4BB
		private static Delegate GetInvoke_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty1Invoker.cb_invoke_Ljava_lang_Object_ == null)
			{
				IKMutableProperty1Invoker.cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty1Invoker.n_Invoke_Ljava_lang_Object_));
			}
			return IKMutableProperty1Invoker.cb_invoke_Ljava_lang_Object_;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0002F2E0 File Offset: 0x0002D4E0
		private static IntPtr n_Invoke_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFunction1 @object = Java.Lang.Object.GetObject<IKMutableProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2));
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0002F308 File Offset: 0x0002D508
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

		// Token: 0x0400039D RID: 925
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty1", typeof(IKMutableProperty1Invoker));

		// Token: 0x0400039E RID: 926
		private IntPtr class_ref;

		// Token: 0x0400039F RID: 927
		[Nullable(2)]
		private static Delegate cb_getSetter;

		// Token: 0x040003A0 RID: 928
		private IntPtr id_getSetter;

		// Token: 0x040003A1 RID: 929
		[Nullable(2)]
		private static Delegate cb_set_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040003A2 RID: 930
		private IntPtr id_set_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040003A3 RID: 931
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x040003A4 RID: 932
		private IntPtr id_getGetter;

		// Token: 0x040003A5 RID: 933
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x040003A6 RID: 934
		private IntPtr id_isConst;

		// Token: 0x040003A7 RID: 935
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x040003A8 RID: 936
		private IntPtr id_isLateinit;

		// Token: 0x040003A9 RID: 937
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040003AA RID: 938
		private IntPtr id_isAbstract;

		// Token: 0x040003AB RID: 939
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040003AC RID: 940
		private IntPtr id_isFinal;

		// Token: 0x040003AD RID: 941
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040003AE RID: 942
		private IntPtr id_isOpen;

		// Token: 0x040003AF RID: 943
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x040003B0 RID: 944
		private IntPtr id_isSuspend;

		// Token: 0x040003B1 RID: 945
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x040003B2 RID: 946
		private IntPtr id_getName;

		// Token: 0x040003B3 RID: 947
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x040003B4 RID: 948
		private IntPtr id_getParameters;

		// Token: 0x040003B5 RID: 949
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x040003B6 RID: 950
		private IntPtr id_getReturnType;

		// Token: 0x040003B7 RID: 951
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x040003B8 RID: 952
		private IntPtr id_getTypeParameters;

		// Token: 0x040003B9 RID: 953
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x040003BA RID: 954
		private IntPtr id_getVisibility;

		// Token: 0x040003BB RID: 955
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x040003BC RID: 956
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x040003BD RID: 957
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x040003BE RID: 958
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x040003BF RID: 959
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x040003C0 RID: 960
		private IntPtr id_getAnnotations;

		// Token: 0x040003C1 RID: 961
		[Nullable(2)]
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x040003C2 RID: 962
		private IntPtr id_get_Ljava_lang_Object_;

		// Token: 0x040003C3 RID: 963
		[Nullable(2)]
		private static Delegate cb_getDelegate_Ljava_lang_Object_;

		// Token: 0x040003C4 RID: 964
		private IntPtr id_getDelegate_Ljava_lang_Object_;

		// Token: 0x040003C5 RID: 965
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_;

		// Token: 0x040003C6 RID: 966
		private IntPtr id_invoke_Ljava_lang_Object_;
	}
}
