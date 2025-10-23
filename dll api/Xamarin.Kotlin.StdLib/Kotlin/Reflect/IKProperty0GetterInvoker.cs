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
	// Token: 0x02000127 RID: 295
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty0$Getter", DoNotGenerateAcw = true)]
	internal class IKProperty0GetterInvoker : Java.Lang.Object, IKProperty0Getter, IFunction0, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKPropertyGetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x00032894 File Offset: 0x00030A94
		private static IntPtr java_class_ref
		{
			get
			{
				return IKProperty0GetterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000328B8 File Offset: 0x00030AB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKProperty0GetterInvoker._members;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000328BF File Offset: 0x00030ABF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x000328C7 File Offset: 0x00030AC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKProperty0GetterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000328D3 File Offset: 0x00030AD3
		[NullableContext(2)]
		public static IKProperty0Getter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(handle, transfer);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x000328DC File Offset: 0x00030ADC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKProperty0GetterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KProperty0.Getter'.");
			}
			return handle;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00032907 File Offset: 0x00030B07
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00032938 File Offset: 0x00030B38
		public IKProperty0GetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKProperty0GetterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00032970 File Offset: 0x00030B70
		private static Delegate GetInvokeHandler()
		{
			if (IKProperty0GetterInvoker.cb_invoke == null)
			{
				IKProperty0GetterInvoker.cb_invoke = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_Invoke));
			}
			return IKProperty0GetterInvoker.cb_invoke;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00032994 File Offset: 0x00030B94
		private static IntPtr n_Invoke(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Invoke());
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000329A8 File Offset: 0x00030BA8
		[NullableContext(2)]
		public Java.Lang.Object Invoke()
		{
			if (this.id_invoke == IntPtr.Zero)
			{
				this.id_invoke = JNIEnv.GetMethodID(this.class_ref, "invoke", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000329F9 File Offset: 0x00030BF9
		private static Delegate GetIsExternalHandler()
		{
			if (IKProperty0GetterInvoker.cb_isExternal == null)
			{
				IKProperty0GetterInvoker.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsExternal));
			}
			return IKProperty0GetterInvoker.cb_isExternal;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00032A1D File Offset: 0x00030C1D
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00032A2C File Offset: 0x00030C2C
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

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00032A6C File Offset: 0x00030C6C
		private static Delegate GetIsInfixHandler()
		{
			if (IKProperty0GetterInvoker.cb_isInfix == null)
			{
				IKProperty0GetterInvoker.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsInfix));
			}
			return IKProperty0GetterInvoker.cb_isInfix;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00032A90 File Offset: 0x00030C90
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00032A9F File Offset: 0x00030C9F
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

		// Token: 0x06000ECC RID: 3788 RVA: 0x00032ADF File Offset: 0x00030CDF
		private static Delegate GetIsInlineHandler()
		{
			if (IKProperty0GetterInvoker.cb_isInline == null)
			{
				IKProperty0GetterInvoker.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsInline));
			}
			return IKProperty0GetterInvoker.cb_isInline;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00032B03 File Offset: 0x00030D03
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00032B12 File Offset: 0x00030D12
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

		// Token: 0x06000ECF RID: 3791 RVA: 0x00032B52 File Offset: 0x00030D52
		private static Delegate GetIsOperatorHandler()
		{
			if (IKProperty0GetterInvoker.cb_isOperator == null)
			{
				IKProperty0GetterInvoker.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsOperator));
			}
			return IKProperty0GetterInvoker.cb_isOperator;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00032B76 File Offset: 0x00030D76
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00032B85 File Offset: 0x00030D85
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

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00032BC5 File Offset: 0x00030DC5
		private static Delegate GetIsSuspendHandler()
		{
			if (IKProperty0GetterInvoker.cb_isSuspend == null)
			{
				IKProperty0GetterInvoker.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsSuspend));
			}
			return IKProperty0GetterInvoker.cb_isSuspend;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00032BE9 File Offset: 0x00030DE9
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00032BF8 File Offset: 0x00030DF8
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

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00032C38 File Offset: 0x00030E38
		private static Delegate GetIsAbstractHandler()
		{
			if (IKProperty0GetterInvoker.cb_isAbstract == null)
			{
				IKProperty0GetterInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsAbstract));
			}
			return IKProperty0GetterInvoker.cb_isAbstract;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00032C5C File Offset: 0x00030E5C
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00032C6B File Offset: 0x00030E6B
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

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00032CAB File Offset: 0x00030EAB
		private static Delegate GetIsFinalHandler()
		{
			if (IKProperty0GetterInvoker.cb_isFinal == null)
			{
				IKProperty0GetterInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsFinal));
			}
			return IKProperty0GetterInvoker.cb_isFinal;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00032CCF File Offset: 0x00030ECF
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00032CDE File Offset: 0x00030EDE
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

		// Token: 0x06000EDB RID: 3803 RVA: 0x00032D1E File Offset: 0x00030F1E
		private static Delegate GetIsOpenHandler()
		{
			if (IKProperty0GetterInvoker.cb_isOpen == null)
			{
				IKProperty0GetterInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKProperty0GetterInvoker.n_IsOpen));
			}
			return IKProperty0GetterInvoker.cb_isOpen;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00032D42 File Offset: 0x00030F42
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00032D51 File Offset: 0x00030F51
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

		// Token: 0x06000EDE RID: 3806 RVA: 0x00032D91 File Offset: 0x00030F91
		private static Delegate GetGetNameHandler()
		{
			if (IKProperty0GetterInvoker.cb_getName == null)
			{
				IKProperty0GetterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_GetName));
			}
			return IKProperty0GetterInvoker.cb_getName;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00032DB5 File Offset: 0x00030FB5
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00032DCC File Offset: 0x00030FCC
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

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00032E1D File Offset: 0x0003101D
		private static Delegate GetGetParametersHandler()
		{
			if (IKProperty0GetterInvoker.cb_getParameters == null)
			{
				IKProperty0GetterInvoker.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_GetParameters));
			}
			return IKProperty0GetterInvoker.cb_getParameters;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00032E41 File Offset: 0x00031041
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00032E58 File Offset: 0x00031058
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

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00032EA9 File Offset: 0x000310A9
		private static Delegate GetGetReturnTypeHandler()
		{
			if (IKProperty0GetterInvoker.cb_getReturnType == null)
			{
				IKProperty0GetterInvoker.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_GetReturnType));
			}
			return IKProperty0GetterInvoker.cb_getReturnType;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00032ECD File Offset: 0x000310CD
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00032EE4 File Offset: 0x000310E4
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

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00032F35 File Offset: 0x00031135
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKProperty0GetterInvoker.cb_getTypeParameters == null)
			{
				IKProperty0GetterInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_GetTypeParameters));
			}
			return IKProperty0GetterInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00032F59 File Offset: 0x00031159
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00032F70 File Offset: 0x00031170
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

		// Token: 0x06000EEA RID: 3818 RVA: 0x00032FC1 File Offset: 0x000311C1
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKProperty0GetterInvoker.cb_getVisibility == null)
			{
				IKProperty0GetterInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_GetVisibility));
			}
			return IKProperty0GetterInvoker.cb_getVisibility;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00032FE5 File Offset: 0x000311E5
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00032FFC File Offset: 0x000311FC
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

		// Token: 0x06000EED RID: 3821 RVA: 0x0003304D File Offset: 0x0003124D
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (IKProperty0GetterInvoker.cb_call_arrayLjava_lang_Object_ == null)
			{
				IKProperty0GetterInvoker.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty0GetterInvoker.n_Call_arrayLjava_lang_Object_));
			}
			return IKProperty0GetterInvoker.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00033074 File Offset: 0x00031274
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000330B8 File Offset: 0x000312B8
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

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00033139 File Offset: 0x00031339
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (IKProperty0GetterInvoker.cb_callBy_Ljava_util_Map_ == null)
			{
				IKProperty0GetterInvoker.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IKProperty0GetterInvoker.n_CallBy_Ljava_util_Map_));
			}
			return IKProperty0GetterInvoker.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00033160 File Offset: 0x00031360
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IKCallable @object = Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00033188 File Offset: 0x00031388
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

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000331FF File Offset: 0x000313FF
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKProperty0GetterInvoker.cb_getAnnotations == null)
			{
				IKProperty0GetterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_GetAnnotations));
			}
			return IKProperty0GetterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00033223 File Offset: 0x00031423
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00033238 File Offset: 0x00031438
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

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00033289 File Offset: 0x00031489
		private static Delegate GetGetPropertyHandler()
		{
			if (IKProperty0GetterInvoker.cb_getProperty == null)
			{
				IKProperty0GetterInvoker.cb_getProperty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKProperty0GetterInvoker.n_GetProperty));
			}
			return IKProperty0GetterInvoker.cb_getProperty;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000332AD File Offset: 0x000314AD
		private static IntPtr n_GetProperty(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKProperty0Getter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Property);
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000332C4 File Offset: 0x000314C4
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

		// Token: 0x04000472 RID: 1138
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty0$Getter", typeof(IKProperty0GetterInvoker));

		// Token: 0x04000473 RID: 1139
		private IntPtr class_ref;

		// Token: 0x04000474 RID: 1140
		[Nullable(2)]
		private static Delegate cb_invoke;

		// Token: 0x04000475 RID: 1141
		private IntPtr id_invoke;

		// Token: 0x04000476 RID: 1142
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x04000477 RID: 1143
		private IntPtr id_isExternal;

		// Token: 0x04000478 RID: 1144
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x04000479 RID: 1145
		private IntPtr id_isInfix;

		// Token: 0x0400047A RID: 1146
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x0400047B RID: 1147
		private IntPtr id_isInline;

		// Token: 0x0400047C RID: 1148
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x0400047D RID: 1149
		private IntPtr id_isOperator;

		// Token: 0x0400047E RID: 1150
		[Nullable(2)]
		private static Delegate cb_isSuspend;

		// Token: 0x0400047F RID: 1151
		private IntPtr id_isSuspend;

		// Token: 0x04000480 RID: 1152
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x04000481 RID: 1153
		private IntPtr id_isAbstract;

		// Token: 0x04000482 RID: 1154
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x04000483 RID: 1155
		private IntPtr id_isFinal;

		// Token: 0x04000484 RID: 1156
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x04000485 RID: 1157
		private IntPtr id_isOpen;

		// Token: 0x04000486 RID: 1158
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000487 RID: 1159
		private IntPtr id_getName;

		// Token: 0x04000488 RID: 1160
		[Nullable(2)]
		private static Delegate cb_getParameters;

		// Token: 0x04000489 RID: 1161
		private IntPtr id_getParameters;

		// Token: 0x0400048A RID: 1162
		[Nullable(2)]
		private static Delegate cb_getReturnType;

		// Token: 0x0400048B RID: 1163
		private IntPtr id_getReturnType;

		// Token: 0x0400048C RID: 1164
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x0400048D RID: 1165
		private IntPtr id_getTypeParameters;

		// Token: 0x0400048E RID: 1166
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x0400048F RID: 1167
		private IntPtr id_getVisibility;

		// Token: 0x04000490 RID: 1168
		[Nullable(2)]
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x04000491 RID: 1169
		private IntPtr id_call_arrayLjava_lang_Object_;

		// Token: 0x04000492 RID: 1170
		[Nullable(2)]
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x04000493 RID: 1171
		private IntPtr id_callBy_Ljava_util_Map_;

		// Token: 0x04000494 RID: 1172
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000495 RID: 1173
		private IntPtr id_getAnnotations;

		// Token: 0x04000496 RID: 1174
		[Nullable(2)]
		private static Delegate cb_getProperty;

		// Token: 0x04000497 RID: 1175
		private IntPtr id_getProperty;
	}
}
