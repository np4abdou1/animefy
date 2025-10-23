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
	// Token: 0x02000125 RID: 293
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty", DoNotGenerateAcw = true)]
	internal class IKPropertyInvoker : Java.Lang.Object, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x00031F6C File Offset: 0x0003016C
		private static IntPtr java_class_ref
		{
			get
			{
				return IKPropertyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00031F90 File Offset: 0x00030190
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKPropertyInvoker._members;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x00031F97 File Offset: 0x00030197
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00031F9F File Offset: 0x0003019F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKPropertyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00031FAB File Offset: 0x000301AB
		[NullableContext(2)]
		public static IKProperty GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKProperty>(handle, transfer);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00031FB4 File Offset: 0x000301B4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKPropertyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty'.");
			}
			return handle;
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00031FDF File Offset: 0x000301DF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00032010 File Offset: 0x00030210
		public IKPropertyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKPropertyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00032048 File Offset: 0x00030248
		private static Delegate GetGetGetterHandler()
		{
			if (IKPropertyInvoker.cb_getGetter == null)
			{
				IKPropertyInvoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyInvoker.n_GetGetter));
			}
			return IKPropertyInvoker.cb_getGetter;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0003206C File Offset: 0x0003026C
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00032080 File Offset: 0x00030280
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

		// Token: 0x06000E90 RID: 3728 RVA: 0x000320D1 File Offset: 0x000302D1
		private static Delegate GetIsConstHandler()
		{
			if (IKPropertyInvoker.cb_isConst == null)
			{
				IKPropertyInvoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyInvoker.n_IsConst));
			}
			return IKPropertyInvoker.cb_isConst;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000320F5 File Offset: 0x000302F5
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00032104 File Offset: 0x00030304
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

		// Token: 0x06000E93 RID: 3731 RVA: 0x00032144 File Offset: 0x00030344
		private static Delegate GetIsLateinitHandler()
		{
			if (IKPropertyInvoker.cb_isLateinit == null)
			{
				IKPropertyInvoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyInvoker.n_IsLateinit));
			}
			return IKPropertyInvoker.cb_isLateinit;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00032168 File Offset: 0x00030368
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00032177 File Offset: 0x00030377
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

		// Token: 0x06000E96 RID: 3734 RVA: 0x000321B7 File Offset: 0x000303B7
		private static Delegate GetIsAbstractHandler()
		{
			if (IKPropertyInvoker.cb_isAbstract == null)
			{
				IKPropertyInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyInvoker.n_IsAbstract));
			}
			return IKPropertyInvoker.cb_isAbstract;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x000321DB File Offset: 0x000303DB
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x000321EA File Offset: 0x000303EA
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

		// Token: 0x06000E99 RID: 3737 RVA: 0x0003222A File Offset: 0x0003042A
		private static Delegate GetIsFinalHandler()
		{
			if (IKPropertyInvoker.cb_isFinal == null)
			{
				IKPropertyInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyInvoker.n_IsFinal));
			}
			return IKPropertyInvoker.cb_isFinal;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0003224E File Offset: 0x0003044E
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x0003225D File Offset: 0x0003045D
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

		// Token: 0x06000E9C RID: 3740 RVA: 0x0003229D File Offset: 0x0003049D
		private static Delegate GetIsOpenHandler()
		{
			if (IKPropertyInvoker.cb_isOpen == null)
			{
				IKPropertyInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyInvoker.n_IsOpen));
			}
			return IKPropertyInvoker.cb_isOpen;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000322C1 File Offset: 0x000304C1
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x000322D0 File Offset: 0x000304D0
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

		// Token: 0x06000E9F RID: 3743 RVA: 0x00032310 File Offset: 0x00030510
		private static Delegate GetIsSuspendHandler()
		{
			if (IKPropertyInvoker.cb_isSuspend == null)
			{
				IKPropertyInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKPropertyInvoker.n_IsSuspend));
			}
			return IKPropertyInvoker.cb_isSuspend;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00032334 File Offset: 0x00030534
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00032343 File Offset: 0x00030543
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

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00032383 File Offset: 0x00030583
		private static Delegate GetGetNameHandler()
		{
			if (IKPropertyInvoker.cb_getName == null)
			{
				IKPropertyInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyInvoker.n_GetName));
			}
			return IKPropertyInvoker.cb_getName;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000323A7 File Offset: 0x000305A7
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x000323BC File Offset: 0x000305BC
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

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003240D File Offset: 0x0003060D
		private static Delegate GetGetParametersHandler()
		{
			if (IKPropertyInvoker.cb_getParameters == null)
			{
				IKPropertyInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyInvoker.n_GetParameters));
			}
			return IKPropertyInvoker.cb_getParameters;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00032431 File Offset: 0x00030631
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00032448 File Offset: 0x00030648
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

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00032499 File Offset: 0x00030699
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKPropertyInvoker.cb_getReturnType == null)
			{
				IKPropertyInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyInvoker.n_GetReturnType));
			}
			return IKPropertyInvoker.cb_getReturnType;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000324BD File Offset: 0x000306BD
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x000324D4 File Offset: 0x000306D4
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

		// Token: 0x06000EAB RID: 3755 RVA: 0x00032525 File Offset: 0x00030725
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKPropertyInvoker.cb_getTypeParameters == null)
			{
				IKPropertyInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyInvoker.n_GetTypeParameters));
			}
			return IKPropertyInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00032549 File Offset: 0x00030749
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00032560 File Offset: 0x00030760
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

		// Token: 0x06000EAE RID: 3758 RVA: 0x000325B1 File Offset: 0x000307B1
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKPropertyInvoker.cb_getVisibility == null)
			{
				IKPropertyInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyInvoker.n_GetVisibility));
			}
			return IKPropertyInvoker.cb_getVisibility;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000325D5 File Offset: 0x000307D5
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x000325EC File Offset: 0x000307EC
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

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0003263D File Offset: 0x0003083D
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKPropertyInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKPropertyInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKPropertyInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKPropertyInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00032664 File Offset: 0x00030864
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000326A8 File Offset: 0x000308A8
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

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00032729 File Offset: 0x00030929
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKPropertyInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKPropertyInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKPropertyInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKPropertyInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00032750 File Offset: 0x00030950
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00032778 File Offset: 0x00030978
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

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000327EF File Offset: 0x000309EF
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKPropertyInvoker.cb_getAnnotations == null)
			{
				IKPropertyInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKPropertyInvoker.n_GetAnnotations));
			}
			return IKPropertyInvoker.cb_getAnnotations;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00032813 File Offset: 0x00030A13
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00032828 File Offset: 0x00030A28
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

		// Token: 0x04000452 RID: 1106
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty", typeof(IKPropertyInvoker));

		// Token: 0x04000453 RID: 1107
		private IntPtr class_ref;

		// Token: 0x04000454 RID: 1108
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x04000455 RID: 1109
		private IntPtr id_getGetter;

		// Token: 0x04000456 RID: 1110
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x04000457 RID: 1111
		private IntPtr id_isConst;

		// Token: 0x04000458 RID: 1112
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x04000459 RID: 1113
		private IntPtr id_isLateinit;

		// Token: 0x0400045A RID: 1114
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x0400045B RID: 1115
		private IntPtr id_isAbstract;

		// Token: 0x0400045C RID: 1116
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x0400045D RID: 1117
		private IntPtr id_isFinal;

		// Token: 0x0400045E RID: 1118
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x0400045F RID: 1119
		private IntPtr id_isOpen;

		// Token: 0x04000460 RID: 1120
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000461 RID: 1121
		private IntPtr id_isSuspend;

		// Token: 0x04000462 RID: 1122
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000463 RID: 1123
		private IntPtr id_getName;

		// Token: 0x04000464 RID: 1124
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x04000465 RID: 1125
		private IntPtr id_getParameters;

		// Token: 0x04000466 RID: 1126
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x04000467 RID: 1127
		private IntPtr id_getReturnType;

		// Token: 0x04000468 RID: 1128
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000469 RID: 1129
		private IntPtr id_getTypeParameters;

		// Token: 0x0400046A RID: 1130
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x0400046B RID: 1131
		private IntPtr id_getVisibility;

		// Token: 0x0400046C RID: 1132
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x0400046D RID: 1133
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x0400046E RID: 1134
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x0400046F RID: 1135
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000470 RID: 1136
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000471 RID: 1137
		private IntPtr id_getAnnotations;
	}
}
