using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200031B RID: 795
	[Register("java/util/Set", DoNotGenerateAcw = true)]
	internal class ISetInvoker : Java.Lang.Object, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x0005EAC8 File Offset: 0x0005CCC8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x0005EAEC File Offset: 0x0005CCEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISetInvoker._members;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x0005EAF3 File Offset: 0x0005CCF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x0005EAFB File Offset: 0x0005CCFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x0005EB07 File Offset: 0x0005CD07
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Set'.");
			}
			return handle;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x0005EB32 File Offset: 0x0005CD32
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0005EB64 File Offset: 0x0005CD64
		public ISetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0005EB9C File Offset: 0x0005CD9C
		private static Delegate GetIsEmptyHandler()
		{
			if (ISetInvoker.cb_isEmpty == null)
			{
				ISetInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISetInvoker.n_IsEmpty));
			}
			return ISetInvoker.cb_isEmpty;
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x0005EBCF File Offset: 0x0005CDCF
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

		// Token: 0x06002199 RID: 8601 RVA: 0x0005EC0F File Offset: 0x0005CE0F
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (ISetInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				ISetInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_Add_Ljava_lang_Object_));
			}
			return ISetInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0005EC34 File Offset: 0x0005CE34
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0005EC58 File Offset: 0x0005CE58
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

		// Token: 0x0600219C RID: 8604 RVA: 0x0005ECC9 File Offset: 0x0005CEC9
		private static Delegate GetAddAll_Ljava_util_Collection_Handler()
		{
			if (ISetInvoker.cb_addAll_Ljava_util_Collection_ == null)
			{
				ISetInvoker.cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_AddAll_Ljava_util_Collection_));
			}
			return ISetInvoker.cb_addAll_Ljava_util_Collection_;
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x0005ECF0 File Offset: 0x0005CEF0
		private static bool n_AddAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(c);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0005ED14 File Offset: 0x0005CF14
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

		// Token: 0x0600219F RID: 8607 RVA: 0x0005ED85 File Offset: 0x0005CF85
		private static Delegate GetClearHandler()
		{
			if (ISetInvoker.cb_clear == null)
			{
				ISetInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ISetInvoker.n_Clear));
			}
			return ISetInvoker.cb_clear;
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0005EDA9 File Offset: 0x0005CFA9
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0005EDB8 File Offset: 0x0005CFB8
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0005EDF8 File Offset: 0x0005CFF8
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (ISetInvoker.cb_contains_Ljava_lang_Object_ == null)
			{
				ISetInvoker.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_Contains_Ljava_lang_Object_));
			}
			return ISetInvoker.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0005EE1C File Offset: 0x0005D01C
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0005EE40 File Offset: 0x0005D040
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

		// Token: 0x060021A5 RID: 8613 RVA: 0x0005EEB3 File Offset: 0x0005D0B3
		private static Delegate GetContainsAll_Ljava_util_Collection_Handler()
		{
			if (ISetInvoker.cb_containsAll_Ljava_util_Collection_ == null)
			{
				ISetInvoker.cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_ContainsAll_Ljava_util_Collection_));
			}
			return ISetInvoker.cb_containsAll_Ljava_util_Collection_;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0005EED8 File Offset: 0x0005D0D8
		private static bool n_ContainsAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(c);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0005EEFC File Offset: 0x0005D0FC
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

		// Token: 0x060021A8 RID: 8616 RVA: 0x0005EF6D File Offset: 0x0005D16D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISetInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISetInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISetInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0005EF94 File Offset: 0x0005D194
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0005EFB8 File Offset: 0x0005D1B8
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

		// Token: 0x060021AB RID: 8619 RVA: 0x0005F02B File Offset: 0x0005D22B
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISetInvoker.cb_hashCode == null)
			{
				ISetInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISetInvoker.n_GetHashCode));
			}
			return ISetInvoker.cb_hashCode;
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0005F04F File Offset: 0x0005D24F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0005F05E File Offset: 0x0005D25E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0005F09E File Offset: 0x0005D29E
		private static Delegate GetIteratorHandler()
		{
			if (ISetInvoker.cb_iterator == null)
			{
				ISetInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISetInvoker.n_Iterator));
			}
			return ISetInvoker.cb_iterator;
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0005F0C2 File Offset: 0x0005D2C2
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0005F0D8 File Offset: 0x0005D2D8
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0005F129 File Offset: 0x0005D329
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (ISetInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				ISetInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_Remove_Ljava_lang_Object_));
			}
			return ISetInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0005F150 File Offset: 0x0005D350
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0005F174 File Offset: 0x0005D374
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

		// Token: 0x060021B4 RID: 8628 RVA: 0x0005F1E7 File Offset: 0x0005D3E7
		private static Delegate GetRemoveAll_Ljava_util_Collection_Handler()
		{
			if (ISetInvoker.cb_removeAll_Ljava_util_Collection_ == null)
			{
				ISetInvoker.cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_RemoveAll_Ljava_util_Collection_));
			}
			return ISetInvoker.cb_removeAll_Ljava_util_Collection_;
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0005F20C File Offset: 0x0005D40C
		private static bool n_RemoveAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(c);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0005F230 File Offset: 0x0005D430
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

		// Token: 0x060021B7 RID: 8631 RVA: 0x0005F2A1 File Offset: 0x0005D4A1
		private static Delegate GetRetainAll_Ljava_util_Collection_Handler()
		{
			if (ISetInvoker.cb_retainAll_Ljava_util_Collection_ == null)
			{
				ISetInvoker.cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISetInvoker.n_RetainAll_Ljava_util_Collection_));
			}
			return ISetInvoker.cb_retainAll_Ljava_util_Collection_;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
		private static bool n_RetainAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(c);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0005F2EC File Offset: 0x0005D4EC
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

		// Token: 0x060021BA RID: 8634 RVA: 0x0005F35D File Offset: 0x0005D55D
		private static Delegate GetSizeHandler()
		{
			if (ISetInvoker.cb_size == null)
			{
				ISetInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISetInvoker.n_Size));
			}
			return ISetInvoker.cb_size;
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0005F381 File Offset: 0x0005D581
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0005F390 File Offset: 0x0005D590
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0005F3D0 File Offset: 0x0005D5D0
		private static Delegate GetToArrayHandler()
		{
			if (ISetInvoker.cb_toArray == null)
			{
				ISetInvoker.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISetInvoker.n_ToArray));
			}
			return ISetInvoker.cb_toArray;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0005F3F4 File Offset: 0x0005D5F4
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0005F408 File Offset: 0x0005D608
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0005F468 File Offset: 0x0005D668
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (ISetInvoker.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				ISetInvoker.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISetInvoker.n_ToArray_arrayLjava_lang_Object_));
			}
			return ISetInvoker.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0005F48C File Offset: 0x0005D68C
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			ISet @object = Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
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

		// Token: 0x04000DC9 RID: 3529
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Set", typeof(ISetInvoker));

		// Token: 0x04000DCA RID: 3530
		private IntPtr class_ref;

		// Token: 0x04000DCB RID: 3531
		private static Delegate cb_isEmpty;

		// Token: 0x04000DCC RID: 3532
		private IntPtr id_isEmpty;

		// Token: 0x04000DCD RID: 3533
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000DCE RID: 3534
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000DCF RID: 3535
		private static Delegate cb_addAll_Ljava_util_Collection_;

		// Token: 0x04000DD0 RID: 3536
		private IntPtr id_addAll_Ljava_util_Collection_;

		// Token: 0x04000DD1 RID: 3537
		private static Delegate cb_clear;

		// Token: 0x04000DD2 RID: 3538
		private IntPtr id_clear;

		// Token: 0x04000DD3 RID: 3539
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x04000DD4 RID: 3540
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000DD5 RID: 3541
		private static Delegate cb_containsAll_Ljava_util_Collection_;

		// Token: 0x04000DD6 RID: 3542
		private IntPtr id_containsAll_Ljava_util_Collection_;

		// Token: 0x04000DD7 RID: 3543
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000DD8 RID: 3544
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000DD9 RID: 3545
		private static Delegate cb_hashCode;

		// Token: 0x04000DDA RID: 3546
		private IntPtr id_hashCode;

		// Token: 0x04000DDB RID: 3547
		private static Delegate cb_iterator;

		// Token: 0x04000DDC RID: 3548
		private IntPtr id_iterator;

		// Token: 0x04000DDD RID: 3549
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000DDE RID: 3550
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000DDF RID: 3551
		private static Delegate cb_removeAll_Ljava_util_Collection_;

		// Token: 0x04000DE0 RID: 3552
		private IntPtr id_removeAll_Ljava_util_Collection_;

		// Token: 0x04000DE1 RID: 3553
		private static Delegate cb_retainAll_Ljava_util_Collection_;

		// Token: 0x04000DE2 RID: 3554
		private IntPtr id_retainAll_Ljava_util_Collection_;

		// Token: 0x04000DE3 RID: 3555
		private static Delegate cb_size;

		// Token: 0x04000DE4 RID: 3556
		private IntPtr id_size;

		// Token: 0x04000DE5 RID: 3557
		private static Delegate cb_toArray;

		// Token: 0x04000DE6 RID: 3558
		private IntPtr id_toArray;

		// Token: 0x04000DE7 RID: 3559
		private static Delegate cb_toArray_arrayLjava_lang_Object_;

		// Token: 0x04000DE8 RID: 3560
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
