using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000307 RID: 775
	[Register("java/util/Collection", DoNotGenerateAcw = true)]
	internal class ICollectionInvoker : Java.Lang.Object, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00054AFC File Offset: 0x00052CFC
		private static IntPtr java_class_ref
		{
			get
			{
				return ICollectionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00054B20 File Offset: 0x00052D20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICollectionInvoker._members;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00054B27 File Offset: 0x00052D27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00054B2F File Offset: 0x00052D2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICollectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00054B3B File Offset: 0x00052D3B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICollectionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Collection'.");
			}
			return handle;
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00054B66 File Offset: 0x00052D66
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00054B98 File Offset: 0x00052D98
		public ICollectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICollectionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00054BD0 File Offset: 0x00052DD0
		private static Delegate GetIsEmptyHandler()
		{
			if (ICollectionInvoker.cb_isEmpty == null)
			{
				ICollectionInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICollectionInvoker.n_IsEmpty));
			}
			return ICollectionInvoker.cb_isEmpty;
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00054BF4 File Offset: 0x00052DF4
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00054C03 File Offset: 0x00052E03
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

		// Token: 0x06001F26 RID: 7974 RVA: 0x00054C43 File Offset: 0x00052E43
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (ICollectionInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				ICollectionInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_Add_Ljava_lang_Object_));
			}
			return ICollectionInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00054C68 File Offset: 0x00052E68
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00054C8C File Offset: 0x00052E8C
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

		// Token: 0x06001F29 RID: 7977 RVA: 0x00054CFD File Offset: 0x00052EFD
		private static Delegate GetAddAll_Ljava_util_Collection_Handler()
		{
			if (ICollectionInvoker.cb_addAll_Ljava_util_Collection_ == null)
			{
				ICollectionInvoker.cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_AddAll_Ljava_util_Collection_));
			}
			return ICollectionInvoker.cb_addAll_Ljava_util_Collection_;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00054D24 File Offset: 0x00052F24
		private static bool n_AddAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(c);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00054D48 File Offset: 0x00052F48
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

		// Token: 0x06001F2C RID: 7980 RVA: 0x00054DB9 File Offset: 0x00052FB9
		private static Delegate GetClearHandler()
		{
			if (ICollectionInvoker.cb_clear == null)
			{
				ICollectionInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICollectionInvoker.n_Clear));
			}
			return ICollectionInvoker.cb_clear;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00054DDD File Offset: 0x00052FDD
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00054DEC File Offset: 0x00052FEC
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00054E2C File Offset: 0x0005302C
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (ICollectionInvoker.cb_contains_Ljava_lang_Object_ == null)
			{
				ICollectionInvoker.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_Contains_Ljava_lang_Object_));
			}
			return ICollectionInvoker.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00054E50 File Offset: 0x00053050
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00054E74 File Offset: 0x00053074
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

		// Token: 0x06001F32 RID: 7986 RVA: 0x00054EE7 File Offset: 0x000530E7
		private static Delegate GetContainsAll_Ljava_util_Collection_Handler()
		{
			if (ICollectionInvoker.cb_containsAll_Ljava_util_Collection_ == null)
			{
				ICollectionInvoker.cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_ContainsAll_Ljava_util_Collection_));
			}
			return ICollectionInvoker.cb_containsAll_Ljava_util_Collection_;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00054F0C File Offset: 0x0005310C
		private static bool n_ContainsAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(c);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00054F30 File Offset: 0x00053130
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

		// Token: 0x06001F35 RID: 7989 RVA: 0x00054FA1 File Offset: 0x000531A1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ICollectionInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ICollectionInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ICollectionInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00054FC8 File Offset: 0x000531C8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00054FEC File Offset: 0x000531EC
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

		// Token: 0x06001F38 RID: 7992 RVA: 0x0005505F File Offset: 0x0005325F
		private static Delegate GetGetHashCodeHandler()
		{
			if (ICollectionInvoker.cb_hashCode == null)
			{
				ICollectionInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICollectionInvoker.n_GetHashCode));
			}
			return ICollectionInvoker.cb_hashCode;
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00055083 File Offset: 0x00053283
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00055092 File Offset: 0x00053292
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000550D2 File Offset: 0x000532D2
		private static Delegate GetIteratorHandler()
		{
			if (ICollectionInvoker.cb_iterator == null)
			{
				ICollectionInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICollectionInvoker.n_Iterator));
			}
			return ICollectionInvoker.cb_iterator;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000550F6 File Offset: 0x000532F6
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0005510C File Offset: 0x0005330C
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0005515D File Offset: 0x0005335D
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (ICollectionInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				ICollectionInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_Remove_Ljava_lang_Object_));
			}
			return ICollectionInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00055184 File Offset: 0x00053384
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x000551A8 File Offset: 0x000533A8
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

		// Token: 0x06001F41 RID: 8001 RVA: 0x0005521B File Offset: 0x0005341B
		private static Delegate GetRemoveAll_Ljava_util_Collection_Handler()
		{
			if (ICollectionInvoker.cb_removeAll_Ljava_util_Collection_ == null)
			{
				ICollectionInvoker.cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_RemoveAll_Ljava_util_Collection_));
			}
			return ICollectionInvoker.cb_removeAll_Ljava_util_Collection_;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00055240 File Offset: 0x00053440
		private static bool n_RemoveAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(c);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00055264 File Offset: 0x00053464
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

		// Token: 0x06001F44 RID: 8004 RVA: 0x000552D5 File Offset: 0x000534D5
		private static Delegate GetRetainAll_Ljava_util_Collection_Handler()
		{
			if (ICollectionInvoker.cb_retainAll_Ljava_util_Collection_ == null)
			{
				ICollectionInvoker.cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollectionInvoker.n_RetainAll_Ljava_util_Collection_));
			}
			return ICollectionInvoker.cb_retainAll_Ljava_util_Collection_;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x000552FC File Offset: 0x000534FC
		private static bool n_RetainAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(c);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00055320 File Offset: 0x00053520
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

		// Token: 0x06001F47 RID: 8007 RVA: 0x00055391 File Offset: 0x00053591
		private static Delegate GetSizeHandler()
		{
			if (ICollectionInvoker.cb_size == null)
			{
				ICollectionInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICollectionInvoker.n_Size));
			}
			return ICollectionInvoker.cb_size;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x000553B5 File Offset: 0x000535B5
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x000553C4 File Offset: 0x000535C4
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00055404 File Offset: 0x00053604
		private static Delegate GetToArrayHandler()
		{
			if (ICollectionInvoker.cb_toArray == null)
			{
				ICollectionInvoker.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICollectionInvoker.n_ToArray));
			}
			return ICollectionInvoker.cb_toArray;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00055428 File Offset: 0x00053628
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0005543C File Offset: 0x0005363C
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0005549C File Offset: 0x0005369C
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (ICollectionInvoker.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				ICollectionInvoker.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICollectionInvoker.n_ToArray_arrayLjava_lang_Object_));
			}
			return ICollectionInvoker.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x000554C0 File Offset: 0x000536C0
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00055504 File Offset: 0x00053704
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

		// Token: 0x04000CB7 RID: 3255
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Collection", typeof(ICollectionInvoker));

		// Token: 0x04000CB8 RID: 3256
		private IntPtr class_ref;

		// Token: 0x04000CB9 RID: 3257
		private static Delegate cb_isEmpty;

		// Token: 0x04000CBA RID: 3258
		private IntPtr id_isEmpty;

		// Token: 0x04000CBB RID: 3259
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000CBC RID: 3260
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000CBD RID: 3261
		private static Delegate cb_addAll_Ljava_util_Collection_;

		// Token: 0x04000CBE RID: 3262
		private IntPtr id_addAll_Ljava_util_Collection_;

		// Token: 0x04000CBF RID: 3263
		private static Delegate cb_clear;

		// Token: 0x04000CC0 RID: 3264
		private IntPtr id_clear;

		// Token: 0x04000CC1 RID: 3265
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x04000CC2 RID: 3266
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000CC3 RID: 3267
		private static Delegate cb_containsAll_Ljava_util_Collection_;

		// Token: 0x04000CC4 RID: 3268
		private IntPtr id_containsAll_Ljava_util_Collection_;

		// Token: 0x04000CC5 RID: 3269
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000CC6 RID: 3270
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000CC7 RID: 3271
		private static Delegate cb_hashCode;

		// Token: 0x04000CC8 RID: 3272
		private IntPtr id_hashCode;

		// Token: 0x04000CC9 RID: 3273
		private static Delegate cb_iterator;

		// Token: 0x04000CCA RID: 3274
		private IntPtr id_iterator;

		// Token: 0x04000CCB RID: 3275
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000CCC RID: 3276
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000CCD RID: 3277
		private static Delegate cb_removeAll_Ljava_util_Collection_;

		// Token: 0x04000CCE RID: 3278
		private IntPtr id_removeAll_Ljava_util_Collection_;

		// Token: 0x04000CCF RID: 3279
		private static Delegate cb_retainAll_Ljava_util_Collection_;

		// Token: 0x04000CD0 RID: 3280
		private IntPtr id_retainAll_Ljava_util_Collection_;

		// Token: 0x04000CD1 RID: 3281
		private static Delegate cb_size;

		// Token: 0x04000CD2 RID: 3282
		private IntPtr id_size;

		// Token: 0x04000CD3 RID: 3283
		private static Delegate cb_toArray;

		// Token: 0x04000CD4 RID: 3284
		private IntPtr id_toArray;

		// Token: 0x04000CD5 RID: 3285
		private static Delegate cb_toArray_arrayLjava_lang_Object_;

		// Token: 0x04000CD6 RID: 3286
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
