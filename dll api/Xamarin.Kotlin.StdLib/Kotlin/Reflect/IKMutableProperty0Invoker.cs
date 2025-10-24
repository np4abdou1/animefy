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
	// Token: 0x02000112 RID: 274
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KMutableProperty0", DoNotGenerateAcw = true)]
	internal class IKMutableProperty0Invoker : Java.Lang.Object, IKMutableProperty0, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty0, IFunction0, IFunction
	{
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableProperty0Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKMutableProperty0Invoker._members;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0002CFCB File Offset: 0x0002B1CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0002CFD3 File Offset: 0x0002B1D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKMutableProperty0Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0002CFDF File Offset: 0x0002B1DF
		[NullableContext(2)]
		public static IKMutableProperty0 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0>(handle, transfer);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0002CFE8 File Offset: 0x0002B1E8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableProperty0Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KMutableProperty0'.");
			}
			return handle;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0002D013 File Offset: 0x0002B213
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0002D044 File Offset: 0x0002B244
		public IKMutableProperty0Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableProperty0Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0002D07C File Offset: 0x0002B27C
		private static Delegate GetGetSetterHandler()
		{
			if (IKMutableProperty0Invoker.cb_getSetter == null)
			{
				IKMutableProperty0Invoker.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetSetter));
			}
			return IKMutableProperty0Invoker.cb_getSetter;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0002D0B4 File Offset: 0x0002B2B4
		public IKMutablePropertySetter Setter
		{
			get
			{
				if (this.id_getSetter == IntPtr.Zero)
				{
					this.id_getSetter = JNIEnv.GetMethodID(this.class_ref, "getSetter", "()Lkotlin/reflect/KMutableProperty0$Setter;");
				}
				return Java.Lang.Object.GetObject<IKMutableProperty0Setter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0002D105 File Offset: 0x0002B305
		private static Delegate GetSet_Ljava_lang_Object_Handler()
		{
			if (IKMutableProperty0Invoker.cb_set_Ljava_lang_Object_ == null)
			{
				IKMutableProperty0Invoker.cb_set_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IKMutableProperty0Invoker.n_Set_Ljava_lang_Object_));
			}
			return IKMutableProperty0Invoker.cb_set_Ljava_lang_Object_;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0002D12C File Offset: 0x0002B32C
		private static void n_Set_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IKMutableProperty0 @object = Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0002D150 File Offset: 0x0002B350
		[NullableContext(2)]
		public unsafe void Set(Java.Lang.Object value)
		{
			if (this.id_set_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_set_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "set", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_set_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0002D1C1 File Offset: 0x0002B3C1
		private static Delegate GetGetGetterHandler()
		{
			if (IKMutableProperty0Invoker.cb_getGetter == null)
			{
				IKMutableProperty0Invoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetGetter));
			}
			return IKMutableProperty0Invoker.cb_getGetter;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0002D1E5 File Offset: 0x0002B3E5
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0002D1FC File Offset: 0x0002B3FC
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

		// Token: 0x06000CBD RID: 3261 RVA: 0x0002D24D File Offset: 0x0002B44D
		private static Delegate GetIsConstHandler()
		{
			if (IKMutableProperty0Invoker.cb_isConst == null)
			{
				IKMutableProperty0Invoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0Invoker.n_IsConst));
			}
			return IKMutableProperty0Invoker.cb_isConst;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0002D271 File Offset: 0x0002B471
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0002D280 File Offset: 0x0002B480
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

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0002D2C0 File Offset: 0x0002B4C0
		private static Delegate GetIsLateinitHandler()
		{
			if (IKMutableProperty0Invoker.cb_isLateinit == null)
			{
				IKMutableProperty0Invoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0Invoker.n_IsLateinit));
			}
			return IKMutableProperty0Invoker.cb_isLateinit;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0002D2E4 File Offset: 0x0002B4E4
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0002D2F3 File Offset: 0x0002B4F3
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

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0002D333 File Offset: 0x0002B533
		private static Delegate GetIsAbstractHandler()
		{
			if (IKMutableProperty0Invoker.cb_isAbstract == null)
			{
				IKMutableProperty0Invoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0Invoker.n_IsAbstract));
			}
			return IKMutableProperty0Invoker.cb_isAbstract;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0002D357 File Offset: 0x0002B557
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0002D366 File Offset: 0x0002B566
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

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0002D3A6 File Offset: 0x0002B5A6
		private static Delegate GetIsFinalHandler()
		{
			if (IKMutableProperty0Invoker.cb_isFinal == null)
			{
				IKMutableProperty0Invoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0Invoker.n_IsFinal));
			}
			return IKMutableProperty0Invoker.cb_isFinal;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0002D3CA File Offset: 0x0002B5CA
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0002D3D9 File Offset: 0x0002B5D9
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

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0002D419 File Offset: 0x0002B619
		private static Delegate GetIsOpenHandler()
		{
			if (IKMutableProperty0Invoker.cb_isOpen == null)
			{
				IKMutableProperty0Invoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0Invoker.n_IsOpen));
			}
			return IKMutableProperty0Invoker.cb_isOpen;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0002D43D File Offset: 0x0002B63D
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0002D44C File Offset: 0x0002B64C
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

		// Token: 0x06000CCC RID: 3276 RVA: 0x0002D48C File Offset: 0x0002B68C
		private static Delegate GetIsSuspendHandler()
		{
			if (IKMutableProperty0Invoker.cb_isSuspend == null)
			{
				IKMutableProperty0Invoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKMutableProperty0Invoker.n_IsSuspend));
			}
			return IKMutableProperty0Invoker.cb_isSuspend;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0002D4BF File Offset: 0x0002B6BF
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

		// Token: 0x06000CCF RID: 3279 RVA: 0x0002D4FF File Offset: 0x0002B6FF
		private static Delegate GetGetNameHandler()
		{
			if (IKMutableProperty0Invoker.cb_getName == null)
			{
				IKMutableProperty0Invoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetName));
			}
			return IKMutableProperty0Invoker.cb_getName;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0002D523 File Offset: 0x0002B723
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0002D538 File Offset: 0x0002B738
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

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0002D589 File Offset: 0x0002B789
		private static Delegate GetGetParametersHandler()
		{
			if (IKMutableProperty0Invoker.cb_getParameters == null)
			{
				IKMutableProperty0Invoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetParameters));
			}
			return IKMutableProperty0Invoker.cb_getParameters;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0002D5AD File Offset: 0x0002B7AD
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0002D5C4 File Offset: 0x0002B7C4
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

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0002D615 File Offset: 0x0002B815
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKMutableProperty0Invoker.cb_getReturnType == null)
			{
				IKMutableProperty0Invoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetReturnType));
			}
			return IKMutableProperty0Invoker.cb_getReturnType;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0002D639 File Offset: 0x0002B839
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0002D650 File Offset: 0x0002B850
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

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0002D6A1 File Offset: 0x0002B8A1
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKMutableProperty0Invoker.cb_getTypeParameters == null)
			{
				IKMutableProperty0Invoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetTypeParameters));
			}
			return IKMutableProperty0Invoker.cb_getTypeParameters;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0002D6C5 File Offset: 0x0002B8C5
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0002D6DC File Offset: 0x0002B8DC
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

		// Token: 0x06000CDB RID: 3291 RVA: 0x0002D72D File Offset: 0x0002B92D
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKMutableProperty0Invoker.cb_getVisibility == null)
			{
				IKMutableProperty0Invoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetVisibility));
			}
			return IKMutableProperty0Invoker.cb_getVisibility;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0002D751 File Offset: 0x0002B951
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0002D768 File Offset: 0x0002B968
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

		// Token: 0x06000CDE RID: 3294 RVA: 0x0002D7B9 File Offset: 0x0002B9B9
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKMutableProperty0Invoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKMutableProperty0Invoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty0Invoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKMutableProperty0Invoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0002D824 File Offset: 0x0002BA24
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

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0002D8A5 File Offset: 0x0002BAA5
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKMutableProperty0Invoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKMutableProperty0Invoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKMutableProperty0Invoker.n_CallBy_Ljava_util_Map_));
			}
			return IKMutableProperty0Invoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0002D8CC File Offset: 0x0002BACC
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
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

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0002D96B File Offset: 0x0002BB6B
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKMutableProperty0Invoker.cb_getAnnotations == null)
			{
				IKMutableProperty0Invoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetAnnotations));
			}
			return IKMutableProperty0Invoker.cb_getAnnotations;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0002D98F File Offset: 0x0002BB8F
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0002D9A4 File Offset: 0x0002BBA4
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

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0002D9F5 File Offset: 0x0002BBF5
		private static Delegate GetGetDelegateHandler()
		{
			if (IKMutableProperty0Invoker.cb_getDelegate == null)
			{
				IKMutableProperty0Invoker.cb_getDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_GetDelegate));
			}
			return IKMutableProperty0Invoker.cb_getDelegate;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0002DA19 File Offset: 0x0002BC19
		private static IntPtr n_GetDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delegate);
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002DA30 File Offset: 0x0002BC30
		[Nullable(2)]
		public Java.Lang.Object Delegate
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getDelegate == IntPtr.Zero)
				{
					this.id_getDelegate = JNIEnv.GetMethodID(this.class_ref, "getDelegate", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDelegate), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0002DA81 File Offset: 0x0002BC81
		private static Delegate GetGetHandler()
		{
			if (IKMutableProperty0Invoker.cb_get == null)
			{
				IKMutableProperty0Invoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_Get));
			}
			return IKMutableProperty0Invoker.cb_get;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0002DAA5 File Offset: 0x0002BCA5
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0002DABC File Offset: 0x0002BCBC
		[NullableContext(2)]
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0002DB0D File Offset: 0x0002BD0D
		private static Delegate GetInvokeHandler()
		{
			if (IKMutableProperty0Invoker.cb_invoke == null)
			{
				IKMutableProperty0Invoker.cb_invoke = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKMutableProperty0Invoker.n_Invoke));
			}
			return IKMutableProperty0Invoker.cb_invoke;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0002DB31 File Offset: 0x0002BD31
		private static IntPtr n_Invoke(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKMutableProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Invoke());
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0002DB48 File Offset: 0x0002BD48
		[NullableContext(2)]
		public Java.Lang.Object Invoke()
		{
			if (this.id_invoke == IntPtr.Zero)
			{
				this.id_invoke = JNIEnv.GetMethodID(this.class_ref, "invoke", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400034D RID: 845
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KMutableProperty0", typeof(IKMutableProperty0Invoker));

		// Token: 0x0400034E RID: 846
		private IntPtr class_ref;

		// Token: 0x0400034F RID: 847
		[Nullable(2)]
		private static Delegate cb_getSetter;

		// Token: 0x04000350 RID: 848
		private IntPtr id_getSetter;

		// Token: 0x04000351 RID: 849
		[Nullable(2)]
		private static Delegate cb_set_Ljava_lang_Object_;

		// Token: 0x04000352 RID: 850
		private IntPtr id_set_Ljava_lang_Object_;

		// Token: 0x04000353 RID: 851
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x04000354 RID: 852
		private IntPtr id_getGetter;

		// Token: 0x04000355 RID: 853
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x04000356 RID: 854
		private IntPtr id_isConst;

		// Token: 0x04000357 RID: 855
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x04000358 RID: 856
		private IntPtr id_isLateinit;

		// Token: 0x04000359 RID: 857
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x0400035A RID: 858
		private IntPtr id_isAbstract;

		// Token: 0x0400035B RID: 859
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x0400035C RID: 860
		private IntPtr id_isFinal;

		// Token: 0x0400035D RID: 861
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x0400035E RID: 862
		private IntPtr id_isOpen;

		// Token: 0x0400035F RID: 863
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000360 RID: 864
		private IntPtr id_isSuspend;

		// Token: 0x04000361 RID: 865
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000362 RID: 866
		private IntPtr id_getName;

		// Token: 0x04000363 RID: 867
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x04000364 RID: 868
		private IntPtr id_getParameters;

		// Token: 0x04000365 RID: 869
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x04000366 RID: 870
		private IntPtr id_getReturnType;

		// Token: 0x04000367 RID: 871
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000368 RID: 872
		private IntPtr id_getTypeParameters;

		// Token: 0x04000369 RID: 873
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x0400036A RID: 874
		private IntPtr id_getVisibility;

		// Token: 0x0400036B RID: 875
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x0400036C RID: 876
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x0400036D RID: 877
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x0400036E RID: 878
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x0400036F RID: 879
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000370 RID: 880
		private IntPtr id_getAnnotations;

		// Token: 0x04000371 RID: 881
		[Nullable(2)]
		private static Delegate cb_getDelegate;

		// Token: 0x04000372 RID: 882
		private IntPtr id_getDelegate;

		// Token: 0x04000373 RID: 883
		[Nullable(2)]
		private static Delegate cb_get;

		// Token: 0x04000374 RID: 884
		private IntPtr id_get;

		// Token: 0x04000375 RID: 885
		[Nullable(2)]
		private static Delegate cb_invoke;

		// Token: 0x04000376 RID: 886
		private IntPtr id_invoke;
	}
}
