using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Lang
{
	// Token: 0x020003EF RID: 1007
	[Register("java/lang/String", DoNotGenerateAcw = true)]
	public sealed class String : Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, ICharSequence, IEnumerable<char>, IEnumerable, IComparable
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x0007A50B File Offset: 0x0007870B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return String._members;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x0007A514 File Offset: 0x00078714
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return String._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x0007A538 File Offset: 0x00078738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return String._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000021E0 File Offset: 0x000003E0
		internal String(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0007A544 File Offset: 0x00078744
		public unsafe char CharAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return String._members.InstanceMethods.InvokeAbstractCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x0007A580 File Offset: 0x00078780
		public unsafe int CompareTo(string anotherString)
		{
			IntPtr intPtr = JNIEnv.NewString(anotherString);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = String._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x0007A5E0 File Offset: 0x000787E0
		public int Length()
		{
			return String._members.InstanceMethods.InvokeAbstractInt32Method("length.()I", this, null);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x0007A5FC File Offset: 0x000787FC
		public unsafe ICharSequence SubSequenceFormatted(int beginIndex, int endIndex)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(beginIndex);
			ptr[1] = new JniArgumentValue(endIndex);
			return Object.GetObject<ICharSequence>(String._members.InstanceMethods.InvokeAbstractObjectMethod("subSequence.(II)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0007A658 File Offset: 0x00078858
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo((o != null) ? o.ToString() : null);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0007A66C File Offset: 0x0007886C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0007A674 File Offset: 0x00078874
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

		// Token: 0x06002C5A RID: 11354 RVA: 0x0007A683 File Offset: 0x00078883
		public String(string toCopy) : base(JNIEnv.NewString(toCopy), JniHandleOwnership.TransferLocalRef)
		{
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x0007A692 File Offset: 0x00078892
		public override string ToString()
		{
			return JNIEnv.GetCharSequence(base.Handle, JniHandleOwnership.DoNotTransfer);
		}

		// Token: 0x0400118F RID: 4495
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/String", typeof(String));
	}
}
