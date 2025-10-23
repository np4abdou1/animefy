using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio
{
	// Token: 0x02000375 RID: 885
	[Register("java/nio/CharBuffer", DoNotGenerateAcw = true)]
	public abstract class CharBuffer : Buffer, IAppendable, IJavaObject, IDisposable, IJavaPeerable, ICharSequence, IEnumerable<char>, IEnumerable, Java.Lang.IComparable, IReadable
	{
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x0006F3D5 File Offset: 0x0006D5D5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharBuffer._members;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x0006F3DC File Offset: 0x0006D5DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharBuffer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x0006F400 File Offset: 0x0006D600
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharBuffer._members.ManagedPeerType;
			}
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x0006F253 File Offset: 0x0006D453
		protected CharBuffer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x0006F40C File Offset: 0x0006D60C
		private static Delegate GetAppend_CHandler()
		{
			if (CharBuffer.cb_append_C == null)
			{
				CharBuffer.cb_append_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(CharBuffer.n_Append_C));
			}
			return CharBuffer.cb_append_C;
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x0006F430 File Offset: 0x0006D630
		private static IntPtr n_Append_C(IntPtr jnienv, IntPtr native__this, char c)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CharBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Append(c));
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0006F448 File Offset: 0x0006D648
		public unsafe virtual CharBuffer Append(char c)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(c);
			return Java.Lang.Object.GetObject<CharBuffer>(CharBuffer._members.InstanceMethods.InvokeVirtualObjectMethod("append.(C)Ljava/nio/CharBuffer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x0006F491 File Offset: 0x0006D691
		private static Delegate GetAppend_Ljava_lang_CharSequence_Handler()
		{
			if (CharBuffer.cb_append_Ljava_lang_CharSequence_ == null)
			{
				CharBuffer.cb_append_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CharBuffer.n_Append_Ljava_lang_CharSequence_));
			}
			return CharBuffer.cb_append_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x0006F4B8 File Offset: 0x0006D6B8
		private static IntPtr n_Append_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_csq)
		{
			CharBuffer @object = Java.Lang.Object.GetObject<CharBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_csq, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2));
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x0006F4E0 File Offset: 0x0006D6E0
		public unsafe virtual CharBuffer Append(ICharSequence csq)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(csq);
			CharBuffer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CharBuffer>(CharBuffer._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(csq);
			}
			return @object;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x0006F554 File Offset: 0x0006D754
		private static Delegate GetAppend_Ljava_lang_CharSequence_IIHandler()
		{
			if (CharBuffer.cb_append_Ljava_lang_CharSequence_II == null)
			{
				CharBuffer.cb_append_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(CharBuffer.n_Append_Ljava_lang_CharSequence_II));
			}
			return CharBuffer.cb_append_Ljava_lang_CharSequence_II;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x0006F578 File Offset: 0x0006D778
		private static IntPtr n_Append_Ljava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, IntPtr native_csq, int start, int end)
		{
			CharBuffer @object = Java.Lang.Object.GetObject<CharBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_csq, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, start, end));
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x0006F5A4 File Offset: 0x0006D7A4
		public unsafe virtual CharBuffer Append(ICharSequence csq, int start, int end)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(csq);
			CharBuffer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(end);
				@object = Java.Lang.Object.GetObject<CharBuffer>(CharBuffer._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(csq);
			}
			return @object;
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x0006F640 File Offset: 0x0006D840
		public unsafe char CharAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return CharBuffer._members.InstanceMethods.InvokeNonvirtualCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x0006F67B File Offset: 0x0006D87B
		private static Delegate GetCompareTo_Ljava_nio_CharBuffer_Handler()
		{
			if (CharBuffer.cb_compareTo_Ljava_nio_CharBuffer_ == null)
			{
				CharBuffer.cb_compareTo_Ljava_nio_CharBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(CharBuffer.n_CompareTo_Ljava_nio_CharBuffer_));
			}
			return CharBuffer.cb_compareTo_Ljava_nio_CharBuffer_;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0006F6A0 File Offset: 0x0006D8A0
		private static int n_CompareTo_Ljava_nio_CharBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_that)
		{
			CharBuffer @object = Java.Lang.Object.GetObject<CharBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CharBuffer object2 = Java.Lang.Object.GetObject<CharBuffer>(native_that, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0006F6C4 File Offset: 0x0006D8C4
		public unsafe virtual int CompareTo(CharBuffer that)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((that == null) ? IntPtr.Zero : that.Handle);
				result = CharBuffer._members.InstanceMethods.InvokeVirtualInt32Method("compareTo.(Ljava/nio/CharBuffer;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(that);
			}
			return result;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0006F72C File Offset: 0x0006D92C
		public int Length()
		{
			return CharBuffer._members.InstanceMethods.InvokeNonvirtualInt32Method("length.()I", this, null);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0006F745 File Offset: 0x0006D945
		private static Delegate GetRead_Ljava_nio_CharBuffer_Handler()
		{
			if (CharBuffer.cb_read_Ljava_nio_CharBuffer_ == null)
			{
				CharBuffer.cb_read_Ljava_nio_CharBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(CharBuffer.n_Read_Ljava_nio_CharBuffer_));
			}
			return CharBuffer.cb_read_Ljava_nio_CharBuffer_;
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x0006F76C File Offset: 0x0006D96C
		private static int n_Read_Ljava_nio_CharBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			CharBuffer @object = Java.Lang.Object.GetObject<CharBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CharBuffer object2 = Java.Lang.Object.GetObject<CharBuffer>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.Read(object2);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x0006F790 File Offset: 0x0006D990
		public unsafe virtual int Read(CharBuffer target)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				result = CharBuffer._members.InstanceMethods.InvokeVirtualInt32Method("read.(Ljava/nio/CharBuffer;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0006F7F8 File Offset: 0x0006D9F8
		private static Delegate GetSubSequence_IIHandler()
		{
			if (CharBuffer.cb_subSequence_II == null)
			{
				CharBuffer.cb_subSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(CharBuffer.n_SubSequence_II));
			}
			return CharBuffer.cb_subSequence_II;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0006F81C File Offset: 0x0006DA1C
		private static IntPtr n_SubSequence_II(IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CharBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubSequenceFormatted(start, end));
		}

		// Token: 0x0600271C RID: 10012
		public abstract ICharSequence SubSequenceFormatted(int start, int end);

		// Token: 0x0600271D RID: 10013 RVA: 0x0006F832 File Offset: 0x0006DA32
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<CharBuffer>());
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0006F840 File Offset: 0x0006DA40
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0006F848 File Offset: 0x0006DA48
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

		// Token: 0x06002720 RID: 10016 RVA: 0x0006F857 File Offset: 0x0006DA57
		IAppendable IAppendable.Append(char ch)
		{
			return this.Append(ch);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0006F860 File Offset: 0x0006DA60
		IAppendable IAppendable.Append(ICharSequence csq)
		{
			return this.Append(csq);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x0006F869 File Offset: 0x0006DA69
		IAppendable IAppendable.Append(ICharSequence csq, int start, int end)
		{
			return this.Append(csq, start, end);
		}

		// Token: 0x0400100E RID: 4110
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/CharBuffer", typeof(CharBuffer));

		// Token: 0x0400100F RID: 4111
		private static Delegate cb_append_C;

		// Token: 0x04001010 RID: 4112
		private static Delegate cb_append_Ljava_lang_CharSequence_;

		// Token: 0x04001011 RID: 4113
		private static Delegate cb_append_Ljava_lang_CharSequence_II;

		// Token: 0x04001012 RID: 4114
		private static Delegate cb_compareTo_Ljava_nio_CharBuffer_;

		// Token: 0x04001013 RID: 4115
		private static Delegate cb_read_Ljava_nio_CharBuffer_;

		// Token: 0x04001014 RID: 4116
		private static Delegate cb_subSequence_II;
	}
}
