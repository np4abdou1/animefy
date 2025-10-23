using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang.Annotation;
using Java.Lang.Reflect;

namespace Java.Lang
{
	// Token: 0x020003C1 RID: 961
	[Register("java/lang/Class", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class Class : Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IGenericDeclaration, IAnnotatedElement, IType
	{
		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x00076C37 File Offset: 0x00074E37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Class._members;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x00076C40 File Offset: 0x00074E40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Class._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x00076C64 File Offset: 0x00074E64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Class._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Class(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x00076C70 File Offset: 0x00074E70
		public string TypeName
		{
			get
			{
				return JNIEnv.GetString(Class._members.InstanceMethods.InvokeAbstractObjectMethod("getTypeName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00076CA4 File Offset: 0x00074EA4
		[JavaTypeParameters(new string[]
		{
			"A extends java.lang.annotation.Annotation"
		})]
		public unsafe Object GetAnnotation(Class annotationClass)
		{
			Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				@object = Java.Lang.Object.GetObject<Object>(Class._members.InstanceMethods.InvokeAbstractObjectMethod("getAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return @object;
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00076D18 File Offset: 0x00074F18
		public IAnnotation[] GetAnnotations()
		{
			return (IAnnotation[])JNIEnv.GetArray(Class._members.InstanceMethods.InvokeAbstractObjectMethod("getAnnotations.()[Ljava/lang/annotation/Annotation;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x00076D5C File Offset: 0x00074F5C
		[JavaTypeParameters(new string[]
		{
			"A extends java.lang.annotation.Annotation"
		})]
		public unsafe Object[] GetAnnotationsByType(Class annotationClass)
		{
			Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				result = (Object[])JNIEnv.GetArray(Class._members.InstanceMethods.InvokeAbstractObjectMethod("getAnnotationsByType.(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Object));
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return result;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00076DE0 File Offset: 0x00074FE0
		[JavaTypeParameters(new string[]
		{
			"A extends java.lang.annotation.Annotation"
		})]
		public unsafe Object GetDeclaredAnnotation(Class annotationClass)
		{
			Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				@object = Java.Lang.Object.GetObject<Object>(Class._members.InstanceMethods.InvokeAbstractObjectMethod("getDeclaredAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return @object;
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00076E54 File Offset: 0x00075054
		public IAnnotation[] GetDeclaredAnnotations()
		{
			return (IAnnotation[])JNIEnv.GetArray(Class._members.InstanceMethods.InvokeAbstractObjectMethod("getDeclaredAnnotations.()[Ljava/lang/annotation/Annotation;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(IAnnotation));
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00076E98 File Offset: 0x00075098
		public ITypeVariable[] GetTypeParameters()
		{
			return (ITypeVariable[])JNIEnv.GetArray(Class._members.InstanceMethods.InvokeAbstractObjectMethod("getTypeParameters.()[Ljava/lang/reflect/TypeVariable;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ITypeVariable));
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00076EDC File Offset: 0x000750DC
		public unsafe bool IsAnnotationPresent(Class annotationClass)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationClass == null) ? IntPtr.Zero : annotationClass.Handle);
				result = Class._members.InstanceMethods.InvokeAbstractBooleanMethod("isAnnotationPresent.(Ljava/lang/Class;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(annotationClass);
			}
			return result;
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x00076C37 File Offset: 0x00074E37
		internal static JniPeerMembers Members
		{
			get
			{
				return Class._members;
			}
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00076FB0 File Offset: 0x000751B0
		public static Class FromType(Type type)
		{
			if (!typeof(IJavaObject).IsAssignableFrom(type))
			{
				throw new ArgumentException("type", "Type is not derived from a java type.");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.FindClass(type), JniHandleOwnership.TransferGlobalRef);
		}

		// Token: 0x0400112F RID: 4399
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Class", typeof(Class));

		// Token: 0x04001130 RID: 4400
		public static readonly IntPtr Object = JNIEnv.FindClass("java/lang/Object");

		// Token: 0x04001131 RID: 4401
		public static readonly IntPtr String = JNIEnv.FindClass("java/lang/String");

		// Token: 0x04001132 RID: 4402
		public static readonly IntPtr CharSequence = JNIEnv.FindClass("java/lang/CharSequence");

		// Token: 0x04001133 RID: 4403
		internal static readonly IntPtr CharSequence_toString = JNIEnv.GetMethodID(Class.CharSequence, "toString", "()Ljava/lang/String;");
	}
}
