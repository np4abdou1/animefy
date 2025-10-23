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

namespace Kotlin.Text
{
	// Token: 0x020000E1 RID: 225
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/MatchGroupCollection", DoNotGenerateAcw = true)]
	internal class IMatchGroupCollectionInvoker : Java.Lang.Object, IMatchGroupCollection, Java.Util.ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0001249C File Offset: 0x0001069C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMatchGroupCollectionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x000124C0 File Offset: 0x000106C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMatchGroupCollectionInvoker._members;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x000124C7 File Offset: 0x000106C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x000124CF File Offset: 0x000106CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMatchGroupCollectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000124DB File Offset: 0x000106DB
		[NullableContext(2)]
		public static IMatchGroupCollection GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMatchGroupCollection>(handle, transfer);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000124E4 File Offset: 0x000106E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMatchGroupCollectionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.text.MatchGroupCollection'.");
			}
			return handle;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001250F File Offset: 0x0001070F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00012540 File Offset: 0x00010740
		public IMatchGroupCollectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMatchGroupCollectionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00012578 File Offset: 0x00010778
		private static Delegate GetGet_IHandler()
		{
			if (IMatchGroupCollectionInvoker.cb_get_I == null)
			{
				IMatchGroupCollectionInvoker.cb_get_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMatchGroupCollectionInvoker.n_Get_I));
			}
			return IMatchGroupCollectionInvoker.cb_get_I;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001259C File Offset: 0x0001079C
		private static IntPtr n_Get_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get(index));
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000125B4 File Offset: 0x000107B4
		[NullableContext(2)]
		public unsafe MatchGroup Get(int index)
		{
			if (this.id_get_I == IntPtr.Zero)
			{
				this.id_get_I = JNIEnv.GetMethodID(this.class_ref, "get", "(I)Lkotlin/text/MatchGroup;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return Java.Lang.Object.GetObject<MatchGroup>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001261E File Offset: 0x0001081E
		private static Delegate GetIsEmptyHandler()
		{
			if (IMatchGroupCollectionInvoker.cb_isEmpty == null)
			{
				IMatchGroupCollectionInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMatchGroupCollectionInvoker.n_IsEmpty));
			}
			return IMatchGroupCollectionInvoker.cb_isEmpty;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00012642 File Offset: 0x00010842
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00012651 File Offset: 0x00010851
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

		// Token: 0x0600072C RID: 1836 RVA: 0x00012691 File Offset: 0x00010891
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				IMatchGroupCollectionInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_Add_Ljava_lang_Object_));
			}
			return IMatchGroupCollectionInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000126B8 File Offset: 0x000108B8
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000126DC File Offset: 0x000108DC
		[NullableContext(2)]
		public unsafe bool Add(Java.Lang.Object e)
		{
			if (this.id_add_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "add", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_add_Ljava_lang_Object_, ptr);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001274F File Offset: 0x0001094F
		private static Delegate GetAddAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_addAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchGroupCollectionInvoker.cb_addAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_AddAll_LSystem_Collections_ICollection_));
			}
			return IMatchGroupCollectionInvoker.cb_addAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00012774 File Offset: 0x00010974
		private static bool n_AddAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(c);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00012798 File Offset: 0x00010998
		public unsafe bool AddAll(System.Collections.ICollection c)
		{
			if (this.id_addAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
			{
				this.id_addAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(this.class_ref, "addAll", "(LSystem/Collections/ICollection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_addAll_LSystem_Collections_ICollection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00012809 File Offset: 0x00010A09
		private static Delegate GetClearHandler()
		{
			if (IMatchGroupCollectionInvoker.cb_clear == null)
			{
				IMatchGroupCollectionInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMatchGroupCollectionInvoker.n_Clear));
			}
			return IMatchGroupCollectionInvoker.cb_clear;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001282D File Offset: 0x00010A2D
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001283C File Offset: 0x00010A3C
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001287C File Offset: 0x00010A7C
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_contains_Ljava_lang_Object_ == null)
			{
				IMatchGroupCollectionInvoker.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_Contains_Ljava_lang_Object_));
			}
			return IMatchGroupCollectionInvoker.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000128A0 File Offset: 0x00010AA0
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000128C4 File Offset: 0x00010AC4
		[NullableContext(2)]
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

		// Token: 0x06000738 RID: 1848 RVA: 0x00012937 File Offset: 0x00010B37
		private static Delegate GetContainsAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_containsAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchGroupCollectionInvoker.cb_containsAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_ContainsAll_LSystem_Collections_ICollection_));
			}
			return IMatchGroupCollectionInvoker.cb_containsAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001295C File Offset: 0x00010B5C
		private static bool n_ContainsAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(c);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00012980 File Offset: 0x00010B80
		public unsafe bool ContainsAll(System.Collections.ICollection c)
		{
			if (this.id_containsAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
			{
				this.id_containsAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(this.class_ref, "containsAll", "(LSystem/Collections/ICollection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_containsAll_LSystem_Collections_ICollection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000129F1 File Offset: 0x00010BF1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMatchGroupCollectionInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMatchGroupCollectionInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00012A18 File Offset: 0x00010C18
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00012A3C File Offset: 0x00010C3C
		[NullableContext(2)]
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

		// Token: 0x0600073E RID: 1854 RVA: 0x00012AAF File Offset: 0x00010CAF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMatchGroupCollectionInvoker.cb_hashCode == null)
			{
				IMatchGroupCollectionInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMatchGroupCollectionInvoker.n_GetHashCode));
			}
			return IMatchGroupCollectionInvoker.cb_hashCode;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00012AD3 File Offset: 0x00010CD3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00012AE2 File Offset: 0x00010CE2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00012B22 File Offset: 0x00010D22
		private static Delegate GetIteratorHandler()
		{
			if (IMatchGroupCollectionInvoker.cb_iterator == null)
			{
				IMatchGroupCollectionInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchGroupCollectionInvoker.n_Iterator));
			}
			return IMatchGroupCollectionInvoker.cb_iterator;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00012B46 File Offset: 0x00010D46
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00012B5C File Offset: 0x00010D5C
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00012BAD File Offset: 0x00010DAD
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				IMatchGroupCollectionInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_Remove_Ljava_lang_Object_));
			}
			return IMatchGroupCollectionInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00012BD4 File Offset: 0x00010DD4
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00012BF8 File Offset: 0x00010DF8
		[NullableContext(2)]
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

		// Token: 0x06000747 RID: 1863 RVA: 0x00012C6B File Offset: 0x00010E6B
		private static Delegate GetRemoveAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_removeAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchGroupCollectionInvoker.cb_removeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_RemoveAll_LSystem_Collections_ICollection_));
			}
			return IMatchGroupCollectionInvoker.cb_removeAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00012C90 File Offset: 0x00010E90
		private static bool n_RemoveAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(c);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00012CB4 File Offset: 0x00010EB4
		public unsafe bool RemoveAll(System.Collections.ICollection c)
		{
			if (this.id_removeAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
			{
				this.id_removeAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(this.class_ref, "removeAll", "(LSystem/Collections/ICollection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_removeAll_LSystem_Collections_ICollection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00012D25 File Offset: 0x00010F25
		private static Delegate GetRetainAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_retainAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchGroupCollectionInvoker.cb_retainAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchGroupCollectionInvoker.n_RetainAll_LSystem_Collections_ICollection_));
			}
			return IMatchGroupCollectionInvoker.cb_retainAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00012D4C File Offset: 0x00010F4C
		private static bool n_RetainAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(c);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00012D70 File Offset: 0x00010F70
		public unsafe bool RetainAll(System.Collections.ICollection c)
		{
			if (this.id_retainAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
			{
				this.id_retainAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(this.class_ref, "retainAll", "(LSystem/Collections/ICollection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_retainAll_LSystem_Collections_ICollection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00012DE1 File Offset: 0x00010FE1
		private static Delegate GetSizeHandler()
		{
			if (IMatchGroupCollectionInvoker.cb_size == null)
			{
				IMatchGroupCollectionInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMatchGroupCollectionInvoker.n_Size));
			}
			return IMatchGroupCollectionInvoker.cb_size;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00012E05 File Offset: 0x00011005
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00012E14 File Offset: 0x00011014
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00012E54 File Offset: 0x00011054
		private static Delegate GetToArrayHandler()
		{
			if (IMatchGroupCollectionInvoker.cb_toArray == null)
			{
				IMatchGroupCollectionInvoker.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchGroupCollectionInvoker.n_ToArray));
			}
			return IMatchGroupCollectionInvoker.cb_toArray;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00012E78 File Offset: 0x00011078
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00012E8C File Offset: 0x0001108C
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00012EEC File Offset: 0x000110EC
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (IMatchGroupCollectionInvoker.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				IMatchGroupCollectionInvoker.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMatchGroupCollectionInvoker.n_ToArray_arrayLjava_lang_Object_));
			}
			return IMatchGroupCollectionInvoker.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00012F10 File Offset: 0x00011110
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00012F54 File Offset: 0x00011154
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

		// Token: 0x040001D1 RID: 465
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/MatchGroupCollection", typeof(IMatchGroupCollectionInvoker));

		// Token: 0x040001D2 RID: 466
		private IntPtr class_ref;

		// Token: 0x040001D3 RID: 467
		[Nullable(2)]
		private static Delegate cb_get_I;

		// Token: 0x040001D4 RID: 468
		private IntPtr id_get_I;

		// Token: 0x040001D5 RID: 469
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x040001D6 RID: 470
		private IntPtr id_isEmpty;

		// Token: 0x040001D7 RID: 471
		[Nullable(2)]
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x040001D8 RID: 472
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x040001D9 RID: 473
		[Nullable(2)]
		private static Delegate cb_addAll_LSystem_Collections_ICollection_;

		// Token: 0x040001DA RID: 474
		private IntPtr id_addAll_LSystem_Collections_ICollection_;

		// Token: 0x040001DB RID: 475
		[Nullable(2)]
		private static Delegate cb_clear;

		// Token: 0x040001DC RID: 476
		private IntPtr id_clear;

		// Token: 0x040001DD RID: 477
		[Nullable(2)]
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x040001DE RID: 478
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x040001DF RID: 479
		[Nullable(2)]
		private static Delegate cb_containsAll_LSystem_Collections_ICollection_;

		// Token: 0x040001E0 RID: 480
		private IntPtr id_containsAll_LSystem_Collections_ICollection_;

		// Token: 0x040001E1 RID: 481
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001E2 RID: 482
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001E3 RID: 483
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040001E4 RID: 484
		private IntPtr id_hashCode;

		// Token: 0x040001E5 RID: 485
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x040001E6 RID: 486
		private IntPtr id_iterator;

		// Token: 0x040001E7 RID: 487
		[Nullable(2)]
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x040001E8 RID: 488
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x040001E9 RID: 489
		[Nullable(2)]
		private static Delegate cb_removeAll_LSystem_Collections_ICollection_;

		// Token: 0x040001EA RID: 490
		private IntPtr id_removeAll_LSystem_Collections_ICollection_;

		// Token: 0x040001EB RID: 491
		[Nullable(2)]
		private static Delegate cb_retainAll_LSystem_Collections_ICollection_;

		// Token: 0x040001EC RID: 492
		private IntPtr id_retainAll_LSystem_Collections_ICollection_;

		// Token: 0x040001ED RID: 493
		[Nullable(2)]
		private static Delegate cb_size;

		// Token: 0x040001EE RID: 494
		private IntPtr id_size;

		// Token: 0x040001EF RID: 495
		[Nullable(2)]
		private static Delegate cb_toArray;

		// Token: 0x040001F0 RID: 496
		private IntPtr id_toArray;

		// Token: 0x040001F1 RID: 497
		[Nullable(2)]
		private static Delegate cb_toArray_arrayLjava_lang_Object_;

		// Token: 0x040001F2 RID: 498
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
