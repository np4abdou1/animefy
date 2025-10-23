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
	// Token: 0x0200011A RID: 282
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty2", DoNotGenerateAcw = true)]
	internal class IKMutableProperty2Invoker : Java.Lang.Object, IKMutableProperty2, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty2, IFunction2, IFunction
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0002FEC8 File Offset: 0x0002E0C8
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableProperty2Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0002FEEC File Offset: 0x0002E0EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutableProperty2Invoker._members;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0002FEF3 File Offset: 0x0002E0F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0002FEFB File Offset: 0x0002E0FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutableProperty2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0002FF07 File Offset: 0x0002E107
		[NullableContext(2)]
		public static IKMutableProperty2 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2>(handle, transfer);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0002FF10 File Offset: 0x0002E110
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableProperty2Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty2'.");
			}
			return handle;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0002FF3B File Offset: 0x0002E13B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0002FF6C File Offset: 0x0002E16C
		public IKMutableProperty2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableProperty2Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0002FFA4 File Offset: 0x0002E1A4
		private static Delegate GetGetSetterHandler()
		{
			if (IKMutableProperty2Invoker.cb_getSetter == null)
			{
				IKMutableProperty2Invoker.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetSetter));
			}
			return IKMutableProperty2Invoker.cb_getSetter;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0002FFC8 File Offset: 0x0002E1C8
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0002FFDC File Offset: 0x0002E1DC
		public IKMutablePropertySetter Setter
		{
			get
			{
				if (this.id_getSetter == IntPtr.Zero)
				{
					this.id_getSetter = JNIEnv.GetMethodID(this.class_ref, "getSetter", "()Lkotlin/reflect/KMutableProperty2$Setter;");
				}
				return Java.Lang.Object.GetObject<IKMutableProperty2Setter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0003002D File Offset: 0x0002E22D
		private static Delegate GetSet_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty2Invoker.cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKMutableProperty2Invoker.cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IKMutableProperty2Invoker.n_Set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKMutableProperty2Invoker.cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00030054 File Offset: 0x0002E254
		private static void n_Set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2, IntPtr native_value)
		{
			IKMutableProperty2 @object = Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2, object3, object4);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0003008C File Offset: 0x0002E28C
		[NullableContext(2)]
		public unsafe void Set(Java.Lang.Object receiver1, Java.Lang.Object receiver2, Java.Lang.Object value)
		{
			if (this.id_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "set", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(receiver2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			JNIEnv.CallVoidMethod(base.Handle, this.id_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00030140 File Offset: 0x0002E340
		private static Delegate GetGetGetterHandler()
		{
			if (IKMutableProperty2Invoker.cb_getGetter == null)
			{
				IKMutableProperty2Invoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetGetter));
			}
			return IKMutableProperty2Invoker.cb_getGetter;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00030164 File Offset: 0x0002E364
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00030178 File Offset: 0x0002E378
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

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000301C9 File Offset: 0x0002E3C9
		private static Delegate GetIsConstHandler()
		{
			if (IKMutableProperty2Invoker.cb_isConst == null)
			{
				IKMutableProperty2Invoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2Invoker.n_IsConst));
			}
			return IKMutableProperty2Invoker.cb_isConst;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000301ED File Offset: 0x0002E3ED
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000301FC File Offset: 0x0002E3FC
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

		// Token: 0x06000DCC RID: 3532 RVA: 0x0003023C File Offset: 0x0002E43C
		private static Delegate GetIsLateinitHandler()
		{
			if (IKMutableProperty2Invoker.cb_isLateinit == null)
			{
				IKMutableProperty2Invoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2Invoker.n_IsLateinit));
			}
			return IKMutableProperty2Invoker.cb_isLateinit;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00030260 File Offset: 0x0002E460
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0003026F File Offset: 0x0002E46F
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

		// Token: 0x06000DCF RID: 3535 RVA: 0x000302AF File Offset: 0x0002E4AF
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutableProperty2Invoker.cb_isAbstract == null)
			{
				IKMutableProperty2Invoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2Invoker.n_IsAbstract));
			}
			return IKMutableProperty2Invoker.cb_isAbstract;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000302D3 File Offset: 0x0002E4D3
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000302E2 File Offset: 0x0002E4E2
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

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00030322 File Offset: 0x0002E522
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutableProperty2Invoker.cb_isFinal == null)
			{
				IKMutableProperty2Invoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2Invoker.n_IsFinal));
			}
			return IKMutableProperty2Invoker.cb_isFinal;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00030346 File Offset: 0x0002E546
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00030355 File Offset: 0x0002E555
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

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00030395 File Offset: 0x0002E595
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutableProperty2Invoker.cb_isOpen == null)
			{
				IKMutableProperty2Invoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2Invoker.n_IsOpen));
			}
			return IKMutableProperty2Invoker.cb_isOpen;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000303B9 File Offset: 0x0002E5B9
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000303C8 File Offset: 0x0002E5C8
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

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00030408 File Offset: 0x0002E608
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutableProperty2Invoker.cb_isSuspend == null)
			{
				IKMutableProperty2Invoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty2Invoker.n_IsSuspend));
			}
			return IKMutableProperty2Invoker.cb_isSuspend;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0003042C File Offset: 0x0002E62C
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0003043B File Offset: 0x0002E63B
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

		// Token: 0x06000DDB RID: 3547 RVA: 0x0003047B File Offset: 0x0002E67B
		private static Delegate GetGetNameHandler()
		{
			if (IKMutableProperty2Invoker.cb_getName == null)
			{
				IKMutableProperty2Invoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetName));
			}
			return IKMutableProperty2Invoker.cb_getName;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0003049F File Offset: 0x0002E69F
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x000304B4 File Offset: 0x0002E6B4
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

		// Token: 0x06000DDE RID: 3550 RVA: 0x00030505 File Offset: 0x0002E705
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutableProperty2Invoker.cb_getParameters == null)
			{
				IKMutableProperty2Invoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetParameters));
			}
			return IKMutableProperty2Invoker.cb_getParameters;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00030529 File Offset: 0x0002E729
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00030540 File Offset: 0x0002E740
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

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00030591 File Offset: 0x0002E791
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutableProperty2Invoker.cb_getReturnType == null)
			{
				IKMutableProperty2Invoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetReturnType));
			}
			return IKMutableProperty2Invoker.cb_getReturnType;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000305B5 File Offset: 0x0002E7B5
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000305CC File Offset: 0x0002E7CC
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

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0003061D File Offset: 0x0002E81D
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutableProperty2Invoker.cb_getTypeParameters == null)
			{
				IKMutableProperty2Invoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetTypeParameters));
			}
			return IKMutableProperty2Invoker.cb_getTypeParameters;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00030641 File Offset: 0x0002E841
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00030658 File Offset: 0x0002E858
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

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000306A9 File Offset: 0x0002E8A9
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutableProperty2Invoker.cb_getVisibility == null)
			{
				IKMutableProperty2Invoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetVisibility));
			}
			return IKMutableProperty2Invoker.cb_getVisibility;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000306CD File Offset: 0x0002E8CD
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000306E4 File Offset: 0x0002E8E4
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

		// Token: 0x06000DEA RID: 3562 RVA: 0x00030735 File Offset: 0x0002E935
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutableProperty2Invoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutableProperty2Invoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty2Invoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutableProperty2Invoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0003075C File Offset: 0x0002E95C
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000307A0 File Offset: 0x0002E9A0
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

		// Token: 0x06000DED RID: 3565 RVA: 0x00030821 File Offset: 0x0002EA21
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutableProperty2Invoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutableProperty2Invoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty2Invoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutableProperty2Invoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00030848 File Offset: 0x0002EA48
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00030870 File Offset: 0x0002EA70
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

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000308E7 File Offset: 0x0002EAE7
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutableProperty2Invoker.cb_getAnnotations == null)
			{
				IKMutableProperty2Invoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty2Invoker.n_GetAnnotations));
			}
			return IKMutableProperty2Invoker.cb_getAnnotations;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0003090B File Offset: 0x0002EB0B
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00030920 File Offset: 0x0002EB20
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

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00030971 File Offset: 0x0002EB71
		private static Delegate GetGet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty2Invoker.cb_get_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKMutableProperty2Invoker.cb_get_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKMutableProperty2Invoker.n_Get_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKMutableProperty2Invoker.cb_get_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00030998 File Offset: 0x0002EB98
		private static IntPtr n_Get_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			IKProperty2 @object = Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2, object3));
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000309CC File Offset: 0x0002EBCC
		[NullableContext(2)]
		public unsafe Java.Lang.Object Get(Java.Lang.Object receiver1, Java.Lang.Object receiver2)
		{
			if (this.id_get_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(receiver2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00030A63 File Offset: 0x0002EC63
		private static Delegate GetGetDelegate_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty2Invoker.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKMutableProperty2Invoker.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKMutableProperty2Invoker.n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKMutableProperty2Invoker.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00030A88 File Offset: 0x0002EC88
		private static IntPtr n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			IKProperty2 @object = Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2, object3));
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00030ABC File Offset: 0x0002ECBC
		[NullableContext(2)]
		public unsafe Java.Lang.Object GetDelegate(Java.Lang.Object receiver1, Java.Lang.Object receiver2)
		{
			if (this.id_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "getDelegate", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(receiver1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(receiver2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDelegate_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00030B53 File Offset: 0x0002ED53
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKMutableProperty2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKMutableProperty2Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKMutableProperty2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00030B78 File Offset: 0x0002ED78
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFunction2 @object = Java.Lang.Object.GetObject<IKMutableProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3));
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00030BAC File Offset: 0x0002EDAC
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

		// Token: 0x040003ED RID: 1005
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty2", typeof(IKMutableProperty2Invoker));

		// Token: 0x040003EE RID: 1006
		private IntPtr class_ref;

		// Token: 0x040003EF RID: 1007
		[Nullable(2)]
		private static Delegate cb_getSetter;

		// Token: 0x040003F0 RID: 1008
		private IntPtr id_getSetter;

		// Token: 0x040003F1 RID: 1009
		[Nullable(2)]
		private static Delegate cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040003F2 RID: 1010
		private IntPtr id_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040003F3 RID: 1011
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x040003F4 RID: 1012
		private IntPtr id_getGetter;

		// Token: 0x040003F5 RID: 1013
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x040003F6 RID: 1014
		private IntPtr id_isConst;

		// Token: 0x040003F7 RID: 1015
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x040003F8 RID: 1016
		private IntPtr id_isLateinit;

		// Token: 0x040003F9 RID: 1017
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040003FA RID: 1018
		private IntPtr id_isAbstract;

		// Token: 0x040003FB RID: 1019
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040003FC RID: 1020
		private IntPtr id_isFinal;

		// Token: 0x040003FD RID: 1021
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040003FE RID: 1022
		private IntPtr id_isOpen;

		// Token: 0x040003FF RID: 1023
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000400 RID: 1024
		private IntPtr id_isSuspend;

		// Token: 0x04000401 RID: 1025
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000402 RID: 1026
		private IntPtr id_getName;

		// Token: 0x04000403 RID: 1027
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x04000404 RID: 1028
		private IntPtr id_getParameters;

		// Token: 0x04000405 RID: 1029
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x04000406 RID: 1030
		private IntPtr id_getReturnType;

		// Token: 0x04000407 RID: 1031
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000408 RID: 1032
		private IntPtr id_getTypeParameters;

		// Token: 0x04000409 RID: 1033
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x0400040A RID: 1034
		private IntPtr id_getVisibility;

		// Token: 0x0400040B RID: 1035
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x0400040C RID: 1036
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x0400040D RID: 1037
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x0400040E RID: 1038
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x0400040F RID: 1039
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000410 RID: 1040
		private IntPtr id_getAnnotations;

		// Token: 0x04000411 RID: 1041
		[Nullable(2)]
		private static Delegate cb_get_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000412 RID: 1042
		private IntPtr id_get_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000413 RID: 1043
		[Nullable(2)]
		private static Delegate cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000414 RID: 1044
		private IntPtr id_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000415 RID: 1045
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000416 RID: 1046
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
