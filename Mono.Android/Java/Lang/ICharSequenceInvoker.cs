using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003D1 RID: 977
	[Register("java/lang/CharSequence", DoNotGenerateAcw = true)]
	internal class ICharSequenceInvoker : Object, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x00077F94 File Offset: 0x00076194
		private static IntPtr java_class_ref
		{
			get
			{
				return ICharSequenceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00077FB8 File Offset: 0x000761B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICharSequenceInvoker._members;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x00077FBF File Offset: 0x000761BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x00077FC7 File Offset: 0x000761C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICharSequenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x00077FD3 File Offset: 0x000761D3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICharSequenceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.CharSequence'.");
			}
			return handle;
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00077FFE File Offset: 0x000761FE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00078030 File Offset: 0x00076230
		public ICharSequenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICharSequenceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00078068 File Offset: 0x00076268
		private static Delegate GetCharAt_IHandler()
		{
			if (ICharSequenceInvoker.cb_charAt_I == null)
			{
				ICharSequenceInvoker.cb_charAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_C(ICharSequenceInvoker.n_CharAt_I));
			}
			return ICharSequenceInvoker.cb_charAt_I;
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0007808C File Offset: 0x0007628C
		private static char n_CharAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return Object.GetObject<ICharSequence>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CharAt(index);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0007809C File Offset: 0x0007629C
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

		// Token: 0x06002B1E RID: 11038 RVA: 0x00078100 File Offset: 0x00076300
		private static Delegate GetLengthHandler()
		{
			if (ICharSequenceInvoker.cb_length == null)
			{
				ICharSequenceInvoker.cb_length = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ICharSequenceInvoker.n_Length));
			}
			return ICharSequenceInvoker.cb_length;
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00078124 File Offset: 0x00076324
		private static int n_Length(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<ICharSequence>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Length();
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00078133 File Offset: 0x00076333
		public int Length()
		{
			if (this.id_length == IntPtr.Zero)
			{
				this.id_length = JNIEnv.GetMethodID(this.class_ref, "length", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_length);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00078173 File Offset: 0x00076373
		private static Delegate GetSubSequence_IIHandler()
		{
			if (ICharSequenceInvoker.cb_subSequence_II == null)
			{
				ICharSequenceInvoker.cb_subSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(ICharSequenceInvoker.n_SubSequence_II));
			}
			return ICharSequenceInvoker.cb_subSequence_II;
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00078197 File Offset: 0x00076397
		private static IntPtr n_SubSequence_II(IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			return CharSequence.ToLocalJniHandle(Object.GetObject<ICharSequence>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubSequenceFormatted(start, end));
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000781B0 File Offset: 0x000763B0
		public unsafe ICharSequence SubSequenceFormatted(int start, int end)
		{
			if (this.id_subSequence_II == IntPtr.Zero)
			{
				this.id_subSequence_II = JNIEnv.GetMethodID(this.class_ref, "subSequence", "(II)Ljava/lang/CharSequence;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(start);
			ptr[1] = new JValue(end);
			return Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_subSequence_II, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x0007822D File Offset: 0x0007642D
		private static Delegate GetToStringHandler()
		{
			if (ICharSequenceInvoker.cb_toString == null)
			{
				ICharSequenceInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICharSequenceInvoker.n_ToString));
			}
			return ICharSequenceInvoker.cb_toString;
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00078251 File Offset: 0x00076451
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<ICharSequence>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00078268 File Offset: 0x00076468
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000782B9 File Offset: 0x000764B9
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000782C1 File Offset: 0x000764C1
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

		// Token: 0x0400114A RID: 4426
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/CharSequence", typeof(ICharSequenceInvoker));

		// Token: 0x0400114B RID: 4427
		private IntPtr class_ref;

		// Token: 0x0400114C RID: 4428
		private static Delegate cb_charAt_I;

		// Token: 0x0400114D RID: 4429
		private IntPtr id_charAt_I;

		// Token: 0x0400114E RID: 4430
		private static Delegate cb_length;

		// Token: 0x0400114F RID: 4431
		private IntPtr id_length;

		// Token: 0x04001150 RID: 4432
		private static Delegate cb_subSequence_II;

		// Token: 0x04001151 RID: 4433
		private IntPtr id_subSequence_II;

		// Token: 0x04001152 RID: 4434
		private static Delegate cb_toString;

		// Token: 0x04001153 RID: 4435
		private IntPtr id_toString;
	}
}
