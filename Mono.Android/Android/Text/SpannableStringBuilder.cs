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
	// Token: 0x020001B2 RID: 434
	[Register("android/text/SpannableStringBuilder", DoNotGenerateAcw = true)]
	public class SpannableStringBuilder : Java.Lang.Object, IEditable, IGetChars, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable, ISpannable, ISpanned, IAppendable
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x0002832A File Offset: 0x0002652A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SpannableStringBuilder._members;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00028334 File Offset: 0x00026534
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SpannableStringBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00028358 File Offset: 0x00026558
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SpannableStringBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SpannableStringBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00028364 File Offset: 0x00026564
		public SpannableStringBuilder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SpannableStringBuilder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SpannableStringBuilder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000283D2 File Offset: 0x000265D2
		private static Delegate GetAppend_CHandler()
		{
			if (SpannableStringBuilder.cb_append_C == null)
			{
				SpannableStringBuilder.cb_append_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(SpannableStringBuilder.n_Append_C));
			}
			return SpannableStringBuilder.cb_append_C;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000283F6 File Offset: 0x000265F6
		private static IntPtr n_Append_C(IntPtr jnienv, IntPtr native__this, char text)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Append(text));
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0002840C File Offset: 0x0002660C
		public unsafe virtual IAppendable Append(char text)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(text);
			return Java.Lang.Object.GetObject<IAppendable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("append.(C)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00028455 File Offset: 0x00026655
		private static Delegate GetAppend_Ljava_lang_CharSequence_Handler()
		{
			if (SpannableStringBuilder.cb_append_Ljava_lang_CharSequence_ == null)
			{
				SpannableStringBuilder.cb_append_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SpannableStringBuilder.n_Append_Ljava_lang_CharSequence_));
			}
			return SpannableStringBuilder.cb_append_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0002847C File Offset: 0x0002667C
		private static IntPtr n_Append_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2));
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000284A4 File Offset: 0x000266A4
		public unsafe virtual IAppendable Append(ICharSequence text)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IAppendable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
			}
			return @object;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00028518 File Offset: 0x00026718
		public IAppendable Append(string text)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			IAppendable result = this.Append(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00028542 File Offset: 0x00026742
		private static Delegate GetAppend_Ljava_lang_CharSequence_IIHandler()
		{
			if (SpannableStringBuilder.cb_append_Ljava_lang_CharSequence_II == null)
			{
				SpannableStringBuilder.cb_append_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(SpannableStringBuilder.n_Append_Ljava_lang_CharSequence_II));
			}
			return SpannableStringBuilder.cb_append_Ljava_lang_CharSequence_II;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00028568 File Offset: 0x00026768
		private static IntPtr n_Append_Ljava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, IntPtr native_text, int start, int end)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, start, end));
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00028594 File Offset: 0x00026794
		public unsafe virtual IAppendable Append(ICharSequence text, int start, int end)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(end);
				@object = Java.Lang.Object.GetObject<IAppendable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
			}
			return @object;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00028630 File Offset: 0x00026830
		private static Delegate GetCharAt_IHandler()
		{
			if (SpannableStringBuilder.cb_charAt_I == null)
			{
				SpannableStringBuilder.cb_charAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_C(SpannableStringBuilder.n_CharAt_I));
			}
			return SpannableStringBuilder.cb_charAt_I;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00028654 File Offset: 0x00026854
		private static char n_CharAt_I(IntPtr jnienv, IntPtr native__this, int where)
		{
			return Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CharAt(where);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00028664 File Offset: 0x00026864
		public unsafe virtual char CharAt(int where)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(where);
			return SpannableStringBuilder._members.InstanceMethods.InvokeVirtualCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0002869F File Offset: 0x0002689F
		private static Delegate GetClearHandler()
		{
			if (SpannableStringBuilder.cb_clear == null)
			{
				SpannableStringBuilder.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SpannableStringBuilder.n_Clear));
			}
			return SpannableStringBuilder.cb_clear;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000286C3 File Offset: 0x000268C3
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000286D2 File Offset: 0x000268D2
		public virtual void Clear()
		{
			SpannableStringBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000286EB File Offset: 0x000268EB
		private static Delegate GetClearSpansHandler()
		{
			if (SpannableStringBuilder.cb_clearSpans == null)
			{
				SpannableStringBuilder.cb_clearSpans = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SpannableStringBuilder.n_ClearSpans));
			}
			return SpannableStringBuilder.cb_clearSpans;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0002870F File Offset: 0x0002690F
		private static void n_ClearSpans(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearSpans();
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0002871E File Offset: 0x0002691E
		public virtual void ClearSpans()
		{
			SpannableStringBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("clearSpans.()V", this, null);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00028737 File Offset: 0x00026937
		private static Delegate GetDelete_IIHandler()
		{
			if (SpannableStringBuilder.cb_delete_II == null)
			{
				SpannableStringBuilder.cb_delete_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(SpannableStringBuilder.n_Delete_II));
			}
			return SpannableStringBuilder.cb_delete_II;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0002875B File Offset: 0x0002695B
		private static IntPtr n_Delete_II(IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delete(start, end));
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00028774 File Offset: 0x00026974
		public unsafe virtual IEditable Delete(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			return Java.Lang.Object.GetObject<IEditable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("delete.(II)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000287D0 File Offset: 0x000269D0
		private static Delegate GetGetChars_IIarrayCIHandler()
		{
			if (SpannableStringBuilder.cb_getChars_IIarrayCI == null)
			{
				SpannableStringBuilder.cb_getChars_IIarrayCI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILI_V(SpannableStringBuilder.n_GetChars_IIarrayCI));
			}
			return SpannableStringBuilder.cb_getChars_IIarrayCI;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000287F4 File Offset: 0x000269F4
		private static void n_GetChars_IIarrayCI(IntPtr jnienv, IntPtr native__this, int start, int end, IntPtr native_dest, int destoff)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			char[] array = (char[])JNIEnv.GetArray(native_dest, JniHandleOwnership.DoNotTransfer, typeof(char));
			@object.GetChars(start, end, array, destoff);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_dest);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00028838 File Offset: 0x00026A38
		public unsafe virtual void GetChars(int start, int end, char[] dest, int destoff)
		{
			IntPtr intPtr = JNIEnv.NewArray(dest);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(end);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(destoff);
				SpannableStringBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("getChars.(II[CI)V", this, ptr);
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

		// Token: 0x06000F95 RID: 3989 RVA: 0x000288E4 File Offset: 0x00026AE4
		private static Delegate GetGetFiltersHandler()
		{
			if (SpannableStringBuilder.cb_getFilters == null)
			{
				SpannableStringBuilder.cb_getFilters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SpannableStringBuilder.n_GetFilters));
			}
			return SpannableStringBuilder.cb_getFilters;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00028908 File Offset: 0x00026B08
		private static IntPtr n_GetFilters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<IInputFilter>(Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetFilters());
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0002891C File Offset: 0x00026B1C
		public virtual IInputFilter[] GetFilters()
		{
			return (IInputFilter[])JNIEnv.GetArray(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getFilters.()[Landroid/text/InputFilter;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(IInputFilter));
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0002895D File Offset: 0x00026B5D
		private static Delegate GetGetSpanEnd_Ljava_lang_Object_Handler()
		{
			if (SpannableStringBuilder.cb_getSpanEnd_Ljava_lang_Object_ == null)
			{
				SpannableStringBuilder.cb_getSpanEnd_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableStringBuilder.n_GetSpanEnd_Ljava_lang_Object_));
			}
			return SpannableStringBuilder.cb_getSpanEnd_Ljava_lang_Object_;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00028984 File Offset: 0x00026B84
		private static int n_GetSpanEnd_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanEnd(object2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000289A8 File Offset: 0x00026BA8
		public unsafe virtual int GetSpanEnd(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannableStringBuilder._members.InstanceMethods.InvokeVirtualInt32Method("getSpanEnd.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00028A10 File Offset: 0x00026C10
		private static Delegate GetGetSpanFlags_Ljava_lang_Object_Handler()
		{
			if (SpannableStringBuilder.cb_getSpanFlags_Ljava_lang_Object_ == null)
			{
				SpannableStringBuilder.cb_getSpanFlags_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableStringBuilder.n_GetSpanFlags_Ljava_lang_Object_));
			}
			return SpannableStringBuilder.cb_getSpanFlags_Ljava_lang_Object_;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00028A34 File Offset: 0x00026C34
		private static int n_GetSpanFlags_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return (int)@object.GetSpanFlags(object2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00028A58 File Offset: 0x00026C58
		public unsafe virtual SpanTypes GetSpanFlags(Java.Lang.Object what)
		{
			SpanTypes result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = (SpanTypes)SpannableStringBuilder._members.InstanceMethods.InvokeVirtualInt32Method("getSpanFlags.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00028AC0 File Offset: 0x00026CC0
		private static Delegate GetGetSpans_IILjava_lang_Class_Handler()
		{
			if (SpannableStringBuilder.cb_getSpans_IILjava_lang_Class_ == null)
			{
				SpannableStringBuilder.cb_getSpans_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(SpannableStringBuilder.n_GetSpans_IILjava_lang_Class_));
			}
			return SpannableStringBuilder.cb_getSpans_IILjava_lang_Class_;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00028AE4 File Offset: 0x00026CE4
		private static IntPtr n_GetSpans_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int queryStart, int queryEnd, IntPtr native_kind)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_kind, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Java.Lang.Object>(@object.GetSpans(queryStart, queryEnd, object2));
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00028B10 File Offset: 0x00026D10
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual Java.Lang.Object[] GetSpans(int queryStart, int queryEnd, Class kind)
		{
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(queryStart);
				ptr[1] = new JniArgumentValue(queryEnd);
				ptr[2] = new JniArgumentValue((kind == null) ? IntPtr.Zero : kind.Handle);
				result = (Java.Lang.Object[])JNIEnv.GetArray(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getSpans.(IILjava/lang/Class;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00028BBC File Offset: 0x00026DBC
		private static Delegate GetGetSpanStart_Ljava_lang_Object_Handler()
		{
			if (SpannableStringBuilder.cb_getSpanStart_Ljava_lang_Object_ == null)
			{
				SpannableStringBuilder.cb_getSpanStart_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableStringBuilder.n_GetSpanStart_Ljava_lang_Object_));
			}
			return SpannableStringBuilder.cb_getSpanStart_Ljava_lang_Object_;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00028BE0 File Offset: 0x00026DE0
		private static int n_GetSpanStart_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanStart(object2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00028C04 File Offset: 0x00026E04
		public unsafe virtual int GetSpanStart(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannableStringBuilder._members.InstanceMethods.InvokeVirtualInt32Method("getSpanStart.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00028C6C File Offset: 0x00026E6C
		private static Delegate GetInsert_ILjava_lang_CharSequence_Handler()
		{
			if (SpannableStringBuilder.cb_insert_ILjava_lang_CharSequence_ == null)
			{
				SpannableStringBuilder.cb_insert_ILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(SpannableStringBuilder.n_Insert_ILjava_lang_CharSequence_));
			}
			return SpannableStringBuilder.cb_insert_ILjava_lang_CharSequence_;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00028C90 File Offset: 0x00026E90
		private static IntPtr n_Insert_ILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int where, IntPtr native_tb)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tb, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Insert(where, object2));
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00028CBC File Offset: 0x00026EBC
		public unsafe virtual IEditable Insert(int where, ICharSequence tb)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(tb);
			IEditable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(where);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IEditable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("insert.(ILjava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tb);
			}
			return @object;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00028D40 File Offset: 0x00026F40
		private static Delegate GetInsert_ILjava_lang_CharSequence_IIHandler()
		{
			if (SpannableStringBuilder.cb_insert_ILjava_lang_CharSequence_II == null)
			{
				SpannableStringBuilder.cb_insert_ILjava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILII_L(SpannableStringBuilder.n_Insert_ILjava_lang_CharSequence_II));
			}
			return SpannableStringBuilder.cb_insert_ILjava_lang_CharSequence_II;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00028D64 File Offset: 0x00026F64
		private static IntPtr n_Insert_ILjava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, int where, IntPtr native_tb, int start, int end)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tb, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Insert(where, object2, start, end));
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00028D94 File Offset: 0x00026F94
		public unsafe virtual IEditable Insert(int where, ICharSequence tb, int start, int end)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(tb);
			IEditable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(where);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(start);
				ptr[3] = new JniArgumentValue(end);
				@object = Java.Lang.Object.GetObject<IEditable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("insert.(ILjava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tb);
			}
			return @object;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00028E48 File Offset: 0x00027048
		private static Delegate GetLengthHandler()
		{
			if (SpannableStringBuilder.cb_length == null)
			{
				SpannableStringBuilder.cb_length = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SpannableStringBuilder.n_Length));
			}
			return SpannableStringBuilder.cb_length;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00028E6C File Offset: 0x0002706C
		private static int n_Length(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Length();
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00028E7B File Offset: 0x0002707B
		public virtual int Length()
		{
			return SpannableStringBuilder._members.InstanceMethods.InvokeVirtualInt32Method("length.()I", this, null);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00028E94 File Offset: 0x00027094
		private static Delegate GetNextSpanTransition_IILjava_lang_Class_Handler()
		{
			if (SpannableStringBuilder.cb_nextSpanTransition_IILjava_lang_Class_ == null)
			{
				SpannableStringBuilder.cb_nextSpanTransition_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_I(SpannableStringBuilder.n_NextSpanTransition_IILjava_lang_Class_));
			}
			return SpannableStringBuilder.cb_nextSpanTransition_IILjava_lang_Class_;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00028EB8 File Offset: 0x000270B8
		private static int n_NextSpanTransition_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int start, int limit, IntPtr native_kind)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_kind, JniHandleOwnership.DoNotTransfer);
			return @object.NextSpanTransition(start, limit, object2);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00028EE0 File Offset: 0x000270E0
		public unsafe virtual int NextSpanTransition(int start, int limit, Class kind)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(limit);
				ptr[2] = new JniArgumentValue((kind == null) ? IntPtr.Zero : kind.Handle);
				result = SpannableStringBuilder._members.InstanceMethods.InvokeVirtualInt32Method("nextSpanTransition.(IILjava/lang/Class;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00028F70 File Offset: 0x00027170
		private static Delegate GetRemoveSpan_Ljava_lang_Object_Handler()
		{
			if (SpannableStringBuilder.cb_removeSpan_Ljava_lang_Object_ == null)
			{
				SpannableStringBuilder.cb_removeSpan_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SpannableStringBuilder.n_RemoveSpan_Ljava_lang_Object_));
			}
			return SpannableStringBuilder.cb_removeSpan_Ljava_lang_Object_;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00028F94 File Offset: 0x00027194
		private static void n_RemoveSpan_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.RemoveSpan(object2);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00028FB8 File Offset: 0x000271B8
		public unsafe virtual void RemoveSpan(Java.Lang.Object what)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				SpannableStringBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("removeSpan.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0002901C File Offset: 0x0002721C
		private static Delegate GetReplace_IILjava_lang_CharSequence_Handler()
		{
			if (SpannableStringBuilder.cb_replace_IILjava_lang_CharSequence_ == null)
			{
				SpannableStringBuilder.cb_replace_IILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(SpannableStringBuilder.n_Replace_IILjava_lang_CharSequence_));
			}
			return SpannableStringBuilder.cb_replace_IILjava_lang_CharSequence_;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00029040 File Offset: 0x00027240
		private static IntPtr n_Replace_IILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int start, int end, IntPtr native_tb)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tb, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(start, end, object2));
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0002906C File Offset: 0x0002726C
		public unsafe virtual IEditable Replace(int start, int end, ICharSequence tb)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(tb);
			IEditable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(end);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IEditable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(IILjava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tb);
			}
			return @object;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00029108 File Offset: 0x00027308
		private static Delegate GetReplace_IILjava_lang_CharSequence_IIHandler()
		{
			if (SpannableStringBuilder.cb_replace_IILjava_lang_CharSequence_II == null)
			{
				SpannableStringBuilder.cb_replace_IILjava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILII_L(SpannableStringBuilder.n_Replace_IILjava_lang_CharSequence_II));
			}
			return SpannableStringBuilder.cb_replace_IILjava_lang_CharSequence_II;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0002912C File Offset: 0x0002732C
		private static IntPtr n_Replace_IILjava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, int start, int end, IntPtr native_tb, int tbstart, int tbend)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tb, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(start, end, object2, tbstart, tbend));
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0002915C File Offset: 0x0002735C
		public unsafe virtual IEditable Replace(int start, int end, ICharSequence tb, int tbstart, int tbend)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(tb);
			IEditable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(end);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(tbstart);
				ptr[4] = new JniArgumentValue(tbend);
				@object = Java.Lang.Object.GetObject<IEditable>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(IILjava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tb);
			}
			return @object;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00029224 File Offset: 0x00027424
		private static Delegate GetSetFilters_arrayLandroid_text_InputFilter_Handler()
		{
			if (SpannableStringBuilder.cb_setFilters_arrayLandroid_text_InputFilter_ == null)
			{
				SpannableStringBuilder.cb_setFilters_arrayLandroid_text_InputFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SpannableStringBuilder.n_SetFilters_arrayLandroid_text_InputFilter_));
			}
			return SpannableStringBuilder.cb_setFilters_arrayLandroid_text_InputFilter_;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00029248 File Offset: 0x00027448
		private static void n_SetFilters_arrayLandroid_text_InputFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_filters)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInputFilter[] array = (IInputFilter[])JNIEnv.GetArray(native_filters, JniHandleOwnership.DoNotTransfer, typeof(IInputFilter));
			@object.SetFilters(array);
			if (array != null)
			{
				JNIEnv.CopyArray<IInputFilter>(array, native_filters);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00029284 File Offset: 0x00027484
		public unsafe virtual void SetFilters(IInputFilter[] filters)
		{
			IntPtr intPtr = JNIEnv.NewArray<IInputFilter>(filters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SpannableStringBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setFilters.([Landroid/text/InputFilter;)V", this, ptr);
			}
			finally
			{
				if (filters != null)
				{
					JNIEnv.CopyArray<IInputFilter>(intPtr, filters);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(filters);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000292F0 File Offset: 0x000274F0
		private static Delegate GetSetSpan_Ljava_lang_Object_IIIHandler()
		{
			if (SpannableStringBuilder.cb_setSpan_Ljava_lang_Object_III == null)
			{
				SpannableStringBuilder.cb_setSpan_Ljava_lang_Object_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(SpannableStringBuilder.n_SetSpan_Ljava_lang_Object_III));
			}
			return SpannableStringBuilder.cb_setSpan_Ljava_lang_Object_III;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00029314 File Offset: 0x00027514
		private static void n_SetSpan_Ljava_lang_Object_III(IntPtr jnienv, IntPtr native__this, IntPtr native_what, int start, int end, int native_flags)
		{
			SpannableStringBuilder @object = Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.SetSpan(object2, start, end, (SpanTypes)native_flags);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00029340 File Offset: 0x00027540
		public unsafe virtual void SetSpan(Java.Lang.Object what, int start, int end, [GeneratedEnum] SpanTypes flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(end);
				ptr[3] = new JniArgumentValue((int)flags);
				SpannableStringBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setSpan.(Ljava/lang/Object;III)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x000293E4 File Offset: 0x000275E4
		private static Delegate GetSubSequence_IIHandler()
		{
			if (SpannableStringBuilder.cb_subSequence_II == null)
			{
				SpannableStringBuilder.cb_subSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(SpannableStringBuilder.n_SubSequence_II));
			}
			return SpannableStringBuilder.cb_subSequence_II;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00029408 File Offset: 0x00027608
		private static IntPtr n_SubSequence_II(IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<SpannableStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubSequenceFormatted(start, end));
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00029420 File Offset: 0x00027620
		public unsafe virtual ICharSequence SubSequenceFormatted(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			return Java.Lang.Object.GetObject<ICharSequence>(SpannableStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("subSequence.(II)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0002947C File Offset: 0x0002767C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00029484 File Offset: 0x00027684
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

		// Token: 0x0400072B RID: 1835
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/SpannableStringBuilder", typeof(SpannableStringBuilder));

		// Token: 0x0400072C RID: 1836
		private static Delegate cb_append_C;

		// Token: 0x0400072D RID: 1837
		private static Delegate cb_append_Ljava_lang_CharSequence_;

		// Token: 0x0400072E RID: 1838
		private static Delegate cb_append_Ljava_lang_CharSequence_II;

		// Token: 0x0400072F RID: 1839
		private static Delegate cb_charAt_I;

		// Token: 0x04000730 RID: 1840
		private static Delegate cb_clear;

		// Token: 0x04000731 RID: 1841
		private static Delegate cb_clearSpans;

		// Token: 0x04000732 RID: 1842
		private static Delegate cb_delete_II;

		// Token: 0x04000733 RID: 1843
		private static Delegate cb_getChars_IIarrayCI;

		// Token: 0x04000734 RID: 1844
		private static Delegate cb_getFilters;

		// Token: 0x04000735 RID: 1845
		private static Delegate cb_getSpanEnd_Ljava_lang_Object_;

		// Token: 0x04000736 RID: 1846
		private static Delegate cb_getSpanFlags_Ljava_lang_Object_;

		// Token: 0x04000737 RID: 1847
		private static Delegate cb_getSpans_IILjava_lang_Class_;

		// Token: 0x04000738 RID: 1848
		private static Delegate cb_getSpanStart_Ljava_lang_Object_;

		// Token: 0x04000739 RID: 1849
		private static Delegate cb_insert_ILjava_lang_CharSequence_;

		// Token: 0x0400073A RID: 1850
		private static Delegate cb_insert_ILjava_lang_CharSequence_II;

		// Token: 0x0400073B RID: 1851
		private static Delegate cb_length;

		// Token: 0x0400073C RID: 1852
		private static Delegate cb_nextSpanTransition_IILjava_lang_Class_;

		// Token: 0x0400073D RID: 1853
		private static Delegate cb_removeSpan_Ljava_lang_Object_;

		// Token: 0x0400073E RID: 1854
		private static Delegate cb_replace_IILjava_lang_CharSequence_;

		// Token: 0x0400073F RID: 1855
		private static Delegate cb_replace_IILjava_lang_CharSequence_II;

		// Token: 0x04000740 RID: 1856
		private static Delegate cb_setFilters_arrayLandroid_text_InputFilter_;

		// Token: 0x04000741 RID: 1857
		private static Delegate cb_setSpan_Ljava_lang_Object_III;

		// Token: 0x04000742 RID: 1858
		private static Delegate cb_subSequence_II;
	}
}
