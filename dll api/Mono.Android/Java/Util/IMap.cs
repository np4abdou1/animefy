using System;
using System.Collections;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x02000314 RID: 788
	[Register("java/util/Map", "", "Java.Util.IMapInvoker")]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public interface IMap : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600207C RID: 8316
		bool IsEmpty { get; }

		// Token: 0x0600207D RID: 8317
		void Clear();

		// Token: 0x0600207E RID: 8318
		bool ContainsKey(Java.Lang.Object key);

		// Token: 0x0600207F RID: 8319
		bool ContainsValue(Java.Lang.Object value);

		// Token: 0x06002080 RID: 8320
		ICollection EntrySet();

		// Token: 0x06002081 RID: 8321
		bool Equals(Java.Lang.Object o);

		// Token: 0x06002082 RID: 8322
		Java.Lang.Object Get(Java.Lang.Object key);

		// Token: 0x06002083 RID: 8323
		int GetHashCode();

		// Token: 0x06002084 RID: 8324
		ICollection KeySet();

		// Token: 0x06002085 RID: 8325
		Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object value);

		// Token: 0x06002086 RID: 8326
		void PutAll(IDictionary m);

		// Token: 0x06002087 RID: 8327
		Java.Lang.Object Remove(Java.Lang.Object key);

		// Token: 0x06002088 RID: 8328
		int Size();

		// Token: 0x06002089 RID: 8329
		ICollection Values();

		// Token: 0x0600208A RID: 8330 RVA: 0x00059376 File Offset: 0x00057576
		private static Delegate GetCompute_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (IMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				IMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMap.n_Compute_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return IMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x0005939C File Offset: 0x0005759C
		private static IntPtr n_Compute_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_remappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Compute(object2, object3));
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000593D0 File Offset: 0x000575D0
		unsafe Java.Lang.Object Compute(Java.Lang.Object key, IBiFunction remappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((remappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)remappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IMap._members.InstanceMethods.InvokeVirtualObjectMethod("compute.(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(remappingFunction);
			}
			return @object;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00059470 File Offset: 0x00057670
		private static Delegate GetComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_Handler()
		{
			if (IMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_ == null)
			{
				IMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMap.n_ComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_));
			}
			return IMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00059494 File Offset: 0x00057694
		private static IntPtr n_ComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_mappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_mappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ComputeIfAbsent(object2, object3));
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000594C8 File Offset: 0x000576C8
		unsafe Java.Lang.Object ComputeIfAbsent(Java.Lang.Object key, IFunction mappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((mappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)mappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IMap._members.InstanceMethods.InvokeVirtualObjectMethod("computeIfAbsent.(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(mappingFunction);
			}
			return @object;
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00059568 File Offset: 0x00057768
		private static Delegate GetComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (IMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				IMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMap.n_ComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return IMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0005958C File Offset: 0x0005778C
		private static IntPtr n_ComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_remappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ComputeIfPresent(object2, object3));
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000595C0 File Offset: 0x000577C0
		unsafe Java.Lang.Object ComputeIfPresent(Java.Lang.Object key, IBiFunction remappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((remappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)remappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IMap._members.InstanceMethods.InvokeVirtualObjectMethod("computeIfPresent.(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(remappingFunction);
			}
			return @object;
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00059660 File Offset: 0x00057860
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary CopyOf(IDictionary map)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(map);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("copyOf.(Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(map);
			}
			return result;
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x000596D0 File Offset: 0x000578D0
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IMapEntry Entry(Java.Lang.Object k, Java.Lang.Object v)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v);
			IMapEntry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<IMapEntry>(IMap._members.StaticMethods.InvokeObjectMethod("entry.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map$Entry;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(k);
				GC.KeepAlive(v);
			}
			return @object;
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00059768 File Offset: 0x00057968
		private static Delegate GetForEach_Ljava_util_function_BiConsumer_Handler()
		{
			if (IMap.cb_forEach_Ljava_util_function_BiConsumer_ == null)
			{
				IMap.cb_forEach_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMap.n_ForEach_Ljava_util_function_BiConsumer_));
			}
			return IMap.cb_forEach_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x0005978C File Offset: 0x0005798C
		private static void n_ForEach_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.ForEach(object2);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000597B0 File Offset: 0x000579B0
		unsafe void ForEach(IBiConsumer action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				IMap._members.InstanceMethods.InvokeVirtualVoidMethod("forEach.(Ljava/util/function/BiConsumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00059818 File Offset: 0x00057A18
		private static Delegate GetGetOrDefault_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMap.n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x0005983C File Offset: 0x00057A3C
		private static IntPtr n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defaultValue)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_defaultValue, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOrDefault(object2, object3));
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00059870 File Offset: 0x00057A70
		unsafe Java.Lang.Object GetOrDefault(Java.Lang.Object key, Java.Lang.Object defaultValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(defaultValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IMap._members.InstanceMethods.InvokeVirtualObjectMethod("getOrDefault.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0005990C File Offset: 0x00057B0C
		private static Delegate GetMerge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (IMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				IMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IMap.n_Merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return IMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00059930 File Offset: 0x00057B30
		private static IntPtr n_Merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native_remappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IBiFunction object4 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Merge(object2, object3, object4));
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0005996C File Offset: 0x00057B6C
		unsafe Java.Lang.Object Merge(Java.Lang.Object key, Java.Lang.Object value, IBiFunction remappingFunction)
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IMap._members.InstanceMethods.InvokeVirtualObjectMethod("merge.(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600209E RID: 8350 RVA: 0x00059A38 File Offset: 0x00057C38
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public static IDictionary Of()
		{
			return JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.()Ljava/util/Map;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00059A6C File Offset: 0x00057C6C
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
			}
			return result;
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00059B04 File Offset: 0x00057D04
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
			}
			return result;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00059BF8 File Offset: 0x00057DF8
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
			}
			return result;
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00059D48 File Offset: 0x00057F48
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3, Java.Lang.Object k4, Java.Lang.Object v4)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(k4);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(v4);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
				GC.KeepAlive(k4);
				GC.KeepAlive(v4);
			}
			return result;
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00059EF8 File Offset: 0x000580F8
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3, Java.Lang.Object k4, Java.Lang.Object v4, Java.Lang.Object k5, Java.Lang.Object v5)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(k4);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(v4);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(k5);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(v5);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				ptr[9] = new JniArgumentValue(intPtr10);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				JNIEnv.DeleteLocalRef(intPtr10);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
				GC.KeepAlive(k4);
				GC.KeepAlive(v4);
				GC.KeepAlive(k5);
				GC.KeepAlive(v5);
			}
			return result;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0005A114 File Offset: 0x00058314
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3, Java.Lang.Object k4, Java.Lang.Object v4, Java.Lang.Object k5, Java.Lang.Object v5, Java.Lang.Object k6, Java.Lang.Object v6)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(k4);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(v4);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(k5);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(v5);
			IntPtr intPtr11 = JNIEnv.ToLocalJniHandle(k6);
			IntPtr intPtr12 = JNIEnv.ToLocalJniHandle(v6);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				ptr[9] = new JniArgumentValue(intPtr10);
				ptr[10] = new JniArgumentValue(intPtr11);
				ptr[11] = new JniArgumentValue(intPtr12);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				JNIEnv.DeleteLocalRef(intPtr10);
				JNIEnv.DeleteLocalRef(intPtr11);
				JNIEnv.DeleteLocalRef(intPtr12);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
				GC.KeepAlive(k4);
				GC.KeepAlive(v4);
				GC.KeepAlive(k5);
				GC.KeepAlive(v5);
				GC.KeepAlive(k6);
				GC.KeepAlive(v6);
			}
			return result;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0005A390 File Offset: 0x00058590
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3, Java.Lang.Object k4, Java.Lang.Object v4, Java.Lang.Object k5, Java.Lang.Object v5, Java.Lang.Object k6, Java.Lang.Object v6, Java.Lang.Object k7, Java.Lang.Object v7)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(k4);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(v4);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(k5);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(v5);
			IntPtr intPtr11 = JNIEnv.ToLocalJniHandle(k6);
			IntPtr intPtr12 = JNIEnv.ToLocalJniHandle(v6);
			IntPtr intPtr13 = JNIEnv.ToLocalJniHandle(k7);
			IntPtr intPtr14 = JNIEnv.ToLocalJniHandle(v7);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				ptr[9] = new JniArgumentValue(intPtr10);
				ptr[10] = new JniArgumentValue(intPtr11);
				ptr[11] = new JniArgumentValue(intPtr12);
				ptr[12] = new JniArgumentValue(intPtr13);
				ptr[13] = new JniArgumentValue(intPtr14);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				JNIEnv.DeleteLocalRef(intPtr10);
				JNIEnv.DeleteLocalRef(intPtr11);
				JNIEnv.DeleteLocalRef(intPtr12);
				JNIEnv.DeleteLocalRef(intPtr13);
				JNIEnv.DeleteLocalRef(intPtr14);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
				GC.KeepAlive(k4);
				GC.KeepAlive(v4);
				GC.KeepAlive(k5);
				GC.KeepAlive(v5);
				GC.KeepAlive(k6);
				GC.KeepAlive(v6);
				GC.KeepAlive(k7);
				GC.KeepAlive(v7);
			}
			return result;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0005A66C File Offset: 0x0005886C
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3, Java.Lang.Object k4, Java.Lang.Object v4, Java.Lang.Object k5, Java.Lang.Object v5, Java.Lang.Object k6, Java.Lang.Object v6, Java.Lang.Object k7, Java.Lang.Object v7, Java.Lang.Object k8, Java.Lang.Object v8)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(k4);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(v4);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(k5);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(v5);
			IntPtr intPtr11 = JNIEnv.ToLocalJniHandle(k6);
			IntPtr intPtr12 = JNIEnv.ToLocalJniHandle(v6);
			IntPtr intPtr13 = JNIEnv.ToLocalJniHandle(k7);
			IntPtr intPtr14 = JNIEnv.ToLocalJniHandle(v7);
			IntPtr intPtr15 = JNIEnv.ToLocalJniHandle(k8);
			IntPtr intPtr16 = JNIEnv.ToLocalJniHandle(v8);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				ptr[9] = new JniArgumentValue(intPtr10);
				ptr[10] = new JniArgumentValue(intPtr11);
				ptr[11] = new JniArgumentValue(intPtr12);
				ptr[12] = new JniArgumentValue(intPtr13);
				ptr[13] = new JniArgumentValue(intPtr14);
				ptr[14] = new JniArgumentValue(intPtr15);
				ptr[15] = new JniArgumentValue(intPtr16);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				JNIEnv.DeleteLocalRef(intPtr10);
				JNIEnv.DeleteLocalRef(intPtr11);
				JNIEnv.DeleteLocalRef(intPtr12);
				JNIEnv.DeleteLocalRef(intPtr13);
				JNIEnv.DeleteLocalRef(intPtr14);
				JNIEnv.DeleteLocalRef(intPtr15);
				JNIEnv.DeleteLocalRef(intPtr16);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
				GC.KeepAlive(k4);
				GC.KeepAlive(v4);
				GC.KeepAlive(k5);
				GC.KeepAlive(v5);
				GC.KeepAlive(k6);
				GC.KeepAlive(v6);
				GC.KeepAlive(k7);
				GC.KeepAlive(v7);
				GC.KeepAlive(k8);
				GC.KeepAlive(v8);
			}
			return result;
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0005A9A8 File Offset: 0x00058BA8
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3, Java.Lang.Object k4, Java.Lang.Object v4, Java.Lang.Object k5, Java.Lang.Object v5, Java.Lang.Object k6, Java.Lang.Object v6, Java.Lang.Object k7, Java.Lang.Object v7, Java.Lang.Object k8, Java.Lang.Object v8, Java.Lang.Object k9, Java.Lang.Object v9)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(k4);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(v4);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(k5);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(v5);
			IntPtr intPtr11 = JNIEnv.ToLocalJniHandle(k6);
			IntPtr intPtr12 = JNIEnv.ToLocalJniHandle(v6);
			IntPtr intPtr13 = JNIEnv.ToLocalJniHandle(k7);
			IntPtr intPtr14 = JNIEnv.ToLocalJniHandle(v7);
			IntPtr intPtr15 = JNIEnv.ToLocalJniHandle(k8);
			IntPtr intPtr16 = JNIEnv.ToLocalJniHandle(v8);
			IntPtr intPtr17 = JNIEnv.ToLocalJniHandle(k9);
			IntPtr intPtr18 = JNIEnv.ToLocalJniHandle(v9);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				ptr[9] = new JniArgumentValue(intPtr10);
				ptr[10] = new JniArgumentValue(intPtr11);
				ptr[11] = new JniArgumentValue(intPtr12);
				ptr[12] = new JniArgumentValue(intPtr13);
				ptr[13] = new JniArgumentValue(intPtr14);
				ptr[14] = new JniArgumentValue(intPtr15);
				ptr[15] = new JniArgumentValue(intPtr16);
				ptr[16] = new JniArgumentValue(intPtr17);
				ptr[17] = new JniArgumentValue(intPtr18);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				JNIEnv.DeleteLocalRef(intPtr10);
				JNIEnv.DeleteLocalRef(intPtr11);
				JNIEnv.DeleteLocalRef(intPtr12);
				JNIEnv.DeleteLocalRef(intPtr13);
				JNIEnv.DeleteLocalRef(intPtr14);
				JNIEnv.DeleteLocalRef(intPtr15);
				JNIEnv.DeleteLocalRef(intPtr16);
				JNIEnv.DeleteLocalRef(intPtr17);
				JNIEnv.DeleteLocalRef(intPtr18);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
				GC.KeepAlive(k4);
				GC.KeepAlive(v4);
				GC.KeepAlive(k5);
				GC.KeepAlive(v5);
				GC.KeepAlive(k6);
				GC.KeepAlive(v6);
				GC.KeepAlive(k7);
				GC.KeepAlive(v7);
				GC.KeepAlive(k8);
				GC.KeepAlive(v8);
				GC.KeepAlive(k9);
				GC.KeepAlive(v9);
			}
			return result;
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0005AD44 File Offset: 0x00058F44
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Of(Java.Lang.Object k1, Java.Lang.Object v1, Java.Lang.Object k2, Java.Lang.Object v2, Java.Lang.Object k3, Java.Lang.Object v3, Java.Lang.Object k4, Java.Lang.Object v4, Java.Lang.Object k5, Java.Lang.Object v5, Java.Lang.Object k6, Java.Lang.Object v6, Java.Lang.Object k7, Java.Lang.Object v7, Java.Lang.Object k8, Java.Lang.Object v8, Java.Lang.Object k9, Java.Lang.Object v9, Java.Lang.Object k10, Java.Lang.Object v10)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(k1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(v1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(k2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(v2);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(k3);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(v3);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(k4);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(v4);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(k5);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(v5);
			IntPtr intPtr11 = JNIEnv.ToLocalJniHandle(k6);
			IntPtr intPtr12 = JNIEnv.ToLocalJniHandle(v6);
			IntPtr intPtr13 = JNIEnv.ToLocalJniHandle(k7);
			IntPtr intPtr14 = JNIEnv.ToLocalJniHandle(v7);
			IntPtr intPtr15 = JNIEnv.ToLocalJniHandle(k8);
			IntPtr intPtr16 = JNIEnv.ToLocalJniHandle(v8);
			IntPtr intPtr17 = JNIEnv.ToLocalJniHandle(k9);
			IntPtr intPtr18 = JNIEnv.ToLocalJniHandle(v9);
			IntPtr intPtr19 = JNIEnv.ToLocalJniHandle(k10);
			IntPtr intPtr20 = JNIEnv.ToLocalJniHandle(v10);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				ptr[9] = new JniArgumentValue(intPtr10);
				ptr[10] = new JniArgumentValue(intPtr11);
				ptr[11] = new JniArgumentValue(intPtr12);
				ptr[12] = new JniArgumentValue(intPtr13);
				ptr[13] = new JniArgumentValue(intPtr14);
				ptr[14] = new JniArgumentValue(intPtr15);
				ptr[15] = new JniArgumentValue(intPtr16);
				ptr[16] = new JniArgumentValue(intPtr17);
				ptr[17] = new JniArgumentValue(intPtr18);
				ptr[18] = new JniArgumentValue(intPtr19);
				ptr[19] = new JniArgumentValue(intPtr20);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				JNIEnv.DeleteLocalRef(intPtr10);
				JNIEnv.DeleteLocalRef(intPtr11);
				JNIEnv.DeleteLocalRef(intPtr12);
				JNIEnv.DeleteLocalRef(intPtr13);
				JNIEnv.DeleteLocalRef(intPtr14);
				JNIEnv.DeleteLocalRef(intPtr15);
				JNIEnv.DeleteLocalRef(intPtr16);
				JNIEnv.DeleteLocalRef(intPtr17);
				JNIEnv.DeleteLocalRef(intPtr18);
				JNIEnv.DeleteLocalRef(intPtr19);
				JNIEnv.DeleteLocalRef(intPtr20);
				GC.KeepAlive(k1);
				GC.KeepAlive(v1);
				GC.KeepAlive(k2);
				GC.KeepAlive(v2);
				GC.KeepAlive(k3);
				GC.KeepAlive(v3);
				GC.KeepAlive(k4);
				GC.KeepAlive(v4);
				GC.KeepAlive(k5);
				GC.KeepAlive(v5);
				GC.KeepAlive(k6);
				GC.KeepAlive(v6);
				GC.KeepAlive(k7);
				GC.KeepAlive(v7);
				GC.KeepAlive(k8);
				GC.KeepAlive(v8);
				GC.KeepAlive(k9);
				GC.KeepAlive(v9);
				GC.KeepAlive(k10);
				GC.KeepAlive(v10);
			}
			return result;
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0005B140 File Offset: 0x00059340
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary OfEntries(params IMapEntry[] entries)
		{
			IntPtr intPtr = JNIEnv.NewArray<IMapEntry>(entries);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(IMap._members.StaticMethods.InvokeObjectMethod("ofEntries.([Ljava/util/Map$Entry;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (entries != null)
				{
					JNIEnv.CopyArray<IMapEntry>(intPtr, entries);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(entries);
			}
			return result;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0005B1BC File Offset: 0x000593BC
		private static Delegate GetPutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMap.n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0005B1E0 File Offset: 0x000593E0
		private static IntPtr n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutIfAbsent(object2, object3));
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0005B214 File Offset: 0x00059414
		unsafe Java.Lang.Object PutIfAbsent(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IMap._members.InstanceMethods.InvokeVirtualObjectMethod("putIfAbsent.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060020AD RID: 8365 RVA: 0x0005B2B0 File Offset: 0x000594B0
		private static Delegate GetRemove_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IMap.n_Remove_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0005B2D4 File Offset: 0x000594D4
		private static bool n_Remove_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2, object3);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0005B300 File Offset: 0x00059500
		unsafe bool Remove(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = IMap._members.InstanceMethods.InvokeVirtualBooleanMethod("remove.(Ljava/lang/Object;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0005B38C File Offset: 0x0005958C
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMap.n_Replace_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0005B3B0 File Offset: 0x000595B0
		private static IntPtr n_Replace_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(object2, object3));
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0005B3E4 File Offset: 0x000595E4
		unsafe Java.Lang.Object Replace(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IMap._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060020B3 RID: 8371 RVA: 0x0005B480 File Offset: 0x00059680
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IMap.n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0005B4A4 File Offset: 0x000596A4
		private static bool n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_oldValue, IntPtr native_newValue)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldValue, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_newValue, JniHandleOwnership.DoNotTransfer);
			return @object.Replace(object2, object3, object4);
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x0005B4DC File Offset: 0x000596DC
		unsafe bool Replace(Java.Lang.Object key, Java.Lang.Object oldValue, Java.Lang.Object newValue)
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
				result = IMap._members.InstanceMethods.InvokeVirtualBooleanMethod("replace.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", this, ptr);
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

		// Token: 0x060020B6 RID: 8374 RVA: 0x0005B590 File Offset: 0x00059790
		private static Delegate GetReplaceAll_Ljava_util_function_BiFunction_Handler()
		{
			if (IMap.cb_replaceAll_Ljava_util_function_BiFunction_ == null)
			{
				IMap.cb_replaceAll_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMap.n_ReplaceAll_Ljava_util_function_BiFunction_));
			}
			return IMap.cb_replaceAll_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x0005B5B4 File Offset: 0x000597B4
		private static void n_ReplaceAll_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_function, JniHandleOwnership.DoNotTransfer);
			@object.ReplaceAll(object2);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0005B5D8 File Offset: 0x000597D8
		unsafe void ReplaceAll(IBiFunction function)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				IMap._members.InstanceMethods.InvokeVirtualVoidMethod("replaceAll.(Ljava/util/function/BiFunction;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(function);
			}
		}

		// Token: 0x04000D50 RID: 3408
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Map", typeof(IMap), true);

		// Token: 0x04000D51 RID: 3409
		private static Delegate cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000D52 RID: 3410
		private static Delegate cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_;

		// Token: 0x04000D53 RID: 3411
		private static Delegate cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000D54 RID: 3412
		private static Delegate cb_forEach_Ljava_util_function_BiConsumer_;

		// Token: 0x04000D55 RID: 3413
		private static Delegate cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D56 RID: 3414
		private static Delegate cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000D57 RID: 3415
		private static Delegate cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D58 RID: 3416
		private static Delegate cb_remove_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D59 RID: 3417
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D5A RID: 3418
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D5B RID: 3419
		private static Delegate cb_replaceAll_Ljava_util_function_BiFunction_;
	}
}
