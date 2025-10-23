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
	// Token: 0x02000129 RID: 297
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty0", DoNotGenerateAcw = true)]
	internal class IKProperty0Invoker : Java.Lang.Object, IKProperty0, IFunction0, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00033330 File Offset: 0x00031530
		private static IntPtr java_class_ref
		{
			get
			{
				return IKProperty0Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00033354 File Offset: 0x00031554
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKProperty0Invoker._members;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0003335B File Offset: 0x0003155B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00033363 File Offset: 0x00031563
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKProperty0Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0003336F File Offset: 0x0003156F
		[NullableContext(2)]
		public static IKProperty0 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKProperty0>(handle, transfer);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00033378 File Offset: 0x00031578
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKProperty0Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty0'.");
			}
			return handle;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000333A3 File Offset: 0x000315A3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x000333D4 File Offset: 0x000315D4
		public IKProperty0Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IKProperty0Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0003340C File Offset: 0x0003160C
		private static Delegate GetGetDelegateHandler()
		{
			if (IKProperty0Invoker.cb_getDelegate == null)
			{
				IKProperty0Invoker.cb_getDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetDelegate));
			}
			return IKProperty0Invoker.cb_getDelegate;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00033430 File Offset: 0x00031630
		private static IntPtr n_GetDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delegate);
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00033444 File Offset: 0x00031644
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

		// Token: 0x06000F08 RID: 3848 RVA: 0x00033495 File Offset: 0x00031695
		private static Delegate GetGetGetterHandler()
		{
			if (IKProperty0Invoker.cb_getGetter == null)
			{
				IKProperty0Invoker.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetGetter));
			}
			return IKProperty0Invoker.cb_getGetter;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000334B9 File Offset: 0x000316B9
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000334D0 File Offset: 0x000316D0
		public IKPropertyGetter Getter
		{
			get
			{
				if (this.id_getGetter == IntPtr.Zero)
				{
					this.id_getGetter = JNIEnv.GetMethodID(this.class_ref, "getGetter", "()Lkotlin/reflect/KProperty0$Getter;");
				}
				return Java.Lang.Object.GetObject<IKProperty0Getter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGetter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00033521 File Offset: 0x00031721
		private static Delegate GetGetHandler()
		{
			if (IKProperty0Invoker.cb_get == null)
			{
				IKProperty0Invoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_Get));
			}
			return IKProperty0Invoker.cb_get;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00033545 File Offset: 0x00031745
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0003355C File Offset: 0x0003175C
		[NullableContext(2)]
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000335AD File Offset: 0x000317AD
		private static Delegate GetInvokeHandler()
		{
			if (IKProperty0Invoker.cb_invoke == null)
			{
				IKProperty0Invoker.cb_invoke = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_Invoke));
			}
			return IKProperty0Invoker.cb_invoke;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000335D1 File Offset: 0x000317D1
		private static IntPtr n_Invoke(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Invoke());
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000335E8 File Offset: 0x000317E8
		[NullableContext(2)]
		public Java.Lang.Object Invoke()
		{
			if (this.id_invoke == IntPtr.Zero)
			{
				this.id_invoke = JNIEnv.GetMethodID(this.class_ref, "invoke", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00033639 File Offset: 0x00031839
		private static Delegate GetIsConstHandler()
		{
			if (IKProperty0Invoker.cb_isConst == null)
			{
				IKProperty0Invoker.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0Invoker.n_IsConst));
			}
			return IKProperty0Invoker.cb_isConst;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0003365D File Offset: 0x0003185D
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0003366C File Offset: 0x0003186C
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

		// Token: 0x06000F14 RID: 3860 RVA: 0x000336AC File Offset: 0x000318AC
		private static Delegate GetIsLateinitHandler()
		{
			if (IKProperty0Invoker.cb_isLateinit == null)
			{
				IKProperty0Invoker.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0Invoker.n_IsLateinit));
			}
			return IKProperty0Invoker.cb_isLateinit;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000336D0 File Offset: 0x000318D0
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x000336DF File Offset: 0x000318DF
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

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003371F File Offset: 0x0003191F
		private static Delegate GetIsAbstractHandler()
		{
			if (IKProperty0Invoker.cb_isAbstract == null)
			{
				IKProperty0Invoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0Invoker.n_IsAbstract));
			}
			return IKProperty0Invoker.cb_isAbstract;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00033743 File Offset: 0x00031943
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00033752 File Offset: 0x00031952
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

		// Token: 0x06000F1A RID: 3866 RVA: 0x00033792 File Offset: 0x00031992
		private static Delegate GetIsFinalHandler()
		{
			if (IKProperty0Invoker.cb_isFinal == null)
			{
				IKProperty0Invoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0Invoker.n_IsFinal));
			}
			return IKProperty0Invoker.cb_isFinal;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000337B6 File Offset: 0x000319B6
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x000337C5 File Offset: 0x000319C5
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

		// Token: 0x06000F1D RID: 3869 RVA: 0x00033805 File Offset: 0x00031A05
		private static Delegate GetIsOpenHandler()
		{
			if (IKProperty0Invoker.cb_isOpen == null)
			{
				IKProperty0Invoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0Invoker.n_IsOpen));
			}
			return IKProperty0Invoker.cb_isOpen;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00033829 File Offset: 0x00031A29
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00033838 File Offset: 0x00031A38
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

		// Token: 0x06000F20 RID: 3872 RVA: 0x00033878 File Offset: 0x00031A78
		private static Delegate GetIsSuspendHandler()
		{
			if (IKProperty0Invoker.cb_isSuspend == null)
			{
				IKProperty0Invoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0Invoker.n_IsSuspend));
			}
			return IKProperty0Invoker.cb_isSuspend;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0003389C File Offset: 0x00031A9C
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x000338AB File Offset: 0x00031AAB
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

		// Token: 0x06000F23 RID: 3875 RVA: 0x000338EB File Offset: 0x00031AEB
		private static Delegate GetGetNameHandler()
		{
			if (IKProperty0Invoker.cb_getName == null)
			{
				IKProperty0Invoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetName));
			}
			return IKProperty0Invoker.cb_getName;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0003390F File Offset: 0x00031B0F
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00033924 File Offset: 0x00031B24
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

		// Token: 0x06000F26 RID: 3878 RVA: 0x00033975 File Offset: 0x00031B75
		private static Delegate GetGetParametersHandler()
		{
			if (IKProperty0Invoker.cb_getParameters == null)
			{
				IKProperty0Invoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetParameters));
			}
			return IKProperty0Invoker.cb_getParameters;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00033999 File Offset: 0x00031B99
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x000339B0 File Offset: 0x00031BB0
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

		// Token: 0x06000F29 RID: 3881 RVA: 0x00033A01 File Offset: 0x00031C01
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKProperty0Invoker.cb_getReturnType == null)
			{
				IKProperty0Invoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetReturnType));
			}
			return IKProperty0Invoker.cb_getReturnType;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00033A25 File Offset: 0x00031C25
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00033A3C File Offset: 0x00031C3C
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

		// Token: 0x06000F2C RID: 3884 RVA: 0x00033A8D File Offset: 0x00031C8D
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKProperty0Invoker.cb_getTypeParameters == null)
			{
				IKProperty0Invoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetTypeParameters));
			}
			return IKProperty0Invoker.cb_getTypeParameters;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00033AB1 File Offset: 0x00031CB1
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00033AC8 File Offset: 0x00031CC8
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

		// Token: 0x06000F2F RID: 3887 RVA: 0x00033B19 File Offset: 0x00031D19
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKProperty0Invoker.cb_getVisibility == null)
			{
				IKProperty0Invoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetVisibility));
			}
			return IKProperty0Invoker.cb_getVisibility;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00033B3D File Offset: 0x00031D3D
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00033B54 File Offset: 0x00031D54
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

		// Token: 0x06000F32 RID: 3890 RVA: 0x00033BA5 File Offset: 0x00031DA5
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKProperty0Invoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKProperty0Invoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty0Invoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKProperty0Invoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00033BCC File Offset: 0x00031DCC
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00033C10 File Offset: 0x00031E10
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

		// Token: 0x06000F35 RID: 3893 RVA: 0x00033C91 File Offset: 0x00031E91
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKProperty0Invoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKProperty0Invoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty0Invoker.n_CallBy_Ljava_util_Map_));
			}
			return IKProperty0Invoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00033CB8 File Offset: 0x00031EB8
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00033CE0 File Offset: 0x00031EE0
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

		// Token: 0x06000F38 RID: 3896 RVA: 0x00033D57 File Offset: 0x00031F57
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKProperty0Invoker.cb_getAnnotations == null)
			{
				IKProperty0Invoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0Invoker.n_GetAnnotations));
			}
			return IKProperty0Invoker.cb_getAnnotations;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00033D7B File Offset: 0x00031F7B
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00033D90 File Offset: 0x00031F90
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

		// Token: 0x04000498 RID: 1176
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty0", typeof(IKProperty0Invoker));

		// Token: 0x04000499 RID: 1177
		private IntPtr class_ref;

		// Token: 0x0400049A RID: 1178
		[Nullable(2)]
		private static Delegate cb_getDelegate;

		// Token: 0x0400049B RID: 1179
		private IntPtr id_getDelegate;

		// Token: 0x0400049C RID: 1180
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x0400049D RID: 1181
		private IntPtr id_getGetter;

		// Token: 0x0400049E RID: 1182
		[Nullable(2)]
		private static Delegate cb_get;

		// Token: 0x0400049F RID: 1183
		private IntPtr id_get;

		// Token: 0x040004A0 RID: 1184
		[Nullable(2)]
		private static Delegate cb_invoke;

		// Token: 0x040004A1 RID: 1185
		private IntPtr id_invoke;

		// Token: 0x040004A2 RID: 1186
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x040004A3 RID: 1187
		private IntPtr id_isConst;

		// Token: 0x040004A4 RID: 1188
		[Nullable(2)]
		private static Delegate cb_isLateinit;

		// Token: 0x040004A5 RID: 1189
		private IntPtr id_isLateinit;

		// Token: 0x040004A6 RID: 1190
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x040004A7 RID: 1191
		private IntPtr id_isAbstract;

		// Token: 0x040004A8 RID: 1192
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x040004A9 RID: 1193
		private IntPtr id_isFinal;

		// Token: 0x040004AA RID: 1194
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x040004AB RID: 1195
		private IntPtr id_isOpen;

		// Token: 0x040004AC RID: 1196
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x040004AD RID: 1197
		private IntPtr id_isSuspend;

		// Token: 0x040004AE RID: 1198
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x040004AF RID: 1199
		private IntPtr id_getName;

		// Token: 0x040004B0 RID: 1200
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x040004B1 RID: 1201
		private IntPtr id_getParameters;

		// Token: 0x040004B2 RID: 1202
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x040004B3 RID: 1203
		private IntPtr id_getReturnType;

		// Token: 0x040004B4 RID: 1204
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x040004B5 RID: 1205
		private IntPtr id_getTypeParameters;

		// Token: 0x040004B6 RID: 1206
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x040004B7 RID: 1207
		private IntPtr id_getVisibility;

		// Token: 0x040004B8 RID: 1208
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x040004B9 RID: 1209
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x040004BA RID: 1210
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x040004BB RID: 1211
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x040004BC RID: 1212
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x040004BD RID: 1213
		private IntPtr id_getAnnotations;
	}
}
