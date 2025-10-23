using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x020002FB RID: 763
	[Register("java/util/AbstractList", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractList : AbstractCollection, IList, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x000528D2 File Offset: 0x00050AD2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractList._members;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000528DC File Offset: 0x00050ADC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractList._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00052900 File Offset: 0x00050B00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractList._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0005284F File Offset: 0x00050A4F
		protected AbstractList(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0005290C File Offset: 0x00050B0C
		private static Delegate GetAdd_ILjava_lang_Object_Handler()
		{
			if (AbstractList.cb_add_ILjava_lang_Object_ == null)
			{
				AbstractList.cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(AbstractList.n_Add_ILjava_lang_Object_));
			}
			return AbstractList.cb_add_ILjava_lang_Object_;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00052930 File Offset: 0x00050B30
		private static void n_Add_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			@object.Add(index, object2);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00052954 File Offset: 0x00050B54
		public unsafe virtual void Add(int index, Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				AbstractList._members.InstanceMethods.InvokeVirtualVoidMethod("add.(ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000529C8 File Offset: 0x00050BC8
		private static Delegate GetAddAll_ILjava_util_Collection_Handler()
		{
			if (AbstractList.cb_addAll_ILjava_util_Collection_ == null)
			{
				AbstractList.cb_addAll_ILjava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(AbstractList.n_AddAll_ILjava_util_Collection_));
			}
			return AbstractList.cb_addAll_ILjava_util_Collection_;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000529EC File Offset: 0x00050BEC
		private static bool n_AddAll_ILjava_util_Collection_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_c)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(index, c);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00052A10 File Offset: 0x00050C10
		public unsafe virtual bool AddAll(int index, ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				result = AbstractList._members.InstanceMethods.InvokeVirtualBooleanMethod("addAll.(ILjava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00052A88 File Offset: 0x00050C88
		private static Delegate GetGet_IHandler()
		{
			if (AbstractList.cb_get_I == null)
			{
				AbstractList.cb_get_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AbstractList.n_Get_I));
			}
			return AbstractList.cb_get_I;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00052AAC File Offset: 0x00050CAC
		private static IntPtr n_Get_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get(index));
		}

		// Token: 0x06001E4D RID: 7757
		public abstract Java.Lang.Object Get(int index);

		// Token: 0x06001E4E RID: 7758 RVA: 0x00052AC1 File Offset: 0x00050CC1
		private static Delegate GetIndexOf_Ljava_lang_Object_Handler()
		{
			if (AbstractList.cb_indexOf_Ljava_lang_Object_ == null)
			{
				AbstractList.cb_indexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(AbstractList.n_IndexOf_Ljava_lang_Object_));
			}
			return AbstractList.cb_indexOf_Ljava_lang_Object_;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00052AE8 File Offset: 0x00050CE8
		private static int n_IndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.IndexOf(object2);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00052B0C File Offset: 0x00050D0C
		public unsafe virtual int IndexOf(Java.Lang.Object o)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = AbstractList._members.InstanceMethods.InvokeVirtualInt32Method("indexOf.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00052B74 File Offset: 0x00050D74
		private static Delegate GetIteratorHandler()
		{
			if (AbstractList.cb_iterator == null)
			{
				AbstractList.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractList.n_Iterator));
			}
			return AbstractList.cb_iterator;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00052B98 File Offset: 0x00050D98
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00052BAC File Offset: 0x00050DAC
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00052BDE File Offset: 0x00050DDE
		private static Delegate GetLastIndexOf_Ljava_lang_Object_Handler()
		{
			if (AbstractList.cb_lastIndexOf_Ljava_lang_Object_ == null)
			{
				AbstractList.cb_lastIndexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(AbstractList.n_LastIndexOf_Ljava_lang_Object_));
			}
			return AbstractList.cb_lastIndexOf_Ljava_lang_Object_;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00052C04 File Offset: 0x00050E04
		private static int n_LastIndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.LastIndexOf(object2);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00052C28 File Offset: 0x00050E28
		public unsafe virtual int LastIndexOf(Java.Lang.Object o)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = AbstractList._members.InstanceMethods.InvokeVirtualInt32Method("lastIndexOf.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00052C90 File Offset: 0x00050E90
		private static Delegate GetListIteratorHandler()
		{
			if (AbstractList.cb_listIterator == null)
			{
				AbstractList.cb_listIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractList.n_ListIterator));
			}
			return AbstractList.cb_listIterator;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00052CB4 File Offset: 0x00050EB4
		private static IntPtr n_ListIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator());
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00052CC8 File Offset: 0x00050EC8
		public virtual IListIterator ListIterator()
		{
			return Java.Lang.Object.GetObject<IListIterator>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("listIterator.()Ljava/util/ListIterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00052CFA File Offset: 0x00050EFA
		private static Delegate GetListIterator_IHandler()
		{
			if (AbstractList.cb_listIterator_I == null)
			{
				AbstractList.cb_listIterator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AbstractList.n_ListIterator_I));
			}
			return AbstractList.cb_listIterator_I;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00052D1E File Offset: 0x00050F1E
		private static IntPtr n_ListIterator_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator(index));
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00052D34 File Offset: 0x00050F34
		public unsafe virtual IListIterator ListIterator(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<IListIterator>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("listIterator.(I)Ljava/util/ListIterator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00052D7D File Offset: 0x00050F7D
		private static Delegate GetRemove_IHandler()
		{
			if (AbstractList.cb_remove_I == null)
			{
				AbstractList.cb_remove_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AbstractList.n_Remove_I));
			}
			return AbstractList.cb_remove_I;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00052DA1 File Offset: 0x00050FA1
		private static IntPtr n_Remove_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove(index));
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00052DB8 File Offset: 0x00050FB8
		public unsafe virtual Java.Lang.Object Remove(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00052E01 File Offset: 0x00051001
		private static Delegate GetSet_ILjava_lang_Object_Handler()
		{
			if (AbstractList.cb_set_ILjava_lang_Object_ == null)
			{
				AbstractList.cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(AbstractList.n_Set_ILjava_lang_Object_));
			}
			return AbstractList.cb_set_ILjava_lang_Object_;
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00052E28 File Offset: 0x00051028
		private static IntPtr n_Set_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Set(index, object2));
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00052E54 File Offset: 0x00051054
		public unsafe virtual Java.Lang.Object Set(int index, Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("set.(ILjava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return @object;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00052ED8 File Offset: 0x000510D8
		private static Delegate GetSubList_IIHandler()
		{
			if (AbstractList.cb_subList_II == null)
			{
				AbstractList.cb_subList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(AbstractList.n_SubList_II));
			}
			return AbstractList.cb_subList_II;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00052EFC File Offset: 0x000510FC
		private static IntPtr n_SubList_II(IntPtr jnienv, IntPtr native__this, int fromIndex, int toIndex)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubList(fromIndex, toIndex));
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00052F14 File Offset: 0x00051114
		public unsafe virtual IList SubList(int fromIndex, int toIndex)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(fromIndex);
			ptr[1] = new JniArgumentValue(toIndex);
			return JavaList.FromJniHandle(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("subList.(II)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000C7C RID: 3196
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractList", typeof(AbstractList));

		// Token: 0x04000C7D RID: 3197
		private static Delegate cb_add_ILjava_lang_Object_;

		// Token: 0x04000C7E RID: 3198
		private static Delegate cb_addAll_ILjava_util_Collection_;

		// Token: 0x04000C7F RID: 3199
		private static Delegate cb_get_I;

		// Token: 0x04000C80 RID: 3200
		private static Delegate cb_indexOf_Ljava_lang_Object_;

		// Token: 0x04000C81 RID: 3201
		private static Delegate cb_iterator;

		// Token: 0x04000C82 RID: 3202
		private static Delegate cb_lastIndexOf_Ljava_lang_Object_;

		// Token: 0x04000C83 RID: 3203
		private static Delegate cb_listIterator;

		// Token: 0x04000C84 RID: 3204
		private static Delegate cb_listIterator_I;

		// Token: 0x04000C85 RID: 3205
		private static Delegate cb_remove_I;

		// Token: 0x04000C86 RID: 3206
		private static Delegate cb_set_ILjava_lang_Object_;

		// Token: 0x04000C87 RID: 3207
		private static Delegate cb_subList_II;
	}
}
