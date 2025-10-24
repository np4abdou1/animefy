using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Collections
{
	// Token: 0x020002AF RID: 687
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractList", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractList : AbstractCollection, Java.Util.IList, Java.Util.ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0006A630 File Offset: 0x00068830
		internal new static IntPtr class_ref
		{
			get
			{
				return AbstractList._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0006A654 File Offset: 0x00068854
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractList._members;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0006A65C File Offset: 0x0006885C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractList._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0006A680 File Offset: 0x00068880
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractList._members.ManagedPeerType;
			}
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x0006A68C File Offset: 0x0006888C
		protected AbstractList(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0006A698 File Offset: 0x00068898
		[Register(".ctor", "()V", "")]
		protected AbstractList() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractList._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractList._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x0006A706 File Offset: 0x00068906
		private static Delegate GetAdd_ILjava_lang_Object_Handler()
		{
			if (AbstractList.cb_add_ILjava_lang_Object_ == null)
			{
				AbstractList.cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(AbstractList.n_Add_ILjava_lang_Object_));
			}
			return AbstractList.cb_add_ILjava_lang_Object_;
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0006A72C File Offset: 0x0006892C
		private static void n_Add_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			@object.Add(index, object2);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0006A750 File Offset: 0x00068950
		[NullableContext(2)]
		[Register("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler")]
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

		// Token: 0x06001FD4 RID: 8148 RVA: 0x0006A7C4 File Offset: 0x000689C4
		private static Delegate GetAddAll_ILjava_util_Collection_Handler()
		{
			if (AbstractList.cb_addAll_ILjava_util_Collection_ == null)
			{
				AbstractList.cb_addAll_ILjava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(AbstractList.n_AddAll_ILjava_util_Collection_));
			}
			return AbstractList.cb_addAll_ILjava_util_Collection_;
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0006A7E8 File Offset: 0x000689E8
		private static bool n_AddAll_ILjava_util_Collection_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_elements)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection elements = JavaCollection.FromJniHandle(native_elements, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(index, elements);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x0006A80C File Offset: 0x00068A0C
		[NullableContext(2)]
		[Register("addAll", "(ILjava/util/Collection;)Z", "GetAddAll_ILjava_util_Collection_Handler")]
		public unsafe virtual bool AddAll(int index, System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
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
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0006A884 File Offset: 0x00068A84
		private static Delegate GetGet_IHandler()
		{
			if (AbstractList.cb_get_I == null)
			{
				AbstractList.cb_get_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AbstractList.n_Get_I));
			}
			return AbstractList.cb_get_I;
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0006A8A8 File Offset: 0x00068AA8
		private static IntPtr n_Get_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get(index));
		}

		// Token: 0x06001FD9 RID: 8153
		[NullableContext(2)]
		[Register("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public abstract Java.Lang.Object Get(int index);

		// Token: 0x06001FDA RID: 8154 RVA: 0x0006A8BD File Offset: 0x00068ABD
		private static Delegate GetIndexOf_Ljava_lang_Object_Handler()
		{
			if (AbstractList.cb_indexOf_Ljava_lang_Object_ == null)
			{
				AbstractList.cb_indexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(AbstractList.n_IndexOf_Ljava_lang_Object_));
			}
			return AbstractList.cb_indexOf_Ljava_lang_Object_;
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		private static int n_IndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.IndexOf(object2);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0006A908 File Offset: 0x00068B08
		[NullableContext(2)]
		[Register("indexOf", "(Ljava/lang/Object;)I", "GetIndexOf_Ljava_lang_Object_Handler")]
		public unsafe virtual int IndexOf(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractList._members.InstanceMethods.InvokeVirtualInt32Method("indexOf.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0006A96C File Offset: 0x00068B6C
		private static Delegate GetIteratorHandler()
		{
			if (AbstractList.cb_iterator == null)
			{
				AbstractList.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractList.n_Iterator));
			}
			return AbstractList.cb_iterator;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0006A990 File Offset: 0x00068B90
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0006A9A4 File Offset: 0x00068BA4
		[Register("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0006A9D6 File Offset: 0x00068BD6
		private static Delegate GetLastIndexOf_Ljava_lang_Object_Handler()
		{
			if (AbstractList.cb_lastIndexOf_Ljava_lang_Object_ == null)
			{
				AbstractList.cb_lastIndexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(AbstractList.n_LastIndexOf_Ljava_lang_Object_));
			}
			return AbstractList.cb_lastIndexOf_Ljava_lang_Object_;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0006A9FC File Offset: 0x00068BFC
		private static int n_LastIndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.LastIndexOf(object2);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0006AA20 File Offset: 0x00068C20
		[NullableContext(2)]
		[Register("lastIndexOf", "(Ljava/lang/Object;)I", "GetLastIndexOf_Ljava_lang_Object_Handler")]
		public unsafe virtual int LastIndexOf(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractList._members.InstanceMethods.InvokeVirtualInt32Method("lastIndexOf.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0006AA84 File Offset: 0x00068C84
		private static Delegate GetListIteratorHandler()
		{
			if (AbstractList.cb_listIterator == null)
			{
				AbstractList.cb_listIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractList.n_ListIterator));
			}
			return AbstractList.cb_listIterator;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0006AAA8 File Offset: 0x00068CA8
		private static IntPtr n_ListIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator());
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0006AABC File Offset: 0x00068CBC
		[Register("listIterator", "()Ljava/util/ListIterator;", "GetListIteratorHandler")]
		public virtual IListIterator ListIterator()
		{
			return Java.Lang.Object.GetObject<IListIterator>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("listIterator.()Ljava/util/ListIterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0006AAEE File Offset: 0x00068CEE
		private static Delegate GetListIterator_IHandler()
		{
			if (AbstractList.cb_listIterator_I == null)
			{
				AbstractList.cb_listIterator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AbstractList.n_ListIterator_I));
			}
			return AbstractList.cb_listIterator_I;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0006AB12 File Offset: 0x00068D12
		private static IntPtr n_ListIterator_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator(index));
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0006AB28 File Offset: 0x00068D28
		[Register("listIterator", "(I)Ljava/util/ListIterator;", "GetListIterator_IHandler")]
		public unsafe virtual IListIterator ListIterator(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<IListIterator>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("listIterator.(I)Ljava/util/ListIterator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0006AB71 File Offset: 0x00068D71
		private static Delegate GetRemove_IHandler()
		{
			if (AbstractList.cb_remove_I == null)
			{
				AbstractList.cb_remove_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AbstractList.n_Remove_I));
			}
			return AbstractList.cb_remove_I;
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0006AB95 File Offset: 0x00068D95
		private static IntPtr n_Remove_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove(index));
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0006ABAC File Offset: 0x00068DAC
		[NullableContext(2)]
		[Register("remove", "(I)Ljava/lang/Object;", "GetRemove_IHandler")]
		public unsafe virtual Java.Lang.Object Remove(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0006ABF5 File Offset: 0x00068DF5
		private static Delegate GetSet_ILjava_lang_Object_Handler()
		{
			if (AbstractList.cb_set_ILjava_lang_Object_ == null)
			{
				AbstractList.cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(AbstractList.n_Set_ILjava_lang_Object_));
			}
			return AbstractList.cb_set_ILjava_lang_Object_;
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0006AC1C File Offset: 0x00068E1C
		private static IntPtr n_Set_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			AbstractList @object = Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Set(index, object2));
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0006AC48 File Offset: 0x00068E48
		[NullableContext(2)]
		[Register("set", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetSet_ILjava_lang_Object_Handler")]
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

		// Token: 0x06001FEF RID: 8175 RVA: 0x0006ACCC File Offset: 0x00068ECC
		private static Delegate GetSubList_IIHandler()
		{
			if (AbstractList.cb_subList_II == null)
			{
				AbstractList.cb_subList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(AbstractList.n_SubList_II));
			}
			return AbstractList.cb_subList_II;
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0006ACF0 File Offset: 0x00068EF0
		private static IntPtr n_SubList_II(IntPtr jnienv, IntPtr native__this, int fromIndex, int toIndex)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubList(fromIndex, toIndex));
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0006AD08 File Offset: 0x00068F08
		[Register("subList", "(II)Ljava/util/List;", "GetSubList_IIHandler")]
		public unsafe virtual System.Collections.IList SubList(int fromIndex, int toIndex)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(fromIndex);
			ptr[1] = new JniArgumentValue(toIndex);
			return JavaList.FromJniHandle(AbstractList._members.InstanceMethods.InvokeVirtualObjectMethod("subList.(II)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400095E RID: 2398
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractList", typeof(AbstractList));

		// Token: 0x0400095F RID: 2399
		[Nullable(2)]
		private static Delegate cb_add_ILjava_lang_Object_;

		// Token: 0x04000960 RID: 2400
		[Nullable(2)]
		private static Delegate cb_addAll_ILjava_util_Collection_;

		// Token: 0x04000961 RID: 2401
		[Nullable(2)]
		private static Delegate cb_get_I;

		// Token: 0x04000962 RID: 2402
		[Nullable(2)]
		private static Delegate cb_indexOf_Ljava_lang_Object_;

		// Token: 0x04000963 RID: 2403
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x04000964 RID: 2404
		[Nullable(2)]
		private static Delegate cb_lastIndexOf_Ljava_lang_Object_;

		// Token: 0x04000965 RID: 2405
		[Nullable(2)]
		private static Delegate cb_listIterator;

		// Token: 0x04000966 RID: 2406
		[Nullable(2)]
		private static Delegate cb_listIterator_I;

		// Token: 0x04000967 RID: 2407
		[Nullable(2)]
		private static Delegate cb_remove_I;

		// Token: 0x04000968 RID: 2408
		[Nullable(2)]
		private static Delegate cb_set_ILjava_lang_Object_;

		// Token: 0x04000969 RID: 2409
		[Nullable(2)]
		private static Delegate cb_subList_II;
	}
}
