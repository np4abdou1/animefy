using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util.Concurrent
{
	// Token: 0x0200034B RID: 843
	[Register("java/util/concurrent/ConcurrentMap", "", "Java.Util.Concurrent.IConcurrentMapInvoker")]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public interface IConcurrentMap : IMap, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002501 RID: 9473
		Java.Lang.Object PutIfAbsent(Java.Lang.Object key, Java.Lang.Object value);

		// Token: 0x06002502 RID: 9474
		bool Remove(Java.Lang.Object key, Java.Lang.Object value);

		// Token: 0x06002503 RID: 9475
		Java.Lang.Object Replace(Java.Lang.Object key, Java.Lang.Object value);

		// Token: 0x06002504 RID: 9476
		bool Replace(Java.Lang.Object key, Java.Lang.Object oldValue, Java.Lang.Object newValue);

		// Token: 0x06002505 RID: 9477 RVA: 0x00069CDC File Offset: 0x00067EDC
		private static Delegate GetCompute_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (IConcurrentMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				IConcurrentMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IConcurrentMap.n_Compute_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return IConcurrentMap.cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00069D00 File Offset: 0x00067F00
		private static IntPtr n_Compute_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_remappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Compute(object2, object3));
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00069D34 File Offset: 0x00067F34
		unsafe Java.Lang.Object Compute(Java.Lang.Object key, IBiFunction remappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((remappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)remappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IConcurrentMap._members.InstanceMethods.InvokeVirtualObjectMethod("compute.(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(remappingFunction);
			}
			return @object;
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00069DD4 File Offset: 0x00067FD4
		private static Delegate GetComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_Handler()
		{
			if (IConcurrentMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_ == null)
			{
				IConcurrentMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IConcurrentMap.n_ComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_));
			}
			return IConcurrentMap.cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00069DF8 File Offset: 0x00067FF8
		private static IntPtr n_ComputeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_mappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_mappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ComputeIfAbsent(object2, object3));
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00069E2C File Offset: 0x0006802C
		unsafe Java.Lang.Object ComputeIfAbsent(Java.Lang.Object key, IFunction mappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((mappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)mappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IConcurrentMap._members.InstanceMethods.InvokeVirtualObjectMethod("computeIfAbsent.(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(mappingFunction);
			}
			return @object;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00069ECC File Offset: 0x000680CC
		private static Delegate GetComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (IConcurrentMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				IConcurrentMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IConcurrentMap.n_ComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return IConcurrentMap.cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00069EF0 File Offset: 0x000680F0
		private static IntPtr n_ComputeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_remappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ComputeIfPresent(object2, object3));
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00069F24 File Offset: 0x00068124
		unsafe Java.Lang.Object ComputeIfPresent(Java.Lang.Object key, IBiFunction remappingFunction)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((remappingFunction == null) ? IntPtr.Zero : ((Java.Lang.Object)remappingFunction).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IConcurrentMap._members.InstanceMethods.InvokeVirtualObjectMethod("computeIfPresent.(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(remappingFunction);
			}
			return @object;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00069FC4 File Offset: 0x000681C4
		private static Delegate GetForEach_Ljava_util_function_BiConsumer_Handler()
		{
			if (IConcurrentMap.cb_forEach_Ljava_util_function_BiConsumer_ == null)
			{
				IConcurrentMap.cb_forEach_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConcurrentMap.n_ForEach_Ljava_util_function_BiConsumer_));
			}
			return IConcurrentMap.cb_forEach_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00069FE8 File Offset: 0x000681E8
		private static void n_ForEach_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			IMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.ForEach(object2);
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0006A00C File Offset: 0x0006820C
		unsafe void ForEach(IBiConsumer action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				IConcurrentMap._members.InstanceMethods.InvokeVirtualVoidMethod("forEach.(Ljava/util/function/BiConsumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x0006A074 File Offset: 0x00068274
		private static Delegate GetGetOrDefault_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IConcurrentMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IConcurrentMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IConcurrentMap.n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IConcurrentMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x0006A098 File Offset: 0x00068298
		private static IntPtr n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defaultValue)
		{
			IMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_defaultValue, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOrDefault(object2, object3));
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0006A0CC File Offset: 0x000682CC
		unsafe Java.Lang.Object GetOrDefault(Java.Lang.Object key, Java.Lang.Object defaultValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(defaultValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IConcurrentMap._members.InstanceMethods.InvokeVirtualObjectMethod("getOrDefault.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0006A168 File Offset: 0x00068368
		private static Delegate GetMerge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_Handler()
		{
			if (IConcurrentMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_ == null)
			{
				IConcurrentMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IConcurrentMap.n_Merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_));
			}
			return IConcurrentMap.cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x0006A18C File Offset: 0x0006838C
		private static IntPtr n_Merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native_remappingFunction)
		{
			IMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IBiFunction object4 = Java.Lang.Object.GetObject<IBiFunction>(native_remappingFunction, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Merge(object2, object3, object4));
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0006A1C8 File Offset: 0x000683C8
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(IConcurrentMap._members.InstanceMethods.InvokeVirtualObjectMethod("merge.(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002517 RID: 9495 RVA: 0x0006A294 File Offset: 0x00068494
		private static Delegate GetReplaceAll_Ljava_util_function_BiFunction_Handler()
		{
			if (IConcurrentMap.cb_replaceAll_Ljava_util_function_BiFunction_ == null)
			{
				IConcurrentMap.cb_replaceAll_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConcurrentMap.n_ReplaceAll_Ljava_util_function_BiFunction_));
			}
			return IConcurrentMap.cb_replaceAll_Ljava_util_function_BiFunction_;
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x0006A2B8 File Offset: 0x000684B8
		private static void n_ReplaceAll_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			IMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_function, JniHandleOwnership.DoNotTransfer);
			@object.ReplaceAll(object2);
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x0006A2DC File Offset: 0x000684DC
		unsafe void ReplaceAll(IBiFunction function)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				IConcurrentMap._members.InstanceMethods.InvokeVirtualVoidMethod("replaceAll.(Ljava/util/function/BiFunction;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(function);
			}
		}

		// Token: 0x04000F42 RID: 3906
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/ConcurrentMap", typeof(IConcurrentMap), true);

		// Token: 0x04000F43 RID: 3907
		private static Delegate cb_compute_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000F44 RID: 3908
		private static Delegate cb_computeIfAbsent_Ljava_lang_Object_Ljava_util_function_Function_;

		// Token: 0x04000F45 RID: 3909
		private static Delegate cb_computeIfPresent_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000F46 RID: 3910
		private static Delegate cb_forEach_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F47 RID: 3911
		private static Delegate cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F48 RID: 3912
		private static Delegate cb_merge_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_function_BiFunction_;

		// Token: 0x04000F49 RID: 3913
		private static Delegate cb_replaceAll_Ljava_util_function_BiFunction_;
	}
}
