using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200031D RID: 797
	[Register("java/util/SortedSet", DoNotGenerateAcw = true)]
	internal class ISortedSetInvoker : Java.Lang.Object, ISortedSet, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0005F604 File Offset: 0x0005D804
		private static IntPtr java_class_ref
		{
			get
			{
				return ISortedSetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x0005F628 File Offset: 0x0005D828
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISortedSetInvoker._members;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0005F62F File Offset: 0x0005D82F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x0005F637 File Offset: 0x0005D837
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISortedSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0005F643 File Offset: 0x0005D843
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISortedSetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.SortedSet'.");
			}
			return handle;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0005F66E File Offset: 0x0005D86E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0005F6A0 File Offset: 0x0005D8A0
		public ISortedSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISortedSetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0005F6D8 File Offset: 0x0005D8D8
		private static Delegate GetComparatorHandler()
		{
			if (ISortedSetInvoker.cb_comparator == null)
			{
				ISortedSetInvoker.cb_comparator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISortedSetInvoker.n_Comparator));
			}
			return ISortedSetInvoker.cb_comparator;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		private static IntPtr n_Comparator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISortedSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Comparator());
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0005F710 File Offset: 0x0005D910
		public IComparator Comparator()
		{
			if (this.id_comparator == IntPtr.Zero)
			{
				this.id_comparator = JNIEnv.GetMethodID(this.class_ref, "comparator", "()Ljava/util/Comparator;");
			}
			return Java.Lang.Object.GetObject<IComparator>(JNIEnv.CallObjectMethod(base.Handle, this.id_comparator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0005F761 File Offset: 0x0005D961
		private static Delegate GetFirstHandler()
		{
			if (ISortedSetInvoker.cb_first == null)
			{
				ISortedSetInvoker.cb_first = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISortedSetInvoker.n_First));
			}
			return ISortedSetInvoker.cb_first;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0005F785 File Offset: 0x0005D985
		private static IntPtr n_First(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISortedSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).First());
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0005F79C File Offset: 0x0005D99C
		public Java.Lang.Object First()
		{
			if (this.id_first == IntPtr.Zero)
			{
				this.id_first = JNIEnv.GetMethodID(this.class_ref, "first", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_first), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0005F7ED File Offset: 0x0005D9ED
		private static Delegate GetHeadSet_Ljava_lang_Object_Handler()
		{
			if (ISortedSetInvoker.cb_headSet_Ljava_lang_Object_ == null)
			{
				ISortedSetInvoker.cb_headSet_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISortedSetInvoker.n_HeadSet_Ljava_lang_Object_));
			}
			return ISortedSetInvoker.cb_headSet_Ljava_lang_Object_;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0005F814 File Offset: 0x0005DA14
		private static IntPtr n_HeadSet_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_toElement)
		{
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HeadSet(object2));
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0005F83C File Offset: 0x0005DA3C
		public unsafe ISortedSet HeadSet(Java.Lang.Object toElement)
		{
			if (this.id_headSet_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_headSet_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(toElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_headSet_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0005F8B3 File Offset: 0x0005DAB3
		private static Delegate GetLastHandler()
		{
			if (ISortedSetInvoker.cb_last == null)
			{
				ISortedSetInvoker.cb_last = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISortedSetInvoker.n_Last));
			}
			return ISortedSetInvoker.cb_last;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0005F8D7 File Offset: 0x0005DAD7
		private static IntPtr n_Last(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISortedSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Last());
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0005F8EC File Offset: 0x0005DAEC
		public Java.Lang.Object Last()
		{
			if (this.id_last == IntPtr.Zero)
			{
				this.id_last = JNIEnv.GetMethodID(this.class_ref, "last", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_last), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0005F93D File Offset: 0x0005DB3D
		private static Delegate GetSubSet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (ISortedSetInvoker.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				ISortedSetInvoker.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ISortedSetInvoker.n_SubSet_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return ISortedSetInvoker.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0005F964 File Offset: 0x0005DB64
		private static IntPtr n_SubSet_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement, IntPtr native_toElement)
		{
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SubSet(object2, object3));
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0005F998 File Offset: 0x0005DB98
		public unsafe ISortedSet SubSet(Java.Lang.Object fromElement, Java.Lang.Object toElement)
		{
			if (this.id_subSet_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_subSet_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(toElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_subSet_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0005FA2F File Offset: 0x0005DC2F
		private static Delegate GetTailSet_Ljava_lang_Object_Handler()
		{
			if (ISortedSetInvoker.cb_tailSet_Ljava_lang_Object_ == null)
			{
				ISortedSetInvoker.cb_tailSet_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISortedSetInvoker.n_TailSet_Ljava_lang_Object_));
			}
			return ISortedSetInvoker.cb_tailSet_Ljava_lang_Object_;
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x0005FA54 File Offset: 0x0005DC54
		private static IntPtr n_TailSet_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement)
		{
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TailSet(object2));
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0005FA7C File Offset: 0x0005DC7C
		public unsafe ISortedSet TailSet(Java.Lang.Object fromElement)
		{
			if (this.id_tailSet_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_tailSet_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_tailSet_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x0005FAF3 File Offset: 0x0005DCF3
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

		// Token: 0x060021E8 RID: 8680 RVA: 0x0005FB34 File Offset: 0x0005DD34
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

		// Token: 0x060021E9 RID: 8681 RVA: 0x0005FBA8 File Offset: 0x0005DDA8
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

		// Token: 0x060021EA RID: 8682 RVA: 0x0005FC19 File Offset: 0x0005DE19
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0005FC5C File Offset: 0x0005DE5C
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

		// Token: 0x060021EC RID: 8684 RVA: 0x0005FCD0 File Offset: 0x0005DED0
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

		// Token: 0x060021ED RID: 8685 RVA: 0x0005FD44 File Offset: 0x0005DF44
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

		// Token: 0x060021EE RID: 8686 RVA: 0x0005FDB7 File Offset: 0x0005DFB7
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0005FDF8 File Offset: 0x0005DFF8
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0005FE4C File Offset: 0x0005E04C
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

		// Token: 0x060021F1 RID: 8689 RVA: 0x0005FEC0 File Offset: 0x0005E0C0
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

		// Token: 0x060021F2 RID: 8690 RVA: 0x0005FF34 File Offset: 0x0005E134
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

		// Token: 0x060021F3 RID: 8691 RVA: 0x0005FFA5 File Offset: 0x0005E1A5
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0005FFE8 File Offset: 0x0005E1E8
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00060048 File Offset: 0x0005E248
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

		// Token: 0x04000DEB RID: 3563
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/SortedSet", typeof(ISortedSetInvoker));

		// Token: 0x04000DEC RID: 3564
		private IntPtr class_ref;

		// Token: 0x04000DED RID: 3565
		private static Delegate cb_comparator;

		// Token: 0x04000DEE RID: 3566
		private IntPtr id_comparator;

		// Token: 0x04000DEF RID: 3567
		private static Delegate cb_first;

		// Token: 0x04000DF0 RID: 3568
		private IntPtr id_first;

		// Token: 0x04000DF1 RID: 3569
		private static Delegate cb_headSet_Ljava_lang_Object_;

		// Token: 0x04000DF2 RID: 3570
		private IntPtr id_headSet_Ljava_lang_Object_;

		// Token: 0x04000DF3 RID: 3571
		private static Delegate cb_last;

		// Token: 0x04000DF4 RID: 3572
		private IntPtr id_last;

		// Token: 0x04000DF5 RID: 3573
		private static Delegate cb_subSet_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000DF6 RID: 3574
		private IntPtr id_subSet_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000DF7 RID: 3575
		private static Delegate cb_tailSet_Ljava_lang_Object_;

		// Token: 0x04000DF8 RID: 3576
		private IntPtr id_tailSet_Ljava_lang_Object_;

		// Token: 0x04000DF9 RID: 3577
		private IntPtr id_isEmpty;

		// Token: 0x04000DFA RID: 3578
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000DFB RID: 3579
		private IntPtr id_addAll_Ljava_util_Collection_;

		// Token: 0x04000DFC RID: 3580
		private IntPtr id_clear;

		// Token: 0x04000DFD RID: 3581
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000DFE RID: 3582
		private IntPtr id_containsAll_Ljava_util_Collection_;

		// Token: 0x04000DFF RID: 3583
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000E00 RID: 3584
		private IntPtr id_hashCode;

		// Token: 0x04000E01 RID: 3585
		private IntPtr id_iterator;

		// Token: 0x04000E02 RID: 3586
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000E03 RID: 3587
		private IntPtr id_removeAll_Ljava_util_Collection_;

		// Token: 0x04000E04 RID: 3588
		private IntPtr id_retainAll_Ljava_util_Collection_;

		// Token: 0x04000E05 RID: 3589
		private IntPtr id_size;

		// Token: 0x04000E06 RID: 3590
		private IntPtr id_toArray;

		// Token: 0x04000E07 RID: 3591
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
