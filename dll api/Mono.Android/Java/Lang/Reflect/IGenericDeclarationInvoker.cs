using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Java.Lang.Reflect
{
	// Token: 0x02000402 RID: 1026
	[Register("java/lang/reflect/GenericDeclaration", DoNotGenerateAcw = true)]
	internal class IGenericDeclarationInvoker : Object, IGenericDeclaration, IAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x0007C664 File Offset: 0x0007A864
		private static IntPtr java_class_ref
		{
			get
			{
				return IGenericDeclarationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x0007C688 File Offset: 0x0007A888
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGenericDeclarationInvoker._members;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x0007C68F File Offset: 0x0007A88F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x0007C697 File Offset: 0x0007A897
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGenericDeclarationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x0007C6A3 File Offset: 0x0007A8A3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGenericDeclarationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.reflect.GenericDeclaration'.");
			}
			return handle;
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0007C6CE File Offset: 0x0007A8CE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x0007C700 File Offset: 0x0007A900
		public IGenericDeclarationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGenericDeclarationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x0007C738 File Offset: 0x0007A938
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IGenericDeclarationInvoker.cb_getTypeParameters == null)
			{
				IGenericDeclarationInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGenericDeclarationInvoker.n_GetTypeParameters));
			}
			return IGenericDeclarationInvoker.cb_getTypeParameters;
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x0007C75C File Offset: 0x0007A95C
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<ITypeVariable>(Object.GetObject<IGenericDeclaration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetTypeParameters());
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0007C770 File Offset: 0x0007A970
		public ITypeVariable[] GetTypeParameters()
		{
			if (this.id_getTypeParameters == IntPtr.Zero)
			{
				this.id_getTypeParameters = JNIEnv.GetMethodID(this.class_ref, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			}
			return (ITypeVariable[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getTypeParameters), JniHandleOwnership.TransferLocalRef, typeof(ITypeVariable));
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x0007C7D0 File Offset: 0x0007A9D0
		public unsafe Object GetAnnotation(Class annotationClass)
		{
			if (this.id_getAnnotation_Ljava_lang_Class_ == IntPtr.Zero)
			{
				this.id_getAnnotation_Ljava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
			return Object.GetObject<Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getAnnotation_Ljava_lang_Class_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x0007C84C File Offset: 0x0007AA4C
		public IAnnotation[] GetAnnotations()
		{
			if (this.id_getAnnotations == IntPtr.Zero)
			{
				this.id_getAnnotations = JNIEnv.GetMethodID(this.class_ref, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			}
			return (IAnnotation[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getAnnotations), JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x0007C8AC File Offset: 0x0007AAAC
		public IAnnotation[] GetDeclaredAnnotations()
		{
			if (this.id_getDeclaredAnnotations == IntPtr.Zero)
			{
				this.id_getDeclaredAnnotations = JNIEnv.GetMethodID(this.class_ref, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			}
			return (IAnnotation[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getDeclaredAnnotations), JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x0007C90C File Offset: 0x0007AB0C
		public unsafe bool IsAnnotationPresent(Class annotationClass)
		{
			if (this.id_isAnnotationPresent_Ljava_lang_Class_ == IntPtr.Zero)
			{
				this.id_isAnnotationPresent_Ljava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_isAnnotationPresent_Ljava_lang_Class_, ptr);
		}

		// Token: 0x040011D2 RID: 4562
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/GenericDeclaration", typeof(IGenericDeclarationInvoker));

		// Token: 0x040011D3 RID: 4563
		private IntPtr class_ref;

		// Token: 0x040011D4 RID: 4564
		private static Delegate cb_getTypeParameters;

		// Token: 0x040011D5 RID: 4565
		private IntPtr id_getTypeParameters;

		// Token: 0x040011D6 RID: 4566
		private IntPtr id_getAnnotation_Ljava_lang_Class_;

		// Token: 0x040011D7 RID: 4567
		private IntPtr id_getAnnotations;

		// Token: 0x040011D8 RID: 4568
		private IntPtr id_getDeclaredAnnotations;

		// Token: 0x040011D9 RID: 4569
		private IntPtr id_isAnnotationPresent_Ljava_lang_Class_;
	}
}
