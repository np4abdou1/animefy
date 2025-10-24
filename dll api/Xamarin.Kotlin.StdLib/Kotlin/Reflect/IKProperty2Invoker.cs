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
	// Token: 0x02000131 RID: 305
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty2", DoNotGenerateAcw = true)]
	internal class IKProperty2Invoker : Java.Lang.Object, IKProperty2, IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00035F48 File Offset: 0x00034148
		private static IntPtr java_class_ref
		{
			get
			{
				return IKProperty2Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00035F6C File Offset: 0x0003416C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKProperty2Invoker._members;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00035F73 File Offset: 0x00034173
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00035F7B File Offset: 0x0003417B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKProperty2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00035F87 File Offset: 0x00034187
		[NullableContext(2)]
		public static IKProperty2 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKProperty2>(handle, transfer);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00035F90 File Offset: 0x00034190
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKProperty2Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty2'.");
			}
			return handle;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00035FBB File Offset: 0x000341BB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00035FEC File Offset: 0x000341EC
		public IKProperty2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IKProperty2Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00036024 File Offset: 0x00034224
		private static Delegate GetGetGetterHandler()
		{
			if (IKProperty2Invoker.cb_getGetter == null)
			{
				IKProperty2Invoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2Invoker.n_GetGetter));
			}
			return IKProperty2Invoker.cb_getGetter;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00036048 File Offset: 0x00034248
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0003605C File Offset: 0x0003425C
		public IKPropertyGetter Getter
		{
			get
			{
				if (this.id_getGetter == IntPtr.Zero)
				{
					this.id_getGetter = JNIEnv.GetMethodID(this.class_ref, "getGetter", "()Lkotlin/reflect/KProperty2$Getter;");
				}
				return Java.Lang.Object.GetObject<IKProperty2Getter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000360AD File Offset: 0x000342AD
		private static Delegate GetGet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKProperty2Invoker.cb_get_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKProperty2Invoker.cb_get_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKProperty2Invoker.n_Get_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKProperty2Invoker.cb_get_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000360D4 File Offset: 0x000342D4
		private static IntPtr n_Get_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			IKProperty2 @object = Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2, object3));
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00036108 File Offset: 0x00034308
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

		// Token: 0x0600100D RID: 4109 RVA: 0x0003619F File Offset: 0x0003439F
		private static Delegate GetGetDelegate_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKProperty2Invoker.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKProperty2Invoker.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKProperty2Invoker.n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKProperty2Invoker.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000361C4 File Offset: 0x000343C4
		private static IntPtr n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			IKProperty2 @object = Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2, object3));
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000361F8 File Offset: 0x000343F8
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

		// Token: 0x06001010 RID: 4112 RVA: 0x0003628F File Offset: 0x0003448F
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IKProperty2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IKProperty2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IKProperty2Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IKProperty2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000362B4 File Offset: 0x000344B4
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFunction2 @object = Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3));
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000362E8 File Offset: 0x000344E8
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

		// Token: 0x06001013 RID: 4115 RVA: 0x0003637F File Offset: 0x0003457F
		private static Delegate GetIsConstHandler()
		{
			if (IKProperty2Invoker.cb_isConst == null)
			{
				IKProperty2Invoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2Invoker.n_IsConst));
			}
			return IKProperty2Invoker.cb_isConst;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000363A3 File Offset: 0x000345A3
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x000363B2 File Offset: 0x000345B2
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

		// Token: 0x06001016 RID: 4118 RVA: 0x000363F2 File Offset: 0x000345F2
		private static Delegate GetIsLateinitHandler()
		{
			if (IKProperty2Invoker.cb_isLateinit == null)
			{
				IKProperty2Invoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2Invoker.n_IsLateinit));
			}
			return IKProperty2Invoker.cb_isLateinit;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00036416 File Offset: 0x00034616
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00036425 File Offset: 0x00034625
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

		// Token: 0x06001019 RID: 4121 RVA: 0x00036465 File Offset: 0x00034665
		private static Delegate GetIsAbstractHandler()
		{
			if (IKProperty2Invoker.cb_isAbstract == null)
			{
				IKProperty2Invoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2Invoker.n_IsAbstract));
			}
			return IKProperty2Invoker.cb_isAbstract;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00036489 File Offset: 0x00034689
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00036498 File Offset: 0x00034698
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

		// Token: 0x0600101C RID: 4124 RVA: 0x000364D8 File Offset: 0x000346D8
		private static Delegate GetIsFinalHandler()
		{
			if (IKProperty2Invoker.cb_isFinal == null)
			{
				IKProperty2Invoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2Invoker.n_IsFinal));
			}
			return IKProperty2Invoker.cb_isFinal;
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000364FC File Offset: 0x000346FC
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0003650B File Offset: 0x0003470B
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

		// Token: 0x0600101F RID: 4127 RVA: 0x0003654B File Offset: 0x0003474B
		private static Delegate GetIsOpenHandler()
		{
			if (IKProperty2Invoker.cb_isOpen == null)
			{
				IKProperty2Invoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2Invoker.n_IsOpen));
			}
			return IKProperty2Invoker.cb_isOpen;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0003656F File Offset: 0x0003476F
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0003657E File Offset: 0x0003477E
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

		// Token: 0x06001022 RID: 4130 RVA: 0x000365BE File Offset: 0x000347BE
		private static Delegate GetIsSuspendHandler()
		{
			if (IKProperty2Invoker.cb_isSuspend == null)
			{
				IKProperty2Invoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty2Invoker.n_IsSuspend));
			}
			return IKProperty2Invoker.cb_isSuspend;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000365E2 File Offset: 0x000347E2
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000365F1 File Offset: 0x000347F1
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

		// Token: 0x06001025 RID: 4133 RVA: 0x00036631 File Offset: 0x00034831
		private static Delegate GetGetNameHandler()
		{
			if (IKProperty2Invoker.cb_getName == null)
			{
				IKProperty2Invoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2Invoker.n_GetName));
			}
			return IKProperty2Invoker.cb_getName;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00036655 File Offset: 0x00034855
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0003666C File Offset: 0x0003486C
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

		// Token: 0x06001028 RID: 4136 RVA: 0x000366BD File Offset: 0x000348BD
		private static Delegate GetGetParametersHandler()
		{
			if (IKProperty2Invoker.cb_getParameters == null)
			{
				IKProperty2Invoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2Invoker.n_GetParameters));
			}
			return IKProperty2Invoker.cb_getParameters;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000366E1 File Offset: 0x000348E1
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x000366F8 File Offset: 0x000348F8
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

		// Token: 0x0600102B RID: 4139 RVA: 0x00036749 File Offset: 0x00034949
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKProperty2Invoker.cb_getReturnType == null)
			{
				IKProperty2Invoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2Invoker.n_GetReturnType));
			}
			return IKProperty2Invoker.cb_getReturnType;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0003676D File Offset: 0x0003496D
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00036784 File Offset: 0x00034984
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

		// Token: 0x0600102E RID: 4142 RVA: 0x000367D5 File Offset: 0x000349D5
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKProperty2Invoker.cb_getTypeParameters == null)
			{
				IKProperty2Invoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2Invoker.n_GetTypeParameters));
			}
			return IKProperty2Invoker.cb_getTypeParameters;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000367F9 File Offset: 0x000349F9
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00036810 File Offset: 0x00034A10
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

		// Token: 0x06001031 RID: 4145 RVA: 0x00036861 File Offset: 0x00034A61
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKProperty2Invoker.cb_getVisibility == null)
			{
				IKProperty2Invoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2Invoker.n_GetVisibility));
			}
			return IKProperty2Invoker.cb_getVisibility;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00036885 File Offset: 0x00034A85
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0003689C File Offset: 0x00034A9C
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

		// Token: 0x06001034 RID: 4148 RVA: 0x000368ED File Offset: 0x00034AED
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKProperty2Invoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKProperty2Invoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty2Invoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKProperty2Invoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00036914 File Offset: 0x00034B14
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00036958 File Offset: 0x00034B58
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

		// Token: 0x06001037 RID: 4151 RVA: 0x000369D9 File Offset: 0x00034BD9
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKProperty2Invoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKProperty2Invoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty2Invoker.n_CallBy_Ljava_util_Map_));
			}
			return IKProperty2Invoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00036A00 File Offset: 0x00034C00
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00036A28 File Offset: 0x00034C28
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

		// Token: 0x0600103A RID: 4154 RVA: 0x00036A9F File Offset: 0x00034C9F
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKProperty2Invoker.cb_getAnnotations == null)
			{
				IKProperty2Invoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty2Invoker.n_GetAnnotations));
			}
			return IKProperty2Invoker.cb_getAnnotations;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00036AC3 File Offset: 0x00034CC3
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00036AD8 File Offset: 0x00034CD8
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

		// Token: 0x04000530 RID: 1328
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty2", typeof(IKProperty2Invoker));

		// Token: 0x04000531 RID: 1329
		private IntPtr class_ref;

		// Token: 0x04000532 RID: 1330
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x04000533 RID: 1331
		private IntPtr id_getGetter;

		// Token: 0x04000534 RID: 1332
		[Nullable(2)]
		private static Delegate cb_get_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000535 RID: 1333
		private IntPtr id_get_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000536 RID: 1334
		[Nullable(2)]
		private static Delegate cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000537 RID: 1335
		private IntPtr id_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000538 RID: 1336
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000539 RID: 1337
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400053A RID: 1338
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x0400053B RID: 1339
		private IntPtr id_isConst;

		// Token: 0x0400053C RID: 1340
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x0400053D RID: 1341
		private IntPtr id_isLateinit;

		// Token: 0x0400053E RID: 1342
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x0400053F RID: 1343
		private IntPtr id_isAbstract;

		// Token: 0x04000540 RID: 1344
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x04000541 RID: 1345
		private IntPtr id_isFinal;

		// Token: 0x04000542 RID: 1346
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x04000543 RID: 1347
		private IntPtr id_isOpen;

		// Token: 0x04000544 RID: 1348
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000545 RID: 1349
		private IntPtr id_isSuspend;

		// Token: 0x04000546 RID: 1350
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000547 RID: 1351
		private IntPtr id_getName;

		// Token: 0x04000548 RID: 1352
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x04000549 RID: 1353
		private IntPtr id_getParameters;

		// Token: 0x0400054A RID: 1354
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x0400054B RID: 1355
		private IntPtr id_getReturnType;

		// Token: 0x0400054C RID: 1356
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x0400054D RID: 1357
		private IntPtr id_getTypeParameters;

		// Token: 0x0400054E RID: 1358
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x0400054F RID: 1359
		private IntPtr id_getVisibility;

		// Token: 0x04000550 RID: 1360
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000551 RID: 1361
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x04000552 RID: 1362
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000553 RID: 1363
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000554 RID: 1364
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000555 RID: 1365
		private IntPtr id_getAnnotations;
	}
}
