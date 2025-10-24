using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E3 RID: 995
	[Register("java/lang/LinkageError", DoNotGenerateAcw = true)]
	public class LinkageError : Error
	{
		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000791FB File Offset: 0x000773FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinkageError._members;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x00079204 File Offset: 0x00077404
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinkageError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00079228 File Offset: 0x00077428
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinkageError._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00079234 File Offset: 0x00077434
		protected LinkageError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00079240 File Offset: 0x00077440
		public unsafe LinkageError(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(LinkageError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinkageError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001173 RID: 4467
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/LinkageError", typeof(LinkageError));
	}
}
