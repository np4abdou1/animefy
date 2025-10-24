using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200030F RID: 783
	[Register("java/util/List", DoNotGenerateAcw = true)]
	internal class IListInvoker : Java.Lang.Object, IList, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x0005767C File Offset: 0x0005587C
		private static IntPtr java_class_ref
		{
			get
			{
				return IListInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000576A0 File Offset: 0x000558A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IListInvoker._members;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000576A7 File Offset: 0x000558A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x000576AF File Offset: 0x000558AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IListInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000576BB File Offset: 0x000558BB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IListInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.List'.");
			}
			return handle;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000576E6 File Offset: 0x000558E6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00057718 File Offset: 0x00055918
		public IListInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IListInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00057750 File Offset: 0x00055950
		private static Delegate GetIsEmptyHandler()
		{
			if (IListInvoker.cb_isEmpty == null)
			{
				IListInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IListInvoker.n_IsEmpty));
			}
			return IListInvoker.cb_isEmpty;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00057774 File Offset: 0x00055974
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00057783 File Offset: 0x00055983
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

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000577C3 File Offset: 0x000559C3
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (IListInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				IListInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_Add_Ljava_lang_Object_));
			}
			return IListInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000577E8 File Offset: 0x000559E8
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0005780C File Offset: 0x00055A0C
		public unsafe bool Add(Java.Lang.Object e)
		{
			if (this.id_add_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "add", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_add_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0005787D File Offset: 0x00055A7D
		private static Delegate GetAdd_ILjava_lang_Object_Handler()
		{
			if (IListInvoker.cb_add_ILjava_lang_Object_ == null)
			{
				IListInvoker.cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IListInvoker.n_Add_ILjava_lang_Object_));
			}
			return IListInvoker.cb_add_ILjava_lang_Object_;
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x000578A4 File Offset: 0x00055AA4
		private static void n_Add_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			@object.Add(index, object2);
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000578C8 File Offset: 0x00055AC8
		public unsafe void Add(int index, Java.Lang.Object element)
		{
			if (this.id_add_ILjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "add", "(ILjava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_add_ILjava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0005794C File Offset: 0x00055B4C
		private static Delegate GetAddAll_ILjava_util_Collection_Handler()
		{
			if (IListInvoker.cb_addAll_ILjava_util_Collection_ == null)
			{
				IListInvoker.cb_addAll_ILjava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(IListInvoker.n_AddAll_ILjava_util_Collection_));
			}
			return IListInvoker.cb_addAll_ILjava_util_Collection_;
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00057970 File Offset: 0x00055B70
		private static bool n_AddAll_ILjava_util_Collection_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_c)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(index, c);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00057994 File Offset: 0x00055B94
		public unsafe bool AddAll(int index, ICollection c)
		{
			if (this.id_addAll_ILjava_util_Collection_ == IntPtr.Zero)
			{
				this.id_addAll_ILjava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "addAll", "(ILjava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_addAll_ILjava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00057A18 File Offset: 0x00055C18
		private static Delegate GetAddAll_Ljava_util_Collection_Handler()
		{
			if (IListInvoker.cb_addAll_Ljava_util_Collection_ == null)
			{
				IListInvoker.cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_AddAll_Ljava_util_Collection_));
			}
			return IListInvoker.cb_addAll_Ljava_util_Collection_;
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00057A3C File Offset: 0x00055C3C
		private static bool n_AddAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(c);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00057A60 File Offset: 0x00055C60
		public unsafe bool AddAll(ICollection c)
		{
			if (this.id_addAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_addAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "addAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_addAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00057AD1 File Offset: 0x00055CD1
		private static Delegate GetClearHandler()
		{
			if (IListInvoker.cb_clear == null)
			{
				IListInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IListInvoker.n_Clear));
			}
			return IListInvoker.cb_clear;
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00057AF5 File Offset: 0x00055CF5
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00057B04 File Offset: 0x00055D04
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00057B44 File Offset: 0x00055D44
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (IListInvoker.cb_contains_Ljava_lang_Object_ == null)
			{
				IListInvoker.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_Contains_Ljava_lang_Object_));
			}
			return IListInvoker.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00057B68 File Offset: 0x00055D68
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00057B8C File Offset: 0x00055D8C
		public unsafe bool Contains(Java.Lang.Object o)
		{
			if (this.id_contains_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "contains", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_contains_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00057BFF File Offset: 0x00055DFF
		private static Delegate GetContainsAll_Ljava_util_Collection_Handler()
		{
			if (IListInvoker.cb_containsAll_Ljava_util_Collection_ == null)
			{
				IListInvoker.cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_ContainsAll_Ljava_util_Collection_));
			}
			return IListInvoker.cb_containsAll_Ljava_util_Collection_;
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00057C24 File Offset: 0x00055E24
		private static bool n_ContainsAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(c);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00057C48 File Offset: 0x00055E48
		public unsafe bool ContainsAll(ICollection c)
		{
			if (this.id_containsAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_containsAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "containsAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_containsAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00057CB9 File Offset: 0x00055EB9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IListInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IListInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IListInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00057CE0 File Offset: 0x00055EE0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00057D04 File Offset: 0x00055F04
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

		// Token: 0x06001FFE RID: 8190 RVA: 0x00057D77 File Offset: 0x00055F77
		private static Delegate GetGet_IHandler()
		{
			if (IListInvoker.cb_get_I == null)
			{
				IListInvoker.cb_get_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IListInvoker.n_Get_I));
			}
			return IListInvoker.cb_get_I;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00057D9B File Offset: 0x00055F9B
		private static IntPtr n_Get_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get(index));
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00057DB0 File Offset: 0x00055FB0
		public unsafe Java.Lang.Object Get(int index)
		{
			if (this.id_get_I == IntPtr.Zero)
			{
				this.id_get_I = JNIEnv.GetMethodID(this.class_ref, "get", "(I)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00057E1A File Offset: 0x0005601A
		private static Delegate GetGetHashCodeHandler()
		{
			if (IListInvoker.cb_hashCode == null)
			{
				IListInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IListInvoker.n_GetHashCode));
			}
			return IListInvoker.cb_hashCode;
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00057E3E File Offset: 0x0005603E
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00057E4D File Offset: 0x0005604D
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00057E8D File Offset: 0x0005608D
		private static Delegate GetIndexOf_Ljava_lang_Object_Handler()
		{
			if (IListInvoker.cb_indexOf_Ljava_lang_Object_ == null)
			{
				IListInvoker.cb_indexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IListInvoker.n_IndexOf_Ljava_lang_Object_));
			}
			return IListInvoker.cb_indexOf_Ljava_lang_Object_;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00057EB4 File Offset: 0x000560B4
		private static int n_IndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.IndexOf(object2);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00057ED8 File Offset: 0x000560D8
		public unsafe int IndexOf(Java.Lang.Object o)
		{
			if (this.id_indexOf_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_indexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "indexOf", "(Ljava/lang/Object;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_indexOf_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00057F4B File Offset: 0x0005614B
		private static Delegate GetIteratorHandler()
		{
			if (IListInvoker.cb_iterator == null)
			{
				IListInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IListInvoker.n_Iterator));
			}
			return IListInvoker.cb_iterator;
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00057F6F File Offset: 0x0005616F
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00057F84 File Offset: 0x00056184
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00057FD5 File Offset: 0x000561D5
		private static Delegate GetLastIndexOf_Ljava_lang_Object_Handler()
		{
			if (IListInvoker.cb_lastIndexOf_Ljava_lang_Object_ == null)
			{
				IListInvoker.cb_lastIndexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IListInvoker.n_LastIndexOf_Ljava_lang_Object_));
			}
			return IListInvoker.cb_lastIndexOf_Ljava_lang_Object_;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00057FFC File Offset: 0x000561FC
		private static int n_LastIndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.LastIndexOf(object2);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00058020 File Offset: 0x00056220
		public unsafe int LastIndexOf(Java.Lang.Object o)
		{
			if (this.id_lastIndexOf_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_lastIndexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "lastIndexOf", "(Ljava/lang/Object;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_lastIndexOf_Ljava_lang_Object_, ptr);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00058093 File Offset: 0x00056293
		private static Delegate GetListIteratorHandler()
		{
			if (IListInvoker.cb_listIterator == null)
			{
				IListInvoker.cb_listIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IListInvoker.n_ListIterator));
			}
			return IListInvoker.cb_listIterator;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000580B7 File Offset: 0x000562B7
		private static IntPtr n_ListIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator());
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000580CC File Offset: 0x000562CC
		public IListIterator ListIterator()
		{
			if (this.id_listIterator == IntPtr.Zero)
			{
				this.id_listIterator = JNIEnv.GetMethodID(this.class_ref, "listIterator", "()Ljava/util/ListIterator;");
			}
			return Java.Lang.Object.GetObject<IListIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_listIterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0005811D File Offset: 0x0005631D
		private static Delegate GetListIterator_IHandler()
		{
			if (IListInvoker.cb_listIterator_I == null)
			{
				IListInvoker.cb_listIterator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IListInvoker.n_ListIterator_I));
			}
			return IListInvoker.cb_listIterator_I;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00058141 File Offset: 0x00056341
		private static IntPtr n_ListIterator_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator(index));
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00058158 File Offset: 0x00056358
		public unsafe IListIterator ListIterator(int index)
		{
			if (this.id_listIterator_I == IntPtr.Zero)
			{
				this.id_listIterator_I = JNIEnv.GetMethodID(this.class_ref, "listIterator", "(I)Ljava/util/ListIterator;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return Java.Lang.Object.GetObject<IListIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_listIterator_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000581C2 File Offset: 0x000563C2
		private static Delegate GetRemove_IHandler()
		{
			if (IListInvoker.cb_remove_I == null)
			{
				IListInvoker.cb_remove_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IListInvoker.n_Remove_I));
			}
			return IListInvoker.cb_remove_I;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000581E6 File Offset: 0x000563E6
		private static IntPtr n_Remove_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove(index));
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000581FC File Offset: 0x000563FC
		public unsafe Java.Lang.Object Remove(int index)
		{
			if (this.id_remove_I == IntPtr.Zero)
			{
				this.id_remove_I = JNIEnv.GetMethodID(this.class_ref, "remove", "(I)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_remove_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00058266 File Offset: 0x00056466
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (IListInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				IListInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_Remove_Ljava_lang_Object_));
			}
			return IListInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0005828C File Offset: 0x0005648C
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000582B0 File Offset: 0x000564B0
		public unsafe bool Remove(Java.Lang.Object o)
		{
			if (this.id_remove_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_remove_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00058323 File Offset: 0x00056523
		private static Delegate GetRemoveAll_Ljava_util_Collection_Handler()
		{
			if (IListInvoker.cb_removeAll_Ljava_util_Collection_ == null)
			{
				IListInvoker.cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_RemoveAll_Ljava_util_Collection_));
			}
			return IListInvoker.cb_removeAll_Ljava_util_Collection_;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00058348 File Offset: 0x00056548
		private static bool n_RemoveAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(c);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0005836C File Offset: 0x0005656C
		public unsafe bool RemoveAll(ICollection c)
		{
			if (this.id_removeAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_removeAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "removeAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_removeAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000583DD File Offset: 0x000565DD
		private static Delegate GetRetainAll_Ljava_util_Collection_Handler()
		{
			if (IListInvoker.cb_retainAll_Ljava_util_Collection_ == null)
			{
				IListInvoker.cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IListInvoker.n_RetainAll_Ljava_util_Collection_));
			}
			return IListInvoker.cb_retainAll_Ljava_util_Collection_;
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00058404 File Offset: 0x00056604
		private static bool n_RetainAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(c);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00058428 File Offset: 0x00056628
		public unsafe bool RetainAll(ICollection c)
		{
			if (this.id_retainAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_retainAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "retainAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_retainAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00058499 File Offset: 0x00056699
		private static Delegate GetSet_ILjava_lang_Object_Handler()
		{
			if (IListInvoker.cb_set_ILjava_lang_Object_ == null)
			{
				IListInvoker.cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(IListInvoker.n_Set_ILjava_lang_Object_));
			}
			return IListInvoker.cb_set_ILjava_lang_Object_;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000584C0 File Offset: 0x000566C0
		private static IntPtr n_Set_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Set(index, object2));
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x000584EC File Offset: 0x000566EC
		public unsafe Java.Lang.Object Set(int index, Java.Lang.Object element)
		{
			if (this.id_set_ILjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_set_ILjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_set_ILjava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00058576 File Offset: 0x00056776
		private static Delegate GetSizeHandler()
		{
			if (IListInvoker.cb_size == null)
			{
				IListInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IListInvoker.n_Size));
			}
			return IListInvoker.cb_size;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0005859A File Offset: 0x0005679A
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x000585A9 File Offset: 0x000567A9
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000585E9 File Offset: 0x000567E9
		private static Delegate GetSubList_IIHandler()
		{
			if (IListInvoker.cb_subList_II == null)
			{
				IListInvoker.cb_subList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(IListInvoker.n_SubList_II));
			}
			return IListInvoker.cb_subList_II;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0005860D File Offset: 0x0005680D
		private static IntPtr n_SubList_II(IntPtr jnienv, IntPtr native__this, int fromIndex, int toIndex)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubList(fromIndex, toIndex));
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00058624 File Offset: 0x00056824
		public unsafe IList SubList(int fromIndex, int toIndex)
		{
			if (this.id_subList_II == IntPtr.Zero)
			{
				this.id_subList_II = JNIEnv.GetMethodID(this.class_ref, "subList", "(II)Ljava/util/List;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(fromIndex);
			ptr[1] = new JValue(toIndex);
			return JavaList.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_subList_II, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000586A1 File Offset: 0x000568A1
		private static Delegate GetToArrayHandler()
		{
			if (IListInvoker.cb_toArray == null)
			{
				IListInvoker.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IListInvoker.n_ToArray));
			}
			return IListInvoker.cb_toArray;
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000586C5 File Offset: 0x000568C5
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x000586DC File Offset: 0x000568DC
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0005873C File Offset: 0x0005693C
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (IListInvoker.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				IListInvoker.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IListInvoker.n_ToArray_arrayLjava_lang_Object_));
			}
			return IListInvoker.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00058760 File Offset: 0x00056960
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x000587A4 File Offset: 0x000569A4
		public unsafe Java.Lang.Object[] ToArray(Java.Lang.Object[] a)
		{
			if (this.id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(a);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object[] result = (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray_arrayLjava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			if (a != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr, a);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x04000CFB RID: 3323
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/List", typeof(IListInvoker));

		// Token: 0x04000CFC RID: 3324
		private IntPtr class_ref;

		// Token: 0x04000CFD RID: 3325
		private static Delegate cb_isEmpty;

		// Token: 0x04000CFE RID: 3326
		private IntPtr id_isEmpty;

		// Token: 0x04000CFF RID: 3327
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000D00 RID: 3328
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000D01 RID: 3329
		private static Delegate cb_add_ILjava_lang_Object_;

		// Token: 0x04000D02 RID: 3330
		private IntPtr id_add_ILjava_lang_Object_;

		// Token: 0x04000D03 RID: 3331
		private static Delegate cb_addAll_ILjava_util_Collection_;

		// Token: 0x04000D04 RID: 3332
		private IntPtr id_addAll_ILjava_util_Collection_;

		// Token: 0x04000D05 RID: 3333
		private static Delegate cb_addAll_Ljava_util_Collection_;

		// Token: 0x04000D06 RID: 3334
		private IntPtr id_addAll_Ljava_util_Collection_;

		// Token: 0x04000D07 RID: 3335
		private static Delegate cb_clear;

		// Token: 0x04000D08 RID: 3336
		private IntPtr id_clear;

		// Token: 0x04000D09 RID: 3337
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x04000D0A RID: 3338
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000D0B RID: 3339
		private static Delegate cb_containsAll_Ljava_util_Collection_;

		// Token: 0x04000D0C RID: 3340
		private IntPtr id_containsAll_Ljava_util_Collection_;

		// Token: 0x04000D0D RID: 3341
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000D0E RID: 3342
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000D0F RID: 3343
		private static Delegate cb_get_I;

		// Token: 0x04000D10 RID: 3344
		private IntPtr id_get_I;

		// Token: 0x04000D11 RID: 3345
		private static Delegate cb_hashCode;

		// Token: 0x04000D12 RID: 3346
		private IntPtr id_hashCode;

		// Token: 0x04000D13 RID: 3347
		private static Delegate cb_indexOf_Ljava_lang_Object_;

		// Token: 0x04000D14 RID: 3348
		private IntPtr id_indexOf_Ljava_lang_Object_;

		// Token: 0x04000D15 RID: 3349
		private static Delegate cb_iterator;

		// Token: 0x04000D16 RID: 3350
		private IntPtr id_iterator;

		// Token: 0x04000D17 RID: 3351
		private static Delegate cb_lastIndexOf_Ljava_lang_Object_;

		// Token: 0x04000D18 RID: 3352
		private IntPtr id_lastIndexOf_Ljava_lang_Object_;

		// Token: 0x04000D19 RID: 3353
		private static Delegate cb_listIterator;

		// Token: 0x04000D1A RID: 3354
		private IntPtr id_listIterator;

		// Token: 0x04000D1B RID: 3355
		private static Delegate cb_listIterator_I;

		// Token: 0x04000D1C RID: 3356
		private IntPtr id_listIterator_I;

		// Token: 0x04000D1D RID: 3357
		private static Delegate cb_remove_I;

		// Token: 0x04000D1E RID: 3358
		private IntPtr id_remove_I;

		// Token: 0x04000D1F RID: 3359
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000D20 RID: 3360
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000D21 RID: 3361
		private static Delegate cb_removeAll_Ljava_util_Collection_;

		// Token: 0x04000D22 RID: 3362
		private IntPtr id_removeAll_Ljava_util_Collection_;

		// Token: 0x04000D23 RID: 3363
		private static Delegate cb_retainAll_Ljava_util_Collection_;

		// Token: 0x04000D24 RID: 3364
		private IntPtr id_retainAll_Ljava_util_Collection_;

		// Token: 0x04000D25 RID: 3365
		private static Delegate cb_set_ILjava_lang_Object_;

		// Token: 0x04000D26 RID: 3366
		private IntPtr id_set_ILjava_lang_Object_;

		// Token: 0x04000D27 RID: 3367
		private static Delegate cb_size;

		// Token: 0x04000D28 RID: 3368
		private IntPtr id_size;

		// Token: 0x04000D29 RID: 3369
		private static Delegate cb_subList_II;

		// Token: 0x04000D2A RID: 3370
		private IntPtr id_subList_II;

		// Token: 0x04000D2B RID: 3371
		private static Delegate cb_toArray;

		// Token: 0x04000D2C RID: 3372
		private IntPtr id_toArray;

		// Token: 0x04000D2D RID: 3373
		private static Delegate cb_toArray_arrayLjava_lang_Object_;

		// Token: 0x04000D2E RID: 3374
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
