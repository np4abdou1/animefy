using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Java.Lang.Reflect
{
	// Token: 0x020003FF RID: 1023
	[Register("java/lang/reflect/AnnotatedElement", "", "Java.Lang.Reflect.IAnnotatedElementInvoker")]
	public interface IAnnotatedElement : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002D0E RID: 11534
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		Object GetAnnotation(Class annotationClass);

		// Token: 0x06002D0F RID: 11535
		IAnnotation[] GetAnnotations();

		// Token: 0x06002D10 RID: 11536
		IAnnotation[] GetDeclaredAnnotations();

		// Token: 0x06002D11 RID: 11537
		bool IsAnnotationPresent(Class annotationClass);

		// Token: 0x06002D12 RID: 11538 RVA: 0x0007C043 File Offset: 0x0007A243
		private static Delegate GetGetAnnotationsByType_Ljava_lang_Class_Handler()
		{
			if (IAnnotatedElement.cb_getAnnotationsByType_Ljava_lang_Class_ == null)
			{
				IAnnotatedElement.cb_getAnnotationsByType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAnnotatedElement.n_GetAnnotationsByType_Ljava_lang_Class_));
			}
			return IAnnotatedElement.cb_getAnnotationsByType_Ljava_lang_Class_;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x0007C068 File Offset: 0x0007A268
		private static IntPtr n_GetAnnotationsByType_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			IAnnotatedElement @object = Object.GetObject<IAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Object>(@object.GetAnnotationsByType(object2));
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x0007C090 File Offset: 0x0007A290
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		unsafe Object[] GetAnnotationsByType(Class annotationClass)
		{
			Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				result = (Object[])JNIEnv.GetArray(IAnnotatedElement._members.InstanceMethods.InvokeVirtualObjectMethod("getAnnotationsByType.(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Object));
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return result;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x0007C114 File Offset: 0x0007A314
		private static Delegate GetGetDeclaredAnnotation_Ljava_lang_Class_Handler()
		{
			if (IAnnotatedElement.cb_getDeclaredAnnotation_Ljava_lang_Class_ == null)
			{
				IAnnotatedElement.cb_getDeclaredAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAnnotatedElement.n_GetDeclaredAnnotation_Ljava_lang_Class_));
			}
			return IAnnotatedElement.cb_getDeclaredAnnotation_Ljava_lang_Class_;
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x0007C138 File Offset: 0x0007A338
		private static IntPtr n_GetDeclaredAnnotation_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			IAnnotatedElement @object = Object.GetObject<IAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDeclaredAnnotation(object2));
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0007C160 File Offset: 0x0007A360
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		unsafe Object GetDeclaredAnnotation(Class annotationClass)
		{
			Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				@object = Object.GetObject<Object>(IAnnotatedElement._members.InstanceMethods.InvokeVirtualObjectMethod("getDeclaredAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return @object;
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x0007C1D4 File Offset: 0x0007A3D4
		private static Delegate GetGetDeclaredAnnotationsByType_Ljava_lang_Class_Handler()
		{
			if (IAnnotatedElement.cb_getDeclaredAnnotationsByType_Ljava_lang_Class_ == null)
			{
				IAnnotatedElement.cb_getDeclaredAnnotationsByType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAnnotatedElement.n_GetDeclaredAnnotationsByType_Ljava_lang_Class_));
			}
			return IAnnotatedElement.cb_getDeclaredAnnotationsByType_Ljava_lang_Class_;
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x0007C1F8 File Offset: 0x0007A3F8
		private static IntPtr n_GetDeclaredAnnotationsByType_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			IAnnotatedElement @object = Object.GetObject<IAnnotatedElement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Object>(@object.GetDeclaredAnnotationsByType(object2));
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x0007C220 File Offset: 0x0007A420
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		unsafe Object[] GetDeclaredAnnotationsByType(Class annotationClass)
		{
			Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				result = (Object[])JNIEnv.GetArray(IAnnotatedElement._members.InstanceMethods.InvokeVirtualObjectMethod("getDeclaredAnnotationsByType.(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Object));
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return result;
		}

		// Token: 0x040011C4 RID: 4548
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/AnnotatedElement", typeof(IAnnotatedElement), true);

		// Token: 0x040011C5 RID: 4549
		private static Delegate cb_getAnnotationsByType_Ljava_lang_Class_;

		// Token: 0x040011C6 RID: 4550
		private static Delegate cb_getDeclaredAnnotation_Ljava_lang_Class_;

		// Token: 0x040011C7 RID: 4551
		private static Delegate cb_getDeclaredAnnotationsByType_Ljava_lang_Class_;
	}
}
