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
	// Token: 0x0200012D RID: 301
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty1", DoNotGenerateAcw = true)]
	internal class IKProperty1Invoker : Java.Lang.Object, IKProperty1, IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x000348D0 File Offset: 0x00032AD0
		private static IntPtr java_class_ref
		{
			get
			{
				return IKProperty1Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x000348F4 File Offset: 0x00032AF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKProperty1Invoker._members;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x000348FB File Offset: 0x00032AFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00034903 File Offset: 0x00032B03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKProperty1Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0003490F File Offset: 0x00032B0F
		[NullableContext(2)]
		public static IKProperty1 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKProperty1>(handle, transfer);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00034918 File Offset: 0x00032B18
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKProperty1Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty1'.");
			}
			return handle;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00034943 File Offset: 0x00032B43
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00034974 File Offset: 0x00032B74
		public IKProperty1Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IKProperty1Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000349AC File Offset: 0x00032BAC
		private static Delegate GetGetGetterHandler()
		{
			if (IKProperty1Invoker.cb_getGetter == null)
			{
				IKProperty1Invoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1Invoker.n_GetGetter));
			}
			return IKProperty1Invoker.cb_getGetter;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000349D0 File Offset: 0x00032BD0
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x000349E4 File Offset: 0x00032BE4
		public IKPropertyGetter Getter
		{
			get
			{
				if (this.id_getGetter == IntPtr.Zero)
				{
					this.id_getGetter = JNIEnv.GetMethodID(this.class_ref, "getGetter", "()Lkotlin/reflect/KProperty1$Getter;");
				}
				return Java.Lang.Object.GetObject<IKProperty1Getter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00034A35 File Offset: 0x00032C35
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (IKProperty1Invoker.cb_get_Ljava_lang_Object_ == null)
			{
				IKProperty1Invoker.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1Invoker.n_Get_Ljava_lang_Object_));
			}
			return IKProperty1Invoker.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00034A5C File Offset: 0x00032C5C
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			IKProperty1 @object = Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00034A84 File Offset: 0x00032C84
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

		// Token: 0x06000F8C RID: 3980 RVA: 0x00034AFB File Offset: 0x00032CFB
		private static Delegate GetGetDelegate_Ljava_lang_Object_Handler()
		{
			if (IKProperty1Invoker.cb_getDelegate_Ljava_lang_Object_ == null)
			{
				IKProperty1Invoker.cb_getDelegate_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1Invoker.n_GetDelegate_Ljava_lang_Object_));
			}
			return IKProperty1Invoker.cb_getDelegate_Ljava_lang_Object_;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00034B20 File Offset: 0x00032D20
		private static IntPtr n_GetDelegate_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			IKProperty1 @object = Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2));
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00034B48 File Offset: 0x00032D48
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

		// Token: 0x06000F8F RID: 3983 RVA: 0x00034BBF File Offset: 0x00032DBF
		private static Delegate GetInvoke_Ljava_lang_Object_Handler()
		{
			if (IKProperty1Invoker.cb_invoke_Ljava_lang_Object_ == null)
			{
				IKProperty1Invoker.cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1Invoker.n_Invoke_Ljava_lang_Object_));
			}
			return IKProperty1Invoker.cb_invoke_Ljava_lang_Object_;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00034BE4 File Offset: 0x00032DE4
		private static IntPtr n_Invoke_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFunction1 @object = Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2));
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00034C0C File Offset: 0x00032E0C
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

		// Token: 0x06000F92 RID: 3986 RVA: 0x00034C83 File Offset: 0x00032E83
		private static Delegate GetIsConstHandler()
		{
			if (IKProperty1Invoker.cb_isConst == null)
			{
				IKProperty1Invoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1Invoker.n_IsConst));
			}
			return IKProperty1Invoker.cb_isConst;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00034CA7 File Offset: 0x00032EA7
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00034CB6 File Offset: 0x00032EB6
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

		// Token: 0x06000F95 RID: 3989 RVA: 0x00034CF6 File Offset: 0x00032EF6
		private static Delegate GetIsLateinitHandler()
		{
			if (IKProperty1Invoker.cb_isLateinit == null)
			{
				IKProperty1Invoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1Invoker.n_IsLateinit));
			}
			return IKProperty1Invoker.cb_isLateinit;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00034D1A File Offset: 0x00032F1A
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00034D29 File Offset: 0x00032F29
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

		// Token: 0x06000F98 RID: 3992 RVA: 0x00034D69 File Offset: 0x00032F69
		private static Delegate GetIsAbstractHandler()
		{
			if (IKProperty1Invoker.cb_isAbstract == null)
			{
				IKProperty1Invoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1Invoker.n_IsAbstract));
			}
			return IKProperty1Invoker.cb_isAbstract;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00034D8D File Offset: 0x00032F8D
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00034D9C File Offset: 0x00032F9C
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

		// Token: 0x06000F9B RID: 3995 RVA: 0x00034DDC File Offset: 0x00032FDC
		private static Delegate GetIsFinalHandler()
		{
			if (IKProperty1Invoker.cb_isFinal == null)
			{
				IKProperty1Invoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1Invoker.n_IsFinal));
			}
			return IKProperty1Invoker.cb_isFinal;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00034E00 File Offset: 0x00033000
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00034E0F File Offset: 0x0003300F
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

		// Token: 0x06000F9E RID: 3998 RVA: 0x00034E4F File Offset: 0x0003304F
		private static Delegate GetIsOpenHandler()
		{
			if (IKProperty1Invoker.cb_isOpen == null)
			{
				IKProperty1Invoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1Invoker.n_IsOpen));
			}
			return IKProperty1Invoker.cb_isOpen;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00034E73 File Offset: 0x00033073
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00034E82 File Offset: 0x00033082
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

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00034EC2 File Offset: 0x000330C2
		private static Delegate GetIsSuspendHandler()
		{
			if (IKProperty1Invoker.cb_isSuspend == null)
			{
				IKProperty1Invoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty1Invoker.n_IsSuspend));
			}
			return IKProperty1Invoker.cb_isSuspend;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00034EE6 File Offset: 0x000330E6
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00034EF5 File Offset: 0x000330F5
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

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00034F35 File Offset: 0x00033135
		private static Delegate GetGetNameHandler()
		{
			if (IKProperty1Invoker.cb_getName == null)
			{
				IKProperty1Invoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1Invoker.n_GetName));
			}
			return IKProperty1Invoker.cb_getName;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00034F59 File Offset: 0x00033159
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00034F70 File Offset: 0x00033170
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

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00034FC1 File Offset: 0x000331C1
		private static Delegate GetGetParametersHandler()
		{
			if (IKProperty1Invoker.cb_getParameters == null)
			{
				IKProperty1Invoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1Invoker.n_GetParameters));
			}
			return IKProperty1Invoker.cb_getParameters;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00034FE5 File Offset: 0x000331E5
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00034FFC File Offset: 0x000331FC
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

		// Token: 0x06000FAA RID: 4010 RVA: 0x0003504D File Offset: 0x0003324D
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKProperty1Invoker.cb_getReturnType == null)
			{
				IKProperty1Invoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1Invoker.n_GetReturnType));
			}
			return IKProperty1Invoker.cb_getReturnType;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00035071 File Offset: 0x00033271
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00035088 File Offset: 0x00033288
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

		// Token: 0x06000FAD RID: 4013 RVA: 0x000350D9 File Offset: 0x000332D9
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKProperty1Invoker.cb_getTypeParameters == null)
			{
				IKProperty1Invoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1Invoker.n_GetTypeParameters));
			}
			return IKProperty1Invoker.cb_getTypeParameters;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000350FD File Offset: 0x000332FD
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00035114 File Offset: 0x00033314
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

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00035165 File Offset: 0x00033365
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKProperty1Invoker.cb_getVisibility == null)
			{
				IKProperty1Invoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1Invoker.n_GetVisibility));
			}
			return IKProperty1Invoker.cb_getVisibility;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00035189 File Offset: 0x00033389
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x000351A0 File Offset: 0x000333A0
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

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000351F1 File Offset: 0x000333F1
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKProperty1Invoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKProperty1Invoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1Invoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKProperty1Invoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00035218 File Offset: 0x00033418
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0003525C File Offset: 0x0003345C
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

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000352DD File Offset: 0x000334DD
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKProperty1Invoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKProperty1Invoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty1Invoker.n_CallBy_Ljava_util_Map_));
			}
			return IKProperty1Invoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00035304 File Offset: 0x00033504
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0003532C File Offset: 0x0003352C
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

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000353A3 File Offset: 0x000335A3
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKProperty1Invoker.cb_getAnnotations == null)
			{
				IKProperty1Invoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty1Invoker.n_GetAnnotations));
			}
			return IKProperty1Invoker.cb_getAnnotations;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000353C7 File Offset: 0x000335C7
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000353DC File Offset: 0x000335DC
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

		// Token: 0x040004E4 RID: 1252
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty1", typeof(IKProperty1Invoker));

		// Token: 0x040004E5 RID: 1253
		private IntPtr class_ref;

		// Token: 0x040004E6 RID: 1254
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x040004E7 RID: 1255
		private IntPtr id_getGetter;

		// Token: 0x040004E8 RID: 1256
		[Nullable(2)]
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x040004E9 RID: 1257
		private IntPtr id_get_Ljava_lang_Object_;

		// Token: 0x040004EA RID: 1258
		[Nullable(2)]
		private static Delegate cb_getDelegate_Ljava_lang_Object_;

		// Token: 0x040004EB RID: 1259
		private IntPtr id_getDelegate_Ljava_lang_Object_;

		// Token: 0x040004EC RID: 1260
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_;

		// Token: 0x040004ED RID: 1261
		private IntPtr id_invoke_Ljava_lang_Object_;

		// Token: 0x040004EE RID: 1262
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x040004EF RID: 1263
		private IntPtr id_isConst;

		// Token: 0x040004F0 RID: 1264
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x040004F1 RID: 1265
		private IntPtr id_isLateinit;

		// Token: 0x040004F2 RID: 1266
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040004F3 RID: 1267
		private IntPtr id_isAbstract;

		// Token: 0x040004F4 RID: 1268
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040004F5 RID: 1269
		private IntPtr id_isFinal;

		// Token: 0x040004F6 RID: 1270
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040004F7 RID: 1271
		private IntPtr id_isOpen;

		// Token: 0x040004F8 RID: 1272
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x040004F9 RID: 1273
		private IntPtr id_isSuspend;

		// Token: 0x040004FA RID: 1274
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x040004FB RID: 1275
		private IntPtr id_getName;

		// Token: 0x040004FC RID: 1276
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x040004FD RID: 1277
		private IntPtr id_getParameters;

		// Token: 0x040004FE RID: 1278
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x040004FF RID: 1279
		private IntPtr id_getReturnType;

		// Token: 0x04000500 RID: 1280
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x04000501 RID: 1281
		private IntPtr id_getTypeParameters;

		// Token: 0x04000502 RID: 1282
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x04000503 RID: 1283
		private IntPtr id_getVisibility;

		// Token: 0x04000504 RID: 1284
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000505 RID: 1285
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x04000506 RID: 1286
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000507 RID: 1287
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000508 RID: 1288
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000509 RID: 1289
		private IntPtr id_getAnnotations;
	}
}
