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
	// Token: 0x02000100 RID: 256
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KCallable", DoNotGenerateAcw = true)]
	internal class IKCallableInvoker : Java.Lang.Object, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00028F60 File Offset: 0x00027160
		private static IntPtr java_class_ref
		{
			get
			{
				return IKCallableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00028F84 File Offset: 0x00027184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKCallableInvoker._members;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00028F8B File Offset: 0x0002718B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00028F93 File Offset: 0x00027193
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKCallableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00028F9F File Offset: 0x0002719F
		[NullableContext(2)]
		public static IKCallable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKCallable>(handle, transfer);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00028FA8 File Offset: 0x000271A8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKCallableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KCallable'.");
			}
			return handle;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00028FD3 File Offset: 0x000271D3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00029004 File Offset: 0x00027204
		public IKCallableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKCallableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002903C File Offset: 0x0002723C
		private static Delegate GetIsAbstractHandler()
		{
			if (IKCallableInvoker.cb_isAbstract == null)
			{
				IKCallableInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKCallableInvoker.n_IsAbstract));
			}
			return IKCallableInvoker.cb_isAbstract;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00029060 File Offset: 0x00027260
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0002906F File Offset: 0x0002726F
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

		// Token: 0x06000B0F RID: 2831 RVA: 0x000290AF File Offset: 0x000272AF
		private static Delegate GetIsFinalHandler()
		{
			if (IKCallableInvoker.cb_isFinal == null)
			{
				IKCallableInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKCallableInvoker.n_IsFinal));
			}
			return IKCallableInvoker.cb_isFinal;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000290D3 File Offset: 0x000272D3
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000290E2 File Offset: 0x000272E2
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

		// Token: 0x06000B12 RID: 2834 RVA: 0x00029122 File Offset: 0x00027322
		private static Delegate GetIsOpenHandler()
		{
			if (IKCallableInvoker.cb_isOpen == null)
			{
				IKCallableInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKCallableInvoker.n_IsOpen));
			}
			return IKCallableInvoker.cb_isOpen;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00029146 File Offset: 0x00027346
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00029155 File Offset: 0x00027355
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

		// Token: 0x06000B15 RID: 2837 RVA: 0x00029195 File Offset: 0x00027395
		private static Delegate GetIsSuspendHandler()
		{
			if (IKCallableInvoker.cb_isSuspend == null)
			{
				IKCallableInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKCallableInvoker.n_IsSuspend));
			}
			return IKCallableInvoker.cb_isSuspend;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000291B9 File Offset: 0x000273B9
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000291C8 File Offset: 0x000273C8
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

		// Token: 0x06000B18 RID: 2840 RVA: 0x00029208 File Offset: 0x00027408
		private static Delegate GetGetNameHandler()
		{
			if (IKCallableInvoker.cb_getName == null)
			{
				IKCallableInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKCallableInvoker.n_GetName));
			}
			return IKCallableInvoker.cb_getName;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002922C File Offset: 0x0002742C
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00029240 File Offset: 0x00027440
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

		// Token: 0x06000B1B RID: 2843 RVA: 0x00029291 File Offset: 0x00027491
		private static Delegate GetGetParametersHandler()
		{
			if (IKCallableInvoker.cb_getParameters == null)
			{
				IKCallableInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKCallableInvoker.n_GetParameters));
			}
			return IKCallableInvoker.cb_getParameters;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000292B5 File Offset: 0x000274B5
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x000292CC File Offset: 0x000274CC
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

		// Token: 0x06000B1E RID: 2846 RVA: 0x0002931D File Offset: 0x0002751D
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKCallableInvoker.cb_getReturnType == null)
			{
				IKCallableInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKCallableInvoker.n_GetReturnType));
			}
			return IKCallableInvoker.cb_getReturnType;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00029341 File Offset: 0x00027541
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00029358 File Offset: 0x00027558
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

		// Token: 0x06000B21 RID: 2849 RVA: 0x000293A9 File Offset: 0x000275A9
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKCallableInvoker.cb_getTypeParameters == null)
			{
				IKCallableInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKCallableInvoker.n_GetTypeParameters));
			}
			return IKCallableInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x000293CD File Offset: 0x000275CD
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000293E4 File Offset: 0x000275E4
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

		// Token: 0x06000B24 RID: 2852 RVA: 0x00029435 File Offset: 0x00027635
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKCallableInvoker.cb_getVisibility == null)
			{
				IKCallableInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKCallableInvoker.n_GetVisibility));
			}
			return IKCallableInvoker.cb_getVisibility;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00029459 File Offset: 0x00027659
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00029470 File Offset: 0x00027670
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

		// Token: 0x06000B27 RID: 2855 RVA: 0x000294C1 File Offset: 0x000276C1
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKCallableInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKCallableInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKCallableInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKCallableInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000294E8 File Offset: 0x000276E8
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002952C File Offset: 0x0002772C
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

		// Token: 0x06000B2A RID: 2858 RVA: 0x000295AD File Offset: 0x000277AD
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKCallableInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKCallableInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKCallableInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKCallableInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x000295D4 File Offset: 0x000277D4
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x000295FC File Offset: 0x000277FC
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

		// Token: 0x06000B2D RID: 2861 RVA: 0x00029673 File Offset: 0x00027873
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKCallableInvoker.cb_getAnnotations == null)
			{
				IKCallableInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKCallableInvoker.n_GetAnnotations));
			}
			return IKCallableInvoker.cb_getAnnotations;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00029697 File Offset: 0x00027897
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKCallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x000296AC File Offset: 0x000278AC
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

		// Token: 0x0400026D RID: 621
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KCallable", typeof(IKCallableInvoker));

		// Token: 0x0400026E RID: 622
		private IntPtr class_ref;

		// Token: 0x0400026F RID: 623
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x04000270 RID: 624
		private IntPtr id_isAbstract;

		// Token: 0x04000271 RID: 625
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x04000272 RID: 626
		private IntPtr id_isFinal;

		// Token: 0x04000273 RID: 627
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x04000274 RID: 628
		private IntPtr id_isOpen;

		// Token: 0x04000275 RID: 629
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x04000276 RID: 630
		private IntPtr id_isSuspend;

		// Token: 0x04000277 RID: 631
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000278 RID: 632
		private IntPtr id_getName;

		// Token: 0x04000279 RID: 633
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x0400027A RID: 634
		private IntPtr id_getParameters;

		// Token: 0x0400027B RID: 635
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x0400027C RID: 636
		private IntPtr id_getReturnType;

		// Token: 0x0400027D RID: 637
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x0400027E RID: 638
		private IntPtr id_getTypeParameters;

		// Token: 0x0400027F RID: 639
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x04000280 RID: 640
		private IntPtr id_getVisibility;

		// Token: 0x04000281 RID: 641
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000282 RID: 642
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x04000283 RID: 643
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000284 RID: 644
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000285 RID: 645
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000286 RID: 646
		private IntPtr id_getAnnotations;
	}
}
