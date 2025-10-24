using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Java.Lang.Reflect
{
	// Token: 0x02000400 RID: 1024
	[Register("java/lang/reflect/AnnotatedElement", DoNotGenerateAcw = true)]
	internal class IAnnotatedElementInvoker : Object, IAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x0007C2C0 File Offset: 0x0007A4C0
		private static IntPtr java_class_ref
		{
			get
			{
				return IAnnotatedElementInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x0007C2E4 File Offset: 0x0007A4E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAnnotatedElementInvoker._members;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x0007C2EB File Offset: 0x0007A4EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x0007C2F3 File Offset: 0x0007A4F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAnnotatedElementInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x0007C2FF File Offset: 0x0007A4FF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAnnotatedElementInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.reflect.AnnotatedElement'.");
			}
			return handle;
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0007C32A File Offset: 0x0007A52A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x0007C35C File Offset: 0x0007A55C
		public IAnnotatedElementInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAnnotatedElementInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x0007C394 File Offset: 0x0007A594
		private static Delegate GetGetAnnotation_Ljava_lang_Class_Handler()
		{
			if (IAnnotatedElementInvoker.cb_getAnnotation_Ljava_lang_Class_ == null)
			{
				IAnnotatedElementInvoker.cb_getAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAnnotatedElementInvoker.n_GetAnnotation_Ljava_lang_Class_));
			}
			return IAnnotatedElementInvoker.cb_getAnnotation_Ljava_lang_Class_;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x0007C3B8 File Offset: 0x0007A5B8
		private static IntPtr n_GetAnnotation_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			IAnnotatedElement @object = Object.GetObject<IAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetAnnotation(object2));
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x0007C3E0 File Offset: 0x0007A5E0
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

		// Token: 0x06002D26 RID: 11558 RVA: 0x0007C459 File Offset: 0x0007A659
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IAnnotatedElementInvoker.cb_getAnnotations == null)
			{
				IAnnotatedElementInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAnnotatedElementInvoker.n_GetAnnotations));
			}
			return IAnnotatedElementInvoker.cb_getAnnotations;
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x0007C47D File Offset: 0x0007A67D
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<IAnnotation>(Object.GetObject<IAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAnnotations());
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0007C494 File Offset: 0x0007A694
		public IAnnotation[] GetAnnotations()
		{
			if (this.id_getAnnotations == IntPtr.Zero)
			{
				this.id_getAnnotations = JNIEnv.GetMethodID(this.class_ref, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			}
			return (IAnnotation[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getAnnotations), JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x0007C4F4 File Offset: 0x0007A6F4
		private static Delegate GetGetDeclaredAnnotationsHandler()
		{
			if (IAnnotatedElementInvoker.cb_getDeclaredAnnotations == null)
			{
				IAnnotatedElementInvoker.cb_getDeclaredAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAnnotatedElementInvoker.n_GetDeclaredAnnotations));
			}
			return IAnnotatedElementInvoker.cb_getDeclaredAnnotations;
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x0007C518 File Offset: 0x0007A718
		private static IntPtr n_GetDeclaredAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<IAnnotation>(Object.GetObject<IAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDeclaredAnnotations());
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x0007C52C File Offset: 0x0007A72C
		public IAnnotation[] GetDeclaredAnnotations()
		{
			if (this.id_getDeclaredAnnotations == IntPtr.Zero)
			{
				this.id_getDeclaredAnnotations = JNIEnv.GetMethodID(this.class_ref, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			}
			return (IAnnotation[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getDeclaredAnnotations), JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x0007C58C File Offset: 0x0007A78C
		private static Delegate GetIsAnnotationPresent_Ljava_lang_Class_Handler()
		{
			if (IAnnotatedElementInvoker.cb_isAnnotationPresent_Ljava_lang_Class_ == null)
			{
				IAnnotatedElementInvoker.cb_isAnnotationPresent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAnnotatedElementInvoker.n_IsAnnotationPresent_Ljava_lang_Class_));
			}
			return IAnnotatedElementInvoker.cb_isAnnotationPresent_Ljava_lang_Class_;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x0007C5B0 File Offset: 0x0007A7B0
		private static bool n_IsAnnotationPresent_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			IAnnotatedElement @object = Object.GetObject<IAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return @object.IsAnnotationPresent(object2);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x0007C5D4 File Offset: 0x0007A7D4
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

		// Token: 0x040011C8 RID: 4552
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/AnnotatedElement", typeof(IAnnotatedElementInvoker));

		// Token: 0x040011C9 RID: 4553
		private IntPtr class_ref;

		// Token: 0x040011CA RID: 4554
		private static Delegate cb_getAnnotation_Ljava_lang_Class_;

		// Token: 0x040011CB RID: 4555
		private IntPtr id_getAnnotation_Ljava_lang_Class_;

		// Token: 0x040011CC RID: 4556
		private static Delegate cb_getAnnotations;

		// Token: 0x040011CD RID: 4557
		private IntPtr id_getAnnotations;

		// Token: 0x040011CE RID: 4558
		private static Delegate cb_getDeclaredAnnotations;

		// Token: 0x040011CF RID: 4559
		private IntPtr id_getDeclaredAnnotations;

		// Token: 0x040011D0 RID: 4560
		private static Delegate cb_isAnnotationPresent_Ljava_lang_Class_;

		// Token: 0x040011D1 RID: 4561
		private IntPtr id_isAnnotationPresent_Ljava_lang_Class_;
	}
}
