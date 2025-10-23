using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001C9 RID: 457
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/Reflection", DoNotGenerateAcw = true)]
	public class Reflection : Java.Lang.Object
	{
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00048CD8 File Offset: 0x00046ED8
		internal static IntPtr class_ref
		{
			get
			{
				return Reflection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x00048CFC File Offset: 0x00046EFC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return Reflection._members;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00048D04 File Offset: 0x00046F04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Reflection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x00048D28 File Offset: 0x00046F28
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return Reflection._members.ManagedPeerType;
			}
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00048D34 File Offset: 0x00046F34
		protected Reflection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00048D40 File Offset: 0x00046F40
		[Register(".ctor", "()V", "")]
		public Reflection() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Reflection._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Reflection._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00048DB0 File Offset: 0x00046FB0
		[Register("createKotlinClass", "(Ljava/lang/Class;)Lkotlin/reflect/KClass;", "")]
		public unsafe static IKClass CreateKotlinClass(Class javaClass)
		{
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				@object = Java.Lang.Object.GetObject<IKClass>(Reflection._members.StaticMethods.InvokeObjectMethod("createKotlinClass.(Ljava/lang/Class;)Lkotlin/reflect/KClass;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00048E24 File Offset: 0x00047024
		[Register("createKotlinClass", "(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", "")]
		public unsafe static IKClass CreateKotlinClass(Class javaClass, string internalName)
		{
			IntPtr intPtr = JNIEnv.NewString(internalName);
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKClass>(Reflection._members.StaticMethods.InvokeObjectMethod("createKotlinClass.(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00048EB8 File Offset: 0x000470B8
		[Register("function", "(Lkotlin/jvm/internal/FunctionReference;)Lkotlin/reflect/KFunction;", "")]
		public unsafe static IKFunction Function(FunctionReference f)
		{
			IKFunction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
				@object = Java.Lang.Object.GetObject<IKFunction>(Reflection._members.StaticMethods.InvokeObjectMethod("function.(Lkotlin/jvm/internal/FunctionReference;)Lkotlin/reflect/KFunction;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(f);
			}
			return @object;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00048F2C File Offset: 0x0004712C
		[Register("getOrCreateKotlinClass", "(Ljava/lang/Class;)Lkotlin/reflect/KClass;", "")]
		public unsafe static IKClass GetOrCreateKotlinClass(Class javaClass)
		{
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				@object = Java.Lang.Object.GetObject<IKClass>(Reflection._members.StaticMethods.InvokeObjectMethod("getOrCreateKotlinClass.(Ljava/lang/Class;)Lkotlin/reflect/KClass;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00048FA0 File Offset: 0x000471A0
		[Register("getOrCreateKotlinClass", "(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", "")]
		public unsafe static IKClass GetOrCreateKotlinClass(Class javaClass, string internalName)
		{
			IntPtr intPtr = JNIEnv.NewString(internalName);
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKClass>(Reflection._members.StaticMethods.InvokeObjectMethod("getOrCreateKotlinClass.(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00049034 File Offset: 0x00047234
		[Register("getOrCreateKotlinClasses", "([Ljava/lang/Class;)[Lkotlin/reflect/KClass;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public unsafe static IKClass[] GetOrCreateKotlinClasses([Nullable(new byte[]
		{
			2,
			1
		})] Class[] javaClasses)
		{
			IntPtr intPtr = JNIEnv.NewArray<Class>(javaClasses);
			IKClass[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (IKClass[])JNIEnv.GetArray(Reflection._members.StaticMethods.InvokeObjectMethod("getOrCreateKotlinClasses.([Ljava/lang/Class;)[Lkotlin/reflect/KClass;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(IKClass));
			}
			finally
			{
				if (javaClasses != null)
				{
					JNIEnv.CopyArray<Class>(intPtr, javaClasses);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(javaClasses);
			}
			return result;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000490C0 File Offset: 0x000472C0
		[Register("getOrCreateKotlinPackage", "(Ljava/lang/Class;)Lkotlin/reflect/KDeclarationContainer;", "")]
		public unsafe static IKDeclarationContainer GetOrCreateKotlinPackage(Class javaClass)
		{
			IKDeclarationContainer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				@object = Java.Lang.Object.GetObject<IKDeclarationContainer>(Reflection._members.StaticMethods.InvokeObjectMethod("getOrCreateKotlinPackage.(Ljava/lang/Class;)Lkotlin/reflect/KDeclarationContainer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00049134 File Offset: 0x00047334
		[Register("getOrCreateKotlinPackage", "(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KDeclarationContainer;", "")]
		public unsafe static IKDeclarationContainer GetOrCreateKotlinPackage(Class javaClass, string moduleName)
		{
			IntPtr intPtr = JNIEnv.NewString(moduleName);
			IKDeclarationContainer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKDeclarationContainer>(Reflection._members.StaticMethods.InvokeObjectMethod("getOrCreateKotlinPackage.(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KDeclarationContainer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000491C8 File Offset: 0x000473C8
		[Register("mutableCollectionType", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType MutableCollectionType(IKType type)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("mutableCollectionType.(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00049240 File Offset: 0x00047440
		[Register("mutableProperty0", "(Lkotlin/jvm/internal/MutablePropertyReference0;)Lkotlin/reflect/KMutableProperty0;", "")]
		public unsafe static IKMutableProperty0 MutableProperty0(MutablePropertyReference0 p)
		{
			IKMutableProperty0 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKMutableProperty0>(Reflection._members.StaticMethods.InvokeObjectMethod("mutableProperty0.(Lkotlin/jvm/internal/MutablePropertyReference0;)Lkotlin/reflect/KMutableProperty0;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000492B4 File Offset: 0x000474B4
		[Register("mutableProperty1", "(Lkotlin/jvm/internal/MutablePropertyReference1;)Lkotlin/reflect/KMutableProperty1;", "")]
		public unsafe static IKMutableProperty1 MutableProperty1(MutablePropertyReference1 p)
		{
			IKMutableProperty1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKMutableProperty1>(Reflection._members.StaticMethods.InvokeObjectMethod("mutableProperty1.(Lkotlin/jvm/internal/MutablePropertyReference1;)Lkotlin/reflect/KMutableProperty1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00049328 File Offset: 0x00047528
		[Register("mutableProperty2", "(Lkotlin/jvm/internal/MutablePropertyReference2;)Lkotlin/reflect/KMutableProperty2;", "")]
		public unsafe static IKMutableProperty2 MutableProperty2(MutablePropertyReference2 p)
		{
			IKMutableProperty2 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKMutableProperty2>(Reflection._members.StaticMethods.InvokeObjectMethod("mutableProperty2.(Lkotlin/jvm/internal/MutablePropertyReference2;)Lkotlin/reflect/KMutableProperty2;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0004939C File Offset: 0x0004759C
		[Register("nothingType", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType NothingType(IKType type)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("nothingType.(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00049414 File Offset: 0x00047614
		[Register("nullableTypeOf", "(Ljava/lang/Class;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType NullableTypeOf(Class klass)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("nullableTypeOf.(Ljava/lang/Class;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(klass);
			}
			return @object;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00049488 File Offset: 0x00047688
		[Register("nullableTypeOf", "(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType NullableTypeOf(Class klass, KTypeProjection arg1)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				ptr[1] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("nullableTypeOf.(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(klass);
				GC.KeepAlive(arg1);
			}
			return @object;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00049524 File Offset: 0x00047724
		[Register("nullableTypeOf", "(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType NullableTypeOf(Class klass, KTypeProjection arg1, KTypeProjection arg2)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				ptr[1] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				ptr[2] = new JniArgumentValue((arg2 == null) ? IntPtr.Zero : arg2.Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("nullableTypeOf.(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(klass);
				GC.KeepAlive(arg1);
				GC.KeepAlive(arg2);
			}
			return @object;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000495EC File Offset: 0x000477EC
		[Register("nullableTypeOf", "(Ljava/lang/Class;[Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType NullableTypeOf(Class klass, [Nullable(new byte[]
		{
			2,
			1
		})] params KTypeProjection[] arguments)
		{
			IntPtr intPtr = JNIEnv.NewArray<KTypeProjection>(arguments);
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("nullableTypeOf.(Ljava/lang/Class;[Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (arguments != null)
				{
					JNIEnv.CopyArray<KTypeProjection>(intPtr, arguments);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(klass);
				GC.KeepAlive(arguments);
			}
			return @object;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00049690 File Offset: 0x00047890
		[Register("nullableTypeOf", "(Lkotlin/reflect/KClassifier;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType NullableTypeOf(IKClassifier classifier)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((classifier == null) ? IntPtr.Zero : ((Java.Lang.Object)classifier).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("nullableTypeOf.(Lkotlin/reflect/KClassifier;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(classifier);
			}
			return @object;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00049708 File Offset: 0x00047908
		[Register("platformType", "(Lkotlin/reflect/KType;Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType PlatformType(IKType lowerBound, IKType upperBound)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((lowerBound == null) ? IntPtr.Zero : ((Java.Lang.Object)lowerBound).Handle);
				ptr[1] = new JniArgumentValue((upperBound == null) ? IntPtr.Zero : ((Java.Lang.Object)upperBound).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("platformType.(Lkotlin/reflect/KType;Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(lowerBound);
				GC.KeepAlive(upperBound);
			}
			return @object;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000497AC File Offset: 0x000479AC
		[Register("property0", "(Lkotlin/jvm/internal/PropertyReference0;)Lkotlin/reflect/KProperty0;", "")]
		public unsafe static IKProperty0 Property0(PropertyReference0 p)
		{
			IKProperty0 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKProperty0>(Reflection._members.StaticMethods.InvokeObjectMethod("property0.(Lkotlin/jvm/internal/PropertyReference0;)Lkotlin/reflect/KProperty0;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00049820 File Offset: 0x00047A20
		[Register("property1", "(Lkotlin/jvm/internal/PropertyReference1;)Lkotlin/reflect/KProperty1;", "")]
		public unsafe static IKProperty1 Property1(PropertyReference1 p)
		{
			IKProperty1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKProperty1>(Reflection._members.StaticMethods.InvokeObjectMethod("property1.(Lkotlin/jvm/internal/PropertyReference1;)Lkotlin/reflect/KProperty1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00049894 File Offset: 0x00047A94
		[Register("property2", "(Lkotlin/jvm/internal/PropertyReference2;)Lkotlin/reflect/KProperty2;", "")]
		public unsafe static IKProperty2 Property2(PropertyReference2 p)
		{
			IKProperty2 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKProperty2>(Reflection._members.StaticMethods.InvokeObjectMethod("property2.(Lkotlin/jvm/internal/PropertyReference2;)Lkotlin/reflect/KProperty2;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00049908 File Offset: 0x00047B08
		[Register("renderLambdaToString", "(Lkotlin/jvm/internal/FunctionBase;)Ljava/lang/String;", "")]
		public unsafe static string RenderLambdaToString(IFunctionBase lambda)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((lambda == null) ? IntPtr.Zero : ((Java.Lang.Object)lambda).Handle);
				@string = JNIEnv.GetString(Reflection._members.StaticMethods.InvokeObjectMethod("renderLambdaToString.(Lkotlin/jvm/internal/FunctionBase;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(lambda);
			}
			return @string;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00049980 File Offset: 0x00047B80
		[Register("renderLambdaToString", "(Lkotlin/jvm/internal/Lambda;)Ljava/lang/String;", "")]
		public unsafe static string RenderLambdaToString(Lambda lambda)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((lambda == null) ? IntPtr.Zero : lambda.Handle);
				@string = JNIEnv.GetString(Reflection._members.StaticMethods.InvokeObjectMethod("renderLambdaToString.(Lkotlin/jvm/internal/Lambda;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(lambda);
			}
			return @string;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000499F4 File Offset: 0x00047BF4
		[Register("setUpperBounds", "(Lkotlin/reflect/KTypeParameter;Lkotlin/reflect/KType;)V", "")]
		public unsafe static void SetUpperBounds(IKTypeParameter typeParameter, IKType bound)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((typeParameter == null) ? IntPtr.Zero : ((Java.Lang.Object)typeParameter).Handle);
				ptr[1] = new JniArgumentValue((bound == null) ? IntPtr.Zero : ((Java.Lang.Object)bound).Handle);
				Reflection._members.StaticMethods.InvokeVoidMethod("setUpperBounds.(Lkotlin/reflect/KTypeParameter;Lkotlin/reflect/KType;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(typeParameter);
				GC.KeepAlive(bound);
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00049A88 File Offset: 0x00047C88
		[Register("setUpperBounds", "(Lkotlin/reflect/KTypeParameter;[Lkotlin/reflect/KType;)V", "")]
		public unsafe static void SetUpperBounds(IKTypeParameter typeParameter, [Nullable(new byte[]
		{
			2,
			1
		})] params IKType[] bounds)
		{
			IntPtr intPtr = JNIEnv.NewArray<IKType>(bounds);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((typeParameter == null) ? IntPtr.Zero : ((Java.Lang.Object)typeParameter).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Reflection._members.StaticMethods.InvokeVoidMethod("setUpperBounds.(Lkotlin/reflect/KTypeParameter;[Lkotlin/reflect/KType;)V", ptr);
			}
			finally
			{
				if (bounds != null)
				{
					JNIEnv.CopyArray<IKType>(intPtr, bounds);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(typeParameter);
				GC.KeepAlive(bounds);
			}
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00049B20 File Offset: 0x00047D20
		[Register("typeOf", "(Ljava/lang/Class;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType TypeOf(Class klass)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("typeOf.(Ljava/lang/Class;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(klass);
			}
			return @object;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00049B94 File Offset: 0x00047D94
		[Register("typeOf", "(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType TypeOf(Class klass, KTypeProjection arg1)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				ptr[1] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("typeOf.(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(klass);
				GC.KeepAlive(arg1);
			}
			return @object;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00049C30 File Offset: 0x00047E30
		[Register("typeOf", "(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType TypeOf(Class klass, KTypeProjection arg1, KTypeProjection arg2)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				ptr[1] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				ptr[2] = new JniArgumentValue((arg2 == null) ? IntPtr.Zero : arg2.Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("typeOf.(Ljava/lang/Class;Lkotlin/reflect/KTypeProjection;Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(klass);
				GC.KeepAlive(arg1);
				GC.KeepAlive(arg2);
			}
			return @object;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00049CF8 File Offset: 0x00047EF8
		[Register("typeOf", "(Ljava/lang/Class;[Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType TypeOf(Class klass, [Nullable(new byte[]
		{
			2,
			1
		})] params KTypeProjection[] arguments)
		{
			IntPtr intPtr = JNIEnv.NewArray<KTypeProjection>(arguments);
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : klass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("typeOf.(Ljava/lang/Class;[Lkotlin/reflect/KTypeProjection;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (arguments != null)
				{
					JNIEnv.CopyArray<KTypeProjection>(intPtr, arguments);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(klass);
				GC.KeepAlive(arguments);
			}
			return @object;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00049D9C File Offset: 0x00047F9C
		[Register("typeOf", "(Lkotlin/reflect/KClassifier;)Lkotlin/reflect/KType;", "")]
		public unsafe static IKType TypeOf(IKClassifier classifier)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((classifier == null) ? IntPtr.Zero : ((Java.Lang.Object)classifier).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(Reflection._members.StaticMethods.InvokeObjectMethod("typeOf.(Lkotlin/reflect/KClassifier;)Lkotlin/reflect/KType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(classifier);
			}
			return @object;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00049E14 File Offset: 0x00048014
		[Register("typeParameter", "(Ljava/lang/Object;Ljava/lang/String;Lkotlin/reflect/KVariance;Z)Lkotlin/reflect/KTypeParameter;", "")]
		public unsafe static IKTypeParameter TypeParameter(Java.Lang.Object container, string name, KVariance variance, bool isReified)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IKTypeParameter @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((variance == null) ? IntPtr.Zero : variance.Handle);
				ptr[3] = new JniArgumentValue(isReified);
				@object = Java.Lang.Object.GetObject<IKTypeParameter>(Reflection._members.StaticMethods.InvokeObjectMethod("typeParameter.(Ljava/lang/Object;Ljava/lang/String;Lkotlin/reflect/KVariance;Z)Lkotlin/reflect/KTypeParameter;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(container);
				GC.KeepAlive(variance);
			}
			return @object;
		}

		// Token: 0x04000727 RID: 1831
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Reflection", typeof(Reflection));
	}
}
