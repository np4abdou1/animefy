using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000315 RID: 789
	[Register("java/util/Map", DoNotGenerateAcw = true)]
	internal class IMapInvoker : Java.Lang.Object, IMap, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0005B65C File Offset: 0x0005985C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMapInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0005B680 File Offset: 0x00059880
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMapInvoker._members;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0005B687 File Offset: 0x00059887
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0005B68F File Offset: 0x0005988F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0005B69B File Offset: 0x0005989B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMapInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Map'.");
			}
			return handle;
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0005B6C6 File Offset: 0x000598C6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0005B6F8 File Offset: 0x000598F8
		public IMapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMapInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0005B730 File Offset: 0x00059930
		private static Delegate GetIsEmptyHandler()
		{
			if (IMapInvoker.cb_isEmpty == null)
			{
				IMapInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMapInvoker.n_IsEmpty));
			}
			return IMapInvoker.cb_isEmpty;
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0005B754 File Offset: 0x00059954
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0005B763 File Offset: 0x00059963
		public bool IsEmpty
		{
			get
			{
				if (this.id_isEmpty == IntPtr.Zero)
				{
					this.id_isEmpty = JNIEnv.GetMethodID(this.class_ref, "isEmpty", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEmpty);
			}
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0005B7A3 File Offset: 0x000599A3
		private static Delegate GetClearHandler()
		{
			if (IMapInvoker.cb_clear == null)
			{
				IMapInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMapInvoker.n_Clear));
			}
			return IMapInvoker.cb_clear;
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0005B7C7 File Offset: 0x000599C7
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x0005B7D6 File Offset: 0x000599D6
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x0005B816 File Offset: 0x00059A16
		private static Delegate GetContainsKey_Ljava_lang_Object_Handler()
		{
			if (IMapInvoker.cb_containsKey_Ljava_lang_Object_ == null)
			{
				IMapInvoker.cb_containsKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMapInvoker.n_ContainsKey_Ljava_lang_Object_));
			}
			return IMapInvoker.cb_containsKey_Ljava_lang_Object_;
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0005B83C File Offset: 0x00059A3C
		private static bool n_ContainsKey_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsKey(object2);
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0005B860 File Offset: 0x00059A60
		public unsafe bool ContainsKey(Java.Lang.Object key)
		{
			if (this.id_containsKey_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_containsKey_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "containsKey", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_containsKey_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x0005B8D1 File Offset: 0x00059AD1
		private static Delegate GetContainsValue_Ljava_lang_Object_Handler()
		{
			if (IMapInvoker.cb_containsValue_Ljava_lang_Object_ == null)
			{
				IMapInvoker.cb_containsValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMapInvoker.n_ContainsValue_Ljava_lang_Object_));
			}
			return IMapInvoker.cb_containsValue_Ljava_lang_Object_;
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x0005B8F8 File Offset: 0x00059AF8
		private static bool n_ContainsValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsValue(object2);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x0005B91C File Offset: 0x00059B1C
		public unsafe bool ContainsValue(Java.Lang.Object value)
		{
			if (this.id_containsValue_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_containsValue_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "containsValue", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_containsValue_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0005B98D File Offset: 0x00059B8D
		private static Delegate GetEntrySetHandler()
		{
			if (IMapInvoker.cb_entrySet == null)
			{
				IMapInvoker.cb_entrySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMapInvoker.n_EntrySet));
			}
			return IMapInvoker.cb_entrySet;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x0005B9B1 File Offset: 0x00059BB1
		private static IntPtr n_EntrySet(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EntrySet());
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x0005B9C8 File Offset: 0x00059BC8
		public ICollection EntrySet()
		{
			if (this.id_entrySet == IntPtr.Zero)
			{
				this.id_entrySet = JNIEnv.GetMethodID(this.class_ref, "entrySet", "()Ljava/util/Set;");
			}
			return JavaSet.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_entrySet), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x0005BA19 File Offset: 0x00059C19
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMapInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMapInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMapInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMapInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x0005BA40 File Offset: 0x00059C40
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0005BA64 File Offset: 0x00059C64
		public new unsafe bool Equals(Java.Lang.Object o)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0005BAD7 File Offset: 0x00059CD7
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (IMapInvoker.cb_get_Ljava_lang_Object_ == null)
			{
				IMapInvoker.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMapInvoker.n_Get_Ljava_lang_Object_));
			}
			return IMapInvoker.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0005BAFC File Offset: 0x00059CFC
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0005BB24 File Offset: 0x00059D24
		public unsafe Java.Lang.Object Get(Java.Lang.Object key)
		{
			if (this.id_get_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x0005BB9B File Offset: 0x00059D9B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMapInvoker.cb_hashCode == null)
			{
				IMapInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMapInvoker.n_GetHashCode));
			}
			return IMapInvoker.cb_hashCode;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0005BBBF File Offset: 0x00059DBF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0005BBCE File Offset: 0x00059DCE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0005BC0E File Offset: 0x00059E0E
		private static Delegate GetKeySetHandler()
		{
			if (IMapInvoker.cb_keySet == null)
			{
				IMapInvoker.cb_keySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMapInvoker.n_KeySet));
			}
			return IMapInvoker.cb_keySet;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0005BC32 File Offset: 0x00059E32
		private static IntPtr n_KeySet(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).KeySet());
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0005BC48 File Offset: 0x00059E48
		public ICollection KeySet()
		{
			if (this.id_keySet == IntPtr.Zero)
			{
				this.id_keySet = JNIEnv.GetMethodID(this.class_ref, "keySet", "()Ljava/util/Set;");
			}
			return JavaSet.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_keySet), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0005BC99 File Offset: 0x00059E99
		private static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IMapInvoker.cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IMapInvoker.cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMapInvoker.n_Put_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IMapInvoker.cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x0005BCC0 File Offset: 0x00059EC0
		private static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x0005BCF4 File Offset: 0x00059EF4
		public unsafe Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object value)
		{
			if (this.id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_put_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0005BD8B File Offset: 0x00059F8B
		private static Delegate GetPutAll_Ljava_util_Map_Handler()
		{
			if (IMapInvoker.cb_putAll_Ljava_util_Map_ == null)
			{
				IMapInvoker.cb_putAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMapInvoker.n_PutAll_Ljava_util_Map_));
			}
			return IMapInvoker.cb_putAll_Ljava_util_Map_;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0005BDB0 File Offset: 0x00059FB0
		private static void n_PutAll_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_m)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary m = JavaDictionary.FromJniHandle(native_m, JniHandleOwnership.DoNotTransfer);
			@object.PutAll(m);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0005BDD4 File Offset: 0x00059FD4
		public unsafe void PutAll(IDictionary m)
		{
			if (this.id_putAll_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_putAll_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "putAll", "(Ljava/util/Map;)V");
			}
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(m);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_putAll_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0005BE45 File Offset: 0x0005A045
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (IMapInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				IMapInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMapInvoker.n_Remove_Ljava_lang_Object_));
			}
			return IMapInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x0005BE6C File Offset: 0x0005A06C
		private static IntPtr n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			IMap @object = Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0005BE94 File Offset: 0x0005A094
		public unsafe Java.Lang.Object Remove(Java.Lang.Object key)
		{
			if (this.id_remove_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_remove_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0005BF0B File Offset: 0x0005A10B
		private static Delegate GetSizeHandler()
		{
			if (IMapInvoker.cb_size == null)
			{
				IMapInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMapInvoker.n_Size));
			}
			return IMapInvoker.cb_size;
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0005BF2F File Offset: 0x0005A12F
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x0005BF3E File Offset: 0x0005A13E
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0005BF7E File Offset: 0x0005A17E
		private static Delegate GetValuesHandler()
		{
			if (IMapInvoker.cb_values == null)
			{
				IMapInvoker.cb_values = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMapInvoker.n_Values));
			}
			return IMapInvoker.cb_values;
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x0005BFA2 File Offset: 0x0005A1A2
		private static IntPtr n_Values(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection.ToLocalJniHandle(Java.Lang.Object.GetObject<IMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Values());
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0005BFB8 File Offset: 0x0005A1B8
		public ICollection Values()
		{
			if (this.id_values == IntPtr.Zero)
			{
				this.id_values = JNIEnv.GetMethodID(this.class_ref, "values", "()Ljava/util/Collection;");
			}
			return JavaCollection.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_values), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000D5C RID: 3420
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Map", typeof(IMapInvoker));

		// Token: 0x04000D5D RID: 3421
		private IntPtr class_ref;

		// Token: 0x04000D5E RID: 3422
		private static Delegate cb_isEmpty;

		// Token: 0x04000D5F RID: 3423
		private IntPtr id_isEmpty;

		// Token: 0x04000D60 RID: 3424
		private static Delegate cb_clear;

		// Token: 0x04000D61 RID: 3425
		private IntPtr id_clear;

		// Token: 0x04000D62 RID: 3426
		private static Delegate cb_containsKey_Ljava_lang_Object_;

		// Token: 0x04000D63 RID: 3427
		private IntPtr id_containsKey_Ljava_lang_Object_;

		// Token: 0x04000D64 RID: 3428
		private static Delegate cb_containsValue_Ljava_lang_Object_;

		// Token: 0x04000D65 RID: 3429
		private IntPtr id_containsValue_Ljava_lang_Object_;

		// Token: 0x04000D66 RID: 3430
		private static Delegate cb_entrySet;

		// Token: 0x04000D67 RID: 3431
		private IntPtr id_entrySet;

		// Token: 0x04000D68 RID: 3432
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000D69 RID: 3433
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000D6A RID: 3434
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x04000D6B RID: 3435
		private IntPtr id_get_Ljava_lang_Object_;

		// Token: 0x04000D6C RID: 3436
		private static Delegate cb_hashCode;

		// Token: 0x04000D6D RID: 3437
		private IntPtr id_hashCode;

		// Token: 0x04000D6E RID: 3438
		private static Delegate cb_keySet;

		// Token: 0x04000D6F RID: 3439
		private IntPtr id_keySet;

		// Token: 0x04000D70 RID: 3440
		private static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D71 RID: 3441
		private IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D72 RID: 3442
		private static Delegate cb_putAll_Ljava_util_Map_;

		// Token: 0x04000D73 RID: 3443
		private IntPtr id_putAll_Ljava_util_Map_;

		// Token: 0x04000D74 RID: 3444
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000D75 RID: 3445
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000D76 RID: 3446
		private static Delegate cb_size;

		// Token: 0x04000D77 RID: 3447
		private IntPtr id_size;

		// Token: 0x04000D78 RID: 3448
		private static Delegate cb_values;

		// Token: 0x04000D79 RID: 3449
		private IntPtr id_values;
	}
}
