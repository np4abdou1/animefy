using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm
{
	// Token: 0x02000176 RID: 374
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmClassMappingKt", DoNotGenerateAcw = true)]
	public sealed class JvmClassMappingKt : Java.Lang.Object
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x0003E804 File Offset: 0x0003CA04
		internal static IntPtr class_ref
		{
			get
			{
				return JvmClassMappingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0003E828 File Offset: 0x0003CA28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JvmClassMappingKt._members;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0003E830 File Offset: 0x0003CA30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JvmClassMappingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0003E854 File Offset: 0x0003CA54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JvmClassMappingKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0003E860 File Offset: 0x0003CA60
		internal JvmClassMappingKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0003E86C File Offset: 0x0003CA6C
		[Register("getAnnotationClass", "(Ljava/lang/annotation/Annotation;)Lkotlin/reflect/KClass;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.annotation.Annotation"
		})]
		public unsafe static IKClass GetAnnotationClass(Java.Lang.Object obj)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(obj);
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKClass>(JvmClassMappingKt._members.StaticMethods.InvokeObjectMethod("getAnnotationClass.(Ljava/lang/annotation/Annotation;)Lkotlin/reflect/KClass;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0003E8DC File Offset: 0x0003CADC
		[Register("getJavaClass", "(Lkotlin/reflect/KClass;)Ljava/lang/Class;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Class GetJavaClass(IKClass obj)
		{
			Class @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<Class>(JvmClassMappingKt._members.StaticMethods.InvokeObjectMethod("getJavaClass.(Lkotlin/reflect/KClass;)Ljava/lang/Class;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0003E954 File Offset: 0x0003CB54
		[Register("getJavaClass", "(Ljava/lang/Object;)Ljava/lang/Class;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Class GetJavaClass(Java.Lang.Object obj)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(obj);
			Class @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Class>(JvmClassMappingKt._members.StaticMethods.InvokeObjectMethod("getJavaClass.(Ljava/lang/Object;)Ljava/lang/Class;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0003E9C4 File Offset: 0x0003CBC4
		[Register("getJavaObjectType", "(Lkotlin/reflect/KClass;)Ljava/lang/Class;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Class GetJavaObjectType(IKClass obj)
		{
			Class @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<Class>(JvmClassMappingKt._members.StaticMethods.InvokeObjectMethod("getJavaObjectType.(Lkotlin/reflect/KClass;)Ljava/lang/Class;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0003EA3C File Offset: 0x0003CC3C
		[Register("getJavaPrimitiveType", "(Lkotlin/reflect/KClass;)Ljava/lang/Class;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Class GetJavaPrimitiveType(IKClass obj)
		{
			Class @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<Class>(JvmClassMappingKt._members.StaticMethods.InvokeObjectMethod("getJavaPrimitiveType.(Lkotlin/reflect/KClass;)Ljava/lang/Class;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0003EAB4 File Offset: 0x0003CCB4
		[Register("getKotlinClass", "(Ljava/lang/Class;)Lkotlin/reflect/KClass;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IKClass GetKotlinClass(Class obj)
		{
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IKClass>(JvmClassMappingKt._members.StaticMethods.InvokeObjectMethod("getKotlinClass.(Ljava/lang/Class;)Lkotlin/reflect/KClass;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0003EB28 File Offset: 0x0003CD28
		[Obsolete("deprecated")]
		[Register("getRuntimeClassOfKClassInstance", "(Lkotlin/reflect/KClass;)Ljava/lang/Class;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Class GetRuntimeClassOfKClassInstance(IKClass obj)
		{
			Class @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<Class>(JvmClassMappingKt._members.StaticMethods.InvokeObjectMethod("getRuntimeClassOfKClassInstance.(Lkotlin/reflect/KClass;)Ljava/lang/Class;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0400066F RID: 1647
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmClassMappingKt", typeof(JvmClassMappingKt));
	}
}
