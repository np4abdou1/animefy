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
	// Token: 0x020001A7 RID: 423
	[Register("android/text/Spannable", DoNotGenerateAcw = true)]
	internal class ISpannableInvoker : Java.Lang.Object, ISpannable, ISpanned, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x000265F4 File Offset: 0x000247F4
		private static IntPtr java_class_ref
		{
			get
			{
				return ISpannableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00026618 File Offset: 0x00024818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISpannableInvoker._members;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0002661F File Offset: 0x0002481F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00026627 File Offset: 0x00024827
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISpannableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00026633 File Offset: 0x00024833
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISpannableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.Spannable'.");
			}
			return handle;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0002665E File Offset: 0x0002485E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00026690 File Offset: 0x00024890
		public ISpannableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISpannableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000266C8 File Offset: 0x000248C8
		private static Delegate GetRemoveSpan_Ljava_lang_Object_Handler()
		{
			if (ISpannableInvoker.cb_removeSpan_Ljava_lang_Object_ == null)
			{
				ISpannableInvoker.cb_removeSpan_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISpannableInvoker.n_RemoveSpan_Ljava_lang_Object_));
			}
			return ISpannableInvoker.cb_removeSpan_Ljava_lang_Object_;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000266EC File Offset: 0x000248EC
		private static void n_RemoveSpan_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			ISpannable @object = Java.Lang.Object.GetObject<ISpannable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.RemoveSpan(object2);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00026710 File Offset: 0x00024910
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

		// Token: 0x06000EEC RID: 3820 RVA: 0x00026783 File Offset: 0x00024983
		private static Delegate GetSetSpan_Ljava_lang_Object_IIIHandler()
		{
			if (ISpannableInvoker.cb_setSpan_Ljava_lang_Object_III == null)
			{
				ISpannableInvoker.cb_setSpan_Ljava_lang_Object_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(ISpannableInvoker.n_SetSpan_Ljava_lang_Object_III));
			}
			return ISpannableInvoker.cb_setSpan_Ljava_lang_Object_III;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000267A8 File Offset: 0x000249A8
		private static void n_SetSpan_Ljava_lang_Object_III(IntPtr jnienv, IntPtr native__this, IntPtr native_what, int start, int end, int native_flags)
		{
			ISpannable @object = Java.Lang.Object.GetObject<ISpannable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.SetSpan(object2, start, end, (SpanTypes)native_flags);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000267D4 File Offset: 0x000249D4
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

		// Token: 0x06000EEF RID: 3823 RVA: 0x00026888 File Offset: 0x00024A88
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

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000268FC File Offset: 0x00024AFC
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

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00026970 File Offset: 0x00024B70
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

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00026A24 File Offset: 0x00024C24
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

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00026A98 File Offset: 0x00024C98
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

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00026B34 File Offset: 0x00024D34
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

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00026B98 File Offset: 0x00024D98
		public int Length()
		{
			if (this.id_length == IntPtr.Zero)
			{
				this.id_length = JNIEnv.GetMethodID(this.class_ref, "length", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_length);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00026BD8 File Offset: 0x00024DD8
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

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00026C58 File Offset: 0x00024E58
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00026CA9 File Offset: 0x00024EA9
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00026CB1 File Offset: 0x00024EB1
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

		// Token: 0x040006EB RID: 1771
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/Spannable", typeof(ISpannableInvoker));

		// Token: 0x040006EC RID: 1772
		private IntPtr class_ref;

		// Token: 0x040006ED RID: 1773
		private static Delegate cb_removeSpan_Ljava_lang_Object_;

		// Token: 0x040006EE RID: 1774
		private IntPtr id_removeSpan_Ljava_lang_Object_;

		// Token: 0x040006EF RID: 1775
		private static Delegate cb_setSpan_Ljava_lang_Object_III;

		// Token: 0x040006F0 RID: 1776
		private IntPtr id_setSpan_Ljava_lang_Object_III;

		// Token: 0x040006F1 RID: 1777
		private IntPtr id_getSpanEnd_Ljava_lang_Object_;

		// Token: 0x040006F2 RID: 1778
		private IntPtr id_getSpanFlags_Ljava_lang_Object_;

		// Token: 0x040006F3 RID: 1779
		private IntPtr id_getSpans_IILjava_lang_Class_;

		// Token: 0x040006F4 RID: 1780
		private IntPtr id_getSpanStart_Ljava_lang_Object_;

		// Token: 0x040006F5 RID: 1781
		private IntPtr id_nextSpanTransition_IILjava_lang_Class_;

		// Token: 0x040006F6 RID: 1782
		private IntPtr id_charAt_I;

		// Token: 0x040006F7 RID: 1783
		private IntPtr id_length;

		// Token: 0x040006F8 RID: 1784
		private IntPtr id_subSequence_II;

		// Token: 0x040006F9 RID: 1785
		private IntPtr id_toString;
	}
}
