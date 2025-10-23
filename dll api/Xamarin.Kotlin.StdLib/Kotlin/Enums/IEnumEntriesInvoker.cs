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

namespace Kotlin.Enums
{
	// Token: 0x0200024B RID: 587
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/enums/EnumEntries", DoNotGenerateAcw = true)]
	internal class IEnumEntriesInvoker : Java.Lang.Object, IEnumEntries, Java.Util.IList, Java.Util.ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00059CCC File Offset: 0x00057ECC
		private static IntPtr java_class_ref
		{
			get
			{
				return IEnumEntriesInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x00059CF0 File Offset: 0x00057EF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEnumEntriesInvoker._members;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00059CF7 File Offset: 0x00057EF7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00059CFF File Offset: 0x00057EFF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEnumEntriesInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00059D0B File Offset: 0x00057F0B
		[NullableContext(2)]
		public static IEnumEntries GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IEnumEntries>(handle, transfer);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00059D14 File Offset: 0x00057F14
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEnumEntriesInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.enums.EnumEntries'.");
			}
			return handle;
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00059D3F File Offset: 0x00057F3F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00059D70 File Offset: 0x00057F70
		public IEnumEntriesInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEnumEntriesInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00059DA8 File Offset: 0x00057FA8
		private static Delegate GetIsEmptyHandler()
		{
			if (IEnumEntriesInvoker.cb_isEmpty == null)
			{
				IEnumEntriesInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IEnumEntriesInvoker.n_IsEmpty));
			}
			return IEnumEntriesInvoker.cb_isEmpty;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00059DCC File Offset: 0x00057FCC
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00059DDB File Offset: 0x00057FDB
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

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00059E1B File Offset: 0x0005801B
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_Add_Ljava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00059E40 File Offset: 0x00058040
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00059E64 File Offset: 0x00058064
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

