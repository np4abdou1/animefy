using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001B4 RID: 436
	[Register("android/text/SpannableStringInternal", DoNotGenerateAcw = true)]
	public abstract class SpannableStringInternal : Java.Lang.Object
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0002954A File Offset: 0x0002774A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SpannableStringInternal._members;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00029554 File Offset: 0x00027754
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SpannableStringInternal._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00029578 File Offset: 0x00027778
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SpannableStringInternal._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SpannableStringInternal(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00029584 File Offset: 0x00027784
		private static Delegate GetGetSpanEnd_Ljava_lang_Object_Handler()
		{
			if (SpannableStringInternal.cb_getSpanEnd_Ljava_lang_Object_ == null)
			{
				SpannableStringInternal.cb_getSpanEnd_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableStringInternal.n_GetSpanEnd_Ljava_lang_Object_));
			}
			return SpannableStringInternal.cb_getSpanEnd_Ljava_lang_Object_;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000295A8 File Offset: 0x000277A8
		private static int n_GetSpanEnd_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanEnd(object2);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x000295CC File Offset: 0x000277CC
		public unsafe virtual int GetSpanEnd(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannableStringInternal._members.InstanceMethods.InvokeVirtualInt32Method("getSpanEnd.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00029634 File Offset: 0x00027834
		private static Delegate GetGetSpanFlags_Ljava_lang_Object_Handler()
		{
			if (SpannableStringInternal.cb_getSpanFlags_Ljava_lang_Object_ == null)
			{
				SpannableStringInternal.cb_getSpanFlags_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableStringInternal.n_GetSpanFlags_Ljava_lang_Object_));
			}
			return SpannableStringInternal.cb_getSpanFlags_Ljava_lang_Object_;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00029658 File Offset: 0x00027858
		private static int n_GetSpanFlags_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return (int)@object.GetSpanFlags(object2);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0002967C File Offset: 0x0002787C
		[return: GeneratedEnum]
		public unsafe virtual SpanTypes GetSpanFlags(Java.Lang.Object what)
		{
			SpanTypes result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = (SpanTypes)SpannableStringInternal._members.InstanceMethods.InvokeVirtualInt32Method("getSpanFlags.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000296E4 File Offset: 0x000278E4
		private static Delegate GetGetSpans_IILjava_lang_Class_Handler()
		{
			if (SpannableStringInternal.cb_getSpans_IILjava_lang_Class_ == null)
			{
				SpannableStringInternal.cb_getSpans_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(SpannableStringInternal.n_GetSpans_IILjava_lang_Class_));
			}
			return SpannableStringInternal.cb_getSpans_IILjava_lang_Class_;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00029708 File Offset: 0x00027908
		private static IntPtr n_GetSpans_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int queryStart, int queryEnd, IntPtr native_kind)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_kind, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Java.Lang.Object>(@object.GetSpans(queryStart, queryEnd, object2));
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00029734 File Offset: 0x00027934
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
				result = (Java.Lang.Object[])JNIEnv.GetArray(SpannableStringInternal._members.InstanceMethods.InvokeVirtualObjectMethod("getSpans.(IILjava/lang/Class;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000297E0 File Offset: 0x000279E0
		private static Delegate GetGetSpanStart_Ljava_lang_Object_Handler()
		{
			if (SpannableStringInternal.cb_getSpanStart_Ljava_lang_Object_ == null)
			{
				SpannableStringInternal.cb_getSpanStart_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SpannableStringInternal.n_GetSpanStart_Ljava_lang_Object_));
			}
			return SpannableStringInternal.cb_getSpanStart_Ljava_lang_Object_;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00029804 File Offset: 0x00027A04
		private static int n_GetSpanStart_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_what, JniHandleOwnership.DoNotTransfer);
			return @object.GetSpanStart(object2);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00029828 File Offset: 0x00027A28
		public unsafe virtual int GetSpanStart(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannableStringInternal._members.InstanceMethods.InvokeVirtualInt32Method("getSpanStart.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00029890 File Offset: 0x00027A90
		private static Delegate GetNextSpanTransition_IILjava_lang_Class_Handler()
		{
			if (SpannableStringInternal.cb_nextSpanTransition_IILjava_lang_Class_ == null)
			{
				SpannableStringInternal.cb_nextSpanTransition_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_I(SpannableStringInternal.n_NextSpanTransition_IILjava_lang_Class_));
			}
			return SpannableStringInternal.cb_nextSpanTransition_IILjava_lang_Class_;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000298B4 File Offset: 0x00027AB4
		private static int n_NextSpanTransition_IILjava_lang_Class_(IntPtr jnienv, IntPtr native__this, int start, int limit, IntPtr native_kind)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_kind, JniHandleOwnership.DoNotTransfer);
			return @object.NextSpanTransition(start, limit, object2);
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000298DC File Offset: 0x00027ADC
		public unsafe virtual int NextSpanTransition(int start, int limit, Class kind)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(limit);
				ptr[2] = new JniArgumentValue((kind == null) ? IntPtr.Zero : kind.Handle);
				result = SpannableStringInternal._members.InstanceMethods.InvokeVirtualInt32Method("nextSpanTransition.(IILjava/lang/Class;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0002996C File Offset: 0x00027B6C
		private static Delegate GetCharAt_IHandler()
		{
			if (SpannableStringInternal.cb_charAt_I == null)
			{
				SpannableStringInternal.cb_charAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_C(SpannableStringInternal.n_CharAt_I));
			}
			return SpannableStringInternal.cb_charAt_I;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00029990 File Offset: 0x00027B90
		private static char n_CharAt_I(IntPtr jnienv, IntPtr native__this, int i)
		{
			return Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CharAt(i);
		}

		// Token: 0x06000FE0 RID: 4064
		public abstract char CharAt(int i);

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000299A0 File Offset: 0x00027BA0
		private static Delegate GetGetChars_IIarrayCIHandler()
		{
			if (SpannableStringInternal.cb_getChars_IIarrayCI == null)
			{
				SpannableStringInternal.cb_getChars_IIarrayCI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILI_V(SpannableStringInternal.n_GetChars_IIarrayCI));
			}
			return SpannableStringInternal.cb_getChars_IIarrayCI;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000299C4 File Offset: 0x00027BC4
		private static void n_GetChars_IIarrayCI(IntPtr jnienv, IntPtr native__this, int start, int end, IntPtr native_dest, int off)
		{
			SpannableStringInternal @object = Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			char[] array = (char[])JNIEnv.GetArray(native_dest, JniHandleOwnership.DoNotTransfer, typeof(char));
			@object.GetChars(start, end, array, off);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_dest);
			}
		}

		// Token: 0x06000FE3 RID: 4067
		public abstract void GetChars(int start, int end, char[] dest, int off);

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00029A06 File Offset: 0x00027C06
		private static Delegate GetLengthHandler()
		{
			if (SpannableStringInternal.cb_length == null)
			{
				SpannableStringInternal.cb_length = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SpannableStringInternal.n_Length));
			}
			return SpannableStringInternal.cb_length;
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00029A2A File Offset: 0x00027C2A
		private static int n_Length(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Length();
		}

		// Token: 0x06000FE6 RID: 4070
		public abstract int Length();

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00029A39 File Offset: 0x00027C39
		private static Delegate GetToStringHandler()
		{
			if (SpannableStringInternal.cb_toString == null)
			{
				SpannableStringInternal.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SpannableStringInternal.n_ToString));
			}
			return SpannableStringInternal.cb_toString;
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00029A5D File Offset: 0x00027C5D
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<SpannableStringInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000FE9 RID: 4073
		public new abstract string ToString();

		// Token: 0x04000747 RID: 1863
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/SpannableStringInternal", typeof(SpannableStringInternal));

		// Token: 0x04000748 RID: 1864
		private static Delegate cb_getSpanEnd_Ljava_lang_Object_;

		// Token: 0x04000749 RID: 1865
		private static Delegate cb_getSpanFlags_Ljava_lang_Object_;

		// Token: 0x0400074A RID: 1866
		private static Delegate cb_getSpans_IILjava_lang_Class_;

		// Token: 0x0400074B RID: 1867
		private static Delegate cb_getSpanStart_Ljava_lang_Object_;

		// Token: 0x0400074C RID: 1868
		private static Delegate cb_nextSpanTransition_IILjava_lang_Class_;

		// Token: 0x0400074D RID: 1869
		private static Delegate cb_charAt_I;

		// Token: 0x0400074E RID: 1870
		private static Delegate cb_getChars_IIarrayCI;

		// Token: 0x0400074F RID: 1871
		private static Delegate cb_length;

		// Token: 0x04000750 RID: 1872
		private static Delegate cb_toString;
	}
}
