using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x020002F9 RID: 761
	[Register("java/util/AbstractCollection", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractCollection : Java.Lang.Object, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x000520C9 File Offset: 0x000502C9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractCollection._members;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000520D0 File Offset: 0x000502D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractCollection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x000520F4 File Offset: 0x000502F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractCollection._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AbstractCollection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00052100 File Offset: 0x00050300
		private static Delegate GetIsEmptyHandler()
		{
			if (AbstractCollection.cb_isEmpty == null)
			{
				AbstractCollection.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AbstractCollection.n_IsEmpty));
			}
			return AbstractCollection.cb_isEmpty;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00052124 File Offset: 0x00050324
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00052133 File Offset: 0x00050333
		public virtual bool IsEmpty
		{
			get
			{
				return AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0005214C File Offset: 0x0005034C
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_add_Ljava_lang_Object_ == null)
			{
				AbstractCollection.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_Add_Ljava_lang_Object_));
			}
			return AbstractCollection.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00052170 File Offset: 0x00050370
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00052194 File Offset: 0x00050394
		public unsafe virtual bool Add(Java.Lang.Object e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("add.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000521FC File Offset: 0x000503FC
		private static Delegate GetAddAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_addAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_AddAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_addAll_Ljava_util_Collection_;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00052220 File Offset: 0x00050420
		private static bool n_AddAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(c);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00052244 File Offset: 0x00050444
		public unsafe virtual bool AddAll(ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("addAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000522A8 File Offset: 0x000504A8
		private static Delegate GetClearHandler()
		{
			if (AbstractCollection.cb_clear == null)
			{
				AbstractCollection.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbstractCollection.n_Clear));
			}
			return AbstractCollection.cb_clear;
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000522CC File Offset: 0x000504CC
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000522DB File Offset: 0x000504DB
		public virtual void Clear()
		{
			AbstractCollection._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x000522F4 File Offset: 0x000504F4
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_contains_Ljava_lang_Object_ == null)
			{
				AbstractCollection.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_Contains_Ljava_lang_Object_));
			}
			return AbstractCollection.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00052318 File Offset: 0x00050518
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0005233C File Offset: 0x0005053C
		public unsafe virtual bool Contains(Java.Lang.Object o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("contains.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x000523A4 File Offset: 0x000505A4
		private static Delegate GetContainsAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_containsAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_ContainsAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_containsAll_Ljava_util_Collection_;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x000523C8 File Offset: 0x000505C8
		private static bool n_ContainsAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(c);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000523EC File Offset: 0x000505EC
		public unsafe virtual bool ContainsAll(ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("containsAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00052450 File Offset: 0x00050650
		private static Delegate GetIteratorHandler()
		{
			if (AbstractCollection.cb_iterator == null)
			{
				AbstractCollection.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractCollection.n_Iterator));
			}
			return AbstractCollection.cb_iterator;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00052474 File Offset: 0x00050674
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001E27 RID: 7719
		public abstract IIterator Iterator();

		// Token: 0x06001E28 RID: 7720 RVA: 0x00052488 File Offset: 0x00050688
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_remove_Ljava_lang_Object_ == null)
			{
				AbstractCollection.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_Remove_Ljava_lang_Object_));
			}
			return AbstractCollection.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x000524AC File Offset: 0x000506AC
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x000524D0 File Offset: 0x000506D0
		public unsafe virtual bool Remove(Java.Lang.Object o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("remove.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00052538 File Offset: 0x00050738
		private static Delegate GetRemoveAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_removeAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_RemoveAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_removeAll_Ljava_util_Collection_;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0005255C File Offset: 0x0005075C
		private static bool n_RemoveAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(c);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00052580 File Offset: 0x00050780
		public unsafe virtual bool RemoveAll(ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("removeAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000525E4 File Offset: 0x000507E4
		private static Delegate GetRetainAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_retainAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_RetainAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_retainAll_Ljava_util_Collection_;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00052608 File Offset: 0x00050808
		private static bool n_RetainAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(c);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0005262C File Offset: 0x0005082C
		public unsafe virtual bool RetainAll(ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("retainAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00052690 File Offset: 0x00050890
		private static Delegate GetSizeHandler()
		{
			if (AbstractCollection.cb_size == null)
			{
				AbstractCollection.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractCollection.n_Size));
			}
			return AbstractCollection.cb_size;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000526B4 File Offset: 0x000508B4
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06001E33 RID: 7731
		public abstract int Size();

		// Token: 0x06001E34 RID: 7732 RVA: 0x000526C3 File Offset: 0x000508C3
		private static Delegate GetToArrayHandler()
		{
			if (AbstractCollection.cb_toArray == null)
			{
				AbstractCollection.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractCollection.n_ToArray));
			}
			return AbstractCollection.cb_toArray;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000526E7 File Offset: 0x000508E7
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000526FC File Offset: 0x000508FC
		public virtual Java.Lang.Object[] ToArray()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(AbstractCollection._members.InstanceMethods.InvokeVirtualObjectMethod("toArray.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0005273D File Offset: 0x0005093D
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				AbstractCollection.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractCollection.n_ToArray_arrayLjava_lang_Object_));
			}
			return AbstractCollection.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00052764 File Offset: 0x00050964
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000527A8 File Offset: 0x000509A8
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual Java.Lang.Object[] ToArray(Java.Lang.Object[] a)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(a);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Java.Lang.Object[])JNIEnv.GetArray(AbstractCollection._members.InstanceMethods.InvokeVirtualObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				if (a != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, a);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(a);
			}
			return result;
		}

		// Token: 0x04000C6D RID: 3181
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractCollection", typeof(AbstractCollection));

		// Token: 0x04000C6E RID: 3182
		private static Delegate cb_isEmpty;

		// Token: 0x04000C6F RID: 3183
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000C70 RID: 3184
		private static Delegate cb_addAll_Ljava_util_Collection_;

		// Token: 0x04000C71 RID: 3185
		private static Delegate cb_clear;

		// Token: 0x04000C72 RID: 3186
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x04000C73 RID: 3187
		private static Delegate cb_containsAll_Ljava_util_Collection_;

		// Token: 0x04000C74 RID: 3188
		private static Delegate cb_iterator;

		// Token: 0x04000C75 RID: 3189
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000C76 RID: 3190
		private static Delegate cb_removeAll_Ljava_util_Collection_;

		// Token: 0x04000C77 RID: 3191
		private static Delegate cb_retainAll_Ljava_util_Collection_;

		// Token: 0x04000C78 RID: 3192
		private static Delegate cb_size;

		// Token: 0x04000C79 RID: 3193
		private static Delegate cb_toArray;

		// Token: 0x04000C7A RID: 3194
		private static Delegate cb_toArray_arrayLjava_lang_Object_;
	}
}
