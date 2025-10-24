using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x02000304 RID: 772
	[Register("java/util/HashMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public class HashMap : AbstractMap, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable, IMap
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00053C75 File Offset: 0x00051E75
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HashMap._members;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00053C7C File Offset: 0x00051E7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HashMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00053CA0 File Offset: 0x00051EA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HashMap._members.ManagedPeerType;
			}
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000536E9 File Offset: 0x000518E9
		protected HashMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00053CAC File Offset: 0x00051EAC
		private static Delegate GetCompute_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (HashMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				HashMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(HashMap.n_Compute_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return HashMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00053CD0 File Offset: 0x00051ED0
		private static IntPtr n_Compute_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_remappingFunction)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Compute(object2, object3));
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00053D04 File Offset: 0x00051F04
		public unsafe virtual Java.Lang.Object Compute(Java.Lang.Object key, IBiFunction remappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((remappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)remappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("compute.(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(remappingFunction);
			}
			return @object;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00053DA4 File Offset: 0x00051FA4
		private static Delegate GetComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_Handler()
		{
			if (HashMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_ == null)
			{
				HashMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(HashMap.n_ComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_));
			}
			return HashMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00053DC8 File Offset: 0x00051FC8
		private static IntPtr n_ComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_mappingFunction)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_mappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ComputeIfAbsent(object2, object3));
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00053DFC File Offset: 0x00051FFC
		public unsafe virtual Java.Lang.Object ComputeIfAbsent(Java.Lang.Object key, IFunction mappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((mappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)mappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("computeIfAbsent.(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(mappingFunction);
			}
			return @object;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00053E9C File Offset: 0x0005209C
		private static Delegate GetComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (HashMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				HashMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(HashMap.n_ComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return HashMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00053EC0 File Offset: 0x000520C0
		private static IntPtr n_ComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_remappingFunction)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ComputeIfPresent(object2, object3));
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00053EF4 File Offset: 0x000520F4
		public unsafe virtual Java.Lang.Object ComputeIfPresent(Java.Lang.Object key, IBiFunction remappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((remappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)remappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("computeIfPresent.(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(remappingFunction);
			}
			return @object;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00053F94 File Offset: 0x00052194
		private static Delegate GetEntrySetHandler()
		{
			if (HashMap.cb_entrySet == null)
			{
				HashMap.cb_entrySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(HashMap.n_EntrySet));
			}
			return HashMap.cb_entrySet;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00053FB8 File Offset: 0x000521B8
		private static IntPtr n_EntrySet(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EntrySet());
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00053FCC File Offset: 0x000521CC
		public override ICollection EntrySet()
		{
			return JavaSet.FromJniHandle(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("entrySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00053FFE File Offset: 0x000521FE
		private static Delegate GetForEach_Ljava_util_function_BiConsumer_Handler()
		{
			if (HashMap.cb_forEach_Ljava_util_function_BiConsumer_ == null)
			{
				HashMap.cb_forEach_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(HashMap.n_ForEach_Ljava_util_function_BiConsumer_));
			}
			return HashMap.cb_forEach_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00054024 File Offset: 0x00052224
		private static void n_ForEach_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.ForEach(object2);
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00054048 File Offset: 0x00052248
		public unsafe virtual void ForEach(IBiConsumer action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				HashMap._members.InstanceMethods.InvokeVirtualVoidMethod("forEach.(Ljava/util/function/BiConsumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000540B0 File Offset: 0x000522B0
		private static Delegate GetGetOrDefault_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (HashMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				HashMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(HashMap.n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return HashMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000540D4 File Offset: 0x000522D4
		private static IntPtr n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defaultValue)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_defaultValue, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOrDefault(object2, object3));
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00054108 File Offset: 0x00052308
		public unsafe virtual Java.Lang.Object GetOrDefault(Java.Lang.Object key, Java.Lang.Object defaultValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(defaultValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("getOrDefault.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000541A4 File Offset: 0x000523A4
		private static Delegate GetMerge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (HashMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				HashMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(HashMap.n_Merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return HashMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000541C8 File Offset: 0x000523C8
		private static IntPtr n_Merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native_remappingFunction)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IBiFunction object4 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Merge(object2, object3, object4));
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00054204 File Offset: 0x00052404
		public unsafe virtual Java.Lang.Object Merge(Java.Lang.Object key, Java.Lang.Object value, IBiFunction remappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((remappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)remappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("merge.(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(value);
				GC.KeepAlive(remappingFunction);
			}
			return @object;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000542D0 File Offset: 0x000524D0
		private static Delegate GetPutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (HashMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				HashMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(HashMap.n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return HashMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000542F4 File Offset: 0x000524F4
		private static IntPtr n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutIfAbsent(object2, object3));
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00054328 File Offset: 0x00052528
		public unsafe virtual Java.Lang.Object PutIfAbsent(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("putIfAbsent.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000543C4 File Offset: 0x000525C4
		private static Delegate GetRemove_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (HashMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				HashMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(HashMap.n_Remove_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return HashMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000543E8 File Offset: 0x000525E8
		private static bool n_Remove_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2, object3);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00054414 File Offset: 0x00052614
		public unsafe virtual bool Remove(Java.Lang.Object key, Java.Lang.Object value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = HashMap._members.InstanceMethods.InvokeVirtualBooleanMethod("remove.(Ljava/lang/Object;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000544A4 File Offset: 0x000526A4
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (HashMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				HashMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(HashMap.n_Replace_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return HashMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000544C8 File Offset: 0x000526C8
		private static IntPtr n_Replace_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(object2, object3));
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000544FC File Offset: 0x000526FC
		public unsafe virtual Java.Lang.Object Replace(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HashMap._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00054598 File Offset: 0x00052798
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (HashMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				HashMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(HashMap.n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return HashMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000545BC File Offset: 0x000527BC
		private static bool n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_oldValue, IntPtr native_newValue)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldValue, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_newValue, JniHandleOwnership.DoNotTransfer);
			return @object.Replace(object2, object3, object4);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000545F4 File Offset: 0x000527F4
		public unsafe virtual bool Replace(Java.Lang.Object key, Java.Lang.Object oldValue, Java.Lang.Object newValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(oldValue);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(newValue);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				result = HashMap._members.InstanceMethods.InvokeVirtualBooleanMethod("replace.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(key);
				GC.KeepAlive(oldValue);
				GC.KeepAlive(newValue);
			}
			return result;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000546A8 File Offset: 0x000528A8
		private static Delegate GetReplaceAll_Ljava_util_function_BiFunction_Handler()
		{
			if (HashMap.cb_replaceAll_Ljava_util_function_BiFunction_ == null)
			{
				HashMap.cb_replaceAll_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(HashMap.n_ReplaceAll_Ljava_util_function_BiFunction_));
			}
			return HashMap.cb_replaceAll_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000546CC File Offset: 0x000528CC
		private static void n_ReplaceAll_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			HashMap @object = Java.Lang.Object.GetObject<HashMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_function, JniHandleOwnership.DoNotTransfer);
			@object.ReplaceAll(object2);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000546F0 File Offset: 0x000528F0
		public unsafe virtual void ReplaceAll(IBiFunction function)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				HashMap._members.InstanceMethods.InvokeVirtualVoidMethod("replaceAll.(Ljava/util/function/BiFunction;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(function);
			}
		}

		// Token: 0x04000CA2 RID: 3234
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/HashMap", typeof(HashMap));

		// Token: 0x04000CA3 RID: 3235
		private static Delegate cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000CA4 RID: 3236
		private static Delegate cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_;

		// Token: 0x04000CA5 RID: 3237
		private static Delegate cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000CA6 RID: 3238
		private static Delegate cb_entrySet;

		// Token: 0x04000CA7 RID: 3239
		private static Delegate cb_forEach_Ljava_util_function_BiConsumer_;

		// Token: 0x04000CA8 RID: 3240
		private static Delegate cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000CA9 RID: 3241
		private static Delegate cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000CAA RID: 3242
		private static Delegate cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000CAB RID: 3243
		private static Delegate cb_remove_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000CAC RID: 3244
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000CAD RID: 3245
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000CAE RID: 3246
		private static Delegate cb_replaceAll_Ljava_util_function_BiFunction_;
	}
}
