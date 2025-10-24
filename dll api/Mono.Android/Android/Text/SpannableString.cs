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
	// Token: 0x020001B0 RID: 432
	[Register("android/text/SpannableString", DoNotGenerateAcw = true)]
	public class SpannableString : SpannableStringInternal, IGetChars, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable, ISpannable, ISpanned
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00027956 File Offset: 0x00025B56
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SpannableString._members;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00027960 File Offset: 0x00025B60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SpannableString._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00027984 File Offset: 0x00025B84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SpannableString._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00027990 File Offset: 0x00025B90
		protected SpannableString(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0002799C File Offset: 0x00025B9C
		public unsafe SpannableString(string source) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(source);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(SpannableString._members.InstanceMethods.StartCreateInstance("(Ljava/lang/CharSequence;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SpannableString._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00027A48 File Offset: 0x00025C48
		public unsafe sealed override char CharAt(int i)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(i);
			return SpannableString._members.InstanceMethods.InvokeNonvirtualCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00027A83 File Offset: 0x00025C83
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (SpannableString.cb_equals_Ljava_lang_Object_ == null)
			{
				SpannableString.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(SpannableString.n_Equals_Ljava_lang_Object_));
			}
			return SpannableString.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00027AA8 File Offset: 0x00025CA8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Lang.Object @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00027ACC File Offset: 0x00025CCC
		public unsafe override bool Equals(Java.Lang.Object o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = SpannableString._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00027B34 File Offset: 0x00025D34
		public unsafe sealed override void GetChars(int start, int end, char[] dest, int off)
		{
			IntPtr intPtr = JNIEnv.NewArray(dest);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(end);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(off);
				SpannableString._members.InstanceMethods.InvokeNonvirtualVoidMethod("getChars.(II[CI)V", this, ptr);
			}
			finally
			{
				if (dest != null)
				{
					JNIEnv.CopyArray(intPtr, dest);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00027BE0 File Offset: 0x00025DE0
		private static Delegate GetGetSpanEnd_Ljava_lang_Object_Handler()
		{
			if (SpannableString.cb_getSpanEnd_Ljava_lang_Object_ == null)
			{
				SpannableString.cb_getSpanEnd_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableString.n_GetSpanEnd_Ljava_lang_Object_));
			}
			return SpannableString.cb_getSpanEnd_Ljava_lang_Object_;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00027C04 File Offset: 0x00025E04
		private static int n_GetSpanEnd_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanEnd(object2);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00027C28 File Offset: 0x00025E28
		public unsafe override int GetSpanEnd(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannableString._members.InstanceMethods.InvokeVirtualInt32Method("getSpanEnd.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00027C90 File Offset: 0x00025E90
		private static Delegate GetGetSpanFlags_Ljava_lang_Object_Handler()
		{
			if (SpannableString.cb_getSpanFlags_Ljava_lang_Object_ == null)
			{
				SpannableString.cb_getSpanFlags_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableString.n_GetSpanFlags_Ljava_lang_Object_));
			}
			return SpannableString.cb_getSpanFlags_Ljava_lang_Object_;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00027CB4 File Offset: 0x00025EB4
		private static int n_GetSpanFlags_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return (int)@object.GetSpanFlags(object2);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00027CD8 File Offset: 0x00025ED8
		public unsafe override SpanTypes GetSpanFlags(Java.Lang.Object what)
		{
			SpanTypes result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = (SpanTypes)SpannableString._members.InstanceMethods.InvokeVirtualInt32Method("getSpanFlags.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00027D40 File Offset: 0x00025F40
		private static Delegate GetGetSpans_IILjava_lang_Class_Handler()
		{
			if (SpannableString.cb_getSpans_IILjava_lang_Class_ == null)
			{
				SpannableString.cb_getSpans_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(SpannableString.n_GetSpans_IILjava_lang_Class_));
			}
			return SpannableString.cb_getSpans_IILjava_lang_Class_;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00027D64 File Offset: 0x00025F64
		private static IntPtr n_GetSpans_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int queryStart, int queryEnd, IntPtr native_kind)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_kind, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Java.Lang.Object>(@object.GetSpans(queryStart, queryEnd, object2));
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00027D90 File Offset: 0x00025F90
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe override Java.Lang.Object[] GetSpans(int queryStart, int queryEnd, Class kind)
		{
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(queryStart);
				ptr[1] = new JniArgumentValue(queryEnd);
				ptr[2] = new JniArgumentValue((kind == null) ? IntPtr.Zero : kind.Handle);
				result = (Java.Lang.Object[])JNIEnv.GetArray(SpannableString._members.InstanceMethods.InvokeVirtualObjectMethod("getSpans.(IILjava/lang/Class;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00027E3C File Offset: 0x0002603C
		private static Delegate GetGetSpanStart_Ljava_lang_Object_Handler()
		{
			if (SpannableString.cb_getSpanStart_Ljava_lang_Object_ == null)
			{
				SpannableString.cb_getSpanStart_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableString.n_GetSpanStart_Ljava_lang_Object_));
			}
			return SpannableString.cb_getSpanStart_Ljava_lang_Object_;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00027E60 File Offset: 0x00026060
		private static int n_GetSpanStart_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanStart(object2);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00027E84 File Offset: 0x00026084
		public unsafe override int GetSpanStart(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannableString._members.InstanceMethods.InvokeVirtualInt32Method("getSpanStart.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00027EEC File Offset: 0x000260EC
		private static Delegate GetGetHashCodeHandler()
		{
			if (SpannableString.cb_hashCode == null)
			{
				SpannableString.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SpannableString.n_GetHashCode));
			}
			return SpannableString.cb_hashCode;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00027F10 File Offset: 0x00026110
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00027F1F File Offset: 0x0002611F
		public override int GetHashCode()
		{
			return SpannableString._members.InstanceMethods.InvokeVirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00027F38 File Offset: 0x00026138
		public sealed override int Length()
		{
			return SpannableString._members.InstanceMethods.InvokeNonvirtualInt32Method("length.()I", this, null);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00027F51 File Offset: 0x00026151
		private static Delegate GetNextSpanTransition_IILjava_lang_Class_Handler()
		{
			if (SpannableString.cb_nextSpanTransition_IILjava_lang_Class_ == null)
			{
				SpannableString.cb_nextSpanTransition_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_I(SpannableString.n_NextSpanTransition_IILjava_lang_Class_));
			}
			return SpannableString.cb_nextSpanTransition_IILjava_lang_Class_;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00027F78 File Offset: 0x00026178
		private static int n_NextSpanTransition_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int start, int limit, IntPtr native_kind)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_kind, JniHandleOwnership.DoNotTransfer);
			return @object.NextSpanTransition(start, limit, object2);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00027FA0 File Offset: 0x000261A0
		public unsafe override int NextSpanTransition(int start, int limit, Class kind)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(limit);
				ptr[2] = new JniArgumentValue((kind == null) ? IntPtr.Zero : kind.Handle);
				result = SpannableString._members.InstanceMethods.InvokeVirtualInt32Method("nextSpanTransition.(IILjava/lang/Class;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00028030 File Offset: 0x00026230
		private static Delegate GetRemoveSpan_Ljava_lang_Object_Handler()
		{
			if (SpannableString.cb_removeSpan_Ljava_lang_Object_ == null)
			{
				SpannableString.cb_removeSpan_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SpannableString.n_RemoveSpan_Ljava_lang_Object_));
			}
			return SpannableString.cb_removeSpan_Ljava_lang_Object_;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00028054 File Offset: 0x00026254
		private static void n_RemoveSpan_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableString @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.RemoveSpan(object2);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00028078 File Offset: 0x00026278
		public unsafe virtual void RemoveSpan(Java.Lang.Object what)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				SpannableString._members.InstanceMethods.InvokeVirtualVoidMethod("removeSpan.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000280DC File Offset: 0x000262DC
		private static Delegate GetSetSpan_Ljava_lang_Object_IIIHandler()
		{
			if (SpannableString.cb_setSpan_Ljava_lang_Object_III == null)
			{
				SpannableString.cb_setSpan_Ljava_lang_Object_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(SpannableString.n_SetSpan_Ljava_lang_Object_III));
			}
			return SpannableString.cb_setSpan_Ljava_lang_Object_III;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00028100 File Offset: 0x00026300
		private static void n_SetSpan_Ljava_lang_Object_III(IntPtr jnienv, IntPtr native__this, IntPtr native_what, int start, int end, int native_flags)
		{
			SpannableString @object = Java.Lang.Object.GetObject<SpannableString>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.SetSpan(object2, start, end, (SpanTypes)native_flags);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0002812C File Offset: 0x0002632C
		public unsafe virtual void SetSpan(Java.Lang.Object what, int start, int end, [GeneratedEnum] SpanTypes flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(end);
				ptr[3] = new JniArgumentValue((int)flags);
				SpannableString._members.InstanceMethods.InvokeVirtualVoidMethod("setSpan.(Ljava/lang/Object;III)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000281D0 File Offset: 0x000263D0
		public unsafe ICharSequence SubSequenceFormatted(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			return Java.Lang.Object.GetObject<ICharSequence>(SpannableString._members.InstanceMethods.InvokeNonvirtualObjectMethod("subSequence.(II)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0002822C File Offset: 0x0002642C
		public sealed override string ToString()
		{
			return JNIEnv.GetString(SpannableString._members.InstanceMethods.InvokeNonvirtualObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0002825E File Offset: 0x0002645E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00028266 File Offset: 0x00026466
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

		// Token: 0x0400071D RID: 1821
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/SpannableString", typeof(SpannableString));

		// Token: 0x0400071E RID: 1822
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400071F RID: 1823
		private static Delegate cb_getSpanEnd_Ljava_lang_Object_;

		// Token: 0x04000720 RID: 1824
		private static Delegate cb_getSpanFlags_Ljava_lang_Object_;

		// Token: 0x04000721 RID: 1825
		private static Delegate cb_getSpans_IILjava_lang_Class_;

		// Token: 0x04000722 RID: 1826
		private static Delegate cb_getSpanStart_Ljava_lang_Object_;

		// Token: 0x04000723 RID: 1827
		private static Delegate cb_hashCode;

		// Token: 0x04000724 RID: 1828
		private static Delegate cb_nextSpanTransition_IILjava_lang_Class_;

		// Token: 0x04000725 RID: 1829
		private static Delegate cb_removeSpan_Ljava_lang_Object_;

		// Token: 0x04000726 RID: 1830
		private static Delegate cb_setSpan_Ljava_lang_Object_III;
	}
}
