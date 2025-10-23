using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Collection
{
	// Token: 0x02000014 RID: 20
	[Register("androidx/collection/SimpleArrayMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public class SimpleArrayMap : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000026A8 File Offset: 0x000008A8
		internal static IntPtr class_ref
		{
			get
			{
				return SimpleArrayMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000026CC File Offset: 0x000008CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SimpleArrayMap._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000026D4 File Offset: 0x000008D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SimpleArrayMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000026F8 File Offset: 0x000008F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SimpleArrayMap._members.ManagedPeerType;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002704 File Offset: 0x00000904
		protected SimpleArrayMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002710 File Offset: 0x00000910
		[Register(".ctor", "()V", "")]
		public SimpleArrayMap() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SimpleArrayMap._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SimpleArrayMap._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002780 File Offset: 0x00000980
		[Register(".ctor", "(Landroidx/collection/SimpleArrayMap;)V", "")]
		public unsafe SimpleArrayMap(SimpleArrayMap map) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((map == null) ? IntPtr.Zero : map.Handle);
				base.SetHandle(SimpleArrayMap._members.InstanceMethods.StartCreateInstance("(Landroidx/collection/SimpleArrayMap;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SimpleArrayMap._members.InstanceMethods.FinishCreateInstance("(Landroidx/collection/SimpleArrayMap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(map);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002830 File Offset: 0x00000A30
		[Register(".ctor", "(I)V", "")]
		public unsafe SimpleArrayMap(int capacity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(capacity);
			base.SetHandle(SimpleArrayMap._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			SimpleArrayMap._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000028B4 File Offset: 0x00000AB4
		private static Delegate GetIsEmptyHandler()
		{
			if (SimpleArrayMap.cb_isEmpty == null)
			{
				SimpleArrayMap.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SimpleArrayMap.n_IsEmpty));
			}
			return SimpleArrayMap.cb_isEmpty;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000028D8 File Offset: 0x00000AD8
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000028E7 File Offset: 0x00000AE7
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return SimpleArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002900 File Offset: 0x00000B00
		private static Delegate GetClearHandler()
		{
			if (SimpleArrayMap.cb_clear == null)
			{
				SimpleArrayMap.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SimpleArrayMap.n_Clear));
			}
			return SimpleArrayMap.cb_clear;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002924 File Offset: 0x00000B24
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002933 File Offset: 0x00000B33
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			SimpleArrayMap._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000294C File Offset: 0x00000B4C
		private static Delegate GetContainsKey_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_containsKey_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_containsKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(SimpleArrayMap.n_ContainsKey_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_containsKey_Ljava_lang_Object_;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002970 File Offset: 0x00000B70
		private static bool n_ContainsKey_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsKey(object2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002994 File Offset: 0x00000B94
		[Register("containsKey", "(Ljava/lang/Object;)Z", "GetContainsKey_Ljava_lang_Object_Handler")]
		public unsafe virtual bool ContainsKey(Java.Lang.Object key)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				result = SimpleArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("containsKey.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000029FC File Offset: 0x00000BFC
		private static Delegate GetContainsValue_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_containsValue_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_containsValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(SimpleArrayMap.n_ContainsValue_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_containsValue_Ljava_lang_Object_;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002A20 File Offset: 0x00000C20
		private static bool n_ContainsValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsValue(object2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002A44 File Offset: 0x00000C44
		[Register("containsValue", "(Ljava/lang/Object;)Z", "GetContainsValue_Ljava_lang_Object_Handler")]
		public unsafe virtual bool ContainsValue(Java.Lang.Object value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = SimpleArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("containsValue.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002AAC File Offset: 0x00000CAC
		private static Delegate GetEnsureCapacity_IHandler()
		{
			if (SimpleArrayMap.cb_ensureCapacity_I == null)
			{
				SimpleArrayMap.cb_ensureCapacity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SimpleArrayMap.n_EnsureCapacity_I));
			}
			return SimpleArrayMap.cb_ensureCapacity_I;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002AD0 File Offset: 0x00000CD0
		private static void n_EnsureCapacity_I(IntPtr jnienv, IntPtr native__this, int minimumCapacity)
		{
			Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EnsureCapacity(minimumCapacity);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002AE0 File Offset: 0x00000CE0
		[Register("ensureCapacity", "(I)V", "GetEnsureCapacity_IHandler")]
		public unsafe virtual void EnsureCapacity(int minimumCapacity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(minimumCapacity);
			SimpleArrayMap._members.InstanceMethods.InvokeVirtualVoidMethod("ensureCapacity.(I)V", this, ptr);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002B1B File Offset: 0x00000D1B
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_get_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SimpleArrayMap.n_Get_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002B40 File Offset: 0x00000D40
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002B68 File Offset: 0x00000D68
		[Register("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002BDC File Offset: 0x00000DDC
		private static Delegate GetGetOrDefault_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SimpleArrayMap.n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002C00 File Offset: 0x00000E00
		private static IntPtr n_GetOrDefault_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defaultValue)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_defaultValue, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOrDefault(object2, object3));
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002C34 File Offset: 0x00000E34
		[Register("getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetOrDefault_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object GetOrDefault(Java.Lang.Object key, Java.Lang.Object defaultValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(defaultValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("getOrDefault.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002CD0 File Offset: 0x00000ED0
		private static Delegate GetIndexOfKey_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_indexOfKey_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_indexOfKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SimpleArrayMap.n_IndexOfKey_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_indexOfKey_Ljava_lang_Object_;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002CF4 File Offset: 0x00000EF4
		private static int n_IndexOfKey_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.IndexOfKey(object2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002D18 File Offset: 0x00000F18
		[Register("indexOfKey", "(Ljava/lang/Object;)I", "GetIndexOfKey_Ljava_lang_Object_Handler")]
		public unsafe virtual int IndexOfKey(Java.Lang.Object key)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				result = SimpleArrayMap._members.InstanceMethods.InvokeVirtualInt32Method("indexOfKey.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return result;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002D80 File Offset: 0x00000F80
		private static Delegate GetKeyAt_IHandler()
		{
			if (SimpleArrayMap.cb_keyAt_I == null)
			{
				SimpleArrayMap.cb_keyAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(SimpleArrayMap.n_KeyAt_I));
			}
			return SimpleArrayMap.cb_keyAt_I;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002DA4 File Offset: 0x00000FA4
		private static IntPtr n_KeyAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).KeyAt(index));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Register("keyAt", "(I)Ljava/lang/Object;", "GetKeyAt_IHandler")]
		public unsafe virtual Java.Lang.Object KeyAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("keyAt.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002E05 File Offset: 0x00001005
		private static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SimpleArrayMap.n_Put_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002E2C File Offset: 0x0000102C
		private static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002E60 File Offset: 0x00001060
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000081 RID: 129 RVA: 0x00002EFC File Offset: 0x000010FC
		private static Delegate GetPutAll_Landroidx_collection_SimpleArrayMap_Handler()
		{
			if (SimpleArrayMap.cb_putAll_Landroidx_collection_SimpleArrayMap_ == null)
			{
				SimpleArrayMap.cb_putAll_Landroidx_collection_SimpleArrayMap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SimpleArrayMap.n_PutAll_Landroidx_collection_SimpleArrayMap_));
			}
			return SimpleArrayMap.cb_putAll_Landroidx_collection_SimpleArrayMap_;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002F20 File Offset: 0x00001120
		private static void n_PutAll_Landroidx_collection_SimpleArrayMap_(IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SimpleArrayMap object2 = Java.Lang.Object.GetObject<SimpleArrayMap>(native_array, JniHandleOwnership.DoNotTransfer);
			@object.PutAll(object2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002F44 File Offset: 0x00001144
		[Register("putAll", "(Landroidx/collection/SimpleArrayMap;)V", "GetPutAll_Landroidx_collection_SimpleArrayMap_Handler")]
		public unsafe virtual void PutAll(SimpleArrayMap array)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((array == null) ? IntPtr.Zero : array.Handle);
				SimpleArrayMap._members.InstanceMethods.InvokeVirtualVoidMethod("putAll.(Landroidx/collection/SimpleArrayMap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(array);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002FA8 File Offset: 0x000011A8
		private static Delegate GetPutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SimpleArrayMap.n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002FCC File Offset: 0x000011CC
		private static IntPtr n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutIfAbsent(object2, object3));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003000 File Offset: 0x00001200
		[Register("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_Handler")]
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("putIfAbsent.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000087 RID: 135 RVA: 0x0000309C File Offset: 0x0000129C
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_remove_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SimpleArrayMap.n_Remove_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000030C0 File Offset: 0x000012C0
		private static IntPtr n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000030E8 File Offset: 0x000012E8
		[Register("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetRemove_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Remove(Java.Lang.Object key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000315C File Offset: 0x0000135C
		private static Delegate GetRemove_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(SimpleArrayMap.n_Remove_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_remove_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003180 File Offset: 0x00001380
		private static bool n_Remove_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2, object3);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000031AC File Offset: 0x000013AC
		[Register("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetRemove_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual bool Remove(Java.Lang.Object key, Java.Lang.Object value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = SimpleArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("remove.(Ljava/lang/Object;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000323C File Offset: 0x0000143C
		private static Delegate GetRemoveAt_IHandler()
		{
			if (SimpleArrayMap.cb_removeAt_I == null)
			{
				SimpleArrayMap.cb_removeAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(SimpleArrayMap.n_RemoveAt_I));
			}
			return SimpleArrayMap.cb_removeAt_I;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003260 File Offset: 0x00001460
		private static IntPtr n_RemoveAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAt(index));
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003278 File Offset: 0x00001478
		[Register("removeAt", "(I)Ljava/lang/Object;", "GetRemoveAt_IHandler")]
		public unsafe virtual Java.Lang.Object RemoveAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("removeAt.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000032C1 File Offset: 0x000014C1
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SimpleArrayMap.n_Replace_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000032E8 File Offset: 0x000014E8
		private static IntPtr n_Replace_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(object2, object3));
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000331C File Offset: 0x0000151C
		[Register("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetReplace_Ljava_lang_Object_Ljava_lang_Object_Handler")]
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000093 RID: 147 RVA: 0x000033B8 File Offset: 0x000015B8
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(SimpleArrayMap.n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return SimpleArrayMap.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000033DC File Offset: 0x000015DC
		private static bool n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_oldValue, IntPtr native_newValue)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldValue, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_newValue, JniHandleOwnership.DoNotTransfer);
			return @object.Replace(object2, object3, object4);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003414 File Offset: 0x00001614
		[Register("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", "GetReplace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler")]
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
				result = SimpleArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("replace.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", this, ptr);
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

		// Token: 0x06000096 RID: 150 RVA: 0x000034C8 File Offset: 0x000016C8
		private static Delegate GetSetValueAt_ILjava_lang_Object_Handler()
		{
			if (SimpleArrayMap.cb_setValueAt_ILjava_lang_Object_ == null)
			{
				SimpleArrayMap.cb_setValueAt_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(SimpleArrayMap.n_SetValueAt_ILjava_lang_Object_));
			}
			return SimpleArrayMap.cb_setValueAt_ILjava_lang_Object_;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000034EC File Offset: 0x000016EC
		private static IntPtr n_SetValueAt_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_value)
		{
			SimpleArrayMap @object = Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetValueAt(index, object2));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003518 File Offset: 0x00001718
		[Register("setValueAt", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetSetValueAt_ILjava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object SetValueAt(int index, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("setValueAt.(ILjava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000359C File Offset: 0x0000179C
		private static Delegate GetSizeHandler()
		{
			if (SimpleArrayMap.cb_size == null)
			{
				SimpleArrayMap.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SimpleArrayMap.n_Size));
			}
			return SimpleArrayMap.cb_size;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000035C0 File Offset: 0x000017C0
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000035CF File Offset: 0x000017CF
		[Register("size", "()I", "GetSizeHandler")]
		public virtual int Size()
		{
			return SimpleArrayMap._members.InstanceMethods.InvokeVirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000035E8 File Offset: 0x000017E8
		private static Delegate GetValueAt_IHandler()
		{
			if (SimpleArrayMap.cb_valueAt_I == null)
			{
				SimpleArrayMap.cb_valueAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(SimpleArrayMap.n_ValueAt_I));
			}
			return SimpleArrayMap.cb_valueAt_I;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000360C File Offset: 0x0000180C
		private static IntPtr n_ValueAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SimpleArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ValueAt(index));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003624 File Offset: 0x00001824
		[Register("valueAt", "(I)Ljava/lang/Object;", "GetValueAt_IHandler")]
		public unsafe virtual Java.Lang.Object ValueAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("valueAt.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400000B RID: 11
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/collection/SimpleArrayMap", typeof(SimpleArrayMap));

		// Token: 0x0400000C RID: 12
		private static Delegate cb_isEmpty;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_clear;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_containsKey_Ljava_lang_Object_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_containsValue_Ljava_lang_Object_;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_ensureCapacity_I;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_getOrDefault_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_indexOfKey_Ljava_lang_Object_;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_keyAt_I;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_putAll_Landroidx_collection_SimpleArrayMap_;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_remove_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_removeAt_I;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_setValueAt_ILjava_lang_Object_;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_size;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_valueAt_I;
	}
}
