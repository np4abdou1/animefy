using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Text
{
	// Token: 0x020001B5 RID: 437
	[Register("android/text/SpannableStringInternal", DoNotGenerateAcw = true)]
	internal class SpannableStringInternalInvoker : SpannableStringInternal
	{
		// Token: 0x06000FEB RID: 4075 RVA: 0x00027990 File Offset: 0x00025B90
		public SpannableStringInternalInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00029A8C File Offset: 0x00027C8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SpannableStringInternalInvoker._members;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00029A93 File Offset: 0x00027C93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SpannableStringInternalInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00029AA0 File Offset: 0x00027CA0
		public unsafe override char CharAt(int i)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(i);
			return SpannableStringInternalInvoker._members.InstanceMethods.InvokeAbstractCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00029ADC File Offset: 0x00027CDC
		public unsafe override void GetChars(int start, int end, char[] dest, int off)
		{
			IntPtr intPtr = JNIEnv.NewArray(dest);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(end);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(off);
				SpannableStringInternalInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("getChars.(II[CI)V", this, ptr);
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

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00029B88 File Offset: 0x00027D88
		public override int Length()
		{
			return SpannableStringInternalInvoker._members.InstanceMethods.InvokeAbstractInt32Method("length.()I", this, null);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00029BA4 File Offset: 0x00027DA4
		public override string ToString()
		{
			return JNIEnv.GetString(SpannableStringInternalInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000751 RID: 1873
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/SpannableStringInternal", typeof(SpannableStringInternalInvoker));
	}
}
