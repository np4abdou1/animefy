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
	// Token: 0x020003F1 RID: 1009
	[Register("java/lang/StringBuilder", DoNotGenerateAcw = true)]
	public sealed class StringBuilder : AbstractStringBuilder, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IAppendable, ICharSequence, IEnumerable<char>, IEnumerable
	{
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x0007A756 File Offset: 0x00078956
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StringBuilder._members;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x0007A760 File Offset: 0x00078960
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StringBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x0007A784 File Offset: 0x00078984
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StringBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000764C2 File Offset: 0x000746C2
		internal StringBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x0007A790 File Offset: 0x00078990
		public unsafe override IAppendable Append(char c)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(c);
			return Object.GetObject<IAppendable>(StringBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("append.(C)Ljava/lang/StringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x0007A7DC File Offset: 0x000789DC
		public unsafe override IAppendable Append(ICharSequence s)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Object.GetObject<IAppendable>(StringBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("append.(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(s);
			}
			return @object;
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x0007A850 File Offset: 0x00078A50
		public unsafe override IAppendable Append(ICharSequence s, int start, int end)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(end);
				@object = Object.GetObject<IAppendable>(StringBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("append.(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(s);
			}
			return @object;
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x0007A8EC File Offset: 0x00078AEC
		public unsafe override char CharAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return StringBuilder._members.InstanceMethods.InvokeAbstractCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x0007A927 File Offset: 0x00078B27
		public override int Length()
		{
			return StringBuilder._members.InstanceMethods.InvokeAbstractInt32Method("length.()I", this, null);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0007A940 File Offset: 0x00078B40
		public unsafe override ICharSequence SubSequenceFormatted(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			return Object.GetObject<ICharSequence>(StringBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("subSequence.(II)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0007A99C File Offset: 0x00078B9C
		public override string ToString()
		{
			return JNIEnv.GetString(StringBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x0007A9CE File Offset: 0x00078BCE
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x0007A9D6 File Offset: 0x00078BD6
		public new IEnumerator<char> GetEnumerator()
		{
			int num;
			for (int i = 0; i < this.Length(); i = num + 1)
			{
				yield return this.CharAt(i);
				num = i;
			}
			yield break;
		}

		// Token: 0x04001194 RID: 4500
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/StringBuilder", typeof(StringBuilder));
	}
}
