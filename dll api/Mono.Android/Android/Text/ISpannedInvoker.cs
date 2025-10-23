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
	// Token: 0x020001AA RID: 426
	[Register("android/text/Spanned", DoNotGenerateAcw = true)]
	internal class ISpannedInvoker : Java.Lang.Object, ISpanned, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00026D78 File Offset: 0x00024F78
		private static IntPtr java_class_ref
		{
			get
			{
				return ISpannedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00026D9C File Offset: 0x00024F9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISpannedInvoker._members;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00026DA3 File Offset: 0x00024FA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00026DAB File Offset: 0x00024FAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISpannedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00026DB7 File Offset: 0x00024FB7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISpannedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.Spanned'.");
			}
			return handle;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00026DE2 File Offset: 0x00024FE2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00026E14 File Offset: 0x00025014
		public ISpannedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISpannedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00026E4C File Offset: 0x0002504C
		private static Delegate GetGetSpanEnd_Ljava_lang_Object_Handler()
		{
			if (ISpannedInvoker.cb_getSpanEnd_Ljava_lang_Object_ == null)
			{
				ISpannedInvoker.cb_getSpanEnd_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ISpannedInvoker.n_GetSpanEnd_Ljava_lang_Object_));
			}
			return ISpannedInvoker.cb_getSpanEnd_Ljava_lang_Object_;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00026E70 File Offset: 0x00025070
		private static int n_GetSpanEnd_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			ISpanned @object = Java.Lang.Object.GetObject<ISpanned>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_tag, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanEnd(object2);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00026E94 File Offset: 0x00025094
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

		// Token: 0x06000F10 RID: 3856 RVA: 0x00026F07 File Offset: 0x00025107
		private static Delegate GetGetSpanFlags_Ljava_lang_Object_Handler()
		{
			if (ISpannedInvoker.cb_getSpanFlags_Ljava_lang_Object_ == null)
			{
				ISpannedInvoker.cb_getSpanFlags_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ISpannedInvoker.n_GetSpanFlags_Ljava_lang_Object_));
			}
			return ISpannedInvoker.cb_getSpanFlags_Ljava_lang_Object_;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00026F2C File Offset: 0x0002512C
		private static int n_GetSpanFlags_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			ISpanned @object = Java.Lang.Object.GetObject<ISpanned>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_tag, JniHandleOwnership.DoNotTransfer);
			return (int)@object.GetSpanFlags(object2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00026F50 File Offset: 0x00025150
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

		// Token: 0x06000F13 RID: 3859 RVA: 0x00026FC3 File Offset: 0x000251C3
		private static Delegate GetGetSpans_IILjava_lang_Class_Handler()
		{
			if (ISpannedInvoker.cb_getSpans_IILjava_lang_Class_ == null)
			{
				ISpannedInvoker.cb_getSpans_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(ISpannedInvoker.n_GetSpans_IILjava_lang_Class_));
			}
			return ISpannedInvoker.cb_getSpans_IILjava_lang_Class_;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00026FE8 File Offset: 0x000251E8
		private static IntPtr n_GetSpans_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int start, int end, IntPtr native_type)
		{
			ISpanned @object = Java.Lang.Object.GetObject<ISpanned>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_type, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Java.Lang.Object>(@object.GetSpans(start, end, object2));
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00027014 File Offset: 0x00025214
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

		// Token: 0x06000F16 RID: 3862 RVA: 0x000270C5 File Offset: 0x000252C5
		private static Delegate GetGetSpanStart_Ljava_lang_Object_Handler()
		{
			if (ISpannedInvoker.cb_getSpanStart_Ljava_lang_Object_ == null)
			{
				ISpannedInvoker.cb_getSpanStart_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ISpannedInvoker.n_GetSpanStart_Ljava_lang_Object_));
			}
			return ISpannedInvoker.cb_getSpanStart_Ljava_lang_Object_;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000270EC File Offset: 0x000252EC
		private static int n_GetSpanStart_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			ISpanned @object = Java.Lang.Object.GetObject<ISpanned>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_tag, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanStart(object2);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00027110 File Offset: 0x00025310
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

		// Token: 0x06000F19 RID: 3865 RVA: 0x00027183 File Offset: 0x00025383
		private static Delegate GetNextSpanTransition_IILjava_lang_Class_Handler()
		{
			if (ISpannedInvoker.cb_nextSpanTransition_IILjava_lang_Class_ == null)
			{
				ISpannedInvoker.cb_nextSpanTransition_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_I(ISpannedInvoker.n_NextSpanTransition_IILjava_lang_Class_));
			}
			return ISpannedInvoker.cb_nextSpanTransition_IILjava_lang_Class_;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000271A8 File Offset: 0x000253A8
		private static int n_NextSpanTransition_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int start, int limit, IntPtr native_type)
		{
			ISpanned @object = Java.Lang.Object.GetObject<ISpanned>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_type, JniHandleOwnership.DoNotTransfer);
			return @object.NextSpanTransition(start, limit, object2);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000271D0 File Offset: 0x000253D0
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

		// Token: 0x06000F1C RID: 3868 RVA: 0x0002726C File Offset: 0x0002546C
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

		// Token: 0x06000F1D RID: 3869 RVA: 0x000272D0 File Offset: 0x000254D0
		public int Length()
		{
			if (this.id_length == IntPtr.Zero)
			{
				this.id_length = JNIEnv.GetMethodID(this.class_ref, "length", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_length);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00027310 File Offset: 0x00025510
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

		// Token: 0x06000F1F RID: 3871 RVA: 0x00027390 File Offset: 0x00025590
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000273E1 File Offset: 0x000255E1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000273E9 File Offset: 0x000255E9
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

		// Token: 0x040006FE RID: 1790
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/Spanned", typeof(ISpannedInvoker));

		// Token: 0x040006FF RID: 1791
		private IntPtr class_ref;

		// Token: 0x04000700 RID: 1792
		private static Delegate cb_getSpanEnd_Ljava_lang_Object_;

		// Token: 0x04000701 RID: 1793
		private IntPtr id_getSpanEnd_Ljava_lang_Object_;

		// Token: 0x04000702 RID: 1794
		private static Delegate cb_getSpanFlags_Ljava_lang_Object_;

		// Token: 0x04000703 RID: 1795
		private IntPtr id_getSpanFlags_Ljava_lang_Object_;

		// Token: 0x04000704 RID: 1796
		private static Delegate cb_getSpans_IILjava_lang_Class_;

		// Token: 0x04000705 RID: 1797
		private IntPtr id_getSpans_IILjava_lang_Class_;

		// Token: 0x04000706 RID: 1798
		private static Delegate cb_getSpanStart_Ljava_lang_Object_;

		// Token: 0x04000707 RID: 1799
		private IntPtr id_getSpanStart_Ljava_lang_Object_;

		// Token: 0x04000708 RID: 1800
		private static Delegate cb_nextSpanTransition_IILjava_lang_Class_;

		// Token: 0x04000709 RID: 1801
		private IntPtr id_nextSpanTransition_IILjava_lang_Class_;

		// Token: 0x0400070A RID: 1802
		private IntPtr id_charAt_I;

		// Token: 0x0400070B RID: 1803
		private IntPtr id_length;

		// Token: 0x0400070C RID: 1804
		private IntPtr id_subSequence_II;

		// Token: 0x0400070D RID: 1805
		private IntPtr id_toString;
	}
}
