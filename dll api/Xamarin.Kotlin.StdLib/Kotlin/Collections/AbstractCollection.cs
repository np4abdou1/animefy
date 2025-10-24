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
	// Token: 0x020002AB RID: 683
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractCollection", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractCollection : Java.Lang.Object, Java.Util.ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00069A74 File Offset: 0x00067C74
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractCollection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00069A98 File Offset: 0x00067C98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractCollection._members;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00069AA0 File Offset: 0x00067CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractCollection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00069AC4 File Offset: 0x00067CC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractCollection._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00069AD0 File Offset: 0x00067CD0
		protected AbstractCollection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00069ADC File Offset: 0x00067CDC
		[Register(".ctor", "()V", "")]
		protected AbstractCollection() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractCollection._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractCollection._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00069B4A File Offset: 0x00067D4A
		private static Delegate GetIsEmptyHandler()
		{
			if (AbstractCollection.cb_isEmpty == null)
			{
				AbstractCollection.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AbstractCollection.n_IsEmpty));
			}
			return AbstractCollection.cb_isEmpty;
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00069B6E File Offset: 0x00067D6E
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00069B7D File Offset: 0x00067D7D
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00069B96 File Offset: 0x00067D96
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_add_Ljava_lang_Object_ == null)
			{
				AbstractCollection.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_Add_Ljava_lang_Object_));
			}
			return AbstractCollection.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00069BBC File Offset: 0x00067DBC
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00069BE0 File Offset: 0x00067DE0
		[NullableContext(2)]
		[Register("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler")]
		public unsafe virtual bool Add(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("add.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00069C44 File Offset: 0x00067E44
		private static Delegate GetAddAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_addAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_AddAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_addAll_Ljava_util_Collection_;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00069C68 File Offset: 0x00067E68
		private static bool n_AddAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_elements)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection elements = JavaCollection.FromJniHandle(native_elements, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(elements);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00069C8C File Offset: 0x00067E8C
		[NullableContext(2)]
		[Register("addAll", "(Ljava/util/Collection;)Z", "GetAddAll_Ljava_util_Collection_Handler")]
		public unsafe virtual bool AddAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
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
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00069CF0 File Offset: 0x00067EF0
		private static Delegate GetClearHandler()
		{
			if (AbstractCollection.cb_clear == null)
			{
				AbstractCollection.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbstractCollection.n_Clear));
			}
			return AbstractCollection.cb_clear;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00069D14 File Offset: 0x00067F14
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00069D23 File Offset: 0x00067F23
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			AbstractCollection._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00069D3C File Offset: 0x00067F3C
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_contains_Ljava_lang_Object_ == null)
			{
				AbstractCollection.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_Contains_Ljava_lang_Object_));
			}
			return AbstractCollection.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00069D60 File Offset: 0x00067F60
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00069D84 File Offset: 0x00067F84
		[NullableContext(2)]
		[Register("contains", "(Ljava/lang/Object;)Z", "GetContains_Ljava_lang_Object_Handler")]
		public unsafe virtual bool Contains(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("contains.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00069DE8 File Offset: 0x00067FE8
		private static Delegate GetContainsAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_containsAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_ContainsAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_containsAll_Ljava_util_Collection_;
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00069E0C File Offset: 0x0006800C
		private static bool n_ContainsAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_elements)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection elements = JavaCollection.FromJniHandle(native_elements, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(elements);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00069E30 File Offset: 0x00068030
		[Register("containsAll", "(Ljava/util/Collection;)Z", "GetContainsAll_Ljava_util_Collection_Handler")]
		public unsafe virtual bool ContainsAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
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
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00069E94 File Offset: 0x00068094
		private static Delegate GetGetSizeHandler()
		{
			if (AbstractCollection.cb_getSize == null)
			{
				AbstractCollection.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractCollection.n_GetSize));
			}
			return AbstractCollection.cb_getSize;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00069EB8 File Offset: 0x000680B8
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSize();
		}

		// Token: 0x06001F96 RID: 8086
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public abstract int GetSize();

		// Token: 0x06001F97 RID: 8087 RVA: 0x00069EC7 File Offset: 0x000680C7
		private static Delegate GetIteratorHandler()
		{
			if (AbstractCollection.cb_iterator == null)
			{
				AbstractCollection.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractCollection.n_Iterator));
			}
			return AbstractCollection.cb_iterator;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00069EEB File Offset: 0x000680EB
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001F99 RID: 8089
		[Register("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public abstract IIterator Iterator();

		// Token: 0x06001F9A RID: 8090 RVA: 0x00069EFF File Offset: 0x000680FF
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_remove_Ljava_lang_Object_ == null)
			{
				AbstractCollection.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_Remove_Ljava_lang_Object_));
			}
			return AbstractCollection.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00069F24 File Offset: 0x00068124
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00069F48 File Offset: 0x00068148
		[NullableContext(2)]
		[Register("remove", "(Ljava/lang/Object;)Z", "GetRemove_Ljava_lang_Object_Handler")]
		public unsafe virtual bool Remove(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = AbstractCollection._members.InstanceMethods.InvokeVirtualBooleanMethod("remove.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00069FB0 File Offset: 0x000681B0
		private static Delegate GetRemoveAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_removeAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_RemoveAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_removeAll_Ljava_util_Collection_;
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x00069FD4 File Offset: 0x000681D4
		private static bool n_RemoveAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_elements)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection elements = JavaCollection.FromJniHandle(native_elements, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(elements);
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00069FF8 File Offset: 0x000681F8
		[NullableContext(2)]
		[Register("removeAll", "(Ljava/util/Collection;)Z", "GetRemoveAll_Ljava_util_Collection_Handler")]
		public unsafe virtual bool RemoveAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
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
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0006A05C File Offset: 0x0006825C
		private static Delegate GetRetainAll_Ljava_util_Collection_Handler()
		{
			if (AbstractCollection.cb_retainAll_Ljava_util_Collection_ == null)
			{
				AbstractCollection.cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractCollection.n_RetainAll_Ljava_util_Collection_));
			}
			return AbstractCollection.cb_retainAll_Ljava_util_Collection_;
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0006A080 File Offset: 0x00068280
		private static bool n_RetainAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_elements)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection elements = JavaCollection.FromJniHandle(native_elements, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(elements);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0006A0A4 File Offset: 0x000682A4
		[NullableContext(2)]
		[Register("retainAll", "(Ljava/util/Collection;)Z", "GetRetainAll_Ljava_util_Collection_Handler")]
		public unsafe virtual bool RetainAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
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
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0006A108 File Offset: 0x00068308
		[Register("size", "()I", "")]
		public int Size()
		{
			return AbstractCollection._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0006A121 File Offset: 0x00068321
		private static Delegate GetToArrayHandler()
		{
			if (AbstractCollection.cb_toArray == null)
			{
				AbstractCollection.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractCollection.n_ToArray));
			}
			return AbstractCollection.cb_toArray;
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0006A145 File Offset: 0x00068345
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0006A15C File Offset: 0x0006835C
		[Register("toArray", "()[Ljava/lang/Object;", "GetToArrayHandler")]
		public virtual Java.Lang.Object[] ToArray()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(AbstractCollection._members.InstanceMethods.InvokeVirtualObjectMethod("toArray.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0006A19D File Offset: 0x0006839D
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (AbstractCollection.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				AbstractCollection.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractCollection.n_ToArray_arrayLjava_lang_Object_));
			}
			return AbstractCollection.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0006A1C4 File Offset: 0x000683C4
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			AbstractCollection @object = Java.Lang.Object.GetObject<AbstractCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_array, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_array);
			}
			return result;
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0006A208 File Offset: 0x00068408
		[Register("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "GetToArray_arrayLjava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual Java.Lang.Object[] ToArray(Java.Lang.Object[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(array);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Java.Lang.Object[])JNIEnv.GetArray(AbstractCollection._members.InstanceMethods.InvokeVirtualObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return result;
		}

		// Token: 0x04000949 RID: 2377
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractCollection", typeof(AbstractCollection));

		// Token: 0x0400094A RID: 2378
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x0400094B RID: 2379
		[Nullable(2)]
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x0400094C RID: 2380
		[Nullable(2)]
		private static Delegate cb_addAll_Ljava_util_Collection_;

		// Token: 0x0400094D RID: 2381
		[Nullable(2)]
		private static Delegate cb_clear;

		// Token: 0x0400094E RID: 2382
		[Nullable(2)]
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x0400094F RID: 2383
		[Nullable(2)]
		private static Delegate cb_containsAll_Ljava_util_Collection_;

		// Token: 0x04000950 RID: 2384
		[Nullable(2)]
		private static Delegate cb_getSize;

		// Token: 0x04000951 RID: 2385
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x04000952 RID: 2386
		[Nullable(2)]
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000953 RID: 2387
		[Nullable(2)]
		private static Delegate cb_removeAll_Ljava_util_Collection_;

		// Token: 0x04000954 RID: 2388
		[Nullable(2)]
		private static Delegate cb_retainAll_Ljava_util_Collection_;

		// Token: 0x04000955 RID: 2389
		[Nullable(2)]
		private static Delegate cb_toArray;

		// Token: 0x04000956 RID: 2390
		[Nullable(2)]
		private static Delegate cb_toArray_arrayLjava_lang_Object_;
	}
}
