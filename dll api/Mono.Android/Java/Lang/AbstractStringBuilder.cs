using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003BB RID: 955
	[Register("java/lang/AbstractStringBuilder", DoNotGenerateAcw = true)]
	public abstract class AbstractStringBuilder : Object, IAppendable, IJavaObject, IDisposable, IJavaPeerable, ICharSequence, IEnumerable<char>, IEnumerable
	{
		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x00075FFB File Offset: 0x000741FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractStringBuilder._members;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x00076004 File Offset: 0x00074204
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractStringBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x00076028 File Offset: 0x00074228
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractStringBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AbstractStringBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00076034 File Offset: 0x00074234
		private static Delegate GetAppend_CHandler()
		{
			if (AbstractStringBuilder.cb_append_C == null)
			{
				AbstractStringBuilder.cb_append_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(AbstractStringBuilder.n_Append_C));
			}
			return AbstractStringBuilder.cb_append_C;
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x00076058 File Offset: 0x00074258
		private static IntPtr n_Append_C(IntPtr jnienv, IntPtr native__this, char c)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<AbstractStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Append(c));
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00076070 File Offset: 0x00074270
		public unsafe virtual IAppendable Append(char c)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(c);
			return Object.GetObject<IAppendable>(AbstractStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("append.(C)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000760B9 File Offset: 0x000742B9
		private static Delegate GetAppend_Ljava_lang_CharSequence_Handler()
		{
			if (AbstractStringBuilder.cb_append_Ljava_lang_CharSequence_ == null)
			{
				AbstractStringBuilder.cb_append_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractStringBuilder.n_Append_Ljava_lang_CharSequence_));
			}
			return AbstractStringBuilder.cb_append_Ljava_lang_CharSequence_;
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000760E0 File Offset: 0x000742E0
		private static IntPtr n_Append_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			AbstractStringBuilder @object = Object.GetObject<AbstractStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Object.GetObject<ICharSequence>(native_s, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2));
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00076108 File Offset: 0x00074308
		public unsafe virtual IAppendable Append(ICharSequence s)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Object.GetObject<IAppendable>(AbstractStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(s);
			}
			return @object;
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0007617C File Offset: 0x0007437C
		private static Delegate GetAppend_Ljava_lang_CharSequence_IIHandler()
		{
			if (AbstractStringBuilder.cb_append_Ljava_lang_CharSequence_II == null)
			{
				AbstractStringBuilder.cb_append_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(AbstractStringBuilder.n_Append_Ljava_lang_CharSequence_II));
			}
			return AbstractStringBuilder.cb_append_Ljava_lang_CharSequence_II;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x000761A0 File Offset: 0x000743A0
		private static IntPtr n_Append_Ljava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int end)
		{
			AbstractStringBuilder @object = Object.GetObject<AbstractStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Object.GetObject<ICharSequence>(native_s, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, start, end));
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000761CC File Offset: 0x000743CC
		public unsafe virtual IAppendable Append(ICharSequence s, int start, int end)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(end);
				@object = Object.GetObject<IAppendable>(AbstractStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;II)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(s);
			}
			return @object;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00076268 File Offset: 0x00074468
		private static Delegate GetCharAt_IHandler()
		{
			if (AbstractStringBuilder.cb_charAt_I == null)
			{
				AbstractStringBuilder.cb_charAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_C(AbstractStringBuilder.n_CharAt_I));
			}
			return AbstractStringBuilder.cb_charAt_I;
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x0007628C File Offset: 0x0007448C
		private static char n_CharAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return Object.GetObject<AbstractStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CharAt(index);
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x0007629C File Offset: 0x0007449C
		public unsafe virtual char CharAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return AbstractStringBuilder._members.InstanceMethods.InvokeVirtualCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000762D7 File Offset: 0x000744D7
		private static Delegate GetLengthHandler()
		{
			if (AbstractStringBuilder.cb_length == null)
			{
				AbstractStringBuilder.cb_length = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractStringBuilder.n_Length));
			}
			return AbstractStringBuilder.cb_length;
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000762FB File Offset: 0x000744FB
		private static int n_Length(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<AbstractStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Length();
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0007630A File Offset: 0x0007450A
		public virtual int Length()
		{
			return AbstractStringBuilder._members.InstanceMethods.InvokeVirtualInt32Method("length.()I", this, null);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00076323 File Offset: 0x00074523
		private static Delegate GetSubSequence_IIHandler()
		{
			if (AbstractStringBuilder.cb_subSequence_II == null)
			{
				AbstractStringBuilder.cb_subSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(AbstractStringBuilder.n_SubSequence_II));
			}
			return AbstractStringBuilder.cb_subSequence_II;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00076347 File Offset: 0x00074547
		private static IntPtr n_SubSequence_II(IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			return CharSequence.ToLocalJniHandle(Object.GetObject<AbstractStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubSequenceFormatted(start, end));
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00076360 File Offset: 0x00074560
		public unsafe virtual ICharSequence SubSequenceFormatted(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			return Object.GetObject<ICharSequence>(AbstractStringBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("subSequence.(II)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000763BC File Offset: 0x000745BC
		private static Delegate GetToStringHandler()
		{
			if (AbstractStringBuilder.cb_toString == null)
			{
				AbstractStringBuilder.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractStringBuilder.n_ToString));
			}
			return AbstractStringBuilder.cb_toString;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000763E0 File Offset: 0x000745E0
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<AbstractStringBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06002A1A RID: 10778
		public new abstract string ToString();

		// Token: 0x06002A1B RID: 10779 RVA: 0x000763F4 File Offset: 0x000745F4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000763FC File Offset: 0x000745FC
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

		// Token: 0x0400111F RID: 4383
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/AbstractStringBuilder", typeof(AbstractStringBuilder));

		// Token: 0x04001120 RID: 4384
		private static Delegate cb_append_C;

		// Token: 0x04001121 RID: 4385
		private static Delegate cb_append_Ljava_lang_CharSequence_;

		// Token: 0x04001122 RID: 4386
		private static Delegate cb_append_Ljava_lang_CharSequence_II;

		// Token: 0x04001123 RID: 4387
		private static Delegate cb_charAt_I;

		// Token: 0x04001124 RID: 4388
		private static Delegate cb_length;

		// Token: 0x04001125 RID: 4389
		private static Delegate cb_subSequence_II;

		// Token: 0x04001126 RID: 4390
		private static Delegate cb_toString;
	}
}
