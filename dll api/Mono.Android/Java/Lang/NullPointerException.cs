using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E7 RID: 999
	[Register("java/lang/NullPointerException", DoNotGenerateAcw = true)]
	public class NullPointerException : RuntimeException
	{
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x0007970F File Offset: 0x0007790F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NullPointerException._members;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x00079718 File Offset: 0x00077918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NullPointerException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x0007973C File Offset: 0x0007793C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NullPointerException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00060884 File Offset: 0x0005EA84
		protected NullPointerException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00079748 File Offset: 0x00077948
		public unsafe NullPointerException(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(s);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(NullPointerException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NullPointerException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001177 RID: 4471
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/NullPointerException", typeof(NullPointerException));
	}
}
