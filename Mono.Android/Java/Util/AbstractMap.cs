using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x020002FD RID: 765
	[Register("java/util/AbstractMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public abstract class AbstractMap : Java.Lang.Object, IMap, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00053025 File Offset: 0x00051225
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMap._members;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0005302C File Offset: 0x0005122C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00053050 File Offset: 0x00051250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMap._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AbstractMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0005305C File Offset: 0x0005125C
		private static Delegate GetIsEmptyHandler()
		{
			if (AbstractMap.cb_isEmpty == null)
			{
				AbstractMap.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AbstractMap.n_IsEmpty));
			}
			return AbstractMap.cb_isEmpty;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00053080 File Offset: 0x00051280
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x0005308F File Offset: 0x0005128F
		public virtual bool IsEmpty
		{
			get
			{
				return AbstractMap._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000530A8 File Offset: 0x000512A8
		private static Delegate GetClearHandler()
		{
			if (AbstractMap.cb_clear == null)
			{
				AbstractMap.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbstractMap.n_Clear));
			}
			return AbstractMap.cb_clear;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x000530CC File Offset: 0x000512CC
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x000530DB File Offset: 0x000512DB
		public virtual void Clear()
		{
			AbstractMap._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x000530F4 File Offset: 0x000512F4
		private static Delegate GetContainsKey_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_containsKey_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_containsKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractMap.n_ContainsKey_Ljava_lang_Object_));
			}
			return AbstractMap.cb_containsKey_Ljava_lang_Object_;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00053118 File Offset: 0x00051318
		private static bool n_ContainsKey_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsKey(object2);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0005313C File Offset: 0x0005133C
		public unsafe virtual bool ContainsKey(Java.Lang.Object key)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				result = AbstractMap._members.InstanceMethods.InvokeVirtualBooleanMethod("containsKey.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return result;
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x000531A4 File Offset: 0x000513A4
		private static Delegate GetContainsValue_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_containsValue_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_containsValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractMap.n_ContainsValue_Ljava_lang_Object_));
			}
			return AbstractMap.cb_containsValue_Ljava_lang_Object_;
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000531C8 File Offset: 0x000513C8
		private static bool n_ContainsValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsValue(object2);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000531EC File Offset: 0x000513EC
		public unsafe virtual bool ContainsValue(Java.Lang.Object value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = AbstractMap._members.InstanceMethods.InvokeVirtualBooleanMethod("containsValue.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00053254 File Offset: 0x00051454
		private static Delegate GetEntrySetHandler()
		{
			if (AbstractMap.cb_entrySet == null)
			{
				AbstractMap.cb_entrySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMap.n_EntrySet));
			}
			return AbstractMap.cb_entrySet;
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00053278 File Offset: 0x00051478
		private static IntPtr n_EntrySet(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EntrySet());
		}

		// Token: 0x06001E7F RID: 7807
		public abstract ICollection EntrySet();

		// Token: 0x06001E80 RID: 7808 RVA: 0x0005328C File Offset: 0x0005148C
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_get_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractMap.n_Get_Ljava_lang_Object_));
			}
			return AbstractMap.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000532B0 File Offset: 0x000514B0
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000532D8 File Offset: 0x000514D8
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0005334C File Offset: 0x0005154C
		private static Delegate GetKeySetHandler()
		{
			if (AbstractMap.cb_keySet == null)
			{
				AbstractMap.cb_keySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMap.n_KeySet));
			}
			return AbstractMap.cb_keySet;
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00053370 File Offset: 0x00051570
		private static IntPtr n_KeySet(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).KeySet());
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00053384 File Offset: 0x00051584
		public virtual ICollection KeySet()
		{
			return JavaSet.FromJniHandle(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("keySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000533B6 File Offset: 0x000515B6
		private static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AbstractMap.n_Put_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return AbstractMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x000533DC File Offset: 0x000515DC
		private static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00053410 File Offset: 0x00051610
		public unsafe virtual Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06001E89 RID: 7817 RVA: 0x000534AC File Offset: 0x000516AC
		private static Delegate GetPutAll_Ljava_util_Map_Handler()
		{
			if (AbstractMap.cb_putAll_Ljava_util_Map_ == null)
			{
				AbstractMap.cb_putAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AbstractMap.n_PutAll_Ljava_util_Map_));
			}
			return AbstractMap.cb_putAll_Ljava_util_Map_;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x000534D0 File Offset: 0x000516D0
		private static void n_PutAll_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_m)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary m = JavaDictionary.FromJniHandle(native_m, JniHandleOwnership.DoNotTransfer);
			@object.PutAll(m);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x000534F4 File Offset: 0x000516F4
		public unsafe virtual void PutAll(IDictionary m)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(m);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AbstractMap._members.InstanceMethods.InvokeVirtualVoidMethod("putAll.(Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(m);
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00053558 File Offset: 0x00051758
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_remove_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractMap.n_Remove_Ljava_lang_Object_));
			}
			return AbstractMap.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0005357C File Offset: 0x0005177C
		private static IntPtr n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000535A4 File Offset: 0x000517A4
		public unsafe virtual Java.Lang.Object Remove(Java.Lang.Object key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00053618 File Offset: 0x00051818
		private static Delegate GetSizeHandler()
		{
			if (AbstractMap.cb_size == null)
			{
				AbstractMap.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractMap.n_Size));
			}
			return AbstractMap.cb_size;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0005363C File Offset: 0x0005183C
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0005364B File Offset: 0x0005184B
		public virtual int Size()
		{
			return AbstractMap._members.InstanceMethods.InvokeVirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00053664 File Offset: 0x00051864
		private static Delegate GetValuesHandler()
		{
			if (AbstractMap.cb_values == null)
			{
				AbstractMap.cb_values = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMap.n_Values));
			}
			return AbstractMap.cb_values;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00053688 File Offset: 0x00051888
		private static IntPtr n_Values(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Values());
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x0005369C File Offset: 0x0005189C
		public virtual ICollection Values()
		{
			return JavaCollection.FromJniHandle(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("values.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000C89 RID: 3209
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractMap", typeof(AbstractMap));

		// Token: 0x04000C8A RID: 3210
		private static Delegate cb_isEmpty;

		// Token: 0x04000C8B RID: 3211
		private static Delegate cb_clear;

		// Token: 0x04000C8C RID: 3212
		private static Delegate cb_containsKey_Ljava_lang_Object_;

		// Token: 0x04000C8D RID: 3213
		private static Delegate cb_containsValue_Ljava_lang_Object_;

		// Token: 0x04000C8E RID: 3214
		private static Delegate cb_entrySet;

		// Token: 0x04000C8F RID: 3215
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x04000C90 RID: 3216
		private static Delegate cb_keySet;

		// Token: 0x04000C91 RID: 3217
		private static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000C92 RID: 3218
		private static Delegate cb_putAll_Ljava_util_Map_;

		// Token: 0x04000C93 RID: 3219
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000C94 RID: 3220
		private static Delegate cb_size;

		// Token: 0x04000C95 RID: 3221
		private static Delegate cb_values;
	}
}
