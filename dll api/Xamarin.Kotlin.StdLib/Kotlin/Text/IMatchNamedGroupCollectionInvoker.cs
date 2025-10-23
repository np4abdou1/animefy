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
	// Token: 0x020000E3 RID: 227
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/MatchNamedGroupCollection", DoNotGenerateAcw = true)]
	internal class IMatchNamedGroupCollectionInvoker : Java.Lang.Object, IMatchNamedGroupCollection, IMatchGroupCollection, Java.Util.ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00013000 File Offset: 0x00011200
		private static IntPtr java_class_ref
		{
			get
			{
				return IMatchNamedGroupCollectionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00013024 File Offset: 0x00011224
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMatchNamedGroupCollectionInvoker._members;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0001302B File Offset: 0x0001122B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00013033 File Offset: 0x00011233
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMatchNamedGroupCollectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0001303F File Offset: 0x0001123F
		[NullableContext(2)]
		public static IMatchNamedGroupCollection GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(handle, transfer);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00013048 File Offset: 0x00011248
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMatchNamedGroupCollectionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.text.MatchNamedGroupCollection'.");
			}
			return handle;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00013073 File Offset: 0x00011273
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000130A4 File Offset: 0x000112A4
		public IMatchNamedGroupCollectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMatchNamedGroupCollectionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000130DC File Offset: 0x000112DC
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_get_Ljava_lang_String_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMatchNamedGroupCollectionInvoker.n_Get_Ljava_lang_String_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_get_Ljava_lang_String_;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00013100 File Offset: 0x00011300
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			IMatchNamedGroupCollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00013128 File Offset: 0x00011328
		[return: Nullable(2)]
		public unsafe MatchGroup Get(string name)
		{
			if (this.id_get_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/String;)Lkotlin/text/MatchGroup;");
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			MatchGroup @object = Java.Lang.Object.GetObject<MatchGroup>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001319F File Offset: 0x0001139F
		private static Delegate GetGet_IHandler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_get_I == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_get_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMatchNamedGroupCollectionInvoker.n_Get_I));
			}
			return IMatchNamedGroupCollectionInvoker.cb_get_I;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000131C3 File Offset: 0x000113C3
		private static IntPtr n_Get_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get(index));
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000131D8 File Offset: 0x000113D8
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

		// Token: 0x06000766 RID: 1894 RVA: 0x00013242 File Offset: 0x00011442
		private static Delegate GetIsEmptyHandler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_isEmpty == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMatchNamedGroupCollectionInvoker.n_IsEmpty));
			}
			return IMatchNamedGroupCollectionInvoker.cb_isEmpty;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00013266 File Offset: 0x00011466
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00013275 File Offset: 0x00011475
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

		// Token: 0x06000769 RID: 1897 RVA: 0x000132B5 File Offset: 0x000114B5
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_Add_Ljava_lang_Object_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000132DC File Offset: 0x000114DC
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00013300 File Offset: 0x00011500
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

		// Token: 0x0600076C RID: 1900 RVA: 0x00013373 File Offset: 0x00011573
		private static Delegate GetAddAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_addAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_addAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_AddAll_LSystem_Collections_ICollection_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_addAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00013398 File Offset: 0x00011598
		private static bool n_AddAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(c);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000133BC File Offset: 0x000115BC
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

		// Token: 0x0600076F RID: 1903 RVA: 0x0001342D File Offset: 0x0001162D
		private static Delegate GetClearHandler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_clear == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMatchNamedGroupCollectionInvoker.n_Clear));
			}
			return IMatchNamedGroupCollectionInvoker.cb_clear;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00013451 File Offset: 0x00011651
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00013460 File Offset: 0x00011660
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000134A0 File Offset: 0x000116A0
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_contains_Ljava_lang_Object_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_Contains_Ljava_lang_Object_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000134C4 File Offset: 0x000116C4
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000134E8 File Offset: 0x000116E8
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

		// Token: 0x06000775 RID: 1909 RVA: 0x0001355B File Offset: 0x0001175B
		private static Delegate GetContainsAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_containsAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_containsAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_ContainsAll_LSystem_Collections_ICollection_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_containsAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00013580 File Offset: 0x00011780
		private static bool n_ContainsAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(c);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000135A4 File Offset: 0x000117A4
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

		// Token: 0x06000778 RID: 1912 RVA: 0x00013615 File Offset: 0x00011815
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001363C File Offset: 0x0001183C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00013660 File Offset: 0x00011860
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

		// Token: 0x0600077B RID: 1915 RVA: 0x000136D3 File Offset: 0x000118D3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_hashCode == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMatchNamedGroupCollectionInvoker.n_GetHashCode));
			}
			return IMatchNamedGroupCollectionInvoker.cb_hashCode;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000136F7 File Offset: 0x000118F7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00013706 File Offset: 0x00011906
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00013746 File Offset: 0x00011946
		private static Delegate GetIteratorHandler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_iterator == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchNamedGroupCollectionInvoker.n_Iterator));
			}
			return IMatchNamedGroupCollectionInvoker.cb_iterator;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001376A File Offset: 0x0001196A
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00013780 File Offset: 0x00011980
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000137D1 File Offset: 0x000119D1
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_Remove_Ljava_lang_Object_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000137F8 File Offset: 0x000119F8
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001381C File Offset: 0x00011A1C
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

		// Token: 0x06000784 RID: 1924 RVA: 0x0001388F File Offset: 0x00011A8F
		private static Delegate GetRemoveAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_removeAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_removeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_RemoveAll_LSystem_Collections_ICollection_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_removeAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000138B4 File Offset: 0x00011AB4
		private static bool n_RemoveAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(c);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000138D8 File Offset: 0x00011AD8
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

		// Token: 0x06000787 RID: 1927 RVA: 0x00013949 File Offset: 0x00011B49
		private static Delegate GetRetainAll_LSystem_Collections_ICollection_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_retainAll_LSystem_Collections_ICollection_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_retainAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMatchNamedGroupCollectionInvoker.n_RetainAll_LSystem_Collections_ICollection_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_retainAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00013970 File Offset: 0x00011B70
		private static bool n_RetainAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(c);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00013994 File Offset: 0x00011B94
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

		// Token: 0x0600078A RID: 1930 RVA: 0x00013A05 File Offset: 0x00011C05
		private static Delegate GetSizeHandler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_size == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMatchNamedGroupCollectionInvoker.n_Size));
			}
			return IMatchNamedGroupCollectionInvoker.cb_size;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00013A29 File Offset: 0x00011C29
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00013A38 File Offset: 0x00011C38
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00013A78 File Offset: 0x00011C78
		private static Delegate GetToArrayHandler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_toArray == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchNamedGroupCollectionInvoker.n_ToArray));
			}
			return IMatchNamedGroupCollectionInvoker.cb_toArray;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00013A9C File Offset: 0x00011C9C
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00013AB0 File Offset: 0x00011CB0
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00013B10 File Offset: 0x00011D10
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (IMatchNamedGroupCollectionInvoker.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				IMatchNamedGroupCollectionInvoker.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMatchNamedGroupCollectionInvoker.n_ToArray_arrayLjava_lang_Object_));
			}
			return IMatchNamedGroupCollectionInvoker.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00013B34 File Offset: 0x00011D34
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			Java.Util.ICollection @object = Java.Lang.Object.GetObject<IMatchNamedGroupCollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00013B78 File Offset: 0x00011D78
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

		// Token: 0x040001F3 RID: 499
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/MatchNamedGroupCollection", typeof(IMatchNamedGroupCollectionInvoker));

		// Token: 0x040001F4 RID: 500
		private IntPtr class_ref;

		// Token: 0x040001F5 RID: 501
		[Nullable(2)]
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x040001F6 RID: 502
		private IntPtr id_get_Ljava_lang_String_;

		// Token: 0x040001F7 RID: 503
		[Nullable(2)]
		private static Delegate cb_get_I;

		// Token: 0x040001F8 RID: 504
		private IntPtr id_get_I;

		// Token: 0x040001F9 RID: 505
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x040001FA RID: 506
		private IntPtr id_isEmpty;

		// Token: 0x040001FB RID: 507
		[Nullable(2)]
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x040001FC RID: 508
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x040001FD RID: 509
		[Nullable(2)]
		private static Delegate cb_addAll_LSystem_Collections_ICollection_;

		// Token: 0x040001FE RID: 510
		private IntPtr id_addAll_LSystem_Collections_ICollection_;

		// Token: 0x040001FF RID: 511
		[Nullable(2)]
		private static Delegate cb_clear;

		// Token: 0x04000200 RID: 512
		private IntPtr id_clear;

		// Token: 0x04000201 RID: 513
		[Nullable(2)]
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x04000202 RID: 514
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000203 RID: 515
		[Nullable(2)]
		private static Delegate cb_containsAll_LSystem_Collections_ICollection_;

		// Token: 0x04000204 RID: 516
		private IntPtr id_containsAll_LSystem_Collections_ICollection_;

		// Token: 0x04000205 RID: 517
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000206 RID: 518
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000207 RID: 519
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000208 RID: 520
		private IntPtr id_hashCode;

		// Token: 0x04000209 RID: 521
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x0400020A RID: 522
		private IntPtr id_iterator;

		// Token: 0x0400020B RID: 523
		[Nullable(2)]
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x0400020C RID: 524
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x0400020D RID: 525
		[Nullable(2)]
		private static Delegate cb_removeAll_LSystem_Collections_ICollection_;

		// Token: 0x0400020E RID: 526
		private IntPtr id_removeAll_LSystem_Collections_ICollection_;

		// Token: 0x0400020F RID: 527
		[Nullable(2)]
		private static Delegate cb_retainAll_LSystem_Collections_ICollection_;

		// Token: 0x04000210 RID: 528
		private IntPtr id_retainAll_LSystem_Collections_ICollection_;

		// Token: 0x04000211 RID: 529
		[Nullable(2)]
		private static Delegate cb_size;

		// Token: 0x04000212 RID: 530
		private IntPtr id_size;

		// Token: 0x04000213 RID: 531
		[Nullable(2)]
		private static Delegate cb_toArray;

		// Token: 0x04000214 RID: 532
		private IntPtr id_toArray;

		// Token: 0x04000215 RID: 533
		[Nullable(2)]
		private static Delegate cb_toArray_arrayLjava_lang_Object_;

		// Token: 0x04000216 RID: 534
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
