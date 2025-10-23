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
	// Token: 0x0200010E RID: 270
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty", DoNotGenerateAcw = true)]
	internal class IKMutablePropertyInvoker : Java.Lang.Object, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0002BB18 File Offset: 0x00029D18
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutablePropertyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0002BB3C File Offset: 0x00029D3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutablePropertyInvoker._members;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0002BB43 File Offset: 0x00029D43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0002BB4B File Offset: 0x00029D4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutablePropertyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0002BB57 File Offset: 0x00029D57
		[NullableContext(2)]
		public static IKMutableProperty GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty>(handle, transfer);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0002BB60 File Offset: 0x00029D60
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutablePropertyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty'.");
			}
			return handle;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0002BB8B File Offset: 0x00029D8B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0002BBBC File Offset: 0x00029DBC
		public IKMutablePropertyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutablePropertyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0002BBF4 File Offset: 0x00029DF4
		private static Delegate GetGetSetterHandler()
		{
			if (IKMutablePropertyInvoker.cb_getSetter == null)
			{
				IKMutablePropertyInvoker.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetSetter));
			}
			return IKMutablePropertyInvoker.cb_getSetter;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0002BC18 File Offset: 0x00029E18
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0002BC2C File Offset: 0x00029E2C
		public IKMutablePropertySetter Setter
		{
			get
			{
				if (this.id_getSetter == IntPtr.Zero)
				{
					this.id_getSetter = JNIEnv.GetMethodID(this.class_ref, "getSetter", "()Lkotlin/reflect/KMutableProperty$Setter;");
				}
				return Java.Lang.Object.GetObject<IKMutablePropertySetter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0002BC7D File Offset: 0x00029E7D
		private static Delegate GetGetGetterHandler()
		{
			if (IKMutablePropertyInvoker.cb_getGetter == null)
			{
				IKMutablePropertyInvoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetGetter));
			}
			return IKMutablePropertyInvoker.cb_getGetter;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0002BCA1 File Offset: 0x00029EA1
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0002BCB8 File Offset: 0x00029EB8
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

		// Token: 0x06000C40 RID: 3136 RVA: 0x0002BD09 File Offset: 0x00029F09
		private static Delegate GetIsConstHandler()
		{
			if (IKMutablePropertyInvoker.cb_isConst == null)
			{
				IKMutablePropertyInvoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertyInvoker.n_IsConst));
			}
			return IKMutablePropertyInvoker.cb_isConst;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0002BD2D File Offset: 0x00029F2D
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0002BD3C File Offset: 0x00029F3C
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

		// Token: 0x06000C43 RID: 3139 RVA: 0x0002BD7C File Offset: 0x00029F7C
		private static Delegate GetIsLateinitHandler()
		{
			if (IKMutablePropertyInvoker.cb_isLateinit == null)
			{
				IKMutablePropertyInvoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertyInvoker.n_IsLateinit));
			}
			return IKMutablePropertyInvoker.cb_isLateinit;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0002BDAF File Offset: 0x00029FAF
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

		// Token: 0x06000C46 RID: 3142 RVA: 0x0002BDEF File Offset: 0x00029FEF
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutablePropertyInvoker.cb_isAbstract == null)
			{
				IKMutablePropertyInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertyInvoker.n_IsAbstract));
			}
			return IKMutablePropertyInvoker.cb_isAbstract;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0002BE13 File Offset: 0x0002A013
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0002BE22 File Offset: 0x0002A022
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

		// Token: 0x06000C49 RID: 3145 RVA: 0x0002BE62 File Offset: 0x0002A062
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutablePropertyInvoker.cb_isFinal == null)
			{
				IKMutablePropertyInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertyInvoker.n_IsFinal));
			}
			return IKMutablePropertyInvoker.cb_isFinal;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0002BE86 File Offset: 0x0002A086
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0002BE95 File Offset: 0x0002A095
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

		// Token: 0x06000C4C RID: 3148 RVA: 0x0002BED5 File Offset: 0x0002A0D5
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutablePropertyInvoker.cb_isOpen == null)
			{
				IKMutablePropertyInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertyInvoker.n_IsOpen));
			}
			return IKMutablePropertyInvoker.cb_isOpen;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0002BEF9 File Offset: 0x0002A0F9
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0002BF08 File Offset: 0x0002A108
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

		// Token: 0x06000C4F RID: 3151 RVA: 0x0002BF48 File Offset: 0x0002A148
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutablePropertyInvoker.cb_isSuspend == null)
			{
				IKMutablePropertyInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutablePropertyInvoker.n_IsSuspend));
			}
			return IKMutablePropertyInvoker.cb_isSuspend;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0002BF6C File Offset: 0x0002A16C
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0002BF7B File Offset: 0x0002A17B
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

		// Token: 0x06000C52 RID: 3154 RVA: 0x0002BFBB File Offset: 0x0002A1BB
		private static Delegate GetGetNameHandler()
		{
			if (IKMutablePropertyInvoker.cb_getName == null)
			{
				IKMutablePropertyInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetName));
			}
			return IKMutablePropertyInvoker.cb_getName;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0002BFDF File Offset: 0x0002A1DF
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0002BFF4 File Offset: 0x0002A1F4
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

		// Token: 0x06000C55 RID: 3157 RVA: 0x0002C045 File Offset: 0x0002A245
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutablePropertyInvoker.cb_getParameters == null)
			{
				IKMutablePropertyInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetParameters));
			}
			return IKMutablePropertyInvoker.cb_getParameters;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0002C069 File Offset: 0x0002A269
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0002C080 File Offset: 0x0002A280
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

		// Token: 0x06000C58 RID: 3160 RVA: 0x0002C0D1 File Offset: 0x0002A2D1
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutablePropertyInvoker.cb_getReturnType == null)
			{
				IKMutablePropertyInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetReturnType));
			}
			return IKMutablePropertyInvoker.cb_getReturnType;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0002C0F5 File Offset: 0x0002A2F5
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0002C10C File Offset: 0x0002A30C
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

		// Token: 0x06000C5B RID: 3163 RVA: 0x0002C15D File Offset: 0x0002A35D
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutablePropertyInvoker.cb_getTypeParameters == null)
			{
				IKMutablePropertyInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetTypeParameters));
			}
			return IKMutablePropertyInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0002C181 File Offset: 0x0002A381
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0002C198 File Offset: 0x0002A398
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

		// Token: 0x06000C5E RID: 3166 RVA: 0x0002C1E9 File Offset: 0x0002A3E9
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutablePropertyInvoker.cb_getVisibility == null)
			{
				IKMutablePropertyInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetVisibility));
			}
			return IKMutablePropertyInvoker.cb_getVisibility;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0002C20D File Offset: 0x0002A40D
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0002C224 File Offset: 0x0002A424
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

		// Token: 0x06000C61 RID: 3169 RVA: 0x0002C275 File Offset: 0x0002A475
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutablePropertyInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutablePropertyInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutablePropertyInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutablePropertyInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0002C29C File Offset: 0x0002A49C
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
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

		// Token: 0x06000C64 RID: 3172 RVA: 0x0002C361 File Offset: 0x0002A561
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutablePropertyInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutablePropertyInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutablePropertyInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutablePropertyInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0002C388 File Offset: 0x0002A588
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0002C3B0 File Offset: 0x0002A5B0
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

		// Token: 0x06000C67 RID: 3175 RVA: 0x0002C427 File Offset: 0x0002A627
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutablePropertyInvoker.cb_getAnnotations == null)
			{
				IKMutablePropertyInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutablePropertyInvoker.n_GetAnnotations));
			}
			return IKMutablePropertyInvoker.cb_getAnnotations;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0002C44B File Offset: 0x0002A64B
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0002C460 File Offset: 0x0002A660
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

		// Token: 0x04000305 RID: 773
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty", typeof(IKMutablePropertyInvoker));

		// Token: 0x04000306 RID: 774
		private IntPtr class_ref;

		// Token: 0x04000307 RID: 775
		[Nullable(2)]
		private static Delegate cb_getSetter;

		// Token: 0x04000308 RID: 776
		private IntPtr id_getSetter;

		// Token: 0x04000309 RID: 777
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x0400030A RID: 778
		private IntPtr id_getGetter;

		// Token: 0x0400030B RID: 779
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x0400030C RID: 780
		private IntPtr id_isConst;

		// Token: 0x0400030D RID: 781
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x0400030E RID: 782
		private IntPtr id_isLateinit;

		// Token: 0x0400030F RID: 783
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x04000310 RID: 784
		private IntPtr id_isAbstract;

		// Token: 0x04000311 RID: 785
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x04000312 RID: 786
		private IntPtr id_isFinal;

		// Token: 0x04000313 RID: 787
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x04000314 RID: 788
		private IntPtr id_isOpen;

		// Token: 0x04000315 RID: 789
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000316 RID: 790
		private IntPtr id_isSuspend;

		// Token: 0x04000317 RID: 791
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000318 RID: 792
		private IntPtr id_getName;

		// Token: 0x04000319 RID: 793
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x0400031A RID: 794
		private IntPtr id_getParameters;

		// Token: 0x0400031B RID: 795
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x0400031C RID: 796
		private IntPtr id_getReturnType;

		// Token: 0x0400031D RID: 797
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x0400031E RID: 798
		private IntPtr id_getTypeParameters;

		// Token: 0x0400031F RID: 799
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x04000320 RID: 800
		private IntPtr id_getVisibility;

		// Token: 0x04000321 RID: 801
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000322 RID: 802
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x04000323 RID: 803
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000324 RID: 804
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000325 RID: 805
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000326 RID: 806
		private IntPtr id_getAnnotations;
	}
}
