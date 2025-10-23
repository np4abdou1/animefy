using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x0200019B RID: 411
	[Register("android/text/Editable", DoNotGenerateAcw = true)]
	internal class IEditableInvoker : Java.Lang.Object, IEditable, IGetChars, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable, ISpannable, ISpanned, IAppendable
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00024B3C File Offset: 0x00022D3C
		private static IntPtr java_class_ref
		{
			get
			{
				return IEditableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00024B60 File Offset: 0x00022D60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEditableInvoker._members;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00024B67 File Offset: 0x00022D67
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00024B6F File Offset: 0x00022D6F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEditableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00024B7B File Offset: 0x00022D7B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEditableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.Editable'.");
			}
			return handle;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00024BA6 File Offset: 0x00022DA6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00024BD8 File Offset: 0x00022DD8
		public IEditableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEditableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00024C10 File Offset: 0x00022E10
		private static Delegate GetAppend_CHandler()
		{
			if (IEditableInvoker.cb_append_C == null)
			{
				IEditableInvoker.cb_append_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(IEditableInvoker.n_Append_C));
			}
			return IEditableInvoker.cb_append_C;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00024C34 File Offset: 0x00022E34
		private static IntPtr n_Append_C(IntPtr jnienv, IntPtr native__this, char text)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Append(text));
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00024C4C File Offset: 0x00022E4C
		public unsafe IAppendable Append(char text)
		{
			if (this.id_append_C == IntPtr.Zero)
			{
				this.id_append_C = JNIEnv.GetMethodID(this.class_ref, "append", "(C)Landroid/text/Editable;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(text);
			return Java.Lang.Object.GetObject<IAppendable>(JNIEnv.CallObjectMethod(base.Handle, this.id_append_C, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00024CB6 File Offset: 0x00022EB6
		private static Delegate GetAppend_Ljava_lang_CharSequence_Handler()
		{
			if (IEditableInvoker.cb_append_Ljava_lang_CharSequence_ == null)
			{
				IEditableInvoker.cb_append_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IEditableInvoker.n_Append_Ljava_lang_CharSequence_));
			}
			return IEditableInvoker.cb_append_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00024CDC File Offset: 0x00022EDC
		private static IntPtr n_Append_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2));
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00024D04 File Offset: 0x00022F04
		public unsafe IAppendable Append(ICharSequence text)
		{
			if (this.id_append_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_append_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IAppendable @object = Java.Lang.Object.GetObject<IAppendable>(JNIEnv.CallObjectMethod(base.Handle, this.id_append_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00024D7B File Offset: 0x00022F7B
		private static Delegate GetAppend_Ljava_lang_CharSequence_IIHandler()
		{
			if (IEditableInvoker.cb_append_Ljava_lang_CharSequence_II == null)
			{
				IEditableInvoker.cb_append_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(IEditableInvoker.n_Append_Ljava_lang_CharSequence_II));
			}
			return IEditableInvoker.cb_append_Ljava_lang_CharSequence_II;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00024DA0 File Offset: 0x00022FA0
		private static IntPtr n_Append_Ljava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, IntPtr native_text, int start, int end)
		{
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, start, end));
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00024DCC File Offset: 0x00022FCC
		public unsafe IAppendable Append(ICharSequence text, int start, int end)
		{
			if (this.id_append_Ljava_lang_CharSequence_II == IntPtr.Zero)
			{
				this.id_append_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID(this.class_ref, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(start);
			ptr[2] = new JValue(end);
			IAppendable @object = Java.Lang.Object.GetObject<IAppendable>(JNIEnv.CallObjectMethod(base.Handle, this.id_append_Ljava_lang_CharSequence_II, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00024E6C File Offset: 0x0002306C
		private static Delegate GetClearHandler()
		{
			if (IEditableInvoker.cb_clear == null)
			{
				IEditableInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IEditableInvoker.n_Clear));
			}
			return IEditableInvoker.cb_clear;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00024E90 File Offset: 0x00023090
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00024E9F File Offset: 0x0002309F
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00024EDF File Offset: 0x000230DF
		private static Delegate GetClearSpansHandler()
		{
			if (IEditableInvoker.cb_clearSpans == null)
			{
				IEditableInvoker.cb_clearSpans = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IEditableInvoker.n_ClearSpans));
			}
			return IEditableInvoker.cb_clearSpans;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00024F03 File Offset: 0x00023103
		private static void n_ClearSpans(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearSpans();
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00024F12 File Offset: 0x00023112
		public void ClearSpans()
		{
			if (this.id_clearSpans == IntPtr.Zero)
			{
				this.id_clearSpans = JNIEnv.GetMethodID(this.class_ref, "clearSpans", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearSpans);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00024F52 File Offset: 0x00023152
		private static Delegate GetDelete_IIHandler()
		{
			if (IEditableInvoker.cb_delete_II == null)
			{
				IEditableInvoker.cb_delete_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(IEditableInvoker.n_Delete_II));
			}
			return IEditableInvoker.cb_delete_II;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00024F76 File Offset: 0x00023176
		private static IntPtr n_Delete_II(IntPtr jnienv, IntPtr native__this, int st, int en)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delete(st, en));
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00024F8C File Offset: 0x0002318C
		public unsafe IEditable Delete(int st, int en)
		{
			if (this.id_delete_II == IntPtr.Zero)
			{
				this.id_delete_II = JNIEnv.GetMethodID(this.class_ref, "delete", "(II)Landroid/text/Editable;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(st);
			ptr[1] = new JValue(en);
			return Java.Lang.Object.GetObject<IEditable>(JNIEnv.CallObjectMethod(base.Handle, this.id_delete_II, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00025009 File Offset: 0x00023209
		private static Delegate GetGetFiltersHandler()
		{
			if (IEditableInvoker.cb_getFilters == null)
			{
				IEditableInvoker.cb_getFilters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEditableInvoker.n_GetFilters));
			}
			return IEditableInvoker.cb_getFilters;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0002502D File Offset: 0x0002322D
		private static IntPtr n_GetFilters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<IInputFilter>(Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetFilters());
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00025044 File Offset: 0x00023244
		public IInputFilter[] GetFilters()
		{
			if (this.id_getFilters == IntPtr.Zero)
			{
				this.id_getFilters = JNIEnv.GetMethodID(this.class_ref, "getFilters", "()[Landroid/text/InputFilter;");
			}
			return (IInputFilter[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getFilters), JniHandleOwnership.TransferLocalRef, typeof(IInputFilter));
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000250A4 File Offset: 0x000232A4
		private static Delegate GetInsert_ILjava_lang_CharSequence_Handler()
		{
			if (IEditableInvoker.cb_insert_ILjava_lang_CharSequence_ == null)
			{
				IEditableInvoker.cb_insert_ILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(IEditableInvoker.n_Insert_ILjava_lang_CharSequence_));
			}
			return IEditableInvoker.cb_insert_ILjava_lang_CharSequence_;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000250C8 File Offset: 0x000232C8
		private static IntPtr n_Insert_ILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int where, IntPtr native_text)
		{
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Insert(where, object2));
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000250F4 File Offset: 0x000232F4
		public unsafe IEditable Insert(int where, ICharSequence text)
		{
			if (this.id_insert_ILjava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_insert_ILjava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(where);
			ptr[1] = new JValue(intPtr);
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(JNIEnv.CallObjectMethod(base.Handle, this.id_insert_ILjava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0002517E File Offset: 0x0002337E
		private static Delegate GetInsert_ILjava_lang_CharSequence_IIHandler()
		{
			if (IEditableInvoker.cb_insert_ILjava_lang_CharSequence_II == null)
			{
				IEditableInvoker.cb_insert_ILjava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILII_L(IEditableInvoker.n_Insert_ILjava_lang_CharSequence_II));
			}
			return IEditableInvoker.cb_insert_ILjava_lang_CharSequence_II;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000251A4 File Offset: 0x000233A4
		private static IntPtr n_Insert_ILjava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, int where, IntPtr native_text, int start, int end)
		{
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Insert(where, object2, start, end));
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000251D4 File Offset: 0x000233D4
		public unsafe IEditable Insert(int where, ICharSequence text, int start, int end)
		{
			if (this.id_insert_ILjava_lang_CharSequence_II == IntPtr.Zero)
			{
				this.id_insert_ILjava_lang_CharSequence_II = JNIEnv.GetMethodID(this.class_ref, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(where);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(start);
			ptr[3] = new JValue(end);
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(JNIEnv.CallObjectMethod(base.Handle, this.id_insert_ILjava_lang_CharSequence_II, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0002528B File Offset: 0x0002348B
		private static Delegate GetReplace_IILjava_lang_CharSequence_Handler()
		{
			if (IEditableInvoker.cb_replace_IILjava_lang_CharSequence_ == null)
			{
				IEditableInvoker.cb_replace_IILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(IEditableInvoker.n_Replace_IILjava_lang_CharSequence_));
			}
			return IEditableInvoker.cb_replace_IILjava_lang_CharSequence_;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000252B0 File Offset: 0x000234B0
		private static IntPtr n_Replace_IILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int st, int en, IntPtr native_text)
		{
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(st, en, object2));
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000252DC File Offset: 0x000234DC
		public unsafe IEditable Replace(int st, int en, ICharSequence text)
		{
			if (this.id_replace_IILjava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_replace_IILjava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(st);
			ptr[1] = new JValue(en);
			ptr[2] = new JValue(intPtr);
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(JNIEnv.CallObjectMethod(base.Handle, this.id_replace_IILjava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0002537C File Offset: 0x0002357C
		private static Delegate GetReplace_IILjava_lang_CharSequence_IIHandler()
		{
			if (IEditableInvoker.cb_replace_IILjava_lang_CharSequence_II == null)
			{
				IEditableInvoker.cb_replace_IILjava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILII_L(IEditableInvoker.n_Replace_IILjava_lang_CharSequence_II));
			}
			return IEditableInvoker.cb_replace_IILjava_lang_CharSequence_II;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x000253A0 File Offset: 0x000235A0
		private static IntPtr n_Replace_IILjava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, int st, int en, IntPtr native_source, int start, int end)
		{
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_source, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(st, en, object2, start, end));
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000253D0 File Offset: 0x000235D0
		public unsafe IEditable Replace(int st, int en, ICharSequence source, int start, int end)
		{
			if (this.id_replace_IILjava_lang_CharSequence_II == IntPtr.Zero)
			{
				this.id_replace_IILjava_lang_CharSequence_II = JNIEnv.GetMethodID(this.class_ref, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(source);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(st);
			ptr[1] = new JValue(en);
			ptr[2] = new JValue(intPtr);
			ptr[3] = new JValue(start);
			ptr[4] = new JValue(end);
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(JNIEnv.CallObjectMethod(base.Handle, this.id_replace_IILjava_lang_CharSequence_II, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0002549E File Offset: 0x0002369E
		private static Delegate GetSetFilters_arrayLandroid_text_InputFilter_Handler()
		{
			if (IEditableInvoker.cb_setFilters_arrayLandroid_text_InputFilter_ == null)
			{
				IEditableInvoker.cb_setFilters_arrayLandroid_text_InputFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IEditableInvoker.n_SetFilters_arrayLandroid_text_InputFilter_));
			}
			return IEditableInvoker.cb_setFilters_arrayLandroid_text_InputFilter_;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000254C4 File Offset: 0x000236C4
		private static void n_SetFilters_arrayLandroid_text_InputFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_filters)
		{
			IEditable @object = Java.Lang.Object.GetObject<IEditable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInputFilter[] array = (IInputFilter[])JNIEnv.GetArray(native_filters, JniHandleOwnership.DoNotTransfer, typeof(IInputFilter));
			@object.SetFilters(array);
			if (array != null)
			{
				JNIEnv.CopyArray<IInputFilter>(array, native_filters);
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00025500 File Offset: 0x00023700
		public unsafe void SetFilters(IInputFilter[] filters)
		{
			if (this.id_setFilters_arrayLandroid_text_InputFilter_ == IntPtr.Zero)
			{
				this.id_setFilters_arrayLandroid_text_InputFilter_ = JNIEnv.GetMethodID(this.class_ref, "setFilters", "([Landroid/text/InputFilter;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray<IInputFilter>(filters);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setFilters_arrayLandroid_text_InputFilter_, ptr);
			if (filters != null)
			{
				JNIEnv.CopyArray<IInputFilter>(intPtr, filters);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0002557C File Offset: 0x0002377C
		public unsafe void GetChars(int start, int end, char[] dest, int destoff)
		{
			if (this.id_getChars_IIarrayCI == IntPtr.Zero)
			{
				this.id_getChars_IIarrayCI = JNIEnv.GetMethodID(this.class_ref, "getChars", "(II[CI)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(dest);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(start);
			ptr[1] = new JValue(end);
			ptr[2] = new JValue(intPtr);
			ptr[3] = new JValue(destoff);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getChars_IIarrayCI, ptr);
			if (dest != null)
			{
				JNIEnv.CopyArray(intPtr, dest);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00025638 File Offset: 0x00023838
		public unsafe char CharAt(int index)
		{
			if (this.id_charAt_I == IntPtr.Zero)
			{
				this.id_charAt_I = JNIEnv.GetMethodID(this.class_ref, "charAt", "(I)C");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return JNIEnv.CallCharMethod(base.Handle, this.id_charAt_I, ptr);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0002569C File Offset: 0x0002389C
		public int Length()
		{
			if (this.id_length == IntPtr.Zero)
			{
				this.id_length = JNIEnv.GetMethodID(this.class_ref, "length", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_length);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000256DC File Offset: 0x000238DC
		public unsafe ICharSequence SubSequenceFormatted(int start, int end)
		{
			if (this.id_subSequence_II == IntPtr.Zero)
			{
				this.id_subSequence_II = JNIEnv.GetMethodID(this.class_ref, "subSequence", "(II)Ljava/lang/CharSequence;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(start);
			ptr[1] = new JValue(end);
			return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_subSequence_II, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0002575C File Offset: 0x0002395C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000257AD File Offset: 0x000239AD
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x000257B5 File Offset: 0x000239B5
		public IEnumerator<char> GetEnumerator()
		{
			int num;
			for (int i = 0; i < this.Length(); i = num + 1)
			{
				yield return this.CharAt(i);
				num = i;
			}
			yield break;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x000257C4 File Offset: 0x000239C4
		public unsafe void RemoveSpan(Java.Lang.Object what)
		{
			if (this.id_removeSpan_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_removeSpan_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "removeSpan", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((what == null) ? IntPtr.Zero : what.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeSpan_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00025838 File Offset: 0x00023A38
		public unsafe void SetSpan(Java.Lang.Object what, int start, int end, [GeneratedEnum] SpanTypes flags)
		{
			if (this.id_setSpan_Ljava_lang_Object_III == IntPtr.Zero)
			{
				this.id_setSpan_Ljava_lang_Object_III = JNIEnv.GetMethodID(this.class_ref, "setSpan", "(Ljava/lang/Object;III)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((what == null) ? IntPtr.Zero : what.Handle);
			ptr[1] = new JValue(start);
			ptr[2] = new JValue(end);
			ptr[3] = new JValue((int)flags);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setSpan_Ljava_lang_Object_III, ptr);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x000258EC File Offset: 0x00023AEC
		public unsafe int GetSpanEnd(Java.Lang.Object tag)
		{
			if (this.id_getSpanEnd_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_getSpanEnd_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "getSpanEnd", "(Ljava/lang/Object;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((tag == null) ? IntPtr.Zero : tag.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getSpanEnd_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00025960 File Offset: 0x00023B60
		public unsafe SpanTypes GetSpanFlags(Java.Lang.Object tag)
		{
			if (this.id_getSpanFlags_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_getSpanFlags_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "getSpanFlags", "(Ljava/lang/Object;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((tag == null) ? IntPtr.Zero : tag.Handle);
			return (SpanTypes)JNIEnv.CallIntMethod(base.Handle, this.id_getSpanFlags_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000259D4 File Offset: 0x00023BD4
		public unsafe Java.Lang.Object[] GetSpans(int start, int end, Class type)
		{
			if (this.id_getSpans_IILjava_lang_Class_ == IntPtr.Zero)
			{
				this.id_getSpans_IILjava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(start);
			ptr[1] = new JValue(end);
			ptr[2] = new JValue((type == null) ? IntPtr.Zero : type.Handle);
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getSpans_IILjava_lang_Class_, ptr), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00025A88 File Offset: 0x00023C88
		public unsafe int GetSpanStart(Java.Lang.Object tag)
		{
			if (this.id_getSpanStart_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_getSpanStart_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "getSpanStart", "(Ljava/lang/Object;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((tag == null) ? IntPtr.Zero : tag.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getSpanStart_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00025AFC File Offset: 0x00023CFC
		public unsafe int NextSpanTransition(int start, int limit, Class type)
		{
			if (this.id_nextSpanTransition_IILjava_lang_Class_ == IntPtr.Zero)
			{
				this.id_nextSpanTransition_IILjava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "nextSpanTransition", "(IILjava/lang/Class;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(start);
			ptr[1] = new JValue(limit);
			ptr[2] = new JValue((type == null) ? IntPtr.Zero : type.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_nextSpanTransition_IILjava_lang_Class_, ptr);
		}

		// Token: 0x040006A9 RID: 1705
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/Editable", typeof(IEditableInvoker));

		// Token: 0x040006AA RID: 1706
		private IntPtr class_ref;

		// Token: 0x040006AB RID: 1707
		private static Delegate cb_append_C;

		// Token: 0x040006AC RID: 1708
		private IntPtr id_append_C;

		// Token: 0x040006AD RID: 1709
		private static Delegate cb_append_Ljava_lang_CharSequence_;

		// Token: 0x040006AE RID: 1710
		private IntPtr id_append_Ljava_lang_CharSequence_;

		// Token: 0x040006AF RID: 1711
		private static Delegate cb_append_Ljava_lang_CharSequence_II;

		// Token: 0x040006B0 RID: 1712
		private IntPtr id_append_Ljava_lang_CharSequence_II;

		// Token: 0x040006B1 RID: 1713
		private static Delegate cb_clear;

		// Token: 0x040006B2 RID: 1714
		private IntPtr id_clear;

		// Token: 0x040006B3 RID: 1715
		private static Delegate cb_clearSpans;

		// Token: 0x040006B4 RID: 1716
		private IntPtr id_clearSpans;

		// Token: 0x040006B5 RID: 1717
		private static Delegate cb_delete_II;

		// Token: 0x040006B6 RID: 1718
		private IntPtr id_delete_II;

		// Token: 0x040006B7 RID: 1719
		private static Delegate cb_getFilters;

		// Token: 0x040006B8 RID: 1720
		private IntPtr id_getFilters;

		// Token: 0x040006B9 RID: 1721
		private static Delegate cb_insert_ILjava_lang_CharSequence_;

		// Token: 0x040006BA RID: 1722
		private IntPtr id_insert_ILjava_lang_CharSequence_;

		// Token: 0x040006BB RID: 1723
		private static Delegate cb_insert_ILjava_lang_CharSequence_II;

		// Token: 0x040006BC RID: 1724
		private IntPtr id_insert_ILjava_lang_CharSequence_II;

		// Token: 0x040006BD RID: 1725
		private static Delegate cb_replace_IILjava_lang_CharSequence_;

		// Token: 0x040006BE RID: 1726
		private IntPtr id_replace_IILjava_lang_CharSequence_;

		// Token: 0x040006BF RID: 1727
		private static Delegate cb_replace_IILjava_lang_CharSequence_II;

		// Token: 0x040006C0 RID: 1728
		private IntPtr id_replace_IILjava_lang_CharSequence_II;

		// Token: 0x040006C1 RID: 1729
		private static Delegate cb_setFilters_arrayLandroid_text_InputFilter_;

		// Token: 0x040006C2 RID: 1730
		private IntPtr id_setFilters_arrayLandroid_text_InputFilter_;

		// Token: 0x040006C3 RID: 1731
		private IntPtr id_getChars_IIarrayCI;

		// Token: 0x040006C4 RID: 1732
		private IntPtr id_charAt_I;

		// Token: 0x040006C5 RID: 1733
		private IntPtr id_length;

		// Token: 0x040006C6 RID: 1734
		private IntPtr id_subSequence_II;

		// Token: 0x040006C7 RID: 1735
		private IntPtr id_toString;

		// Token: 0x040006C8 RID: 1736
		private IntPtr id_removeSpan_Ljava_lang_Object_;

		// Token: 0x040006C9 RID: 1737
		private IntPtr id_setSpan_Ljava_lang_Object_III;

		// Token: 0x040006CA RID: 1738
		private IntPtr id_getSpanEnd_Ljava_lang_Object_;

		// Token: 0x040006CB RID: 1739
		private IntPtr id_getSpanFlags_Ljava_lang_Object_;

		// Token: 0x040006CC RID: 1740
		private IntPtr id_getSpans_IILjava_lang_Class_;

		// Token: 0x040006CD RID: 1741
		private IntPtr id_getSpanStart_Ljava_lang_Object_;

		// Token: 0x040006CE RID: 1742
		private IntPtr id_nextSpanTransition_IILjava_lang_Class_;
	}
}