		// Token: 0x06001ADB RID: 6875 RVA: 0x00059ED7 File Offset: 0x000580D7
		private static Delegate GetAdd_ILjava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_add_ILjava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IEnumEntriesInvoker.n_Add_ILjava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_add_ILjava_lang_Object_;
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00059EFC File Offset: 0x000580FC
		private static void n_Add_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			@object.Add(index, object2);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00059F20 File Offset: 0x00058120
		[NullableContext(2)]
		public unsafe void Add(int index, Java.Lang.Object element)
		{
			if (this.id_add_ILjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "add", "(ILjava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue((element == null) ? IntPtr.Zero : element.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_add_ILjava_lang_Object_, ptr);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00059FA6 File Offset: 0x000581A6
		private static Delegate GetAddAll_ILSystem_Collections_ICollection_Handler()
		{
			if (IEnumEntriesInvoker.cb_addAll_ILSystem_Collections_ICollection_ == null)
			{
				IEnumEntriesInvoker.cb_addAll_ILSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(IEnumEntriesInvoker.n_AddAll_ILSystem_Collections_ICollection_));
			}
			return IEnumEntriesInvoker.cb_addAll_ILSystem_Collections_ICollection_;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00059FCC File Offset: 0x000581CC
		private static bool n_AddAll_ILSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_c)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(index, c);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00059FF0 File Offset: 0x000581F0
		public unsafe bool AddAll(int index, System.Collections.ICollection c)
		{
			if (this.id_addAll_ILSystem_Collections_ICollection_ == IntPtr.Zero)
			{
				this.id_addAll_ILSystem_Collections_ICollection_ = JNIEnv.GetMethodID(this.class_ref, "addAll", "(ILSystem/Collections/ICollection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_addAll_ILSystem_Collections_ICollection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0005A074 File Offset: 0x00058274
		private static Delegate GetAddAll_LSystem_Collections_ICollection_Handler()
		{
			if (IEnumEntriesInvoker.cb_addAll_LSystem_Collections_ICollection_ == null)
			{
				IEnumEntriesInvoker.cb_addAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_AddAll_LSystem_Collections_ICollection_));
			}
			return IEnumEntriesInvoker.cb_addAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0005A098 File Offset: 0x00058298
		private static bool n_AddAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.AddAll(c);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0005A0BC File Offset: 0x000582BC
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

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0005A12D File Offset: 0x0005832D
		private static Delegate GetClearHandler()
		{
			if (IEnumEntriesInvoker.cb_clear == null)
			{
				IEnumEntriesInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IEnumEntriesInvoker.n_Clear));
			}
			return IEnumEntriesInvoker.cb_clear;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0005A151 File Offset: 0x00058351
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0005A160 File Offset: 0x00058360
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0005A1A0 File Offset: 0x000583A0
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_contains_Ljava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_Contains_Ljava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0005A1C4 File Offset: 0x000583C4
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0005A1E8 File Offset: 0x000583E8
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

		// Token: 0x06001AEA RID: 6890 RVA: 0x0005A25B File Offset: 0x0005845B
		private static Delegate GetContainsAll_LSystem_Collections_ICollection_Handler()
		{
			if (IEnumEntriesInvoker.cb_containsAll_LSystem_Collections_ICollection_ == null)
			{
				IEnumEntriesInvoker.cb_containsAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_ContainsAll_LSystem_Collections_ICollection_));
			}
			return IEnumEntriesInvoker.cb_containsAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0005A280 File Offset: 0x00058480
		private static bool n_ContainsAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(c);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0005A2A4 File Offset: 0x000584A4
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

		// Token: 0x06001AED RID: 6893 RVA: 0x0005A315 File Offset: 0x00058515
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0005A33C File Offset: 0x0005853C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0005A360 File Offset: 0x00058560
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

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0005A3D3 File Offset: 0x000585D3
		private static Delegate GetGet_IHandler()
		{
			if (IEnumEntriesInvoker.cb_get_I == null)
			{
				IEnumEntriesInvoker.cb_get_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IEnumEntriesInvoker.n_Get_I));
			}
			return IEnumEntriesInvoker.cb_get_I;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0005A3F7 File Offset: 0x000585F7
		private static IntPtr n_Get_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get(index));
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0005A40C File Offset: 0x0005860C
		[NullableContext(2)]
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

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0005A476 File Offset: 0x00058676
		private static Delegate GetGetHashCodeHandler()
		{
			if (IEnumEntriesInvoker.cb_hashCode == null)
			{
				IEnumEntriesInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IEnumEntriesInvoker.n_GetHashCode));
			}
			return IEnumEntriesInvoker.cb_hashCode;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0005A49A File Offset: 0x0005869A
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0005A4A9 File Offset: 0x000586A9
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0005A4E9 File Offset: 0x000586E9
		private static Delegate GetIndexOf_Ljava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_indexOf_Ljava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_indexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IEnumEntriesInvoker.n_IndexOf_Ljava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_indexOf_Ljava_lang_Object_;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0005A510 File Offset: 0x00058710
		private static int n_IndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.IndexOf(object2);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0005A534 File Offset: 0x00058734
		[NullableContext(2)]
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

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0005A5A7 File Offset: 0x000587A7
		private static Delegate GetIteratorHandler()
		{
			if (IEnumEntriesInvoker.cb_iterator == null)
			{
				IEnumEntriesInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEnumEntriesInvoker.n_Iterator));
			}
			return IEnumEntriesInvoker.cb_iterator;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0005A5CB File Offset: 0x000587CB
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0005A5E0 File Offset: 0x000587E0
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0005A631 File Offset: 0x00058831
		private static Delegate GetLastIndexOf_Ljava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_lastIndexOf_Ljava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_lastIndexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IEnumEntriesInvoker.n_LastIndexOf_Ljava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_lastIndexOf_Ljava_lang_Object_;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0005A658 File Offset: 0x00058858
		private static int n_LastIndexOf_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.LastIndexOf(object2);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0005A67C File Offset: 0x0005887C
		[NullableContext(2)]
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

		// Token: 0x06001AFF RID: 6911 RVA: 0x0005A6EF File Offset: 0x000588EF
		private static Delegate GetListIteratorHandler()
		{
			if (IEnumEntriesInvoker.cb_listIterator == null)
			{
				IEnumEntriesInvoker.cb_listIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEnumEntriesInvoker.n_ListIterator));
			}
			return IEnumEntriesInvoker.cb_listIterator;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0005A713 File Offset: 0x00058913
		private static IntPtr n_ListIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator());
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0005A728 File Offset: 0x00058928
		public IListIterator ListIterator()
		{
			if (this.id_listIterator == IntPtr.Zero)
			{
				this.id_listIterator = JNIEnv.GetMethodID(this.class_ref, "listIterator", "()Ljava/util/ListIterator;");
			}
			return Java.Lang.Object.GetObject<IListIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_listIterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0005A779 File Offset: 0x00058979
		private static Delegate GetListIterator_IHandler()
		{
			if (IEnumEntriesInvoker.cb_listIterator_I == null)
			{
				IEnumEntriesInvoker.cb_listIterator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IEnumEntriesInvoker.n_ListIterator_I));
			}
			return IEnumEntriesInvoker.cb_listIterator_I;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0005A79D File Offset: 0x0005899D
		private static IntPtr n_ListIterator_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListIterator(index));
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0005A7B4 File Offset: 0x000589B4
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

		// Token: 0x06001B05 RID: 6917 RVA: 0x0005A81E File Offset: 0x00058A1E
		private static Delegate GetRemove_IHandler()
		{
			if (IEnumEntriesInvoker.cb_remove_I == null)
			{
				IEnumEntriesInvoker.cb_remove_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IEnumEntriesInvoker.n_Remove_I));
			}
			return IEnumEntriesInvoker.cb_remove_I;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0005A842 File Offset: 0x00058A42
		private static IntPtr n_Remove_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove(index));
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0005A858 File Offset: 0x00058A58
		[NullableContext(2)]
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

		// Token: 0x06001B08 RID: 6920 RVA: 0x0005A8C2 File Offset: 0x00058AC2
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_Remove_Ljava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0005A90C File Offset: 0x00058B0C
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

		// Token: 0x06001B0B RID: 6923 RVA: 0x0005A97F File Offset: 0x00058B7F
		private static Delegate GetRemoveAll_LSystem_Collections_ICollection_Handler()
		{
			if (IEnumEntriesInvoker.cb_removeAll_LSystem_Collections_ICollection_ == null)
			{
				IEnumEntriesInvoker.cb_removeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_RemoveAll_LSystem_Collections_ICollection_));
			}
			return IEnumEntriesInvoker.cb_removeAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0005A9A4 File Offset: 0x00058BA4
		private static bool n_RemoveAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(c);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0005A9C8 File Offset: 0x00058BC8
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

		// Token: 0x06001B0E RID: 6926 RVA: 0x0005AA39 File Offset: 0x00058C39
		private static Delegate GetRetainAll_LSystem_Collections_ICollection_Handler()
		{
			if (IEnumEntriesInvoker.cb_retainAll_LSystem_Collections_ICollection_ == null)
			{
				IEnumEntriesInvoker.cb_retainAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IEnumEntriesInvoker.n_RetainAll_LSystem_Collections_ICollection_));
			}
			return IEnumEntriesInvoker.cb_retainAll_LSystem_Collections_ICollection_;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0005AA60 File Offset: 0x00058C60
		private static bool n_RetainAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(c);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0005AA84 File Offset: 0x00058C84
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

		// Token: 0x06001B11 RID: 6929 RVA: 0x0005AAF5 File Offset: 0x00058CF5
		private static Delegate GetSet_ILjava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_set_ILjava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(IEnumEntriesInvoker.n_Set_ILjava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_set_ILjava_lang_Object_;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0005AB1C File Offset: 0x00058D1C
		private static IntPtr n_Set_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_element, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Set(index, object2));
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0005AB48 File Offset: 0x00058D48
		[NullableContext(2)]
		public unsafe Java.Lang.Object Set(int index, Java.Lang.Object element)
		{
			if (this.id_set_ILjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_set_ILjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			ptr[1] = new JValue((element == null) ? IntPtr.Zero : element.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_set_ILjava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0005ABD4 File Offset: 0x00058DD4
		private static Delegate GetSizeHandler()
		{
			if (IEnumEntriesInvoker.cb_size == null)
			{
				IEnumEntriesInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IEnumEntriesInvoker.n_Size));
			}
			return IEnumEntriesInvoker.cb_size;
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0005ABF8 File Offset: 0x00058DF8
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0005AC07 File Offset: 0x00058E07
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0005AC47 File Offset: 0x00058E47
		private static Delegate GetSubList_IIHandler()
		{
			if (IEnumEntriesInvoker.cb_subList_II == null)
			{
				IEnumEntriesInvoker.cb_subList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(IEnumEntriesInvoker.n_SubList_II));
			}
			return IEnumEntriesInvoker.cb_subList_II;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0005AC6B File Offset: 0x00058E6B
		private static IntPtr n_SubList_II(IntPtr jnienv, IntPtr native__this, int fromIndex, int toIndex)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubList(fromIndex, toIndex));
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0005AC84 File Offset: 0x00058E84
		public unsafe System.Collections.IList SubList(int fromIndex, int toIndex)
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

		// Token: 0x06001B1A RID: 6938 RVA: 0x0005AD01 File Offset: 0x00058F01
		private static Delegate GetToArrayHandler()
		{
			if (IEnumEntriesInvoker.cb_toArray == null)
			{
				IEnumEntriesInvoker.cb_toArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEnumEntriesInvoker.n_ToArray));
			}
			return IEnumEntriesInvoker.cb_toArray;
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0005AD25 File Offset: 0x00058F25
		private static IntPtr n_ToArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToArray());
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0005AD3C File Offset: 0x00058F3C
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0005AD9C File Offset: 0x00058F9C
		private static Delegate GetToArray_arrayLjava_lang_Object_Handler()
		{
			if (IEnumEntriesInvoker.cb_toArray_arrayLjava_lang_Object_ == null)
			{
				IEnumEntriesInvoker.cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IEnumEntriesInvoker.n_ToArray_arrayLjava_lang_Object_));
			}
			return IEnumEntriesInvoker.cb_toArray_arrayLjava_lang_Object_;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0005ADC0 File Offset: 0x00058FC0
		private static IntPtr n_ToArray_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_a)
		{
			Java.Util.IList @object = Java.Lang.Object.GetObject<IEnumEntries>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_a, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_a);
			}
			return result;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0005AE04 File Offset: 0x00059004
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

		// Token: 0x0400082C RID: 2092
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/enums/EnumEntries", typeof(IEnumEntriesInvoker));

		// Token: 0x0400082D RID: 2093
		private IntPtr class_ref;

		// Token: 0x0400082E RID: 2094
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x0400082F RID: 2095
		private IntPtr id_isEmpty;

		// Token: 0x04000830 RID: 2096
		[Nullable(2)]
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000831 RID: 2097
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000832 RID: 2098
		[Nullable(2)]
		private static Delegate cb_add_ILjava_lang_Object_;

		// Token: 0x04000833 RID: 2099
		private IntPtr id_add_ILjava_lang_Object_;

		// Token: 0x04000834 RID: 2100
		[Nullable(2)]
		private static Delegate cb_addAll_ILSystem_Collections_ICollection_;

		// Token: 0x04000835 RID: 2101
		private IntPtr id_addAll_ILSystem_Collections_ICollection_;

		// Token: 0x04000836 RID: 2102
		[Nullable(2)]
		private static Delegate cb_addAll_LSystem_Collections_ICollection_;

		// Token: 0x04000837 RID: 2103
		private IntPtr id_addAll_LSystem_Collections_ICollection_;

		// Token: 0x04000838 RID: 2104
		[Nullable(2)]
		private static Delegate cb_clear;

		// Token: 0x04000839 RID: 2105
		private IntPtr id_clear;

		// Token: 0x0400083A RID: 2106
		[Nullable(2)]
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x0400083B RID: 2107
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x0400083C RID: 2108
		[Nullable(2)]
		private static Delegate cb_containsAll_LSystem_Collections_ICollection_;

		// Token: 0x0400083D RID: 2109
		private IntPtr id_containsAll_LSystem_Collections_ICollection_;

		// Token: 0x0400083E RID: 2110
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400083F RID: 2111
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000840 RID: 2112
		[Nullable(2)]
		private static Delegate cb_get_I;

		// Token: 0x04000841 RID: 2113
		private IntPtr id_get_I;

		// Token: 0x04000842 RID: 2114
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000843 RID: 2115
		private IntPtr id_hashCode;

		// Token: 0x04000844 RID: 2116
		[Nullable(2)]
		private static Delegate cb_indexOf_Ljava_lang_Object_;

		// Token: 0x04000845 RID: 2117
		private IntPtr id_indexOf_Ljava_lang_Object_;

		// Token: 0x04000846 RID: 2118
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x04000847 RID: 2119
		private IntPtr id_iterator;

		// Token: 0x04000848 RID: 2120
		[Nullable(2)]
		private static Delegate cb_lastIndexOf_Ljava_lang_Object_;

		// Token: 0x04000849 RID: 2121
		private IntPtr id_lastIndexOf_Ljava_lang_Object_;

		// Token: 0x0400084A RID: 2122
		[Nullable(2)]
		private static Delegate cb_listIterator;

		// Token: 0x0400084B RID: 2123
		private IntPtr id_listIterator;

		// Token: 0x0400084C RID: 2124
		[Nullable(2)]
		private static Delegate cb_listIterator_I;

		// Token: 0x0400084D RID: 2125
		private IntPtr id_listIterator_I;

		// Token: 0x0400084E RID: 2126
		[Nullable(2)]
		private static Delegate cb_remove_I;

		// Token: 0x0400084F RID: 2127
		private IntPtr id_remove_I;

		// Token: 0x04000850 RID: 2128
		[Nullable(2)]
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000851 RID: 2129
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000852 RID: 2130
		[Nullable(2)]
		private static Delegate cb_removeAll_LSystem_Collections_ICollection_;

		// Token: 0x04000853 RID: 2131
		private IntPtr id_removeAll_LSystem_Collections_ICollection_;

		// Token: 0x04000854 RID: 2132
		[Nullable(2)]
		private static Delegate cb_retainAll_LSystem_Collections_ICollection_;

		// Token: 0x04000855 RID: 2133
		private IntPtr id_retainAll_LSystem_Collections_ICollection_;

		// Token: 0x04000856 RID: 2134
		[Nullable(2)]
		private static Delegate cb_set_ILjava_lang_Object_;

		// Token: 0x04000857 RID: 2135
		private IntPtr id_set_ILjava_lang_Object_;

		// Token: 0x04000858 RID: 2136
		[Nullable(2)]
		private static Delegate cb_size;

		// Token: 0x04000859 RID: 2137
		private IntPtr id_size;

		// Token: 0x0400085A RID: 2138
		[Nullable(2)]
		private static Delegate cb_subList_II;

		// Token: 0x0400085B RID: 2139
		private IntPtr id_subList_II;

		// Token: 0x0400085C RID: 2140
		[Nullable(2)]
		private static Delegate cb_toArray;

		// Token: 0x0400085D RID: 2141
		private IntPtr id_toArray;

		// Token: 0x0400085E RID: 2142
		[Nullable(2)]
		private static Delegate cb_toArray_arrayLjava_lang_Object_;

		// Token: 0x0400085F RID: 2143
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
