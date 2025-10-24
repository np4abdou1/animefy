using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x02000308 RID: 776
	[Register("java/util/Comparator", "", "Java.Util.IComparatorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IComparator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001F51 RID: 8017
		int Compare(Java.Lang.Object o1, Java.Lang.Object o2);

		// Token: 0x06001F52 RID: 8018
		bool Equals(Java.Lang.Object obj);

		// Token: 0x06001F53 RID: 8019 RVA: 0x000555B0 File Offset: 0x000537B0
		[JavaTypeParameters(new string[]
		{
			"T",
			"U extends java.lang.Comparable<? super U>"
		})]
		public unsafe static IComparator Comparing(IFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("comparing.(Ljava/util/function/Function;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00055628 File Offset: 0x00053828
		[JavaTypeParameters(new string[]
		{
			"T",
			"U"
		})]
		public unsafe static IComparator Comparing(IFunction keyExtractor, IComparator keyComparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				ptr[1] = new JniArgumentValue((keyComparator == null) ? IntPtr.Zero : ((Java.Lang.Object)keyComparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("comparing.(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
				GC.KeepAlive(keyComparator);
			}
			return @object;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x000556CC File Offset: 0x000538CC
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator ComparingDouble(IToDoubleFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("comparingDouble.(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00055744 File Offset: 0x00053944
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator ComparingInt(IToIntFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("comparingInt.(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000557BC File Offset: 0x000539BC
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator ComparingLong(IToLongFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("comparingLong.(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00055834 File Offset: 0x00053A34
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public static IComparator NaturalOrder()
		{
			return Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("naturalOrder.()Ljava/util/Comparator;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00055868 File Offset: 0x00053A68
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator NullsFirst(IComparator comparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("nullsFirst.(Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000558E0 File Offset: 0x00053AE0
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IComparator NullsLast(IComparator comparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((comparator == null) ? IntPtr.Zero : ((Java.Lang.Object)comparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("nullsLast.(Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(comparator);
			}
			return @object;
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00055958 File Offset: 0x00053B58
		private static Delegate GetReversedHandler()
		{
			if (IComparator.cb_reversed == null)
			{
				IComparator.cb_reversed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IComparator.n_Reversed));
			}
			return IComparator.cb_reversed;
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0005597C File Offset: 0x00053B7C
		private static IntPtr n_Reversed(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reversed());
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00055990 File Offset: 0x00053B90
		IComparator Reversed()
		{
			return Java.Lang.Object.GetObject<IComparator>(IComparator._members.InstanceMethods.InvokeVirtualObjectMethod("reversed.()Ljava/util/Comparator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000559C4 File Offset: 0x00053BC4
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public static IComparator ReverseOrder()
		{
			return Java.Lang.Object.GetObject<IComparator>(IComparator._members.StaticMethods.InvokeObjectMethod("reverseOrder.()Ljava/util/Comparator;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x000559F5 File Offset: 0x00053BF5
		private static Delegate GetThenComparing_Ljava_util_Comparator_Handler()
		{
			if (IComparator.cb_thenComparing_Ljava_util_Comparator_ == null)
			{
				IComparator.cb_thenComparing_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IComparator.n_ThenComparing_Ljava_util_Comparator_));
			}
			return IComparator.cb_thenComparing_Ljava_util_Comparator_;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00055A1C File Offset: 0x00053C1C
		private static IntPtr n_ThenComparing_Ljava_util_Comparator_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IComparator object2 = Java.Lang.Object.GetObject<IComparator>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComparing(object2));
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00055A44 File Offset: 0x00053C44
		unsafe IComparator ThenComparing(IComparator other)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.InstanceMethods.InvokeVirtualObjectMethod("thenComparing.(Ljava/util/Comparator;)Ljava/util/Comparator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00055ABC File Offset: 0x00053CBC
		private static Delegate GetThenComparing_Ljava_util_function_Function_Handler()
		{
			if (IComparator.cb_thenComparing_Ljava_util_function_Function_ == null)
			{
				IComparator.cb_thenComparing_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IComparator.n_ThenComparing_Ljava_util_function_Function_));
			}
			return IComparator.cb_thenComparing_Ljava_util_function_Function_;
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00055AE0 File Offset: 0x00053CE0
		private static IntPtr n_ThenComparing_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_keyExtractor)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_keyExtractor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComparing(object2));
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00055B08 File Offset: 0x00053D08
		[JavaTypeParameters(new string[]
		{
			"U extends java.lang.Comparable<? super U>"
		})]
		unsafe IComparator ThenComparing(IFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.InstanceMethods.InvokeVirtualObjectMethod("thenComparing.(Ljava/util/function/Function;)Ljava/util/Comparator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00055B80 File Offset: 0x00053D80
		private static Delegate GetThenComparing_Ljava_util_function_Function_Ljava_util_Comparator_Handler()
		{
			if (IComparator.cb_thenComparing_Ljava_util_function_Function_Ljava_util_Comparator_ == null)
			{
				IComparator.cb_thenComparing_Ljava_util_function_Function_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IComparator.n_ThenComparing_Ljava_util_function_Function_Ljava_util_Comparator_));
			}
			return IComparator.cb_thenComparing_Ljava_util_function_Function_Ljava_util_Comparator_;
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00055BA4 File Offset: 0x00053DA4
		private static IntPtr n_ThenComparing_Ljava_util_function_Function_Ljava_util_Comparator_(IntPtr jnienv, IntPtr native__this, IntPtr native_keyExtractor, IntPtr native_keyComparator)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_keyExtractor, JniHandleOwnership.DoNotTransfer);
			IComparator object3 = Java.Lang.Object.GetObject<IComparator>(native_keyComparator, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComparing(object2, object3));
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00055BD8 File Offset: 0x00053DD8
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		unsafe IComparator ThenComparing(IFunction keyExtractor, IComparator keyComparator)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				ptr[1] = new JniArgumentValue((keyComparator == null) ? IntPtr.Zero : ((Java.Lang.Object)keyComparator).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.InstanceMethods.InvokeVirtualObjectMethod("thenComparing.(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
				GC.KeepAlive(keyComparator);
			}
			return @object;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00055C80 File Offset: 0x00053E80
		private static Delegate GetThenComparingDouble_Ljava_util_function_ToDoubleFunction_Handler()
		{
			if (IComparator.cb_thenComparingDouble_Ljava_util_function_ToDoubleFunction_ == null)
			{
				IComparator.cb_thenComparingDouble_Ljava_util_function_ToDoubleFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IComparator.n_ThenComparingDouble_Ljava_util_function_ToDoubleFunction_));
			}
			return IComparator.cb_thenComparingDouble_Ljava_util_function_ToDoubleFunction_;
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00055CA4 File Offset: 0x00053EA4
		private static IntPtr n_ThenComparingDouble_Ljava_util_function_ToDoubleFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_keyExtractor)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IToDoubleFunction object2 = Java.Lang.Object.GetObject<IToDoubleFunction>(native_keyExtractor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComparingDouble(object2));
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00055CCC File Offset: 0x00053ECC
		unsafe IComparator ThenComparingDouble(IToDoubleFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.InstanceMethods.InvokeVirtualObjectMethod("thenComparingDouble.(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00055D44 File Offset: 0x00053F44
		private static Delegate GetThenComparingInt_Ljava_util_function_ToIntFunction_Handler()
		{
			if (IComparator.cb_thenComparingInt_Ljava_util_function_ToIntFunction_ == null)
			{
				IComparator.cb_thenComparingInt_Ljava_util_function_ToIntFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IComparator.n_ThenComparingInt_Ljava_util_function_ToIntFunction_));
			}
			return IComparator.cb_thenComparingInt_Ljava_util_function_ToIntFunction_;
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00055D68 File Offset: 0x00053F68
		private static IntPtr n_ThenComparingInt_Ljava_util_function_ToIntFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_keyExtractor)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IToIntFunction object2 = Java.Lang.Object.GetObject<IToIntFunction>(native_keyExtractor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComparingInt(object2));
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00055D90 File Offset: 0x00053F90
		unsafe IComparator ThenComparingInt(IToIntFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.InstanceMethods.InvokeVirtualObjectMethod("thenComparingInt.(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00055E08 File Offset: 0x00054008
		private static Delegate GetThenComparingLong_Ljava_util_function_ToLongFunction_Handler()
		{
			if (IComparator.cb_thenComparingLong_Ljava_util_function_ToLongFunction_ == null)
			{
				IComparator.cb_thenComparingLong_Ljava_util_function_ToLongFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IComparator.n_ThenComparingLong_Ljava_util_function_ToLongFunction_));
			}
			return IComparator.cb_thenComparingLong_Ljava_util_function_ToLongFunction_;
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00055E2C File Offset: 0x0005402C
		private static IntPtr n_ThenComparingLong_Ljava_util_function_ToLongFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_keyExtractor)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IToLongFunction object2 = Java.Lang.Object.GetObject<IToLongFunction>(native_keyExtractor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComparingLong(object2));
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00055E54 File Offset: 0x00054054
		unsafe IComparator ThenComparingLong(IToLongFunction keyExtractor)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyExtractor == null) ? IntPtr.Zero : ((Java.Lang.Object)keyExtractor).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IComparator._members.InstanceMethods.InvokeVirtualObjectMethod("thenComparingLong.(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(keyExtractor);
			}
			return @object;
		}

		// Token: 0x04000CD7 RID: 3287
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Comparator", typeof(IComparator), true);

		// Token: 0x04000CD8 RID: 3288
		private static Delegate cb_reversed;

		// Token: 0x04000CD9 RID: 3289
		private static Delegate cb_thenComparing_Ljava_util_Comparator_;

		// Token: 0x04000CDA RID: 3290
		private static Delegate cb_thenComparing_Ljava_util_function_Function_;

		// Token: 0x04000CDB RID: 3291
		private static Delegate cb_thenComparing_Ljava_util_function_Function_Ljava_util_Comparator_;

		// Token: 0x04000CDC RID: 3292
		private static Delegate cb_thenComparingDouble_Ljava_util_function_ToDoubleFunction_;

		// Token: 0x04000CDD RID: 3293
		private static Delegate cb_thenComparingInt_Ljava_util_function_ToIntFunction_;

		// Token: 0x04000CDE RID: 3294
		private static Delegate cb_thenComparingLong_Ljava_util_function_ToLongFunction_;
	}
}
