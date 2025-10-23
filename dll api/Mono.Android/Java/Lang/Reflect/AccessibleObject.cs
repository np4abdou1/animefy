using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Java.Lang.Reflect
{
	// Token: 0x020003FB RID: 1019
	[Register("java/lang/reflect/AccessibleObject", DoNotGenerateAcw = true)]
	public class AccessibleObject : Object, IAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x0007B62F File Offset: 0x0007982F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibleObject._members;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x0007B638 File Offset: 0x00079838
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibleObject._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x0007B65C File Offset: 0x0007985C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibleObject._members.ManagedPeerType;
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AccessibleObject(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0007B668 File Offset: 0x00079868
		private static Delegate GetGetAnnotation_Ljava_lang_Class_Handler()
		{
			if (AccessibleObject.cb_getAnnotation_Ljava_lang_Class_ == null)
			{
				AccessibleObject.cb_getAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AccessibleObject.n_GetAnnotation_Ljava_lang_Class_));
			}
			return AccessibleObject.cb_getAnnotation_Ljava_lang_Class_;
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0007B68C File Offset: 0x0007988C
		private static IntPtr n_GetAnnotation_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			AccessibleObject @object = Object.GetObject<AccessibleObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetAnnotation(object2));
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x0007B6B4 File Offset: 0x000798B4
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		public unsafe virtual Object GetAnnotation(Class annotationClass)
		{
			Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				@object = Object.GetObject<Object>(AccessibleObject._members.InstanceMethods.InvokeVirtualObjectMethod("getAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return @object;
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x0007B728 File Offset: 0x00079928
		private static Delegate GetGetAnnotationsHandler()
		{
			if (AccessibleObject.cb_getAnnotations == null)
			{
				AccessibleObject.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibleObject.n_GetAnnotations));
			}
			return AccessibleObject.cb_getAnnotations;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0007B74C File Offset: 0x0007994C
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<IAnnotation>(Object.GetObject<AccessibleObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAnnotations());
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x0007B760 File Offset: 0x00079960
		public virtual IAnnotation[] GetAnnotations()
		{
			return (IAnnotation[])JNIEnv.GetArray(AccessibleObject._members.InstanceMethods.InvokeVirtualObjectMethod("getAnnotations.()[Ljava/lang/annotation/Annotation;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x0007B7A1 File Offset: 0x000799A1
		private static Delegate GetGetAnnotationsByType_Ljava_lang_Class_Handler()
		{
			if (AccessibleObject.cb_getAnnotationsByType_Ljava_lang_Class_ == null)
			{
				AccessibleObject.cb_getAnnotationsByType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AccessibleObject.n_GetAnnotationsByType_Ljava_lang_Class_));
			}
			return AccessibleObject.cb_getAnnotationsByType_Ljava_lang_Class_;
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0007B7C8 File Offset: 0x000799C8
		private static IntPtr n_GetAnnotationsByType_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			AccessibleObject @object = Object.GetObject<AccessibleObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Object>(@object.GetAnnotationsByType(object2));
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0007B7F0 File Offset: 0x000799F0
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		public unsafe virtual Object[] GetAnnotationsByType(Class annotationClass)
		{
			Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				result = (Object[])JNIEnv.GetArray(AccessibleObject._members.InstanceMethods.InvokeVirtualObjectMethod("getAnnotationsByType.(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Object));
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return result;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0007B874 File Offset: 0x00079A74
		private static Delegate GetGetDeclaredAnnotation_Ljava_lang_Class_Handler()
		{
			if (AccessibleObject.cb_getDeclaredAnnotation_Ljava_lang_Class_ == null)
			{
				AccessibleObject.cb_getDeclaredAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AccessibleObject.n_GetDeclaredAnnotation_Ljava_lang_Class_));
			}
			return AccessibleObject.cb_getDeclaredAnnotation_Ljava_lang_Class_;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x0007B898 File Offset: 0x00079A98
		private static IntPtr n_GetDeclaredAnnotation_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			AccessibleObject @object = Object.GetObject<AccessibleObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDeclaredAnnotation(object2));
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x0007B8C0 File Offset: 0x00079AC0
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		public unsafe virtual Object GetDeclaredAnnotation(Class annotationClass)
		{
			Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				@object = Object.GetObject<Object>(AccessibleObject._members.InstanceMethods.InvokeVirtualObjectMethod("getDeclaredAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return @object;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x0007B934 File Offset: 0x00079B34
		private static Delegate GetGetDeclaredAnnotationsHandler()
		{
			if (AccessibleObject.cb_getDeclaredAnnotations == null)
			{
				AccessibleObject.cb_getDeclaredAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibleObject.n_GetDeclaredAnnotations));
			}
			return AccessibleObject.cb_getDeclaredAnnotations;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x0007B958 File Offset: 0x00079B58
		private static IntPtr n_GetDeclaredAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<IAnnotation>(Object.GetObject<AccessibleObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDeclaredAnnotations());
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0007B96C File Offset: 0x00079B6C
		public virtual IAnnotation[] GetDeclaredAnnotations()
		{
			return (IAnnotation[])JNIEnv.GetArray(AccessibleObject._members.InstanceMethods.InvokeVirtualObjectMethod("getDeclaredAnnotations.()[Ljava/lang/annotation/Annotation;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x0007B9AD File Offset: 0x00079BAD
		private static Delegate GetGetDeclaredAnnotationsByType_Ljava_lang_Class_Handler()
		{
			if (AccessibleObject.cb_getDeclaredAnnotationsByType_Ljava_lang_Class_ == null)
			{
				AccessibleObject.cb_getDeclaredAnnotationsByType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AccessibleObject.n_GetDeclaredAnnotationsByType_Ljava_lang_Class_));
			}
			return AccessibleObject.cb_getDeclaredAnnotationsByType_Ljava_lang_Class_;
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x0007B9D4 File Offset: 0x00079BD4
		private static IntPtr n_GetDeclaredAnnotationsByType_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			AccessibleObject @object = Object.GetObject<AccessibleObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Object>(@object.GetDeclaredAnnotationsByType(object2));
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0007B9FC File Offset: 0x00079BFC
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		public unsafe virtual Object[] GetDeclaredAnnotationsByType(Class annotationClass)
		{
			Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				result = (Object[])JNIEnv.GetArray(AccessibleObject._members.InstanceMethods.InvokeVirtualObjectMethod("getDeclaredAnnotationsByType.(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Object));
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return result;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x0007BA80 File Offset: 0x00079C80
		private static Delegate GetIsAnnotationPresent_Ljava_lang_Class_Handler()
		{
			if (AccessibleObject.cb_isAnnotationPresent_Ljava_lang_Class_ == null)
			{
				AccessibleObject.cb_isAnnotationPresent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AccessibleObject.n_IsAnnotationPresent_Ljava_lang_Class_));
			}
			return AccessibleObject.cb_isAnnotationPresent_Ljava_lang_Class_;
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x0007BAA4 File Offset: 0x00079CA4
		private static bool n_IsAnnotationPresent_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			AccessibleObject @object = Object.GetObject<AccessibleObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationClass, JniHandleOwnership.DoNotTransfer);
			return @object.IsAnnotationPresent(object2);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0007BAC8 File Offset: 0x00079CC8
		public unsafe virtual bool IsAnnotationPresent(Class annotationClass)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				result = AccessibleObject._members.InstanceMethods.InvokeVirtualBooleanMethod("isAnnotationPresent.(Ljava/lang/Class;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return result;
		}

		// Token: 0x040011B3 RID: 4531
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/AccessibleObject", typeof(AccessibleObject));

		// Token: 0x040011B4 RID: 4532
		private static Delegate cb_getAnnotation_Ljava_lang_Class_;

		// Token: 0x040011B5 RID: 4533
		private static Delegate cb_getAnnotations;

		// Token: 0x040011B6 RID: 4534
		private static Delegate cb_getAnnotationsByType_Ljava_lang_Class_;

		// Token: 0x040011B7 RID: 4535
		private static Delegate cb_getDeclaredAnnotation_Ljava_lang_Class_;

		// Token: 0x040011B8 RID: 4536
		private static Delegate cb_getDeclaredAnnotations;

		// Token: 0x040011B9 RID: 4537
		private static Delegate cb_getDeclaredAnnotationsByType_Ljava_lang_Class_;

		// Token: 0x040011BA RID: 4538
		private static Delegate cb_isAnnotationPresent_Ljava_lang_Class_;
	}
}
