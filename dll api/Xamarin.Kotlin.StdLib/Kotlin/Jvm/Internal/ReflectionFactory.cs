using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001CA RID: 458
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/ReflectionFactory", DoNotGenerateAcw = true)]
	public class ReflectionFactory : Java.Lang.Object
	{
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00049F04 File Offset: 0x00048104
		internal static IntPtr class_ref
		{
			get
			{
				return ReflectionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00049F28 File Offset: 0x00048128
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ReflectionFactory._members;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00049F30 File Offset: 0x00048130
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ReflectionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00049F54 File Offset: 0x00048154
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ReflectionFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00049F60 File Offset: 0x00048160
		protected ReflectionFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00049F6C File Offset: 0x0004816C
		[Register(".ctor", "()V", "")]
		public ReflectionFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ReflectionFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ReflectionFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00049FDA File Offset: 0x000481DA
		[NullableContext(1)]
		private static Delegate GetCreateKotlinClass_Ljava_lang_Class_Handler()
		{
			if (ReflectionFactory.cb_createKotlinClass_Ljava_lang_Class_ == null)
			{
				ReflectionFactory.cb_createKotlinClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_CreateKotlinClass_Ljava_lang_Class_));
			}
			return ReflectionFactory.cb_createKotlinClass_Ljava_lang_Class_;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0004A000 File Offset: 0x00048200
		private static IntPtr n_CreateKotlinClass_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_javaClass)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_javaClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateKotlinClass(object2));
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0004A028 File Offset: 0x00048228
		[Register("createKotlinClass", "(Ljava/lang/Class;)Lkotlin/reflect/KClass;", "GetCreateKotlinClass_Ljava_lang_Class_Handler")]
		public unsafe virtual IKClass CreateKotlinClass(Class javaClass)
		{
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				@object = Java.Lang.Object.GetObject<IKClass>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("createKotlinClass.(Ljava/lang/Class;)Lkotlin/reflect/KClass;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0004A09C File Offset: 0x0004829C
		[NullableContext(1)]
		private static Delegate GetCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_Handler()
		{
			if (ReflectionFactory.cb_createKotlinClass_Ljava_lang_Class_Ljava_lang_String_ == null)
			{
				ReflectionFactory.cb_createKotlinClass_Ljava_lang_Class_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ReflectionFactory.n_CreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_));
			}
			return ReflectionFactory.cb_createKotlinClass_Ljava_lang_Class_Ljava_lang_String_;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0004A0C0 File Offset: 0x000482C0
		private static IntPtr n_CreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_javaClass, IntPtr native_internalName)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_javaClass, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_internalName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateKotlinClass(object2, @string));
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0004A0F4 File Offset: 0x000482F4
		[Register("createKotlinClass", "(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", "GetCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_Handler")]
		public unsafe virtual IKClass CreateKotlinClass(Class javaClass, string internalName)
		{
			IntPtr intPtr = JNIEnv.NewString(internalName);
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKClass>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("createKotlinClass.(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0004A188 File Offset: 0x00048388
		[NullableContext(1)]
		private static Delegate GetFunction_Lkotlin_jvm_internal_FunctionReference_Handler()
		{
			if (ReflectionFactory.cb_function_Lkotlin_jvm_internal_FunctionReference_ == null)
			{
				ReflectionFactory.cb_function_Lkotlin_jvm_internal_FunctionReference_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_Function_Lkotlin_jvm_internal_FunctionReference_));
			}
			return ReflectionFactory.cb_function_Lkotlin_jvm_internal_FunctionReference_;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0004A1AC File Offset: 0x000483AC
		private static IntPtr n_Function_Lkotlin_jvm_internal_FunctionReference_(IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FunctionReference object2 = Java.Lang.Object.GetObject<FunctionReference>(native_f, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Function(object2));
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0004A1D4 File Offset: 0x000483D4
		[Register("function", "(Lkotlin/jvm/internal/FunctionReference;)Lkotlin/reflect/KFunction;", "GetFunction_Lkotlin_jvm_internal_FunctionReference_Handler")]
		public unsafe virtual IKFunction Function(FunctionReference f)
		{
			IKFunction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((f == null) ? IntPtr.Zero : f.Handle);
				@object = Java.Lang.Object.GetObject<IKFunction>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("function.(Lkotlin/jvm/internal/FunctionReference;)Lkotlin/reflect/KFunction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(f);
			}
			return @object;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0004A248 File Offset: 0x00048448
		[NullableContext(1)]
		private static Delegate GetGetOrCreateKotlinClass_Ljava_lang_Class_Handler()
		{
			if (ReflectionFactory.cb_getOrCreateKotlinClass_Ljava_lang_Class_ == null)
			{
				ReflectionFactory.cb_getOrCreateKotlinClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_GetOrCreateKotlinClass_Ljava_lang_Class_));
			}
			return ReflectionFactory.cb_getOrCreateKotlinClass_Ljava_lang_Class_;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0004A26C File Offset: 0x0004846C
		private static IntPtr n_GetOrCreateKotlinClass_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_javaClass)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_javaClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOrCreateKotlinClass(object2));
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0004A294 File Offset: 0x00048494
		[Register("getOrCreateKotlinClass", "(Ljava/lang/Class;)Lkotlin/reflect/KClass;", "GetGetOrCreateKotlinClass_Ljava_lang_Class_Handler")]
		public unsafe virtual IKClass GetOrCreateKotlinClass(Class javaClass)
		{
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				@object = Java.Lang.Object.GetObject<IKClass>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getOrCreateKotlinClass.(Ljava/lang/Class;)Lkotlin/reflect/KClass;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0004A308 File Offset: 0x00048508
		[NullableContext(1)]
		private static Delegate GetGetOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_Handler()
		{
			if (ReflectionFactory.cb_getOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_ == null)
			{
				ReflectionFactory.cb_getOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ReflectionFactory.n_GetOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_));
			}
			return ReflectionFactory.cb_getOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0004A32C File Offset: 0x0004852C
		private static IntPtr n_GetOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_javaClass, IntPtr native_internalName)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_javaClass, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_internalName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOrCreateKotlinClass(object2, @string));
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0004A360 File Offset: 0x00048560
		[Register("getOrCreateKotlinClass", "(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", "GetGetOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_Handler")]
		public unsafe virtual IKClass GetOrCreateKotlinClass(Class javaClass, string internalName)
		{
			IntPtr intPtr = JNIEnv.NewString(internalName);
			IKClass @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKClass>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getOrCreateKotlinClass.(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KClass;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0004A3F4 File Offset: 0x000485F4
		[NullableContext(1)]
		private static Delegate GetGetOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_Handler()
		{
			if (ReflectionFactory.cb_getOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_ == null)
			{
				ReflectionFactory.cb_getOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ReflectionFactory.n_GetOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_));
			}
			return ReflectionFactory.cb_getOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0004A418 File Offset: 0x00048618
		private static IntPtr n_GetOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_javaClass, IntPtr native_moduleName)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_javaClass, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_moduleName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOrCreateKotlinPackage(object2, @string));
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0004A44C File Offset: 0x0004864C
		[Register("getOrCreateKotlinPackage", "(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KDeclarationContainer;", "GetGetOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_Handler")]
		public unsafe virtual IKDeclarationContainer GetOrCreateKotlinPackage(Class javaClass, string moduleName)
		{
			IntPtr intPtr = JNIEnv.NewString(moduleName);
			IKDeclarationContainer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((javaClass == null) ? IntPtr.Zero : javaClass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IKDeclarationContainer>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getOrCreateKotlinPackage.(Ljava/lang/Class;Ljava/lang/String;)Lkotlin/reflect/KDeclarationContainer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(javaClass);
			}
			return @object;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0004A4E0 File Offset: 0x000486E0
		[NullableContext(1)]
		private static Delegate GetMutableCollectionType_Lkotlin_reflect_KType_Handler()
		{
			if (ReflectionFactory.cb_mutableCollectionType_Lkotlin_reflect_KType_ == null)
			{
				ReflectionFactory.cb_mutableCollectionType_Lkotlin_reflect_KType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_MutableCollectionType_Lkotlin_reflect_KType_));
			}
			return ReflectionFactory.cb_mutableCollectionType_Lkotlin_reflect_KType_;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0004A504 File Offset: 0x00048704
		private static IntPtr n_MutableCollectionType_Lkotlin_reflect_KType_(IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKType object2 = Java.Lang.Object.GetObject<IKType>(native_type, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MutableCollectionType(object2));
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0004A52C File Offset: 0x0004872C
		[Register("mutableCollectionType", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", "GetMutableCollectionType_Lkotlin_reflect_KType_Handler")]
		public unsafe virtual IKType MutableCollectionType(IKType type)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("mutableCollectionType.(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0004A5A4 File Offset: 0x000487A4
		[NullableContext(1)]
		private static Delegate GetMutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_Handler()
		{
			if (ReflectionFactory.cb_mutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_ == null)
			{
				ReflectionFactory.cb_mutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_MutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_));
			}
			return ReflectionFactory.cb_mutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0004A5C8 File Offset: 0x000487C8
		private static IntPtr n_MutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_(IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MutablePropertyReference0 object2 = Java.Lang.Object.GetObject<MutablePropertyReference0>(native_p, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MutableProperty0(object2));
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0004A5F0 File Offset: 0x000487F0
		[Register("mutableProperty0", "(Lkotlin/jvm/internal/MutablePropertyReference0;)Lkotlin/reflect/KMutableProperty0;", "GetMutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_Handler")]
		public unsafe virtual IKMutableProperty0 MutableProperty0(MutablePropertyReference0 p)
		{
			IKMutableProperty0 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKMutableProperty0>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("mutableProperty0.(Lkotlin/jvm/internal/MutablePropertyReference0;)Lkotlin/reflect/KMutableProperty0;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0004A664 File Offset: 0x00048864
		[NullableContext(1)]
		private static Delegate GetMutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_Handler()
		{
			if (ReflectionFactory.cb_mutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_ == null)
			{
				ReflectionFactory.cb_mutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_MutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_));
			}
			return ReflectionFactory.cb_mutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0004A688 File Offset: 0x00048888
		private static IntPtr n_MutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_(IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MutablePropertyReference1 object2 = Java.Lang.Object.GetObject<MutablePropertyReference1>(native_p, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MutableProperty1(object2));
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0004A6B0 File Offset: 0x000488B0
		[Register("mutableProperty1", "(Lkotlin/jvm/internal/MutablePropertyReference1;)Lkotlin/reflect/KMutableProperty1;", "GetMutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_Handler")]
		public unsafe virtual IKMutableProperty1 MutableProperty1(MutablePropertyReference1 p)
		{
			IKMutableProperty1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKMutableProperty1>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("mutableProperty1.(Lkotlin/jvm/internal/MutablePropertyReference1;)Lkotlin/reflect/KMutableProperty1;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0004A724 File Offset: 0x00048924
		[NullableContext(1)]
		private static Delegate GetMutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_Handler()
		{
			if (ReflectionFactory.cb_mutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_ == null)
			{
				ReflectionFactory.cb_mutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_MutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_));
			}
			return ReflectionFactory.cb_mutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0004A748 File Offset: 0x00048948
		private static IntPtr n_MutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_(IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MutablePropertyReference2 object2 = Java.Lang.Object.GetObject<MutablePropertyReference2>(native_p, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MutableProperty2(object2));
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0004A770 File Offset: 0x00048970
		[Register("mutableProperty2", "(Lkotlin/jvm/internal/MutablePropertyReference2;)Lkotlin/reflect/KMutableProperty2;", "GetMutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_Handler")]
		public unsafe virtual IKMutableProperty2 MutableProperty2(MutablePropertyReference2 p)
		{
			IKMutableProperty2 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKMutableProperty2>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("mutableProperty2.(Lkotlin/jvm/internal/MutablePropertyReference2;)Lkotlin/reflect/KMutableProperty2;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0004A7E4 File Offset: 0x000489E4
		[NullableContext(1)]
		private static Delegate GetNothingType_Lkotlin_reflect_KType_Handler()
		{
			if (ReflectionFactory.cb_nothingType_Lkotlin_reflect_KType_ == null)
			{
				ReflectionFactory.cb_nothingType_Lkotlin_reflect_KType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_NothingType_Lkotlin_reflect_KType_));
			}
			return ReflectionFactory.cb_nothingType_Lkotlin_reflect_KType_;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0004A808 File Offset: 0x00048A08
		private static IntPtr n_NothingType_Lkotlin_reflect_KType_(IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKType object2 = Java.Lang.Object.GetObject<IKType>(native_type, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.NothingType(object2));
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0004A830 File Offset: 0x00048A30
		[Register("nothingType", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", "GetNothingType_Lkotlin_reflect_KType_Handler")]
		public unsafe virtual IKType NothingType(IKType type)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("nothingType.(Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0004A8A8 File Offset: 0x00048AA8
		[NullableContext(1)]
		private static Delegate GetPlatformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_Handler()
		{
			if (ReflectionFactory.cb_platformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_ == null)
			{
				ReflectionFactory.cb_platformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ReflectionFactory.n_PlatformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_));
			}
			return ReflectionFactory.cb_platformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0004A8CC File Offset: 0x00048ACC
		private static IntPtr n_PlatformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_(IntPtr jnienv, IntPtr native__this, IntPtr native_lowerBound, IntPtr native_upperBound)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKType object2 = Java.Lang.Object.GetObject<IKType>(native_lowerBound, JniHandleOwnership.DoNotTransfer);
			IKType object3 = Java.Lang.Object.GetObject<IKType>(native_upperBound, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PlatformType(object2, object3));
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0004A900 File Offset: 0x00048B00
		[Register("platformType", "(Lkotlin/reflect/KType;Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", "GetPlatformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_Handler")]
		public unsafe virtual IKType PlatformType(IKType lowerBound, IKType upperBound)
		{
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((lowerBound == null) ? IntPtr.Zero : ((Java.Lang.Object)lowerBound).Handle);
				ptr[1] = new JniArgumentValue((upperBound == null) ? IntPtr.Zero : ((Java.Lang.Object)upperBound).Handle);
				@object = Java.Lang.Object.GetObject<IKType>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("platformType.(Lkotlin/reflect/KType;Lkotlin/reflect/KType;)Lkotlin/reflect/KType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(lowerBound);
				GC.KeepAlive(upperBound);
			}
			return @object;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0004A9A8 File Offset: 0x00048BA8
		[NullableContext(1)]
		private static Delegate GetProperty0_Lkotlin_jvm_internal_PropertyReference0_Handler()
		{
			if (ReflectionFactory.cb_property0_Lkotlin_jvm_internal_PropertyReference0_ == null)
			{
				ReflectionFactory.cb_property0_Lkotlin_jvm_internal_PropertyReference0_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_Property0_Lkotlin_jvm_internal_PropertyReference0_));
			}
			return ReflectionFactory.cb_property0_Lkotlin_jvm_internal_PropertyReference0_;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0004A9CC File Offset: 0x00048BCC
		private static IntPtr n_Property0_Lkotlin_jvm_internal_PropertyReference0_(IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PropertyReference0 object2 = Java.Lang.Object.GetObject<PropertyReference0>(native_p, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Property0(object2));
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0004A9F4 File Offset: 0x00048BF4
		[Register("property0", "(Lkotlin/jvm/internal/PropertyReference0;)Lkotlin/reflect/KProperty0;", "GetProperty0_Lkotlin_jvm_internal_PropertyReference0_Handler")]
		public unsafe virtual IKProperty0 Property0(PropertyReference0 p)
		{
			IKProperty0 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKProperty0>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("property0.(Lkotlin/jvm/internal/PropertyReference0;)Lkotlin/reflect/KProperty0;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0004AA68 File Offset: 0x00048C68
		[NullableContext(1)]
		private static Delegate GetProperty1_Lkotlin_jvm_internal_PropertyReference1_Handler()
		{
			if (ReflectionFactory.cb_property1_Lkotlin_jvm_internal_PropertyReference1_ == null)
			{
				ReflectionFactory.cb_property1_Lkotlin_jvm_internal_PropertyReference1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_Property1_Lkotlin_jvm_internal_PropertyReference1_));
			}
			return ReflectionFactory.cb_property1_Lkotlin_jvm_internal_PropertyReference1_;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0004AA8C File Offset: 0x00048C8C
		private static IntPtr n_Property1_Lkotlin_jvm_internal_PropertyReference1_(IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PropertyReference1 object2 = Java.Lang.Object.GetObject<PropertyReference1>(native_p, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Property1(object2));
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0004AAB4 File Offset: 0x00048CB4
		[Register("property1", "(Lkotlin/jvm/internal/PropertyReference1;)Lkotlin/reflect/KProperty1;", "GetProperty1_Lkotlin_jvm_internal_PropertyReference1_Handler")]
		public unsafe virtual IKProperty1 Property1(PropertyReference1 p)
		{
			IKProperty1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKProperty1>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("property1.(Lkotlin/jvm/internal/PropertyReference1;)Lkotlin/reflect/KProperty1;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0004AB28 File Offset: 0x00048D28
		[NullableContext(1)]
		private static Delegate GetProperty2_Lkotlin_jvm_internal_PropertyReference2_Handler()
		{
			if (ReflectionFactory.cb_property2_Lkotlin_jvm_internal_PropertyReference2_ == null)
			{
				ReflectionFactory.cb_property2_Lkotlin_jvm_internal_PropertyReference2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_Property2_Lkotlin_jvm_internal_PropertyReference2_));
			}
			return ReflectionFactory.cb_property2_Lkotlin_jvm_internal_PropertyReference2_;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0004AB4C File Offset: 0x00048D4C
		private static IntPtr n_Property2_Lkotlin_jvm_internal_PropertyReference2_(IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PropertyReference2 object2 = Java.Lang.Object.GetObject<PropertyReference2>(native_p, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Property2(object2));
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0004AB74 File Offset: 0x00048D74
		[Register("property2", "(Lkotlin/jvm/internal/PropertyReference2;)Lkotlin/reflect/KProperty2;", "GetProperty2_Lkotlin_jvm_internal_PropertyReference2_Handler")]
		public unsafe virtual IKProperty2 Property2(PropertyReference2 p)
		{
			IKProperty2 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				@object = Java.Lang.Object.GetObject<IKProperty2>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("property2.(Lkotlin/jvm/internal/PropertyReference2;)Lkotlin/reflect/KProperty2;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p);
			}
			return @object;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0004ABE8 File Offset: 0x00048DE8
		[NullableContext(1)]
		private static Delegate GetRenderLambdaToString_Lkotlin_jvm_internal_FunctionBase_Handler()
		{
			if (ReflectionFactory.cb_renderLambdaToString_Lkotlin_jvm_internal_FunctionBase_ == null)
			{
				ReflectionFactory.cb_renderLambdaToString_Lkotlin_jvm_internal_FunctionBase_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_RenderLambdaToString_Lkotlin_jvm_internal_FunctionBase_));
			}
			return ReflectionFactory.cb_renderLambdaToString_Lkotlin_jvm_internal_FunctionBase_;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0004AC0C File Offset: 0x00048E0C
		private static IntPtr n_RenderLambdaToString_Lkotlin_jvm_internal_FunctionBase_(IntPtr jnienv, IntPtr native__this, IntPtr native_lambda)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunctionBase object2 = Java.Lang.Object.GetObject<IFunctionBase>(native_lambda, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.RenderLambdaToString(object2));
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0004AC34 File Offset: 0x00048E34
		[Register("renderLambdaToString", "(Lkotlin/jvm/internal/FunctionBase;)Ljava/lang/String;", "GetRenderLambdaToString_Lkotlin_jvm_internal_FunctionBase_Handler")]
		public unsafe virtual string RenderLambdaToString(IFunctionBase lambda)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((lambda == null) ? IntPtr.Zero : ((Java.Lang.Object)lambda).Handle);
				@string = JNIEnv.GetString(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("renderLambdaToString.(Lkotlin/jvm/internal/FunctionBase;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(lambda);
			}
			return @string;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0004ACAC File Offset: 0x00048EAC
		[NullableContext(1)]
		private static Delegate GetRenderLambdaToString_Lkotlin_jvm_internal_Lambda_Handler()
		{
			if (ReflectionFactory.cb_renderLambdaToString_Lkotlin_jvm_internal_Lambda_ == null)
			{
				ReflectionFactory.cb_renderLambdaToString_Lkotlin_jvm_internal_Lambda_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ReflectionFactory.n_RenderLambdaToString_Lkotlin_jvm_internal_Lambda_));
			}
			return ReflectionFactory.cb_renderLambdaToString_Lkotlin_jvm_internal_Lambda_;
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0004ACD0 File Offset: 0x00048ED0
		private static IntPtr n_RenderLambdaToString_Lkotlin_jvm_internal_Lambda_(IntPtr jnienv, IntPtr native__this, IntPtr native_lambda)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Lambda object2 = Java.Lang.Object.GetObject<Lambda>(native_lambda, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.RenderLambdaToString(object2));
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0004ACF8 File Offset: 0x00048EF8
		[Register("renderLambdaToString", "(Lkotlin/jvm/internal/Lambda;)Ljava/lang/String;", "GetRenderLambdaToString_Lkotlin_jvm_internal_Lambda_Handler")]
		public unsafe virtual string RenderLambdaToString(Lambda lambda)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((lambda == null) ? IntPtr.Zero : lambda.Handle);
				@string = JNIEnv.GetString(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("renderLambdaToString.(Lkotlin/jvm/internal/Lambda;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(lambda);
			}
			return @string;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0004AD6C File Offset: 0x00048F6C
		[NullableContext(1)]
		private static Delegate GetSetUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_Handler()
		{
			if (ReflectionFactory.cb_setUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_ == null)
			{
				ReflectionFactory.cb_setUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ReflectionFactory.n_SetUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_));
			}
			return ReflectionFactory.cb_setUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0004AD90 File Offset: 0x00048F90
		private static void n_SetUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_typeParameter, IntPtr native_bounds)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKTypeParameter object2 = Java.Lang.Object.GetObject<IKTypeParameter>(native_typeParameter, JniHandleOwnership.DoNotTransfer);
			IList<IKType> bounds = JavaList<IKType>.FromJniHandle(native_bounds, JniHandleOwnership.DoNotTransfer);
			@object.SetUpperBounds(object2, bounds);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0004ADBC File Offset: 0x00048FBC
		[Register("setUpperBounds", "(Lkotlin/reflect/KTypeParameter;Ljava/util/List;)V", "GetSetUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_Handler")]
		public unsafe virtual void SetUpperBounds(IKTypeParameter typeParameter, [Nullable(new byte[]
		{
			2,
			1
		})] IList<IKType> bounds)
		{
			IntPtr intPtr = JavaList<IKType>.ToLocalJniHandle(bounds);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((typeParameter == null) ? IntPtr.Zero : ((Java.Lang.Object)typeParameter).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ReflectionFactory._members.InstanceMethods.InvokeVirtualVoidMethod("setUpperBounds.(Lkotlin/reflect/KTypeParameter;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(typeParameter);
				GC.KeepAlive(bounds);
			}
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0004AE4C File Offset: 0x0004904C
		[NullableContext(1)]
		private static Delegate GetTypeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_ZHandler()
		{
			if (ReflectionFactory.cb_typeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_Z == null)
			{
				ReflectionFactory.cb_typeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_L(ReflectionFactory.n_TypeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_Z));
			}
			return ReflectionFactory.cb_typeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_Z;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0004AE70 File Offset: 0x00049070
		private static IntPtr n_TypeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_klass, IntPtr native_arguments, bool isMarkedNullable)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKClassifier object2 = Java.Lang.Object.GetObject<IKClassifier>(native_klass, JniHandleOwnership.DoNotTransfer);
			IList<KTypeProjection> arguments = JavaList<KTypeProjection>.FromJniHandle(native_arguments, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TypeOf(object2, arguments, isMarkedNullable));
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0004AEA4 File Offset: 0x000490A4
		[Register("typeOf", "(Lkotlin/reflect/KClassifier;Ljava/util/List;Z)Lkotlin/reflect/KType;", "GetTypeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_ZHandler")]
		public unsafe virtual IKType TypeOf(IKClassifier klass, [Nullable(new byte[]
		{
			2,
			1
		})] IList<KTypeProjection> arguments, bool isMarkedNullable)
		{
			IntPtr intPtr = JavaList<KTypeProjection>.ToLocalJniHandle(arguments);
			IKType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((klass == null) ? IntPtr.Zero : ((Java.Lang.Object)klass).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(isMarkedNullable);
				@object = Java.Lang.Object.GetObject<IKType>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("typeOf.(Lkotlin/reflect/KClassifier;Ljava/util/List;Z)Lkotlin/reflect/KType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(klass);
				GC.KeepAlive(arguments);
			}
			return @object;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0004AF58 File Offset: 0x00049158
		[NullableContext(1)]
		private static Delegate GetTypeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_ZHandler()
		{
			if (ReflectionFactory.cb_typeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_Z == null)
			{
				ReflectionFactory.cb_typeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLZ_L(ReflectionFactory.n_TypeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_Z));
			}
			return ReflectionFactory.cb_typeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_Z;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0004AF7C File Offset: 0x0004917C
		private static IntPtr n_TypeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_container, IntPtr native_name, IntPtr native_variance, bool isReified)
		{
			ReflectionFactory @object = Java.Lang.Object.GetObject<ReflectionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_container, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			KVariance object3 = Java.Lang.Object.GetObject<KVariance>(native_variance, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TypeParameter(object2, @string, object3, isReified));
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0004AFBC File Offset: 0x000491BC
		[Register("typeParameter", "(Ljava/lang/Object;Ljava/lang/String;Lkotlin/reflect/KVariance;Z)Lkotlin/reflect/KTypeParameter;", "GetTypeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_ZHandler")]
		public unsafe virtual IKTypeParameter TypeParameter(Java.Lang.Object container, string name, KVariance variance, bool isReified)
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
				@object = Java.Lang.Object.GetObject<IKTypeParameter>(ReflectionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("typeParameter.(Ljava/lang/Object;Ljava/lang/String;Lkotlin/reflect/KVariance;Z)Lkotlin/reflect/KTypeParameter;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(container);
				GC.KeepAlive(variance);
			}
			return @object;
		}

		// Token: 0x04000728 RID: 1832
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ReflectionFactory", typeof(ReflectionFactory));

		// Token: 0x04000729 RID: 1833
		private static Delegate cb_createKotlinClass_Ljava_lang_Class_;

		// Token: 0x0400072A RID: 1834
		private static Delegate cb_createKotlinClass_Ljava_lang_Class_Ljava_lang_String_;

		// Token: 0x0400072B RID: 1835
		private static Delegate cb_function_Lkotlin_jvm_internal_FunctionReference_;

		// Token: 0x0400072C RID: 1836
		private static Delegate cb_getOrCreateKotlinClass_Ljava_lang_Class_;

		// Token: 0x0400072D RID: 1837
		private static Delegate cb_getOrCreateKotlinClass_Ljava_lang_Class_Ljava_lang_String_;

		// Token: 0x0400072E RID: 1838
		private static Delegate cb_getOrCreateKotlinPackage_Ljava_lang_Class_Ljava_lang_String_;

		// Token: 0x0400072F RID: 1839
		private static Delegate cb_mutableCollectionType_Lkotlin_reflect_KType_;

		// Token: 0x04000730 RID: 1840
		private static Delegate cb_mutableProperty0_Lkotlin_jvm_internal_MutablePropertyReference0_;

		// Token: 0x04000731 RID: 1841
		private static Delegate cb_mutableProperty1_Lkotlin_jvm_internal_MutablePropertyReference1_;

		// Token: 0x04000732 RID: 1842
		private static Delegate cb_mutableProperty2_Lkotlin_jvm_internal_MutablePropertyReference2_;

		// Token: 0x04000733 RID: 1843
		private static Delegate cb_nothingType_Lkotlin_reflect_KType_;

		// Token: 0x04000734 RID: 1844
		private static Delegate cb_platformType_Lkotlin_reflect_KType_Lkotlin_reflect_KType_;

		// Token: 0x04000735 RID: 1845
		private static Delegate cb_property0_Lkotlin_jvm_internal_PropertyReference0_;

		// Token: 0x04000736 RID: 1846
		private static Delegate cb_property1_Lkotlin_jvm_internal_PropertyReference1_;

		// Token: 0x04000737 RID: 1847
		private static Delegate cb_property2_Lkotlin_jvm_internal_PropertyReference2_;

		// Token: 0x04000738 RID: 1848
		private static Delegate cb_renderLambdaToString_Lkotlin_jvm_internal_FunctionBase_;

		// Token: 0x04000739 RID: 1849
		private static Delegate cb_renderLambdaToString_Lkotlin_jvm_internal_Lambda_;

		// Token: 0x0400073A RID: 1850
		private static Delegate cb_setUpperBounds_Lkotlin_reflect_KTypeParameter_Ljava_util_List_;

		// Token: 0x0400073B RID: 1851
		private static Delegate cb_typeOf_Lkotlin_reflect_KClassifier_Ljava_util_List_Z;

		// Token: 0x0400073C RID: 1852
		private static Delegate cb_typeParameter_Ljava_lang_Object_Ljava_lang_String_Lkotlin_reflect_KVariance_Z;
	}
}
